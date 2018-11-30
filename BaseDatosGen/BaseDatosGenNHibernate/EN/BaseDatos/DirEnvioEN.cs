
using System;
// Definición clase DirEnvioEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class DirEnvioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo calle
 */
private string calle;



/**
 *	Atributo cP
 */
private int cP;



/**
 *	Atributo localidad
 */
private string localidad;



/**
 *	Atributo provincia
 */
private string provincia;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> pedido;



/**
 *	Atributo usuario
 */
private BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Calle {
        get { return calle; } set { calle = value;  }
}



public virtual int CP {
        get { return cP; } set { cP = value;  }
}



public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}



public virtual string Provincia {
        get { return provincia; } set { provincia = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public DirEnvioEN()
{
        pedido = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN>();
}



public DirEnvioEN(int id, string calle, int cP, string localidad, string provincia, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> pedido, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuario
                  )
{
        this.init (Id, calle, cP, localidad, provincia, pedido, usuario);
}


public DirEnvioEN(DirEnvioEN dirEnvio)
{
        this.init (Id, dirEnvio.Calle, dirEnvio.CP, dirEnvio.Localidad, dirEnvio.Provincia, dirEnvio.Pedido, dirEnvio.Usuario);
}

private void init (int id
                   , string calle, int cP, string localidad, string provincia, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> pedido, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuario)
{
        this.Id = id;


        this.Calle = calle;

        this.CP = cP;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Pedido = pedido;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DirEnvioEN t = obj as DirEnvioEN;
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
