

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using TupadreGenNHibernate.Exceptions;

using TupadreGenNHibernate.EN.Tupadre;
using TupadreGenNHibernate.CAD.Tupadre;


namespace TupadreGenNHibernate.CEN.Tupadre
{
/*
 *      Definition of the class PadreCEN
 *
 */
public partial class PadreCEN
{
private IPadreCAD _IPadreCAD;

public PadreCEN()
{
        this._IPadreCAD = new PadreCAD ();
}

public PadreCEN(IPadreCAD _IPadreCAD)
{
        this._IPadreCAD = _IPadreCAD;
}

public IPadreCAD get_IPadreCAD ()
{
        return this._IPadreCAD;
}

public int New_ (int p_edad)
{
        PadreEN padreEN = null;
        int oid;

        //Initialized PadreEN
        padreEN = new PadreEN ();
        padreEN.Edad = p_edad;

        //Call to PadreCAD

        oid = _IPadreCAD.New_ (padreEN);
        return oid;
}

public void Modify (int p_padre_OID, int p_edad)
{
        PadreEN padreEN = null;

        //Initialized PadreEN
        padreEN = new PadreEN ();
        padreEN.Nombre = p_padre_OID;
        padreEN.Edad = p_edad;
        //Call to PadreCAD

        _IPadreCAD.Modify (padreEN);
}

public void Destroy (int nombre
                     )
{
        _IPadreCAD.Destroy (nombre);
}
}
}
