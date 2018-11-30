

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
 *      Definition of the class CategoriaDescripcionCEN
 *
 */
public partial class CategoriaDescripcionCEN
{
private ICategoriaDescripcionCAD _ICategoriaDescripcionCAD;

public CategoriaDescripcionCEN()
{
        this._ICategoriaDescripcionCAD = new CategoriaDescripcionCAD ();
}

public CategoriaDescripcionCEN(ICategoriaDescripcionCAD _ICategoriaDescripcionCAD)
{
        this._ICategoriaDescripcionCAD = _ICategoriaDescripcionCAD;
}

public ICategoriaDescripcionCAD get_ICategoriaDescripcionCAD ()
{
        return this._ICategoriaDescripcionCAD;
}

public int New_ (string p_texto, BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum p_idioma, int p_categoria)
{
        CategoriaDescripcionEN categoriaDescripcionEN = null;
        int oid;

        //Initialized CategoriaDescripcionEN
        categoriaDescripcionEN = new CategoriaDescripcionEN ();
        categoriaDescripcionEN.Texto = p_texto;

        categoriaDescripcionEN.Idioma = p_idioma;


        if (p_categoria != -1) {
                // El argumento p_categoria -> Property categoria es oid = false
                // Lista de oids id
                categoriaDescripcionEN.Categoria = new BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN ();
                categoriaDescripcionEN.Categoria.Id = p_categoria;
        }

        //Call to CategoriaDescripcionCAD

        oid = _ICategoriaDescripcionCAD.New_ (categoriaDescripcionEN);
        return oid;
}

public void Modify (int p_CategoriaDescripcion_OID, string p_texto, BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum p_idioma)
{
        CategoriaDescripcionEN categoriaDescripcionEN = null;

        //Initialized CategoriaDescripcionEN
        categoriaDescripcionEN = new CategoriaDescripcionEN ();
        categoriaDescripcionEN.Id = p_CategoriaDescripcion_OID;
        categoriaDescripcionEN.Texto = p_texto;
        categoriaDescripcionEN.Idioma = p_idioma;
        //Call to CategoriaDescripcionCAD

        _ICategoriaDescripcionCAD.Modify (categoriaDescripcionEN);
}

public void Destroy (int id
                     )
{
        _ICategoriaDescripcionCAD.Destroy (id);
}

public CategoriaDescripcionEN MuestraCategoriaDescripcionPorOID (int id
                                                                 )
{
        CategoriaDescripcionEN categoriaDescripcionEN = null;

        categoriaDescripcionEN = _ICategoriaDescripcionCAD.MuestraCategoriaDescripcionPorOID (id);
        return categoriaDescripcionEN;
}

public System.Collections.Generic.IList<CategoriaDescripcionEN> MuestraCategoriaDescripcion (int first, int size)
{
        System.Collections.Generic.IList<CategoriaDescripcionEN> list = null;

        list = _ICategoriaDescripcionCAD.MuestraCategoriaDescripcion (first, size);
        return list;
}
}
}
