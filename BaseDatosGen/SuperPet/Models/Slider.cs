using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace SuperPet.Models
{
    public class Slider
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Prompt = "Imagen 1 del slider", Description = "Descripción de la imagen1", Name = "Imagen1 ")]
        [Required(ErrorMessage = "Debe indicar una imagen para el slider")]
        public string Imagen1 { get; set; }

        [Display(Prompt = "Imagen 2 del slider", Description = "Descripción de la imagen2", Name = "Imagen2 ")]
        [Required(ErrorMessage = "Debe indicar una imagen para el slider")]
        public string Imagen2 { get; set; }

        [Display(Prompt = "Imagen 3 del slider", Description = "Descripción de la imagen3", Name = "Imagen3 ")]
        [Required(ErrorMessage = "Debe indicar una imagen para el slider")]
        public string Imagen3 { get; set; }

        [Display(Prompt = "Imagen 4 del slider", Description = "Descripción de la imagen4", Name = "Imagen4 ")]
        [Required(ErrorMessage = "Debe indicar una imagen para el slider")]
        public string Imagen4 { get; set; }


    }
}