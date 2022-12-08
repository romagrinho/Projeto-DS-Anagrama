using anagrama.DAO;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using anagrama.DTO;


namespace anagrama
{
    public partial class frm_fasefacil : Form
    {
        private PalavraDAO dao;      
        int counter = 0;
        int tempo = 0;
        int minuto = 0;
        int segundo = 0;


        public frm_fasefacil()
        {
            InitializeComponent();
            dao = new PalavraDAO();
            lblContador.Text = $"Palavras descobertas: {counter}";
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

            if (palavras.Any(palavra => palavra.Palavra.ToLower() == txtAnagrama.Text.ToLower()))
            {
                switch (txtAnagrama.Text)
                {
                    case "ACNE":
                        lblAcne.Text = "ACNE";
                        counter++;
                        break;
                    case "CANAL":
                        lblCanal.Text = "CANAL";
                        counter++;
                        break;
                    case "CANELA":
                        lblCanela.Text = "CANELA";
                        counter++;
                        break;
                    case "CELA":
                        lblCela.Text = "CELA";
                        counter++;
                        break;
                    case "ACENA":
                        lblAcena.Text = "ACENA";
                        counter++;
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
                PlayerDTO player = PlayerDAO.currentPlayerCatcher();
                PlayerDAO.playerUpdate(player, tempo);
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
            tempo = 120;
            minuto = tempo / 60;
            segundo = tempo % 60;
            lbl_Cronometro.Text = "0" + minuto + ":" + segundo;

        }

        private void TmrCronometro_Tick(object sender, EventArgs e)
        {
            segundo--;
            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            lbl_Cronometro.Text = "0" + minuto + ":" + segundo;                       

            if (minuto == 0 && segundo == 0)
            {
                tmrCronometro.Enabled = false;
            }
        }

        private void LblContador_Click(object sender, EventArgs e)
        {

        }
    }
}