
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
public partial class DirEnvioCP : BasicCP
{
public DirEnvioCP() : base ()
{
}

public DirEnvioCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
