
using System;
// Definición clase SliderEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class SliderEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo imagen1
 */
private string imagen1;



/**
 *	Atributo imagen2
 */
private string imagen2;



/**
 *	Atributo imagen3
 */
private string imagen3;



/**
 *	Atributo imagen4
 */
private string imagen4;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Imagen1 {
        get { return imagen1; } set { imagen1 = value;  }
}



public virtual string Imagen2 {
        get { return imagen2; } set { imagen2 = value;  }
}



public virtual string Imagen3 {
        get { return imagen3; } set { imagen3 = value;  }
}



public virtual string Imagen4 {
        get { return imagen4; } set { imagen4 = value;  }
}





public SliderEN()
{
}



public SliderEN(int id, string imagen1, string imagen2, string imagen3, string imagen4
                )
{
        this.init (Id, imagen1, imagen2, imagen3, imagen4);
}


public SliderEN(SliderEN slider)
{
        this.init (Id, slider.Imagen1, slider.Imagen2, slider.Imagen3, slider.Imagen4);
}

private void init (int id
                   , string imagen1, string imagen2, string imagen3, string imagen4)
{
        this.Id = id;


        this.Imagen1 = imagen1;

        this.Imagen2 = imagen2;

        this.Imagen3 = imagen3;

        this.Imagen4 = imagen4;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SliderEN t = obj as SliderEN;
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
