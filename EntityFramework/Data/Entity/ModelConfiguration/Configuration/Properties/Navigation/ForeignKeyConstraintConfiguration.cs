using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation
{
	// Token: 0x0200020A RID: 522
	internal class ForeignKeyConstraintConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration
	{
		// Token: 0x06001BA3 RID: 7075 RVA: 0x0004B631 File Offset: 0x00049831
		public ForeignKeyConstraintConfiguration()
		{
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0004B644 File Offset: 0x00049844
		internal ForeignKeyConstraintConfiguration(global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> dependentProperties)
		{
			this._dependentProperties.AddRange(dependentProperties);
			this._isFullySpecified = true;
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0004B66A File Offset: 0x0004986A
		private ForeignKeyConstraintConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ForeignKeyConstraintConfiguration source)
		{
			this._dependentProperties.AddRange(source._dependentProperties);
			this._isFullySpecified = source._isFullySpecified;
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0004B69A File Offset: 0x0004989A
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ForeignKeyConstraintConfiguration(this);
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x0004B6A2 File Offset: 0x000498A2
		public override bool IsFullySpecified
		{
			get
			{
				return this._isFullySpecified;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0004B6AA File Offset: 0x000498AA
		internal global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> ToProperties
		{
			get
			{
				return this._dependentProperties;
			}
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0004B6B2 File Offset: 0x000498B2
		public void AddColumn(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			if (!this._dependentProperties.ContainsSame(propertyInfo))
			{
				this._dependentProperties.Add(propertyInfo);
			}
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0004B6DC File Offset: 0x000498DC
		internal override void Configure(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentEnd, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration)
		{
			if (!this._dependentProperties.Any<global::System.Reflection.PropertyInfo>())
			{
				return;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> enumerable = this._dependentProperties.AsEnumerable<global::System.Reflection.PropertyInfo>();
			if (!this.IsFullySpecified)
			{
				if (dependentEnd.GetEntityType().GetClrType() != entityTypeConfiguration.ClrType)
				{
					return;
				}
				var source = from p in this._dependentProperties
				select new
				{
					PropertyInfo = p,
					ColumnOrder = entityTypeConfiguration.Property(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(p), null).ColumnOrder
				};
				if (this._dependentProperties.Count > 1)
				{
					if (source.Any(p => p.ColumnOrder == null))
					{
						global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> dependentKeys = dependentEnd.GetEntityType().KeyProperties;
						if (dependentKeys.Count == this._dependentProperties.Count && source.All(fk => dependentKeys.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.GetClrPropertyInfo().IsSameAs(fk.PropertyInfo))))
						{
							enumerable = from p in dependentKeys
							select p.GetClrPropertyInfo();
							goto IL_177;
						}
						throw global::System.Data.Entity.Resources.Error.ForeignKeyAttributeConvention_OrderRequired(entityTypeConfiguration.ClrType);
					}
				}
				enumerable = from p in source
				orderby p.ColumnOrder
				select p.PropertyInfo;
			}
			IL_177:
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			foreach (global::System.Reflection.PropertyInfo propertyInfo in enumerable)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty declaredPrimitiveProperty = dependentEnd.GetEntityType().GetDeclaredPrimitiveProperty(propertyInfo);
				if (declaredPrimitiveProperty == null)
				{
					throw global::System.Data.Entity.Resources.Error.ForeignKeyPropertyNotFound(propertyInfo.Name, dependentEnd.GetEntityType().Name);
				}
				list.Add(declaredPrimitiveProperty);
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherEnd = associationType.GetOtherEnd(dependentEnd);
			global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = new global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint(otherEnd, dependentEnd, otherEnd.GetEntityType().KeyProperties, list);
			if (otherEnd.IsRequired())
			{
				referentialConstraint.ToProperties.Each((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Nullable = false);
			}
			associationType.Constraint = referentialConstraint;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0004B92C File Offset: 0x00049B2C
		public bool Equals(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ForeignKeyConstraintConfiguration other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			return other.ToProperties.SequenceEqual(this.ToProperties, new global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Reflection.PropertyInfo>((global::System.Reflection.PropertyInfo p1, global::System.Reflection.PropertyInfo p2) => p1.IsSameAs(p2)));
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0004B979 File Offset: 0x00049B79
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != typeof(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ForeignKeyConstraintConfiguration)) && this.Equals((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ForeignKeyConstraintConfiguration)obj)));
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0004B9AB File Offset: 0x00049BAB
		public override int GetHashCode()
		{
			return this.ToProperties.Aggregate(0, (int t, global::System.Reflection.PropertyInfo p) => t + p.GetHashCode());
		}

		// Token: 0x04000ACB RID: 2763
		private readonly global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> _dependentProperties = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>();

		// Token: 0x04000ACC RID: 2764
		private readonly bool _isFullySpecified;
	}
}
