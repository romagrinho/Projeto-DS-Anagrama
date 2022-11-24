using anagrama.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace anagrama
{

    public partial class frm_fasemedio : Form
    {
        private PalavraDAO dao;
        private Stopwatch stopWatch;

        public frm_fasemedio() 
        {
            InitializeComponent();
            dao = new PalavraDAO();
        }   
        private void frm_fasemedio_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
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
                        break;
                    case "ROMA":
                        lblRoma.Text = "ROMA";
                        break;
                    case "ROMÃ":
                        lblRomã.Text = "ROMÃ";
                        break;
                    case "ROMANO":
                        lblRomano.Text = "ROMANO";
                        break;
                    case "AMORA":
                        lblAmora.Text = "AMORA";
                        break;
                    case "NAMORA":
                        lblNamora.Text = "NAMORA";
                        break;
                    case "ADORA":
                        lblAdora.Text = "ADORA";
                        break;
                    case "MORNO":
                        lblMorno.Text = "MORNO";
                        break;
                    case "MORNA":
                        lblMorna.Text = "MORNA";
                        break;
                    case "RAMO":
                        lblRamo.Text = "RAMO";
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
            this.lbl_Cronometro.Text = string.Format("{0:mm\\:ss}", stopWatch.Elapsed);
        }
    }
}
