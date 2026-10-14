using System;
using System.Collections;

namespace Infragistics
{
	// Token: 0x0200010A RID: 266
	public class MergeDataContext
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0002313E File Offset: 0x0002133E
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00023146 File Offset: 0x00021346
		public object Value { get; internal set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0002314F File Offset: 0x0002134F
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00023157 File Offset: 0x00021357
		public global::System.Collections.IList Records { get; internal set; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00023160 File Offset: 0x00021360
		public int Count
		{
			get
			{
				if (this.Records == null)
				{
					return 0;
				}
				return this.Records.Count;
			}
		}
	}
}
