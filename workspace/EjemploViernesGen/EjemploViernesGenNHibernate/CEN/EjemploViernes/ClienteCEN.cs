

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
 *      Definition of the class ClienteCEN
 *
 */
public partial class ClienteCEN
{
private IClienteCAD _IClienteCAD;

public ClienteCEN()
{
        this._IClienteCAD = new ClienteCAD ();
}

public ClienteCEN(IClienteCAD _IClienteCAD)
{
        this._IClienteCAD = _IClienteCAD;
}

public IClienteCAD get_IClienteCAD ()
{
        return this._IClienteCAD;
}

public string Nuevo (string p_DNI, string p_nombre, Nullable<DateTime> p_fechaNac, int p_codPostal)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_DNI;

        clienteEN.Nombre = p_nombre;

        clienteEN.FechaNac = p_fechaNac;

        clienteEN.CodPostal = p_codPostal;

        //Call to ClienteCAD

        oid = _IClienteCAD.Nuevo (clienteEN);
        return oid;
}

public void Modify (string p_Cliente_OID, string p_nombre, Nullable<DateTime> p_fechaNac, int p_codPostal)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_Cliente_OID;
        clienteEN.Nombre = p_nombre;
        clienteEN.FechaNac = p_fechaNac;
        clienteEN.CodPostal = p_codPostal;
        //Call to ClienteCAD

        _IClienteCAD.Modify (clienteEN);
}

public void Destroy (string DNI
                     )
{
        _IClienteCAD.Destroy (DNI);
}

public ClienteEN MostrarClienteOID (string DNI
                                    )
{
        ClienteEN clienteEN = null;

        clienteEN = _IClienteCAD.MostrarClienteOID (DNI);
        return clienteEN;
}

public System.Collections.Generic.IList<ClienteEN> MostrarClientes (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> list = null;

        list = _IClienteCAD.MostrarClientes (first, size);
        return list;
}
}
}
