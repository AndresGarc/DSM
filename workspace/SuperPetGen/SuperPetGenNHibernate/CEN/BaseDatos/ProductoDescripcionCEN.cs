

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
 *      Definition of the class ProductoDescripcionCEN
 *
 */
public partial class ProductoDescripcionCEN
{
private IProductoDescripcionCAD _IProductoDescripcionCAD;

public ProductoDescripcionCEN()
{
        this._IProductoDescripcionCAD = new ProductoDescripcionCAD ();
}

public ProductoDescripcionCEN(IProductoDescripcionCAD _IProductoDescripcionCAD)
{
        this._IProductoDescripcionCAD = _IProductoDescripcionCAD;
}

public IProductoDescripcionCAD get_IProductoDescripcionCAD ()
{
        return this._IProductoDescripcionCAD;
}

public int New_ (int p_producto, string p_texto, SuperPetGenNHibernate.Enumerated.BaseDatos.IdiomaEnum p_idioma)
{
        ProductoDescripcionEN productoDescripcionEN = null;
        int oid;

        //Initialized ProductoDescripcionEN
        productoDescripcionEN = new ProductoDescripcionEN ();

        if (p_producto != -1) {
                // El argumento p_producto -> Property producto es oid = false
                // Lista de oids id
                productoDescripcionEN.Producto = new SuperPetGenNHibernate.EN.BaseDatos.ProductoEN ();
                productoDescripcionEN.Producto.Id = p_producto;
        }

        productoDescripcionEN.Texto = p_texto;

        productoDescripcionEN.Idioma = p_idioma;

        //Call to ProductoDescripcionCAD

        oid = _IProductoDescripcionCAD.New_ (productoDescripcionEN);
        return oid;
}

public void Modify (int p_ProductoDescripcion_OID, string p_texto, SuperPetGenNHibernate.Enumerated.BaseDatos.IdiomaEnum p_idioma)
{
        ProductoDescripcionEN productoDescripcionEN = null;

        //Initialized ProductoDescripcionEN
        productoDescripcionEN = new ProductoDescripcionEN ();
        productoDescripcionEN.Id = p_ProductoDescripcion_OID;
        productoDescripcionEN.Texto = p_texto;
        productoDescripcionEN.Idioma = p_idioma;
        //Call to ProductoDescripcionCAD

        _IProductoDescripcionCAD.Modify (productoDescripcionEN);
}

public void Destroy (int id
                     )
{
        _IProductoDescripcionCAD.Destroy (id);
}

public ProductoDescripcionEN MuestraProductoDescripcionPorOID (int id
                                                               )
{
        ProductoDescripcionEN productoDescripcionEN = null;

        productoDescripcionEN = _IProductoDescripcionCAD.MuestraProductoDescripcionPorOID (id);
        return productoDescripcionEN;
}

public System.Collections.Generic.IList<ProductoDescripcionEN> MuestraProductoDescripcion (int first, int size)
{
        System.Collections.Generic.IList<ProductoDescripcionEN> list = null;

        list = _IProductoDescripcionCAD.MuestraProductoDescripcion (first, size);
        return list;
}
}
}
