

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SuperPetGenNHibernate.Exceptions;

using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.CAD.BaseDatos;


namespace SuperPetGenNHibernate.CEN.BaseDatos
{
/*
 *      Definition of the class MetodoPagoCEN
 *
 */
public partial class MetodoPagoCEN
{
private IMetodoPagoCAD _IMetodoPagoCAD;

public MetodoPagoCEN()
{
        this._IMetodoPagoCAD = new MetodoPagoCAD ();
}

public MetodoPagoCEN(IMetodoPagoCAD _IMetodoPagoCAD)
{
        this._IMetodoPagoCAD = _IMetodoPagoCAD;
}

public IMetodoPagoCAD get_IMetodoPagoCAD ()
{
        return this._IMetodoPagoCAD;
}

public int New_ (SuperPetGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum p_tipoPago)
{
        MetodoPagoEN metodoPagoEN = null;
        int oid;

        //Initialized MetodoPagoEN
        metodoPagoEN = new MetodoPagoEN ();
        metodoPagoEN.TipoPago = p_tipoPago;

        //Call to MetodoPagoCAD

        oid = _IMetodoPagoCAD.New_ (metodoPagoEN);
        return oid;
}

public void Modify (int p_MetodoPago_OID, SuperPetGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum p_tipoPago)
{
        MetodoPagoEN metodoPagoEN = null;

        //Initialized MetodoPagoEN
        metodoPagoEN = new MetodoPagoEN ();
        metodoPagoEN.Id = p_MetodoPago_OID;
        metodoPagoEN.TipoPago = p_tipoPago;
        //Call to MetodoPagoCAD

        _IMetodoPagoCAD.Modify (metodoPagoEN);
}

public void Destroy (int id
                     )
{
        _IMetodoPagoCAD.Destroy (id);
}

public MetodoPagoEN MuestraMetodoPagoPorOID (int id
                                             )
{
        MetodoPagoEN metodoPagoEN = null;

        metodoPagoEN = _IMetodoPagoCAD.MuestraMetodoPagoPorOID (id);
        return metodoPagoEN;
}

public System.Collections.Generic.IList<MetodoPagoEN> MuestraMetodoPagos (int first, int size)
{
        System.Collections.Generic.IList<MetodoPagoEN> list = null;

        list = _IMetodoPagoCAD.MuestraMetodoPagos (first, size);
        return list;
}
}
}
