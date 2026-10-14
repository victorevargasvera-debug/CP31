using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.DockManager;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200008A RID: 138
	public class UnpinnedTabFlyoutSplitter : global::Infragistics.Windows.DockManager.PaneSplitter
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x0001B5B8 File Offset: 0x000197B8
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DockManager.UnpinnedTabFlyoutSplitterAutomationPeer(this);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001B5C0 File Offset: 0x000197C0
		protected override double ConstrainDelta(double delta)
		{
			global::System.Windows.FrameworkElement frameworkElement = base.TemplatedParent as global::Infragistics.Windows.DockManager.UnpinnedTabFlyout;
			bool flag = base.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			double val = flag ? frameworkElement.ActualWidth : frameworkElement.ActualHeight;
			double val2 = 10.0 + (flag ? (global::System.Windows.SystemParameters.VerticalScrollBarWidth + base.ActualWidth) : (global::System.Windows.SystemParameters.HorizontalScrollBarHeight + base.ActualHeight));
			double num = global::System.Math.Min(val, global::System.Math.Max(val2, flag ? frameworkElement.MinWidth : frameworkElement.MinHeight));
			double num2 = global::System.Math.Max(val, flag ? frameworkElement.MaxWidth : frameworkElement.MaxHeight);
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			global::Infragistics.Windows.DockManager.DockManagerPanel dockManagerPanel = (dockManager != null) ? dockManager.DockPanel : null;
			if (dockManagerPanel != null)
			{
				double reservedSpace = global::Infragistics.Windows.DockManager.UnpinnedTabFlyoutSplitter.GetReservedSpace(flag);
				num2 = global::System.Math.Max(global::System.Math.Min(num2, -reservedSpace + (flag ? dockManagerPanel.ActualWidth : dockManagerPanel.ActualHeight)), 0.0);
			}
			double num3 = this.ProcessDeltaHelper(delta, false);
			if (num3 > num2)
			{
				delta += this.AdjustDeltaForLocation(num2 - num3);
			}
			else if (num3 < num)
			{
				delta += this.AdjustDeltaForLocation(num - num3);
			}
			return delta;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001B6DE File Offset: 0x000198DE
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!(base.TemplatedParent is global::Infragistics.Windows.DockManager.UnpinnedTabFlyout))
			{
				return;
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001B6F5 File Offset: 0x000198F5
		protected override void ProcessDelta(double delta, bool isComplete)
		{
			this.ProcessDeltaHelper(delta, true);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0001B700 File Offset: 0x00019900
		public override global::Infragistics.Windows.DockManager.PaneSplitterType SplitterType
		{
			get
			{
				return global::Infragistics.Windows.DockManager.PaneSplitterType.UnpinnedPane;
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001B704 File Offset: 0x00019904
		private double AdjustDeltaForLocation(double delta)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = base.TemplatedParent as global::Infragistics.Windows.DockManager.UnpinnedTabFlyout;
			if (unpinnedTabFlyout != null)
			{
				switch (unpinnedTabFlyout.Side)
				{
				case global::System.Windows.Controls.Dock.Right:
				case global::System.Windows.Controls.Dock.Bottom:
					return -delta;
				}
			}
			return delta;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001B73D File Offset: 0x0001993D
		internal static double GetReservedSpace(bool isHorizontal)
		{
			return 10.0 + (isHorizontal ? global::System.Windows.SystemParameters.VerticalScrollBarWidth : global::System.Windows.SystemParameters.HorizontalScrollBarHeight);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001B758 File Offset: 0x00019958
		private double ProcessDeltaHelper(double delta, bool resizeElement)
		{
			global::System.Windows.FrameworkElement frameworkElement = base.TemplatedParent as global::Infragistics.Windows.DockManager.UnpinnedTabFlyout;
			bool flag = base.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			double num = this.AdjustDeltaForLocation(delta);
			global::System.Windows.DependencyProperty dp;
			if (flag)
			{
				dp = global::System.Windows.FrameworkElement.WidthProperty;
				num += global::Infragistics.Windows.DockManager.DockManagerUtilities.GetWidth(frameworkElement, true);
			}
			else
			{
				dp = global::System.Windows.FrameworkElement.HeightProperty;
				num += global::Infragistics.Windows.DockManager.DockManagerUtilities.GetHeight(frameworkElement, true);
			}
			if (resizeElement)
			{
				num = global::System.Math.Max(num, 0.0);
				frameworkElement.SetValue(dp, num);
			}
			return num;
		}

		// Token: 0x04000334 RID: 820
		private const double MinExtraSpace = 10.0;
	}
}
