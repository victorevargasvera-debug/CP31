using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x0200008B RID: 139
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("3DF9B733-B9AE-4A15-86B4-EB9EE9826469")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2CompositionController
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600036D RID: 877
		// (set) Token: 0x0600036E RID: 878
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		object RootVisualTarget { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600036F RID: 879
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SendMouseInput([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_MOUSE_EVENT_KIND eventKind, [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS virtualKeys, [global::System.Runtime.InteropServices.In] uint mouseData, [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.tagPOINT point);

		// Token: 0x06000370 RID: 880
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SendPointerInput([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_POINTER_EVENT_KIND eventKind, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PointerInfo pointerInfo);

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000371 RID: 881
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		global::System.IntPtr Cursor { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000372 RID: 882
		[global::System.Runtime.InteropServices.DispId(1610678277)]
		uint SystemCursorId { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000373 RID: 883
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_CursorChanged([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CursorChangedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x06000374 RID: 884
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_CursorChanged([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);
	}
}
