
using System;
using System.Text;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.Exceptions;


/*
 * Clase Envio:
 *
 */

namespace BaseDatosGenNHibernate.CAD.BaseDatos
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
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
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
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
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

                envioEN.FechaSalida = envio.FechaSalida;


                envioEN.FechaLlegada = envio.FechaLlegada;


                envioEN.Estado = envio.Estado;


                session.Update (envioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
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
                        envio.Pedido = (BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN)session.Load (typeof(BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN), envio.Pedido.Id);

                        envio.Pedido.Envio
                                = envio;
                }

                session.Save (envio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
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

                envioEN.FechaSalida = envio.FechaSalida;


                envioEN.FechaLlegada = envio.FechaLlegada;


                envioEN.Estado = envio.Estado;

                session.Update (envioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
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
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.EnvioEN> GetEnvioByPedido (int p_pedido, int first, int size)
{
        System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.EnvioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM EnvioEN self where FROM EnvioEN env WHERE env.Pedido.Id = :p_pedido";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("EnvioENgetEnvioByPedidoHQL");
                query.SetParameter ("p_pedido", p_pedido);

                if (size > 0) {
                        query.SetFirstResult (first).SetMaxResults (size);
                }
                else{
                        query.SetFirstResult (first);
                }

                result = query.List<BaseDatosGenNHibernate.EN.BaseDatos.EnvioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in EnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
