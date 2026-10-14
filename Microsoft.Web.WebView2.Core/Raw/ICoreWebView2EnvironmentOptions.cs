using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000A8 RID: 168
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("2FDE08A8-1E9A-4766-8C05-95A9CEB9D1C5")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2EnvironmentOptions
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003E6 RID: 998
		// (set) Token: 0x060003E7 RID: 999
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		string AdditionalBrowserArguments { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003E8 RID: 1000
		// (set) Token: 0x060003E9 RID: 1001
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		string Language { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003EA RID: 1002
		// (set) Token: 0x060003EB RID: 1003
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		string TargetCompatibleBrowserVersion { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003EC RID: 1004
		// (set) Token: 0x060003ED RID: 1005
		[global::System.Runtime.InteropServices.DispId(1610678278)]
		int AllowSingleSignOnUsingOSPrimaryAccount { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
