using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x020000D6 RID: 214
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class UnpinnedTabItemPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x00022288 File Offset: 0x00020488
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(finalSize);
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			global::System.Windows.Controls.Dock tabStripPlacement = this.TabStripPlacement;
			bool flag = tabStripPlacement == global::System.Windows.Controls.Dock.Top || tabStripPlacement == global::System.Windows.Controls.Dock.Bottom;
			int i = 0;
			int count = children.Count;
			while (i < count)
			{
				global::System.Windows.UIElement uielement = children[i];
				if (flag)
				{
					finalRect.Width = uielement.DesiredSize.Width;
				}
				else
				{
					finalRect.Height = uielement.DesiredSize.Height;
				}
				uielement.Arrange(finalRect);
				if (flag)
				{
					finalRect.X += finalRect.Width;
				}
				else
				{
					finalRect.Y += finalRect.Height;
				}
				i++;
			}
			return finalSize;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00022348 File Offset: 0x00020548
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			bool isHorizontal = this.IsHorizontal;
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			global::System.Windows.Size availableSize2 = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
			double num = 0.0;
			double num2 = 0.0;
			global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer = null;
			int i = 0;
			int count = children.Count;
			while (i < count)
			{
				global::System.Windows.UIElement uielement = children[i];
				if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem = uielement as global::Infragistics.Windows.DockManager.PaneTabItem;
					global::Infragistics.Windows.DockManager.ContentPane contentPane = (paneTabItem != null) ? paneTabItem.Pane : null;
					global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer2 = (contentPane != null) ? contentPane.PlacementInfo.DockedContainer : null;
					uielement.SetValue(global::Infragistics.Windows.DockManager.UnpinnedTabItemPanel.IsFirstInGroupPropertyKey, (contentPaneContainer2 != contentPaneContainer) ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
					contentPaneContainer = contentPaneContainer2;
					uielement.Measure(availableSize2);
					global::System.Windows.Size desiredSize = uielement.DesiredSize;
					double num3 = isHorizontal ? desiredSize.Width : desiredSize.Height;
					double val = isHorizontal ? desiredSize.Height : desiredSize.Width;
					num += num3;
					num2 = global::System.Math.Max(val, num2);
				}
				i++;
			}
			global::System.Windows.Size result;
			if (isHorizontal)
			{
				result = new global::System.Windows.Size(num, num2);
			}
			else
			{
				result = new global::System.Windows.Size(num2, num);
			}
			return result;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00022480 File Offset: 0x00020680
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
			if (visualRemoved != null)
			{
				visualRemoved.ClearValue(global::Infragistics.Windows.DockManager.UnpinnedTabItemPanel.IsFirstInGroupPropertyKey);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00022498 File Offset: 0x00020698
		private bool IsHorizontal
		{
			get
			{
				switch (this.TabStripPlacement)
				{
				case global::System.Windows.Controls.Dock.Left:
				case global::System.Windows.Controls.Dock.Right:
					return false;
				default:
					return true;
				}
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000224C5 File Offset: 0x000206C5
		public static bool GetIsFirstInGroup(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.UnpinnedTabItemPanel.IsFirstInGroupProperty);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x000224D7 File Offset: 0x000206D7
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x000224E9 File Offset: 0x000206E9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Dock TabStripPlacement
		{
			get
			{
				return (global::System.Windows.Controls.Dock)base.GetValue(global::Infragistics.Windows.DockManager.DocumentTabPanel.TabStripPlacementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.DocumentTabPanel.TabStripPlacementProperty, value);
			}
		}

		// Token: 0x040003C9 RID: 969
		private static readonly global::System.Windows.DependencyPropertyKey IsFirstInGroupPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsFirstInGroup", typeof(bool), typeof(global::Infragistics.Windows.DockManager.UnpinnedTabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003CA RID: 970
		public static readonly global::System.Windows.DependencyProperty IsFirstInGroupProperty = global::Infragistics.Windows.DockManager.UnpinnedTabItemPanel.IsFirstInGroupPropertyKey.DependencyProperty;

		// Token: 0x040003CB RID: 971
		public static readonly global::System.Windows.DependencyProperty TabStripPlacementProperty = global::System.Windows.Controls.TabControl.TabStripPlacementProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabItemPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.DockTopBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
	}
}
