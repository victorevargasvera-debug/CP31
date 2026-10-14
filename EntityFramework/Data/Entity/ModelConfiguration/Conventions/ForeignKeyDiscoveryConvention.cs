using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001AA RID: 426
	public abstract class ForeignKeyDiscoveryConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x0003E3AE File Offset: 0x0003C5AE
		protected virtual bool SupportsMultipleAssociations
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001776 RID: 6006
		protected abstract bool MatchDependentKeyProperty(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentAssociationEnd, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty dependentProperty, global::System.Data.Entity.Core.Metadata.Edm.EntityType principalEntityType, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty principalKeyProperty);

		// Token: 0x06001777 RID: 6007 RVA: 0x0003E3B4 File Offset: 0x0003C5B4
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			if (item.Constraint != null || item.IsIndependent() || (item.IsOneToOne() && item.IsSelfReferencing()))
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentEnd;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember principalEnd;
			if (!item.TryGuessPrincipalAndDependentEnds(out principalEnd, out dependentEnd))
			{
				return;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> source = principalEnd.GetEntityType().KeyProperties();
			if (!source.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				return;
			}
			if (!this.SupportsMultipleAssociations && model.ConceptualModel.GetAssociationTypesBetween(principalEnd.GetEntityType(), dependentEnd.GetEntityType()).Count<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>() > 1)
			{
				return;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerable = from p in source
			from d in dependentEnd.GetEntityType().DeclaredProperties
			where this.MatchDependentKeyProperty(item, dependentEnd, d, principalEnd.GetEntityType(), p) && p.UnderlyingPrimitiveType == d.UnderlyingPrimitiveType
			select d;
			if (!enumerable.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() || enumerable.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() != source.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				return;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> source2 = dependentEnd.GetEntityType().KeyProperties();
			bool flag = source2.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() == enumerable.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() && source2.All(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool>(enumerable.Contains<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>));
			if ((dependentEnd.IsMany() || item.IsSelfReferencing()) && flag)
			{
				return;
			}
			if (!dependentEnd.IsMany() && !flag)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = new global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint(principalEnd, dependentEnd, source.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), enumerable.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
			item.Constraint = referentialConstraint;
			if (principalEnd.IsRequired())
			{
				referentialConstraint.ToProperties.Each((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Nullable = false);
			}
		}
	}
}
