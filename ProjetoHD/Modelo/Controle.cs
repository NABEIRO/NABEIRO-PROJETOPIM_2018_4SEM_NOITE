using ProjetoHD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHD.Modelo
{
    public class Controle//classe que faz a comunicação entre as outras classes
    {
        //atributos
        public bool tem;//bool de boleano verdadeiro ou falso(para confirmação no banco de dados)
        public String mensagem = "";

        //metodo acessar
        public bool acessar(String login, String senha)//recebe do formulario de cadastro os valores e envia para logindoacomandos fazer a verificação se tem no BD*/
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem  = loginDao.verificarLogin(login, senha);//parâmetros enviados do formulário para controle e confirmados confirmados em logindaocomandos
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;//string da classe controle recebe a string da classe logindaocomandos
            }
            return tem;
        }

        //metodo cadastrar
        public String cadastrar(String email, String senha, String confsenha)
        {
            return mensagem;
        }
    }

}
