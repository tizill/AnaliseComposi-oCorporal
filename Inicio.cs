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

namespace AnaliseDeComposicaoCorporal
{
    public partial class Inicio : Form
    {
        int i = 0;
        int Id = 2;
        private string line;
        public Inicio()
        {
            InitializeComponent();
            Historico();
        }

        private void efetuarNovaAnaliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preenchimento Efetuar_Analise = new Preenchimento();
            Efetuar_Analise.ShowDialog();
            Inicio Inicio1 = new Inicio();
            Inicio1.Dispose();

        }
        public void Historico()
        {
            string[] arquivos = Directory.GetFiles("C:\\Users\\marce\\source\\repos\\Textos", "*.txt", SearchOption.AllDirectories);

            foreach (string arq in arquivos)
            {
                string pessoa = arq.Substring(35);

                dataGridView1.Rows.Add(new object[] { pessoa });
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("Abrindo Arquivo de Historico, cuidado para não efetuar nenhuma alteração acidentalmente !", "CUIDADO ARQUIVO SALVO");
                string Nome;
                string PesoAtual;
                string Altura;

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

                string ResulGorduraAtual;
                string IMC;
                string Gordura;
                string MassaMagra;
                string MassaResidual;
                string TMB;
                //TODO - Button Clicked - Execute Code Here
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader("C:\\Users\\marce\\source\\repos\\Textos/" + dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    //Read the first line of text and write the line to console window
                    line = sr.ReadLine();
                    string[] line1 = line.Split(':');
                    Nome = line1[1];

                    line = sr.ReadLine();
                    string[] line2 = line.Split(':');
                    PesoAtual = line2[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line3 = line.Split(':');
                    Altura = line3[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line4 = line.Split(':');
                    Subscapular = line4[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line5 = line.Split(':');
                    Tricipital = line5[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line6 = line.Split(':');
                    Bicipital = line6[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line7 = line.Split(':');
                    Peitoral = line7[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line8 = line.Split(':');
                    AxiliarMedia = line8[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line9 = line.Split(':');
                    SupraIliaca = line9[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line10 = line.Split(':');
                    Abdminal = line10[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line11 = line.Split(':');
                    DobraCoxa = line11[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line12 = line.Split(':');
                    Panturrilha = line12[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line13 = line.Split(':');
                    SomDobras = line13[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line14 = line.Split(':');
                    ResulGorduraAtual = line14[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line15 = line.Split(':');
                    Gordura = line15[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line16 = line.Split(':');
                    MassaMagra = line16[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line17 = line.Split(':');
                    MassaResidual = line17[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line18 = line.Split(':');
                    IMC = line18[1];

                    //Read the next line and write the line to console window
                    line = sr.ReadLine();
                    string[] line19 = line.Split(':');
                    TMB = line19[1];

                    


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
                    Inicio Inicio1 = new Inicio();
                    Inicio1.Dispose();
              
                    //close the file
                    sr.Close();
                    Console.ReadLine();
                   

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
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
