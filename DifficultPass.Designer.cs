
namespace WindowsFormsApp1._0
{
    partial class DifficultPass
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
            this.grpBx_step2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_pswEq = new System.Windows.Forms.Label();
            this.lb_textForUser = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.grpBx_step2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBx_step2
            // 
            this.grpBx_step2.BackColor = System.Drawing.Color.AliceBlue;
            this.grpBx_step2.Controls.Add(this.button1);
            this.grpBx_step2.Controls.Add(this.label1);
            this.grpBx_step2.Controls.Add(this.lb_pswEq);
            this.grpBx_step2.Controls.Add(this.lb_textForUser);
            this.grpBx_step2.Controls.Add(this.tb_password);
            this.grpBx_step2.Controls.Add(this.lb_password);
            this.grpBx_step2.Controls.Add(this.tb_login);
            this.grpBx_step2.Controls.Add(this.lb_login);
            this.grpBx_step2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBx_step2.Location = new System.Drawing.Point(12, 13);
            this.grpBx_step2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBx_step2.Name = "grpBx_step2";
            this.grpBx_step2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBx_step2.Size = new System.Drawing.Size(309, 273);
            this.grpBx_step2.TabIndex = 2;
            this.grpBx_step2.TabStop = false;
            this.grpBx_step2.Text = "Sign up";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(209, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 36;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 52);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enter your password\'s symbols number: ";
            // 
            // lb_pswEq
            // 
            this.lb_pswEq.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_pswEq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.lb_pswEq.Location = new System.Drawing.Point(13, 191);
            this.lb_pswEq.Name = "lb_pswEq";
            this.lb_pswEq.Size = new System.Drawing.Size(294, 43);
            this.lb_pswEq.TabIndex = 33;
            // 
            // lb_textForUser
            // 
            this.lb_textForUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_textForUser.Location = new System.Drawing.Point(24, 28);
            this.lb_textForUser.Name = "lb_textForUser";
            this.lb_textForUser.Size = new System.Drawing.Size(279, 33);
            this.lb_textForUser.TabIndex = 14;
            this.lb_textForUser.Text = "Enter your username and password";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(124, 158);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(143, 29);
            this.tb_password.TabIndex = 11;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // lb_password
            // 
            this.lb_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_password.Location = new System.Drawing.Point(35, 158);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(86, 31);
            this.lb_password.TabIndex = 10;
            this.lb_password.Text = "Password:";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(124, 65);
            this.tb_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(143, 29);
            this.tb_login.TabIndex = 9;
            this.tb_login.TextChanged += new System.EventHandler(this.tb_login_TextChanged);
            // 
            // lb_login
            // 
            this.lb_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_login.Location = new System.Drawing.Point(35, 65);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(75, 31);
            this.lb_login.TabIndex = 8;
            this.lb_login.Text = "Login:";
            // 
            // DifficultPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 294);
            this.Controls.Add(this.grpBx_step2);
            this.Name = "DifficultPass";
            this.Text = "DifficultPass";
            this.grpBx_step2.ResumeLayout(false);
            this.grpBx_step2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBx_step2;
        private System.Windows.Forms.Label lb_pswEq;
        private System.Windows.Forms.Label lb_textForUser;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}