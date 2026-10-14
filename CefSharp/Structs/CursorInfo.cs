using System;

namespace CefSharp.Structs
{
	// Token: 0x020000AB RID: 171
	public struct CursorInfo
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00008353 File Offset: 0x00006553
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0000835B File Offset: 0x0000655B
		public global::System.IntPtr Buffer { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00008364 File Offset: 0x00006564
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x0000836C File Offset: 0x0000656C
		public global::CefSharp.Structs.Point Hotspot { get; private set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00008375 File Offset: 0x00006575
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x0000837D File Offset: 0x0000657D
		public float ImageScaleFactor { get; private set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00008386 File Offset: 0x00006586
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0000838E File Offset: 0x0000658E
		public global::CefSharp.Structs.Size Size { get; private set; }

		// Token: 0x0600053E RID: 1342 RVA: 0x00008397 File Offset: 0x00006597
		public CursorInfo(global::System.IntPtr buffer, global::CefSharp.Structs.Point hotspot, float imageScaleFactor, global::CefSharp.Structs.Size size)
		{
			this.Buffer = buffer;
			this.Hotspot = hotspot;
			this.ImageScaleFactor = imageScaleFactor;
			this.Size = size;
		}
	}
}
