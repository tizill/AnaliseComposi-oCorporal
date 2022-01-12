using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseDeComposicaoCorporal
{
    public partial class Login : Form
    {
        //Variavaeis de login
        string email = "marcelolaranjeira99@gmail.com";
        string senha = "konami2002";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Autenticacao();
            TxtLogin.Text = string.Empty;
            TxtSenha.Text = string.Empty;
        }
        public void Login_Autenticacao()
        {
            string Email = TxtLogin.Text;
            string Senha = TxtSenha.Text;

            if (Email == email && Senha == senha)
            {
                MessageBox.Show("Login Efetuado Com Sucesso, " +
                    "entrando ...");

                Inicio Tela_Principal = new Inicio();
                Tela_Principal.ShowDialog();
                Login login = new Login();
                login.Dispose();
            }
            else
            {
                MessageBox.Show("ERRO: Usuario ou senha invalidos, por favor tente novamente ou verifique...");
            }
        }
    }
}
