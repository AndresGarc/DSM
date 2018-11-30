
using System;
using System.Text;
using TupadreGenNHibernate.CEN.Tupadre;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using TupadreGenNHibernate.EN.Tupadre;
using TupadreGenNHibernate.Exceptions;


/*
 * Clase padre:
 *
 */

namespace TupadreGenNHibernate.CAD.Tupadre
{
public partial class PadreCAD : BasicCAD, IPadreCAD
{
public PadreCAD() : base ()
{
}

public PadreCAD(ISession sessionAux) : base (sessionAux)
{
}



public PadreEN ReadOIDDefault (int nombre
                               )
{
        PadreEN padreEN = null;

        try
        {
                SessionInitializeTransaction ();
                padreEN = (PadreEN)session.Get (typeof(PadreEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in PadreCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return padreEN;
}

public System.Collections.Generic.IList<PadreEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PadreEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PadreEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PadreEN>();
                        else
                                result = session.CreateCriteria (typeof(PadreEN)).List<PadreEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in PadreCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PadreEN padre)
{
        try
        {
                SessionInitializeTransaction ();
                PadreEN padreEN = (PadreEN)session.Load (typeof(PadreEN), padre.Nombre);

                padreEN.Edad = padre.Edad;


                session.Update (padreEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in PadreCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PadreEN padre)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (padre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in PadreCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return padre.Nombre;
}

public void Modify (PadreEN padre)
{
        try
        {
                SessionInitializeTransaction ();
                PadreEN padreEN = (PadreEN)session.Load (typeof(PadreEN), padre.Nombre);

                padreEN.Edad = padre.Edad;

                session.Update (padreEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in PadreCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int nombre
                     )
{
        try
        {
                SessionInitializeTransaction ();
                PadreEN padreEN = (PadreEN)session.Load (typeof(PadreEN), nombre);
                session.Delete (padreEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in PadreCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
