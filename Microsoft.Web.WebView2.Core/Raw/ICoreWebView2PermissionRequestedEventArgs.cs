using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000C2 RID: 194
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("973AE2EF-FF18-4894-8FB2-3C758F046810")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2PermissionRequestedEventArgs
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600042D RID: 1069
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		string Uri { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600042E RID: 1070
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_PERMISSION_KIND PermissionKind { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600042F RID: 1071
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		int IsUserInitiated { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000430 RID: 1072
		// (set) Token: 0x06000431 RID: 1073
		[global::System.Runtime.InteropServices.DispId(1610678275)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_PERMISSION_STATE State { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000432 RID: 1074
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral GetDeferral();
	}
}
