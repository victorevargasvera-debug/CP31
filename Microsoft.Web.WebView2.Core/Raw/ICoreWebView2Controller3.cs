using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x02000092 RID: 146
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("F9614724-5D2B-41DC-AEF7-73D62B51543B")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2Controller3 : global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2
	{
		// Token: 0x06000393 RID: 915
		void _VtblGap1_25();

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000394 RID: 916
		// (set) Token: 0x06000395 RID: 917
		[global::System.Runtime.InteropServices.DispId(1610809344)]
		double RasterizationScale { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000396 RID: 918
		// (set) Token: 0x06000397 RID: 919
		[global::System.Runtime.InteropServices.DispId(1610809346)]
		int ShouldDetectMonitorScaleChanges { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x06000398 RID: 920
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_RasterizationScaleChanged([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2RasterizationScaleChangedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x06000399 RID: 921
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_RasterizationScaleChanged([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600039A RID: 922
		// (set) Token: 0x0600039B RID: 923
		[global::System.Runtime.InteropServices.DispId(1610809350)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_BOUNDS_MODE BoundsMode { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
