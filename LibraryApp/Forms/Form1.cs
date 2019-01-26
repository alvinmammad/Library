using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using LibraryApp.Model;

namespace LibraryApp
{
    public partial class Form1 : MetroForm
    {
        LibraryAppEntities db = new LibraryAppEntities();   
        public Form1()
        {
            InitializeComponent();
            txtUsername.Text = "yolchu";
            txtPassword.Text = "yolchu123";
        }

        
        //When login to Dashboard form Login form will close
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Login to Dashboard form
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text)||String.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "İstifadəçi adı və ya Şifrə boş ola bilməz","Səhv aşkarlandı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Worker worker = db.Workers.FirstOrDefault(w => w.Username == username || w.Password == password);

            if (worker==null)
            {
                MetroMessageBox.Show(this, "İstifadəçi adı və ya Şifrə səhvdir", "Səhv aşkarlandı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
