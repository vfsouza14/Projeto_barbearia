using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Barbearia
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }
  

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Usuarios cad_usuarios = new Cad_Usuarios();
            cad_usuarios.Show();
            cad_usuarios = null;

        }

        private void opCadastroClientes_Click(object sender, EventArgs e)
        {

            Cad_Clientes cad_Clientes = new Cad_Clientes();
            cad_Clientes.Show();
            cad_Clientes = null;

        }

        private void produtosServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Prod_Serv cad_prod = new Cad_Prod_Serv();
            cad_prod.Show();
            cad_prod = null;

        }
    }
}
