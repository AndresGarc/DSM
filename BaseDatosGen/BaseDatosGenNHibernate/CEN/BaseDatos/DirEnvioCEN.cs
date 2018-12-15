

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
 *      Definition of the class DirEnvioCEN
 *
 */
public partial class DirEnvioCEN
{
private IDirEnvioCAD _IDirEnvioCAD;

public DirEnvioCEN()
{
        this._IDirEnvioCAD = new DirEnvioCAD ();
}

public DirEnvioCEN(IDirEnvioCAD _IDirEnvioCAD)
{
        this._IDirEnvioCAD = _IDirEnvioCAD;
}

public IDirEnvioCAD get_IDirEnvioCAD ()
{
        return this._IDirEnvioCAD;
}

public int New_ (string p_Calle, int p_CP, string p_Localidad, string p_Provincia, int p_usuario)
{
        DirEnvioEN dirEnvioEN = null;
        int oid;

        //Initialized DirEnvioEN
        dirEnvioEN = new DirEnvioEN ();
        dirEnvioEN.Calle = p_Calle;

        dirEnvioEN.CP = p_CP;

        dirEnvioEN.Localidad = p_Localidad;

        dirEnvioEN.Provincia = p_Provincia;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                dirEnvioEN.Usuario = new BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN ();
                dirEnvioEN.Usuario.Id = p_usuario;
        }

        //Call to DirEnvioCAD

        oid = _IDirEnvioCAD.New_ (dirEnvioEN);
        return oid;
}

public void Modify (int p_DirEnvio_OID, string p_Calle, int p_CP, string p_Localidad, string p_Provincia)
{
        DirEnvioEN dirEnvioEN = null;

        //Initialized DirEnvioEN
        dirEnvioEN = new DirEnvioEN ();
        dirEnvioEN.Id = p_DirEnvio_OID;
        dirEnvioEN.Calle = p_Calle;
        dirEnvioEN.CP = p_CP;
        dirEnvioEN.Localidad = p_Localidad;
        dirEnvioEN.Provincia = p_Provincia;
        //Call to DirEnvioCAD

        _IDirEnvioCAD.Modify (dirEnvioEN);
}

public void Destroy (int id
                     )
{
        _IDirEnvioCAD.Destroy (id);
}

public DirEnvioEN MuestraDireccionPorOID (int id
                                          )
{
        DirEnvioEN dirEnvioEN = null;

        dirEnvioEN = _IDirEnvioCAD.MuestraDireccionPorOID (id);
        return dirEnvioEN;
}

public System.Collections.Generic.IList<DirEnvioEN> MuestraDirecciones (int first, int size)
{
        System.Collections.Generic.IList<DirEnvioEN> list = null;

        list = _IDirEnvioCAD.MuestraDirecciones (first, size);
        return list;
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN> GetDirEnvioByPedido (int p_pedido, int first, int size)
{
        return _IDirEnvioCAD.GetDirEnvioByPedido (p_pedido, first, size);
}
}
}
