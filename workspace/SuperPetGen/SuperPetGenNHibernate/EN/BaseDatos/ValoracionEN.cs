
using System;
// Definición clase ValoracionEN
namespace SuperPetGenNHibernate.EN.BaseDatos
{
public partial class ValoracionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo valor
 */
private float valor;



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



public virtual float Valor {
        get { return valor; } set { valor = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}





public ValoracionEN()
{
}



public ValoracionEN(int id, float valor, SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario, SuperPetGenNHibernate.EN.BaseDatos.ProductoEN producto
                    )
{
        this.init (Id, valor, usuario, producto);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Id, valoracion.Valor, valoracion.Usuario, valoracion.Producto);
}

private void init (int id
                   , float valor, SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario, SuperPetGenNHibernate.EN.BaseDatos.ProductoEN producto)
{
        this.Id = id;


        this.Valor = valor;

        this.Usuario = usuario;

        this.Producto = producto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ValoracionEN t = obj as ValoracionEN;
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
