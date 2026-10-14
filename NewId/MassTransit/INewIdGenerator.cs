using System;

namespace MassTransit
{
	// Token: 0x02000005 RID: 5
	public interface INewIdGenerator
	{
		// Token: 0x06000004 RID: 4
		global::MassTransit.NewId Next();

		// Token: 0x06000005 RID: 5
		global::System.ArraySegment<global::MassTransit.NewId> Next(global::MassTransit.NewId[] ids, int index, int count);

		// Token: 0x06000006 RID: 6
		global::System.Guid NextGuid();
	}
}
