using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x02000094 RID: 148
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("F7F6F714-5D2A-43C6-9503-346ECE02D186")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2CookieList
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003AA RID: 938
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		uint Count { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060003AB RID: 939
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Cookie GetValueAtIndex([global::System.Runtime.InteropServices.In] uint index);
	}
}
