using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000DF RID: 223
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("5EAF559F-B46E-4397-8860-E422F287FF1E")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2WindowFeatures
	{
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004C2 RID: 1218
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		int HasPosition { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060004C3 RID: 1219
		[global::System.Runtime.InteropServices.DispId(1610678273)]
		int HasSize { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004C4 RID: 1220
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		uint Left { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004C5 RID: 1221
		[global::System.Runtime.InteropServices.DispId(1610678275)]
		uint Top { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060004C6 RID: 1222
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		uint Height { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060004C7 RID: 1223
		[global::System.Runtime.InteropServices.DispId(1610678277)]
		uint Width { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060004C8 RID: 1224
		[global::System.Runtime.InteropServices.DispId(1610678278)]
		int ShouldDisplayMenuBar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060004C9 RID: 1225
		[global::System.Runtime.InteropServices.DispId(1610678279)]
		int ShouldDisplayStatus { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004CA RID: 1226
		[global::System.Runtime.InteropServices.DispId(1610678280)]
		int ShouldDisplayToolbar { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004CB RID: 1227
		[global::System.Runtime.InteropServices.DispId(1610678281)]
		int ShouldDisplayScrollBars { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; }
	}
}
