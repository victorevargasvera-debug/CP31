using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001B0 RID: 432
	public class OneToOneConstraintIntroductionConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001786 RID: 6022 RVA: 0x0003EA4C File Offset: 0x0003CC4C
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			if (item.IsOneToOne() && !item.IsSelfReferencing() && !item.IsIndependent() && item.Constraint == null)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> source = item.SourceEnd.GetEntityType().KeyProperties();
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> source2 = item.TargetEnd.GetEntityType().KeyProperties();
				if (source.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() == source2.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2;
					if ((from p in source
					select p.UnderlyingPrimitiveType).SequenceEqual(from p in source2
					select p.UnderlyingPrimitiveType) && (item.TryGuessPrincipalAndDependentEnds(out associationEndMember, out associationEndMember2) || item.IsPrincipalConfigured()))
					{
						associationEndMember2 = (associationEndMember2 ?? item.TargetEnd);
						global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherEnd = item.GetOtherEnd(associationEndMember2);
						global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint = new global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint(otherEnd, associationEndMember2, otherEnd.GetEntityType().KeyProperties().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), associationEndMember2.GetEntityType().KeyProperties().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
						item.Constraint = constraint;
					}
				}
			}
		}
	}
}
