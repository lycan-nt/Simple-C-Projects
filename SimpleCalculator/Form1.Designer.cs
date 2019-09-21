namespace CalculadoraSimples
{
    partial class FrmlCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbN1 = new System.Windows.Forms.TextBox();
            this.TxbN2 = new System.Windows.Forms.TextBox();
            this.BtnSum = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbR = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "1º Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "2º Number:";
            // 
            // TxbN1
            // 
            this.TxbN1.Location = new System.Drawing.Point(132, 43);
            this.TxbN1.Name = "TxbN1";
            this.TxbN1.Size = new System.Drawing.Size(100, 20);
            this.TxbN1.TabIndex = 2;
            // 
            // TxbN2
            // 
            this.TxbN2.Location = new System.Drawing.Point(132, 101);
            this.TxbN2.Name = "TxbN2";
            this.TxbN2.Size = new System.Drawing.Size(100, 20);
            this.TxbN2.TabIndex = 3;
            // 
            // BtnSum
            // 
            this.BtnSum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSum.Location = new System.Drawing.Point(13, 10);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(43, 23);
            this.BtnSum.TabIndex = 4;
            this.BtnSum.Text = "+";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.BtnDiv);
            this.panel1.Controls.Add(this.BtnMul);
            this.panel1.Controls.Add(this.BtnSub);
            this.panel1.Controls.Add(this.BtnSum);
            this.panel1.Location = new System.Drawing.Point(251, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 221);
            this.panel1.TabIndex = 5;
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(13, 184);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(43, 23);
            this.BtnDiv.TabIndex = 7;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMul.Location = new System.Drawing.Point(13, 128);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(43, 23);
            this.BtnMul.TabIndex = 6;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.Location = new System.Drawing.Point(13, 66);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(43, 23);
            this.BtnSub.TabIndex = 5;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            // 
            // TxbR
            // 
            this.TxbR.Location = new System.Drawing.Point(132, 150);
            this.TxbR.Name = "TxbR";
            this.TxbR.ReadOnly = true;
            this.TxbR.Size = new System.Drawing.Size(100, 20);
            this.TxbR.TabIndex = 8;
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(24, 190);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(208, 33);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmlCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 237);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxbR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxbN2);
            this.Controls.Add(this.TxbN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmlCalculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbN1;
        private System.Windows.Forms.TextBox TxbN2;
        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbR;
        private System.Windows.Forms.Button BtnClear;
    }
}

