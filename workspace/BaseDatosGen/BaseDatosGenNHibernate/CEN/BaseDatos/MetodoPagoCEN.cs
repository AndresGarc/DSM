

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

public int New_ (BaseDatosGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum p_tipoPago, string p_usuario)
{
        MetodoPagoEN metodoPagoEN = null;
        int oid;

        //Initialized MetodoPagoEN
        metodoPagoEN = new MetodoPagoEN ();
        metodoPagoEN.TipoPago = p_tipoPago;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                metodoPagoEN.Usuario = new BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN ();
                metodoPagoEN.Usuario.Email = p_usuario;
        }

        //Call to MetodoPagoCAD

        oid = _IMetodoPagoCAD.New_ (metodoPagoEN);
        return oid;
}

public void Modify (int p_MetodoPago_OID, BaseDatosGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum p_tipoPago)
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
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN> GetMetodoPagoByPedido (int p_pedido, int first, int size)
{
        return _IMetodoPagoCAD.GetMetodoPagoByPedido (p_pedido, first, size);
}
}
}
