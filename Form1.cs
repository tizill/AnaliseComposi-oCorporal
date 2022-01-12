using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Form que recebe os dados do Preenchimento atravez de parametros da função form1 chamada, faz a analise da composição corporal completo
namespace AnaliseDeComposicaoCorporal
{
    public partial class Form1 : Form
    {
        //Variavies de Inserção
        decimal PesoAtual = 0;
        decimal Altura = 0;
        double FcRespouso;
        double PAS;
        double PAD;
        //Inserção Medidas Cultâneas
        double Subscapular;
        double Tricipital;
        double Bicipital;
        double Peitoral;
        double AxiliarMedia;
        double SupraIliaca;
        double Abdminal;
        double DobraCoxa;
        double Panturrilha;
        double SomDobras;
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
        //Variaveis de Resultado
        double DensidadeCorporal;
        decimal ResulGorduraAtual;
        decimal IMC;
        decimal Gordura;
        decimal MassaMagra;
        decimal MassaResidual;
        decimal TMB;

        // 
        public Form1(
            int Id,
            string NomePre,
            string PesoAtualPre, 
            string AlturaPre, 
            string SubscapularPre,
            string TricipitalPre,
            string BicipitalPre, 
            string PeitoralPre, 
            string AxiliarMediaPre, 
            string SupraIliacaPre, 
            string AbdminalPre, 
            string DobraCoxaPre, 
            string PanturrilhaPre,  
            string SomDobrasPre,
            string ResulGorduraAtualPre,
            string IMCPre,
            string GorduraPre,
            string MassaMagraPre,
            string MassaResidualPre,
            string TMBPre 
            )
        {
            InitializeComponent();

            // id para Mudar o Titulo de acordo com o arquivo que veio, historico ou inserção
            if(Id == 2)
            {
                LbnTitulo.Text = "Efetuar Alteração";
            }

            LbnNome.Text = NomePre;
            TxtNome.Text = NomePre;
            TxtAltura.Text = AlturaPre;
            TxtPesoAtual.Text = PesoAtualPre;
            TxtSubscapular.Text = SubscapularPre;
            TxtTricipital.Text = TricipitalPre;
            TxtBicipital.Text = BicipitalPre;
            TxtPeitoral.Text = PeitoralPre;
            TxtAxilarMedia.Text = AxiliarMediaPre;
            TxtSupraIliaca.Text = SupraIliacaPre;
            TxtAbdominal.Text = AbdminalPre;
            TxtCoxa.Text = DobraCoxaPre;
            TxtPanturrilha.Text = PanturrilhaPre;
            TxtGorduraAtual.Text = ResulGorduraAtualPre;
            TxtIMC.Text = IMCPre;
            TxtMassaGorda.Text = GorduraPre;
            TxtMassaMuscular.Text = MassaMagraPre;
            TxtMassaResidual.Text = MassaResidualPre;
            TxtMetabolicoBasal.Text = TMBPre;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtPesoAtual_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label44_Click(object sender, EventArgs e)
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
            ChamarFuncoes();
        }

        public void CalcularImc()
        {
            if (TxtPesoAtual.Text != string.Empty && TxtAltura.Text != string.Empty)
            {
                PesoAtual = Convert.ToDecimal(TxtPesoAtual.Text);
                Altura = Convert.ToDecimal(TxtAltura.Text);


                IMC = (PesoAtual / (Altura * Altura));


                TxtIMC.Text = Convert.ToString(decimal.Round(IMC, 1, MidpointRounding.AwayFromZero));
                MessageBox.Show("Avaliação bem sucessida");
            }
            else
            {
                MessageBox.Show("Erro: Não é possivel efetuar a avaliação com valores em branco");
            }
        } 

        public void CalcularGordura()
        {
            if(TxtSubscapular.Text != string.Empty && TxtTricipital.Text != string.Empty && TxtBicipital.Text != string.Empty && TxtPeitoral.Text != string.Empty && TxtAxilarMedia.Text != string.Empty && TxtSupraIliaca.Text != string.Empty && TxtAbdominal.Text != string.Empty && TxtCoxa.Text != string.Empty && TxtPanturrilha.Text != string.Empty)
            {
                Subscapular = Convert.ToDouble(TxtSubscapular.Text);
                Tricipital = Convert.ToDouble(TxtTricipital.Text);
                Bicipital = Convert.ToDouble(TxtBicipital.Text);
                Peitoral = Convert.ToDouble(TxtPeitoral.Text);
                AxiliarMedia = Convert.ToDouble(TxtAxilarMedia.Text);
                SupraIliaca = Convert.ToDouble(TxtSupraIliaca.Text);
                Abdminal = Convert.ToDouble(TxtAbdominal.Text);
                DobraCoxa = Convert.ToDouble(TxtCoxa.Text);
                Panturrilha = Convert.ToDouble(TxtPanturrilha.Text);


                SomDobras = (Subscapular + Tricipital + Bicipital + Peitoral + AxiliarMedia + SupraIliaca + Abdminal + DobraCoxa + Panturrilha);
                DensidadeCorporal = 1.1714 - 0.0671 * Math.Log10(Tricipital + SupraIliaca + Abdminal);


                ResulGorduraAtual = Convert.ToDecimal((((4.95 / DensidadeCorporal) - 4.5) * 100));
                TxtGorduraAtual.Text = Convert.ToString(decimal.Round(ResulGorduraAtual, 1, MidpointRounding.AwayFromZero));
                TxtSomDobras.Text = Convert.ToString(SomDobras);
            }
            else
            {
                MessageBox.Show("Erro: Não é possivel efetuar a avaliação com valores em branco, porfavor revise as informações.");
            }
        }

