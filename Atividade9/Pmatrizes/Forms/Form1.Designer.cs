namespace Pmatrizes
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
            this.btnInverterVetor = new System.Windows.Forms.Button();
            this.btnArmazem = new System.Windows.Forms.Button();
            this.btnTamanhoString = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnExercicio6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInverterVetor
            // 
            this.btnInverterVetor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverterVetor.Location = new System.Drawing.Point(85, 61);
            this.btnInverterVetor.Margin = new System.Windows.Forms.Padding(4);
            this.btnInverterVetor.Name = "btnInverterVetor";
            this.btnInverterVetor.Size = new System.Drawing.Size(219, 98);
            this.btnInverterVetor.TabIndex = 0;
            this.btnInverterVetor.Text = "Inverte &Vetor";
            this.btnInverterVetor.UseVisualStyleBackColor = true;
            this.btnInverterVetor.Click += new System.EventHandler(this.BtnInverterVetor_Click);
            // 
            // btnArmazem
            // 
            this.btnArmazem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArmazem.Location = new System.Drawing.Point(312, 61);
            this.btnArmazem.Margin = new System.Windows.Forms.Padding(4);
            this.btnArmazem.Name = "btnArmazem";
            this.btnArmazem.Size = new System.Drawing.Size(219, 98);
            this.btnArmazem.TabIndex = 1;
            this.btnArmazem.Text = "&Armazém de Mercadorias";
            this.btnArmazem.UseVisualStyleBackColor = true;
            this.btnArmazem.Click += new System.EventHandler(this.BtnArmazem_Click);
            // 
            // btnTamanhoString
            // 
            this.btnTamanhoString.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamanhoString.Location = new System.Drawing.Point(539, 61);
            this.btnTamanhoString.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamanhoString.Name = "btnTamanhoString";
            this.btnTamanhoString.Size = new System.Drawing.Size(219, 98);
            this.btnTamanhoString.TabIndex = 2;
            this.btnTamanhoString.Text = "Tamanho da &String";
            this.btnTamanhoString.UseVisualStyleBackColor = true;
            this.btnTamanhoString.Click += new System.EventHandler(this.BtnTamanhoString_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrayList.Location = new System.Drawing.Point(85, 167);
            this.btnArrayList.Margin = new System.Windows.Forms.Padding(4);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(219, 98);
            this.btnArrayList.TabIndex = 3;
            this.btnArrayList.Text = "Array &List";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.Location = new System.Drawing.Point(312, 167);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(219, 98);
            this.btnMedia.TabIndex = 4;
            this.btnMedia.Text = "&Calcular Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnExercicio6
            // 
            this.btnExercicio6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio6.Location = new System.Drawing.Point(539, 167);
            this.btnExercicio6.Margin = new System.Windows.Forms.Padding(4);
            this.btnExercicio6.Name = "btnExercicio6";
            this.btnExercicio6.Size = new System.Drawing.Size(219, 98);
            this.btnExercicio6.TabIndex = 5;
            this.btnExercicio6.Text = "&Exercício 6";
            this.btnExercicio6.UseVisualStyleBackColor = true;
            this.btnExercicio6.Click += new System.EventHandler(this.btnExercicio6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 343);
            this.Controls.Add(this.btnExercicio6);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnTamanhoString);
            this.Controls.Add(this.btnArmazem);
            this.Controls.Add(this.btnInverterVetor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInverterVetor;
        private System.Windows.Forms.Button btnArmazem;
        private System.Windows.Forms.Button btnTamanhoString;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnExercicio6;
    }
}

