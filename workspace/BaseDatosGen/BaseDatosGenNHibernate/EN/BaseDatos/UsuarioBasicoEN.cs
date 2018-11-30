
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





public UsuarioBasicoEN()
{
}



public UsuarioBasicoEN(string email, string nombreUsu, String password, bool logged
                       )
{
        this.init (Email, nombreUsu, password, logged);
}


public UsuarioBasicoEN(UsuarioBasicoEN usuarioBasico)
{
        this.init (Email, usuarioBasico.NombreUsu, usuarioBasico.Password, usuarioBasico.Logged);
}

private void init (string Email
                   , string nombreUsu, String password, bool logged)
{
        this.Email = Email;


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
