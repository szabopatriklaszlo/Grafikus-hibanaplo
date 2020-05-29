namespace Grafikus_hibanaplo
{
    partial class felhasznaloibejelento
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
            this.RB_computererror = new System.Windows.Forms.RadioButton();
            this.RB_networkerror = new System.Windows.Forms.RadioButton();
            this.RB_othererror = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DTP_dateofperception = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_nameofreporter = new System.Windows.Forms.TextBox();
            this.TB_emailofreporter = new System.Windows.Forms.TextBox();
            this.TB_phonenumberofreporter = new System.Windows.Forms.TextBox();
            this.TB_timeofperception = new System.Windows.Forms.TextBox();
            this.TB_longreport = new System.Windows.Forms.TextBox();
            this.BT_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Töltse ki az űrlapot, kérem 1 mezőt se hagyjon üresen!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(49, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bejelentés típúsa:";
            // 
            // RB_computererror
            // 
            this.RB_computererror.AutoSize = true;
            this.RB_computererror.Location = new System.Drawing.Point(179, 57);
            this.RB_computererror.Name = "RB_computererror";
            this.RB_computererror.Size = new System.Drawing.Size(188, 17);
            this.RB_computererror.TabIndex = 2;
            this.RB_computererror.TabStop = true;
            this.RB_computererror.Text = "Számítógép hibájának bejelentése";
            this.RB_computererror.UseVisualStyleBackColor = true;
            // 
            // RB_networkerror
            // 
            this.RB_networkerror.AutoSize = true;
            this.RB_networkerror.Location = new System.Drawing.Point(404, 57);
            this.RB_networkerror.Name = "RB_networkerror";
            this.RB_networkerror.Size = new System.Drawing.Size(143, 17);
            this.RB_networkerror.TabIndex = 3;
            this.RB_networkerror.TabStop = true;
            this.RB_networkerror.Text = "Hálózati hiba bejelentése";
            this.RB_networkerror.UseVisualStyleBackColor = true;
            // 
            // RB_othererror
            // 
            this.RB_othererror.AutoSize = true;
            this.RB_othererror.Location = new System.Drawing.Point(600, 57);
            this.RB_othererror.Name = "RB_othererror";
            this.RB_othererror.Size = new System.Drawing.Size(78, 17);
            this.RB_othererror.TabIndex = 4;
            this.RB_othererror.TabStop = true;
            this.RB_othererror.Text = "Egyéb hiba";
            this.RB_othererror.UseVisualStyleBackColor = true;
            this.RB_othererror.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RB_othererror_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(49, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bejelentő neve:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(49, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bejelentő email-címe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(176, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(462, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amennyiben egy adatot nem akar megadni, úgy egy \"-\" jellel jelezze azt.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(49, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bejelentő telefonszáma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(49, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Észlelés napja:";
            // 
            // DTP_dateofperception
            // 
            this.DTP_dateofperception.Location = new System.Drawing.Point(158, 184);
            this.DTP_dateofperception.Name = "DTP_dateofperception";
            this.DTP_dateofperception.Size = new System.Drawing.Size(200, 20);
            this.DTP_dateofperception.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(49, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Észlelés ideje:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(49, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "A hiba részletes leírása:";
            // 
            // TB_nameofreporter
            // 
            this.TB_nameofreporter.Location = new System.Drawing.Point(161, 86);
            this.TB_nameofreporter.Name = "TB_nameofreporter";
            this.TB_nameofreporter.Size = new System.Drawing.Size(236, 20);
            this.TB_nameofreporter.TabIndex = 13;
            // 
            // TB_emailofreporter
            // 
            this.TB_emailofreporter.Location = new System.Drawing.Point(197, 117);
            this.TB_emailofreporter.Name = "TB_emailofreporter";
            this.TB_emailofreporter.Size = new System.Drawing.Size(100, 20);
            this.TB_emailofreporter.TabIndex = 14;
            // 
            // TB_phonenumberofreporter
            // 
            this.TB_phonenumberofreporter.Location = new System.Drawing.Point(214, 148);
            this.TB_phonenumberofreporter.Name = "TB_phonenumberofreporter";
            this.TB_phonenumberofreporter.Size = new System.Drawing.Size(100, 20);
            this.TB_phonenumberofreporter.TabIndex = 15;
            // 
            // TB_timeofperception
            // 
            this.TB_timeofperception.Location = new System.Drawing.Point(158, 218);
            this.TB_timeofperception.Name = "TB_timeofperception";
            this.TB_timeofperception.Size = new System.Drawing.Size(100, 20);
            this.TB_timeofperception.TabIndex = 16;
            // 
            // TB_longreport
            // 
            this.TB_longreport.Location = new System.Drawing.Point(52, 289);
            this.TB_longreport.Multiline = true;
            this.TB_longreport.Name = "TB_longreport";
            this.TB_longreport.Size = new System.Drawing.Size(717, 120);
            this.TB_longreport.TabIndex = 17;
            // 
            // BT_report
            // 
            this.BT_report.Location = new System.Drawing.Point(366, 415);
            this.BT_report.Name = "BT_report";
            this.BT_report.Size = new System.Drawing.Size(75, 23);
            this.BT_report.TabIndex = 18;
            this.BT_report.Text = "Bejelentés";
            this.BT_report.UseVisualStyleBackColor = true;
            this.BT_report.Click += new System.EventHandler(this.BT_report_Click);
            // 
            // felhasznaloibejelento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_report);
            this.Controls.Add(this.TB_longreport);
            this.Controls.Add(this.TB_timeofperception);
            this.Controls.Add(this.TB_phonenumberofreporter);
            this.Controls.Add(this.TB_emailofreporter);
            this.Controls.Add(this.TB_nameofreporter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTP_dateofperception);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RB_othererror);
            this.Controls.Add(this.RB_networkerror);
            this.Controls.Add(this.RB_computererror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "felhasznaloibejelento";
            this.Text = "Felhasználói hiba bejelentő felület";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RB_computererror;
        private System.Windows.Forms.RadioButton RB_networkerror;
        private System.Windows.Forms.RadioButton RB_othererror;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTP_dateofperception;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_nameofreporter;
        private System.Windows.Forms.TextBox TB_emailofreporter;
        private System.Windows.Forms.TextBox TB_phonenumberofreporter;
        private System.Windows.Forms.TextBox TB_timeofperception;
        private System.Windows.Forms.TextBox TB_longreport;
        private System.Windows.Forms.Button BT_report;
    }
}