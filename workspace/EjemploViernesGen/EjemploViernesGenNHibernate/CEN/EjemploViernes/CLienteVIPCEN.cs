

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
 *      Definition of the class CLienteVIPCEN
 *
 */
public partial class CLienteVIPCEN
{
private ICLienteVIPCAD _ICLienteVIPCAD;

public CLienteVIPCEN()
{
        this._ICLienteVIPCAD = new CLienteVIPCAD ();
}

public CLienteVIPCEN(ICLienteVIPCAD _ICLienteVIPCAD)
{
        this._ICLienteVIPCAD = _ICLienteVIPCAD;
}

public ICLienteVIPCAD get_ICLienteVIPCAD ()
{
        return this._ICLienteVIPCAD;
}

public string New_ (string p_DNI, string p_nombre, Nullable<DateTime> p_fechaNac, int p_codPostal, int p_numSocio)
{
        CLienteVIPEN cLienteVIPEN = null;
        string oid;

        //Initialized CLienteVIPEN
        cLienteVIPEN = new CLienteVIPEN ();
        cLienteVIPEN.DNI = p_DNI;

        cLienteVIPEN.Nombre = p_nombre;

        cLienteVIPEN.FechaNac = p_fechaNac;

        cLienteVIPEN.CodPostal = p_codPostal;

        cLienteVIPEN.NumSocio = p_numSocio;

        //Call to CLienteVIPCAD

        oid = _ICLienteVIPCAD.New_ (cLienteVIPEN);
        return oid;
}

public void Modify (string p_CLienteVIP_OID, string p_nombre, Nullable<DateTime> p_fechaNac, int p_codPostal, int p_numSocio)
{
        CLienteVIPEN cLienteVIPEN = null;

        //Initialized CLienteVIPEN
        cLienteVIPEN = new CLienteVIPEN ();
        cLienteVIPEN.DNI = p_CLienteVIP_OID;
        cLienteVIPEN.Nombre = p_nombre;
        cLienteVIPEN.FechaNac = p_fechaNac;
        cLienteVIPEN.CodPostal = p_codPostal;
        cLienteVIPEN.NumSocio = p_numSocio;
        //Call to CLienteVIPCAD

        _ICLienteVIPCAD.Modify (cLienteVIPEN);
}

public void Destroy (string DNI
                     )
{
        _ICLienteVIPCAD.Destroy (DNI);
}
}
}
