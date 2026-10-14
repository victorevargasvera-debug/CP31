using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000A2 RID: 162
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("E99BBE21-43E9-4544-A732-282764EAFA60")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2DownloadStartingEventArgs
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003D3 RID: 979
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation DownloadOperation { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003D4 RID: 980
		// (set) Token: 0x060003D5 RID: 981
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		int Cancel { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003D6 RID: 982
		// (set) Token: 0x060003D7 RID: 983
		[global::System.Runtime.InteropServices.DispId(1610678275)]
		string ResultFilePath { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003D8 RID: 984
		// (set) Token: 0x060003D9 RID: 985
		[global::System.Runtime.InteropServices.DispId(1610678277)]
		int Handled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x060003DA RID: 986
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral GetDeferral();
	}
}
