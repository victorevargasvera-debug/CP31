using System;

namespace MassTransit
{
	// Token: 0x02000007 RID: 7
	public interface IProcessIdProvider
	{
		// Token: 0x06000008 RID: 8
		byte[] GetProcessId();
	}
}
