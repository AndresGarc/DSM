

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BaseDatosGenNHibernate.Exceptions;

using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;


namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
/*
 *      Definition of the class UsuarioBasicoCEN
 *
 */
public partial class UsuarioBasicoCEN
{
private IUsuarioBasicoCAD _IUsuarioBasicoCAD;

public UsuarioBasicoCEN()
{
        this._IUsuarioBasicoCAD = new UsuarioBasicoCAD ();
}

public UsuarioBasicoCEN(IUsuarioBasicoCAD _IUsuarioBasicoCAD)
{
        this._IUsuarioBasicoCAD = _IUsuarioBasicoCAD;
}

public IUsuarioBasicoCAD get_IUsuarioBasicoCAD ()
{
        return this._IUsuarioBasicoCAD;
}

public int New_ (string p_Email, string p_NombreUsu, String p_Password, bool p_logged)
{
        UsuarioBasicoEN usuarioBasicoEN = null;
        int oid;

        //Initialized UsuarioBasicoEN
        usuarioBasicoEN = new UsuarioBasicoEN ();
        usuarioBasicoEN.Email = p_Email;

        usuarioBasicoEN.NombreUsu = p_NombreUsu;

        usuarioBasicoEN.Password = Utils.Util.GetEncondeMD5 (p_Password);

        usuarioBasicoEN.Logged = p_logged;

        //Call to UsuarioBasicoCAD

        oid = _IUsuarioBasicoCAD.New_ (usuarioBasicoEN);
        return oid;
}

public void Modify (int p_UsuarioBasico_OID, string p_Email, string p_NombreUsu, String p_Password, bool p_logged)
{
        UsuarioBasicoEN usuarioBasicoEN = null;

        //Initialized UsuarioBasicoEN
        usuarioBasicoEN = new UsuarioBasicoEN ();
        usuarioBasicoEN.Id = p_UsuarioBasico_OID;
        usuarioBasicoEN.Email = p_Email;
        usuarioBasicoEN.NombreUsu = p_NombreUsu;
        usuarioBasicoEN.Password = Utils.Util.GetEncondeMD5 (p_Password);
        usuarioBasicoEN.Logged = p_logged;
        //Call to UsuarioBasicoCAD

        _IUsuarioBasicoCAD.Modify (usuarioBasicoEN);
}

public void Destroy (int id
                     )
{
        _IUsuarioBasicoCAD.Destroy (id);
}
}
}
