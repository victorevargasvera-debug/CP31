using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;
using Microsoft.Expression.Interactivity.Core;

namespace Microsoft.Expression.Interactivity.Layout
{
	// Token: 0x02000022 RID: 34
	public class MouseDragElementBehavior : global::System.Windows.Interactivity.Behavior<global::System.Windows.FrameworkElement>
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600013B RID: 315 RVA: 0x00007AAC File Offset: 0x00005CAC
		// (remove) Token: 0x0600013C RID: 316 RVA: 0x00007AE4 File Offset: 0x00005CE4
		public event global::System.Windows.Input.MouseEventHandler DragBegun;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600013D RID: 317 RVA: 0x00007B1C File Offset: 0x00005D1C
		// (remove) Token: 0x0600013E RID: 318 RVA: 0x00007B54 File Offset: 0x00005D54
		public event global::System.Windows.Input.MouseEventHandler Dragging;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600013F RID: 319 RVA: 0x00007B8C File Offset: 0x00005D8C
		// (remove) Token: 0x06000140 RID: 320 RVA: 0x00007BC4 File Offset: 0x00005DC4
		public event global::System.Windows.Input.MouseEventHandler DragFinished;

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00007BF9 File Offset: 0x00005DF9
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00007C0B File Offset: 0x00005E0B
		public double X
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.XProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.XProperty, value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00007C1E File Offset: 0x00005E1E
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00007C30 File Offset: 0x00005E30
		public double Y
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.YProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.YProperty, value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00007C43 File Offset: 0x00005E43
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00007C55 File Offset: 0x00005E55
		public bool ConstrainToParentBounds
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.ConstrainToParentBoundsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.ConstrainToParentBoundsProperty, value);
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00007C68 File Offset: 0x00005E68
		private static void OnXChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior mouseDragElementBehavior = (global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior)sender;
			mouseDragElementBehavior.UpdatePosition(new global::System.Windows.Point((double)args.NewValue, mouseDragElementBehavior.Y));
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00007C9C File Offset: 0x00005E9C
		private static void OnYChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior mouseDragElementBehavior = (global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior)sender;
			mouseDragElementBehavior.UpdatePosition(new global::System.Windows.Point(mouseDragElementBehavior.X, (double)args.NewValue));
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00007CD0 File Offset: 0x00005ED0
		private static void OnConstrainToParentBoundsChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior mouseDragElementBehavior = (global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior)sender;
			mouseDragElementBehavior.UpdatePosition(new global::System.Windows.Point(mouseDragElementBehavior.X, mouseDragElementBehavior.Y));
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00007CFC File Offset: 0x00005EFC
		private global::System.Windows.Point ActualPosition
		{
			get
			{
				global::System.Windows.Media.GeneralTransform transform = base.AssociatedObject.TransformToVisual(this.RootElement);
				global::System.Windows.Point transformOffset = global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.GetTransformOffset(transform);
				return new global::System.Windows.Point(transformOffset.X, transformOffset.Y);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00007D38 File Offset: 0x00005F38
		private global::System.Windows.Rect ElementBounds
		{
			get
			{
				global::System.Windows.Rect layoutRect = global::Microsoft.Expression.Interactivity.Core.ExtendedVisualStateManager.GetLayoutRect(base.AssociatedObject);
				return new global::System.Windows.Rect(new global::System.Windows.Point(0.0, 0.0), new global::System.Windows.Size(layoutRect.Width, layoutRect.Height));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00007D80 File Offset: 0x00005F80
		private global::System.Windows.FrameworkElement ParentElement
		{
			get
			{
				return base.AssociatedObject.Parent as global::System.Windows.FrameworkElement;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00007D94 File Offset: 0x00005F94
		private global::System.Windows.UIElement RootElement
		{
			get
			{
				global::System.Windows.DependencyObject dependencyObject = base.AssociatedObject;
				for (global::System.Windows.DependencyObject dependencyObject2 = dependencyObject; dependencyObject2 != null; dependencyObject2 = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject))
				{
					dependencyObject = dependencyObject2;
				}
				return dependencyObject as global::System.Windows.UIElement;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00007DC0 File Offset: 0x00005FC0
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00007E0B File Offset: 0x0000600B
		private global::System.Windows.Media.Transform RenderTransform
		{
			get
			{
				if (this.cachedRenderTransform == null || !object.ReferenceEquals(this.cachedRenderTransform, base.AssociatedObject.RenderTransform))
				{
					global::System.Windows.Media.Transform renderTransform = global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.CloneTransform(base.AssociatedObject.RenderTransform);
					this.RenderTransform = renderTransform;
				}
				return this.cachedRenderTransform;
			}
			set
			{
				if (this.cachedRenderTransform != value)
				{
					this.cachedRenderTransform = value;
					base.AssociatedObject.RenderTransform = value;
				}
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00007E2C File Offset: 0x0000602C
		private void UpdatePosition(global::System.Windows.Point point)
		{
			if (!this.settingPosition && base.AssociatedObject != null)
			{
				global::System.Windows.Media.GeneralTransform transform = base.AssociatedObject.TransformToVisual(this.RootElement);
				global::System.Windows.Point transformOffset = global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.GetTransformOffset(transform);
				double x = double.IsNaN(point.X) ? 0.0 : (point.X - transformOffset.X);
				double y = double.IsNaN(point.Y) ? 0.0 : (point.Y - transformOffset.Y);
				this.ApplyTranslation(x, y);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00007EBC File Offset: 0x000060BC
		private void ApplyTranslation(double x, double y)
		{
			if (this.ParentElement != null)
			{
				global::System.Windows.Media.GeneralTransform transform = this.RootElement.TransformToVisual(this.ParentElement);
				global::System.Windows.Point point = global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.TransformAsVector(transform, x, y);
				x = point.X;
				y = point.Y;
				if (this.ConstrainToParentBounds)
				{
					global::System.Windows.FrameworkElement parentElement = this.ParentElement;
					global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, parentElement.ActualWidth, parentElement.ActualHeight);
					global::System.Windows.Media.GeneralTransform generalTransform = base.AssociatedObject.TransformToVisual(parentElement);
					global::System.Windows.Rect rect2 = this.ElementBounds;
					rect2 = generalTransform.TransformBounds(rect2);
					global::System.Windows.Rect rect3 = rect2;
					rect3.X += x;
					rect3.Y += y;
					if (!global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.RectContainsRect(rect, rect3))
					{
						if (rect3.X < rect.Left)
						{
							double num = rect3.X - rect.Left;
							x -= num;
						}
						else if (rect3.Right > rect.Right)
						{
							double num2 = rect3.Right - rect.Right;
							x -= num2;
						}
						if (rect3.Y < rect.Top)
						{
							double num3 = rect3.Y - rect.Top;
							y -= num3;
						}
						else if (rect3.Bottom > rect.Bottom)
						{
							double num4 = rect3.Bottom - rect.Bottom;
							y -= num4;
						}
					}
				}
				this.ApplyTranslationTransform(x, y);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00008030 File Offset: 0x00006230
		internal void ApplyTranslationTransform(double x, double y)
		{
			global::System.Windows.Media.Transform renderTransform = this.RenderTransform;
			global::System.Windows.Media.TranslateTransform translateTransform = renderTransform as global::System.Windows.Media.TranslateTransform;
			if (translateTransform == null)
			{
				global::System.Windows.Media.TransformGroup transformGroup = renderTransform as global::System.Windows.Media.TransformGroup;
				global::System.Windows.Media.MatrixTransform matrixTransform = renderTransform as global::System.Windows.Media.MatrixTransform;
				if (transformGroup != null)
				{
					if (transformGroup.Children.Count > 0)
					{
						translateTransform = (transformGroup.Children[transformGroup.Children.Count - 1] as global::System.Windows.Media.TranslateTransform);
					}
					if (translateTransform == null)
					{
						translateTransform = new global::System.Windows.Media.TranslateTransform();
						transformGroup.Children.Add(translateTransform);
					}
				}
				else
				{
					if (matrixTransform != null)
					{
						global::System.Windows.Media.Matrix matrix = matrixTransform.Matrix;
						matrix.OffsetX += x;
						matrix.OffsetY += y;
						this.RenderTransform = new global::System.Windows.Media.MatrixTransform
						{
							Matrix = matrix
						};
						return;
					}
					global::System.Windows.Media.TransformGroup transformGroup2 = new global::System.Windows.Media.TransformGroup();
					translateTransform = new global::System.Windows.Media.TranslateTransform();
					if (renderTransform != null)
					{
						transformGroup2.Children.Add(renderTransform);
					}
					transformGroup2.Children.Add(translateTransform);
					this.RenderTransform = transformGroup2;
				}
			}
			translateTransform.X += x;
			translateTransform.Y += y;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00008138 File Offset: 0x00006338
		internal static global::System.Windows.Media.Transform CloneTransform(global::System.Windows.Media.Transform transform)
		{
			if (transform == null)
			{
				return null;
			}
			transform.GetType();
			global::System.Windows.Media.ScaleTransform scaleTransform;
			if ((scaleTransform = (transform as global::System.Windows.Media.ScaleTransform)) != null)
			{
				return new global::System.Windows.Media.ScaleTransform
				{
					CenterX = scaleTransform.CenterX,
					CenterY = scaleTransform.CenterY,
					ScaleX = scaleTransform.ScaleX,
					ScaleY = scaleTransform.ScaleY
				};
			}
			global::System.Windows.Media.RotateTransform rotateTransform;
			if ((rotateTransform = (transform as global::System.Windows.Media.RotateTransform)) != null)
			{
				return new global::System.Windows.Media.RotateTransform
				{
					Angle = rotateTransform.Angle,
					CenterX = rotateTransform.CenterX,
					CenterY = rotateTransform.CenterY
				};
			}
			global::System.Windows.Media.SkewTransform skewTransform;
			if ((skewTransform = (transform as global::System.Windows.Media.SkewTransform)) != null)
			{
				return new global::System.Windows.Media.SkewTransform
				{
					AngleX = skewTransform.AngleX,
					AngleY = skewTransform.AngleY,
					CenterX = skewTransform.CenterX,
					CenterY = skewTransform.CenterY
				};
			}
			global::System.Windows.Media.TranslateTransform translateTransform;
			if ((translateTransform = (transform as global::System.Windows.Media.TranslateTransform)) != null)
			{
				return new global::System.Windows.Media.TranslateTransform
				{
					X = translateTransform.X,
					Y = translateTransform.Y
				};
			}
			global::System.Windows.Media.MatrixTransform matrixTransform;
			if ((matrixTransform = (transform as global::System.Windows.Media.MatrixTransform)) != null)
			{
				return new global::System.Windows.Media.MatrixTransform
				{
					Matrix = matrixTransform.Matrix
				};
			}
			global::System.Windows.Media.TransformGroup transformGroup;
			if ((transformGroup = (transform as global::System.Windows.Media.TransformGroup)) != null)
			{
				global::System.Windows.Media.TransformGroup transformGroup2 = new global::System.Windows.Media.TransformGroup();
				foreach (global::System.Windows.Media.Transform transform2 in transformGroup.Children)
				{
					transformGroup2.Children.Add(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.CloneTransform(transform2));
				}
				return transformGroup2;
			}
			return null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000082E8 File Offset: 0x000064E8
		private void UpdatePosition()
		{
			global::System.Windows.Media.GeneralTransform transform = base.AssociatedObject.TransformToVisual(this.RootElement);
			global::System.Windows.Point transformOffset = global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.GetTransformOffset(transform);
			this.X = transformOffset.X;
			this.Y = transformOffset.Y;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00008328 File Offset: 0x00006528
		internal void StartDrag(global::System.Windows.Point positionInElementCoordinates)
		{
			this.relativePosition = positionInElementCoordinates;
			base.AssociatedObject.CaptureMouse();
			base.AssociatedObject.MouseMove += this.OnMouseMove;
			base.AssociatedObject.LostMouseCapture += this.OnLostMouseCapture;
			base.AssociatedObject.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.OnMouseLeftButtonUp), false);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00008394 File Offset: 0x00006594
		internal void HandleDrag(global::System.Windows.Point newPositionInElementCoordinates)
		{
			double x = newPositionInElementCoordinates.X - this.relativePosition.X;
			double y = newPositionInElementCoordinates.Y - this.relativePosition.Y;
			global::System.Windows.Media.GeneralTransform transform = base.AssociatedObject.TransformToVisual(this.RootElement);
			global::System.Windows.Point point = global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.TransformAsVector(transform, x, y);
			this.settingPosition = true;
			this.ApplyTranslation(point.X, point.Y);
			this.UpdatePosition();
			this.settingPosition = false;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000840C File Offset: 0x0000660C
		internal void EndDrag()
		{
			base.AssociatedObject.MouseMove -= this.OnMouseMove;
			base.AssociatedObject.LostMouseCapture -= this.OnLostMouseCapture;
			base.AssociatedObject.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.OnMouseLeftButtonUp));
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00008463 File Offset: 0x00006663
		private void OnMouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.StartDrag(e.GetPosition(base.AssociatedObject));
			if (this.DragBegun != null)
			{
				this.DragBegun(this, e);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000848C File Offset: 0x0000668C
		private void OnLostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.EndDrag();
			if (this.DragFinished != null)
			{
				this.DragFinished(this, e);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000084A9 File Offset: 0x000066A9
		private void OnMouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.AssociatedObject.ReleaseMouseCapture();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000084B6 File Offset: 0x000066B6
		private void OnMouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.HandleDrag(e.GetPosition(base.AssociatedObject));
			if (this.Dragging != null)
			{
				this.Dragging(this, e);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000084E0 File Offset: 0x000066E0
		private static bool RectContainsRect(global::System.Windows.Rect rect1, global::System.Windows.Rect rect2)
		{
			return !rect1.IsEmpty && !rect2.IsEmpty && (rect1.X <= rect2.X && rect1.Y <= rect2.Y && rect1.X + rect1.Width >= rect2.X + rect2.Width) && rect1.Y + rect1.Height >= rect2.Y + rect2.Height;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00008568 File Offset: 0x00006768
		private static global::System.Windows.Point TransformAsVector(global::System.Windows.Media.GeneralTransform transform, double x, double y)
		{
			global::System.Windows.Point point = transform.Transform(new global::System.Windows.Point(0.0, 0.0));
			global::System.Windows.Point point2 = transform.Transform(new global::System.Windows.Point(x, y));
			return new global::System.Windows.Point(point2.X - point.X, point2.Y - point.Y);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000085C4 File Offset: 0x000067C4
		private static global::System.Windows.Point GetTransformOffset(global::System.Windows.Media.GeneralTransform transform)
		{
			return transform.Transform(new global::System.Windows.Point(0.0, 0.0));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000085E3 File Offset: 0x000067E3
		protected override void OnAttached()
		{
			base.AssociatedObject.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.OnMouseLeftButtonDown), false);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00008602 File Offset: 0x00006802
		protected override void OnDetaching()
		{
			base.AssociatedObject.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.OnMouseLeftButtonDown));
		}

		// Token: 0x0400006B RID: 107
		private bool settingPosition;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Point relativePosition;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Media.Transform cachedRenderTransform;

		// Token: 0x04000071 RID: 113
		public static readonly global::System.Windows.DependencyProperty XProperty = global::System.Windows.DependencyProperty.Register("X", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior), new global::System.Windows.PropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.OnXChanged)));

		// Token: 0x04000072 RID: 114
		public static readonly global::System.Windows.DependencyProperty YProperty = global::System.Windows.DependencyProperty.Register("Y", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior), new global::System.Windows.PropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.OnYChanged)));

		// Token: 0x04000073 RID: 115
		public static readonly global::System.Windows.DependencyProperty ConstrainToParentBoundsProperty = global::System.Windows.DependencyProperty.Register("ConstrainToParentBounds", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Layout.MouseDragElementBehavior.OnConstrainToParentBoundsChanged)));
	}
}
