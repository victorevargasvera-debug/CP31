using System;

namespace AcpUILib
{
	// Token: 0x02000004 RID: 4
	public interface IAcpUICtrlBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10
		// (set) Token: 0x0600000B RID: 11
		bool IsAcpValid { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12
		// (set) Token: 0x0600000D RID: 13
		bool IsAcpApplicable { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14
		// (set) Token: 0x0600000F RID: 15
		bool IsAcpEditable { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16
		// (set) Token: 0x06000011 RID: 17
		bool IsAcpVisible { get; set; }
	}
}
