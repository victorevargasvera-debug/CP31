using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x020000C4 RID: 196
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	[global::System.Runtime.InteropServices.Guid("E6995887-D10D-4F5D-9359-4CE46E4F96B9")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.InteropServices.ComImport]
	public interface ICoreWebView2PointerInfo
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000434 RID: 1076
		// (set) Token: 0x06000435 RID: 1077
		[global::System.Runtime.InteropServices.DispId(1610678272)]
		uint PointerKind { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000436 RID: 1078
		// (set) Token: 0x06000437 RID: 1079
		[global::System.Runtime.InteropServices.DispId(1610678274)]
		uint PointerId { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000438 RID: 1080
		// (set) Token: 0x06000439 RID: 1081
		[global::System.Runtime.InteropServices.DispId(1610678276)]
		uint FrameId { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600043A RID: 1082
		// (set) Token: 0x0600043B RID: 1083
		[global::System.Runtime.InteropServices.DispId(1610678278)]
		uint PointerFlags { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600043C RID: 1084
		// (set) Token: 0x0600043D RID: 1085
		[global::System.Runtime.InteropServices.DispId(1610678280)]
		global::Microsoft.Web.WebView2.Core.Raw.tagRECT PointerDeviceRect { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600043E RID: 1086
		// (set) Token: 0x0600043F RID: 1087
		[global::System.Runtime.InteropServices.DispId(1610678282)]
		global::Microsoft.Web.WebView2.Core.Raw.tagRECT DisplayRect { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000440 RID: 1088
		// (set) Token: 0x06000441 RID: 1089
		[global::System.Runtime.InteropServices.DispId(1610678284)]
		global::Microsoft.Web.WebView2.Core.Raw.tagPOINT PixelLocation { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000442 RID: 1090
		// (set) Token: 0x06000443 RID: 1091
		[global::System.Runtime.InteropServices.DispId(1610678286)]
		global::Microsoft.Web.WebView2.Core.Raw.tagPOINT HimetricLocation { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000444 RID: 1092
		// (set) Token: 0x06000445 RID: 1093
		[global::System.Runtime.InteropServices.DispId(1610678288)]
		global::Microsoft.Web.WebView2.Core.Raw.tagPOINT PixelLocationRaw { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000446 RID: 1094
		// (set) Token: 0x06000447 RID: 1095
		[global::System.Runtime.InteropServices.DispId(1610678290)]
		global::Microsoft.Web.WebView2.Core.Raw.tagPOINT HimetricLocationRaw { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000448 RID: 1096
		// (set) Token: 0x06000449 RID: 1097
		[global::System.Runtime.InteropServices.DispId(1610678292)]
		uint Time { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600044A RID: 1098
		// (set) Token: 0x0600044B RID: 1099
		[global::System.Runtime.InteropServices.DispId(1610678294)]
		uint HistoryCount { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600044C RID: 1100
		// (set) Token: 0x0600044D RID: 1101
		[global::System.Runtime.InteropServices.DispId(1610678296)]
		int InputData { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600044E RID: 1102
		// (set) Token: 0x0600044F RID: 1103
		[global::System.Runtime.InteropServices.DispId(1610678298)]
		uint KeyStates { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000450 RID: 1104
		// (set) Token: 0x06000451 RID: 1105
		[global::System.Runtime.InteropServices.DispId(1610678300)]
		ulong PerformanceCount { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000452 RID: 1106
		// (set) Token: 0x06000453 RID: 1107
		[global::System.Runtime.InteropServices.DispId(1610678302)]
		int ButtonChangeKind { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000454 RID: 1108
		// (set) Token: 0x06000455 RID: 1109
		[global::System.Runtime.InteropServices.DispId(1610678304)]
		uint PenFlags { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000456 RID: 1110
		// (set) Token: 0x06000457 RID: 1111
		[global::System.Runtime.InteropServices.DispId(1610678306)]
		uint PenMask { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000458 RID: 1112
		// (set) Token: 0x06000459 RID: 1113
		[global::System.Runtime.InteropServices.DispId(1610678308)]
		uint PenPressure { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600045A RID: 1114
		// (set) Token: 0x0600045B RID: 1115
		[global::System.Runtime.InteropServices.DispId(1610678310)]
		uint PenRotation { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600045C RID: 1116
		// (set) Token: 0x0600045D RID: 1117
		[global::System.Runtime.InteropServices.DispId(1610678312)]
		int PenTiltX { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600045E RID: 1118
		// (set) Token: 0x0600045F RID: 1119
		[global::System.Runtime.InteropServices.DispId(1610678314)]
		int PenTiltY { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000460 RID: 1120
		// (set) Token: 0x06000461 RID: 1121
		[global::System.Runtime.InteropServices.DispId(1610678316)]
		uint TouchFlags { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000462 RID: 1122
		// (set) Token: 0x06000463 RID: 1123
		[global::System.Runtime.InteropServices.DispId(1610678318)]
		uint TouchMask { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000464 RID: 1124
		// (set) Token: 0x06000465 RID: 1125
		[global::System.Runtime.InteropServices.DispId(1610678320)]
		global::Microsoft.Web.WebView2.Core.Raw.tagRECT TouchContact { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000466 RID: 1126
		// (set) Token: 0x06000467 RID: 1127
		[global::System.Runtime.InteropServices.DispId(1610678322)]
		global::Microsoft.Web.WebView2.Core.Raw.tagRECT TouchContactRaw { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000468 RID: 1128
		// (set) Token: 0x06000469 RID: 1129
		[global::System.Runtime.InteropServices.DispId(1610678324)]
		uint TouchOrientation { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600046A RID: 1130
		// (set) Token: 0x0600046B RID: 1131
		[global::System.Runtime.InteropServices.DispId(1610678326)]
		uint TouchPressure { [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] get; [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)] [param: global::System.Runtime.InteropServices.In] set; }
	}
}
