
using System;
// Definición clase CategoriaEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class CategoriaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo supercategoria
 */
private BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN supercategoria;



/**
 *	Atributo subcategoria
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> subcategoria;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> producto;



/**
 *	Atributo categoriaDescripcion
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN> categoriaDescripcion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN Supercategoria {
        get { return supercategoria; } set { supercategoria = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> Subcategoria {
        get { return subcategoria; } set { subcategoria = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN> CategoriaDescripcion {
        get { return categoriaDescripcion; } set { categoriaDescripcion = value;  }
}





public CategoriaEN()
{
        subcategoria = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN>();
        producto = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
        categoriaDescripcion = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN>();
}



public CategoriaEN(int id, string nombre, BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN supercategoria, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> subcategoria, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> producto, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN> categoriaDescripcion
                   )
{
        this.init (Id, nombre, supercategoria, subcategoria, producto, categoriaDescripcion);
}


public CategoriaEN(CategoriaEN categoria)
{
        this.init (Id, categoria.Nombre, categoria.Supercategoria, categoria.Subcategoria, categoria.Producto, categoria.CategoriaDescripcion);
}

private void init (int id
                   , string nombre, BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN supercategoria, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> subcategoria, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> producto, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN> categoriaDescripcion)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Supercategoria = supercategoria;

        this.Subcategoria = subcategoria;

        this.Producto = producto;

        this.CategoriaDescripcion = categoriaDescripcion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CategoriaEN t = obj as CategoriaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
