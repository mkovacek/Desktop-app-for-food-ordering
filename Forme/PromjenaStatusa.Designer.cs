namespace eNarudžba.Forme
{
    partial class PromjenaStatusa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromjenaStatusa));
            this.btnPromijeniStatus = new System.Windows.Forms.Button();
            this.rdbNarudzbaZaprimljena = new System.Windows.Forms.RadioButton();
            this.rdbNarudzbaNaRedu = new System.Windows.Forms.RadioButton();
            this.rdbNarudzbaGotova = new System.Windows.Forms.RadioButton();
            this.rdbDostavljaSe = new System.Windows.Forms.RadioButton();
            this.rdbDostavljena = new System.Windows.Forms.RadioButton();
            this.lblNarudzbaDOstavljena = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPromijeniStatus
            // 
            this.btnPromijeniStatus.BackColor = System.Drawing.Color.White;
            this.btnPromijeniStatus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPromijeniStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromijeniStatus.Location = new System.Drawing.Point(178, 261);
            this.btnPromijeniStatus.Name = "btnPromijeniStatus";
            this.btnPromijeniStatus.Size = new System.Drawing.Size(117, 23);
            this.btnPromijeniStatus.TabIndex = 10;
            this.btnPromijeniStatus.Text = "Promijeni status";
            this.toolTip1.SetToolTip(this.btnPromijeniStatus, "Gumb za promjenu statusa.\r\nPrije potvrde potrebno je odabrati status.");
            this.btnPromijeniStatus.UseVisualStyleBackColor = false;
            this.btnPromijeniStatus.Click += new System.EventHandler(this.btnPromijeniStatus_Click);
            // 
            // rdbNarudzbaZaprimljena
            // 
            this.rdbNarudzbaZaprimljena.AutoSize = true;
            this.rdbNarudzbaZaprimljena.BackColor = System.Drawing.Color.Transparent;
            this.rdbNarudzbaZaprimljena.ForeColor = System.Drawing.Color.White;
            this.rdbNarudzbaZaprimljena.Location = new System.Drawing.Point(35, 58);
            this.rdbNarudzbaZaprimljena.Name = "rdbNarudzbaZaprimljena";
            this.rdbNarudzbaZaprimljena.Size = new System.Drawing.Size(137, 17);
            this.rdbNarudzbaZaprimljena.TabIndex = 11;
            this.rdbNarudzbaZaprimljena.TabStop = true;
            this.rdbNarudzbaZaprimljena.Text = "Narudžba je zaprimljena";
            this.rdbNarudzbaZaprimljena.UseVisualStyleBackColor = false;
            // 
            // rdbNarudzbaNaRedu
            // 
            this.rdbNarudzbaNaRedu.AutoSize = true;
            this.rdbNarudzbaNaRedu.BackColor = System.Drawing.Color.Transparent;
            this.rdbNarudzbaNaRedu.ForeColor = System.Drawing.Color.White;
            this.rdbNarudzbaNaRedu.Location = new System.Drawing.Point(35, 101);
            this.rdbNarudzbaNaRedu.Name = "rdbNarudzbaNaRedu";
            this.rdbNarudzbaNaRedu.Size = new System.Drawing.Size(121, 17);
            this.rdbNarudzbaNaRedu.TabIndex = 12;
            this.rdbNarudzbaNaRedu.TabStop = true;
            this.rdbNarudzbaNaRedu.Text = "Narudžba je na redu";
            this.rdbNarudzbaNaRedu.UseVisualStyleBackColor = false;
            // 
            // rdbNarudzbaGotova
            // 
            this.rdbNarudzbaGotova.AutoSize = true;
            this.rdbNarudzbaGotova.BackColor = System.Drawing.Color.Transparent;
            this.rdbNarudzbaGotova.ForeColor = System.Drawing.Color.White;
            this.rdbNarudzbaGotova.Location = new System.Drawing.Point(35, 145);
            this.rdbNarudzbaGotova.Name = "rdbNarudzbaGotova";
            this.rdbNarudzbaGotova.Size = new System.Drawing.Size(118, 17);
            this.rdbNarudzbaGotova.TabIndex = 13;
            this.rdbNarudzbaGotova.TabStop = true;
            this.rdbNarudzbaGotova.Text = "Narudžba je gotova";
            this.rdbNarudzbaGotova.UseVisualStyleBackColor = false;
            // 
            // rdbDostavljaSe
            // 
            this.rdbDostavljaSe.AutoSize = true;
            this.rdbDostavljaSe.BackColor = System.Drawing.Color.Transparent;
            this.rdbDostavljaSe.ForeColor = System.Drawing.Color.White;
            this.rdbDostavljaSe.Location = new System.Drawing.Point(35, 187);
            this.rdbDostavljaSe.Name = "rdbDostavljaSe";
            this.rdbDostavljaSe.Size = new System.Drawing.Size(83, 17);
            this.rdbDostavljaSe.TabIndex = 14;
            this.rdbDostavljaSe.TabStop = true;
            this.rdbDostavljaSe.Text = "Dostavlja se";
            this.rdbDostavljaSe.UseVisualStyleBackColor = false;
            // 
            // rdbDostavljena
            // 
            this.rdbDostavljena.AutoSize = true;
            this.rdbDostavljena.BackColor = System.Drawing.Color.Transparent;
            this.rdbDostavljena.ForeColor = System.Drawing.Color.White;
            this.rdbDostavljena.Location = new System.Drawing.Point(35, 229);
            this.rdbDostavljena.Name = "rdbDostavljena";
            this.rdbDostavljena.Size = new System.Drawing.Size(81, 17);
            this.rdbDostavljena.TabIndex = 15;
            this.rdbDostavljena.TabStop = true;
            this.rdbDostavljena.Text = "Dostavljena";
            this.rdbDostavljena.UseVisualStyleBackColor = false;
            // 
            // lblNarudzbaDOstavljena
            // 
            this.lblNarudzbaDOstavljena.AutoSize = true;
            this.lblNarudzbaDOstavljena.BackColor = System.Drawing.Color.Transparent;
            this.lblNarudzbaDOstavljena.ForeColor = System.Drawing.Color.White;
            this.lblNarudzbaDOstavljena.Location = new System.Drawing.Point(32, 42);
            this.lblNarudzbaDOstavljena.Name = "lblNarudzbaDOstavljena";
            this.lblNarudzbaDOstavljena.Size = new System.Drawing.Size(121, 13);
            this.lblNarudzbaDOstavljena.TabIndex = 16;
            this.lblNarudzbaDOstavljena.Text = "Narudžba je dostavljena";
            this.toolTip1.SetToolTip(this.lblNarudzbaDOstavljena, "Narudžba je dostavljena.\r\nViše se nemože mijenjati status narudžbe.");
            this.lblNarudzbaDOstavljena.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Minimiziranje forme");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(276, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Zatvaranje forme");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PromjenaStatusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(307, 296);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNarudzbaDOstavljena);
            this.Controls.Add(this.rdbDostavljena);
            this.Controls.Add(this.rdbDostavljaSe);
            this.Controls.Add(this.rdbNarudzbaGotova);
            this.Controls.Add(this.rdbNarudzbaNaRedu);
            this.Controls.Add(this.rdbNarudzbaZaprimljena);
            this.Controls.Add(this.btnPromijeniStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PromjenaStatusa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PromjenaStatusa";
            this.Load += new System.EventHandler(this.PromjenaStatusa_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PromjenaStatusa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PromjenaStatusa_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPromijeniStatus;
        private System.Windows.Forms.RadioButton rdbNarudzbaZaprimljena;
        private System.Windows.Forms.RadioButton rdbNarudzbaNaRedu;
        private System.Windows.Forms.RadioButton rdbNarudzbaGotova;
        private System.Windows.Forms.RadioButton rdbDostavljaSe;
        private System.Windows.Forms.RadioButton rdbDostavljena;
        private System.Windows.Forms.Label lblNarudzbaDOstavljena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}