
namespace WindowsFormsApp1._0
{
    partial class Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_whit = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_oran = new System.Windows.Forms.Button();
            this.btn_li_blu = new System.Windows.Forms.Button();
            this.btn_gre = new System.Windows.Forms.Button();
            this.btn_yel = new System.Windows.Forms.Button();
            this.btn_blac = new System.Windows.Forms.Button();
            this.btn_viol = new System.Windows.Forms.Button();
            this.btn_blu = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctrBx_pencil = new System.Windows.Forms.PictureBox();
            this.btn_other = new System.Windows.Forms.Button();
            this.trackBar_pencil = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx_pencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pencil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btn_whit
            // 
            this.btn_whit.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_whit, "btn_whit");
            this.btn_whit.Name = "btn_whit";
            this.btn_whit.UseVisualStyleBackColor = false;
            this.btn_whit.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btn_red, "btn_red");
            this.btn_red.Name = "btn_red";
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_oran
            // 
            this.btn_oran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btn_oran, "btn_oran");
            this.btn_oran.Name = "btn_oran";
            this.btn_oran.UseVisualStyleBackColor = false;
            this.btn_oran.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_li_blu
            // 
            this.btn_li_blu.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.btn_li_blu, "btn_li_blu");
            this.btn_li_blu.Name = "btn_li_blu";
            this.btn_li_blu.UseVisualStyleBackColor = false;
            this.btn_li_blu.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_gre
            // 
            this.btn_gre.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.btn_gre, "btn_gre");
            this.btn_gre.Name = "btn_gre";
            this.btn_gre.UseVisualStyleBackColor = false;
            this.btn_gre.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_yel
            // 
            this.btn_yel.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btn_yel, "btn_yel");
            this.btn_yel.Name = "btn_yel";
            this.btn_yel.UseVisualStyleBackColor = false;
            this.btn_yel.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_blac
            // 
            this.btn_blac.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btn_blac, "btn_blac");
            this.btn_blac.Name = "btn_blac";
            this.btn_blac.UseVisualStyleBackColor = false;
            this.btn_blac.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_viol
            // 
            this.btn_viol.BackColor = System.Drawing.Color.DarkOrchid;
            resources.ApplyResources(this.btn_viol, "btn_viol");
            this.btn_viol.Name = "btn_viol";
            this.btn_viol.UseVisualStyleBackColor = false;
            this.btn_viol.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_blu
            // 
            this.btn_blu.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.btn_blu, "btn_blu");
            this.btn_blu.Name = "btn_blu";
            this.btn_blu.UseVisualStyleBackColor = false;
            this.btn_blu.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.btn_save, "btn_save");
            this.btn_save.Name = "btn_save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.btn_clear, "btn_clear");
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pctrBx_pencil);
            this.panel1.Controls.Add(this.btn_other);
            this.panel1.Controls.Add(this.trackBar_pencil);
            this.panel1.Controls.Add(this.btn_oran);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_whit);
            this.panel1.Controls.Add(this.btn_red);
            this.panel1.Controls.Add(this.btn_yel);
            this.panel1.Controls.Add(this.btn_blac);
            this.panel1.Controls.Add(this.btn_gre);
            this.panel1.Controls.Add(this.btn_viol);
            this.panel1.Controls.Add(this.btn_blu);
            this.panel1.Controls.Add(this.btn_li_blu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pctrBx_pencil
            // 
            this.pctrBx_pencil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pctrBx_pencil, "pctrBx_pencil");
            this.pctrBx_pencil.Name = "pctrBx_pencil";
            this.pctrBx_pencil.TabStop = false;
            // 
            // btn_other
            // 
            this.btn_other.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btn_other, "btn_other");
            this.btn_other.Name = "btn_other";
            this.btn_other.UseVisualStyleBackColor = false;
            this.btn_other.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // trackBar_pencil
            // 
            resources.ApplyResources(this.trackBar_pencil, "trackBar_pencil");
            this.trackBar_pencil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar_pencil.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBar_pencil.LargeChange = 4;
            this.trackBar_pencil.Maximum = 20;
            this.trackBar_pencil.Name = "trackBar_pencil";
            this.trackBar_pencil.ValueChanged += new System.EventHandler(this.trackBar_pencil_ValueChanged);
            // 
            // Paint
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx_pencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_pencil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btn_whit;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_oran;
        private System.Windows.Forms.Button btn_li_blu;
        private System.Windows.Forms.Button btn_gre;
        private System.Windows.Forms.Button btn_yel;
        private System.Windows.Forms.Button btn_blac;
        private System.Windows.Forms.Button btn_viol;
        private System.Windows.Forms.Button btn_blu;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar_pencil;
        private System.Windows.Forms.Button btn_other;
        private System.Windows.Forms.PictureBox pctrBx_pencil;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}