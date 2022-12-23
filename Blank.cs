using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1._0
{
    public partial class Blank : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        ProgressBar load = new ProgressBar();
        bool fl = false; // флаг отвечает за то, что все поля заполнены пользователем
        Image excl_mark = Image.FromFile("D:\\Учёба\\ООП\\Лабы\\Лаба 1\\WindowsFormsApp1.0\\WindowsFormsApp1.0\\изображения\\Empty.jpg");
        string password = "";
        bool pswrd_equal = false;
        Color yellow = System.Drawing.ColorTranslator.FromHtml("#fafbde");
        public Blank()
        {
            InitializeComponent();
            // удаляем вторую вкладку, чтобы пользователь не мог с ней работать, пока не заполнил все данные
            //tabPage2.Enabled = false;
            tbCntrl_blank.TabPages.Remove(tabPage2);
            // свойства таймера
            timer.Interval = 500;
            timer.Tick += new EventHandler(this.timer_Tick);
            // и прогресс бара
            load.Maximum = 4;
            load.Value = 0;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (load.Value != load.Maximum)
                load.Value += 1;
            else
            {
                timer.Enabled = false;
                MessageBox.Show("Your data has been successfully saved");
                load.Visible = false;
            }
        }
        private void check_fields() // проверка, все ли поля заполнены
        {
            fl = true; // изначально принимаем, что все поля заполнены
            // если где-то поле пустое, то флаг опускается
            // если поле компонента не заполнено, то рядом появляется красный воскл. знак
            if (tb_name.Text == "")
            {
                pb_name.Image = excl_mark;
                fl = false;
            }
            else pb_name.Image = null;
            if (tb_surname.Text == "")
            {
                pb_surname.Image = excl_mark;
                fl = false;
            }
            else pb_surname.Image = null;
            if (rbtn_male.Checked == false && rbtn_female.Checked == false)
            {
                pb_gender.Image = excl_mark;
                fl = false;
            }
            else pb_gender.Image = null;
            if (dateTimePicker_DOB.Checked == false)
            {
                pb_DOB.Image = excl_mark;
                fl = false;
            }
            else pb_DOB.Image = null;
            if (tb_address.Text == "")
            {
                pb_address.Image = excl_mark;
                fl = false;
            }
            else pb_address.Image = null;
            if (maskTb_phNum.Text.ToString()[1] == ' ')
            {
                pb_phone.Image = excl_mark;
                fl = false;
            }
            else pb_phone.Image = null;
            if (tb_email.Text == "")
            {
                pb_email.Image = excl_mark;
                fl = false;
            }
            else pb_email.Image = null;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (tbCntrl_blank.SelectedTab == tabPage1)
            {
                check_fields(); // проверяем все ли поля заполнены (тогда fl = true)
                lb_redInf.ResetText();
                if (fl == true && btn_next.Enabled == false)
                { // если все поля заполнены, "появляется" вторая вкладка и кнопка >> активируется
                    tbCntrl_blank.TabPages.Add(tabPage2);
                    btn_next.Enabled = true;
                }
                else lb_redInf.Text = " ** Not all fields are filled in";
            }
            else
            {
                lb_pswEq.ResetText();
                if (pswrd_equal == false)
                {
                    lb_pswEq.Text = "*You entered two different passwords. Please try again";
                }
                else if (cb_robot.Checked == false)
                {
                    lb_pswEq.Text = "* Please complete the captcha below";
                }
                else if (load.Value == 0)
                {
                    // загрузка progressBar 
                    load.Visible = true;
                    timer.Enabled = true;
                    //if (load.Value != load.Maximum)
                    //    System.Windows.Forms.MessageBox.Show(load, "Loading...");
                    tbCntrl_blank.TabPages[1].Controls.Add(load);
                    load.Location = new Point(50, 375);
                    //загрузка в бд инфы о новом пользователе
                    User_st db = new User_st(@"db.txt");
                    User new_user = new User(tb_login.Text, tb_password.Text);
                    db.add(new_user);
                    db.save(@"db.txt");
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == ">>")
            {
                btn.Text = "<<";
                // переключаемся на др. вкладку
                tbCntrl_blank.SelectedTab = tabPage2;
            }
            else
            {
                btn.Text = ">>";
                tbCntrl_blank.SelectedTab = tabPage1;
            }
        }
        private void pctrBx_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                pctrBx_photo.Image = new Bitmap(open_dialog.FileName);
            }
        }
        private void tb_password_TextChanged(object sender, EventArgs e)
        { // если поле ввода пяроля не пусто, то цвет поля становится желтым
            password = tb_password.Text;
            if (tb_password.Text != "")
                tb_password.BackColor = yellow;
            else tb_password.BackColor = Color.White;
        }
        private void tb_password2_TextChanged(object sender, EventArgs e)
        { // проверка на соответвествие двух паролей
            if (tb_password2.Text == password)
            {
                pswrd_equal = true;
                tb_password2.BackColor = yellow;
            }
            else { 
                pswrd_equal = false;
                tb_password2.BackColor = Color.White;
            }
        }

        private void tb_login_TextChanged(object sender, EventArgs e)
        { // если поле логина не пусто, то цвет поля становится желтым
            if (tb_login.Text != "")
                tb_login.BackColor = yellow;
            else tb_login.BackColor = Color.White;
        }

        private void cb_robot_CheckedChanged(object sender, EventArgs e)
        { // рисование зеленой галочки на checkBox
            //if (cb_robot.Checked == true){
                PictureBox pctrBx_robot = new PictureBox();
                pctrBx_robot.Location = new System.Drawing.Point(297, 292);
                pctrBx_robot.Name = "pctrBx_robot";
                pctrBx_robot.Size = new System.Drawing.Size(15, 15);
                pctrBx_robot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pctrBx_robot.Image = Image.FromFile("D:\\Учёба\\ООП\\Лабы\\Лаба 1\\WindowsFormsApp1.0\\WindowsFormsApp1.0\\изображения\\green_mark.jpg");
                pctrBx_robot.Visible = true;
            //}
        }
    }
}
