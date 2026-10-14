using System;

namespace CefSharp
{
	// Token: 0x0200009A RID: 154
	public struct MouseEvent
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00006BF7 File Offset: 0x00004DF7
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00006BFF File Offset: 0x00004DFF
		public int X { get; private set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00006C08 File Offset: 0x00004E08
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00006C10 File Offset: 0x00004E10
		public int Y { get; private set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00006C19 File Offset: 0x00004E19
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00006C21 File Offset: 0x00004E21
		public global::CefSharp.CefEventFlags Modifiers { get; private set; }

		// Token: 0x0600046F RID: 1135 RVA: 0x00006C2A File Offset: 0x00004E2A
		public MouseEvent(int x, int y, global::CefSharp.CefEventFlags modifiers)
		{
			this = default(global::CefSharp.MouseEvent);
			this.X = x;
			this.Y = y;
			this.Modifiers = modifiers;
		}
	}
}
