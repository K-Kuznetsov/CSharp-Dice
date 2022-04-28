namespace Täring
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
            this.btnJuku = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPeeter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPunktid1 = new System.Windows.Forms.Label();
            this.lblRandom1 = new System.Windows.Forms.Label();
            this.lblRandom2 = new System.Windows.Forms.Label();
            this.lblPunktid2 = new System.Windows.Forms.Label();
            this.lblRandom3 = new System.Windows.Forms.Label();
            this.lblRandom4 = new System.Windows.Forms.Label();
            this.lblTulemus = new System.Windows.Forms.Label();
            this.pilt1 = new System.Windows.Forms.PictureBox();
            this.pilt2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pilt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJuku
            // 
            this.btnJuku.BackColor = System.Drawing.Color.SteelBlue;
            this.btnJuku.FlatAppearance.BorderSize = 0;
            this.btnJuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnJuku.ForeColor = System.Drawing.Color.White;
            this.btnJuku.Location = new System.Drawing.Point(40, 300);
            this.btnJuku.Margin = new System.Windows.Forms.Padding(0);
            this.btnJuku.Name = "btnJuku";
            this.btnJuku.Size = new System.Drawing.Size(250, 50);
            this.btnJuku.TabIndex = 0;
            this.btnJuku.Text = "Mängib Juku";
            this.btnJuku.UseVisualStyleBackColor = false;
            this.btnJuku.Click += new System.EventHandler(this.btnJuku_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.OliveDrab;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStart.ForeColor = System.Drawing.Color.Snow;
            this.btnStart.Location = new System.Drawing.Point(472, 351);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(250, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Alusta uut mängu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPeeter
            // 
            this.btnPeeter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPeeter.FlatAppearance.BorderSize = 0;
            this.btnPeeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPeeter.ForeColor = System.Drawing.Color.White;
            this.btnPeeter.Location = new System.Drawing.Point(912, 300);
            this.btnPeeter.Margin = new System.Windows.Forms.Padding(0);
            this.btnPeeter.Name = "btnPeeter";
            this.btnPeeter.Size = new System.Drawing.Size(250, 50);
            this.btnPeeter.TabIndex = 2;
            this.btnPeeter.Text = "Mängib Peeter";
            this.btnPeeter.UseVisualStyleBackColor = false;
            this.btnPeeter.Click += new System.EventHandler(this.btnPeeter_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(72, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Esimene mängija";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(113, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Juku";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(100, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Punktid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(967, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teine mängija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(1002, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Peeter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(1002, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Punktid";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(314, 469);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "Tulemus";
            // 
            // lblPunktid1
            // 
            this.lblPunktid1.BackColor = System.Drawing.Color.White;
            this.lblPunktid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPunktid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPunktid1.ForeColor = System.Drawing.Color.Green;
            this.lblPunktid1.Location = new System.Drawing.Point(37, 135);
            this.lblPunktid1.Name = "lblPunktid1";
            this.lblPunktid1.Size = new System.Drawing.Size(250, 50);
            this.lblPunktid1.TabIndex = 10;
            this.lblPunktid1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRandom1
            // 
            this.lblRandom1.BackColor = System.Drawing.Color.White;
            this.lblRandom1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRandom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRandom1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRandom1.Location = new System.Drawing.Point(58, 214);
            this.lblRandom1.Name = "lblRandom1";
            this.lblRandom1.Size = new System.Drawing.Size(60, 60);
            this.lblRandom1.TabIndex = 11;
            this.lblRandom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRandom2
            // 
            this.lblRandom2.BackColor = System.Drawing.Color.White;
            this.lblRandom2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRandom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRandom2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRandom2.Location = new System.Drawing.Point(186, 216);
            this.lblRandom2.Name = "lblRandom2";
            this.lblRandom2.Size = new System.Drawing.Size(60, 60);
            this.lblRandom2.TabIndex = 12;
            this.lblRandom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPunktid2
            // 
            this.lblPunktid2.BackColor = System.Drawing.Color.White;
            this.lblPunktid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPunktid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPunktid2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPunktid2.Location = new System.Drawing.Point(912, 135);
            this.lblPunktid2.Name = "lblPunktid2";
            this.lblPunktid2.Size = new System.Drawing.Size(250, 50);
            this.lblPunktid2.TabIndex = 13;
            this.lblPunktid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRandom3
            // 
            this.lblRandom3.BackColor = System.Drawing.Color.White;
            this.lblRandom3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRandom3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRandom3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRandom3.Location = new System.Drawing.Point(939, 214);
            this.lblRandom3.Name = "lblRandom3";
            this.lblRandom3.Size = new System.Drawing.Size(60, 60);
            this.lblRandom3.TabIndex = 14;
            this.lblRandom3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRandom4
            // 
            this.lblRandom4.BackColor = System.Drawing.Color.White;
            this.lblRandom4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRandom4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRandom4.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRandom4.Location = new System.Drawing.Point(1067, 214);
            this.lblRandom4.Name = "lblRandom4";
            this.lblRandom4.Size = new System.Drawing.Size(60, 60);
            this.lblRandom4.TabIndex = 15;
            this.lblRandom4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTulemus
            // 
            this.lblTulemus.BackColor = System.Drawing.Color.White;
            this.lblTulemus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTulemus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTulemus.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTulemus.Location = new System.Drawing.Point(433, 456);
            this.lblTulemus.Name = "lblTulemus";
            this.lblTulemus.Size = new System.Drawing.Size(400, 50);
            this.lblTulemus.TabIndex = 16;
            this.lblTulemus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pilt1
            // 
            this.pilt1.Location = new System.Drawing.Point(319, 28);
            this.pilt1.Name = "pilt1";
            this.pilt1.Size = new System.Drawing.Size(256, 256);
            this.pilt1.TabIndex = 17;
            this.pilt1.TabStop = false;
            // 
            // pilt2
            // 
            this.pilt2.Location = new System.Drawing.Point(622, 28);
            this.pilt2.Name = "pilt2";
            this.pilt2.Size = new System.Drawing.Size(256, 256);
            this.pilt2.TabIndex = 18;
            this.pilt2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1201, 561);
            this.Controls.Add(this.pilt2);
            this.Controls.Add(this.pilt1);
            this.Controls.Add(this.lblTulemus);
            this.Controls.Add(this.lblRandom4);
            this.Controls.Add(this.lblRandom3);
            this.Controls.Add(this.lblPunktid2);
            this.Controls.Add(this.lblRandom2);
            this.Controls.Add(this.lblRandom1);
            this.Controls.Add(this.lblPunktid1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPeeter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnJuku);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pilt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJuku;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPeeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPunktid1;
        private System.Windows.Forms.Label lblRandom1;
        private System.Windows.Forms.Label lblRandom2;
        private System.Windows.Forms.Label lblPunktid2;
        private System.Windows.Forms.Label lblRandom3;
        private System.Windows.Forms.Label lblRandom4;
        private System.Windows.Forms.Label lblTulemus;
        private System.Windows.Forms.PictureBox pilt1;
        private System.Windows.Forms.PictureBox pilt2;
    }
}

