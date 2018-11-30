
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



/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CP.BaseDatos_Factura_crearFactura) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CP.BaseDatos
{
public partial class FacturaCP : BasicCP
{
public void CrearFactura (int p_pedido, Nullable<DateTime> p_FechaPago)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CP.BaseDatos_Factura_crearFactura) ENABLED START*/

        FacturaCEN facturaCEN = null;
        PedidoCEN pedidoCEN = null;
        DirEnvioCEN dirEnvioCEN = null;
        MetodoPagoCEN metodoPagoCEN = null;

        try
        {
                SessionInitializeTransaction ();
                IFacturaCAD facturaCAD = new FacturaCAD (session);
                IPedidoCAD pedidoCAD = new PedidoCAD (session);
                IDirEnvioCAD dirEnvioCAD = new DirEnvioCAD (session);
                IMetodoPagoCAD metodoPagoCAD = new MetodoPagoCAD (session);

                facturaCEN = new FacturaCEN (facturaCAD);
                pedidoCEN = new PedidoCEN (pedidoCAD);
                dirEnvioCEN = new DirEnvioCEN (dirEnvioCAD);
                metodoPagoCEN = new MetodoPagoCEN (metodoPagoCAD);

                PedidoEN pedidoEN = pedidoCEN.MuestraPedidoPorOID (p_oid);

                if (pedidoEN.Estado == Enumerated.BaseDatos.EstadoPedidoEnum.Pendiente) {
                        DirEnvioEN dirEnvioEN = dirEnvioCEN.MuestraDireccionPorOID (dirEnvioCEN.New_ (p_Calle, p_CP, p_Localidad, p_Provincia, p_oid));
                        MetodoPagoEN metodoPagoEN = metodoPagoCEN.MuestraMetodoPagoPorOID (metodoPagoCEN.New_ (p_TipoPago, p_oid));

                        //pedidoCEN.AddDirEnvio(p_oid, dirEnvioEN.Id);
                        //pedidoCEN.AddMetodoPago(p_oid, metodoPagoEN.Id);

                        double precioTotal = 0;
                        double totalIVA = 0;
                        double precioSinIVA = 0;

                        foreach (LineaPedidoEN lineaPedidoEN in pedidoEN.LineaPedido) {
                                ProductoEN productoEN = lineaPedidoEN.Producto;
                                precioTotal = precioTotal + (productoEN.Precio * lineaPedidoEN.Cantidad);
                        }

                        totalIVA = precioTotal * 0.21;
                        precioSinIVA = precioTotal - totalIVA;

                        facturaCEN.New_ (precioTotal, p_oid, totalIVA, precioSinIVA);
                        pedidoCEN.Modify (p_oid, pedidoEN.Fecha, Enumerated.BaseDatos.EstadoPedidoEnum.Pagado);
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
