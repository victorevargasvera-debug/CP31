using System;

namespace Gibraltar.Agent
{
	// Token: 0x02000005 RID: 5
	public interface IMessageSourceProvider
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5
		string MethodName { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6
		string ClassName { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7
		string FileName { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8
		int LineNumber { get; }
	}
}
