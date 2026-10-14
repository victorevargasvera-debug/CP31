using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x02000093 RID: 147
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("AD26D6BE-1486-43E6-BF87-A2034006CA21")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2Cookie
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600039C RID: 924
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		string Name { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600039D RID: 925
		// (set) Token: 0x0600039E RID: 926
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		string Value { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600039F RID: 927
		[global::System.Runtime.InteropServices.DispId(1610678275)]
		string Domain { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003A0 RID: 928
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		string Path { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003A1 RID: 929
		// (set) Token: 0x060003A2 RID: 930
		[global::System.Runtime.InteropServices.DispId(1610678277)]
		double Expires { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003A3 RID: 931
		// (set) Token: 0x060003A4 RID: 932
		[global::System.Runtime.InteropServices.DispId(1610678279)]
		int IsHttpOnly { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003A5 RID: 933
		// (set) Token: 0x060003A6 RID: 934
		[global::System.Runtime.InteropServices.DispId(1610678281)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_COOKIE_SAME_SITE_KIND SameSite { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003A7 RID: 935
		// (set) Token: 0x060003A8 RID: 936
		[global::System.Runtime.InteropServices.DispId(1610678283)]
		int IsSecure { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003A9 RID: 937
		[global::System.Runtime.InteropServices.DispId(1610678285)]
		int IsSession { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
