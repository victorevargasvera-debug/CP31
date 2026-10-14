using System;

namespace NLog.LogReceiverService
{
	// Token: 0x0200008D RID: 141
	public class LogReceiverForwardingService : global::NLog.LogReceiverService.BaseLogReceiverForwardingService, global::NLog.LogReceiverService.ILogReceiverServer
	{
		// Token: 0x060008FD RID: 2301 RVA: 0x00017C3A File Offset: 0x00015E3A
		public LogReceiverForwardingService() : this(null)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00017C43 File Offset: 0x00015E43
		public LogReceiverForwardingService(global::NLog.LogFactory logFactory) : base(logFactory)
		{
		}
	}
}
