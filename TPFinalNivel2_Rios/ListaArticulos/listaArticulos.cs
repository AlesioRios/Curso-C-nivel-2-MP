using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Gestión;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace ListaArticulos
{
    public partial class listaArticulosFRM : Form
    {
        private List<Articulo> listaDeArticulos;
      
        public listaArticulosFRM()
        {
            InitializeComponent();
        }
        //Estos eventos MouseMove y MouseLeave para Agregar, Eliminar y Modificar provocan que cambien de color al pasar el mouse sobre ellos.
        private void agregarBTN_MouseMove(object sender, MouseEventArgs e)
        {
            agregarBTN.BackColor = Color.Green;
            agregarBTN.ForeColor = Color.White;
            
        }
        private void agregarBTN_MouseLeave(object sender, EventArgs e)
        {
            agregarBTN.ForeColor = Color.Black;
            agregarBTN.BackColor = Color.White;
            
        }
        private void eliminarBTN_MouseMove(object sender, MouseEventArgs e)
        {
            eliminarBTN.BackColor = Color.Red;
            eliminarBTN.ForeColor = Color.White;
        }
        private void eliminarBTN_MouseLeave(object sender, EventArgs e)
        {
            eliminarBTN.ForeColor = Color.Black;
            eliminarBTN.BackColor = Color.White;
        }
        private void modificarBTN_MouseMove(object sender, MouseEventArgs e)
        {
            modificarBTN.BackColor = Color.Gray;
            modificarBTN.ForeColor= Color.White;
        }
        private void modificarBTN_MouseLeave(object sender, EventArgs e)
        {
            modificarBTN.ForeColor = Color.Black;
            modificarBTN.BackColor = Color.White;
        }
        // Fin eventos MouseMove y MouseLeave
        private void ayudaBTN_Click(object sender, EventArgs e) //Este evento muestra el tutorial de la App.
        {
            DialogResult eleccion = MessageBox.Show("A continuación te explicamos cómo funciona la aplicación. Presiona 'OK' para continuar.", "Ayuda", MessageBoxButtons.OKCancel);
            if (eleccion == DialogResult.OK)
            {   //Si el usuario presiona "OK" se sigue mostrando el tutorial. En caso contrario, dejan de aparecer los carteles informativos.
                //Diseñado de tal forma que el número de viñetas y mensajes se acomoda con tan solo agregar el texto a la lista "mensajes".
                //Se van a mostrar en pantalla según el orden en que fueron agregados a mensajes mediante .Add().

                List<string> mensajes = new List<string>();
                mensajes.Add("Esta aplicación muestra un catálogo de diversos artículos. Si pulsas el botón 'Agregar' podrás añadir nuevos artículos al catálogo ingresando sus datos (código de artículo, marca, precio, etc.).");
                mensajes.Add("El botón 'Eliminar' se usa para borrar de la lista los artículos que se encuentren seleccionados.");
                mensajes.Add("El botón 'Modificar' sirve para cambiar los atributos del artículo seleccionado.");
                mensajes.Add("También puedes usar la barra superior de búsqueda para encontrar artículos específicos. Si desea una búsqueda más precisa, puede presionar el botón 'Filtro Avanazado...' para desplegar un menú de búsqueda más sofisticado.");
                mensajes.Add("Por último, si presionas la imagen del artículo podrás verla en mejor detalle.");

                int numero_de_carteles = mensajes.Count;
                int paso = 0;

                foreach(string msg in mensajes)
                {
                    if (eleccion == DialogResult.OK)
                    {
                        paso++;
                        eleccion = MessageBox.Show(msg, $"{paso}/{numero_de_carteles}", MessageBoxButtons.OKCancel);
                    }
                    else
                        break;
              
                }
            }
        }
        private void filtroAvanBTN_Click(object sender, EventArgs e)
        {
            List<Control> filtro_avanzado = new List<Control>(); //En esta lista se agregan los controles del filtro avanzado.
            filtro_avanzado.Add(campoLBL);
            filtro_avanzado.Add(campoCBOX);
            filtro_avanzado.Add(condicionLBL);
            filtro_avanzado.Add(condicionCBOX);
            filtro_avanzado.Add(buscarAvanTXTB);
            filtro_avanzado.Add(buscarAvanBTN);

            if (filtroAvanBTN.Text.ToUpper().Contains("FILTR")) //Pregunta si el botón está en "Filtro avanzado" o similares.
            {
                filtroAvanBTN.Text = "Ocultar";
                buscarTXTB.Text = "";
                buscarTXTB.Enabled = false; buscarTXTB.Visible = false; //Oculta la barra superior de búsqueda simple.
                busquedaRapLBL.Enabled = false; busquedaRapLBL.Visible = false;


                foreach (Control control in filtro_avanzado) //Este foreach activa todos los controles del filtro avanzado.
                {
                    control.Enabled = true; control.Visible = true;
                }  
            }
            else //En caso contrario, el botón vuelve a mostrar la leyenda "Filtro Avanzado..." y se desactivan todos los controles del filtro.
            {//Vuelve a aparecer la barra de búsqueda simple.
                LeyendaTextBox(buscarTXTB);
                filtroAvanBTN.Text = "Filtro Avanzado";
                buscarTXTB.Enabled = true; buscarTXTB.Visible = true;
                busquedaRapLBL.Enabled = true; busquedaRapLBL.Visible = true;

                foreach (Control control in filtro_avanzado)
                {
                    control.Enabled = false; control.Visible = false;
                }
            }
        }

        //Declaración de las variables que almacenarán el tipo de letra usado en la barra de búsqueda simple y avanzada.
        private Font fuente;
        private float tamano;
        private Color color;
        private FontStyle estilo_fuente;
        //
        private void LeyendaTextBox(TextBox buscar) //Este método coloca en los textbox la leyenda "Buscar..." o la quita según su contenido.
        {
            if (buscar.Text.ToUpper() == "")
            {
                buscar.ForeColor = Color.FromArgb(128, 128, 128);
                buscar.Font = new Font(buscarTXTB.Font.FontFamily, 8, FontStyle.Italic);
                buscar.Text = "Buscar...";

            }
            else if (buscar.Text.ToUpper() == "BUSCAR...")
            {
                buscar.Text = "";
                buscar.Font = fuente;
                buscar.ForeColor = color;
            }
        }
        private void listaArticulosFRM_Load(object sender, EventArgs e)
        {
            CargarArticulos();
            //Se guardan los valores;
            fuente = buscarTXTB.Font;
            tamano = buscarTXTB.Font.Size;
            color = buscarTXTB.ForeColor;
            estilo_fuente = buscarTXTB.Font.Style;
            //

            //Se muestra la leyenda "Buscar..." en la barra de búsqueda simple.
            LeyendaTextBox(buscarTXTB);

            //Si no se invcluye la línea de acá abajo, al cargar el programa y seleccionar "Modificar" o "Eliminar", la App arroja una NullReferenceException.
            listaArticulosDGV.Select();
           
            //Carga de datos del filtro avanzado
            campoCBOX.Items.Add("Código de Artículo");
            campoCBOX.Items.Add("Nombre");
            campoCBOX.Items.Add("Marca");
            campoCBOX.Items.Add("Categoría");
            campoCBOX.Items.Add("Precio");
            campoCBOX.Items.Add("Descripción");
        }
        private void CargarArticulos()  
        {
            ListaGestion lista = new ListaGestion();
            try
            {
                listaDeArticulos = lista.Listar();
                listaArticulosDGV.DataSource = listaDeArticulos;
                OcultarColumnas();
                CargarImagen(listaDeArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }
        private void OcultarColumnas()
        {
            listaArticulosDGV.Columns["UrlImagen"].Visible = false;
            listaArticulosDGV.Columns["Id"].Visible = false;
            listaArticulosDGV.Columns["Precio"].Visible = false;
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                imagenArticuloPBOX.Load(imagen);
            }
            catch (Exception ex)
            {
                imagenArticuloPBOX.Load("https://imgs.search.brave.com/YZ1SjLQxhbj0Pd5D19P6s61NQ7GMYKNHOnjLmt8DrdQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4u/c2hvcGlmeS5jb20v/cy9maWxlcy8xLzA1/MzMvMjA4OS9maWxl/cy9wbGFjZWhvbGRl/ci1pbWFnZXMtaW1h/Z2VfbGFyZ2UucG5n/P3Y9MTUzMDEyOTA4/MQ");
            } //"https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png" este link dejó de funcionar ("Invalid Parameter").
        }
        private void buscarTXTB_Enter(object sender, EventArgs e)
        {
            LeyendaTextBox(buscarTXTB);
        }
        private void buscarTXTB_Leave(object sender, EventArgs e)
        {
            LeyendaTextBox(buscarTXTB);
        }
        private void buscarAvanTXTB_Leave(object sender, EventArgs e)
        {
            if (buscarAvanTXTB.Text == "") //Este if desactiva el evento click de Modificar si no hay ninguna columna seleccionada.
            {
                ListaGestion gestion = new ListaGestion();
                try
                {
                    if (ValidarFiltro())
                        return;

                    string campo = campoCBOX.SelectedItem.ToString();
                    string condicion = condicionCBOX.SelectedItem.ToString();
                    string filtro = buscarAvanTXTB.Text;
                    listaArticulosDGV.DataSource = gestion.Filtrar(campo, condicion, filtro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        private void agregarBTN_Click(object sender, EventArgs e)
        {
            CambiarCatalogoFRM ventana_de_cambios = new CambiarCatalogoFRM();
            ventana_de_cambios.Text = "Agregar Artículo";
            ventana_de_cambios.ShowDialog();
            CargarArticulos();
        }
        private void modificarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaArticulosDGV.CurrentRow != null)
                {
                    CambiarCatalogoFRM ventana_de_cambios = new CambiarCatalogoFRM((Articulo)listaArticulosDGV.CurrentRow.DataBoundItem); //Constructor para modificar artículo requiere un Articulo como parámetro.
                    ventana_de_cambios.Text = "Modificar Artículo";
                    ventana_de_cambios.ShowDialog();
                    CargarArticulos();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No hay ningún artículo seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listaArticulosDGV.CurrentRow != null)
            {
                Articulo articulo = (Articulo)listaArticulosDGV.CurrentRow.DataBoundItem;
                ImagenFRM imagen = new ImagenFRM(articulo.UrlImagen);
                imagen.ShowDialog();
            }
        }
        private void listaArticulosDGV_SelectionChanged(object sender, EventArgs e)
        {
            if(listaArticulosDGV.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)listaArticulosDGV.CurrentRow.DataBoundItem;
                CargarImagen(articuloSeleccionado.UrlImagen);
            }
        }
        private void eliminarBTN_Click(object sender, EventArgs e)
        {
            DialogResult eleccion;
            Articulo articuloEliminado; 
                eleccion = MessageBox.Show("Estás seguro de que quieres eliminar los artículos seleccionados? (No podrán ser recuperados).", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (eleccion == DialogResult.Yes)
                {
                    ListaGestion gestion = new ListaGestion();
                   
                    try
                    {     
                        if (listaArticulosDGV.SelectedRows.Count == 1)
                        {
                            articuloEliminado = (Articulo)listaArticulosDGV.CurrentRow.DataBoundItem;
                            gestion.Eliminar(articuloEliminado.Id);
                            CargarArticulos();
                        }
                        else //Código para eliminar múltiples artiículos seleccionados. En vez de un artículo se usa una lista de artículos.
                        {
                            List<Articulo> listaEliminar = new List<Articulo>();
                            foreach (DataGridViewRow fila in listaArticulosDGV.SelectedRows) 
                            {
                                articuloEliminado = (Articulo)fila.DataBoundItem;
                                listaEliminar.Add(articuloEliminado);
                            }
                            gestion.Eliminar(listaEliminar);
                            CargarArticulos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            
        }
        private void buscarTXTB_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = buscarTXTB.Text;

            if (listaArticulosDGV.CurrentRow == null)
                imagenArticuloPBOX.Image = null;

            if (filtro.Length >= 1 && filtro.ToUpper() != "BUSCAR...")
            {
                //Este filtro busca por código de artículo, nombre, descripción, marca y categoría.
                listaFiltrada = listaDeArticulos.FindAll(articuloX => articuloX.Nombre.ToUpper().Contains(filtro.ToUpper()) || articuloX.Descripcion.ToUpper().Contains(filtro.ToUpper()) || articuloX.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || articuloX.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || articuloX.Codigo.ToUpper().Contains(filtro.ToUpper()));
                listaArticulosDGV.DataSource = null;
                listaArticulosDGV.DataSource = listaFiltrada;
            }
            else
            {
                listaArticulosDGV.DataSource = null;
                listaArticulosDGV.DataSource = listaDeArticulos;
            }
            OcultarColumnas();
        }
        private bool ValidarFiltro() //Esta validación de filtro sólo chequea que estén completos el campo y la condición. Si la barra de búsqueda no tiene nada se
        {//muestra todo el catálogo.
            if (campoCBOX.SelectedIndex < 0)
            {
                MessageBox.Show("Ingrese un campo para filtrar.", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return true;
            }
            if(condicionCBOX.SelectedIndex < 0)
            {
                MessageBox.Show("Ingrese un condición para filtrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void campoCBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(campoCBOX.Text.ToUpper() != "PRECIO")
            {
                condicionCBOX.Items.Clear();
                condicionCBOX.Items.Add("Empieza con");
                condicionCBOX.Items.Add("Termina con");
                condicionCBOX.Items.Add("Contiene");
                condicionCBOX.Items.Add("No Contiene");

            }
            else
            {
                condicionCBOX.Items.Clear();
                condicionCBOX.Items.Add("Menor que");
                condicionCBOX.Items.Add("Mayor que");
                condicionCBOX.Items.Add("Igual a");
                condicionCBOX.Items.Add("Menor o igual que");
                condicionCBOX.Items.Add("Mayor o igual que");
            }
        }
        private void buscarAvanBTN_Click(object sender, EventArgs e)
        {
            ListaGestion gestion = new ListaGestion();

            try
            {
                if (ValidarFiltro())
                    return;

                string campo = campoCBOX.SelectedItem.ToString();
                string condicion = condicionCBOX.SelectedItem.ToString();
                string filtro = buscarAvanTXTB.Text;
                listaArticulosDGV.DataSource = gestion.Filtrar(campo, condicion, filtro);
                if (listaArticulosDGV.CurrentRow == null)
                    imagenArticuloPBOX.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }
        private void buscarAvanTXTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (campoCBOX.SelectedIndex >= 0) //Se ponen los 3 if por separado para que sean más legibles y entendibles.
            {//Primero se pregunta si el Selected Index es mayor o igual que 0. Si primero se preguntase si el campo elegido es "Precio" pero aún no se seleccionó ningún campo, el programa arroja una NullReferenceException.
                //Preguntando primero por el Selected Index nos ahorramos este problema.
                if (campoCBOX.SelectedItem.ToString().ToUpper() == "PRECIO")
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) //Si el campo es "Precio" la barra de búsqueda sólo admite números.
                        e.Handled = true;
                }
            }
        }
        private bool SoloNumeros(string texto) 
        {
            foreach(char caracter in texto)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
                
            }
            return true;
        } //Creo que esta función no se usa nunca pero por las dudas no la borro. No vaya a ser que reviente la app jajaja.  
    }
}
