
using System;
// Definición clase LineaPedidoEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class LineaPedidoEN
{
/**
 *	Atributo numero
 */
private int numero;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo producto
 */
private BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN producto;



/**
 *	Atributo pedido
 */
private BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedido;






public virtual int Numero {
        get { return numero; } set { numero = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int numero, int cantidad, BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN producto, BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedido
                     )
{
        this.init (Numero, cantidad, producto, pedido);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (Numero, lineaPedido.Cantidad, lineaPedido.Producto, lineaPedido.Pedido);
}

private void init (int Numero
                   , int cantidad, BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN producto, BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedido)
{
        this.Numero = Numero;


        this.Cantidad = cantidad;

        this.Producto = producto;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
        if (t == null)
                return false;
        if (Numero.Equals (t.Numero))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Numero.GetHashCode ();
        return hash;
}
}
}
