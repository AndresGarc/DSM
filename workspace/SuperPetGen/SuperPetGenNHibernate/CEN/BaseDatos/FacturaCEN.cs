

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
 *      Definition of the class FacturaCEN
 *
 */
public partial class FacturaCEN
{
private IFacturaCAD _IFacturaCAD;

public FacturaCEN()
{
        this._IFacturaCAD = new FacturaCAD ();
}

public FacturaCEN(IFacturaCAD _IFacturaCAD)
{
        this._IFacturaCAD = _IFacturaCAD;
}

public IFacturaCAD get_IFacturaCAD ()
{
        return this._IFacturaCAD;
}

public int New_ (float p_precioTotal, int p_pedido, float p_IVA)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.PrecioTotal = p_precioTotal;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                facturaEN.Pedido = new SuperPetGenNHibernate.EN.BaseDatos.PedidoEN ();
                facturaEN.Pedido.Id = p_pedido;
        }

        facturaEN.IVA = p_IVA;

        //Call to FacturaCAD

        oid = _IFacturaCAD.New_ (facturaEN);
        return oid;
}

public void Modify (int p_Factura_OID, float p_precioTotal, float p_IVA)
{
        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_Factura_OID;
        facturaEN.PrecioTotal = p_precioTotal;
        facturaEN.IVA = p_IVA;
        //Call to FacturaCAD

        _IFacturaCAD.Modify (facturaEN);
}

public void Destroy (int id
                     )
{
        _IFacturaCAD.Destroy (id);
}

public FacturaEN MuestraFacturaPorOID (int id
                                       )
{
        FacturaEN facturaEN = null;

        facturaEN = _IFacturaCAD.MuestraFacturaPorOID (id);
        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> MuestraFacturas (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> list = null;

        list = _IFacturaCAD.MuestraFacturas (first, size);
        return list;
}
}
}
