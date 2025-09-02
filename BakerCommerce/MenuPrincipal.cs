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
    }
}
