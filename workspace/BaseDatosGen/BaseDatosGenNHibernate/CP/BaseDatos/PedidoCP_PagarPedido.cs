
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;



/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CP.BaseDatos_Pedido_pagarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CP.BaseDatos
{
public partial class PedidoCP : BasicCP
{
public void PagarPedido (int p_pedido, int p_dirEnvio, int p_metodoPago)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CP.BaseDatos_Pedido_pagarPedido) ENABLED START*/

        try
        {
                SessionInitializeTransaction ();

                IPedidoCAD pedidoCAD = new PedidoCAD (session);
                IDirEnvioCAD dirEnvioCAD = new DirEnvioCAD (session);
                IMetodoPagoCAD metodoPagoCAD = new MetodoPagoCAD (session);
                IFacturaCAD facturaCAD = new FacturaCAD (session);

                PedidoCEN pedidoCEN = new PedidoCEN (pedidoCAD);
                DirEnvioCEN dirEnvioCEN = new DirEnvioCEN (dirEnvioCAD);
                MetodoPagoCEN metodoPagoCEN = new MetodoPagoCEN (metodoPagoCAD);
                FacturaCEN facturaCEN = new FacturaCEN (facturaCAD);

                PedidoEN pedidoEN = pedidoCEN.MuestraPedidoPorOID (p_pedido);

                if (pedidoEN.Estado == Enumerated.BaseDatos.EstadoPedidoEnum.Pendiente) {
                        DirEnvioEN dirEnvioEN = dirEnvioCEN.MuestraDireccionPorOID (p_dirEnvio);
                        MetodoPagoEN metodoPagoEN = metodoPagoCEN.MuestraMetodoPagoPorOID (p_metodoPago);

                        pedidoCEN.AddDirEnvio (p_pedido, dirEnvioEN.Id);
                        pedidoCEN.AddMetodoPago (p_pedido, metodoPagoEN.Id);
                        pedidoEN.Estado = Enumerated.BaseDatos.EstadoPedidoEnum.Pagado;
                        pedidoCAD.Modify (pedidoEN);

                        double precioTotal = 0;
                        double totalIVA = 0;
                        double precioSinIVA = 0;

                        foreach (LineaPedidoEN lineaPedidoEN in pedidoEN.LineaPedido) {
                                ProductoEN productoEN = lineaPedidoEN.Producto;
                                precioTotal = precioTotal + (productoEN.Precio * lineaPedidoEN.Cantidad);
                        }

                        totalIVA = precioTotal * 0.21;
                        precioSinIVA = precioTotal - totalIVA;

                        facturaCEN.New_ (precioTotal, p_pedido, totalIVA, precioSinIVA, DateTime.Now);
                }

                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
