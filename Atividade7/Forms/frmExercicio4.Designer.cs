namespace Pmetodos.Forms
{
    partial class frmExercicio4
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
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnQtdAlfabetico = new System.Windows.Forms.Button();
            this.btnLocalizaEspaco = new System.Windows.Forms.Button();
            this.btnQtdNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(139, 29);
            this.rtxtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(714, 306);
            this.rtxtTexto.TabIndex = 25;
            this.rtxtTexto.Text = "";
            // 
            // btnQtdAlfabetico
            // 
            this.btnQtdAlfabetico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtdAlfabetico.Location = new System.Drawing.Point(599, 343);
            this.btnQtdAlfabetico.Margin = new System.Windows.Forms.Padding(4);
            this.btnQtdAlfabetico.Name = "btnQtdAlfabetico";
            this.btnQtdAlfabetico.Size = new System.Drawing.Size(194, 63);
            this.btnQtdAlfabetico.TabIndex = 24;
            this.btnQtdAlfabetico.Text = "&Quantidades de letras";
            this.btnQtdAlfabetico.UseVisualStyleBackColor = true;
            this.btnQtdAlfabetico.Click += new System.EventHandler(this.btnQtdAlfabetico_Click);
            // 
            // btnLocalizaEspaco
            // 
            this.btnLocalizaEspaco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizaEspaco.Location = new System.Drawing.Point(397, 343);
            this.btnLocalizaEspaco.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocalizaEspaco.Name = "btnLocalizaEspaco";
            this.btnLocalizaEspaco.Size = new System.Drawing.Size(194, 63);
            this.btnLocalizaEspaco.TabIndex = 23;
            this.btnLocalizaEspaco.Text = "&Localizar Espaço";
            this.btnLocalizaEspaco.UseVisualStyleBackColor = true;
            this.btnLocalizaEspaco.Click += new System.EventHandler(this.btnLocalizaEspaco_Click);
            // 
            // btnQtdNum
            // 
            this.btnQtdNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtdNum.Location = new System.Drawing.Point(195, 343);
            this.btnQtdNum.Margin = new System.Windows.Forms.Padding(4);
            this.btnQtdNum.Name = "btnQtdNum";
            this.btnQtdNum.Size = new System.Drawing.Size(194, 63);
            this.btnQtdNum.TabIndex = 22;
            this.btnQtdNum.Text = "Quantidade de &números";
            this.btnQtdNum.UseVisualStyleBackColor = true;
            this.btnQtdNum.Click += new System.EventHandler(this.btnQtdNum_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.rtxtTexto);
            this.Controls.Add(this.btnQtdAlfabetico);
            this.Controls.Add(this.btnLocalizaEspaco);
            this.Controls.Add(this.btnQtdNum);
            this.Name = "frmExercicio4";
            this.Text = "Exercício 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Button btnQtdAlfabetico;
        private System.Windows.Forms.Button btnLocalizaEspaco;
        private System.Windows.Forms.Button btnQtdNum;
    }
}