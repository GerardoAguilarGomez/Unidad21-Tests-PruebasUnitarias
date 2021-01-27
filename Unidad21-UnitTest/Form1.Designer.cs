
namespace Unidad21_UnitTest
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
            this.group = new System.Windows.Forms.GroupBox();
            this.Trapecio = new System.Windows.Forms.RadioButton();
            this.Romboide = new System.Windows.Forms.RadioButton();
            this.Rombo = new System.Windows.Forms.RadioButton();
            this.Pentagono = new System.Windows.Forms.RadioButton();
            this.Rectangulo = new System.Windows.Forms.RadioButton();
            this.Triangulo = new System.Windows.Forms.RadioButton();
            this.Circulo = new System.Windows.Forms.RadioButton();
            this.cuadrado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.operador1 = new System.Windows.Forms.TextBox();
            this.operador2 = new System.Windows.Forms.TextBox();
            this.operador3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.Trapecio);
            this.group.Controls.Add(this.Romboide);
            this.group.Controls.Add(this.Rombo);
            this.group.Controls.Add(this.Pentagono);
            this.group.Controls.Add(this.Rectangulo);
            this.group.Controls.Add(this.Triangulo);
            this.group.Controls.Add(this.Circulo);
            this.group.Controls.Add(this.cuadrado);
            this.group.Font = new System.Drawing.Font("Viner Hand ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.Location = new System.Drawing.Point(12, 30);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(319, 160);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // Trapecio
            // 
            this.Trapecio.AutoSize = true;
            this.Trapecio.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trapecio.Location = new System.Drawing.Point(172, 114);
            this.Trapecio.Name = "Trapecio";
            this.Trapecio.Size = new System.Drawing.Size(97, 31);
            this.Trapecio.TabIndex = 7;
            this.Trapecio.TabStop = true;
            this.Trapecio.Text = "Trapecio";
            this.Trapecio.UseVisualStyleBackColor = true;
            this.Trapecio.CheckedChanged += new System.EventHandler(this.Trapecio_CheckedChanged);
            // 
            // Romboide
            // 
            this.Romboide.AutoSize = true;
            this.Romboide.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Romboide.Location = new System.Drawing.Point(172, 83);
            this.Romboide.Name = "Romboide";
            this.Romboide.Size = new System.Drawing.Size(103, 31);
            this.Romboide.TabIndex = 6;
            this.Romboide.TabStop = true;
            this.Romboide.Text = "Romboide";
            this.Romboide.UseVisualStyleBackColor = true;
            this.Romboide.CheckedChanged += new System.EventHandler(this.Romboide_CheckedChanged);
            // 
            // Rombo
            // 
            this.Rombo.AutoSize = true;
            this.Rombo.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rombo.Location = new System.Drawing.Point(172, 49);
            this.Rombo.Name = "Rombo";
            this.Rombo.Size = new System.Drawing.Size(82, 31);
            this.Rombo.TabIndex = 5;
            this.Rombo.TabStop = true;
            this.Rombo.Text = "Rombo";
            this.Rombo.UseVisualStyleBackColor = true;
            this.Rombo.CheckedChanged += new System.EventHandler(this.Rombo_CheckedChanged);
            // 
            // Pentagono
            // 
            this.Pentagono.AutoSize = true;
            this.Pentagono.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pentagono.Location = new System.Drawing.Point(172, 19);
            this.Pentagono.Name = "Pentagono";
            this.Pentagono.Size = new System.Drawing.Size(115, 31);
            this.Pentagono.TabIndex = 4;
            this.Pentagono.TabStop = true;
            this.Pentagono.Text = "Pentágono";
            this.Pentagono.UseVisualStyleBackColor = true;
            this.Pentagono.CheckedChanged += new System.EventHandler(this.Pentagono_CheckedChanged);
            // 
            // Rectangulo
            // 
            this.Rectangulo.AutoSize = true;
            this.Rectangulo.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rectangulo.Location = new System.Drawing.Point(3, 111);
            this.Rectangulo.Name = "Rectangulo";
            this.Rectangulo.Size = new System.Drawing.Size(123, 31);
            this.Rectangulo.TabIndex = 3;
            this.Rectangulo.TabStop = true;
            this.Rectangulo.Text = "Rectángulo";
            this.Rectangulo.UseVisualStyleBackColor = true;
            this.Rectangulo.CheckedChanged += new System.EventHandler(this.Rectangulo_CheckedChanged);
            // 
            // Triangulo
            // 
            this.Triangulo.AutoSize = true;
            this.Triangulo.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Triangulo.Location = new System.Drawing.Point(3, 81);
            this.Triangulo.Name = "Triangulo";
            this.Triangulo.Size = new System.Drawing.Size(112, 31);
            this.Triangulo.TabIndex = 2;
            this.Triangulo.TabStop = true;
            this.Triangulo.Text = "Triángulo";
            this.Triangulo.UseVisualStyleBackColor = true;
            this.Triangulo.CheckedChanged += new System.EventHandler(this.Triangulo_CheckedChanged);
            // 
            // Circulo
            // 
            this.Circulo.AutoSize = true;
            this.Circulo.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Circulo.Location = new System.Drawing.Point(3, 50);
            this.Circulo.Name = "Circulo";
            this.Circulo.Size = new System.Drawing.Size(91, 31);
            this.Circulo.TabIndex = 1;
            this.Circulo.TabStop = true;
            this.Circulo.Text = "Circulo";
            this.Circulo.UseVisualStyleBackColor = true;
            this.Circulo.CheckedChanged += new System.EventHandler(this.Circulo_CheckedChanged);
            // 
            // cuadrado
            // 
            this.cuadrado.AutoSize = true;
            this.cuadrado.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadrado.Location = new System.Drawing.Point(3, 19);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(109, 31);
            this.cuadrado.TabIndex = 0;
            this.cuadrado.TabStop = true;
            this.cuadrado.Text = "Cuadrado";
            this.cuadrado.UseVisualStyleBackColor = true;
            this.cuadrado.CheckedChanged += new System.EventHandler(this.cuadrado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Figuras Geográficas";
            // 
            // operador1
            // 
            this.operador1.Enabled = false;
            this.operador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operador1.Location = new System.Drawing.Point(120, 199);
            this.operador1.Name = "operador1";
            this.operador1.Size = new System.Drawing.Size(52, 28);
            this.operador1.TabIndex = 2;
            this.operador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // operador2
            // 
            this.operador2.Enabled = false;
            this.operador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operador2.Location = new System.Drawing.Point(120, 244);
            this.operador2.Name = "operador2";
            this.operador2.Size = new System.Drawing.Size(52, 28);
            this.operador2.TabIndex = 3;
            this.operador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // operador3
            // 
            this.operador3.Enabled = false;
            this.operador3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operador3.Location = new System.Drawing.Point(120, 290);
            this.operador3.Name = "operador3";
            this.operador3.Size = new System.Drawing.Size(52, 28);
            this.operador3.TabIndex = 4;
            this.operador3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operador 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operador 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operador 3:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(103, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operador3);
            this.Controls.Add(this.operador2);
            this.Controls.Add(this.operador1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.group);
            this.Name = "Form1";
            this.Text = "Operaciones geométricas";
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.RadioButton cuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Circulo;
        private System.Windows.Forms.RadioButton Triangulo;
        private System.Windows.Forms.RadioButton Rectangulo;
        private System.Windows.Forms.RadioButton Pentagono;
        private System.Windows.Forms.RadioButton Rombo;
        private System.Windows.Forms.RadioButton Romboide;
        private System.Windows.Forms.RadioButton Trapecio;
        private System.Windows.Forms.TextBox operador1;
        private System.Windows.Forms.TextBox operador2;
        private System.Windows.Forms.TextBox operador3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

