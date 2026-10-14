using System;

namespace MassTransit
{
	// Token: 0x02000009 RID: 9
	public interface IWorkerIdProvider
	{
		// Token: 0x0600000A RID: 10
		byte[] GetWorkerId(int index);
	}
}
