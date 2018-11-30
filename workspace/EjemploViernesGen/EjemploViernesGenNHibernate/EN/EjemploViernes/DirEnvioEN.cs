
using System;
// Definición clase DirEnvioEN
namespace EjemploViernesGenNHibernate.EN.EjemploViernes
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
private System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> pedido;






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



public virtual System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}





public DirEnvioEN()
{
        pedido = new System.Collections.Generic.List<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN>();
}



public DirEnvioEN(int id, string calle, int cP, string localidad, string provincia, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> pedido
                  )
{
        this.init (Id, calle, cP, localidad, provincia, pedido);
}


public DirEnvioEN(DirEnvioEN dirEnvio)
{
        this.init (Id, dirEnvio.Calle, dirEnvio.CP, dirEnvio.Localidad, dirEnvio.Provincia, dirEnvio.Pedido);
}

private void init (int id
                   , string calle, int cP, string localidad, string provincia, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> pedido)
{
        this.Id = id;


        this.Calle = calle;

        this.CP = cP;

        this.Localidad = localidad;

        this.Provincia = provincia;

        this.Pedido = pedido;
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
