using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F5 RID: 501
	public class PrimitivePropertyConfiguration
	{
		// Token: 0x06001A3C RID: 6716 RVA: 0x00045DC6 File Offset: 0x00043FC6
		internal PrimitivePropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration configuration)
		{
			this._configuration = configuration;
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x00045DD5 File Offset: 0x00043FD5
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00045DDD File Offset: 0x00043FDD
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration IsOptional()
		{
			this.Configuration.IsNullable = new bool?(true);
			return this;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00045DF1 File Offset: 0x00043FF1
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration IsRequired()
		{
			this.Configuration.IsNullable = new bool?(false);
			return this;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00045E05 File Offset: 0x00044005
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration HasDatabaseGeneratedOption(global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption? databaseGeneratedOption)
		{
			if (databaseGeneratedOption != null && !global::System.Enum.IsDefined(typeof(global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption), databaseGeneratedOption))
			{
				throw new global::System.ArgumentOutOfRangeException("databaseGeneratedOption");
			}
			this.Configuration.DatabaseGeneratedOption = databaseGeneratedOption;
			return this;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00045E3F File Offset: 0x0004403F
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration IsConcurrencyToken()
		{
			this.IsConcurrencyToken(new bool?(true));
			return this;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00045E50 File Offset: 0x00044050
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration IsConcurrencyToken(bool? concurrencyToken)
		{
			this.Configuration.ConcurrencyMode = ((concurrencyToken == null) ? null : new global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode?(concurrencyToken.Value ? global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed : global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.None));
			return this;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00045E8F File Offset: 0x0004408F
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration HasColumnType(string columnType)
		{
			this.Configuration.ColumnType = columnType;
			return this;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00045E9E File Offset: 0x0004409E
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration HasColumnName(string columnName)
		{
			this.Configuration.ColumnName = columnName;
			return this;
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00045EAD File Offset: 0x000440AD
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration HasColumnAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.Configuration.SetAnnotation(name, value);
			return this;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00045EC9 File Offset: 0x000440C9
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration HasParameterName(string parameterName)
		{
			this.Configuration.ParameterName = parameterName;
			return this;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00045ED8 File Offset: 0x000440D8
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration HasColumnOrder(int? columnOrder)
		{
			if (columnOrder != null && columnOrder.Value < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("columnOrder");
			}
			this.Configuration.ColumnOrder = columnOrder;
			return this;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00045F05 File Offset: 0x00044105
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00045F0D File Offset: 0x0004410D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00045F16 File Offset: 0x00044116
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00045F1E File Offset: 0x0004411E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A8F RID: 2703
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration _configuration;
	}
}
