using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000DA RID: 218
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("D1DB483D-6796-4B8B-80FC-13712BB716F4")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2WebResourceResponseReceivedEventArgs
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004B9 RID: 1209
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequest Request { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004BA RID: 1210
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseView Response { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
