namespace RentAndSell.Car.FormApp
{
    partial class RegisterPage
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
            txtFirstName = new TextBox();
            gBox = new GroupBox();
            lblMessage = new Label();
            btnLogin = new Button();
            btnSave = new Button();
            txtPasswordAgain = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            gBox.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(21, 22);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Adınız";
            txtFirstName.Size = new Size(192, 23);
            txtFirstName.TabIndex = 0;
            // 
            // gBox
            // 
            gBox.Controls.Add(lblMessage);
            gBox.Controls.Add(btnLogin);
            gBox.Controls.Add(btnSave);
            gBox.Controls.Add(txtPasswordAgain);
            gBox.Controls.Add(txtPassword);
            gBox.Controls.Add(txtUserName);
            gBox.Controls.Add(txtEmail);
            gBox.Controls.Add(txtLastName);
            gBox.Controls.Add(txtFirstName);
            gBox.Location = new Point(12, 12);
            gBox.Name = "gBox";
            gBox.Size = new Size(360, 237);
            gBox.TabIndex = 1;
            gBox.TabStop = false;
            gBox.Text = "YENİ KAYIT";
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(219, 22);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(135, 168);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "Mesajlar...";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(138, 196);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Girişe Git";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(21, 196);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPasswordAgain
            // 
            txtPasswordAgain.Location = new Point(21, 167);
            txtPasswordAgain.Name = "txtPasswordAgain";
            txtPasswordAgain.PasswordChar = '*';
            txtPasswordAgain.PlaceholderText = "Şifreniz Tekrar";
            txtPasswordAgain.Size = new Size(192, 23);
            txtPasswordAgain.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(21, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Şifreniz";
            txtPassword.Size = new Size(192, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(21, 109);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Kullanıcı Adınız";
            txtUserName.Size = new Size(192, 23);
            txtUserName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(21, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-Posta Adresiniz";
            txtEmail.Size = new Size(192, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(21, 51);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Soyadınız";
            txtLastName.Size = new Size(192, 23);
            txtLastName.TabIndex = 1;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(gBox);
            Name = "RegisterPage";
            Text = "RegisterPage";
            gBox.ResumeLayout(false);
            gBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFirstName;
        private GroupBox gBox;
        private TextBox txtPasswordAgain;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private Label lblMessage;
        private Button btnLogin;
        private Button btnSave;
    }
}