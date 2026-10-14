using System;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x0200002C RID: 44
	internal class BoolWrapper
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0001065E File Offset: 0x0000E85E
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00010666 File Offset: 0x0000E866
		internal bool Value { get; set; }

		// Token: 0x06000446 RID: 1094 RVA: 0x0001066F File Offset: 0x0000E86F
		internal BoolWrapper()
		{
			this.Value = false;
		}
	}
}
