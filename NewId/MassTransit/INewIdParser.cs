using System;

namespace MassTransit
{
	// Token: 0x02000006 RID: 6
	public interface INewIdParser
	{
		// Token: 0x06000007 RID: 7
		global::MassTransit.NewId Parse(in string text);
	}
}
