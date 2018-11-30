
using System;
// Definición clase CategoriaDescripcionEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class CategoriaDescripcionEN
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
 *	Atributo categoria
 */
private BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN categoria;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum Idioma {
        get { return idioma; } set { idioma = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN Categoria {
        get { return categoria; } set { categoria = value;  }
}





public CategoriaDescripcionEN()
{
}



public CategoriaDescripcionEN(int id, string texto, BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum idioma, BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN categoria
                              )
{
        this.init (Id, texto, idioma, categoria);
}


public CategoriaDescripcionEN(CategoriaDescripcionEN categoriaDescripcion)
{
        this.init (Id, categoriaDescripcion.Texto, categoriaDescripcion.Idioma, categoriaDescripcion.Categoria);
}

private void init (int id
                   , string texto, BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum idioma, BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN categoria)
{
        this.Id = id;


        this.Texto = texto;

        this.Idioma = idioma;

        this.Categoria = categoria;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CategoriaDescripcionEN t = obj as CategoriaDescripcionEN;
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
