using LibraryApp.Model;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LibraryApp
{
    public partial class Dashboard : MetroForm
    {
        List<int> searchedBook = new List<int>();
        LibraryAppEntities db = new LibraryAppEntities();
        public DateTime StartDate = DateTime.Now;
        public Dashboard()
        {
            InitializeComponent();
            FillDgvStockedBooks();
            FillCmbUsers();
            FillCmbUserReturnSearch();
        }
        //When form closed , application will be exited
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #region Fill Comboboxes
        private void FillCmbUsers()
        {
            foreach (Worker worker in db.Workers.ToList())
            {
                cmbUsers.Items.Add(worker.Name + " " + worker.Surname + " " + worker.Phone);
            }
        }
        private void FillCmbUserReturnSearch()
        {
            foreach (Order order in db.Orders.ToList())
            {
                if (order.Returned == false)
                {
                    cmbWorkerforReturn.Items.Add(order.Worker.Name + " " + order.Worker.Surname + " " + order.Worker.Phone);
                }
            }

        }
        #endregion
        #region Fill Data Grid Views
        private void FillDgvStockedBooks()
        {
            dgvStockedBooks.Rows.Clear();
            List<Book> books = db.Books.OrderBy(b => b.Name).ToList();
            foreach (Book book in books)
            {
                dgvStockedBooks.Rows.Add(book.ID, book.Name, book.Category.Name, book.Author.Name, book.Available == false ? "Kitab artıq əldədir" : "Var");
            }
        }
        #endregion
        //When textbox text changed , data grid view will be fill
        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            dgvStockedBooks.Rows.Clear();
            string find = txtSearchBook.Text;
            foreach (Book item in db.Books.ToList())
            {
                if (item.Name.ToLower().Contains(find.ToLower()) && !searchedBook.Contains(item.ID))
                {

                    dgvStockedBooks.Rows.Add(item.ID,
                                       item.Name,
                                       item.Category.Name,
                                       item.Author.Name + " " + item.Author.Surname,
                                       item.Available == false ? "Kitab artıq əldədir" : "Var"
                                       );
                }
            }
        }
        //Add choosen book event
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int ID = dgvStockedBooks.CurrentCell.RowIndex;
            int BookID = Convert.ToInt32(dgvStockedBooks.Rows[ID].Cells[0].Value.ToString());

            searchedBook.Add(BookID);
            Book willAdd = new Book();
            willAdd = db.Books.FirstOrDefault(b => b.ID == BookID);
            if (willAdd.Available == false)
            {
                MetroMessageBox.Show(this, "Bu kitab artıq əldə olunub", "Səhv aşkarlandı !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                checkedLB.Items.Add(willAdd.ID + ".Kitabın adı:" + " " + willAdd.Name);
                dgvStockedBooks.Rows.RemoveAt(ID);
            }
        }
        //Confirm books
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (checkedLB.Items.Count > 0)
            {
                int checkedInteger = 0;
                if (cmbUsers.Text == "")
                {
                    MetroMessageBox.Show(this, "İstifadəçi seçin !", "Səhv aşkarlandı !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                Order order = new Order();
                string cmbUserString = cmbUsers.Text;
                string userPhone = cmbUserString.Split(' ')[2];
                int workerID = db.Workers.FirstOrDefault(w => w.Phone == userPhone).ID;
                
                for (int i = 0; i < checkedLB.Items.Count; i++)
                {
                    checkedInteger++;
                }
                if (checkedInteger > 0)
                {
                    order.UserID = workerID;
                    order.Date = StartDate;
                    order.Returned = false;
                    //db.Orders.Add(order);
                    //db.SaveChanges();
                    for (int j = 0; j < checkedLB.Items.Count; j++)
                    {
                        if (checkedLB.GetItemChecked(j))
                        {
                            //Order newOrder = new Order();
                           
                            int bookId = Convert.ToInt32(checkedLB.Items[j].ToString().Split('.')[0]);
                            order.BookID = bookId;
                            Book newBook = new Book();
                            newBook = db.Books.FirstOrDefault(b => b.ID == bookId);
                            newBook.Available = false;
                            db.Orders.Add(order);
                            db.SaveChanges();
                        }

                    }
                }
                MetroMessageBox.Show(this, "Uğurla təsdiq olundu", "Təsdiqetmə", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                dgvStockedBooks.Rows.Clear();
                FillDgvStockedBooks();
                checkedLB.Items.Clear();
                cmbUsers.Text = "";
                searchedBook.Clear();
                cmbWorkerforReturn.Text = "";
                cmbWorkerforReturn.Items.Clear();
                FillCmbUserReturnSearch();
            }
            else
            {
                MetroMessageBox.Show(this, "Kitab seçin", "Səhv aşkarlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Search for Remaining Date
        private void btnRemainingDate_Click(object sender, EventArgs e)
        {
            dgvReturned.Rows.Clear();
            DateTime timeforSearch = new DateTime();
            timeforSearch = dtpReturnBook.Value;
            double remainingDays = Convert.ToDouble(txtRemainingDays.Text);
            timeforSearch = timeforSearch.AddDays(remainingDays);
            foreach (Order order in db.Orders.ToList())
            {
                DateTime endDate = new DateTime();
                endDate = Convert.ToDateTime(order.Date);
                endDate = endDate.AddDays(30);
                if (endDate.Date == timeforSearch.Date && order.Returned == false)
                {
                    dgvReturned.Rows.Add(order.Worker.ID,
                                       order.Worker.Name,
                                       order.Worker.Surname,
                                       order.Worker.Phone,
                                       order.Book.Name,
                                       endDate.ToString("dd-MM-yyyy")
                                       );
                }
            }
            txtRemainingDays.Text = "0";
        }
        //Search for Worker
        private void btnSearchforWorker_Click(object sender, EventArgs e)
        {
            dgvReturned.Rows.Clear();
            if (cmbWorkerforReturn.Text == "")
            {
                MetroMessageBox.Show(this,"Zəhmət olmasa istifadəçini seçin", "Səhv aşkarlandı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string workerText = cmbWorkerforReturn.Text;
                string workerPhone = workerText.Split(' ')[2];
                int workerID = db.Workers.FirstOrDefault(x => x.Phone == workerPhone).ID;



                foreach (Order order in db.Orders.ToList())
                {
                    if (order.Worker.ID== workerID && order.Returned== false)
                    {
                        DateTime endDate = new DateTime();
                        endDate = Convert.ToDateTime(order.EndTime);
                        endDate = endDate.AddDays(30);
                        dgvReturned.Rows.Add(order.Worker.ID,
                                           order.Worker.Name,
                                           order.Worker.Surname,
                                           order.Worker.Phone,
                                           order.Book.Name,
                                           endDate.ToString("dd-MM-yyyy")
                                           );


                    }


                }


            }
        }
        //Finally , Return book event
        private void btnReturn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvReturned.SelectedRows.Count; i++)
            {
                int workerID = Convert.ToInt32(dgvReturned.SelectedRows[i].Cells[0].Value.ToString());
                var timeofOrder = dgvReturned.SelectedRows[i].Cells[5].Value.ToString();
                foreach (Order order in db.Orders.ToList())

                {
                   
                    if (workerID == order.Worker.ID&& timeofOrder == order.EndTime?.Date.AddDays(30).ToString("dd-MM-yyyy"))
                    {

                        foreach (Order newOrder in db.Orders.ToList())
                        {
                            if (newOrder.ID == order.ID)
                            {
                                newOrder.Book.Available = true;
                                db.SaveChanges();
                            }
                        }
                        order.Returned= true;
                        db.SaveChanges();

                    }

                }
            }
            MetroMessageBox.Show(this,"Seçilmiş kitablar qaytarıldı", "Əla!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvReturned.Rows.Clear();
            cmbWorkerforReturn.Text = "";
            cmbWorkerforReturn.Items.Clear();
            FillCmbUserReturnSearch();
        }
        //When is clicking Combobox of Workers , combobox text will be clear
        private void cmbUsers_Click(object sender, EventArgs e)
        {
            cmbUsers.Items.Clear();
            FillCmbUsers();
        }
    }
}
