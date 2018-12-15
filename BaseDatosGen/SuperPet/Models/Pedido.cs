using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SuperPet.Models
{
    public class Pedido
    {
        [Display(Prompt = "Pedido", Description = "Pedido", Name = "Pedido")]
        public int Id { get; set; }

        [Display(Prompt = "Email", Description = "Email del usuario", Name = "Email")]
        [Required(ErrorMessage = "Debe indicar una direccion de email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Debe ser un correo electrónico válido")]
        public string Email { get; set; }

        [Display(Prompt = "Fecha", Description = "Fecha del pedido", Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Display(Prompt = "Estado del pedido", Description = "Estado del pedido", Name = "Estado")]
        public BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum Estado { get; set; }

        [ScaffoldColumn(false)]
        public int NumLinPed { get; set; }

        [ScaffoldColumn(false)]
        public int IdFactura { get; set; }

        [ScaffoldColumn(false)]
        public int IdDirEnvio { get; set; }

        [ScaffoldColumn(false)]
        public int IdMetodoPago { get; set; }

        [ScaffoldColumn(false)]
        public int IdEnvio { get; set; }
    }
}