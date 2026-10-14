using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000E1 RID: 225
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("9E8F0CF8-E670-4B5E-B2BC-73E061E3184C")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2_2 : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2
	{
		// Token: 0x060004CD RID: 1229
		void _VtblGap1_58();

		// Token: 0x060004CE RID: 1230
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_WebResourceResponseReceived([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060004CF RID: 1231
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_WebResourceResponseReceived([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060004D0 RID: 1232
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void NavigateWithWebResourceRequest([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequest Request);

		// Token: 0x060004D1 RID: 1233
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_DOMContentLoaded([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DOMContentLoadedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060004D2 RID: 1234
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_DOMContentLoaded([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004D3 RID: 1235
		[global::System.Runtime.InteropServices.DispId(1610743813)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieManager CookieManager { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004D4 RID: 1236
		[global::System.Runtime.InteropServices.DispId(1610743814)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment Environment { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
