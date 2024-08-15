using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ListaArticulos
{
    public partial class ImagenFRM : Form
    {
        public ImagenFRM(string urlImagen)
        {
            InitializeComponent();
            cerrarImgBTN.BackColor = Color.Transparent;
            cerrarImgBTN.FlatAppearance.BorderSize = 0;

            try
            {
                imagenPBOX.Load(urlImagen);
            }
            catch (Exception ex)
            {
                imagenPBOX.Load("https://imgs.search.brave.com/YZ1SjLQxhbj0Pd5D19P6s61NQ7GMYKNHOnjLmt8DrdQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/c2hvcGlmeS5jb20v/cy9maWxlcy8xLzA1/MzMvMjA4OS9maWxl/cy9wbGFjZWhvbGRl/ci1pbWFnZXMtaW1h/Z2VfbGFyZ2UucG5n/P3Y9MTUzMDEyOTA4/MQ");
            }
        }
        private void cerrarImgBTN_Click_1(object sender, EventArgs e)
        {
            
            Close();
        }
        private void cerrarImgBTN_MouseMove(object sender, MouseEventArgs e)
        {
            cerrarImgBTN.BackColor = Color.Red; //Al posicionarse sobre el botón, este se pone de color rojo.
            cerrarImgBTN.ForeColor = Color.White;
        }
        private void cerrarImgBTN_MouseLeave_1(object sender, EventArgs e)
        {
            cerrarImgBTN.BackColor = Color.Transparent;
            cerrarImgBTN.ForeColor = Color.Black;
        }
    }
}
