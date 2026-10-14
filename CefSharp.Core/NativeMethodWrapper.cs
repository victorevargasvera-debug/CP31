using System;
using CefSharp.Core;

namespace CefSharp
{
	// Token: 0x02000008 RID: 8
	public static class NativeMethodWrapper
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00002CA7 File Offset: 0x00000EA7
		public static void MemoryCopy(global::System.IntPtr dest, global::System.IntPtr src, int numberOfBytes)
		{
			global::CefSharp.Core.NativeMethodWrapper.MemoryCopy(dest, src, numberOfBytes);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002CB1 File Offset: 0x00000EB1
		public static bool IsFocused(global::System.IntPtr handle)
		{
			return global::CefSharp.Core.NativeMethodWrapper.IsFocused(handle);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002CB9 File Offset: 0x00000EB9
		public static void SetWindowPosition(global::System.IntPtr handle, int x, int y, int width, int height)
		{
			global::CefSharp.Core.NativeMethodWrapper.SetWindowPosition(handle, x, y, width, height);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002CC6 File Offset: 0x00000EC6
		public static void SetWindowParent(global::System.IntPtr child, global::System.IntPtr newParent)
		{
			global::CefSharp.Core.NativeMethodWrapper.SetWindowParent(child, newParent);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002CCF File Offset: 0x00000ECF
		public static void RemoveExNoActivateStyle(global::System.IntPtr browserHwnd)
		{
			global::CefSharp.Core.NativeMethodWrapper.RemoveExNoActivateStyle(browserHwnd);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002CD7 File Offset: 0x00000ED7
		public static global::System.IntPtr LoadCursorFromLibCef(int resourceIdentifier)
		{
			return global::CefSharp.Core.NativeMethodWrapper.LoadCursorFromLibCef(resourceIdentifier);
		}
	}
}
