using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive
{
	// Token: 0x02000201 RID: 513
	internal class BinaryPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration
	{
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x00049444 File Offset: 0x00047644
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0004944C File Offset: 0x0004764C
		public bool? IsRowVersion { get; set; }

		// Token: 0x06001B28 RID: 6952 RVA: 0x00049455 File Offset: 0x00047655
		public BinaryPropertyConfiguration()
		{
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0004945D File Offset: 0x0004765D
		private BinaryPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration source) : base(source)
		{
			this.IsRowVersion = source.IsRowVersion;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00049472 File Offset: 0x00047672
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration(this);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0004947C File Offset: 0x0004767C
		protected override void ConfigureProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			if (this.IsRowVersion != null && this.IsRowVersion.Value)
			{
				base.ConcurrencyMode = new global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode?(base.ConcurrencyMode ?? global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed);
				base.DatabaseGeneratedOption = new global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption?(base.DatabaseGeneratedOption ?? global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
				base.IsNullable = new bool?(base.IsNullable.GetValueOrDefault());
				base.MaxLength = new int?(base.MaxLength ?? 8);
			}
			base.ConfigureProperty(property);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00049540 File Offset: 0x00047740
		protected override void ConfigureColumn(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (this.IsRowVersion != null && this.IsRowVersion.Value)
			{
				base.ColumnType = (base.ColumnType ?? "rowversion");
			}
			base.ConfigureColumn(column, table, providerManifest);
			if (this.IsRowVersion != null && this.IsRowVersion.Value)
			{
				column.MaxLength = null;
			}
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x000495BC File Offset: 0x000477BC
		internal override void CopyFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other)
		{
			base.CopyFrom(other);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration binaryPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration;
			if (binaryPropertyConfiguration != null)
			{
				this.IsRowVersion = binaryPropertyConfiguration.IsRowVersion;
			}
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x000495E8 File Offset: 0x000477E8
		internal override void FillFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.FillFrom(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration binaryPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration;
			if (binaryPropertyConfiguration != null && this.IsRowVersion == null)
			{
				this.IsRowVersion = binaryPropertyConfiguration.IsRowVersion;
			}
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00049624 File Offset: 0x00047824
		internal override void MakeCompatibleWith(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.MakeCompatibleWith(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration binaryPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration;
			if (binaryPropertyConfiguration == null)
			{
				return;
			}
			if (binaryPropertyConfiguration.IsRowVersion != null)
			{
				this.IsRowVersion = null;
			}
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00049664 File Offset: 0x00047864
		internal override bool IsCompatible(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace, out string errorMessage)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration binaryPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration;
			bool flag = base.IsCompatible(other, inCSpace, out errorMessage);
			bool flag2 = binaryPropertyConfiguration == null || base.IsCompatible<bool, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration c) => c.IsRowVersion, binaryPropertyConfiguration, ref errorMessage);
			return flag && flag2;
		}
	}
}
