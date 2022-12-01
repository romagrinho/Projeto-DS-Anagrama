using anagrama.DAO;
using anagrama.DTO;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace anagrama
{

    public partial class frm_fasedificil : Form
    {
        private PalavraDAO dao;        
        int counter = 0;
        int tempo = 0;
        int minuto = 0;
        int segundo = 0;

        public frm_fasedificil()
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

        private void TxtAnagrama_TextChanged_1(object sender, EventArgs e)
        {
            tmrPesquisa.Enabled = false;
            tmrPesquisa.Enabled = true;

            var palavras = dao.ListarPalavras("Difícil");

            if (palavras.Any(palavra => palavra.Palavra.ToLower() == txtAnagrama.Text.ToLower()))
            {
                switch (txtAnagrama.Text)
                {
                    case "ZOO":
                        lblZoo.Text = "ZOO";
                        counter++;
                        break;
                    case "ÓDIO":
                        lblOdio.Text = "ÓDIO";
                        counter++;
                        break;
                    case "CHÁ":
                        lblCha.Text = "CHÁ";
                        counter++;
                        break;
                    case "OCA":
                        lblOca.Text = "OCA";
                        counter++;
                        break;
                    case "OCO":
                        lblOco.Text = "OCO";
                        counter++;
                        break;
                    case "CIO":
                        lblCio.Text = "CIO";
                        counter++;
                        break;
                    case "NOA":
                        lblNoa.Text = "NOA";
                        counter++;
                        break;
                    case "DICA":
                        lblDica.Text = "DICA";
                        counter++;
                        break;
                    case "DOCA":
                        lblDoca.Text = "DOCA";
                        counter++;
                        break;
                    case "DONA":
                        lblDona.Text = "DONA";
                        counter++;
                        break;
                    case "DONO":
                        lblDono.Text = "DONO";
                        counter++;
                        break;
                    case "ZINCO":
                        lblZinco.Text = "ZINCO";
                        counter++;
                        break;
                    case "CANHO":
                        lblCanho.Text = "CANHO";
                        counter++;
                        break;
                    case "COZINHA":
                        lblCozinha.Text = "COZINHA";
                        counter++;
                        break;
                    case "COZINHADO":
                        lblCozinhado.Text = "COZINHADO";
                        counter++;
                        break;
                    default:
                        break;
                }

                txtAnagrama.Text = string.Empty;
            }
            if (lblZoo.Text == "ZOO" && lblOdio.Text == "ÓDIO"
                   && lblCha.Text == "CHÁ" && lblOca.Text == "OCA" && lblOco.Text == "OCO")
            {
                frm_proxnivel frm_Proxnivel = new frm_proxnivel();
                PlayerDTO player = PlayerDAO.playerCatcher();
                PlayerDAO.playerUpdate(player, tempo);
                frm_Proxnivel.Show();
            }
        }

        private void TmrPesquisa_Tick(object sender, EventArgs e)
        {
            tmrPesquisa.Enabled = false;
            //Executa a pesquisa
        }

        private void Frm_fasedificil_Load(object sender, EventArgs e)
        {
            tempo = 120;
            minuto = tempo / 60;
            segundo = tempo % 60;
            lbl_Cronometro.Text = "0" + minuto + ":" + segundo;
        }

        private void tmrCronometro_Tick(object sender, EventArgs e)
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
    }
}