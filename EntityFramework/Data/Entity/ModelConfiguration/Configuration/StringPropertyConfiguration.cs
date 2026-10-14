using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F7 RID: 503
	public class StringPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.LengthPropertyConfiguration
	{
		// Token: 0x06001A50 RID: 6736 RVA: 0x00045F68 File Offset: 0x00044168
		internal StringPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration configuration) : base(configuration)
		{
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00045F71 File Offset: 0x00044171
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration IsMaxLength()
		{
			base.IsMaxLength();
			return this;
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00045F7B File Offset: 0x0004417B
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration HasMaxLength(int? value)
		{
			base.HasMaxLength(value);
			return this;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00045F86 File Offset: 0x00044186
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration IsFixedLength()
		{
			base.IsFixedLength();
			return this;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00045F90 File Offset: 0x00044190
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration IsVariableLength()
		{
			base.IsVariableLength();
			return this;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00045F9A File Offset: 0x0004419A
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration IsOptional()
		{
			base.IsOptional();
			return this;
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00045FA4 File Offset: 0x000441A4
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration IsRequired()
		{
			base.IsRequired();
			return this;
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00045FAE File Offset: 0x000441AE
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration HasDatabaseGeneratedOption(global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption? databaseGeneratedOption)
		{
			base.HasDatabaseGeneratedOption(databaseGeneratedOption);
			return this;
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00045FB9 File Offset: 0x000441B9
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration IsConcurrencyToken()
		{
			base.IsConcurrencyToken();
			return this;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00045FC3 File Offset: 0x000441C3
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration IsConcurrencyToken(bool? concurrencyToken)
		{
			base.IsConcurrencyToken(concurrencyToken);
			return this;
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00045FCE File Offset: 0x000441CE
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration HasColumnName(string columnName)
		{
			base.HasColumnName(columnName);
			return this;
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00045FD9 File Offset: 0x000441D9
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration HasColumnAnnotation(string name, object value)
		{
			base.HasColumnAnnotation(name, value);
			return this;
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00045FE5 File Offset: 0x000441E5
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration HasColumnType(string columnType)
		{
			base.HasColumnType(columnType);
			return this;
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00045FF0 File Offset: 0x000441F0
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration HasColumnOrder(int? columnOrder)
		{
			base.HasColumnOrder(columnOrder);
			return this;
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00045FFB File Offset: 0x000441FB
		public global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration IsUnicode()
		{
			this.IsUnicode(new bool?(true));
			return this;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0004600B File Offset: 0x0004420B
		public global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration IsUnicode(bool? unicode)
		{
			this.Configuration.IsUnicode = unicode;
			return this;
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0004601A File Offset: 0x0004421A
		internal new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration Configuration
		{
			get
			{
				return (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration)base.Configuration;
			}
		}
	}
}
