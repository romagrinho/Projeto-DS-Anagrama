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
            // lbl_pausa
            // 
            this.lbl_pausa.AutoSize = true;
            this.lbl_pausa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pausa.ForeColor = System.Drawing.Color.White;
            this.lbl_pausa.Location = new System.Drawing.Point(378, 9);
            this.lbl_pausa.Name = "lbl_pausa";
            this.lbl_pausa.Size = new System.Drawing.Size(264, 91);
            this.lbl_pausa.TabIndex = 1;
            this.lbl_pausa.Text = "Pausa";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Location = new System.Drawing.Point(373, 124);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(279, 65);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Começar";
            this.btn_start.UseVisualStyleBackColor = false;
            // 
            // btn_config
            // 
            this.btn_config.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_config.Location = new System.Drawing.Point(373, 227);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(279, 65);
            this.btn_config.TabIndex = 3;
            this.btn_config.Text = "Configurações";
            this.btn_config.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Location = new System.Drawing.Point(373, 332);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(279, 65);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // frm_pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1005, 474);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_start);
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
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_sair;
    }
}