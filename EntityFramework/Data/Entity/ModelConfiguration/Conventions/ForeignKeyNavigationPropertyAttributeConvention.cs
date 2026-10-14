using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001AB RID: 427
	public class ForeignKeyNavigationPropertyAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001779 RID: 6009 RVA: 0x0003E5E0 File Offset: 0x0003C7E0
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType association = item.Association;
			if (association.Constraint != null)
			{
				return;
			}
			global::System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute foreignKeyAttribute = item.GetClrAttributes<global::System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute>().SingleOrDefault<global::System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute>();
			if (foreignKeyAttribute == null)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2;
			if (association.TryGuessPrincipalAndDependentEnds(out associationEndMember, out associationEndMember2) || association.IsPrincipalConfigured())
			{
				associationEndMember2 = (associationEndMember2 ?? association.TargetEnd);
				associationEndMember = (associationEndMember ?? association.SourceEnd);
				global::System.Collections.Generic.IEnumerable<string> dependentPropertyNames = from p in foreignKeyAttribute.Name.Split(new char[]
				{
					','
				})
				select p.Trim();
				global::System.Data.Entity.Core.Metadata.Edm.EntityType declaringEntityType = model.ConceptualModel.EntityTypes.Single((global::System.Data.Entity.Core.Metadata.Edm.EntityType e) => e.DeclaredNavigationProperties.Contains(item));
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> toProperties = global::System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyNavigationPropertyAttributeConvention.GetDependentProperties(associationEndMember2.GetEntityType(), dependentPropertyNames, declaringEntityType, item).ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint = new global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint(associationEndMember, associationEndMember2, associationEndMember.GetEntityType().KeyProperties().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), toProperties);
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> source = associationEndMember2.GetEntityType().KeyProperties();
				if (source.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() == constraint.ToProperties.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() && source.All((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty kp) => constraint.ToProperties.Contains(kp)))
				{
					associationEndMember.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
					if (associationEndMember2.RelationshipMultiplicity.IsMany())
					{
						associationEndMember2.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne;
					}
				}
				if (associationEndMember.IsRequired())
				{
					constraint.ToProperties.Each((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Nullable = false);
				}
				association.Constraint = constraint;
			}
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0003E7B1 File Offset: 0x0003C9B1
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetDependentProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentType, global::System.Collections.Generic.IEnumerable<string> dependentPropertyNames, global::System.Data.Entity.Core.Metadata.Edm.EntityType declaringEntityType, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty)
		{
			using (global::System.Collections.Generic.IEnumerator<string> enumerator = dependentPropertyNames.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string dependentPropertyName = enumerator.Current;
					if (string.IsNullOrWhiteSpace(dependentPropertyName))
					{
						throw global::System.Data.Entity.Resources.Error.ForeignKeyAttributeConvention_EmptyKey(navigationProperty.Name, declaringEntityType.GetClrType());
					}
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = dependentType.Properties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Name.Equals(dependentPropertyName, global::System.StringComparison.Ordinal));
					if (edmProperty == null)
					{
						throw global::System.Data.Entity.Resources.Error.ForeignKeyAttributeConvention_InvalidKey(navigationProperty.Name, declaringEntityType.GetClrType(), dependentPropertyName, dependentType.GetClrType());
					}
					yield return edmProperty;
				}
			}
			global::System.Collections.Generic.IEnumerator<string> enumerator = null;
			yield break;
			yield break;
		}
	}
}
