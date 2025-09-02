namespace BakerCommerce
{
    partial class FormUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.txbNomeCadastrar = new System.Windows.Forms.TextBox();
            this.txbEmailCadastrar = new System.Windows.Forms.TextBox();
            this.lblEmailCadastrar = new System.Windows.Forms.Label();
            this.txbSenhaCadastrar = new System.Windows.Forms.TextBox();
            this.lblSenhaCadastrar = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbSenhaEditar = new System.Windows.Forms.TextBox();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.txbEmailEditar = new System.Windows.Forms.TextBox();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblDescricaoApagar = new System.Windows.Forms.Label();
            this.lblDescricaoLogo = new System.Windows.Forms.Label();
            this.pibLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(11, 100);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(768, 250);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // grbCadastro
            // 
            this.grbCadastro.BackColor = System.Drawing.Color.LightGray;
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbSenhaCadastrar);
            this.grbCadastro.Controls.Add(this.lblSenhaCadastrar);
            this.grbCadastro.Controls.Add(this.txbEmailCadastrar);
            this.grbCadastro.Controls.Add(this.lblEmailCadastrar);
            this.grbCadastro.Controls.Add(this.txbNomeCadastrar);
            this.grbCadastro.Controls.Add(this.lblNomeCadastro);
            this.grbCadastro.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(11, 356);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(376, 212);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastrar";
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(16, 29);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(159, 24);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome Completo:";
            // 
            // txbNomeCadastrar
            // 
            this.txbNomeCadastrar.BackColor = System.Drawing.Color.Azure;
            this.txbNomeCadastrar.Location = new System.Drawing.Point(181, 23);
            this.txbNomeCadastrar.Name = "txbNomeCadastrar";
            this.txbNomeCadastrar.Size = new System.Drawing.Size(189, 30);
            this.txbNomeCadastrar.TabIndex = 1;
            // 
            // txbEmailCadastrar
            // 
            this.txbEmailCadastrar.BackColor = System.Drawing.Color.Azure;
            this.txbEmailCadastrar.Location = new System.Drawing.Point(181, 65);
            this.txbEmailCadastrar.Name = "txbEmailCadastrar";
            this.txbEmailCadastrar.Size = new System.Drawing.Size(189, 30);
            this.txbEmailCadastrar.TabIndex = 3;
            // 
            // lblEmailCadastrar
            // 
            this.lblEmailCadastrar.AutoSize = true;
            this.lblEmailCadastrar.Location = new System.Drawing.Point(16, 65);
            this.lblEmailCadastrar.Name = "lblEmailCadastrar";
            this.lblEmailCadastrar.Size = new System.Drawing.Size(76, 24);
            this.lblEmailCadastrar.TabIndex = 2;
            this.lblEmailCadastrar.Text = "Email:";
            // 
            // txbSenhaCadastrar
            // 
            this.txbSenhaCadastrar.BackColor = System.Drawing.Color.Azure;
            this.txbSenhaCadastrar.Location = new System.Drawing.Point(181, 101);
            this.txbSenhaCadastrar.Name = "txbSenhaCadastrar";
            this.txbSenhaCadastrar.Size = new System.Drawing.Size(189, 30);
            this.txbSenhaCadastrar.TabIndex = 5;
            // 
            // lblSenhaCadastrar
            // 
            this.lblSenhaCadastrar.AutoSize = true;
            this.lblSenhaCadastrar.Location = new System.Drawing.Point(16, 101);
            this.lblSenhaCadastrar.Name = "lblSenhaCadastrar";
            this.lblSenhaCadastrar.Size = new System.Drawing.Size(73, 24);
            this.lblSenhaCadastrar.TabIndex = 4;
            this.lblSenhaCadastrar.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Azure;
            this.btnCadastrar.Location = new System.Drawing.Point(19, 143);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(351, 63);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.Color.LightGray;
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbSenhaEditar);
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.txbEmailEditar);
            this.grbEditar.Controls.Add(this.lblEmailEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(404, 356);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(375, 212);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Azure;
            this.btnEditar.Location = new System.Drawing.Point(17, 143);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(351, 63);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // txbSenhaEditar
            // 
            this.txbSenhaEditar.BackColor = System.Drawing.Color.Azure;
            this.txbSenhaEditar.Location = new System.Drawing.Point(179, 101);
            this.txbSenhaEditar.Name = "txbSenhaEditar";
            this.txbSenhaEditar.Size = new System.Drawing.Size(189, 30);
            this.txbSenhaEditar.TabIndex = 5;
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(16, 101);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(73, 24);
            this.lblSenhaEditar.TabIndex = 4;
            this.lblSenhaEditar.Text = "Senha:";
            // 
            // txbEmailEditar
            // 
            this.txbEmailEditar.BackColor = System.Drawing.Color.Azure;
            this.txbEmailEditar.Location = new System.Drawing.Point(179, 65);
            this.txbEmailEditar.Name = "txbEmailEditar";
            this.txbEmailEditar.Size = new System.Drawing.Size(189, 30);
            this.txbEmailEditar.TabIndex = 3;
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(16, 65);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(76, 24);
            this.lblEmailEditar.TabIndex = 2;
            this.lblEmailEditar.Text = "Email:";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.BackColor = System.Drawing.Color.Azure;
            this.txbNomeEditar.Location = new System.Drawing.Point(179, 23);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(189, 30);
            this.txbNomeEditar.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(14, 29);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(159, 24);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome Completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.BackColor = System.Drawing.Color.LightGray;
            this.grbApagar.Controls.Add(this.lblDescricaoApagar);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.Location = new System.Drawing.Point(11, 574);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(768, 109);
            this.grbApagar.TabIndex = 8;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(572, 19);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(190, 84);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoApagar
            // 
            this.lblDescricaoApagar.AutoSize = true;
            this.lblDescricaoApagar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoApagar.Location = new System.Drawing.Point(21, 42);
            this.lblDescricaoApagar.Name = "lblDescricaoApagar";
            this.lblDescricaoApagar.Size = new System.Drawing.Size(334, 24);
            this.lblDescricaoApagar.TabIndex = 1;
            this.lblDescricaoApagar.Text = "Selecione um usuário para apagar:";
            // 
            // lblDescricaoLogo
            // 
            this.lblDescricaoLogo.AutoSize = true;
            this.lblDescricaoLogo.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoLogo.Location = new System.Drawing.Point(108, 35);
            this.lblDescricaoLogo.Name = "lblDescricaoLogo";
            this.lblDescricaoLogo.Size = new System.Drawing.Size(411, 38);
            this.lblDescricaoLogo.TabIndex = 9;
            this.lblDescricaoLogo.Text = "Gerenciador de Usuários";
            // 
            // pibLogo
            // 
            this.pibLogo.BackColor = System.Drawing.Color.LightGray;
            this.pibLogo.Image = global::BakerCommerce.Properties.Resources._1772772;
            this.pibLogo.Location = new System.Drawing.Point(636, 12);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(143, 82);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 10;
            this.pibLogo.TabStop = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.pibLogo);
            this.Controls.Add(this.lblDescricaoLogo);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FormUsuarios";
            this.Text = "Gerenciador de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbSenhaCadastrar;
        private System.Windows.Forms.Label lblSenhaCadastrar;
        private System.Windows.Forms.TextBox txbEmailCadastrar;
        private System.Windows.Forms.Label lblEmailCadastrar;
        private System.Windows.Forms.TextBox txbNomeCadastrar;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbSenhaEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.TextBox txbEmailEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblDescricaoApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblDescricaoLogo;
        private System.Windows.Forms.PictureBox pibLogo;
    }
}