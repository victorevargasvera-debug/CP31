using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F2 RID: 498
	public class DateTimePropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration
	{
		// Token: 0x06001A1E RID: 6686 RVA: 0x00045BDB File Offset: 0x00043DDB
		internal DateTimePropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration configuration) : base(configuration)
		{
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00045BE4 File Offset: 0x00043DE4
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration IsOptional()
		{
			base.IsOptional();
			return this;
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00045BEE File Offset: 0x00043DEE
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration IsRequired()
		{
			base.IsRequired();
			return this;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00045BF8 File Offset: 0x00043DF8
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration HasDatabaseGeneratedOption(global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption? databaseGeneratedOption)
		{
			base.HasDatabaseGeneratedOption(databaseGeneratedOption);
			return this;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00045C03 File Offset: 0x00043E03
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration IsConcurrencyToken()
		{
			base.IsConcurrencyToken();
			return this;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00045C0D File Offset: 0x00043E0D
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration IsConcurrencyToken(bool? concurrencyToken)
		{
			base.IsConcurrencyToken(concurrencyToken);
			return this;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00045C18 File Offset: 0x00043E18
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration HasColumnName(string columnName)
		{
			base.HasColumnName(columnName);
			return this;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00045C23 File Offset: 0x00043E23
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration HasColumnAnnotation(string name, object value)
		{
			base.HasColumnAnnotation(name, value);
			return this;
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00045C2F File Offset: 0x00043E2F
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration HasColumnType(string columnType)
		{
			base.HasColumnType(columnType);
			return this;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00045C3A File Offset: 0x00043E3A
		public new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration HasColumnOrder(int? columnOrder)
		{
			base.HasColumnOrder(columnOrder);
			return this;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00045C45 File Offset: 0x00043E45
		public global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration HasPrecision(byte value)
		{
			this.Configuration.Precision = new byte?(value);
			return this;
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x00045C59 File Offset: 0x00043E59
		internal new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration Configuration
		{
			get
			{
				return (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration)base.Configuration;
			}
		}
	}
}
