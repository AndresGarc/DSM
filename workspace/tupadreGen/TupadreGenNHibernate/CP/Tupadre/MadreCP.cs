
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using TupadreGenNHibernate.Exceptions;
using TupadreGenNHibernate.EN.Tupadre;
using TupadreGenNHibernate.CAD.Tupadre;
using TupadreGenNHibernate.CEN.Tupadre;



namespace TupadreGenNHibernate.CP.Tupadre
{
public partial class MadreCP : BasicCP
{
public MadreCP() : base ()
{
}

public MadreCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
