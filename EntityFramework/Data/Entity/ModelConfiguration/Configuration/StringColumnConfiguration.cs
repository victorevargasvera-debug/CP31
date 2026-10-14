using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001E2 RID: 482
	public class StringColumnConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.LengthColumnConfiguration
	{
		// Token: 0x0600194B RID: 6475 RVA: 0x000430DD File Offset: 0x000412DD
		internal StringColumnConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration configuration) : base(configuration)
		{
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x000430E6 File Offset: 0x000412E6
		internal new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration Configuration
		{
			get
			{
				return (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration)base.Configuration;
			}
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x000430F3 File Offset: 0x000412F3
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration IsMaxLength()
		{
			base.IsMaxLength();
			return this;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000430FD File Offset: 0x000412FD
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration HasMaxLength(int? value)
		{
			base.HasMaxLength(value);
			return this;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00043108 File Offset: 0x00041308
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration IsFixedLength()
		{
			base.IsFixedLength();
			return this;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00043112 File Offset: 0x00041312
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration IsVariableLength()
		{
			base.IsVariableLength();
			return this;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0004311C File Offset: 0x0004131C
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration IsOptional()
		{
			base.IsOptional();
			return this;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00043126 File Offset: 0x00041326
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration IsRequired()
		{
			base.IsRequired();
			return this;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00043130 File Offset: 0x00041330
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration HasColumnType(string columnType)
		{
			base.HasColumnType(columnType);
			return this;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0004313B File Offset: 0x0004133B
		public new global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration HasColumnOrder(int? columnOrder)
		{
			base.HasColumnOrder(columnOrder);
			return this;
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00043146 File Offset: 0x00041346
		public global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration IsUnicode()
		{
			this.IsUnicode(new bool?(true));
			return this;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00043156 File Offset: 0x00041356
		public global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration IsUnicode(bool? unicode)
		{
			this.Configuration.IsUnicode = unicode;
			return this;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00043165 File Offset: 0x00041365
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0004316D File Offset: 0x0004136D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00043176 File Offset: 0x00041376
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0004317E File Offset: 0x0004137E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
