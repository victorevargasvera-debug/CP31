using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000CC RID: 204
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("EE9A0F68-F46C-4E32-AC23-EF8CAC224D2A")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2Settings2 : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings
	{
		// Token: 0x0600048F RID: 1167
		void _VtblGap1_18();

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000490 RID: 1168
		// (set) Token: 0x06000491 RID: 1169
		[global::System.Runtime.InteropServices.DispId(1610743808)]
		string UserAgent { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
