namespace Tiempo_2
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
            this.Dia = new System.Windows.Forms.Label();
            this.Mes = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Convertir = new System.Windows.Forms.Label();
            this.Resultadodia = new System.Windows.Forms.Label();
            this.Resultadomes = new System.Windows.Forms.Label();
            this.Resultadoaño = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Dia
            // 
            this.Dia.AutoSize = true;
            this.Dia.Location = new System.Drawing.Point(133, 133);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(23, 13);
            this.Dia.TabIndex = 0;
            this.Dia.Text = "Dia";
            // 
            // Mes
            // 
            this.Mes.AutoSize = true;
            this.Mes.Location = new System.Drawing.Point(351, 133);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(27, 13);
            this.Mes.TabIndex = 1;
            this.Mes.Text = "Mes";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Location = new System.Drawing.Point(561, 133);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(26, 13);
            this.Año.TabIndex = 2;
            this.Año.Text = "Año";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 173);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 173);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(519, 173);
            this.textBox3.MaxLength = 4;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Convertir
            // 
            this.Convertir.AutoSize = true;
            this.Convertir.Location = new System.Drawing.Point(351, 249);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(49, 13);
            this.Convertir.TabIndex = 6;
            this.Convertir.Text = "Convertir";
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // Resultadodia
            // 
            this.Resultadodia.AutoSize = true;
            this.Resultadodia.Location = new System.Drawing.Point(121, 321);
            this.Resultadodia.Name = "Resultadodia";
            this.Resultadodia.Size = new System.Drawing.Size(0, 13);
            this.Resultadodia.TabIndex = 7;
            this.Resultadodia.Click += new System.EventHandler(this.Resultadodia_Click);
            // 
            // Resultadomes
            // 
            this.Resultadomes.AutoSize = true;
            this.Resultadomes.Location = new System.Drawing.Point(343, 321);
            this.Resultadomes.Name = "Resultadomes";
            this.Resultadomes.Size = new System.Drawing.Size(0, 13);
            this.Resultadomes.TabIndex = 8;
            this.Resultadomes.Click += new System.EventHandler(this.Resultadomes_Click);
            // 
            // Resultadoaño
            // 
            this.Resultadoaño.AutoSize = true;
            this.Resultadoaño.Location = new System.Drawing.Point(552, 321);
            this.Resultadoaño.Name = "Resultadoaño";
            this.Resultadoaño.Size = new System.Drawing.Size(0, 13);
            this.Resultadoaño.TabIndex = 9;
            this.Resultadoaño.Click += new System.EventHandler(this.Resultadoaño_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(343, 29);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 13);
            this.Error.TabIndex = 10;
            this.Error.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Resultadoaño);
            this.Controls.Add(this.Resultadomes);
            this.Controls.Add(this.Resultadodia);
            this.Controls.Add(this.Convertir);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.Mes);
            this.Controls.Add(this.Dia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dia;
        private System.Windows.Forms.Label Mes;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Convertir;
        private System.Windows.Forms.Label Resultadodia;
        private System.Windows.Forms.Label Resultadomes;
        private System.Windows.Forms.Label Resultadoaño;
        private System.Windows.Forms.Label Error;
    }
}

