
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using EjemploViernesGenNHibernate.Exceptions;
using EjemploViernesGenNHibernate.EN.EjemploViernes;
using EjemploViernesGenNHibernate.CAD.EjemploViernes;
using EjemploViernesGenNHibernate.CEN.EjemploViernes;



namespace EjemploViernesGenNHibernate.CP.EjemploViernes
{
public partial class ClienteCP : BasicCP
{
public ClienteCP() : base ()
{
}

public ClienteCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
