using System;
using Infragistics.Windows.DockManager.Dragging;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000023 RID: 35
	internal static class DockManagerKnownBoxes
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x000096B8 File Offset: 0x000078B8
		public static object FromValue(global::Infragistics.Windows.DockManager.PaneLocation value)
		{
			switch (value)
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.Unknown:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationUnknownBox;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationDockedLeftBox;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationDockedRightBox;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationDockedTopBox;
			default:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationDockedBottomBox;
			case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationFloatingBox;
			case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationFloatingOnlyBox;
			case global::Infragistics.Windows.DockManager.PaneLocation.Unpinned:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationUnpinnedBox;
			case global::Infragistics.Windows.DockManager.PaneLocation.Document:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationDocumentBox;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00009728 File Offset: 0x00007928
		public static object FromValue(global::Infragistics.Windows.DockManager.InitialPaneLocation value)
		{
			switch (value)
			{
			case global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedTop:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.InitialPaneLocationDockedTopBox;
			case global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedRight:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.InitialPaneLocationDockedRightBox;
			case global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedBottom:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.InitialPaneLocationDockedBottomBox;
			case global::Infragistics.Windows.DockManager.InitialPaneLocation.DockableFloating:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.InitialPaneLocationDockableFloatingBox;
			case global::Infragistics.Windows.DockManager.InitialPaneLocation.FloatingOnly:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.InitialPaneLocationFloatingOnlyBox;
			}
			return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.InitialPaneLocationDockedLeftBox;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000977C File Offset: 0x0000797C
		public static object FromValue(global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation value)
		{
			switch (value)
			{
			default:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.DropPreviewTabLocationNoneBox;
			case global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Left:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.DropPreviewTabLocationLeftBox;
			case global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Top:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.DropPreviewTabLocationTopBox;
			case global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Right:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.DropPreviewTabLocationRightBox;
			case global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Bottom:
				return global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.DropPreviewTabLocationBottomBox;
			}
		}

		// Token: 0x04000128 RID: 296
		public static readonly object PaneLocationDockedLeftBox = global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft;

		// Token: 0x04000129 RID: 297
		public static readonly object PaneLocationDockedTopBox = global::Infragistics.Windows.DockManager.PaneLocation.DockedTop;

		// Token: 0x0400012A RID: 298
		public static readonly object PaneLocationDockedBottomBox = global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom;

		// Token: 0x0400012B RID: 299
		public static readonly object PaneLocationDockedRightBox = global::Infragistics.Windows.DockManager.PaneLocation.DockedRight;

		// Token: 0x0400012C RID: 300
		public static readonly object PaneLocationFloatingBox = global::Infragistics.Windows.DockManager.PaneLocation.Floating;

		// Token: 0x0400012D RID: 301
		public static readonly object PaneLocationFloatingOnlyBox = global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly;

		// Token: 0x0400012E RID: 302
		public static readonly object PaneLocationUnpinnedBox = global::Infragistics.Windows.DockManager.PaneLocation.Unpinned;

		// Token: 0x0400012F RID: 303
		public static readonly object PaneLocationUnknownBox = global::Infragistics.Windows.DockManager.PaneLocation.Unknown;

		// Token: 0x04000130 RID: 304
		public static readonly object PaneLocationDocumentBox = global::Infragistics.Windows.DockManager.PaneLocation.Document;

		// Token: 0x04000131 RID: 305
		public static readonly object DropPreviewTabLocationNoneBox = global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.None;

		// Token: 0x04000132 RID: 306
		public static readonly object DropPreviewTabLocationTopBox = global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Top;

		// Token: 0x04000133 RID: 307
		public static readonly object DropPreviewTabLocationLeftBox = global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Left;

		// Token: 0x04000134 RID: 308
		public static readonly object DropPreviewTabLocationRightBox = global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Right;

		// Token: 0x04000135 RID: 309
		public static readonly object DropPreviewTabLocationBottomBox = global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Bottom;

		// Token: 0x04000136 RID: 310
		public static readonly object InitialPaneLocationDockedLeftBox = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedLeft;

		// Token: 0x04000137 RID: 311
		public static readonly object InitialPaneLocationDockedTopBox = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedTop;

		// Token: 0x04000138 RID: 312
		public static readonly object InitialPaneLocationDockedBottomBox = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedBottom;

		// Token: 0x04000139 RID: 313
		public static readonly object InitialPaneLocationDockedRightBox = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedRight;

		// Token: 0x0400013A RID: 314
		public static readonly object InitialPaneLocationDockableFloatingBox = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockableFloating;

		// Token: 0x0400013B RID: 315
		public static readonly object InitialPaneLocationFloatingOnlyBox = global::Infragistics.Windows.DockManager.InitialPaneLocation.FloatingOnly;
	}
}
