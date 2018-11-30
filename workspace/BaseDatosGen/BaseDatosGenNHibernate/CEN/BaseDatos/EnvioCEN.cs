

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
 *      Definition of the class EnvioCEN
 *
 */
public partial class EnvioCEN
{
private IEnvioCAD _IEnvioCAD;

public EnvioCEN()
{
        this._IEnvioCAD = new EnvioCAD ();
}

public EnvioCEN(IEnvioCAD _IEnvioCAD)
{
        this._IEnvioCAD = _IEnvioCAD;
}

public IEnvioCAD get_IEnvioCAD ()
{
        return this._IEnvioCAD;
}

public int New_ (Nullable<DateTime> p_fechaSalida, Nullable<DateTime> p_fechaLlegada, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum p_estado, int p_pedido)
{
        EnvioEN envioEN = null;
        int oid;

        //Initialized EnvioEN
        envioEN = new EnvioEN ();
        envioEN.FechaSalida = p_fechaSalida;

        envioEN.FechaLlegada = p_fechaLlegada;

        envioEN.Estado = p_estado;


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids id
                envioEN.Pedido = new BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN ();
                envioEN.Pedido.Id = p_pedido;
        }

        //Call to EnvioCAD

        oid = _IEnvioCAD.New_ (envioEN);
        return oid;
}

public void Modify (int p_Envio_OID, Nullable<DateTime> p_fechaSalida, Nullable<DateTime> p_fechaLlegada, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum p_estado)
{
        EnvioEN envioEN = null;

        //Initialized EnvioEN
        envioEN = new EnvioEN ();
        envioEN.Id = p_Envio_OID;
        envioEN.FechaSalida = p_fechaSalida;
        envioEN.FechaLlegada = p_fechaLlegada;
        envioEN.Estado = p_estado;
        //Call to EnvioCAD

        _IEnvioCAD.Modify (envioEN);
}

public void Destroy (int id
                     )
{
        _IEnvioCAD.Destroy (id);
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.EnvioEN> GetEnvioByPedido (int p_pedido, int first, int size)
{
        return _IEnvioCAD.GetEnvioByPedido (p_pedido, first, size);
}
}
}
