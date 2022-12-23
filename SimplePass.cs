using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1._0
{
    public partial class SimplePass : Form

    {
        Color yellow = System.Drawing.ColorTranslator.FromHtml("#fafbde");
        string password = "";
        string login = "";
        public SimplePass()
        {
            InitializeComponent();
        }

        private void tb_login_TextChanged(object sender, EventArgs e)
        {
            // если поле логина не пусто, то цвет поля становится желтым
            //if (tb_login.Text != "")
            //    tb_login.BackColor = yellow;
            //else tb_login.BackColor = Color.White;
            login= tb_login.Text;
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            // если поле ввода пяроля не пусто, то цвет поля становится желтым
            password = tb_password.Text;
            //if (tb_password.Text != "")
            //    tb_password.BackColor = yellow;
            //else tb_password.BackColor = Color.White;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool flag = false;
            lb_pswEq.Text = "";
            User_st db = new User_st(@"db.txt");

            for (int i = 0; i < db.k; ++i)
            {
                if (db.st[i].login == login && db.st[i].password == password)
                    flag = true;
            }
            if (flag == false)
                lb_pswEq.Text = "This user does not exist";
            else { 
                Close();
                Form new_frm = new Paint();
                new_frm.Show();
            }

        }
    }
}
