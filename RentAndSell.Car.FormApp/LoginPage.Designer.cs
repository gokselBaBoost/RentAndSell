﻿namespace RentAndSell.Car.FormApp
{
    partial class LoginPage
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            gBoxLogin = new GroupBox();
            lblMessage = new Label();
            gBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(6, 22);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Kullanıcı Adı";
            txtUserName.Size = new Size(211, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 51);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new Size(211, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(6, 80);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(142, 80);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // gBoxLogin
            // 
            gBoxLogin.Controls.Add(lblMessage);
            gBoxLogin.Controls.Add(txtUserName);
            gBoxLogin.Controls.Add(btnRegister);
            gBoxLogin.Controls.Add(txtPassword);
            gBoxLogin.Controls.Add(btnLogin);
            gBoxLogin.Location = new Point(12, 12);
            gBoxLogin.Name = "gBoxLogin";
            gBoxLogin.Size = new Size(360, 127);
            gBoxLogin.TabIndex = 4;
            gBoxLogin.TabStop = false;
            gBoxLogin.Text = "GİRİŞ";
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(223, 22);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(131, 81);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Mesajlar...";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(gBoxLogin);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            gBoxLogin.ResumeLayout(false);
            gBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private GroupBox gBoxLogin;
        private Label lblMessage;
    }
}