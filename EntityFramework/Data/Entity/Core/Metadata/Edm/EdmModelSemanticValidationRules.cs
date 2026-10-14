using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004AC RID: 1196
	internal static class EdmModelSemanticValidationRules
	{
		// Token: 0x06003AEA RID: 15082 RVA: 0x000C17D3 File Offset: 0x000BF9D3
		private static string GetQualifiedName(global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem item, string qualifiedPrefix)
		{
			return qualifiedPrefix + "." + item.Name;
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x000C17E6 File Offset: 0x000BF9E6
		private static bool AreRelationshipEndsEqual(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> left, global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> right)
		{
			return left.Value == right.Value && left.Key.ElementType == right.Key.ElementType;
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x000C1818 File Offset: 0x000BFA18
		private static bool IsReferentialConstraintReadyForValidation(global::System.Data.Entity.Core.Metadata.Edm.AssociationType association)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint = association.Constraint;
			if (constraint == null)
			{
				return false;
			}
			if (constraint.FromRole == null || constraint.ToRole == null)
			{
				return false;
			}
			if (constraint.FromRole.GetEntityType() == null || constraint.ToRole.GetEntityType() == null)
			{
				return false;
			}
			if (constraint.ToProperties.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator = constraint.ToProperties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = enumerator.Current;
						if (edmProperty == null)
						{
							return false;
						}
						if (edmProperty.TypeUsage == null || edmProperty.TypeUsage.EdmType == null)
						{
							return false;
						}
					}
					goto IL_9A;
				}
				return false;
				IL_9A:
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> validKey = constraint.FromRole.GetEntityType().GetValidKey();
				if (validKey.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
				{
					return validKey.All((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propRef) => propRef != null && propRef.TypeUsage != null && propRef.TypeUsage.EdmType != null);
				}
				return false;
			}
			return false;
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x000C1914 File Offset: 0x000BFB14
		private static void IsKeyProperty(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> roleProperties, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember roleElement, out bool isKeyProperty, out bool areAllPropertiesNullable, out bool isAnyPropertyNullable, out bool isSubsetOfKeyProperties)
		{
			isKeyProperty = true;
			areAllPropertiesNullable = true;
			isAnyPropertyNullable = false;
			isSubsetOfKeyProperties = true;
			if (roleElement.GetEntityType().GetValidKey().Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() != roleProperties.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				isKeyProperty = false;
			}
			for (int i = 0; i < roleProperties.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(); i++)
			{
				if (isSubsetOfKeyProperties && !roleElement.GetEntityType().GetValidKey().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>().Contains(roleProperties[i]))
				{
					isKeyProperty = false;
					isSubsetOfKeyProperties = false;
				}
				bool nullable = roleProperties[i].Nullable;
				areAllPropertiesNullable = (areAllPropertiesNullable && nullable);
				isAnyPropertyNullable = (isAnyPropertyNullable || nullable);
			}
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x000C19A0 File Offset: 0x000BFBA0
		private static void AddMemberNameToHashSet(global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem item, global::System.Collections.Generic.HashSet<string> memberNameList, global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Func<string, string> getErrorString)
		{
			if (!string.IsNullOrWhiteSpace(item.Name) && !memberNameList.Add(item.Name))
			{
				context.AddError((global::System.Data.Entity.Core.Metadata.Edm.MetadataItem)item, "Name", getErrorString(item.Name));
			}
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x000C19DC File Offset: 0x000BFBDC
		private static bool CheckForInheritanceCycle<T>(T type, global::System.Func<T, T> getBaseType) where T : class
		{
			T t = getBaseType(type);
			if (t != null)
			{
				T t2 = t;
				T t3 = t;
				for (;;)
				{
					t3 = getBaseType(t3);
					if (t2 == t3)
					{
						break;
					}
					if (t2 == null)
					{
						return false;
					}
					t2 = getBaseType(t2);
					if (t3 != null)
					{
						t3 = getBaseType(t3);
					}
					if (t3 == null)
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x000C1A40 File Offset: 0x000BFC40
		private static bool IsPrimitiveTypesEqual(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty primitiveType1, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty primitiveType2)
		{
			return primitiveType1.PrimitiveType.PrimitiveTypeKind == primitiveType2.PrimitiveType.PrimitiveTypeKind;
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x000C1A5A File Offset: 0x000BFC5A
		private static bool IsEdmSystemNamespace(string namespaceName)
		{
			return namespaceName == "Transient" || namespaceName == "Edm" || namespaceName == "System";
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x000C1A84 File Offset: 0x000BFC84
		private static bool IsTypeDefinesNewConcurrencyProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return (from property in entityType.DeclaredProperties
			where property.TypeUsage != null
			select property).Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property) => property.PrimitiveType != null && property.ConcurrencyMode > global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.None);
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x000C1AE0 File Offset: 0x000BFCE0
		private static bool TypeIsSubTypeOf(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> baseEntitySetTypes, out global::System.Data.Entity.Core.Metadata.Edm.EntitySet set)
		{
			if (entityType.IsTypeHierarchyRoot())
			{
				set = null;
				return false;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType key in entityType.ToHierarchy())
			{
				if (baseEntitySetTypes.ContainsKey(key))
				{
					set = baseEntitySetTypes[key];
					return true;
				}
			}
			set = null;
			return false;
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x000C1B50 File Offset: 0x000BFD50
		private static bool IsTypeHierarchyRoot(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return entityType.BaseType == null;
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x000C1B5B File Offset: 0x000BFD5B
		private static bool IsForeignKey(this global::System.Data.Entity.Core.Metadata.Edm.AssociationType association, double version)
		{
			return version >= 2.0 && association.Constraint != null;
		}

		// Token: 0x0400143A RID: 5178
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> EdmFunction_ComposableFunctionImportsNotAllowed_V1_V2 = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			if (function.IsFunctionImport && function.IsComposableAttribute)
			{
				context.AddError(function, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_ComposableFunctionImportsNotSupportedForSchemaVersion);
			}
		});

		// Token: 0x0400143B RID: 5179
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> EdmFunction_DuplicateParameterName = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			global::System.Collections.Generic.HashSet<string> memberNameList = new global::System.Collections.Generic.HashSet<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in function.Parameters)
			{
				if (functionParameter != null && !string.IsNullOrWhiteSpace(functionParameter.Name))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.AddMemberNameToHashSet(functionParameter, memberNameList, context, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.ParameterNameAlreadyDefinedDuplicate));
				}
			}
		});

		// Token: 0x0400143C RID: 5180
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmType> EdmType_SystemNamespaceEncountered = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.IsEdmSystemNamespace(edmType.NamespaceName) && edmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType && edmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType && edmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
			{
				context.AddError(edmType, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_SystemNamespaceEncountered(edmType.Name));
			}
		});

		// Token: 0x0400143D RID: 5181
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> EdmEntityContainer_SimilarRelationshipEnd = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer edmEntityContainer)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in edmEntityContainer.AssociationSets)
			{
				global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> sourceEnd = new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(associationSet, associationSet.SourceSet);
				global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> targetEnd = new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(associationSet, associationSet.TargetSet);
				global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> keyValuePair = list.FirstOrDefault((global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> e) => global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.AreRelationshipEndsEqual(e, sourceEnd));
				global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> keyValuePair2 = list2.FirstOrDefault((global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> e) => global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.AreRelationshipEndsEqual(e, targetEnd));
				if (!keyValuePair.Equals(default(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>)))
				{
					context.AddError(edmEntityContainer, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_SimilarRelationshipEnd(keyValuePair.Key.ElementType.SourceEnd.Name, keyValuePair.Key.Name, associationSet.Name, keyValuePair.Value.Name, edmEntityContainer.Name));
				}
				else
				{
					list.Add(sourceEnd);
				}
				if (!keyValuePair2.Equals(default(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>)))
				{
					context.AddError(edmEntityContainer, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_SimilarRelationshipEnd(keyValuePair2.Key.ElementType.TargetEnd.Name, keyValuePair2.Key.Name, associationSet.Name, keyValuePair2.Value.Name, edmEntityContainer.Name));
				}
				else
				{
					list2.Add(targetEnd);
				}
			}
		});

		// Token: 0x0400143E RID: 5182
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> EdmEntityContainer_InvalidEntitySetNameReference = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer edmEntityContainer)
		{
			if (edmEntityContainer.AssociationSets != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in edmEntityContainer.AssociationSets)
				{
					if (associationSet.SourceSet != null && associationSet.ElementType != null && associationSet.ElementType.SourceEnd != null && !edmEntityContainer.EntitySets.Contains(associationSet.SourceSet))
					{
						context.AddError(associationSet.SourceSet, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidEntitySetNameReference(associationSet.SourceSet.Name, associationSet.ElementType.SourceEnd.Name));
					}
					if (associationSet.TargetSet != null && associationSet.ElementType != null && associationSet.ElementType.TargetEnd != null && !edmEntityContainer.EntitySets.Contains(associationSet.TargetSet))
					{
						context.AddError(associationSet.TargetSet, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidEntitySetNameReference(associationSet.TargetSet.Name, associationSet.ElementType.TargetEnd.Name));
					}
				}
			}
		});

		// Token: 0x0400143F RID: 5183
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> EdmEntityContainer_ConcurrencyRedefinedOnSubTypeOfEntitySetType = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer edmEntityContainer)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in edmEntityContainer.EntitySets)
			{
				if (entitySet != null && entitySet.ElementType != null && !dictionary.ContainsKey(entitySet.ElementType))
				{
					dictionary.Add(entitySet.ElementType, entitySet);
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in context.Model.EntityTypes)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2;
				if (global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.TypeIsSubTypeOf(entityType, dictionary, out entitySet2) && global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.IsTypeDefinesNewConcurrencyProperties(entityType))
				{
					context.AddError(entityType, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_ConcurrencyRedefinedOnSubTypeOfEntitySetType(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(entityType, entityType.NamespaceName), global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(entitySet2.ElementType, entitySet2.ElementType.NamespaceName), global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(entitySet2, entitySet2.EntityContainer.Name)));
				}
			}
		});

		// Token: 0x04001440 RID: 5184
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> EdmEntityContainer_DuplicateEntityContainerMemberName = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer edmEntityContainer)
		{
			global::System.Collections.Generic.HashSet<string> memberNameList = new global::System.Collections.Generic.HashSet<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase item in edmEntityContainer.BaseEntitySets)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.AddMemberNameToHashSet(item, memberNameList, context, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_DuplicateEntityContainerMemberName));
			}
		});

		// Token: 0x04001441 RID: 5185
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> EdmEntityContainer_DuplicateEntitySetTable = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer edmEntityContainer)
		{
			global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in edmEntityContainer.BaseEntitySets)
			{
				if (!string.IsNullOrWhiteSpace(entitySetBase.Table) && !hashSet.Add(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
				{
					entitySetBase.Schema,
					entitySetBase.Table
				})))
				{
					context.AddError(entitySetBase, "Name", global::System.Data.Entity.Resources.Strings.DuplicateEntitySetTable(entitySetBase.Name, entitySetBase.Schema, entitySetBase.Table));
				}
			}
		});

		// Token: 0x04001442 RID: 5186
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> EdmEntitySet_EntitySetTypeHasNoKeys = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntitySet edmEntitySet)
		{
			if (edmEntitySet.ElementType != null && !edmEntitySet.ElementType.GetValidKey().Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				context.AddError(edmEntitySet, "EntityType", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_EntitySetTypeHasNoKeys(edmEntitySet.Name, edmEntitySet.ElementType.Name));
			}
		});

		// Token: 0x04001443 RID: 5187
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> EdmAssociationSet_DuplicateEndName = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet edmAssociationSet)
		{
			if (edmAssociationSet.ElementType != null && edmAssociationSet.ElementType.SourceEnd != null && edmAssociationSet.ElementType.TargetEnd != null && edmAssociationSet.ElementType.SourceEnd.Name == edmAssociationSet.ElementType.TargetEnd.Name)
			{
				context.AddError(edmAssociationSet.SourceSet, "Name", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_DuplicateEndName(edmAssociationSet.ElementType.SourceEnd.Name));
			}
		});

		// Token: 0x04001444 RID: 5188
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EdmEntityType_DuplicatePropertyNameSpecifiedInEntityKey = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType edmEntityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = edmEntityType.GetKeyProperties().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			if (list.Count > 0)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty key = enumerator.Current;
						if (key != null && !list2.Contains(key))
						{
							if (list.Count((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => key.Equals(p)) > 1)
							{
								context.AddError(key, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_DuplicatePropertyNameSpecifiedInEntityKey(edmEntityType.Name, key.Name));
							}
							list2.Add(key);
						}
					}
				}
			}
		});

		// Token: 0x04001445 RID: 5189
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EdmEntityType_InvalidKeyNullablePart = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType edmEntityType)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in edmEntityType.GetValidKey())
			{
				if (edmProperty.IsPrimitiveType && edmProperty.Nullable)
				{
					context.AddError(edmProperty, "Nullable", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidKeyNullablePart(edmProperty.Name, edmEntityType.Name));
				}
			}
		});

		// Token: 0x04001446 RID: 5190
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EdmEntityType_EntityKeyMustBeScalar = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType edmEntityType)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in edmEntityType.GetValidKey())
			{
				if (!edmProperty.IsUnderlyingPrimitiveType)
				{
					context.AddError(edmProperty, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_EntityKeyMustBeScalar(edmEntityType.Name, edmProperty.Name));
				}
			}
		});

		// Token: 0x04001447 RID: 5191
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EdmEntityType_InvalidKeyKeyDefinedInBaseClass = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType edmEntityType)
		{
			if (edmEntityType.BaseType != null && (from key in edmEntityType.KeyProperties
			where edmEntityType.DeclaredMembers.Contains(key)
			select key).Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				context.AddError(edmEntityType.BaseType, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidKeyKeyDefinedInBaseClass(edmEntityType.Name, edmEntityType.BaseType.Name));
			}
		});

		// Token: 0x04001448 RID: 5192
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EdmEntityType_KeyMissingOnEntityType = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType edmEntityType)
		{
			if (edmEntityType.BaseType == null && edmEntityType.KeyProperties.Count == 0)
			{
				context.AddError(edmEntityType, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_KeyMissingOnEntityType(edmEntityType.Name));
			}
		});

		// Token: 0x04001449 RID: 5193
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EdmEntityType_InvalidMemberNameMatchesTypeName = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType edmEntityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = edmEntityType.Properties.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			if (!string.IsNullOrWhiteSpace(edmEntityType.Name) && list.Count > 0)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in list)
				{
					if (edmProperty != null && context.IsCSpace && edmProperty.Name.EqualsOrdinal(edmEntityType.Name))
					{
						context.AddError(edmProperty, "Name", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidMemberNameMatchesTypeName(edmProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(edmEntityType, edmEntityType.NamespaceName)));
					}
				}
				if (edmEntityType.DeclaredNavigationProperties.Any<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>())
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty in edmEntityType.DeclaredNavigationProperties)
					{
						if (navigationProperty != null && navigationProperty.Name.EqualsOrdinal(edmEntityType.Name))
						{
							context.AddError(navigationProperty, "Name", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidMemberNameMatchesTypeName(navigationProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(edmEntityType, edmEntityType.NamespaceName)));
						}
					}
				}
			}
		});

		// Token: 0x0400144A RID: 5194
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EdmEntityType_PropertyNameAlreadyDefinedDuplicate = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType edmEntityType)
		{
			global::System.Collections.Generic.HashSet<string> memberNameList = new global::System.Collections.Generic.HashSet<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in edmEntityType.Properties)
			{
				if (edmProperty != null && !string.IsNullOrWhiteSpace(edmProperty.Name))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.AddMemberNameToHashSet(edmProperty, memberNameList, context, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_PropertyNameAlreadyDefinedDuplicate));
				}
			}
			if (edmEntityType.DeclaredNavigationProperties.Any<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>())
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty in edmEntityType.DeclaredNavigationProperties)
				{
					if (navigationProperty != null && !string.IsNullOrWhiteSpace(navigationProperty.Name))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.AddMemberNameToHashSet(navigationProperty, memberNameList, context, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_PropertyNameAlreadyDefinedDuplicate));
					}
				}
			}
		});

		// Token: 0x0400144B RID: 5195
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EdmEntityType_CycleInTypeHierarchy = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EntityType edmEntityType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.CheckForInheritanceCycle<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(edmEntityType, (global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => (global::System.Data.Entity.Core.Metadata.Edm.EntityType)et.BaseType))
			{
				context.AddError(edmEntityType, "BaseType", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_CycleInTypeHierarchy(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(edmEntityType, edmEntityType.NamespaceName)));
			}
		});

		// Token: 0x0400144C RID: 5196
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> EdmNavigationProperty_BadNavigationPropertyUndefinedRole = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty edmNavigationProperty)
		{
			if (edmNavigationProperty.Association != null && edmNavigationProperty.Association.SourceEnd != null && edmNavigationProperty.Association.TargetEnd != null && edmNavigationProperty.Association.SourceEnd.Name != null && edmNavigationProperty.Association.TargetEnd.Name != null && edmNavigationProperty.ToEndMember != edmNavigationProperty.Association.SourceEnd && edmNavigationProperty.ToEndMember != edmNavigationProperty.Association.TargetEnd)
			{
				context.AddError(edmNavigationProperty, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_BadNavigationPropertyUndefinedRole(edmNavigationProperty.Association.SourceEnd.Name, edmNavigationProperty.Association.TargetEnd.Name, edmNavigationProperty.Association.Name));
			}
		});

		// Token: 0x0400144D RID: 5197
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> EdmNavigationProperty_BadNavigationPropertyRolesCannotBeTheSame = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty edmNavigationProperty)
		{
			if (edmNavigationProperty.Association != null && edmNavigationProperty.Association.SourceEnd != null && edmNavigationProperty.Association.TargetEnd != null && edmNavigationProperty.ToEndMember == edmNavigationProperty.GetFromEnd())
			{
				context.AddError(edmNavigationProperty, "ToRole", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_BadNavigationPropertyRolesCannotBeTheSame);
			}
		});

		// Token: 0x0400144E RID: 5198
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> EdmNavigationProperty_BadNavigationPropertyBadFromRoleType = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty edmNavigationProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember fromEnd;
			if (edmNavigationProperty.Association != null && (fromEnd = edmNavigationProperty.GetFromEnd()) != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = null;
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list = (context.Model.EntityTypes as global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>) ?? context.Model.EntityTypes.ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
				for (int i = 0; i < list.Count; i++)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = list[i];
					if (entityType2.DeclaredNavigationProperties.Contains(edmNavigationProperty))
					{
						entityType = entityType2;
						break;
					}
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType3 = fromEnd.GetEntityType();
				if (entityType != entityType3)
				{
					context.AddError(edmNavigationProperty, "FromRole", global::System.Data.Entity.Resources.Strings.BadNavigationPropertyBadFromRoleType(edmNavigationProperty.Name, entityType3.Name, fromEnd.Name, edmNavigationProperty.Association.Name, entityType.Name));
				}
			}
		});

		// Token: 0x0400144F RID: 5199
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> EdmAssociationType_InvalidOperationMultipleEndsInAssociation = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationType edmAssociationType)
		{
			if (edmAssociationType.SourceEnd != null && edmAssociationType.SourceEnd.DeleteBehavior != global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None && edmAssociationType.TargetEnd != null && edmAssociationType.TargetEnd.DeleteBehavior != global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None)
			{
				context.AddError(edmAssociationType, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidOperationMultipleEndsInAssociation);
			}
		});

		// Token: 0x04001450 RID: 5200
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> EdmAssociationType_EndWithManyMultiplicityCannotHaveOperationsSpecified = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationType edmAssociationType)
		{
			if (edmAssociationType.SourceEnd != null && edmAssociationType.SourceEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many && edmAssociationType.SourceEnd.DeleteBehavior != global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None)
			{
				context.AddError(edmAssociationType.SourceEnd, "OnDelete", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_EndWithManyMultiplicityCannotHaveOperationsSpecified(edmAssociationType.SourceEnd.Name, edmAssociationType.Name));
			}
			if (edmAssociationType.TargetEnd != null && edmAssociationType.TargetEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many && edmAssociationType.TargetEnd.DeleteBehavior != global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None)
			{
				context.AddError(edmAssociationType.TargetEnd, "OnDelete", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_EndWithManyMultiplicityCannotHaveOperationsSpecified(edmAssociationType.TargetEnd.Name, edmAssociationType.Name));
			}
		});

		// Token: 0x04001451 RID: 5201
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> EdmAssociationType_EndNameAlreadyDefinedDuplicate = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationType edmAssociationType)
		{
			if (edmAssociationType.SourceEnd != null && edmAssociationType.TargetEnd != null && edmAssociationType.SourceEnd.Name == edmAssociationType.TargetEnd.Name)
			{
				context.AddError(edmAssociationType.SourceEnd, "Name", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_EndNameAlreadyDefinedDuplicate(edmAssociationType.SourceEnd.Name));
			}
		});

		// Token: 0x04001452 RID: 5202
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> EdmAssociationType_SameRoleReferredInReferentialConstraint = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationType edmAssociationType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.IsReferentialConstraintReadyForValidation(edmAssociationType) && edmAssociationType.Constraint.FromRole.Name == edmAssociationType.Constraint.ToRole.Name)
			{
				context.AddError(edmAssociationType.Constraint.ToRole, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_SameRoleReferredInReferentialConstraint(edmAssociationType.Name));
			}
		});

		// Token: 0x04001453 RID: 5203
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> EdmAssociationType_ValidateReferentialConstraint = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationType edmAssociationType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.IsReferentialConstraintReadyForValidation(edmAssociationType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint = edmAssociationType.Constraint;
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromRole = constraint.FromRole;
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toRole = constraint.ToRole;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.IsKeyProperty(constraint.ToProperties.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), toRole, out flag, out flag2, out flag3, out flag4);
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.IsKeyProperty(constraint.FromRole.GetEntityType().GetValidKey().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(), fromRole, out flag5, out flag6, out flag7, out flag8);
				bool flag9 = context.Model.SchemaVersion <= 1.1;
				if (fromRole.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					context.AddError(fromRole, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleUpperBoundMustBeOne(fromRole.Name, edmAssociationType.Name));
				}
				else if (flag2 && fromRole.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
				{
					string errorMessage = global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNullableV1(fromRole.Name, edmAssociationType.Name);
					context.AddError(edmAssociationType, null, errorMessage);
				}
				else if (((flag9 && !flag2) || (!flag9 && !flag3)) && fromRole.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
				{
					string errorMessage2;
					if (flag9)
					{
						errorMessage2 = global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV1(fromRole.Name, edmAssociationType.Name);
					}
					else
					{
						errorMessage2 = global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidMultiplicityFromRoleToPropertyNonNullableV2(fromRole.Name, edmAssociationType.Name);
					}
					context.AddError(edmAssociationType, null, errorMessage2);
				}
				if (!flag4 && !edmAssociationType.IsForeignKey(context.Model.SchemaVersion) && context.IsCSpace)
				{
					context.AddError(toRole, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidToPropertyInRelationshipConstraint(toRole.Name, global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(toRole.GetEntityType(), toRole.GetEntityType().NamespaceName), global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(edmAssociationType, edmAssociationType.NamespaceName)));
				}
				if (flag)
				{
					if (toRole.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
					{
						context.AddError(toRole, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeOne(toRole.Name, edmAssociationType.Name));
					}
				}
				else if (toRole.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					context.AddError(toRole, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidMultiplicityToRoleUpperBoundMustBeMany(toRole.Name, edmAssociationType.Name));
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = fromRole.GetEntityType().GetValidKey().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list2 = constraint.ToProperties.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				if (list2.Count != list.Count)
				{
					context.AddError(constraint, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_MismatchNumberOfPropertiesinRelationshipConstraint);
					return;
				}
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> principalProperties = constraint.FromProperties.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				int count = list2.Count;
				int j;
				int i;
				global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> <>9__45;
				for (i = 0; i < count; i = j + 1)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = list2[i];
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> source = list;
					global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> predicate;
					if ((predicate = <>9__45) == null)
					{
						predicate = (<>9__45 = ((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Name == principalProperties[i].Name));
					}
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = source.SingleOrDefault(predicate);
					if (edmProperty2 != null && edmProperty != null && edmProperty2.TypeUsage != null && edmProperty.TypeUsage != null && edmProperty2.IsPrimitiveType && edmProperty.IsPrimitiveType && !global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.IsPrimitiveTypesEqual(edmProperty, edmProperty2))
					{
						context.AddError(constraint, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_TypeMismatchRelationshipConstraint(constraint.ToProperties.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()[i].Name, toRole.GetEntityType().Name, edmProperty2.Name, fromRole.GetEntityType().Name, edmAssociationType.Name));
					}
					j = i;
				}
			}
		});

		// Token: 0x04001454 RID: 5204
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> EdmAssociationType_InvalidPropertyInRelationshipConstraint = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.AssociationType edmAssociationType)
		{
			if (edmAssociationType.Constraint != null && edmAssociationType.Constraint.ToRole != null && edmAssociationType.Constraint.ToRole.GetEntityType() != null)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = edmAssociationType.Constraint.ToRole.GetEntityType().Properties.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in edmAssociationType.Constraint.ToProperties)
				{
					if (edmProperty != null && !list.Contains(edmProperty))
					{
						context.AddError(edmProperty, null, global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidPropertyInRelationshipConstraint(edmProperty.Name, edmAssociationType.Constraint.ToRole.Name));
					}
				}
			}
		});

		// Token: 0x04001455 RID: 5205
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> EdmComplexType_InvalidIsAbstract = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.ComplexType edmComplexType)
		{
			if (edmComplexType.Abstract)
			{
				context.AddError(edmComplexType, "Abstract", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidComplexTypeAbstract(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(edmComplexType, edmComplexType.NamespaceName)));
			}
		});

		// Token: 0x04001456 RID: 5206
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> EdmComplexType_InvalidIsPolymorphic = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.ComplexType edmComplexType)
		{
			if (edmComplexType.BaseType != null)
			{
				context.AddError(edmComplexType, "BaseType", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidComplexTypePolymorphic(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(edmComplexType, edmComplexType.NamespaceName)));
			}
		});

		// Token: 0x04001457 RID: 5207
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> EdmComplexType_InvalidMemberNameMatchesTypeName = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.ComplexType edmComplexType)
		{
			if (!string.IsNullOrWhiteSpace(edmComplexType.Name) && edmComplexType.Properties.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in edmComplexType.Properties)
				{
					if (edmProperty != null && edmProperty.Name.EqualsOrdinal(edmComplexType.Name))
					{
						context.AddError(edmProperty, "Name", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidMemberNameMatchesTypeName(edmProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(edmComplexType, edmComplexType.NamespaceName)));
					}
				}
			}
		});

		// Token: 0x04001458 RID: 5208
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> EdmComplexType_PropertyNameAlreadyDefinedDuplicate = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.ComplexType edmComplexType)
		{
			if (edmComplexType.Properties.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				global::System.Collections.Generic.HashSet<string> memberNameList = new global::System.Collections.Generic.HashSet<string>();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in edmComplexType.Properties)
				{
					if (!string.IsNullOrWhiteSpace(edmProperty.Name))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.AddMemberNameToHashSet(edmProperty, memberNameList, context, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_PropertyNameAlreadyDefinedDuplicate));
					}
				}
			}
		});

		// Token: 0x04001459 RID: 5209
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> EdmComplexType_PropertyNameAlreadyDefinedDuplicate_V1_1 = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.ComplexType edmComplexType)
		{
			if (edmComplexType.Properties.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				global::System.Collections.Generic.HashSet<string> memberNameList = new global::System.Collections.Generic.HashSet<string>();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in edmComplexType.Properties)
				{
					if (edmProperty != null && !string.IsNullOrWhiteSpace(edmProperty.Name))
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.AddMemberNameToHashSet(edmProperty, memberNameList, context, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_PropertyNameAlreadyDefinedDuplicate));
					}
				}
			}
		});

		// Token: 0x0400145A RID: 5210
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> EdmComplexType_CycleInTypeHierarchy_V1_1 = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.ComplexType edmComplexType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.CheckForInheritanceCycle<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(edmComplexType, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType ct) => (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)ct.BaseType))
			{
				context.AddError(edmComplexType, "BaseType", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_CycleInTypeHierarchy(global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.GetQualifiedName(edmComplexType, edmComplexType.NamespaceName)));
			}
		});

		// Token: 0x0400145B RID: 5211
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> EdmProperty_InvalidCollectionKind = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty)
		{
			if (edmProperty.CollectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
			{
				context.AddError(edmProperty, "CollectionKind", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidCollectionKindNotV1_1(edmProperty.Name));
			}
		});

		// Token: 0x0400145C RID: 5212
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> EdmProperty_InvalidCollectionKind_V1_1 = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty)
		{
			if (edmProperty.CollectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None && edmProperty.TypeUsage != null && !edmProperty.IsCollectionType)
			{
				context.AddError(edmProperty, "CollectionKind", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidCollectionKindNotCollection(edmProperty.Name));
			}
		});

		// Token: 0x0400145D RID: 5213
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> EdmProperty_NullableComplexType = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty)
		{
			if (edmProperty.TypeUsage != null && edmProperty.ComplexType != null && edmProperty.Nullable)
			{
				context.AddError(edmProperty, "Nullable", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_NullableComplexType(edmProperty.Name));
			}
		});

		// Token: 0x0400145E RID: 5214
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> EdmProperty_InvalidPropertyType = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty)
		{
			if (edmProperty.TypeUsage.EdmType != null && !edmProperty.IsPrimitiveType && !edmProperty.IsComplexType)
			{
				context.AddError(edmProperty, "Type", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidPropertyType(edmProperty.IsCollectionType ? "CollectionType" : edmProperty.TypeUsage.EdmType.BuiltInTypeKind.ToString()));
			}
		});

		// Token: 0x0400145F RID: 5215
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> EdmProperty_InvalidPropertyType_V1_1 = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty)
		{
			if (edmProperty.TypeUsage != null && edmProperty.TypeUsage.EdmType != null && !edmProperty.IsPrimitiveType && !edmProperty.IsComplexType && !edmProperty.IsCollectionType)
			{
				context.AddError(edmProperty, "Type", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidPropertyType_V1_1(edmProperty.TypeUsage.EdmType.BuiltInTypeKind.ToString()));
			}
		});

		// Token: 0x04001460 RID: 5216
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> EdmProperty_InvalidPropertyType_V3 = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty)
		{
			if (edmProperty.TypeUsage != null && edmProperty.TypeUsage.EdmType != null && !edmProperty.IsPrimitiveType && !edmProperty.IsComplexType && !edmProperty.IsEnumType)
			{
				context.AddError(edmProperty, "Type", global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_InvalidPropertyType_V3(edmProperty.TypeUsage.EdmType.BuiltInTypeKind.ToString()));
			}
		});

		// Token: 0x04001461 RID: 5217
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmModel> EdmNamespace_TypeNameAlreadyDefinedDuplicate = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationRule<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			global::System.Collections.Generic.HashSet<string> memberNameList = new global::System.Collections.Generic.HashSet<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType item in model.NamespaceItems)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmModelSemanticValidationRules.AddMemberNameToHashSet(item, memberNameList, context, new global::System.Func<string, string>(global::System.Data.Entity.Resources.Strings.EdmModel_Validator_Semantic_TypeNameAlreadyDefinedDuplicate));
			}
		});
	}
}
