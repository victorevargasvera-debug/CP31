using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200005C RID: 92
	internal static class Empty
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x00013428 File Offset: 0x00011628
		public static T[] Array<T>()
		{
			return global::ICSharpCode.SharpZipLib.Core.Empty.EmptyArray<T>.Value;
		}

		// Token: 0x02000092 RID: 146
		internal static class EmptyArray<T>
		{
			// Token: 0x04000376 RID: 886
			public static readonly T[] Value = new T[0];
		}
	}
}
