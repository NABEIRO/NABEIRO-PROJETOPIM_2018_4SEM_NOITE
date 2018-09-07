using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHD.DAL
{
    public class LoginDaoComandos
    {
        public bool tem = false;//como falso pois se houver retorno nas linhas do banco de dados então muda para 'true'
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();//instancia da classe do comando sql
        Conexao con = new Conexao();//instancia do metodo de conexão connection
        SqlDataReader dr;//varial dr criada para aguardar o retorno do banco de dados

        public bool verificarLogin(String login, String senha)//informação que veio da classe controle e que puxou do form1
        {
            //procurar no banco de dados login e senha
            //CommandText é usado para inserir o comando SQL 
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login",login);//adiciona o parâmetro recebido no formulário e passado para controle em (login) e passa para (@login)
            cmd.Parameters.AddWithValue("@senha",senha);//adiciona o parâmetro recebido no formulário e passado para controle em (senha) e passa para (@senha)

            try
            {
                cmd.Connection = con.conectar();//metodo connection usado na classe conexao e usado para conectar ao banco
                dr = cmd.ExecuteReader();//pega a informação do banco de dados e guarda na variavel dr
                if(dr.HasRows)//se tem linhas então verdadeiro
                {
                    tem = true;//verdadeiro
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o Banco de Dados!";//se não houver linhas
            }
            return tem;//retorna tem para classe controle
        }
        public String cadastrar(String email, String senha, String confsenha)
        {
            //comandos para inserir
            return mensagem;
        }
    }
}
