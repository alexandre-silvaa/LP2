
namespace PTesteClasse.Forms
{
    partial class frmHorista
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
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtDataEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtNumHoras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHome
            // 
            this.gbxHome.Controls.Add(this.rbtnNao);
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHome.Location = new System.Drawing.Point(499, 24);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(197, 102);
            this.gbxHome.TabIndex = 17;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Trabalha Home Office?";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(6, 55);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(52, 21);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Checked = true;
            this.rbtnSim.Location = new System.Drawing.Point(6, 27);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(52, 21);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // txtDataEntradaEmpresa
            // 
            this.txtDataEntradaEmpresa.Location = new System.Drawing.Point(198, 131);
            this.txtDataEntradaEmpresa.Name = "txtDataEntradaEmpresa";
            this.txtDataEntradaEmpresa.Size = new System.Drawing.Size(98, 20);
            this.txtDataEntradaEmpresa.TabIndex = 16;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(198, 79);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(138, 20);
            this.txtSalarioMensal.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(198, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 14;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(198, 24);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(138, 20);
            this.txtMatricula.TabIndex = 13;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(30, 132);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(158, 17);
            this.lblDataEntrada.TabIndex = 12;
            this.lblDataEntrada.Text = "Data Entrada Empresa";
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMensal.Location = new System.Drawing.Point(30, 79);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(121, 17);
            this.lblSalarioMensal.TabIndex = 11;
            this.lblSalarioMensal.Text = "Salário por Horas";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(30, 51);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 17);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(30, 24);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(66, 17);
            this.lblMatricula.TabIndex = 9;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtNumHoras
            // 
            this.txtNumHoras.Location = new System.Drawing.Point(198, 105);
            this.txtNumHoras.Name = "txtNumHoras";
            this.txtNumHoras.Size = new System.Drawing.Size(98, 20);
            this.txtNumHoras.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Número de Horas";
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(198, 157);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(98, 20);
            this.txtDiasFalta.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Dias de Falta";
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstanciar.Location = new System.Drawing.Point(499, 137);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(197, 40);
            this.btnInstanciar.TabIndex = 22;
            this.btnInstanciar.Text = "Instanciar";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            this.btnInstanciar.Click += new System.EventHandler(this.btnInstanciar_Click);
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 201);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtDataEntradaEmpresa);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmHorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fomulário de Horista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtDataEntradaEmpresa;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtNumHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInstanciar;
    }
}