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

    public partial class frm_fasedificil : Form
    {
        private PalavraDAO dao;
        private Stopwatch stopWatch;

        public frm_fasedificil()
        {
            InitializeComponent();
            dao = new PalavraDAO();
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
                        break;
                    case "ÓDIO":
                        lblOdio.Text = "ÓDIO";
                        break;
                    case "CHÁ":
                        lblCha.Text = "CHÁ";
                        break;
                    case "OCA":
                        lblOca.Text = "OCA";
                        break;
                    case "OCO":
                        lblOco.Text = "OCO";
                        break;
                    case "CIO":
                        lblCio.Text = "CIO";
                        break;
                    case "NOA":
                        lblNoa.Text = "NOA";
                        break;
                    case "DICA":
                        lblDica.Text = "DICA";
                        break;
                    case "DOCA":
                        lblDoca.Text = "DOCA";
                        break;
                    case "DONA":
                        lblDona.Text = "DONA";
                        break;
                    case "DONO":
                        lblDono.Text = "DONO";
                        break;
                    case "ZINCO":
                        lblZinco.Text = "ZINCO";
                        break;
                    case "CANHO":
                        lblCanho.Text = "CANHO";
                        break;
                    case "COZINHA":
                        lblCozinha.Text = "COZINHA";
                        break;
                    case "COZINHADO":
                        lblCozinhado.Text = "COZINHADO";
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
                frm_Proxnivel.Show();
            }
        }

        private void TmrPesquisa_Tick(object sender, EventArgs e)
        {
            tmrPesquisa.Enabled = false;
            //Executa a pesquisa
        }
    }
}