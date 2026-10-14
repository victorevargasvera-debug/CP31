using System;
using CefSharp.Enums;

namespace CefSharp.Structs
{
	// Token: 0x020000B2 RID: 178
	public struct TouchEvent
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000085E9 File Offset: 0x000067E9
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x000085F1 File Offset: 0x000067F1
		public int Id { get; set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x000085FA File Offset: 0x000067FA
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00008602 File Offset: 0x00006802
		public float X { get; set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0000860B File Offset: 0x0000680B
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00008613 File Offset: 0x00006813
		public float Y { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0000861C File Offset: 0x0000681C
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00008624 File Offset: 0x00006824
		public float RadiusX { get; set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0000862D File Offset: 0x0000682D
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00008635 File Offset: 0x00006835
		public float RadiusY { get; set; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0000863E File Offset: 0x0000683E
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00008646 File Offset: 0x00006846
		public float RotationAngle { get; set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000864F File Offset: 0x0000684F
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00008657 File Offset: 0x00006857
		public global::CefSharp.Enums.PointerType PointerType { get; set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00008660 File Offset: 0x00006860
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00008668 File Offset: 0x00006868
		public float Pressure { get; set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00008671 File Offset: 0x00006871
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00008679 File Offset: 0x00006879
		public global::CefSharp.Enums.TouchEventType Type { get; set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00008682 File Offset: 0x00006882
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0000868A File Offset: 0x0000688A
		public global::CefSharp.CefEventFlags Modifiers { get; set; }
	}
}
