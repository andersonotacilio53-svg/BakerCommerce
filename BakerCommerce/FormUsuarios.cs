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
    public partial class FormUsuarios : Form
    {

        // Objetos globais:
        Model.Usuario usuario;

        int idSelecionado = 0; // armazenar o id do usuário selecionado p/ apagar ou editar:

        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            Atualizardgv();
            
        }
        public void Atualizardgv()
        {
            // Mostrar as informações do banco de dados no datagridview:
            dgvUsuarios.DataSource = usuario.Listar();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeCadastrar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no minimo 5 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbEmailCadastrar.Text.Length < 7) // a@a.co
            {
                MessageBox.Show("O email deve ter no minimo 7 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txbSenhaCadastrar.Text.Length < 6)
            {
                MessageBox.Show("O Senha deve ter no minimo 6 caracteres.",
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer o cadastro....
                Model.Usuario usuarioCadastro = new Model.Usuario();

                // Salvar os valores dos campos nos atributos do obj:
                usuarioCadastro.NomeCompleto = txbNomeCadastrar.Text;
                usuarioCadastro.Email = txbEmailCadastrar.Text;
                usuarioCadastro.Senha = txbSenhaCadastrar.Text;
                // Executar o INSERT:
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrar com sucesso!","Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    // atualizar o dvg:
                    Atualizardgv();

                    // apagar os campos de cadastro:
                    txbNomeCadastrar.Clear();
                    txbEmailCadastrar.Clear();
                    txbSenhaCadastrar.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuario.", 
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            // Colocar os valores das células no txbx de edição:
            txbNomeEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();

            // Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar
            grbEditar.Enabled = true;

            //ajustar no grbApagar:
            lblDescricaoApagar.Text = $"Apagar:{dgvUsuarios.Rows[ls].Cells[1].Value}";

            // Ativar o grvApagar:
            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
             //Perguntar se realmente  quer apagar:
             DialogResult r = MessageBox.Show("Tem certeza que deseja este usuário?",
                 "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Usuario usuarioApagar = new Model.Usuario();

                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuario apagado com sucesso!",
                       "Show", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    
                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário.",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        public void ResetarCampos()
        {
            // Atualizar odgv():
            Atualizardgv();

            //limpar campos de edição:
            txbEmailEditar.Clear();
            txbSenhaEditar.Clear();
            txbNomeEditar.Clear();

            // Retornar o idSelecionado para 0
            idSelecionado = 0;

            // Retornar o texto padrão do "apagar":
            lblDescricaoApagar.Text = "Selecione o usuário que deseja apagar.";

            //Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeCadastrar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no minimo 5 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbEmailCadastrar.Text.Length < 7) // a@a.co
            {
                MessageBox.Show("O email deve ter no minimo 7 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaCadastrar.Text.Length < 6)
            {
                MessageBox.Show("O Senha deve ter no minimo 6 caracteres.",
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir com a edição:
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.NomeCompleto = txbNomeEditar.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;

                if (usuarioEditar.Modificar())
                {
                    MessageBox.Show("Usuario modificado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha em modificar o usuário!",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
