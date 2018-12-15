
using System;
// Definición clase AdministradorEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
{
public partial class AdministradorEN                                                                        : BaseDatosGenNHibernate.EN.BaseDatos.UsuarioBasicoEN


{
public AdministradorEN() : base ()
{
}



public AdministradorEN(int id,
                       string email, string nombreUsu, String password, bool logged
                       )
{
        this.init (Id, email, nombreUsu, password, logged);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (Id, administrador.Email, administrador.NombreUsu, administrador.Password, administrador.Logged);
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
        AdministradorEN t = obj as AdministradorEN;
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
