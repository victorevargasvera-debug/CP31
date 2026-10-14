using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004AB RID: 1195
	internal abstract class EdmModelRuleSet : global::System.Data.Entity.Core.Metadata.Edm.DataModelValidationRuleSet
	{
		// Token: 0x06003AE8 RID: 15080 RVA: 0x000C1554 File Offset: 0x000BF754
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet CreateEdmModelRuleSet(double version, bool validateSyntax)
		{
			if (object.Equals(version, 1.0))
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet.V1RuleSet(validateSyntax);
			}
			if (object.Equals(version, 1.1))
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet.V1_1RuleSet(validateSyntax);
			}
			if (object.Equals(version, 2.0))
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet.V2RuleSet(validateSyntax);
			}
			if (object.Equals(version, 3.0))
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet.V3RuleSet(validateSyntax);
			}
			return null;
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x000C15EC File Offset: 0x000BF7EC
		private EdmModelRuleSet(bool validateSyntax)
		{
			if (validateSyntax)
			{
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmAssociationConstraint_DependentEndMustNotBeNull);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmAssociationConstraint_DependentPropertiesMustNotBeEmpty);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmAssociationEnd_EntityTypeMustNotBeNull);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmAssociationSet_ElementTypeMustNotBeNull);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmAssociationSet_SourceSetMustNotBeNull);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmAssociationSet_TargetSetMustNotBeNull);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmAssociationType_AssociationEndMustNotBeNull);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmEntitySet_ElementTypeMustNotBeNull);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmModel_NameMustNotBeEmptyOrWhiteSpace);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmModel_NameIsTooLong);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmModel_NameIsNotAllowed);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmNavigationProperty_AssociationMustNotBeNull);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmNavigationProperty_ResultEndMustNotBeNull);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSyntacticValidationRules.EdmTypeReference_TypeNotValid);
			}
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmType_SystemNamespaceEncountered);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityContainer_SimilarRelationshipEnd);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityContainer_InvalidEntitySetNameReference);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityContainer_ConcurrencyRedefinedOnSubTypeOfEntitySetType);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityContainer_DuplicateEntityContainerMemberName);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityContainer_DuplicateEntitySetTable);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntitySet_EntitySetTypeHasNoKeys);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmAssociationSet_DuplicateEndName);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityType_EntityKeyMustBeScalar);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityType_DuplicatePropertyNameSpecifiedInEntityKey);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityType_InvalidKeyNullablePart);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityType_InvalidKeyKeyDefinedInBaseClass);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityType_KeyMissingOnEntityType);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityType_InvalidMemberNameMatchesTypeName);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityType_PropertyNameAlreadyDefinedDuplicate);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmEntityType_CycleInTypeHierarchy);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmNavigationProperty_BadNavigationPropertyUndefinedRole);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmNavigationProperty_BadNavigationPropertyRolesCannotBeTheSame);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmNavigationProperty_BadNavigationPropertyBadFromRoleType);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmAssociationType_InvalidOperationMultipleEndsInAssociation);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmAssociationType_EndWithManyMultiplicityCannotHaveOperationsSpecified);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmAssociationType_EndNameAlreadyDefinedDuplicate);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmAssociationType_InvalidPropertyInRelationshipConstraint);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmAssociationType_SameRoleReferredInReferentialConstraint);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmAssociationType_ValidateReferentialConstraint);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmComplexType_InvalidMemberNameMatchesTypeName);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmNamespace_TypeNameAlreadyDefinedDuplicate);
			base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmFunction_DuplicateParameterName);
		}

		// Token: 0x02000AD4 RID: 2772
		private abstract class NonV1_1RuleSet : global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet
		{
			// Token: 0x0600635E RID: 25438 RVA: 0x0015743C File Offset: 0x0015563C
			protected NonV1_1RuleSet(bool validateSyntax) : base(validateSyntax)
			{
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmProperty_NullableComplexType);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmProperty_InvalidCollectionKind);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmComplexType_PropertyNameAlreadyDefinedDuplicate);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmComplexType_InvalidIsAbstract);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmComplexType_InvalidIsPolymorphic);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmFunction_ComposableFunctionImportsNotAllowed_V1_V2);
			}
		}

		// Token: 0x02000AD5 RID: 2773
		private sealed class V1RuleSet : global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet.NonV1_1RuleSet
		{
			// Token: 0x0600635F RID: 25439 RVA: 0x00157492 File Offset: 0x00155692
			internal V1RuleSet(bool validateSyntax) : base(validateSyntax)
			{
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmProperty_InvalidPropertyType);
			}
		}

		// Token: 0x02000AD6 RID: 2774
		private sealed class V1_1RuleSet : global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet
		{
			// Token: 0x06006360 RID: 25440 RVA: 0x001574A6 File Offset: 0x001556A6
			internal V1_1RuleSet(bool validateSyntax) : base(validateSyntax)
			{
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmComplexType_PropertyNameAlreadyDefinedDuplicate_V1_1);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmComplexType_CycleInTypeHierarchy_V1_1);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmProperty_InvalidCollectionKind_V1_1);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmProperty_InvalidPropertyType_V1_1);
			}
		}

		// Token: 0x02000AD7 RID: 2775
		private class V2RuleSet : global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet.NonV1_1RuleSet
		{
			// Token: 0x06006361 RID: 25441 RVA: 0x001574DB File Offset: 0x001556DB
			internal V2RuleSet(bool validateSyntax) : base(validateSyntax)
			{
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmProperty_InvalidPropertyType);
			}
		}

		// Token: 0x02000AD8 RID: 2776
		private sealed class V3RuleSet : global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet.V2RuleSet
		{
			// Token: 0x06006362 RID: 25442 RVA: 0x001574EF File Offset: 0x001556EF
			internal V3RuleSet(bool validateSyntax) : base(validateSyntax)
			{
				base.RemoveRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmProperty_InvalidPropertyType);
				base.AddRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmProperty_InvalidPropertyType_V3);
				base.RemoveRule(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.EdmFunction_ComposableFunctionImportsNotAllowed_V1_V2);
			}
		}
	}
}
