
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
 * Clase CLienteVIP:
 *
 */

namespace EjemploViernesGenNHibernate.CAD.EjemploViernes
{
public partial class CLienteVIPCAD : BasicCAD, ICLienteVIPCAD
{
public CLienteVIPCAD() : base ()
{
}

public CLienteVIPCAD(ISession sessionAux) : base (sessionAux)
{
}



public CLienteVIPEN ReadOIDDefault (string DNI
                                    )
{
        CLienteVIPEN cLienteVIPEN = null;

        try
        {
                SessionInitializeTransaction ();
                cLienteVIPEN = (CLienteVIPEN)session.Get (typeof(CLienteVIPEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in CLienteVIPCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cLienteVIPEN;
}

public System.Collections.Generic.IList<CLienteVIPEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CLienteVIPEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CLienteVIPEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CLienteVIPEN>();
                        else
                                result = session.CreateCriteria (typeof(CLienteVIPEN)).List<CLienteVIPEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in CLienteVIPCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CLienteVIPEN cLienteVIP)
{
        try
        {
                SessionInitializeTransaction ();
                CLienteVIPEN cLienteVIPEN = (CLienteVIPEN)session.Load (typeof(CLienteVIPEN), cLienteVIP.DNI);

                cLienteVIPEN.NumSocio = cLienteVIP.NumSocio;

                session.Update (cLienteVIPEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in CLienteVIPCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (CLienteVIPEN cLienteVIP)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cLienteVIP);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in CLienteVIPCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cLienteVIP.DNI;
}

public void Modify (CLienteVIPEN cLienteVIP)
{
        try
        {
                SessionInitializeTransaction ();
                CLienteVIPEN cLienteVIPEN = (CLienteVIPEN)session.Load (typeof(CLienteVIPEN), cLienteVIP.DNI);

                cLienteVIPEN.Nombre = cLienteVIP.Nombre;


                cLienteVIPEN.FechaNac = cLienteVIP.FechaNac;


                cLienteVIPEN.CodPostal = cLienteVIP.CodPostal;


                cLienteVIPEN.NumSocio = cLienteVIP.NumSocio;

                session.Update (cLienteVIPEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in CLienteVIPCAD.", ex);
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
                CLienteVIPEN cLienteVIPEN = (CLienteVIPEN)session.Load (typeof(CLienteVIPEN), DNI);
                session.Delete (cLienteVIPEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is EjemploViernesGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new EjemploViernesGenNHibernate.Exceptions.DataLayerException ("Error in CLienteVIPCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
