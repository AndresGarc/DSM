
using System;
// Definición clase ClienteEN
namespace EjemploViernesGenNHibernate.EN.EjemploViernes
{
public partial class ClienteEN
{
/**
 *	Atributo dNI
 */
private string dNI;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo fechaNac
 */
private Nullable<DateTime> fechaNac;



/**
 *	Atributo codPostal
 */
private int codPostal;



/**
 *	Atributo pedidos
 */
private System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> pedidos;






public virtual string DNI {
        get { return dNI; } set { dNI = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual Nullable<DateTime> FechaNac {
        get { return fechaNac; } set { fechaNac = value;  }
}



public virtual int CodPostal {
        get { return codPostal; } set { codPostal = value;  }
}



public virtual System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> Pedidos {
        get { return pedidos; } set { pedidos = value;  }
}





public ClienteEN()
{
        pedidos = new System.Collections.Generic.List<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN>();
}



public ClienteEN(string dNI, string nombre, Nullable<DateTime> fechaNac, int codPostal, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> pedidos
                 )
{
        this.init (DNI, nombre, fechaNac, codPostal, pedidos);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (DNI, cliente.Nombre, cliente.FechaNac, cliente.CodPostal, cliente.Pedidos);
}

private void init (string DNI
                   , string nombre, Nullable<DateTime> fechaNac, int codPostal, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> pedidos)
{
        this.DNI = DNI;


        this.Nombre = nombre;

        this.FechaNac = fechaNac;

        this.CodPostal = codPostal;

        this.Pedidos = pedidos;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
        if (t == null)
                return false;
        if (DNI.Equals (t.DNI))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.DNI.GetHashCode ();
        return hash;
}
}
}
