
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using SuperPetGenNHibernate.Exceptions;
using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.CAD.BaseDatos;
using SuperPetGenNHibernate.CEN.BaseDatos;



namespace SuperPetGenNHibernate.CP.BaseDatos
{
public partial class EnvioCP : BasicCP
{
public EnvioCP() : base ()
{
}

public EnvioCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
