
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BaseDatosGenNHibernate.Exceptions;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;


/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CEN.BaseDatos_Envio_cambioEnvio) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
public partial class EnvioCEN
{
public void CambioEnvio (int p_oid, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoEnvioEnum newEstado)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_Envio_cambioEnvio) ENABLED START*/

        // Write here your custom code...

        EnvioEN en = _IEnvioCAD.ReadOIDDefault (p_oid);

        en.Estado = newEstado;

        _IEnvioCAD.Modify (en);

        /*PROTECTED REGION END*/
}
}
}
