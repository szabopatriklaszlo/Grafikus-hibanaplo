namespace Grafikus_hibanaplo
{
    partial class Start
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
            this.BT_user = new System.Windows.Forms.Button();
            this.BT_sysadmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_user
            // 
            this.BT_user.Location = new System.Drawing.Point(67, 188);
            this.BT_user.Name = "BT_user";
            this.BT_user.Size = new System.Drawing.Size(195, 184);
            this.BT_user.TabIndex = 0;
            this.BT_user.Text = "Felhasználó";
            this.BT_user.UseVisualStyleBackColor = true;
            this.BT_user.Click += new System.EventHandler(this.BT_user_Click);
            // 
            // BT_sysadmin
            // 
            this.BT_sysadmin.Location = new System.Drawing.Point(477, 188);
            this.BT_sysadmin.Name = "BT_sysadmin";
            this.BT_sysadmin.Size = new System.Drawing.Size(195, 184);
            this.BT_sysadmin.TabIndex = 1;
            this.BT_sysadmin.Text = "Rendszergazda";
            this.BT_sysadmin.UseVisualStyleBackColor = true;
            this.BT_sysadmin.Click += new System.EventHandler(this.BT_sysadmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(781, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kérem válasszon, hogy rendszergazdaként vagy felhasználóként szeretne bejelentkez" +
    "ni!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(210, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Üdvözlöm a hibanapló szoftverben!";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_sysadmin);
            this.Controls.Add(this.BT_user);
            this.Name = "Start";
            this.Text = "Hibanapló - Hozzáférési mód választó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_user;
        private System.Windows.Forms.Button BT_sysadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

