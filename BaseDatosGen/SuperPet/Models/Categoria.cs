using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperPet.Models
{
    public class Categoria
    {
        //ID DE LA CATEGORIA
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //ID DE LA SUPERCATEGORIA
        [ScaffoldColumn(false)]
        public int idSuperCategoria { get; set; }

        //NOMBRE DE LA SUPERCATEGORIA
        [ScaffoldColumn(false)]
        public string NombreSupcat { get; set; }

        //NOMBRE DE LA CATEGORIA
        [Display(Prompt = "Nombre de la categoria", Description = "Nombre de la categoria", Name = "Nombre ")]
        [Required(ErrorMessage = "Debe indicar un nombre para la categoria")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string NombreCat { get; set; }


    }
}