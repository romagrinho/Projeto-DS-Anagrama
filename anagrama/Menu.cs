using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using anagrama.DAO;
using anagrama.DTO;

namespace anagrama
{
    public partial class frm_menu : Form
    {
       
        public frm_menu()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void TypeWords(string strInput)
        {
            string[] ArrWords = strInput.Split(' ');

            Task t = Task.Run(() =>
            {

                foreach (string strWord in ArrWords)
                {

                    foreach (char chrLetter in strWord)
                    {

                        Thread.Sleep(100);

                    }

                    Thread.Sleep(250);
                }
            });

            t.Wait();

        }

        private void lbl_anagrama_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(lblTitle.Text))
            {
                TypeWords(lblTitle.Text);
            }

        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            if (cmb_dificuldades.SelectedIndex == 0 || txtxPlayerNome.Text != "")
            {
                var player = new PlayerDTO();
                player.Nome = txtxPlayerNome.Text;
                player.Tempo = 0;

                PlayerDAO.playerInsert(player);

                this.Hide();
                frm_fasefacil frmFasefacil = new frm_fasefacil();
                frmFasefacil.Show();
            }

            if (cmb_dificuldades.SelectedIndex == 1 || txtxPlayerNome.Text != "")
            {
                var player = new PlayerDTO();
                player.Nome = txtxPlayerNome.Text;
                player.Tempo = 0;

                PlayerDAO.playerInsert(player);

                frm_fasemedio frm_Fasemedio = new frm_fasemedio();
                frm_Fasemedio.Show();
            }

            if (cmb_dificuldades.SelectedIndex == 2 || txtxPlayerNome.Text != "")
            {
                var player = new PlayerDTO();
                player.Nome = txtxPlayerNome.Text;
                player.Tempo = 0;

                PlayerDAO.playerInsert(player);

                frm_fasedificil frm_Fasedificil = new frm_fasedificil();
                frm_Fasedificil.Show();
            }

            if (cmb_dificuldades.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma dificuldade!", "Lembrete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtxPlayerNome.Text == "") 
            {
                MessageBox.Show("Não se esqueça de inserir seu nome!", "Lembrete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // if (cmb_dificuldades.SelectedIndex >= 0)
            // {
            //     this.Hide();//vai “esconder” o formulário atual
            // }
        }

        private void cmb_dificuldades_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_dificuldades.Text)
            {
                case "Fácil":
                    lbl_dificuldade.Text = "No modo fácil";
                    break;
                case "Médio":
                    lbl_dificuldade.Text = "No modo mediano";
                    break;
                case "Difícil":
                    lbl_dificuldade.Text = "No modo mais difícil";
                    break;
                default:
                    break;
            }
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o jogo?", "Saída",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }


        }

        string[] titleChars = new string[11] {"{", "a", "n", "a", "g", "r", "a", "m", "a", "!", "}"};
        int Count = 0;

        private void TimerTitle_Tick_1(object sender, EventArgs e)
        {
            string title = lblTitle.Text;
            Count++;

            if (Count < 11)
            {
                title += titleChars[Count];
            }
            if (Count >= 40)
            {
                Count = 0;
                title = "{";
            }
            lblTitle.Text = title;     
        }

        private void txtxPlayerNome_TextChanged(object sender, EventArgs e)
        {
            lblNome.Text = $"Olá, {txtxPlayerNome.Text}.";
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            frmRanking frmRanking = new frmRanking();
            frmRanking.Show();
        }
    }

}
