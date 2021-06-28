
namespace Tubes_KPL
{
    partial class Dashboard
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
            this.buttonInputKue = new System.Windows.Forms.Button();
            this.buttonPembeli = new System.Windows.Forms.Button();
            this.buttonTransaksi = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BON BON CAKERY";
            // 
            // buttonInputKue
            // 
            this.buttonInputKue.Location = new System.Drawing.Point(128, 263);
            this.buttonInputKue.Name = "buttonInputKue";
            this.buttonInputKue.Size = new System.Drawing.Size(75, 23);
            this.buttonInputKue.TabIndex = 1;
            this.buttonInputKue.Text = "Input Kue";
            this.buttonInputKue.UseVisualStyleBackColor = true;
            this.buttonInputKue.Click += new System.EventHandler(this.buttonInputKue_Click);
            // 
            // buttonPembeli
            // 
            this.buttonPembeli.Location = new System.Drawing.Point(349, 263);
            this.buttonPembeli.Name = "buttonPembeli";
            this.buttonPembeli.Size = new System.Drawing.Size(75, 23);
            this.buttonPembeli.TabIndex = 2;
            this.buttonPembeli.Text = "Pembeli";
            this.buttonPembeli.UseVisualStyleBackColor = true;
            this.buttonPembeli.Click += new System.EventHandler(this.buttonPembeli_Click);
            // 
            // buttonTransaksi
            // 
            this.buttonTransaksi.Location = new System.Drawing.Point(563, 263);
            this.buttonTransaksi.Name = "buttonTransaksi";
            this.buttonTransaksi.Size = new System.Drawing.Size(75, 23);
            this.buttonTransaksi.TabIndex = 3;
            this.buttonTransaksi.Text = "Transaksi";
            this.buttonTransaksi.UseVisualStyleBackColor = true;
            this.buttonTransaksi.Click += new System.EventHandler(this.buttonTransaksi_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(349, 401);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonTransaksi);
            this.Controls.Add(this.buttonPembeli);
            this.Controls.Add(this.buttonInputKue);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInputKue;
        private System.Windows.Forms.Button buttonPembeli;
        private System.Windows.Forms.Button buttonTransaksi;
        private System.Windows.Forms.Button buttonLogout;
    }
}