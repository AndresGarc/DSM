

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

public string New_ (string p_Email, string p_NombreUsu, String p_Password, bool p_logged, string p_Nombre, string p_Apellidos, string p_Direccion, int p_Telefono, Nullable<DateTime> p_FNacimiento, int p_CP, bool p_Activo)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Email;

        usuarioEN.NombreUsu = p_NombreUsu;

        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_Password);

        usuarioEN.Logged = p_logged;

        usuarioEN.Nombre = p_Nombre;

        usuarioEN.Apellidos = p_Apellidos;

        usuarioEN.Direccion = p_Direccion;

        usuarioEN.Telefono = p_Telefono;

        usuarioEN.FNacimiento = p_FNacimiento;

        usuarioEN.CP = p_CP;

        usuarioEN.Activo = p_Activo;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public void Modify (string p_Usuario_OID, string p_NombreUsu, String p_Password, bool p_logged, string p_Nombre, string p_Apellidos, string p_Direccion, int p_Telefono, Nullable<DateTime> p_FNacimiento, int p_CP, bool p_Activo)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Email = p_Usuario_OID;
        usuarioEN.NombreUsu = p_NombreUsu;
        usuarioEN.Password = Utils.Util.GetEncondeMD5 (p_Password);
        usuarioEN.Logged = p_logged;
        usuarioEN.Nombre = p_Nombre;
        usuarioEN.Apellidos = p_Apellidos;
        usuarioEN.Direccion = p_Direccion;
        usuarioEN.Telefono = p_Telefono;
        usuarioEN.FNacimiento = p_FNacimiento;
        usuarioEN.CP = p_CP;
        usuarioEN.Activo = p_Activo;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (string Email
                     )
{
        _IUsuarioCAD.Destroy (Email);
}

public System.Collections.Generic.IList<UsuarioEN> MuestraUsuarios (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.MuestraUsuarios (first, size);
        return list;
}
public UsuarioEN MuestraUsuarioPorOID (string Email
                                       )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.MuestraUsuarioPorOID (Email);
        return usuarioEN;
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN> GetUsuarioByNombre (string p_nombre, int first, int size)
{
        return _IUsuarioCAD.GetUsuarioByNombre (p_nombre, first, size);
}
public void AddFavoritos (string p_Usuario_OID, System.Collections.Generic.IList<int> p_favoritos_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.AddFavoritos (p_Usuario_OID, p_favoritos_OIDs);
}
public void QuitarFavoritos (string p_Usuario_OID, System.Collections.Generic.IList<int> p_favoritos_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.QuitarFavoritos (p_Usuario_OID, p_favoritos_OIDs);
}
}
}
