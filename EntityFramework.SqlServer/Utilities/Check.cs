using System;
using System.Data.Entity.SqlServer.Resources;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000027 RID: 39
	internal class Check
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x000100F0 File Offset: 0x0000E2F0
		public static T NotNull<T>(T value, string parameterName) where T : class
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(parameterName);
			}
			return value;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00010102 File Offset: 0x0000E302
		public static T? NotNull<T>(T? value, string parameterName) where T : struct
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(parameterName);
			}
			return value;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00010115 File Offset: 0x0000E315
		public static string NotEmpty(string value, string parameterName)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.SqlServer.Resources.Strings.ArgumentIsNullOrWhitespace(parameterName));
			}
			return value;
		}
	}
}
