using anagrama.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace anagrama
{
    public partial class frm_fasefacil : Form
    {
        private PalavraDAO dao;
        private Stopwatch stopWatch;

        public frm_fasefacil()
        {
            InitializeComponent();
            dao = new PalavraDAO();
        }

        private void Btn_pause_Click(object sender, EventArgs e)
        {
            frm_pause frmpause = new frm_pause();
            frmpause.Show();
        }

        private void txtAnagrama_TextChanged(object sender, EventArgs e)
        {
            tmrPesquisa.Enabled = false;
            tmrPesquisa.Enabled = true;

            var palavras = dao.ListarPalavras("Fácil");

            if(palavras.Any(palavra => palavra.Palavra.ToLower() == txtAnagrama.Text.ToLower()))
            {
                switch (txtAnagrama.Text)
                {
                    case "ACNE":
                        lblAcne.Text = "ACNE";
                        break;
                    case "CANAL":
                        lblCanal.Text = "CANAL";
                        break;
                    case "CANELA":
                        lblCanela.Text = "CANELA";
                        break;
                    case "CELA":
                        lblCela.Text = "CELA";
                        break;
                    case "ACENA":
                        lblAcena.Text = "ACENA";
                        break;
                    default:
                        break; 
                }

                txtAnagrama.Text = string.Empty;
            }
            if (lblAcena.Text == "ACENA" && lblAcne.Text == "ACNE"
                    && lblCanal.Text == "CANAL" && lblCanela.Text == "CANELA" && lblCela.Text == "CELA")
            {
                frm_proxnivel frm_Proxnivel = new frm_proxnivel();
                frm_Proxnivel.Show();
            }

        }

        private void tmrPesquisa_Tick(object sender, EventArgs e)
        {
            tmrPesquisa.Enabled = false;
            //Executa a pesquisa
        }

        private void Frm_fasefacil_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
            stopWatch.Start();
        }

        private void TmrCronometro_Tick(object sender, EventArgs e)
        {
            this.lbl_Cronometro.Text = string.Format("{0:mm\\:ss}", stopWatch.Elapsed);
        }
    }
}