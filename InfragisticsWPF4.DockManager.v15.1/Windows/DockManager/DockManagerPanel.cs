using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DockManager.Dragging;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000025 RID: 37
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.Markup.ContentProperty("Child")]
	public class DockManagerPanel : global::System.Windows.FrameworkElement, global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner, global::Infragistics.Windows.DockManager.IHwndHostInfoOwner
	{
		// Token: 0x060001CD RID: 461 RVA: 0x000098AD File Offset: 0x00007AAD
		public DockManagerPanel()
		{
			this._panes = new global::Infragistics.Windows.DockManager.ObservableSplitElementCollection<global::Infragistics.Windows.DockManager.SplitPane>(this, global::Infragistics.Windows.DockManager.PaneSplitterMode.SinglePane);
			this._panes.CollectionChanged += this.OnPanesChanged;
			global::Infragistics.Windows.DockManager.HwndHostInfo.SetHwndHost(this, new global::Infragistics.Windows.DockManager.HwndHostInfo(this));
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000098F4 File Offset: 0x00007AF4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(finalSize);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo>();
			global::System.Windows.UIElement fillElement = this.FillElement;
			global::System.Windows.Size size = default(global::System.Windows.Size);
			global::System.Windows.Size size2 = default(global::System.Windows.Size);
			int i = 0;
			int count = this._panes.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DockManager.SplitPane splitPane = this._panes[i];
				if (splitPane != fillElement)
				{
					global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo paneSizeInfo = new global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo(splitPane);
					if (paneSizeInfo.IsPaneVisible || paneSizeInfo.IsSplitterVisible)
					{
						list.Add(paneSizeInfo);
						bool isLeftRight = paneSizeInfo.IsLeftRight;
						if (paneSizeInfo.IsPaneVisible)
						{
							global::System.Windows.Size desiredSize = splitPane.DesiredSize;
							paneSizeInfo.ExplicitExtent = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetExtent(splitPane, false, isLeftRight);
							if (double.IsNaN(paneSizeInfo.ExplicitExtent))
							{
								paneSizeInfo.PreferredExtent = (isLeftRight ? desiredSize.Width : desiredSize.Height);
							}
							else
							{
								paneSizeInfo.PreferredExtent = paneSizeInfo.ExplicitExtent;
								if (isLeftRight)
								{
									size2.Width += paneSizeInfo.ExplicitExtent - paneSizeInfo.ExplicitMinExtent;
								}
								else
								{
									size2.Height += paneSizeInfo.ExplicitExtent - paneSizeInfo.ExplicitMinExtent;
								}
							}
							paneSizeInfo.MinExtent = global::Infragistics.Windows.DockManager.DockManagerPanel.GetMinimumExtent(splitPane, isLeftRight);
						}
						global::Infragistics.Windows.DockManager.PaneSplitter splitter = paneSizeInfo.Splitter;
						if (paneSizeInfo.IsSplitterVisible)
						{
							paneSizeInfo.SplitterExtent = (isLeftRight ? splitter.DesiredSize.Width : splitter.DesiredSize.Height);
						}
						if (isLeftRight)
						{
							size.Width += paneSizeInfo.PreferredExtent + paneSizeInfo.SplitterExtent;
						}
						else
						{
							size.Height += paneSizeInfo.PreferredExtent + paneSizeInfo.SplitterExtent;
						}
					}
				}
				i++;
			}
			global::System.Windows.Size size3 = this.CalculateMinimumContentSize();
			double num = global::System.Math.Min(size2.Width, size3.Width + size.Width - finalSize.Width);
			double num2 = global::System.Math.Min(size2.Height, size3.Height + size.Height - finalSize.Height);
			bool flag = false;
			if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsGreaterThan(num, 0.0) || global::Infragistics.Windows.DockManager.DockManagerUtilities.IsGreaterThan(num2, 0.0))
			{
				bool flag2 = global::Infragistics.CoreUtilities.GreaterThan(finalSize.Width, 0.0) && global::Infragistics.CoreUtilities.GreaterThan(finalSize.Height, 0.0);
				double num3 = 0.0;
				for (int j = list.Count - 1; j >= 0; j--)
				{
					global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo paneSizeInfo2 = list[j];
					if (paneSizeInfo2.IsPaneVisible && !double.IsNaN(paneSizeInfo2.ExplicitExtent))
					{
						bool isLeftRight2 = paneSizeInfo2.IsLeftRight;
						double num4 = isLeftRight2 ? num : num2;
						if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsGreaterThan(num4, 0.0))
						{
							double num5;
							if (!flag)
							{
								num5 = paneSizeInfo2.ExplicitExtent - paneSizeInfo2.MinExtent;
							}
							else
							{
								if (paneSizeInfo2.MinExtent <= paneSizeInfo2.ExplicitMinExtent)
								{
									goto IL_3CD;
								}
								num5 = global::System.Math.Min(1.0, paneSizeInfo2.MinExtent - paneSizeInfo2.ExplicitMinExtent);
								paneSizeInfo2.MinExtent -= num5;
							}
							num5 = global::System.Math.Min(num4, num5);
							if (num5 > 0.0)
							{
								num3 += num5;
								paneSizeInfo2.PreferredExtent -= num5;
								global::System.Windows.Size desiredSize2 = paneSizeInfo2.Pane.DesiredSize;
								if (isLeftRight2)
								{
									if (flag2)
									{
										paneSizeInfo2.Pane.Width -= num5;
									}
									num -= num5;
									desiredSize2.Width = paneSizeInfo2.PreferredExtent;
								}
								else
								{
									if (flag2)
									{
										paneSizeInfo2.Pane.Height -= num5;
									}
									num2 -= num5;
									desiredSize2.Height = paneSizeInfo2.PreferredExtent;
								}
								this.MeasureElementImpl(paneSizeInfo2.Pane, desiredSize2);
							}
						}
					}
					IL_3CD:;
				}
				if (!flag || num3 > 0.0)
				{
				}
			}
			int k = 0;
			int count2 = list.Count;
			while (k < count2)
			{
				global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo paneSizeInfo3 = list[k];
				global::Infragistics.Windows.DockManager.SplitPane pane = paneSizeInfo3.Pane;
				global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(pane);
				if (paneSizeInfo3.IsPaneVisible)
				{
					global::System.Windows.Size desiredSize3 = pane.DesiredSize;
					if (paneSizeInfo3.IsLeftRight)
					{
						desiredSize3.Width = paneSizeInfo3.PreferredExtent;
					}
					else
					{
						desiredSize3.Height = paneSizeInfo3.PreferredExtent;
					}
					this.ArrangeDocked(pane, paneLocation, desiredSize3, ref rect);
				}
				if (paneSizeInfo3.IsSplitterVisible)
				{
					global::Infragistics.Windows.DockManager.PaneSplitter splitter2 = paneSizeInfo3.Splitter;
					if (splitter2 != null)
					{
						this.ArrangeDocked(splitter2, paneLocation, splitter2.DesiredSize, ref rect);
					}
				}
				k++;
			}
			this._lastContentRect = rect;
			if (fillElement != null)
			{
				fillElement.Arrange(rect);
			}
			if (this._flyoutPanel != null)
			{
				this.ArrangeFlyout(finalSize);
			}
			if (this._unpinnedContainer != null)
			{
				this._unpinnedContainer.Arrange(new global::System.Windows.Rect(finalSize));
			}
			if (num > 0.0)
			{
				finalSize.Width += num;
			}
			if (num2 > 0.0)
			{
				finalSize.Height += num2;
			}
			return finalSize;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009E3C File Offset: 0x0000803C
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			int visualChildrenCount = this._panes.VisualChildrenCount;
			if (index < visualChildrenCount)
			{
				return this._panes.GetVisualChild(index);
			}
			index -= visualChildrenCount;
			if (this._child != null)
			{
				if (index == 0)
				{
					return this._child;
				}
				index--;
			}
			if (this._flyoutPanel != null && this.FlyoutIsChildElement)
			{
				if (index == 0)
				{
					return this._flyoutPanel;
				}
				index--;
			}
			if (this._unpinnedContainer != null)
			{
				if (index == 0)
				{
					return this._unpinnedContainer;
				}
				index--;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00009EC0 File Offset: 0x000080C0
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
				{
					this._panes.GetSplitterEnumerator(),
					new global::Infragistics.Collections.SingleItemEnumerator(this.FlyoutIsChildElement ? this._flyoutPanel : null),
					new global::Infragistics.Collections.SingleItemEnumerator(this._unpinnedContainer)
				});
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00009F10 File Offset: 0x00008110
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::Infragistics.Windows.DockManager.DockManagerPanel.DockSize dockSize = default(global::Infragistics.Windows.DockManager.DockManagerPanel.DockSize);
			global::System.Windows.Size availableSize2 = availableSize;
			global::System.Windows.Size size = this.CalculateMinimumContentSize();
			global::System.Windows.Size size2 = size;
			global::System.Windows.Size size3 = default(global::System.Windows.Size);
			global::System.Windows.UIElement fillElement = this.FillElement;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo>();
			int i = 0;
			int count = this._panes.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DockManager.SplitPane splitPane = this._panes[i];
				if (splitPane != fillElement)
				{
					global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo paneSizeInfo = new global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo(splitPane);
					if (paneSizeInfo.IsPaneVisible || paneSizeInfo.IsSplitterVisible)
					{
						list.Add(paneSizeInfo);
						if (paneSizeInfo.IsPaneVisible)
						{
							paneSizeInfo.MinExtent = global::Infragistics.Windows.DockManager.DockManagerPanel.GetMinimumExtent(splitPane, paneSizeInfo.IsLeftRight);
							if (paneSizeInfo.IsLeftRight)
							{
								size2.Width += paneSizeInfo.ExplicitMinExtent;
								size3.Width += paneSizeInfo.MinExtent - paneSizeInfo.ExplicitMinExtent;
							}
							else
							{
								size2.Height += paneSizeInfo.ExplicitMinExtent;
								size3.Height += paneSizeInfo.MinExtent - paneSizeInfo.ExplicitMinExtent;
							}
						}
						if (paneSizeInfo.IsSplitterVisible)
						{
							global::Infragistics.Windows.DockManager.PaneSplitter splitter = paneSizeInfo.Splitter;
							splitter.Measure(availableSize);
							global::System.Windows.Size desiredSize = splitter.DesiredSize;
							if (paneSizeInfo.IsLeftRight)
							{
								paneSizeInfo.SplitterExtent = desiredSize.Width;
								size2.Width += paneSizeInfo.SplitterExtent;
							}
							else
							{
								paneSizeInfo.SplitterExtent = desiredSize.Height;
								size2.Height += paneSizeInfo.SplitterExtent;
							}
						}
					}
				}
				i++;
			}
			global::System.Windows.Size size4 = new global::System.Windows.Size(size3.Width + size2.Width, size3.Height + size2.Height);
			global::System.Windows.Size size5 = new global::System.Windows.Size(global::System.Math.Max(size4.Width - global::System.Math.Max(size2.Width, availableSize.Width), 0.0), global::System.Math.Max(size4.Height - global::System.Math.Max(size2.Height, availableSize.Height), 0.0));
			while (size5.Width > 0.0 || size5.Height > 0.0)
			{
				global::System.Windows.Size size6 = size5;
				for (int j = list.Count - 1; j >= 0; j--)
				{
					global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo paneSizeInfo2 = list[j];
					if (paneSizeInfo2.IsPaneVisible)
					{
						if (paneSizeInfo2.IsLeftRight && size5.Width > 0.0 && paneSizeInfo2.MinExtent > paneSizeInfo2.ExplicitMinExtent)
						{
							double num = global::System.Math.Min(1.0, size5.Width);
							paneSizeInfo2.MinExtent -= num;
							global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractWidth(ref size5, num);
						}
						else if (!paneSizeInfo2.IsLeftRight && size5.Height > 0.0 && paneSizeInfo2.MinExtent > paneSizeInfo2.ExplicitMinExtent)
						{
							double num2 = global::System.Math.Min(1.0, size5.Height);
							paneSizeInfo2.MinExtent -= num2;
							global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractHeight(ref size5, num2);
						}
					}
				}
				if (size6.Equals(size5))
				{
					break;
				}
			}
			int k = 0;
			int count2 = list.Count;
			while (k < count2)
			{
				global::Infragistics.Windows.DockManager.DockManagerPanel.PaneSizeInfo paneSizeInfo3 = list[k];
				global::Infragistics.Windows.DockManager.SplitPane pane = paneSizeInfo3.Pane;
				global::Infragistics.Windows.DockManager.PaneSplitter splitter2 = paneSizeInfo3.Splitter;
				bool isLeftRight = paneSizeInfo3.IsLeftRight;
				double num3;
				if (isLeftRight)
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractWidth(ref size4, paneSizeInfo3.MinExtent);
					num3 = global::System.Math.Max(global::System.Math.Min(availableSize.Width - paneSizeInfo3.MinExtent, size4.Width), 0.0);
					global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractWidth(ref availableSize, num3);
				}
				else
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractHeight(ref size4, paneSizeInfo3.MinExtent);
					num3 = global::System.Math.Max(global::System.Math.Min(availableSize.Height - paneSizeInfo3.MinExtent, size4.Height), 0.0);
					global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractHeight(ref availableSize, num3);
				}
				if (paneSizeInfo3.IsPaneVisible)
				{
					pane.Measure(availableSize);
					global::System.Windows.Size desiredSize2 = pane.DesiredSize;
					dockSize.AddDocked(isLeftRight, desiredSize2);
					global::Infragistics.Windows.DockManager.DockManagerPanel.AdjustAvailableSize(isLeftRight, desiredSize2, ref availableSize);
				}
				if (paneSizeInfo3.IsSplitterVisible)
				{
					double num4 = global::System.Math.Min(num3, paneSizeInfo3.SplitterExtent);
					num3 -= num4;
					if (isLeftRight)
					{
						global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractWidth(ref size4, paneSizeInfo3.SplitterExtent);
						availableSize.Width += num4;
					}
					else
					{
						global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractHeight(ref size4, paneSizeInfo3.SplitterExtent);
						availableSize.Height += num4;
					}
					splitter2.Measure(availableSize);
					dockSize.AddDocked(isLeftRight, splitter2.DesiredSize);
					global::Infragistics.Windows.DockManager.DockManagerPanel.AdjustAvailableSize(isLeftRight, splitter2.DesiredSize, ref availableSize);
				}
				if (isLeftRight)
				{
					availableSize.Width += num3;
				}
				else
				{
					availableSize.Height += num3;
				}
				k++;
			}
			if (fillElement != null)
			{
				fillElement.Measure(availableSize);
				global::System.Windows.Size desiredSize3 = fillElement.DesiredSize;
				dockSize.Width += desiredSize3.Width;
				dockSize.Height += desiredSize3.Height;
			}
			if (this._flyoutPanel != null && this.FlyoutIsChildElement)
			{
				this._flyoutPanel.Measure(availableSize2);
			}
			if (this._unpinnedContainer != null)
			{
				this._unpinnedContainer.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
			}
			return dockSize.ToSize();
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A4A0 File Offset: 0x000086A0
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._elementBeingMeasured == child)
			{
				return;
			}
			if (child is global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer)
			{
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000A4BC File Offset: 0x000086BC
		protected override int VisualChildrenCount
		{
			get
			{
				int num = (this._child != null) ? 1 : 0;
				num += this._panes.VisualChildrenCount;
				if (this._flyoutPanel != null && this.FlyoutIsChildElement)
				{
					num++;
				}
				if (this._unpinnedContainer != null)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000A505 File Offset: 0x00008705
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000A50D File Offset: 0x0000870D
		public global::System.Windows.UIElement Child
		{
			get
			{
				return this._child;
			}
			set
			{
				if (value != this._child)
				{
					if (this._child != null)
					{
						base.RemoveVisualChild(this._child);
					}
					this._child = value;
					if (this._child != null)
					{
						base.AddVisualChild(this._child);
					}
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000A548 File Offset: 0x00008748
		internal global::System.Windows.Size AvailableContentSize
		{
			get
			{
				global::System.Windows.Size size = this._lastContentRect.Size;
				global::System.Windows.Size size2 = this.CalculateMinimumContentSize();
				global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractWidth(ref size, size2.Width);
				global::Infragistics.Windows.DockManager.DockManagerUtilities.SubtractHeight(ref size, size2.Height);
				return size;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000A588 File Offset: 0x00008788
		internal global::Infragistics.Windows.DockManager.UnpinnedTabFlyout FlyoutPanel
		{
			get
			{
				if (this._flyoutPanel == null)
				{
					this.VerifyFlyoutPanelHost(null);
				}
				return this._flyoutPanel;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000A5B2 File Offset: 0x000087B2
		internal bool HasFlyoutPanel
		{
			get
			{
				return this._flyoutPanel != null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000A5C0 File Offset: 0x000087C0
		internal bool HasHwndHost
		{
			get
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(this);
				return hwndHost != null && hwndHost.HasHwndHost;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000A5DF File Offset: 0x000087DF
		internal global::System.Windows.Rect LastContentRect
		{
			get
			{
				return this._lastContentRect;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000A5E7 File Offset: 0x000087E7
		internal global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DockManager.SplitPane> Panes
		{
			get
			{
				return this._panes;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000A5F0 File Offset: 0x000087F0
		private global::System.Windows.UIElement FillElement
		{
			get
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				if (dockManager == null)
				{
					return this._child;
				}
				switch (dockManager.LayoutMode)
				{
				default:
					return this._child;
				case global::Infragistics.Windows.DockManager.DockedPaneLayoutMode.FillContainer:
					return dockManager.FillPane;
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000A630 File Offset: 0x00008830
		private bool FlyoutIsChildElement
		{
			get
			{
				return this._flyoutWindow == null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000A63B File Offset: 0x0000883B
		private global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer UnpinnedContainer
		{
			get
			{
				if (this._unpinnedContainer == null)
				{
					this._unpinnedContainer = new global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer();
					base.AddVisualChild(this._unpinnedContainer);
					base.AddLogicalChild(this._unpinnedContainer);
				}
				return this._unpinnedContainer;
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A670 File Offset: 0x00008870
		internal void AddUnpinnedPane(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (pane.IsPinned)
			{
				return;
			}
			if (global::System.Windows.Media.VisualTreeHelper.GetParent(pane) == null)
			{
				this.UnpinnedContainer.AddPane(pane);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A69C File Offset: 0x0000889C
		internal static double GetMinimumExtent(global::Infragistics.Windows.DockManager.SplitPane split, bool width)
		{
			double result;
			if (width)
			{
				double num = 10.0 + global::System.Windows.SystemParameters.VerticalScrollBarWidth;
				if (!double.IsNaN(split.Width))
				{
					num = global::System.Math.Min(num, split.Width);
				}
				result = global::System.Math.Max(split.MinWidth, num);
			}
			else
			{
				double num2 = 10.0 + global::System.Windows.SystemParameters.HorizontalScrollBarHeight;
				if (!double.IsNaN(split.Height))
				{
					num2 = global::System.Math.Min(num2, split.Height);
				}
				result = global::System.Math.Max(split.MinHeight, num2);
			}
			return result;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A71D File Offset: 0x0000891D
		internal void RemoveAllUnpinnedPanes()
		{
			if (this.HasFlyoutPanel)
			{
				this._flyoutPanel.HideFlyout(null, false, false, true, false, false);
			}
			if (this._unpinnedContainer != null)
			{
				this._unpinnedContainer.RemoveAllPanes();
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A74B File Offset: 0x0000894B
		internal void RemoveUnpinnedPane(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (this.HasFlyoutPanel)
			{
				this._flyoutPanel.HideFlyout(pane, false, false, true, false, false);
			}
			this.UnpinnedContainer.RemovePane(pane);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A774 File Offset: 0x00008974
		internal void VerifyFlyoutPanelHost(bool? useToolWindow)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			bool flag = this._flyoutWindow != null;
			bool flag2 = this._flyoutPanel == null;
			bool flag3 = (useToolWindow == null) ? (dockManager != null && dockManager.ShowFlyoutInToolWindow) : useToolWindow.Value;
			if (flag3 && this._flyoutWindow == null)
			{
				this._flyoutWindow = new global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow();
				this._flyoutWindow.UseOSNonClientArea = false;
				this._flyoutWindow.ResizeMode = global::System.Windows.ResizeMode.NoResize;
				this._flyoutWindow.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey, dockManager);
				this._flyoutWindow.Template = global::Infragistics.Windows.DockManager.Dragging.DragManager.GetIndicatorToolWindowTemplate(dockManager);
				this._flyoutWindow.VerticalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
				this._flyoutWindow.HorizontalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment;
				this._flyoutWindow.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			}
			if (flag3 != flag && this._flyoutPanel != null)
			{
				flag2 = true;
				this._flyoutPanel.HideFlyout(null, false, false, true, false, false);
				if (flag)
				{
					this._flyoutWindow.Close();
					this._flyoutWindow.Content = null;
					this._flyoutWindow = null;
				}
				else
				{
					base.RemoveLogicalChild(this._flyoutPanel);
					base.RemoveVisualChild(this._flyoutPanel);
				}
			}
			if (this._flyoutPanel == null)
			{
				global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer unpinnedContainer = this.UnpinnedContainer;
				this._flyoutPanel = new global::Infragistics.Windows.DockManager.UnpinnedTabFlyout();
				this._flyoutPanel.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
				this._flyoutPanel.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationUnpinnedBox);
				this._flyoutPanel.SetBinding(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.MaxFlyoutWidthProperty, new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(global::System.Windows.FrameworkElement.ActualWidthProperty),
					Source = this
				});
				this._flyoutPanel.SetBinding(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.MaxFlyoutHeightProperty, new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(global::System.Windows.FrameworkElement.ActualHeightProperty),
					Source = this
				});
			}
			if (flag2)
			{
				if (!flag3)
				{
					base.AddVisualChild(this._flyoutPanel);
					base.AddLogicalChild(this._flyoutPanel);
					return;
				}
				this._flyoutWindow.Content = this._flyoutPanel;
				this._flyoutWindow.Tag = global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindowId;
				this._flyoutPanel.InitializeToolWindowAlignment();
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A998 File Offset: 0x00008B98
		private static void AdjustAvailableSize(bool isLeftRight, global::System.Windows.Size dockedSize, ref global::System.Windows.Size availableSize)
		{
			if (isLeftRight)
			{
				availableSize.Width = global::System.Math.Max(availableSize.Width - dockedSize.Width, 0.0);
				return;
			}
			availableSize.Height = global::System.Math.Max(availableSize.Height - dockedSize.Height, 0.0);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A9F0 File Offset: 0x00008BF0
		private void ArrangeDocked(global::System.Windows.UIElement element, global::Infragistics.Windows.DockManager.PaneLocation location, global::System.Windows.Size paneSize, ref global::System.Windows.Rect finalRect)
		{
			global::System.Windows.Rect finalRect2 = new global::System.Windows.Rect(finalRect.X, finalRect.Y, paneSize.Width, paneSize.Height);
			switch (location)
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
				finalRect2.Height = finalRect.Height;
				finalRect.X += finalRect2.Width;
				finalRect.Width = global::System.Math.Max(finalRect.Width - finalRect2.Width, 0.0);
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				finalRect2.Height = finalRect.Height;
				finalRect2.X = global::System.Math.Max(finalRect.Right - finalRect2.Width, 0.0);
				finalRect.Width = global::System.Math.Max(finalRect.Width - finalRect2.Width, 0.0);
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
				finalRect2.Width = finalRect.Width;
				finalRect.Y += finalRect2.Height;
				finalRect.Height = global::System.Math.Max(finalRect.Height - finalRect2.Height, 0.0);
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				finalRect2.Y = global::System.Math.Max(finalRect.Bottom - finalRect2.Height, 0.0);
				finalRect2.Width = finalRect.Width;
				finalRect.Height = global::System.Math.Max(finalRect.Height - finalRect2.Height, 0.0);
				break;
			default:
				finalRect2 = default(global::System.Windows.Rect);
				break;
			}
			element.Arrange(finalRect2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000AB98 File Offset: 0x00008D98
		private void ArrangeFlyout(global::System.Windows.Size finalSize)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (!this.FlyoutIsChildElement)
			{
				return;
			}
			if (this._flyoutPanel != null && dockManager != null)
			{
				global::System.Windows.Controls.Dock side = this._flyoutPanel.Side;
				global::System.Windows.Rect rect = new global::System.Windows.Rect(finalSize);
				switch (side)
				{
				default:
					rect.Width = 0.0;
					break;
				case global::System.Windows.Controls.Dock.Top:
					rect.Height = 0.0;
					break;
				case global::System.Windows.Controls.Dock.Right:
					rect.X = rect.Width;
					rect.Width = 0.0;
					break;
				case global::System.Windows.Controls.Dock.Bottom:
					rect.Y = rect.Height;
					rect.Height = 0.0;
					break;
				}
				global::System.Windows.Size desiredSize = this._flyoutPanel.DesiredSize;
				global::System.Windows.Rect finalRect = new global::System.Windows.Rect(desiredSize);
				switch (side)
				{
				default:
					finalRect.Location = rect.TopRight;
					finalRect.Height = rect.Height;
					break;
				case global::System.Windows.Controls.Dock.Top:
					finalRect.Location = rect.BottomLeft;
					finalRect.Width = rect.Width;
					break;
				case global::System.Windows.Controls.Dock.Right:
					finalRect.Location = rect.TopLeft;
					finalRect.X -= finalRect.Width;
					finalRect.Height = rect.Height;
					break;
				case global::System.Windows.Controls.Dock.Bottom:
					finalRect.Location = rect.TopLeft;
					finalRect.Y -= finalRect.Height;
					finalRect.Width = rect.Width;
					break;
				}
				this._flyoutPanel.Arrange(finalRect);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000AD34 File Offset: 0x00008F34
		private global::System.Windows.Size CalculateMinimumContentSize()
		{
			global::System.Windows.Size result = default(global::System.Windows.Size);
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			global::System.Windows.UIElement fillElement = this.FillElement;
			if (fillElement == this._child && (dockManager == null || !dockManager.HasContent))
			{
				return result;
			}
			if (fillElement != null)
			{
				double val = 0.0;
				double val2 = 0.0;
				global::System.Windows.FrameworkElement frameworkElement = fillElement as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					val = frameworkElement.MinWidth;
					val2 = frameworkElement.MinHeight;
				}
				result.Width = global::System.Math.Max(val, global::System.Windows.SystemParameters.VerticalScrollBarWidth + 5.0);
				result.Height = global::System.Math.Max(val2, global::System.Windows.SystemParameters.HorizontalScrollBarHeight + 5.0);
			}
			return result;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000ADDC File Offset: 0x00008FDC
		private void MeasureElementImpl(global::System.Windows.UIElement element, global::System.Windows.Size availableSize)
		{
			global::System.Windows.UIElement elementBeingMeasured = this._elementBeingMeasured;
			this._elementBeingMeasured = element;
			try
			{
				element.Measure(availableSize);
			}
			finally
			{
				this._elementBeingMeasured = elementBeingMeasured;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000AE18 File Offset: 0x00009018
		private void OnPanesChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.InvalidateMeasure();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000AE20 File Offset: 0x00009020
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnElementAdding(global::System.Windows.FrameworkElement newElement)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000AE22 File Offset: 0x00009022
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnElementAdded(global::System.Windows.FrameworkElement newElement)
		{
			base.AddVisualChild(newElement);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000AE2B File Offset: 0x0000902B
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnElementRemoved(global::System.Windows.FrameworkElement oldElement)
		{
			base.RemoveVisualChild(oldElement);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000AE34 File Offset: 0x00009034
		global::Infragistics.Windows.DockManager.PaneSplitter global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.CreateSplitter()
		{
			return new global::Infragistics.Windows.DockManager.DockedPaneSplitter();
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000AE3B File Offset: 0x0000903B
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnSplitterAdded(global::Infragistics.Windows.DockManager.PaneSplitter splitter)
		{
			splitter.SetBinding(global::Infragistics.Windows.DockManager.PaneSplitter.OrientationProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationProperty, global::System.Windows.Data.BindingMode.OneWay, splitter.ElementBeforeSplitter, global::Infragistics.Windows.DockManager.DockedLocationToSplitterOrientationConverter.Instance));
			base.AddVisualChild(splitter);
			base.AddLogicalChild(splitter);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000AE6D File Offset: 0x0000906D
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnSplitterRemoved(global::Infragistics.Windows.DockManager.PaneSplitter splitter)
		{
			global::System.Windows.Data.BindingOperations.ClearBinding(splitter, global::Infragistics.Windows.DockManager.PaneSplitter.OrientationProperty);
			base.RemoveLogicalChild(splitter);
			base.RemoveVisualChild(splitter);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000AE88 File Offset: 0x00009088
		void global::Infragistics.Windows.DockManager.IHwndHostInfoOwner.OnHasHostsChanged()
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				dockManager.DirtyHasHwndHosts();
			}
		}

		// Token: 0x0400013C RID: 316
		private global::System.Windows.UIElement _child;

		// Token: 0x0400013D RID: 317
		private global::Infragistics.Windows.DockManager.ObservableSplitElementCollection<global::Infragistics.Windows.DockManager.SplitPane> _panes;

		// Token: 0x0400013E RID: 318
		private global::Infragistics.Windows.DockManager.UnpinnedTabFlyout _flyoutPanel;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Rect _lastContentRect;

		// Token: 0x04000140 RID: 320
		private global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer _unpinnedContainer;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.UIElement _elementBeingMeasured;

		// Token: 0x04000142 RID: 322
		private global::Infragistics.Windows.Controls.ToolWindow _flyoutWindow;

		// Token: 0x04000143 RID: 323
		internal static readonly object FlyoutToolWindowId = new object();

		// Token: 0x02000026 RID: 38
		private struct DockSize
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x0000AEA8 File Offset: 0x000090A8
			public void AddDocked(bool isLeftRight, global::System.Windows.Size size)
			{
				if (isLeftRight)
				{
					this.Width += size.Width;
					this.LeftRightHeight = global::System.Math.Max(this.LeftRightHeight, this.Height + size.Height);
					return;
				}
				this.Height += size.Height;
				this.TopBottomWidth = global::System.Math.Max(this.TopBottomWidth, this.Width + size.Width);
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x0000AF1F File Offset: 0x0000911F
			public global::System.Windows.Size ToSize()
			{
				return new global::System.Windows.Size(global::System.Math.Max(this.Width, this.TopBottomWidth), global::System.Math.Max(this.Height, this.LeftRightHeight));
			}

			// Token: 0x04000144 RID: 324
			internal double Width;

			// Token: 0x04000145 RID: 325
			internal double TopBottomWidth;

			// Token: 0x04000146 RID: 326
			internal double Height;

			// Token: 0x04000147 RID: 327
			internal double LeftRightHeight;
		}

		// Token: 0x02000027 RID: 39
		private class PaneSizeInfo
		{
			// Token: 0x060001F4 RID: 500 RVA: 0x0000AF48 File Offset: 0x00009148
			internal PaneSizeInfo(global::Infragistics.Windows.DockManager.SplitPane pane)
			{
				this.Pane = pane;
				this.Splitter = global::Infragistics.Windows.DockManager.PaneSplitter.GetSplitter(pane);
				this.IsLeftRight = pane.IsDockedLeftRight;
				this.IsPaneVisible = (pane.Visibility != global::System.Windows.Visibility.Collapsed);
				this.IsSplitterVisible = (this.Splitter != null && this.Splitter.Visibility != global::System.Windows.Visibility.Collapsed);
				if (this.IsPaneVisible)
				{
					this.ExplicitMinExtent = (this.IsLeftRight ? pane.MinWidth : pane.MinHeight);
				}
			}

			// Token: 0x04000148 RID: 328
			internal readonly global::Infragistics.Windows.DockManager.SplitPane Pane;

			// Token: 0x04000149 RID: 329
			internal readonly global::Infragistics.Windows.DockManager.PaneSplitter Splitter;

			// Token: 0x0400014A RID: 330
			internal readonly bool IsLeftRight;

			// Token: 0x0400014B RID: 331
			internal double PreferredExtent;

			// Token: 0x0400014C RID: 332
			internal double MinExtent;

			// Token: 0x0400014D RID: 333
			internal double SplitterExtent;

			// Token: 0x0400014E RID: 334
			internal double ExplicitExtent;

			// Token: 0x0400014F RID: 335
			internal double ExplicitMinExtent;

			// Token: 0x04000150 RID: 336
			internal bool IsPaneVisible;

			// Token: 0x04000151 RID: 337
			internal bool IsSplitterVisible;
		}

		// Token: 0x02000028 RID: 40
		internal class UnpinnedPaneContainer : global::System.Windows.FrameworkElement
		{
			// Token: 0x060001F5 RID: 501 RVA: 0x0000AFD4 File Offset: 0x000091D4
			static UnpinnedPaneContainer()
			{
				global::System.Windows.UIElement.IsHitTestVisibleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
				global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer.OnRequestBringIntoView));
				global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer), global::Infragistics.Windows.DockManager.DockManagerUtilities.VisibilityChangedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer.OnChildVisibilityChanged));
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x0000B07A File Offset: 0x0000927A
			internal UnpinnedPaneContainer()
			{
				this._panes = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
				base.Opacity = 0.0;
				base.Clip = global::System.Windows.Media.Geometry.Empty;
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x0000B0A7 File Offset: 0x000092A7
			public static bool GetIsHiddenUnpinned(global::System.Windows.DependencyObject d)
			{
				return (bool)d.GetValue(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer.IsHiddenUnpinnedProperty);
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x0000B0BC File Offset: 0x000092BC
			private static void OnIsHiddenUnpinnedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = d as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane != null)
				{
					contentPane.VerifyContentVisibility();
					contentPane.HideAllHwndHosts();
					contentPane.VerifyIsVisibleResolved();
				}
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x0000B0E5 File Offset: 0x000092E5
			internal void AddPane(global::System.Windows.FrameworkElement pane)
			{
				this._panes.Add(pane);
				base.AddVisualChild(pane);
				pane.SetValue(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer.IsHiddenUnpinnedProperty, global::Infragistics.KnownBoxes.TrueBox);
			}

			// Token: 0x060001FA RID: 506 RVA: 0x0000B10C File Offset: 0x0000930C
			private static void OnChildVisibilityChanged(object sender, global::System.Windows.RoutedEventArgs e)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = e.OriginalSource as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane != null)
				{
					global::Infragistics.Windows.DockManager.UnpinnedTabArea unpinnedTabArea = global::System.Windows.LogicalTreeHelper.GetParent(contentPane) as global::Infragistics.Windows.DockManager.UnpinnedTabArea;
					if (unpinnedTabArea != null)
					{
						unpinnedTabArea.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
						e.Handled = true;
					}
				}
			}

			// Token: 0x060001FB RID: 507 RVA: 0x0000B14C File Offset: 0x0000934C
			private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
			{
				global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer unpinnedPaneContainer = sender as global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer;
				unpinnedPaneContainer.OnRequestBringIntoView(e);
			}

			// Token: 0x060001FC RID: 508 RVA: 0x0000B168 File Offset: 0x00009368
			private void OnRequestBringIntoView(global::System.Windows.RequestBringIntoViewEventArgs e)
			{
				global::System.Windows.DependencyObject dependencyObject = e.TargetObject;
				while (dependencyObject != null && !(dependencyObject is global::Infragistics.Windows.DockManager.ContentPane))
				{
					dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject, true);
				}
				global::Infragistics.Windows.DockManager.ContentPane contentPane = dependencyObject as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane != null && contentPane.Visibility == global::System.Windows.Visibility.Visible)
				{
					global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane);
					if (dockManager != null && dockManager == global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this) && !dockManager.IsShowFlyoutSuspended)
					{
						dockManager.ShowFlyout(contentPane, false, false);
					}
				}
			}

			// Token: 0x060001FD RID: 509 RVA: 0x0000B1C8 File Offset: 0x000093C8
			internal void RemoveAllPanes()
			{
				global::System.Windows.FrameworkElement[] array = this._panes.ToArray();
				for (int i = array.Length - 1; i >= 0; i--)
				{
					this._panes.RemoveAt(i);
					base.RemoveVisualChild(array[i]);
					array[i].ClearValue(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer.IsHiddenUnpinnedProperty);
				}
			}

			// Token: 0x060001FE RID: 510 RVA: 0x0000B213 File Offset: 0x00009413
			internal void RemovePane(global::System.Windows.FrameworkElement pane)
			{
				this._panes.Remove(pane);
				base.RemoveVisualChild(pane);
				pane.ClearValue(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer.IsHiddenUnpinnedProperty);
			}

			// Token: 0x060001FF RID: 511 RVA: 0x0000B234 File Offset: 0x00009434
			protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
			{
				return base.MeasureOverride(availableSize);
			}

			// Token: 0x06000200 RID: 512 RVA: 0x0000B23D File Offset: 0x0000943D
			protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
			{
				return base.ArrangeOverride(finalSize);
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000201 RID: 513 RVA: 0x0000B246 File Offset: 0x00009446
			protected override int VisualChildrenCount
			{
				get
				{
					return this._panes.Count;
				}
			}

			// Token: 0x06000202 RID: 514 RVA: 0x0000B253 File Offset: 0x00009453
			protected override global::System.Windows.Media.Visual GetVisualChild(int index)
			{
				return this._panes[index];
			}

			// Token: 0x04000152 RID: 338
			private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> _panes;

			// Token: 0x04000153 RID: 339
			public static readonly global::System.Windows.DependencyProperty IsHiddenUnpinnedProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsHiddenUnpinned", typeof(bool), typeof(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits | global::System.Windows.FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer.OnIsHiddenUnpinnedChanged)));
		}

		// Token: 0x02000029 RID: 41
		private class FlyoutToolWindow : global::Infragistics.Windows.Controls.ToolWindow
		{
			// Token: 0x06000203 RID: 515 RVA: 0x0000B264 File Offset: 0x00009464
			internal FlyoutToolWindow()
			{
				base.AddHandler(global::System.Windows.Input.CommandManager.CanExecuteEvent, new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow.OnCanExecuteCommand));
				base.AddHandler(global::System.Windows.Input.CommandManager.ExecutedEvent, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow.OnExecuteCommand));
				global::System.Windows.Input.KeyEventHandler value = new global::System.Windows.Input.KeyEventHandler(global::Infragistics.Windows.DockManager.DockManagerUtilities.OnToolWindowKeyEvent);
				base.PreviewKeyDown += value;
				base.PreviewKeyUp += value;
				base.KeyDown += value;
				base.KeyUp += value;
				base.SetBinding(global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow.SideProperty, new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath("Content.Side", new object[0]),
					RelativeSource = global::System.Windows.Data.RelativeSource.Self,
					FallbackValue = null
				});
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000204 RID: 516 RVA: 0x0000B309 File Offset: 0x00009509
			internal override bool KeepOnScreen
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000205 RID: 517 RVA: 0x0000B30C File Offset: 0x0000950C
			protected override void OnActivated(global::System.EventArgs e)
			{
				base.OnActivated(e);
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				if (dockManager != null)
				{
					dockManager.ActivePaneManager.OnToolWindowActivationChanged(this);
				}
			}

			// Token: 0x06000206 RID: 518 RVA: 0x0000B338 File Offset: 0x00009538
			protected override void OnDeactivated(global::System.EventArgs e)
			{
				base.OnDeactivated(e);
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				if (dockManager != null)
				{
					dockManager.ActivePaneManager.OnToolWindowActivationChanged(this);
				}
			}

			// Token: 0x06000207 RID: 519 RVA: 0x0000B364 File Offset: 0x00009564
			protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
			{
				base.OnKeyDown(e);
				if (e.Handled)
				{
					return;
				}
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				if (dockManager != null)
				{
					dockManager.ProcessKeyDown(e);
				}
			}

			// Token: 0x06000208 RID: 520 RVA: 0x0000B394 File Offset: 0x00009594
			protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
			{
				base.OnKeyUp(e);
				if (e.Handled)
				{
					return;
				}
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				if (dockManager != null)
				{
					dockManager.ProcessKeyUp(e);
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000209 RID: 521 RVA: 0x0000B3C2 File Offset: 0x000095C2
			protected override bool SupportsAllowsTransparency
			{
				get
				{
					return !global::Infragistics.Windows.DockManager.DockManagerUtilities.GetPreventAllowsTransparency(this);
				}
			}

			// Token: 0x0600020A RID: 522 RVA: 0x0000B3D0 File Offset: 0x000095D0
			private static void OnSideChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::System.Windows.Controls.Dock? dock = (global::System.Windows.Controls.Dock?)e.NewValue;
				if (dock == null)
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(d, global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupHeightProperty);
					global::System.Windows.Data.BindingOperations.ClearBinding(d, global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupWidthProperty);
					return;
				}
				bool flag = dock.Value == global::System.Windows.Controls.Dock.Left || dock.Value == global::System.Windows.Controls.Dock.Right;
				global::System.Windows.Data.BindingOperations.SetBinding(d, global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupHeightProperty, new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(flag ? "Height" : "Content.Height", new object[0]),
					RelativeSource = global::System.Windows.Data.RelativeSource.Self
				});
				global::System.Windows.Data.BindingOperations.SetBinding(d, global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupWidthProperty, new global::System.Windows.Data.Binding
				{
					Path = new global::System.Windows.PropertyPath(flag ? "Content.Width" : "Width", new object[0]),
					RelativeSource = global::System.Windows.Data.RelativeSource.Self
				});
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600020B RID: 523 RVA: 0x0000B49D File Offset: 0x0000969D
			// (set) Token: 0x0600020C RID: 524 RVA: 0x0000B4AF File Offset: 0x000096AF
			private global::System.Windows.Controls.Dock? Side
			{
				get
				{
					return (global::System.Windows.Controls.Dock?)base.GetValue(global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow.SideProperty);
				}
				set
				{
					base.SetValue(global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow.SideProperty, value);
				}
			}

			// Token: 0x0600020D RID: 525 RVA: 0x0000B4C4 File Offset: 0x000096C4
			private static void OnCanExecuteCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
			{
				global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow d = sender as global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow;
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(d);
				if (dockManager != null)
				{
					global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
					if (routedCommand != null)
					{
						e.CanExecute = routedCommand.CanExecute(e.Parameter, dockManager);
						e.ContinueRouting = false;
						e.Handled = true;
					}
				}
			}

			// Token: 0x0600020E RID: 526 RVA: 0x0000B514 File Offset: 0x00009714
			private static void OnExecuteCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
			{
				global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow d = sender as global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow;
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(d);
				if (dockManager != null)
				{
					global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
					if (routedCommand != null)
					{
						routedCommand.Execute(e.Parameter, dockManager);
						e.Handled = true;
					}
				}
			}

			// Token: 0x04000154 RID: 340
			public static readonly global::System.Windows.DependencyProperty SideProperty = global::Infragistics.DependencyPropertyUtilities.Register("Side", typeof(global::System.Windows.Controls.Dock?), typeof(global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindow.OnSideChanged)));
		}
	}
}
