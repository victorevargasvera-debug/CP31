using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Windows.Automation.Peers.DockManager;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000087 RID: 135
	public class SplitPaneSplitter : global::Infragistics.Windows.DockManager.PaneSplitter
	{
		// Token: 0x060004E9 RID: 1257 RVA: 0x0001ACE7 File Offset: 0x00018EE7
		internal SplitPaneSplitter()
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0001ACEF File Offset: 0x00018EEF
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DockManager.SplitPaneSplitterAutomationPeer(this);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0001ACF7 File Offset: 0x00018EF7
		protected override double ConstrainDelta(double delta)
		{
			if (delta < this._dragInfo.BeforeExtent)
			{
				delta = this._dragInfo.BeforeExtent;
			}
			else if (delta > this._dragInfo.AfterExtent)
			{
				delta = this._dragInfo.AfterExtent;
			}
			return delta;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001AD34 File Offset: 0x00018F34
		protected override void OnDraggingChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (true.Equals(e.NewValue))
			{
				global::Infragistics.Windows.DockManager.SplitPane splitPane = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::Infragistics.Windows.DockManager.SplitPane;
				global::System.Windows.FrameworkElement elementBeforeSplitter = base.ElementBeforeSplitter;
				global::System.Windows.FrameworkElement frameworkElement = null;
				if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsFloating(global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(splitPane)))
				{
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(splitPane);
					global::Infragistics.Windows.DockManager.SplitPane splitPane2 = (toolWindow != null) ? (toolWindow.Content as global::Infragistics.Windows.DockManager.SplitPane) : null;
					if (splitPane2 != null && global::Infragistics.Windows.DockManager.XamDockManager.GetFloatingSize(splitPane2).IsEmpty)
					{
						global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> allPanes = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetAllPanes(splitPane, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible);
						if (allPanes != null)
						{
							foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in allPanes)
							{
								if (contentPane.HasHwndHost)
								{
									global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingSize(splitPane2, splitPane2.RenderSize);
									break;
								}
							}
						}
					}
				}
				int num = splitPane.Panes.IndexOf(elementBeforeSplitter);
				int i = num + 1;
				int count = splitPane.Panes.Count;
				while (i < count)
				{
					global::System.Windows.FrameworkElement frameworkElement2 = splitPane.Panes[i];
					if (frameworkElement2.Visibility == global::System.Windows.Visibility.Visible)
					{
						frameworkElement = frameworkElement2;
						break;
					}
					i++;
				}
				if (frameworkElement == null)
				{
					if (base.IsMouseCaptured)
					{
						base.ReleaseMouseCapture();
					}
					else
					{
						base.CancelDrag();
					}
				}
				else
				{
					this._dragInfo = new global::Infragistics.Windows.DockManager.SplitPaneSplitter.SplitDragInfo(this, splitPane, elementBeforeSplitter, frameworkElement);
				}
			}
			base.OnDraggingChanged(e);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001AE90 File Offset: 0x00019090
		protected override void ProcessDelta(double delta, bool isComplete)
		{
			this._dragInfo.ProcessDelta(delta, isComplete);
			if (isComplete)
			{
				this._dragInfo = null;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0001AEA9 File Offset: 0x000190A9
		public override global::Infragistics.Windows.DockManager.PaneSplitterType SplitterType
		{
			get
			{
				return global::Infragistics.Windows.DockManager.PaneSplitterType.SplitPane;
			}
		}

		// Token: 0x0400032B RID: 811
		private global::Infragistics.Windows.DockManager.SplitPaneSplitter.SplitDragInfo _dragInfo;

		// Token: 0x02000088 RID: 136
		private class SplitDragInfo
		{
			// Token: 0x060004EF RID: 1263 RVA: 0x0001AEAC File Offset: 0x000190AC
			internal SplitDragInfo(global::Infragistics.Windows.DockManager.PaneSplitter splitter, global::Infragistics.Windows.DockManager.SplitPane split, global::System.Windows.FrameworkElement elementBefore, global::System.Windows.FrameworkElement elementAfter)
			{
				this._splitter = splitter;
				this._elementBefore = elementBefore;
				this._elementAfter = elementAfter;
				this._split = split;
				this._isVertical = (splitter.Orientation == global::System.Windows.Controls.Orientation.Vertical);
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0001AF09 File Offset: 0x00019109
			internal double BeforeExtent
			{
				get
				{
					if (double.IsNaN(this._beforeExtent))
					{
						this.CalculateBeforeAfterExtent();
					}
					return this._beforeExtent;
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0001AF24 File Offset: 0x00019124
			internal double AfterExtent
			{
				get
				{
					if (double.IsNaN(this._afterExtent))
					{
						this.CalculateBeforeAfterExtent();
					}
					return this._afterExtent;
				}
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x0001AF40 File Offset: 0x00019140
			private void CalculateBeforeAfterExtent()
			{
				bool isVertical = this._isVertical;
				global::System.Windows.Size size = new global::System.Windows.Size(this._elementBefore.MinWidth, this._elementBefore.MinHeight);
				global::System.Windows.Size size2 = new global::System.Windows.Size(this._elementBefore.MaxWidth, this._elementBefore.MaxHeight);
				global::System.Windows.Size size3 = new global::System.Windows.Size(this._elementAfter.MinWidth, this._elementAfter.MinHeight);
				global::System.Windows.Size size4 = new global::System.Windows.Size(this._elementAfter.MaxWidth, this._elementAfter.MaxHeight);
				global::System.Windows.Size size5 = new global::System.Windows.Size(this._elementBefore.ActualWidth, this._elementBefore.ActualHeight);
				global::System.Windows.Size size6 = new global::System.Windows.Size(this._elementAfter.ActualWidth, this._elementAfter.ActualHeight);
				double val = 10.0 + (isVertical ? global::System.Windows.SystemParameters.VerticalScrollBarWidth : global::System.Windows.SystemParameters.HorizontalScrollBarHeight);
				double num = isVertical ? size5.Width : size5.Height;
				double num2 = isVertical ? size6.Width : size6.Height;
				double num3 = global::System.Math.Max(global::System.Math.Min(num, val), isVertical ? size.Width : size.Height);
				double num4 = isVertical ? size2.Width : size2.Height;
				double num5 = global::System.Math.Max(global::System.Math.Min(num2, val), isVertical ? size3.Width : size3.Height);
				double num6 = isVertical ? size4.Width : size4.Height;
				if (!isVertical)
				{
					double actualHeight = this._splitter.ActualHeight;
				}
				else
				{
					double actualWidth = this._splitter.ActualWidth;
				}
				if ((num3 >= num4 && !double.IsNaN(num4)) || (num5 >= num6 && !double.IsNaN(num6)))
				{
				}
				double afterExtent;
				if (!double.IsNaN(num4) && num >= num4)
				{
					afterExtent = 0.0;
				}
				else if (num2 <= num5)
				{
					afterExtent = 0.0;
				}
				else if (num4 != 0.0)
				{
					afterExtent = (double)((int)global::System.Math.Min(num2 - num5, num4 - num));
				}
				else
				{
					afterExtent = num2 - num5;
				}
				double beforeExtent;
				if (num6 != 0.0 && num2 >= num6)
				{
					beforeExtent = 0.0;
				}
				else if (num <= num3)
				{
					beforeExtent = 0.0;
				}
				else if (num6 != 0.0)
				{
					beforeExtent = (double)(-(double)((int)global::System.Math.Min(num - num3, num6 - num2)));
				}
				else
				{
					beforeExtent = -(num - num3);
				}
				this._beforeExtent = beforeExtent;
				this._afterExtent = afterExtent;
			}

			// Token: 0x060004F3 RID: 1267 RVA: 0x0001B1C8 File Offset: 0x000193C8
			internal void Dirty()
			{
				this._beforeExtent = (this._afterExtent = double.NaN);
			}

			// Token: 0x060004F4 RID: 1268 RVA: 0x0001B1F0 File Offset: 0x000193F0
			internal void ProcessDelta(double delta, bool isComplete)
			{
				global::System.Windows.Size relativeSize = global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(this._elementBefore);
				global::System.Windows.Size relativeSize2 = global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(this._elementAfter);
				double num = this._isVertical ? relativeSize.Width : relativeSize.Height;
				double num2 = this._isVertical ? relativeSize2.Width : relativeSize2.Height;
				double num3 = this._isVertical ? this._elementBefore.ActualWidth : this._elementBefore.ActualHeight;
				double num4 = this._isVertical ? this._elementAfter.ActualWidth : this._elementAfter.ActualHeight;
				double num5 = num + num2;
				double val = num3 + num4;
				num3 += delta;
				num4 -= delta;
				double num6 = num5 * (num3 / global::System.Math.Max(val, 1.0));
				double num7 = num5 - num6;
				if (this._isVertical)
				{
					relativeSize.Width = num6;
					relativeSize2.Width = num7;
				}
				else
				{
					relativeSize.Height = num6;
					relativeSize2.Height = num7;
				}
				global::Infragistics.Windows.DockManager.SplitPane.SetRelativeSize(this._elementBefore, relativeSize);
				global::Infragistics.Windows.DockManager.SplitPane.SetRelativeSize(this._elementAfter, relativeSize2);
				if (!isComplete)
				{
					this.Dirty();
				}
			}

			// Token: 0x0400032C RID: 812
			private const double MinExtraSpace = 10.0;

			// Token: 0x0400032D RID: 813
			private global::System.Windows.FrameworkElement _elementBefore;

			// Token: 0x0400032E RID: 814
			private global::System.Windows.FrameworkElement _elementAfter;

			// Token: 0x0400032F RID: 815
			private global::Infragistics.Windows.DockManager.SplitPane _split;

			// Token: 0x04000330 RID: 816
			private global::Infragistics.Windows.DockManager.PaneSplitter _splitter;

			// Token: 0x04000331 RID: 817
			private double _beforeExtent = double.NaN;

			// Token: 0x04000332 RID: 818
			private double _afterExtent = double.NaN;

			// Token: 0x04000333 RID: 819
			private bool _isVertical;
		}
	}
}
