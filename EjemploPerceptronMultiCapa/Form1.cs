using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAupt.uptRNA;

namespace EjemploPerceptronMultiCapa
{
    public partial class Form1 : Form
    {
        public double res = 0;
        public int r, g, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEntrenar_Click(object sender, EventArgs e)
        {
            PerceptronMultiCapa rna = new PerceptronMultiCapa(@"ejemplo.pml");
            rna.entrenar();
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            res = 0;
            txtBRojo.Text = "";
            txtBVerde.Text = "";
            txtBAzul.Text = "";
            lbPerceptron.Text = "";
            Bitmap paleta = new Bitmap(pictureBox1.Image);
            Color color = paleta.GetPixel(e.X, e.Y);
            txtBRojo.Text = color.R.ToString();
            txtBVerde.Text = color.G.ToString();
            txtBAzul.Text = color.B.ToString();
            r = color.R;
            g = color.G;
            b = color.B;

        }

        private void BtnReconococer_Click(object sender, EventArgs e)
        {
            PerceptronMultiCapa rna = new PerceptronMultiCapa(@"ejemplo.ppm");
            double[] x = { r,g,b };
            rna.reconocer(x);
            for (int i = 0; i < rna.y.Length; i++)
            {
                for (int s = 0; s < rna.y.Length; s++)
                {
                    res = rna.y[i, s];
                }
            }
            switch (res)
            {
                case 1:
                    res = 0;
                    lbPerceptron.Text = "Respuesta Perceptron: Rojo";
                    rna.y[0, 0] = 0;
                    break;
                case 2:
                    lbPerceptron.Text = "Respuesta Perceptron: Amarillo";
                    res = 0;
                    rna.y[0, 0] = 0;
                    break;
                case 3:
                    lbPerceptron.Text = "Respuesta Perceptron: Azul";
                    res = 0;
                    rna.y[0, 0] = 0;
                    break;
                case 4:
                    lbPerceptron.Text = "Respuesta Perceptron: Verde";
                    res = 0;
                    rna.y[0, 0] = 0;
                    break;
                case 5:
                    lbPerceptron.Text = "Respuesta Perceptron: Morado";
                    res = 0;
                    rna.y[0, 0] = 0;
                    break;
                case 6:
                    lbPerceptron.Text = "Respuesta Perceptron: Naranja";
                    res = 0;
                    rna.y[0, 0] = 0;
                    break;
                default:
                    lbPerceptron.Text = "No reconozco el color:" + res;
                    res = 0;
                    rna.y[0, 0] = 0;
                    break;
            }
        }
    }
}
