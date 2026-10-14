using System;
using System.ComponentModel;
using CefSharp.Structs;

namespace CefSharp
{
	// Token: 0x02000086 RID: 134
	public interface IWindowInfo : global::System.IDisposable
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600037E RID: 894
		// (set) Token: 0x0600037F RID: 895
		int X { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000380 RID: 896
		// (set) Token: 0x06000381 RID: 897
		int Y { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000382 RID: 898
		// (set) Token: 0x06000383 RID: 899
		int Width { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000384 RID: 900
		// (set) Token: 0x06000385 RID: 901
		int Height { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000386 RID: 902
		// (set) Token: 0x06000387 RID: 903
		uint Style { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000388 RID: 904
		// (set) Token: 0x06000389 RID: 905
		uint ExStyle { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600038A RID: 906
		// (set) Token: 0x0600038B RID: 907
		global::System.IntPtr ParentWindowHandle { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600038C RID: 908
		// (set) Token: 0x0600038D RID: 909
		bool WindowlessRenderingEnabled { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600038E RID: 910
		// (set) Token: 0x0600038F RID: 911
		bool SharedTextureEnabled { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000390 RID: 912
		// (set) Token: 0x06000391 RID: 913
		bool ExternalBeginFrameEnabled { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000392 RID: 914
		// (set) Token: 0x06000393 RID: 915
		global::System.IntPtr WindowHandle { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000394 RID: 916
		// (set) Token: 0x06000395 RID: 917
		string WindowName { get; set; }

		// Token: 0x06000396 RID: 918
		void SetAsChild(global::System.IntPtr parentHandle);

		// Token: 0x06000397 RID: 919
		void SetAsChild(global::System.IntPtr parentHandle, global::CefSharp.Structs.Rect windowBounds);

		// Token: 0x06000398 RID: 920
		void SetAsChild(global::System.IntPtr parentHandle, int left, int top, int right, int bottom);

		// Token: 0x06000399 RID: 921
		void SetAsPopup(global::System.IntPtr parentHandle, string windowName);

		// Token: 0x0600039A RID: 922
		void SetAsWindowless(global::System.IntPtr parentHandle);

		// Token: 0x0600039B RID: 923
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		global::CefSharp.IWindowInfo UnWrap();
	}
}
