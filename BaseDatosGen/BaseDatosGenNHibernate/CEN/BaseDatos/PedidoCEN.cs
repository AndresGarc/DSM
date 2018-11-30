

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

public int New_ (Nullable<DateTime> p_Fecha, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum p_Estado, string p_usuarioPedido, string p_usuarioCarrito)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Fecha = p_Fecha;

        pedidoEN.Estado = p_Estado;


        if (p_usuarioPedido != null) {
                // El argumento p_usuarioPedido -> Property usuarioPedido es oid = false
                // Lista de oids id
                pedidoEN.UsuarioPedido = new BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN ();
                pedidoEN.UsuarioPedido.Email = p_usuarioPedido;
        }


        if (p_usuarioCarrito != null) {
                // El argumento p_usuarioCarrito -> Property usuarioCarrito es oid = false
                // Lista de oids id
                pedidoEN.UsuarioCarrito = new BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN ();
                pedidoEN.UsuarioCarrito.Email = p_usuarioCarrito;
        }

        //Call to PedidoCAD

        oid = _IPedidoCAD.New_ (pedidoEN);
        return oid;
}

public void Modify (int p_Pedido_OID, Nullable<DateTime> p_Fecha, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum p_Estado)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_Pedido_OID;
        pedidoEN.Fecha = p_Fecha;
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

public void AddDirEnvio (int p_Pedido_OID, int p_dirEnvio_OID)
{
        //Call to PedidoCAD

        _IPedidoCAD.AddDirEnvio (p_Pedido_OID, p_dirEnvio_OID);
}
public void AddMetodoPago (int p_Pedido_OID, int p_metodoPago_OID)
{
        //Call to PedidoCAD

        _IPedidoCAD.AddMetodoPago (p_Pedido_OID, p_metodoPago_OID);
}
public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> GetAllPedidosByUsuario (string p_usuario, int first, int size)
{
        return _IPedidoCAD.GetAllPedidosByUsuario (p_usuario, first, size);
}
}
}
