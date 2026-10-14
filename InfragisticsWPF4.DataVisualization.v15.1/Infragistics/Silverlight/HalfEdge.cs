using System;

namespace Infragistics.Silverlight
{
	// Token: 0x020000BF RID: 191
	public class HalfEdge
	{
		// Token: 0x0600082B RID: 2091 RVA: 0x000266AD File Offset: 0x000248AD
		public HalfEdge(int beg, int end)
		{
			this.Beg = beg;
			this.End = end;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000266C3 File Offset: 0x000248C3
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x000266CB File Offset: 0x000248CB
		public int Beg { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x000266D4 File Offset: 0x000248D4
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x000266DC File Offset: 0x000248DC
		public int End { get; set; }
	}
}
