namespace PROJEKK
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
            this.PANELCONTROL = new System.Windows.Forms.Panel();
            this.btnKaryawan = new FontAwesome.Sharp.IconButton();
            this.panelDekstop = new System.Windows.Forms.Panel();
            this.PANELCONTROL.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANELCONTROL
            // 
            this.PANELCONTROL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PANELCONTROL.BackColor = System.Drawing.Color.Silver;
            this.PANELCONTROL.Controls.Add(this.btnKaryawan);
            this.PANELCONTROL.Location = new System.Drawing.Point(-1, -3);
            this.PANELCONTROL.Name = "PANELCONTROL";
            this.PANELCONTROL.Size = new System.Drawing.Size(268, 565);
            this.PANELCONTROL.TabIndex = 0;
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaryawan.FlatAppearance.BorderSize = 0;
            this.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaryawan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnKaryawan.IconColor = System.Drawing.Color.Black;
            this.btnKaryawan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKaryawan.Location = new System.Drawing.Point(13, 118);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(247, 64);
            this.btnKaryawan.TabIndex = 0;
            this.btnKaryawan.Text = "Karyawan";
            this.btnKaryawan.UseVisualStyleBackColor = true;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // panelDekstop
            // 
            this.panelDekstop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDekstop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(227)))));
            this.panelDekstop.Location = new System.Drawing.Point(265, -3);
            this.panelDekstop.Name = "panelDekstop";
            this.panelDekstop.Size = new System.Drawing.Size(806, 626);
            this.panelDekstop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 560);
            this.Controls.Add(this.panelDekstop);
            this.Controls.Add(this.PANELCONTROL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PANELCONTROL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANELCONTROL;
        private System.Windows.Forms.Panel panelDekstop;
        private FontAwesome.Sharp.IconButton btnKaryawan;
    }
}

