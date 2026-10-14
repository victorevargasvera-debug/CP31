using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000014 RID: 20
	internal abstract class VisualElement : global::System.Windows.DependencyObject
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00006382 File Offset: 0x00004582
		protected VisualElement()
		{
			this.StrokeDashArray = new global::System.Windows.Media.DoubleCollection();
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00006395 File Offset: 0x00004595
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000063A7 File Offset: 0x000045A7
		public global::System.Windows.Rect Bounds
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.VisualElement.BoundsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.BoundsProperty, value);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000063BA File Offset: 0x000045BA
		private static void OnBoundsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnBoundsChanged((global::System.Windows.Rect)e.OldValue, (global::System.Windows.Rect)e.NewValue);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000063E0 File Offset: 0x000045E0
		protected virtual void OnBoundsChanged(global::System.Windows.Rect oldValue, global::System.Windows.Rect newValue)
		{
			this.ChangingBounds = true;
			if (this.X != newValue.X)
			{
				this.X = newValue.X;
			}
			if (this.Y != newValue.Y)
			{
				this.Y = newValue.Y;
			}
			if (this.Width != newValue.Width)
			{
				this.Width = newValue.Width;
			}
			if (this.Height != newValue.Height)
			{
				this.Height = newValue.Height;
			}
			this.ChangingBounds = false;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000646B File Offset: 0x0000466B
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00006473 File Offset: 0x00004673
		private bool ChangingBounds
		{
			get
			{
				return this._changingBounds;
			}
			set
			{
				this._changingBounds = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000647C File Offset: 0x0000467C
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000648E File Offset: 0x0000468E
		public int ZIndex
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.VisualElement.ZIndexProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.ZIndexProperty, value);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000064A1 File Offset: 0x000046A1
		private static void OnZIndexChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnZIndexChanged((int)e.OldValue, (int)e.NewValue);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000064C6 File Offset: 0x000046C6
		protected virtual void OnZIndexChanged(int oldValue, int newValue)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000064C8 File Offset: 0x000046C8
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000064DA File Offset: 0x000046DA
		public global::System.Windows.Visibility Visibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.VisualElement.VisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.VisibilityProperty, value);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000064ED File Offset: 0x000046ED
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnVisibilityChanged((global::System.Windows.Visibility)e.OldValue, (global::System.Windows.Visibility)e.NewValue);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006512 File Offset: 0x00004712
		protected virtual void OnVisibilityChanged(global::System.Windows.Visibility oldValue, global::System.Windows.Visibility newValue)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00006514 File Offset: 0x00004714
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00006526 File Offset: 0x00004726
		public double X
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.VisualElement.XProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.XProperty, value);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006539 File Offset: 0x00004739
		private static void OnXChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnXChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006560 File Offset: 0x00004760
		protected virtual void OnXChanged(double oldValue, double newValue)
		{
			if (!this.ChangingBounds)
			{
				this.Bounds = new global::System.Windows.Rect(newValue, this.Bounds.Y, this.Bounds.Width, this.Bounds.Height);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000065AB File Offset: 0x000047AB
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000065BD File Offset: 0x000047BD
		public double Y
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.VisualElement.YProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.YProperty, value);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000065D0 File Offset: 0x000047D0
		private static void OnYChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnYChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000065F8 File Offset: 0x000047F8
		protected virtual void OnYChanged(double oldValue, double newValue)
		{
			if (!this.ChangingBounds)
			{
				this.Bounds = new global::System.Windows.Rect(this.Bounds.X, newValue, this.Bounds.Width, this.Bounds.Height);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00006643 File Offset: 0x00004843
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00006655 File Offset: 0x00004855
		public double Width
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.VisualElement.WidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.WidthProperty, value);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006668 File Offset: 0x00004868
		private static void OnWidthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnWidthChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006690 File Offset: 0x00004890
		protected virtual void OnWidthChanged(double oldValue, double newValue)
		{
			if (!this.ChangingBounds)
			{
				this.Bounds = new global::System.Windows.Rect(this.Bounds.X, this.Bounds.Y, newValue, this.Bounds.Height);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000066DB File Offset: 0x000048DB
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000066ED File Offset: 0x000048ED
		public double Height
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.VisualElement.HeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.HeightProperty, value);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006700 File Offset: 0x00004900
		private static void OnHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnHeightChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006728 File Offset: 0x00004928
		protected virtual void OnHeightChanged(double oldValue, double newValue)
		{
			if (!this.ChangingBounds)
			{
				this.Bounds = new global::System.Windows.Rect(this.Bounds.X, this.Bounds.Y, this.Bounds.Width, newValue);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00006774 File Offset: 0x00004974
		public double Left
		{
			get
			{
				return this.Bounds.Left;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00006790 File Offset: 0x00004990
		public double Top
		{
			get
			{
				return this.Bounds.Top;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000067AC File Offset: 0x000049AC
		public double Right
		{
			get
			{
				return this.Bounds.Right;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000067C8 File Offset: 0x000049C8
		public double Bottom
		{
			get
			{
				return this.Bounds.Bottom;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000067E4 File Offset: 0x000049E4
		public global::System.Windows.Point Center
		{
			get
			{
				global::System.Windows.Point result = new global::System.Windows.Point(this.X + this.Width / 2.0, this.Y + this.Height / 2.0);
				return result;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00006827 File Offset: 0x00004A27
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00006839 File Offset: 0x00004A39
		public global::System.Windows.Media.Brush Fill
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.VisualElement.FillProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.FillProperty, value);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006847 File Offset: 0x00004A47
		private static void OnFillChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnFillChanged((global::System.Windows.Media.Brush)e.OldValue, (global::System.Windows.Media.Brush)e.NewValue);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000686C File Offset: 0x00004A6C
		protected virtual void OnFillChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000686E File Offset: 0x00004A6E
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00006880 File Offset: 0x00004A80
		public global::System.Windows.Media.Brush Stroke
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.VisualElement.StrokeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.StrokeProperty, value);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000688E File Offset: 0x00004A8E
		private static void OnStrokeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnStrokeChanged((global::System.Windows.Media.Brush)e.OldValue, (global::System.Windows.Media.Brush)e.NewValue);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000068B3 File Offset: 0x00004AB3
		protected virtual void OnStrokeChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000068B5 File Offset: 0x00004AB5
		// (set) Token: 0x060000CE RID: 206 RVA: 0x000068C7 File Offset: 0x00004AC7
		public double StrokeThickness
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.VisualElement.StrokeThicknessProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.StrokeThicknessProperty, value);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000068DA File Offset: 0x00004ADA
		private static void OnStrokeThicknessChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnStrokeThicknessChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000068FF File Offset: 0x00004AFF
		protected virtual void OnStrokeThicknessChanged(double oldValue, double newValue)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00006901 File Offset: 0x00004B01
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00006913 File Offset: 0x00004B13
		public global::System.Windows.Media.DoubleCollection StrokeDashArray
		{
			get
			{
				return (global::System.Windows.Media.DoubleCollection)base.GetValue(global::Infragistics.VisualElement.StrokeDashArrayProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.VisualElement.StrokeDashArrayProperty, value);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006921 File Offset: 0x00004B21
		private static void OnStrokeDashArrayChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.VisualElement)d).OnStrokeDashArrayChanged((global::System.Windows.Media.DoubleCollection)e.OldValue, (global::System.Windows.Media.DoubleCollection)e.NewValue);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006946 File Offset: 0x00004B46
		private void OnStrokeDashArrayChanged(global::System.Windows.Media.DoubleCollection oldValue, global::System.Windows.Media.DoubleCollection newValue)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00006948 File Offset: 0x00004B48
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00006950 File Offset: 0x00004B50
		public bool Initializing { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00006959 File Offset: 0x00004B59
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00006961 File Offset: 0x00004B61
		public virtual global::Infragistics.InteractiveControl View
		{
			get
			{
				return this._view;
			}
			protected set
			{
				this._view = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000696A File Offset: 0x00004B6A
		protected global::System.Windows.Controls.Canvas Canvas
		{
			get
			{
				return this.View.Canvas;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006977 File Offset: 0x00004B77
		internal virtual void SetView(global::Infragistics.InteractiveControl view)
		{
			this.View = view;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006980 File Offset: 0x00004B80
		public virtual bool HitTest(global::System.Windows.Point point)
		{
			return this.Bounds.Contains(point);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000699C File Offset: 0x00004B9C
		public virtual bool HitTest(global::System.Windows.Rect rect)
		{
			return rect.X <= this.Bounds.X && rect.Y <= this.Bounds.Y && rect.Right >= this.Bounds.Right && rect.Bottom >= this.Bounds.Bottom;
		}

		// Token: 0x060000DD RID: 221
		public abstract void Render();

		// Token: 0x060000DE RID: 222
		public abstract void Remove();

		// Token: 0x04000050 RID: 80
		public static readonly global::System.Windows.DependencyProperty BoundsProperty = global::System.Windows.DependencyProperty.Register("Bounds", typeof(global::System.Windows.Rect), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(new global::System.Windows.Rect(0.0, 0.0, 0.0, 0.0), new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnBoundsChanged)));

		// Token: 0x04000051 RID: 81
		private bool _changingBounds;

		// Token: 0x04000052 RID: 82
		public static readonly global::System.Windows.DependencyProperty ZIndexProperty = global::System.Windows.DependencyProperty.Register("ZIndex", typeof(int), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnZIndexChanged)));

		// Token: 0x04000053 RID: 83
		public static readonly global::System.Windows.DependencyProperty VisibilityProperty = global::System.Windows.DependencyProperty.Register("Visibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Visible, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnVisibilityChanged)));

		// Token: 0x04000054 RID: 84
		public static readonly global::System.Windows.DependencyProperty XProperty = global::System.Windows.DependencyProperty.Register("X", typeof(double), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnXChanged)));

		// Token: 0x04000055 RID: 85
		public static readonly global::System.Windows.DependencyProperty YProperty = global::System.Windows.DependencyProperty.Register("Y", typeof(double), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnYChanged)));

		// Token: 0x04000056 RID: 86
		public static readonly global::System.Windows.DependencyProperty WidthProperty = global::System.Windows.DependencyProperty.Register("Width", typeof(double), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnWidthChanged)));

		// Token: 0x04000057 RID: 87
		public static readonly global::System.Windows.DependencyProperty HeightProperty = global::System.Windows.DependencyProperty.Register("Height", typeof(double), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnHeightChanged)));

		// Token: 0x04000058 RID: 88
		public static readonly global::System.Windows.DependencyProperty FillProperty = global::System.Windows.DependencyProperty.Register("Fill", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnFillChanged)));

		// Token: 0x04000059 RID: 89
		public static readonly global::System.Windows.DependencyProperty StrokeProperty = global::System.Windows.DependencyProperty.Register("Stroke", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnStrokeChanged)));

		// Token: 0x0400005A RID: 90
		public static readonly global::System.Windows.DependencyProperty StrokeThicknessProperty = global::System.Windows.DependencyProperty.Register("StrokeThickness", typeof(double), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnStrokeThicknessChanged)));

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Windows.DependencyProperty StrokeDashArrayProperty = global::System.Windows.DependencyProperty.Register("StrokeDashArray", typeof(global::System.Windows.Media.DoubleCollection), typeof(global::Infragistics.VisualElement), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.VisualElement.OnStrokeDashArrayChanged)));

		// Token: 0x0400005C RID: 92
		private global::Infragistics.InteractiveControl _view;
	}
}
