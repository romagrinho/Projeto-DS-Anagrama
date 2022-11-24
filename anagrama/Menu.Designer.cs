namespace anagrama
{
    partial class frm_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_anagrama = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.cmb_dificuldades = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_anagrama
            // 
            this.lbl_anagrama.AutoSize = true;
            this.lbl_anagrama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anagrama.Font = new System.Drawing.Font("Bauhaus 93", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anagrama.ForeColor = System.Drawing.Color.White;
            this.lbl_anagrama.Location = new System.Drawing.Point(33, 181);
            this.lbl_anagrama.Name = "lbl_anagrama";
            this.lbl_anagrama.Size = new System.Drawing.Size(531, 108);
            this.lbl_anagrama.TabIndex = 1;
            this.lbl_anagrama.Text = "anagrama!";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_start.FlatAppearance.BorderSize = 2;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start.Location = new System.Drawing.Point(570, 124);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(351, 59);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Começar";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(570, 291);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(351, 59);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // cmb_dificuldades
            // 
            this.cmb_dificuldades.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmb_dificuldades.DisplayMember = "Fácil";
            this.cmb_dificuldades.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dificuldades.FormattingEnabled = true;
            this.cmb_dificuldades.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.cmb_dificuldades.Location = new System.Drawing.Point(570, 206);
            this.cmb_dificuldades.Name = "cmb_dificuldades";
            this.cmb_dificuldades.Size = new System.Drawing.Size(351, 63);
            this.cmb_dificuldades.TabIndex = 5;
            this.cmb_dificuldades.Text = "Dificuldade";
            this.cmb_dificuldades.ValueMember = "Fácil";
            this.cmb_dificuldades.SelectedIndexChanged += new System.EventHandler(this.cmb_dificuldades_SelectedIndexChanged);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1005, 474);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_dificuldades);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_anagrama);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_menu";
            this.Text = "Anagrama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_anagrama;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ComboBox cmb_dificuldades;
    }
}

