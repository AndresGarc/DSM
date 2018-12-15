
using System;
// Definición clase UsuarioBasicoEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class UsuarioBasicoEN
{
/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo nombreUsu
 */
private string nombreUsu;



/**
 *	Atributo password
 */
private String password;



/**
 *	Atributo logged
 */
private bool logged;



/**
 *	Atributo id
 */
private int id;






public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string NombreUsu {
        get { return nombreUsu; } set { nombreUsu = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}



public virtual bool Logged {
        get { return logged; } set { logged = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public UsuarioBasicoEN()
{
}



public UsuarioBasicoEN(int id, string email, string nombreUsu, String password, bool logged
                       )
{
        this.init (Id, email, nombreUsu, password, logged);
}


public UsuarioBasicoEN(UsuarioBasicoEN usuarioBasico)
{
        this.init (Id, usuarioBasico.Email, usuarioBasico.NombreUsu, usuarioBasico.Password, usuarioBasico.Logged);
}

private void init (int id
                   , string email, string nombreUsu, String password, bool logged)
{
        this.Id = id;


        this.Email = email;

        this.NombreUsu = nombreUsu;

        this.Password = password;

        this.Logged = logged;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioBasicoEN t = obj as UsuarioBasicoEN;
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
