using System;

namespace MassTransit.NewIdProviders
{
	// Token: 0x0200000E RID: 14
	public class DateTimeTickProvider : global::MassTransit.ITickProvider
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002EB0 File Offset: 0x000010B0
		public long Ticks
		{
			get
			{
				return global::System.DateTime.UtcNow.Ticks;
			}
		}
	}
}
