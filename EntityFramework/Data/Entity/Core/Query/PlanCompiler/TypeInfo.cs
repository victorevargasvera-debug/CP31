using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000373 RID: 883
	internal class TypeInfo
	{
		// Token: 0x06002ABD RID: 10941 RVA: 0x0008BBF8 File Offset: 0x00089DF8
		internal static global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo superTypeInfo, global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap discriminatorMap)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo result;
			if (superTypeInfo == null)
			{
				result = new global::System.Data.Entity.Core.Query.PlanCompiler.RootTypeInfo(type, discriminatorMap);
			}
			else
			{
				result = new global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo(type, superTypeInfo);
			}
			return result;
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x0008BC1B File Offset: 0x00089E1B
		protected TypeInfo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo superType)
		{
			this.m_type = type;
			this.m_immediateSubTypes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo>();
			this.m_superType = superType;
			if (superType != null)
			{
				superType.m_immediateSubTypes.Add(this);
				this.m_rootType = superType.RootType;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x0008BC57 File Offset: 0x00089E57
		internal bool IsRootType
		{
			get
			{
				return this.m_rootType == null;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x0008BC62 File Offset: 0x00089E62
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo> ImmediateSubTypes
		{
			get
			{
				return this.m_immediateSubTypes;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x0008BC6A File Offset: 0x00089E6A
		internal global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo SuperType
		{
			get
			{
				return this.m_superType;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x0008BC72 File Offset: 0x00089E72
		internal global::System.Data.Entity.Core.Query.PlanCompiler.RootTypeInfo RootType
		{
			get
			{
				return this.m_rootType ?? ((global::System.Data.Entity.Core.Query.PlanCompiler.RootTypeInfo)this);
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0008BC84 File Offset: 0x00089E84
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Type
		{
			get
			{
				return this.m_type;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x0008BC8C File Offset: 0x00089E8C
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x0008BC94 File Offset: 0x00089E94
		internal object TypeId { get; set; }

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x0008BC9D File Offset: 0x00089E9D
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.RowType FlattenedType
		{
			get
			{
				return this.RootType.FlattenedType;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0008BCAA File Offset: 0x00089EAA
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage FlattenedTypeUsage
		{
			get
			{
				return this.RootType.FlattenedTypeUsage;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x0008BCB7 File Offset: 0x00089EB7
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.EdmProperty EntitySetIdProperty
		{
			get
			{
				return this.RootType.EntitySetIdProperty;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0008BCC4 File Offset: 0x00089EC4
		internal bool HasEntitySetIdProperty
		{
			get
			{
				return this.RootType.EntitySetIdProperty != null;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x0008BCD4 File Offset: 0x00089ED4
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.EdmProperty NullSentinelProperty
		{
			get
			{
				return this.RootType.NullSentinelProperty;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x0008BCE1 File Offset: 0x00089EE1
		internal bool HasNullSentinelProperty
		{
			get
			{
				return this.RootType.NullSentinelProperty != null;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002ACC RID: 10956 RVA: 0x0008BCF1 File Offset: 0x00089EF1
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.EdmProperty TypeIdProperty
		{
			get
			{
				return this.RootType.TypeIdProperty;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x0008BCFE File Offset: 0x00089EFE
		internal bool HasTypeIdProperty
		{
			get
			{
				return this.RootType.TypeIdProperty != null;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06002ACE RID: 10958 RVA: 0x0008BD0E File Offset: 0x00089F0E
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> PropertyRefList
		{
			get
			{
				return this.RootType.PropertyRefList;
			}
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x0008BD1C File Offset: 0x00089F1C
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmProperty GetNewProperty(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty result;
			this.TryGetNewProperty(propertyRef, true, out result);
			return result;
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x0008BD35 File Offset: 0x00089F35
		internal bool TryGetNewProperty(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef, bool throwIfMissing, out global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty)
		{
			return this.RootType.TryGetNewProperty(propertyRef, throwIfMissing, out newProperty);
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x0008BD45 File Offset: 0x00089F45
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> GetKeyPropertyRefs()
		{
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType = null;
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(this.m_type, out refType))
			{
				entityTypeBase = refType.ElementType;
			}
			else
			{
				entityTypeBase = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(this.m_type);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in entityTypeBase.KeyMembers)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(edmMember is global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, "Non-EdmProperty key members are not supported");
				global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef simplePropertyRef = new global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef(edmMember);
				yield return simplePropertyRef;
			}
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Enumerator enumerator = default(global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x0008BD55 File Offset: 0x00089F55
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> GetIdentityPropertyRefs()
		{
			if (this.HasEntitySetIdProperty)
			{
				yield return global::System.Data.Entity.Core.Query.PlanCompiler.EntitySetIdPropertyRef.Instance;
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in this.GetKeyPropertyRefs())
			{
				yield return propertyRef;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x0008BD65 File Offset: 0x00089F65
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> GetAllPropertyRefs()
		{
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in this.PropertyRefList)
			{
				yield return propertyRef;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x0008BD75 File Offset: 0x00089F75
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetAllProperties()
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in this.FlattenedType.Properties)
			{
				yield return edmProperty;
			}
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator = default(global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x0008BD88 File Offset: 0x00089F88
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo> GetTypeHierarchy()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo> result = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo>();
			this.GetTypeHierarchy(result);
			return result;
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0008BDA4 File Offset: 0x00089FA4
		private void GetTypeHierarchy(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo> result)
		{
			result.Add(this);
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo in this.ImmediateSubTypes)
			{
				typeInfo.GetTypeHierarchy(result);
			}
		}

		// Token: 0x04000ECA RID: 3786
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_type;

		// Token: 0x04000ECB RID: 3787
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo> m_immediateSubTypes;

		// Token: 0x04000ECC RID: 3788
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo m_superType;

		// Token: 0x04000ECD RID: 3789
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.RootTypeInfo m_rootType;
	}
}
