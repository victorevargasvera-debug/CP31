using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.AutomationPeers;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls
{
	// Token: 0x02000012 RID: 18
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDock", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	public class XamDock : global::System.Windows.Controls.Panel
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00004ED0 File Offset: 0x000030D0
		public XamDock()
		{
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.XamDock), this);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004EE9 File Offset: 0x000030E9
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00004EFB File Offset: 0x000030FB
		public global::Infragistics.Controls.LayoutPriority LayoutPriority
		{
			get
			{
				return (global::Infragistics.Controls.LayoutPriority)base.GetValue(global::Infragistics.Controls.XamDock.LayoutPriorityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.XamDock.LayoutPriorityProperty, value);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004F0E File Offset: 0x0000310E
		public static void SetEdge(global::System.Windows.DependencyObject d, global::Infragistics.Controls.DockEdge dockEdge)
		{
			d.SetValue(global::Infragistics.Controls.XamDock.EdgeProperty, dockEdge);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004F21 File Offset: 0x00003121
		public static global::Infragistics.Controls.DockEdge GetEdge(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Controls.DockEdge)d.GetValue(global::Infragistics.Controls.XamDock.EdgeProperty);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004F34 File Offset: 0x00003134
		private static void HandlePropertyChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.XamDock xamDock = global::System.Windows.Media.VisualTreeHelper.GetParent(sender) as global::Infragistics.Controls.XamDock;
			if (xamDock != null)
			{
				xamDock.InvalidateMeasure();
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004F58 File Offset: 0x00003158
		private void MeasureToFit(global::System.Windows.UIElement element, global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size size = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
			if (global::Infragistics.Controls.XamDock.GetEdge(element) == global::Infragistics.Controls.DockEdge.Central)
			{
				element.Measure(availableSize);
				global::System.Windows.Size desiredSize = element.DesiredSize;
				element.Measure(size);
				global::System.Windows.Size desiredSize2 = element.DesiredSize;
				global::System.Windows.Size availableSize2;
				if (desiredSize.Height >= desiredSize2.Height && desiredSize.Width >= desiredSize2.Width && desiredSize.Width <= availableSize.Width && desiredSize.Height <= availableSize.Height)
				{
					availableSize2 = availableSize;
				}
				else
				{
					availableSize2 = size;
				}
				element.Measure(availableSize2);
			}
			else
			{
				element.Measure(size);
			}
			if (element.DesiredSize.Width > availableSize.Width && element.DesiredSize.Height < availableSize.Height)
			{
				element.Measure(new global::System.Windows.Size(availableSize.Width, double.PositiveInfinity));
				if (element.DesiredSize.Width > availableSize.Width || element.DesiredSize.Height > availableSize.Height)
				{
					element.Measure(size);
					return;
				}
			}
			else if (element.DesiredSize.Height > availableSize.Height && element.DesiredSize.Width < availableSize.Width)
			{
				element.Measure(new global::System.Windows.Size(double.PositiveInfinity, availableSize.Height));
				if (element.DesiredSize.Width > availableSize.Width || element.DesiredSize.Height > availableSize.Height)
				{
					element.Measure(size);
					return;
				}
			}
			else if (element.DesiredSize.Height > availableSize.Height && element.DesiredSize.Width > availableSize.Width)
			{
				element.Measure(availableSize);
				if (element.DesiredSize.Width > availableSize.Width || element.DesiredSize.Height > availableSize.Height)
				{
					element.Measure(size);
				}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005170 File Offset: 0x00003370
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Collections.Generic.List<global::System.Windows.UIElement>[] array = this.ByEdge(base.Children);
			double[,] array2 = new double[4, 4];
			double[,] array3 = new double[4, 4];
			double[] array4 = new double[4];
			double[] array5 = new double[4];
			for (int i = 0; i < 4; i++)
			{
				foreach (global::System.Windows.UIElement uielement in array[i])
				{
					this.MeasureToFit(uielement, availableSize);
					if (i % 2 == 0)
					{
						int num = (int)global::Infragistics.Controls.XamDock.GetVerticalDockAlignment(uielement);
						array3[i, num] += uielement.DesiredSize.Height;
						num = (int)global::Infragistics.Controls.XamDock.GetHorizontalDockAlignment(uielement);
						array2[i, num] = global::System.Math.Max(array2[i, num], uielement.DesiredSize.Width);
					}
					else
					{
						int num = (int)global::Infragistics.Controls.XamDock.GetVerticalDockAlignment(uielement);
						array3[i, num] = global::System.Math.Max(array3[i, num], uielement.DesiredSize.Height);
						num = (int)global::Infragistics.Controls.XamDock.GetHorizontalDockAlignment(uielement);
						array2[i, num] += uielement.DesiredSize.Width;
					}
				}
				if (i % 2 == 1)
				{
					array5[i] = global::System.Math.Max(global::System.Math.Max(array3[i, 0], array3[i, 1]), array3[i, 2] + array3[i, 3]);
					array4[i] = array2[i, 0] + array2[i, 1] + array2[i, 2];
					if (array2[i, 1] > 0.0)
					{
						array4[i] = global::System.Math.Max(array2[i, 0] * 2.0 + array2[i, 1], array2[i, 2] * 2.0 + array2[i, 1]);
					}
				}
				else
				{
					array4[i] = global::System.Math.Max(global::System.Math.Max(array2[i, 0], array2[i, 1]), array2[i, 2]);
					array5[i] = array3[i, 0] + array3[i, 1] + array3[i, 2] + array3[i, 3];
					if (array3[i, 1] > 0.0)
					{
						array5[i] = global::System.Math.Max(array3[i, 0] * 2.0 + array3[i, 1], array3[i, 2] * 2.0 + array3[i, 1]);
					}
				}
			}
			if (this.LayoutPriority == global::Infragistics.Controls.LayoutPriority.TopAndBottom)
			{
				double num2 = array5[1] + array5[3];
				array5[0] += num2;
				array5[2] += num2;
			}
			else if (this.LayoutPriority == global::Infragistics.Controls.LayoutPriority.LeftAndRight)
			{
				double num3 = array4[0] + array4[2];
				array4[1] += num3;
				array4[3] += num3;
			}
			global::System.Windows.Size availableSize2 = new global::System.Windows.Size(global::System.Math.Max(0.0, availableSize.Width - array4[0] - array4[2]), global::System.Math.Max(0.0, availableSize.Height - array5[3] - array5[1]));
			for (int j = 4; j < 8; j++)
			{
				foreach (global::System.Windows.UIElement element in array[j])
				{
					this.MeasureToFit(element, availableSize2);
				}
			}
			global::System.Windows.Size result = default(global::System.Windows.Size);
			foreach (global::System.Windows.UIElement uielement2 in array[8])
			{
				this.MeasureToFit(uielement2, availableSize2);
				result.Height = global::System.Math.Max(global::System.Math.Max(global::System.Math.Max(array5[0], array5[2]), array5[1] + array5[3] + uielement2.DesiredSize.Height), result.Height);
				result.Width = global::System.Math.Max(global::System.Math.Max(global::System.Math.Max(array4[1], array4[3]), array4[0] + array4[2] + uielement2.DesiredSize.Width), result.Width);
			}
			return result;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005628 File Offset: 0x00003828
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Collections.Generic.List<global::System.Windows.UIElement>[] array = this.ByEdge(base.Children);
			global::System.Windows.Rect bounds = new global::System.Windows.Rect(0.0, 0.0, finalSize.Width, finalSize.Height);
			global::System.Windows.Rect rect = this.Arrange(bounds, array[0], array[1], array[2], array[3]);
			global::System.Windows.Rect bounds2 = new global::System.Windows.Rect(double.MaxValue, double.MaxValue, 0.0, 0.0);
			if (array[8].Count == 0)
			{
				bounds2 = rect;
			}
			else
			{
				foreach (global::System.Windows.UIElement uielement in array[8])
				{
					uielement.Arrange(rect);
					if (uielement is global::System.Windows.FrameworkElement)
					{
						bounds2 = new global::System.Windows.Rect(global::System.Math.Min((rect.Width - ((global::System.Windows.FrameworkElement)uielement).ActualWidth) / 2.0, bounds2.X), global::System.Math.Min((rect.Height - ((global::System.Windows.FrameworkElement)uielement).ActualHeight) / 2.0, bounds2.Y), global::System.Math.Max(((global::System.Windows.FrameworkElement)uielement).ActualWidth, bounds2.Width), global::System.Math.Max(((global::System.Windows.FrameworkElement)uielement).ActualHeight, bounds2.Height));
					}
				}
				bounds2 = new global::System.Windows.Rect(global::System.Math.Max(bounds2.X, 0.0) + rect.X, global::System.Math.Max(bounds2.Y, 0.0) + rect.Y, global::System.Math.Min(bounds2.Width, rect.Width), global::System.Math.Min(bounds2.Height, rect.Height));
			}
			this.Arrange(bounds2, array[4], array[5], array[6], array[7]);
			return finalSize;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005818 File Offset: 0x00003A18
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.XamDockAutomationPeer(this);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005820 File Offset: 0x00003A20
		private global::System.Windows.Rect Arrange(global::System.Windows.Rect bounds, global::System.Collections.Generic.List<global::System.Windows.UIElement> leftElements, global::System.Collections.Generic.List<global::System.Windows.UIElement> bottomElements, global::System.Collections.Generic.List<global::System.Windows.UIElement> rightElements, global::System.Collections.Generic.List<global::System.Windows.UIElement> topElements)
		{
			global::System.Windows.Size size = this.Size(leftElements, bounds, global::Infragistics.Controls.XamDock.DockDirection.Vertical);
			global::System.Windows.Size size2 = this.Size(bottomElements, bounds, global::Infragistics.Controls.XamDock.DockDirection.Horizontal);
			global::System.Windows.Size size3 = this.Size(rightElements, bounds, global::Infragistics.Controls.XamDock.DockDirection.Vertical);
			global::System.Windows.Size size4 = this.Size(topElements, bounds, global::Infragistics.Controls.XamDock.DockDirection.Horizontal);
			if (this.LayoutPriority == global::Infragistics.Controls.LayoutPriority.None)
			{
				this.ArrangeEdge(leftElements, new global::System.Windows.Rect(bounds.Left, bounds.Top, size.Width, bounds.Height), global::Infragistics.Controls.XamDock.DockDirection.Vertical);
				this.ArrangeEdge(bottomElements, new global::System.Windows.Rect(bounds.Left, bounds.Bottom - size2.Height, bounds.Width, size2.Height), global::Infragistics.Controls.XamDock.DockDirection.Horizontal);
				this.ArrangeEdge(rightElements, new global::System.Windows.Rect(bounds.Right - size3.Width, bounds.Top, size3.Width, bounds.Height), global::Infragistics.Controls.XamDock.DockDirection.Vertical);
				this.ArrangeEdge(topElements, new global::System.Windows.Rect(bounds.Left, bounds.Top, bounds.Width, size4.Height), global::Infragistics.Controls.XamDock.DockDirection.Horizontal);
			}
			else if (this.LayoutPriority == global::Infragistics.Controls.LayoutPriority.LeftAndRight)
			{
				this.ArrangeEdge(rightElements, new global::System.Windows.Rect(bounds.Right - size3.Width, bounds.Top, size3.Width, bounds.Height), global::Infragistics.Controls.XamDock.DockDirection.Vertical);
				this.ArrangeEdge(leftElements, new global::System.Windows.Rect(bounds.Left, bounds.Top, size.Width, bounds.Height), global::Infragistics.Controls.XamDock.DockDirection.Vertical);
				this.ArrangeEdge(bottomElements, new global::System.Windows.Rect(bounds.Left + size.Width, bounds.Bottom - size2.Height, global::System.Math.Max(0.0, bounds.Width - size.Width - size3.Width), size2.Height), global::Infragistics.Controls.XamDock.DockDirection.Horizontal);
				this.ArrangeEdge(topElements, new global::System.Windows.Rect(bounds.Left + size.Width, bounds.Top, global::System.Math.Max(0.0, bounds.Width - size.Width - size3.Width), size4.Height), global::Infragistics.Controls.XamDock.DockDirection.Horizontal);
			}
			else
			{
				this.ArrangeEdge(topElements, new global::System.Windows.Rect(bounds.Left, bounds.Top, bounds.Width, size4.Height), global::Infragistics.Controls.XamDock.DockDirection.Horizontal);
				this.ArrangeEdge(bottomElements, new global::System.Windows.Rect(bounds.Left, bounds.Bottom - size2.Height, bounds.Width, size2.Height), global::Infragistics.Controls.XamDock.DockDirection.Horizontal);
				this.ArrangeEdge(rightElements, new global::System.Windows.Rect(bounds.Right - size3.Width, bounds.Top + size4.Height, size3.Width, global::System.Math.Max(0.0, bounds.Height - size4.Height - size2.Height)), global::Infragistics.Controls.XamDock.DockDirection.Vertical);
				this.ArrangeEdge(leftElements, new global::System.Windows.Rect(bounds.Left, bounds.Top + size4.Height, size.Width, global::System.Math.Max(0.0, bounds.Height - size4.Height - size2.Height)), global::Infragistics.Controls.XamDock.DockDirection.Vertical);
			}
			return new global::System.Windows.Rect(bounds.Left + size.Width, bounds.Top + size4.Height, global::System.Math.Max(0.0, bounds.Width - (size.Width + size3.Width)), global::System.Math.Max(0.0, bounds.Height - (size4.Height + size2.Height)));
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005BA0 File Offset: 0x00003DA0
		private void ArrangeEdge(global::System.Collections.Generic.List<global::System.Windows.UIElement> elements, global::System.Windows.Rect bounds, global::Infragistics.Controls.XamDock.DockDirection edge)
		{
			global::System.Collections.Generic.List<global::System.Windows.UIElement>[] array = this.ByPosition(elements, edge);
			global::System.Windows.Size[] array2 = new global::System.Windows.Size[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = this.Size(array[i], bounds, edge);
			}
			if (edge == global::Infragistics.Controls.XamDock.DockDirection.Horizontal)
			{
				this.Arrange(array[0], new global::System.Windows.Rect(bounds.Left, bounds.Top, array2[0].Width, bounds.Height), edge, false);
				this.Arrange(array[1], new global::System.Windows.Rect(bounds.Left + 0.5 * (bounds.Width - array2[1].Width), bounds.Top, array2[1].Width, bounds.Height), edge, false);
				this.Arrange(array[2], new global::System.Windows.Rect(bounds.Left + (bounds.Width - array2[2].Width), bounds.Top, array2[2].Width, bounds.Height), edge, false);
				this.Arrange(array[3], new global::System.Windows.Rect(bounds.Left + array2[0].Width, bounds.Top, global::System.Math.Max(0.0, bounds.Width - array2[0].Width - array2[2].Width), bounds.Height), edge, true);
				return;
			}
			this.Arrange(array[0], new global::System.Windows.Rect(bounds.Left, bounds.Top, bounds.Width, array2[0].Height), edge, false);
			this.Arrange(array[1], new global::System.Windows.Rect(bounds.Left, bounds.Top + 0.5 * (bounds.Height - array2[1].Height), bounds.Width, array2[1].Height), edge, false);
			this.Arrange(array[2], new global::System.Windows.Rect(bounds.Left, bounds.Top + (bounds.Height - array2[2].Height), bounds.Width, array2[2].Height), edge, false);
			this.Arrange(array[3], new global::System.Windows.Rect(bounds.Left, bounds.Top + array2[0].Width, bounds.Width, global::System.Math.Max(0.0, bounds.Height - array2[0].Width - array2[2].Width)), edge, true);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005E3C File Offset: 0x0000403C
		private global::System.Windows.Size Size(global::System.Collections.Generic.List<global::System.Windows.UIElement> elements, global::System.Windows.Rect bounds, global::Infragistics.Controls.XamDock.DockDirection direction)
		{
			global::System.Windows.Size result = default(global::System.Windows.Size);
			foreach (global::System.Windows.UIElement uielement in elements)
			{
				double width = uielement.DesiredSize.Width;
				double height = uielement.DesiredSize.Height;
				if (direction == global::Infragistics.Controls.XamDock.DockDirection.Vertical)
				{
					result.Height += height;
					result.Width = global::System.Math.Max(result.Width, width);
				}
				else
				{
					result.Width += width;
					result.Height = global::System.Math.Max(result.Height, height);
				}
			}
			result.Width = global::System.Math.Min(result.Width, bounds.Width);
			result.Height = global::System.Math.Min(result.Height, bounds.Height);
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005F30 File Offset: 0x00004130
		private void Arrange(global::System.Collections.Generic.List<global::System.Windows.UIElement> elements, global::System.Windows.Rect bounds, global::Infragistics.Controls.XamDock.DockDirection direction, bool isStrech)
		{
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(bounds.Left, bounds.Top, bounds.Width, bounds.Height);
			if (direction == global::Infragistics.Controls.XamDock.DockDirection.Horizontal)
			{
				if (isStrech)
				{
					finalRect.Width /= (double)elements.Count;
					using (global::System.Collections.Generic.List<global::System.Windows.UIElement>.Enumerator enumerator = elements.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Windows.UIElement uielement = enumerator.Current;
							uielement.Arrange(finalRect);
							finalRect.X += finalRect.Width;
						}
						return;
					}
				}
				using (global::System.Collections.Generic.List<global::System.Windows.UIElement>.Enumerator enumerator2 = elements.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::System.Windows.UIElement uielement2 = enumerator2.Current;
						finalRect.Width = uielement2.DesiredSize.Width;
						finalRect.Width = global::System.Math.Min(finalRect.Width, bounds.Width);
						uielement2.Arrange(finalRect);
						finalRect.X += finalRect.Width;
					}
					return;
				}
			}
			if (isStrech)
			{
				finalRect.Height /= (double)elements.Count;
				using (global::System.Collections.Generic.List<global::System.Windows.UIElement>.Enumerator enumerator3 = elements.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						global::System.Windows.UIElement uielement3 = enumerator3.Current;
						uielement3.Arrange(finalRect);
						finalRect.Y += finalRect.Height;
					}
					return;
				}
			}
			foreach (global::System.Windows.UIElement uielement4 in elements)
			{
				finalRect.Height = uielement4.DesiredSize.Height;
				finalRect.Height = global::System.Math.Min(finalRect.Height, bounds.Height);
				uielement4.Arrange(finalRect);
				finalRect.Y += finalRect.Height;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006158 File Offset: 0x00004358
		private global::System.Collections.Generic.List<global::System.Windows.UIElement>[] ByEdge(global::System.Windows.Controls.UIElementCollection elements)
		{
			global::System.Collections.Generic.List<global::System.Windows.UIElement>[] array = new global::System.Collections.Generic.List<global::System.Windows.UIElement>[9];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new global::System.Collections.Generic.List<global::System.Windows.UIElement>();
			}
			foreach (object obj in elements)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				array[(int)global::Infragistics.Controls.XamDock.GetEdge(uielement)].Add(uielement);
			}
			return array;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000061D8 File Offset: 0x000043D8
		private global::System.Collections.Generic.List<global::System.Windows.UIElement>[] ByPosition(global::System.Collections.Generic.IList<global::System.Windows.UIElement> elements, global::Infragistics.Controls.XamDock.DockDirection direction)
		{
			global::System.Collections.Generic.List<global::System.Windows.UIElement>[] array = new global::System.Collections.Generic.List<global::System.Windows.UIElement>[4];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new global::System.Collections.Generic.List<global::System.Windows.UIElement>();
			}
			foreach (global::System.Windows.UIElement uielement in elements)
			{
				array[this.GetPosition(uielement, direction)].Add(uielement);
			}
			return array;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006248 File Offset: 0x00004448
		public static global::System.Windows.HorizontalAlignment GetHorizontalDockAlignment(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.HorizontalAlignment)d.GetValue(global::Infragistics.Controls.XamDock.HorizontalDockAlignmentProperty);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000625A File Offset: 0x0000445A
		public static global::System.Windows.VerticalAlignment GetVerticalDockAlignment(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.VerticalAlignment)d.GetValue(global::Infragistics.Controls.XamDock.VerticalDockAlignmentProperty);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000626C File Offset: 0x0000446C
		public static void SetHorizontalDockAlignment(global::System.Windows.DependencyObject d, global::System.Windows.HorizontalAlignment value)
		{
			d.SetValue(global::Infragistics.Controls.XamDock.HorizontalDockAlignmentProperty, value);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000627F File Offset: 0x0000447F
		public static void SetVerticalDockAlignment(global::System.Windows.DependencyObject d, global::System.Windows.VerticalAlignment value)
		{
			d.SetValue(global::Infragistics.Controls.XamDock.VerticalDockAlignmentProperty, value);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006292 File Offset: 0x00004492
		private int GetPosition(global::System.Windows.UIElement element, global::Infragistics.Controls.XamDock.DockDirection direction)
		{
			if (direction == global::Infragistics.Controls.XamDock.DockDirection.Horizontal)
			{
				return (int)global::Infragistics.Controls.XamDock.GetHorizontalDockAlignment(element);
			}
			return (int)global::Infragistics.Controls.XamDock.GetVerticalDockAlignment(element);
		}

		// Token: 0x04000049 RID: 73
		public static readonly global::System.Windows.DependencyProperty LayoutPriorityProperty = global::System.Windows.DependencyProperty.Register("LayoutPriority", typeof(global::Infragistics.Controls.LayoutPriority), typeof(global::Infragistics.Controls.XamDock), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.LayoutPriority.None, null));

		// Token: 0x0400004A RID: 74
		public static readonly global::System.Windows.DependencyProperty EdgeProperty = global::System.Windows.DependencyProperty.RegisterAttached("Edge", typeof(global::Infragistics.Controls.DockEdge), typeof(global::Infragistics.Controls.XamDock), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.DockEdge.Central, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamDock.HandlePropertyChanged)));

		// Token: 0x0400004B RID: 75
		public static readonly global::System.Windows.DependencyProperty HorizontalDockAlignmentProperty = global::System.Windows.DependencyProperty.RegisterAttached("HorizontalDockAlignment", typeof(global::System.Windows.HorizontalAlignment), typeof(global::Infragistics.Controls.XamDock), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamDock.HandlePropertyChanged)));

		// Token: 0x0400004C RID: 76
		public static readonly global::System.Windows.DependencyProperty VerticalDockAlignmentProperty = global::System.Windows.DependencyProperty.RegisterAttached("VerticalDockAlignment", typeof(global::System.Windows.VerticalAlignment), typeof(global::Infragistics.Controls.XamDock), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.XamDock.HandlePropertyChanged)));

		// Token: 0x02000013 RID: 19
		private enum DockDirection
		{
			// Token: 0x0400004E RID: 78
			Horizontal,
			// Token: 0x0400004F RID: 79
			Vertical
		}
	}
}
