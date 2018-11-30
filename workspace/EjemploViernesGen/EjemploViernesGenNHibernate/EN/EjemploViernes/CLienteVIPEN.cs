
using System;
// Definición clase CLienteVIPEN
namespace EjemploViernesGenNHibernate.EN.EjemploViernes
{
public partial class CLienteVIPEN                                                                   : EjemploViernesGenNHibernate.EN.EjemploViernes.ClienteEN


{
/**
 *	Atributo numSocio
 */
private int numSocio;






public virtual int NumSocio {
        get { return numSocio; } set { numSocio = value;  }
}





public CLienteVIPEN() : base ()
{
}



public CLienteVIPEN(string dNI, int numSocio
                    , string nombre, Nullable<DateTime> fechaNac, int codPostal, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> pedidos
                    )
{
        this.init (DNI, numSocio, nombre, fechaNac, codPostal, pedidos);
}


public CLienteVIPEN(CLienteVIPEN cLienteVIP)
{
        this.init (DNI, cLienteVIP.NumSocio, cLienteVIP.Nombre, cLienteVIP.FechaNac, cLienteVIP.CodPostal, cLienteVIP.Pedidos);
}

private void init (string DNI
                   , int numSocio, string nombre, Nullable<DateTime> fechaNac, int codPostal, System.Collections.Generic.IList<EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN> pedidos)
{
        this.DNI = DNI;


        this.NumSocio = numSocio;

        this.Nombre = nombre;

        this.FechaNac = fechaNac;

        this.CodPostal = codPostal;

        this.Pedidos = pedidos;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CLienteVIPEN t = obj as CLienteVIPEN;
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
