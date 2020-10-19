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
    class Usuarios
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();


        public String menssagem = "";



        public void Inserir(String nome, String login, String senha, bool tipo)
        {

            cmd.CommandText = "INSERT INTO Usuarios (Nome, Login, Senha, Tipo) VALUES(@nome, @login, @senha, @tipo)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@tipo", tipo);

            try
            {

                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();

            }
            catch (SqlException e)
            {

                menssagem = e.Message;

            }

        }

        public void Alteracao(String nome, String login, String senha, bool tipo, int ID)
        {

            cmd.CommandText = "UPDATE Usuarios SET Nome = @nome " +
                                 "                            ,Login = @login " +
                                 "                            ,Senha = @senha" +
                                 "                            ,Tipo = @tipo" +
                                 " WHERE id_Usuario = @ID ";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();
            conexao.desconectar();

        }

        public void Deletar(int ID)
        {

            cmd.CommandText = "DELETE Usuarios WHERE Id_Usuario = @ID ";

            cmd.Parameters.AddWithValue("@ID", ID);
            //Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();
            conexao.desconectar();

        }

    }

}
