

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
 *      Definition of the class MadreCEN
 *
 */
public partial class MadreCEN
{
private IMadreCAD _IMadreCAD;

public MadreCEN()
{
        this._IMadreCAD = new MadreCAD ();
}

public MadreCEN(IMadreCAD _IMadreCAD)
{
        this._IMadreCAD = _IMadreCAD;
}

public IMadreCAD get_IMadreCAD ()
{
        return this._IMadreCAD;
}

public int New_ (int p_edad)
{
        MadreEN madreEN = null;
        int oid;

        //Initialized MadreEN
        madreEN = new MadreEN ();
        madreEN.Edad = p_edad;

        //Call to MadreCAD

        oid = _IMadreCAD.New_ (madreEN);
        return oid;
}

public void Modify (int p_madre_OID, int p_edad)
{
        MadreEN madreEN = null;

        //Initialized MadreEN
        madreEN = new MadreEN ();
        madreEN.Nombre = p_madre_OID;
        madreEN.Edad = p_edad;
        //Call to MadreCAD

        _IMadreCAD.Modify (madreEN);
}

public void Destroy (int nombre
                     )
{
        _IMadreCAD.Destroy (nombre);
}
}
}
