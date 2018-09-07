using ProjetoHD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHD.Modelo
{
    public class Controle
    {
        //atributos
        public bool tem;
        public String mensagem = "";

        //metodo acessar
        public bool acessar(String login, String senha)//recebe do formulario de cadastro os valores e envia para logindoacomandos fazer a verificação se tem no BD*/
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem  = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
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
