namespace App_Cuadratica
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cal = new System.Windows.Forms.Button();
            this.dispos = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "X1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "X2:";
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(73, 246);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 5;
            this.cal.Text = "&Calcular";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.button1_Click);
            // 
            // dispos
            // 
            this.dispos.Location = new System.Drawing.Point(175, 246);
            this.dispos.Name = "dispos";
            this.dispos.Size = new System.Drawing.Size(75, 23);
            this.dispos.TabIndex = 6;
            this.dispos.Text = "&Salir";
            this.dispos.UseVisualStyleBackColor = true;
            this.dispos.Click += new System.EventHandler(this.dispos_Click);
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(282, 246);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 23);
            this.nuevo.TabIndex = 7;
            this.nuevo.Text = "&Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(175, 60);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 8;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(175, 95);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 9;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(175, 126);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 10;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(175, 158);
            this.x1.Name = "x1";
            this.x1.ReadOnly = true;
            this.x1.Size = new System.Drawing.Size(100, 20);
            this.x1.TabIndex = 11;
            this.x1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(175, 189);
            this.x2.Name = "x2";
            this.x2.ReadOnly = true;
            this.x2.Size = new System.Drawing.Size(100, 20);
            this.x2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 312);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.dispos);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ecuacion Segundo Grado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Button dispos;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox x2;
    }
}

