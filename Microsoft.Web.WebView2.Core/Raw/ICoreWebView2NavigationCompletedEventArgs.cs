using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000BB RID: 187
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("30D68B7D-20D9-4752-A9CA-EC8448FBB5C1")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2NavigationCompletedEventArgs
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000417 RID: 1047
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		int IsSuccess { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000418 RID: 1048
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_WEB_ERROR_STATUS WebErrorStatus { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000419 RID: 1049
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		ulong NavigationId { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
