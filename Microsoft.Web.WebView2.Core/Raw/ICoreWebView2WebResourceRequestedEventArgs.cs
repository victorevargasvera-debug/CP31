using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000D7 RID: 215
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("453E667F-12C7-49D4-BE6D-DDBE7956F57A")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2WebResourceRequestedEventArgs
	{
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004AC RID: 1196
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequest Request { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004AD RID: 1197
		// (set) Token: 0x060004AE RID: 1198
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponse Response { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060004AF RID: 1199
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral GetDeferral();

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004B0 RID: 1200
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
