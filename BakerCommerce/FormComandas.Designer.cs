namespace BakerCommerce
{
    partial class FormComandas
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
            this.grbInformacao = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQualidadeLancamento = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbInformacao.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformacao
            // 
            this.grbInformacao.Controls.Add(this.btnContinuar);
            this.grbInformacao.Controls.Add(this.txbCodProduto);
            this.grbInformacao.Controls.Add(this.lblCodProduto);
            this.grbInformacao.Controls.Add(this.txbComanda);
            this.grbInformacao.Controls.Add(this.lblComanda);
            this.grbInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacao.Location = new System.Drawing.Point(12, 22);
            this.grbInformacao.Name = "grbInformacao";
            this.grbInformacao.Size = new System.Drawing.Size(311, 289);
            this.grbInformacao.TabIndex = 0;
            this.grbInformacao.TabStop = false;
            this.grbInformacao.Text = "Informação";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Cyan;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnContinuar.Location = new System.Drawing.Point(11, 203);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(288, 67);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(181, 130);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(124, 29);
            this.txbCodProduto.TabIndex = 3;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(-4, 133);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(166, 24);
            this.lblCodProduto.TabIndex = 2;
            this.lblCodProduto.Text = "COD.PRODUTO:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(181, 55);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(124, 31);
            this.txbComanda.TabIndex = 1;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(7, 55);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(120, 24);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "COMANDA:";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnCancelar);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.txbProduto);
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.lblProduto);
            this.grbLancamento.Controls.Add(this.lblQualidadeLancamento);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLancamento.Location = new System.Drawing.Point(12, 373);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(311, 305);
            this.grbLancamento.TabIndex = 1;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Blue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(11, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(288, 65);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.Cyan;
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.ForeColor = System.Drawing.Color.Red;
            this.btnLancar.Location = new System.Drawing.Point(11, 150);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(288, 65);
            this.btnLancar.TabIndex = 9;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbProduto
            // 
            this.txbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(175, 34);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.ReadOnly = true;
            this.txbProduto.Size = new System.Drawing.Size(124, 29);
            this.txbProduto.TabIndex = 6;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(175, 100);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(124, 29);
            this.txbQuantidade.TabIndex = 8;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(7, 39);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(89, 24);
            this.lblProduto.TabIndex = 5;
            this.lblProduto.Text = "Produto:";
            // 
            // lblQualidadeLancamento
            // 
            this.lblQualidadeLancamento.AutoSize = true;
            this.lblQualidadeLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualidadeLancamento.Location = new System.Drawing.Point(7, 103);
            this.lblQualidadeLancamento.Name = "lblQualidadeLancamento";
            this.lblQualidadeLancamento.Size = new System.Drawing.Size(124, 24);
            this.lblQualidadeLancamento.TabIndex = 7;
            this.lblQualidadeLancamento.Text = "Quantidade:\r\n";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(332, 128);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(457, 479);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(340, 34);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(291, 25);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Lançamento de Comandas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakerCommerce.Properties.Resources.code;
            this.pictureBox1.Location = new System.Drawing.Point(647, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 715);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformacao);
            this.MaximizeBox = false;
            this.Name = "FormComandas";
            this.Text = "FormComandas";
            this.grbInformacao.ResumeLayout(false);
            this.grbInformacao.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacao;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblComanda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQualidadeLancamento;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCancelar;
    }
}