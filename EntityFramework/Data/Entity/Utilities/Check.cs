using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000089 RID: 137
	internal class Check
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x0000F658 File Offset: 0x0000D858
		public static T NotNull<T>(T value, string parameterName) where T : class
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(parameterName);
			}
			return value;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000F66A File Offset: 0x0000D86A
		public static T? NotNull<T>(T? value, string parameterName) where T : struct
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(parameterName);
			}
			return value;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000F67D File Offset: 0x0000D87D
		public static string NotEmpty(string value, string parameterName)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ArgumentIsNullOrWhitespace(parameterName));
			}
			return value;
		}
	}
}
