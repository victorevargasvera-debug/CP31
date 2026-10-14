using System;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F4 RID: 500
	public abstract class LengthPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration
	{
		// Token: 0x06001A36 RID: 6710 RVA: 0x00045D02 File Offset: 0x00043F02
		internal LengthPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration configuration) : base(configuration)
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00045D0C File Offset: 0x00043F0C
		public global::System.Data.Entity.ModelConfiguration.Configuration.LengthPropertyConfiguration IsMaxLength()
		{
			this.Configuration.IsMaxLength = new bool?(true);
			this.Configuration.MaxLength = null;
			return this;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00045D40 File Offset: 0x00043F40
		public global::System.Data.Entity.ModelConfiguration.Configuration.LengthPropertyConfiguration HasMaxLength(int? value)
		{
			this.Configuration.MaxLength = value;
			this.Configuration.IsMaxLength = null;
			this.Configuration.IsFixedLength = new bool?(this.Configuration.IsFixedLength.GetValueOrDefault());
			return this;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00045D91 File Offset: 0x00043F91
		public global::System.Data.Entity.ModelConfiguration.Configuration.LengthPropertyConfiguration IsFixedLength()
		{
			this.Configuration.IsFixedLength = new bool?(true);
			return this;
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00045DA5 File Offset: 0x00043FA5
		public global::System.Data.Entity.ModelConfiguration.Configuration.LengthPropertyConfiguration IsVariableLength()
		{
			this.Configuration.IsFixedLength = new bool?(false);
			return this;
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00045DB9 File Offset: 0x00043FB9
		internal new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration Configuration
		{
			get
			{
				return (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration)base.Configuration;
			}
		}
	}
}
