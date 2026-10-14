using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics
{
	// Token: 0x0200005A RID: 90
	public static class KnownBoxes
	{
		// Token: 0x06000385 RID: 901 RVA: 0x0000FC41 File Offset: 0x0000DE41
		public static object FromValue(bool value)
		{
			if (value)
			{
				return global::Infragistics.KnownBoxes.TrueBox;
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000FC51 File Offset: 0x0000DE51
		public static object FromValue(bool? value)
		{
			if (value == null)
			{
				return null;
			}
			return global::Infragistics.KnownBoxes.FromValue(value.Value);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000FC6C File Offset: 0x0000DE6C
		public static object FromValue(global::System.Windows.Controls.ScrollBarVisibility value)
		{
			switch (value)
			{
			case global::System.Windows.Controls.ScrollBarVisibility.Disabled:
				return global::Infragistics.KnownBoxes.ScrollBarVisibilityDisabledBox;
			default:
				return global::Infragistics.KnownBoxes.ScrollBarVisibilityAutoBox;
			case global::System.Windows.Controls.ScrollBarVisibility.Hidden:
				return global::Infragistics.KnownBoxes.ScrollBarVisibilityHiddenBox;
			case global::System.Windows.Controls.ScrollBarVisibility.Visible:
				return global::Infragistics.KnownBoxes.ScrollBarVisibilityVisibleBox;
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		public static object FromValue(global::System.Windows.Visibility value)
		{
			switch (value)
			{
			case global::System.Windows.Visibility.Hidden:
				return global::Infragistics.KnownBoxes.VisibilityHiddenBox;
			case global::System.Windows.Visibility.Collapsed:
				return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			return global::Infragistics.KnownBoxes.VisibilityVisibleBox;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000FCDC File Offset: 0x0000DEDC
		public static object FromValue(global::System.Windows.Controls.Orientation value)
		{
			switch (value)
			{
			case global::System.Windows.Controls.Orientation.Horizontal:
				return global::Infragistics.KnownBoxes.OrientationHorizontalBox;
			default:
				return global::Infragistics.KnownBoxes.OrientationVerticalBox;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000FD04 File Offset: 0x0000DF04
		public static object FromValue(global::System.Windows.HorizontalAlignment value)
		{
			switch (value)
			{
			case global::System.Windows.HorizontalAlignment.Left:
				return global::Infragistics.KnownBoxes.HorizontalAlignmentLeftBox;
			case global::System.Windows.HorizontalAlignment.Center:
				return global::Infragistics.KnownBoxes.HorizontalAlignmentCenterBox;
			case global::System.Windows.HorizontalAlignment.Right:
				return global::Infragistics.KnownBoxes.HorizontalAlignmentRightBox;
			default:
				return global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox;
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000FD40 File Offset: 0x0000DF40
		public static object FromValue(global::System.Windows.VerticalAlignment value)
		{
			switch (value)
			{
			case global::System.Windows.VerticalAlignment.Top:
				return global::Infragistics.KnownBoxes.VerticalAlignmentTopBox;
			case global::System.Windows.VerticalAlignment.Center:
				return global::Infragistics.KnownBoxes.VerticalAlignmentCenterBox;
			case global::System.Windows.VerticalAlignment.Bottom:
				return global::Infragistics.KnownBoxes.VerticalAlignmentBottomBox;
			default:
				return global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox;
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000FD7C File Offset: 0x0000DF7C
		public static object FromValue(global::System.Windows.Controls.Dock value)
		{
			switch (value)
			{
			case global::System.Windows.Controls.Dock.Left:
				return global::Infragistics.KnownBoxes.DockLeftBox;
			default:
				return global::Infragistics.KnownBoxes.DockTopBox;
			case global::System.Windows.Controls.Dock.Right:
				return global::Infragistics.KnownBoxes.DockRightBox;
			case global::System.Windows.Controls.Dock.Bottom:
				return global::Infragistics.KnownBoxes.DockBottomBox;
			}
		}

		// Token: 0x04000124 RID: 292
		public static readonly object TrueBox = true;

		// Token: 0x04000125 RID: 293
		public static readonly object FalseBox = false;

		// Token: 0x04000126 RID: 294
		public static readonly object ScrollBarVisibilityHiddenBox = global::System.Windows.Controls.ScrollBarVisibility.Hidden;

		// Token: 0x04000127 RID: 295
		public static readonly object ScrollBarVisibilityVisibleBox = global::System.Windows.Controls.ScrollBarVisibility.Visible;

		// Token: 0x04000128 RID: 296
		public static readonly object ScrollBarVisibilityDisabledBox = global::System.Windows.Controls.ScrollBarVisibility.Disabled;

		// Token: 0x04000129 RID: 297
		public static readonly object ScrollBarVisibilityAutoBox = global::System.Windows.Controls.ScrollBarVisibility.Auto;

		// Token: 0x0400012A RID: 298
		public static readonly object VisibilityHiddenBox = global::System.Windows.Visibility.Hidden;

		// Token: 0x0400012B RID: 299
		public static readonly object VisibilityVisibleBox = global::System.Windows.Visibility.Visible;

		// Token: 0x0400012C RID: 300
		public static readonly object VisibilityCollapsedBox = global::System.Windows.Visibility.Collapsed;

		// Token: 0x0400012D RID: 301
		public static readonly object OrientationVerticalBox = global::System.Windows.Controls.Orientation.Vertical;

		// Token: 0x0400012E RID: 302
		public static readonly object OrientationHorizontalBox = global::System.Windows.Controls.Orientation.Horizontal;

		// Token: 0x0400012F RID: 303
		public static readonly object HorizontalAlignmentCenterBox = global::System.Windows.HorizontalAlignment.Center;

		// Token: 0x04000130 RID: 304
		public static readonly object HorizontalAlignmentLeftBox = global::System.Windows.HorizontalAlignment.Left;

		// Token: 0x04000131 RID: 305
		public static readonly object HorizontalAlignmentRightBox = global::System.Windows.HorizontalAlignment.Right;

		// Token: 0x04000132 RID: 306
		public static readonly object HorizontalAlignmentStretchBox = global::System.Windows.HorizontalAlignment.Stretch;

		// Token: 0x04000133 RID: 307
		public static readonly object VerticalAlignmentCenterBox = global::System.Windows.VerticalAlignment.Center;

		// Token: 0x04000134 RID: 308
		public static readonly object VerticalAlignmentTopBox = global::System.Windows.VerticalAlignment.Top;

		// Token: 0x04000135 RID: 309
		public static readonly object VerticalAlignmentBottomBox = global::System.Windows.VerticalAlignment.Bottom;

		// Token: 0x04000136 RID: 310
		public static readonly object VerticalAlignmentStretchBox = global::System.Windows.VerticalAlignment.Stretch;

		// Token: 0x04000137 RID: 311
		public static readonly object DockTopBox = global::System.Windows.Controls.Dock.Top;

		// Token: 0x04000138 RID: 312
		public static readonly object DockBottomBox = global::System.Windows.Controls.Dock.Bottom;

		// Token: 0x04000139 RID: 313
		public static readonly object DockLeftBox = global::System.Windows.Controls.Dock.Left;

		// Token: 0x0400013A RID: 314
		public static readonly object DockRightBox = global::System.Windows.Controls.Dock.Right;

		// Token: 0x0400013B RID: 315
		internal static readonly object DoubleZeroBox = 0.0;
	}
}
