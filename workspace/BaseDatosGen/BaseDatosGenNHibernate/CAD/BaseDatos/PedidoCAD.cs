
using System;
using System.Text;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.Exceptions;


/*
 * Clase Pedido:
 *
 */

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial class PedidoCAD : BasicCAD, IPedidoCAD
{
public PedidoCAD() : base ()
{
}

public PedidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PedidoEN ReadOIDDefault (int id
                                )
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PedidoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PedidoEN>();
                        else
                                result = session.CreateCriteria (typeof(PedidoEN)).List<PedidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), pedido.Id);

                pedidoEN.Fecha = pedido.Fecha;


                pedidoEN.Estado = pedido.Estado;








                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                if (pedido.UsuarioPedido != null) {
                        // Argumento OID y no colección.
                        pedido.UsuarioPedido = (BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN)session.Load (typeof(BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN), pedido.UsuarioPedido.Email);

                        pedido.UsuarioPedido.PedidoRealizado
                        .Add (pedido);
                }
                if (pedido.UsuarioCarrito != null) {
                        // Argumento OID y no colección.
                        pedido.UsuarioCarrito = (BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN)session.Load (typeof(BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN), pedido.UsuarioCarrito.Email);

                        pedido.UsuarioCarrito.CarritoActual
                                = pedido;
                }

                session.Save (pedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedido.Id;
}

public void Modify (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), pedido.Id);

                pedidoEN.Fecha = pedido.Fecha;


                pedidoEN.Estado = pedido.Estado;

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                PedidoEN pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), id);
                session.Delete (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<PedidoEN> MuestraPedidos (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PedidoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PedidoEN>();
                else
                        result = session.CreateCriteria (typeof(PedidoEN)).List<PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: MuestraPedidoPorOID
//Con e: PedidoEN
public PedidoEN MuestraPedidoPorOID (int id
                                     )
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}

public void AddDirEnvio (int p_Pedido_OID, int p_dirEnvio_OID)
{
        BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);
                pedidoEN.DirEnvio = (BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN)session.Load (typeof(BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN), p_dirEnvio_OID);

                pedidoEN.DirEnvio.Pedido.Add (pedidoEN);



                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AddMetodoPago (int p_Pedido_OID, int p_metodoPago_OID)
{
        BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);
                pedidoEN.MetodoPago = (BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN)session.Load (typeof(BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN), p_metodoPago_OID);

                pedidoEN.MetodoPago.Pedido.Add (pedidoEN);



                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> GetAllPedidosByUsuario (string p_usuario, int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PedidoEN self where FROM PedidoEN ped WHERE ped.UsuarioPedido.Email = :p_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PedidoENgetAllPedidosByUsuarioHQL");
                query.SetParameter ("p_usuario", p_usuario);

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
