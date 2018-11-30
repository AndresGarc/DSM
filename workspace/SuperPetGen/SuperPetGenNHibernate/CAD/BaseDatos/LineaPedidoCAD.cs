
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
 * Clase LineaPedido:
 *
 */

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial class LineaPedidoCAD : BasicCAD, ILineaPedidoCAD
{
public LineaPedidoCAD() : base ()
{
}

public LineaPedidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public LineaPedidoEN ReadOIDDefault (int Numero
                                     )
{
        LineaPedidoEN lineaPedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaPedidoEN = (LineaPedidoEN)session.Get (typeof(LineaPedidoEN), Numero);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoEN;
}

public System.Collections.Generic.IList<LineaPedidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LineaPedidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LineaPedidoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<LineaPedidoEN>();
                        else
                                result = session.CreateCriteria (typeof(LineaPedidoEN)).List<LineaPedidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LineaPedidoEN lineaPedido)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoEN lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), lineaPedido.Numero);

                lineaPedidoEN.Cantidad = lineaPedido.Cantidad;



                session.Update (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (LineaPedidoEN lineaPedido)
{
        try
        {
                SessionInitializeTransaction ();
                if (lineaPedido.Producto != null) {
                        // Argumento OID y no colección.
                        lineaPedido.Producto = (SuperPetGenNHibernate.EN.BaseDatos.ProductoEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.ProductoEN), lineaPedido.Producto.Id);

                        lineaPedido.Producto.LineaPedido
                        .Add (lineaPedido);
                }
                if (lineaPedido.Pedido != null) {
                        // Argumento OID y no colección.
                        lineaPedido.Pedido = (SuperPetGenNHibernate.EN.BaseDatos.PedidoEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.PedidoEN), lineaPedido.Pedido.Id);

                        lineaPedido.Pedido.LineaPedido
                        .Add (lineaPedido);
                }

                session.Save (lineaPedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedido.Numero;
}

public void Modify (LineaPedidoEN lineaPedido)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoEN lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), lineaPedido.Numero);

                lineaPedidoEN.Cantidad = lineaPedido.Cantidad;

                session.Update (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int Numero
                     )
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoEN lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), Numero);
                session.Delete (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<LineaPedidoEN> MuestraLineaPedidos (int first, int size)
{
        System.Collections.Generic.IList<LineaPedidoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(LineaPedidoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<LineaPedidoEN>();
                else
                        result = session.CreateCriteria (typeof(LineaPedidoEN)).List<LineaPedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: MuestraLineaPedidoPorOID
//Con e: LineaPedidoEN
public LineaPedidoEN MuestraLineaPedidoPorOID (int Numero
                                               )
{
        LineaPedidoEN lineaPedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaPedidoEN = (LineaPedidoEN)session.Get (typeof(LineaPedidoEN), Numero);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoEN;
}
}
}
