

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

public int New_ (string p_descripcion, string p_cliente, EjemploViernesGenNHibernate.Enumerated.EjemploViernes.EstadoPEdidoEnum p_estado)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Descripcion = p_descripcion;


        if (p_cliente != null) {
                // El argumento p_cliente -> Property cliente es oid = false
                // Lista de oids id
                pedidoEN.Cliente = new EjemploViernesGenNHibernate.EN.EjemploViernes.ClienteEN ();
                pedidoEN.Cliente.DNI = p_cliente;
        }

        pedidoEN.Estado = p_estado;

        //Call to PedidoCAD

        oid = _IPedidoCAD.New_ (pedidoEN);
        return oid;
}

public void Modify (int p_Pedido_OID, string p_descripcion, EjemploViernesGenNHibernate.Enumerated.EjemploViernes.EstadoPEdidoEnum p_estado)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_Pedido_OID;
        pedidoEN.Descripcion = p_descripcion;
        pedidoEN.Estado = p_estado;
        //Call to PedidoCAD

        _IPedidoCAD.Modify (pedidoEN);
}

public void Destroy (int id
                     )
{
        _IPedidoCAD.Destroy (id);
}

public void AnyDir (int p_Pedido_OID, System.Collections.Generic.IList<int> p_dirEnvio_OIDs)
{
        //Call to PedidoCAD

        _IPedidoCAD.AnyDir (p_Pedido_OID, p_dirEnvio_OIDs);
}
public void ElimDir (int p_Pedido_OID, System.Collections.Generic.IList<int> p_dirEnvio_OIDs)
{
        //Call to PedidoCAD

        _IPedidoCAD.ElimDir (p_Pedido_OID, p_dirEnvio_OIDs);
}
}
}
