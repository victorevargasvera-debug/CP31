using System;

namespace CefSharp.Internals
{
	// Token: 0x020000DC RID: 220
	public static class IntPtrExtensions
	{
		// Token: 0x06000662 RID: 1634 RVA: 0x0000A0EB File Offset: 0x000082EB
		public static int CastToInt32(this global::System.IntPtr intPtr)
		{
			return (int)intPtr.ToInt64();
		}
	}
}
