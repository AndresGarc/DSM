
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System.Collections.Generic;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;



/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CP.BaseDatos_Usuario_realizarValoracion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CP.BaseDatos
{
public partial class UsuarioCP : BasicCP
{
public void RealizarValoracion (int p_usuario, int p_producto, double p_valor)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CP.BaseDatos_Usuario_realizarValoracion) ENABLED START*/

        try
        {
                SessionInitializeTransaction ();

                ProductoCAD prodCAD = new ProductoCAD (session);
                ValoracionCAD valoracionCAD = new ValoracionCAD (session);

                ProductoCEN prodCEN = new ProductoCEN (prodCAD);
                ValoracionCEN valoracionCEN = new ValoracionCEN (valoracionCAD);

                valoracionCEN.New_ (p_valor, p_usuario, p_producto);

                ProductoEN productoEN = prodCEN.MuestraProductoPorOID (p_producto);

                double v_Media = 0;
                double v_Num = 0;
                double v_Total = 0;

                foreach (ValoracionEN valoracionEN in productoEN.Valoracion) {
                        v_Media += valoracionEN.Valor;
                        v_Num++;
                }

                v_Total = v_Media / v_Num;

                productoEN.ValoracionMedia = v_Total;
                prodCAD.Modify (productoEN);

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
