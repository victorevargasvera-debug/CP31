using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000CE RID: 206
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("CB56846C-4168-4D53-B04F-03B6D6796FF2")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2Settings4 : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Settings3
	{
		// Token: 0x06000495 RID: 1173
		void _VtblGap1_22();

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000496 RID: 1174
		// (set) Token: 0x06000497 RID: 1175
		[global::System.Runtime.InteropServices.DispId(1610874880)]
		int IsPasswordAutosaveEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000498 RID: 1176
		// (set) Token: 0x06000499 RID: 1177
		[global::System.Runtime.InteropServices.DispId(1610874882)]
		int IsGeneralAutofillEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
