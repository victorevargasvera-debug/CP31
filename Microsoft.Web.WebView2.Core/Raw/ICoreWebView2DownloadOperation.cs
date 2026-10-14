using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000A1 RID: 161
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("3D6B6CF2-AFE1-44C7-A995-C65117714336")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2DownloadOperation
	{
		// Token: 0x060003C0 RID: 960
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_BytesReceivedChanged([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2BytesReceivedChangedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003C1 RID: 961
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_BytesReceivedChanged([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003C2 RID: 962
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_EstimatedEndTimeChanged([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2EstimatedEndTimeChangedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003C3 RID: 963
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_EstimatedEndTimeChanged([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003C4 RID: 964
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_StateChanged([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2StateChangedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003C5 RID: 965
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_StateChanged([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003C6 RID: 966
		[global::System.Runtime.InteropServices.DispId(1610678278)]
		string Uri { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003C7 RID: 967
		[global::System.Runtime.InteropServices.DispId(1610678279)]
		string ContentDisposition { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003C8 RID: 968
		[global::System.Runtime.InteropServices.DispId(1610678280)]
		string MimeType { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003C9 RID: 969
		[global::System.Runtime.InteropServices.DispId(1610678281)]
		long TotalBytesToReceive { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003CA RID: 970
		[global::System.Runtime.InteropServices.DispId(1610678282)]
		long BytesReceived { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003CB RID: 971
		[global::System.Runtime.InteropServices.DispId(1610678283)]
		string EstimatedEndTime { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003CC RID: 972
		[global::System.Runtime.InteropServices.DispId(1610678284)]
		string ResultFilePath { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003CD RID: 973
		[global::System.Runtime.InteropServices.DispId(1610678285)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_DOWNLOAD_STATE State { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003CE RID: 974
		[global::System.Runtime.InteropServices.DispId(1610678286)]
		global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON InterruptReason { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x060003CF RID: 975
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Cancel();

		// Token: 0x060003D0 RID: 976
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Pause();

		// Token: 0x060003D1 RID: 977
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void Resume();

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003D2 RID: 978
		[global::System.Runtime.InteropServices.DispId(1610678290)]
		int CanResume { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
