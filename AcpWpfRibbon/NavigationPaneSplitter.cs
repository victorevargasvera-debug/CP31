using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000068 RID: 104
	[global::System.Windows.TemplatePart(Name = "PART_SplitterBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NavigationPaneSplitter : global::System.Windows.Controls.Control
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0006908C File Offset: 0x0006728C
		static NavigationPaneSplitter()
		{
			int a_ = 17;
			short num = (short)293134874;
			short num2 = num;
			num = (short)1196941850;
			switch (num2 == num)
			{
			default:
			{
				num = (short)727842816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)876281857;
			if (num != 0)
			{
			}
			num = (short)1778909184;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.NavigationPaneSplitter.PanePanelProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㥨੪ͬ੮ⅰቲ᭴ቶᕸ", a_), typeof(global::DevComponents.WpfRibbon.NavigationPanePanel), typeof(global::DevComponents.WpfRibbon.NavigationPaneSplitter), new global::System.Windows.UIPropertyMetadata(null));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.NavigationPaneSplitter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.NavigationPaneSplitter)));
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00069194 File Offset: 0x00067394
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00069250 File Offset: 0x00067450
		public global::DevComponents.WpfRibbon.NavigationPanePanel PanePanel
		{
			get
			{
				short num = (short)62896278;
				short num2 = num;
				num = (short)1524021398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)30081024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855913985;
				if (num != 0)
				{
				}
				num = (short)1792933888;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.NavigationPanePanel)base.GetValue(global::DevComponents.WpfRibbon.NavigationPaneSplitter.PanePanelProperty);
			}
			set
			{
				short num = (short)776357985;
				short num2 = num;
				num = (short)552290401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)744095744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2064056321;
				if (num != 0)
				{
				}
				num = (short)1040842752;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.NavigationPaneSplitter.PanePanelProperty, value);
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00069304 File Offset: 0x00067504
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1745813505;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_141;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 2:
					if (base.TemplatedParent is global::DevComponents.WpfRibbon.NavigationPane)
					{
						num = (short)1329135619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F4;
				case 3:
				{
					num = (short)1720975361;
					if (num != 0)
					{
					}
					for (;;)
					{
						global::DevComponents.WpfRibbon.NavigationPane navigationPane = base.TemplatedParent as global::DevComponents.WpfRibbon.NavigationPane;
						this._VisibleItemsCount = this.PanePanel.VisiblePaneItemCount;
						this._FirstElementSize = this.PanePanel.FirstVisible.RenderSize;
						this._MinContentHeight = navigationPane.MinimumContentHeight;
						base.CaptureMouse();
						e.Handled = true;
						num = (short)1807041785;
						short num3 = num;
						num = (short)1930052857;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_E7;
						}
					}
					IL_E7:
					num = (short)1107361792;
					short num4 = num;
					num = (short)1627979776;
					if (num != 0)
					{
					}
					num = (short)1184694272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (this.PanePanel.FirstVisible != null)
					{
						num = (short)1974075397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F4;
				case 5:
					num = (short)1032978434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)920256516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_40:
				if (this.PanePanel == null)
				{
					break;
				}
				num = (short)1521876998;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_141:
			IL_1F4:
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0006950C File Offset: 0x0006770C
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)70582272;
			switch (num)
			{
			default:
			{
				num = (short)1816723469;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfRibbon.NavigationPane navigationPane;
					int largeItemsCount;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Point position;
						if (position.Y >= 0.0)
						{
							num = (short)1695416332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)933685366;
						short num3 = num;
						num = (short)864938102;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2AF;
						default:
							num = (short)1373896704;
							if (num != 0)
							{
							}
							num = (short)1929969667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_2AF;
					case 2:
					{
						global::System.Windows.Point position;
						if (position.Y + base.RenderSize.Height > this._FirstElementSize.Height * 0.75)
						{
							num = (short)95158273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					}
					case 3:
						num = (short)1759903753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1498873872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_2DA;
					case 6:
						if (navigationPane.SelectedContent is global::System.Windows.UIElement)
						{
							num = (short)1181745159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32D;
					case 7:
					{
						double num4 = ((global::System.Windows.UIElement)navigationPane.SelectedContent).RenderSize.Height;
						num = (short)1260781582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						num = (short)416874497;
						if (num != 0)
						{
						}
						global::System.Windows.Point position;
						if (global::System.Math.Abs(position.Y) > this._FirstElementSize.Height * 0.8)
						{
							num = (short)9895951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					}
					case 9:
						if (this.PanePanel.LargeItemsCount < this._VisibleItemsCount)
						{
							num = (short)47775748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 10:
						goto IL_2AA;
					case 11:
					{
						global::System.Windows.Point position = e.GetPosition(this);
						double num4 = double.PositiveInfinity;
						navigationPane = (base.TemplatedParent as global::DevComponents.WpfRibbon.NavigationPane);
						num = (short)705363974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (this.PanePanel.LargeItemsCount > 0)
						{
							num = (short)576258066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 14:
						goto IL_32D;
					case 15:
					{
						global::DevComponents.WpfRibbon.NavigationPane navigationPane2 = navigationPane;
						largeItemsCount = navigationPane2.LargeItemsCount;
						navigationPane2.LargeItemsCount = largeItemsCount + 1;
						num = (short)308215818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						num = (short)1192034304;
						short num5 = num;
						double num4;
						if (num4 - this._FirstElementSize.Height > this._MinContentHeight)
						{
							num = (short)202440721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					}
					case 17:
						num = (short)1408368648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)946405378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8F:
					if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
					{
						num = (short)710082571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_2AF:
					global::DevComponents.WpfRibbon.NavigationPane navigationPane3 = navigationPane;
					largeItemsCount = navigationPane3.LargeItemsCount;
					navigationPane3.LargeItemsCount = largeItemsCount - 1;
					num = (short)536018949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32D:
					num = (short)899219456;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2AA:
				IL_2DA:
				IL_43A:
				base.OnMouseMove(e);
				return;
			}
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0006995C File Offset: 0x00067B5C
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)622460930;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					for (;;)
					{
						base.ReleaseMouseCapture();
						e.Handled = true;
						num = (short)342860333;
						short num3 = num;
						num = (short)139960877;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_BD;
						}
					}
					IL_BD:
					num = (short)933429248;
					short num4 = num;
					num = (short)1899560960;
					if (num != 0)
					{
					}
					num = (short)1368719361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_114;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1251737601;
				if (num != 0)
				{
				}
				if (!base.IsMouseCaptured)
				{
					break;
				}
				num = (short)1712848896;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_114:
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x04000280 RID: 640
		public static readonly global::System.Windows.DependencyProperty PanePanelProperty;

		// Token: 0x04000281 RID: 641
		private int _VisibleItemsCount = -1;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.Size _FirstElementSize;

		// Token: 0x04000283 RID: 643
		private double _MinContentHeight;
	}
}
