using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000168 RID: 360
	internal static class EntityTypeExtensions
	{
		// Token: 0x06001672 RID: 5746 RVA: 0x0003A4D0 File Offset: 0x000386D0
		public static void AddColumn(this global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			column.SetPreferredName(column.Name);
			column.Name = table.Properties.UniquifyName(column.Name);
			table.AddMember(column);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0003A4FC File Offset: 0x000386FC
		public static void SetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.EntityType table, object configuration)
		{
			table.GetMetadataProperties().SetConfiguration(configuration);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0003A50A File Offset: 0x0003870A
		public static global::System.Data.Entity.Utilities.DatabaseName GetTableName(this global::System.Data.Entity.Core.Metadata.Edm.EntityType table)
		{
			return (global::System.Data.Entity.Utilities.DatabaseName)table.Annotations.GetAnnotation("TableName");
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0003A521 File Offset: 0x00038721
		public static void SetTableName(this global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Utilities.DatabaseName tableName)
		{
			table.GetMetadataProperties().SetAnnotation("TableName", tableName);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0003A534 File Offset: 0x00038734
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> ToHierarchy(this global::System.Data.Entity.Core.Metadata.Edm.EntityType edmType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.EdmType.SafeTraverseHierarchy<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(edmType);
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0003A53C File Offset: 0x0003873C
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetValidKey(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list2 = entityType.ToHierarchy().ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			for (int i = list2.Count - 1; i >= 0; i--)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = list2[i];
				if (entityType2.BaseType == null && entityType2.KeyProperties.Count > 0)
				{
					if (list != null)
					{
						return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
					}
					list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
					global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
					global::System.Collections.Generic.HashSet<string> hashSet2 = new global::System.Collections.Generic.HashSet<string>();
					global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> hashSet3 = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(from p in entityType2.DeclaredProperties
					where p != null
					select p);
					for (int j = 0; j < entityType2.KeyProperties.Count; j++)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = entityType2.KeyProperties[j];
						if (edmProperty == null || hashSet.Contains(edmProperty) || !hashSet3.Contains(edmProperty) || string.IsNullOrEmpty(edmProperty.Name) || string.IsNullOrWhiteSpace(edmProperty.Name) || hashSet2.Contains(edmProperty.Name))
						{
							return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
						}
						list.Add(edmProperty);
						hashSet.Add(edmProperty);
						hashSet2.Add(edmProperty.Name);
					}
				}
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerable = list;
			return enumerable ?? global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0003A690 File Offset: 0x00038890
		public static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetKeyProperties(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType> visitedTypes = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			global::System.Data.Entity.ModelConfiguration.Edm.EntityTypeExtensions.GetKeyProperties(visitedTypes, entityType, list);
			return list;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0003A6B0 File Offset: 0x000388B0
		private static void GetKeyProperties(global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntityType> visitedTypes, global::System.Data.Entity.Core.Metadata.Edm.EntityType visitingType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> keyProperties)
		{
			if (visitedTypes.Contains(visitingType))
			{
				return;
			}
			visitedTypes.Add(visitingType);
			if (visitingType.BaseType != null)
			{
				global::System.Data.Entity.ModelConfiguration.Edm.EntityTypeExtensions.GetKeyProperties(visitedTypes, (global::System.Data.Entity.Core.Metadata.Edm.EntityType)visitingType.BaseType, keyProperties);
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> keyProperties2 = visitingType.KeyProperties;
			if (keyProperties2.Count > 0)
			{
				keyProperties.AddRange(keyProperties2);
			}
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0003A704 File Offset: 0x00038904
		public static global::System.Data.Entity.Core.Metadata.Edm.EntityType GetRootType(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = entityType;
			while (edmType.BaseType != null)
			{
				edmType = edmType.BaseType;
			}
			return (global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0003A72A File Offset: 0x0003892A
		public static bool IsAncestorOf(this global::System.Data.Entity.Core.Metadata.Edm.EntityType ancestor, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			while (entityType != null)
			{
				if (entityType.BaseType == ancestor)
				{
					return true;
				}
				entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType;
			}
			return false;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x0003A74A File Offset: 0x0003894A
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> KeyProperties(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return entityType.GetRootType().KeyProperties;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0003A757 File Offset: 0x00038957
		public static object GetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return entityType.Annotations.GetConfiguration();
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x0003A764 File Offset: 0x00038964
		public static global::System.Type GetClrType(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return entityType.Annotations.GetClrType();
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x0003A771 File Offset: 0x00038971
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> TypeHierarchyIterator(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			yield return entityType;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> derivedTypes = model.GetDerivedTypes(entityType);
			if (derivedTypes != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 in derivedTypes)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType3 in entityType2.TypeHierarchyIterator(model))
					{
						yield return entityType3;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EntityType> enumerator2 = null;
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EntityType> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0003A788 File Offset: 0x00038988
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty AddComplexProperty(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, string name, global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = global::System.Data.Entity.Core.Metadata.Edm.EdmProperty.CreateComplex(name, complexType);
			entityType.AddMember(edmProperty);
			return edmProperty;
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0003A7A8 File Offset: 0x000389A8
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty GetDeclaredPrimitiveProperty(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Reflection.PropertyInfo propertyInfo)
		{
			return entityType.GetDeclaredPrimitiveProperties().SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.GetClrPropertyInfo().IsSameAs(propertyInfo));
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0003A7D9 File Offset: 0x000389D9
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetDeclaredPrimitiveProperties(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return from p in entityType.DeclaredProperties
			where p.IsUnderlyingPrimitiveType
			select p;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0003A808 File Offset: 0x00038A08
		public static global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty AddNavigationProperty(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, string name, global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = associationType.TargetEnd.GetEntityType();
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = associationType.TargetEnd.RelationshipMultiplicity.IsMany() ? entityType2.GetCollectionType() : entityType2;
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = new global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty(name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType))
			{
				RelationshipType = associationType,
				FromEndMember = associationType.SourceEnd,
				ToEndMember = associationType.TargetEnd
			};
			entityType.AddMember(navigationProperty);
			return navigationProperty;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0003A874 File Offset: 0x00038A74
		public static global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty GetNavigationProperty(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Reflection.PropertyInfo propertyInfo)
		{
			return entityType.NavigationProperties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty np) => np.GetClrPropertyInfo().IsSameAs(propertyInfo));
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0003A8A8 File Offset: 0x00038AA8
		public static bool IsRootOfSet(this global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> set)
		{
			return set.All((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et == entityType || entityType.IsAncestorOf(et) || et.GetRootType() != entityType.GetRootType());
		}

		// Token: 0x04000A08 RID: 2568
		private const string TableNameAnnotation = "TableName";
	}
}
