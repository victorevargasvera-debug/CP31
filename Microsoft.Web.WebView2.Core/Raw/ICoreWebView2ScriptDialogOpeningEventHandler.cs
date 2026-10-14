using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000CA RID: 202
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("EF381BF9-AFA8-4E37-91C4-8AC48524BDFB")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2ScriptDialogOpeningEventHandler
	{
		// Token: 0x0600047C RID: 1148
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Invoke([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 sender, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScriptDialogOpeningEventArgs args);
	}
}
