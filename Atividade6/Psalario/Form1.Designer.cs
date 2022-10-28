namespace Psalario
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQtdFilho = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.btnValida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdFilho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(116, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(354, 22);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(52, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 49);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(84, 16);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nº Filhos";
            // 
            // nudQtdFilho
            // 
            this.nudQtdFilho.Location = new System.Drawing.Point(116, 74);
            this.nudQtdFilho.Name = "nudQtdFilho";
            this.nudQtdFilho.Size = new System.Drawing.Size(67, 22);
            this.nudQtdFilho.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFeminino);
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Location = new System.Drawing.Point(499, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(6, 47);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(83, 20);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(6, 21);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(89, 20);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // btnValida
            // 
            this.btnValida.Location = new System.Drawing.Point(15, 133);
            this.btnValida.Name = "btnValida";
            this.btnValida.Size = new System.Drawing.Size(171, 23);
            this.btnValida.TabIndex = 7;
            this.btnValida.Text = "Validar Desconto";
            this.btnValida.UseVisualStyleBackColor = true;
            this.btnValida.Click += new System.EventHandler(this.btnValida_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnCasado);
            this.panel1.Location = new System.Drawing.Point(499, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 58);
            this.panel1.TabIndex = 8;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(6, 19);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(92, 20);
            this.rbtnCasado.TabIndex = 1;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado(a)";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // lblDados
            // 
            this.lblDados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDados.Location = new System.Drawing.Point(15, 176);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(655, 23);
            this.lblDados.TabIndex = 9;
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(20, 224);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(90, 16);
            this.lblAliquotaINSS.TabIndex = 10;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Location = new System.Drawing.Point(116, 221);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.ReadOnly = true;
            this.txtAliquotaINSS.Size = new System.Drawing.Size(119, 22);
            this.txtAliquotaINSS.TabIndex = 11;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(116, 249);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.ReadOnly = true;
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(119, 22);
            this.txtAliquotaIRPF.TabIndex = 13;
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(20, 252);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(89, 16);
            this.lblAliquotaIRPF.TabIndex = 12;
            this.lblAliquotaIRPF.Text = "Aliquota IRPF";
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Location = new System.Drawing.Point(548, 246);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.ReadOnly = true;
            this.txtDescontoIRPF.Size = new System.Drawing.Size(119, 22);
            this.txtDescontoIRPF.TabIndex = 17;
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(444, 249);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(98, 16);
            this.lblDescontoIRPF.TabIndex = 16;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Location = new System.Drawing.Point(548, 218);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.ReadOnly = true;
            this.txtDescontoINSS.Size = new System.Drawing.Size(119, 22);
            this.txtDescontoINSS.TabIndex = 15;
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(443, 221);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(99, 16);
            this.lblDescontoINSS.TabIndex = 14;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(116, 340);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(119, 22);
            this.txtSalarioLiquido.TabIndex = 21;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(13, 343);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioLiquido.TabIndex = 20;
            this.lblSalarioLiquido.Text = "Salário Liquído";
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Location = new System.Drawing.Point(116, 312);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.ReadOnly = true;
            this.txtSalarioFamilia.Size = new System.Drawing.Size(119, 22);
            this.txtSalarioFamilia.TabIndex = 19;
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(13, 315);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioFamilia.TabIndex = 18;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(116, 46);
            this.mskbxSalario.Mask = "#####.##";
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(83, 22);
            this.mskbxSalario.TabIndex = 22;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(496, 339);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(171, 23);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar Dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 403);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnValida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudQtdFilho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Calcular Salário";
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdFilho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQtdFilho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Button btnValida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.Button btnLimpar;
    }
}

