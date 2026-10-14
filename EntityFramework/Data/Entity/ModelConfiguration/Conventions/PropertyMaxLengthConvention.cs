using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001B3 RID: 435
	public class PropertyMaxLengthConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EntityType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention, global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>
	{
		// Token: 0x0600178D RID: 6029 RVA: 0x0003EC6A File Offset: 0x0003CE6A
		public PropertyMaxLengthConvention() : this(128)
		{
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0003EC77 File Offset: 0x0003CE77
		public PropertyMaxLengthConvention(int length)
		{
			if (length <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length", global::System.Data.Entity.Resources.Strings.InvalidMaxLengthSize);
			}
			this._length = length;
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0003EC9A File Offset: 0x0003CE9A
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EntityType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			this.SetLength(item.DeclaredProperties, item.KeyProperties);
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0003ECC6 File Offset: 0x0003CEC6
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.ComplexType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			this.SetLength(item.Properties, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0003ECF4 File Offset: 0x0003CEF4
		private void SetLength(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> keyProperties)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in properties)
			{
				if (edmProperty.IsPrimitiveType)
				{
					if (edmProperty.PrimitiveType == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
					{
						this.SetStringDefaults(edmProperty, keyProperties.Contains(edmProperty));
					}
					if (edmProperty.PrimitiveType == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary))
					{
						this.SetBinaryDefaults(edmProperty, keyProperties.Contains(edmProperty));
					}
				}
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0003ED78 File Offset: 0x0003CF78
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			if (item.Constraint == null)
			{
				return;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> source = item.GetOtherEnd(item.Constraint.DependentEnd).GetEntityType().KeyProperties();
			if (source.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() != item.Constraint.ToProperties.Count)
			{
				return;
			}
			for (int i = 0; i < item.Constraint.ToProperties.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = item.Constraint.ToProperties[i];
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = source.ElementAt(i);
				if (edmProperty.PrimitiveType == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String) || edmProperty.PrimitiveType == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary))
				{
					edmProperty.IsUnicode = edmProperty2.IsUnicode;
					edmProperty.IsFixedLength = edmProperty2.IsFixedLength;
					edmProperty.MaxLength = edmProperty2.MaxLength;
					edmProperty.IsMaxLength = edmProperty2.IsMaxLength;
				}
			}
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0003EE60 File Offset: 0x0003D060
		private void SetStringDefaults(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, bool isKey)
		{
			if (property.IsUnicode == null)
			{
				property.IsUnicode = new bool?(true);
			}
			this.SetBinaryDefaults(property, isKey);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0003EE94 File Offset: 0x0003D094
		private void SetBinaryDefaults(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, bool isKey)
		{
			if (property.IsFixedLength == null)
			{
				property.IsFixedLength = new bool?(false);
			}
			if (property.MaxLength == null && !property.IsMaxLength)
			{
				if (!isKey)
				{
					bool? isFixedLength = property.IsFixedLength;
					bool flag = true;
					if (!(isFixedLength.GetValueOrDefault() == flag & isFixedLength != null))
					{
						property.IsMaxLength = true;
						return;
					}
				}
				property.MaxLength = new int?(this._length);
				return;
			}
		}

		// Token: 0x04000A37 RID: 2615
		private const int DefaultLength = 128;

		// Token: 0x04000A38 RID: 2616
		private readonly int _length;
	}
}
