using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive
{
	// Token: 0x02000204 RID: 516
	internal abstract class LengthPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00049B91 File Offset: 0x00047D91
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x00049B99 File Offset: 0x00047D99
		public bool? IsFixedLength { get; set; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00049BA2 File Offset: 0x00047DA2
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x00049BAA File Offset: 0x00047DAA
		public int? MaxLength { get; set; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00049BB3 File Offset: 0x00047DB3
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00049BBB File Offset: 0x00047DBB
		public bool? IsMaxLength { get; set; }

		// Token: 0x06001B4F RID: 6991 RVA: 0x00049BC4 File Offset: 0x00047DC4
		protected LengthPropertyConfiguration()
		{
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00049BCC File Offset: 0x00047DCC
		protected LengthPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration source) : base(source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration>(source, "source");
			this.IsFixedLength = source.IsFixedLength;
			this.MaxLength = source.MaxLength;
			this.IsMaxLength = source.IsMaxLength;
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00049C08 File Offset: 0x00047E08
		protected override void ConfigureProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			base.ConfigureProperty(property);
			if (this.IsFixedLength != null)
			{
				property.IsFixedLength = this.IsFixedLength;
			}
			if (this.MaxLength != null)
			{
				property.MaxLength = this.MaxLength;
			}
			if (this.IsMaxLength != null)
			{
				property.IsMaxLength = this.IsMaxLength.Value;
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00049C78 File Offset: 0x00047E78
		internal override void Configure(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription)
		{
			base.Configure(column, facetDescription);
			string facetName = facetDescription.FacetName;
			if (facetName != null)
			{
				if (facetName == "FixedLength")
				{
					bool? isFixedLength2;
					if (!facetDescription.IsConstant)
					{
						bool? isFixedLength = this.IsFixedLength;
						isFixedLength2 = ((isFixedLength != null) ? isFixedLength : column.IsFixedLength);
					}
					else
					{
						isFixedLength2 = null;
					}
					column.IsFixedLength = isFixedLength2;
					return;
				}
				if (!(facetName == "MaxLength"))
				{
					return;
				}
				int? maxLength2;
				if (!facetDescription.IsConstant)
				{
					int? maxLength = this.MaxLength;
					maxLength2 = ((maxLength != null) ? maxLength : column.MaxLength);
				}
				else
				{
					maxLength2 = null;
				}
				column.MaxLength = maxLength2;
				column.IsMaxLength = (!facetDescription.IsConstant && (this.IsMaxLength ?? column.IsMaxLength));
			}
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x00049D4C File Offset: 0x00047F4C
		internal override void CopyFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other)
		{
			base.CopyFrom(other);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration lengthPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration;
			if (lengthPropertyConfiguration != null)
			{
				this.IsFixedLength = lengthPropertyConfiguration.IsFixedLength;
				this.MaxLength = lengthPropertyConfiguration.MaxLength;
				this.IsMaxLength = lengthPropertyConfiguration.IsMaxLength;
			}
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00049D90 File Offset: 0x00047F90
		internal override void FillFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.FillFrom(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration lengthPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration;
			if (lengthPropertyConfiguration != null)
			{
				if (this.IsFixedLength == null)
				{
					this.IsFixedLength = lengthPropertyConfiguration.IsFixedLength;
				}
				if (this.MaxLength == null)
				{
					this.MaxLength = lengthPropertyConfiguration.MaxLength;
				}
				if (this.IsMaxLength == null)
				{
					this.IsMaxLength = lengthPropertyConfiguration.IsMaxLength;
				}
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00049E04 File Offset: 0x00048004
		internal override void MakeCompatibleWith(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.MakeCompatibleWith(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration lengthPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration;
			if (lengthPropertyConfiguration == null)
			{
				return;
			}
			if (lengthPropertyConfiguration.IsFixedLength != null)
			{
				this.IsFixedLength = null;
			}
			if (lengthPropertyConfiguration.MaxLength != null)
			{
				this.MaxLength = null;
			}
			if (lengthPropertyConfiguration.IsMaxLength != null)
			{
				this.IsMaxLength = null;
			}
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00049E84 File Offset: 0x00048084
		internal override bool IsCompatible(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace, out string errorMessage)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration lengthPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration;
			bool flag = base.IsCompatible(other, inCSpace, out errorMessage);
			bool flag2 = lengthPropertyConfiguration == null || base.IsCompatible<bool, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration c) => c.IsFixedLength, lengthPropertyConfiguration, ref errorMessage);
			bool flag3 = lengthPropertyConfiguration == null || base.IsCompatible<bool, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration c) => c.IsMaxLength, lengthPropertyConfiguration, ref errorMessage);
			bool flag4 = lengthPropertyConfiguration == null || base.IsCompatible<int, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration c) => c.MaxLength, lengthPropertyConfiguration, ref errorMessage);
			return flag && flag2 && flag3 && flag4;
		}
	}
}
