

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

public int New_ (double p_precioTotal, int p_pedido, double p_IVA, double p_precioSinIVA, Nullable<DateTime> p_fechaPago)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.PrecioTotal = p_precioTotal;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                facturaEN.Pedido = new BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN ();
                facturaEN.Pedido.Id = p_pedido;
        }

        facturaEN.IVA = p_IVA;

        facturaEN.PrecioSinIVA = p_precioSinIVA;

        facturaEN.FechaPago = p_fechaPago;

        //Call to FacturaCAD

        oid = _IFacturaCAD.New_ (facturaEN);
        return oid;
}

public void Modify (int p_Factura_OID, double p_precioTotal, double p_IVA, double p_precioSinIVA, Nullable<DateTime> p_fechaPago)
{
        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_Factura_OID;
        facturaEN.PrecioTotal = p_precioTotal;
        facturaEN.IVA = p_IVA;
        facturaEN.PrecioSinIVA = p_precioSinIVA;
        facturaEN.FechaPago = p_fechaPago;
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
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.FacturaEN> GetFacturaByPedido (int p_pedido, int first, int size)
{
        return _IFacturaCAD.GetFacturaByPedido (p_pedido, first, size);
}
}
}
