using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive
{
	// Token: 0x02000207 RID: 519
	internal class StringPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration
	{
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0004AF30 File Offset: 0x00049130
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x0004AF38 File Offset: 0x00049138
		public bool? IsUnicode { get; set; }

		// Token: 0x06001B85 RID: 7045 RVA: 0x0004AF41 File Offset: 0x00049141
		public StringPropertyConfiguration()
		{
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0004AF49 File Offset: 0x00049149
		private StringPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration source) : base(source)
		{
			this.IsUnicode = source.IsUnicode;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0004AF5E File Offset: 0x0004915E
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration(this);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0004AF68 File Offset: 0x00049168
		protected override void ConfigureProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			base.ConfigureProperty(property);
			if (this.IsUnicode != null)
			{
				property.IsUnicode = this.IsUnicode;
			}
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0004AF98 File Offset: 0x00049198
		internal override void Configure(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Data.Entity.Core.Metadata.Edm.FacetDescription facetDescription)
		{
			base.Configure(column, facetDescription);
			string facetName = facetDescription.FacetName;
			if (facetName != null && facetName == "Unicode")
			{
				bool? isUnicode2;
				if (!facetDescription.IsConstant)
				{
					bool? isUnicode = this.IsUnicode;
					isUnicode2 = ((isUnicode != null) ? isUnicode : column.IsUnicode);
				}
				else
				{
					isUnicode2 = null;
				}
				column.IsUnicode = isUnicode2;
			}
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0004AFF8 File Offset: 0x000491F8
		internal override void CopyFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other)
		{
			base.CopyFrom(other);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration stringPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration;
			if (stringPropertyConfiguration != null)
			{
				this.IsUnicode = stringPropertyConfiguration.IsUnicode;
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0004B024 File Offset: 0x00049224
		internal override void FillFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.FillFrom(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration stringPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration;
			if (stringPropertyConfiguration != null && this.IsUnicode == null)
			{
				this.IsUnicode = stringPropertyConfiguration.IsUnicode;
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0004B060 File Offset: 0x00049260
		internal override void MakeCompatibleWith(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace)
		{
			base.MakeCompatibleWith(other, inCSpace);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration stringPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration;
			if (stringPropertyConfiguration == null)
			{
				return;
			}
			if (stringPropertyConfiguration.IsUnicode != null)
			{
				this.IsUnicode = null;
			}
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0004B0A0 File Offset: 0x000492A0
		internal override bool IsCompatible(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration other, bool inCSpace, out string errorMessage)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration stringPropertyConfiguration = other as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration;
			bool flag = base.IsCompatible(other, inCSpace, out errorMessage);
			bool flag2 = stringPropertyConfiguration == null || base.IsCompatible<bool, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration>((global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration c) => c.IsUnicode, stringPropertyConfiguration, ref errorMessage);
			return flag && flag2;
		}
	}
}
