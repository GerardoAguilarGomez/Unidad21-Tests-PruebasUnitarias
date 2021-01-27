using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad21_UnitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double resultado = 0;
        string figura = "";

        public void SaberFigura(string nombre_figura)
        {
            figura = nombre_figura;
            if(nombre_figura=="cuadrado" || nombre_figura == "Circulo")
            {
                operador1.Enabled = true;
                operador2.Enabled = false;
                operador3.Enabled = false;
            }
            else if (nombre_figura=="Trapecio")
            {
                operador1.Enabled = true;
                operador2.Enabled = true;
                operador3.Enabled = true;
            }
            else
            {
                operador1.Enabled = true;
                operador2.Enabled = true;
                operador3.Enabled = false;
            }
        }
        private void cuadrado_CheckedChanged(object sender, EventArgs e)
        {
            SaberFigura(cuadrado.Name);
        }

        private void Circulo_CheckedChanged(object sender, EventArgs e)
        {
            SaberFigura(Circulo.Name);
        }

        private void Triangulo_CheckedChanged(object sender, EventArgs e)
        {
            SaberFigura(Triangulo.Name);
        }

        private void Rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            SaberFigura(Rectangulo.Name);
        }

        private void Pentagono_CheckedChanged(object sender, EventArgs e)
        {
            SaberFigura(Pentagono.Name);
        }

        private void Rombo_CheckedChanged(object sender, EventArgs e)
        {
            SaberFigura(Rombo.Name);
        }

        private void Romboide_CheckedChanged(object sender, EventArgs e)
        {
            SaberFigura(Romboide.Name);
        }

        private void Trapecio_CheckedChanged(object sender, EventArgs e)
        {
            SaberFigura(Trapecio.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geometria G1 = new Geometria();
            int a = G1.areacuadrado(4);
            switch (figura)
            {
                case "cuadrado":
                    MessageBox.Show("Resultado = " + Convert.ToString(G1.areacuadrado(Convert.ToInt32(operador1.Text))));
                    break;
                case "Circulo":
                    MessageBox.Show("Resultado = " + Convert.ToString(G1.areaCirculo(Convert.ToInt32(operador1.Text))));
                    break;
                case "Triangulo":
                    MessageBox.Show("Resultado = " + Convert.ToString(G1.areatriangulo(Convert.ToInt32(operador1.Text), Convert.ToInt32(operador2.Text))));
                    break;
                case "Rectangulo":
                    MessageBox.Show("Resultado = " + Convert.ToString(G1.arearectangulo(Convert.ToInt32(operador1.Text), Convert.ToInt32(operador2.Text))));
                    break;
                case "Pentagono":
                    MessageBox.Show("Resultado = " + Convert.ToString(G1.areapentagono(Convert.ToInt32(operador1.Text), Convert.ToInt32(operador2.Text))));
                    break;
                case "Rombo":
                    MessageBox.Show("Resultado = " + Convert.ToString(G1.arearombo(Convert.ToInt32(operador1.Text), Convert.ToInt32(operador2.Text))));
                    break;
                case "Romboide":
                    MessageBox.Show("Resultado = " + Convert.ToString(G1.arearomboide(Convert.ToInt32(operador1.Text), Convert.ToInt32(operador2.Text))));
                    break;
                case "Trapecio":
                    MessageBox.Show("Resultado = " + Convert.ToString(G1.areatrapecio(Convert.ToInt32(operador1.Text), Convert.ToInt32(operador2.Text), Convert.ToInt32(operador3.Text))));
                    break;
            }
        }
    }
}
