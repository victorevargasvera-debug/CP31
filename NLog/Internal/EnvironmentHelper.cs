using System;
using System.Security;

namespace NLog.Internal
{
	// Token: 0x020000FE RID: 254
	internal static class EnvironmentHelper
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0001F435 File Offset: 0x0001D635
		internal static string NewLine
		{
			get
			{
				return global::System.Environment.NewLine;
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0001F43C File Offset: 0x0001D63C
		internal static string GetMachineName()
		{
			string result;
			try
			{
				result = global::System.Environment.MachineName;
			}
			catch (global::System.Security.SecurityException)
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0001F46C File Offset: 0x0001D66C
		internal static string GetSafeEnvironmentVariable(string name)
		{
			string result;
			try
			{
				string environmentVariable = global::System.Environment.GetEnvironmentVariable(name);
				if (environmentVariable == null || environmentVariable.Length == 0)
				{
					result = null;
				}
				else
				{
					result = environmentVariable;
				}
			}
			catch (global::System.Security.SecurityException)
			{
				result = null;
			}
			return result;
		}
	}
}
