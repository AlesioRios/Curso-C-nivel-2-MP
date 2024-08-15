﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public Articulo() //Constructor que genera un obejto Marca y un Objeto Categoria.
        {
            Marca = new Marca();
            Categoria = new Categoria();
        }
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; } //Declaración de propiedades.
        public string UrlImagen { get; set; }
        public decimal Precio { get; set; }
        [DisplayName("Precio")]
        public string PrecioString { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
    }
}
