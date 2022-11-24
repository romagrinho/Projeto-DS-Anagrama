using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anagrama
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o jogo?", "Saída",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            if (cmb_dificuldades.SelectedIndex == 0 == true)
            {
                frm_fasefacil frmFasefacil = new frm_fasefacil();
                frmFasefacil.Show();
            }

            if (cmb_dificuldades.SelectedIndex == 1 == true)
            {
                frm_fasemedio frm_Fasemedio = new frm_fasemedio();
                frm_Fasemedio.Show();
            }

            if (cmb_dificuldades.SelectedIndex == 2 == true)
            {
                frm_fasedificil frm_Fasedificil = new frm_fasedificil();
                frm_Fasedificil.Show();
            }

            if (cmb_dificuldades.SelectedIndex < 0 )
            {
                MessageBox.Show("Selecione uma dificuldade!", "Dficuldade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_dificuldades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
