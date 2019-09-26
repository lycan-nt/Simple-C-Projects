namespace Cashier
{
    partial class FrmCachier
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCachier));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicPro = new System.Windows.Forms.PictureBox();
            this.LblProCod = new System.Windows.Forms.Label();
            this.TxbCod = new System.Windows.Forms.TextBox();
            this.LblTot = new System.Windows.Forms.Label();
            this.TxbTot = new System.Windows.Forms.TextBox();
            this.ListProd = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPro)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PicPro
            // 
            this.PicPro.Location = new System.Drawing.Point(12, 197);
            this.PicPro.Name = "PicPro";
            this.PicPro.Size = new System.Drawing.Size(200, 200);
            this.PicPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPro.TabIndex = 1;
            this.PicPro.TabStop = false;
            // 
            // LblProCod
            // 
            this.LblProCod.AutoSize = true;
            this.LblProCod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProCod.Location = new System.Drawing.Point(8, 153);
            this.LblProCod.Name = "LblProCod";
            this.LblProCod.Size = new System.Drawing.Size(128, 22);
            this.LblProCod.TabIndex = 2;
            this.LblProCod.Text = "Product Code";
            this.LblProCod.Click += new System.EventHandler(this.LblProCod_Click);
            // 
            // TxbCod
            // 
            this.TxbCod.Location = new System.Drawing.Point(142, 157);
            this.TxbCod.Name = "TxbCod";
            this.TxbCod.Size = new System.Drawing.Size(140, 20);
            this.TxbCod.TabIndex = 3;
            this.TxbCod.TextChanged += new System.EventHandler(this.TxbCod_TextChanged);
            // 
            // LblTot
            // 
            this.LblTot.AutoSize = true;
            this.LblTot.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTot.Location = new System.Drawing.Point(243, 375);
            this.LblTot.Name = "LblTot";
            this.LblTot.Size = new System.Drawing.Size(50, 22);
            this.LblTot.TabIndex = 4;
            this.LblTot.Text = "Total";
            // 
            // TxbTot
            // 
            this.TxbTot.Location = new System.Drawing.Point(299, 375);
            this.TxbTot.Name = "TxbTot";
            this.TxbTot.ReadOnly = true;
            this.TxbTot.Size = new System.Drawing.Size(100, 20);
            this.TxbTot.TabIndex = 5;
            // 
            // ListProd
            // 
            this.ListProd.FormattingEnabled = true;
            this.ListProd.Location = new System.Drawing.Point(247, 197);
            this.ListProd.Name = "ListProd";
            this.ListProd.Size = new System.Drawing.Size(342, 134);
            this.ListProd.TabIndex = 6;
            // 
            // FrmCachier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 419);
            this.Controls.Add(this.ListProd);
            this.Controls.Add(this.TxbTot);
            this.Controls.Add(this.LblTot);
            this.Controls.Add(this.TxbCod);
            this.Controls.Add(this.LblProCod);
            this.Controls.Add(this.PicPro);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmCachier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.FrmCachier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicPro;
        private System.Windows.Forms.Label LblProCod;
        private System.Windows.Forms.TextBox TxbCod;
        private System.Windows.Forms.Label LblTot;
        private System.Windows.Forms.TextBox TxbTot;
        private System.Windows.Forms.ListBox ListProd;
    }
}

