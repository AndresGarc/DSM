using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperPet.Models
{
    public class Usuario
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Prompt = "Email", Description = "Email", Name = "Email")]
        [Required(ErrorMessage = "Debe indicar una direccion de email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Debe ser un correo electrónico válido")]
        public string Email { get; set; }

        [Display(Prompt = "Nombre de usuario", Description = "Nombre de usuario", Name = "Nombre de usuario")]
        [Required(ErrorMessage = "Debe indicar un nombre de usuario")]
        [StringLength(maximumLength: 20, ErrorMessage = "El nombre de usuario no puede tener más de 20 caracteres")]
        public string NombreUsuario { get; set; }

        [Display(Prompt = "Contraseña", Description = "Contraseña", Name = "Contraseña")]
        [Required(ErrorMessage = "Debe indicar una contraseña")]
        [DataType(DataType.Password)]
        [StringLength(maximumLength: 16, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres")]
        public string Password { get; set; }

        [Display(Prompt = "Nombre", Description = "Nombre", Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar su nombre")]
        [StringLength(maximumLength: 30, ErrorMessage = "El nombre no puede tener más de 30 caracteres")]
        public string Nombre { get; set; }

        [Display(Prompt = "Apellidos", Description = "Apellidos", Name = "Apellidos")]
        [Required(ErrorMessage = "Debe indicar sus apellidos")]
        [StringLength(maximumLength: 30, ErrorMessage = "El apellido no puede tener más de 30 caracteres")]
        public string Apellidos { get; set; }

        [Display(Prompt = "Fecha de nacimiento", Description = "Fecha de nacimiento", Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "Debe indicar la fecha de nacimiento")]
        [DataType(DataType.DateTime)]
        public DateTime Nacimiento { get; set; }

        [Display(Prompt = "Teléfono", Description = "Teléfono", Name = "Teléfono")]
        [Required(ErrorMessage = "Debe indicar un teléfono")]
        [DataType(DataType.PhoneNumber)]
        public int Telefono { get; set; }

        [Display(Prompt = "Logged", Description = "Logged", Name = "Logged")]
        public bool Logged { get; set; }

        [Display(Prompt = "Activo", Description = "Activo", Name = "Activo")]
        public bool Activo { get; set; }
    }
}