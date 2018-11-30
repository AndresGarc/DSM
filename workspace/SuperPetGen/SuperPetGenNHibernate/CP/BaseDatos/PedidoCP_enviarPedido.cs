
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.CAD.BaseDatos;
using SuperPetGenNHibernate.CEN.BaseDatos;



/*PROTECTED REGION ID(usingSuperPetGenNHibernate.CP.BaseDatos_Pedido_enviarPedido) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace SuperPetGenNHibernate.CP.BaseDatos
{
public partial class PedidoCP : BasicCP
{
public SuperPetGenNHibernate.EN.BaseDatos.PedidoEN EnviarPedido (Nullable<DateTime> p_Fecha, string p_TipoPago, SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum p_Estado, string p_usuario, string p_usuario_0)
{
        /*PROTECTED REGION ID(SuperPetGenNHibernate.CP.BaseDatos_Pedido_enviarPedido) ENABLED START*/

        IPedidoCAD pedidoCAD = null;
        PedidoCEN pedidoCEN = null;

        SuperPetGenNHibernate.EN.BaseDatos.PedidoEN result = null;


        try
        {
                SessionInitializeTransaction ();
                pedidoCAD = new PedidoCAD (session);
                pedidoCEN = new  PedidoCEN (pedidoCAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method EnviarPedido() not yet implemented.");



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
