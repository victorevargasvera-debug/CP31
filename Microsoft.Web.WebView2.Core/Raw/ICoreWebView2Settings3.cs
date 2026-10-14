using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000CD RID: 205
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("FDB5AB74-AF33-4854-84F0-0A631DEB5EBA")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2Settings3 : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings2
	{
		// Token: 0x06000492 RID: 1170
		void _VtblGap1_20();

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000493 RID: 1171
		// (set) Token: 0x06000494 RID: 1172
		[global::System.Runtime.InteropServices.DispId(1610809344)]
		int AreBrowserAcceleratorKeysEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
