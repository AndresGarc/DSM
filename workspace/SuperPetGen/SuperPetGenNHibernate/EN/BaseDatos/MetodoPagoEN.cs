
using System;
// Definición clase MetodoPagoEN
namespace SuperPetGenNHibernate.EN.BaseDatos
{
public partial class MetodoPagoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo tipoPago
 */
private SuperPetGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum tipoPago;



/**
 *	Atributo pedido
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN> pedido;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual SuperPetGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum TipoPago {
        get { return tipoPago; } set { tipoPago = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}





public MetodoPagoEN()
{
        pedido = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN>();
}



public MetodoPagoEN(int id, SuperPetGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum tipoPago, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN> pedido
                    )
{
        this.init (Id, tipoPago, pedido);
}


public MetodoPagoEN(MetodoPagoEN metodoPago)
{
        this.init (Id, metodoPago.TipoPago, metodoPago.Pedido);
}

private void init (int id
                   , SuperPetGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum tipoPago, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN> pedido)
{
        this.Id = id;


        this.TipoPago = tipoPago;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MetodoPagoEN t = obj as MetodoPagoEN;
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
