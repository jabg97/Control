namespace Control
{
    partial class MainView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.barra = new System.Windows.Forms.ProgressBar();
            this.puerto = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(15, 109);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(321, 23);
            this.barra.TabIndex = 6;
            // 
            // puerto
            // 
            this.puerto.BackColor = System.Drawing.Color.Transparent;
            this.puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puerto.Location = new System.Drawing.Point(15, 77);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(318, 29);
            this.puerto.TabIndex = 8;
            this.puerto.Text = "COM1";
            this.puerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.Color.Transparent;
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(12, 145);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(324, 16);
            this.estado.TabIndex = 9;
            this.estado.Text = "No se pudo conectar.";
            this.estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 170);
            this.ControlBox = false;
            this.Controls.Add(this.estado);
            this.Controls.Add(this.puerto);
            this.Controls.Add(this.barra);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscando Puertos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Shown += new System.EventHandler(this.MainView_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar barra;
        private System.Windows.Forms.Label puerto;
        private System.Windows.Forms.Label estado;
    }
}

