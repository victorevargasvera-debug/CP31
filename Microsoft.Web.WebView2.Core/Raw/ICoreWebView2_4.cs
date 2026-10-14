using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000E3 RID: 227
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("20D02D59-6DF2-42DC-BD06-F98A694B1302")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2_4 : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3
	{
		// Token: 0x060004DB RID: 1243
		void _VtblGap1_70();

		// Token: 0x060004DC RID: 1244
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_FrameCreated([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameCreatedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060004DD RID: 1245
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_FrameCreated([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060004DE RID: 1246
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_DownloadStarting([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadStartingEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060004DF RID: 1247
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_DownloadStarting([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);
	}
}
