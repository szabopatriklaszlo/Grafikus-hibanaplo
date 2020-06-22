namespace Grafikus_hibanaplo
{
    partial class Rendszergazdavalasztofelulet
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
            this.BT_emailsystem = new System.Windows.Forms.Button();
            this.BT_createuser = new System.Windows.Forms.Button();
            this.BT_deleteuser = new System.Windows.Forms.Button();
            this.BT_showreports = new System.Windows.Forms.Button();
            this.BT_showclosedreports = new System.Windows.Forms.Button();
            this.BT_showactualsysadmins = new System.Windows.Forms.Button();
            this.BT_showactualusers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(185, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üdvözlöm a rendszergazdai felületen!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(255, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kérem válassza ki a kívánt műveletet!";
            // 
            // BT_emailsystem
            // 
            this.BT_emailsystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_emailsystem.Location = new System.Drawing.Point(116, 165);
            this.BT_emailsystem.Name = "BT_emailsystem";
            this.BT_emailsystem.Size = new System.Drawing.Size(180, 116);
            this.BT_emailsystem.TabIndex = 2;
            this.BT_emailsystem.Text = "E-mail értesítő rendszer kezelése";
            this.BT_emailsystem.UseVisualStyleBackColor = true;
            this.BT_emailsystem.Click += new System.EventHandler(this.BT_emailsystem_Click_1);
            // 
            // BT_createuser
            // 
            this.BT_createuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_createuser.Location = new System.Drawing.Point(302, 165);
            this.BT_createuser.Name = "BT_createuser";
            this.BT_createuser.Size = new System.Drawing.Size(180, 55);
            this.BT_createuser.TabIndex = 5;
            this.BT_createuser.Text = "Felhasználói fiók létrehozása";
            this.BT_createuser.UseVisualStyleBackColor = true;
            this.BT_createuser.Click += new System.EventHandler(this.BT_createuser_Click);
            // 
            // BT_deleteuser
            // 
            this.BT_deleteuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_deleteuser.Location = new System.Drawing.Point(302, 226);
            this.BT_deleteuser.Name = "BT_deleteuser";
            this.BT_deleteuser.Size = new System.Drawing.Size(180, 55);
            this.BT_deleteuser.TabIndex = 6;
            this.BT_deleteuser.Text = "Felhasználói fiók törlése";
            this.BT_deleteuser.UseVisualStyleBackColor = true;
            this.BT_deleteuser.Click += new System.EventHandler(this.BT_deleteuser_Click);
            // 
            // BT_showreports
            // 
            this.BT_showreports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_showreports.Location = new System.Drawing.Point(488, 165);
            this.BT_showreports.Name = "BT_showreports";
            this.BT_showreports.Size = new System.Drawing.Size(180, 55);
            this.BT_showreports.TabIndex = 7;
            this.BT_showreports.Text = "Aktuális hibák megtekintése";
            this.BT_showreports.UseVisualStyleBackColor = true;
            this.BT_showreports.Click += new System.EventHandler(this.BT_showreports_Click);
            // 
            // BT_showclosedreports
            // 
            this.BT_showclosedreports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_showclosedreports.Location = new System.Drawing.Point(488, 226);
            this.BT_showclosedreports.Name = "BT_showclosedreports";
            this.BT_showclosedreports.Size = new System.Drawing.Size(180, 55);
            this.BT_showclosedreports.TabIndex = 8;
            this.BT_showclosedreports.Text = "Lezárt hibák megtekintése";
            this.BT_showclosedreports.UseVisualStyleBackColor = true;
            this.BT_showclosedreports.Click += new System.EventHandler(this.BT_showclosedreports_Click);
            // 
            // BT_showactualsysadmins
            // 
            this.BT_showactualsysadmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_showactualsysadmins.Location = new System.Drawing.Point(116, 348);
            this.BT_showactualsysadmins.Name = "BT_showactualsysadmins";
            this.BT_showactualsysadmins.Size = new System.Drawing.Size(552, 55);
            this.BT_showactualsysadmins.TabIndex = 9;
            this.BT_showactualsysadmins.Text = "Aktuális rendszergazdai fiókok megtekintése";
            this.BT_showactualsysadmins.UseVisualStyleBackColor = true;
            this.BT_showactualsysadmins.Click += new System.EventHandler(this.BT_showactualsysadmins_Click);
            // 
            // BT_showactualusers
            // 
            this.BT_showactualusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BT_showactualusers.Location = new System.Drawing.Point(116, 287);
            this.BT_showactualusers.Name = "BT_showactualusers";
            this.BT_showactualusers.Size = new System.Drawing.Size(552, 55);
            this.BT_showactualusers.TabIndex = 10;
            this.BT_showactualusers.Text = "Aktuális felhasználói fiókok megtekintése";
            this.BT_showactualusers.UseVisualStyleBackColor = true;
            this.BT_showactualusers.Click += new System.EventHandler(this.BT_showactualusers_Click);
            // 
            // Rendszergazdavalasztofelulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_showactualusers);
            this.Controls.Add(this.BT_showactualsysadmins);
            this.Controls.Add(this.BT_showclosedreports);
            this.Controls.Add(this.BT_showreports);
            this.Controls.Add(this.BT_deleteuser);
            this.Controls.Add(this.BT_createuser);
            this.Controls.Add(this.BT_emailsystem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rendszergazdavalasztofelulet";
            this.Text = "Rendszergazdai választó felület";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_emailsystem;
        private System.Windows.Forms.Button BT_createuser;
        private System.Windows.Forms.Button BT_deleteuser;
        private System.Windows.Forms.Button BT_showreports;
        private System.Windows.Forms.Button BT_showclosedreports;
        private System.Windows.Forms.Button BT_showactualsysadmins;
        private System.Windows.Forms.Button BT_showactualusers;
    }
}