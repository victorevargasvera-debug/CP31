using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000C9 RID: 201
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("7390BB70-ABE0-4843-9529-F143B31B03D6")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2ScriptDialogOpeningEventArgs
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000474 RID: 1140
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		string Uri { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000475 RID: 1141
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_SCRIPT_DIALOG_KIND Kind { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000476 RID: 1142
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		string Message { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x06000477 RID: 1143
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Accept();

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000478 RID: 1144
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		string DefaultText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000479 RID: 1145
		// (set) Token: 0x0600047A RID: 1146
		[global::System.Runtime.InteropServices.DispId(1610678277)]
		string ResultText { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x0600047B RID: 1147
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)]
		global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral GetDeferral();
	}
}
