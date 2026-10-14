using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001E1 RID: 481
	public class PrimitiveColumnConfiguration
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x00043041 File Offset: 0x00041241
		internal PrimitiveColumnConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration configuration)
		{
			this._configuration = configuration;
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x00043050 File Offset: 0x00041250
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00043058 File Offset: 0x00041258
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration IsOptional()
		{
			this.Configuration.IsNullable = new bool?(true);
			return this;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0004306C File Offset: 0x0004126C
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration IsRequired()
		{
			this.Configuration.IsNullable = new bool?(false);
			return this;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00043080 File Offset: 0x00041280
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration HasColumnType(string columnType)
		{
			this.Configuration.ColumnType = columnType;
			return this;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0004308F File Offset: 0x0004128F
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration HasColumnOrder(int? columnOrder)
		{
			if (columnOrder != null && columnOrder.Value < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("columnOrder");
			}
			this.Configuration.ColumnOrder = columnOrder;
			return this;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000430BC File Offset: 0x000412BC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000430C4 File Offset: 0x000412C4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000430CD File Offset: 0x000412CD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x000430D5 File Offset: 0x000412D5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A77 RID: 2679
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration _configuration;
	}
}
