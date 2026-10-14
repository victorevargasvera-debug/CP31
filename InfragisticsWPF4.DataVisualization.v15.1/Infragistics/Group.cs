using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000017 RID: 23
	[global::System.Windows.Markup.ContentProperty("Children")]
	internal class Group : global::Infragistics.Groupable
	{
		// Token: 0x0600010F RID: 271 RVA: 0x0000734D File Offset: 0x0000554D
		public Group()
		{
			this.Children = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Groupable>();
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00007360 File Offset: 0x00005560
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00007368 File Offset: 0x00005568
		private bool AddingItem
		{
			get
			{
				return this._addingItem;
			}
			set
			{
				this._addingItem = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00007371 File Offset: 0x00005571
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00007383 File Offset: 0x00005583
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Groupable> Children
		{
			get
			{
				return (global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Groupable>)base.GetValue(global::Infragistics.Group.ChildrenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Group.ChildrenProperty, value);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00007391 File Offset: 0x00005591
		private static void OnChildrenChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Group)d).OnChildrenChanged((global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Groupable>)e.OldValue, (global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Groupable>)e.NewValue);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000073B6 File Offset: 0x000055B6
		private void OnChildrenChanged(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Groupable> oldValue, global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Groupable> newValue)
		{
			if (oldValue != null)
			{
				oldValue.CollectionChanged -= this.Children_CollectionChanged;
				this.RemoveItems(oldValue);
			}
			if (newValue != null)
			{
				this.AddItems(newValue);
				newValue.CollectionChanged += this.Children_CollectionChanged;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000073F0 File Offset: 0x000055F0
		private void Children_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				this.AddItems(e.NewItems);
				return;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				this.RemoveItems(e.OldItems);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				break;
			default:
				return;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00007438 File Offset: 0x00005638
		public void AddItems(global::System.Collections.IList items)
		{
			if (items == null)
			{
				return;
			}
			foreach (object obj in items)
			{
				global::Infragistics.Groupable groupable = (global::Infragistics.Groupable)obj;
				groupable.SetView(this.View);
				groupable.Parent = this;
				this.AddingItem = true;
				this.AccumulateBounds(groupable);
				this.AddingItem = false;
				this.AddItem(groupable);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000074B8 File Offset: 0x000056B8
		public void RemoveItems(global::System.Collections.IList items)
		{
			if (items == null)
			{
				return;
			}
			foreach (object obj in items)
			{
				global::Infragistics.Groupable groupable = (global::Infragistics.Groupable)obj;
				groupable.Parent = base.Parent;
				this.RemoveItem(groupable);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000751C File Offset: 0x0000571C
		protected virtual void AddItem(global::Infragistics.Groupable item)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000751E File Offset: 0x0000571E
		protected virtual void RemoveItem(global::Infragistics.Groupable item)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00007520 File Offset: 0x00005720
		protected override void OnBoundsChanged(global::System.Windows.Rect oldValue, global::System.Windows.Rect newValue)
		{
			base.OnBoundsChanged(oldValue, newValue);
			if (!base.Initializing && !this.AddingItem)
			{
				this.ArrangeChildren(oldValue, newValue);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00007544 File Offset: 0x00005744
		protected override void OnVisibilityChanged(global::System.Windows.Visibility oldValue, global::System.Windows.Visibility newValue)
		{
			base.OnVisibilityChanged(oldValue, newValue);
			foreach (global::Infragistics.Groupable groupable in this.Children)
			{
				groupable.Visibility = newValue;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000759C File Offset: 0x0000579C
		protected override void OnZIndexChanged(int oldValue, int newValue)
		{
			base.OnZIndexChanged(oldValue, newValue);
			foreach (global::Infragistics.Groupable groupable in this.Children)
			{
				groupable.ZIndex = newValue;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000075F4 File Offset: 0x000057F4
		protected override void OnCursorChanged(global::System.Windows.Input.Cursor oldValue, global::System.Windows.Input.Cursor newValue)
		{
			base.OnCursorChanged(oldValue, newValue);
			foreach (global::Infragistics.Groupable groupable in this.Children)
			{
				groupable.Cursor = newValue;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000764C File Offset: 0x0000584C
		protected override void OnFillChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
			base.OnFillChanged(oldValue, newValue);
			foreach (global::Infragistics.Groupable groupable in this.Children)
			{
				groupable.Fill = newValue;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000076A4 File Offset: 0x000058A4
		protected override void OnStrokeChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
			base.OnStrokeChanged(oldValue, newValue);
			foreach (global::Infragistics.Groupable groupable in this.Children)
			{
				groupable.Stroke = newValue;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000076FC File Offset: 0x000058FC
		protected override void OnStrokeThicknessChanged(double oldValue, double newValue)
		{
			base.OnStrokeThicknessChanged(oldValue, newValue);
			foreach (global::Infragistics.Groupable groupable in this.Children)
			{
				groupable.StrokeThickness = newValue;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00007754 File Offset: 0x00005954
		public override void Render()
		{
			foreach (global::Infragistics.VisualElement visualElement in this.Children)
			{
				if (visualElement.View == null)
				{
					visualElement.SetView(this.View);
				}
				visualElement.Render();
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000077B4 File Offset: 0x000059B4
		public override void Remove()
		{
			foreach (global::Infragistics.VisualElement visualElement in this.Children)
			{
				if (visualElement.View != null)
				{
					visualElement.Remove();
				}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00007808 File Offset: 0x00005A08
		public override bool HitTest(global::System.Windows.Point point)
		{
			if (base.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				return false;
			}
			foreach (global::Infragistics.Groupable groupable in this.Children)
			{
				if (groupable.HitTest(point))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000786C File Offset: 0x00005A6C
		public override bool HitTest(global::System.Windows.Rect rect)
		{
			if (base.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				return false;
			}
			foreach (global::Infragistics.Groupable groupable in this.Children)
			{
				if (groupable.HitTest(rect))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000078D0 File Offset: 0x00005AD0
		public override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			foreach (global::Infragistics.InteractiveElement interactiveElement in this.Children)
			{
				if (interactiveElement.IsMouseOver)
				{
					interactiveElement.OnMouseLeave(e);
				}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000792C File Offset: 0x00005B2C
		public override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			global::System.Windows.Point docMousePosition = this.View.LastInput.DocMousePosition;
			foreach (global::Infragistics.InteractiveElement interactiveElement in this.Children)
			{
				if (interactiveElement.HitTest(docMousePosition))
				{
					if (interactiveElement.IsMouseOver)
					{
						interactiveElement.OnMouseMove(e);
					}
					else
					{
						interactiveElement.OnMouseEnter(e);
					}
				}
				else if (interactiveElement.IsMouseOver)
				{
					interactiveElement.OnMouseLeave(e);
				}
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000079BC File Offset: 0x00005BBC
		public override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			global::System.Windows.Point docMousePosition = this.View.LastInput.DocMousePosition;
			foreach (global::Infragistics.InteractiveElement interactiveElement in this.Children)
			{
				if (interactiveElement.HitTest(docMousePosition))
				{
					interactiveElement.OnMouseLeftButtonDown(e);
				}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00007A2C File Offset: 0x00005C2C
		public override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			global::System.Windows.Point docMousePosition = this.View.LastInput.DocMousePosition;
			foreach (global::Infragistics.InteractiveElement interactiveElement in this.Children)
			{
				if (interactiveElement.HitTest(docMousePosition))
				{
					interactiveElement.OnMouseLeftButtonUp(e);
				}
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00007A9C File Offset: 0x00005C9C
		public override void OnMouseLeftButtonDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDoubleClick(e);
			global::System.Windows.Point docMousePosition = this.View.LastInput.DocMousePosition;
			for (int i = 0; i < this.Children.Count; i++)
			{
				global::Infragistics.InteractiveElement interactiveElement = this.Children[i];
				if (interactiveElement.HitTest(docMousePosition))
				{
					interactiveElement.OnMouseLeftButtonDoubleClick(e);
				}
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00007AF4 File Offset: 0x00005CF4
		public override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Point docMousePosition = this.View.LastInput.DocMousePosition;
			foreach (global::Infragistics.InteractiveElement interactiveElement in this.Children)
			{
				if (interactiveElement.HitTest(docMousePosition))
				{
					interactiveElement.OnKeyDown(e);
				}
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00007B5C File Offset: 0x00005D5C
		public override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Point docMousePosition = this.View.LastInput.DocMousePosition;
			foreach (global::Infragistics.InteractiveElement interactiveElement in this.Children)
			{
				if (interactiveElement.HitTest(docMousePosition))
				{
					interactiveElement.OnKeyUp(e);
				}
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00007BC4 File Offset: 0x00005DC4
		public override void TransformBounds(global::System.Windows.Media.Transform transform)
		{
			this.AddingItem = true;
			global::System.Windows.Rect newBounds = global::Infragistics.Groupable.TransformRect(transform, base.Bounds);
			this.ArrangeChildren(base.Bounds, newBounds);
			base.TransformBounds(transform);
			this.AddingItem = false;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00007C00 File Offset: 0x00005E00
		public virtual void ArrangeChildren(global::System.Windows.Rect oldBounds, global::System.Windows.Rect newBounds)
		{
			global::System.Windows.Media.Transform groupTransform = global::Infragistics.Groupable.CalculateTransform(newBounds, oldBounds);
			foreach (global::Infragistics.Groupable groupable in this.Children)
			{
				groupable.ArrangeInGroup(oldBounds, newBounds, groupTransform);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00007C58 File Offset: 0x00005E58
		protected static global::System.Windows.Rect CalculateBounds(global::Infragistics.Groupable[] items)
		{
			global::System.Windows.Rect bounds = new global::System.Windows.Rect(0.0, 0.0, 0.0, 0.0);
			foreach (global::Infragistics.Groupable visualElement in items)
			{
				bool flag = bounds.X == 0.0 && bounds.Y == 0.0 && bounds.Width == 0.0 && bounds.Height == 0.0;
				if (bounds.IsEmpty || flag)
				{
					bounds = visualElement.Bounds;
				}
				else
				{
					bounds.Union(visualElement.Bounds);
				}
			}
			return bounds;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00007D18 File Offset: 0x00005F18
		protected void AccumulateBounds(global::Infragistics.VisualElement item)
		{
			global::System.Windows.Rect bounds = base.Bounds;
			bool flag = bounds.X == 0.0 && bounds.Y == 0.0 && bounds.Width == 0.0 && bounds.Height == 0.0;
			if (bounds.IsEmpty || flag)
			{
				bounds = item.Bounds;
			}
			else
			{
				bounds.Union(item.Bounds);
			}
			base.Bounds = bounds;
		}

		// Token: 0x04000066 RID: 102
		private bool _addingItem;

		// Token: 0x04000067 RID: 103
		public static readonly global::System.Windows.DependencyProperty ChildrenProperty = global::System.Windows.DependencyProperty.Register("Children", typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Groupable>), typeof(global::Infragistics.Group), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Group.OnChildrenChanged)));
	}
}
