using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001B4 RID: 436
	public class SqlCePropertyMaxLengthConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EntityType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention, global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>
	{
		// Token: 0x06001795 RID: 6037 RVA: 0x0003EF0E File Offset: 0x0003D10E
		public SqlCePropertyMaxLengthConvention() : this(4000)
		{
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0003EF1B File Offset: 0x0003D11B
		public SqlCePropertyMaxLengthConvention(int length)
		{
			if (length <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length", global::System.Data.Entity.Resources.Strings.InvalidMaxLengthSize);
			}
			this._length = length;
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0003EF40 File Offset: 0x0003D140
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EntityType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo = model.ProviderInfo;
			if (providerInfo != null && providerInfo.IsSqlCe())
			{
				this.SetLength(item.DeclaredProperties);
			}
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x0003EF84 File Offset: 0x0003D184
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.ComplexType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo = model.ProviderInfo;
			if (providerInfo != null && providerInfo.IsSqlCe())
			{
				this.SetLength(item.Properties);
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0003EFC8 File Offset: 0x0003D1C8
		private void SetLength(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in properties)
			{
				if (edmProperty.IsPrimitiveType && (edmProperty.PrimitiveType == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String) || edmProperty.PrimitiveType == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary)))
				{
					this.SetDefaults(edmProperty);
				}
			}
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0003F038 File Offset: 0x0003D238
		private void SetDefaults(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			if (property.MaxLength == null && !property.IsMaxLength)
			{
				property.MaxLength = new int?(this._length);
			}
		}

		// Token: 0x04000A39 RID: 2617
		private const int DefaultLength = 4000;

		// Token: 0x04000A3A RID: 2618
		private readonly int _length;
	}
}
