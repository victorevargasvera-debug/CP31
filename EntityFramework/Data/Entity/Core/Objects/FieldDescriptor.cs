using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200040B RID: 1035
	internal sealed class FieldDescriptor : global::System.ComponentModel.PropertyDescriptor
	{
		// Token: 0x0600312A RID: 12586 RVA: 0x0009BE07 File Offset: 0x0009A007
		internal FieldDescriptor(string propertyName) : base(propertyName, null)
		{
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x0009BE11 File Offset: 0x0009A011
		internal FieldDescriptor(global::System.Type itemType, bool isReadOnly, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property) : base(property.Name, null)
		{
			this._itemType = itemType;
			this._property = property;
			this._isReadOnly = isReadOnly;
			this._fieldType = this.DetermineClrType(this._property.TypeUsage);
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x0009BE4C File Offset: 0x0009A04C
		private global::System.Type DetermineClrType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Type type = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = typeUsage.EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType.BuiltInTypeKind;
			if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
				{
					if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType || builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
					{
						type = edmType.ClrType;
					}
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmType).TypeUsage;
					type = this.DetermineClrType(typeUsage2);
					type = typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
					{
						type
					});
				}
			}
			else if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType || builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
				{
					type = edmType.ClrType;
					global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
					if (type.IsValueType() && typeUsage.Facets.TryGetValue("Nullable", false, out facet) && (bool)facet.Value)
					{
						type = typeof(global::System.Nullable<>).MakeGenericType(new global::System.Type[]
						{
							type
						});
					}
				}
			}
			else if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType)
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
				{
					type = typeof(global::System.Data.IDataRecord);
				}
			}
			else
			{
				type = typeof(global::System.Data.Entity.Core.EntityKey);
			}
			return type;
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x0009BF55 File Offset: 0x0009A155
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmProperty EdmProperty
		{
			get
			{
				return this._property;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x0009BF5D File Offset: 0x0009A15D
		public override global::System.Type ComponentType
		{
			get
			{
				return this._itemType;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x0009BF65 File Offset: 0x0009A165
		public override bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0009BF6D File Offset: 0x0009A16D
		public override global::System.Type PropertyType
		{
			get
			{
				return this._fieldType;
			}
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x0009BF75 File Offset: 0x0009A175
		public override bool CanResetValue(object item)
		{
			return false;
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x0009BF78 File Offset: 0x0009A178
		public override object GetValue(object item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(item, "item");
			if (!this._itemType.IsAssignableFrom(item.GetType()))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectView_IncompatibleArgument);
			}
			global::System.Data.Common.DbDataRecord dbDataRecord = item as global::System.Data.Common.DbDataRecord;
			object value;
			if (dbDataRecord != null)
			{
				value = dbDataRecord.GetValue(dbDataRecord.GetOrdinal(this._property.Name));
			}
			else
			{
				value = global::System.Data.Entity.Core.Objects.DelegateFactory.GetValue(this._property, item);
			}
			return value;
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x0009BFE1 File Offset: 0x0009A1E1
		public override void ResetValue(object item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x0009BFE8 File Offset: 0x0009A1E8
		public override void SetValue(object item, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(item, "item");
			if (!this._itemType.IsAssignableFrom(item.GetType()))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectView_IncompatibleArgument);
			}
			if (!this._isReadOnly)
			{
				global::System.Data.Entity.Core.Objects.DelegateFactory.SetValue(this._property, item, value);
				return;
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectView_WriteOperationNotAllowedOnReadOnlyBindingList);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x0009C03F File Offset: 0x0009A23F
		public override bool ShouldSerializeValue(object item)
		{
			return false;
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x0009C042 File Offset: 0x0009A242
		public override bool IsBrowsable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04001036 RID: 4150
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _property;

		// Token: 0x04001037 RID: 4151
		private readonly global::System.Type _fieldType;

		// Token: 0x04001038 RID: 4152
		private readonly global::System.Type _itemType;

		// Token: 0x04001039 RID: 4153
		private readonly bool _isReadOnly;
	}
}
