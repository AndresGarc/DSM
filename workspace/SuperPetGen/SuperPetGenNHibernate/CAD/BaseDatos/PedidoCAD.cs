
using System;
using System.Text;
using SuperPetGenNHibernate.CEN.BaseDatos;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.Exceptions;


/*
 * Clase Pedido:
 *
 */

namespace SuperPetGenNHibernate.CAD.BaseDatos
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
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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


                pedidoEN.TipoPago = pedido.TipoPago;


                pedidoEN.Estado = pedido.Estado;








                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                if (pedido.Usuario != null) {
                        // Argumento OID y no colección.
                        pedido.Usuario = (SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN), pedido.Usuario.Email);

                        pedido.Usuario.PedidoRealizado
                        .Add (pedido);
                }
                if (pedido.Usuario_0 != null) {
                        // Argumento OID y no colección.
                        pedido.Usuario_0 = (SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN), pedido.Usuario_0.Email);

                        pedido.Usuario_0.CarritoActual
                                = pedido;
                }
                if (pedido.LineaPedido != null) {
                        foreach (SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN item in pedido.LineaPedido) {
                                item.Pedido = pedido;
                                session.Save (item);
                        }
                }

                session.Save (pedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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


                pedidoEN.TipoPago = pedido.TipoPago;


                pedidoEN.Estado = pedido.Estado;

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}

public void AddDirEnvio (int p_Pedido_OID, System.Collections.Generic.IList<int> p_dirEnvio_OIDs)
{
        SuperPetGenNHibernate.EN.BaseDatos.PedidoEN pedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);
                SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN dirEnvioENAux = null;
                if (pedidoEN.DirEnvio == null) {
                        pedidoEN.DirEnvio = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN>();
                }

                foreach (int item in p_dirEnvio_OIDs) {
                        dirEnvioENAux = new SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN ();
                        dirEnvioENAux = (SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN), item);
                        dirEnvioENAux.Pedido.Add (pedidoEN);

                        pedidoEN.DirEnvio.Add (dirEnvioENAux);
                }


                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AddMetodoPago (int p_Pedido_OID, int p_metodoPago_OID)
{
        SuperPetGenNHibernate.EN.BaseDatos.PedidoEN pedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);
                pedidoEN.MetodoPago = (SuperPetGenNHibernate.EN.BaseDatos.MetodoPagoEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.MetodoPagoEN), p_metodoPago_OID);

                pedidoEN.MetodoPago.Pedido.Add (pedidoEN);



                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
