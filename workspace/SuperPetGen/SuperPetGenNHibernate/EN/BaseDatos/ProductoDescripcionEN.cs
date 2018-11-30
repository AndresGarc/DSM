
using System;
// Definición clase ProductoDescripcionEN
namespace SuperPetGenNHibernate.EN.BaseDatos
{
public partial class ProductoDescripcionEN
{
/**
 *	Atributo producto
 */
private SuperPetGenNHibernate.EN.BaseDatos.ProductoEN producto;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo idioma
 */
private SuperPetGenNHibernate.Enumerated.BaseDatos.IdiomaEnum idioma;






public virtual SuperPetGenNHibernate.EN.BaseDatos.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual SuperPetGenNHibernate.Enumerated.BaseDatos.IdiomaEnum Idioma {
        get { return idioma; } set { idioma = value;  }
}





public ProductoDescripcionEN()
{
}



public ProductoDescripcionEN(int id, SuperPetGenNHibernate.EN.BaseDatos.ProductoEN producto, string texto, SuperPetGenNHibernate.Enumerated.BaseDatos.IdiomaEnum idioma
                             )
{
        this.init (Id, producto, texto, idioma);
}


public ProductoDescripcionEN(ProductoDescripcionEN productoDescripcion)
{
        this.init (Id, productoDescripcion.Producto, productoDescripcion.Texto, productoDescripcion.Idioma);
}

private void init (int id
                   , SuperPetGenNHibernate.EN.BaseDatos.ProductoEN producto, string texto, SuperPetGenNHibernate.Enumerated.BaseDatos.IdiomaEnum idioma)
{
        this.Id = id;


        this.Producto = producto;

        this.Texto = texto;

        this.Idioma = idioma;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoDescripcionEN t = obj as ProductoDescripcionEN;
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
