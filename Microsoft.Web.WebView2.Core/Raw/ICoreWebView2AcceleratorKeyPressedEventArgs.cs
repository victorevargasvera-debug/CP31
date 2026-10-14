using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x02000085 RID: 133
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("9F760F8A-FB79-42BE-9990-7B56900FA9C7")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2AcceleratorKeyPressedEventArgs
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000362 RID: 866
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_KEY_EVENT_KIND KeyEventKind { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000363 RID: 867
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		uint VirtualKey { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000364 RID: 868
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		int KeyEventLParam { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000365 RID: 869
		[global::System.Runtime.InteropServices.DispId(1610678275)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_PHYSICAL_KEY_STATUS PhysicalKeyStatus { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000366 RID: 870
		// (set) Token: 0x06000367 RID: 871
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		int Handled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
