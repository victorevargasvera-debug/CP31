using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive
{
	// Token: 0x02000202 RID: 514
	internal class DateTimePropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
	{
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x000496CD File Offset: 0x000478CD
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x000496D5 File Offset: 0x000478D5
		public byte? Precision { get; set; }

		// Token: 0x06001B33 RID: 6963 RVA: 0x000496DE File Offset: 0x000478DE
		public DateTimePropertyConfiguration()
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000496E6 File Offset: 0x000478E6
		private DateTimePropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration source) : base(source)
		{
			this.Precision = source.Precision;
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000496FB File Offset: 0x000478FB
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration(this);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00049704 File Offset: 0x00047904
		protected override void ConfigureProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			base.ConfigureProperty(property);
			if (this.Precision != null)
			{
				property.Precision = this.Precision;
			}
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00049734 File Offset: 0x00047934
		internal override void Configure(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription)
		{
			base.Configure(column, facetDescription);
			string facetName = facetDescription.FacetName;
			if (facetName != null && facetName == "Precision")
			{
				byte? precision2;
				if (!facetDescription.IsConstant)
				{
					byte? precision = this.Precision;
					precision2 = ((precision != null) ? precision : column.Precision);
				}
				else
				{
					precision2 = null;
				}
				column.Precision = precision2;
			}
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00049794 File Offset: 0x00047994
		internal override void CopyFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other)
		{
			base.CopyFrom(other);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration dateTimePropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration;
			if (dateTimePropertyConfiguration != null)
			{
				this.Precision = dateTimePropertyConfiguration.Precision;
			}
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000497C0 File Offset: 0x000479C0
		internal override void FillFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.FillFrom(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration dateTimePropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration;
			if (dateTimePropertyConfiguration != null && this.Precision == null)
			{
				this.Precision = dateTimePropertyConfiguration.Precision;
			}
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000497FC File Offset: 0x000479FC
		internal override void MakeCompatibleWith(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.MakeCompatibleWith(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration dateTimePropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration;
			if (dateTimePropertyConfiguration == null)
			{
				return;
			}
			if (dateTimePropertyConfiguration.Precision != null)
			{
				this.Precision = null;
			}
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0004983C File Offset: 0x00047A3C
		internal override bool IsCompatible(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace, out string errorMessage)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration dateTimePropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration;
			bool flag = base.IsCompatible(other, inCSpace, out errorMessage);
			bool flag2 = dateTimePropertyConfiguration == null || base.IsCompatible<byte, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration c) => c.Precision, dateTimePropertyConfiguration, ref errorMessage);
			return flag && flag2;
		}
	}
}
