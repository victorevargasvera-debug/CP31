using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004CA RID: 1226
	internal static class Helper
	{
		// Token: 0x06003CAC RID: 15532 RVA: 0x000C8404 File Offset: 0x000C6604
		internal static string GetAttributeValue(global::System.Xml.XPath.XPathNavigator nav, string attributeName)
		{
			nav = nav.Clone();
			string result = null;
			if (nav.MoveToAttribute(attributeName, string.Empty))
			{
				result = nav.Value;
			}
			return result;
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x000C8434 File Offset: 0x000C6634
		internal static object GetTypedAttributeValue(global::System.Xml.XPath.XPathNavigator nav, string attributeName, global::System.Type clrType)
		{
			nav = nav.Clone();
			object result = null;
			if (nav.MoveToAttribute(attributeName, string.Empty))
			{
				result = nav.ValueAs(clrType);
			}
			return result;
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x000C8464 File Offset: 0x000C6664
		internal static global::System.Data.Entity.Core.Metadata.Edm.FacetDescription GetFacet(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> facetCollection, string facetName)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription in facetCollection)
			{
				if (facetDescription.FacetName == facetName)
				{
					return facetDescription;
				}
			}
			return null;
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x000C84BC File Offset: 0x000C66BC
		internal static bool IsAssignableFrom(global::System.Data.Entity.Core.Metadata.Edm.EdmType firstType, global::System.Data.Entity.Core.Metadata.Edm.EdmType secondType)
		{
			return secondType != null && (firstType.Equals(secondType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSubtypeOf(secondType, firstType));
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x000C84D8 File Offset: 0x000C66D8
		internal static bool IsSubtypeOf(global::System.Data.Entity.Core.Metadata.Edm.EdmType firstType, global::System.Data.Entity.Core.Metadata.Edm.EdmType secondType)
		{
			if (secondType == null)
			{
				return false;
			}
			for (global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType = firstType.BaseType; baseType != null; baseType = baseType.BaseType)
			{
				if (baseType == secondType)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x000C8504 File Offset: 0x000C6704
		internal static global::System.Collections.IList GetAllStructuralMembers(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType.BuiltInTypeKind;
			if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)edmType).AssociationEndMembers;
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)edmType).Properties;
				}
			}
			else
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType).Properties;
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType).Properties;
				}
			}
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyArrayEdmProperty;
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x000C8568 File Offset: 0x000C6768
		internal static global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember GetEndThatShouldBeMappedToKey(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			if (associationType.AssociationEndMembers.Any((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember it) => it.RelationshipMultiplicity.Equals(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)))
			{
				return associationType.AssociationEndMembers.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember it) => it.RelationshipMultiplicity.Equals(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many) || it.RelationshipMultiplicity.Equals(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne));
			}
			if (associationType.AssociationEndMembers.Any((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember it) => it.RelationshipMultiplicity.Equals(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)))
			{
				return associationType.AssociationEndMembers.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember it) => it.RelationshipMultiplicity.Equals(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many));
			}
			return null;
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x000C8624 File Offset: 0x000C6824
		internal static string GetCommaDelimitedString(global::System.Collections.Generic.IEnumerable<string> stringList)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			foreach (string value in stringList)
			{
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				else
				{
					flag = false;
				}
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x000C8690 File Offset: 0x000C6890
		internal static global::System.Collections.Generic.IEnumerable<T> Concat<T>(params global::System.Collections.Generic.IEnumerable<T>[] sources)
		{
			foreach (global::System.Collections.Generic.IEnumerable<T> enumerable in sources)
			{
				if (enumerable != null)
				{
					foreach (T t in enumerable)
					{
						yield return t;
					}
					global::System.Collections.Generic.IEnumerator<T> enumerator = null;
				}
			}
			global::System.Collections.Generic.IEnumerable<T>[] array = null;
			yield break;
			yield break;
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x000C86A0 File Offset: 0x000C68A0
		internal static void DisposeXmlReaders(global::System.Collections.Generic.IEnumerable<global::System.Xml.XmlReader> xmlReaders)
		{
			foreach (global::System.Xml.XmlReader xmlReader in xmlReaders)
			{
				((global::System.IDisposable)xmlReader).Dispose();
			}
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x000C86E8 File Offset: 0x000C68E8
		internal static bool IsStructuralType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(type) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(type) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipType(type) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(type);
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x000C870A File Offset: 0x000C690A
		internal static bool IsCollectionType(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == item.BuiltInTypeKind;
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x000C8715 File Offset: 0x000C6915
		internal static bool IsEntityType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType == type.BuiltInTypeKind;
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x000C8721 File Offset: 0x000C6921
		internal static bool IsComplexType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType == type.BuiltInTypeKind;
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x000C872C File Offset: 0x000C692C
		internal static bool IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType == type.BuiltInTypeKind;
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x000C8738 File Offset: 0x000C6938
		internal static bool IsRefType(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType == item.BuiltInTypeKind;
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x000C8744 File Offset: 0x000C6944
		internal static bool IsRowType(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType == item.BuiltInTypeKind;
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x000C8750 File Offset: 0x000C6950
		internal static bool IsAssociationType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType == type.BuiltInTypeKind;
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x000C875B File Offset: 0x000C695B
		internal static bool IsRelationshipType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType == type.BuiltInTypeKind;
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x000C8766 File Offset: 0x000C6966
		internal static bool IsEdmProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty == member.BuiltInTypeKind;
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x000C8772 File Offset: 0x000C6972
		internal static bool IsRelationshipEndMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return member.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationEndMember;
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x000C877D File Offset: 0x000C697D
		internal static bool IsAssociationEndMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return member.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationEndMember;
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x000C8788 File Offset: 0x000C6988
		internal static bool IsNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty == member.BuiltInTypeKind;
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x000C8794 File Offset: 0x000C6994
		internal static bool IsEntityTypeBase(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipType(edmType);
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x000C87A6 File Offset: 0x000C69A6
		internal static bool IsTransientType(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(edmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(edmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(edmType);
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x000C87C0 File Offset: 0x000C69C0
		internal static bool IsAssociationSet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet == entitySetBase.BuiltInTypeKind;
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x000C87CB File Offset: 0x000C69CB
		internal static bool IsEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet == entitySetBase.BuiltInTypeKind;
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x000C87D7 File Offset: 0x000C69D7
		internal static bool IsRelationshipSet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet == entitySetBase.BuiltInTypeKind;
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x000C87E2 File Offset: 0x000C69E2
		internal static bool IsEntityContainer(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityContainer == item.BuiltInTypeKind;
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x000C87EE File Offset: 0x000C69EE
		internal static bool IsEdmFunction(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmFunction == item.BuiltInTypeKind;
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x000C87FA File Offset: 0x000C69FA
		internal static string GetFileNameFromUri(global::System.Uri uri)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Uri>(uri, "uri");
			if (uri.IsFile)
			{
				return uri.LocalPath;
			}
			if (uri.IsAbsoluteUri)
			{
				return uri.AbsolutePath;
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.UnacceptableUri(uri), "uri");
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x000C8836 File Offset: 0x000C6A36
		internal static bool IsEnumType(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType == edmType.BuiltInTypeKind;
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x000C8842 File Offset: 0x000C6A42
		internal static bool IsUnboundedFacetValue(global::System.Data.Entity.Core.Metadata.Edm.Facet facet)
		{
			return facet.Value == global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.UnboundedValue;
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x000C8851 File Offset: 0x000C6A51
		internal static bool IsVariableFacetValue(global::System.Data.Entity.Core.Metadata.Edm.Facet facet)
		{
			return facet.Value == global::System.Data.Entity.Core.Metadata.Edm.EdmConstants.VariableValue;
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x000C8860 File Offset: 0x000C6A60
		internal static bool IsScalarType(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType);
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x000C8872 File Offset: 0x000C6A72
		internal static bool IsHierarchyIdType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type)
		{
			return type.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId;
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x000C887E File Offset: 0x000C6A7E
		internal static bool IsSpatialType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicType(type) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeometricType(type);
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x000C8890 File Offset: 0x000C6A90
		internal static bool IsSpatialType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, out bool isGeographic)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = type as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			if (primitiveType == null)
			{
				isGeographic = false;
				return false;
			}
			isGeographic = global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicType(primitiveType);
			return isGeographic || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeometricType(primitiveType);
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x000C88C0 File Offset: 0x000C6AC0
		internal static bool IsGeographicType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicTypeKind(type.PrimitiveTypeKind);
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x000C88CD File Offset: 0x000C6ACD
		internal static bool AreSameSpatialUnionType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType firstType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType secondType)
		{
			return (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicTypeKind(firstType.PrimitiveTypeKind) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicTypeKind(secondType.PrimitiveTypeKind)) || (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeometricTypeKind(firstType.PrimitiveTypeKind) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeometricTypeKind(secondType.PrimitiveTypeKind));
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x000C8908 File Offset: 0x000C6B08
		internal static bool IsGeographicTypeKind(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind kind)
		{
			return kind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStrongGeographicTypeKind(kind);
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x000C8917 File Offset: 0x000C6B17
		internal static bool IsGeometricType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeometricTypeKind(type.PrimitiveTypeKind);
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x000C8924 File Offset: 0x000C6B24
		internal static bool IsGeometricTypeKind(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind kind)
		{
			return kind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStrongGeometricTypeKind(kind);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x000C8933 File Offset: 0x000C6B33
		internal static bool IsStrongSpatialTypeKind(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind kind)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStrongGeometricTypeKind(kind) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStrongGeographicTypeKind(kind);
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x000C8945 File Offset: 0x000C6B45
		private static bool IsStrongGeometricTypeKind(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind kind)
		{
			return kind >= global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint && kind <= global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection;
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x000C8956 File Offset: 0x000C6B56
		private static bool IsStrongGeographicTypeKind(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind kind)
		{
			return kind >= global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint && kind <= global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection;
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x000C8967 File Offset: 0x000C6B67
		internal static bool IsHierarchyIdType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType && ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId;
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x000C898E File Offset: 0x000C6B8E
		internal static bool IsSpatialType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType);
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x000C89B4 File Offset: 0x000C6BB4
		internal static bool IsSpatialType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind spatialType)
		{
			if (type.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicTypeKind(primitiveType.PrimitiveTypeKind) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeometricTypeKind(primitiveType.PrimitiveTypeKind))
				{
					spatialType = primitiveType.PrimitiveTypeKind;
					return true;
				}
			}
			spatialType = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary;
			return false;
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x000C8A04 File Offset: 0x000C6C04
		internal static string ToString(global::System.Data.ParameterDirection value)
		{
			switch (value)
			{
			case global::System.Data.ParameterDirection.Input:
				return "Input";
			case global::System.Data.ParameterDirection.Output:
				return "Output";
			case global::System.Data.ParameterDirection.InputOutput:
				return "InputOutput";
			case global::System.Data.ParameterDirection.ReturnValue:
				return "ReturnValue";
			}
			return value.ToString();
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x000C8A58 File Offset: 0x000C6C58
		internal static string ToString(global::System.Data.Entity.Core.Metadata.Edm.ParameterMode value)
		{
			switch (value)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In:
				return "In";
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out:
				return "Out";
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut:
				return "InOut";
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue:
				return "ReturnValue";
			default:
				return value.ToString();
			}
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x000C8A97 File Offset: 0x000C6C97
		internal static bool IsSupportedEnumUnderlyingType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind typeKind)
		{
			return typeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte || typeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte || typeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16 || typeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32 || typeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64;
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x000C8AB2 File Offset: 0x000C6CB2
		internal static bool IsEnumMemberValueInRange(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind underlyingTypeKind, long value)
		{
			return value >= global::System.Data.Entity.Core.Metadata.Edm.Helper._enumUnderlyingTypeRanges[underlyingTypeKind][0] && value <= global::System.Data.Entity.Core.Metadata.Edm.Helper._enumUnderlyingTypeRanges[underlyingTypeKind][1];
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x000C8AD9 File Offset: 0x000C6CD9
		internal static global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType AsPrimitive(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(type))
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.GetUnderlyingEdmTypeForEnumType(type);
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x000C8AF0 File Offset: 0x000C6CF0
		internal static global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetUnderlyingEdmTypeForEnumType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return ((global::System.Data.Entity.Core.Metadata.Edm.EnumType)type).UnderlyingType;
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x000C8B00 File Offset: 0x000C6D00
		internal static global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetSpatialNormalizedPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicType(primitiveType) && primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeometricType(primitiveType) && primitiveType.PrimitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry);
			}
			return primitiveType;
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x000C8B4C File Offset: 0x000C6D4C
		internal static string CombineErrorMessage(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(global::System.Environment.NewLine);
			int num = 0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError value in errors)
			{
				if (num++ != 0)
				{
					stringBuilder.Append(global::System.Environment.NewLine);
				}
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x000C8BBC File Offset: 0x000C6DBC
		internal static string CombineErrorMessage(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> errors)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(global::System.Environment.NewLine);
			int num = 0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmItemError edmItemError in errors)
			{
				if (num++ != 0)
				{
					stringBuilder.Append(global::System.Environment.NewLine);
				}
				stringBuilder.Append(edmItemError.Message);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x000C8C30 File Offset: 0x000C6E30
		internal static global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<T, S>> PairEnumerations<T, S>(global::System.Data.Entity.Core.Metadata.Edm.IBaseList<T> left, global::System.Collections.Generic.IEnumerable<S> right)
		{
			global::System.Collections.IEnumerator leftEnumerator = left.GetEnumerator();
			global::System.Collections.Generic.IEnumerator<S> rightEnumerator = right.GetEnumerator();
			while (leftEnumerator.MoveNext() && rightEnumerator.MoveNext())
			{
				yield return new global::System.Collections.Generic.KeyValuePair<T, S>((T)((object)leftEnumerator.Current), rightEnumerator.Current);
			}
			yield break;
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x000C8C47 File Offset: 0x000C6E47
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			return typeUsage.ModelTypeUsage;
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x000C8C4F File Offset: 0x000C6E4F
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(member.TypeUsage);
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x000C8C5C File Offset: 0x000C6E5C
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateAndConvertTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty columnProperty)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.ValidateAndConvertTypeUsage(edmProperty.TypeUsage, columnProperty.TypeUsage);
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x000C8C70 File Offset: 0x000C6E70
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateAndConvertTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage cspaceType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage sspaceType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = sspaceType;
			if (sspaceType.EdmType.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
			{
				typeUsage = sspaceType.ModelTypeUsage;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.ValidateScalarTypesAreCompatible(cspaceType, typeUsage))
			{
				return typeUsage;
			}
			return null;
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x000C8CA0 File Offset: 0x000C6EA0
		private static bool ValidateScalarTypesAreCompatible(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage cspaceType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(cspaceType.EdmType))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetUnderlyingEdmTypeForEnumType(cspaceType.EdmType)), storeType);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(cspaceType, storeType);
		}

		// Token: 0x040014DD RID: 5341
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember[] EmptyArrayEdmProperty = new global::System.Data.Entity.Core.Metadata.Edm.EdmMember[0];

		// Token: 0x040014DE RID: 5342
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, long[]> _enumUnderlyingTypeRanges = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind, long[]>
		{
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte,
				new long[]
				{
					0L,
					255L
				}
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte,
				new long[]
				{
					-128L,
					127L
				}
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16,
				new long[]
				{
					-32768L,
					32767L
				}
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
				new long[]
				{
					-2147483648L,
					2147483647L
				}
			},
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64,
				new long[]
				{
					long.MinValue,
					long.MaxValue
				}
			}
		};

		// Token: 0x040014DF RID: 5343
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>> EmptyKeyValueStringObjectList = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>(new global::System.Collections.Generic.KeyValuePair<string, object>[0]);

		// Token: 0x040014E0 RID: 5344
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<string> EmptyStringList = new global::System.Collections.ObjectModel.ReadOnlyCollection<string>(new string[0]);

		// Token: 0x040014E1 RID: 5345
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> EmptyFacetDescriptionEnumerable = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[0]);

		// Token: 0x040014E2 RID: 5346
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> EmptyEdmFunctionReadOnlyCollection = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction[0]);

		// Token: 0x040014E3 RID: 5347
		internal static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> EmptyPrimitiveTypeReadOnlyCollection = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType[0]);

		// Token: 0x040014E4 RID: 5348
		internal static readonly global::System.Collections.Generic.KeyValuePair<string, object>[] EmptyKeyValueStringObjectArray = new global::System.Collections.Generic.KeyValuePair<string, object>[0];

		// Token: 0x040014E5 RID: 5349
		internal const char PeriodSymbol = '.';

		// Token: 0x040014E6 RID: 5350
		internal const char CommaSymbol = ',';
	}
}
