using System;
using NLog.Config;

namespace NLog.Internal
{
	// Token: 0x0200010A RID: 266
	internal interface ISupportsInitialize
	{
		// Token: 0x06000CF8 RID: 3320
		void Initialize(global::NLog.Config.LoggingConfiguration configuration);

		// Token: 0x06000CF9 RID: 3321
		void Close();
	}
}
