using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x02000098 RID: 152
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("4E8A3389-C9D8-4BD2-B6B5-124FEE6CC14D")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
	{
		// Token: 0x060003B6 RID: 950
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Invoke([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Error)] int errorCode, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Environment createdEnvironment);
	}
}
