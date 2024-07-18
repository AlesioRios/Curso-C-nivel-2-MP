using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fechaBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fecha seleccionada: " + fechaDTP.Value.ToString("dddd, MM/yyy") + ".");
        }

        private void calendarioBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fecha seleccionada: " + calendarioMC.SelectionStart.ToString("dd/MM/yyyy") + ".");
        }
    }
}
