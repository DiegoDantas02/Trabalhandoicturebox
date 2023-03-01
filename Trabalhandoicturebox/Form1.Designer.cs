namespace Trabalhandoicturebox
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
            this.pictureBoxMostrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMostrar
            // 
            this.pictureBoxMostrar.Image = global::Trabalhandoicturebox.Properties.Resources.pexels_esranur_kalay_13169922;
            this.pictureBoxMostrar.Location = new System.Drawing.Point(145, 32);
            this.pictureBoxMostrar.Name = "pictureBoxMostrar";
            this.pictureBoxMostrar.Size = new System.Drawing.Size(459, 414);
            this.pictureBoxMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMostrar.TabIndex = 0;
            this.pictureBoxMostrar.TabStop = false;
            this.pictureBoxMostrar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(785, 528);
            this.Controls.Add(this.pictureBoxMostrar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Picture Box";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMostrar;
    }
}

