using anagrama.DAO;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace anagrama
{

    public partial class frm_fasemedio : Form
    {
        private PalavraDAO dao;       
        int counter = 0;

        public frm_fasemedio()
        {
            InitializeComponent();
            dao = new PalavraDAO();
            lblContador.Text = $"Palavras descobertas: {counter}";
        }
        private void frm_fasemedio_Load(object sender, EventArgs e)
        {
            
        }
        private void Btn_pause_Click(object sender, EventArgs e)
        {
            frm_pause frmpause = new frm_pause();
            frmpause.Show();
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            tmrPesquisa.Enabled = false;
            //Executa a pesquisa
        }

        private void txtAnagrama_TextChanged(object sender, EventArgs e)
        {
            tmrPesquisa.Enabled = false;
            tmrPesquisa.Enabled = true;

            var palavras = dao.ListarPalavras("Médio");

            if (palavras.Any(palavra => palavra.Palavra.ToLower() == txtAnagrama.Text.ToLower()))
            {
                switch (txtAnagrama.Text)
                {
                    case "AMOR":
                        lblAmor.Text = "AMOR";
                        counter++;
                        break;
                    case "ROMA":
                        lblRoma.Text = "ROMA";
                        counter++;
                        break;
                    case "ROMÃ":
                        lblRomã.Text = "ROMÃ";
                        counter++;
                        break;
                    case "ROMANO":
                        lblRomano.Text = "ROMANO";
                        counter++;
                        break;
                    case "AMORA":
                        lblAmora.Text = "AMORA";
                        counter++;
                        break;
                    case "NAMORA":
                        lblNamora.Text = "NAMORA";
                        counter++;
                        break;
                    case "ADORA":
                        lblAdora.Text = "ADORA";
                        counter++;
                        break;
                    case "MORNO":
                        lblMorno.Text = "MORNO";
                        counter++;
                        break;
                    case "MORNA":
                        lblMorna.Text = "MORNA";
                        counter++;
                        break;
                    case "RAMO":
                        lblRamo.Text = "RAMO";
                        counter++;
                        break;
                    default:
                        break;
                }

                txtAnagrama.Text = string.Empty;
            }
            if (lblMorno.Text == "MORNO" && lblAmor.Text == "AMOR"
                    && lblRomano.Text == "ROMANO" && lblAdora.Text == "ADORA" && lblRamo.Text == "RAMO")
            {
                frm_proxnivel frm_Proxnivel = new frm_proxnivel();
                frm_Proxnivel.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }
    }
}
