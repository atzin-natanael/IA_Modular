using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lector_IA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            Abrir.InitialDirectory= "C:\\Imagenes";
            Abrir.FileName = "";
            Abrir.Filter = "Files|*.jpg;*.jpeg;*.png;";
            if(Abrir.ShowDialog() == DialogResult.OK)
            {
                Imagen.Image = Image.FromFile(Abrir.FileName);
            }
        }

        private void Cargar_Click_1(object sender, EventArgs e)
        {
            if (Imagen.Image != null)
            {
                Bitmap imagenCargada;
                imagenCargada = new Bitmap(Imagen.Image);
                for(int i = 0; i< imagenCargada.Height; ++i)
                {
                    MessageBox.Show(imagenCargada.GetPixel(i, 200).ToString());
                    imagenCargada.SetPixel(i, 200, Color.Red);
                    Imagen.Image = imagenCargada;
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
