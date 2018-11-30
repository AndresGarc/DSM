
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
 * Clase ProductoDescripcion:
 *
 */

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial class ProductoDescripcionCAD : BasicCAD, IProductoDescripcionCAD
{
public ProductoDescripcionCAD() : base ()
{
}

public ProductoDescripcionCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProductoDescripcionEN ReadOIDDefault (int id
                                             )
{
        ProductoDescripcionEN productoDescripcionEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoDescripcionEN = (ProductoDescripcionEN)session.Get (typeof(ProductoDescripcionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoDescripcionEN;
}

public System.Collections.Generic.IList<ProductoDescripcionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ProductoDescripcionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ProductoDescripcionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ProductoDescripcionEN>();
                        else
                                result = session.CreateCriteria (typeof(ProductoDescripcionEN)).List<ProductoDescripcionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoDescripcionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ProductoDescripcionEN productoDescripcion)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoDescripcionEN productoDescripcionEN = (ProductoDescripcionEN)session.Load (typeof(ProductoDescripcionEN), productoDescripcion.Id);

                productoDescripcionEN.Texto = productoDescripcion.Texto;


                productoDescripcionEN.Idioma = productoDescripcion.Idioma;


                session.Update (productoDescripcionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ProductoDescripcionEN productoDescripcion)
{
        try
        {
                SessionInitializeTransaction ();
                if (productoDescripcion.Producto != null) {
                        // Argumento OID y no colección.
                        productoDescripcion.Producto = (BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN)session.Load (typeof(BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN), productoDescripcion.Producto.Id);

                        productoDescripcion.Producto.ProductoDescripcion
                        .Add (productoDescripcion);
                }

                session.Save (productoDescripcion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoDescripcion.Id;
}

public void Modify (ProductoDescripcionEN productoDescripcion)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoDescripcionEN productoDescripcionEN = (ProductoDescripcionEN)session.Load (typeof(ProductoDescripcionEN), productoDescripcion.Id);

                productoDescripcionEN.Texto = productoDescripcion.Texto;


                productoDescripcionEN.Idioma = productoDescripcion.Idioma;

                session.Update (productoDescripcionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoDescripcionCAD.", ex);
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
                ProductoDescripcionEN productoDescripcionEN = (ProductoDescripcionEN)session.Load (typeof(ProductoDescripcionEN), id);
                session.Delete (productoDescripcionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: MuestraProductoDescripcionPorOID
//Con e: ProductoDescripcionEN
public ProductoDescripcionEN MuestraProductoDescripcionPorOID (int id
                                                               )
{
        ProductoDescripcionEN productoDescripcionEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoDescripcionEN = (ProductoDescripcionEN)session.Get (typeof(ProductoDescripcionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoDescripcionEN;
}

public System.Collections.Generic.IList<ProductoDescripcionEN> MuestraProductoDescripcion (int first, int size)
{
        System.Collections.Generic.IList<ProductoDescripcionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProductoDescripcionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProductoDescripcionEN>();
                else
                        result = session.CreateCriteria (typeof(ProductoDescripcionEN)).List<ProductoDescripcionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
