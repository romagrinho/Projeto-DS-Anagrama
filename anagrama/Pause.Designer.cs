namespace anagrama
{
    partial class frm_pause
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
            this.lbl_pausa = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            // lbl_pausa
            // 
            this.lbl_pausa.AutoSize = true;
            this.lbl_pausa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pausa.Font = new System.Drawing.Font("Cascadia Code SemiBold", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pausa.ForeColor = System.Drawing.Color.Lime;
            this.lbl_pausa.Location = new System.Drawing.Point(140, 43);
            this.lbl_pausa.Name = "lbl_pausa";
            this.lbl_pausa.Size = new System.Drawing.Size(209, 79);
            this.lbl_pausa.TabIndex = 1;
            this.lbl_pausa.Text = "Pausa";
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_voltar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_voltar.FlatAppearance.BorderSize = 2;
            this.btn_voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_voltar.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.Lime;
            this.btn_voltar.Location = new System.Drawing.Point(107, 218);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(279, 65);
            this.btn_voltar.TabIndex = 2;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.Btn_voltar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_sair.FlatAppearance.BorderSize = 2;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Lime;
            this.btn_sair.Location = new System.Drawing.Point(107, 298);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(279, 65);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(-278, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1087, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "P4Mth\'25rQyBP4MP4MtP4Mth\'25rQyBh\'25rQyBP4Mth\'25rQyBP4Mth\'25rQyBP4Mth\'25rQyBtP4Mth" +
    "\'25rQyBh\'25rQyBP4Mth\'25rQyBP4Mth\'25rQyP4Mth\'25rQyBP4Mth\'25rQyBP4Mth\'25rQyBP4Mth\'" +
    "25rQyBBP4Mth\'25rQyB";
            // 
            // frm_pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(473, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_pausa);
            this.Controls.Add(this.label1);
            this.Name = "frm_pause";
            this.Text = "Pause";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pausa;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label2;
    }
}