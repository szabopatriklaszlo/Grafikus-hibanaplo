﻿namespace Grafikus_hibanaplo
{
    partial class Form1
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
            this.BT_login = new System.Windows.Forms.Button();
            this.BT_back = new System.Windows.Forms.Button();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.TB_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_login
            // 
            this.BT_login.Location = new System.Drawing.Point(340, 224);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(100, 23);
            this.BT_login.TabIndex = 13;
            this.BT_login.Text = "Bejelentkezés";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // BT_back
            // 
            this.BT_back.Location = new System.Drawing.Point(604, 403);
            this.BT_back.Name = "BT_back";
            this.BT_back.Size = new System.Drawing.Size(184, 35);
            this.BT_back.TabIndex = 12;
            this.BT_back.Text = "Vissza a választó menüre";
            this.BT_back.UseVisualStyleBackColor = true;
            this.BT_back.Click += new System.EventHandler(this.BT_back_Click);
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(340, 180);
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '*';
            this.TB_password.Size = new System.Drawing.Size(100, 20);
            this.TB_password.TabIndex = 11;
            // 
            // TB_username
            // 
            this.TB_username.Location = new System.Drawing.Point(340, 144);
            this.TB_username.Name = "TB_username";
            this.TB_username.Size = new System.Drawing.Size(100, 20);
            this.TB_username.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(269, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jelszó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(194, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Felhasználónév:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(193, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ön a felhasználói belépést választotta!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(337, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Figyelem! A program bezárásával autómatikusan kijelentkezik!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_login);
            this.Controls.Add(this.BT_back);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Felhasználói bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_login;
        private System.Windows.Forms.Button BT_back;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.TextBox TB_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}