using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000E2 RID: 226
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("A0D6DF20-3B92-416D-AA0C-437A9C727857")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2_3 : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_2
	{
		// Token: 0x060004D5 RID: 1237
		void _VtblGap1_65();

		// Token: 0x060004D6 RID: 1238
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void TrySuspend([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2TrySuspendCompletedHandler handler);

		// Token: 0x060004D7 RID: 1239
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Resume();

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004D8 RID: 1240
		[global::System.Runtime.InteropServices.DispId(1610809346)]
		int IsSuspended { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060004D9 RID: 1241
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void SetVirtualHostNameToFolderMapping([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string hostName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string folderPath, [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind);

		// Token: 0x060004DA RID: 1242
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void ClearVirtualHostNameToFolderMapping([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string hostName);
	}
}
