namespace anagrama
{
    partial class frm_configuracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_idioma = new System.Windows.Forms.Button();
            this.btn_dificuldade = new System.Windows.Forms.Button();
            this.btn_tema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configurações";
            // 
            // btn_idioma
            // 
            this.btn_idioma.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_idioma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_idioma.Location = new System.Drawing.Point(67, 132);
            this.btn_idioma.Name = "btn_idioma";
            this.btn_idioma.Size = new System.Drawing.Size(168, 62);
            this.btn_idioma.TabIndex = 1;
            this.btn_idioma.Text = "Idioma";
            this.btn_idioma.UseVisualStyleBackColor = false;
            // 
            // btn_dificuldade
            // 
            this.btn_dificuldade.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_dificuldade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dificuldade.Location = new System.Drawing.Point(67, 234);
            this.btn_dificuldade.Name = "btn_dificuldade";
            this.btn_dificuldade.Size = new System.Drawing.Size(168, 62);
            this.btn_dificuldade.TabIndex = 2;
            this.btn_dificuldade.Text = "Dificuldade";
            this.btn_dificuldade.UseVisualStyleBackColor = false;
            // 
            // btn_tema
            // 
            this.btn_tema.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_tema.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tema.Location = new System.Drawing.Point(67, 335);
            this.btn_tema.Name = "btn_tema";
            this.btn_tema.Size = new System.Drawing.Size(168, 62);
            this.btn_tema.TabIndex = 3;
            this.btn_tema.Text = "Tema";
            this.btn_tema.UseVisualStyleBackColor = false;
            this.btn_tema.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1005, 474);
            this.Controls.Add(this.btn_tema);
            this.Controls.Add(this.btn_dificuldade);
            this.Controls.Add(this.btn_idioma);
            this.Controls.Add(this.label1);
            this.Name = "frm_configuracoes";
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_idioma;
        private System.Windows.Forms.Button btn_dificuldade;
        private System.Windows.Forms.Button btn_tema;
    }
}