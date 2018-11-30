
using System;
// Definición clase ProductoDescripcionEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class ProductoDescripcionEN
{
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
private BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum idioma;



/**
 *	Atributo producto
 */
private BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN producto;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}





public ProductoDescripcionEN()
{
}



public ProductoDescripcionEN(int id, string texto, BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum idioma, BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN producto
                             )
{
        this.init (Id, texto, idioma, producto);
}


public ProductoDescripcionEN(ProductoDescripcionEN productoDescripcion)
{
        this.init (Id, productoDescripcion.Texto, productoDescripcion.Idioma, productoDescripcion.Producto);
}

private void init (int id
                   , string texto, BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum idioma, BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN producto)
{
        this.Id = id;


        this.Texto = texto;

        this.Idioma = idioma;

        this.Producto = producto;
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
