
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
 * Clase Producto:
 *
 */

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial class ProductoCAD : BasicCAD, IProductoCAD
{
public ProductoCAD() : base ()
{
}

public ProductoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ProductoEN ReadOIDDefault (int id
                                  )
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}

public System.Collections.Generic.IList<ProductoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ProductoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ProductoEN>();
                        else
                                result = session.CreateCriteria (typeof(ProductoEN)).List<ProductoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), producto.Id);

                productoEN.Nombre = producto.Nombre;


                productoEN.URLFoto = producto.URLFoto;


                productoEN.Precio = producto.Precio;


                productoEN.Stock = producto.Stock;






                productoEN.ValoracionMedia = producto.ValoracionMedia;




                productoEN.Destacado = producto.Destacado;


                productoEN.Oferta = producto.Oferta;

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                if (producto.Categoria != null) {
                        // Argumento OID y no colección.
                        producto.Categoria = (BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN)session.Load (typeof(BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN), producto.Categoria.Id);

                        producto.Categoria.Producto
                        .Add (producto);
                }

                session.Save (producto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return producto.Id;
}

public void Modify (ProductoEN producto)
{
        try
        {
                SessionInitializeTransaction ();
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), producto.Id);

                productoEN.Nombre = producto.Nombre;


                productoEN.URLFoto = producto.URLFoto;


                productoEN.Precio = producto.Precio;


                productoEN.Stock = producto.Stock;


                productoEN.ValoracionMedia = producto.ValoracionMedia;


                productoEN.Destacado = producto.Destacado;


                productoEN.Oferta = producto.Oferta;

                session.Update (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
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
                ProductoEN productoEN = (ProductoEN)session.Load (typeof(ProductoEN), id);
                session.Delete (productoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ProductoEN> MuestraProductos (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ProductoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ProductoEN>();
                else
                        result = session.CreateCriteria (typeof(ProductoEN)).List<ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: MuestraProductoPorOID
//Con e: ProductoEN
public ProductoEN MuestraProductoPorOID (int id
                                         )
{
        ProductoEN productoEN = null;

        try
        {
                SessionInitializeTransaction ();
                productoEN = (ProductoEN)session.Get (typeof(ProductoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productoEN;
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByNombre (string p_nombre, int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where FROM ProductoEN pro WHERE pro.Nombre LIKE '%'+:p_nombre +'%'";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENgetProductosByNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetAllProductosByPedido (int p_pedido, int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where SELECT producto FROM ProductoEN producto INNER JOIN producto.LineaPedido as lnPed WHERE lnPed.Pedido.Id = :p_pedido";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENgetAllProductosByPedidoHQL");
                query.SetParameter ("p_pedido", p_pedido);

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosVendidos (int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where SELECT prod, sum(lnPed.Cantidad) FROM ProductoEN as prod INNER JOIN prod.LineaPedido as lnPed ";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENgetProductosVendidosHQL");

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosNuevos (int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where FROM ProductoEN as prod ORDER BY prod.Id desc";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENgetProductosNuevosHQL");

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosDestacados (int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where FROM ProductoEN as prod WHERE prod.Destacado = true";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENgetProductosDestacadosHQL");

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductoConOferta (int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where FROM ProductoEN prod WHERE prod.Oferta > 0";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENgetProductoConOfertaHQL");

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetFavoritos (string p_usuario, int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where SELECT prod FROM ProductoEN as prod INNER JOIN prod.UsuarioFavorito as favs WHERE favs.Email = :p_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENgetFavoritosHQL");
                query.SetParameter ("p_usuario", p_usuario);

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosCompradosByUsuario (string p_usuario, int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ProductoEN self where SELECT prod FROM ProductoEN as prod INNER JOIN prod.LineaPedido as lnPed WHERE lnPed.Pedido.UsuarioPedido.Email = :p_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ProductoENgetProductosCompradosByUsuarioHQL");
                query.SetParameter ("p_usuario", p_usuario);

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in ProductoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
