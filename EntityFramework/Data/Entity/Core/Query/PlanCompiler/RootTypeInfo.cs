using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000363 RID: 867
	internal class RootTypeInfo : global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo
	{
		// Token: 0x06002A24 RID: 10788 RVA: 0x00088598 File Offset: 0x00086798
		internal RootTypeInfo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap discriminatorMap) : base(type, null)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(type.EdmType.BaseType == null, "only root types allowed here");
			this.m_propertyMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			this.m_propertyRefList = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef>();
			this.m_discriminatorMap = discriminatorMap;
			this.TypeIdKind = global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdKind.Generated;
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000885E9 File Offset: 0x000867E9
		// (set) Token: 0x06002A26 RID: 10790 RVA: 0x000885F1 File Offset: 0x000867F1
		internal global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdKind TypeIdKind { get; set; }

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000885FA File Offset: 0x000867FA
		// (set) Token: 0x06002A28 RID: 10792 RVA: 0x00088602 File Offset: 0x00086802
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeIdType { get; set; }

		// Token: 0x06002A29 RID: 10793 RVA: 0x0008860B File Offset: 0x0008680B
		internal void AddPropertyMapping(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty)
		{
			this.m_propertyMap[propertyRef] = newProperty;
			if (propertyRef is global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdPropertyRef)
			{
				this.m_typeIdProperty = newProperty;
				return;
			}
			if (propertyRef is global::System.Data.Entity.Core.Query.PlanCompiler.EntitySetIdPropertyRef)
			{
				this.m_entitySetIdProperty = newProperty;
				return;
			}
			if (propertyRef is global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef)
			{
				this.m_nullSentinelProperty = newProperty;
			}
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00088649 File Offset: 0x00086849
		internal void AddPropertyRef(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef)
		{
			this.m_propertyRefList.Add(propertyRef);
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x00088657 File Offset: 0x00086857
		// (set) Token: 0x06002A2C RID: 10796 RVA: 0x0008865F File Offset: 0x0008685F
		internal new global::System.Data.Entity.Core.Metadata.Edm.RowType FlattenedType
		{
			get
			{
				return this.m_flattenedType;
			}
			set
			{
				this.m_flattenedType = value;
				this.m_flattenedTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(value);
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x00088674 File Offset: 0x00086874
		internal new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage FlattenedTypeUsage
		{
			get
			{
				return this.m_flattenedTypeUsage;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x0008867C File Offset: 0x0008687C
		internal global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap DiscriminatorMap
		{
			get
			{
				return this.m_discriminatorMap;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x00088684 File Offset: 0x00086884
		internal new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty EntitySetIdProperty
		{
			get
			{
				return this.m_entitySetIdProperty;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x0008868C File Offset: 0x0008688C
		internal new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty NullSentinelProperty
		{
			get
			{
				return this.m_nullSentinelProperty;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x00088694 File Offset: 0x00086894
		internal new global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> PropertyRefList
		{
			get
			{
				return this.m_propertyRefList;
			}
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x0008869C File Offset: 0x0008689C
		internal int GetNestedStructureOffset(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef property)
		{
			for (int i = 0; i < this.m_propertyRefList.Count; i++)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef nestedPropertyRef = this.m_propertyRefList[i] as global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef;
				if (nestedPropertyRef != null && nestedPropertyRef.InnerProperty.Equals(property))
				{
					return i;
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "no complex structure " + ((property != null) ? property.ToString() : null) + " found in TypeInfo");
			return 0;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00088708 File Offset: 0x00086908
		internal new bool TryGetNewProperty(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef, bool throwIfMissing, out global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			bool flag = this.m_propertyMap.TryGetValue(propertyRef, out property);
			if (throwIfMissing && !flag)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "Unable to find property " + ((propertyRef != null) ? propertyRef.ToString() : null) + " in type " + base.Type.EdmType.Identity);
			}
			return flag;
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x0008875C File Offset: 0x0008695C
		internal new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty TypeIdProperty
		{
			get
			{
				return this.m_typeIdProperty;
			}
		}

		// Token: 0x04000E73 RID: 3699
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> m_propertyRefList;

		// Token: 0x04000E74 RID: 3700
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> m_propertyMap;

		// Token: 0x04000E75 RID: 3701
		private global::System.Data.Entity.Core.Metadata.Edm.EdmProperty m_nullSentinelProperty;

		// Token: 0x04000E76 RID: 3702
		private global::System.Data.Entity.Core.Metadata.Edm.EdmProperty m_typeIdProperty;

		// Token: 0x04000E77 RID: 3703
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap m_discriminatorMap;

		// Token: 0x04000E78 RID: 3704
		private global::System.Data.Entity.Core.Metadata.Edm.EdmProperty m_entitySetIdProperty;

		// Token: 0x04000E79 RID: 3705
		private global::System.Data.Entity.Core.Metadata.Edm.RowType m_flattenedType;

		// Token: 0x04000E7A RID: 3706
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_flattenedTypeUsage;
	}
}
