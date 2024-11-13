namespace estudo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnZero = new Button();
            btnComfirma = new Button();
            btnCorrigir = new Button();
            btnBranco = new Button();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // btnUm
            // 
            btnUm.Location = new Point(590, 203);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(72, 68);
            btnUm.TabIndex = 0;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(512, 203);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(72, 68);
            btnDois.TabIndex = 1;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(434, 203);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(72, 68);
            btnTres.TabIndex = 2;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(590, 129);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(72, 68);
            btnQuatro.TabIndex = 3;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(512, 129);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(72, 68);
            btnCinco.TabIndex = 4;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(434, 129);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(72, 68);
            btnSeis.TabIndex = 5;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(590, 55);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(72, 68);
            btnSete.TabIndex = 6;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(512, 55);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(72, 68);
            btnOito.TabIndex = 7;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(434, 55);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(72, 68);
            btnNove.TabIndex = 8;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(512, 277);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(72, 68);
            btnZero.TabIndex = 9;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnComfirma
            // 
            btnComfirma.Location = new Point(512, 351);
            btnComfirma.Name = "btnComfirma";
            btnComfirma.Size = new Size(90, 68);
            btnComfirma.TabIndex = 10;
            btnComfirma.Text = "CONFIRMA";
            btnComfirma.UseVisualStyleBackColor = true;
            btnComfirma.Click += btnComfirma_Click;
            // 
            // btnCorrigir
            // 
            btnCorrigir.Location = new Point(608, 351);
            btnCorrigir.Name = "btnCorrigir";
            btnCorrigir.Size = new Size(90, 68);
            btnCorrigir.TabIndex = 11;
            btnCorrigir.Text = "CORRIGIR";
            btnCorrigir.UseVisualStyleBackColor = true;
            btnCorrigir.Click += btnCorrigir_Click;
            // 
            // btnBranco
            // 
            btnBranco.Location = new Point(416, 351);
            btnBranco.Name = "btnBranco";
            btnBranco.Size = new Size(90, 68);
            btnBranco.TabIndex = 12;
            btnBranco.Text = "BRANCO";
            btnBranco.UseVisualStyleBackColor = true;
            btnBranco.Click += btnBranco_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(86, 153);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(124, 23);
            txtNumero.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero);
            Controls.Add(btnBranco);
            Controls.Add(btnCorrigir);
            Controls.Add(btnComfirma);
            Controls.Add(btnZero);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnZero;
        private Button btnComfirma;
        private Button btnCorrigir;
        private Button btnBranco;
        private TextBox txtNumero;
    }
}
