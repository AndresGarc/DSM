
using System;
// Definición clase PedidoEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class PedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo estado
 */
private BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum estado;



/**
 *	Atributo usuarioPedido
 */
private BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuarioPedido;



/**
 *	Atributo usuarioCarrito
 */
private BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuarioCarrito;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido;



/**
 *	Atributo factura
 */
private BaseDatosGenNHibernate.EN.BaseDatos.FacturaEN factura;



/**
 *	Atributo dirEnvio
 */
private BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN dirEnvio;



/**
 *	Atributo metodoPago
 */
private BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN metodoPago;



/**
 *	Atributo envio
 */
private BaseDatosGenNHibernate.EN.BaseDatos.EnvioEN envio;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN UsuarioPedido {
        get { return usuarioPedido; } set { usuarioPedido = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN UsuarioCarrito {
        get { return usuarioCarrito; } set { usuarioCarrito = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN DirEnvio {
        get { return dirEnvio; } set { dirEnvio = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN MetodoPago {
        get { return metodoPago; } set { metodoPago = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.EnvioEN Envio {
        get { return envio; } set { envio = value;  }
}





public PedidoEN()
{
        lineaPedido = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN>();
}



public PedidoEN(int id, Nullable<DateTime> fecha, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum estado, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuarioPedido, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuarioCarrito, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido, BaseDatosGenNHibernate.EN.BaseDatos.FacturaEN factura, BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN dirEnvio, BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN metodoPago, BaseDatosGenNHibernate.EN.BaseDatos.EnvioEN envio
                )
{
        this.init (Id, fecha, estado, usuarioPedido, usuarioCarrito, lineaPedido, factura, dirEnvio, metodoPago, envio);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (Id, pedido.Fecha, pedido.Estado, pedido.UsuarioPedido, pedido.UsuarioCarrito, pedido.LineaPedido, pedido.Factura, pedido.DirEnvio, pedido.MetodoPago, pedido.Envio);
}

private void init (int id
                   , Nullable<DateTime> fecha, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum estado, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuarioPedido, BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN usuarioCarrito, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido, BaseDatosGenNHibernate.EN.BaseDatos.FacturaEN factura, BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN dirEnvio, BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN metodoPago, BaseDatosGenNHibernate.EN.BaseDatos.EnvioEN envio)
{
        this.Id = id;


        this.Fecha = fecha;

        this.Estado = estado;

        this.UsuarioPedido = usuarioPedido;

        this.UsuarioCarrito = usuarioCarrito;

        this.LineaPedido = lineaPedido;

        this.Factura = factura;

        this.DirEnvio = dirEnvio;

        this.MetodoPago = metodoPago;

        this.Envio = envio;
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
