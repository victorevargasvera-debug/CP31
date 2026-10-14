using System;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000174 RID: 372
	internal class ClientLogger : global::Gibraltar.Server.Client.IClientLogger
	{
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x0002A24C File Offset: 0x0002844C
		public bool SilentMode
		{
			get
			{
				return global::Gibraltar.Monitor.Log.SilentMode;
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0002A254 File Offset: 0x00028454
		public void Write(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string category, string caption, string description, params object[] args)
		{
			global::Gibraltar.Monitor.Log.Write(severity, category, caption, description, args);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0002A264 File Offset: 0x00028464
		public void Write(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::System.Exception exception, bool attributeToException, string category, string caption, string description, params object[] args)
		{
			global::Gibraltar.Monitor.Log.Write(severity, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, attributeToException, category, caption, description, args);
		}
	}
}
