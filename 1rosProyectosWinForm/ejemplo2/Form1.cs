using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtElemento.Text;
            lvElementos.Items.Add(elemento);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxColores.Items.Add("Rojo");
            cBoxColores.Items.Add("Amarillo");
            cBoxColores.Items.Add("Azul");
            cBoxColores.Items.Add("Verde");
            cBoxColores.Items.Add("Naranja");
            cBoxColores.Items.Add("Violeta");
        }

        private void ButtonVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtElemento.Text;
            DateTime fecha = dateTimePicker.Value;
            string colorFav = cBoxColores.SelectedItem.ToString();
            decimal edad = nUDEdad.Value;
            string invertir = CheckboxInvAnt.Checked == true ? "Ha invertido con anterioridad." : "Nunca ha invertido.";
            string InvFavorita;
            if (RadButAcc.Checked)
            {
                InvFavorita = RadButAcc.Text;
            }
            else if (RadButBon.Checked)
            {
                InvFavorita = RadButBon.Text;
            }
            else
            {
                InvFavorita = RadButFCI.Text;
            }
            string showNombre = "Nombre: " + nombre + Environment.NewLine;
            string showFeNac = "Fecha de nacimiento: " + fecha + Environment.NewLine;
            string showColorFav = "Color favorito: " + colorFav + "\n";
            string showEdad = $"Edad: {edad}.\n";
            string showInvertir = invertir;
            string showInvFavorita = $"Inversión favorita: {InvFavorita}.\n";
            MessageBox.Show(showNombre + showFeNac + showColorFav + showEdad + showInvertir + showInvFavorita);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
