using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormActs
{
    public partial class practicaForm : Form
    {
        public practicaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a este WinForm!");
        }

        private void practicaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("El WinForm se cerrará.");
        }
        private void boton1_Click(object sender, EventArgs e) {
            
        }

        private void boton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se activó el evento click", "Atención");
            this.BackColor = Color.Green;
        }

        private void practicaForm_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Se presionó el botón izquierdo", "Advertencia");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Se presionó el botón derecho", "Advertencia");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Se presionó el botón del medio", "Advertencia");
        }

        string color = Color.Yellow.ToString();
        private void soyuntextoLBL_MouseMove(object sender, MouseEventArgs e)
        {
            soyuntextoLBL.BackColor = Color.Yellow;
            soyuntextoLBL.Cursor = Cursors.Hand;
        }

        private void soyuntextoLBL_MouseLeave(object sender, EventArgs e)
        {
            soyuntextoLBL.BackColor = System.Drawing.SystemColors.Control;
            soyuntextoLBL.Cursor = Cursors.Arrow;
        }

        private void soyuntextoLBL_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "")
            {
                txtBox.BackColor = Color.Gray;
            }
            else
                txtBox.BackColor = Color.Blue;
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) &&  e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textbox2_Leave(object sender, EventArgs e)
        {
            int caracteres = textbox2.Text.Length;
            MessageBox.Show($"Tiene {caracteres} caracteres.");
        }
    }
}
