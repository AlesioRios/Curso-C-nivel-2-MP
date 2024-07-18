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
    public partial class EFICH : Form
    {
        public EFICH()
        {
            InitializeComponent();
        }

        private void EFICH_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sea Bienvenido!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pabloNovara_Click(object sender, EventArgs e)
        {

        }

        private void ingresarBTN_Click(object sender, EventArgs e)
        {
            
            string nombre = NombreTXTB.Text;
            int dni = int.Parse(dniTXTB.Text);
            DateTime fechaNac = fechaDTP.Value;
            string passw = passwordTXTB.Text;
            string nombreShow = $"Nombre: {nombre}.\n";
            string dniShow = $"DNI: {dni}.\n";
            string fechaNacShow = $"Fecha de Nacimiento: {fechaNac}.{Environment.NewLine}";
            string passwShow = $"Contraseña: {passw}.\n";
            string mensaje = nombreShow + dniShow + fechaNacShow + passwShow;
            string msgMafioso = "Enhorabuena!. Tus datos han sido robados y fueron vendidos bastante barato.";
            MessageBox.Show(mensaje);
            MessageBox.Show(msgMafioso);
           
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
