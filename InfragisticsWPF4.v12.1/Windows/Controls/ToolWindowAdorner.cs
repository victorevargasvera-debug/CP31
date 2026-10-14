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
	// Token: 0x02000208 RID: 520
	internal class ToolWindowAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06001460 RID: 5216 RVA: 0x0004B3F1 File Offset: 0x000495F1
		internal ToolWindowAdorner(global::System.Windows.UIElement adornedElement) : base(adornedElement)
		{
			this._panel = new global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel();
			base.AddVisualChild(this._panel);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0004B414 File Offset: 0x00049614
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

		// Token: 0x06001462 RID: 5218 RVA: 0x0004B44A File Offset: 0x0004964A
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

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0004B470 File Offset: 0x00049670
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

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0004B48C File Offset: 0x0004968C
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

		// Token: 0x06001465 RID: 5221 RVA: 0x0004B4BC File Offset: 0x000496BC
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

		// Token: 0x06001466 RID: 5222 RVA: 0x0004B51C File Offset: 0x0004971C
		internal void BringToFront(global::Infragistics.Windows.Controls.ToolWindow toolWindow)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = global::System.Windows.Media.VisualTreeHelper.GetParent(toolWindow) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = (toolWindowAdornerItem != null) ? this.GetPanel(toolWindowAdornerItem) : null;
			if (toolWindowAdornerPanel != null)
			{
				toolWindowAdornerPanel.BringToFront(toolWindowAdornerItem);
			}
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0004B54D File Offset: 0x0004974D
		internal void GetToolWindows(global::System.Windows.FrameworkElement owner, global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow> windows, ref int insertAtIndex)
		{
			if (this._topMostPanel != null)
			{
				this._topMostPanel.GetToolWindows(owner, windows, ref insertAtIndex);
			}
			this._panel.GetToolWindows(owner, windows, ref insertAtIndex);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0004B574 File Offset: 0x00049774
		internal void RemoveWindow(global::Infragistics.Windows.Controls.ToolWindow window)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel panel = this.GetPanel(window);
			if (panel != null)
			{
				this.RemoveWindow(window, panel);
			}
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0004B598 File Offset: 0x00049798
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

		// Token: 0x0600146A RID: 5226 RVA: 0x0004B608 File Offset: 0x00049808
		private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel GetPanel(global::Infragistics.Windows.Controls.ToolWindow window)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem toolWindowAdornerItem = global::System.Windows.Media.VisualTreeHelper.GetParent(window) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem;
			if (toolWindowAdornerItem != null)
			{
				return this.GetPanel(toolWindowAdornerItem);
			}
			return null;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0004B630 File Offset: 0x00049830
		private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel GetPanel(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem item)
		{
			return global::System.Windows.Media.VisualTreeHelper.GetParent(item) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0004B64C File Offset: 0x0004984C
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

		// Token: 0x0600146D RID: 5229 RVA: 0x0004B680 File Offset: 0x00049880
		private void TransferToOtherPanel(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem child, global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel currentPanel)
		{
			global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = (currentPanel == this._panel) ? this.TopMostPanel : this._panel;
			currentPanel.Children.Remove(child);
			toolWindowAdornerPanel.Children.Add(child);
		}

		// Token: 0x04000A4D RID: 2637
		private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel _panel;

		// Token: 0x04000A4E RID: 2638
		private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel _topMostPanel;

		// Token: 0x02000209 RID: 521
		private class ToolWindowAdornerPanel : global::System.Windows.Controls.Panel
		{
			// Token: 0x0600146E RID: 5230 RVA: 0x0004B6BE File Offset: 0x000498BE
			internal ToolWindowAdornerPanel()
			{
				this._owners = new global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowOwnerInfo>();
			}

			// Token: 0x0600146F RID: 5231 RVA: 0x0004B6D4 File Offset: 0x000498D4
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

			// Token: 0x06001470 RID: 5232 RVA: 0x0004B904 File Offset: 0x00049B04
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

			// Token: 0x06001471 RID: 5233 RVA: 0x0004B978 File Offset: 0x00049B78
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

			// Token: 0x06001472 RID: 5234 RVA: 0x0004B9B0 File Offset: 0x00049BB0
			internal void BringToFront(global::System.Windows.UIElement child)
			{
				global::System.Windows.Media.Visual visualChild = this.GetVisualChild(this.VisualChildrenCount - 1);
				if (child != visualChild)
				{
					child.SetValue(global::System.Windows.Controls.Panel.ZIndexProperty, ++this._topZIndex);
				}
			}

			// Token: 0x06001473 RID: 5235 RVA: 0x0004B9F4 File Offset: 0x00049BF4
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

			// Token: 0x06001474 RID: 5236 RVA: 0x0004BAD0 File Offset: 0x00049CD0
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

			// Token: 0x06001475 RID: 5237 RVA: 0x0004BB30 File Offset: 0x00049D30
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

			// Token: 0x06001476 RID: 5238 RVA: 0x0004BB80 File Offset: 0x00049D80
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

			// Token: 0x06001477 RID: 5239 RVA: 0x0004BBBC File Offset: 0x00049DBC
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

			// Token: 0x06001478 RID: 5240 RVA: 0x0004BBF4 File Offset: 0x00049DF4
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

			// Token: 0x04000A4F RID: 2639
			private int _topZIndex;

			// Token: 0x04000A50 RID: 2640
			private global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowOwnerInfo> _owners;
		}

		// Token: 0x0200020A RID: 522
		private class ToolWindowOwnerInfo
		{
			// Token: 0x06001479 RID: 5241 RVA: 0x0004BC29 File Offset: 0x00049E29
			internal ToolWindowOwnerInfo(global::System.Windows.FrameworkElement owner, global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel panel)
			{
				this._owner = owner;
				this._panel = panel;
				this._windows = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem>();
			}

			// Token: 0x0600147A RID: 5242 RVA: 0x0004BC58 File Offset: 0x00049E58
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

			// Token: 0x0600147B RID: 5243 RVA: 0x0004BCF0 File Offset: 0x00049EF0
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

			// Token: 0x0600147C RID: 5244 RVA: 0x0004BD74 File Offset: 0x00049F74
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

			// Token: 0x0600147D RID: 5245 RVA: 0x0004BDD0 File Offset: 0x00049FD0
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

			// Token: 0x04000A51 RID: 2641
			private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel _panel;

			// Token: 0x04000A52 RID: 2642
			private global::System.Windows.FrameworkElement _owner;

			// Token: 0x04000A53 RID: 2643
			private global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem> _windows;

			// Token: 0x04000A54 RID: 2644
			private global::System.Windows.Rect _lastRelativeBounds = global::System.Windows.Rect.Empty;

			// Token: 0x04000A55 RID: 2645
			private int _relativeItemCount;
		}

		// Token: 0x0200020E RID: 526
		private class ToolWindowAdornerItem : global::Infragistics.Windows.Controls.ToolWindowContainer, global::Infragistics.Windows.Controls.IToolWindowHost
		{
			// Token: 0x060014AE RID: 5294 RVA: 0x0004CB2D File Offset: 0x0004AD2D
			static ToolWindowAdornerItem()
			{
				global::Infragistics.Windows.Controls.ToolWindowContainer.TopmostProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem.OnTopmostChanged)));
			}

			// Token: 0x060014AF RID: 5295 RVA: 0x0004CB54 File Offset: 0x0004AD54
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

			// Token: 0x060014B0 RID: 5296 RVA: 0x0004CC44 File Offset: 0x0004AE44
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
						toolWindow.OnClosedInternal();
					}
				}
			}

			// Token: 0x060014B1 RID: 5297 RVA: 0x0004CC9C File Offset: 0x0004AE9C
			public override void RelativePositionStateChanged()
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel;
				if (toolWindowAdornerPanel != null)
				{
					toolWindowAdornerPanel.OnRelativeStateChanged(this);
				}
			}

			// Token: 0x060014B2 RID: 5298 RVA: 0x0004CCC0 File Offset: 0x0004AEC0
			public override void BringToFront()
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel toolWindowAdornerPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerPanel;
				if (toolWindowAdornerPanel != null)
				{
					toolWindowAdornerPanel.BringToFront(this);
				}
			}

			// Token: 0x170004B3 RID: 1203
			// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0004CCE3 File Offset: 0x0004AEE3
			public override bool AllowsTransparency
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060014B4 RID: 5300 RVA: 0x0004CCE6 File Offset: 0x0004AEE6
			public override bool SupportsAllowTransparency(bool allowsTransparency)
			{
				return allowsTransparency;
			}

			// Token: 0x060014B5 RID: 5301 RVA: 0x0004CCEC File Offset: 0x0004AEEC
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

		// Token: 0x0200020F RID: 527
		private class DeferShowHelper : global::Infragistics.Windows.Controls.ToolWindow.IDeferShow
		{
			// Token: 0x060014B7 RID: 5303 RVA: 0x0004CD21 File Offset: 0x0004AF21
			internal DeferShowHelper(global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem window)
			{
				this._window = window;
			}

			// Token: 0x060014B8 RID: 5304 RVA: 0x0004CD30 File Offset: 0x0004AF30
			public void Show(bool activate)
			{
				if (activate)
				{
					this._window.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
				}
			}

			// Token: 0x060014B9 RID: 5305 RVA: 0x0004CD47 File Offset: 0x0004AF47
			public void Cancel()
			{
				this._window.Close();
			}

			// Token: 0x04000A6B RID: 2667
			private global::Infragistics.Windows.Controls.ToolWindowAdorner.ToolWindowAdornerItem _window;
		}
	}
}
