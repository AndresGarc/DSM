
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
 * Clase MetodoPago:
 *
 */

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial class MetodoPagoCAD : BasicCAD, IMetodoPagoCAD
{
public MetodoPagoCAD() : base ()
{
}

public MetodoPagoCAD(ISession sessionAux) : base (sessionAux)
{
}



public MetodoPagoEN ReadOIDDefault (int id
                                    )
{
        MetodoPagoEN metodoPagoEN = null;

        try
        {
                SessionInitializeTransaction ();
                metodoPagoEN = (MetodoPagoEN)session.Get (typeof(MetodoPagoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return metodoPagoEN;
}

public System.Collections.Generic.IList<MetodoPagoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MetodoPagoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MetodoPagoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MetodoPagoEN>();
                        else
                                result = session.CreateCriteria (typeof(MetodoPagoEN)).List<MetodoPagoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MetodoPagoEN metodoPago)
{
        try
        {
                SessionInitializeTransaction ();
                MetodoPagoEN metodoPagoEN = (MetodoPagoEN)session.Load (typeof(MetodoPagoEN), metodoPago.Id);

                metodoPagoEN.TipoPago = metodoPago.TipoPago;



                session.Update (metodoPagoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MetodoPagoEN metodoPago)
{
        try
        {
                SessionInitializeTransaction ();
                if (metodoPago.Usuario != null) {
                        // Argumento OID y no colección.
                        metodoPago.Usuario = (BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN)session.Load (typeof(BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN), metodoPago.Usuario.Id);

                        metodoPago.Usuario.MetodoPago
                        .Add (metodoPago);
                }

                session.Save (metodoPago);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return metodoPago.Id;
}

public void Modify (MetodoPagoEN metodoPago)
{
        try
        {
                SessionInitializeTransaction ();
                MetodoPagoEN metodoPagoEN = (MetodoPagoEN)session.Load (typeof(MetodoPagoEN), metodoPago.Id);

                metodoPagoEN.TipoPago = metodoPago.TipoPago;

                session.Update (metodoPagoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
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
                MetodoPagoEN metodoPagoEN = (MetodoPagoEN)session.Load (typeof(MetodoPagoEN), id);
                session.Delete (metodoPagoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: MuestraMetodoPagoPorOID
//Con e: MetodoPagoEN
public MetodoPagoEN MuestraMetodoPagoPorOID (int id
                                             )
{
        MetodoPagoEN metodoPagoEN = null;

        try
        {
                SessionInitializeTransaction ();
                metodoPagoEN = (MetodoPagoEN)session.Get (typeof(MetodoPagoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return metodoPagoEN;
}

public System.Collections.Generic.IList<MetodoPagoEN> MuestraMetodoPagos (int first, int size)
{
        System.Collections.Generic.IList<MetodoPagoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MetodoPagoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MetodoPagoEN>();
                else
                        result = session.CreateCriteria (typeof(MetodoPagoEN)).List<MetodoPagoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN> GetMetodoPagoByPedido (int p_pedido, int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MetodoPagoEN self where SELECT met FROM MetodoPagoEN as met INNER JOIN met.Pedido as ped WHERE ped.Id = :p_pedido";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MetodoPagoENgetMetodoPagoByPedidoHQL");
                query.SetParameter ("p_pedido", p_pedido);

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in MetodoPagoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
