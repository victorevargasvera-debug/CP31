using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000B2 RID: 178
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("1BF89E2D-1B2B-4629-B28F-05099B41BB03")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2FrameInfoCollectionIterator
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003FF RID: 1023
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		int HasCurrent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000400 RID: 1024
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfo GetCurrent();

		// Token: 0x06000401 RID: 1025
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int MoveNext();
	}
}
