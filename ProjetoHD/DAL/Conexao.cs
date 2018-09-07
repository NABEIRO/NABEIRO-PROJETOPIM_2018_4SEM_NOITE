using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHD.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();//classe para conexao com sql
        public Conexao()//contrutor da classe 
        {
            con.ConnectionString = @"Data Source=DESKTOP-RQBQ871;Initial Catalog=ProjetoLogin;Integrated Security=True";//recebe o endereço do banco de dados
        }
        
        public SqlConnection conectar()//metodo de conectar
        {
            if(con.State == System.Data.ConnectionState.Closed)//verificando se a conexão está fechada
            {
                con.Open();//abre a conexão
            }
            return con;
        }
        
        public void deconectar()//metodo de desconectar
        {
            if(con.State == System.Data.ConnectionState.Open)//verifica se a conexão está aberta 
            {
                con.Close();//fecha a conexão
            }
        }
    }
}
