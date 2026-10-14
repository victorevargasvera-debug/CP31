using System;

namespace Microsoft.Practices.Prism.Logging
{
	// Token: 0x0200001F RID: 31
	public interface ILoggerFacade
	{
		// Token: 0x060000AC RID: 172
		void Log(string message, global::Microsoft.Practices.Prism.Logging.Category category, global::Microsoft.Practices.Prism.Logging.Priority priority);
	}
}
