using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000016 RID: 22
	internal abstract class Groupable : global::Infragistics.InteractiveElement
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00006DB8 File Offset: 0x00004FB8
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00006DCA File Offset: 0x00004FCA
		public bool AutoRescales
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Groupable.AutoRescalesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Groupable.AutoRescalesProperty, value);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00006DDD File Offset: 0x00004FDD
		private static void OnAutoRescalesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Groupable)d).OnAutoRescalesChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006E02 File Offset: 0x00005002
		protected virtual void OnAutoRescalesChanged(bool oldValue, bool newValue)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00006E04 File Offset: 0x00005004
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00006E16 File Offset: 0x00005016
		public global::System.Windows.HorizontalAlignment HorizontalAlignment
		{
			get
			{
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::Infragistics.Groupable.HorizontalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Groupable.HorizontalAlignmentProperty, value);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006E29 File Offset: 0x00005029
		private static void OnHorizontalAlignmentChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Groupable)d).OnHorizontalAlignmentChanged((global::System.Windows.HorizontalAlignment)e.OldValue, (global::System.Windows.HorizontalAlignment)e.NewValue);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006E4E File Offset: 0x0000504E
		protected virtual void OnHorizontalAlignmentChanged(global::System.Windows.HorizontalAlignment oldValue, global::System.Windows.HorizontalAlignment newValue)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00006E50 File Offset: 0x00005050
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00006E62 File Offset: 0x00005062
		public global::System.Windows.VerticalAlignment VerticalAlignment
		{
			get
			{
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::Infragistics.Groupable.VerticalAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Groupable.VerticalAlignmentProperty, value);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00006E75 File Offset: 0x00005075
		private static void OnVerticalAlignmentChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Groupable)d).OnVerticalAlignmentChanged((global::System.Windows.VerticalAlignment)e.OldValue, (global::System.Windows.VerticalAlignment)e.NewValue);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006E9A File Offset: 0x0000509A
		protected virtual void OnVerticalAlignmentChanged(global::System.Windows.VerticalAlignment oldValue, global::System.Windows.VerticalAlignment newValue)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00006E9C File Offset: 0x0000509C
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00006EAE File Offset: 0x000050AE
		public global::System.Windows.Thickness Margin
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Groupable.MarginProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Groupable.MarginProperty, value);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006EC1 File Offset: 0x000050C1
		private static void OnMarginChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Groupable)d).OnMarginChanged((global::System.Windows.Thickness)e.OldValue, (global::System.Windows.Thickness)e.NewValue);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00006EE6 File Offset: 0x000050E6
		protected virtual void OnMarginChanged(global::System.Windows.Thickness oldValue, global::System.Windows.Thickness newValue)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00006EE8 File Offset: 0x000050E8
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00006EF0 File Offset: 0x000050F0
		public global::Infragistics.Group Parent
		{
			get
			{
				return this._parent;
			}
			internal set
			{
				this._parent = value;
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00006EF9 File Offset: 0x000050F9
		public virtual void ArrangeInGroup(global::System.Windows.Rect oldGroupBounds, global::System.Windows.Rect newGroupBounds, global::System.Windows.Media.Transform groupTransform)
		{
			if (this.AutoRescales)
			{
				this.TransformBounds(groupTransform);
				return;
			}
			this.ArrangeRelative(oldGroupBounds, newGroupBounds);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006F14 File Offset: 0x00005114
		protected static global::System.Windows.Rect TransformRect(global::System.Windows.Media.GeneralTransform transform, global::System.Windows.Rect rect)
		{
			global::System.Windows.Point point = transform.Transform(new global::System.Windows.Point(rect.X, rect.Y));
			global::System.Windows.Point point2 = transform.Transform(new global::System.Windows.Point(rect.Right, rect.Bottom));
			return new global::System.Windows.Rect(point, point2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006F5C File Offset: 0x0000515C
		protected static global::System.Windows.Media.TranslateTransform CalculateTranslateTransform(global::System.Windows.Rect newBounds, global::System.Windows.Rect oldBounds)
		{
			global::System.Windows.Media.TranslateTransform translateTransform = new global::System.Windows.Media.TranslateTransform();
			if (newBounds.IsEmpty || oldBounds.IsEmpty)
			{
				return translateTransform;
			}
			double x = newBounds.X - oldBounds.X;
			double y = newBounds.Y - oldBounds.Y;
			translateTransform.X = x;
			translateTransform.Y = y;
			return translateTransform;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006FB4 File Offset: 0x000051B4
		protected static global::System.Windows.Media.ScaleTransform CalculateScaleTransform(global::System.Windows.Rect newBounds, global::System.Windows.Rect oldBounds)
		{
			global::System.Windows.Media.ScaleTransform scaleTransform = new global::System.Windows.Media.ScaleTransform();
			if (oldBounds.Width == 0.0 || oldBounds.Height == 0.0 || newBounds.Width == 0.0 || newBounds.Height == 0.0 || oldBounds.IsEmpty || newBounds.IsEmpty)
			{
				return scaleTransform;
			}
			scaleTransform.CenterX = oldBounds.X;
			scaleTransform.CenterY = oldBounds.Y;
			double scaleX = newBounds.Width / oldBounds.Width;
			double scaleY = newBounds.Height / oldBounds.Height;
			scaleTransform.ScaleX = scaleX;
			scaleTransform.ScaleY = scaleY;
			return scaleTransform;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000706C File Offset: 0x0000526C
		protected static global::System.Windows.Media.TransformGroup CalculateTransform(global::System.Windows.Rect newBounds, global::System.Windows.Rect oldBounds)
		{
			global::System.Windows.Media.TransformGroup transformGroup = new global::System.Windows.Media.TransformGroup();
			global::System.Windows.Media.ScaleTransform value = global::Infragistics.Groupable.CalculateScaleTransform(newBounds, oldBounds);
			transformGroup.Children.Add(value);
			global::System.Windows.Media.TranslateTransform value2 = global::Infragistics.Groupable.CalculateTranslateTransform(newBounds, oldBounds);
			transformGroup.Children.Add(value2);
			return transformGroup;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000070A8 File Offset: 0x000052A8
		public virtual void TransformBounds(global::System.Windows.Media.Transform transform)
		{
			base.Bounds = global::Infragistics.Groupable.TransformRect(transform, base.Bounds);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000070BC File Offset: 0x000052BC
		public virtual void ArrangeRelative(global::System.Windows.Rect oldGroupBounds, global::System.Windows.Rect newGroupBounds)
		{
			global::System.Windows.Rect bounds = base.Bounds;
			global::System.Windows.Thickness margin = this.Margin;
			switch (this.HorizontalAlignment)
			{
			case global::System.Windows.HorizontalAlignment.Left:
				bounds.X = newGroupBounds.X + margin.Left;
				break;
			case global::System.Windows.HorizontalAlignment.Center:
				bounds.X = newGroupBounds.X + (newGroupBounds.Width - bounds.Width) / 2.0;
				break;
			case global::System.Windows.HorizontalAlignment.Right:
				bounds.X = newGroupBounds.Right - bounds.Width - margin.Right;
				break;
			case global::System.Windows.HorizontalAlignment.Stretch:
				bounds.X = newGroupBounds.X + margin.Left;
				bounds.Width = newGroupBounds.Width - margin.Left - margin.Left;
				break;
			}
			switch (this.VerticalAlignment)
			{
			case global::System.Windows.VerticalAlignment.Top:
				bounds.Y = newGroupBounds.Y + margin.Top;
				break;
			case global::System.Windows.VerticalAlignment.Center:
				bounds.Y = newGroupBounds.Y + (newGroupBounds.Height - bounds.Height) / 2.0;
				break;
			case global::System.Windows.VerticalAlignment.Bottom:
				bounds.Y = newGroupBounds.Bottom - bounds.Height - margin.Bottom;
				break;
			case global::System.Windows.VerticalAlignment.Stretch:
				bounds.Y = newGroupBounds.Y + margin.Top;
				bounds.Height = newGroupBounds.Height - margin.Top - margin.Bottom;
				break;
			}
			base.Bounds = bounds;
		}

		// Token: 0x04000061 RID: 97
		public static readonly global::System.Windows.DependencyProperty AutoRescalesProperty = global::System.Windows.DependencyProperty.Register("AutoRescales", typeof(bool), typeof(global::Infragistics.Groupable), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Groupable.OnAutoRescalesChanged)));

		// Token: 0x04000062 RID: 98
		public static readonly global::System.Windows.DependencyProperty HorizontalAlignmentProperty = global::System.Windows.DependencyProperty.Register("HorizontalAlignment", typeof(global::System.Windows.HorizontalAlignment), typeof(global::Infragistics.Groupable), new global::System.Windows.PropertyMetadata(global::System.Windows.HorizontalAlignment.Left, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Groupable.OnHorizontalAlignmentChanged)));

		// Token: 0x04000063 RID: 99
		public static readonly global::System.Windows.DependencyProperty VerticalAlignmentProperty = global::System.Windows.DependencyProperty.Register("VerticalAlignment", typeof(global::System.Windows.VerticalAlignment), typeof(global::Infragistics.Groupable), new global::System.Windows.PropertyMetadata(global::System.Windows.VerticalAlignment.Top, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Groupable.OnVerticalAlignmentChanged)));

		// Token: 0x04000064 RID: 100
		public static readonly global::System.Windows.DependencyProperty MarginProperty = global::System.Windows.DependencyProperty.Register("Margin", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Groupable), new global::System.Windows.PropertyMetadata(default(global::System.Windows.Thickness), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Groupable.OnMarginChanged)));

		// Token: 0x04000065 RID: 101
		private global::Infragistics.Group _parent;
	}
}
