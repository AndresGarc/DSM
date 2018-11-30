using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Producto//No se que hacer con los comentarios si cogerlos como lista o no cogerlos aqui porque necesito todos no uno
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [ScaffoldColumn(false)]
        public int IdCategoria { get; set; }

        [ScaffoldColumn(false)]
        public string NombreCategoria { get; set; }
        /* No se si va por supercategoria o por subcategoria
        [ScaffoldColumn(false)]
        public string Subcategoria { get; set; }
        */
        [Display(Prompt = "Nombre del producto", Description = "Nombre del producto", Name = "Nombre ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el producto")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Nombre { get; set; }

        [Display(Prompt = "Precio del producto", Description = "Precio del producto", Name = "Precio ")]
        [Required(ErrorMessage = "Debe indicar un precio para el producto")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe ser mayor que cero y menor de 10000")]
        public double Precio { get; set; }

        [Display(Prompt = "Stock del producto", Description = "Stock del producto", Name = "Stock ")]
        [Required(ErrorMessage = "Debe indicar un stock para el producto")]
        [DataType(DataType.Currency, ErrorMessage = "El stock debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El stock debe ser cero o mayor que cero")]
        public int Stock { get; set; }

        [Display(Prompt = "Descripción del producto", Description = "Descripción del producto", Name = "Descripción ")]
        [Required(ErrorMessage = "Debe indicar una descripción para el producto")]
        [StringLength(maximumLength: 200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }


        [Display(Prompt = "Imagen del producto", Description = "Imagen del producto", Name = "Imagen ")]
        [Required(ErrorMessage = "Debe indicar una imagen del producto")]
        public string Imagen { get; set; }

        [ScaffoldColumn(true)]//No se si asi o como los otros que quiero mostrar al crear
        public bool Destacado { get; set; }

        [Display(Prompt = "Oferta del producto", Description = "Oferta del producto", Name = "Oferta ")]
        [Required(ErrorMessage = "Debe indicar una oferta para el producto, si no tiene oferta poner un 0")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 1, ErrorMessage = "El oferta debe ser mayor que cero y menor de 1 (num. decimal)")]
        public double Oferta { get; set; }

        [ScaffoldColumn(false)]
        public double ValoracionMedia { get; set; }
    }
}