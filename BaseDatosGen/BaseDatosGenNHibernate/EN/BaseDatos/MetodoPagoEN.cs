
using System;
// Definición clase MetodoPagoEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
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
private BaseDatosGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum tipoPago;



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



public virtual BaseDatosGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum TipoPago {
        get { return tipoPago; } set { tipoPago = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}





public MetodoPagoEN()
{
        pedido = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN>();
}



public MetodoPagoEN(int id, BaseDatosGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum tipoPago, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> pedido, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuario
                    )
{
        this.init (Id, tipoPago, pedido, usuario);
}


public MetodoPagoEN(MetodoPagoEN metodoPago)
{
        this.init (Id, metodoPago.TipoPago, metodoPago.Pedido, metodoPago.Usuario);
}

private void init (int id
                   , BaseDatosGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum tipoPago, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> pedido, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuario)
{
        this.Id = id;


        this.TipoPago = tipoPago;

        this.Pedido = pedido;

        this.Usuario = usuario;
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
