namespace TheMist
{
    partial class LoginDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.tbxDatabase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDbPassword = new System.Windows.Forms.TextBox();
            this.tbxDbUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(237, 59);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(514, 33);
            this.tbxLogin.TabIndex = 2;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(237, 127);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(514, 33);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassword_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(620, 196);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 54);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(458, 196);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(127, 54);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "设置";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.tbxDatabase);
            this.pnlSettings.Controls.Add(this.label6);
            this.pnlSettings.Controls.Add(this.tbxDbPassword);
            this.pnlSettings.Controls.Add(this.tbxDbUser);
            this.pnlSettings.Controls.Add(this.label5);
            this.pnlSettings.Controls.Add(this.label4);
            this.pnlSettings.Controls.Add(this.tbxHost);
            this.pnlSettings.Controls.Add(this.label3);
            this.pnlSettings.Location = new System.Drawing.Point(46, 288);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(760, 309);
            this.pnlSettings.TabIndex = 6;
            // 
            // tbxDatabase
            // 
            this.tbxDatabase.Location = new System.Drawing.Point(182, 94);
            this.tbxDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDatabase.Name = "tbxDatabase";
            this.tbxDatabase.Size = new System.Drawing.Size(522, 33);
            this.tbxDatabase.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "数据库名称";
            // 
            // tbxDbPassword
            // 
            this.tbxDbPassword.Location = new System.Drawing.Point(182, 238);
            this.tbxDbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDbPassword.Name = "tbxDbPassword";
            this.tbxDbPassword.Size = new System.Drawing.Size(522, 33);
            this.tbxDbPassword.TabIndex = 5;
            this.tbxDbPassword.UseSystemPasswordChar = true;
            // 
            // tbxDbUser
            // 
            this.tbxDbUser.Location = new System.Drawing.Point(182, 167);
            this.tbxDbUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDbUser.Name = "tbxDbUser";
            this.tbxDbUser.Size = new System.Drawing.Size(522, 33);
            this.tbxDbUser.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "数据库密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "数据库用户名";
            // 
            // tbxHost
            // 
            this.tbxHost.Location = new System.Drawing.Point(182, 29);
            this.tbxHost.Margin = new System.Windows.Forms.Padding(2);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(522, 33);
            this.tbxHost.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "服务器IP";
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 638);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.LoginDialog_Load);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.TextBox tbxDbPassword;
        private System.Windows.Forms.TextBox tbxDbUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDatabase;
        private System.Windows.Forms.Label label6;
    }
}