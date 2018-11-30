
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



/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CP.BaseDatos_Pedido_recibirPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CP.BaseDatos
{
public partial class PedidoCP : BasicCP
{
public void RecibirPedido (int p_pedido)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CP.BaseDatos_Pedido_recibirPedido) ENABLED START*/

        try
        {
                SessionInitializeTransaction ();

                IPedidoCAD pedidoCAD = new PedidoCAD (session);
                IEnvioCAD envioCAD = new EnvioCAD (session);

                PedidoCEN pedidoCEN = new PedidoCEN (pedidoCAD);
                EnvioCEN envioCEN = new EnvioCEN (envioCAD);

                PedidoEN pedidoEN = pedidoCEN.MuestraPedidoPorOID (p_pedido);
                EnvioEN envioEN = pedidoEN.Envio;

                if (pedidoEN.Estado == Enumerated.BaseDatos.EstadoPedidoEnum.Enviado) {
                        pedidoEN.Estado = Enumerated.BaseDatos.EstadoPedidoEnum.Recibido;
                        pedidoCAD.Modify (pedidoEN);

                        envioEN.Estado = Enumerated.BaseDatos.EstadoEnvioEnum.Entregado;
                        envioCAD.Modify (envioEN);
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
