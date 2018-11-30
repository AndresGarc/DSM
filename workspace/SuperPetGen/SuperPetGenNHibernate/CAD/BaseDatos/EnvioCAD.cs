
using System;
using System.Text;
using SuperPetGenNHibernate.CEN.BaseDatos;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.Exceptions;


/*
 * Clase Envio:
 *
 */

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial class EnvioCAD : BasicCAD, IEnvioCAD
{
public EnvioCAD() : base ()
{
}

public EnvioCAD(ISession sessionAux) : base (sessionAux)
{
}



public EnvioEN ReadOIDDefault (int id
                               )
{
        EnvioEN envioEN = null;

        try
        {
                SessionInitializeTransaction ();
                envioEN = (EnvioEN)session.Get (typeof(EnvioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return envioEN;
}

public System.Collections.Generic.IList<EnvioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EnvioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EnvioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EnvioEN>();
                        else
                                result = session.CreateCriteria (typeof(EnvioEN)).List<EnvioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EnvioEN envio)
{
        try
        {
                SessionInitializeTransaction ();
                EnvioEN envioEN = (EnvioEN)session.Load (typeof(EnvioEN), envio.Id);

                envioEN.HoraSalida = envio.HoraSalida;


                envioEN.HoraLlegada = envio.HoraLlegada;


                envioEN.FechaSalida = envio.FechaSalida;


                envioEN.FechaLlegada = envio.FechaLlegada;


                envioEN.Estado = envio.Estado;


                session.Update (envioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EnvioEN envio)
{
        try
        {
                SessionInitializeTransaction ();
                if (envio.Pedido != null) {
                        // Argumento OID y no colección.
                        envio.Pedido = (SuperPetGenNHibernate.EN.BaseDatos.PedidoEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.PedidoEN), envio.Pedido.Id);

                        envio.Pedido.Envio
                        .Add (envio);
                }

                session.Save (envio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return envio.Id;
}

public void Modify (EnvioEN envio)
{
        try
        {
                SessionInitializeTransaction ();
                EnvioEN envioEN = (EnvioEN)session.Load (typeof(EnvioEN), envio.Id);

                envioEN.HoraSalida = envio.HoraSalida;


                envioEN.HoraLlegada = envio.HoraLlegada;


                envioEN.FechaSalida = envio.FechaSalida;


                envioEN.FechaLlegada = envio.FechaLlegada;


                envioEN.Estado = envio.Estado;

                session.Update (envioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                EnvioEN envioEN = (EnvioEN)session.Load (typeof(EnvioEN), id);
                session.Delete (envioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
