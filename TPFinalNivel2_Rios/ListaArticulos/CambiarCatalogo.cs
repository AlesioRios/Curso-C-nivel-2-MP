using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Gestión;

namespace ListaArticulos
{
    public partial class CambiarCatalogoFRM : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public CambiarCatalogoFRM()
        {
            InitializeComponent();
        }

        public CambiarCatalogoFRM(Articulo modificado)
        {
            InitializeComponent();
            articulo = modificado;
        }

        private void CambiarCatalogoFRM_Load(object sender, EventArgs e)
        {
            MarcasGestion marcaGestion = new MarcasGestion();
            CategoriaGestion categoriaGestion = new CategoriaGestion();
            try
            {
                marcaCBOX.DataSource = marcaGestion.Listar();
                marcaCBOX.ValueMember = "Id";
                marcaCBOX.DisplayMember = "Descripcion";
                categoriaCBOX.DataSource = categoriaGestion.Listar();
                categoriaCBOX.ValueMember = "Id";
               categoriaCBOX.DisplayMember = "Descripcion";
                marcaCBOX.SelectedIndex = -1;
                categoriaCBOX.SelectedIndex = -1;


                if (articulo != null)
                {
                    codigoArtTXTB.Text = articulo.Codigo;
                    nombreTXTB.Text = articulo.Nombre;
                    descripcionTXTB.Text = articulo.Descripcion;
                    marcaCBOX.Text = articulo.Marca.Descripcion;
                    categoriaCBOX.Text = articulo.Categoria.Descripcion;
                    imagenTXTB.Text = articulo.UrlImagen;
                    CargarImagen(articulo.UrlImagen);
                    precioTXTB.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void aceptarBTN_MouseMove(object sender, MouseEventArgs e)
        {
            aceptarBTN.BackColor = Color.Green;
            aceptarBTN.ForeColor = Color.White;
        }
        private void aceptarBTN_MouseLeave(object sender, EventArgs e)
        {
            aceptarBTN.BackColor = Color.White;
            aceptarBTN.ForeColor = Color.Black;
        }
        private void cancelarBTN_MouseMove(object sender, MouseEventArgs e)
        {
            cancelarBTN.BackColor = Color.Red;
            cancelarBTN.ForeColor = Color.White;
        }
        private void cancelarBTN_MouseLeave(object sender, EventArgs e)
        {
            cancelarBTN.BackColor = Color.White;
            cancelarBTN.ForeColor = Color.Black;
        }
        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void aceptarBTN_Click(object sender, EventArgs e)
        {
            ListaGestion gestion = new ListaGestion();
            try
            {
                //nuevoArticulo.
                if (articulo == null)
                    articulo = new Articulo();

                    articulo.Codigo = codigoArtTXTB.Text;
                    articulo.Nombre = nombreTXTB.Text;
                    articulo.Descripcion = descripcionTXTB.Text;
                    articulo.UrlImagen = imagenTXTB.Text;
                    if (precioTXTB.Text != "")
                        articulo.Precio = decimal.Parse(precioTXTB.Text);
                    else
                        articulo.Precio = 0;
                    articulo.Marca = (Marca)marcaCBOX.SelectedItem;
                    articulo.Categoria = (Categoria)categoriaCBOX.SelectedItem;

                if (!DatosCompletados())
                    return;

                if (articulo.Id != 0)
                {
                    gestion.Modificar(articulo);
                    MessageBox.Show("Modificado con éxito.");
                }
                else
                {
                    gestion.Agregar(articulo);
                    MessageBox.Show("Agregado con éxito");
                }

                if (!(imagenTXTB.Text.ToUpper().Contains("HTTP")) && archivo != null) 
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool DatosCompletados()
        {
            if(codigoArtTXTB.Text == "")
            {
                MessageBox.Show("Ingrese el código de artículo.", "Atemción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(nombreTXTB.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del artículo.", "Atemción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(marcaCBOX.Text == "")
            {
                MessageBox.Show("Ingrese la marca del artículo.", "Atemción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(categoriaCBOX.Text == "")
            {
                MessageBox.Show("Ingrese la categoría del artículo.", "Atemción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(precioTXTB.Text == "")
            {
                MessageBox.Show("Ingrese el precio del artículo.", "Atemción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void imagenTXTB_Leave(object sender, EventArgs e)
        {
            CargarImagen(imagenTXTB.Text);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                imagenPBOX.Load(imagen);
            }
            catch (Exception ex)
            {
                imagenPBOX.Load("https://imgs.search.brave.com/YZ1SjLQxhbj0Pd5D19P6s61NQ7GMYKNHOnjLmt8DrdQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/c2hvcGlmeS5jb20v/cy9maWxlcy8xLzA1/MzMvMjA4OS9maWxl/cy9wbGFjZWhvbGRl/ci1pbWFnZXMtaW1h/Z2VfbGFyZ2UucG5n/P3Y9MTUzMDEyOTA4/MQ");
            }
        }
        private void importarBTN_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            archivo.ShowDialog();
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                imagenTXTB.Text = archivo.FileName;
                CargarImagen(archivo.FileName);

                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }
        private void precioTXTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void imagenPBOX_Click(object sender, EventArgs e)
        {
            ImagenFRM imagen = new ImagenFRM(imagenTXTB.Text);
            imagen.ShowDialog();
        }
    }
}
