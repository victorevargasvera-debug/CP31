using System;
using System.ComponentModel;
using CefSharp.Core;
using CefSharp.Structs;

namespace CefSharp
{
	// Token: 0x02000011 RID: 17
	public class WindowInfo : global::CefSharp.IWindowInfo, global::System.IDisposable
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00003757 File Offset: 0x00001957
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00003764 File Offset: 0x00001964
		public int X
		{
			get
			{
				return this.windowInfo.X;
			}
			set
			{
				this.windowInfo.X = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00003772 File Offset: 0x00001972
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000377F File Offset: 0x0000197F
		public int Y
		{
			get
			{
				return this.windowInfo.Y;
			}
			set
			{
				this.windowInfo.Y = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000378D File Offset: 0x0000198D
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000379A File Offset: 0x0000199A
		public int Width
		{
			get
			{
				return this.windowInfo.Width;
			}
			set
			{
				this.windowInfo.Width = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000037A8 File Offset: 0x000019A8
		// (set) Token: 0x06000132 RID: 306 RVA: 0x000037B5 File Offset: 0x000019B5
		public int Height
		{
			get
			{
				return this.windowInfo.Height;
			}
			set
			{
				this.windowInfo.Height = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000037C3 File Offset: 0x000019C3
		// (set) Token: 0x06000134 RID: 308 RVA: 0x000037D0 File Offset: 0x000019D0
		public uint Style
		{
			get
			{
				return this.windowInfo.Style;
			}
			set
			{
				this.windowInfo.Style = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000037DE File Offset: 0x000019DE
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000037EB File Offset: 0x000019EB
		public uint ExStyle
		{
			get
			{
				return this.windowInfo.ExStyle;
			}
			set
			{
				this.windowInfo.ExStyle = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000037F9 File Offset: 0x000019F9
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00003806 File Offset: 0x00001A06
		public global::System.IntPtr ParentWindowHandle
		{
			get
			{
				return this.windowInfo.ParentWindowHandle;
			}
			set
			{
				this.windowInfo.ParentWindowHandle = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00003814 File Offset: 0x00001A14
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00003821 File Offset: 0x00001A21
		public bool WindowlessRenderingEnabled
		{
			get
			{
				return this.windowInfo.WindowlessRenderingEnabled;
			}
			set
			{
				this.windowInfo.WindowlessRenderingEnabled = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000382F File Offset: 0x00001A2F
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000383C File Offset: 0x00001A3C
		public bool SharedTextureEnabled
		{
			get
			{
				return this.windowInfo.SharedTextureEnabled;
			}
			set
			{
				this.windowInfo.SharedTextureEnabled = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000384A File Offset: 0x00001A4A
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00003857 File Offset: 0x00001A57
		public bool ExternalBeginFrameEnabled
		{
			get
			{
				return this.windowInfo.ExternalBeginFrameEnabled;
			}
			set
			{
				this.windowInfo.ExternalBeginFrameEnabled = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00003865 File Offset: 0x00001A65
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00003872 File Offset: 0x00001A72
		public global::System.IntPtr WindowHandle
		{
			get
			{
				return this.windowInfo.WindowHandle;
			}
			set
			{
				this.windowInfo.WindowHandle = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00003880 File Offset: 0x00001A80
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000388D File Offset: 0x00001A8D
		public string WindowName
		{
			get
			{
				return this.windowInfo.WindowName;
			}
			set
			{
				this.windowInfo.WindowName = value;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000389B File Offset: 0x00001A9B
		public void Dispose()
		{
			this.windowInfo.Dispose();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000038A8 File Offset: 0x00001AA8
		public void SetAsChild(global::System.IntPtr parentHandle)
		{
			this.windowInfo.SetAsChild(parentHandle);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000038B6 File Offset: 0x00001AB6
		public void SetAsChild(global::System.IntPtr parentHandle, global::CefSharp.Structs.Rect windowBounds)
		{
			this.windowInfo.SetAsChild(parentHandle, windowBounds);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000038C5 File Offset: 0x00001AC5
		public void SetAsChild(global::System.IntPtr parentHandle, int left, int top, int right, int bottom)
		{
			this.windowInfo.SetAsChild(parentHandle, left, top, right, bottom);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000038D9 File Offset: 0x00001AD9
		public void SetAsPopup(global::System.IntPtr parentHandle, string windowName)
		{
			this.windowInfo.SetAsPopup(parentHandle, windowName);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000038E8 File Offset: 0x00001AE8
		public void SetAsWindowless(global::System.IntPtr parentHandle)
		{
			this.windowInfo.SetAsWindowless(parentHandle);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000038F6 File Offset: 0x00001AF6
		public static global::CefSharp.IWindowInfo Create()
		{
			return new global::CefSharp.Core.WindowInfo();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000038FD File Offset: 0x00001AFD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::CefSharp.IWindowInfo UnWrap()
		{
			return this.windowInfo;
		}

		// Token: 0x0400000E RID: 14
		private global::CefSharp.Core.WindowInfo windowInfo = new global::CefSharp.Core.WindowInfo();
	}
}
