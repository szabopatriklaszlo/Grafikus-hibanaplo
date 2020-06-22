namespace Grafikus_hibanaplo
{
    partial class Emailmuvelet
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBL_warning1 = new System.Windows.Forms.Label();
            this.LBL_warning2 = new System.Windows.Forms.Label();
            this.TB_actualsysemail = new System.Windows.Forms.TextBox();
            this.TB_actualsenderemail = new System.Windows.Forms.TextBox();
            this.TB_actualsenderpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_newsenderpassword = new System.Windows.Forms.TextBox();
            this.TB_newsenderemail = new System.Windows.Forms.TextBox();
            this.TB_newsysemail = new System.Windows.Forms.TextBox();
            this.BT_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(134, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Értesítő e-mail cím jelszava:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(203, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "Értesítő e-mail cím:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(134, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Rendszergazda e-mail címe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(344, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "Aktuális adatok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(373, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Új adatok";
            // 
            // LBL_warning1
            // 
            this.LBL_warning1.AutoSize = true;
            this.LBL_warning1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_warning1.Location = new System.Drawing.Point(213, 9);
            this.LBL_warning1.Name = "LBL_warning1";
            this.LBL_warning1.Size = new System.Drawing.Size(368, 20);
            this.LBL_warning1.TabIndex = 47;
            this.LBL_warning1.Text = "Figyelem! Az értesítő e-mail csak gmailes cím lehet!";
            // 
            // LBL_warning2
            // 
            this.LBL_warning2.AutoSize = true;
            this.LBL_warning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_warning2.Location = new System.Drawing.Point(101, 29);
            this.LBL_warning2.Name = "LBL_warning2";
            this.LBL_warning2.Size = new System.Drawing.Size(561, 13);
            this.LBL_warning2.TabIndex = 48;
            this.LBL_warning2.Text = "Amennyiben a rendszergazda nem igényel értesítést, úgy az értesítő e-mail legyen " +
    "beírva rendszergazdai e-mailnak is!";
            // 
            // TB_actualsysemail
            // 
            this.TB_actualsysemail.Enabled = false;
            this.TB_actualsysemail.Location = new System.Drawing.Point(370, 107);
            this.TB_actualsysemail.Name = "TB_actualsysemail";
            this.TB_actualsysemail.Size = new System.Drawing.Size(211, 20);
            this.TB_actualsysemail.TabIndex = 49;
            // 
            // TB_actualsenderemail
            // 
            this.TB_actualsenderemail.Enabled = false;
            this.TB_actualsenderemail.Location = new System.Drawing.Point(370, 133);
            this.TB_actualsenderemail.Name = "TB_actualsenderemail";
            this.TB_actualsenderemail.Size = new System.Drawing.Size(211, 20);
            this.TB_actualsenderemail.TabIndex = 50;
            // 
            // TB_actualsenderpassword
            // 
            this.TB_actualsenderpassword.Enabled = false;
            this.TB_actualsenderpassword.Location = new System.Drawing.Point(370, 159);
            this.TB_actualsenderpassword.Name = "TB_actualsenderpassword";
            this.TB_actualsenderpassword.Size = new System.Drawing.Size(211, 20);
            this.TB_actualsenderpassword.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(134, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "Értesítő e-mail cím jelszava:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(203, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Értesítő e-mail cím:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(134, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Rendszergazda e-mail címe:";
            // 
            // TB_newsenderpassword
            // 
            this.TB_newsenderpassword.Location = new System.Drawing.Point(370, 303);
            this.TB_newsenderpassword.Name = "TB_newsenderpassword";
            this.TB_newsenderpassword.Size = new System.Drawing.Size(211, 20);
            this.TB_newsenderpassword.TabIndex = 57;
            // 
            // TB_newsenderemail
            // 
            this.TB_newsenderemail.Location = new System.Drawing.Point(370, 277);
            this.TB_newsenderemail.Name = "TB_newsenderemail";
            this.TB_newsenderemail.Size = new System.Drawing.Size(211, 20);
            this.TB_newsenderemail.TabIndex = 56;
            // 
            // TB_newsysemail
            // 
            this.TB_newsysemail.Location = new System.Drawing.Point(370, 251);
            this.TB_newsysemail.Name = "TB_newsysemail";
            this.TB_newsysemail.Size = new System.Drawing.Size(211, 20);
            this.TB_newsysemail.TabIndex = 55;
            // 
            // BT_change
            // 
            this.BT_change.Location = new System.Drawing.Point(394, 329);
            this.BT_change.Name = "BT_change";
            this.BT_change.Size = new System.Drawing.Size(145, 23);
            this.BT_change.TabIndex = 58;
            this.BT_change.Text = "Adatok megváltoztatása";
            this.BT_change.UseVisualStyleBackColor = true;
            this.BT_change.Click += new System.EventHandler(this.BT_change_Click);
            // 
            // Emailmuvelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_change);
            this.Controls.Add(this.TB_newsenderpassword);
            this.Controls.Add(this.TB_newsenderemail);
            this.Controls.Add(this.TB_newsysemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_actualsenderpassword);
            this.Controls.Add(this.TB_actualsenderemail);
            this.Controls.Add(this.TB_actualsysemail);
            this.Controls.Add(this.LBL_warning2);
            this.Controls.Add(this.LBL_warning1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BT_back);
            this.Name = "Emailmuvelet";
            this.Text = "Emailmuvelet";
            this.Load += new System.EventHandler(this.Emailmuvelet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBL_warning1;
        private System.Windows.Forms.Label LBL_warning2;
        private System.Windows.Forms.TextBox TB_actualsysemail;
        private System.Windows.Forms.TextBox TB_actualsenderemail;
        private System.Windows.Forms.TextBox TB_actualsenderpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_newsenderpassword;
        private System.Windows.Forms.TextBox TB_newsenderemail;
        private System.Windows.Forms.TextBox TB_newsysemail;
        private System.Windows.Forms.Button BT_change;
    }
}