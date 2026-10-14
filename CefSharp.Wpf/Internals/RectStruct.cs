using System;
using CefSharp.Structs;

namespace CefSharp.Wpf.Internals
{
	// Token: 0x02000017 RID: 23
	public struct RectStruct
	{
		// Token: 0x06000193 RID: 403 RVA: 0x000061C2 File Offset: 0x000043C2
		public static implicit operator global::CefSharp.Structs.Rect(global::CefSharp.Wpf.Internals.RectStruct rect)
		{
			return new global::CefSharp.Structs.Rect(0, 0, rect.Right - rect.Left, rect.Bottom - rect.Top);
		}

		// Token: 0x040000BD RID: 189
		public int Left;

		// Token: 0x040000BE RID: 190
		public int Top;

		// Token: 0x040000BF RID: 191
		public int Right;

		// Token: 0x040000C0 RID: 192
		public int Bottom;
	}
}
