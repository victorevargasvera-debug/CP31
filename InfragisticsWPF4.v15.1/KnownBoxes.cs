using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics
{
	// Token: 0x0200006E RID: 110
	public static class KnownBoxes
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x000118A9 File Offset: 0x0000FAA9
		public static object FromValue(bool value)
		{
			if (value)
			{
				return global::Infragistics.KnownBoxes.TrueBox;
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000118B9 File Offset: 0x0000FAB9
		public static object FromValue(bool? value)
		{
			if (value == null)
			{
				return null;
			}
			return global::Infragistics.KnownBoxes.FromValue(value.Value);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000118D4 File Offset: 0x0000FAD4
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

		// Token: 0x0600041D RID: 1053 RVA: 0x00011910 File Offset: 0x0000FB10
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

		// Token: 0x0600041E RID: 1054 RVA: 0x00011944 File Offset: 0x0000FB44
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

		// Token: 0x0600041F RID: 1055 RVA: 0x0001196C File Offset: 0x0000FB6C
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

		// Token: 0x06000420 RID: 1056 RVA: 0x000119A8 File Offset: 0x0000FBA8
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

		// Token: 0x06000421 RID: 1057 RVA: 0x000119E4 File Offset: 0x0000FBE4
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

		// Token: 0x0400017F RID: 383
		public static readonly object TrueBox = true;

		// Token: 0x04000180 RID: 384
		public static readonly object FalseBox = false;

		// Token: 0x04000181 RID: 385
		public static readonly object ScrollBarVisibilityHiddenBox = global::System.Windows.Controls.ScrollBarVisibility.Hidden;

		// Token: 0x04000182 RID: 386
		public static readonly object ScrollBarVisibilityVisibleBox = global::System.Windows.Controls.ScrollBarVisibility.Visible;

		// Token: 0x04000183 RID: 387
		public static readonly object ScrollBarVisibilityDisabledBox = global::System.Windows.Controls.ScrollBarVisibility.Disabled;

		// Token: 0x04000184 RID: 388
		public static readonly object ScrollBarVisibilityAutoBox = global::System.Windows.Controls.ScrollBarVisibility.Auto;

		// Token: 0x04000185 RID: 389
		public static readonly object VisibilityHiddenBox = global::System.Windows.Visibility.Hidden;

		// Token: 0x04000186 RID: 390
		public static readonly object VisibilityVisibleBox = global::System.Windows.Visibility.Visible;

		// Token: 0x04000187 RID: 391
		public static readonly object VisibilityCollapsedBox = global::System.Windows.Visibility.Collapsed;

		// Token: 0x04000188 RID: 392
		public static readonly object OrientationVerticalBox = global::System.Windows.Controls.Orientation.Vertical;

		// Token: 0x04000189 RID: 393
		public static readonly object OrientationHorizontalBox = global::System.Windows.Controls.Orientation.Horizontal;

		// Token: 0x0400018A RID: 394
		public static readonly object HorizontalAlignmentCenterBox = global::System.Windows.HorizontalAlignment.Center;

		// Token: 0x0400018B RID: 395
		public static readonly object HorizontalAlignmentLeftBox = global::System.Windows.HorizontalAlignment.Left;

		// Token: 0x0400018C RID: 396
		public static readonly object HorizontalAlignmentRightBox = global::System.Windows.HorizontalAlignment.Right;

		// Token: 0x0400018D RID: 397
		public static readonly object HorizontalAlignmentStretchBox = global::System.Windows.HorizontalAlignment.Stretch;

		// Token: 0x0400018E RID: 398
		public static readonly object VerticalAlignmentCenterBox = global::System.Windows.VerticalAlignment.Center;

		// Token: 0x0400018F RID: 399
		public static readonly object VerticalAlignmentTopBox = global::System.Windows.VerticalAlignment.Top;

		// Token: 0x04000190 RID: 400
		public static readonly object VerticalAlignmentBottomBox = global::System.Windows.VerticalAlignment.Bottom;

		// Token: 0x04000191 RID: 401
		public static readonly object VerticalAlignmentStretchBox = global::System.Windows.VerticalAlignment.Stretch;

		// Token: 0x04000192 RID: 402
		public static readonly object DockTopBox = global::System.Windows.Controls.Dock.Top;

		// Token: 0x04000193 RID: 403
		public static readonly object DockBottomBox = global::System.Windows.Controls.Dock.Bottom;

		// Token: 0x04000194 RID: 404
		public static readonly object DockLeftBox = global::System.Windows.Controls.Dock.Left;

		// Token: 0x04000195 RID: 405
		public static readonly object DockRightBox = global::System.Windows.Controls.Dock.Right;

		// Token: 0x04000196 RID: 406
		internal static readonly object DoubleZeroBox = 0.0;
	}
}
