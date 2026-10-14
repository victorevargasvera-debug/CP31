using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000524 RID: 1316
	public class ComplexTypeMapping : global::System.Data.Entity.Core.Mapping.StructuralTypeMapping
	{
		// Token: 0x060040EE RID: 16622 RVA: 0x000DA788 File Offset: 0x000D8988
		public ComplexTypeMapping(global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(complexType, "complexType");
			this.AddType(complexType);
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x000DA7F0 File Offset: 0x000D89F0
		internal ComplexTypeMapping(bool isPartial)
		{
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060040F0 RID: 16624 RVA: 0x000DA843 File Offset: 0x000D8A43
		public global::System.Data.Entity.Core.Metadata.Edm.ComplexType ComplexType
		{
			get
			{
				return this.m_types.Values.SingleOrDefault<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>();
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x000DA855 File Offset: 0x000D8A55
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> Types
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(this.m_types.Values));
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060040F2 RID: 16626 RVA: 0x000DA86C File Offset: 0x000D8A6C
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> IsOfTypes
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(this.m_isOfTypes.Values));
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x000DA883 File Offset: 0x000D8A83
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping> PropertyMappings
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>(this.m_properties.Values));
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060040F4 RID: 16628 RVA: 0x000DA89A File Offset: 0x000D8A9A
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> Conditions
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(this.m_conditionProperties.Values));
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x000DA8B1 File Offset: 0x000D8AB1
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping> AllProperties
		{
			get
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>();
				list.AddRange(this.m_properties.Values);
				list.AddRange(this.m_conditionProperties.Values);
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping>(list);
			}
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x000DA8DF File Offset: 0x000D8ADF
		internal void AddType(global::System.Data.Entity.Core.Metadata.Edm.ComplexType type)
		{
			this.m_types.Add(type.FullName, type);
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x000DA8F3 File Offset: 0x000D8AF3
		internal void AddIsOfType(global::System.Data.Entity.Core.Metadata.Edm.ComplexType type)
		{
			this.m_isOfTypes.Add(type.FullName, type);
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x000DA907 File Offset: 0x000D8B07
		public override void AddPropertyMapping(global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.PropertyMapping>(propertyMapping, "propertyMapping");
			base.ThrowIfReadOnly();
			this.m_properties.Add(propertyMapping.Property.Name, propertyMapping);
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x000DA932 File Offset: 0x000D8B32
		public override void RemovePropertyMapping(global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.PropertyMapping>(propertyMapping, "propertyMapping");
			base.ThrowIfReadOnly();
			this.m_properties.Remove(propertyMapping.Property.Name);
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x000DA95D File Offset: 0x000D8B5D
		public override void AddCondition(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(condition, "condition");
			base.ThrowIfReadOnly();
			this.AddConditionProperty(condition, delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmMember _)
			{
			});
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x000DA997 File Offset: 0x000D8B97
		public override void RemoveCondition(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(condition, "condition");
			base.ThrowIfReadOnly();
			this.m_conditionProperties.Remove(condition.Property ?? condition.Column);
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x000DA9C7 File Offset: 0x000D8BC7
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this.m_properties.Values);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this.m_conditionProperties.Values);
			base.SetReadOnly();
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x000DA9F0 File Offset: 0x000D8BF0
		internal void AddConditionProperty(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMap, global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> duplicateMemberConditionError)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (conditionPropertyMap.Property != null) ? conditionPropertyMap.Property : conditionPropertyMap.Column;
			if (!this.m_conditionProperties.ContainsKey(edmProperty))
			{
				this.m_conditionProperties.Add(edmProperty, conditionPropertyMap);
				return;
			}
			duplicateMemberConditionError(edmProperty);
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x000DAA38 File Offset: 0x000D8C38
		internal global::System.Data.Entity.Core.Metadata.Edm.ComplexType GetOwnerType(string memberName)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType in this.m_types.Values)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
				if (complexType.Members.TryGetValue(memberName, false, out edmMember) && edmMember is global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)
				{
					return complexType;
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType2 in this.m_isOfTypes.Values)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2;
				if (complexType2.Members.TryGetValue(memberName, false, out edmMember2) && edmMember2 is global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)
				{
					return complexType2;
				}
			}
			return null;
		}

		// Token: 0x04001687 RID: 5767
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.PropertyMapping> m_properties = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.PropertyMapping>(global::System.StringComparer.Ordinal);

		// Token: 0x04001688 RID: 5768
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> m_conditionProperties = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Default);

		// Token: 0x04001689 RID: 5769
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.ComplexType> m_types = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(global::System.StringComparer.Ordinal);

		// Token: 0x0400168A RID: 5770
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.ComplexType> m_isOfTypes = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(global::System.StringComparer.Ordinal);
	}
}
