
using System;
using TupadreGenNHibernate.EN.Tupadre;

namespace TupadreGenNHibernate.CAD.Tupadre
{
public partial interface IMadreCAD
{
MadreEN ReadOIDDefault (int nombre
                        );

void ModifyDefault (MadreEN madre);

System.Collections.Generic.IList<MadreEN> ReadAllDefault (int first, int size);



int New_ (MadreEN madre);

void Modify (MadreEN madre);


void Destroy (int nombre
              );
}
}
