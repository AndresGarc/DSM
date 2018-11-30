
using System;
// Definición clase UsuarioEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class UsuarioEN                                                                      : BaseDatosGenNHibernate.EN.BaseDatos.UsuarioBasicoEN


{
/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo apellidos
 */
private string apellidos;



/**
 *	Atributo direccion
 */
private string direccion;



/**
 *	Atributo telefono
 */
private int telefono;



/**
 *	Atributo fNacimiento
 */
private Nullable<DateTime> fNacimiento;



/**
 *	Atributo cP
 */
private int cP;



/**
 *	Atributo activo
 */
private bool activo;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN> comentario;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion;



/**
 *	Atributo pedidoRealizado
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> pedidoRealizado;



/**
 *	Atributo carritoActual
 */
private BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN carritoActual;



/**
 *	Atributo favoritos
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> favoritos;



/**
 *	Atributo dirEnvio
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN> dirEnvio;



/**
 *	Atributo metodoPago
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN> metodoPago;






public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}



public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual int Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual Nullable<DateTime> FNacimiento {
        get { return fNacimiento; } set { fNacimiento = value;  }
}



public virtual int CP {
        get { return cP; } set { cP = value;  }
}



public virtual bool Activo {
        get { return activo; } set { activo = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> PedidoRealizado {
        get { return pedidoRealizado; } set { pedidoRealizado = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN CarritoActual {
        get { return carritoActual; } set { carritoActual = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> Favoritos {
        get { return favoritos; } set { favoritos = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN> DirEnvio {
        get { return dirEnvio; } set { dirEnvio = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN> MetodoPago {
        get { return metodoPago; } set { metodoPago = value;  }
}





public UsuarioEN() : base ()
{
        comentario = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN>();
        valoracion = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN>();
        pedidoRealizado = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN>();
        favoritos = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN>();
        dirEnvio = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN>();
        metodoPago = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN>();
}



public UsuarioEN(string email, string nombre, string apellidos, string direccion, int telefono, Nullable<DateTime> fNacimiento, int cP, bool activo, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN> comentario, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> pedidoRealizado, BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN carritoActual, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> favoritos, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN> dirEnvio, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN> metodoPago
                 , string nombreUsu, String password, bool logged
                 )
{
        this.init (Email, nombre, apellidos, direccion, telefono, fNacimiento, cP, activo, comentario, valoracion, pedidoRealizado, carritoActual, favoritos, dirEnvio, metodoPago, nombreUsu, password, logged);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Email, usuario.Nombre, usuario.Apellidos, usuario.Direccion, usuario.Telefono, usuario.FNacimiento, usuario.CP, usuario.Activo, usuario.Comentario, usuario.Valoracion, usuario.PedidoRealizado, usuario.CarritoActual, usuario.Favoritos, usuario.DirEnvio, usuario.MetodoPago, usuario.NombreUsu, usuario.Password, usuario.Logged);
}

private void init (string Email
                   , string nombre, string apellidos, string direccion, int telefono, Nullable<DateTime> fNacimiento, int cP, bool activo, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN> comentario, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> pedidoRealizado, BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN carritoActual, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> favoritos, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN> dirEnvio, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN> metodoPago, string nombreUsu, String password, bool logged)
{
        this.Email = Email;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Direccion = direccion;

        this.Telefono = telefono;

        this.FNacimiento = fNacimiento;

        this.CP = cP;

        this.Activo = activo;

        this.Comentario = comentario;

        this.Valoracion = valoracion;

        this.PedidoRealizado = pedidoRealizado;

        this.CarritoActual = carritoActual;

        this.Favoritos = favoritos;

        this.DirEnvio = dirEnvio;

        this.MetodoPago = metodoPago;

        this.NombreUsu = nombreUsu;

        this.Password = password;

        this.Logged = logged;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Email.Equals (t.Email))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Email.GetHashCode ();
        return hash;
}
}
}
