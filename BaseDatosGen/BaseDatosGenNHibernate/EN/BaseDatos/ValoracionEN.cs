
using System;
// Definición clase ValoracionEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
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
private double valor;



/**
 *	Atributo usuario
 */
private BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuario;



/**
 *	Atributo producto
 */
private BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN producto;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual double Valor {
        get { return valor; } set { valor = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}





public ValoracionEN()
{
}



public ValoracionEN(int id, double valor, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuario, BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN producto
                    )
{
        this.init (Id, valor, usuario, producto);
}


public ValoracionEN(ValoracionEN valoracion)
{
        this.init (Id, valoracion.Valor, valoracion.Usuario, valoracion.Producto);
}

private void init (int id
                   , double valor, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuario, BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN producto)
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
