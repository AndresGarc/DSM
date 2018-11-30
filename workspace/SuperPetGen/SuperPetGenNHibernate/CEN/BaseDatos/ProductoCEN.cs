

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SuperPetGenNHibernate.Exceptions;

using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.CAD.BaseDatos;


namespace SuperPetGenNHibernate.CEN.BaseDatos
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

public int New_ (string p_Nombre, string p_URLFoto, float p_Precio, int p_Stock, int p_categoria, float p_valoracionMedia)
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
                productoEN.Categoria = new SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN ();
                productoEN.Categoria.Id = p_categoria;
        }

        productoEN.ValoracionMedia = p_valoracionMedia;

        //Call to ProductoCAD

        oid = _IProductoCAD.New_ (productoEN);
        return oid;
}

public void Modify (int p_Producto_OID, string p_Nombre, string p_URLFoto, float p_Precio, int p_Stock, float p_valoracionMedia)
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
}
}
