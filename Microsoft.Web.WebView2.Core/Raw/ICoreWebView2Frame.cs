using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000AC RID: 172
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("F1131A5E-9BA9-11EB-A8B3-0242AC130003")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2Frame
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003F1 RID: 1009
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		string Name { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] get; }

		// Token: 0x060003F2 RID: 1010
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_NameChanged([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameNameChangedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003F3 RID: 1011
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_NameChanged([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003F4 RID: 1012
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void AddHostObjectToScriptWithOrigins([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string name, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] ref object @object, [global::System.Runtime.InteropServices.In] uint originsCount, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPArray, ArraySubType = global::System.Runtime.InteropServices.UnmanagedType.LPWStr, SizeParamIndex = 2)] [global::System.Runtime.InteropServices.In] string[] origins);

		// Token: 0x060003F5 RID: 1013
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void RemoveHostObjectFromScript([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string name);

		// Token: 0x060003F6 RID: 1014
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void add_Destroyed([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Interface)] [global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameDestroyedEventHandler eventHandler, out global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003F7 RID: 1015
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		void remove_Destroyed([global::System.Runtime.InteropServices.In] global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken token);

		// Token: 0x060003F8 RID: 1016
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		int IsDestroyed();
	}
}
