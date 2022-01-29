using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1._0
{
    public partial class frmMain : Form
    {
        //private Form currentChildForm = null;
        public frmMain()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //this.Text = "Событие Paint";
        }
        private void New_Form(string form_name)// открытие новой формы
        {
            // проверяем не была ли уже открыта эта форма
            bool fl = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == form_name)
                {
                    //this.Hide();
                    form.Visible = true;
                    fl = true;
                    break;
                }
            }
            if (fl == false)
            {
                Form new_frm = null;
                //this.Hide();
                if (form_name == "Calculator")
                {
                    new_frm = new Calculator();
                }
                else if (form_name == "Paint") {
                    new_frm = new Paint();
                }
                else if (form_name == "About program")
                {
                    new_frm = new About_program();
                }
                else if (form_name == "Blank")
                {
                    new_frm = new Blank();
                }
                else if (form_name == "Timer")
                {
                    new_frm = new Timer();
                }
                new_frm.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsMnItm_aboutPr)
            {
                New_Form("About program");
            }
            else if (e.ClickedItem == tsMnItm_task)
            {
                Process.Start("notepad.exe", "D:\\Учёба\\ООП\\Лабы\\Лаба 1\\WindowsFormsApp1.0\\task.txt");
            }
        }
        private void tsMI_file_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsMIfileOF_Paint_Click(object sender, EventArgs e)
        {
            Paint paint = new Paint();
            // paint.ShowDialog();
            paint.Visible = true;
            // btn_paint_Click(this, null);
        }

        private void btn_paint_Click(object sender, EventArgs e)
        {
            New_Form("Paint");
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            New_Form("Calculator");
        }

        private void btn_blank_Click(object sender, EventArgs e)
        {
            New_Form("Blank");
        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            New_Form("Timer");
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            lb_mouse.ResetText();
            lb_mouse.Text = (e.X).ToString() + "\n";
            lb_mouse.Text += (e.Y).ToString();
        }

        //ChangeToolStripMenuItem(ts, 0, 1,"fff", Keys.Alt | Keys.X);
        //(System.Drawing.Image) global::IIS.Product.Properties.Resources.Exit16
        private void OpenChildForm(Form childForm)
        {
            //open only form
            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //}
            //currentChildForm = childForm;
            //End
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //panelDesktop.Controls.Add(childForm);
            //panelDesktop.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
           // lblTitleChildForm.Text = childForm.Text;
        }

        private void btn_mainForm_Click(object sender, EventArgs e)
        {
            //Form fr = new Paint();
            //fr.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Additional add_form = new Additional();
            //Additional.MdiParent = this;
            Button btn = new Button();
            
        }
    }
}
