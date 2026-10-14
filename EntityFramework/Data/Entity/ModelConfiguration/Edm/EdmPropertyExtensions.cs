using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000165 RID: 357
	internal static class EdmPropertyExtensions
	{
		// Token: 0x0600165E RID: 5726 RVA: 0x0003A12C File Offset: 0x0003832C
		public static void CopyFrom(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty other)
		{
			column.IsFixedLength = other.IsFixedLength;
			column.IsMaxLength = other.IsMaxLength;
			column.IsUnicode = other.IsUnicode;
			column.MaxLength = other.MaxLength;
			column.Precision = other.Precision;
			column.Scale = other.Scale;
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0003A184 File Offset: 0x00038384
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty Clone(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty tableColumn)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty columnMetadata = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(tableColumn.Name, tableColumn.TypeUsage)
			{
				Nullable = tableColumn.Nullable,
				StoreGeneratedPattern = tableColumn.StoreGeneratedPattern,
				IsFixedLength = tableColumn.IsFixedLength,
				IsMaxLength = tableColumn.IsMaxLength,
				IsUnicode = tableColumn.IsUnicode,
				MaxLength = tableColumn.MaxLength,
				Precision = tableColumn.Precision,
				Scale = tableColumn.Scale
			};
			tableColumn.Annotations.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty a)
			{
				columnMetadata.GetMetadataProperties().Add(a);
			});
			return columnMetadata;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0003A22B File Offset: 0x0003842B
		public static int? GetOrder(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty tableColumn)
		{
			return (int?)tableColumn.Annotations.GetAnnotation("Order");
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0003A242 File Offset: 0x00038442
		public static void SetOrder(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty tableColumn, int order)
		{
			tableColumn.GetMetadataProperties().SetAnnotation("Order", order);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0003A25A File Offset: 0x0003845A
		public static string GetPreferredName(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty tableColumn)
		{
			return (string)tableColumn.Annotations.GetAnnotation("PreferredName");
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0003A271 File Offset: 0x00038471
		public static void SetPreferredName(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty tableColumn, string name)
		{
			tableColumn.GetMetadataProperties().SetAnnotation("PreferredName", name);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0003A284 File Offset: 0x00038484
		public static string GetUnpreferredUniqueName(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty tableColumn)
		{
			return (string)tableColumn.Annotations.GetAnnotation("UnpreferredUniqueName");
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0003A29B File Offset: 0x0003849B
		public static void SetUnpreferredUniqueName(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty tableColumn, string name)
		{
			tableColumn.GetMetadataProperties().SetAnnotation("UnpreferredUniqueName", name);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0003A2AE File Offset: 0x000384AE
		public static void RemoveStoreGeneratedIdentityPattern(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty tableColumn)
		{
			if (tableColumn.StoreGeneratedPattern == global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity)
			{
				tableColumn.StoreGeneratedPattern = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None;
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0003A2C0 File Offset: 0x000384C0
		public static bool HasStoreGeneratedPattern(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern? storeGeneratedPattern = property.GetStoreGeneratedPattern();
			if (storeGeneratedPattern != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern? storeGeneratedPattern2 = storeGeneratedPattern;
				global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern storeGeneratedPattern3 = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None;
				return !(storeGeneratedPattern2.GetValueOrDefault() == storeGeneratedPattern3 & storeGeneratedPattern2 != null);
			}
			return false;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0003A2F8 File Offset: 0x000384F8
		public static global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern? GetStoreGeneratedPattern(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty;
			if (property.MetadataProperties.TryGetValue("http://schemas.microsoft.com/ado/2009/02/edm/annotation:StoreGeneratedPattern", false, out metadataProperty))
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern?)global::System.Enum.Parse(typeof(global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern), (string)metadataProperty.Value);
			}
			return null;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0003A344 File Offset: 0x00038544
		public static void SetStoreGeneratedPattern(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern storeGeneratedPattern)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty;
			if (!property.MetadataProperties.TryGetValue("http://schemas.microsoft.com/ado/2009/02/edm/annotation:StoreGeneratedPattern", false, out metadataProperty))
			{
				property.MetadataProperties.Source.Add(new global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty("http://schemas.microsoft.com/ado/2009/02/edm/annotation:StoreGeneratedPattern", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)), storeGeneratedPattern.ToString()));
				return;
			}
			metadataProperty.Value = storeGeneratedPattern.ToString();
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0003A3B2 File Offset: 0x000385B2
		public static object GetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			return property.Annotations.GetConfiguration();
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0003A3BF File Offset: 0x000385BF
		public static void SetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, object configuration)
		{
			property.GetMetadataProperties().SetConfiguration(configuration);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0003A3CD File Offset: 0x000385CD
		public static global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> ToPropertyPathList(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			return property.ToPropertyPathList(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0003A3DA File Offset: 0x000385DA
		public static global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> ToPropertyPathList(this global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> currentPath)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> list = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath>();
			global::System.Data.Entity.ModelConfiguration.Edm.EdmPropertyExtensions.IncludePropertyPath(list, currentPath, property);
			return list;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0003A3EC File Offset: 0x000385EC
		private static void IncludePropertyPath(global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> propertyPaths, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> currentPath, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			currentPath.Add(property);
			if (property.IsUnderlyingPrimitiveType)
			{
				propertyPaths.Add(new global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath(currentPath));
			}
			else if (property.IsComplexType)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property2 in property.ComplexType.Properties)
				{
					global::System.Data.Entity.ModelConfiguration.Edm.EdmPropertyExtensions.IncludePropertyPath(propertyPaths, currentPath, property2);
				}
			}
			currentPath.Remove(property);
		}

		// Token: 0x04000A05 RID: 2565
		private const string OrderAnnotation = "Order";

		// Token: 0x04000A06 RID: 2566
		private const string PreferredNameAnnotation = "PreferredName";

		// Token: 0x04000A07 RID: 2567
		private const string UnpreferredUniqueNameAnnotation = "UnpreferredUniqueName";
	}
}
