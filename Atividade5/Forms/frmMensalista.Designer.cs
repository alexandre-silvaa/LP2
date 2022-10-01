
namespace PTesteClasse.Forms
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.txtDataEntradaEmpresa = new System.Windows.Forms.TextBox();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(28, 31);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(66, 17);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(28, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMensal.Location = new System.Drawing.Point(28, 86);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(103, 17);
            this.lblSalarioMensal.TabIndex = 2;
            this.lblSalarioMensal.Text = "Salário Mensal";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(28, 113);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(158, 17);
            this.lblDataEntrada.TabIndex = 3;
            this.lblDataEntrada.Text = "Data Entrada Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(196, 31);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(138, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Location = new System.Drawing.Point(196, 86);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(138, 20);
            this.txtSalarioMensal.TabIndex = 6;
            // 
            // txtDataEntradaEmpresa
            // 
            this.txtDataEntradaEmpresa.Location = new System.Drawing.Point(196, 112);
            this.txtDataEntradaEmpresa.Name = "txtDataEntradaEmpresa";
            this.txtDataEntradaEmpresa.Size = new System.Drawing.Size(98, 20);
            this.txtDataEntradaEmpresa.TabIndex = 7;
            // 
            // gbxHome
            // 
            this.gbxHome.Controls.Add(this.rbtnNao);
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHome.Location = new System.Drawing.Point(497, 31);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(197, 102);
            this.gbxHome.TabIndex = 8;
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
            // btnInstanciar
            // 
            this.btnInstanciar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstanciar.Location = new System.Drawing.Point(154, 178);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(209, 40);
            this.btnInstanciar.TabIndex = 9;
            this.btnInstanciar.Text = "Instanciar";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            this.btnInstanciar.Click += new System.EventHandler(this.btnInstanciar_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametros.Location = new System.Drawing.Point(369, 178);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(209, 40);
            this.btnParametros.TabIndex = 10;
            this.btnParametros.Text = "Instanciar com Parâmetros";
            this.btnParametros.UseVisualStyleBackColor = true;
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 251);
            this.Controls.Add(this.btnParametros);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtDataEntradaEmpresa);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensalista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.TextBox txtDataEntradaEmpresa;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button btnInstanciar;
        private System.Windows.Forms.Button btnParametros;
    }
}