using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001DF RID: 479
	public abstract class LengthColumnConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration
	{
		// Token: 0x0600192C RID: 6444 RVA: 0x00042DFF File Offset: 0x00040FFF
		internal LengthColumnConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration configuration) : base(configuration)
		{
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00042E08 File Offset: 0x00041008
		internal new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration Configuration
		{
			get
			{
				return (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.LengthPropertyConfiguration)base.Configuration;
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00042E18 File Offset: 0x00041018
		public global::System.Data.Entity.ModelConfiguration.Configuration.LengthColumnConfiguration IsMaxLength()
		{
			this.Configuration.IsMaxLength = new bool?(true);
			this.Configuration.MaxLength = null;
			return this;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00042E4C File Offset: 0x0004104C
		public global::System.Data.Entity.ModelConfiguration.Configuration.LengthColumnConfiguration HasMaxLength(int? value)
		{
			this.Configuration.MaxLength = value;
			this.Configuration.IsMaxLength = null;
			return this;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00042E7A File Offset: 0x0004107A
		public global::System.Data.Entity.ModelConfiguration.Configuration.LengthColumnConfiguration IsFixedLength()
		{
			this.Configuration.IsFixedLength = new bool?(true);
			return this;
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00042E8E File Offset: 0x0004108E
		public global::System.Data.Entity.ModelConfiguration.Configuration.LengthColumnConfiguration IsVariableLength()
		{
			this.Configuration.IsFixedLength = new bool?(false);
			return this;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00042EA2 File Offset: 0x000410A2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00042EAA File Offset: 0x000410AA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00042EB3 File Offset: 0x000410B3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00042EBB File Offset: 0x000410BB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
