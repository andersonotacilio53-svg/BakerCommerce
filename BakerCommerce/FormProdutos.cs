using BakerCommerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BakerCommerce
{
    public partial class FormProdutos : Form
    {

        Model.Usuario usuario;
        int idSelecionado = 0;

        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            listarCategoriasCmb();
            Atualizardgv();
        }

        public void Atualizardgv()
        {
            Model.Produto produtos = new Model.Produto();

            // Mostrar as informações do banco de dados no datagridview:
            dgvProduto.DataSource = produtos.Listar();

        }

        public void listarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // Tabela p/ receber o resultado do SELECT:
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                cmbCategoriaCadastrar.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeCadastrar.Text.Length < 2)
            {
                MessageBox.Show("O nome deve ter no minimo 2 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (cmbCategoriaCadastrar.Text == "")
            {
                MessageBox.Show("selecione uma categoria.",
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer o cadastro....
                Model.Produto ProdutoCadastar = new Model.Produto();

                // Salvar os valores dos campos nos atributos do obj:
                ProdutoCadastar.Nome = txbNomeCadastrar.Text;
                ProdutoCadastar.Preco = double.Parse(txbPrecoCadastrar.Text);
                ProdutoCadastar.IdRespCadastro = usuario.Id;

                string linha = cmbCategoriaCadastrar.Text;
                string numero = linha.Split('-')[0].Trim();

                ProdutoCadastar.IdCategoria = int.Parse(numero);





                if (ProdutoCadastar.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrar com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar o dvg:
                    Atualizardgv();

                    // apagar os campos de cadastro:
                    txbNomeCadastrar.Clear();
                    txbPrecoCadastrar.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuario.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 2)
            {
                MessageBox.Show("O nome deve ter no minimo 2 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (cmbCategoriaEditar.Text == "")
            {
                MessageBox.Show("selecione uma categoria.",
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer o cadastro....
                Model.Produto produtoEditar = new Model.Produto();

                // Salvar os valores dos campos nos atributos do obj:
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = double.Parse(txbPrecoEditar.Text);
                produtoEditar.IdRespCadastro = usuario.Id;

                string linha = cmbCategoriaEditar.Text;
                string numero = linha.Split('-')[0].Trim();

                produtoEditar.IdCategoria = int.Parse(numero);
                produtoEditar.Id = idSelecionado;




                if (produtoEditar.Modificar())
                {
                    MessageBox.Show("Produto modificado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar o dvg:
                    Atualizardgv();

                    // apagar os campos de cadastro:
                    txbNomeEditar.Clear();
                    txbPrecoEditar.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar o produto.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tem certeza que deseja este produto?",
                 "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Produto produtoApagar = new Model.Produto();

                produtoApagar.Id = idSelecionado;
                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!",
                       "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o produto8.",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        public void ResetarCampos()
        {
            // Atualizar odgv():
            Atualizardgv();

            //limpar campos de edição:
            txbNomeEditar.Clear();
            txbPrecoEditar.Clear();
           

            // Retornar o idSelecionado para 0
            idSelecionado = 0;

            // Retornar o texto padrão do "apagar":
            lblDescricaoApagar.Text = "Selecione o produto que deseja apagar.";

            //Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;


        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada
            int ls = dgvProduto.SelectedCells[0].RowIndex;

            // Colocar os valores das células no txbx de edição:
            txbNomeEditar.Text = dgvProduto.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProduto.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvProduto.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar
            grbEditar.Enabled = true;

            //ajustar no grbApagar:
            lblDescricaoApagar.Text = $"Apagar:{dgvProduto.Rows[ls].Cells[1].Value}";

            // Ativar o grvApagar:
            grbApagar.Enabled = true;
        }
    }
}
