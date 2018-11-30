
using System;
using System.Text;
using EjemploViernesGenNHibernate.CEN.EjemploViernes;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using EjemploViernesGenNHibernate.EN.EjemploViernes;
using EjemploViernesGenNHibernate.Exceptions;


/*
 * Clase Pedido:
 *
 */

namespace EjemploViernesGenNHibernate.CAD.EjemploViernes
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
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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

                pedidoEN.Descripcion = pedido.Descripcion;




                pedidoEN.Estado = pedido.Estado;


                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                if (pedido.Cliente != null) {
                        // Argumento OID y no colección.
                        pedido.Cliente = (EjemploViernesGenNHibernate.EN.EjemploViernes.ClienteEN)session.Load (typeof(EjemploViernesGenNHibernate.EN.EjemploViernes.ClienteEN), pedido.Cliente.DNI);

                        pedido.Cliente.Pedidos
                        .Add (pedido);
                }

                session.Save (pedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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

                pedidoEN.Descripcion = pedido.Descripcion;


                pedidoEN.Estado = pedido.Estado;

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
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
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AnyDir (int p_Pedido_OID, System.Collections.Generic.IList<int> p_dirEnvio_OIDs)
{
        EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN pedidoEN = null;
        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);
                EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN dirEnvioENAux = null;
                if (pedidoEN.DirEnvio == null) {
                        pedidoEN.DirEnvio = new System.Collections.Generic.List<EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN>();
                }

                foreach (int item in p_dirEnvio_OIDs) {
                        dirEnvioENAux = new EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN ();
                        dirEnvioENAux = (EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN)session.Load (typeof(EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN), item);
                        dirEnvioENAux.Pedido.Add (pedidoEN);

                        pedidoEN.DirEnvio.Add (dirEnvioENAux);
                }


                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void ElimDir (int p_Pedido_OID, System.Collections.Generic.IList<int> p_dirEnvio_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN pedidoEN = null;
                pedidoEN = (PedidoEN)session.Load (typeof(PedidoEN), p_Pedido_OID);

                EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN dirEnvioENAux = null;
                if (pedidoEN.DirEnvio != null) {
                        foreach (int item in p_dirEnvio_OIDs) {
                                dirEnvioENAux = (EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN)session.Load (typeof(EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN), item);
                                if (pedidoEN.DirEnvio.Contains (dirEnvioENAux) == true) {
                                        pedidoEN.DirEnvio.Remove (dirEnvioENAux);
                                        dirEnvioENAux.Pedido.Remove (pedidoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_dirEnvio_OIDs you are trying to unrelationer, doesn't exist in PedidoEN");
                        }
                }

                session.Update (pedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in PedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
