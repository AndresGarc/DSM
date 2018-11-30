

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
 *      Definition of the class PedidoCEN
 *
 */
public partial class PedidoCEN
{
private IPedidoCAD _IPedidoCAD;

public PedidoCEN()
{
        this._IPedidoCAD = new PedidoCAD ();
}

public PedidoCEN(IPedidoCAD _IPedidoCAD)
{
        this._IPedidoCAD = _IPedidoCAD;
}

public IPedidoCAD get_IPedidoCAD ()
{
        return this._IPedidoCAD;
}

public int New_ (Nullable<DateTime> p_Fecha, string p_TipoPago, SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum p_Estado, string p_usuario, string p_usuario_0, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN> p_lineaPedido)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Fecha = p_Fecha;

        pedidoEN.TipoPago = p_TipoPago;

        pedidoEN.Estado = p_Estado;


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                pedidoEN.Usuario = new SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN ();
                pedidoEN.Usuario.Email = p_usuario;
        }


        if (p_usuario_0 != null) {
                // El argumento p_usuario_0 -> Property usuario_0 es oid = false
                // Lista de oids id
                pedidoEN.Usuario_0 = new SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN ();
                pedidoEN.Usuario_0.Email = p_usuario_0;
        }

        pedidoEN.LineaPedido = p_lineaPedido;

        //Call to PedidoCAD

        oid = _IPedidoCAD.New_ (pedidoEN);
        return oid;
}

public void Modify (int p_Pedido_OID, Nullable<DateTime> p_Fecha, string p_TipoPago, SuperPetGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum p_Estado)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_Pedido_OID;
        pedidoEN.Fecha = p_Fecha;
        pedidoEN.TipoPago = p_TipoPago;
        pedidoEN.Estado = p_Estado;
        //Call to PedidoCAD

        _IPedidoCAD.Modify (pedidoEN);
}

public void Destroy (int id
                     )
{
        _IPedidoCAD.Destroy (id);
}

public System.Collections.Generic.IList<PedidoEN> MuestraPedidos (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> list = null;

        list = _IPedidoCAD.MuestraPedidos (first, size);
        return list;
}
public PedidoEN MuestraPedidoPorOID (int id
                                     )
{
        PedidoEN pedidoEN = null;

        pedidoEN = _IPedidoCAD.MuestraPedidoPorOID (id);
        return pedidoEN;
}

public void AddDirEnvio (int p_Pedido_OID, System.Collections.Generic.IList<int> p_dirEnvio_OIDs)
{
        //Call to PedidoCAD

        _IPedidoCAD.AddDirEnvio (p_Pedido_OID, p_dirEnvio_OIDs);
}
public void AddMetodoPago (int p_Pedido_OID, int p_metodoPago_OID)
{
        //Call to PedidoCAD

        _IPedidoCAD.AddMetodoPago (p_Pedido_OID, p_metodoPago_OID);
}
}
}
