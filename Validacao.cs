using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_Barbearia
{
    class Validacao
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public  int ValidaCadastro(String nome, String celular)
        {

            int result = 0;
            if (nome != "" || celular != "")
            {

                cmd.CommandText = "SELECT * FROM Cadastro_clientes WHERE Nome = @nome AND Celular = @celular";
                SqlParameter codigo = new SqlParameter("@nome", nome);
                SqlParameter codigo2 = new SqlParameter("@celular", celular);
                cmd.Parameters.Add(codigo);
                cmd.Parameters.Add(codigo2);

                cmd.Connection = conexao.conectar();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.desconectar();
                cmd = null;

            }

            return result;
        }

        public int ValidaProdServ(String desc)
        {

            int result = 0;
            if (desc != "")
            {

                cmd.CommandText = "SELECT * FROM Produtos WHERE Descricao = @desc";
                SqlParameter codigo = new SqlParameter("@desc", desc);
                cmd.Parameters.Add(codigo);
                

                cmd.Connection = conexao.conectar();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.desconectar();
                cmd = null;

            }

            return result;


        }

        public int ValidaUsuario( String login)
        {

            int result = 0;
            if(login != "")
            {

                cmd.CommandText = "SELECT * FROM Usuarios WHERE Login = @login";
                SqlParameter codigo = new SqlParameter("@login", login);
                cmd.Parameters.Add(codigo);

                cmd.Connection = conexao.conectar();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.desconectar();
                cmd = null;

            }

            return result;

        }

    }

    
}
