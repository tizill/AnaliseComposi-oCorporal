using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Form para enviar todos os dados de medição para O form de efetuar a analise e salvar os dados, passando todas as variaveis atravez de parametros
namespace AnaliseDeComposicaoCorporal
{
    public partial class Preenchimento : Form
    {
        //id para Mudar o Titulo de acordo com o arquivo que veio, historico ou inserção
        int Id;

        //Variavies de Inserção

        string Nome;
        string PesoAtual;
        string Altura;
        string FcRespouso;
        string PAS;
        string PAD;
        //Inserção Medidas Cultâneas

        string Subscapular;
        string Tricipital;
        string Bicipital;
        string Peitoral;
        string AxiliarMedia;
        string SupraIliaca;
        string Abdminal;
        string DobraCoxa;
        string Panturrilha;
        string SomDobras;
        //Inserção Perimetros

        double PeriOmbro;
        double PeriTorax;
        double PeriCintura;
        double PeriAbdomen;
        double PeriQuadril;
        double PeriBraco;
        double PeriAntebraco;
        double PeriCoxa;
        double PeriPanturrilha;
        double RCQ;
        double Classificação;

        string ResulGorduraAtual;
        string IMC;
        string Gordura;
        string MassaMagra;
        string MassaResidual;
        string TMB;
        public Preenchimento()
        {
            InitializeComponent();
        }

        private void TxtFcRepouso_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBicipital_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TxtSupraIliaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtPesoAtual.Text = string.Empty;
            TxtPAS.Text = string.Empty;
            TxtPAD.Text = string.Empty;
            TxtAltura.Text = string.Empty;
            TxtFcRepouso.Text = string.Empty;
        }

        private void BtnConcluir_Click(object sender, EventArgs e)
        {
            PassarValores();


            Form1 EfetuarAnalise = new Form1(
            Id,
            Nome,
            PesoAtual,
            Altura,
            Subscapular,
            Tricipital,
            Bicipital,
            Peitoral,
            AxiliarMedia,
            SupraIliaca,
            Abdminal,
            DobraCoxa,
            Panturrilha,
            SomDobras,
            ResulGorduraAtual,
            IMC,
            Gordura,
            MassaMagra,
            MassaResidual,
            TMB
                );

            EfetuarAnalise.ShowDialog();
            Preenchimento Preenchimento1 = new Preenchimento();
            Preenchimento1.Dispose();
        }


        public void PassarValores()
        {
            Id = 1;
            Nome = TxtNome.Text;
            PesoAtual = TxtPesoAtual.Text;
            Altura = TxtAltura.Text;
            Subscapular = TxtSubscapular.Text;
            Tricipital = TxtTricipital.Text;
            Bicipital = TxtBicipital.Text;
            Peitoral = TxtPeitoral.Text;
            AxiliarMedia = TxtAxilarMedia.Text;
            SupraIliaca = TxtSupraIliaca.Text;
            Abdminal = TxtAbdominal.Text;
            DobraCoxa = TxtCoxa.Text;
            Panturrilha = TxtPanturrilha.Text;
            SomDobras = TxtAltura.Text;
        }
    }
}
