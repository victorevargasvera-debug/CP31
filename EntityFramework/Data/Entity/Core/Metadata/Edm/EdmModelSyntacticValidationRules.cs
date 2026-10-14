using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004AD RID: 1197
	internal static class EdmModelSyntacticValidationRules
	{
		// Token: 0x06003AF7 RID: 15095 RVA: 0x000C1F94 File Offset: 0x000C0194
		private static bool IsEdmTypeUsageValid(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> visitedValidTypeUsages = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();
			return global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.IsEdmTypeUsageValid(typeUsage, visitedValidTypeUsages);
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x000C1FAE File Offset: 0x000C01AE
		private static bool IsEdmTypeUsageValid(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> visitedValidTypeUsages)
		{
			if (visitedValidTypeUsages.Contains(typeUsage))
			{
				return false;
			}
			visitedValidTypeUsages.Add(typeUsage);
			return true;
		}

		// Token: 0x04001462 RID: 5218
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem> EdmModel_NameMustNotBeEmptyOrWhiteSpace = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem item)
		{
			if (string.IsNullOrWhiteSpace(item.Name))
			{
				context.AddError((global::System.Data.Entity.Core.Metadata.Edm.MetadataItem)item, "Name", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_MissingName);
			}
		});

		// Token: 0x04001463 RID: 5219
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem> EdmModel_NameIsTooLong = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem item)
		{
			if (!string.IsNullOrWhiteSpace(item.Name) && item.Name.Length > 480 && !(item is global::System.Data.Entity.Core.Metadata.Edm.RowType) && !(item is global::System.Data.Entity.Core.Metadata.Edm.CollectionType))
			{
				context.AddError((global::System.Data.Entity.Core.Metadata.Edm.MetadataItem)item, "Name", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmModel_NameIsTooLong(item.Name));
			}
		});

		// Token: 0x04001464 RID: 5220
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem> EdmModel_NameIsNotAllowed = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem item)
		{
			if (string.IsNullOrWhiteSpace(item.Name) || item is global::System.Data.Entity.Core.Metadata.Edm.RowType || item is global::System.Data.Entity.Core.Metadata.Edm.CollectionType || (!context.IsCSpace && item is global::System.Data.Entity.Core.Metadata.Edm.EdmProperty))
			{
				return;
			}
			if (item.Name.Contains(".") || (context.IsCSpace && !item.Name.IsValidUndottedName()))
			{
				context.AddError((global::System.Data.Entity.Core.Metadata.Edm.MetadataItem)item, "Name", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmModel_NameIsNotAllowed(item.Name));
			}
		});

		// Token: 0x04001465 RID: 5221
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> EdmAssociationType_AssociationEndMustNotBeNull = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationType edmAssociationType)
		{
			if (edmAssociationType.SourceEnd == null || edmAssociationType.TargetEnd == null)
			{
				context.AddError(edmAssociationType, "End", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmAssociationType_AssociationEndMustNotBeNull);
			}
		});

		// Token: 0x04001466 RID: 5222
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> EdmAssociationConstraint_DependentEndMustNotBeNull = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint edmAssociationConstraint)
		{
			if (edmAssociationConstraint.ToRole == null)
			{
				context.AddError(edmAssociationConstraint, "Dependent", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentEndMustNotBeNull);
			}
		});

		// Token: 0x04001467 RID: 5223
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> EdmAssociationConstraint_DependentPropertiesMustNotBeEmpty = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint edmAssociationConstraint)
		{
			if (edmAssociationConstraint.ToProperties == null || !edmAssociationConstraint.ToProperties.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				context.AddError(edmAssociationConstraint, "Dependent", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmAssociationConstraint_DependentPropertiesMustNotBeEmpty);
			}
		});

		// Token: 0x04001468 RID: 5224
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> EdmNavigationProperty_AssociationMustNotBeNull = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty edmNavigationProperty)
		{
			if (edmNavigationProperty.Association == null)
			{
				context.AddError(edmNavigationProperty, "Relationship", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmNavigationProperty_AssociationMustNotBeNull);
			}
		});

		// Token: 0x04001469 RID: 5225
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> EdmNavigationProperty_ResultEndMustNotBeNull = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty edmNavigationProperty)
		{
			if (edmNavigationProperty.ToEndMember == null)
			{
				context.AddError(edmNavigationProperty, "ToRole", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmNavigationProperty_ResultEndMustNotBeNull);
			}
		});

		// Token: 0x0400146A RID: 5226
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> EdmAssociationEnd_EntityTypeMustNotBeNull = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember edmAssociationEnd)
		{
			if (edmAssociationEnd.GetEntityType() == null)
			{
				context.AddError(edmAssociationEnd, "Type", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmAssociationEnd_EntityTypeMustNotBeNull);
			}
		});

		// Token: 0x0400146B RID: 5227
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> EdmEntitySet_ElementTypeMustNotBeNull = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet edmEntitySet)
		{
			if (edmEntitySet.ElementType == null)
			{
				context.AddError(edmEntitySet, "ElementType", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmEntitySet_ElementTypeMustNotBeNull);
			}
		});

		// Token: 0x0400146C RID: 5228
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> EdmAssociationSet_ElementTypeMustNotBeNull = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet edmAssociationSet)
		{
			if (edmAssociationSet.ElementType == null)
			{
				context.AddError(edmAssociationSet, "ElementType", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmAssociationSet_ElementTypeMustNotBeNull);
			}
		});

		// Token: 0x0400146D RID: 5229
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> EdmAssociationSet_SourceSetMustNotBeNull = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet edmAssociationSet)
		{
			if (context.IsCSpace && edmAssociationSet.SourceSet == null)
			{
				context.AddError(edmAssociationSet, "FromRole", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmAssociationSet_SourceSetMustNotBeNull);
			}
		});

		// Token: 0x0400146E RID: 5230
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> EdmAssociationSet_TargetSetMustNotBeNull = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet edmAssociationSet)
		{
			if (context.IsCSpace && edmAssociationSet.TargetSet == null)
			{
				context.AddError(edmAssociationSet, "ToRole", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmAssociationSet_TargetSetMustNotBeNull);
			}
		});

		// Token: 0x0400146F RID: 5231
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> EdmTypeReference_TypeNotValid = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmTypeReference)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.IsEdmTypeUsageValid(edmTypeReference))
			{
				context.AddError(edmTypeReference, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Syntactic_EdmTypeReferenceNotValid);
			}
		});
	}
}
