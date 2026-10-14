using System;

namespace NLog.LogReceiverService
{
	// Token: 0x0200008E RID: 142
	public class LogReceiverOneWayForwardingService : global::NLog.LogReceiverService.BaseLogReceiverForwardingService, global::NLog.LogReceiverService.ILogReceiverOneWayServer
	{
		// Token: 0x060008FF RID: 2303 RVA: 0x00017C4C File Offset: 0x00015E4C
		public LogReceiverOneWayForwardingService() : this(null)
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00017C55 File Offset: 0x00015E55
		public LogReceiverOneWayForwardingService(global::NLog.LogFactory logFactory) : base(logFactory)
		{
		}
	}
}
