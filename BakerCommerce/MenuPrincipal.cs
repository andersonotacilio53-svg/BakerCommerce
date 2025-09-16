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
    public partial class MenuPrincipal : Form
    {
        //Variaveis globais:
        Model.Usuario usuario = new Model.Usuario();

        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblDescricao.Text = $"Olá{usuario.NomeCompleto},\nEscolha uma opção abaixo:";
        }

        private void lblDescricao_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios(usuario);
            formUsuarios.ShowDialog(); // Mostrar o form
        }

        private void btnComandas_Click(object sender, EventArgs e)

        {

            FormComandas formComandas = new FormComandas(usuario);

            formComandas.ShowDialog();

        }

        private void btnProdutos_Click(object sender, EventArgs e)

        {

            FormProdutos formProdutos = new FormProdutos(usuario);

            formProdutos.ShowDialog();

        }

        private void btnCaixa_Click(object sender, EventArgs e)

        {

            BakerCommerce formCaixa = new BakerCommerce(usuario);

            formCaixa.ShowDialog();

        }

        private void btnCaixa_Click_1(object sender, EventArgs e)
        {
            BakerCommerce formCaixa = new BakerCommerce(usuario);
            formCaixa.ShowDialog();
        }
    }
}
