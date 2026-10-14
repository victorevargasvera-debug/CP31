using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000A6 RID: 166
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("80A22AE3-BE7C-4CE2-AFE1-5A50056CDEEB")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2Environment3 : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment2
	{
		// Token: 0x060003E3 RID: 995
		void _VtblGap1_6();

		// Token: 0x060003E4 RID: 996
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void CreateCoreWebView2CompositionController(global::System.IntPtr ParentWindow, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler);

		// Token: 0x060003E5 RID: 997
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PointerInfo CreateCoreWebView2PointerInfo();
	}
}
