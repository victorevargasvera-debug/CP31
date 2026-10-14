using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000A4 RID: 164
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("B96D755E-0319-4E92-A296-23436F46A1FC")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2Environment
	{
		// Token: 0x060003DC RID: 988
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CreateCoreWebView2Controller(global::System.IntPtr ParentWindow, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler);

		// Token: 0x060003DD RID: 989
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponse CreateWebResourceResponse([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::System.Runtime.InteropServices.ComTypes.IStream Content, [global::System.Runtime.InteropServices.In] int StatusCode, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string ReasonPhrase, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string Headers);

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003DE RID: 990
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		string BrowserVersionString { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x060003DF RID: 991
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_NewBrowserVersionAvailable([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003E0 RID: 992
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_NewBrowserVersionAvailable([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);
	}
}
