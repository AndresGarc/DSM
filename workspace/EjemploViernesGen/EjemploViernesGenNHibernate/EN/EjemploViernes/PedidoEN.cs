
using System;
// Definición clase PedidoEN
namespace EjemploViernesGenNHibernate.EN.EjemploViernes
{
public partial class PedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo cliente
 */
private EjemploViernesGenNHibernate.EN.EjemploViernes.ClienteEN cliente;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.LineaPedidoEN> lineaPedido;



/**
 *	Atributo estado
 */
private EjemploViernesGenNHibernate.Enumerated.EjemploViernes.EstadoPEdidoEnum estado;



/**
 *	Atributo dirEnvio
 */
private System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN> dirEnvio;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual EjemploViernesGenNHibernate.EN.EjemploViernes.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}



public virtual System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual EjemploViernesGenNHibernate.Enumerated.EjemploViernes.EstadoPEdidoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN> DirEnvio {
        get { return dirEnvio; } set { dirEnvio = value;  }
}





public PedidoEN()
{
        lineaPedido = new System.Collections.Generic.List<EjemploViernesGenNHibernate.EN.EjemploViernes.LineaPedidoEN>();
        dirEnvio = new System.Collections.Generic.List<EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN>();
}



public PedidoEN(int id, string descripcion, EjemploViernesGenNHibernate.EN.EjemploViernes.ClienteEN cliente, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.LineaPedidoEN> lineaPedido, EjemploViernesGenNHibernate.Enumerated.EjemploViernes.EstadoPEdidoEnum estado, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN> dirEnvio
                )
{
        this.init (Id, descripcion, cliente, lineaPedido, estado, dirEnvio);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (Id, pedido.Descripcion, pedido.Cliente, pedido.LineaPedido, pedido.Estado, pedido.DirEnvio);
}

private void init (int id
                   , string descripcion, EjemploViernesGenNHibernate.EN.EjemploViernes.ClienteEN cliente, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.LineaPedidoEN> lineaPedido, EjemploViernesGenNHibernate.Enumerated.EjemploViernes.EstadoPEdidoEnum estado, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.DirEnvioEN> dirEnvio)
{
        this.Id = id;


        this.Descripcion = descripcion;

        this.Cliente = cliente;

        this.LineaPedido = lineaPedido;

        this.Estado = estado;

        this.DirEnvio = dirEnvio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
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
