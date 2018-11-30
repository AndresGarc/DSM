
using System;
// Definición clase EnvioEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class EnvioEN
{
/**
 *	Atributo fechaSalida
 */
private Nullable<DateTime> fechaSalida;



/**
 *	Atributo fechaLlegada
 */
private Nullable<DateTime> fechaLlegada;



/**
 *	Atributo estado
 */
private BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum estado;



/**
 *	Atributo pedido
 */
private BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedido;



/**
 *	Atributo id
 */
private int id;






public virtual Nullable<DateTime> FechaSalida {
        get { return fechaSalida; } set { fechaSalida = value;  }
}



public virtual Nullable<DateTime> FechaLlegada {
        get { return fechaLlegada; } set { fechaLlegada = value;  }
}



public virtual BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public EnvioEN()
{
}



public EnvioEN(int id, Nullable<DateTime> fechaSalida, Nullable<DateTime> fechaLlegada, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum estado, BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedido
               )
{
        this.init (Id, fechaSalida, fechaLlegada, estado, pedido);
}


public EnvioEN(EnvioEN envio)
{
        this.init (Id, envio.FechaSalida, envio.FechaLlegada, envio.Estado, envio.Pedido);
}

private void init (int id
                   , Nullable<DateTime> fechaSalida, Nullable<DateTime> fechaLlegada, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum estado, BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN pedido)
{
        this.Id = id;


        this.FechaSalida = fechaSalida;

        this.FechaLlegada = fechaLlegada;

        this.Estado = estado;

        this.Pedido = pedido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EnvioEN t = obj as EnvioEN;
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
