using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x0200001A RID: 26
	internal class DataFieldComparer : global::System.Collections.Generic.IComparer<global::Infragistics.DataField>
	{
		// Token: 0x0600014B RID: 331 RVA: 0x0000889C File Offset: 0x00006A9C
		public int Compare(global::Infragistics.DataField x, global::Infragistics.DataField y)
		{
			return x.Order.CompareTo(y.Order);
		}
	}
}
