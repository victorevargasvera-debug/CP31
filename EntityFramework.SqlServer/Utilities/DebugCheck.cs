using System;
using System.Diagnostics;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000029 RID: 41
	internal class DebugCheck
	{
		// Token: 0x0600042F RID: 1071 RVA: 0x00010373 File Offset: 0x0000E573
		[global::System.Diagnostics.Conditional("DEBUG")]
		public static void NotNull<T>(T value) where T : class
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00010375 File Offset: 0x0000E575
		[global::System.Diagnostics.Conditional("DEBUG")]
		public static void NotNull<T>(T? value) where T : struct
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00010377 File Offset: 0x0000E577
		[global::System.Diagnostics.Conditional("DEBUG")]
		public static void NotEmpty(string value)
		{
		}
	}
}
