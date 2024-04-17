namespace Prueba01
{
    partial class Form1
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
            this.Cerrar1 = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Cerrar1
            // 
            this.Cerrar1.Location = new System.Drawing.Point(912, 371);
            this.Cerrar1.Margin = new System.Windows.Forms.Padding(4);
            this.Cerrar1.Name = "Cerrar1";
            this.Cerrar1.Size = new System.Drawing.Size(138, 94);
            this.Cerrar1.TabIndex = 0;
            this.Cerrar1.Text = "Cerrar";
            this.Cerrar1.UseVisualStyleBackColor = true;
            this.Cerrar1.Click += new System.EventHandler(this.Cerrar1_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(32, 377);
            this.Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(164, 90);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            //this.Aceptar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(303, 53);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(6);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(270, 31);
            this.txt_nombre.TabIndex = 2;
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(126, 56);
            this.texto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(131, 33);
            this.texto.TabIndex = 3;
            this.texto.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.FormattingEnabled = true;
            this.txtNombres.ItemHeight = 25;
            this.txtNombres.Location = new System.Drawing.Point(253, 157);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(436, 179);
            this.txtNombres.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 529);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cerrar1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Cerrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cerrar1;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.ListBox txtNombres;
    }
}

