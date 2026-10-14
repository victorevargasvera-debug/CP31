using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F3 RID: 499
	public class DecimalPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration
	{
		// Token: 0x06001A2A RID: 6698 RVA: 0x00045C66 File Offset: 0x00043E66
		internal DecimalPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration configuration) : base(configuration)
		{
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00045C6F File Offset: 0x00043E6F
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration IsOptional()
		{
			base.IsOptional();
			return this;
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00045C79 File Offset: 0x00043E79
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration IsRequired()
		{
			base.IsRequired();
			return this;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00045C83 File Offset: 0x00043E83
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration HasDatabaseGeneratedOption(global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption? databaseGeneratedOption)
		{
			base.HasDatabaseGeneratedOption(databaseGeneratedOption);
			return this;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00045C8E File Offset: 0x00043E8E
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration IsConcurrencyToken()
		{
			base.IsConcurrencyToken();
			return this;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00045C98 File Offset: 0x00043E98
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration IsConcurrencyToken(bool? concurrencyToken)
		{
			base.IsConcurrencyToken(concurrencyToken);
			return this;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00045CA3 File Offset: 0x00043EA3
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration HasColumnName(string columnName)
		{
			base.HasColumnName(columnName);
			return this;
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00045CAE File Offset: 0x00043EAE
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration HasColumnAnnotation(string name, object value)
		{
			base.HasColumnAnnotation(name, value);
			return this;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00045CBA File Offset: 0x00043EBA
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration HasColumnType(string columnType)
		{
			base.HasColumnType(columnType);
			return this;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00045CC5 File Offset: 0x00043EC5
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration HasColumnOrder(int? columnOrder)
		{
			base.HasColumnOrder(columnOrder);
			return this;
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00045CD0 File Offset: 0x00043ED0
		public global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration HasPrecision(byte precision, byte scale)
		{
			this.Configuration.Precision = new byte?(precision);
			this.Configuration.Scale = new byte?(scale);
			return this;
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00045CF5 File Offset: 0x00043EF5
		internal new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration Configuration
		{
			get
			{
				return (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration)base.Configuration;
			}
		}
	}
}
