using ProjetoHD.Apresentacao;
using ProjetoHD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHD
{
    public partial class LoginCadastro : Form
    {
        public LoginCadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //ao clicar no botão cadastro abre a form para cadatrar 
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //instanciando form cadastro
            CadastreSe cad = new CadastreSe();
            cad.Show();

        }
        
        //configurando botão sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            //fecha o programa
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BEMVINDO bv = new BEMVINDO();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, Verifique Login e Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
