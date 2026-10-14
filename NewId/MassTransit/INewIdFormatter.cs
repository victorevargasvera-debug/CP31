using System;

namespace MassTransit
{
	// Token: 0x02000004 RID: 4
	public interface INewIdFormatter
	{
		// Token: 0x06000003 RID: 3
		string Format(in byte[] bytes);
	}
}
