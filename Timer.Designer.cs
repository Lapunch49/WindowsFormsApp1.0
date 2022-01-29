
namespace WindowsFormsApp1._0
{
    partial class Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_timeToEnd = new System.Windows.Forms.Label();
            this.cmbx_min = new System.Windows.Forms.ComboBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.cmbx_sec = new System.Windows.Forms.ComboBox();
            this.lb_hour = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.lb_sec = new System.Windows.Forms.Label();
            this.nud_hour = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_timeToEnd
            // 
            this.lb_timeToEnd.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_timeToEnd.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_timeToEnd.Location = new System.Drawing.Point(55, 26);
            this.lb_timeToEnd.Name = "lb_timeToEnd";
            this.lb_timeToEnd.Size = new System.Drawing.Size(227, 75);
            this.lb_timeToEnd.TabIndex = 0;
            this.lb_timeToEnd.Text = "00:00:00";
            this.lb_timeToEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbx_min
            // 
            this.cmbx_min.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cmbx_min.FormattingEnabled = true;
            this.cmbx_min.Location = new System.Drawing.Point(44, 176);
            this.cmbx_min.Name = "cmbx_min";
            this.cmbx_min.Size = new System.Drawing.Size(121, 23);
            this.cmbx_min.TabIndex = 2;
            this.cmbx_min.Text = "0";
            this.cmbx_min.SelectedIndexChanged += new System.EventHandler(this.cmbx_min_SelectedIndexChanged);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Azure;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_start.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_start.Location = new System.Drawing.Point(85, 219);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(176, 49);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Azure;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stop.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_stop.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_stop.Location = new System.Drawing.Point(12, 219);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(143, 49);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Visible = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Azure;
            this.btn_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_restart.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_restart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_restart.Location = new System.Drawing.Point(181, 219);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(143, 49);
            this.btn_restart.TabIndex = 5;
            this.btn_restart.Text = "RESTART";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // cmbx_sec
            // 
            this.cmbx_sec.ForeColor = System.Drawing.Color.DarkBlue;
            this.cmbx_sec.FormattingEnabled = true;
            this.cmbx_sec.Location = new System.Drawing.Point(171, 176);
            this.cmbx_sec.Name = "cmbx_sec";
            this.cmbx_sec.Size = new System.Drawing.Size(121, 23);
            this.cmbx_sec.TabIndex = 8;
            this.cmbx_sec.Text = "0";
            this.cmbx_sec.SelectedIndexChanged += new System.EventHandler(this.cmbx_sec_SelectedIndexChanged);
            // 
            // lb_hour
            // 
            this.lb_hour.AutoSize = true;
            this.lb_hour.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_hour.Location = new System.Drawing.Point(109, 111);
            this.lb_hour.Name = "lb_hour";
            this.lb_hour.Size = new System.Drawing.Size(42, 15);
            this.lb_hour.TabIndex = 9;
            this.lb_hour.Text = "Hours:";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_min.Location = new System.Drawing.Point(44, 158);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(53, 15);
            this.lb_min.TabIndex = 10;
            this.lb_min.Text = "Minutes:";
            // 
            // lb_sec
            // 
            this.lb_sec.AutoSize = true;
            this.lb_sec.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_sec.Location = new System.Drawing.Point(171, 158);
            this.lb_sec.Name = "lb_sec";
            this.lb_sec.Size = new System.Drawing.Size(55, 15);
            this.lb_sec.TabIndex = 11;
            this.lb_sec.Text = "Seconds:";
            // 
            // nud_hour
            // 
            this.nud_hour.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.nud_hour.Location = new System.Drawing.Point(110, 132);
            this.nud_hour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nud_hour.Name = "nud_hour";
            this.nud_hour.Size = new System.Drawing.Size(120, 23);
            this.nud_hour.TabIndex = 12;
            this.nud_hour.ValueChanged += new System.EventHandler(this.nud_hour_ValueChanged);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 284);
            this.Controls.Add(this.nud_hour);
            this.Controls.Add(this.lb_sec);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.lb_hour);
            this.Controls.Add(this.cmbx_sec);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.cmbx_min);
            this.Controls.Add(this.lb_timeToEnd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timer";
            this.Text = "Timer";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            ((System.ComponentModel.ISupportInitialize)(this.nud_hour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_timeToEnd;
        private System.Windows.Forms.ComboBox cmbx_min;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.ComboBox cmbx_sec;
        private System.Windows.Forms.Label lb_hour;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label lb_sec;
        private System.Windows.Forms.NumericUpDown nud_hour;
    }
}

