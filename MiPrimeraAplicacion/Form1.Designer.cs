namespace MiPrimeraAplicacion
{
    partial class Formulario
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
            this.boton = new System.Windows.Forms.Button();
            this.Comentario = new System.Windows.Forms.Label();
            this.caja = new System.Windows.Forms.TextBox();
            this.caja2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton
            // 
            this.boton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton.Location = new System.Drawing.Point(95, 56);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 0;
            this.boton.Text = "Run";
            this.boton.UseVisualStyleBackColor = false;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // Comentario
            // 
            this.Comentario.AutoSize = true;
            this.Comentario.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Comentario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Comentario.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comentario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Comentario.Location = new System.Drawing.Point(189, 56);
            this.Comentario.Name = "Comentario";
            this.Comentario.Size = new System.Drawing.Size(54, 26);
            this.Comentario.TabIndex = 1;
            this.Comentario.Text = "Hola";
            this.Comentario.MouseLeave += new System.EventHandler(this.Comentario_MouseLeave);
            this.Comentario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Comentario_MouseMove);
            // 
            // caja
            // 
            this.caja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.caja.Location = new System.Drawing.Point(95, 103);
            this.caja.MaxLength = 4;
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(100, 20);
            this.caja.TabIndex = 2;
            this.caja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caja_KeyPress);
            // 
            // caja2
            // 
            this.caja2.Location = new System.Drawing.Point(95, 140);
            this.caja2.Multiline = true;
            this.caja2.Name = "caja2";
            this.caja2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.caja2.Size = new System.Drawing.Size(100, 20);
            this.caja2.TabIndex = 3;
            this.caja2.MouseLeave += new System.EventHandler(this.caja2_MouseLeave);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(425, 296);
            this.Controls.Add(this.caja2);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.Comentario);
            this.Controls.Add(this.boton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulario_FormClosed);
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.Click += new System.EventHandler(this.Formulario_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Label Comentario;
        private System.Windows.Forms.TextBox caja;
        private System.Windows.Forms.TextBox caja2;
    }
}

