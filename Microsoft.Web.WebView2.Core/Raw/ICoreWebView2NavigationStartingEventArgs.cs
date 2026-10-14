using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000BD RID: 189
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("5B495469-E119-438A-9B18-7604F25F2E49")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2NavigationStartingEventArgs
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600041B RID: 1051
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		string Uri { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600041C RID: 1052
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		int IsUserInitiated { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600041D RID: 1053
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		int IsRedirected { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600041E RID: 1054
		[global::System.Runtime.InteropServices.DispId(1610678275)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2HttpRequestHeaders RequestHeaders { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600041F RID: 1055
		// (set) Token: 0x06000420 RID: 1056
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		int Cancel { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000421 RID: 1057
		[global::System.Runtime.InteropServices.DispId(1610678278)]
		ulong NavigationId { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
