using System;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x02000012 RID: 18
	public class DataEventArgs<TData> : global::System.EventArgs
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0000344C File Offset: 0x0000164C
		public DataEventArgs(TData value)
		{
			this._value = value;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000345B File Offset: 0x0000165B
		public TData Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x0400001D RID: 29
		private readonly TData _value;
	}
}
