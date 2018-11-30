
using System;
using TupadreGenNHibernate.EN.Tupadre;

namespace TupadreGenNHibernate.CAD.Tupadre
{
public partial interface IPadreCAD
{
PadreEN ReadOIDDefault (int nombre
                        );

void ModifyDefault (PadreEN padre);

System.Collections.Generic.IList<PadreEN> ReadAllDefault (int first, int size);



int New_ (PadreEN padre);

void Modify (PadreEN padre);


void Destroy (int nombre
              );
}
}
