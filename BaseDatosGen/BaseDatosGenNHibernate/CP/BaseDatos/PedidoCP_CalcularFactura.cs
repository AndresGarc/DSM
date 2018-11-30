
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



/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CP.BaseDatos_Pedido_calcularFactura) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CP.BaseDatos
{
public partial class PedidoCP : BasicCP
{
public System.Collections.Generic.IList<double> CalcularFactura (int p_pedido, ISession p_session)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CP.BaseDatos_Pedido_calcularFactura) ENABLED START*/

        System.Collections.Generic.IList<double>  result = null;

        try
        {
                SessionInitializeTransaction ();
                IPedidoCAD pedidoCAD = new PedidoCAD (p_session);
                PedidoCEN pedidoCEN = new  PedidoCEN (pedidoCAD);

                PedidoEN pedidoEN = pedidoCEN.MuestraPedidoPorOID (p_pedido);

                double precioTotal = 0;
                double totalIVA = 0;
                double precioSinIVA = 0;

                foreach (LineaPedidoEN lineaPedidoEN in pedidoEN.LineaPedido) {
                        ProductoEN productoEN = lineaPedidoEN.Producto;
                        precioTotal = precioTotal + (productoEN.Precio * lineaPedidoEN.Cantidad);
                }

                totalIVA = precioTotal * 0.21;
                precioSinIVA = precioTotal - totalIVA;

                result = new List<double>();
                result.Add (precioTotal);
                result.Add (precioSinIVA);
                result.Add (totalIVA);

                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
