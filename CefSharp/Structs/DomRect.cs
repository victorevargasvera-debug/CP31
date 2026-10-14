using System;

namespace CefSharp.Structs
{
	// Token: 0x020000AC RID: 172
	public struct DomRect
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x000083B6 File Offset: 0x000065B6
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x000083BE File Offset: 0x000065BE
		public double X { get; private set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000083C7 File Offset: 0x000065C7
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x000083CF File Offset: 0x000065CF
		public double Y { get; private set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x000083D8 File Offset: 0x000065D8
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x000083E0 File Offset: 0x000065E0
		public double Width { get; private set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000083E9 File Offset: 0x000065E9
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x000083F1 File Offset: 0x000065F1
		public double Height { get; private set; }

		// Token: 0x06000547 RID: 1351 RVA: 0x000083FA File Offset: 0x000065FA
		public DomRect(double x, double y, double width, double height)
		{
			this.X = x;
			this.Y = y;
			this.Width = width;
			this.Height = height;
		}
	}
}
