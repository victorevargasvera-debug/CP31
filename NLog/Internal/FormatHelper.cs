using System;
using NLog.Config;

namespace NLog.Internal
{
	// Token: 0x02000105 RID: 261
	internal static class FormatHelper
	{
		// Token: 0x06000CE3 RID: 3299 RVA: 0x0001FAAC File Offset: 0x0001DCAC
		internal static string ConvertToString(object o, global::System.IFormatProvider formatProvider)
		{
			if (formatProvider == null && !(o is string))
			{
				global::NLog.Config.LoggingConfiguration configuration = global::NLog.LogManager.Configuration;
				if (configuration != null)
				{
					formatProvider = configuration.DefaultCultureInfo;
				}
			}
			return global::System.Convert.ToString(o, formatProvider);
		}
	}
}
