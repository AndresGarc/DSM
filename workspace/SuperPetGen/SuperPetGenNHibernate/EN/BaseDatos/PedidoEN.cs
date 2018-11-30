
using System;
// Definición clase PedidoEN
namespace SuperPetGenNHibernate.EN.BaseDatos
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
 *	Atributo tipoPago
 */
private string tipoPago;



/**
 *	Atributo estado
 */
private SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum estado;



/**
 *	Atributo usuario
 */
private SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario;



/**
 *	Atributo usuario_0
 */
private SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario_0;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido;



/**
 *	Atributo factura
 */
private SuperPetGenNHibernate.EN.BaseDatos.FacturaEN factura;



/**
 *	Atributo dirEnvio
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN> dirEnvio;



/**
 *	Atributo metodoPago
 */
private SuperPetGenNHibernate.EN.BaseDatos.MetodoPagoEN metodoPago;



/**
 *	Atributo envio
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.EnvioEN> envio;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual string TipoPago {
        get { return tipoPago; } set { tipoPago = value;  }
}



public virtual SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN Usuario_0 {
        get { return usuario_0; } set { usuario_0 = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN> DirEnvio {
        get { return dirEnvio; } set { dirEnvio = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.MetodoPagoEN MetodoPago {
        get { return metodoPago; } set { metodoPago = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.EnvioEN> Envio {
        get { return envio; } set { envio = value;  }
}





public PedidoEN()
{
        lineaPedido = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN>();
        dirEnvio = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN>();
        envio = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.EnvioEN>();
}



public PedidoEN(int id, Nullable<DateTime> fecha, string tipoPago, SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum estado, SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario, SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario_0, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido, SuperPetGenNHibernate.EN.BaseDatos.FacturaEN factura, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN> dirEnvio, SuperPetGenNHibernate.EN.BaseDatos.MetodoPagoEN metodoPago, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.EnvioEN> envio
                )
{
        this.init (Id, fecha, tipoPago, estado, usuario, usuario_0, lineaPedido, factura, dirEnvio, metodoPago, envio);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (Id, pedido.Fecha, pedido.TipoPago, pedido.Estado, pedido.Usuario, pedido.Usuario_0, pedido.LineaPedido, pedido.Factura, pedido.DirEnvio, pedido.MetodoPago, pedido.Envio);
}

private void init (int id
                   , Nullable<DateTime> fecha, string tipoPago, SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum estado, SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario, SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN usuario_0, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido, SuperPetGenNHibernate.EN.BaseDatos.FacturaEN factura, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.DirEnvioEN> dirEnvio, SuperPetGenNHibernate.EN.BaseDatos.MetodoPagoEN metodoPago, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.EnvioEN> envio)
{
        this.Id = id;


        this.Fecha = fecha;

        this.TipoPago = tipoPago;

        this.Estado = estado;

        this.Usuario = usuario;

        this.Usuario_0 = usuario_0;

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
