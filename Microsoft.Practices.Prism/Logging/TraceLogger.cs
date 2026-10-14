using System;
using System.Diagnostics;

namespace Microsoft.Practices.Prism.Logging
{
	// Token: 0x02000023 RID: 35
	public class TraceLogger : global::Microsoft.Practices.Prism.Logging.ILoggerFacade
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00004143 File Offset: 0x00002343
		public void Log(string message, global::Microsoft.Practices.Prism.Logging.Category category, global::Microsoft.Practices.Prism.Logging.Priority priority)
		{
			if (category == global::Microsoft.Practices.Prism.Logging.Category.Exception)
			{
				global::System.Diagnostics.Trace.TraceError(message);
				return;
			}
			global::System.Diagnostics.Trace.TraceInformation(message);
		}
	}
}
