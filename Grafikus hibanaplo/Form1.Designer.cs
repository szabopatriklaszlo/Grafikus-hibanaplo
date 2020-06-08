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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_sysadmin = new System.Windows.Forms.Button();
            this.BT_user = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(781, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kérem válasszon, hogy felhasználóként vagy rendszergazdaként szeretne bejelentkez" +
    "ni!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Üdvözlöm a hibanapló szoftverben!";
            // 
            // BT_sysadmin
            // 
            this.BT_sysadmin.BackgroundImage = global::Grafikus_hibanaplo.Properties.Resources.kisspng_computer_icons_login_user_system_administrator_ima_editing_mafsyah_template_5b75843a7b1045_0356392015344282185041;
            this.BT_sysadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_sysadmin.FlatAppearance.BorderSize = 0;
            this.BT_sysadmin.Location = new System.Drawing.Point(499, 197);
            this.BT_sysadmin.Name = "BT_sysadmin";
            this.BT_sysadmin.Size = new System.Drawing.Size(195, 184);
            this.BT_sysadmin.TabIndex = 1;
            this.BT_sysadmin.UseVisualStyleBackColor = true;
            this.BT_sysadmin.Click += new System.EventHandler(this.BT_sysadmin_Click);
            // 
            // BT_user
            // 
            this.BT_user.BackColor = System.Drawing.SystemColors.Control;
            this.BT_user.BackgroundImage = global::Grafikus_hibanaplo.Properties.Resources.avat_01_512;
            this.BT_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_user.FlatAppearance.BorderSize = 0;
            this.BT_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_user.Location = new System.Drawing.Point(115, 197);
            this.BT_user.Name = "BT_user";
            this.BT_user.Size = new System.Drawing.Size(195, 184);
            this.BT_user.TabIndex = 0;
            this.BT_user.UseVisualStyleBackColor = false;
            this.BT_user.Click += new System.EventHandler(this.BT_user_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Felhasználó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rendszergazda";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

