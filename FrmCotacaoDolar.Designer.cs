
namespace CotacaoDolarHG
{
    partial class FrmCotacaoDolar
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
            this.labelDolar = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblVariacao = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblValorVariacao = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDolar
            // 
            this.labelDolar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolar.Location = new System.Drawing.Point(13, 13);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(775, 129);
            this.labelDolar.TabIndex = 0;
            this.labelDolar.Text = "Dólar";
            this.labelDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(285, 330);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(246, 45);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.Location = new System.Drawing.Point(22, 202);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(112, 30);
            this.lblCompra.TabIndex = 1;
            this.lblCompra.Text = "Compra:";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(559, 204);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(93, 30);
            this.lblVenda.TabIndex = 3;
            this.lblVenda.Text = "Venda:";
            // 
            // lblVariacao
            // 
            this.lblVariacao.AutoSize = true;
            this.lblVariacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariacao.Location = new System.Drawing.Point(289, 202);
            this.lblVariacao.Name = "lblVariacao";
            this.lblVariacao.Size = new System.Drawing.Size(121, 30);
            this.lblVariacao.TabIndex = 4;
            this.lblVariacao.Text = "Variação:";
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.Location = new System.Drawing.Point(126, 195);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(53, 39);
            this.lblValorCompra.TabIndex = 5;
            this.lblValorCompra.Text = "xx";
            // 
            // lblValorVariacao
            // 
            this.lblValorVariacao.AutoSize = true;
            this.lblValorVariacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVariacao.Location = new System.Drawing.Point(402, 195);
            this.lblValorVariacao.Name = "lblValorVariacao";
            this.lblValorVariacao.Size = new System.Drawing.Size(53, 39);
            this.lblValorVariacao.TabIndex = 6;
            this.lblValorVariacao.Text = "xx";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVenda.Location = new System.Drawing.Point(646, 197);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(53, 39);
            this.lblValorVenda.TabIndex = 7;
            this.lblValorVenda.Text = "xx";
            // 
            // FrmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblValorVariacao);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.lblVariacao);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.labelDolar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotacaoDolar";
            this.Text = "Cotação Dolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblVariacao;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblValorVariacao;
        private System.Windows.Forms.Label lblValorVenda;
    }
}

