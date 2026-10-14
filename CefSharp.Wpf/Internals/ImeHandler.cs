using System;
using System.Collections.Generic;
using System.Text;
using CefSharp.Structs;

namespace CefSharp.Wpf.Internals
{
	// Token: 0x02000013 RID: 19
	public static class ImeHandler
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00005E7C File Offset: 0x0000407C
		public static bool GetResult(global::System.IntPtr hwnd, uint lParam, out string text)
		{
			global::System.IntPtr hIMC = global::CefSharp.Wpf.Internals.ImeNative.ImmGetContext(hwnd);
			bool @string = global::CefSharp.Wpf.Internals.ImeHandler.GetString(hIMC, lParam, 2048U, out text);
			global::CefSharp.Wpf.Internals.ImeNative.ImmReleaseContext(hwnd, hIMC);
			return @string;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005EA8 File Offset: 0x000040A8
		public static bool GetComposition(global::System.IntPtr hwnd, uint lParam, global::System.Collections.Generic.List<global::CefSharp.Structs.CompositionUnderline> underlines, ref int compositionStart, out string text)
		{
			global::System.IntPtr hIMC = global::CefSharp.Wpf.Internals.ImeNative.ImmGetContext(hwnd);
			bool @string = global::CefSharp.Wpf.Internals.ImeHandler.GetString(hIMC, lParam, 8U, out text);
			if (@string)
			{
				global::CefSharp.Wpf.Internals.ImeHandler.GetCompositionInfo(hwnd, lParam, text, underlines, ref compositionStart);
			}
			global::CefSharp.Wpf.Internals.ImeNative.ImmReleaseContext(hwnd, hIMC);
			return @string;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005EE0 File Offset: 0x000040E0
		private static bool GetString(global::System.IntPtr hIMC, uint lParam, uint type, out string text)
		{
			text = string.Empty;
			if (!global::CefSharp.Wpf.Internals.ImeHandler.IsParam(lParam, type))
			{
				return false;
			}
			uint num = global::CefSharp.Wpf.Internals.ImeNative.ImmGetCompositionString(hIMC, type, null, 0U);
			if (num <= 0U)
			{
				return false;
			}
			byte[] array = new byte[num];
			global::CefSharp.Wpf.Internals.ImeNative.ImmGetCompositionString(hIMC, type, array, num);
			text = global::System.Text.Encoding.Unicode.GetString(array);
			return true;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005F30 File Offset: 0x00004130
		private static void GetCompositionInfo(global::System.IntPtr hwnd, uint lParam, string text, global::System.Collections.Generic.List<global::CefSharp.Structs.CompositionUnderline> underlines, ref int compositionStart)
		{
			global::System.IntPtr hIMC = global::CefSharp.Wpf.Internals.ImeNative.ImmGetContext(hwnd);
			underlines.Clear();
			byte[] array = null;
			int length = text.Length;
			int length2 = text.Length;
			if (global::CefSharp.Wpf.Internals.ImeHandler.IsParam(lParam, 16U))
			{
				array = global::CefSharp.Wpf.Internals.ImeHandler.GetCompositionSelectionRange(hIMC, ref length, ref length2);
			}
			if (!global::CefSharp.Wpf.Internals.ImeHandler.IsParam(lParam, 16384U) && global::CefSharp.Wpf.Internals.ImeHandler.IsParam(lParam, 128U))
			{
				int num = (int)global::CefSharp.Wpf.Internals.ImeNative.ImmGetCompositionString(hIMC, 128U, null, 0U);
				compositionStart = num;
			}
			else
			{
				compositionStart = 0;
			}
			if (array == null || ((compositionStart <= 0 || compositionStart - 1 >= array.Length || array[compositionStart - 1] != 0) && (compositionStart < 0 || compositionStart >= array.Length || array[compositionStart] != 0)))
			{
				compositionStart = text.Length;
			}
			if (global::CefSharp.Wpf.Internals.ImeHandler.IsParam(lParam, 32U))
			{
				global::CefSharp.Wpf.Internals.ImeHandler.GetCompositionUnderlines(hIMC, length, length2, underlines);
			}
			if (underlines.Count == 0)
			{
				global::CefSharp.Structs.Range range = default(global::CefSharp.Structs.Range);
				bool thick = false;
				if (length > 0)
				{
					range = new global::CefSharp.Structs.Range(0, length);
				}
				if (length2 > length)
				{
					range = new global::CefSharp.Structs.Range(length, length2);
					thick = true;
				}
				if (length2 < text.Length)
				{
					range = new global::CefSharp.Structs.Range(length2, text.Length);
				}
				underlines.Add(new global::CefSharp.Structs.CompositionUnderline(range, global::CefSharp.Wpf.Internals.ImeHandler.ColorUNDERLINE, global::CefSharp.Wpf.Internals.ImeHandler.ColorBKCOLOR, thick));
			}
			global::CefSharp.Wpf.Internals.ImeNative.ImmReleaseContext(hwnd, hIMC);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00006058 File Offset: 0x00004258
		private static void GetCompositionUnderlines(global::System.IntPtr hIMC, int targetStart, int targetEnd, global::System.Collections.Generic.List<global::CefSharp.Structs.CompositionUnderline> underlines)
		{
			uint num = global::CefSharp.Wpf.Internals.ImeNative.ImmGetCompositionString(hIMC, 32U, null, 0U);
			if (num <= 0U)
			{
				return;
			}
			int num2 = (int)(num / 4U);
			byte[] array = new byte[num];
			global::CefSharp.Wpf.Internals.ImeNative.ImmGetCompositionString(hIMC, 32U, array, num);
			int num3 = num2 - 1;
			for (int i = 0; i < num3; i++)
			{
				int from = global::System.BitConverter.ToInt32(array, i * 4);
				int to = global::System.BitConverter.ToInt32(array, (i + 1) * 4);
				global::CefSharp.Structs.Range range = new global::CefSharp.Structs.Range(from, to);
				bool thick = range.From >= targetStart && range.To <= targetEnd;
				underlines.Add(new global::CefSharp.Structs.CompositionUnderline(range, global::CefSharp.Wpf.Internals.ImeHandler.ColorUNDERLINE, global::CefSharp.Wpf.Internals.ImeHandler.ColorBKCOLOR, thick));
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000060FC File Offset: 0x000042FC
		private static byte[] GetCompositionSelectionRange(global::System.IntPtr hIMC, ref int targetStart, ref int targetEnd)
		{
			uint num = global::CefSharp.Wpf.Internals.ImeNative.ImmGetCompositionString(hIMC, 16U, null, 0U);
			if (num <= 0U)
			{
				return null;
			}
			byte[] array = new byte[num];
			global::CefSharp.Wpf.Internals.ImeNative.ImmGetCompositionString(hIMC, 16U, array, num);
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num) && !global::CefSharp.Wpf.Internals.ImeHandler.IsSelectionAttribute(array[num2]))
			{
				num2++;
			}
			int num3 = num2;
			while ((long)num3 < (long)((ulong)num) && global::CefSharp.Wpf.Internals.ImeHandler.IsSelectionAttribute(array[num3]))
			{
				num3++;
			}
			targetStart = num2;
			targetEnd = num3;
			return array;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006167 File Offset: 0x00004367
		private static bool IsSelectionAttribute(byte attribute)
		{
			return attribute == 1 || attribute == 3;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00006173 File Offset: 0x00004373
		private static bool IsParam(uint lParam, uint type)
		{
			return (lParam & type) == type;
		}

		// Token: 0x0400009D RID: 157
		public static uint ColorUNDERLINE = 4278190080U;

		// Token: 0x0400009E RID: 158
		public static uint ColorBKCOLOR = 0U;
	}
}
