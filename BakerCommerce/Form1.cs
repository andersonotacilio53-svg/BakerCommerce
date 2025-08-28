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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Verificar se a pessoa digitou o email e a senha:
            if(txbEmail.Text.Length > 6)
            {
                MessageBox.Show("Digite um  email Válido",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(txbSenha.Text.Length > 4)
            {
                MessageBox.Show("Digite uma senha Válida",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 // Prosseguir...
                 Model.Usuario usuario = new Model.Usuario();

                // Colocar os valores dos campos nos atributos do usuário:
                usuario.Email =txbEmail.Text;
                usuario.Senha =txbSenha.Text;


            }
        }
    }
}
