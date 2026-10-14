using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers.DockManager;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000089 RID: 137
	public class DockedPaneSplitter : global::Infragistics.Windows.DockManager.PaneSplitter
	{
		// Token: 0x060004F5 RID: 1269 RVA: 0x0001B311 File Offset: 0x00019511
		internal DockedPaneSplitter()
		{
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0001B319 File Offset: 0x00019519
		internal override global::System.Windows.DependencyProperty ElementBeforeVisibilityProperty
		{
			get
			{
				return global::Infragistics.Windows.DockManager.PaneSplitter.SplitterVisibilityProperty;
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001B320 File Offset: 0x00019520
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DockManager.DockedPaneSplitterAutomationPeer(this);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001B328 File Offset: 0x00019528
		protected override double ConstrainDelta(double delta)
		{
			global::System.Windows.FrameworkElement elementBeforeSplitter = base.ElementBeforeSplitter;
			bool flag = base.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			double num = flag ? elementBeforeSplitter.ActualWidth : elementBeforeSplitter.ActualHeight;
			double val = 10.0 + (flag ? global::System.Windows.SystemParameters.VerticalScrollBarWidth : global::System.Windows.SystemParameters.HorizontalScrollBarHeight);
			double num2 = global::System.Math.Min(num, global::System.Math.Max(val, flag ? elementBeforeSplitter.MinWidth : elementBeforeSplitter.MinHeight));
			double num3 = global::System.Math.Max(num, flag ? elementBeforeSplitter.MaxWidth : elementBeforeSplitter.MaxHeight);
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null && dockManager.DockPanel != null)
			{
				global::System.Windows.Size availableContentSize = dockManager.DockPanel.AvailableContentSize;
				global::Infragistics.Windows.DockManager.SplitPane splitPane = elementBeforeSplitter as global::Infragistics.Windows.DockManager.SplitPane;
				int num4 = dockManager.Panes.IndexOf(splitPane);
				bool flag2 = false;
				bool isDockedLeftRight = splitPane.IsDockedLeftRight;
				int i = num4 + 1;
				int count = dockManager.Panes.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DockManager.SplitPane splitPane2 = dockManager.Panes[i];
					if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDocked(splitPane2) && splitPane2.Visibility == global::System.Windows.Visibility.Visible)
					{
						bool isDockedLeftRight2 = splitPane2.IsDockedLeftRight;
						if (isDockedLeftRight2 != isDockedLeftRight)
						{
							flag2 = true;
						}
						else if (flag2 && flag2)
						{
							double actualWidth = splitPane2.ActualWidth;
							double minimumExtent = global::Infragistics.Windows.DockManager.DockManagerPanel.GetMinimumExtent(splitPane2, isDockedLeftRight2);
							double num5 = actualWidth - minimumExtent;
							if (num5 > 0.0)
							{
								if (isDockedLeftRight2)
								{
									availableContentSize.Width += num5;
								}
								else
								{
									availableContentSize.Height += num5;
								}
							}
						}
					}
					i++;
				}
				num3 = global::System.Math.Min(num3, num + (flag ? availableContentSize.Width : availableContentSize.Height));
			}
			double num6 = this.ProcessDeltaHelper(delta, false);
			if (num6 > num3)
			{
				delta += this.AdjustDeltaForLocation(num3 - num6);
			}
			else if (num6 < num2)
			{
				delta += this.AdjustDeltaForLocation(num2 - num6);
			}
			return delta;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001B500 File Offset: 0x00019700
		protected override void ProcessDelta(double delta, bool isComplete)
		{
			this.ProcessDeltaHelper(delta, true);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0001B50B File Offset: 0x0001970B
		public override global::Infragistics.Windows.DockManager.PaneSplitterType SplitterType
		{
			get
			{
				return global::Infragistics.Windows.DockManager.PaneSplitterType.DockedPane;
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001B510 File Offset: 0x00019710
		private double AdjustDeltaForLocation(double delta)
		{
			switch (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(base.ElementBeforeSplitter))
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				return -delta;
			}
			return delta;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001B544 File Offset: 0x00019744
		private double ProcessDeltaHelper(double delta, bool resizeElement)
		{
			global::System.Windows.FrameworkElement elementBeforeSplitter = base.ElementBeforeSplitter;
			bool flag = base.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			double num = this.AdjustDeltaForLocation(delta);
			global::System.Windows.DependencyProperty dp;
			if (flag)
			{
				dp = global::System.Windows.FrameworkElement.WidthProperty;
				num += global::Infragistics.Windows.DockManager.DockManagerUtilities.GetWidth(elementBeforeSplitter, true);
			}
			else
			{
				dp = global::System.Windows.FrameworkElement.HeightProperty;
				num += global::Infragistics.Windows.DockManager.DockManagerUtilities.GetHeight(elementBeforeSplitter, true);
			}
			if (resizeElement)
			{
				num = global::System.Math.Max(num, 0.0);
				elementBeforeSplitter.SetValue(dp, num);
			}
			return num;
		}
	}
}
