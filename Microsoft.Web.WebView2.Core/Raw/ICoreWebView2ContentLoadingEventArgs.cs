using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x0200008E RID: 142
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("0C8A1275-9B6B-4901-87AD-70DF25BAFA6E")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2ContentLoadingEventArgs
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000376 RID: 886
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		int IsErrorPage { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000377 RID: 887
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		ulong NavigationId { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
