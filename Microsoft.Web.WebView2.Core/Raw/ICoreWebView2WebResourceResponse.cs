using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000D9 RID: 217
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("AAFCC94F-FA27-48FD-97DF-830EF75AAEC9")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2WebResourceResponse
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004B2 RID: 1202
		// (set) Token: 0x060004B3 RID: 1203
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		global::System.Runtime.InteropServices.ComTypes.IStream Content { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004B4 RID: 1204
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpResponseHeaders Headers { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004B5 RID: 1205
		// (set) Token: 0x060004B6 RID: 1206
		[global::System.Runtime.InteropServices.DispId(1610678275)]
		int StatusCode { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004B7 RID: 1207
		// (set) Token: 0x060004B8 RID: 1208
		[global::System.Runtime.InteropServices.DispId(1610678277)]
		string ReasonPhrase { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
