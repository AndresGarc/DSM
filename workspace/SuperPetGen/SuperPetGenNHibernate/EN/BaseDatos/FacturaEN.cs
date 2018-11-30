
using System;
// Definición clase FacturaEN
namespace SuperPetGenNHibernate.EN.BaseDatos
{
public partial class FacturaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo precioTotal
 */
private float precioTotal;



/**
 *	Atributo pedido
 */
private SuperPetGenNHibernate.EN.BaseDatos.PedidoEN pedido;



/**
 *	Atributo iVA
 */
private float iVA;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual float PrecioTotal {
        get { return precioTotal; } set { precioTotal = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual float IVA {
        get { return iVA; } set { iVA = value;  }
}





public FacturaEN()
{
}



public FacturaEN(int id, float precioTotal, SuperPetGenNHibernate.EN.BaseDatos.PedidoEN pedido, float iVA
                 )
{
        this.init (Id, precioTotal, pedido, iVA);
}


public FacturaEN(FacturaEN factura)
{
        this.init (Id, factura.PrecioTotal, factura.Pedido, factura.IVA);
}

private void init (int id
                   , float precioTotal, SuperPetGenNHibernate.EN.BaseDatos.PedidoEN pedido, float iVA)
{
        this.Id = id;


        this.PrecioTotal = precioTotal;

        this.Pedido = pedido;

        this.IVA = iVA;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FacturaEN t = obj as FacturaEN;
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
