using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000D6 RID: 214
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("97055CD4-512C-4264-8B5F-E3F446CEA6A5")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2WebResourceRequest
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004A5 RID: 1189
		// (set) Token: 0x060004A6 RID: 1190
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		string Uri { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004A7 RID: 1191
		// (set) Token: 0x060004A8 RID: 1192
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		string Method { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004A9 RID: 1193
		// (set) Token: 0x060004AA RID: 1194
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		global::System.Runtime.InteropServices.ComTypes.IStream Content { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004AB RID: 1195
		[global::System.Runtime.InteropServices.DispId(1610678278)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpRequestHeaders Headers { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
