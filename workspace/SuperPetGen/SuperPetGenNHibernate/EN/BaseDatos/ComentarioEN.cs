
using System;
// Definición clase ComentarioEN
namespace SuperPetGenNHibernate.EN.BaseDatos
{
public partial class ComentarioEN
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
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo hora
 */
private Nullable<DateTime> hora;



/**
 *	Atributo usuario
 */
private SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario;



/**
 *	Atributo producto
 */
private SuperPetGenNHibernate.EN.BaseDatos.ProductoEN producto;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual Nullable<DateTime> Hora {
        get { return hora; } set { hora = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}





public ComentarioEN()
{
}



public ComentarioEN(int id, string texto, Nullable<DateTime> fecha, Nullable<DateTime> hora, SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario, SuperPetGenNHibernate.EN.BaseDatos.ProductoEN producto
                    )
{
        this.init (Id, texto, fecha, hora, usuario, producto);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (Id, comentario.Texto, comentario.Fecha, comentario.Hora, comentario.Usuario, comentario.Producto);
}

private void init (int id
                   , string texto, Nullable<DateTime> fecha, Nullable<DateTime> hora, SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario, SuperPetGenNHibernate.EN.BaseDatos.ProductoEN producto)
{
        this.Id = id;


        this.Texto = texto;

        this.Fecha = fecha;

        this.Hora = hora;

        this.Usuario = usuario;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
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
