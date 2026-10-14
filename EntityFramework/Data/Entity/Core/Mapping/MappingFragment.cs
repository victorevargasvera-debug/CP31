using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000548 RID: 1352
	public class MappingFragment : global::System.Data.Entity.Core.Mapping.StructuralTypeMapping
	{
		// Token: 0x0600422E RID: 16942 RVA: 0x000DFC08 File Offset: 0x000DDE08
		public MappingFragment(global::System.Data.Entity.Core.Metadata.Edm.EntitySet storeEntitySet, global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping, bool makeColumnsDistinct)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(storeEntitySet, "storeEntitySet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.TypeMapping>(typeMapping, "typeMapping");
			this.m_tableExtent = storeEntitySet;
			this.m_typeMapping = typeMapping;
			this.m_isSQueryDistinct = makeColumnsDistinct;
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x000DFC6E File Offset: 0x000DDE6E
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> ColumnMappings
		{
			get
			{
				return this._columnMappings;
			}
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x000DFC78 File Offset: 0x000DDE78
		internal void AddColumnMapping(global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>(columnMappingBuilder, "columnMappingBuilder");
			if (!columnMappingBuilder.PropertyPath.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() || this._columnMappings.Contains(columnMappingBuilder))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidColumnBuilderArgument("columnBuilderMapping"));
			}
			this._columnMappings.Add(columnMappingBuilder);
			global::System.Data.Entity.Core.Mapping.StructuralTypeMapping structuralTypeMapping = this;
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping, bool> <>9__1;
			int i;
			for (i = 0; i < columnMappingBuilder.PropertyPath.Count - 1; i++)
			{
				property = columnMappingBuilder.PropertyPath[i];
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping> source = structuralTypeMapping.PropertyMappings.OfType<global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping>();
				global::System.Func<global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping, bool> predicate;
				if ((predicate = <>9__1) == null)
				{
					predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping pm) => pm.Property == property));
				}
				global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = source.SingleOrDefault(predicate);
				global::System.Data.Entity.Core.Mapping.ComplexTypeMapping complexTypeMapping = null;
				if (complexPropertyMapping == null)
				{
					complexTypeMapping = new global::System.Data.Entity.Core.Mapping.ComplexTypeMapping(false);
					complexTypeMapping.AddType(property.ComplexType);
					complexPropertyMapping = new global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping(property);
					complexPropertyMapping.AddTypeMapping(complexTypeMapping);
					structuralTypeMapping.AddPropertyMapping(complexPropertyMapping);
				}
				structuralTypeMapping = (complexTypeMapping ?? complexPropertyMapping.TypeMappings.Single<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping>());
			}
			property = columnMappingBuilder.PropertyPath[i];
			global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = structuralTypeMapping.PropertyMappings.OfType<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>().SingleOrDefault((global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping pm) => pm.Property == property);
			if (scalarPropertyMapping == null)
			{
				scalarPropertyMapping = new global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping(property, columnMappingBuilder.ColumnProperty);
				structuralTypeMapping.AddPropertyMapping(scalarPropertyMapping);
				columnMappingBuilder.SetTarget(scalarPropertyMapping);
				return;
			}
			scalarPropertyMapping.Column = columnMappingBuilder.ColumnProperty;
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x000DFDE4 File Offset: 0x000DDFE4
		internal void RemoveColumnMapping(global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder)
		{
			this._columnMappings.Remove(columnMappingBuilder);
			global::System.Data.Entity.Core.Mapping.MappingFragment.RemoveColumnMapping(this, columnMappingBuilder.PropertyPath);
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x000DFE00 File Offset: 0x000DE000
		private static void RemoveColumnMapping(global::System.Data.Entity.Core.Mapping.StructuralTypeMapping structuralTypeMapping, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> propertyPath)
		{
			global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping = structuralTypeMapping.PropertyMappings.Single((global::System.Data.Entity.Core.Mapping.PropertyMapping pm) => pm.Property == propertyPath.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
			if (propertyMapping is global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping)
			{
				structuralTypeMapping.RemovePropertyMapping(propertyMapping);
				return;
			}
			global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = (global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping)propertyMapping;
			global::System.Data.Entity.Core.Mapping.ComplexTypeMapping complexTypeMapping = complexPropertyMapping.TypeMappings.Single<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping>();
			global::System.Data.Entity.Core.Mapping.MappingFragment.RemoveColumnMapping(complexTypeMapping, propertyPath.Skip(1));
			if (!complexTypeMapping.PropertyMappings.Any<global::System.Data.Entity.Core.Mapping.PropertyMapping>())
			{
				structuralTypeMapping.RemovePropertyMapping(complexPropertyMapping);
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06004233 RID: 16947 RVA: 0x000DFE79 File Offset: 0x000DE079
		// (set) Token: 0x06004234 RID: 16948 RVA: 0x000DFE81 File Offset: 0x000DE081
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet StoreEntitySet
		{
			get
			{
				return this.m_tableExtent;
			}
			internal set
			{
				this.m_tableExtent = value;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06004235 RID: 16949 RVA: 0x000DFE8A File Offset: 0x000DE08A
		// (set) Token: 0x06004236 RID: 16950 RVA: 0x000DFE92 File Offset: 0x000DE092
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet TableSet
		{
			get
			{
				return this.StoreEntitySet;
			}
			set
			{
				this.StoreEntitySet = value;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06004237 RID: 16951 RVA: 0x000DFE9B File Offset: 0x000DE09B
		internal global::System.Data.Entity.Core.Metadata.Edm.EntityType Table
		{
			get
			{
				return this.m_tableExtent.ElementType;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06004238 RID: 16952 RVA: 0x000DFEA8 File Offset: 0x000DE0A8
		public global::System.Data.Entity.Core.Mapping.TypeMapping TypeMapping
		{
			get
			{
				return this.m_typeMapping;
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06004239 RID: 16953 RVA: 0x000DFEB0 File Offset: 0x000DE0B0
		public bool MakeColumnsDistinct
		{
			get
			{
				return this.m_isSQueryDistinct;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600423A RID: 16954 RVA: 0x000DFEB8 File Offset: 0x000DE0B8
		internal bool IsSQueryDistinct
		{
			get
			{
				return this.MakeColumnsDistinct;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600423B RID: 16955 RVA: 0x000DFEC0 File Offset: 0x000DE0C0
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping> AllProperties
		{
			get
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>();
				list.AddRange(this.m_properties);
				list.AddRange(this.m_conditionProperties.Values);
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping>(list);
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600423C RID: 16956 RVA: 0x000DFEE9 File Offset: 0x000DE0E9
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping> PropertyMappings
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping>(this.m_properties);
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x0600423D RID: 16957 RVA: 0x000DFEF6 File Offset: 0x000DE0F6
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> Conditions
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(this.m_conditionProperties.Values));
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x000DFF0D File Offset: 0x000DE10D
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> FlattenedProperties
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.MappingFragment.GetFlattenedProperties(this.m_properties, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
			}
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x000DFF1F File Offset: 0x000DE11F
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> GetFlattenedProperties(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.PropertyMapping> propertyMappings, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> propertyPath)
		{
			foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in propertyMappings)
			{
				propertyPath.Add(propertyMapping.Property);
				global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping;
				if (complexPropertyMapping != null)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder in global::System.Data.Entity.Core.Mapping.MappingFragment.GetFlattenedProperties(complexPropertyMapping.TypeMappings.Single<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping>().PropertyMappings, propertyPath))
					{
						yield return columnMappingBuilder;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> enumerator2 = null;
				}
				else
				{
					global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = propertyMapping as global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping;
					if (scalarPropertyMapping != null)
					{
						yield return new global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder(scalarPropertyMapping.Column, propertyPath.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
					}
				}
				propertyPath.Remove(propertyMapping.Property);
				propertyMapping = null;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.PropertyMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06004240 RID: 16960 RVA: 0x000DFF36 File Offset: 0x000DE136
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> ColumnConditions
		{
			get
			{
				return this.m_conditionProperties.Values;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06004241 RID: 16961 RVA: 0x000DFF43 File Offset: 0x000DE143
		// (set) Token: 0x06004242 RID: 16962 RVA: 0x000DFF4B File Offset: 0x000DE14B
		internal int StartLineNumber { get; set; }

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06004243 RID: 16963 RVA: 0x000DFF54 File Offset: 0x000DE154
		// (set) Token: 0x06004244 RID: 16964 RVA: 0x000DFF5C File Offset: 0x000DE15C
		internal int StartLinePosition { get; set; }

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06004245 RID: 16965 RVA: 0x000DFF65 File Offset: 0x000DE165
		internal string SourceLocation
		{
			get
			{
				return this.m_typeMapping.SetMapping.EntityContainerMapping.SourceLocation;
			}
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x000DFF7C File Offset: 0x000DE17C
		public override void AddPropertyMapping(global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.PropertyMapping>(propertyMapping, "propertyMapping");
			base.ThrowIfReadOnly();
			this.m_properties.Add(propertyMapping);
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x000DFF9C File Offset: 0x000DE19C
		public override void RemovePropertyMapping(global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.PropertyMapping>(propertyMapping, "propertyMapping");
			base.ThrowIfReadOnly();
			this.m_properties.Remove(propertyMapping);
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x000DFFBD File Offset: 0x000DE1BD
		public override void AddCondition(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(condition, "condition");
			base.ThrowIfReadOnly();
			this.AddConditionProperty(condition);
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x000DFFD8 File Offset: 0x000DE1D8
		public override void RemoveCondition(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(condition, "condition");
			base.ThrowIfReadOnly();
			this.RemoveConditionProperty(condition);
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x000DFFF3 File Offset: 0x000DE1F3
		internal void ClearConditions()
		{
			this.m_conditionProperties.Clear();
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x000E0000 File Offset: 0x000DE200
		internal override void SetReadOnly()
		{
			this.m_properties.TrimExcess();
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this.m_properties);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this.m_conditionProperties.Values);
			base.SetReadOnly();
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x000E0030 File Offset: 0x000DE230
		internal void RemoveConditionProperty(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty key = condition.Property ?? condition.Column;
			this.m_conditionProperties.Remove(key);
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x000E005B File Offset: 0x000DE25B
		internal void AddConditionProperty(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMap)
		{
			this.AddConditionProperty(conditionPropertyMap, delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmMember _)
			{
			});
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x000E0084 File Offset: 0x000DE284
		internal void AddConditionProperty(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMap, global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> duplicateMemberConditionError)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = conditionPropertyMap.Property ?? conditionPropertyMap.Column;
			if (!this.m_conditionProperties.ContainsKey(edmProperty))
			{
				this.m_conditionProperties.Add(edmProperty, conditionPropertyMap);
				return;
			}
			duplicateMemberConditionError(edmProperty);
		}

		// Token: 0x04001764 RID: 5988
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> _columnMappings = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>();

		// Token: 0x04001765 RID: 5989
		private global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_tableExtent;

		// Token: 0x04001766 RID: 5990
		private readonly global::System.Data.Entity.Core.Mapping.TypeMapping m_typeMapping;

		// Token: 0x04001767 RID: 5991
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> m_conditionProperties = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Default);

		// Token: 0x04001768 RID: 5992
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping> m_properties = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.PropertyMapping>();

		// Token: 0x04001769 RID: 5993
		private readonly bool m_isSQueryDistinct;
	}
}
