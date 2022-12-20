namespace Otobus_bilet
{
    partial class AnaSayfaFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfaFormu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnyetkiliGiris = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Mistral", 33F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "AYHAN TURİZM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnyetkiliGiris
            // 
            this.btnyetkiliGiris.BackColor = System.Drawing.Color.Yellow;
            this.btnyetkiliGiris.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyetkiliGiris.ForeColor = System.Drawing.Color.Black;
            this.btnyetkiliGiris.Location = new System.Drawing.Point(537, 503);
            this.btnyetkiliGiris.Margin = new System.Windows.Forms.Padding(5);
            this.btnyetkiliGiris.Name = "btnyetkiliGiris";
            this.btnyetkiliGiris.Size = new System.Drawing.Size(220, 56);
            this.btnyetkiliGiris.TabIndex = 3;
            this.btnyetkiliGiris.Text = "Yetkili Girişi";
            this.btnyetkiliGiris.UseVisualStyleBackColor = false;
            this.btnyetkiliGiris.Click += new System.EventHandler(this.btnyetkiliGiris_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(17, 503);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 43);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Götür beni gittiğin yere...";
            // 
            // AnaSayfaFormu
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(789, 576);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnyetkiliGiris);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnaSayfaFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnyetkiliGiris;
        private System.Windows.Forms.TextBox textBox1;
    }
}

