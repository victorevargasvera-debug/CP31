using System;
using CefSharp.Structs;

namespace CefSharp.Wpf
{
	// Token: 0x02000008 RID: 8
	public class PaintEventArgs : global::System.EventArgs
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00005172 File Offset: 0x00003372
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000517A File Offset: 0x0000337A
		public bool IsPopup { get; private set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00005183 File Offset: 0x00003383
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000518B File Offset: 0x0000338B
		public global::CefSharp.Structs.Rect DirtyRect { get; private set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00005194 File Offset: 0x00003394
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000519C File Offset: 0x0000339C
		public global::System.IntPtr Buffer { get; private set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000051A5 File Offset: 0x000033A5
		// (set) Token: 0x06000144 RID: 324 RVA: 0x000051AD File Offset: 0x000033AD
		public int Width { get; private set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000051B6 File Offset: 0x000033B6
		// (set) Token: 0x06000146 RID: 326 RVA: 0x000051BE File Offset: 0x000033BE
		public int Height { get; private set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000051C7 File Offset: 0x000033C7
		// (set) Token: 0x06000148 RID: 328 RVA: 0x000051CF File Offset: 0x000033CF
		public bool Handled { get; set; }

		// Token: 0x06000149 RID: 329 RVA: 0x000051D8 File Offset: 0x000033D8
		public PaintEventArgs(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height)
		{
			this.IsPopup = isPopup;
			this.DirtyRect = dirtyRect;
			this.Buffer = buffer;
			this.Width = width;
			this.Height = height;
		}
	}
}
