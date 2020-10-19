using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Barbearia
{
    public partial class Cad_Usuarios : Form
    {
        public Cad_Usuarios()
        {
            InitializeComponent();
        }

        int ID;

        private void gridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

        private void Cad_Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'barbearia_shopDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.barbearia_shopDataSet.Usuarios);
            
       

        }
        public void Limpar()
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";

        }

        private bool FiltrarDados()
        {
            //instrução SQL

            //conexão com o banco de dados
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            //objeto command para executar a instruçao sql
            cmd.CommandText = "SELECT * FROM Usuarios WHERE Nome LIKE '%'+@nome+'%'";
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);

            //abre a conexao
            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();

            //tipo do comando
            cmd.CommandType = CommandType.Text;
            //dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //objeto datatable
            DataTable usuarios = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(usuarios);
            //atribui o datatable ao datagridview para exibir o resultado
            gridUsuario.DataSource = usuarios;
            conexao.desconectar();
            return true;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtLogin.Text != "" && txtSenha.Text != "")
            {
                Conexao conexao = new Conexao();
                Validacao valida = new Validacao();
                int resposta = valida.ValidaUsuario(txtLogin.Text);

                if (resposta == 0)
                {

                    Usuarios usuario = new Usuarios();
                    usuario.Inserir(txtNome.Text, txtLogin.Text, txtSenha.Text, cbTipo.Checked);
                    MessageBox.Show("Cadastro realizado com sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.desconectar();
                    this.usuariosTableAdapter.Fill(this.barbearia_shopDataSet.Usuarios);

                }
                else if (resposta != 0)
                {

                    MessageBox.Show("Já existe um cliente cadastrado com essas informações!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Limpar();

            }
            else
            {
                //a
                MessageBox.Show("Preencha as informações corretamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if (txtLogin.Text != "" || txtSenha.Text != "")
            {

                Usuarios usuarios = new Usuarios();
                usuarios.Alteracao(txtNome.Text, txtLogin.Text, txtSenha.Text ,cbTipo.Checked, ID);

                MessageBox.Show("Atualização feita!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();

                this.usuariosTableAdapter.Fill(this.barbearia_shopDataSet.Usuarios);

                if (FiltrarDados())
                {

                    this.FiltrarDados();


                }


            }
            else
            {

                MessageBox.Show("Não foi selecionado nenhum registro para atualização", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void gridUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = Convert.ToInt32(gridUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = gridUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLogin.Text = gridUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSenha.Text = gridUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbTipo.Checked = Convert.ToBoolean(gridUsuario.Rows[e.RowIndex].Cells[4].Value);
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if (txtNome.Text != "")
            {

                Usuarios usuarios = new Usuarios();
                usuarios.Deletar(ID);

                MessageBox.Show("Deletado com sucesso!", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                this.usuariosTableAdapter.Fill(this.barbearia_shopDataSet.Usuarios);

                if (FiltrarDados())
                {

                    this.FiltrarDados();


                }


            }
            else
            {

                MessageBox.Show("Dados não selecionados para deletar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            FiltrarDados();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            Limpar();

        }
    }


}
