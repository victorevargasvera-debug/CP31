using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000C0 RID: 192
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("34ACB11C-FC37-4418-9132-F9C21D1EAFB9")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2NewWindowRequestedEventArgs
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000424 RID: 1060
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		string Uri { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000426 RID: 1062
		// (set) Token: 0x06000425 RID: 1061
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 NewWindow { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000428 RID: 1064
		// (set) Token: 0x06000427 RID: 1063
		[global::System.Runtime.InteropServices.DispId(1610678275)]
		int Handled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000429 RID: 1065
		[global::System.Runtime.InteropServices.DispId(1610678277)]
		int IsUserInitiated { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600042A RID: 1066
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral GetDeferral();

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600042B RID: 1067
		[global::System.Runtime.InteropServices.DispId(1610678279)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WindowFeatures WindowFeatures { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
