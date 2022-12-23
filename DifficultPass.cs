using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1._0
{
    public partial class DifficultPass : Form
    {
        string login = "";
        string passR = "";
        string passU = "";
        int s1;
        int s2;
        int s3;

        public DifficultPass()
        {
            InitializeComponent();
            Random rnd = new Random();
            lb_pswEq.Text = "";
            s1 = rnd.Next(0, 6);
            s2 = rnd.Next(0, 6);
            s3 = rnd.Next(0, 6);
            label1.Text = "Enter your password's symbols number: " + (s1+1).ToString() + " " + (s2+1).ToString() + " " + (s3+1).ToString();
        }

        private void tb_login_TextChanged(object sender, EventArgs e)
        {
            login = tb_login.Text;
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            passU = tb_password.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            User_st db = new User_st(@"db_.txt");

            for (int i = 0; i < db.k; ++i)
            {
                if (db.st[i].login == login)
                {
                    string pass = db.st[i].password;
                    passR = pass[s1].ToString() + pass[s2].ToString() + pass[s3].ToString();
                    if(passU == passR)
                        flag = true;
                }
                else lb_pswEq.Text = "Invalid login";
            }
            if (flag == false && passU != "")
            {
                lb_pswEq.Text = "Invalid password";
                Random rnd = new Random();
                s1 = rnd.Next(0, 6);
                s2 = rnd.Next(0, 6);
                s3 = rnd.Next(0, 6);
                label1.Text = "Enter your password's symbols number: " + (s1 + 1).ToString() + " " + (s2 + 1).ToString() + " " + (s3 + 1).ToString();
            }

            if (flag == true)
            {
                Close();
                Form new_frm = new Calculator();
                new_frm.Show();
            }
        }
    }
}
