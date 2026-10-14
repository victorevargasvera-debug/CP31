using System;
using CefSharp.Enums;

namespace CefSharp.Structs
{
	// Token: 0x020000AA RID: 170
	public struct CompositionUnderline
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x000082AA File Offset: 0x000064AA
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x000082B2 File Offset: 0x000064B2
		public global::CefSharp.Structs.Range Range { get; private set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x000082BB File Offset: 0x000064BB
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x000082C3 File Offset: 0x000064C3
		public uint Color { get; private set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000082CC File Offset: 0x000064CC
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x000082D4 File Offset: 0x000064D4
		public uint BackgroundColor { get; private set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x000082DD File Offset: 0x000064DD
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x000082E5 File Offset: 0x000064E5
		public bool Thick { get; private set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x000082EE File Offset: 0x000064EE
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x000082F6 File Offset: 0x000064F6
		public global::CefSharp.Enums.CompositionUnderlineStyle Style { get; private set; }

		// Token: 0x06000534 RID: 1332 RVA: 0x000082FF File Offset: 0x000064FF
		public CompositionUnderline(global::CefSharp.Structs.Range range, uint color, uint backGroundColor, bool thick)
		{
			this = default(global::CefSharp.Structs.CompositionUnderline);
			this.Range = range;
			this.Color = color;
			this.BackgroundColor = backGroundColor;
			this.Thick = thick;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00008325 File Offset: 0x00006525
		public CompositionUnderline(global::CefSharp.Structs.Range range, uint color, uint backGroundColor, bool thick, global::CefSharp.Enums.CompositionUnderlineStyle style)
		{
			this = default(global::CefSharp.Structs.CompositionUnderline);
			this.Range = range;
			this.Color = color;
			this.BackgroundColor = backGroundColor;
			this.Thick = thick;
			this.Style = style;
		}
	}
}
