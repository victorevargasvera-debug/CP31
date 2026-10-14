using System;
using System.Collections.Generic;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Mappers
{
	// Token: 0x0200015B RID: 347
	internal sealed class PropertyFilter
	{
		// Token: 0x060015FD RID: 5629 RVA: 0x00038001 File Offset: 0x00036201
		public PropertyFilter(global::System.Data.Entity.DbModelBuilderVersion modelBuilderVersion = global::System.Data.Entity.DbModelBuilderVersion.Latest)
		{
			this._modelBuilderVersion = modelBuilderVersion;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00038010 File Offset: 0x00036210
		public global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetProperties(global::System.Type type, bool declaredOnly, global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> explicitlyMappedProperties = null, global::System.Collections.Generic.IEnumerable<global::System.Type> knownTypes = null, bool includePrivate = false)
		{
			explicitlyMappedProperties = (explicitlyMappedProperties ?? global::System.Linq.Enumerable.Empty<global::System.Reflection.PropertyInfo>());
			knownTypes = (knownTypes ?? global::System.Linq.Enumerable.Empty<global::System.Type>());
			this.ValidatePropertiesForModelVersion(type, explicitlyMappedProperties);
			return from p in declaredOnly ? type.GetDeclaredProperties() : type.GetNonHiddenProperties()
			where !p.IsStatic() && p.IsValidStructuralProperty()
			let m = p.Getter()
			where (includePrivate || m.IsPublic || explicitlyMappedProperties.Contains(p) || knownTypes.Contains(p.PropertyType)) && (!declaredOnly || type.BaseType().GetInstanceProperties().All((global::System.Reflection.PropertyInfo bp) => bp.Name != p.Name)) && (this.EdmV3FeaturesSupported || (!global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter.IsEnumType(p.PropertyType) && !global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter.IsSpatialType(p.PropertyType) && !global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter.IsHierarchyIdType(p.PropertyType))) && (this.Ef6FeaturesSupported || !p.PropertyType.IsNested)
			select p;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00038128 File Offset: 0x00036328
		public void ValidatePropertiesForModelVersion(global::System.Type type, global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> explicitlyMappedProperties)
		{
			if (this._modelBuilderVersion == global::System.Data.Entity.DbModelBuilderVersion.Latest)
			{
				return;
			}
			if (!this.EdmV3FeaturesSupported)
			{
				global::System.Reflection.PropertyInfo propertyInfo = explicitlyMappedProperties.FirstOrDefault((global::System.Reflection.PropertyInfo p) => global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter.IsEnumType(p.PropertyType) || global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter.IsSpatialType(p.PropertyType) || global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter.IsHierarchyIdType(p.PropertyType));
				if (propertyInfo != null)
				{
					throw global::System.Data.Entity.Resources.Error.UnsupportedUseOfV3Type(type.Name, propertyInfo.Name);
				}
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x00038187 File Offset: 0x00036387
		public bool EdmV3FeaturesSupported
		{
			get
			{
				return this._modelBuilderVersion.GetEdmVersion() >= 3.0;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x000381A2 File Offset: 0x000363A2
		public bool Ef6FeaturesSupported
		{
			get
			{
				return this._modelBuilderVersion == global::System.Data.Entity.DbModelBuilderVersion.Latest || this._modelBuilderVersion >= global::System.Data.Entity.DbModelBuilderVersion.V6_0;
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000381BA File Offset: 0x000363BA
		private static bool IsEnumType(global::System.Type type)
		{
			type.TryUnwrapNullableType(out type);
			return type.IsEnum();
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000381CB File Offset: 0x000363CB
		private static bool IsHierarchyIdType(global::System.Type type)
		{
			type.TryUnwrapNullableType(out type);
			return type == typeof(global::System.Data.Entity.Hierarchy.HierarchyId);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000381E6 File Offset: 0x000363E6
		private static bool IsSpatialType(global::System.Type type)
		{
			type.TryUnwrapNullableType(out type);
			return type == typeof(global::System.Data.Entity.Spatial.DbGeometry) || type == typeof(global::System.Data.Entity.Spatial.DbGeography);
		}

		// Token: 0x040009FC RID: 2556
		private readonly global::System.Data.Entity.DbModelBuilderVersion _modelBuilderVersion;
	}
}
