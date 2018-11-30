
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using EjemploViernesGenNHibernate.Exceptions;
using EjemploViernesGenNHibernate.EN.EjemploViernes;
using EjemploViernesGenNHibernate.CAD.EjemploViernes;


/*PROTECTED REGION ID(usingEjemploViernesGenNHibernate.CEN.EjemploViernes_Pedido_enviar) ENABLED START*/
//  references to other libraries
using EjemploViernesGenNHibernate.Enumerated.EjemploViernes;
using EjemploViernesGenNHibernate.Exceptions;
/*PROTECTED REGION END*/

namespace EjemploViernesGenNHibernate.CEN.EjemploViernes
{
public partial class PedidoCEN
{
public void Enviar (int p_oid)
{
        /*PROTECTED REGION ID(EjemploViernesGenNHibernate.CEN.EjemploViernes_Pedido_enviar) ENABLED START*/

        PedidoEN en = _IPedidoCAD.ReadOIDDefault (p_oid);

        if (!(en.Estado == EstadoPEdidoEnum.pendiente))
                throw new ModelException ("El pedido debe estar pendiente para enviarlo");

        en.Estado = EstadoPEdidoEnum.enviado;

        _IPedidoCAD.ModifyDefault (en);

        /*PROTECTED REGION END*/
}
}
}
