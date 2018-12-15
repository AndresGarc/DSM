using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace SuperPet.Models
{
    public class AssemblerPedido
    {
        public Pedido ConvertENToModelUI(PedidoEN en)
        {
            Pedido ped = new Pedido();
            ped.Id = en.Id;
            ped.Email = en.UsuarioPedido.Email;
            ped.Fecha = DateTime.Parse(en.Fecha.ToString());
            ped.Estado = en.Estado;
            ped.IdFactura = en.Factura.Id;
            ped.IdDirEnvio = en.DirEnvio.Id;
            ped.IdMetodoPago = en.MetodoPago.Id;

            return ped;
        }

        public IList<Pedido> ConvertListENToModel(IList<PedidoEN> ens)
        {
            IList<Pedido> peds = new List<Pedido>();
            foreach (PedidoEN en in ens)
            {
                peds.Add(ConvertENToModelUI(en));
            }
            return peds;
        }
    }
}