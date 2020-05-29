namespace Grafikus_hibanaplo
{
    partial class Aktualisfelhasznaloifiokok
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
            this.LB_users = new System.Windows.Forms.ListBox();
            this.LB_passwords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_users
            // 
            this.LB_users.FormattingEnabled = true;
            this.LB_users.Location = new System.Drawing.Point(290, 120);
            this.LB_users.Name = "LB_users";
            this.LB_users.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LB_users.Size = new System.Drawing.Size(120, 95);
            this.LB_users.TabIndex = 1;
            // 
            // LB_passwords
            // 
            this.LB_passwords.FormattingEnabled = true;
            this.LB_passwords.Location = new System.Drawing.Point(405, 120);
            this.LB_passwords.Name = "LB_passwords";
            this.LB_passwords.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LB_passwords.Size = new System.Drawing.Size(120, 95);
            this.LB_passwords.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aktuális felhasználói fiókok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Felhasználó neve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Felhasználó jelszava";
            // 
            // BT_back
            // 
            this.BT_back.Location = new System.Drawing.Point(604, 403);
            this.BT_back.Name = "BT_back";
            this.BT_back.Size = new System.Drawing.Size(184, 35);
            this.BT_back.TabIndex = 37;
            this.BT_back.Text = "Vissza a választó menüre";
            this.BT_back.UseVisualStyleBackColor = true;
            this.BT_back.Click += new System.EventHandler(this.BT_back_Click);
            // 
            // Aktualisfelhasznaloifiokok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_passwords);
            this.Controls.Add(this.LB_users);
            this.Name = "Aktualisfelhasznaloifiokok";
            this.Text = "Aktuális felhasználói fiókok";
            this.Load += new System.EventHandler(this.Aktualisfelhasznaloifiokok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_users;
        private System.Windows.Forms.ListBox LB_passwords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_back;
    }
}