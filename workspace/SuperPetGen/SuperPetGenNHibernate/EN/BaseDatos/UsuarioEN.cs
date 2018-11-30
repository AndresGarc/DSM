
using System;
// Definición clase UsuarioEN
namespace SuperPetGenNHibernate.EN.BaseDatos
{
public partial class UsuarioEN                                                                      : SuperPetGenNHibernate.EN.BaseDatos.UsuarioBasicoEN


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
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN> comentario;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion;



/**
 *	Atributo categoria
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN> categoria;



/**
 *	Atributo productosComprados
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> productosComprados;



/**
 *	Atributo pedidoRealizado
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN> pedidoRealizado;



/**
 *	Atributo carritoActual
 */
private SuperPetGenNHibernate.EN.BaseDatos.PedidoEN carritoActual;



/**
 *	Atributo favoritos
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> favoritos;






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



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN> Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> ProductosComprados {
        get { return productosComprados; } set { productosComprados = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN> PedidoRealizado {
        get { return pedidoRealizado; } set { pedidoRealizado = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.PedidoEN CarritoActual {
        get { return carritoActual; } set { carritoActual = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> Favoritos {
        get { return favoritos; } set { favoritos = value;  }
}





public UsuarioEN() : base ()
{
        comentario = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN>();
        valoracion = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN>();
        categoria = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN>();
        productosComprados = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN>();
        pedidoRealizado = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN>();
        favoritos = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN>();
}



public UsuarioEN(string email, string nombre, string apellidos, string direccion, int telefono, Nullable<DateTime> fNacimiento, int cP, bool activo, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN> comentario, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN> categoria, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> productosComprados, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN> pedidoRealizado, SuperPetGenNHibernate.EN.BaseDatos.PedidoEN carritoActual, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> favoritos
                 , string nombreUsu, String password, bool logged
                 )
{
        this.init (Email, nombre, apellidos, direccion, telefono, fNacimiento, cP, activo, comentario, valoracion, categoria, productosComprados, pedidoRealizado, carritoActual, favoritos, nombreUsu, password, logged);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Email, usuario.Nombre, usuario.Apellidos, usuario.Direccion, usuario.Telefono, usuario.FNacimiento, usuario.CP, usuario.Activo, usuario.Comentario, usuario.Valoracion, usuario.Categoria, usuario.ProductosComprados, usuario.PedidoRealizado, usuario.CarritoActual, usuario.Favoritos, usuario.NombreUsu, usuario.Password, usuario.Logged);
}

private void init (string Email
                   , string nombre, string apellidos, string direccion, int telefono, Nullable<DateTime> fNacimiento, int cP, bool activo, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN> comentario, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN> categoria, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> productosComprados, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.PedidoEN> pedidoRealizado, SuperPetGenNHibernate.EN.BaseDatos.PedidoEN carritoActual, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoEN> favoritos, string nombreUsu, String password, bool logged)
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

        this.Categoria = categoria;

        this.ProductosComprados = productosComprados;

        this.PedidoRealizado = pedidoRealizado;

        this.CarritoActual = carritoActual;

        this.Favoritos = favoritos;

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
