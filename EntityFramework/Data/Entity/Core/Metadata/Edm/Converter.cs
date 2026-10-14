using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Core.SchemaObjectModel;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000495 RID: 1173
	internal static class Converter
	{
		// Token: 0x06003A03 RID: 14851 RVA: 0x000BE0F8 File Offset: 0x000BC2F8
		static Converter()
		{
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType = new global::System.Data.Entity.Core.Metadata.Edm.EnumType("ConcurrencyMode", "Edm", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32), false, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			foreach (string text in global::System.Enum.GetNames(typeof(global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode)))
			{
				enumType.AddMember(new global::System.Data.Entity.Core.Metadata.Edm.EnumMember(text, (int)global::System.Enum.Parse(typeof(global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode), text, false)));
			}
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType2 = new global::System.Data.Entity.Core.Metadata.Edm.EnumType("StoreGeneratedPattern", "Edm", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32), false, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			foreach (string text2 in global::System.Enum.GetNames(typeof(global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern)))
			{
				enumType2.AddMember(new global::System.Data.Entity.Core.Metadata.Edm.EnumMember(text2, (int)global::System.Enum.Parse(typeof(global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern), text2, false)));
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.ConcurrencyModeFacet = new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("ConcurrencyMode", enumType, null, null, global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.None);
			global::System.Data.Entity.Core.Metadata.Edm.Converter.StoreGeneratedPatternFacet = new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("StoreGeneratedPattern", enumType2, null, null, global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None);
			global::System.Data.Entity.Core.Metadata.Edm.Converter.CollationFacet = new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("Collation", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String), null, null, string.Empty);
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x000BE258 File Offset: 0x000BC458
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> ConvertSchema(global::System.Data.Entity.Core.SchemaObjectModel.Schema somSchema, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem>();
			global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertSchema(somSchema, providerManifest, new global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache(itemCollection), dictionary);
			return dictionary.Values;
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x000BE280 File Offset: 0x000BC480
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> ConvertSchema(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.Schema> somSchemas, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem>();
			global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache = new global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache(itemCollection);
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Schema somSchema in somSchemas)
			{
				global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertSchema(somSchema, providerManifest, convertedItemCache, dictionary);
			}
			return dictionary.Values;
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x000BE2DC File Offset: 0x000BC4DC
		private static void ConvertSchema(global::System.Data.Entity.Core.SchemaObjectModel.Schema somSchema, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.Function> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.Function>();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType in somSchema.SchemaTypes)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(schemaType, providerManifest, convertedItemCache, newGlobalItems) == null)
				{
					global::System.Data.Entity.Core.SchemaObjectModel.Function function = schemaType as global::System.Data.Entity.Core.SchemaObjectModel.Function;
					if (function != null)
					{
						list.Add(function);
					}
				}
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType element in somSchema.SchemaTypes.OfType<global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType>())
			{
				global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadEntityTypePhase2(element, providerManifest, convertedItemCache, newGlobalItems);
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Function element2 in list)
			{
				global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(element2, providerManifest, convertedItemCache, newGlobalItems);
			}
			if (convertedItemCache.ItemCollection.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				((global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection)convertedItemCache.ItemCollection).EdmVersion = somSchema.SchemaVersion;
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = convertedItemCache.ItemCollection as global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection;
			if (storeItemCollection != null)
			{
				storeItemCollection.StoreSchemaVersion = somSchema.SchemaVersion;
			}
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x000BE418 File Offset: 0x000BC618
		internal static global::System.Data.Entity.Core.Metadata.Edm.MetadataItem LoadSchemaElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaType element, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.GlobalItem result;
			if (newGlobalItems.TryGetValue(element, out result))
			{
				return result;
			}
			global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer entityContainer = element as global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer;
			if (entityContainer != null)
			{
				result = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToEntityContainer(entityContainer, providerManifest, convertedItemCache, newGlobalItems);
			}
			else if (element is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType)
			{
				result = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToEntityType((global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType)element, providerManifest, convertedItemCache, newGlobalItems);
			}
			else if (element is global::System.Data.Entity.Core.SchemaObjectModel.Relationship)
			{
				result = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToAssociationType((global::System.Data.Entity.Core.SchemaObjectModel.Relationship)element, providerManifest, convertedItemCache, newGlobalItems);
			}
			else if (element is global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType)
			{
				result = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToComplexType((global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType)element, providerManifest, convertedItemCache, newGlobalItems);
			}
			else if (element is global::System.Data.Entity.Core.SchemaObjectModel.Function)
			{
				result = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToFunction((global::System.Data.Entity.Core.SchemaObjectModel.Function)element, providerManifest, convertedItemCache, null, newGlobalItems);
			}
			else
			{
				if (!(element is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType))
				{
					return null;
				}
				result = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToEnumType((global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType)element, newGlobalItems);
			}
			return result;
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x000BE4C8 File Offset: 0x000BC6C8
		private static global::System.Data.Entity.Core.Metadata.Edm.EntityContainer ConvertToEntityContainer(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer element, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer = new global::System.Data.Entity.Core.Metadata.Edm.EntityContainer(element.Name, global::System.Data.Entity.Core.Metadata.Edm.Converter.GetDataSpace(providerManifest));
			newGlobalItems.Add(element, entityContainer);
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet set in element.EntitySets)
			{
				entityContainer.AddEntitySetBase(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToEntitySet(set, providerManifest, convertedItemCache, newGlobalItems));
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet relationshipSet in element.RelationshipSets)
			{
				entityContainer.AddEntitySetBase(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToAssociationSet(relationshipSet, providerManifest, convertedItemCache, entityContainer, newGlobalItems));
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Function somFunction in element.FunctionImports)
			{
				entityContainer.AddFunctionImport(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToFunction(somFunction, providerManifest, convertedItemCache, entityContainer, newGlobalItems));
			}
			if (element.Documentation != null)
			{
				entityContainer.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(element.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(element, entityContainer);
			return entityContainer;
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x000BE5EC File Offset: 0x000BC7EC
		private static global::System.Data.Entity.Core.Metadata.Edm.EntityType ConvertToEntityType(global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType element, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			string[] array = null;
			if (element.DeclaredKeyProperties.Count != 0)
			{
				array = new string[element.DeclaredKeyProperties.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = element.DeclaredKeyProperties[i].Property.Name;
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] array2 = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[element.Properties.Count];
			int num = 0;
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty somProperty in element.Properties)
			{
				array2[num++] = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToProperty(somProperty, providerManifest, convertedItemCache, newGlobalItems);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = new global::System.Data.Entity.Core.Metadata.Edm.EntityType(element.Name, element.Namespace, global::System.Data.Entity.Core.Metadata.Edm.Converter.GetDataSpace(providerManifest), array, array2);
			if (element.BaseType != null)
			{
				entityType.BaseType = (global::System.Data.Entity.Core.Metadata.Edm.EdmType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(element.BaseType, providerManifest, convertedItemCache, newGlobalItems);
			}
			entityType.Abstract = element.IsAbstract;
			if (element.Documentation != null)
			{
				entityType.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(element.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(element, entityType);
			newGlobalItems.Add(element, entityType);
			return entityType;
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x000BE71C File Offset: 0x000BC91C
		private static void LoadEntityTypePhase2(global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType element, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)newGlobalItems[element];
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.NavigationProperty somNavigationProperty in element.NavigationProperties)
			{
				entityType.AddMember(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToNavigationProperty(entityType, somNavigationProperty, providerManifest, convertedItemCache, newGlobalItems));
			}
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x000BE780 File Offset: 0x000BC980
		private static global::System.Data.Entity.Core.Metadata.Edm.ComplexType ConvertToComplexType(global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType element, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType(element.Name, element.Namespace, global::System.Data.Entity.Core.Metadata.Edm.Converter.GetDataSpace(providerManifest));
			newGlobalItems.Add(element, complexType);
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty somProperty in element.Properties)
			{
				complexType.AddMember(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToProperty(somProperty, providerManifest, convertedItemCache, newGlobalItems));
			}
			complexType.Abstract = element.IsAbstract;
			if (element.BaseType != null)
			{
				complexType.BaseType = (global::System.Data.Entity.Core.Metadata.Edm.EdmType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(element.BaseType, providerManifest, convertedItemCache, newGlobalItems);
			}
			if (element.Documentation != null)
			{
				complexType.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(element.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(element, complexType);
			return complexType;
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x000BE844 File Offset: 0x000BCA44
		private static global::System.Data.Entity.Core.Metadata.Edm.AssociationType ConvertToAssociationType(global::System.Data.Entity.Core.SchemaObjectModel.Relationship element, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = new global::System.Data.Entity.Core.Metadata.Edm.AssociationType(element.Name, element.Namespace, element.IsForeignKey, global::System.Data.Entity.Core.Metadata.Edm.Converter.GetDataSpace(providerManifest));
			newGlobalItems.Add(element, associationType);
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd in element.Ends)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd relationshipEnd2 = (global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd)relationshipEnd;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType endMemberType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(relationshipEnd2.Type, providerManifest, convertedItemCache, newGlobalItems);
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = global::System.Data.Entity.Core.Metadata.Edm.Converter.InitializeAssociationEndMember(associationType, relationshipEnd2, endMemberType);
				global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(relationshipEnd2, associationEndMember);
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.OnOperation onOperation in relationshipEnd2.Operations)
				{
					if (onOperation.Operation == global::System.Data.Entity.Core.SchemaObjectModel.Operation.Delete)
					{
						global::System.Data.Entity.Core.Metadata.Edm.OperationAction deleteBehavior = global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None;
						global::System.Data.Entity.Core.SchemaObjectModel.Action action = onOperation.Action;
						if (action != global::System.Data.Entity.Core.SchemaObjectModel.Action.None)
						{
							if (action == global::System.Data.Entity.Core.SchemaObjectModel.Action.Cascade)
							{
								deleteBehavior = global::System.Data.Entity.Core.Metadata.Edm.OperationAction.Cascade;
							}
						}
						else
						{
							deleteBehavior = global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None;
						}
						associationEndMember.DeleteBehavior = deleteBehavior;
					}
				}
				if (relationshipEnd2.Documentation != null)
				{
					associationEndMember.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(relationshipEnd2.Documentation);
				}
			}
			for (int i = 0; i < element.Constraints.Count; i++)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.ReferentialConstraint referentialConstraint = element.Constraints[i];
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)associationType.Members[referentialConstraint.PrincipalRole.Name];
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember3 = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)associationType.Members[referentialConstraint.DependentRole.Name];
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = ((global::System.Data.Entity.Core.Metadata.Edm.RefType)associationEndMember2.TypeUsage.EdmType).ElementType;
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType2 = ((global::System.Data.Entity.Core.Metadata.Edm.RefType)associationEndMember3.TypeUsage.EdmType).ElementType;
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint2 = new global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint(associationEndMember2, associationEndMember3, global::System.Data.Entity.Core.Metadata.Edm.Converter.GetProperties(elementType, referentialConstraint.PrincipalRole.RoleProperties), global::System.Data.Entity.Core.Metadata.Edm.Converter.GetProperties(elementType2, referentialConstraint.DependentRole.RoleProperties));
				if (referentialConstraint.Documentation != null)
				{
					referentialConstraint2.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(referentialConstraint.Documentation);
				}
				if (referentialConstraint.PrincipalRole.Documentation != null)
				{
					referentialConstraint2.FromRole.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(referentialConstraint.PrincipalRole.Documentation);
				}
				if (referentialConstraint.DependentRole.Documentation != null)
				{
					referentialConstraint2.ToRole.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(referentialConstraint.DependentRole.Documentation);
				}
				associationType.AddReferentialConstraint(referentialConstraint2);
				global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(element.Constraints[i], referentialConstraint2);
			}
			if (element.Documentation != null)
			{
				associationType.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(element.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(element, associationType);
			return associationType;
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x000BEADC File Offset: 0x000BCCDC
		private static global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember InitializeAssociationEndMember(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end, global::System.Data.Entity.Core.Metadata.Edm.EntityType endMemberType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
			if (!associationType.Members.TryGetValue(end.Name, false, out edmMember))
			{
				associationEndMember = new global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember(end.Name, endMemberType.GetReferenceType(), end.Multiplicity.Value);
				associationType.AddKeyMember(associationEndMember);
			}
			else
			{
				associationEndMember = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)edmMember;
			}
			global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd relationshipEnd = end as global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEnd;
			if (relationshipEnd != null && relationshipEnd.Documentation != null)
			{
				associationEndMember.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(relationshipEnd.Documentation);
			}
			return associationEndMember;
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x000BEB54 File Offset: 0x000BCD54
		private static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] GetProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.PropertyRefElement> properties)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] array = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[properties.Count];
			for (int i = 0; i < properties.Count; i++)
			{
				array[i] = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)entityType.Members[properties[i].Name];
			}
			return array;
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x000BEB9E File Offset: 0x000BCD9E
		private static void AddOtherContent(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement element, global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			if (element.OtherContent.Count > 0)
			{
				item.AddMetadataProperties(element.OtherContent);
			}
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x000BEBBC File Offset: 0x000BCDBC
		private static global::System.Data.Entity.Core.Metadata.Edm.EntitySet ConvertToEntitySet(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet set, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = new global::System.Data.Entity.Core.Metadata.Edm.EntitySet(set.Name, set.DbSchema, set.Table, set.DefiningQuery, (global::System.Data.Entity.Core.Metadata.Edm.EntityType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(set.EntityType, providerManifest, convertedItemCache, newGlobalItems));
			if (set.Documentation != null)
			{
				entitySet.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(set.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(set, entitySet);
			return entitySet;
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x000BEC1B File Offset: 0x000BCE1B
		private static global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySet(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet set, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container)
		{
			return container.GetEntitySetByName(set.Name, false);
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x000BEC2C File Offset: 0x000BCE2C
		private static global::System.Data.Entity.Core.Metadata.Edm.AssociationSet ConvertToAssociationSet(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSet relationshipSet, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement((global::System.Data.Entity.Core.SchemaObjectModel.SchemaType)relationshipSet.Relationship, providerManifest, convertedItemCache, newGlobalItems);
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = new global::System.Data.Entity.Core.Metadata.Edm.AssociationSet(relationshipSet.Name, associationType);
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerRelationshipSetEnd entityContainerRelationshipSetEnd in relationshipSet.Ends)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)associationType.Members[entityContainerRelationshipSetEnd.Name];
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = new global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd(global::System.Data.Entity.Core.Metadata.Edm.Converter.GetEntitySet(entityContainerRelationshipSetEnd.EntitySet, container), associationSet, endMember);
				global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(entityContainerRelationshipSetEnd, associationSetEnd);
				associationSet.AddAssociationSetEnd(associationSetEnd);
				if (entityContainerRelationshipSetEnd.Documentation != null)
				{
					associationSetEnd.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(entityContainerRelationshipSetEnd.Documentation);
				}
			}
			if (relationshipSet.Documentation != null)
			{
				associationSet.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(relationshipSet.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(relationshipSet, associationSet);
			return associationSet;
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x000BED14 File Offset: 0x000BCF14
		private static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty ConvertToProperty(global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty somProperty, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = null;
			global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalarType = somProperty.Type as global::System.Data.Entity.Core.SchemaObjectModel.ScalarType;
			if (scalarType != null && somProperty.Schema.DataModel != global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				typeUsage = somProperty.TypeUsage;
				global::System.Data.Entity.Core.Metadata.Edm.Converter.UpdateSentinelValuesInFacets(ref typeUsage);
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
				if (scalarType != null)
				{
					edmType = convertedItemCache.ItemCollection.GetItem<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(somProperty.TypeUsage.EdmType.FullName);
				}
				else
				{
					edmType = (global::System.Data.Entity.Core.Metadata.Edm.EdmType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(somProperty.Type, providerManifest, convertedItemCache, newGlobalItems);
				}
				if (somProperty.CollectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(edmType));
				}
				else
				{
					bool flag = ((scalarType == null) ? (somProperty.Type as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType) : null) != null;
					typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType);
					if (flag)
					{
						somProperty.EnsureEnumTypeFacets(convertedItemCache, newGlobalItems);
					}
					if (somProperty.TypeUsage != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.Converter.ApplyTypePropertyFacets(somProperty.TypeUsage, ref typeUsage);
					}
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.PopulateGeneralFacets(somProperty, ref typeUsage);
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(somProperty.Name, typeUsage);
			if (somProperty.Documentation != null)
			{
				edmProperty.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(somProperty.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(somProperty, edmProperty);
			return edmProperty;
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x000BEE0C File Offset: 0x000BD00C
		private static global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty ConvertToNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.EntityType declaringEntityType, global::System.Data.Entity.Core.SchemaObjectModel.NavigationProperty somNavigationProperty, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(somNavigationProperty.Type, providerManifest, convertedItemCache, newGlobalItems);
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement((global::System.Data.Entity.Core.SchemaObjectModel.Relationship)somNavigationProperty.Relationship, providerManifest, convertedItemCache, newGlobalItems);
			global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd = null;
			somNavigationProperty.Relationship.TryGetEnd(somNavigationProperty.ToEnd.Name, out relationshipEnd);
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? multiplicity = relationshipEnd.Multiplicity;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (multiplicity.GetValueOrDefault() == relationshipMultiplicity & multiplicity != null)
			{
				edmType = entityType.GetCollectionType();
			}
			else
			{
				edmType = entityType;
			}
			multiplicity = relationshipEnd.Multiplicity;
			relationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (multiplicity.GetValueOrDefault() == relationshipMultiplicity & multiplicity != null)
			{
				typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					Nullable = new bool?(false)
				});
			}
			else
			{
				typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.InitializeAssociationEndMember(associationType, somNavigationProperty.ToEnd, entityType);
			global::System.Data.Entity.Core.Metadata.Edm.Converter.InitializeAssociationEndMember(associationType, somNavigationProperty.FromEnd, declaringEntityType);
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = new global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty(somNavigationProperty.Name, typeUsage);
			navigationProperty.RelationshipType = associationType;
			navigationProperty.ToEndMember = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)associationType.Members[somNavigationProperty.ToEnd.Name];
			navigationProperty.FromEndMember = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)associationType.Members[somNavigationProperty.FromEnd.Name];
			if (somNavigationProperty.Documentation != null)
			{
				navigationProperty.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(somNavigationProperty.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(somNavigationProperty, navigationProperty);
			return navigationProperty;
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x000BEF74 File Offset: 0x000BD174
		private static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction ConvertToFunction(global::System.Data.Entity.Core.SchemaObjectModel.Function somFunction, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Data.Entity.Core.Metadata.Edm.EntityContainer functionImportEntityContainer, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem = null;
			if (!somFunction.IsFunctionImport && newGlobalItems.TryGetValue(somFunction, out globalItem))
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction)globalItem;
			}
			bool flag = somFunction.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderManifestModel;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>();
			if (somFunction.ReturnTypeList != null)
			{
				int num = 0;
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.SchemaObjectModel.ReturnType> enumerator = somFunction.ReturnTypeList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.SchemaObjectModel.ReturnType returnType2 = enumerator.Current;
						global::System.Data.Entity.Core.Metadata.Edm.TypeUsage functionTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Converter.GetFunctionTypeUsage(somFunction is global::System.Data.Entity.Core.SchemaObjectModel.ModelFunction, somFunction, returnType2, providerManifest, flag, returnType2.Type, returnType2.CollectionKind, returnType2.IsRefType, convertedItemCache, newGlobalItems);
						if (functionTypeUsage == null)
						{
							return null;
						}
						string str = (num == 0) ? string.Empty : num.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						num++;
						global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter item = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter("ReturnType" + str, functionTypeUsage, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue);
						global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(returnType2, item);
						list.Add(item);
					}
					goto IL_14F;
				}
			}
			if (somFunction.Type != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage functionTypeUsage2 = global::System.Data.Entity.Core.Metadata.Edm.Converter.GetFunctionTypeUsage(somFunction is global::System.Data.Entity.Core.SchemaObjectModel.ModelFunction, somFunction, null, providerManifest, flag, somFunction.Type, somFunction.CollectionKind, somFunction.IsReturnAttributeReftype, convertedItemCache, newGlobalItems);
				if (functionTypeUsage2 == null)
				{
					return null;
				}
				list.Add(new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter("ReturnType", functionTypeUsage2, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue));
			}
			IL_14F:
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet[] entitySets = null;
			string namespaceName;
			if (somFunction.IsFunctionImport)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.FunctionImportElement functionImportElement = (global::System.Data.Entity.Core.SchemaObjectModel.FunctionImportElement)somFunction;
				namespaceName = functionImportElement.Container.Name;
				if (functionImportElement.EntitySet != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityContainer functionImportEntityContainer2 = functionImportEntityContainer;
					entitySets = new global::System.Data.Entity.Core.Metadata.Edm.EntitySet[]
					{
						global::System.Data.Entity.Core.Metadata.Edm.Converter.GetEntitySet(functionImportElement.EntitySet, functionImportEntityContainer2)
					};
				}
				else if (functionImportElement.ReturnTypeList != null)
				{
					entitySets = functionImportElement.ReturnTypeList.Select(delegate(global::System.Data.Entity.Core.SchemaObjectModel.ReturnType returnType)
					{
						if (returnType.EntitySet == null)
						{
							return null;
						}
						return global::System.Data.Entity.Core.Metadata.Edm.Converter.GetEntitySet(returnType.EntitySet, functionImportEntityContainer);
					}).ToArray<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
				}
			}
			else
			{
				namespaceName = somFunction.Namespace;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Parameter parameter in somFunction.Parameters)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage functionTypeUsage3 = global::System.Data.Entity.Core.Metadata.Edm.Converter.GetFunctionTypeUsage(somFunction is global::System.Data.Entity.Core.SchemaObjectModel.ModelFunction, somFunction, parameter, providerManifest, flag, parameter.Type, parameter.CollectionKind, parameter.IsRefType, convertedItemCache, newGlobalItems);
				if (functionTypeUsage3 == null)
				{
					return null;
				}
				global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter(parameter.Name, functionTypeUsage3, global::System.Data.Entity.Core.Metadata.Edm.Converter.GetParameterMode(parameter.ParameterDirection));
				global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(parameter, functionParameter);
				if (parameter.Documentation != null)
				{
					functionParameter.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(parameter.Documentation);
				}
				list2.Add(functionParameter);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction(somFunction.Name, namespaceName, global::System.Data.Entity.Core.Metadata.Edm.Converter.GetDataSpace(providerManifest), new global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload
			{
				Schema = somFunction.DbSchema,
				StoreFunctionName = somFunction.StoreFunctionName,
				CommandText = somFunction.CommandText,
				EntitySets = entitySets,
				IsAggregate = new bool?(somFunction.IsAggregate),
				IsBuiltIn = new bool?(somFunction.IsBuiltIn),
				IsNiladic = new bool?(somFunction.IsNiladicFunction),
				IsComposable = new bool?(somFunction.IsComposable),
				IsFromProviderManifest = new bool?(flag),
				IsFunctionImport = new bool?(somFunction.IsFunctionImport),
				ReturnParameters = list.ToArray(),
				Parameters = list2.ToArray(),
				ParameterTypeSemantics = new global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics?(somFunction.ParameterTypeSemantics)
			});
			if (!somFunction.IsFunctionImport)
			{
				newGlobalItems.Add(somFunction, edmFunction);
			}
			if (somFunction.Documentation != null)
			{
				edmFunction.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(somFunction.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(somFunction, edmFunction);
			return edmFunction;
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x000BF334 File Offset: 0x000BD534
		private static global::System.Data.Entity.Core.Metadata.Edm.EnumType ConvertToEnumType(global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType somEnumType, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalarType = (global::System.Data.Entity.Core.SchemaObjectModel.ScalarType)somEnumType.UnderlyingType;
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType = new global::System.Data.Entity.Core.Metadata.Edm.EnumType(somEnumType.Name, somEnumType.Namespace, scalarType.Type, somEnumType.IsFlags, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			global::System.Type clrEquivalentType = scalarType.Type.ClrEquivalentType;
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumMember schemaEnumMember in somEnumType.EnumMembers)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember = new global::System.Data.Entity.Core.Metadata.Edm.EnumMember(schemaEnumMember.Name, global::System.Convert.ChangeType(schemaEnumMember.Value, clrEquivalentType, global::System.Globalization.CultureInfo.InvariantCulture));
				if (schemaEnumMember.Documentation != null)
				{
					enumMember.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(schemaEnumMember.Documentation);
				}
				global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(schemaEnumMember, enumMember);
				enumType.AddMember(enumMember);
			}
			if (somEnumType.Documentation != null)
			{
				enumType.Documentation = global::System.Data.Entity.Core.Metadata.Edm.Converter.ConvertToDocumentation(somEnumType.Documentation);
			}
			global::System.Data.Entity.Core.Metadata.Edm.Converter.AddOtherContent(somEnumType, enumType);
			newGlobalItems.Add(somEnumType, enumType);
			return enumType;
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x000BF430 File Offset: 0x000BD630
		private static global::System.Data.Entity.Core.Metadata.Edm.Documentation ConvertToDocumentation(global::System.Data.Entity.Core.SchemaObjectModel.DocumentationElement element)
		{
			return element.MetadataDocumentation;
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x000BF438 File Offset: 0x000BD638
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetFunctionTypeUsage(bool isModelFunction, global::System.Data.Entity.Core.SchemaObjectModel.Function somFunction, global::System.Data.Entity.Core.SchemaObjectModel.FacetEnabledSchemaElement somParameter, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, bool areConvertingForProviderManifest, global::System.Data.Entity.Core.SchemaObjectModel.SchemaType type, global::System.Data.Entity.Core.Metadata.Edm.CollectionKind collectionKind, bool isRefType, global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			if (somParameter != null && areConvertingForProviderManifest && somParameter.HasUserDefinedFacets)
			{
				return somParameter.TypeUsage;
			}
			if (type != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
				if (!areConvertingForProviderManifest)
				{
					global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalarType = type as global::System.Data.Entity.Core.SchemaObjectModel.ScalarType;
					if (scalarType != null)
					{
						if (isModelFunction && somParameter != null)
						{
							if (somParameter.TypeUsage == null)
							{
								somParameter.ValidateAndSetTypeUsage(scalarType);
							}
							return somParameter.TypeUsage;
						}
						if (isModelFunction)
						{
							global::System.Data.Entity.Core.SchemaObjectModel.ModelFunction modelFunction = somFunction as global::System.Data.Entity.Core.SchemaObjectModel.ModelFunction;
							if (modelFunction.TypeUsage == null)
							{
								modelFunction.ValidateAndSetTypeUsage(scalarType);
							}
							return modelFunction.TypeUsage;
						}
						if (somParameter != null && somParameter.HasUserDefinedFacets && somFunction.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
						{
							somParameter.ValidateAndSetTypeUsage(scalarType);
							return somParameter.TypeUsage;
						}
						edmType = global::System.Data.Entity.Core.Metadata.Edm.Converter.GetPrimitiveType(scalarType, providerManifest);
					}
					else
					{
						edmType = (global::System.Data.Entity.Core.Metadata.Edm.EdmType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(type, providerManifest, convertedItemCache, newGlobalItems);
						if (isModelFunction && type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType)
						{
							if (somParameter != null)
							{
								somParameter.ValidateAndSetTypeUsage(edmType);
								return somParameter.TypeUsage;
							}
							if (somFunction != null)
							{
								global::System.Data.Entity.Core.SchemaObjectModel.ModelFunction modelFunction2 = (global::System.Data.Entity.Core.SchemaObjectModel.ModelFunction)somFunction;
								modelFunction2.ValidateAndSetTypeUsage(edmType);
								return modelFunction2.TypeUsage;
							}
						}
					}
				}
				else if (type is global::System.Data.Entity.Core.SchemaObjectModel.TypeElement)
				{
					edmType = (type as global::System.Data.Entity.Core.SchemaObjectModel.TypeElement).PrimitiveType;
				}
				else
				{
					edmType = (type as global::System.Data.Entity.Core.SchemaObjectModel.ScalarType).Type;
				}
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
				if (collectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					result = convertedItemCache.GetCollectionTypeUsageWithNullFacets(edmType);
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = edmType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
					if (entityType != null && isRefType)
					{
						result = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.RefType(entityType));
					}
					else
					{
						result = convertedItemCache.GetTypeUsageWithNullFacets(edmType);
					}
				}
				return result;
			}
			if (isModelFunction && somParameter != null && somParameter is global::System.Data.Entity.Core.SchemaObjectModel.Parameter)
			{
				((global::System.Data.Entity.Core.SchemaObjectModel.Parameter)somParameter).ResolveNestedTypeNames(convertedItemCache, newGlobalItems);
				return somParameter.TypeUsage;
			}
			if (somParameter != null && somParameter is global::System.Data.Entity.Core.SchemaObjectModel.ReturnType)
			{
				((global::System.Data.Entity.Core.SchemaObjectModel.ReturnType)somParameter).ResolveNestedTypeNames(convertedItemCache, newGlobalItems);
				return somParameter.TypeUsage;
			}
			return null;
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x000BF5CD File Offset: 0x000BD7CD
		private static global::System.Data.Entity.Core.Metadata.Edm.ParameterMode GetParameterMode(global::System.Data.ParameterDirection parameterDirection)
		{
			switch (parameterDirection)
			{
			case global::System.Data.ParameterDirection.Input:
				return global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In;
			case global::System.Data.ParameterDirection.Output:
				return global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut;
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x000BF5EC File Offset: 0x000BD7EC
		private static void ApplyTypePropertyFacets(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage sourceType, ref global::System.Data.Entity.Core.Metadata.Edm.TypeUsage targetType)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> dictionary = targetType.Facets.ToDictionary((global::System.Data.Entity.Core.Metadata.Edm.Facet f) => f.Name);
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.Facet facet in sourceType.Facets)
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet2;
				if (dictionary.TryGetValue(facet.Name, out facet2))
				{
					if (!facet2.Description.IsConstant)
					{
						flag = true;
						dictionary[facet2.Name] = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(facet2.Description, facet.Value);
					}
				}
				else
				{
					flag = true;
					dictionary.Add(facet.Name, facet);
				}
			}
			if (flag)
			{
				targetType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(targetType.EdmType, dictionary.Values);
			}
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x000BF6D0 File Offset: 0x000BD8D0
		private static void PopulateGeneralFacets(global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty somProperty, ref global::System.Data.Entity.Core.Metadata.Edm.TypeUsage propertyTypeUsage)
		{
			bool flag = false;
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.Facet> dictionary = propertyTypeUsage.Facets.ToDictionary((global::System.Data.Entity.Core.Metadata.Edm.Facet f) => f.Name);
			if (!somProperty.Nullable)
			{
				dictionary["Nullable"] = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.NullableFacetDescription, false);
				flag = true;
			}
			if (somProperty.Default != null)
			{
				dictionary["DefaultValue"] = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.DefaultValueFacetDescription, somProperty.DefaultAsObject);
				flag = true;
			}
			if (somProperty.Schema.SchemaVersion == 1.1)
			{
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet = global::System.Data.Entity.Core.Metadata.Edm.Facet.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.CollectionKindFacetDescription, somProperty.CollectionKind);
				dictionary.Add(facet.Name, facet);
				flag = true;
			}
			if (flag)
			{
				propertyTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(propertyTypeUsage.EdmType, dictionary.Values);
			}
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x000BF7A7 File Offset: 0x000BD9A7
		private static global::System.Data.Entity.Core.Metadata.Edm.DataSpace GetDataSpace(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (providerManifest is global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace;
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x000BF7B4 File Offset: 0x000BD9B4
		private static global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetPrimitiveType(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalarType, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType result = null;
			string name = scalarType.Name;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in providerManifest.GetStoreTypes())
			{
				if (primitiveType.Name == name)
				{
					result = primitiveType;
					break;
				}
			}
			return result;
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x000BF818 File Offset: 0x000BDA18
		private static void UpdateSentinelValuesInFacets(ref global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)typeUsage.EdmType;
			if ((primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String || primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsUnboundedFacetValue(typeUsage.Facets["MaxLength"]))
			{
				typeUsage = typeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					MaxLength = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(primitiveType.FacetDescriptions, "MaxLength").MaxValue
				});
			}
		}

		// Token: 0x0400135F RID: 4959
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.FacetDescription ConcurrencyModeFacet;

		// Token: 0x04001360 RID: 4960
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.FacetDescription StoreGeneratedPatternFacet;

		// Token: 0x04001361 RID: 4961
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.FacetDescription CollationFacet;

		// Token: 0x02000AC4 RID: 2756
		internal class ConversionCache
		{
			// Token: 0x06006322 RID: 25378 RVA: 0x00157088 File Offset: 0x00155288
			internal ConversionCache(global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection)
			{
				this.ItemCollection = itemCollection;
				this._nullFacetsTypeUsage = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();
				this._nullFacetsCollectionTypeUsage = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>();
			}

			// Token: 0x06006323 RID: 25379 RVA: 0x001570B0 File Offset: 0x001552B0
			internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsageWithNullFacets(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
				if (this._nullFacetsTypeUsage.TryGetValue(edmType, out typeUsage))
				{
					return typeUsage;
				}
				typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, global::System.Data.Entity.Core.Metadata.Edm.FacetValues.NullFacetValues);
				this._nullFacetsTypeUsage.Add(edmType, typeUsage);
				return typeUsage;
			}

			// Token: 0x06006324 RID: 25380 RVA: 0x001570EC File Offset: 0x001552EC
			internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetCollectionTypeUsageWithNullFacets(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
				if (this._nullFacetsCollectionTypeUsage.TryGetValue(edmType, out typeUsage))
				{
					return typeUsage;
				}
				typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(this.GetTypeUsageWithNullFacets(edmType)), global::System.Data.Entity.Core.Metadata.Edm.FacetValues.NullFacetValues);
				this._nullFacetsCollectionTypeUsage.Add(edmType, typeUsage);
				return typeUsage;
			}

			// Token: 0x04002BA2 RID: 11170
			internal readonly global::System.Data.Entity.Core.Metadata.Edm.ItemCollection ItemCollection;

			// Token: 0x04002BA3 RID: 11171
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> _nullFacetsTypeUsage;

			// Token: 0x04002BA4 RID: 11172
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> _nullFacetsCollectionTypeUsage;
		}
	}
}
