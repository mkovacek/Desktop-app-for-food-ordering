namespace eNarudžba.Forme
{
    partial class GlavnaFormaNarucitelj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaFormaNarucitelj));
            this.btnPonudaJelovnika = new System.Windows.Forms.Button();
            this.btnPovijestNarudžbi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPonudaJelovnika
            // 
            this.btnPonudaJelovnika.BackColor = System.Drawing.Color.White;
            this.btnPonudaJelovnika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPonudaJelovnika.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPonudaJelovnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonudaJelovnika.Location = new System.Drawing.Point(53, 56);
            this.btnPonudaJelovnika.Name = "btnPonudaJelovnika";
            this.btnPonudaJelovnika.Size = new System.Drawing.Size(283, 62);
            this.btnPonudaJelovnika.TabIndex = 0;
            this.btnPonudaJelovnika.Text = "Ponuda jelovnika";
            this.toolTip1.SetToolTip(this.btnPonudaJelovnika, "Gumb za pregled ponude jelovnika");
            this.btnPonudaJelovnika.UseVisualStyleBackColor = false;
            this.btnPonudaJelovnika.Click += new System.EventHandler(this.btnPonudaJelovnika_Click);
            // 
            // btnPovijestNarudžbi
            // 
            this.btnPovijestNarudžbi.BackColor = System.Drawing.Color.White;
            this.btnPovijestNarudžbi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPovijestNarudžbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPovijestNarudžbi.Location = new System.Drawing.Point(54, 145);
            this.btnPovijestNarudžbi.Name = "btnPovijestNarudžbi";
            this.btnPovijestNarudžbi.Size = new System.Drawing.Size(283, 62);
            this.btnPovijestNarudžbi.TabIndex = 1;
            this.btnPovijestNarudžbi.Text = "Povijest narudžbi";
            this.toolTip1.SetToolTip(this.btnPovijestNarudžbi, "Gumb za pregled Vaših prethodnih narudžbi");
            this.btnPovijestNarudžbi.UseVisualStyleBackColor = false;
            this.btnPovijestNarudžbi.Click += new System.EventHandler(this.btnPovijestNarudžbi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Minimiziranje forme");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(360, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Zatvaranje forme");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // GlavnaFormaNarucitelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(391, 269);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPovijestNarudžbi);
            this.Controls.Add(this.btnPonudaJelovnika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "GlavnaFormaNarucitelj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eNarudžba";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlavnaFormaNarucitelj_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlavnaFormaNarucitelj_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPonudaJelovnika;
        private System.Windows.Forms.Button btnPovijestNarudžbi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}