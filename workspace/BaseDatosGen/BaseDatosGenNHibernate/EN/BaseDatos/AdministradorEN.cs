
using System;
// Definición clase AdministradorEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class AdministradorEN                                                                        : BaseDatosGenNHibernate.EN.BaseDatos.UsuarioBasicoEN


{
public AdministradorEN() : base ()
{
}



public AdministradorEN(string email,
                       string nombreUsu, String password, bool logged
                       )
{
        this.init (Email, nombreUsu, password, logged);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (Email, administrador.NombreUsu, administrador.Password, administrador.Logged);
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
        AdministradorEN t = obj as AdministradorEN;
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
