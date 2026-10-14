using System;

namespace CefSharp.Structs
{
	// Token: 0x020000B0 RID: 176
	public struct ScreenInfo
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0000854A File Offset: 0x0000674A
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00008552 File Offset: 0x00006752
		public float DeviceScaleFactor { get; set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0000855B File Offset: 0x0000675B
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00008563 File Offset: 0x00006763
		public int Depth { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0000856C File Offset: 0x0000676C
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00008574 File Offset: 0x00006774
		public int DepthPerComponent { get; set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0000857D File Offset: 0x0000677D
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00008585 File Offset: 0x00006785
		public bool IsMonochrome { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0000858E File Offset: 0x0000678E
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00008596 File Offset: 0x00006796
		public global::CefSharp.Structs.Rect? Rect { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0000859F File Offset: 0x0000679F
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000085A7 File Offset: 0x000067A7
		public global::CefSharp.Structs.Rect? AvailableRect { get; set; }
	}
}
