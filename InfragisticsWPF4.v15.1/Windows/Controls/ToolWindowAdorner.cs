using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000239 RID: 569
	internal class ToolWindowAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06001647 RID: 5703 RVA: 0x000513BD File Offset: 0x0004F5BD
		internal ToolWindowAdorner(global::System.Windows.UIElement adornedElement) : base(adornedElement)
		{
			this._panel = new global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel();
			base.AddVisualChild(this._panel);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x000513E0 File Offset: 0x0004F5E0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(finalSize);
			this._panel.Arrange(finalRect);
			if (this._topMostPanel != null)
			{
				this._topMostPanel.Arrange(finalRect);
			}
			return finalSize;
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00051416 File Offset: 0x0004F616
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index == 0)
			{
				return this._panel;
			}
			if (index == 1 && this._topMostPanel != null)
			{
				return this._topMostPanel;
			}
			throw new global::System.ArgumentOutOfRangeException();
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x0005143C File Offset: 0x0004F63C
		protected override int VisualChildrenCount
		{
			get
			{
				int num = 1;
				if (this._topMostPanel != null)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x00051458 File Offset: 0x0004F658
		private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel TopMostPanel
		{
			get
			{
				if (this._topMostPanel == null)
				{
					this._topMostPanel = new global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel();
					base.AddVisualChild(this._topMostPanel);
					base.InvalidateMeasure();
				}
				return this._topMostPanel;
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00051488 File Offset: 0x0004F688
		internal global::Infragistics.Windows.Controls.ToolWindow.IDeferShow AddWindow(global::Infragistics.Windows.Controls.ToolWindow window, global::System.Windows.FrameworkElement owner)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = new global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem();
			toolWindowAdornerItem.Child = window;
			if (!toolWindowAdornerItem.Topmost)
			{
				this._panel.Children.Add(toolWindowAdornerItem);
			}
			else
			{
				this.TopMostPanel.Children.Add(toolWindowAdornerItem);
			}
			window.Activated += this.OnToolWindowActivated;
			return new global::Infragistics.Windows.Controls.ToolWindowAdorner.DeferShowHelper(toolWindowAdornerItem);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x000514E8 File Offset: 0x0004F6E8
		internal void BringToFront(global::Infragistics.Windows.Controls.ToolWindow toolWindow)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = global::System.Windows.Media.VisualTreeHelper.GetParent(toolWindow) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = (toolWindowAdornerItem != null) ? this.GetPanel(toolWindowAdornerItem) : null;
			if (toolWindowAdornerPanel != null)
			{
				toolWindowAdornerPanel.BringToFront(toolWindowAdornerItem);
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00051519 File Offset: 0x0004F719
		internal void GetToolWindows(global::System.Windows.FrameworkElement owner, global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow> windows, ref int insertAtIndex)
		{
			if (this._topMostPanel != null)
			{
				this._topMostPanel.GetToolWindows(owner, windows, ref insertAtIndex);
			}
			this._panel.GetToolWindows(owner, windows, ref insertAtIndex);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00051540 File Offset: 0x0004F740
		internal void RemoveWindow(global::Infragistics.Windows.Controls.ToolWindow window)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel panel = this.GetPanel(window);
			if (panel != null)
			{
				this.RemoveWindow(window, panel);
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00051564 File Offset: 0x0004F764
		private bool RemoveWindow(global::Infragistics.Windows.Controls.ToolWindow window, global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel panel)
		{
			int i = 0;
			int num = panel.Children.Count - 1;
			while (i < num)
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = panel.Children[i] as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
				if (toolWindowAdornerItem != null && toolWindowAdornerItem.Child == window)
				{
					window.Activated -= this.OnToolWindowActivated;
					toolWindowAdornerItem.Child = null;
					panel.Children.RemoveAt(i);
					return true;
				}
				i++;
			}
			return false;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x000515D4 File Offset: 0x0004F7D4
		private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel GetPanel(global::Infragistics.Windows.Controls.ToolWindow window)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = global::System.Windows.Media.VisualTreeHelper.GetParent(window) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
			if (toolWindowAdornerItem != null)
			{
				return this.GetPanel(toolWindowAdornerItem);
			}
			return null;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000515FC File Offset: 0x0004F7FC
		private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel GetPanel(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem item)
		{
			return global::System.Windows.Media.VisualTreeHelper.GetParent(item) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00051618 File Offset: 0x0004F818
		private void OnToolWindowActivated(object sender, global::System.EventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = global::System.Windows.Media.VisualTreeHelper.GetParent((global::System.Windows.DependencyObject)sender) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
			if (toolWindowAdornerItem != null)
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel panel = this.GetPanel(toolWindowAdornerItem);
				if (panel != null)
				{
					panel.BringToFront(toolWindowAdornerItem);
				}
			}
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0005164C File Offset: 0x0004F84C
		private void TransferToOtherPanel(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem child, global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel currentPanel)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = (currentPanel == this._panel) ? this.TopMostPanel : this._panel;
			currentPanel.Children.Remove(child);
			toolWindowAdornerPanel.Children.Add(child);
		}

		// Token: 0x04000B9F RID: 2975
		private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel _panel;

		// Token: 0x04000BA0 RID: 2976
		private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel _topMostPanel;

		// Token: 0x0200023A RID: 570
		private class ToolWindowAdornerPanel : global::System.Windows.Controls.Panel
		{
			// Token: 0x06001655 RID: 5717 RVA: 0x0005168A File Offset: 0x0004F88A
			internal ToolWindowAdornerPanel()
			{
				this._owners = new global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowOwnerInfo>();
			}

			// Token: 0x06001656 RID: 5718 RVA: 0x000516A0 File Offset: 0x0004F8A0
			protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
			{
				global::System.Windows.Rect rect = new global::System.Windows.Rect(finalSize);
				rect.Inflate(-10.0, -10.0);
				foreach (object obj in base.Children)
				{
					global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = (global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem)obj;
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = toolWindowAdornerItem.Child as global::Infragistics.Windows.Controls.ToolWindow;
					double num = toolWindowAdornerItem.Left;
					double num2 = toolWindowAdornerItem.Top;
					double width = toolWindowAdornerItem.Width;
					double height = toolWindowAdornerItem.Height;
					if (double.IsNaN(num))
					{
						num = 0.0;
					}
					if (double.IsNaN(num2))
					{
						num2 = 0.0;
					}
					if (double.IsNaN(width))
					{
						width = toolWindowAdornerItem.DesiredSize.Width;
					}
					if (double.IsNaN(height))
					{
						height = toolWindowAdornerItem.DesiredSize.Height;
					}
					global::System.Windows.Rect rect2 = new global::System.Windows.Rect(num, num2, width, height);
					if (toolWindow != null && toolWindow.Owner != null)
					{
						global::System.Windows.FrameworkElement owner = toolWindow.Owner;
						if (owner.FindCommonVisualAncestor(this) != null)
						{
							global::System.Windows.Rect ownerRect = owner.TransformToVisual(this).TransformBounds(new global::System.Windows.Rect(0.0, 0.0, owner.ActualWidth, owner.ActualHeight));
							toolWindowAdornerItem.PerformInitialPositioning(ref rect2);
							toolWindow.AdjustRelativeRect(ownerRect, ref rect2);
						}
					}
					if (!rect2.IntersectsWith(rect) && (toolWindow == null || toolWindow.KeepOnScreen))
					{
						rect2.Offset(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel.CalculateAdjustment(rect, rect2));
					}
					toolWindowAdornerItem.Arrange(rect2);
					if (toolWindow != null && toolWindow.KeepOnScreen)
					{
						global::System.Windows.FrameworkElement captionElement = toolWindow.CaptionElement;
						if (captionElement != null && captionElement.IsVisible)
						{
							global::System.Windows.Media.GeneralTransform generalTransform = captionElement.TransformToAncestor(toolWindowAdornerItem);
							if (generalTransform != null)
							{
								global::System.Windows.Rect rect3 = generalTransform.TransformBounds(new global::System.Windows.Rect(captionElement.RenderSize));
								rect3.Offset(rect2.X, rect2.Y);
								if (!rect3.IntersectsWith(rect))
								{
									rect2.Offset(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel.CalculateAdjustment(rect, rect3));
									toolWindowAdornerItem.Arrange(rect2);
								}
							}
						}
					}
				}
				return finalSize;
			}

			// Token: 0x06001657 RID: 5719 RVA: 0x000518D0 File Offset: 0x0004FAD0
			protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
			{
				foreach (object obj in base.Children)
				{
					global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = (global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem)obj;
					global::System.Windows.Size availableSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
					toolWindowAdornerItem.Measure(availableSize);
				}
				return constraint;
			}

			// Token: 0x06001658 RID: 5720 RVA: 0x00051944 File Offset: 0x0004FB44
			protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = visualRemoved as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem2 = visualAdded as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
				if (toolWindowAdornerItem != null)
				{
					this.OnItemRemoved(toolWindowAdornerItem);
				}
				if (toolWindowAdornerItem2 != null)
				{
					this.OnItemAdded(toolWindowAdornerItem2);
				}
				base.OnVisualChildrenChanged(visualAdded, visualRemoved);
			}

			// Token: 0x06001659 RID: 5721 RVA: 0x0005197C File Offset: 0x0004FB7C
			internal void BringToFront(global::System.Windows.UIElement child)
			{
				global::System.Windows.Media.Visual visualChild = this.GetVisualChild(this.VisualChildrenCount - 1);
				if (child != visualChild)
				{
					child.SetValue(global::System.Windows.Controls.Panel.ZIndexProperty, ++this._topZIndex);
				}
			}

			// Token: 0x0600165A RID: 5722 RVA: 0x000519C0 File Offset: 0x0004FBC0
			private static global::System.Windows.Vector CalculateAdjustment(global::System.Windows.Rect screenRect, global::System.Windows.Rect rect)
			{
				global::System.Windows.Vector result = default(global::System.Windows.Vector);
				if (rect.Left >= screenRect.Right)
				{
					result.X = screenRect.Right - 1.0 - rect.Left;
				}
				else if (rect.Right < screenRect.Left)
				{
					result.X = screenRect.Left + 1.0 - rect.Right;
				}
				if (rect.Top >= screenRect.Bottom)
				{
					result.Y = screenRect.Bottom - 1.0 - rect.Top;
				}
				else if (rect.Bottom < screenRect.Top)
				{
					result.Y = screenRect.Top + 1.0 - rect.Bottom;
				}
				return result;
			}

			// Token: 0x0600165B RID: 5723 RVA: 0x00051A9C File Offset: 0x0004FC9C
			internal void GetToolWindows(global::System.Windows.FrameworkElement owner, global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow> windows, ref int insertAtIndex)
			{
				int i = 0;
				int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this);
				while (i < childrenCount)
				{
					global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = global::System.Windows.Media.VisualTreeHelper.GetChild(this, i) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = (toolWindowAdornerItem != null) ? (toolWindowAdornerItem.Child as global::Infragistics.Windows.Controls.ToolWindow) : null;
					if (toolWindow != null && toolWindow.Owner == owner)
					{
						windows.Insert(insertAtIndex++, toolWindow);
					}
					i++;
				}
			}

			// Token: 0x0600165C RID: 5724 RVA: 0x00051AFC File Offset: 0x0004FCFC
			private void OnItemAdded(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem item)
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = item.Child as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindow != null)
				{
					global::System.Windows.FrameworkElement owner = toolWindow.Owner;
					global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowOwnerInfo toolWindowOwnerInfo;
					if (!this._owners.TryGetValue(owner, out toolWindowOwnerInfo))
					{
						toolWindowOwnerInfo = new global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowOwnerInfo(owner, this);
						this._owners.Add(owner, toolWindowOwnerInfo);
					}
					toolWindowOwnerInfo.AddWindow(item);
				}
			}

			// Token: 0x0600165D RID: 5725 RVA: 0x00051B4C File Offset: 0x0004FD4C
			private void OnItemRemoved(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem item)
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = item.Child as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindow != null)
				{
					global::System.Windows.FrameworkElement owner = toolWindow.Owner;
					if (owner != null)
					{
						global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowOwnerInfo toolWindowOwnerInfo = this._owners[owner];
						toolWindowOwnerInfo.RemoveWindow(item);
					}
				}
			}

			// Token: 0x0600165E RID: 5726 RVA: 0x00051B88 File Offset: 0x0004FD88
			internal void OnRelativeStateChanged(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem item)
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = item.Child as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindow != null)
				{
					global::System.Windows.FrameworkElement owner = toolWindow.Owner;
					global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowOwnerInfo toolWindowOwnerInfo = this._owners[owner];
					toolWindowOwnerInfo.VerifyRelationPositionCount();
				}
			}

			// Token: 0x0600165F RID: 5727 RVA: 0x00051BC0 File Offset: 0x0004FDC0
			internal void OnTopmostStateChanged(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem child)
			{
				int num = base.Children.IndexOf(child);
				if (num >= 0)
				{
					global::Infragistics.Windows.Controls.ToolWindowAdorner toolWindowAdorner = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::Infragistics.Windows.Controls.ToolWindowAdorner;
					if (toolWindowAdorner != null)
					{
						toolWindowAdorner.TransferToOtherPanel(child, this);
					}
				}
			}

			// Token: 0x04000BA1 RID: 2977
			private int _topZIndex;

			// Token: 0x04000BA2 RID: 2978
			private global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowOwnerInfo> _owners;
		}

		// Token: 0x0200023B RID: 571
		private class ToolWindowOwnerInfo
		{
			// Token: 0x06001660 RID: 5728 RVA: 0x00051BF5 File Offset: 0x0004FDF5
			internal ToolWindowOwnerInfo(global::System.Windows.FrameworkElement owner, global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel panel)
			{
				this._owner = owner;
				this._panel = panel;
				this._windows = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem>();
			}

			// Token: 0x06001661 RID: 5729 RVA: 0x00051C24 File Offset: 0x0004FE24
			internal void AddWindow(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem item)
			{
				this._windows.Add(item);
				if (item.UsesRelativePosition)
				{
					this._relativeItemCount++;
					if (this._relativeItemCount == 1)
					{
						this._panel.LayoutUpdated += this.OnPanelLayoutUpdated;
						this._lastRelativeBounds = this._owner.TransformToVisual(this._panel).TransformBounds(new global::System.Windows.Rect(0.0, 0.0, this._owner.ActualWidth, this._owner.ActualHeight));
					}
				}
			}

			// Token: 0x06001662 RID: 5730 RVA: 0x00051CBC File Offset: 0x0004FEBC
			private void OnPanelLayoutUpdated(object sender, global::System.EventArgs e)
			{
				if (this._owner.FindCommonVisualAncestor(this._panel) != null)
				{
					global::System.Windows.Rect rect = this._owner.TransformToVisual(this._panel).TransformBounds(new global::System.Windows.Rect(0.0, 0.0, this._owner.ActualWidth, this._owner.ActualHeight));
					if (rect != this._lastRelativeBounds)
					{
						this._lastRelativeBounds = rect;
						this._panel.InvalidateArrange();
					}
				}
			}

			// Token: 0x06001663 RID: 5731 RVA: 0x00051D40 File Offset: 0x0004FF40
			internal void RemoveWindow(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem item)
			{
				this._windows.Remove(item);
				if (item.UsesRelativePosition)
				{
					this._relativeItemCount--;
					if (this._relativeItemCount == 0)
					{
						this._panel.LayoutUpdated -= this.OnPanelLayoutUpdated;
						this._lastRelativeBounds = global::System.Windows.Rect.Empty;
					}
				}
			}

			// Token: 0x06001664 RID: 5732 RVA: 0x00051D9C File Offset: 0x0004FF9C
			internal void VerifyRelationPositionCount()
			{
				int num = 0;
				int i = 0;
				int count = this._windows.Count;
				while (i < count)
				{
					if (this._windows[i].UsesRelativePosition)
					{
						num++;
					}
					i++;
				}
				if (num != this._relativeItemCount)
				{
					if (this._relativeItemCount == 0)
					{
						this._panel.LayoutUpdated += this.OnPanelLayoutUpdated;
						this._panel.InvalidateArrange();
					}
					else if (num == 0)
					{
						this._panel.LayoutUpdated -= this.OnPanelLayoutUpdated;
						this._lastRelativeBounds = global::System.Windows.Rect.Empty;
						this._panel.InvalidateArrange();
					}
					this._relativeItemCount = num;
				}
			}

			// Token: 0x04000BA3 RID: 2979
			private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel _panel;

			// Token: 0x04000BA4 RID: 2980
			private global::System.Windows.FrameworkElement _owner;

			// Token: 0x04000BA5 RID: 2981
			private global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem> _windows;

			// Token: 0x04000BA6 RID: 2982
			private global::System.Windows.Rect _lastRelativeBounds = global::System.Windows.Rect.Empty;

			// Token: 0x04000BA7 RID: 2983
			private int _relativeItemCount;
		}

		// Token: 0x0200023F RID: 575
		private class ToolWindowAdornerItem : global::Infragistics.Windows.Controls.ToolWindowContainer, global::Infragistics.Windows.Controls.IToolWindowHost
		{
			// Token: 0x06001696 RID: 5782 RVA: 0x00052B09 File Offset: 0x00050D09
			static ToolWindowAdornerItem()
			{
				global::Infragistics.Windows.Controls.ToolWindowContainer.TopmostProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem.OnTopmostChanged)));
			}

			// Token: 0x06001697 RID: 5783 RVA: 0x00052B30 File Offset: 0x00050D30
			protected override global::System.Windows.Point GetRelativeScreenPoint(global::System.Windows.Input.MouseEventArgs e)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::System.Windows.Documents.AdornerLayer), true) as global::System.Windows.FrameworkElement;
				global::System.Windows.Point position = e.GetPosition(frameworkElement);
				if (position.X > frameworkElement.RenderSize.Width)
				{
					position.X = frameworkElement.RenderSize.Width;
				}
				else if (position.X < 0.0)
				{
					position.X = 0.0;
				}
				if (position.Y > frameworkElement.RenderSize.Height)
				{
					position.Y = frameworkElement.RenderSize.Height;
				}
				else if (position.Y < 0.0)
				{
					position.Y = 0.0;
				}
				global::System.Windows.Media.GeneralTransform generalTransform = frameworkElement.TransformToDescendant(this);
				if (generalTransform == null)
				{
					return position;
				}
				global::System.Windows.Point point = generalTransform.Transform(position);
				return global::Infragistics.Windows.Utilities.PointToScreenSafe(this, point);
			}

			// Token: 0x06001698 RID: 5784 RVA: 0x00052C20 File Offset: 0x00050E20
			public override void Close()
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel;
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Child as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindowAdornerPanel != null)
				{
					if (toolWindow != null && toolWindow.OnClosingInternal(new global::System.ComponentModel.CancelEventArgs()))
					{
						return;
					}
					toolWindowAdornerPanel.Children.Remove(this);
					base.Child = null;
					if (toolWindow != null)
					{
						toolWindow.OnClosedInternal(false);
					}
				}
			}

			// Token: 0x06001699 RID: 5785 RVA: 0x00052C78 File Offset: 0x00050E78
			public override void RelativePositionStateChanged()
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel;
				if (toolWindowAdornerPanel != null)
				{
					toolWindowAdornerPanel.OnRelativeStateChanged(this);
				}
			}

			// Token: 0x0600169A RID: 5786 RVA: 0x00052C9C File Offset: 0x00050E9C
			public override void BringToFront()
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel;
				if (toolWindowAdornerPanel != null)
				{
					toolWindowAdornerPanel.BringToFront(this);
				}
			}

			// Token: 0x1700052B RID: 1323
			// (get) Token: 0x0600169B RID: 5787 RVA: 0x00052CBF File Offset: 0x00050EBF
			public override bool AllowsTransparency
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600169C RID: 5788 RVA: 0x00052CC2 File Offset: 0x00050EC2
			public override bool SupportsAllowTransparency(bool allowsTransparency)
			{
				return allowsTransparency;
			}

			// Token: 0x1700052C RID: 1324
			// (get) Token: 0x0600169D RID: 5789 RVA: 0x00052CC5 File Offset: 0x00050EC5
			public override global::Infragistics.Windows.Controls.ToolWindowHostType HostType
			{
				get
				{
					return global::Infragistics.Windows.Controls.ToolWindowHostType.Adorner;
				}
			}

			// Token: 0x0600169E RID: 5790 RVA: 0x00052CC8 File Offset: 0x00050EC8
			private static void OnTopmostChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = d as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(toolWindowAdornerItem) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel;
				if (toolWindowAdornerPanel != null && toolWindowAdornerItem != null)
				{
					toolWindowAdornerPanel.OnTopmostStateChanged(toolWindowAdornerItem);
				}
			}
		}

		// Token: 0x02000240 RID: 576
		private class DeferShowHelper : global::Infragistics.Windows.Controls.ToolWindow.IDeferShow
		{
			// Token: 0x060016A0 RID: 5792 RVA: 0x00052CFD File Offset: 0x00050EFD
			internal DeferShowHelper(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem window)
			{
				this._window = window;
			}

			// Token: 0x060016A1 RID: 5793 RVA: 0x00052D0C File Offset: 0x00050F0C
			public void Show(bool activate)
			{
				if (activate)
				{
					this._window.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
				}
			}

			// Token: 0x060016A2 RID: 5794 RVA: 0x00052D23 File Offset: 0x00050F23
			public void Cancel()
			{
				this._window.Close();
			}

			// Token: 0x04000BBD RID: 3005
			private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem _window;
		}
	}
}
