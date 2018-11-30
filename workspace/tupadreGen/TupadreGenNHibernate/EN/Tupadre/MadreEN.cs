
using System;
// Definición clase MadreEN
namespace TupadreGenNHibernate.EN.Tupadre
{
public partial class MadreEN
{
/**
 *	Atributo nombre
 */
private int nombre;



/**
 *	Atributo edad
 */
private int edad;



/**
 *	Atributo marido
 */
private TupadreGenNHibernate.EN.Tupadre.PadreEN marido;






public virtual int Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int Edad {
        get { return edad; } set { edad = value;  }
}



public virtual TupadreGenNHibernate.EN.Tupadre.PadreEN Marido {
        get { return marido; } set { marido = value;  }
}





public MadreEN()
{
}



public MadreEN(int nombre, int edad, TupadreGenNHibernate.EN.Tupadre.PadreEN marido
               )
{
        this.init (Nombre, edad, marido);
}


public MadreEN(MadreEN madre)
{
        this.init (Nombre, madre.Edad, madre.Marido);
}

private void init (int nombre
                   , int edad, TupadreGenNHibernate.EN.Tupadre.PadreEN marido)
{
        this.Nombre = nombre;


        this.Edad = edad;

        this.Marido = marido;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MadreEN t = obj as MadreEN;
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