        public void CalcularMassa()
        {
            if(PesoAtual != 0 && ResulGorduraAtual != 0)
            { 
            Gordura = ((PesoAtual * ResulGorduraAtual)/100);
            MassaMagra = (PesoAtual - Gordura);
            MassaResidual = ((PesoAtual * 241)/1000);
            TMB = (66 + ((138 * PesoAtual) / 10) + (5 * Altura) - ((68 * 19)/10));
            TxtMassaGorda.Text = Convert.ToString(decimal.Round(Gordura, 1, MidpointRounding.AwayFromZero));
            TxtMassaMuscular.Text = Convert.ToString(decimal.Round(MassaMagra, 1, MidpointRounding.AwayFromZero));
            TxtMassaResidual.Text = Convert.ToString(decimal.Round(MassaResidual, 1, MidpointRounding.AwayFromZero));
            TxtMetabolicoBasal.Text = Convert.ToString(decimal.Round(TMB, 1, MidpointRounding.AwayFromZero));
            }
            else 
            {
                MessageBox.Show("Erro: Não é possivel efetuar a avaliação com valores em branco, porfavor revise as informações.");
            }
        }

        public void ChamarFuncoes()
        {
            CalcularImc();
            CalcularGordura();
            CalcularMassa();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(grpBoxInical.Width, grpBoxInical.Height))
            {
                if(TxtNome.Text != string.Empty) { 
                grpBoxInical.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"C:\Users\marce\source\repos\IMAGENS/" + TxtNome.Text +".bmp");
                SalvarArquivo();
                MessageBox.Show("Imagem salva com sucesso");
                }
                else
                {
                    MessageBox.Show("Porfavor, Preencha o Nome do arquivo !", "ERRO: ");
                }
            }
        }


        public void SalvarArquivo()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter SalvarArquivo = new StreamWriter("C:\\Users\\marce\\source\\repos\\Textos/" + TxtNome.Text + ".txt");
                //Write a line of text
                SalvarArquivo.WriteLine("Nome:" + TxtNome.Text);

                SalvarArquivo.WriteLine("PesoAtual:" + TxtPesoAtual.Text);

                SalvarArquivo.WriteLine("Altura:" + TxtAltura.Text);

                SalvarArquivo.WriteLine("SubsCapular:" + TxtSubscapular.Text);

                SalvarArquivo.WriteLine("Tripicital:" + TxtTricipital.Text);

                SalvarArquivo.WriteLine("Bipicital:" + TxtBicipital.Text);

                SalvarArquivo.WriteLine("Peitoral:" + TxtPeitoral.Text);

                SalvarArquivo.WriteLine("AxiliarMedia:" + TxtAxilarMedia.Text);

                SalvarArquivo.WriteLine("SupraIliaca:" + TxtSupraIliaca.Text);

                SalvarArquivo.WriteLine("Abdominal:" + TxtAbdominal.Text);

                SalvarArquivo.WriteLine("Coxa:" + TxtCoxa.Text);

                SalvarArquivo.WriteLine("Panturrilha:" + TxtPanturrilha.Text);

                SalvarArquivo.WriteLine("Som.Dobras:" + TxtSomDobras.Text);

                SalvarArquivo.WriteLine("GorduraAtual:" + TxtGorduraAtual.Text);

                SalvarArquivo.WriteLine("MassaGorda:" + TxtMassaGorda.Text);

                SalvarArquivo.WriteLine("MassaMuscular:" + TxtMassaMuscular.Text);

                SalvarArquivo.WriteLine("MassaResidual:" + TxtMassaResidual.Text);

                SalvarArquivo.WriteLine("IMC:" + TxtIMC.Text);

                SalvarArquivo.WriteLine("MetabolicoBasal:" + TxtMetabolicoBasal.Text);

                //Messagem que o aruivo foi salvo com sucesso !!
                MessageBox.Show("Arquivo Salvo Com sucesso", "Congratulation");
                //Close the file
                SalvarArquivo.Close();
            }
            catch (Exception a)
            {
                Console.WriteLine("Exception: " + a.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void grpBoxInical_Enter(object sender, EventArgs e)
        {

        }
    }
}
