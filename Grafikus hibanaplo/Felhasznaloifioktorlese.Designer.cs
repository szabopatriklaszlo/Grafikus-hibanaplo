namespace Grafikus_hibanaplo
{
    partial class Felhasznaloifioktorlese
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_delete = new System.Windows.Forms.Button();
            this.BT_back = new System.Windows.Forms.Button();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.TB_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(26, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(726, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Amennyiben nem biztos az adatokban, úgy megnézheti azokat a választómenüben lévő " +
    "\"Aktuális rendszergazdai fiókok megtekintése\" gombra kattintva!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(715, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Figyelem! Biztonsági okokból kifolyólag a pontos felhasználónév és jelszó magadás" +
    "a szükségeltetik! ";
            // 
            // BT_delete
            // 
            this.BT_delete.Location = new System.Drawing.Point(250, 201);
            this.BT_delete.Name = "BT_delete";
            this.BT_delete.Size = new System.Drawing.Size(100, 23);
            this.BT_delete.TabIndex = 37;
            this.BT_delete.Text = "Törlés";
            this.BT_delete.UseVisualStyleBackColor = true;
            this.BT_delete.Click += new System.EventHandler(this.BT_delete_Click);
            // 
            // BT_back
            // 
            this.BT_back.Location = new System.Drawing.Point(604, 403);
            this.BT_back.Name = "BT_back";
            this.BT_back.Size = new System.Drawing.Size(184, 35);
            this.BT_back.TabIndex = 36;
            this.BT_back.Text = "Vissza a választó menüre";
            this.BT_back.UseVisualStyleBackColor = true;
            this.BT_back.Click += new System.EventHandler(this.BT_back_Click);
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(250, 157);
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '*';
            this.TB_password.Size = new System.Drawing.Size(100, 20);
            this.TB_password.TabIndex = 35;
            // 
            // TB_username
            // 
            this.TB_username.Location = new System.Drawing.Point(250, 121);
            this.TB_username.Name = "TB_username";
            this.TB_username.Size = new System.Drawing.Size(100, 20);
            this.TB_username.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(179, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Jelszó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(104, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Felhasználónév:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(91, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Írja be a kívánt felhasználónevet valamint jelszavat és kattintson a törlés gombr" +
    "a.";
            // 
            // Felhasznaloifioktorlese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_delete);
            this.Controls.Add(this.BT_back);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Felhasznaloifioktorlese";
            this.Text = "Felhasználói fiók törlése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_delete;
        private System.Windows.Forms.Button BT_back;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.TextBox TB_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}