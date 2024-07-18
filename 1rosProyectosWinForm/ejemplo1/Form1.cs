using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("Buenos díass");
            if (checkBox1.Checked)
            {
                string name = textBox1.Text;
                MessageBox.Show($"Hola {name}!");
                
            }
            else
                MessageBox.Show("Marque el tick antes de presionar.");

        }
        
        //private void button1_MouseHover(object sender, EventArgs e)
        //{
        ////    MessageBox.Show("Hola!");
        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void boton1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    //MessageBox.Show("Estás bajando...");
        //}

        private void boton1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Sea bienvenido");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
