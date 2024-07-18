using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormActs
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }
        //Holaaa comentarios
        private bool yaSeAcepto = false;
        private Font sintexto;
        private Color colorsintexto;
        private Font estiloOriginal = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        private void DatosPersonales_Load(object sender, EventArgs e)
        {
            sintexto = nombreTXTB.Font;
            colorsintexto = nombreTXTB.ForeColor;
        }
        private void IngresarTexto(ref TextBox cajaTexto)
        {
            if (cajaTexto.BackColor == Color.Red)
            {
                cajaTexto.BackColor = Color.White;
                //sintexto = cajaTexto.Font;
                //colorsintexto = cajaTexto.ForeColor;
            }
            cajaTexto.Text = "";    
            cajaTexto.Font = estiloOriginal;
            cajaTexto.ForeColor = Color.Black;
        }
        private void SalirTexto(ref TextBox cajaTexto, string texto)
        {
            if (cajaTexto.Text == "")
            {
                cajaTexto.Text = texto;
                cajaTexto.Font = sintexto;
                cajaTexto.ForeColor = colorsintexto;
            }
            if (cajaTexto.Text == texto && yaSeAcepto)
                cajaTexto.BackColor = Color.Red;
        }
       

        private void aceptarBTN_MouseMove(object sender, MouseEventArgs e)
        {
            aceptarBTN.BackColor = Color.Green;
        }
        

        private void aceptarBTN_MouseLeave(object sender, EventArgs e)
        {
            aceptarBTN.BackColor = Color.White; 
        }

        //Config textbox Nombre
        //private Color colorlblN;
        private void nombreTXTB_Click(object sender, EventArgs e)
        {
            //colorlblN = nombreTXTB.BackColor;
           // MessageBox.Show(nombreTXTB.BackColor.ToString());
            //if (nombreTXTB.BackColor == Color.Red)
            //    nombreTXTB.BackColor = Color.White;
            IngresarTexto(ref nombreTXTB);
           
        }

        private void nombreTXTB_Leave(object sender, EventArgs e)
        {
            string texto = "Ingresar nombre...";
            SalirTexto(ref nombreTXTB, texto);
            //if (nombreTXTB.Text == texto)
            //    nombreTXTB.BackColor = Color.Red;

        }
        //
        //Config textbox Apellido
        private void apellidoTXTB_Click(object sender, EventArgs e)
        {
            IngresarTexto(ref apellidoTXTB);
        }

        private void apellidoTXTB_Leave(object sender, EventArgs e)
        {
            string texto = "Ingresar apellido...";
            SalirTexto(ref apellidoTXTB, texto);
        }

        //
        //Config textbox Fecha nacimiento
        private void textBox1_Click(object sender, EventArgs e)
        {
            IngresarTexto(ref fechanacimientoTXTB);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string texto = "Ingresar fecha de nacimiento...";
            SalirTexto(ref fechanacimientoTXTB, texto);
        }

        private void direccionTXTB_Click(object sender, EventArgs e)
        {
            IngresarTexto(ref  direccionTXTB);
        }

        private void direccionTXTB_Leave(object sender, EventArgs e)
        {
            string texto = "Ingresar dirección...";
            SalirTexto(ref direccionTXTB, texto);
        }

        //Config Textbox DNI
        private void dniTXTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dniTXTB_Click(object sender, EventArgs e)
        {
            IngresarTexto(ref dniTXTB);

        }

        private void dniTXTB_Leave(object sender, EventArgs e)
        {
            string texto = "Ingresar DNI...";
            SalirTexto(ref dniTXTB, texto);
        }

        private Color colorCancelar;
      

        private void cancelarBTN_MouseLeave(object sender, EventArgs e)
        {
           // MessageBox.Show(colorCancelar.ToString());
            cancelarBTN.BackColor = colorCancelar;
        }

        private void cancelarBTN_MouseEnter(object sender, EventArgs e)
        {
            colorCancelar = cancelarBTN.BackColor;
            // MessageBox.Show(colorCancelar.ToString());
            cancelarBTN.BackColor = Color.Red;
            // MessageBox.Show(colorCancelar.ToString());
        }

        private void aceptarBTN_Click(object sender, EventArgs e)
        {
            bool condicionNombre = nombreTXTB.Text != "" && nombreTXTB.Text != "Ingresar nombre...";
            bool condicionApellido = apellidoTXTB.Text != "" && apellidoTXTB.Text != "Ingresar apellido...";
            bool condicionFechaNac = fechanacimientoTXTB.Text != "" && fechanacimientoTXTB.Text != "Ingresar fecha de nacimiento...";
            bool condicionDireccion = direccionTXTB.Text != "" && direccionTXTB.Text != "Ingresar dirección...";
            bool condicionDni = dniTXTB.Text != "" && dniTXTB.Text != "Ingresar DNI...";
            
            bool condicion = condicionNombre && condicionApellido && condicionFechaNac && condicionDireccion && condicionDni;
            yaSeAcepto = true;

            if (condicion)
            {
                string nombre = nombreTXTB.Text;
                string apellido = apellidoTXTB.Text;
                string fechanacimiento = fechanacimientoTXTB.Text;
                string direccion = direccionTXTB.Text;
                string dni = dniTXTB.Text;

                string Nombre = "Nombre: " + nombre + ".";
                string Apellido = "Apellido: " + apellido + ".";
                string FechaNacimiento = "Fecha de nacimiento: " + fechanacimiento + ".";
                string Direccion = "Dirección: " + direccion + ".";
                string Dni = "DNI: " + dni + ".";

                string mensaje = Nombre + Environment.NewLine + Apellido + Environment.NewLine + FechaNacimiento + Environment.NewLine + Direccion + Environment.NewLine + Dni + Environment.NewLine;
                resultadoTXTB.Text = mensaje;

            } else
            {
                if (!condicionNombre)
                {
                    nombreTXTB.BackColor = Color.Red;
                }
                if (!condicionApellido)
                {
                    apellidoTXTB.BackColor = Color.Red;
                }
                if (!condicionFechaNac)
                {
                    fechanacimientoTXTB.BackColor = Color.Red;
                }
                if (!condicionDireccion)
                {
                    direccionTXTB.BackColor = Color.Red;
                }
                if (!condicionDni)
                {
                    dniTXTB.BackColor = Color.Red;
                }
                MessageBox.Show("Faltan datos.", "Advertencia");

            }
        }

        private void fechanacimientoTXTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }










        //private void IngresarTexto(ref TextBox cajaTexto, string texto, bool seingresa)
        //{
        //   Color colorSinTexto = cajaTexto.ForeColor;
        //    if (seingresa)
        //    {
        //        cajaTexto.Text = "";
        //        cajaTexto.Font = estiloOriginal;
        //        cajaTexto.ForeColor = Color.Black;
        //    }
        //    else
        //    {
        //        cajaTexto.Text = texto;
        //        cajaTexto.Font = nombreTXTB.Font;
        //        cajaTexto.ForeColor = colorSinTexto;
        //    }
        //}
        //private void IngresarTexto(ref TextBox cajaTexto, string texto, bool seingresa)
        //{
        //    Color colorSinTexto = cajaTexto.ForeColor;
        //    if (seingresa)
        //    {
        //        cajaTexto.Text = "";
        //        cajaTexto.Font = estiloOriginal;
        //        cajaTexto.ForeColor = Color.Black;
        //    }
        //    else
        //    {
        //        cajaTexto.Text = texto;
        //        cajaTexto.Font = nombreTXTB.Font;
        //        cajaTexto.ForeColor = colorSinTexto;
        //    }
        //}
    }
}
