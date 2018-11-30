
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



/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CP.BaseDatos_Pedido_enviarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CP.BaseDatos
{
public partial class PedidoCP : BasicCP
{
public BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN EnviarPedido (Nullable<DateTime> p_Fecha, int p_pedido)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CP.BaseDatos_Pedido_enviarPedido) ENABLED START*/

        BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN result = null;

        try
        {
                SessionInitializeTransaction ();

                IPedidoCAD pedidoCAD = new PedidoCAD (session);
                IProductoCAD prodCAD = new ProductoCAD (session);
                IEnvioCAD envioCAD = new EnvioCAD (session);

                PedidoCEN pedidoCEN = new PedidoCEN (pedidoCAD);
                ProductoCEN prodCEN = new ProductoCEN (prodCAD);
                EnvioCEN envioCEN = new EnvioCEN (envioCAD);

                PedidoEN pedidoEN = pedidoCEN.MuestraPedidoPorOID (p_pedido);

                if (pedidoEN.Estado == Enumerated.BaseDatos.EstadoPedidoEnum.Pagado) {
                        foreach (LineaPedidoEN lnEN in pedidoEN.LineaPedido) {
                                ProductoEN prodEN = lnEN.Producto;
                                prodCEN = new ProductoCEN (prodCAD);
                                prodCEN.DecrementaStock (prodEN.Id, lnEN.Cantidad);
                        }

                        pedidoEN.Estado = Enumerated.BaseDatos.EstadoPedidoEnum.Enviado;
                        pedidoCAD.Modify (pedidoEN);
                        envioCEN = new EnvioCEN (envioCAD);
                        envioCEN.New_ (DateTime.Now, p_Fecha, Enumerated.BaseDatos.EstadoEnvioEnum.EnCamino, p_pedido);
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
        return result;


        /*PROTECTED REGION END*/
}
}
}
