using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Infragistics.Controls.Menus.Primitives
{
	// Token: 0x0200002A RID: 42
	public class NodesPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x00007804 File Offset: 0x00005A04
		public NodesPanel()
		{
			this._clipRG = new global::System.Windows.Media.RectangleGeometry();
			base.Clip = this._clipRG;
			this._visibleNodes = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Menus.XamDataTreeNode>();
			this._overrideVerticalMax = -1.0;
			this._nonReleasedNodes = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Menus.XamDataTreeNode>();
			this._notVisibleAndNotArrangedNodes = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
			base.IsManipulationEnabled = true;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000078B2 File Offset: 0x00005AB2
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000078BA File Offset: 0x00005ABA
		public global::Infragistics.Controls.Menus.XamDataTree Tree
		{
			get
			{
				return this._tree;
			}
			protected internal set
			{
				if (this._tree != value)
				{
					this._tree = value;
					this.ScrollInfo = this._tree;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000078D8 File Offset: 0x00005AD8
		public global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Menus.XamDataTreeNode> VisibleNodes
		{
			get
			{
				return this._visibleNodes;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000078E0 File Offset: 0x00005AE0
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000078E8 File Offset: 0x00005AE8
		internal bool MeasureCalled
		{
			get
			{
				return this._measureCalled;
			}
			set
			{
				this._measureCalled = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000078F1 File Offset: 0x00005AF1
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x000078F9 File Offset: 0x00005AF9
		internal bool ScrollNodeIntoViewInProgress { get; private set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00007902 File Offset: 0x00005B02
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0000790A File Offset: 0x00005B0A
		private protected global::Infragistics.IProvideScrollInfo ScrollInfo { protected get; private set; }

		// Token: 0x060001AA RID: 426 RVA: 0x00007913 File Offset: 0x00005B13
		public void ResetNodes()
		{
			this.ResetNodes(false);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000791C File Offset: 0x00005B1C
		public void ResetNodes(bool releaseAll)
		{
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode node in this.VisibleNodes)
			{
				this.ReleaseNode(node, true);
			}
			if (releaseAll)
			{
				foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in this.Tree.GlobalNodeLayouts)
				{
					global::Infragistics.RecyclingManager.Manager.ReleaseAll(this, nodeLayout.Key);
				}
				global::Infragistics.RecyclingManager.Manager.ReleaseAll(this);
				this._previousHeight = -1.0;
				this._previousWidth = -1.0;
			}
			this._overrideVerticalMax = -1.0;
			this._visibleNodes.Clear();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000079FC File Offset: 0x00005BFC
		public void ResetCachedScrollInfo(bool resetVisibleNodes)
		{
			if (!this.MeasureCalled)
			{
				this._overflowAdjustment = 0.0;
				this._overrideVerticalMax = -1.0;
				this._recalcHorizSBVis = true;
				if (resetVisibleNodes)
				{
					this._onNextMeasureReleaseVisibleNodes = true;
				}
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00007A38 File Offset: 0x00005C38
		protected internal virtual global::System.Windows.Size RenderNode(global::Infragistics.Controls.Menus.XamDataTreeNode node, double availableWidth)
		{
			if (node.Control == null)
			{
				global::Infragistics.RecyclingManager.Manager.AttachElement(node, this);
				node.Control.MeasureRaised = false;
				node.Control.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				if (!node.Control.MeasureRaised)
				{
					node.Control.Measure(new global::System.Windows.Size(1.0, 1.0));
					node.Control.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				}
			}
			else
			{
				node.ApplyStyle();
				node.Control.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
			}
			node.EnsureCurrentState();
			node.RaiseNodeRendered();
			this._maximumNodeWidth = global::System.Math.Max(this._maximumNodeWidth, node.Control.DesiredSize.Width + (double)node.Manager.Level * node.NodeLayout.IndentationResolved);
			return node.Control.DesiredSize;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007B5C File Offset: 0x00005D5C
		protected virtual void UpdateScrollInfo(int totalNodeCount, double finalWidth)
		{
			global::System.Windows.Controls.Primitives.ScrollBar verticalScrollBar = this.Tree.VerticalScrollBar;
			if (verticalScrollBar != null)
			{
				double value = verticalScrollBar.Value;
				verticalScrollBar.Maximum = this._overrideVerticalMax;
				if (verticalScrollBar.Value != value && value < verticalScrollBar.Maximum && !this._ensuerVertSBValueUpdated)
				{
					verticalScrollBar.Value = value;
				}
				this._ensuerVertSBValueUpdated = false;
				if (this._resetVertSBViewportSize)
				{
					verticalScrollBar.ViewportSize = (double)this._visibleNodes.Count;
					this._resetVertSBViewportSize = false;
				}
				double num = (double)(this._visibleNodes.Count - 1);
				if (num < 0.0)
				{
					num = 0.0;
				}
				verticalScrollBar.LargeChange = num;
				verticalScrollBar.SmallChange = verticalScrollBar.ViewportSize / 10.0;
				global::System.Windows.Visibility visibility = verticalScrollBar.Visibility;
				verticalScrollBar.Visibility = ((this._overrideVerticalMax <= 0.0 || totalNodeCount == 0) ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
				if (verticalScrollBar.Visibility != visibility && verticalScrollBar.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					verticalScrollBar.Value = 0.0;
				}
			}
			global::System.Windows.Controls.Primitives.ScrollBar horizontalScrollBar = this.Tree.HorizontalScrollBar;
			if (horizontalScrollBar != null)
			{
				if (double.IsPositiveInfinity(this._previousWidth))
				{
					horizontalScrollBar.Visibility = global::System.Windows.Visibility.Collapsed;
					return;
				}
				if (this._maximumNodeWidth > finalWidth)
				{
					horizontalScrollBar.Visibility = global::System.Windows.Visibility.Visible;
					horizontalScrollBar.LargeChange = horizontalScrollBar.ViewportSize;
					horizontalScrollBar.SmallChange = horizontalScrollBar.ViewportSize / 10.0;
					horizontalScrollBar.ViewportSize = finalWidth;
					double num2 = this._maximumNodeWidth - finalWidth;
					if (double.IsInfinity(num2) || double.IsNaN(num2) || num2 < 0.0)
					{
						num2 = 0.0;
					}
					horizontalScrollBar.Maximum = num2;
					this._recalcHorizSBVis = false;
					if (!horizontalScrollBar.IsEnabled)
					{
						horizontalScrollBar.IsEnabled = true;
						return;
					}
				}
				else
				{
					if (this._recalcHorizSBVis)
					{
						horizontalScrollBar.Visibility = global::System.Windows.Visibility.Collapsed;
						horizontalScrollBar.Value = 0.0;
						return;
					}
					if (horizontalScrollBar.IsEnabled)
					{
						horizontalScrollBar.Value = 0.0;
						horizontalScrollBar.Maximum = 0.0;
						horizontalScrollBar.IsEnabled = false;
					}
				}
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00007D74 File Offset: 0x00005F74
		protected static bool ArrangeNode(global::Infragistics.Controls.Menus.XamDataTreeNode node, double left, double top, double width, double height)
		{
			node.Control.ArrangeRaised = false;
			node.Control.Arrange(new global::System.Windows.Rect(left, top, width, height));
			return node.Control.ArrangeRaised;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007DA4 File Offset: 0x00005FA4
		internal void ReleaseNode(global::Infragistics.Controls.Menus.XamDataTreeNode node, bool removeManager = false)
		{
			if (node.Manager != null && node.NodeLayout != null && !node.NodeLayout.Tree.IsLoaded && removeManager)
			{
				node.Manager.UnhookDataManager(false, true);
			}
			if (!global::Infragistics.RecyclingManager.Manager.ReleaseElement(node, this))
			{
				this._nonReleasedNodes.Add(node);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007E00 File Offset: 0x00006000
		private void ThrowoutUnusedNodes(global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> previousVisibleNodes)
		{
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in previousVisibleNodes)
			{
				if (!this._visibleNodes.Contains(xamDataTreeNode) && xamDataTreeNode.Control != null)
				{
					this.ReleaseNode(xamDataTreeNode, true);
				}
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007E68 File Offset: 0x00006068
		private global::System.Windows.Size ResolveBaseSize(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			if (result.Height == 0.0 && !double.IsInfinity(availableSize.Height) && !double.IsNaN(availableSize.Height))
			{
				result.Height = availableSize.Height;
			}
			if (result.Width == 0.0 && !double.IsInfinity(availableSize.Width) && !double.IsNaN(availableSize.Width))
			{
				result.Width = availableSize.Width;
			}
			return result;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00007EF8 File Offset: 0x000060F8
		internal void ScrollNodeIntoView(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (this._measureCalled)
			{
				return;
			}
			if (node.Manager != null && node.Manager.ParentNode != null)
			{
				for (global::Infragistics.Controls.Menus.XamDataTreeNode parentNode = node.Manager.ParentNode; parentNode != null; parentNode = parentNode.Manager.ParentNode)
				{
					if (!parentNode.IsExpanded)
					{
						parentNode.IsExpanded = true;
					}
				}
			}
			int num = this.Tree.InternalNodes.IndexOf(node);
			if (node.Control != null)
			{
				global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this);
				global::System.Windows.Rect layoutSlot2 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(node.Control);
				global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(node.Control.NodeLineControl);
				global::System.Windows.Rect layoutSlot3 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(node.Control.ContentPresenter);
				if (layoutSlot2.Bottom > layoutSlot.Height || (layoutSlot2.X == this._hiddenRect.X && layoutSlot2.Y == this._hiddenRect.Y))
				{
					this._reverseNodeStartIndex = num;
					this._reverseMeasure = true;
				}
				else if (layoutSlot2.Height <= 0.0 || layoutSlot2.Top < 0.0)
				{
					this.ScrollInfo.VerticalScrollBar.Value = (double)num;
				}
				if (layoutSlot3.X + layoutSlot2.X < 0.0)
				{
					this.ScrollInfo.HorizontalScrollBar.Value = layoutSlot3.Left;
				}
			}
			else if (this.VisibleNodes.Count > 0)
			{
				int num2 = this.Tree.InternalNodes.IndexOf(this.VisibleNodes[this.VisibleNodes.Count - 1]);
				if (num > num2)
				{
					this._reverseNodeStartIndex = num;
					this._reverseMeasure = true;
				}
				else
				{
					if ((double)num > this.ScrollInfo.VerticalScrollBar.Maximum)
					{
						this.ScrollInfo.VerticalScrollBar.Maximum = (double)num;
					}
					this.ScrollInfo.VerticalScrollBar.Value = (double)num;
				}
			}
			this._scrollIntoViewNode = node;
			this.ScrollNodeIntoViewInProgress = true;
			base.InvalidateMeasure();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000080F4 File Offset: 0x000062F4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (double.IsInfinity(availableSize.Height) && !double.IsInfinity(this._previousHeight) && this._previousHeight >= 0.0)
			{
				global::System.Windows.Size result = new global::System.Windows.Size(base.DesiredSize.Width, this._previousHeight);
				this._previousHeight = availableSize.Height;
				this._recalcHorizSBVis = true;
				this._resetVertSBViewportSize = true;
				return result;
			}
			if (this._measureCalled && this._previousWidth == availableSize.Width && this._previousHeight == availableSize.Height)
			{
				return base.DesiredSize;
			}
			this._measureCalled = true;
			global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode>();
			if (this._previousHeight != availableSize.Height)
			{
				this._resetVertSBViewportSize = true;
				this._overrideVerticalMax = -1.0;
			}
			if (this._onNextMeasureReleaseVisibleNodes)
			{
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNode node in this.VisibleNodes)
				{
					this.ReleaseNode(node, !this.Tree.InternalNodes.Contains(node));
				}
				this.VisibleNodes.Clear();
				this._onNextMeasureReleaseVisibleNodes = false;
			}
			if (this.VisibleNodes.Count == 0)
			{
				this._recalcHorizSBVis = true;
				this._resetVertSBViewportSize = true;
			}
			this._previousHeight = availableSize.Height;
			this._previousWidth = availableSize.Width;
			this._invalidateNodeHeight = (double)((this._invalidateNodeHeight == 10000.0) ? 10001 : 10000);
			double num = 0.0;
			double height = availableSize.Height;
			double num2 = 0.0;
			global::System.Windows.Controls.Primitives.ScrollBar verticalScrollBar = this.Tree.VerticalScrollBar;
			double num3 = (verticalScrollBar != null) ? verticalScrollBar.Value : 0.0;
			int count = this.Tree.InternalNodes.Count;
			this._maximumNodeWidth = 0.0;
			if (count == 0 || (double.IsInfinity(height) && !base.IsLoaded))
			{
				list.AddRange(this.VisibleNodes);
				this.VisibleNodes.Clear();
				this.ThrowoutUnusedNodes(list);
				return this.ResolveBaseSize(availableSize);
			}
			int num4 = 0;
			double num5 = 0.0;
			double num6 = 0.0;
			if (!this._reverseMeasure)
			{
				num4 = (int)num3;
				if (num4 >= count)
				{
					num4 = count - 1;
				}
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = this.Tree.InternalNodes[num4];
				if (this.VisibleNodes.Count > 0)
				{
					int num7 = this.VisibleNodes.IndexOf(xamDataTreeNode);
					if (num7 != 0)
					{
						if (num7 != -1)
						{
							for (int i = num7; i > 0; i--)
							{
								global::Infragistics.Controls.Menus.XamDataTreeNode node2 = this.VisibleNodes[0];
								this.ReleaseNode(node2, !this.Tree.InternalNodes.Contains(node2));
								this.VisibleNodes.RemoveAt(0);
							}
							list.AddRange(this.VisibleNodes);
						}
						else
						{
							int num8 = this.VisibleNodes.Count;
							int num9 = this.Tree.InternalNodes.IndexOf(this.VisibleNodes[0]);
							int num10 = num9 + num8 - 1;
							if (num10 < num4)
							{
								foreach (global::Infragistics.Controls.Menus.XamDataTreeNode node3 in this.VisibleNodes)
								{
									this.ReleaseNode(node3, !this.Tree.InternalNodes.Contains(node3));
								}
								this.VisibleNodes.Clear();
							}
							else
							{
								num8--;
								int num11 = num9 - num4;
								int num12 = 0;
								while (num12 < num11 && num12 < num8)
								{
									int index = num8 - num12;
									global::Infragistics.Controls.Menus.XamDataTreeNode node4 = this.VisibleNodes[index];
									this.ReleaseNode(node4, !this.Tree.InternalNodes.Contains(node4));
									this.VisibleNodes.RemoveAt(index);
									num12++;
								}
							}
							list.AddRange(this.VisibleNodes);
						}
					}
					else
					{
						list.AddRange(this.VisibleNodes);
					}
					this.VisibleNodes.Clear();
				}
				if (num4 > 0)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2 = this.Tree.InternalNodes[num4 - 1];
				}
				global::System.Windows.Size size = this.RenderNode(xamDataTreeNode, availableSize.Width);
				num6 = size.Height;
				num2 = global::System.Math.Max(num2, size.Width);
				num += num6;
				this._visibleNodes.Add(xamDataTreeNode);
				if (verticalScrollBar != null)
				{
					double num13 = verticalScrollBar.Value - (double)((int)verticalScrollBar.Value);
					num5 = num6 * num13;
					num -= num5;
					this._measureScrollBarValue = verticalScrollBar.Value;
				}
				int j = num4 + 1;
				while (j < count && num < height)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode3 = this.Tree.InternalNodes[j];
					global::System.Windows.Size size2 = this.RenderNode(xamDataTreeNode3, availableSize.Width);
					num6 = global::System.Math.Max(num6, size2.Height);
					num += size2.Height;
					num2 = global::System.Math.Max(num2, size2.Width);
					this._visibleNodes.Add(xamDataTreeNode3);
					j++;
				}
				num += num5;
				num4--;
			}
			else
			{
				list.AddRange(this.VisibleNodes);
				this.VisibleNodes.Clear();
				num4 = this._reverseNodeStartIndex;
			}
			if (num < height && this._visibleNodes.Count < count)
			{
				int j;
				for (j = num4; j >= 0; j--)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode4 = this.Tree.InternalNodes[j];
					if (xamDataTreeNode4 != null)
					{
						global::System.Windows.Size size3 = this.RenderNode(xamDataTreeNode4, availableSize.Width);
						num6 = global::System.Math.Max(num6, size3.Height);
						num2 = global::System.Math.Max(num2, size3.Width);
						num += num6;
						this._visibleNodes.Insert(0, xamDataTreeNode4);
						if (num >= height)
						{
							break;
						}
					}
				}
				if (!double.IsInfinity(height))
				{
					num5 = (num - height) / num6;
					double num14 = (double)j + num5;
					this.Tree.VerticalScrollBar.Value = num14;
					this._measureScrollBarValue = verticalScrollBar.Value;
					if (this.Tree.VerticalScrollBar.Value != num14)
					{
						this._ensuerVertSBValueUpdated = true;
					}
				}
			}
			if (!double.IsPositiveInfinity(height))
			{
				int num15 = count - this.VisibleNodes.Count;
				double num16 = (num - height) / num6;
				if (num6 == 0.0 || double.IsNaN(num16) || double.IsInfinity(num16))
				{
					num16 = 0.0;
				}
				this._overrideVerticalMax = (double)num15 + num16;
				if (this._overrideVerticalMax < 0.0)
				{
					this._overrideVerticalMax = -1.0;
				}
			}
			bool flag = false;
			if (this.Tree.InternalNodes.Count != count)
			{
				if (this.ScrollNodeIntoViewInProgress)
				{
					this._redoScrollProgress = true;
				}
				this._overrideVerticalMax = -1.0;
				this._measureCalled = false;
				base.Measure(availableSize);
				flag = true;
			}
			this.ThrowoutUnusedNodes(list);
			if (flag)
			{
				return base.DesiredSize;
			}
			this._overflowAdjustment = num - height;
			double num17 = availableSize.Width;
			if (double.IsPositiveInfinity(num17))
			{
				num17 = num2;
				if (!this._measureCalledInfinite)
				{
					this._measureCalled = false;
					this._measureCalledInfinite = true;
					base.Measure(availableSize);
				}
			}
			if (!double.IsPositiveInfinity(availableSize.Height) && num > availableSize.Height)
			{
				num = availableSize.Height;
			}
			if (num < 0.0)
			{
				num = 0.0;
			}
			return new global::System.Windows.Size(num17, num);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000887C File Offset: 0x00006A7C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			this._measureCalled = false;
			this._measureCalledInfinite = false;
			double num = 0.0;
			if (this.ScrollInfo.HorizontalScrollBar != null)
			{
				num = -this.ScrollInfo.HorizontalScrollBar.Value;
			}
			this._clipRG.Rect = new global::System.Windows.Rect(0.0, 0.0, finalSize.Width, finalSize.Height);
			if (this._notVisibleAndNotArrangedNodes.Count > 0)
			{
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
				foreach (global::System.Windows.FrameworkElement frameworkElement in this._notVisibleAndNotArrangedNodes)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = (global::Infragistics.Controls.Menus.XamDataTreeNodeControl)frameworkElement;
					if (global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(xamDataTreeNodeControl) != this._hiddenRect)
					{
						xamDataTreeNodeControl.ArrangeRaised = false;
						xamDataTreeNodeControl.Arrange(this._hiddenRect);
						if (!xamDataTreeNodeControl.ArrangeRaised)
						{
							list.Add(xamDataTreeNodeControl);
						}
					}
				}
				this._notVisibleAndNotArrangedNodes.Clear();
				this._notVisibleAndNotArrangedNodes.AddRange(list);
			}
			global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> recentlyAvailableElements = global::Infragistics.RecyclingManager.Manager.GetRecentlyAvailableElements(this, true);
			foreach (global::System.Windows.FrameworkElement frameworkElement2 in recentlyAvailableElements)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl2 = (global::Infragistics.Controls.Menus.XamDataTreeNodeControl)frameworkElement2;
				xamDataTreeNodeControl2.ArrangeRaised = false;
				xamDataTreeNodeControl2.Arrange(this._hiddenRect);
				if (!xamDataTreeNodeControl2.ArrangeRaised)
				{
					this._notVisibleAndNotArrangedNodes.Add(xamDataTreeNodeControl2);
				}
			}
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in this._nonReleasedNodes)
			{
				if (xamDataTreeNode.Control != null)
				{
					xamDataTreeNode.Control.Arrange(this._hiddenRect);
				}
			}
			this._nonReleasedNodes.Clear();
			int count = this.Tree.InternalNodes.Count;
			this.UpdateScrollInfo(count, finalSize.Width);
			double num2 = 0.0;
			if (count != 0)
			{
				global::System.Windows.Controls.Primitives.ScrollBar verticalScrollBar = this.Tree.VerticalScrollBar;
				if (verticalScrollBar != null && verticalScrollBar.Visibility == global::System.Windows.Visibility.Visible && this.VisibleNodes.Count > 0)
				{
					if (this._measureScrollBarValue != verticalScrollBar.Maximum)
					{
						double num3 = this._measureScrollBarValue - (double)((int)this._measureScrollBarValue);
						double num4 = 0.0;
						int count2 = this._visibleNodes.Count;
						for (int i = 0; i < count2; i++)
						{
							double height = this._visibleNodes[i].Control.DesiredSize.Height;
							if (height > 0.0)
							{
								num4 = height;
								break;
							}
						}
						double num5 = num4 * num3;
						double measureScrollBarValue = this._measureScrollBarValue;
						double overrideVerticalMax = this._overrideVerticalMax;
						if (measureScrollBarValue >= overrideVerticalMax && overrideVerticalMax > 0.0)
						{
							num2 -= this._overflowAdjustment;
						}
						else
						{
							num2 += -num5;
						}
					}
					else
					{
						num2 -= this._overflowAdjustment;
					}
					verticalScrollBar.SmallChange = (double)this._visibleNodes.Count / 10.0;
				}
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2 in this._visibleNodes)
				{
					if (xamDataTreeNode2.Control == null)
					{
						this.RenderNode(xamDataTreeNode2, double.PositiveInfinity);
					}
					double height2 = xamDataTreeNode2.Control.DesiredSize.Height;
					double num6 = 0.0;
					global::Infragistics.Controls.Menus.Primitives.NodesPanel.ArrangeNode(xamDataTreeNode2, num6 + num, num2, xamDataTreeNode2.Control.DesiredSize.Width, height2);
					global::System.Windows.Controls.Panel.SetZIndex(xamDataTreeNode2.Control, 0);
					num2 += height2;
				}
			}
			this._reverseMeasure = false;
			if (this.ScrollNodeIntoViewInProgress)
			{
				if (this._scrollIntoViewNode.Control == null || this._redoScrollProgress)
				{
					this.ScrollNodeIntoView(this._scrollIntoViewNode);
				}
				this.ScrollNodeIntoViewInProgress = false;
				this._redoScrollProgress = false;
				this._scrollIntoViewNode = null;
				base.InvalidateMeasure();
			}
			return finalSize;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00008CBC File Offset: 0x00006EBC
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			base.OnChildDesiredSizeChanged(child);
			if (this._maximumNodeWidth < child.DesiredSize.Width)
			{
				this._maximumNodeWidth = child.DesiredSize.Width;
			}
		}

		// Token: 0x04000077 RID: 119
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Menus.XamDataTreeNode> _visibleNodes;

		// Token: 0x04000078 RID: 120
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Menus.XamDataTreeNode> _nonReleasedNodes;

		// Token: 0x04000079 RID: 121
		private double _overrideVerticalMax;

		// Token: 0x0400007A RID: 122
		private double _overflowAdjustment;

		// Token: 0x0400007B RID: 123
		private double _invalidateNodeHeight;

		// Token: 0x0400007C RID: 124
		private double _measureScrollBarValue;

		// Token: 0x0400007D RID: 125
		private double _previousHeight = -1.0;

		// Token: 0x0400007E RID: 126
		private double _previousWidth = -1.0;

		// Token: 0x0400007F RID: 127
		private double _maximumNodeWidth;

		// Token: 0x04000080 RID: 128
		private bool _measureCalled;

		// Token: 0x04000081 RID: 129
		private bool _reverseMeasure;

		// Token: 0x04000082 RID: 130
		private bool _onNextMeasureReleaseVisibleNodes;

		// Token: 0x04000083 RID: 131
		private bool _ensuerVertSBValueUpdated;

		// Token: 0x04000084 RID: 132
		private bool _measureCalledInfinite;

		// Token: 0x04000085 RID: 133
		private bool _recalcHorizSBVis;

		// Token: 0x04000086 RID: 134
		private bool _redoScrollProgress;

		// Token: 0x04000087 RID: 135
		private int _reverseNodeStartIndex;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Media.RectangleGeometry _clipRG;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Rect _hiddenRect = new global::System.Windows.Rect(-1000.0, -1000.0, 0.0, 0.0);

		// Token: 0x0400008A RID: 138
		private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> _notVisibleAndNotArrangedNodes;

		// Token: 0x0400008B RID: 139
		private global::Infragistics.Controls.Menus.XamDataTree _tree;

		// Token: 0x0400008C RID: 140
		private global::Infragistics.Controls.Menus.XamDataTreeNode _scrollIntoViewNode;

		// Token: 0x0400008D RID: 141
		private bool _resetVertSBViewportSize;
	}
}
