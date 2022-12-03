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
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.cmb_dificuldades = new System.Windows.Forms.ComboBox();
            this.timerTitle = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_dificuldade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRanking = new System.Windows.Forms.Button();
            this.txtxPlayerNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Cascadia Code SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Lime;
            this.btn_start.Location = new System.Drawing.Point(570, 114);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(351, 59);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Começar";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // cmb_dificuldades
            // 
            this.cmb_dificuldades.AllowDrop = true;
            this.cmb_dificuldades.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_dificuldades.DisplayMember = "Fácil";
            this.cmb_dificuldades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_dificuldades.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dificuldades.ForeColor = System.Drawing.Color.Lime;
            this.cmb_dificuldades.FormattingEnabled = true;
            this.cmb_dificuldades.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.cmb_dificuldades.Location = new System.Drawing.Point(515, 384);
            this.cmb_dificuldades.Name = "cmb_dificuldades";
            this.cmb_dificuldades.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_dificuldades.Size = new System.Drawing.Size(351, 43);
            this.cmb_dificuldades.TabIndex = 5;
            this.cmb_dificuldades.Text = "Dificuldade";
            this.cmb_dificuldades.ValueMember = "Fácil";
            this.cmb_dificuldades.SelectedIndexChanged += new System.EventHandler(this.cmb_dificuldades_SelectedIndexChanged);
            // 
            // timerTitle
            // 
            this.timerTitle.Enabled = true;
            this.timerTitle.Tick += new System.EventHandler(this.TimerTitle_Tick_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code SemiLight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(31, 180);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 85);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "{";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Cascadia Code SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Lime;
            this.btn_sair.Location = new System.Drawing.Point(570, 274);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(351, 59);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click_1);
            // 
            // lbl_dificuldade
            // 
            this.lbl_dificuldade.AutoSize = true;
            this.lbl_dificuldade.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dificuldade.ForeColor = System.Drawing.Color.Lime;
            this.lbl_dificuldade.Location = new System.Drawing.Point(43, 274);
            this.lbl_dificuldade.Name = "lbl_dificuldade";
            this.lbl_dificuldade.Size = new System.Drawing.Size(0, 17);
            this.lbl_dificuldade.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(-41, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1087, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "P4Mth\'25rQyBP4MP4MtP4Mth\'25rQyBh\'25rQyBP4Mth\'25rQyBP4Mth\'25rQyBP4Mth\'25rQyBtP4Mth" +
    "\'25rQyBh\'25rQyBP4Mth\'25rQyBP4Mth\'25rQyP4Mth\'25rQyBP4Mth\'25rQyBP4Mth\'25rQyBP4Mth\'" +
    "25rQyBBP4Mth\'25rQyB";
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnRanking.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnRanking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRanking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Font = new System.Drawing.Font("Cascadia Code SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.Color.Lime;
            this.btnRanking.Location = new System.Drawing.Point(570, 194);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(351, 59);
            this.btnRanking.TabIndex = 44;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // txtxPlayerNome
            // 
            this.txtxPlayerNome.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtxPlayerNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtxPlayerNome.Font = new System.Drawing.Font("Cascadia Code", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxPlayerNome.ForeColor = System.Drawing.Color.Lime;
            this.txtxPlayerNome.Location = new System.Drawing.Point(128, 384);
            this.txtxPlayerNome.Name = "txtxPlayerNome";
            this.txtxPlayerNome.Size = new System.Drawing.Size(356, 39);
            this.txtxPlayerNome.TabIndex = 45;
            this.txtxPlayerNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtxPlayerNome.TextChanged += new System.EventHandler(this.txtxPlayerNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.Lime;
            this.lblNome.Location = new System.Drawing.Point(128, 365);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 46;
            this.lblNome.Text = "Nome";
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1005, 474);
            this.ControlBox = false;
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtxPlayerNome);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_dificuldade);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.cmb_dificuldades);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Anagrama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmb_dificuldades;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_dificuldade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerTitle;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.TextBox txtxPlayerNome;
        private System.Windows.Forms.Label lblNome;
    }
}

