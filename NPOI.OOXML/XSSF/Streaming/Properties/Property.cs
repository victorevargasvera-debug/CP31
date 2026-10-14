using System;

namespace NPOI.XSSF.Streaming.Properties
{
	// Token: 0x020000DF RID: 223
	public abstract class Property
	{
		// Token: 0x06000DF1 RID: 3569 RVA: 0x00030322 File Offset: 0x0002E522
		protected Property(object value)
		{
			this._value = value;
		}

		// Token: 0x06000DF2 RID: 3570
		public new abstract int GetType();

		// Token: 0x04000412 RID: 1042
		public const int COMMENT = 1;

		// Token: 0x04000413 RID: 1043
		public const int HYPERLINK = 2;

		// Token: 0x04000414 RID: 1044
		public object _value;

		// Token: 0x04000415 RID: 1045
		public global::NPOI.XSSF.Streaming.Properties.Property _next;
	}
}
