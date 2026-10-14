using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000C6 RID: 198
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("4DAB9422-46FA-4C3E-A5D2-41D2071D3680")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2ProcessFailedEventArgs2 : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs
	{
		// Token: 0x0600046D RID: 1133
		void _VtblGap1_1();

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600046E RID: 1134
		[global::System.Runtime.InteropServices.DispId(1610743808)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_PROCESS_FAILED_REASON Reason { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600046F RID: 1135
		[global::System.Runtime.InteropServices.DispId(1610743809)]
		int ExitCode { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000470 RID: 1136
		[global::System.Runtime.InteropServices.DispId(1610743810)]
		string ProcessDescription { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000471 RID: 1137
		[global::System.Runtime.InteropServices.DispId(1610743811)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfoCollection FrameInfosForFailedProcess { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] get; }
	}
}
