using System;
using System.Windows.Forms;

namespace anagrama
{
    public partial class frm_pause : Form
    {
        public frm_pause()
        {
            InitializeComponent();
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o jogo?", "Saída",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }

            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
