using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics
{
	// Token: 0x02000018 RID: 24
	internal class ShapeElement : global::Infragistics.Groupable
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00007DD8 File Offset: 0x00005FD8
		public ShapeElement()
		{
			this.FrameworkElements = new global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.FrameworkElement>();
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00007DEB File Offset: 0x00005FEB
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00007DFD File Offset: 0x00005FFD
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.FrameworkElement> FrameworkElements
		{
			get
			{
				return (global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.FrameworkElement>)base.GetValue(global::Infragistics.ShapeElement.FrameworkElementsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.ShapeElement.FrameworkElementsProperty, value);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00007E0B File Offset: 0x0000600B
		private static void OnFrameworkElementsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.ShapeElement)d).OnFrameworkElementsChanged((global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.FrameworkElement>)e.OldValue, (global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.FrameworkElement>)e.NewValue);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00007E30 File Offset: 0x00006030
		protected virtual void OnFrameworkElementsChanged(global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.FrameworkElement> oldValue, global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.FrameworkElement> newValue)
		{
			if (oldValue != null)
			{
				oldValue.CollectionChanged -= this.FrameworkElements_CollectionChanged;
				this.RemoveFrameworkElementsSettings(oldValue);
			}
			if (newValue != null)
			{
				newValue.CollectionChanged += this.FrameworkElements_CollectionChanged;
				this.SetFrameworkElementsSettings(newValue);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00007E6C File Offset: 0x0000606C
		private void FrameworkElements_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				this.SetFrameworkElementsSettings(e.NewItems);
				break;
			}
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				this.RemoveFrameworkElementsSettings(e.OldItems);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007EC4 File Offset: 0x000060C4
		private void SetFrameworkElementsSettings(global::System.Collections.IList items)
		{
			if (items == null)
			{
				return;
			}
			foreach (object obj in items)
			{
				global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)obj;
				frameworkElement.MouseEnter += this.FrameworkElement_MouseEnter;
				frameworkElement.MouseLeave += this.FrameworkElement_MouseLeave;
				if (this.View != null && base.Canvas != null)
				{
					base.Canvas.Children.Add(frameworkElement);
				}
				this.ChangeFrameworkElementSettings(frameworkElement);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007F64 File Offset: 0x00006164
		private void RemoveFrameworkElementsSettings(global::System.Collections.IList items)
		{
			if (items == null)
			{
				return;
			}
			foreach (object obj in items)
			{
				global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)obj;
				frameworkElement.MouseEnter -= this.FrameworkElement_MouseEnter;
				frameworkElement.MouseLeave -= this.FrameworkElement_MouseLeave;
				if (this.View != null && base.Canvas != null)
				{
					base.Canvas.Children.Remove(frameworkElement);
				}
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00007FFC File Offset: 0x000061FC
		private void FrameworkElement_MouseEnter(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (!base.IsMouseCaptured)
			{
				this.ActiveFrameworkElement = (sender as global::System.Windows.FrameworkElement);
			}
			this.IsMouseEntered = true;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00008019 File Offset: 0x00006219
		private void FrameworkElement_MouseLeave(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (!base.IsMouseCaptured)
			{
				this.ActiveFrameworkElement = null;
			}
			this.IsMouseEntered = false;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008031 File Offset: 0x00006231
		protected override void OnBoundsChanged(global::System.Windows.Rect oldValue, global::System.Windows.Rect newValue)
		{
			base.OnBoundsChanged(oldValue, newValue);
			this.SetFrameworkElementsBounds();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008044 File Offset: 0x00006244
		protected override void OnVisibilityChanged(global::System.Windows.Visibility oldValue, global::System.Windows.Visibility newValue)
		{
			base.OnVisibilityChanged(oldValue, newValue);
			foreach (global::System.Windows.FrameworkElement frameworkElement in this.FrameworkElements)
			{
				frameworkElement.Visibility = newValue;
			}
			if (newValue == global::System.Windows.Visibility.Collapsed)
			{
				this.IsMouseEntered = false;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000080A4 File Offset: 0x000062A4
		protected override void OnZIndexChanged(int oldValue, int newValue)
		{
			base.OnZIndexChanged(oldValue, newValue);
			foreach (global::System.Windows.FrameworkElement element in this.FrameworkElements)
			{
				global::System.Windows.Controls.Panel.SetZIndex(element, newValue);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000080FC File Offset: 0x000062FC
		protected override void OnCursorChanged(global::System.Windows.Input.Cursor oldValue, global::System.Windows.Input.Cursor newValue)
		{
			base.OnCursorChanged(oldValue, newValue);
			foreach (global::System.Windows.FrameworkElement frameworkElement in this.FrameworkElements)
			{
				frameworkElement.Cursor = newValue;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00008154 File Offset: 0x00006354
		protected override void OnFillChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
			base.OnFillChanged(oldValue, newValue);
			foreach (global::System.Windows.FrameworkElement frameworkElement in this.FrameworkElements)
			{
				global::System.Windows.Shapes.Shape shape = frameworkElement as global::System.Windows.Shapes.Shape;
				if (shape != null)
				{
					shape.Fill = newValue;
				}
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000081B4 File Offset: 0x000063B4
		protected override void OnStrokeChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
			base.OnStrokeChanged(oldValue, newValue);
			foreach (global::System.Windows.FrameworkElement frameworkElement in this.FrameworkElements)
			{
				global::System.Windows.Shapes.Shape shape = frameworkElement as global::System.Windows.Shapes.Shape;
				if (shape != null)
				{
					shape.Stroke = newValue;
				}
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00008214 File Offset: 0x00006414
		protected override void OnStrokeThicknessChanged(double oldValue, double newValue)
		{
			base.OnStrokeThicknessChanged(oldValue, newValue);
			foreach (global::System.Windows.FrameworkElement frameworkElement in this.FrameworkElements)
			{
				global::System.Windows.Shapes.Shape shape = frameworkElement as global::System.Windows.Shapes.Shape;
				if (shape != null)
				{
					shape.StrokeThickness = newValue;
				}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00008274 File Offset: 0x00006474
		public override void Render()
		{
			if (this.View == null || base.Canvas == null)
			{
				return;
			}
			foreach (global::System.Windows.FrameworkElement element in this.FrameworkElements)
			{
				if (!base.Canvas.Children.Contains(element))
				{
					base.Canvas.Children.Add(element);
				}
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000082F0 File Offset: 0x000064F0
		public override void Remove()
		{
			foreach (global::System.Windows.FrameworkElement element in this.FrameworkElements)
			{
				base.Canvas.Children.Remove(element);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00008348 File Offset: 0x00006548
		public override bool HitTest(global::System.Windows.Point point)
		{
			return this.IsMouseEntered;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00008350 File Offset: 0x00006550
		public override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (this.ActiveFrameworkElement.Visibility == global::System.Windows.Visibility.Visible)
			{
				this.ActiveFrameworkElement.CaptureMouse();
				this.View.CapturedElement = this;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000837E File Offset: 0x0000657E
		public override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (this.ActiveFrameworkElement.Visibility == global::System.Windows.Visibility.Visible)
			{
				this.View.IsManuallyReleasingMouseCapture = true;
				this.ActiveFrameworkElement.ReleaseMouseCapture();
			}
			this.View.CapturedElement = null;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000083B7 File Offset: 0x000065B7
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000083BF File Offset: 0x000065BF
		internal global::System.Windows.FrameworkElement ActiveFrameworkElement
		{
			get
			{
				return this._activeFrameworkElement;
			}
			set
			{
				this._activeFrameworkElement = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000083C8 File Offset: 0x000065C8
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000083D0 File Offset: 0x000065D0
		private bool IsMouseEntered
		{
			get
			{
				return this._isMouseEntered;
			}
			set
			{
				this._isMouseEntered = value;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000083D9 File Offset: 0x000065D9
		protected virtual void ChangeFrameworkElementSettings(global::System.Windows.FrameworkElement frameworkElement)
		{
			base.Initializing = true;
			base.Bounds = this.GetBounds(frameworkElement);
			this.SetFrameworkElementBounds(frameworkElement);
			base.Initializing = false;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00008400 File Offset: 0x00006600
		private void SetFrameworkElementsBounds()
		{
			foreach (global::System.Windows.FrameworkElement frameworkElementBounds in this.FrameworkElements)
			{
				this.SetFrameworkElementBounds(frameworkElementBounds);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00008450 File Offset: 0x00006650
		private void SetFrameworkElementBounds(global::System.Windows.FrameworkElement frameworkElement)
		{
			global::System.Windows.Thickness margin = frameworkElement.Margin;
			double num = margin.Left + margin.Right;
			double num2 = margin.Top + margin.Bottom;
			double num3 = base.Bounds.Width - num;
			double num4 = base.Bounds.Height - num2;
			if (num3 < 0.0)
			{
				num3 = 0.0;
			}
			if (num4 < 0.0)
			{
				num4 = 0.0;
			}
			frameworkElement.Width = global::System.Math.Round(num3);
			frameworkElement.Height = global::System.Math.Round(num4);
			global::System.Windows.Controls.Canvas.SetLeft(frameworkElement, global::System.Math.Round(base.Bounds.X));
			global::System.Windows.Controls.Canvas.SetTop(frameworkElement, global::System.Math.Round(base.Bounds.Y));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00008524 File Offset: 0x00006724
		private global::System.Windows.Rect GetBounds(global::System.Windows.FrameworkElement frameworkElement)
		{
			global::System.Windows.Rect bounds = base.Bounds;
			if (base.ReadLocalValue(global::Infragistics.VisualElement.XProperty) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				double left = global::System.Windows.Controls.Canvas.GetLeft(frameworkElement);
				if (!double.IsNaN(left))
				{
					bounds.X = left;
				}
			}
			if (base.ReadLocalValue(global::Infragistics.VisualElement.YProperty) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				double top = global::System.Windows.Controls.Canvas.GetTop(frameworkElement);
				if (!double.IsNaN(top))
				{
					bounds.Y = top;
				}
			}
			if (base.ReadLocalValue(global::Infragistics.VisualElement.WidthProperty) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				double width = frameworkElement.Width;
				if (!double.IsNaN(width))
				{
					bounds.Width = width;
				}
			}
			if (base.ReadLocalValue(global::Infragistics.VisualElement.HeightProperty) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				double height = frameworkElement.Height;
				if (!double.IsNaN(height))
				{
					bounds.Height = height;
				}
			}
			return bounds;
		}

		// Token: 0x04000068 RID: 104
		public static readonly global::System.Windows.DependencyProperty FrameworkElementsProperty = global::System.Windows.DependencyProperty.Register("FrameworkElements", typeof(global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.FrameworkElement>), typeof(global::Infragistics.ShapeElement), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.ShapeElement.OnFrameworkElementsChanged)));

		// Token: 0x04000069 RID: 105
		private global::System.Windows.FrameworkElement _activeFrameworkElement;

		// Token: 0x0400006A RID: 106
		private bool _isMouseEntered;
	}
}
