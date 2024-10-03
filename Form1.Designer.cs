namespace AppSettings
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(260, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Имя пользователя";

            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Location = new System.Drawing.Point(12, 38);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(117, 17);
            this.chkRememberMe.TabIndex = 1;
            this.chkRememberMe.Text = "Запомнить меня";

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 61);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
