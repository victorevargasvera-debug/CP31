using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x02000003 RID: 3
	public interface ISupportPositioning
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10
		global::System.Collections.Generic.IEnumerable<string> Before { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11
		global::System.Collections.Generic.IEnumerable<string> After { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12
		string Key { get; }
	}
}
