

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BaseDatosGenNHibernate.Exceptions;

using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;


namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
/*
 *      Definition of the class ProductoCEN
 *
 */
public partial class ProductoCEN
{
private IProductoCAD _IProductoCAD;

public ProductoCEN()
{
        this._IProductoCAD = new ProductoCAD ();
}

public ProductoCEN(IProductoCAD _IProductoCAD)
{
        this._IProductoCAD = _IProductoCAD;
}

public IProductoCAD get_IProductoCAD ()
{
        return this._IProductoCAD;
}

public int New_ (string p_Nombre, string p_URLFoto, double p_Precio, int p_Stock, int p_categoria, double p_valoracionMedia, bool p_destacado, double p_oferta)
{
        ProductoEN productoEN = null;
        int oid;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Nombre = p_Nombre;

        productoEN.URLFoto = p_URLFoto;

        productoEN.Precio = p_Precio;

        productoEN.Stock = p_Stock;


        if (p_categoria != -1) {
                // El argumento p_categoria -> Property categoria es oid = false
                // Lista de oids id
                productoEN.Categoria = new BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN ();
                productoEN.Categoria.Id = p_categoria;
        }

        productoEN.ValoracionMedia = p_valoracionMedia;

        productoEN.Destacado = p_destacado;

        productoEN.Oferta = p_oferta;

        //Call to ProductoCAD

        oid = _IProductoCAD.New_ (productoEN);
        return oid;
}

public void Modify (int p_Producto_OID, string p_Nombre, string p_URLFoto, double p_Precio, int p_Stock, double p_valoracionMedia, bool p_destacado, double p_oferta)
{
        ProductoEN productoEN = null;

        //Initialized ProductoEN
        productoEN = new ProductoEN ();
        productoEN.Id = p_Producto_OID;
        productoEN.Nombre = p_Nombre;
        productoEN.URLFoto = p_URLFoto;
        productoEN.Precio = p_Precio;
        productoEN.Stock = p_Stock;
        productoEN.ValoracionMedia = p_valoracionMedia;
        productoEN.Destacado = p_destacado;
        productoEN.Oferta = p_oferta;
        //Call to ProductoCAD

        _IProductoCAD.Modify (productoEN);
}

public void Destroy (int id
                     )
{
        _IProductoCAD.Destroy (id);
}

public System.Collections.Generic.IList<ProductoEN> MuestraProductos (int first, int size)
{
        System.Collections.Generic.IList<ProductoEN> list = null;

        list = _IProductoCAD.MuestraProductos (first, size);
        return list;
}
public ProductoEN MuestraProductoPorOID (int id
                                         )
{
        ProductoEN productoEN = null;

        productoEN = _IProductoCAD.MuestraProductoPorOID (id);
        return productoEN;
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByNombre (string p_nombre, int first, int size)
{
        return _IProductoCAD.GetProductosByNombre (p_nombre, first, size);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetAllProductosByPedido (int p_pedido, int first, int size)
{
        return _IProductoCAD.GetAllProductosByPedido (p_pedido, first, size);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosVendidos (int first, int size)
{
        return _IProductoCAD.GetProductosVendidos (first, size);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosNuevos (int first, int size)
{
        return _IProductoCAD.GetProductosNuevos (first, size);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosDestacados (int first, int size)
{
        return _IProductoCAD.GetProductosDestacados (first, size);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductoConOferta (int first, int size)
{
        return _IProductoCAD.GetProductoConOferta (first, size);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetFavoritos (int p_usuario, int first, int size)
{
        return _IProductoCAD.GetFavoritos (p_usuario, first, size);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosCompradosByUsuario (int p_usuario, int first, int size)
{
        return _IProductoCAD.GetProductosCompradosByUsuario (p_usuario, first, size);
}
public void CambiarCategoria (int p_Producto_OID, int p_categoria_OID)
{
        //Call to ProductoCAD

        _IProductoCAD.CambiarCategoria (p_Producto_OID, p_categoria_OID);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByNombreStock (string p_nombre)
{
        return _IProductoCAD.GetProductosByNombreStock (p_nombre);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByPrecios (double? precio1, double ? precio2)
{
        return _IProductoCAD.GetProductosByPrecios (precio1, precio2);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByCategoria (string nombre)
{
        return _IProductoCAD.GetProductosByCategoria (nombre);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosBySuperCategoria (string nombre)
{
        return _IProductoCAD.GetProductosBySuperCategoria (nombre);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetTopVentas ()
{
        return _IProductoCAD.GetTopVentas ();
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByCategoriaId (int id, int first, int size)
{
        return _IProductoCAD.GetProductosByCategoriaId (id, first, size);
}
}
}
