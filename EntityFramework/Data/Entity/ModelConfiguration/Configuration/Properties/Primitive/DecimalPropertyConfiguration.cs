using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive
{
	// Token: 0x02000203 RID: 515
	internal class DecimalPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
	{
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x000498A5 File Offset: 0x00047AA5
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x000498AD File Offset: 0x00047AAD
		public byte? Precision { get; set; }

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x000498B6 File Offset: 0x00047AB6
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x000498BE File Offset: 0x00047ABE
		public byte? Scale { get; set; }

		// Token: 0x06001B40 RID: 6976 RVA: 0x000498C7 File Offset: 0x00047AC7
		public DecimalPropertyConfiguration()
		{
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x000498CF File Offset: 0x00047ACF
		private DecimalPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration source) : base(source)
		{
			this.Precision = source.Precision;
			this.Scale = source.Scale;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000498F0 File Offset: 0x00047AF0
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration(this);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x000498F8 File Offset: 0x00047AF8
		protected override void ConfigureProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			base.ConfigureProperty(property);
			if (this.Precision != null)
			{
				property.Precision = this.Precision;
			}
			if (this.Scale != null)
			{
				property.Scale = this.Scale;
			}
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00049944 File Offset: 0x00047B44
		internal override void Configure(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription)
		{
			base.Configure(column, facetDescription);
			string facetName = facetDescription.FacetName;
			if (facetName != null)
			{
				if (facetName == "Precision")
				{
					byte? precision;
					if (!facetDescription.IsConstant)
					{
						byte? b = this.Precision;
						precision = ((b != null) ? b : column.Precision);
					}
					else
					{
						precision = null;
					}
					column.Precision = precision;
					return;
				}
				if (!(facetName == "Scale"))
				{
					return;
				}
				byte? scale;
				if (!facetDescription.IsConstant)
				{
					byte? b = this.Scale;
					scale = ((b != null) ? b : column.Scale);
				}
				else
				{
					scale = null;
				}
				column.Scale = scale;
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x000499E8 File Offset: 0x00047BE8
		internal override void CopyFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other)
		{
			base.CopyFrom(other);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration decimalPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration;
			if (decimalPropertyConfiguration != null)
			{
				this.Precision = decimalPropertyConfiguration.Precision;
				this.Scale = decimalPropertyConfiguration.Scale;
			}
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00049A20 File Offset: 0x00047C20
		internal override void FillFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.FillFrom(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration decimalPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration;
			if (decimalPropertyConfiguration != null)
			{
				if (this.Precision == null)
				{
					this.Precision = decimalPropertyConfiguration.Precision;
				}
				if (this.Scale == null)
				{
					this.Scale = decimalPropertyConfiguration.Scale;
				}
			}
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00049A78 File Offset: 0x00047C78
		internal override void MakeCompatibleWith(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.MakeCompatibleWith(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration decimalPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration;
			if (decimalPropertyConfiguration == null)
			{
				return;
			}
			if (decimalPropertyConfiguration.Precision != null)
			{
				this.Precision = null;
			}
			if (decimalPropertyConfiguration.Scale != null)
			{
				this.Scale = null;
			}
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00049AD8 File Offset: 0x00047CD8
		internal override bool IsCompatible(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace, out string errorMessage)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration decimalPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration;
			bool flag = base.IsCompatible(other, inCSpace, out errorMessage);
			bool flag2 = decimalPropertyConfiguration == null || base.IsCompatible<byte, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration c) => c.Precision, decimalPropertyConfiguration, ref errorMessage);
			bool flag3 = decimalPropertyConfiguration == null || base.IsCompatible<byte, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration c) => c.Scale, decimalPropertyConfiguration, ref errorMessage);
			return flag && flag2 && flag3;
		}
	}
}
