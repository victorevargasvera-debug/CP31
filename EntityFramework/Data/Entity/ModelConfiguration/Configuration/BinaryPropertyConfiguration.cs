using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F1 RID: 497
	public class BinaryPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.LengthPropertyConfiguration
	{
		// Token: 0x06001A0E RID: 6670 RVA: 0x00045B27 File Offset: 0x00043D27
		internal BinaryPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration configuration) : base(configuration)
		{
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00045B30 File Offset: 0x00043D30
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration IsMaxLength()
		{
			base.IsMaxLength();
			return this;
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x00045B3A File Offset: 0x00043D3A
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration HasMaxLength(int? value)
		{
			base.HasMaxLength(value);
			return this;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00045B45 File Offset: 0x00043D45
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration IsFixedLength()
		{
			base.IsFixedLength();
			return this;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00045B4F File Offset: 0x00043D4F
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration IsVariableLength()
		{
			base.IsVariableLength();
			return this;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00045B59 File Offset: 0x00043D59
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration IsOptional()
		{
			base.IsOptional();
			return this;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00045B63 File Offset: 0x00043D63
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration IsRequired()
		{
			base.IsRequired();
			return this;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00045B6D File Offset: 0x00043D6D
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration HasDatabaseGeneratedOption(global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption? databaseGeneratedOption)
		{
			base.HasDatabaseGeneratedOption(databaseGeneratedOption);
			return this;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00045B78 File Offset: 0x00043D78
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration IsConcurrencyToken()
		{
			base.IsConcurrencyToken();
			return this;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00045B82 File Offset: 0x00043D82
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration IsConcurrencyToken(bool? concurrencyToken)
		{
			base.IsConcurrencyToken(concurrencyToken);
			return this;
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00045B8D File Offset: 0x00043D8D
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration HasColumnName(string columnName)
		{
			base.HasColumnName(columnName);
			return this;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00045B98 File Offset: 0x00043D98
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration HasColumnAnnotation(string name, object value)
		{
			base.HasColumnAnnotation(name, value);
			return this;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00045BA4 File Offset: 0x00043DA4
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration HasColumnType(string columnType)
		{
			base.HasColumnType(columnType);
			return this;
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00045BAF File Offset: 0x00043DAF
		public new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration HasColumnOrder(int? columnOrder)
		{
			base.HasColumnOrder(columnOrder);
			return this;
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00045BBA File Offset: 0x00043DBA
		public global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration IsRowVersion()
		{
			this.Configuration.IsRowVersion = new bool?(true);
			return this;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00045BCE File Offset: 0x00043DCE
		internal new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration Configuration
		{
			get
			{
				return (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration)base.Configuration;
			}
		}
	}
}
