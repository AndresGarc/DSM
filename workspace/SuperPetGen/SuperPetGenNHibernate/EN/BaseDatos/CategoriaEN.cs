
using System;
// Definición clase CategoriaEN
namespace SuperPetGenNHibernate.EN.BaseDatos
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
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo supercategoria
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN> supercategoria;



/**
 *	Atributo subcategoria
 */
private SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN subcategoria;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> usuario;



/**
 *	Atributo producto
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> producto;



/**
 *	Atributo categoriaDescripcion
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN> categoriaDescripcion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN> Supercategoria {
        get { return supercategoria; } set { supercategoria = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN Subcategoria {
        get { return subcategoria; } set { subcategoria = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> Producto {
        get { return producto; } set { producto = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN> CategoriaDescripcion {
        get { return categoriaDescripcion; } set { categoriaDescripcion = value;  }
}





public CategoriaEN()
{
        supercategoria = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN>();
        usuario = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN>();
        producto = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN>();
        categoriaDescripcion = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN>();
}



public CategoriaEN(int id, string nombre, string descripcion, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN> supercategoria, SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN subcategoria, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> usuario, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> producto, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN> categoriaDescripcion
                   )
{
        this.init (Id, nombre, descripcion, supercategoria, subcategoria, usuario, producto, categoriaDescripcion);
}


public CategoriaEN(CategoriaEN categoria)
{
        this.init (Id, categoria.Nombre, categoria.Descripcion, categoria.Supercategoria, categoria.Subcategoria, categoria.Usuario, categoria.Producto, categoria.CategoriaDescripcion);
}

private void init (int id
                   , string nombre, string descripcion, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN> supercategoria, SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN subcategoria, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> usuario, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> producto, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaDescripcionEN> categoriaDescripcion)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Descripcion = descripcion;

        this.Supercategoria = supercategoria;

        this.Subcategoria = subcategoria;

        this.Usuario = usuario;

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
