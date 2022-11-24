namespace anagrama
{
    partial class frm_fasefacil
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
            this.components = new System.ComponentModel.Container();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.lblAcne = new System.Windows.Forms.Label();
            this.lblCela = new System.Windows.Forms.Label();
            this.txtAnagrama = new System.Windows.Forms.TextBox();
            this.txt_letra1 = new System.Windows.Forms.TextBox();
            this.txt_letra2 = new System.Windows.Forms.TextBox();
            this.txt_letra3 = new System.Windows.Forms.TextBox();
            this.txt_letra4 = new System.Windows.Forms.TextBox();
            this.txt_letra5 = new System.Windows.Forms.TextBox();
            this.lblAcena = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.lblCanela = new System.Windows.Forms.Label();
            this.btn_pause = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tmrPesquisa = new System.Windows.Forms.Timer(this.components);
            this.tmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.lbl_Cronometro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nivel.Location = new System.Drawing.Point(429, 9);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(172, 73);
            this.lbl_nivel.TabIndex = 0;
            this.lbl_nivel.Text = "Fácil";
            // 
            // lblAcne
            // 
            this.lblAcne.AutoSize = true;
            this.lblAcne.BackColor = System.Drawing.Color.Transparent;
            this.lblAcne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcne.ForeColor = System.Drawing.Color.White;
            this.lblAcne.Location = new System.Drawing.Point(141, 379);
            this.lblAcne.Name = "lblAcne";
            this.lblAcne.Size = new System.Drawing.Size(84, 25);
            this.lblAcne.TabIndex = 11;
            this.lblAcne.Text = "_ _ _ _ ";
            // 
            // lblCela
            // 
            this.lblCela.AutoSize = true;
            this.lblCela.BackColor = System.Drawing.Color.Transparent;
            this.lblCela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCela.ForeColor = System.Drawing.Color.White;
            this.lblCela.Location = new System.Drawing.Point(306, 379);
            this.lblCela.Name = "lblCela";
            this.lblCela.Size = new System.Drawing.Size(84, 25);
            this.lblCela.TabIndex = 12;
            this.lblCela.Text = "_ _ _ _ ";
            // 
            // txtAnagrama
            // 
            this.txtAnagrama.BackColor = System.Drawing.Color.White;
            this.txtAnagrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 117.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnagrama.Location = new System.Drawing.Point(135, 90);
            this.txtAnagrama.Name = "txtAnagrama";
            this.txtAnagrama.Size = new System.Drawing.Size(752, 185);
            this.txtAnagrama.TabIndex = 26;
            this.txtAnagrama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnagrama.TextChanged += new System.EventHandler(this.txtAnagrama_TextChanged);
            // 
            // txt_letra1
            // 
            this.txt_letra1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txt_letra1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_letra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_letra1.Location = new System.Drawing.Point(56, 320);
            this.txt_letra1.Name = "txt_letra1";
            this.txt_letra1.ReadOnly = true;
            this.txt_letra1.Size = new System.Drawing.Size(126, 26);
            this.txt_letra1.TabIndex = 31;
            this.txt_letra1.Text = "A";
            this.txt_letra1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_letra2
            // 
            this.txt_letra2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txt_letra2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_letra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_letra2.Location = new System.Drawing.Point(208, 320);
            this.txt_letra2.Name = "txt_letra2";
            this.txt_letra2.ReadOnly = true;
            this.txt_letra2.Size = new System.Drawing.Size(126, 26);
            this.txt_letra2.TabIndex = 32;
            this.txt_letra2.Text = "C";
            this.txt_letra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_letra3
            // 
            this.txt_letra3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txt_letra3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_letra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_letra3.Location = new System.Drawing.Point(363, 320);
            this.txt_letra3.Name = "txt_letra3";
            this.txt_letra3.ReadOnly = true;
            this.txt_letra3.Size = new System.Drawing.Size(126, 26);
            this.txt_letra3.TabIndex = 33;
            this.txt_letra3.Text = "N";
            this.txt_letra3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_letra4
            // 
            this.txt_letra4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txt_letra4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_letra4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_letra4.Location = new System.Drawing.Point(514, 320);
            this.txt_letra4.Name = "txt_letra4";
            this.txt_letra4.ReadOnly = true;
            this.txt_letra4.Size = new System.Drawing.Size(126, 26);
            this.txt_letra4.TabIndex = 34;
            this.txt_letra4.Text = "E";
            this.txt_letra4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_letra5
            // 
            this.txt_letra5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txt_letra5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_letra5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_letra5.Location = new System.Drawing.Point(666, 320);
            this.txt_letra5.Name = "txt_letra5";
            this.txt_letra5.ReadOnly = true;
            this.txt_letra5.Size = new System.Drawing.Size(126, 26);
            this.txt_letra5.TabIndex = 35;
            this.txt_letra5.Text = "L";
            this.txt_letra5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAcena
            // 
            this.lblAcena.AutoSize = true;
            this.lblAcena.BackColor = System.Drawing.Color.Transparent;
            this.lblAcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcena.ForeColor = System.Drawing.Color.White;
            this.lblAcena.Location = new System.Drawing.Point(463, 379);
            this.lblAcena.Name = "lblAcena";
            this.lblAcena.Size = new System.Drawing.Size(96, 25);
            this.lblAcena.TabIndex = 13;
            this.lblAcena.Text = "_ _ _ _ _";
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.BackColor = System.Drawing.Color.Transparent;
            this.lblCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanal.ForeColor = System.Drawing.Color.White;
            this.lblCanal.Location = new System.Drawing.Point(621, 379);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(96, 25);
            this.lblCanal.TabIndex = 14;
            this.lblCanal.Text = "_ _ _ _ _";
            // 
            // lblCanela
            // 
            this.lblCanela.AutoSize = true;
            this.lblCanela.BackColor = System.Drawing.Color.Transparent;
            this.lblCanela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanela.ForeColor = System.Drawing.Color.White;
            this.lblCanela.Location = new System.Drawing.Point(771, 379);
            this.lblCanela.Name = "lblCanela";
            this.lblCanela.Size = new System.Drawing.Size(114, 25);
            this.lblCanela.TabIndex = 15;
            this.lblCanela.Text = "_ _ _ _ _ _";
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Location = new System.Drawing.Point(900, 420);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(93, 31);
            this.btn_pause.TabIndex = 36;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.Btn_pause_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(824, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(126, 26);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "A";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrPesquisa
            // 
            this.tmrPesquisa.Tick += new System.EventHandler(this.tmrPesquisa_Tick);
            // 
            // tmrCronometro
            // 
            this.tmrCronometro.Enabled = true;
            this.tmrCronometro.Tick += new System.EventHandler(this.TmrCronometro_Tick);
            // 
            // lbl_Cronometro
            // 
            this.lbl_Cronometro.AutoSize = true;
            this.lbl_Cronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cronometro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Cronometro.Location = new System.Drawing.Point(12, 9);
            this.lbl_Cronometro.Name = "lbl_Cronometro";
            this.lbl_Cronometro.Size = new System.Drawing.Size(112, 42);
            this.lbl_Cronometro.TabIndex = 41;
            this.lbl_Cronometro.Text = "00:00";
            // 
            // frm_fasefacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1005, 474);
            this.Controls.Add(this.lbl_Cronometro);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.txt_letra5);
            this.Controls.Add(this.txt_letra4);
            this.Controls.Add(this.txt_letra3);
            this.Controls.Add(this.txt_letra2);
            this.Controls.Add(this.txt_letra1);
            this.Controls.Add(this.txtAnagrama);
            this.Controls.Add(this.lblCanela);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.lblAcena);
            this.Controls.Add(this.lblCela);
            this.Controls.Add(this.lblAcne);
            this.Controls.Add(this.lbl_nivel);
            this.KeyPreview = true;
            this.Name = "frm_fasefacil";
            this.Text = "Level - Fácil";
            this.Load += new System.EventHandler(this.Frm_fasefacil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Label lblAcne;
        private System.Windows.Forms.Label lblCela;
        private System.Windows.Forms.TextBox txtAnagrama;
        private System.Windows.Forms.TextBox txt_letra1;
        private System.Windows.Forms.TextBox txt_letra2;
        private System.Windows.Forms.TextBox txt_letra3;
        private System.Windows.Forms.TextBox txt_letra4;
        private System.Windows.Forms.TextBox txt_letra5;
        private System.Windows.Forms.Label lblAcena;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.Label lblCanela;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer tmrPesquisa;
        private System.Windows.Forms.Timer tmrCronometro;
        private System.Windows.Forms.Label lbl_Cronometro;
    }
}