namespace Grafikus_hibanaplo
{
    partial class Aktualisfelhasznalok
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
            this.BT_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_message = new System.Windows.Forms.Label();
            this.LB_passwords = new System.Windows.Forms.ListBox();
            this.LB_users = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BT_back
            // 
            this.BT_back.Location = new System.Drawing.Point(604, 403);
            this.BT_back.Name = "BT_back";
            this.BT_back.Size = new System.Drawing.Size(184, 35);
            this.BT_back.TabIndex = 43;
            this.BT_back.Text = "Vissza a választó menüre";
            this.BT_back.UseVisualStyleBackColor = true;
            this.BT_back.Click += new System.EventHandler(this.BT_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Felhasználó jelszava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Felhasználó neve";
            // 
            // LBL_message
            // 
            this.LBL_message.AutoSize = true;
            this.LBL_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_message.Location = new System.Drawing.Point(245, 9);
            this.LBL_message.Name = "LBL_message";
            this.LBL_message.Size = new System.Drawing.Size(306, 26);
            this.LBL_message.TabIndex = 40;
            this.LBL_message.Text = "Aktuális DINAMIKUS fiókok";
            // 
            // LB_passwords
            // 
            this.LB_passwords.FormattingEnabled = true;
            this.LB_passwords.Location = new System.Drawing.Point(405, 120);
            this.LB_passwords.Name = "LB_passwords";
            this.LB_passwords.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LB_passwords.Size = new System.Drawing.Size(120, 212);
            this.LB_passwords.TabIndex = 39;
            // 
            // LB_users
            // 
            this.LB_users.FormattingEnabled = true;
            this.LB_users.Location = new System.Drawing.Point(290, 120);
            this.LB_users.Name = "LB_users";
            this.LB_users.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LB_users.Size = new System.Drawing.Size(120, 212);
            this.LB_users.TabIndex = 38;
            // 
            // Aktualisfelhasznalok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_message);
            this.Controls.Add(this.LB_passwords);
            this.Controls.Add(this.LB_users);
            this.Name = "Aktualisfelhasznalok";
            this.Text = "Aktuális rendszergazdai fiókok";
            this.Load += new System.EventHandler(this.Aktualisrendszergazdaifiokok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_message;
        private System.Windows.Forms.ListBox LB_passwords;
        private System.Windows.Forms.ListBox LB_users;
    }
}