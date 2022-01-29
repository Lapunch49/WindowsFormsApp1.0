
namespace WindowsFormsApp1._0
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMnItm_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMI_file_openForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMIfileOF_Paint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMIfileOF_Calculator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMIfileOF_Timer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMIfileOF_sep = new System.Windows.Forms.ToolStripSeparator();
            this.tsMIfileOF_Blank = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMI_file_close = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItm_aboutPr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMnItm_task = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_paint = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_apps = new System.Windows.Forms.Label();
            this.btn_time = new System.Windows.Forms.Button();
            this.btn_blank = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_mainForm = new System.Windows.Forms.Button();
            this.panel_leftTop = new System.Windows.Forms.Panel();
            this.lb_labWork = new System.Windows.Forms.Label();
            this.lb_mouse = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_style = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.panel_leftTop.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnItm_file,
            this.tsMnItm_aboutPr,
            this.tsMnItm_task});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // tsMnItm_file
            // 
            this.tsMnItm_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMI_file_openForm,
            this.tsMI_file_close});
            this.tsMnItm_file.ForeColor = System.Drawing.Color.White;
            this.tsMnItm_file.Name = "tsMnItm_file";
            this.tsMnItm_file.Size = new System.Drawing.Size(37, 20);
            this.tsMnItm_file.Text = "&File";
            // 
            // tsMI_file_openForm
            // 
            this.tsMI_file_openForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMIfileOF_Paint,
            this.tsMIfileOF_Calculator,
            this.tsMIfileOF_Timer,
            this.tsMIfileOF_sep,
            this.tsMIfileOF_Blank});
            this.tsMI_file_openForm.Name = "tsMI_file_openForm";
            this.tsMI_file_openForm.Size = new System.Drawing.Size(132, 22);
            this.tsMI_file_openForm.Text = "Open form";
            // 
            // tsMIfileOF_Paint
            // 
            this.tsMIfileOF_Paint.Image = ((System.Drawing.Image)(resources.GetObject("tsMIfileOF_Paint.Image")));
            this.tsMIfileOF_Paint.Name = "tsMIfileOF_Paint";
            this.tsMIfileOF_Paint.Size = new System.Drawing.Size(128, 22);
            this.tsMIfileOF_Paint.Text = "Paint";
            this.tsMIfileOF_Paint.Click += new System.EventHandler(this.tsMIfileOF_Paint_Click);
            // 
            // tsMIfileOF_Calculator
            // 
            this.tsMIfileOF_Calculator.Image = ((System.Drawing.Image)(resources.GetObject("tsMIfileOF_Calculator.Image")));
            this.tsMIfileOF_Calculator.Name = "tsMIfileOF_Calculator";
            this.tsMIfileOF_Calculator.Size = new System.Drawing.Size(128, 22);
            this.tsMIfileOF_Calculator.Text = "Calculator";
            this.tsMIfileOF_Calculator.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // tsMIfileOF_Timer
            // 
            this.tsMIfileOF_Timer.Image = ((System.Drawing.Image)(resources.GetObject("tsMIfileOF_Timer.Image")));
            this.tsMIfileOF_Timer.Name = "tsMIfileOF_Timer";
            this.tsMIfileOF_Timer.Size = new System.Drawing.Size(128, 22);
            this.tsMIfileOF_Timer.Text = "Timer";
            this.tsMIfileOF_Timer.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // tsMIfileOF_sep
            // 
            this.tsMIfileOF_sep.Name = "tsMIfileOF_sep";
            this.tsMIfileOF_sep.Size = new System.Drawing.Size(125, 6);
            // 
            // tsMIfileOF_Blank
            // 
            this.tsMIfileOF_Blank.Image = ((System.Drawing.Image)(resources.GetObject("tsMIfileOF_Blank.Image")));
            this.tsMIfileOF_Blank.Name = "tsMIfileOF_Blank";
            this.tsMIfileOF_Blank.Size = new System.Drawing.Size(128, 22);
            this.tsMIfileOF_Blank.Text = "Blank";
            this.tsMIfileOF_Blank.Click += new System.EventHandler(this.btn_blank_Click);
            // 
            // tsMI_file_close
            // 
            this.tsMI_file_close.Name = "tsMI_file_close";
            this.tsMI_file_close.Size = new System.Drawing.Size(132, 22);
            this.tsMI_file_close.Text = "Close";
            this.tsMI_file_close.Click += new System.EventHandler(this.tsMI_file_close_Click);
            // 
            // tsMnItm_aboutPr
            // 
            this.tsMnItm_aboutPr.ForeColor = System.Drawing.SystemColors.Window;
            this.tsMnItm_aboutPr.Name = "tsMnItm_aboutPr";
            this.tsMnItm_aboutPr.Size = new System.Drawing.Size(101, 20);
            this.tsMnItm_aboutPr.Text = "&About program";
            // 
            // tsMnItm_task
            // 
            this.tsMnItm_task.ForeColor = System.Drawing.SystemColors.Window;
            this.tsMnItm_task.ImageTransparentColor = System.Drawing.Color.Lime;
            this.tsMnItm_task.Name = "tsMnItm_task";
            this.tsMnItm_task.Size = new System.Drawing.Size(88, 20);
            this.tsMnItm_task.Text = "&Task for work";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(178, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // btn_paint
            // 
            this.btn_paint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_paint.BackgroundImage")));
            this.btn_paint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_paint.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_paint.Location = new System.Drawing.Point(3, 21);
            this.btn_paint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_paint.Name = "btn_paint";
            this.btn_paint.Size = new System.Drawing.Size(61, 52);
            this.btn_paint.TabIndex = 2;
            this.btn_paint.UseVisualStyleBackColor = true;
            this.btn_paint.Click += new System.EventHandler(this.btn_paint_Click);
            this.btn_paint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // btn_calc
            // 
            this.btn_calc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_calc.BackgroundImage")));
            this.btn_calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_calc.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calc.Location = new System.Drawing.Point(3, 77);
            this.btn_calc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(61, 52);
            this.btn_calc.TabIndex = 3;
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            this.btn_calc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_apps);
            this.flowLayoutPanel1.Controls.Add(this.btn_paint);
            this.flowLayoutPanel1.Controls.Add(this.btn_calc);
            this.flowLayoutPanel1.Controls.Add(this.btn_time);
            this.flowLayoutPanel1.Controls.Add(this.btn_blank);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(341, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(77, 299);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // label_apps
            // 
            this.label_apps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_apps.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_apps.Location = new System.Drawing.Point(3, 0);
            this.label_apps.Name = "label_apps";
            this.label_apps.Size = new System.Drawing.Size(62, 19);
            this.label_apps.TabIndex = 5;
            this.label_apps.Text = "Apps";
            this.label_apps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_apps.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // btn_time
            // 
            this.btn_time.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_time.BackgroundImage")));
            this.btn_time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_time.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_time.Location = new System.Drawing.Point(3, 133);
            this.btn_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(61, 52);
            this.btn_time.TabIndex = 6;
            this.btn_time.UseVisualStyleBackColor = true;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            this.btn_time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // btn_blank
            // 
            this.btn_blank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_blank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_blank.BackgroundImage")));
            this.btn_blank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_blank.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_blank.Location = new System.Drawing.Point(3, 189);
            this.btn_blank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_blank.Name = "btn_blank";
            this.btn_blank.Size = new System.Drawing.Size(61, 52);
            this.btn_blank.TabIndex = 4;
            this.btn_blank.UseVisualStyleBackColor = true;
            this.btn_blank.Click += new System.EventHandler(this.btn_blank_Click);
            this.btn_blank.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // panel_left
            // 
            this.panel_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_left.Controls.Add(this.btn_style);
            this.panel_left.Controls.Add(this.btn_add);
            this.panel_left.Controls.Add(this.btn_mainForm);
            this.panel_left.Controls.Add(this.panel_leftTop);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 24);
            this.panel_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(132, 299);
            this.panel_left.TabIndex = 7;
            this.panel_left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(0, 110);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_add.Size = new System.Drawing.Size(130, 37);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADDITIONAL";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // btn_mainForm
            // 
            this.btn_mainForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mainForm.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_mainForm.FlatAppearance.BorderSize = 0;
            this.btn_mainForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btn_mainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainForm.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_mainForm.Location = new System.Drawing.Point(0, 73);
            this.btn_mainForm.Name = "btn_mainForm";
            this.btn_mainForm.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_mainForm.Size = new System.Drawing.Size(130, 37);
            this.btn_mainForm.TabIndex = 1;
            this.btn_mainForm.Text = "MAIN";
            this.btn_mainForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mainForm.UseVisualStyleBackColor = true;
            this.btn_mainForm.Click += new System.EventHandler(this.btn_mainForm_Click);
            this.btn_mainForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // panel_leftTop
            // 
            this.panel_leftTop.Controls.Add(this.lb_labWork);
            this.panel_leftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_leftTop.Location = new System.Drawing.Point(0, 0);
            this.panel_leftTop.Name = "panel_leftTop";
            this.panel_leftTop.Size = new System.Drawing.Size(130, 73);
            this.panel_leftTop.TabIndex = 0;
            this.panel_leftTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // lb_labWork
            // 
            this.lb_labWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_labWork.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_labWork.Location = new System.Drawing.Point(11, 11);
            this.lb_labWork.Name = "lb_labWork";
            this.lb_labWork.Size = new System.Drawing.Size(119, 56);
            this.lb_labWork.TabIndex = 0;
            this.lb_labWork.Text = "Laboratory work №1";
            this.lb_labWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_labWork.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // lb_mouse
            // 
            this.lb_mouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_mouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_mouse.Font = new System.Drawing.Font("Felix Titling", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_mouse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_mouse.Location = new System.Drawing.Point(348, 251);
            this.lb_mouse.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lb_mouse.Name = "lb_mouse";
            this.lb_mouse.Size = new System.Drawing.Size(61, 42);
            this.lb_mouse.TabIndex = 7;
            this.lb_mouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.lb_mouse);
            this.panel_main.Controls.Add(this.flowLayoutPanel1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(132, 24);
            this.panel_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(418, 299);
            this.panel_main.TabIndex = 9;
            this.panel_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // btn_style
            // 
            this.btn_style.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_style.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_style.FlatAppearance.BorderSize = 0;
            this.btn_style.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btn_style.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_style.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_style.Location = new System.Drawing.Point(0, 147);
            this.btn_style.Name = "btn_style";
            this.btn_style.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_style.Size = new System.Drawing.Size(130, 37);
            this.btn_style.TabIndex = 3;
            this.btn_style.Text = "STYLE";
            this.btn_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_style.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(550, 323);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.panel_leftTop.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMnItm_file;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMI_file_close;
        private System.Windows.Forms.ToolStripMenuItem tsMnItm_aboutPr;
        //private System.Windows.Forms.ToolStripMenuItem tsMnItm3_calc;
        private System.Windows.Forms.Button btn_paint;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button btn_blank;
        //private System.Windows.Forms.ToolStripMenuItem tsMI_file_prop;
        //private System.Windows.Forms.ToolStripMenuItem tsMI_file_close;
        //private System.Windows.Forms.ToolStripComboBox tsCB_file_chosNum;
        //private System.Windows.Forms.ToolStripMenuItem tsMnItm_aboutPr;
        private System.Windows.Forms.ToolStripMenuItem tsMnItm_task;
        private System.Windows.Forms.Label label_apps;
        private System.Windows.Forms.ToolStripMenuItem tsMI_file_openForm;
        private System.Windows.Forms.ToolStripMenuItem tsMIfileOF_Paint;
        private System.Windows.Forms.ToolStripMenuItem tsMIfileOF_Calculator;
        private System.Windows.Forms.ToolStripMenuItem tsMIfileOF_Blank;
        private System.Windows.Forms.ToolStripSeparator tsMIfileOF_sep;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.Label lb_mouse;
        private System.Windows.Forms.Panel panel_leftTop;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_mainForm;
        private System.Windows.Forms.Label lb_labWork;
        private System.Windows.Forms.ToolStripMenuItem tsMIfileOF_Timer;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_style;
    }
}

