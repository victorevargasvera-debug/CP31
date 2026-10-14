using System;

namespace NLog.Internal
{
	// Token: 0x020000F7 RID: 247
	internal static class ArrayHelper
	{
		// Token: 0x06000C8F RID: 3215 RVA: 0x0001EDDD File Offset: 0x0001CFDD
		internal static T[] Empty<T>()
		{
			return global::NLog.Internal.ArrayHelper.EmptyArray<T>.Instance;
		}

		// Token: 0x02000205 RID: 517
		private static class EmptyArray<T>
		{
			// Token: 0x040005CA RID: 1482
			internal static readonly T[] Instance = new T[0];
		}
	}
}
