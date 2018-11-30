
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.CAD.BaseDatos;
using SuperPetGenNHibernate.CEN.BaseDatos;



/*PROTECTED REGION ID(usingSuperPetGenNHibernate.CP.BaseDatos_Factura_crearFactura) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace SuperPetGenNHibernate.CP.BaseDatos
{
public partial class FacturaCP : BasicCP
{
public void CrearFactura (int p_oid)
{
        /*PROTECTED REGION ID(SuperPetGenNHibernate.CP.BaseDatos_Factura_crearFactura) ENABLED START*/

        IFacturaCAD facturaCAD = null;
        FacturaCEN facturaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                facturaCAD = new FacturaCAD (session);
                facturaCEN = new  FacturaCEN (facturaCAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method CrearFactura() not yet implemented.");



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
