using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using anagrama.DAO;
using anagrama.DTO;

namespace anagrama
{
    public partial class frmRanking : Form
    {
        public frmRanking()
        {
            InitializeComponent();
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {   
            List<PlayerDTO> players = PlayerDAO.playerRanking();

            for (int i = 0; i < players.Count; i++)
            {
                if (i == 5)
                {
                    break;
                }
                switch (i)
                {
                    case 0:
                        lblFirst.Text = $"{players[i].Nome ?? ""}";
                        lblT1.Text = $"{players[i].Tempo.ToString() ?? ""}s";
                        break;
                    case 1:
                        lblSecond.Text = $"{players[i].Nome ?? ""}";
                        lblT2.Text = $"{players[i].Tempo.ToString() ?? ""}s";
                        break;
                    case 2:
                        lblThird.Text = $"{players[i].Nome ?? ""}";
                        lblT3.Text = $"{players[i].Tempo.ToString() ?? ""}s";
                        break;
                    case 3:
                        lblFourth.Text = $"{players[i].Nome ?? ""}";
                        lblT4.Text = $"{players[i].Tempo.ToString() ?? ""}s";
                        break;
                    case 4:
                        lblFifth.Text = $"{players[i].Nome ?? ""}";
                        lblT5.Text = $"{players[i].Tempo.ToString() ?? ""}s";
                        break;
                }
            }
        }
    }
}
