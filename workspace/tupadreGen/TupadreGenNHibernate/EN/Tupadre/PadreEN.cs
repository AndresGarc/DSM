
using System;
// Definición clase PadreEN
namespace TupadreGenNHibernate.EN.Tupadre
{
public partial class PadreEN
{
/**
 *	Atributo edad
 */
private int edad;



/**
 *	Atributo nombre
 */
private int nombre;



/**
 *	Atributo mujer
 */
private System.Collections.Generic.IList<TupadreGenNHibernate.EN.Tupadre.MadreEN> mujer;






public virtual int Edad {
        get { return edad; } set { edad = value;  }
}



public virtual int Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<TupadreGenNHibernate.EN.Tupadre.MadreEN> Mujer {
        get { return mujer; } set { mujer = value;  }
}





public PadreEN()
{
        mujer = new System.Collections.Generic.List<TupadreGenNHibernate.EN.Tupadre.MadreEN>();
}



public PadreEN(int nombre, int edad, System.Collections.Generic.IList<TupadreGenNHibernate.EN.Tupadre.MadreEN> mujer
               )
{
        this.init (Nombre, edad, mujer);
}


public PadreEN(PadreEN padre)
{
        this.init (Nombre, padre.Edad, padre.Mujer);
}

private void init (int nombre
                   , int edad, System.Collections.Generic.IList<TupadreGenNHibernate.EN.Tupadre.MadreEN> mujer)
{
        this.Nombre = nombre;


        this.Edad = edad;

        this.Mujer = mujer;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PadreEN t = obj as PadreEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
