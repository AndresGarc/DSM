
using System;
using System.Text;
using EjemploViernesGenNHibernate.CEN.EjemploViernes;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using EjemploViernesGenNHibernate.EN.EjemploViernes;
using EjemploViernesGenNHibernate.Exceptions;


/*
 * Clase Cliente:
 *
 */

namespace EjemploViernesGenNHibernate.CAD.EjemploViernes
{
public partial class ClienteCAD : BasicCAD, IClienteCAD
{
public ClienteCAD() : base ()
{
}

public ClienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClienteEN ReadOIDDefault (string DNI
                                 )
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}

public System.Collections.Generic.IList<ClienteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ClienteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ClienteEN>();
                        else
                                result = session.CreateCriteria (typeof(ClienteEN)).List<ClienteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), cliente.DNI);

                clienteEN.Nombre = cliente.Nombre;


                clienteEN.FechaNac = cliente.FechaNac;


                clienteEN.CodPostal = cliente.CodPostal;


                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string Nuevo (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cliente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cliente.DNI;
}

public void Modify (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), cliente.DNI);

                clienteEN.Nombre = cliente.Nombre;


                clienteEN.FechaNac = cliente.FechaNac;


                clienteEN.CodPostal = cliente.CodPostal;

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string DNI
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), DNI);
                session.Delete (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: MostrarClienteOID
//Con e: ClienteEN
public ClienteEN MostrarClienteOID (string DNI
                                    )
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}

public System.Collections.Generic.IList<ClienteEN> MostrarClientes (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ClienteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ClienteEN>();
                else
                        result = session.CreateCriteria (typeof(ClienteEN)).List<ClienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
