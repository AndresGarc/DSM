
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
 * Clase madre:
 *
 */

namespace TupadreGenNHibernate.CAD.Tupadre
{
public partial class MadreCAD : BasicCAD, IMadreCAD
{
public MadreCAD() : base ()
{
}

public MadreCAD(ISession sessionAux) : base (sessionAux)
{
}



public MadreEN ReadOIDDefault (int nombre
                               )
{
        MadreEN madreEN = null;

        try
        {
                SessionInitializeTransaction ();
                madreEN = (MadreEN)session.Get (typeof(MadreEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in MadreCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return madreEN;
}

public System.Collections.Generic.IList<MadreEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MadreEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MadreEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MadreEN>();
                        else
                                result = session.CreateCriteria (typeof(MadreEN)).List<MadreEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in MadreCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MadreEN madre)
{
        try
        {
                SessionInitializeTransaction ();
                MadreEN madreEN = (MadreEN)session.Load (typeof(MadreEN), madre.Nombre);

                madreEN.Edad = madre.Edad;


                session.Update (madreEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in MadreCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MadreEN madre)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (madre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in MadreCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return madre.Nombre;
}

public void Modify (MadreEN madre)
{
        try
        {
                SessionInitializeTransaction ();
                MadreEN madreEN = (MadreEN)session.Load (typeof(MadreEN), madre.Nombre);

                madreEN.Edad = madre.Edad;

                session.Update (madreEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in MadreCAD.", ex);
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
                MadreEN madreEN = (MadreEN)session.Load (typeof(MadreEN), nombre);
                session.Delete (madreEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is TupadreGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new TupadreGenNHibernate.Exceptions.DataLayerException ("Error in MadreCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
