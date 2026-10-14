using System;
using System.Runtime.InteropServices;

namespace CefSharp.Wpf.Internals
{
	// Token: 0x02000014 RID: 20
	public static class ImeNative
	{
		// Token: 0x0600017E RID: 382
		[global::System.Runtime.InteropServices.DllImport("imm32.dll")]
		internal static extern global::System.IntPtr ImmCreateContext();

		// Token: 0x0600017F RID: 383
		[global::System.Runtime.InteropServices.DllImport("imm32.dll")]
		internal static extern global::System.IntPtr ImmAssociateContext(global::System.IntPtr hWnd, global::System.IntPtr hIMC);

		// Token: 0x06000180 RID: 384
		[global::System.Runtime.InteropServices.DllImport("imm32.dll")]
		internal static extern bool ImmDestroyContext(global::System.IntPtr hIMC);

		// Token: 0x06000181 RID: 385
		[global::System.Runtime.InteropServices.DllImport("imm32.dll")]
		internal static extern global::System.IntPtr ImmGetContext(global::System.IntPtr hWnd);

		// Token: 0x06000182 RID: 386
		[global::System.Runtime.InteropServices.DllImport("Imm32.dll")]
		internal static extern bool ImmReleaseContext(global::System.IntPtr hWnd, global::System.IntPtr hIMC);

		// Token: 0x06000183 RID: 387
		[global::System.Runtime.InteropServices.DllImport("Imm32.dll")]
		internal static extern bool ImmNotifyIME(global::System.IntPtr hIMC, uint action, uint index, uint value);

		// Token: 0x06000184 RID: 388
		[global::System.Runtime.InteropServices.DllImport("imm32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode)]
		internal static extern uint ImmGetCompositionString(global::System.IntPtr hIMC, uint dwIndex, byte[] lpBuf, uint dwBufLen);

		// Token: 0x06000185 RID: 389
		[global::System.Runtime.InteropServices.DllImport("imm32.dll")]
		internal static extern int ImmSetCompositionWindow(global::System.IntPtr hIMC, ref global::CefSharp.Wpf.Internals.ImeNative.COMPOSITIONFORM lpCompForm);

		// Token: 0x06000186 RID: 390
		[global::System.Runtime.InteropServices.DllImport("imm32.dll")]
		public static extern int ImmSetCandidateWindow(global::System.IntPtr hIMC, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] ref global::CefSharp.Wpf.Internals.ImeNative.CANDIDATEFORM lpCandidateForm);

		// Token: 0x06000187 RID: 391
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool CreateCaret(global::System.IntPtr hWnd, global::System.IntPtr hBitmap, int nWidth, int nHeight);

		// Token: 0x06000188 RID: 392
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool DestroyCaret();

		// Token: 0x06000189 RID: 393
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool SetCaretPos(int x, int y);

		// Token: 0x0600018A RID: 394
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr DefWindowProc(global::System.IntPtr hWnd, uint uMsg, global::System.IntPtr wParam, global::System.IntPtr lParam);

		// Token: 0x0600018B RID: 395
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr GetForegroundWindow();

		// Token: 0x0600018C RID: 396
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern uint GetWindowThreadProcessId(global::System.IntPtr hWnd, global::System.IntPtr ProcessId);

		// Token: 0x0600018D RID: 397
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr GetKeyboardLayout(uint idThread);

		// Token: 0x0600018E RID: 398
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr SetFocus(global::System.IntPtr hWnd);

		// Token: 0x0400009F RID: 159
		internal const uint GCS_RESULTSTR = 2048U;

		// Token: 0x040000A0 RID: 160
		internal const uint GCS_COMPSTR = 8U;

		// Token: 0x040000A1 RID: 161
		internal const uint GCS_COMPATTR = 16U;

		// Token: 0x040000A2 RID: 162
		internal const uint GCS_CURSORPOS = 128U;

		// Token: 0x040000A3 RID: 163
		internal const uint GCS_COMPCLAUSE = 32U;

		// Token: 0x040000A4 RID: 164
		internal const uint CPS_CANCEL = 4U;

		// Token: 0x040000A5 RID: 165
		internal const uint CS_NOMOVECARET = 16384U;

		// Token: 0x040000A6 RID: 166
		internal const uint NI_COMPOSITIONSTR = 21U;

		// Token: 0x040000A7 RID: 167
		internal const uint ATTR_INPUT = 0U;

		// Token: 0x040000A8 RID: 168
		internal const uint ATTR_TARGET_CONVERTED = 1U;

		// Token: 0x040000A9 RID: 169
		internal const uint ATTR_TARGET_NOTCONVERTED = 3U;

		// Token: 0x040000AA RID: 170
		internal const uint ISC_SHOWUICOMPOSITIONWINDOW = 2147483648U;

		// Token: 0x040000AB RID: 171
		internal const uint CFS_DEFAULT = 0U;

		// Token: 0x040000AC RID: 172
		internal const uint CFS_RECT = 1U;

		// Token: 0x040000AD RID: 173
		internal const uint CFS_POINT = 2U;

		// Token: 0x040000AE RID: 174
		internal const uint CFS_FORCE_POSITION = 32U;

		// Token: 0x040000AF RID: 175
		internal const uint CFS_CANDIDATEPOS = 64U;

		// Token: 0x040000B0 RID: 176
		internal const uint CFS_EXCLUDE = 128U;

		// Token: 0x040000B1 RID: 177
		internal const uint LANG_JAPANESE = 17U;

		// Token: 0x040000B2 RID: 178
		internal const uint LANG_CHINESE = 4U;

		// Token: 0x040000B3 RID: 179
		internal const uint LANG_KOREAN = 18U;

		// Token: 0x02000045 RID: 69
		public struct POINT
		{
			// Token: 0x0600028B RID: 651 RVA: 0x000096D2 File Offset: 0x000078D2
			public POINT(int x, int y)
			{
				this.X = x;
				this.Y = y;
			}

			// Token: 0x04000222 RID: 546
			public int X;

			// Token: 0x04000223 RID: 547
			public int Y;
		}

		// Token: 0x02000046 RID: 70
		public struct RECT
		{
			// Token: 0x0600028C RID: 652 RVA: 0x000096E2 File Offset: 0x000078E2
			public RECT(int left, int top, int right, int bottom)
			{
				this.Left = left;
				this.Top = top;
				this.Right = right;
				this.Bottom = bottom;
			}

			// Token: 0x04000224 RID: 548
			public int Left;

			// Token: 0x04000225 RID: 549
			public int Top;

			// Token: 0x04000226 RID: 550
			public int Right;

			// Token: 0x04000227 RID: 551
			public int Bottom;
		}

		// Token: 0x02000047 RID: 71
		public struct COMPOSITIONFORM
		{
			// Token: 0x04000228 RID: 552
			public int dwStyle;

			// Token: 0x04000229 RID: 553
			public global::CefSharp.Wpf.Internals.ImeNative.POINT ptCurrentPos;

			// Token: 0x0400022A RID: 554
			public global::CefSharp.Wpf.Internals.ImeNative.RECT rcArea;
		}

		// Token: 0x02000048 RID: 72
		public struct CANDIDATEFORM
		{
			// Token: 0x0400022B RID: 555
			public int dwIndex;

			// Token: 0x0400022C RID: 556
			public int dwStyle;

			// Token: 0x0400022D RID: 557
			public global::CefSharp.Wpf.Internals.ImeNative.POINT ptCurrentPos;

			// Token: 0x0400022E RID: 558
			public global::CefSharp.Wpf.Internals.ImeNative.RECT rcArea;
		}
	}
}
