using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Barbearia
{
    public class Conexao
    {

        SqlConnection con = new SqlConnection();

        //Contrutor
        public Conexao()
        {

            //con.ConnectionString = "server=DESKTOP-U8GG0C0; Database=Barbearia_shop;Integrated Security = SSPI;";
            con.ConnectionString = "server = DESKTOP-U8GG0C0; Database = Barbearia_shop; Integrated Security = SSPI;";
            //server = localhost; Database = BARBEAIRA; Integrated Security = SSPI;

        }

        //Metodos Conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {

                con.Open();

            }
            return con;
        }

        //Medodo Desconectar
        public  void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {

                con.Close();

            }

        }

    }
}
