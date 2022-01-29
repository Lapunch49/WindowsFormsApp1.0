
namespace WindowsFormsApp1._0
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.BtCE = new System.Windows.Forms.Button();
            this.BtDiv = new System.Windows.Forms.Button();
            this.Bt9 = new System.Windows.Forms.Button();
            this.Bt8 = new System.Windows.Forms.Button();
            this.Bt7 = new System.Windows.Forms.Button();
            this.BtC = new System.Windows.Forms.Button();
            this.BtMult = new System.Windows.Forms.Button();
            this.Bt6 = new System.Windows.Forms.Button();
            this.Bt5 = new System.Windows.Forms.Button();
            this.Bt4 = new System.Windows.Forms.Button();
            this.BtMinus = new System.Windows.Forms.Button();
            this.Bt3 = new System.Windows.Forms.Button();
            this.Bt2 = new System.Windows.Forms.Button();
            this.Bt1 = new System.Windows.Forms.Button();
            this.BtEq = new System.Windows.Forms.Button();
            this.BtPlus = new System.Windows.Forms.Button();
            this.BtPoint = new System.Windows.Forms.Button();
            this.Bt0 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtCE
            // 
            this.BtCE.BackColor = System.Drawing.Color.Azure;
            this.BtCE.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtCE.Location = new System.Drawing.Point(277, 130);
            this.BtCE.Name = "BtCE";
            this.BtCE.Size = new System.Drawing.Size(58, 46);
            this.BtCE.TabIndex = 13;
            this.BtCE.Text = "CE";
            this.BtCE.UseVisualStyleBackColor = false;
            this.BtCE.Click += new System.EventHandler(this.BtCE_Click);
            // 
            // BtDiv
            // 
            this.BtDiv.BackColor = System.Drawing.Color.Azure;
            this.BtDiv.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtDiv.Location = new System.Drawing.Point(213, 130);
            this.BtDiv.Name = "BtDiv";
            this.BtDiv.Size = new System.Drawing.Size(58, 46);
            this.BtDiv.TabIndex = 12;
            this.BtDiv.Text = "/";
            this.BtDiv.UseVisualStyleBackColor = false;
            this.BtDiv.Click += new System.EventHandler(this.operator_Click);
            // 
            // Bt9
            // 
            this.Bt9.BackColor = System.Drawing.Color.Azure;
            this.Bt9.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt9.Location = new System.Drawing.Point(149, 130);
            this.Bt9.Name = "Bt9";
            this.Bt9.Size = new System.Drawing.Size(58, 46);
            this.Bt9.TabIndex = 11;
            this.Bt9.Text = "9";
            this.Bt9.UseVisualStyleBackColor = false;
            this.Bt9.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt8
            // 
            this.Bt8.BackColor = System.Drawing.Color.Azure;
            this.Bt8.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt8.Location = new System.Drawing.Point(85, 130);
            this.Bt8.Name = "Bt8";
            this.Bt8.Size = new System.Drawing.Size(58, 46);
            this.Bt8.TabIndex = 10;
            this.Bt8.Text = "8";
            this.Bt8.UseVisualStyleBackColor = false;
            this.Bt8.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt7
            // 
            this.Bt7.BackColor = System.Drawing.Color.Azure;
            this.Bt7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt7.Location = new System.Drawing.Point(21, 130);
            this.Bt7.Name = "Bt7";
            this.Bt7.Size = new System.Drawing.Size(58, 46);
            this.Bt7.TabIndex = 9;
            this.Bt7.Text = "7";
            this.Bt7.UseVisualStyleBackColor = false;
            this.Bt7.Click += new System.EventHandler(this.Bt_Click);
            // 
            // BtC
            // 
            this.BtC.BackColor = System.Drawing.Color.Azure;
            this.BtC.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtC.Location = new System.Drawing.Point(277, 193);
            this.BtC.Name = "BtC";
            this.BtC.Size = new System.Drawing.Size(58, 46);
            this.BtC.TabIndex = 18;
            this.BtC.Text = "C";
            this.BtC.UseVisualStyleBackColor = false;
            this.BtC.Click += new System.EventHandler(this.BtC_Click);
            // 
            // BtMult
            // 
            this.BtMult.BackColor = System.Drawing.Color.Azure;
            this.BtMult.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtMult.Location = new System.Drawing.Point(213, 193);
            this.BtMult.Name = "BtMult";
            this.BtMult.Size = new System.Drawing.Size(58, 46);
            this.BtMult.TabIndex = 17;
            this.BtMult.Text = "*";
            this.BtMult.UseVisualStyleBackColor = false;
            this.BtMult.Click += new System.EventHandler(this.operator_Click);
            // 
            // Bt6
            // 
            this.Bt6.BackColor = System.Drawing.Color.Azure;
            this.Bt6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt6.Location = new System.Drawing.Point(149, 193);
            this.Bt6.Name = "Bt6";
            this.Bt6.Size = new System.Drawing.Size(58, 46);
            this.Bt6.TabIndex = 16;
            this.Bt6.Text = "6";
            this.Bt6.UseVisualStyleBackColor = false;
            this.Bt6.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt5
            // 
            this.Bt5.BackColor = System.Drawing.Color.Azure;
            this.Bt5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt5.Location = new System.Drawing.Point(85, 193);
            this.Bt5.Name = "Bt5";
            this.Bt5.Size = new System.Drawing.Size(58, 46);
            this.Bt5.TabIndex = 15;
            this.Bt5.Text = "5";
            this.Bt5.UseVisualStyleBackColor = false;
            this.Bt5.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt4
            // 
            this.Bt4.BackColor = System.Drawing.Color.Azure;
            this.Bt4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt4.Location = new System.Drawing.Point(21, 193);
            this.Bt4.Name = "Bt4";
            this.Bt4.Size = new System.Drawing.Size(58, 46);
            this.Bt4.TabIndex = 14;
            this.Bt4.Text = "4";
            this.Bt4.UseVisualStyleBackColor = false;
            this.Bt4.Click += new System.EventHandler(this.Bt_Click);
            // 
            // BtMinus
            // 
            this.BtMinus.BackColor = System.Drawing.Color.Azure;
            this.BtMinus.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtMinus.Location = new System.Drawing.Point(213, 254);
            this.BtMinus.Name = "BtMinus";
            this.BtMinus.Size = new System.Drawing.Size(58, 46);
            this.BtMinus.TabIndex = 22;
            this.BtMinus.Text = "-";
            this.BtMinus.UseVisualStyleBackColor = false;
            this.BtMinus.Click += new System.EventHandler(this.operator_Click);
            // 
            // Bt3
            // 
            this.Bt3.BackColor = System.Drawing.Color.Azure;
            this.Bt3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt3.Location = new System.Drawing.Point(149, 254);
            this.Bt3.Name = "Bt3";
            this.Bt3.Size = new System.Drawing.Size(58, 46);
            this.Bt3.TabIndex = 21;
            this.Bt3.Text = "3";
            this.Bt3.UseVisualStyleBackColor = false;
            this.Bt3.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt2
            // 
            this.Bt2.BackColor = System.Drawing.Color.Azure;
            this.Bt2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt2.Location = new System.Drawing.Point(85, 254);
            this.Bt2.Name = "Bt2";
            this.Bt2.Size = new System.Drawing.Size(58, 46);
            this.Bt2.TabIndex = 20;
            this.Bt2.Text = "2";
            this.Bt2.UseVisualStyleBackColor = false;
            this.Bt2.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt1
            // 
            this.Bt1.BackColor = System.Drawing.Color.Azure;
            this.Bt1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt1.Location = new System.Drawing.Point(21, 254);
            this.Bt1.Name = "Bt1";
            this.Bt1.Size = new System.Drawing.Size(58, 46);
            this.Bt1.TabIndex = 19;
            this.Bt1.Text = "1";
            this.Bt1.UseVisualStyleBackColor = false;
            this.Bt1.Click += new System.EventHandler(this.Bt_Click);
            // 
            // BtEq
            // 
            this.BtEq.BackColor = System.Drawing.Color.Azure;
            this.BtEq.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtEq.Location = new System.Drawing.Point(277, 254);
            this.BtEq.Name = "BtEq";
            this.BtEq.Size = new System.Drawing.Size(58, 108);
            this.BtEq.TabIndex = 28;
            this.BtEq.Text = "=";
            this.BtEq.UseVisualStyleBackColor = false;
            this.BtEq.Click += new System.EventHandler(this.BtEq_Click);
            // 
            // BtPlus
            // 
            this.BtPlus.BackColor = System.Drawing.Color.Azure;
            this.BtPlus.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtPlus.Location = new System.Drawing.Point(213, 316);
            this.BtPlus.Name = "BtPlus";
            this.BtPlus.Size = new System.Drawing.Size(58, 46);
            this.BtPlus.TabIndex = 27;
            this.BtPlus.Text = "+";
            this.BtPlus.UseVisualStyleBackColor = false;
            this.BtPlus.Click += new System.EventHandler(this.operator_Click);
            // 
            // BtPoint
            // 
            this.BtPoint.BackColor = System.Drawing.Color.Azure;
            this.BtPoint.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtPoint.Location = new System.Drawing.Point(149, 316);
            this.BtPoint.Name = "BtPoint";
            this.BtPoint.Size = new System.Drawing.Size(58, 46);
            this.BtPoint.TabIndex = 26;
            this.BtPoint.Text = ",";
            this.BtPoint.UseVisualStyleBackColor = false;
            this.BtPoint.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt0
            // 
            this.Bt0.BackColor = System.Drawing.Color.Azure;
            this.Bt0.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bt0.Location = new System.Drawing.Point(21, 316);
            this.Bt0.Name = "Bt0";
            this.Bt0.Size = new System.Drawing.Size(122, 46);
            this.Bt0.TabIndex = 24;
            this.Bt0.Text = "0";
            this.Bt0.UseVisualStyleBackColor = false;
            this.Bt0.Click += new System.EventHandler(this.Bt_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbResult.Location = new System.Drawing.Point(21, 78);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(314, 38);
            this.tbResult.TabIndex = 29;
            this.tbResult.Text = "0";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 30;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.BtEq);
            this.Controls.Add(this.BtPlus);
            this.Controls.Add(this.BtPoint);
            this.Controls.Add(this.Bt0);
            this.Controls.Add(this.BtMinus);
            this.Controls.Add(this.Bt3);
            this.Controls.Add(this.Bt2);
            this.Controls.Add(this.Bt1);
            this.Controls.Add(this.BtC);
            this.Controls.Add(this.BtMult);
            this.Controls.Add(this.Bt6);
            this.Controls.Add(this.Bt5);
            this.Controls.Add(this.Bt4);
            this.Controls.Add(this.BtCE);
            this.Controls.Add(this.BtDiv);
            this.Controls.Add(this.Bt9);
            this.Controls.Add(this.Bt8);
            this.Controls.Add(this.Bt7);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtCE;
        private System.Windows.Forms.Button BtDiv;
        private System.Windows.Forms.Button Bt9;
        private System.Windows.Forms.Button Bt8;
        private System.Windows.Forms.Button Bt7;
        private System.Windows.Forms.Button BtC;
        private System.Windows.Forms.Button BtMult;
        private System.Windows.Forms.Button Bt6;
        private System.Windows.Forms.Button Bt5;
        private System.Windows.Forms.Button Bt4;
        private System.Windows.Forms.Button BtMinus;
        private System.Windows.Forms.Button Bt3;
        private System.Windows.Forms.Button Bt2;
        private System.Windows.Forms.Button Bt1;
        private System.Windows.Forms.Button BtEq;
        private System.Windows.Forms.Button BtPlus;
        private System.Windows.Forms.Button BtPoint;
        private System.Windows.Forms.Button Bt0;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
    }
}

