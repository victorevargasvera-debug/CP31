using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000DC RID: 220
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("79701053-7759-4162-8F7D-F1B3F084928D")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2WebResourceResponseView
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004BC RID: 1212
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpResponseHeaders Headers { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004BD RID: 1213
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		int StatusCode { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004BE RID: 1214
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		string ReasonPhrase { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x060004BF RID: 1215
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void GetContent([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseViewGetContentCompletedHandler handler);
	}
}
