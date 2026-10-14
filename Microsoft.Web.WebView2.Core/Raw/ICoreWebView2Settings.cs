using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000CB RID: 203
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("E562E4F0-D7FA-43AC-8D71-C05150499F00")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2Settings
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600047D RID: 1149
		// (set) Token: 0x0600047E RID: 1150
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		int IsScriptEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600047F RID: 1151
		// (set) Token: 0x06000480 RID: 1152
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		int IsWebMessageEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000481 RID: 1153
		// (set) Token: 0x06000482 RID: 1154
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		int AreDefaultScriptDialogsEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000483 RID: 1155
		// (set) Token: 0x06000484 RID: 1156
		[global::System.Runtime.InteropServices.DispId(1610678278)]
		int IsStatusBarEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000485 RID: 1157
		// (set) Token: 0x06000486 RID: 1158
		[global::System.Runtime.InteropServices.DispId(1610678280)]
		int AreDevToolsEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000487 RID: 1159
		// (set) Token: 0x06000488 RID: 1160
		[global::System.Runtime.InteropServices.DispId(1610678282)]
		int AreDefaultContextMenusEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000489 RID: 1161
		// (set) Token: 0x0600048A RID: 1162
		[global::System.Runtime.InteropServices.DispId(1610678284)]
		int AreHostObjectsAllowed { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600048B RID: 1163
		// (set) Token: 0x0600048C RID: 1164
		[global::System.Runtime.InteropServices.DispId(1610678286)]
		int IsZoomControlEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600048D RID: 1165
		// (set) Token: 0x0600048E RID: 1166
		[global::System.Runtime.InteropServices.DispId(1610678288)]
		int IsBuiltInErrorPageEnabled { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
