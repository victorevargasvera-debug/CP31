using System;
using System.Diagnostics;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200008B RID: 139
	internal class DebugCheck
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x0000F8DB File Offset: 0x0000DADB
		[global::System.Diagnostics.Conditional("DEBUG")]
		public static void NotNull<T>(T value) where T : class
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000F8DD File Offset: 0x0000DADD
		[global::System.Diagnostics.Conditional("DEBUG")]
		public static void NotNull<T>(T? value) where T : struct
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000F8DF File Offset: 0x0000DADF
		[global::System.Diagnostics.Conditional("DEBUG")]
		public static void NotEmpty(string value)
		{
		}
	}
}
