using System;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000244 RID: 580
	internal class MessageAvailableEventArgs : global::System.EventArgs
	{
		// Token: 0x06001D36 RID: 7478 RVA: 0x00066AFC File Offset: 0x00064CFC
		public MessageAvailableEventArgs(global::Loupe.Extensibility.Data.ILogMessage message)
		{
			this.Message = message;
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00066B0C File Offset: 0x00064D0C
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x00066B14 File Offset: 0x00064D14
		public global::Loupe.Extensibility.Data.ILogMessage Message { get; private set; }
	}
}
