namespace APP_Interfaz_wind
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.Label();
            this.resu = new System.Windows.Forms.TextBox();
            this.sa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULO DE UN FACTORIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un entero:";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(130, 78);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.AutoSize = true;
            this.txtresultado.Location = new System.Drawing.Point(31, 113);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(58, 13);
            this.txtresultado.TabIndex = 4;
            this.txtresultado.Text = "Resultado:";
            // 
            // resu
            // 
            this.resu.Location = new System.Drawing.Point(130, 113);
            this.resu.Name = "resu";
            this.resu.ReadOnly = true;
            this.resu.Size = new System.Drawing.Size(100, 20);
            this.resu.TabIndex = 5;
            // 
            // sa
            // 
            this.sa.Location = new System.Drawing.Point(156, 150);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(75, 23);
            this.sa.TabIndex = 6;
            this.sa.Text = "Salir";
            this.sa.UseVisualStyleBackColor = true;
            this.sa.Click += new System.EventHandler(this.sa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 190);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.resu);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtresultado;
        private System.Windows.Forms.TextBox resu;
        private System.Windows.Forms.Button sa;
    }
}

