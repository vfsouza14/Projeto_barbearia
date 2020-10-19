using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;



namespace Projeto_Barbearia
{
    class Prod_Serv
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String menssagem = "";



        public void Inserir(String desc, String valor, bool tipo, int quant ) {

            cmd.CommandText = "INSERT INTO Produtos (Descricao, Valor, Tipo, Quantidade) VALUES(@desc, @valor, @tipo, @quant)";
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@quant", quant);

            try
            {

                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();

            }
            catch(SqlException e)
            {

                menssagem = e.Message;

            }
        }

        public void Deletar( int ID)
        {

            cmd.CommandText = "DELETE Produtos WHERE Id_produto = @ID ";

            cmd.Parameters.AddWithValue("@ID", ID);
            //Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();
            conexao.desconectar();

        }

        public void Alteracao(String desc, String valor, bool tipo, int quant, int ID)
        {

            cmd.CommandText = "UPDATE Produtos SET Descricao = @desc " +
                                 "                            ,Valor = @valor " +
                                 "                            ,Tipo = @tipo" +
                                 "                            ,Quantidade = @quant" +
                                 " WHERE id_produto = @ID ";
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@Valor", valor);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@quant", quant);
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();
            conexao.desconectar();

        }

    }
}
