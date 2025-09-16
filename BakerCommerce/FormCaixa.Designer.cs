namespace BakerCommerce
{
    partial class BakerCommerce
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
            this.lblComanda = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.chbPagamento = new System.Windows.Forms.CheckBox();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(100, 35);
            this.lblComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(236, 26);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Número da Comanda:";
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnListar.Location = new System.Drawing.Point(616, 33);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(159, 35);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // chbPagamento
            // 
            this.chbPagamento.AutoSize = true;
            this.chbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamento.Location = new System.Drawing.Point(633, 515);
            this.chbPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chbPagamento.Name = "chbPagamento";
            this.chbPagamento.Size = new System.Drawing.Size(230, 28);
            this.chbPagamento.TabIndex = 2;
            this.chbPagamento.Text = "Pagamento Recebido";
            this.chbPagamento.UseVisualStyleBackColor = true;
            this.chbPagamento.CheckedChanged += new System.EventHandler(this.cxbPagamento_CheckedChanged);
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(398, 35);
            this.txbComanda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(205, 26);
            this.txbComanda.TabIndex = 3;
            // 
            // dgvComanda
            // 
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Location = new System.Drawing.Point(14, 92);
            this.dgvComanda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.Size = new System.Drawing.Size(877, 314);
            this.dgvComanda.TabIndex = 4;
            this.dgvComanda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComanda_CellClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(629, 480);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 21);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "R$   -  ";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEncerrar.Location = new System.Drawing.Point(633, 566);
            this.btnEncerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(275, 55);
            this.btnEncerrar.TabIndex = 6;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(21, 493);
            this.lblCaixa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(88, 31);
            this.lblCaixa.TabIndex = 7;
            this.lblCaixa.Text = "Caixa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakerCommerce.Properties.Resources.caixa;
            this.pictureBox1.Location = new System.Drawing.Point(129, 490);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BakerCommerce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(104)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(933, 633);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvComanda);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.chbPagamento);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblComanda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BakerCommerce";
            this.Text = "Caixa Barker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.CheckBox chbPagamento;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}