using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200005D RID: 93
	public class DataGridHeaderBorder : global::System.Windows.Controls.Border
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x0001E308 File Offset: 0x0001C508
		static DataGridHeaderBorder()
		{
			global::Microsoft.Windows.Controls.DataGridHelper.HookThemeChange(typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridHeaderBorder.OnThemeChange));
			global::System.Windows.UIElement.SnapsToDevicePixelsProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(true));
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0001E4F6 File Offset: 0x0001C6F6
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0001E508 File Offset: 0x0001C708
		public bool IsHovered
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.IsHoveredProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.IsHoveredProperty, value);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0001E51B File Offset: 0x0001C71B
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0001E52D File Offset: 0x0001C72D
		public bool IsPressed
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.IsPressedProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.IsPressedProperty, value);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001E540 File Offset: 0x0001C740
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x0001E552 File Offset: 0x0001C752
		public bool IsClickable
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.IsClickableProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.IsClickableProperty, value);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001E565 File Offset: 0x0001C765
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0001E577 File Offset: 0x0001C777
		public global::System.ComponentModel.ListSortDirection? SortDirection
		{
			get
			{
				return (global::System.ComponentModel.ListSortDirection?)base.GetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.SortDirectionProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.SortDirectionProperty, value);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0001E58A File Offset: 0x0001C78A
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0001E59C File Offset: 0x0001C79C
		public bool IsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.IsSelectedProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.IsSelectedProperty, value);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0001E5AF File Offset: 0x0001C7AF
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0001E5C1 File Offset: 0x0001C7C1
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.OrientationProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.OrientationProperty, value);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0001E5D4 File Offset: 0x0001C7D4
		private bool UsingBorderImplementation
		{
			get
			{
				return base.Background != null || base.BorderBrush != null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0001E5EC File Offset: 0x0001C7EC
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x0001E5FE File Offset: 0x0001C7FE
		public global::System.Windows.Media.Brush SeparatorBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.SeparatorBrushProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.SeparatorBrushProperty, value);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0001E60C File Offset: 0x0001C80C
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x0001E61E File Offset: 0x0001C81E
		public global::System.Windows.Visibility SeparatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.SeparatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.SeparatorVisibilityProperty, value);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0001E634 File Offset: 0x0001C834
		private string Theme
		{
			get
			{
				string text = global::Microsoft.Windows.Controls.DataGridHelper.GetTheme(this);
				if (string.IsNullOrEmpty(text))
				{
					text = "Classic";
				}
				return text;
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0001E658 File Offset: 0x0001C858
		private static void OnThemeChange(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridHeaderBorder.ReleaseCache();
			global::Microsoft.Windows.Controls.DataGridHeaderBorder dataGridHeaderBorder = (global::Microsoft.Windows.Controls.DataGridHeaderBorder)d;
			dataGridHeaderBorder.InvalidateMeasure();
			dataGridHeaderBorder.InvalidateArrange();
			dataGridHeaderBorder.InvalidateVisual();
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001E684 File Offset: 0x0001C884
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			if (this.UsingBorderImplementation)
			{
				return base.MeasureOverride(constraint);
			}
			global::System.Windows.UIElement child = this.Child;
			if (child != null)
			{
				global::System.Windows.Thickness thickness = base.Padding;
				if (thickness.Equals(default(global::System.Windows.Thickness)))
				{
					thickness = this.DefaultPadding;
				}
				double num = constraint.Width;
				double num2 = constraint.Height;
				if (!double.IsInfinity(num))
				{
					num = global::System.Math.Max(0.0, num - thickness.Left - thickness.Right);
				}
				if (!double.IsInfinity(num2))
				{
					num2 = global::System.Math.Max(0.0, num2 - thickness.Top - thickness.Bottom);
				}
				child.Measure(new global::System.Windows.Size(num, num2));
				global::System.Windows.Size desiredSize = child.DesiredSize;
				return new global::System.Windows.Size(desiredSize.Width + thickness.Left + thickness.Right, desiredSize.Height + thickness.Top + thickness.Bottom);
			}
			return default(global::System.Windows.Size);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0001E784 File Offset: 0x0001C984
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			if (this.UsingBorderImplementation)
			{
				return base.ArrangeOverride(arrangeSize);
			}
			global::System.Windows.UIElement child = this.Child;
			if (child != null)
			{
				global::System.Windows.Thickness thickness = base.Padding;
				if (thickness.Equals(default(global::System.Windows.Thickness)))
				{
					thickness = this.DefaultPadding;
				}
				double width = global::System.Math.Max(0.0, arrangeSize.Width - thickness.Left - thickness.Right);
				double height = global::System.Math.Max(0.0, arrangeSize.Height - thickness.Top - thickness.Bottom);
				child.Arrange(new global::System.Windows.Rect(thickness.Left, thickness.Top, width, height));
			}
			return arrangeSize;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0001E838 File Offset: 0x0001CA38
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			if (this.UsingBorderImplementation)
			{
				base.OnRender(dc);
				return;
			}
			string theme;
			if ((theme = this.Theme) != null)
			{
				if (theme == "Classic")
				{
					this.RenderClassic(dc);
					return;
				}
				if (theme == "Luna.NormalColor")
				{
					this.RenderLuna(dc, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.NormalColor);
					return;
				}
				if (theme == "Luna.HomeStead")
				{
					this.RenderLuna(dc, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.HomeStead);
					return;
				}
				if (theme == "Luna.Metallic")
				{
					this.RenderLuna(dc, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.Metallic);
					return;
				}
				if (theme == "Royale.NormalColor")
				{
					this.RenderLuna(dc, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.Metallic);
					return;
				}
				if (!(theme == "Aero.NormalColor"))
				{
					return;
				}
				this.RenderAeroNormalColor(dc);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x0001E8E4 File Offset: 0x0001CAE4
		private global::System.Windows.Thickness DefaultPadding
		{
			get
			{
				global::System.Windows.Thickness result = new global::System.Windows.Thickness(3.0);
				if (this.Orientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					if (this.Theme == "Aero.NormalColor")
					{
						result = new global::System.Windows.Thickness(5.0, 4.0, 5.0, 4.0);
					}
					else
					{
						result.Right = 15.0;
					}
				}
				if (this.IsPressed && this.IsClickable)
				{
					result.Left += 1.0;
					result.Top += 1.0;
					result.Right -= 1.0;
					result.Bottom -= 1.0;
				}
				return result;
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001E9C6 File Offset: 0x0001CBC6
		private static double Max0(double d)
		{
			return global::System.Math.Max(0.0, d);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0001E9D8 File Offset: 0x0001CBD8
		private void RenderAeroNormalColor(global::System.Windows.Media.DrawingContext dc)
		{
			global::System.Windows.Size renderSize = base.RenderSize;
			bool flag = this.Orientation == global::System.Windows.Controls.Orientation.Horizontal;
			bool flag2 = this.IsClickable && base.IsEnabled;
			bool flag3 = flag2 && this.IsHovered;
			bool flag4 = flag2 && this.IsPressed;
			global::System.ComponentModel.ListSortDirection? sortDirection = this.SortDirection;
			bool flag5 = sortDirection != null;
			bool isSelected = this.IsSelected;
			bool flag6 = !flag3 && !flag4 && !flag5 && !isSelected;
			global::Microsoft.Windows.Controls.DataGridHeaderBorder.EnsureCache(19);
			if (flag)
			{
				global::System.Windows.Media.Matrix trans = default(global::System.Windows.Media.Matrix);
				trans.RotateAt(-90.0, 0.0, 0.0);
				global::System.Windows.Media.Matrix trans2 = default(global::System.Windows.Media.Matrix);
				trans2.Translate(0.0, renderSize.Height);
				global::System.Windows.Media.MatrixTransform matrixTransform = new global::System.Windows.Media.MatrixTransform(trans * trans2);
				matrixTransform.Freeze();
				dc.PushTransform(matrixTransform);
				double width = renderSize.Width;
				renderSize.Width = renderSize.Height;
				renderSize.Height = width;
			}
			if (flag6)
			{
				global::System.Windows.Media.LinearGradientBrush linearGradientBrush = (global::System.Windows.Media.LinearGradientBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(0);
				if (linearGradientBrush == null)
				{
					linearGradientBrush = new global::System.Windows.Media.LinearGradientBrush();
					linearGradientBrush.StartPoint = default(global::System.Windows.Point);
					linearGradientBrush.EndPoint = new global::System.Windows.Point(0.0, 1.0);
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), 0.0));
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), 0.4));
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 252, 252, 253), 0.4));
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 251, 252, 252), 1.0));
					linearGradientBrush.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(linearGradientBrush, 0);
				}
				dc.DrawRectangle(linearGradientBrush, null, new global::System.Windows.Rect(0.0, 0.0, renderSize.Width, renderSize.Height));
			}
			global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables index = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.NormalBackground;
			if (flag4)
			{
				index = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.PressedBackground;
			}
			else if (flag3)
			{
				index = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.HoveredBackground;
			}
			else if (flag5 || isSelected)
			{
				index = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.SortedBackground;
			}
			global::System.Windows.Media.LinearGradientBrush linearGradientBrush2 = (global::System.Windows.Media.LinearGradientBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable((int)index);
			if (linearGradientBrush2 == null)
			{
				linearGradientBrush2 = new global::System.Windows.Media.LinearGradientBrush();
				linearGradientBrush2.StartPoint = default(global::System.Windows.Point);
				linearGradientBrush2.EndPoint = new global::System.Windows.Point(0.0, 1.0);
				switch (index)
				{
				case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.NormalBackground:
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), 0.0));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), 0.4));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 247, 248, 250), 0.4));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 241, 242, 244), 1.0));
					break;
				case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.PressedBackground:
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 188, 228, 249), 0.0));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 188, 228, 249), 0.4));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 141, 214, 247), 0.4));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 138, 209, 245), 1.0));
					break;
				case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.HoveredBackground:
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 227, 247, byte.MaxValue), 0.0));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 227, 247, byte.MaxValue), 0.4));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 189, 237, byte.MaxValue), 0.4));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 183, 231, 251), 1.0));
					break;
				case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.SortedBackground:
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 242, 249, 252), 0.0));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 242, 249, 252), 0.4));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 225, 241, 249), 0.4));
					linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 216, 236, 246), 1.0));
					break;
				}
				linearGradientBrush2.Freeze();
				global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(linearGradientBrush2, (int)index);
			}
			dc.DrawRectangle(linearGradientBrush2, null, new global::System.Windows.Rect(0.0, 0.0, renderSize.Width, renderSize.Height));
			if (renderSize.Width >= 2.0)
			{
				global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables aeroFreezables = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.NormalSides;
				if (flag4)
				{
					aeroFreezables = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.PressedSides;
				}
				else if (flag3)
				{
					aeroFreezables = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.HoveredSides;
				}
				else if (flag5 || isSelected)
				{
					aeroFreezables = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.SortedSides;
				}
				if (this.SeparatorVisibility == global::System.Windows.Visibility.Visible)
				{
					global::System.Windows.Media.Brush brush;
					if (this.SeparatorBrush != null)
					{
						brush = this.SeparatorBrush;
					}
					else
					{
						brush = (global::System.Windows.Media.Brush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable((int)aeroFreezables);
						if (brush == null)
						{
							global::System.Windows.Media.LinearGradientBrush linearGradientBrush3 = null;
							if (aeroFreezables != global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.SortedSides)
							{
								linearGradientBrush3 = new global::System.Windows.Media.LinearGradientBrush();
								linearGradientBrush3.StartPoint = default(global::System.Windows.Point);
								linearGradientBrush3.EndPoint = new global::System.Windows.Point(0.0, 1.0);
								brush = linearGradientBrush3;
							}
							switch (aeroFreezables)
							{
							case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.NormalSides:
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 242, 242, 242), 0.0));
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 239, 239, 239), 0.4));
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 231, 232, 234), 0.4));
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 222, 223, 225), 1.0));
								break;
							case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.PressedSides:
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 122, 158, 177), 0.0));
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 122, 158, 177), 0.4));
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 80, 145, 175), 0.4));
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 77, 141, 173), 1.0));
								break;
							case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.HoveredSides:
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 136, 203, 235), 0.0));
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 136, 203, 235), 0.4));
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 105, 187, 227), 0.4));
								linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 105, 187, 227), 1.0));
								break;
							case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.SortedSides:
								brush = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 150, 217, 249));
								break;
							}
							brush.Freeze();
							global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(brush, (int)aeroFreezables);
						}
					}
					dc.DrawRectangle(brush, null, new global::System.Windows.Rect(0.0, 0.0, 1.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Height - 0.95)));
					dc.DrawRectangle(brush, null, new global::System.Windows.Rect(renderSize.Width - 1.0, 0.0, 1.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Height - 0.95)));
				}
			}
			if (flag4 && renderSize.Width >= 4.0 && renderSize.Height >= 4.0)
			{
				global::System.Windows.Media.LinearGradientBrush linearGradientBrush4 = (global::System.Windows.Media.LinearGradientBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(5);
				if (linearGradientBrush4 == null)
				{
					linearGradientBrush4 = new global::System.Windows.Media.LinearGradientBrush();
					linearGradientBrush4.StartPoint = default(global::System.Windows.Point);
					linearGradientBrush4.EndPoint = new global::System.Windows.Point(0.0, 1.0);
					linearGradientBrush4.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 134, 163, 178), 0.0));
					linearGradientBrush4.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 134, 163, 178), 0.1));
					linearGradientBrush4.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 170, 206, 225), 0.9));
					linearGradientBrush4.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 170, 206, 225), 1.0));
					linearGradientBrush4.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(linearGradientBrush4, 5);
				}
				dc.DrawRectangle(linearGradientBrush4, null, new global::System.Windows.Rect(0.0, 0.0, renderSize.Width, 2.0));
				global::System.Windows.Media.LinearGradientBrush linearGradientBrush5 = (global::System.Windows.Media.LinearGradientBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(10);
				if (linearGradientBrush5 == null)
				{
					linearGradientBrush5 = new global::System.Windows.Media.LinearGradientBrush();
					linearGradientBrush5.StartPoint = default(global::System.Windows.Point);
					linearGradientBrush5.EndPoint = new global::System.Windows.Point(0.0, 1.0);
					linearGradientBrush5.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 162, 203, 224), 0.0));
					linearGradientBrush5.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 162, 203, 224), 0.4));
					linearGradientBrush5.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 114, 188, 223), 0.4));
					linearGradientBrush5.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 110, 184, 220), 1.0));
					linearGradientBrush5.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(linearGradientBrush5, 10);
				}
				dc.DrawRectangle(linearGradientBrush5, null, new global::System.Windows.Rect(1.0, 0.0, 1.0, renderSize.Height - 0.95));
				dc.DrawRectangle(linearGradientBrush5, null, new global::System.Windows.Rect(renderSize.Width - 2.0, 0.0, 1.0, renderSize.Height - 0.95));
			}
			if (renderSize.Height >= 2.0)
			{
				global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables index2 = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.NormalBottom;
				if (flag4)
				{
					index2 = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.PressedOrHoveredBottom;
				}
				else if (flag3)
				{
					index2 = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.PressedOrHoveredBottom;
				}
				else if (flag5 || isSelected)
				{
					index2 = global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.SortedBottom;
				}
				global::System.Windows.Media.SolidColorBrush solidColorBrush = (global::System.Windows.Media.SolidColorBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable((int)index2);
				if (solidColorBrush == null)
				{
					switch (index2)
					{
					case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.NormalBottom:
						solidColorBrush = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 213, 213, 213));
						break;
					case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.PressedOrHoveredBottom:
						solidColorBrush = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 147, 201, 227));
						break;
					case global::Microsoft.Windows.Controls.DataGridHeaderBorder.AeroFreezables.SortedBottom:
						solidColorBrush = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 150, 217, 249));
						break;
					}
					solidColorBrush.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(solidColorBrush, (int)index2);
				}
				dc.DrawRectangle(solidColorBrush, null, new global::System.Windows.Rect(0.0, renderSize.Height - 1.0, renderSize.Width, 1.0));
			}
			if (flag5 && renderSize.Width > 14.0 && renderSize.Height > 10.0)
			{
				global::System.Windows.Media.TranslateTransform translateTransform = new global::System.Windows.Media.TranslateTransform((renderSize.Width - 8.0) * 0.5, 1.0);
				translateTransform.Freeze();
				dc.PushTransform(translateTransform);
				bool flag7 = sortDirection == global::System.ComponentModel.ListSortDirection.Ascending;
				global::System.Windows.Media.PathGeometry pathGeometry = (global::System.Windows.Media.PathGeometry)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(flag7 ? 17 : 18);
				if (pathGeometry == null)
				{
					pathGeometry = new global::System.Windows.Media.PathGeometry();
					global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure();
					if (flag7)
					{
						pathFigure.StartPoint = new global::System.Windows.Point(0.0, 4.0);
						global::System.Windows.Media.LineSegment lineSegment = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(4.0, 0.0), false);
						lineSegment.Freeze();
						pathFigure.Segments.Add(lineSegment);
						lineSegment = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(8.0, 4.0), false);
						lineSegment.Freeze();
						pathFigure.Segments.Add(lineSegment);
					}
					else
					{
						pathFigure.StartPoint = new global::System.Windows.Point(0.0, 0.0);
						global::System.Windows.Media.LineSegment lineSegment2 = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(8.0, 0.0), false);
						lineSegment2.Freeze();
						pathFigure.Segments.Add(lineSegment2);
						lineSegment2 = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(4.0, 4.0), false);
						lineSegment2.Freeze();
						pathFigure.Segments.Add(lineSegment2);
					}
					pathFigure.IsClosed = true;
					pathFigure.Freeze();
					pathGeometry.Figures.Add(pathFigure);
					pathGeometry.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(pathGeometry, flag7 ? 17 : 18);
				}
				global::System.Windows.Media.LinearGradientBrush linearGradientBrush6 = (global::System.Windows.Media.LinearGradientBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(14);
				if (linearGradientBrush6 == null)
				{
					linearGradientBrush6 = new global::System.Windows.Media.LinearGradientBrush();
					linearGradientBrush6.StartPoint = default(global::System.Windows.Point);
					linearGradientBrush6.EndPoint = new global::System.Windows.Point(1.0, 1.0);
					linearGradientBrush6.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 60, 94, 114), 0.0));
					linearGradientBrush6.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 60, 94, 114), 0.1));
					linearGradientBrush6.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 195, 228, 245), 1.0));
					linearGradientBrush6.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(linearGradientBrush6, 14);
				}
				dc.DrawGeometry(linearGradientBrush6, null, pathGeometry);
				global::System.Windows.Media.LinearGradientBrush linearGradientBrush7 = (global::System.Windows.Media.LinearGradientBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(15);
				if (linearGradientBrush7 == null)
				{
					linearGradientBrush7 = new global::System.Windows.Media.LinearGradientBrush();
					linearGradientBrush7.StartPoint = default(global::System.Windows.Point);
					linearGradientBrush7.EndPoint = new global::System.Windows.Point(1.0, 1.0);
					linearGradientBrush7.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 97, 150, 182), 0.0));
					linearGradientBrush7.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 97, 150, 182), 0.1));
					linearGradientBrush7.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 202, 230, 245), 1.0));
					linearGradientBrush7.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(linearGradientBrush7, 15);
				}
				global::System.Windows.Media.ScaleTransform scaleTransform = (global::System.Windows.Media.ScaleTransform)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(16);
				if (scaleTransform == null)
				{
					scaleTransform = new global::System.Windows.Media.ScaleTransform(0.75, 0.75, 3.5, 4.0);
					scaleTransform.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(scaleTransform, 16);
				}
				dc.PushTransform(scaleTransform);
				dc.DrawGeometry(linearGradientBrush7, null, pathGeometry);
				dc.Pop();
				dc.Pop();
			}
			if (flag)
			{
				dc.Pop();
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		private void RenderLuna(global::System.Windows.Media.DrawingContext dc, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna colorVariant)
		{
			global::System.Windows.Size renderSize = base.RenderSize;
			bool flag = this.Orientation == global::System.Windows.Controls.Orientation.Horizontal;
			bool flag2 = this.IsClickable && base.IsEnabled;
			bool flag3 = flag2 && this.IsHovered;
			bool flag4 = flag2 && this.IsPressed;
			global::System.ComponentModel.ListSortDirection? sortDirection = this.SortDirection;
			bool flag5 = sortDirection != null;
			bool isSelected = this.IsSelected;
			global::Microsoft.Windows.Controls.DataGridHeaderBorder.EnsureCache(12);
			if (flag)
			{
				global::System.Windows.Media.Matrix trans = default(global::System.Windows.Media.Matrix);
				trans.RotateAt(-90.0, 0.0, 0.0);
				global::System.Windows.Media.Matrix trans2 = default(global::System.Windows.Media.Matrix);
				trans2.Translate(0.0, renderSize.Height);
				global::System.Windows.Media.MatrixTransform matrixTransform = new global::System.Windows.Media.MatrixTransform(trans * trans2);
				matrixTransform.Freeze();
				dc.PushTransform(matrixTransform);
				double width = renderSize.Width;
				renderSize.Width = renderSize.Height;
				renderSize.Height = width;
			}
			global::Microsoft.Windows.Controls.DataGridHeaderBorder.LunaFreezables index = flag4 ? global::Microsoft.Windows.Controls.DataGridHeaderBorder.LunaFreezables.PressedBackground : (flag3 ? global::Microsoft.Windows.Controls.DataGridHeaderBorder.LunaFreezables.HoveredBackground : global::Microsoft.Windows.Controls.DataGridHeaderBorder.LunaFreezables.NormalBackground);
			global::System.Windows.Media.LinearGradientBrush linearGradientBrush = (global::System.Windows.Media.LinearGradientBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable((int)index);
			if (linearGradientBrush == null)
			{
				linearGradientBrush = new global::System.Windows.Media.LinearGradientBrush();
				linearGradientBrush.StartPoint = default(global::System.Windows.Point);
				linearGradientBrush.EndPoint = new global::System.Windows.Point(0.0, 1.0);
				if (flag4)
				{
					if (colorVariant == global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.Metallic)
					{
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 185, 185, 200), 0.0));
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 236, 236, 243), 0.1));
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 236, 236, 243), 1.0));
					}
					else
					{
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 193, 194, 184), 0.0));
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 222, 223, 216), 0.1));
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 222, 223, 216), 1.0));
					}
				}
				else if (flag3 || isSelected)
				{
					if (colorVariant == global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.Metallic)
					{
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 254, 254, 254), 0.0));
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 254, 254, 254), 0.85));
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 189, 190, 206), 1.0));
					}
					else
					{
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 250, 249, 244), 0.0));
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 250, 249, 244), 0.85));
						linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 236, 233, 216), 1.0));
					}
				}
				else if (colorVariant == global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.Metallic)
				{
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 249, 250, 253), 0.0));
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 249, 250, 253), 0.85));
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 189, 190, 206), 1.0));
				}
				else
				{
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 235, 234, 219), 0.0));
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 235, 234, 219), 0.85));
					linearGradientBrush.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 203, 199, 184), 1.0));
				}
				linearGradientBrush.Freeze();
				global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(linearGradientBrush, (int)index);
			}
			dc.DrawRectangle(linearGradientBrush, null, new global::System.Windows.Rect(0.0, 0.0, renderSize.Width, renderSize.Height));
			if (flag3 && !flag4 && renderSize.Width >= 6.0 && renderSize.Height >= 4.0)
			{
				global::System.Windows.Media.TranslateTransform translateTransform = new global::System.Windows.Media.TranslateTransform(0.0, renderSize.Height - 3.0);
				translateTransform.Freeze();
				dc.PushTransform(translateTransform);
				global::System.Windows.Media.PathGeometry pathGeometry = new global::System.Windows.Media.PathGeometry();
				global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure();
				pathFigure.StartPoint = new global::System.Windows.Point(0.5, 0.5);
				global::System.Windows.Media.LineSegment lineSegment = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(renderSize.Width - 0.5, 0.5), true);
				lineSegment.Freeze();
				pathFigure.Segments.Add(lineSegment);
				global::System.Windows.Media.ArcSegment arcSegment = new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(renderSize.Width - 2.5, 2.5), new global::System.Windows.Size(2.0, 2.0), 90.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true);
				arcSegment.Freeze();
				pathFigure.Segments.Add(arcSegment);
				lineSegment = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(2.5, 2.5), true);
				lineSegment.Freeze();
				pathFigure.Segments.Add(lineSegment);
				arcSegment = new global::System.Windows.Media.ArcSegment(new global::System.Windows.Point(0.5, 0.5), new global::System.Windows.Size(2.0, 2.0), 90.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true);
				arcSegment.Freeze();
				pathFigure.Segments.Add(arcSegment);
				pathFigure.IsClosed = true;
				pathFigure.Freeze();
				pathGeometry.Figures.Add(pathFigure);
				pathGeometry.Freeze();
				global::System.Windows.Media.Pen pen = (global::System.Windows.Media.Pen)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(7);
				if (pen == null)
				{
					global::System.Windows.Media.SolidColorBrush solidColorBrush = new global::System.Windows.Media.SolidColorBrush((colorVariant == global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.HomeStead) ? global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 207, 114, 37) : global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 248, 169, 0));
					solidColorBrush.Freeze();
					pen = new global::System.Windows.Media.Pen(solidColorBrush, 1.0);
					pen.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(pen, 7);
				}
				global::System.Windows.Media.LinearGradientBrush linearGradientBrush2 = (global::System.Windows.Media.LinearGradientBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(8);
				if (linearGradientBrush2 == null)
				{
					linearGradientBrush2 = new global::System.Windows.Media.LinearGradientBrush();
					linearGradientBrush2.StartPoint = default(global::System.Windows.Point);
					linearGradientBrush2.EndPoint = new global::System.Windows.Point(1.0, 0.0);
					if (colorVariant == global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.HomeStead)
					{
						linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 227, 145, 79), 0.0));
						linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 227, 145, 79), 1.0));
					}
					else
					{
						linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 252, 224, 166), 0.0));
						linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 246, 196, 86), 0.1));
						linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 246, 196, 86), 0.9));
						linearGradientBrush2.GradientStops.Add(new global::System.Windows.Media.GradientStop(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 223, 151, 0), 1.0));
					}
					linearGradientBrush2.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(linearGradientBrush2, 8);
				}
				dc.DrawGeometry(linearGradientBrush2, pen, pathGeometry);
				dc.Pop();
			}
			if (flag4 && renderSize.Width >= 2.0 && renderSize.Height >= 2.0)
			{
				global::System.Windows.Media.SolidColorBrush solidColorBrush2 = (global::System.Windows.Media.SolidColorBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(5);
				if (solidColorBrush2 == null)
				{
					solidColorBrush2 = new global::System.Windows.Media.SolidColorBrush((colorVariant == global::Microsoft.Windows.Controls.DataGridHeaderBorder.Luna.Metallic) ? global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 128, 128, 153) : global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 165, 165, 151));
					solidColorBrush2.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(solidColorBrush2, 5);
				}
				dc.DrawRectangle(solidColorBrush2, null, new global::System.Windows.Rect(0.0, 0.0, 1.0, renderSize.Height));
				dc.DrawRectangle(solidColorBrush2, null, new global::System.Windows.Rect(0.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Height - 1.0), renderSize.Width, 1.0));
			}
			if (!flag4 && !flag3 && renderSize.Width >= 4.0 && this.SeparatorVisibility == global::System.Windows.Visibility.Visible)
			{
				global::System.Windows.Media.Brush brush;
				if (this.SeparatorBrush != null)
				{
					brush = this.SeparatorBrush;
				}
				else
				{
					global::System.Windows.Media.LinearGradientBrush linearGradientBrush3 = (global::System.Windows.Media.LinearGradientBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(flag ? 3 : 4);
					if (linearGradientBrush3 == null)
					{
						linearGradientBrush3 = new global::System.Windows.Media.LinearGradientBrush();
						linearGradientBrush3.StartPoint = default(global::System.Windows.Point);
						linearGradientBrush3.EndPoint = new global::System.Windows.Point(1.0, 0.0);
						global::System.Windows.Media.Color color = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
						global::System.Windows.Media.Color color2 = global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 199, 197, 178);
						if (flag)
						{
							linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(color, 0.0));
							linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(color, 0.25));
							linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(color2, 0.75));
							linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(color2, 1.0));
						}
						else
						{
							linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(color2, 0.0));
							linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(color2, 0.25));
							linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(color, 0.75));
							linearGradientBrush3.GradientStops.Add(new global::System.Windows.Media.GradientStop(color, 1.0));
						}
						linearGradientBrush3.Freeze();
						global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(linearGradientBrush3, flag ? 3 : 4);
					}
					brush = linearGradientBrush3;
				}
				dc.DrawRectangle(brush, null, new global::System.Windows.Rect(flag ? 0.0 : global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Width - 2.0), 4.0, 2.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Height - 8.0)));
			}
			if (flag5 && renderSize.Width > 14.0 && renderSize.Height > 10.0)
			{
				global::System.Windows.Media.TranslateTransform translateTransform2 = new global::System.Windows.Media.TranslateTransform(renderSize.Width - 15.0, (renderSize.Height - 5.0) * 0.5);
				translateTransform2.Freeze();
				dc.PushTransform(translateTransform2);
				bool flag6 = sortDirection == global::System.ComponentModel.ListSortDirection.Ascending;
				global::System.Windows.Media.PathGeometry pathGeometry2 = (global::System.Windows.Media.PathGeometry)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(flag6 ? 10 : 11);
				if (pathGeometry2 == null)
				{
					pathGeometry2 = new global::System.Windows.Media.PathGeometry();
					global::System.Windows.Media.PathFigure pathFigure2 = new global::System.Windows.Media.PathFigure();
					if (flag6)
					{
						pathFigure2.StartPoint = new global::System.Windows.Point(0.0, 5.0);
						global::System.Windows.Media.LineSegment lineSegment2 = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(5.0, 0.0), false);
						lineSegment2.Freeze();
						pathFigure2.Segments.Add(lineSegment2);
						lineSegment2 = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(10.0, 5.0), false);
						lineSegment2.Freeze();
						pathFigure2.Segments.Add(lineSegment2);
					}
					else
					{
						pathFigure2.StartPoint = new global::System.Windows.Point(0.0, 0.0);
						global::System.Windows.Media.LineSegment lineSegment3 = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(10.0, 0.0), false);
						lineSegment3.Freeze();
						pathFigure2.Segments.Add(lineSegment3);
						lineSegment3 = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(5.0, 5.0), false);
						lineSegment3.Freeze();
						pathFigure2.Segments.Add(lineSegment3);
					}
					pathFigure2.IsClosed = true;
					pathFigure2.Freeze();
					pathGeometry2.Figures.Add(pathFigure2);
					pathGeometry2.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(pathGeometry2, flag6 ? 10 : 11);
				}
				global::System.Windows.Media.SolidColorBrush solidColorBrush3 = (global::System.Windows.Media.SolidColorBrush)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(9);
				if (solidColorBrush3 == null)
				{
					solidColorBrush3 = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(byte.MaxValue, 172, 168, 153));
					solidColorBrush3.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(solidColorBrush3, 9);
				}
				dc.DrawGeometry(solidColorBrush3, null, pathGeometry2);
				dc.Pop();
			}
			if (flag)
			{
				dc.Pop();
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00020B73 File Offset: 0x0001ED73
		private global::System.Windows.Media.Brush EnsureControlBrush()
		{
			if (base.ReadLocalValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.ControlBrushProperty) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				base.SetResourceReference(global::Microsoft.Windows.Controls.DataGridHeaderBorder.ControlBrushProperty, global::System.Windows.SystemColors.ControlBrushKey);
			}
			return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Windows.Controls.DataGridHeaderBorder.ControlBrushProperty);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00020BA8 File Offset: 0x0001EDA8
		private void RenderClassic(global::System.Windows.Media.DrawingContext dc)
		{
			global::System.Windows.Size renderSize = base.RenderSize;
			bool flag = this.IsClickable && base.IsEnabled;
			bool flag2 = flag && this.IsPressed;
			global::System.ComponentModel.ListSortDirection? sortDirection = this.SortDirection;
			bool flag3 = sortDirection != null;
			bool flag4 = this.Orientation == global::System.Windows.Controls.Orientation.Horizontal;
			global::System.Windows.Media.Brush brush = this.EnsureControlBrush();
			global::System.Windows.Media.Brush controlLightBrush = global::System.Windows.SystemColors.ControlLightBrush;
			global::System.Windows.Media.Brush controlDarkBrush = global::System.Windows.SystemColors.ControlDarkBrush;
			bool flag5 = true;
			bool flag6 = true;
			bool flag7 = false;
			global::System.Windows.Media.Brush brush2 = null;
			if (!flag4)
			{
				if (this.SeparatorVisibility == global::System.Windows.Visibility.Visible && this.SeparatorBrush != null)
				{
					brush2 = this.SeparatorBrush;
					flag7 = true;
				}
				else
				{
					flag5 = false;
				}
			}
			else
			{
				brush2 = global::System.Windows.SystemColors.ControlDarkDarkBrush;
			}
			global::System.Windows.Media.Brush brush3 = null;
			if (flag4)
			{
				if (this.SeparatorVisibility == global::System.Windows.Visibility.Visible && this.SeparatorBrush != null)
				{
					brush3 = this.SeparatorBrush;
					flag7 = true;
				}
				else
				{
					flag6 = false;
				}
			}
			else
			{
				brush3 = global::System.Windows.SystemColors.ControlDarkDarkBrush;
			}
			global::Microsoft.Windows.Controls.DataGridHeaderBorder.EnsureCache(2);
			dc.DrawRectangle(brush, null, new global::System.Windows.Rect(0.0, 0.0, renderSize.Width, renderSize.Height));
			if (renderSize.Width > 3.0 && renderSize.Height > 3.0)
			{
				if (flag2)
				{
					dc.DrawRectangle(controlDarkBrush, null, new global::System.Windows.Rect(0.0, 0.0, renderSize.Width, 1.0));
					dc.DrawRectangle(controlDarkBrush, null, new global::System.Windows.Rect(0.0, 0.0, 1.0, renderSize.Height));
					dc.DrawRectangle(controlDarkBrush, null, new global::System.Windows.Rect(0.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Height - 1.0), renderSize.Width, 1.0));
					dc.DrawRectangle(controlDarkBrush, null, new global::System.Windows.Rect(global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Width - 1.0), 0.0, 1.0, renderSize.Height));
				}
				else
				{
					dc.DrawRectangle(controlLightBrush, null, new global::System.Windows.Rect(0.0, 0.0, 1.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Height - 1.0)));
					dc.DrawRectangle(controlLightBrush, null, new global::System.Windows.Rect(0.0, 0.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Width - 1.0), 1.0));
					if (flag5)
					{
						if (!flag7)
						{
							dc.DrawRectangle(controlDarkBrush, null, new global::System.Windows.Rect(global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Width - 2.0), 1.0, 1.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Height - 2.0)));
						}
						dc.DrawRectangle(brush2, null, new global::System.Windows.Rect(global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Width - 1.0), 0.0, 1.0, renderSize.Height));
					}
					if (flag6)
					{
						if (!flag7)
						{
							dc.DrawRectangle(controlDarkBrush, null, new global::System.Windows.Rect(1.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Height - 2.0), global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Width - 2.0), 1.0));
						}
						dc.DrawRectangle(brush3, null, new global::System.Windows.Rect(0.0, global::Microsoft.Windows.Controls.DataGridHeaderBorder.Max0(renderSize.Height - 1.0), renderSize.Width, 1.0));
					}
				}
			}
			if (flag3 && renderSize.Width > 14.0 && renderSize.Height > 10.0)
			{
				global::System.Windows.Media.TranslateTransform translateTransform = new global::System.Windows.Media.TranslateTransform(renderSize.Width - 15.0, (renderSize.Height - 5.0) * 0.5);
				translateTransform.Freeze();
				dc.PushTransform(translateTransform);
				bool flag8 = sortDirection == global::System.ComponentModel.ListSortDirection.Ascending;
				global::System.Windows.Media.PathGeometry pathGeometry = (global::System.Windows.Media.PathGeometry)global::Microsoft.Windows.Controls.DataGridHeaderBorder.GetCachedFreezable(flag8 ? 0 : 1);
				if (pathGeometry == null)
				{
					pathGeometry = new global::System.Windows.Media.PathGeometry();
					global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure();
					if (flag8)
					{
						pathFigure.StartPoint = new global::System.Windows.Point(0.0, 5.0);
						global::System.Windows.Media.LineSegment lineSegment = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(5.0, 0.0), false);
						lineSegment.Freeze();
						pathFigure.Segments.Add(lineSegment);
						lineSegment = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(10.0, 5.0), false);
						lineSegment.Freeze();
						pathFigure.Segments.Add(lineSegment);
					}
					else
					{
						pathFigure.StartPoint = new global::System.Windows.Point(0.0, 0.0);
						global::System.Windows.Media.LineSegment lineSegment2 = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(10.0, 0.0), false);
						lineSegment2.Freeze();
						pathFigure.Segments.Add(lineSegment2);
						lineSegment2 = new global::System.Windows.Media.LineSegment(new global::System.Windows.Point(5.0, 5.0), false);
						lineSegment2.Freeze();
						pathFigure.Segments.Add(lineSegment2);
					}
					pathFigure.IsClosed = true;
					pathFigure.Freeze();
					pathGeometry.Figures.Add(pathFigure);
					pathGeometry.Freeze();
					global::Microsoft.Windows.Controls.DataGridHeaderBorder.CacheFreezable(pathGeometry, flag8 ? 0 : 1);
				}
				dc.DrawGeometry(global::System.Windows.SystemColors.GrayTextBrush, null, pathGeometry);
				dc.Pop();
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00021174 File Offset: 0x0001F374
		private static void EnsureCache(int size)
		{
			if (global::Microsoft.Windows.Controls.DataGridHeaderBorder._freezableCache == null)
			{
				lock (global::Microsoft.Windows.Controls.DataGridHeaderBorder._cacheAccess)
				{
					if (global::Microsoft.Windows.Controls.DataGridHeaderBorder._freezableCache == null)
					{
						global::Microsoft.Windows.Controls.DataGridHeaderBorder._freezableCache = new global::System.Collections.Generic.List<global::System.Windows.Freezable>(size);
						for (int i = 0; i < size; i++)
						{
							global::Microsoft.Windows.Controls.DataGridHeaderBorder._freezableCache.Add(null);
						}
					}
				}
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000211D8 File Offset: 0x0001F3D8
		private static void ReleaseCache()
		{
			if (global::Microsoft.Windows.Controls.DataGridHeaderBorder._freezableCache != null)
			{
				lock (global::Microsoft.Windows.Controls.DataGridHeaderBorder._cacheAccess)
				{
					global::Microsoft.Windows.Controls.DataGridHeaderBorder._freezableCache = null;
				}
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00021218 File Offset: 0x0001F418
		private static global::System.Windows.Freezable GetCachedFreezable(int index)
		{
			global::System.Windows.Freezable result;
			lock (global::Microsoft.Windows.Controls.DataGridHeaderBorder._cacheAccess)
			{
				global::System.Windows.Freezable freezable = global::Microsoft.Windows.Controls.DataGridHeaderBorder._freezableCache[index];
				result = freezable;
			}
			return result;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0002125C File Offset: 0x0001F45C
		private static void CacheFreezable(global::System.Windows.Freezable freezable, int index)
		{
			lock (global::Microsoft.Windows.Controls.DataGridHeaderBorder._cacheAccess)
			{
				if (global::Microsoft.Windows.Controls.DataGridHeaderBorder._freezableCache[index] != null)
				{
					global::Microsoft.Windows.Controls.DataGridHeaderBorder._freezableCache[index] = freezable;
				}
			}
		}

		// Token: 0x0400021A RID: 538
		private const string ClassicThemeName = "Classic";

		// Token: 0x0400021B RID: 539
		private const string AeroNormalColorName = "Aero.NormalColor";

		// Token: 0x0400021C RID: 540
		private const string LunaNormalColorName = "Luna.NormalColor";

		// Token: 0x0400021D RID: 541
		private const string LunaHomeSteadName = "Luna.HomeStead";

		// Token: 0x0400021E RID: 542
		private const string LunaMetallicName = "Luna.Metallic";

		// Token: 0x0400021F RID: 543
		private const string RoyaleNormalColorName = "Royale.NormalColor";

		// Token: 0x04000220 RID: 544
		public static readonly global::System.Windows.DependencyProperty IsHoveredProperty = global::System.Windows.DependencyProperty.Register("IsHovered", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));

		// Token: 0x04000221 RID: 545
		public static readonly global::System.Windows.DependencyProperty IsPressedProperty = global::System.Windows.DependencyProperty.Register("IsPressed", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));

		// Token: 0x04000222 RID: 546
		public static readonly global::System.Windows.DependencyProperty IsClickableProperty = global::System.Windows.DependencyProperty.Register("IsClickable", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));

		// Token: 0x04000223 RID: 547
		public static readonly global::System.Windows.DependencyProperty SortDirectionProperty = global::System.Windows.DependencyProperty.Register("SortDirection", typeof(global::System.ComponentModel.ListSortDirection?), typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));

		// Token: 0x04000224 RID: 548
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));

		// Token: 0x04000225 RID: 549
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));

		// Token: 0x04000226 RID: 550
		public static readonly global::System.Windows.DependencyProperty SeparatorBrushProperty = global::System.Windows.DependencyProperty.Register("SeparatorBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000227 RID: 551
		public static readonly global::System.Windows.DependencyProperty SeparatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("SeparatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));

		// Token: 0x04000228 RID: 552
		private static readonly global::System.Windows.DependencyProperty ControlBrushProperty = global::System.Windows.DependencyProperty.Register("ControlBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Microsoft.Windows.Controls.DataGridHeaderBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));

		// Token: 0x04000229 RID: 553
		private static global::System.Collections.Generic.List<global::System.Windows.Freezable> _freezableCache;

		// Token: 0x0400022A RID: 554
		private static object _cacheAccess = new object();

		// Token: 0x0200005E RID: 94
		private enum AeroFreezables
		{
			// Token: 0x0400022C RID: 556
			NormalBevel,
			// Token: 0x0400022D RID: 557
			NormalBackground,
			// Token: 0x0400022E RID: 558
			PressedBackground,
			// Token: 0x0400022F RID: 559
			HoveredBackground,
			// Token: 0x04000230 RID: 560
			SortedBackground,
			// Token: 0x04000231 RID: 561
			PressedTop,
			// Token: 0x04000232 RID: 562
			NormalSides,
			// Token: 0x04000233 RID: 563
			PressedSides,
			// Token: 0x04000234 RID: 564
			HoveredSides,
			// Token: 0x04000235 RID: 565
			SortedSides,
			// Token: 0x04000236 RID: 566
			PressedBevel,
			// Token: 0x04000237 RID: 567
			NormalBottom,
			// Token: 0x04000238 RID: 568
			PressedOrHoveredBottom,
			// Token: 0x04000239 RID: 569
			SortedBottom,
			// Token: 0x0400023A RID: 570
			ArrowBorder,
			// Token: 0x0400023B RID: 571
			ArrowFill,
			// Token: 0x0400023C RID: 572
			ArrowFillScale,
			// Token: 0x0400023D RID: 573
			ArrowUpGeometry,
			// Token: 0x0400023E RID: 574
			ArrowDownGeometry,
			// Token: 0x0400023F RID: 575
			NumFreezables
		}

		// Token: 0x0200005F RID: 95
		private enum Luna
		{
			// Token: 0x04000241 RID: 577
			NormalColor,
			// Token: 0x04000242 RID: 578
			HomeStead,
			// Token: 0x04000243 RID: 579
			Metallic
		}

		// Token: 0x02000060 RID: 96
		private enum LunaFreezables
		{
			// Token: 0x04000245 RID: 581
			NormalBackground,
			// Token: 0x04000246 RID: 582
			HoveredBackground,
			// Token: 0x04000247 RID: 583
			PressedBackground,
			// Token: 0x04000248 RID: 584
			HorizontalGripper,
			// Token: 0x04000249 RID: 585
			VerticalGripper,
			// Token: 0x0400024A RID: 586
			PressedBorder,
			// Token: 0x0400024B RID: 587
			TabGeometry,
			// Token: 0x0400024C RID: 588
			TabStroke,
			// Token: 0x0400024D RID: 589
			TabFill,
			// Token: 0x0400024E RID: 590
			ArrowFill,
			// Token: 0x0400024F RID: 591
			ArrowUpGeometry,
			// Token: 0x04000250 RID: 592
			ArrowDownGeometry,
			// Token: 0x04000251 RID: 593
			NumFreezables
		}

		// Token: 0x02000061 RID: 97
		private enum ClassicFreezables
		{
			// Token: 0x04000253 RID: 595
			ArrowUpGeometry,
			// Token: 0x04000254 RID: 596
			ArrowDownGeometry,
			// Token: 0x04000255 RID: 597
			NumFreezables
		}
	}
}
