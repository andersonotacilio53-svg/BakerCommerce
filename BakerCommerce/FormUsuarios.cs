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
    }
}
