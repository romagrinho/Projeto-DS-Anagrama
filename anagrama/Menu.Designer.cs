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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_anagrama = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_start.Location = new System.Drawing.Point(570, 124);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(351, 59);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Começar";
            this.btn_start.UseVisualStyleBackColor = false;
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_config.Location = new System.Drawing.Point(570, 208);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(351, 59);
            this.btn_config.TabIndex = 3;
            this.btn_config.Text = "Configurar";
            this.btn_config.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Location = new System.Drawing.Point(570, 291);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(351, 59);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1005, 474);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_anagrama);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_menu";
            this.Text = "Anagrama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_anagrama;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_sair;
    }
}

