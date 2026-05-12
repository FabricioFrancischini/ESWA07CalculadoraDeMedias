namespace CalculadoraDeMedias01
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
            lblNP1 = new Label();
            lblNP2 = new Label();
            lblPIM = new Label();
            txtNP1 = new TextBox();
            txtNP2 = new TextBox();
            txtPIM = new TextBox();
            lblStatus = new Label();
            lblResultadoMS = new Label();
            lblResultadoMF = new Label();
            btnSemestral = new Button();
            btnLimparSemestral = new Button();
            lblExame = new Label();
            txtExame = new TextBox();
            btnLimparFinal = new Button();
            btnFinal = new Button();
            lblResultadoSemestral = new Label();
            lblResultadoFinal = new Label();
            SuspendLayout();
            // 
            // lblNP1
            // 
            lblNP1.AutoSize = true;
            lblNP1.Location = new Point(256, 66);
            lblNP1.Name = "lblNP1";
            lblNP1.Size = new Size(29, 15);
            lblNP1.TabIndex = 0;
            lblNP1.Text = "NP1";
            // 
            // lblNP2
            // 
            lblNP2.AutoSize = true;
            lblNP2.Location = new Point(256, 95);
            lblNP2.Name = "lblNP2";
            lblNP2.Size = new Size(29, 15);
            lblNP2.TabIndex = 1;
            lblNP2.Text = "NP2";
            // 
            // lblPIM
            // 
            lblPIM.AutoSize = true;
            lblPIM.Location = new Point(257, 121);
            lblPIM.Name = "lblPIM";
            lblPIM.Size = new Size(28, 15);
            lblPIM.TabIndex = 2;
            lblPIM.Text = "PIM";
            // 
            // txtNP1
            // 
            txtNP1.Location = new Point(298, 63);
            txtNP1.Name = "txtNP1";
            txtNP1.Size = new Size(100, 23);
            txtNP1.TabIndex = 3;
            // 
            // txtNP2
            // 
            txtNP2.Location = new Point(298, 92);
            txtNP2.Name = "txtNP2";
            txtNP2.Size = new Size(100, 23);
            txtNP2.TabIndex = 4;
            // 
            // txtPIM
            // 
            txtPIM.Location = new Point(298, 121);
            txtPIM.Name = "txtPIM";
            txtPIM.Size = new Size(100, 23);
            txtPIM.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(298, 33);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "STATUS";
            // 
            // lblResultadoMS
            // 
            lblResultadoMS.AutoSize = true;
            lblResultadoMS.Location = new Point(227, 155);
            lblResultadoMS.Name = "lblResultadoMS";
            lblResultadoMS.Size = new Size(58, 15);
            lblResultadoMS.TabIndex = 7;
            lblResultadoMS.Text = "Semestral";
            // 
            // lblResultadoMF
            // 
            lblResultadoMF.AutoSize = true;
            lblResultadoMF.Location = new Point(253, 290);
            lblResultadoMF.Name = "lblResultadoMF";
            lblResultadoMF.Size = new Size(32, 15);
            lblResultadoMF.TabIndex = 8;
            lblResultadoMF.Text = "Final";
            // 
            // btnSemestral
            // 
            btnSemestral.Location = new Point(355, 199);
            btnSemestral.Name = "btnSemestral";
            btnSemestral.Size = new Size(83, 23);
            btnSemestral.TabIndex = 9;
            btnSemestral.Text = "SEMESTRAL";
            btnSemestral.UseVisualStyleBackColor = true;
            btnSemestral.Click += btnSemestral_Click;
            // 
            // btnLimparSemestral
            // 
            btnLimparSemestral.Location = new Point(256, 199);
            btnLimparSemestral.Name = "btnLimparSemestral";
            btnLimparSemestral.Size = new Size(83, 23);
            btnLimparSemestral.TabIndex = 10;
            btnLimparSemestral.Text = "LIMPAR";
            btnLimparSemestral.UseVisualStyleBackColor = true;
            btnLimparSemestral.Click += btnLimparSemestral_Click;
            // 
            // lblExame
            // 
            lblExame.AutoSize = true;
            lblExame.Location = new Point(240, 264);
            lblExame.Name = "lblExame";
            lblExame.Size = new Size(45, 15);
            lblExame.TabIndex = 11;
            lblExame.Text = "EXAME";
            // 
            // txtExame
            // 
            txtExame.Location = new Point(298, 261);
            txtExame.Name = "txtExame";
            txtExame.Size = new Size(100, 23);
            txtExame.TabIndex = 12;
            // 
            // btnLimparFinal
            // 
            btnLimparFinal.Location = new Point(256, 324);
            btnLimparFinal.Name = "btnLimparFinal";
            btnLimparFinal.Size = new Size(75, 23);
            btnLimparFinal.TabIndex = 13;
            btnLimparFinal.Text = "LIMPAR";
            btnLimparFinal.UseVisualStyleBackColor = true;
            btnLimparFinal.Click += btnLimparFinal_Click;
            // 
            // btnFinal
            // 
            btnFinal.Location = new Point(363, 324);
            btnFinal.Name = "btnFinal";
            btnFinal.Size = new Size(75, 23);
            btnFinal.TabIndex = 14;
            btnFinal.Text = "FINAL";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            // 
            // lblResultadoSemestral
            // 
            lblResultadoSemestral.BackColor = Color.White;
            lblResultadoSemestral.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoSemestral.Location = new Point(298, 154);
            lblResultadoSemestral.Name = "lblResultadoSemestral";
            lblResultadoSemestral.Size = new Size(100, 23);
            lblResultadoSemestral.TabIndex = 16;
            lblResultadoSemestral.Text = "0.0";
            // 
            // lblResultadoFinal
            // 
            lblResultadoFinal.BackColor = Color.White;
            lblResultadoFinal.BorderStyle = BorderStyle.FixedSingle;
            lblResultadoFinal.Location = new Point(298, 290);
            lblResultadoFinal.Name = "lblResultadoFinal";
            lblResultadoFinal.Size = new Size(100, 23);
            lblResultadoFinal.TabIndex = 17;
            lblResultadoFinal.Text = "0.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(811, 454);
            Controls.Add(lblResultadoFinal);
            Controls.Add(lblResultadoSemestral);
            Controls.Add(btnFinal);
            Controls.Add(btnLimparFinal);
            Controls.Add(txtExame);
            Controls.Add(lblExame);
            Controls.Add(btnLimparSemestral);
            Controls.Add(btnSemestral);
            Controls.Add(lblResultadoMF);
            Controls.Add(lblResultadoMS);
            Controls.Add(lblStatus);
            Controls.Add(txtPIM);
            Controls.Add(txtNP2);
            Controls.Add(txtNP1);
            Controls.Add(lblPIM);
            Controls.Add(lblNP2);
            Controls.Add(lblNP1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNP1;
        private Label lblNP2;
        private Label lblPIM;
        private TextBox txtNP1;
        private TextBox txtNP2;
        private TextBox txtPIM;
        private Label lblStatus;
        private Label lblResultadoMS;
        private Label lblResultadoMF;
        private Button btnSemestral;
        private Button btnLimparSemestral;
        private Label lblExame;
        private TextBox txtExame;
        private Button btnLimparFinal;
        private Button btnFinal;
        private Label lblResultadoSemestral;
        private Label lblResultadoFinal;
    }
}
