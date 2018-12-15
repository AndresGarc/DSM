

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
 *      Definition of the class CategoriaCEN
 *
 */
public partial class CategoriaCEN
{
private ICategoriaCAD _ICategoriaCAD;

public CategoriaCEN()
{
        this._ICategoriaCAD = new CategoriaCAD ();
}

public CategoriaCEN(ICategoriaCAD _ICategoriaCAD)
{
        this._ICategoriaCAD = _ICategoriaCAD;
}

public ICategoriaCAD get_ICategoriaCAD ()
{
        return this._ICategoriaCAD;
}

public int New_ (string p_Nombre)
{
        CategoriaEN categoriaEN = null;
        int oid;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Nombre = p_Nombre;

        //Call to CategoriaCAD

        oid = _ICategoriaCAD.New_ (categoriaEN);
        return oid;
}

public void Modify (int p_Categoria_OID, string p_Nombre)
{
        CategoriaEN categoriaEN = null;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Id = p_Categoria_OID;
        categoriaEN.Nombre = p_Nombre;
        //Call to CategoriaCAD

        _ICategoriaCAD.Modify (categoriaEN);
}

public void Destroy (int id
                     )
{
        _ICategoriaCAD.Destroy (id);
}

public System.Collections.Generic.IList<CategoriaEN> MuestraCategorias (int first, int size)
{
        System.Collections.Generic.IList<CategoriaEN> list = null;

        list = _ICategoriaCAD.MuestraCategorias (first, size);
        return list;
}
public CategoriaEN MuestraCategoriaPorOID (int id
                                           )
{
        CategoriaEN categoriaEN = null;

        categoriaEN = _ICategoriaCAD.MuestraCategoriaPorOID (id);
        return categoriaEN;
}

public void CrearSupercategoria (int p_Categoria_OID, int p_supercategoria_OID)
{
        //Call to CategoriaCAD

        _ICategoriaCAD.CrearSupercategoria (p_Categoria_OID, p_supercategoria_OID);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> GetSubcategorias (int p_categoria, int first, int size)
{
        return _ICategoriaCAD.GetSubcategorias (p_categoria, first, size);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> GetSubcategoriasByNombre (string p_nombre)
{
        return _ICategoriaCAD.GetSubcategoriasByNombre (p_nombre);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> GetSupercategoriasByNombre (string p_nombre)
{
        return _ICategoriaCAD.GetSupercategoriasByNombre (p_nombre);
}
}
}
