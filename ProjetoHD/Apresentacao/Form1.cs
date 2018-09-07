using ProjetoHD.Apresentacao;
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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //instanciando form cadastro
             CadastreSe cad = new CadastreSe();
            cad.Show();

        }
        
        //configurando botão sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
