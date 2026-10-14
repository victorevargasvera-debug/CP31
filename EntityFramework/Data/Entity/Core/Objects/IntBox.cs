using System;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200040C RID: 1036
	internal sealed class IntBox
	{
		// Token: 0x06003137 RID: 12599 RVA: 0x0009C045 File Offset: 0x0009A245
		internal IntBox(int val)
		{
			this.Value = val;
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06003138 RID: 12600 RVA: 0x0009C054 File Offset: 0x0009A254
		// (set) Token: 0x06003139 RID: 12601 RVA: 0x0009C05C File Offset: 0x0009A25C
		internal int Value { get; set; }
	}
}
