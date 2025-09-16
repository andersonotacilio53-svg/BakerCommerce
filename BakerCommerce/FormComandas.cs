using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class FormComandas : Form
    {
        Model.Usuario usuario;
        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.Listar();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Pegar a linha selecionada
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            // Colocar os ID do produto no  campo de código:
            txbCodProduto.Text = dgvProdutos.Rows[ls].Cells[0].Value.ToString();
            // Colocar nome do produto no campo de informãções:
            txbProduto.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();

           
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // verificar se os campos estão vazios :
            if(txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Imforme o numero da comanda!",
                      "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else if(txbCodProduto.Text.Length == 0) 
            {
                MessageBox.Show("Imformw o código do produto.",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // Desativar o grbinfos:
                grbInformacao.Enabled = false;
                // Ativar o grblançamento:
                grbLancamento.Enabled = true;
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            // Verificar  se a quantidade foi preenchida:
            if(txbQuantidade.Text.Length == 0)
            {
                MessageBox.Show("Imformw a quantidade!",
                  "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);
                ordemComanda.IdProduto = int.Parse(txbCodProduto.Text);
                ordemComanda.IdFicha = int.Parse(txbQuantidade.Text);
                ordemComanda.IdResp = usuario.Id;

                if (ordemComanda.Cadastrar())
                {
                    MessageBox.Show(" Lançamento Efetuado !", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {

                    MessageBox.Show("Falha ao efetuar lançamento!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ResetarCampos()
        {
            txbCodProduto.Clear();
            txbQuantidade.Clear();
            txbProduto.Clear(); 
            txbComanda.Clear();
            //Resetar os groupboxes:
            grbLancamento.Enabled = false;
            grbInformacao.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
