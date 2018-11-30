
using System;
// Definición clase LineaPedidoEN
namespace EjemploViernesGenNHibernate.EN.EjemploViernes
{
public partial class LineaPedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo pedido
 */
private double pedido;



/**
 *	Atributo pedido_0
 */
private EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN pedido_0;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual double Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN Pedido_0 {
        get { return pedido_0; } set { pedido_0 = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int id, int cantidad, double pedido, EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN pedido_0
                     )
{
        this.init (Id, cantidad, pedido, pedido_0);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (Id, lineaPedido.Cantidad, lineaPedido.Pedido, lineaPedido.Pedido_0);
}

private void init (int id
                   , int cantidad, double pedido, EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN pedido_0)
{
        this.Id = id;


        this.Cantidad = cantidad;

        this.Pedido = pedido;

        this.Pedido_0 = pedido_0;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
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
