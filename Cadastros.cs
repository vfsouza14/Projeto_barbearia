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
using System.Text.RegularExpressions;


namespace Projeto_Barbearia
{
    public class Cadastros
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        

        public String menssagem = "";

       

        public void Cadastro(String data1, String data2)
        {
            
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "INSERT INTO Cadastro_clientes (Nome, Celular) values(@Nome, @Celular)";
            //parametros
            cmd.Parameters.AddWithValue("@nome",data1);
            cmd.Parameters.AddWithValue("@Celular", data2);
            
            try
            {

                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
  

            }
            catch (SqlException e)
            {

                 menssagem = e.Message;

            }
         
            
        }
        

       public void Alteracao(String data1, String data2, int ID)
        {

            cmd.CommandText = "UPDATE Cadastro_clientes SET Nome = @nome " +
                                 "                            ,Celular = @Celular " +
                                 " WHERE Id = @ID ";
            cmd.Parameters.AddWithValue("@nome", data1);
            cmd.Parameters.AddWithValue("@Celular", data2);
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();
            conexao.desconectar();

        }

        public void Deletar(int ID)
        {

            cmd.CommandText = "DELETE Cadastro_clientes WHERE Id = @ID ";

            cmd.Parameters.AddWithValue("@Id", ID);

            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();
            conexao.desconectar();

        }

    }
}
