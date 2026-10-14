using System;
using System.Windows.Media;

namespace System.Windows.Controls.Primitives
{
	// Token: 0x0200001E RID: 30
	public class LinearClipper : global::System.Windows.Controls.Primitives.Clipper
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000070EF File Offset: 0x000052EF
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00007101 File Offset: 0x00005301
		public global::System.Windows.Controls.ExpandDirection ExpandDirection
		{
			get
			{
				return (global::System.Windows.Controls.ExpandDirection)base.GetValue(global::System.Windows.Controls.Primitives.LinearClipper.ExpandDirectionProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Primitives.LinearClipper.ExpandDirectionProperty, value);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00007114 File Offset: 0x00005314
		private static void OnExpandDirectionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.LinearClipper linearClipper = (global::System.Windows.Controls.Primitives.LinearClipper)d;
			global::System.Windows.Controls.ExpandDirection oldValue = (global::System.Windows.Controls.ExpandDirection)e.OldValue;
			global::System.Windows.Controls.ExpandDirection newValue = (global::System.Windows.Controls.ExpandDirection)e.NewValue;
			linearClipper.OnExpandDirectionChanged(oldValue, newValue);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000714A File Offset: 0x0000534A
		protected virtual void OnExpandDirectionChanged(global::System.Windows.Controls.ExpandDirection oldValue, global::System.Windows.Controls.ExpandDirection newValue)
		{
			this.ClipContent();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00007154 File Offset: 0x00005354
		protected override void ClipContent()
		{
			if (this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Right)
			{
				double width = base.RenderSize.Width * base.RatioVisible;
				base.Clip = new global::System.Windows.Media.RectangleGeometry
				{
					Rect = new global::System.Windows.Rect(0.0, 0.0, width, base.RenderSize.Height)
				};
				return;
			}
			if (this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Left)
			{
				double num = base.RenderSize.Width * base.RatioVisible;
				double x = base.RenderSize.Width - num;
				base.Clip = new global::System.Windows.Media.RectangleGeometry
				{
					Rect = new global::System.Windows.Rect(x, 0.0, num, base.RenderSize.Height)
				};
				return;
			}
			if (this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Up)
			{
				double num2 = base.RenderSize.Height * base.RatioVisible;
				double y = base.RenderSize.Height - num2;
				base.Clip = new global::System.Windows.Media.RectangleGeometry
				{
					Rect = new global::System.Windows.Rect(0.0, y, base.RenderSize.Width, num2)
				};
				return;
			}
			if (this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Down)
			{
				double height = base.RenderSize.Height * base.RatioVisible;
				base.Clip = new global::System.Windows.Media.RectangleGeometry
				{
					Rect = new global::System.Windows.Rect(0.0, 0.0, base.RenderSize.Width, height)
				};
			}
		}

		// Token: 0x040000C0 RID: 192
		public static readonly global::System.Windows.DependencyProperty ExpandDirectionProperty = global::System.Windows.DependencyProperty.Register("ExpandDirection", typeof(global::System.Windows.Controls.ExpandDirection), typeof(global::System.Windows.Controls.Primitives.LinearClipper), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.ExpandDirection.Right, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Primitives.LinearClipper.OnExpandDirectionChanged)));
	}
}
