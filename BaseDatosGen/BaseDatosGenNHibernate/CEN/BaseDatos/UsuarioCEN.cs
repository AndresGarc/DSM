

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public int New_ (string p_Email, string p_NombreUsu, String p_Password, bool p_logged, string p_Nombre, string p_Apellidos, int p_Telefono, Nullable<DateTime> p_FNacimiento, bool p_Activo)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Email;

        usuarioEN.NombreUsu = p_NombreUsu;

        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_Password);

        usuarioEN.Logged = p_logged;

        usuarioEN.Nombre = p_Nombre;

        usuarioEN.Apellidos = p_Apellidos;

        usuarioEN.Telefono = p_Telefono;

        usuarioEN.FNacimiento = p_FNacimiento;

        usuarioEN.Activo = p_Activo;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public void Modify (int p_Usuario_OID, string p_Email, string p_NombreUsu, String p_Password, bool p_logged, string p_Nombre, string p_Apellidos, int p_Telefono, Nullable<DateTime> p_FNacimiento, bool p_Activo)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Id = p_Usuario_OID;
        usuarioEN.Email = p_Email;
        usuarioEN.NombreUsu = p_NombreUsu;
        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_Password);
        usuarioEN.Logged = p_logged;
        usuarioEN.Nombre = p_Nombre;
        usuarioEN.Apellidos = p_Apellidos;
        usuarioEN.Telefono = p_Telefono;
        usuarioEN.FNacimiento = p_FNacimiento;
        usuarioEN.Activo = p_Activo;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (int id
                     )
{
        _IUsuarioCAD.Destroy (id);
}

public System.Collections.Generic.IList<UsuarioEN> MuestraUsuarios (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.MuestraUsuarios (first, size);
        return list;
}
public UsuarioEN MuestraUsuarioPorOID (int id
                                       )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.MuestraUsuarioPorOID (id);
        return usuarioEN;
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN> GetUsuarioByNombre (string p_nombre, int first, int size)
{
        return _IUsuarioCAD.GetUsuarioByNombre (p_nombre, first, size);
}
public void AddFavoritos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_favoritos_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.AddFavoritos (p_Usuario_OID, p_favoritos_OIDs);
}
public void QuitarFavoritos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_favoritos_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.QuitarFavoritos (p_Usuario_OID, p_favoritos_OIDs);
}
}
}
