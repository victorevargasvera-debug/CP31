using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;
using Microsoft.Expression.Interactivity.Layout;

namespace Microsoft.Expression.Interactivity.Input
{
	// Token: 0x0200002D RID: 45
	public class TranslateZoomRotateBehavior : global::System.Windows.Interactivity.Behavior<global::System.Windows.FrameworkElement>
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00008EF7 File Offset: 0x000070F7
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00008F09 File Offset: 0x00007109
		public global::System.Windows.Input.ManipulationModes SupportedGestures
		{
			get
			{
				return (global::System.Windows.Input.ManipulationModes)base.GetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.SupportedGesturesProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.SupportedGesturesProperty, value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00008F1C File Offset: 0x0000711C
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00008F2E File Offset: 0x0000712E
		public double TranslateFriction
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.TranslateFrictionProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.TranslateFrictionProperty, value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00008F41 File Offset: 0x00007141
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00008F53 File Offset: 0x00007153
		public double RotationalFriction
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.RotationalFrictionProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.RotationalFrictionProperty, value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00008F66 File Offset: 0x00007166
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00008F78 File Offset: 0x00007178
		public bool ConstrainToParentBounds
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.ConstrainToParentBoundsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.ConstrainToParentBoundsProperty, value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00008F8B File Offset: 0x0000718B
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00008F9D File Offset: 0x0000719D
		public double MinimumScale
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.MinimumScaleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.MinimumScaleProperty, value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00008FB0 File Offset: 0x000071B0
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00008FC2 File Offset: 0x000071C2
		public double MaximumScale
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.MaximumScaleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.MaximumScaleProperty, value);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00008FD5 File Offset: 0x000071D5
		private static void frictionChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00008FD8 File Offset: 0x000071D8
		private static object coerceFriction(global::System.Windows.DependencyObject sender, object value)
		{
			double val = (double)value;
			return global::System.Math.Max(0.0, global::System.Math.Min(1.0, val));
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00009010 File Offset: 0x00007210
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000905B File Offset: 0x0000725B
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000907C File Offset: 0x0000727C
		private global::System.Windows.Point RenderTransformOriginInElementCoordinates
		{
			get
			{
				return new global::System.Windows.Point(base.AssociatedObject.RenderTransformOrigin.X * base.AssociatedObject.ActualWidth, base.AssociatedObject.RenderTransformOrigin.Y * base.AssociatedObject.ActualHeight);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000090CC File Offset: 0x000072CC
		private global::System.Windows.Media.Matrix FullTransformValue
		{
			get
			{
				global::System.Windows.Point renderTransformOriginInElementCoordinates = this.RenderTransformOriginInElementCoordinates;
				global::System.Windows.Media.Matrix value = this.RenderTransform.Value;
				value.TranslatePrepend(-renderTransformOriginInElementCoordinates.X, -renderTransformOriginInElementCoordinates.Y);
				value.Translate(renderTransformOriginInElementCoordinates.X, renderTransformOriginInElementCoordinates.Y);
				return value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00009119 File Offset: 0x00007319
		private global::System.Windows.Media.MatrixTransform MatrixTransform
		{
			get
			{
				this.EnsureTransform();
				return (global::System.Windows.Media.MatrixTransform)this.RenderTransform;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000912C File Offset: 0x0000732C
		private global::System.Windows.FrameworkElement ParentElement
		{
			get
			{
				return base.AssociatedObject.Parent as global::System.Windows.FrameworkElement;
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00009140 File Offset: 0x00007340
		internal void EnsureTransform()
		{
			global::System.Windows.Media.MatrixTransform matrixTransform = this.RenderTransform as global::System.Windows.Media.MatrixTransform;
			if (matrixTransform == null || matrixTransform.IsFrozen)
			{
				if (this.RenderTransform != null)
				{
					matrixTransform = new global::System.Windows.Media.MatrixTransform(this.FullTransformValue);
				}
				else
				{
					matrixTransform = new global::System.Windows.Media.MatrixTransform(global::System.Windows.Media.Matrix.Identity);
				}
				this.RenderTransform = matrixTransform;
			}
			base.AssociatedObject.RenderTransformOrigin = new global::System.Windows.Point(0.0, 0.0);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000091B0 File Offset: 0x000073B0
		internal void ApplyRotationTransform(double angle, global::System.Windows.Point rotationPoint)
		{
			global::System.Windows.Media.Matrix matrix = this.MatrixTransform.Matrix;
			matrix.RotateAt(angle, rotationPoint.X, rotationPoint.Y);
			this.MatrixTransform.Matrix = matrix;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000091EC File Offset: 0x000073EC
		internal void ApplyScaleTransform(double scaleX, double scaleY, global::System.Windows.Point scalePoint)
		{
			double num = scaleX * this.lastScaleX;
			num = global::System.Math.Min(global::System.Math.Max(global::System.Math.Max(1E-06, this.MinimumScale), num), this.MaximumScale);
			scaleX = num / this.lastScaleX;
			this.lastScaleX = scaleX * this.lastScaleX;
			double num2 = scaleY * this.lastScaleY;
			num2 = global::System.Math.Min(global::System.Math.Max(global::System.Math.Max(1E-06, this.MinimumScale), num2), this.MaximumScale);
			scaleY = num2 / this.lastScaleY;
			this.lastScaleY = scaleY * this.lastScaleY;
			global::System.Windows.Media.Matrix matrix = this.MatrixTransform.Matrix;
			matrix.ScaleAt(scaleX, scaleY, scalePoint.X, scalePoint.Y);
			this.MatrixTransform.Matrix = matrix;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000092B8 File Offset: 0x000074B8
		internal void ApplyTranslateTransform(double x, double y)
		{
			global::System.Windows.Media.Matrix matrix = this.MatrixTransform.Matrix;
			matrix.Translate(x, y);
			this.MatrixTransform.Matrix = matrix;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000092E6 File Offset: 0x000074E6
		private void ManipulationStarting(object sender, global::System.Windows.Input.ManipulationStartingEventArgs e)
		{
			e.ManipulationContainer = (this.ParentElement ?? base.AssociatedObject);
			e.Mode = this.SupportedGestures;
			e.Handled = true;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00009314 File Offset: 0x00007514
		private void ManipulationInertiaStarting(object sender, global::System.Windows.Input.ManipulationInertiaStartingEventArgs e)
		{
			double num = (this.TranslateFriction == 1.0) ? 1.0 : (-0.00666 * global::System.Math.Log(1.0 - this.TranslateFriction));
			double val = e.InitialVelocities.LinearVelocity.Length * num;
			e.TranslationBehavior = new global::System.Windows.Input.InertiaTranslationBehavior
			{
				InitialVelocity = e.InitialVelocities.LinearVelocity,
				DesiredDeceleration = global::System.Math.Max(val, 0.0)
			};
			double num2 = (this.RotationalFriction == 1.0) ? 1.0 : (-0.00666 * global::System.Math.Log(1.0 - this.RotationalFriction));
			double val2 = global::System.Math.Abs(e.InitialVelocities.AngularVelocity) * num2;
			e.RotationBehavior = new global::System.Windows.Input.InertiaRotationBehavior
			{
				InitialVelocity = e.InitialVelocities.AngularVelocity,
				DesiredDeceleration = global::System.Math.Max(val2, 0.0)
			};
			e.Handled = true;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00009438 File Offset: 0x00007638
		private void ManipulationDelta(object sender, global::System.Windows.Input.ManipulationDeltaEventArgs e)
		{
			this.EnsureTransform();
			global::System.Windows.Input.ManipulationDelta deltaManipulation = e.DeltaManipulation;
			global::System.Windows.Point point = new global::System.Windows.Point(base.AssociatedObject.ActualWidth / 2.0, base.AssociatedObject.ActualHeight / 2.0);
			global::System.Windows.Point point2 = this.FullTransformValue.Transform(point);
			this.ApplyScaleTransform(deltaManipulation.Scale.X, deltaManipulation.Scale.Y, point2);
			this.ApplyRotationTransform(deltaManipulation.Rotation, point2);
			this.ApplyTranslateTransform(deltaManipulation.Translation.X, deltaManipulation.Translation.Y);
			global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)e.ManipulationContainer;
			global::System.Windows.Rect rect = new global::System.Windows.Rect(frameworkElement.RenderSize);
			global::System.Windows.Rect rect2 = base.AssociatedObject.TransformToVisual(frameworkElement).TransformBounds(new global::System.Windows.Rect(base.AssociatedObject.RenderSize));
			if (e.IsInertial && this.ConstrainToParentBounds && !rect.Contains(rect2))
			{
				e.Complete();
			}
			e.Handled = true;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00009550 File Offset: 0x00007750
		private void MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.AssociatedObject.CaptureMouse();
			base.AssociatedObject.MouseMove += this.AssociatedObject_MouseMove;
			base.AssociatedObject.LostMouseCapture += this.AssociatedObject_LostMouseCapture;
			e.Handled = true;
			this.lastMousePoint = e.GetPosition(base.AssociatedObject);
			this.isDragging = true;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000095B7 File Offset: 0x000077B7
		private void MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.AssociatedObject.ReleaseMouseCapture();
			e.Handled = true;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000095CB File Offset: 0x000077CB
		private void AssociatedObject_LostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.isDragging = false;
			base.AssociatedObject.MouseMove -= this.AssociatedObject_MouseMove;
			base.AssociatedObject.LostMouseCapture -= this.AssociatedObject_LostMouseCapture;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00009604 File Offset: 0x00007804
		private void AssociatedObject_MouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.isDragging && !this.isAdjustingTransform)
			{
				this.isAdjustingTransform = true;
				global::System.Windows.Point position = e.GetPosition(base.AssociatedObject);
				global::System.Windows.Vector vector = position - this.lastMousePoint;
				if ((this.SupportedGestures & global::System.Windows.Input.ManipulationModes.TranslateX) == global::System.Windows.Input.ManipulationModes.None)
				{
					vector.X = 0.0;
				}
				if ((this.SupportedGestures & global::System.Windows.Input.ManipulationModes.TranslateY) == global::System.Windows.Input.ManipulationModes.None)
				{
					vector.Y = 0.0;
				}
				global::System.Windows.Vector vector2 = this.FullTransformValue.Transform(vector);
				this.ApplyTranslateTransform(vector2.X, vector2.Y);
				this.lastMousePoint = e.GetPosition(base.AssociatedObject);
				this.isAdjustingTransform = false;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000096BC File Offset: 0x000078BC
		protected override void OnAttached()
		{
			base.AssociatedObject.AddHandler(global::System.Windows.UIElement.ManipulationStartingEvent, new global::System.EventHandler<global::System.Windows.Input.ManipulationStartingEventArgs>(this.ManipulationStarting), false);
			base.AssociatedObject.AddHandler(global::System.Windows.UIElement.ManipulationInertiaStartingEvent, new global::System.EventHandler<global::System.Windows.Input.ManipulationInertiaStartingEventArgs>(this.ManipulationInertiaStarting), false);
			base.AssociatedObject.AddHandler(global::System.Windows.UIElement.ManipulationDeltaEvent, new global::System.EventHandler<global::System.Windows.Input.ManipulationDeltaEventArgs>(this.ManipulationDelta), false);
			base.AssociatedObject.IsManipulationEnabled = true;
			base.AssociatedObject.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.MouseLeftButtonDown), false);
			base.AssociatedObject.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.MouseLeftButtonUp), false);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00009768 File Offset: 0x00007968
		protected override void OnDetaching()
		{
			base.AssociatedObject.RemoveHandler(global::System.Windows.UIElement.ManipulationStartingEvent, new global::System.EventHandler<global::System.Windows.Input.ManipulationStartingEventArgs>(this.ManipulationStarting));
			base.AssociatedObject.RemoveHandler(global::System.Windows.UIElement.ManipulationInertiaStartingEvent, new global::System.EventHandler<global::System.Windows.Input.ManipulationInertiaStartingEventArgs>(this.ManipulationInertiaStarting));
			base.AssociatedObject.RemoveHandler(global::System.Windows.UIElement.ManipulationDeltaEvent, new global::System.EventHandler<global::System.Windows.Input.ManipulationDeltaEventArgs>(this.ManipulationDelta));
			base.AssociatedObject.IsManipulationEnabled = false;
			base.AssociatedObject.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.MouseLeftButtonDown), false);
			base.AssociatedObject.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.MouseLeftButtonUp), false);
		}

		// Token: 0x04000088 RID: 136
		private const double HardMinimumScale = 1E-06;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Media.Transform cachedRenderTransform;

		// Token: 0x0400008A RID: 138
		private bool isDragging;

		// Token: 0x0400008B RID: 139
		private bool isAdjustingTransform;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Point lastMousePoint;

		// Token: 0x0400008D RID: 141
		private double lastScaleX = 1.0;

		// Token: 0x0400008E RID: 142
		private double lastScaleY = 1.0;

		// Token: 0x0400008F RID: 143
		public static readonly global::System.Windows.DependencyProperty SupportedGesturesProperty = global::System.Windows.DependencyProperty.Register("SupportedGestures", typeof(global::System.Windows.Input.ManipulationModes), typeof(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior), new global::System.Windows.PropertyMetadata(global::System.Windows.Input.ManipulationModes.All));

		// Token: 0x04000090 RID: 144
		public static readonly global::System.Windows.DependencyProperty TranslateFrictionProperty = global::System.Windows.DependencyProperty.Register("TranslateFriction", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.frictionChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.coerceFriction)));

		// Token: 0x04000091 RID: 145
		public static readonly global::System.Windows.DependencyProperty RotationalFrictionProperty = global::System.Windows.DependencyProperty.Register("RotationalFriction", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.frictionChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior.coerceFriction)));

		// Token: 0x04000092 RID: 146
		public static readonly global::System.Windows.DependencyProperty ConstrainToParentBoundsProperty = global::System.Windows.DependencyProperty.Register("ConstrainToParentBounds", typeof(bool), typeof(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x04000093 RID: 147
		public static readonly global::System.Windows.DependencyProperty MinimumScaleProperty = global::System.Windows.DependencyProperty.Register("MinimumScale", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior), new global::System.Windows.PropertyMetadata(0.1));

		// Token: 0x04000094 RID: 148
		public static readonly global::System.Windows.DependencyProperty MaximumScaleProperty = global::System.Windows.DependencyProperty.Register("MaximumScale", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Input.TranslateZoomRotateBehavior), new global::System.Windows.PropertyMetadata(10.0));
	}
}
