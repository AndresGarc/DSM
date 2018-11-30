
using System;
// Definición clase EnvioEN
namespace SuperPetGenNHibernate.EN.BaseDatos
{
public partial class EnvioEN
{
/**
 *	Atributo horaSalida
 */
private Nullable<DateTime> horaSalida;



/**
 *	Atributo horaLlegada
 */
private Nullable<DateTime> horaLlegada;



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
private SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum estado;



/**
 *	Atributo pedido
 */
private SuperPetGenNHibernate.EN.BaseDatos.PedidoEN pedido;



/**
 *	Atributo id
 */
private int id;






public virtual Nullable<DateTime> HoraSalida {
        get { return horaSalida; } set { horaSalida = value;  }
}



public virtual Nullable<DateTime> HoraLlegada {
        get { return horaLlegada; } set { horaLlegada = value;  }
}



public virtual Nullable<DateTime> FechaSalida {
        get { return fechaSalida; } set { fechaSalida = value;  }
}



public virtual Nullable<DateTime> FechaLlegada {
        get { return fechaLlegada; } set { fechaLlegada = value;  }
}



public virtual SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public EnvioEN()
{
}



public EnvioEN(int id, Nullable<DateTime> horaSalida, Nullable<DateTime> horaLlegada, Nullable<DateTime> fechaSalida, Nullable<DateTime> fechaLlegada, SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum estado, SuperPetGenNHibernate.EN.BaseDatos.PedidoEN pedido
               )
{
        this.init (Id, horaSalida, horaLlegada, fechaSalida, fechaLlegada, estado, pedido);
}


public EnvioEN(EnvioEN envio)
{
        this.init (Id, envio.HoraSalida, envio.HoraLlegada, envio.FechaSalida, envio.FechaLlegada, envio.Estado, envio.Pedido);
}

private void init (int id
                   , Nullable<DateTime> horaSalida, Nullable<DateTime> horaLlegada, Nullable<DateTime> fechaSalida, Nullable<DateTime> fechaLlegada, SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum estado, SuperPetGenNHibernate.EN.BaseDatos.PedidoEN pedido)
{
        this.Id = id;


        this.HoraSalida = horaSalida;

        this.HoraLlegada = horaLlegada;

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
