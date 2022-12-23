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
        Panel panel_add = new Panel(); // невидимая панель, которая появляется при нажатии на кнопку
        // и которая позволяет создавать и удалять кнопки на себе
        Panel panel_style = new Panel(); // для изм. стиля формы
        //CheckedListBox style = new CheckedListBox();
        ListBox style = new ListBox();
        Label lb_date = new Label();
        Label lb_time = new Label();
        Color cur_color = Color.Plum;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); // для отображения тек. времени после появления label
        //database
        string[] user_log = new string[4];
        string[] user_pas = new string[4];


        public frmMain()
        {
            InitializeComponent();
            // для обработки нажатия на клавиши
            KeyPreview = true;
            // для создания доп панели, на котором потом можно будет создавать динам. кнопки 
            // и панели для выбора стиля
            add_panels();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.timer_Tick);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // при сворачивании или увеличении окна формы
            // выводим в label текст и случ. число от 1 до 100
            base.OnPaint(e);
            lb_paint.ResetText();
            var rand = new Random();
            rand.Next(1, 100);
            lb_paint.Text = "Paint event: ";
            lb_paint.Text += rand.Next(1, 100).ToString();
        }
        public void New_Form(string form_name)// открытие новой формы
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
                else if (form_name == "Simple_pass")
                {
                    new_frm = new SimplePass();
                }
                else if (form_name == "DifficultPass")
                {
                    new_frm = new DifficultPass();
                }
                new_frm.Show();
            }
        }
        private void add_panels()
        { // для создания доп панели, на котором потом можно будет создавать динам. кнопки
            panel_add.BackColor = cur_color;
            panel_main.Controls.Add(panel_add); // добавляем на panel_main
            // но свойство видимости выбираем false
            panel_add.Visible = false;
            panel_add.Size = panel_main.Size;
            panel_add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            panel_add.MouseDown += new MouseEventHandler(this.frmMain_MouseDown);

            // свойства панели выбора стиля
            panel_style.BackColor = cur_color;
            panel_style.Width = panel_left.Width;
            panel_style.Height = 70;
            panel_style.Location = new Point(0, 244);
            panel_left.Controls.Add(panel_style);
            panel_style.Visible = false;
            panel_style.MouseMove += new MouseEventHandler(frmMain_MouseMove);

            // добавляем ListBox
            panel_style.Controls.Add(style);
            style.BackColor = cur_color;
            style.Width = panel_left.Width;
            style.Font = new Font("Segoe UI", 10f);
            style.Items.AddRange(new object[] { "Pink", "Orange", "Blue" });
            style.SelectedIndexChanged += new EventHandler(this.style_SelectedIndexChanged);
            style.MouseMove += new MouseEventHandler(frmMain_MouseMove);
        }
        private void timer_Tick(object sender, EventArgs e)
        { // для обновления значения текущего времени на label
            lb_time.ResetText();
            lb_time.Text = DateTime.Now.ToLongTimeString();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsMnItm_aboutPr)
            {
                New_Form("About program");
            }
            else if (e.ClickedItem == tsMnItm_task)
            { // Открываем файл-блокнот с заданием
                Process.Start("notepad.exe", "D:\\Учёба\\ООП\\Лабы\\Лаба 1\\WindowsFormsApp1.0\\task.txt");
            }
        }
        private void tsMI_file_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsMIfileOF_Paint_Click(object sender, EventArgs e)
        {
            //Paint paint = new Paint();
            //paint.Visible = true;
            btn_paint.PerformClick();
        }

        private void btn_paint_Click(object sender, EventArgs e)
        {
            New_Form("Simple_pass");
            //New_Form("Paint");
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            New_Form("DifficultPass");
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
        { // обновляем координаты x,y в label при передвижении мыши по форме
            lb_mouse.ResetText();
            lb_mouse.Text = (e.X).ToString() + "\n";
            lb_mouse.Text += (e.Y).ToString();
        }

        private void btn_mainForm_Click(object sender, EventArgs e)
        { // скрываем доп. панель
            panel_add.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        { // высвечиваем доп. панель
            this.panel_add.Visible = true;
        }
        
        private void btn_dynamic_Click(object sender, EventArgs e)
        { // при нажатии на доп. панель - кнопка удаляется
            Button btn = (Button)sender;
            panel_add.Controls.Remove(btn);
        }
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        { // динамическое создание кнопок
            Button btn = new Button();
            btn.FlatStyle = FlatStyle.Flat;
            btn.Width = 60;
            btn.Height = 50;
            btn.Text = ":)";
            btn.BackColor = cur_color;
            btn.Location = new Point(e.X - btn.Width / 2, e.Y - btn.Height / 2);
            panel_add.Controls.Add(btn);
            // добавляем обработчик нажатия на вновь созданную кнопку
            btn.Click += new EventHandler(this.btn_dynamic_Click);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {   // при нажатии на D - появляется label с датой
            if (e.KeyCode == Keys.D)
            {
                lb_date.Size = new Size(300, 40);
                lb_date.BackColor = cur_color;
                lb_date.ResetText();
                lb_date.Text = System.DateTime.Now.ToLongDateString();
                lb_date.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lb_date.Location = new Point(0, 0);
                panel_main.Controls.Add(lb_date);
                lb_date.MouseMove += new MouseEventHandler(this.frmMain_MouseMove);
            }
            // при нажатии на T - появляется label с тек. временем, которое потом изм-ся
            if (e.KeyCode == Keys.T)
            {
                timer.Enabled = true; // запускаем таймер для обновления времени через кажд. сек.
                lb_time.Size = new Size(215, 70);
                lb_time.BorderStyle = BorderStyle.FixedSingle;
                lb_time.BackColor = cur_color;
                lb_time.ResetText();
                lb_time.Text = System.DateTime.Now.ToLongTimeString();
                lb_time.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                lb_time.Location = new Point((panel_main.Width- flowLayoutPanel1.Width) / 2-lb_time.Width/2, panel_main.Height / 3-lb_time.Height/2);
                panel_main.Controls.Add(lb_time);
                lb_time.MouseMove += new MouseEventHandler(this.frmMain_MouseMove);
            }
        }
        private void btn_style_Click(object sender, EventArgs e)
        { // показываем илискрываем панель со списком стилей
            if (panel_style.Visible == false)
                panel_style.Visible = true;
            else panel_style.Visible = false;
        }
        private void change_style()
        { // меняем цвета везде, где необходимо 
            panel_main.BackColor = cur_color;
            panel_left.BackColor = cur_color;
            panel_add.BackColor = cur_color;
            panel_add.BackColor = cur_color;
            panel_leftTop.BackColor = cur_color;
            panel_style.BackColor = cur_color;
            style.BackColor = cur_color;
            btn_mainForm.BackColor = cur_color;
            btn_add.BackColor = cur_color;
            btn_style.BackColor = cur_color;
            lb_date.BackColor = cur_color;
            lb_time.BackColor = cur_color;
            label_apps.BackColor = cur_color;
            lb_mouse.BackColor = cur_color;
            lb_labWork.BackColor = cur_color;
            lb_paint.BackColor = cur_color;
            if (cur_color == Color.Plum)
            {
                menuStrip1.BackColor = Color.MediumPurple;
                btn_mainForm.FlatAppearance.MouseDownBackColor = Color.Orchid;
                btn_add.FlatAppearance.MouseDownBackColor = Color.Orchid;
                btn_style.FlatAppearance.MouseDownBackColor = Color.Orchid;
            }
            else if (cur_color == Color.PeachPuff)
            {
                menuStrip1.BackColor = Color.BurlyWood;
                btn_mainForm.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
                btn_add.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
                btn_style.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
            }
            else
            {
                menuStrip1.BackColor = Color.SteelBlue;
                btn_mainForm.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
                btn_add.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
                btn_style.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            }
        }
        private void style_SelectedIndexChanged(object sender, EventArgs e)
        { // при выборе цвета меняем стиль у формы и объектов на ней
            string color = style.Items[style.SelectedIndex].ToString();
            switch (color)
            {
                case "Pink": cur_color = Color.Plum;  break;
                case "Orange": cur_color = Color.PeachPuff; break;
                case "Blue": cur_color = Color.LightSteelBlue; break;
                default: cur_color = Color.Plum; break;
            }
            change_style();
        }
        
    }
}
