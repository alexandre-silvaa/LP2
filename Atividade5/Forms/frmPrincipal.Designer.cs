
namespace PTesteClasse.Forms
{
    partial class frmPrincipal
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
            this.btnMensalista = new System.Windows.Forms.Button();
            this.btnHorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensalista
            // 
            this.btnMensalista.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensalista.Location = new System.Drawing.Point(125, 97);
            this.btnMensalista.Name = "btnMensalista";
            this.btnMensalista.Size = new System.Drawing.Size(131, 40);
            this.btnMensalista.TabIndex = 0;
            this.btnMensalista.Text = "Mensalista";
            this.btnMensalista.UseVisualStyleBackColor = true;
            this.btnMensalista.Click += new System.EventHandler(this.btnMensalista_Click);
            // 
            // btnHorista
            // 
            this.btnHorista.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorista.Location = new System.Drawing.Point(262, 97);
            this.btnHorista.Name = "btnHorista";
            this.btnHorista.Size = new System.Drawing.Size(131, 40);
            this.btnHorista.TabIndex = 1;
            this.btnHorista.Text = "Horista";
            this.btnHorista.UseVisualStyleBackColor = true;
            this.btnHorista.Click += new System.EventHandler(this.btnHorista_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 248);
            this.Controls.Add(this.btnHorista);
            this.Controls.Add(this.btnMensalista);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empregados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMensalista;
        private System.Windows.Forms.Button btnHorista;
    }
}

