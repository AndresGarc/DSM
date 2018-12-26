using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperPet.Models
{
    public class Comentario
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [ScaffoldColumn(false)]
        public int idUsuario { get; set; }

        [ScaffoldColumn(false)]
        public int idProducto { get; set; }

        [Display(Prompt = "Texto", Description = "Comentario del usuario", Name = "Comentario ")]
        [StringLength(maximumLength: 200, ErrorMessage = "El comentario no puede tener más de 200 caracteres")]
        public string TextoComentario { get; set; }

        [Display(Prompt = "Fecha", Description = "Fecha del comentario", Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Display(Prompt = "Usuario", Description = "Autor del comentario", Name = "Usuario ")]
        public string NombreUsuario { get; set; }

    }
}