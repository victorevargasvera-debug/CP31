using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x0200009F RID: 159
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("B32CA51A-8371-45E9-9317-AF021D080367")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2DevToolsProtocolEventReceiver
	{
		// Token: 0x060003BD RID: 957
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_DevToolsProtocolEventReceived([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventHandler handler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003BE RID: 958
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_DevToolsProtocolEventReceived([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);
	}
}
