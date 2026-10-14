using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000B3 RID: 179
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("435C7DC8-9BAA-11EB-A8B3-0242AC130003")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2FrameNameChangedEventHandler
	{
		// Token: 0x06000402 RID: 1026
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Invoke([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame sender, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IUnknown)] [global::System.Runtime.InteropServices.In] object args);
	}
}
