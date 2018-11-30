

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using EjemploViernesGenNHibernate.Exceptions;

using EjemploViernesGenNHibernate.EN.EjemploViernes;
using EjemploViernesGenNHibernate.CAD.EjemploViernes;


namespace EjemploViernesGenNHibernate.CEN.EjemploViernes
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

public int New_ (string p_calle, int p_CP, string p_Localidad, string p_Provincia)
{
        DirEnvioEN dirEnvioEN = null;
        int oid;

        //Initialized DirEnvioEN
        dirEnvioEN = new DirEnvioEN ();
        dirEnvioEN.Calle = p_calle;

        dirEnvioEN.CP = p_CP;

        dirEnvioEN.Localidad = p_Localidad;

        dirEnvioEN.Provincia = p_Provincia;

        //Call to DirEnvioCAD

        oid = _IDirEnvioCAD.New_ (dirEnvioEN);
        return oid;
}

public void Modify (int p_DirEnvio_OID, string p_calle, int p_CP, string p_Localidad, string p_Provincia)
{
        DirEnvioEN dirEnvioEN = null;

        //Initialized DirEnvioEN
        dirEnvioEN = new DirEnvioEN ();
        dirEnvioEN.Id = p_DirEnvio_OID;
        dirEnvioEN.Calle = p_calle;
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
}
}
