using System;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x0200019D RID: 413
	internal class MessageFilterEventArgs : global::System.EventArgs
	{
		// Token: 0x0600120C RID: 4620 RVA: 0x00033DDC File Offset: 0x00031FDC
		internal MessageFilterEventArgs(global::Loupe.Extensibility.Data.ILogMessage message)
		{
			this.Message = message;
			this.Cancel = false;
		}

		// Token: 0x04000615 RID: 1557
		public readonly global::Loupe.Extensibility.Data.ILogMessage Message;

		// Token: 0x04000616 RID: 1558
		public bool Cancel;
	}
}
