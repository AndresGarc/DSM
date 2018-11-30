
using System;
// Definición clase FacturaEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
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
private double precioTotal;



/**
 *	Atributo pedido
 */
private BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedido;



/**
 *	Atributo iVA
 */
private double iVA;



/**
 *	Atributo precioSinIVA
 */
private double precioSinIVA;



/**
 *	Atributo fechaPago
 */
private Nullable<DateTime> fechaPago;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual double PrecioTotal {
        get { return precioTotal; } set { precioTotal = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual double IVA {
        get { return iVA; } set { iVA = value;  }
}



public virtual double PrecioSinIVA {
        get { return precioSinIVA; } set { precioSinIVA = value;  }
}



public virtual Nullable<DateTime> FechaPago {
        get { return fechaPago; } set { fechaPago = value;  }
}





public FacturaEN()
{
}



public FacturaEN(int id, double precioTotal, BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedido, double iVA, double precioSinIVA, Nullable<DateTime> fechaPago
                 )
{
        this.init (Id, precioTotal, pedido, iVA, precioSinIVA, fechaPago);
}


public FacturaEN(FacturaEN factura)
{
        this.init (Id, factura.PrecioTotal, factura.Pedido, factura.IVA, factura.PrecioSinIVA, factura.FechaPago);
}

private void init (int id
                   , double precioTotal, BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedido, double iVA, double precioSinIVA, Nullable<DateTime> fechaPago)
{
        this.Id = id;


        this.PrecioTotal = precioTotal;

        this.Pedido = pedido;

        this.IVA = iVA;

        this.PrecioSinIVA = precioSinIVA;

        this.FechaPago = fechaPago;
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
