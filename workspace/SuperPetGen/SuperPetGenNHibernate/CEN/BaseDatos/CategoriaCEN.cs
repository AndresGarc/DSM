

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

public int New_ (string p_Nombre, string p_Descripcion)
{
        CategoriaEN categoriaEN = null;
        int oid;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Nombre = p_Nombre;

        categoriaEN.Descripcion = p_Descripcion;

        //Call to CategoriaCAD

        oid = _ICategoriaCAD.New_ (categoriaEN);
        return oid;
}

public void Modify (int p_Categoria_OID, string p_Nombre, string p_Descripcion)
{
        CategoriaEN categoriaEN = null;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Id = p_Categoria_OID;
        categoriaEN.Nombre = p_Nombre;
        categoriaEN.Descripcion = p_Descripcion;
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

public void CrearSubcategoria (int p_Categoria_OID, int p_subcategoria_OID)
{
        //Call to CategoriaCAD

        _ICategoriaCAD.CrearSubcategoria (p_Categoria_OID, p_subcategoria_OID);
}
}
}
