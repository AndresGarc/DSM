
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



/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CP.BaseDatos_Pedido_rechazarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CP.BaseDatos
{
public partial class PedidoCP : BasicCP
{
public void RechazarPedido (int p_pedido)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CP.BaseDatos_Pedido_rechazarPedido) ENABLED START*/

        try
        {
                SessionInitializeTransaction ();

                IPedidoCAD pedidoCAD = new PedidoCAD (session);
                IEnvioCAD envioCAD = new EnvioCAD (session);

                PedidoCEN pedidoCEN = new PedidoCEN (pedidoCAD);
                EnvioCEN envioCEN = new EnvioCEN (envioCAD);

                PedidoEN pedidoEN = pedidoCEN.MuestraPedidoPorOID (p_pedido);

                if (pedidoEN.Estado == Enumerated.BaseDatos.EstadoPedidoEnum.Enviado) {
                        EnvioEN envioEN = pedidoEN.Envio;

                        envioEN.Estado = Enumerated.BaseDatos.EstadoEnvioEnum.Extraviado;
                        envioCAD.Modify (envioEN);
                }

                pedidoEN.Estado = Enumerated.BaseDatos.EstadoPedidoEnum.Rechazado;
                pedidoCAD.Modify (pedidoEN);

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
