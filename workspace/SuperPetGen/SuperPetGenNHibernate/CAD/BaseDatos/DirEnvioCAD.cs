
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
 * Clase DirEnvio:
 *
 */

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial class DirEnvioCAD : BasicCAD, IDirEnvioCAD
{
public DirEnvioCAD() : base ()
{
}

public DirEnvioCAD(ISession sessionAux) : base (sessionAux)
{
}



public DirEnvioEN ReadOIDDefault (int id
                                  )
{
        DirEnvioEN dirEnvioEN = null;

        try
        {
                SessionInitializeTransaction ();
                dirEnvioEN = (DirEnvioEN)session.Get (typeof(DirEnvioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in DirEnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return dirEnvioEN;
}

public System.Collections.Generic.IList<DirEnvioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DirEnvioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DirEnvioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DirEnvioEN>();
                        else
                                result = session.CreateCriteria (typeof(DirEnvioEN)).List<DirEnvioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in DirEnvioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DirEnvioEN dirEnvio)
{
        try
        {
                SessionInitializeTransaction ();
                DirEnvioEN dirEnvioEN = (DirEnvioEN)session.Load (typeof(DirEnvioEN), dirEnvio.Id);

                dirEnvioEN.Calle = dirEnvio.Calle;


                dirEnvioEN.CP = dirEnvio.CP;


                dirEnvioEN.Localidad = dirEnvio.Localidad;


                dirEnvioEN.Provincia = dirEnvio.Provincia;


                session.Update (dirEnvioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in DirEnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (DirEnvioEN dirEnvio)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (dirEnvio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in DirEnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return dirEnvio.Id;
}

public void Modify (DirEnvioEN dirEnvio)
{
        try
        {
                SessionInitializeTransaction ();
                DirEnvioEN dirEnvioEN = (DirEnvioEN)session.Load (typeof(DirEnvioEN), dirEnvio.Id);

                dirEnvioEN.Calle = dirEnvio.Calle;


                dirEnvioEN.CP = dirEnvio.CP;


                dirEnvioEN.Localidad = dirEnvio.Localidad;


                dirEnvioEN.Provincia = dirEnvio.Provincia;

                session.Update (dirEnvioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in DirEnvioCAD.", ex);
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
                DirEnvioEN dirEnvioEN = (DirEnvioEN)session.Load (typeof(DirEnvioEN), id);
                session.Delete (dirEnvioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in DirEnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: MuestraDireccionPorOID
//Con e: DirEnvioEN
public DirEnvioEN MuestraDireccionPorOID (int id
                                          )
{
        DirEnvioEN dirEnvioEN = null;

        try
        {
                SessionInitializeTransaction ();
                dirEnvioEN = (DirEnvioEN)session.Get (typeof(DirEnvioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in DirEnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return dirEnvioEN;
}

public System.Collections.Generic.IList<DirEnvioEN> MuestraDirecciones (int first, int size)
{
        System.Collections.Generic.IList<DirEnvioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DirEnvioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DirEnvioEN>();
                else
                        result = session.CreateCriteria (typeof(DirEnvioEN)).List<DirEnvioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in DirEnvioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
