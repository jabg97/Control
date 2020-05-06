namespace Control
{
    partial class ControlView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.luz_roja_s1 = new System.Windows.Forms.Label();
            this.luz_roja_s2 = new System.Windows.Forms.Label();
            this.luz_verde_s1 = new System.Windows.Forms.Label();
            this.luz_verde_s2 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_s2 = new System.Windows.Forms.Label();
            this.btn_s1 = new System.Windows.Forms.Label();
            this.semaforo2 = new System.Windows.Forms.Label();
            this.semaforo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Semaforo #1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(245, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semaforo #2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // luz_roja_s1
            // 
            this.luz_roja_s1.BackColor = System.Drawing.Color.DimGray;
            this.luz_roja_s1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luz_roja_s1.ForeColor = System.Drawing.Color.Black;
            this.luz_roja_s1.Location = new System.Drawing.Point(54, 167);
            this.luz_roja_s1.Name = "luz_roja_s1";
            this.luz_roja_s1.Size = new System.Drawing.Size(43, 43);
            this.luz_roja_s1.TabIndex = 4;
            this.luz_roja_s1.Click += new System.EventHandler(this.luz_roja_s1_Click);
            // 
            // luz_roja_s2
            // 
            this.luz_roja_s2.BackColor = System.Drawing.Color.DimGray;
            this.luz_roja_s2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luz_roja_s2.Location = new System.Drawing.Point(283, 167);
            this.luz_roja_s2.Name = "luz_roja_s2";
            this.luz_roja_s2.Size = new System.Drawing.Size(43, 43);
            this.luz_roja_s2.TabIndex = 5;
            this.luz_roja_s2.Click += new System.EventHandler(this.luz_roja_s2_Click);
            // 
            // luz_verde_s1
            // 
            this.luz_verde_s1.BackColor = System.Drawing.Color.DimGray;
            this.luz_verde_s1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luz_verde_s1.Location = new System.Drawing.Point(54, 243);
            this.luz_verde_s1.Name = "luz_verde_s1";
            this.luz_verde_s1.Size = new System.Drawing.Size(43, 43);
            this.luz_verde_s1.TabIndex = 6;
            this.luz_verde_s1.Click += new System.EventHandler(this.luz_verde_s1_Click);
            // 
            // luz_verde_s2
            // 
            this.luz_verde_s2.BackColor = System.Drawing.Color.DimGray;
            this.luz_verde_s2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luz_verde_s2.Location = new System.Drawing.Point(283, 243);
            this.luz_verde_s2.Name = "luz_verde_s2";
            this.luz_verde_s2.Size = new System.Drawing.Size(43, 43);
            this.luz_verde_s2.TabIndex = 7;
            this.luz_verde_s2.Click += new System.EventHandler(this.luz_verde_s2_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(189, 120);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(3, 270);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btn_s2
            // 
            this.btn_s2.BackColor = System.Drawing.Color.Transparent;
            this.btn_s2.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_s2.Image = ((System.Drawing.Image)(resources.GetObject("btn_s2.Image")));
            this.btn_s2.Location = new System.Drawing.Point(246, 326);
            this.btn_s2.Name = "btn_s2";
            this.btn_s2.Size = new System.Drawing.Size(105, 64);
            this.btn_s2.TabIndex = 9;
            this.btn_s2.Click += new System.EventHandler(this.btn_s2_Click);
            // 
            // btn_s1
            // 
            this.btn_s1.BackColor = System.Drawing.Color.Transparent;
            this.btn_s1.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_s1.Image = ((System.Drawing.Image)(resources.GetObject("btn_s1.Image")));
            this.btn_s1.Location = new System.Drawing.Point(29, 326);
            this.btn_s1.Name = "btn_s1";
            this.btn_s1.Size = new System.Drawing.Size(108, 64);
            this.btn_s1.TabIndex = 8;
            this.btn_s1.Click += new System.EventHandler(this.btn_s1_Click);
            // 
            // semaforo2
            // 
            this.semaforo2.BackColor = System.Drawing.Color.Transparent;
            this.semaforo2.Image = ((System.Drawing.Image)(resources.GetObject("semaforo2.Image")));
            this.semaforo2.Location = new System.Drawing.Point(242, 120);
            this.semaforo2.Name = "semaforo2";
            this.semaforo2.Size = new System.Drawing.Size(124, 206);
            this.semaforo2.TabIndex = 1;
            // 
            // semaforo1
            // 
            this.semaforo1.BackColor = System.Drawing.Color.Transparent;
            this.semaforo1.Image = ((System.Drawing.Image)(resources.GetObject("semaforo1.Image")));
            this.semaforo1.Location = new System.Drawing.Point(13, 120);
            this.semaforo1.Name = "semaforo1";
            this.semaforo1.Size = new System.Drawing.Size(124, 206);
            this.semaforo1.TabIndex = 0;
            // 
            // ControlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 405);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btn_s2);
            this.Controls.Add(this.btn_s1);
            this.Controls.Add(this.luz_verde_s2);
            this.Controls.Add(this.luz_verde_s1);
            this.Controls.Add(this.luz_roja_s2);
            this.Controls.Add(this.luz_roja_s1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.semaforo2);
            this.Controls.Add(this.semaforo1);
            this.Name = "ControlView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control (COM1)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlView_FormClosed);
            this.Shown += new System.EventHandler(this.ControlView_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label semaforo1;
        private System.Windows.Forms.Label semaforo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label luz_roja_s1;
        private System.Windows.Forms.Label luz_roja_s2;
        private System.Windows.Forms.Label luz_verde_s1;
        private System.Windows.Forms.Label luz_verde_s2;
        private System.Windows.Forms.Label btn_s1;
        private System.Windows.Forms.Label btn_s2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}

