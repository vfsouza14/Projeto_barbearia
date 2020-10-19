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
    public partial class Cad_Clientes : Form
    {
        public Cad_Clientes()
        {
            InitializeComponent();
        }

        int ID;

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (textNome.Text != "" && maskedCelular.Text != "")
            {
                Conexao conexao = new Conexao();
                Validacao valida = new Validacao();
                int resposta = valida.ValidaCadastro(textNome.Text, maskedCelular.Text);

                if (resposta == 0)
                {

                    Cadastros cad = new Cadastros();
                    cad.Cadastro(textNome.Text, maskedCelular.Text);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.desconectar();
                    this.cadastro_clientesTableAdapter.Fill(this.barbearia_shopDataSet.Cadastro_clientes);

                }
                else if (resposta != 0)
                {

                    MessageBox.Show("Já existe um cliente cadastrado com essas informações!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            } else
            {

                MessageBox.Show("Preencha as informações corretamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                
        }

        private void Cad_Clientes_Load(object sender, EventArgs e)
        {
            
            // TODO: esta linha de código carrega dados na tabela 'barbearia_shopDataSet.Cadastro_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_clientesTableAdapter.Fill(this.barbearia_shopDataSet.Cadastro_clientes);
            
   
        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if (textNome.Text != "" /*|| maskedCelular.Text != ""*/)
            {

                Cadastros cad = new Cadastros();
                cad.Alteracao(textNome.Text, maskedCelular.Text, ID);

                MessageBox.Show("Atualização feita!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.cadastro_clientesTableAdapter.Fill(this.barbearia_shopDataSet.Cadastro_clientes);
            }
            else 
            {

                MessageBox.Show("Não foi selecionado nenhum registro para atualização", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = Convert.ToInt32(gridClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            textNome.Text = gridClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            maskedCelular.Text = gridClientes.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if (textNome.Text != "" && maskedCelular.Text != "")
            {

                Cadastros cad = new Cadastros();
                cad.Deletar(ID);
                
                MessageBox.Show("Deletado com sucesso!", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNome.Text = "";
                maskedCelular.Text = "";
                this.cadastro_clientesTableAdapter.Fill(this.barbearia_shopDataSet.Cadastro_clientes);

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

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            textNome.Text = "";
            maskedCelular.Text = "";

        }

        private bool FiltrarDados()
        {
            //instrução SQL
           
            //conexão com o banco de dados
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            //objeto command para executar a instruçao sql
            cmd.CommandText = "SELECT * FROM Cadastro_clientes WHERE Nome like '%'+@nome+'%'";
            cmd.Parameters.AddWithValue("@nome", textNome.Text);

            //abre a conexao
            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();
            
            //tipo do comando
            cmd.CommandType = CommandType.Text;
            //dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            //atribui o datatable ao datagridview para exibir o resultado
            gridClientes.DataSource = clientes;
            conexao.desconectar();
            return true;
            
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {

            FiltrarDados();
            
        }
    }
}

