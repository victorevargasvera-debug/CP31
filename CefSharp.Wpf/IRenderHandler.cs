using System;
using System.Windows.Controls;
using CefSharp.Structs;

namespace CefSharp.Wpf
{
	// Token: 0x02000005 RID: 5
	public interface IRenderHandler : global::System.IDisposable
	{
		// Token: 0x0600011D RID: 285
		void OnAcceleratedPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sharedHandle);

		// Token: 0x0600011E RID: 286
		void OnPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height, global::System.Windows.Controls.Image image);
	}
}
