using System;
using System.Windows.Forms;

namespace anagrama
{
    public partial class frm_proxnivel : Form
    {
        public frm_proxnivel()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frm_menu frm_Menu = new frm_menu();
            frm_Menu.Show();
        }

        private void Btn_Avancar_Click(object sender, EventArgs e)
        {
            frm_fasemedio frm_Fasemedio = new frm_fasemedio();
            frm_Fasemedio.Show();
        }
    }
}
