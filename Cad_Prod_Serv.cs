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
    public partial class Cad_Prod_Serv : Form
    {
        public Cad_Prod_Serv()
        {
            InitializeComponent();
        }

        int ID;

        private void Cad_Prod_Serv_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'barbearia_shopDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.barbearia_shopDataSet.Produtos);

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "" && txtQuant.Text != "" && txtValor.Text != "")
            {

                Conexao conexao = new Conexao();
                Validacao valida = new Validacao();
                int resposta = valida.ValidaProdServ(txtDesc.Text);

                if(resposta == 0)
                {

                    Prod_Serv prod = new Prod_Serv();
                    prod.Inserir(txtDesc.Text, txtValor.Text, cbChange.Checked, Convert.ToInt32(txtQuant.Text));
                    MessageBox.Show("Cadastrado realizado com sucesso!", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.desconectar();
                    this.produtosTableAdapter.Fill(this.barbearia_shopDataSet.Produtos);
                }
                else if (resposta != 0)
                {

                    MessageBox.Show("Já existe um cliente cadastrado com essas informações!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Limpar();

            }
            else
            {

                MessageBox.Show("Preencha as informações corretamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        
        }

        private void rdServ_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void Limpar()
        {
            txtDesc.Text = "";
            txtQuant.Text = "";
            txtValor.Text = "";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private bool FiltrarDados()
        {
            //instrução SQL

            //conexão com o banco de dados
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            //objeto command para executar a instruçao sql
            cmd.CommandText = "SELECT * FROM Produtos WHERE Descricao LIKE '%'+@desc+'%'";
            cmd.Parameters.AddWithValue("@desc", txtDesc.Text);

            //abre a conexao
            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();

            //tipo do comando
            cmd.CommandType = CommandType.Text;
            //dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //objeto datatable
            DataTable prod_serv = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(prod_serv);
            //atribui o datatable ao datagridview para exibir o resultado
            gridProd_Serv.DataSource = prod_serv;
            conexao.desconectar();
            return true;

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if (txtDesc.Text != "")
            {

                Prod_Serv prod = new Prod_Serv();
                prod.Deletar(ID);

                MessageBox.Show("Deletado com sucesso!", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                this.produtosTableAdapter.Fill(this.barbearia_shopDataSet.Produtos);

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

        private void gridProd_Serv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProd_Serv_Click(object sender, EventArgs e)
        {

        }

        private void gridProd_Serv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ID = Convert.ToInt32(gridProd_Serv.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDesc.Text = gridProd_Serv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtValor.Text = gridProd_Serv.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbChange.Checked = Convert.ToBoolean(gridProd_Serv.Rows[e.RowIndex].Cells[3].Value);
            txtQuant.Text = gridProd_Serv.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            if (txtDesc.Text != "" || txtValor.Text != "")
            {

                Prod_Serv prod = new Prod_Serv();
                prod.Alteracao(txtDesc.Text, txtValor.Text, cbChange.Checked, Convert.ToInt32(txtQuant.Text), ID);

                MessageBox.Show("Atualização feita!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();

                this.produtosTableAdapter.Fill(this.barbearia_shopDataSet.Produtos);

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FiltrarDados();
        }
    }
}
