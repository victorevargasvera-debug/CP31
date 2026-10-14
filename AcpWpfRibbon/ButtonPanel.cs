using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200001C RID: 28
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ButtonPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x06000267 RID: 615 RVA: 0x000360F8 File Offset: 0x000342F8
		static ButtonPanel()
		{
			int a_ = 7;
			short num = (short)1031667712;
			short num2 = num;
			num = (short)1712174558;
			short num3 = num;
			num = (short)930330078;
			switch (num3 == num)
			{
			}
			num = (short)117243905;
			if (num != 0)
			{
			}
			num = (short)1527644160;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ButtonPanel.OrientationProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ၞ፠੢d०ᵨ੪ᥬٮṰᵲ", a_), typeof(global::DevComponents.WpfRibbon.eButtonPanelOrientation), typeof(global::DevComponents.WpfRibbon.ButtonPanel), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eButtonPanelOrientation.Vertical, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.ButtonPanel.FixedWidthProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᥞࡠ᭢dͦ㹨ɪ६᭮ᥰ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.ButtonPanel), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.ButtonPanel.FixedHeightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᥞࡠ᭢dͦⅨ๪Ѭ࡮ᥰݲ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.ButtonPanel), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Controls.Control.IsTabStopProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonPanel), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000362C4 File Offset: 0x000344C4
		public virtual global::DevComponents.WpfRibbon.ButtonPanel Copy(bool deepCopy)
		{
			short num = (short)306774016;
			short num2 = num;
			num = (short)550975333;
			short num3 = num;
			num = (short)1937913701;
			switch (num3 == num)
			{
			}
			num = (short)1515061249;
			if (num != 0)
			{
			}
			num = (short)2039021568;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.CloningMachine.Clone(this, deepCopy);
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00036374 File Offset: 0x00034574
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00036430 File Offset: 0x00034630
		[global::System.ComponentModel.Category("Layout")]
		public global::DevComponents.WpfRibbon.eButtonPanelOrientation Orientation
		{
			get
			{
				short num = (short)503709696;
				short num2 = num;
				num = (short)511235182;
				short num3 = num;
				num = (short)1386206318;
				switch (num3 == num)
				{
				}
				num = (short)1776943104;
				if (num != 0)
				{
				}
				num = (short)1446445057;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eButtonPanelOrientation)base.GetValue(global::DevComponents.WpfRibbon.ButtonPanel.OrientationProperty);
			}
			set
			{
				short num = (short)1539768320;
				short num2 = num;
				num = (short)1940981196;
				short num3 = num;
				num = (short)750519756;
				switch (num3 == num)
				{
				}
				num = (short)191627265;
				if (num != 0)
				{
				}
				num = (short)1735000064;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonPanel.OrientationProperty, value);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000364E8 File Offset: 0x000346E8
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000365A0 File Offset: 0x000347A0
		[global::System.ComponentModel.Category("Layout")]
		public double FixedWidth
		{
			get
			{
				short num = (short)361365504;
				short num2 = num;
				num = (short)1067713088;
				short num3 = num;
				num = (short)2127364672;
				switch (num3 == num)
				{
				}
				num = (short)499974145;
				if (num != 0)
				{
				}
				num = (short)1330249728;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.ButtonPanel.FixedWidthProperty);
			}
			set
			{
				short num = (short)1166147585;
				if (num != 0)
				{
				}
				num = (short)1026213779;
				short num2 = num;
				num = (short)1102563219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2078932992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1211826176;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonPanel.FixedWidthProperty, value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00036658 File Offset: 0x00034858
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00036714 File Offset: 0x00034914
		[global::System.ComponentModel.Category("Layout")]
		public double FixedHeight
		{
			get
			{
				short num = (short)930043076;
				short num2 = num;
				num = (short)1895781572;
				switch (num2 == num)
				{
				}
				num = (short)67305472;
				short num3 = num;
				num = (short)369754112;
				if (num != 0)
				{
				}
				num = (short)1671561217;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.ButtonPanel.FixedHeightProperty);
			}
			set
			{
				short num = (short)591003649;
				if (num != 0)
				{
				}
				num = (short)663157307;
				short num2 = num;
				num = (short)1379793467;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298071552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1892941824;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonPanel.FixedHeightProperty, value);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000367D0 File Offset: 0x000349D0
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)2132279302;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
				switch (num2)
				{
				case 0:
					num = (short)910426117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1993211905;
					if (num != 0)
					{
					}
					global::System.Windows.Size size;
					if (size.Width <= availableSize.Width)
					{
						return size;
					}
					num = (short)1825272655;
					short num3 = num;
					num = (short)613446479;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26C;
					default:
						num = (short)279379968;
						if (num != 0)
						{
						}
						num = (short)1800667147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
				{
					global::System.Windows.Size size;
					return size;
				}
				case 3:
				{
					global::System.Windows.Size size = this.MeasureAutoLayout(availableSize);
					num = (short)1579745287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_222;
				case 5:
					if (this.IsDesignMode)
					{
						num = (short)995164160;
						short num4 = num;
						num = (short)933298180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B5;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 7:
					goto IL_227;
				case 8:
				{
					if (base.IsItemsHost)
					{
						num = (short)681967626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Size size;
					return size;
				}
				case 9:
				{
					if (ribbonBar != null)
					{
						num = (short)892469261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Size size;
					return size;
				}
				case 10:
					goto IL_26C;
				case 11:
					ribbonBar.MeasureNeedCollapse = true;
					num = (short)1081147394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					if (this.m_AutoLayoutEnabled)
					{
						num = (short)2132672515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Size size = this.MeasureDefault(availableSize);
					num = (short)535101454;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
				{
					global::System.Windows.Size size;
					ribbonBar.LastPanelMeasureSize = size;
					this.m_LastCalculatedSize = size;
					num = (short)877068289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					goto IL_227;
				}
				IL_61:
				if (base.Children.Count == 0)
				{
					num = (short)1602682880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2B5;
				IL_227:
				ribbonBar = (base.TemplatedParent as global::DevComponents.WpfRibbon.RibbonBar);
				num = (short)1204813832;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_26C:
				num = (short)1229717513;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B5:
				num = (short)911081484;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_222:
			return new global::System.Windows.Size(32.0, 24.0);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00036AD0 File Offset: 0x00034CD0
		private global::System.Windows.Size MeasureDefault(global::System.Windows.Size availableSize)
		{
			short num = (short)492371969;
			if (num != 0)
			{
			}
			num = (short)1613361824;
			short num2 = num;
			num = (short)1643836064;
			switch (num2 == num)
			{
			}
			num = (short)230621184;
			if (num != 0)
			{
			}
			num = (short)1932132352;
			short num3 = num;
			return this.MeasureDefault(availableSize, true);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00036B80 File Offset: 0x00034D80
		private global::System.Windows.Size MeasureDefault(global::System.Windows.Size availableSize, bool childrenMeasure)
		{
			short num = (short)2131689472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FA;
				}
				global::System.Windows.Size size3;
				global::System.Windows.Size size6;
				bool flag2;
				global::System.Windows.Size measureSize;
				global::System.Windows.Size availableSize2;
				int count;
				global::System.Windows.Controls.UIElementCollection internalChildren;
				for (;;)
				{
					IL_27:
					global::System.Windows.Size size;
					global::System.Windows.Size size2;
					global::System.Windows.Size size4;
					global::System.Windows.Size size5;
					bool flag;
					bool flag3;
					global::System.Windows.Size size7;
					global::System.Windows.Size size8;
					int num4;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.UIElement uielement;
						size = uielement.DesiredSize;
						goto IL_66F;
					}
					case 1:
						size2 = new global::System.Windows.Size(size3.Height, size3.Width);
						goto IL_951;
					case 2:
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(size4.Height, size5.Height))
						{
							num = (short)174456865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_539;
					case 3:
						if (flag)
						{
							num = (short)1090322474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return size6;
					case 4:
						if (!flag2)
						{
							num = (short)1166934022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)753926144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_539;
					case 6:
					{
						global::System.Windows.UIElement uielement;
						global::System.Windows.Size desiredSize = uielement.DesiredSize;
						num = (short)203358232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (!double.IsPositiveInfinity(availableSize.Height))
						{
							num = (short)672399389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					case 8:
						if (childrenMeasure)
						{
							num = (short)1446445075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_797;
					case 9:
						flag3 = !double.IsNaN(availableSize.Height);
						goto IL_999;
					case 10:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown != null)
						{
							num = (short)60227629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_797;
					}
					case 11:
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(size5.Width + size4.Width, size7.Width))
						{
							num = (short)798687257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						size5.Width += size4.Width;
						num = (short)1407647746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_539;
					case 13:
					{
						global::System.Windows.UIElement uielement;
						if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)1298792484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_539;
					}
					case 14:
						size8 = measureSize;
						goto IL_331;
					case 15:
						num = (short)1736114189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						size2 = size3;
						goto IL_951;
					case 17:
						if (childrenMeasure)
						{
							num = (short)1500971026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8AF;
					case 18:
						num = (short)2062286894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1952710690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_8AF;
					case 21:
						size8 = new global::System.Windows.Size(measureSize.Height, measureSize.Width);
						goto IL_331;
					case 22:
						num = (short)469565441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						global::System.Windows.UIElement uielement;
						((global::DevComponents.WpfRibbon.Gallery)uielement).IsCollapsed = false;
						uielement.Measure(new global::System.Windows.Size(availableSize2.Width, availableSize.Height));
						num = (short)1865154609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						num = (short)1013579776;
						short num3 = num;
						global::System.Windows.Size desiredSize;
						double height = desiredSize.Height;
						global::System.Windows.UIElement uielement;
						desiredSize = uielement.DesiredSize;
						size = new global::System.Windows.Size(height, desiredSize.Width);
						goto IL_66F;
					}
					case 25:
						size3.Height += size5.Height;
						size3.Width = global::System.Math.Max(size3.Width, size5.Width);
						size5 = size4;
						num = (short)2136276997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						size3.Height += size5.Height;
						size3.Width = global::System.Math.Max(size5.Width, size3.Width);
						num = (short)259260460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						flag3 = false;
						goto IL_999;
					case 28:
						goto IL_4AF;
					case 29:
						num = (short)1806696489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)2113994767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_539;
					}
					case 31:
						num = (short)1357905968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_797;
					case 33:
						size5.Height = size4.Height;
						num = (short)464584716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown.AutoSizeBag != null)
						{
							num = (short)1253376043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_797;
					}
					case 35:
						goto IL_557;
					case 36:
					{
						global::System.Windows.UIElement uielement;
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = uielement as global::DevComponents.WpfRibbon.ButtonDropDown;
						num = (short)1430978570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						num = (short)1520500757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						return size6;
					case 39:
					{
						if (num4 >= count)
						{
							num = (short)1189085210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = internalChildren[num4];
						num = (short)1632501790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_8AF;
					case 41:
					{
						if (double.IsInfinity(availableSize.Height))
						{
							goto IL_399;
						}
						num = (short)2122277121;
						short num5 = num;
						num = (short)966222081;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_557;
						default:
							num = (short)1537081344;
							if (num != 0)
							{
							}
							num = (short)1184301106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 42:
						size6.Height = availableSize.Height;
						num = (short)1425604646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						buttonDropDown.AutoSizeBag.RestoreSettings();
						buttonDropDown.AutoSizeBag = null;
						num = (short)1418788896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						if (!flag2)
						{
							num = (short)1578041366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1108803600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						this.m_ButtonDropDownCount++;
						num = (short)747569160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
					{
						num = (short)593559553;
						if (num != 0)
						{
						}
						global::System.Windows.UIElement uielement;
						if (uielement is global::DevComponents.WpfRibbon.Gallery)
						{
							num = (short)1392574495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement.Measure(availableSize2);
						num = (short)665583656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						if (!flag2)
						{
							num = (short)1491402789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1182203918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
					{
						global::System.Windows.UIElement uielement;
						if ((uielement as global::DevComponents.WpfRibbon.Gallery).IsCollapsible)
						{
							num = (short)1956511767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement.Measure(availableSize2);
						num = (short)1668743188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						goto IL_8AF;
					case 50:
						num = (short)1672282121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FA;
					IL_331:
					size7 = size8;
					size5 = new global::System.Windows.Size(0.0, 0.0);
					num4 = 0;
					num = (short)900988956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_399:
					num = (short)270073883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AF:
					num = (short)1281032231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_557:
					goto IL_4AF;
					IL_539:
					num4++;
					num = (short)328335395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66F:
					size4 = size;
					size4.Width = global::System.Math.Round(size4.Width);
					size4.Height = global::System.Math.Round(size4.Height);
					num = (short)1648558091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_797:
					num = (short)252313617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8AF:
					num = (short)1190723588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_951:
					size6 = size2;
					this.m_RealCalculatedSize = size6;
					num = (short)1768357891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_999:
					flag = flag3;
					num = (short)224722991;
					num2 = (int)((global::System.IntPtr)num);
				}
				return size6;
				IL_FA:
				this.m_ButtonDropDownCount = 0;
				size3 = new global::System.Windows.Size(0.0, 0.0);
				internalChildren = base.InternalChildren;
				count = internalChildren.Count;
				flag2 = (this.Orientation == global::DevComponents.WpfRibbon.eButtonPanelOrientation.Horizontal);
				measureSize = this.GetMeasureSize(availableSize);
				availableSize2 = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
				num = (short)469827591;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00037594 File Offset: 0x00035794
		private void CreatePropertyBag(global::DevComponents.WpfRibbon.ButtonDropDown b)
		{
			if (b.AutoSizeBag == null)
			{
				short num = (short)1188807934;
				short num2 = num;
				num = (short)492815614;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1375076353;
					if (num != 0)
					{
					}
					num = (short)367853568;
					if (num != 0)
					{
					}
					num = (short)64552960;
					short num3 = num;
					global::DevComponents.WpfRibbon.ElementAutoSizeBag elementAutoSizeBag = global::DevComponents.WpfRibbon.AutoSizeBagFactory.CreateAutoSizeBag(b);
					elementAutoSizeBag.RecordSetting(b);
					b.AutoSizeBag = elementAutoSizeBag;
					return;
				}
				}
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0003765C File Offset: 0x0003585C
		private global::System.Windows.Size MeasureAutoLayout(global::System.Windows.Size availableSize)
		{
			short num = (short)1871904768;
			switch (num)
			{
			default:
			{
				num = (short)1059848201;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Size result;
				global::System.Windows.Size result3;
				for (;;)
				{
					int num3;
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					global::System.Windows.Size availableSize2;
					double num7;
					int num8;
					int num9;
					double width2;
					switch (num2)
					{
					case 0:
						if (this.HasGallery)
						{
							num = (short)463470675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C8;
					case 1:
						num = (short)1097990169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)952041564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> list;
						if (list.Count == 0)
						{
							num = (short)80936991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					}
					case 4:
					{
						global::DevComponents.WpfRibbon.eAutoSizeHint minAutoSizeHint;
						if (minAutoSizeHint == global::DevComponents.WpfRibbon.eAutoSizeHint.NoAutoSize)
						{
							num = (short)936050703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1586167825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (num3 != 3)
						{
							num = (short)1920532549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14B6;
					case 6:
						goto IL_859;
					case 7:
						if (buttonDropDown.HasHeader)
						{
							num = (short)1348141116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1513;
					case 8:
						if (result.Width > availableSize.Width)
						{
							num = (short)1857028169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_1D3;
						}
						continue;
					case 10:
						goto IL_642;
					case 11:
						goto IL_14B6;
					case 12:
						try
						{
							num = (short)380370947;
							num2 = (int)((global::System.IntPtr)num);
							global::System.Windows.Size result2;
							for (;;)
							{
								global::System.Windows.Size size;
								switch (num2)
								{
								case 0:
									num = (short)583991298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(size.Width, availableSize.Width))
									{
										num = (short)429916168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									goto IL_C20;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_A2E;
									}
									continue;
								case 4:
								{
									num = (short)689913506;
									short num4 = num;
									num = (short)963919522;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_BA7;
									default:
									{
										num = (short)1535442944;
										if (num != 0)
										{
										}
										global::DevComponents.WpfRibbon.Gallery gallery;
										gallery.IsCollapsed = true;
										gallery.Measure(availableSize2);
										size = this.MeasureDefault(availableSize, false);
										num = (short)1064763397;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 5:
									if (size.Width > availableSize.Width)
									{
										num = (short)1317732364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BA9;
								case 6:
									goto IL_BC5;
								case 7:
									num = (short)1488715787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_BA7;
								case 9:
								{
									global::DevComponents.WpfRibbon.Gallery gallery;
									if (gallery.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)1512112135;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.Gallery>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)769130496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfRibbon.Gallery gallery = enumerator.Current;
									num = (short)2123300873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::DevComponents.WpfRibbon.Gallery gallery;
									if (gallery.IsCollapsible)
									{
										num = (short)1148256260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)365232129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_A2E;
								IL_BA9:
								result2 = size;
								num = (short)742260742;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BA7:
								goto IL_BA9;
								IL_BCA:
								num = (short)1989017610;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A2E:
								goto IL_BCA;
							}
							IL_BC5:
							return result2;
							IL_C20:
							goto IL_605;
						}
						finally
						{
							global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.Gallery>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_C33;
					case 13:
					{
						if (buttonDropDown == null)
						{
							num = (short)1512308769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.eAutoSizeHint minAutoSizeHint = global::DevComponents.WpfRibbon.RibbonBar.GetMinAutoSizeHint(buttonDropDown);
						num = (short)1378942980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_1170;
					case 15:
						buttonDropDown.Measure(availableSize2);
						num = (short)1125777429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::DevComponents.WpfRibbon.eAutoSizeHint minAutoSizeHint;
						if (minAutoSizeHint == global::DevComponents.WpfRibbon.eAutoSizeHint.Small)
						{
							num = (short)992477252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_706;
					}
					case 17:
						if (buttonDropDown.ImagePosition != global::DevComponents.WpfRibbon.eButtonImagePosition.Top)
						{
							num = (short)1695809623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_859;
					case 18:
						num = (short)1724710912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						((global::DevComponents.WpfRibbon.RibbonBar)base.TemplatedParent).MeasureNeedCollapse = true;
						num = (short)1382481944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						try
						{
							num = (short)832569353;
							num2 = (int)((global::System.IntPtr)num);
							global::System.Windows.Size result2;
							for (;;)
							{
								global::System.Windows.Size size2;
								global::DevComponents.WpfRibbon.Gallery gallery2;
								double num5;
								switch (num2)
								{
								case 0:
									goto IL_CF7;
								case 1:
									num = (short)1700200458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (size2.Width > availableSize.Width)
									{
										num = (short)1868169231;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E1D;
								case 3:
								{
									if (gallery2.MinWidth > 0.0)
									{
										num = (short)1906901008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									double val = num5;
									double minContainerWidth = gallery2.GetMinContainerWidth();
									result2 = gallery2.DesiredSize;
									num5 = global::System.Math.Max(val, minContainerWidth + result2.Width - gallery2.PanelWidth);
									num = (short)1173815304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(size2.Width, availableSize.Width))
									{
										num = (short)307691534;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									if (gallery2.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)1097990155;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									if (global::DevComponents.WpfRibbon.RibbonBar.GetMinAutoSizeHint(gallery2) != global::DevComponents.WpfRibbon.eAutoSizeHint.NoAutoSize)
									{
										num = (short)460718098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									goto IL_E3A;
								case 8:
									goto IL_CF7;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_CF2;
									}
									continue;
								case 10:
									goto IL_FE6;
								case 11:
									num = (short)1905721357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.Gallery>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)266797057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									gallery2 = enumerator.Current;
									num = (short)562626566;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									if (double.IsNaN(gallery2.Width))
									{
										num = (short)164954129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 14:
									goto IL_E1D;
								case 15:
									num = (short)1025310724;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									num5 = global::System.Math.Max(num5, gallery2.MinWidth);
									num = (short)1913257984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
								{
									double width = availableSize.Width;
									result2 = base.DesiredSize;
									double num6 = width - result2.Width;
									result2 = gallery2.DesiredSize;
									num5 = result2.Width + num6;
									num = (short)1279787011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									num = (short)1384448005;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CF2;
								IL_CF7:
								gallery2.Measure(new global::System.Windows.Size(num5, availableSize.Height));
								size2 = this.MeasureDefault(availableSize, false);
								num = (short)843317250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E1D:
								result2 = size2;
								num = (short)1413152775;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F90:
								num = (short)401145868;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CF2:
								goto IL_F90;
							}
							IL_E3A:
							return result2;
							IL_FE6:
							goto IL_109F;
						}
						finally
						{
							global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.Gallery>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_FF9;
					case 21:
						goto IL_148A;
					case 22:
						if (buttonDropDown.PartVisibility == global::DevComponents.WpfRibbon.eButtonPartVisibility.ImageAndHeader)
						{
							num = (short)661717030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144D;
					case 23:
						if (buttonDropDown is global::DevComponents.WpfRibbon.Gallery)
						{
							num = (short)533594155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						buttonDropDown.Measure(availableSize2);
						num = (short)1432879174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_46F;
					case 25:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(result3.Width, availableSize.Width))
						{
							num = (short)831586352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result3;
					case 26:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(result.Width, availableSize.Width))
						{
							num = (short)239992869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 27:
						goto IL_1FC;
					case 28:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown2;
						num7 -= buttonDropDown2.DesiredSize.Height;
						num = (short)1790836750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (num7 != double.PositiveInfinity)
						{
							num = (short)2079981596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1170;
					case 30:
						if (num8 == 0)
						{
							num = (short)755367978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					case 31:
						goto IL_951;
					case 32:
					{
						if (!this.IsRibbonBarPanelMeasure)
						{
							num = (short)508231715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						availableSize2 = new global::System.Windows.Size(1000.0, availableSize.Height);
						global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
						num9 = internalChildren.Count - 1;
						num7 = availableSize.Height;
						num3 = 0;
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> list = new global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown>(num9);
						num = (short)723058773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						global::System.Windows.Controls.UIElementCollection internalChildren;
						internalChildren[num8].Measure(availableSize2);
						num = (short)928383072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						goto IL_148A;
					case 35:
						goto IL_1653;
					case 36:
						goto IL_600;
					case 37:
						num = (short)802488396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)1917321287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (buttonDropDown.HasImage)
						{
							num = (short)1829371944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144D;
					case 40:
						num = (short)1494089750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (result3.Width > availableSize.Width)
						{
							num = (short)1383071745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result3;
					case 42:
						num = (short)105447427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						buttonDropDown.Measure(new global::System.Windows.Size(double.PositiveInfinity, availableSize2.Height));
						num = (short)1460338768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (this.HasGallery)
						{
							num = (short)291176509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_605;
					case 45:
						if (base.TemplatedParent is global::DevComponents.WpfRibbon.RibbonBar)
						{
							num = (short)1667694611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14AF;
					case 46:
						num = (short)1435041876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (buttonDropDown.ExpandPosition == global::DevComponents.WpfRibbon.eExpandPosition.Top)
						{
							num = (short)7405631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_956;
					case 48:
						num = (short)661585950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						if (num8 < 0)
						{
							num = (short)1529217101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Controls.UIElementCollection internalChildren;
						buttonDropDown = (internalChildren[num8] as global::DevComponents.WpfRibbon.ButtonDropDown);
						num = (short)27000845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(0.0, num7))
						{
							num = (short)1378811992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14B6;
					case 51:
						if (this.m_ButtonDropDownCount < 2)
						{
							num = (short)1117454354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1617;
					case 52:
						goto IL_103A;
					case 53:
						if (base.IsItemsHost)
						{
							num = (short)252641338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14AF;
					case 54:
					{
						int num10;
						if (num10 > num9)
						{
							num = (short)1107820622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> list;
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown2 = list[num10];
						this.CreatePropertyBag(buttonDropDown2);
						buttonDropDown2.PartVisibility = global::DevComponents.WpfRibbon.eButtonPartVisibility.ImageOnly;
						buttonDropDown2.Measure(availableSize2);
						num3++;
						num = (short)274989085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						if (buttonDropDown.PartVisibility == global::DevComponents.WpfRibbon.eButtonPartVisibility.ImageAndHeader)
						{
							num = (short)1158873178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1513;
					case 56:
						goto IL_FF9;
					case 57:
						num = (short)666828867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						num = (short)615383085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						goto IL_374;
					case 60:
					{
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> list;
						list.Add(buttonDropDown);
						num = (short)20381775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
					{
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.Gallery>.Enumerator enumerator = this.m_Galleries.GetEnumerator();
						num = (short)218890252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						if (num8 == 0)
						{
							num = (short)525664267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					case 63:
						goto IL_114A;
					case 64:
						if (buttonDropDown.HasImage)
						{
							num = (short)430309465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1513;
					case 65:
						num = (short)1072365569;
						if (num != 0)
						{
						}
						if (num7 != double.PositiveInfinity)
						{
							num = (short)803143754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_647;
					case 66:
						num = (short)206962735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (buttonDropDown.ImagePosition != global::DevComponents.WpfRibbon.eButtonImagePosition.Left)
						{
							num = (short)518979586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_374;
					case 68:
					{
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> list;
						list.Add(buttonDropDown);
						num = (short)1404960850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 69:
						goto IL_C33;
					case 70:
						goto IL_148A;
					case 71:
						if (buttonDropDown.HasHeader)
						{
							num = (short)415563848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144D;
					case 72:
						this.CreatePropertyBag(buttonDropDown);
						num = (short)1529282576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						num = (short)2009268250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
					{
						num7 -= buttonDropDown.DesiredSize.Height;
						num = (short)1689714688;
						short num11 = num;
						num = (short)259588171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 75:
						goto IL_647;
					case 76:
					{
						int num10;
						if (num10 == num9)
						{
							num = (short)437190692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						width2 = availableSize2.Width;
						availableSize2.Width = width2 + 1.0;
						num10++;
						num = (short)1196228660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 77:
						num = (short)763887660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						num = (short)484180021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						goto IL_148A;
					case 80:
						goto IL_148A;
					case 81:
						if (buttonDropDown.ExpandPosition != global::DevComponents.WpfRibbon.eExpandPosition.Bottom)
						{
							num = (short)1143799874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114A;
					case 82:
						goto IL_706;
					case 83:
						goto IL_1617;
					case 84:
						if (!this.IsRibbonBarPanelMeasure)
						{
							num = (short)2036006968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C8;
					case 85:
						if (this.HasGallery)
						{
							num = (short)1138884703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_109F;
					case 86:
						goto IL_103A;
					case 87:
						num = (short)1832714338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						num = (short)693829694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						num = (short)1693712439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						num = (short)990511111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
					{
						global::DevComponents.WpfRibbon.eAutoSizeHint minAutoSizeHint;
						if (minAutoSizeHint == global::DevComponents.WpfRibbon.eAutoSizeHint.Small)
						{
							num = (short)1805975609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1513;
					}
					case 92:
						if (buttonDropDown.ImagePosition == global::DevComponents.WpfRibbon.eButtonImagePosition.Right)
						{
							num = (short)1727397947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1513;
					case 93:
					{
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.ButtonDropDown> list;
						if (list.Count == 0)
						{
							num = (short)145424394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7 = availableSize.Height;
						num3 = 0;
						num9 = list.Count - 1;
						int num10 = 0;
						num = (short)304939094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 94:
						goto IL_956;
					case 95:
					{
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.Gallery>.Enumerator enumerator = this.m_Galleries.GetEnumerator();
						num = (short)1186267156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 96:
						goto IL_148A;
					case 97:
						goto IL_1FC;
					case 98:
						if (buttonDropDown.ImagePosition == global::DevComponents.WpfRibbon.eButtonImagePosition.Bottom)
						{
							num = (short)1260912646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144D;
					}
					IL_1D3:
					if (!this.IsSecondMeasurePass)
					{
						num = (short)891617326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF9;
					IL_1FC:
					num = (short)928579633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_374:
					num = (short)1081999424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_605:
					num = (short)1905131613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_647:
					num = (short)1378025477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_706:
					buttonDropDown.ImagePosition = global::DevComponents.WpfRibbon.eButtonImagePosition.Left;
					buttonDropDown.UseSmallImage = true;
					num = (short)1504641105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_859:
					num = (short)224985127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_89B:
					width2 = availableSize2.Width;
					availableSize2.Width = width2 + 1.0;
					num = (short)1082261538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_956:
					buttonDropDown.Measure(availableSize2);
					num3++;
					num = (short)627703873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C33:
					num = (short)1142095922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FF9:
					num = (short)356450355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103A:
					num = (short)1330577462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_109F:
					num8 = num9;
					num = (short)356319329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_114A:
					buttonDropDown.ExpandPosition = global::DevComponents.WpfRibbon.eExpandPosition.Right;
					num = (short)924713054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1170:
					result = this.MeasureDefault(availableSize, false);
					num = (short)1657995272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_144D:
					num = (short)2052325467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_148A:
					num8--;
					num = (short)252837915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14B6:
					num3 = 0;
					num7 = availableSize.Height;
					result3 = this.MeasureDefault(availableSize, false);
					num = (short)531890217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1513:
					num = (short)16056343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1617:
					num = (short)739967008;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_46F:
				goto IL_14AF;
				IL_600:
				return result;
				IL_642:
				return this.MeasureDefault(availableSize, false);
				IL_951:
				return result3;
				IL_10C8:
				return this.MeasureDefault(availableSize);
				IL_14AF:
				return this.m_LastCalculatedSize;
				IL_1653:
				goto IL_10C8;
			}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00038CF8 File Offset: 0x00036EF8
		private bool IsSecondMeasurePass
		{
			get
			{
				short num = (short)956235777;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				int num2;
				global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
				for (;;)
				{
					IL_34:
					switch (num2)
					{
					case 0:
						for (;;)
						{
							num = (short)432675088;
							short num3 = num;
							num = (short)626923792;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_C9;
							}
						}
						IL_C9:
						num = (short)2140930048;
						if (num != 0)
						{
						}
						num = (short)1442643969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (ribbonBar != null)
						{
							num = (short)1630142467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						if (base.IsItemsHost)
						{
							num = (short)1647640576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						goto IL_115;
					}
					goto IL_4A;
				}
				IL_115:
				num = (short)2104950784;
				short num4 = num;
				return ribbonBar.IsSecondMeasurePass;
				IL_4A:
				ribbonBar = (base.TemplatedParent as global::DevComponents.WpfRibbon.RibbonBar);
				num = (short)2002911234;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00038E4C File Offset: 0x0003704C
		private bool IsRibbonBarPanelMeasure
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)28675840;
						short num3 = num2;
						num2 = (short)1554288384;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1778515968;
							if (num2 != 0)
							{
							}
							if (base.IsItemsHost)
							{
								num2 = (short)2131951618;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return false;
						}
						break;
					}
					case 1:
						goto IL_13B;
					case 2:
						num2 = (short)2008154115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (ribbonBar != null)
						{
							num2 = (short)1790312449;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					goto IL_20;
				}
				IL_13B:
				return ribbonBar.IsRibbonBarPanelMeasure;
				IL_20:
				num2 = (short)1842806784;
				short num4 = num2;
				num2 = (short)984743937;
				if (num2 != 0)
				{
				}
				ribbonBar = (base.TemplatedParent as global::DevComponents.WpfRibbon.RibbonBar);
				num2 = (short)815529984;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00038F98 File Offset: 0x00037198
		private global::System.Windows.Size GetMeasureSize(global::System.Windows.Size availableSize)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::System.Windows.Size result;
			short num2;
			double fixedHeight;
			double fixedWidth;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					num2 = (short)1236074496;
					short num3 = num2;
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(fixedHeight))
					{
						num2 = (short)179044360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 2:
				{
					num2 = (short)819583611;
					short num4 = num2;
					num2 = (short)1434638971;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1398865920;
						if (num2 != 0)
						{
						}
						result.Width = fixedWidth;
						num2 = (short)847249413;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (!double.IsNaN(fixedWidth))
					{
						num2 = (short)1851523076;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E9;
				case 4:
					num2 = (short)959578121;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_E9;
				case 6:
					num2 = (short)1623326721;
					if (num2 != 0)
					{
					}
					num2 = (short)1574109185;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (!double.IsNaN(fixedHeight))
					{
						num2 = (short)1534984198;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 8:
					result.Height = fixedHeight;
					num2 = (short)1864564736;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(fixedWidth))
					{
						num2 = (short)692977666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E9;
				}
				goto IL_38;
				IL_E9:
				num2 = (short)1699545095;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_38:
			fixedWidth = this.FixedWidth;
			fixedHeight = this.FixedHeight;
			result = availableSize;
			num2 = (short)1604124675;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000391C4 File Offset: 0x000373C4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1974272000;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					return finalSize;
				case 2:
					num = (short)763887619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)91881473;
					if (num != 0)
					{
					}
					if (this.IsDesignMode)
					{
						goto IL_119;
					}
					goto IL_132;
				}
				IL_34:
				num = (short)298764941;
				short num3 = num;
				num = (short)1121176205;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_119:
					num = (short)1824980993;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)924909568;
					if (num != 0)
					{
					}
					if (base.Children.Count != 0)
					{
						goto IL_132;
					}
					num = (short)488701952;
					short num4 = num;
					num = (short)1974992898;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return finalSize;
			IL_132:
			return this.ArrangeInternal(new global::System.Windows.Rect(finalSize));
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00039310 File Offset: 0x00037510
		private bool GetResizeGallery(global::System.Windows.UIElement elem)
		{
			short num = (short)1259929600;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 1:
					num = (short)1879375877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return true;
				case 3:
				{
					num = (short)502071297;
					if (num != 0)
					{
					}
					num = (short)307167232;
					short num3 = num;
					num = (short)680529567;
					short num4 = num;
					num = (short)1002507935;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1723727872;
						if (num != 0)
						{
						}
						num = (short)169803780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (!((global::DevComponents.WpfRibbon.Gallery)elem).IsCollapsed)
					{
						num = (short)681574402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					if (((global::DevComponents.WpfRibbon.Gallery)elem).IsCollapsible)
					{
						num = (short)86966275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_3E:
				if (!(elem is global::DevComponents.WpfRibbon.Gallery))
				{
					return false;
				}
				num = (short)1976762369;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000394A4 File Offset: 0x000376A4
		protected virtual global::System.Windows.Size ArrangeInternal(global::System.Windows.Rect finalRect)
		{
			short num = (short)25690112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_F3;
				}
				bool flag;
				global::System.Windows.Point location;
				global::System.Windows.Size lineSize;
				global::System.Windows.Size size;
				int num4;
				global::System.Windows.Controls.UIElementCollection internalChildren;
				int num6;
				int num7;
				bool useLineSize;
				for (;;)
				{
					IL_28:
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_799;
					case 1:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)2044395521;
							if (num != 0)
							{
							}
							num = (short)1899364366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_611;
					}
					case 2:
						if (flag)
						{
							num = (short)1184497668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_598;
					case 3:
						if (base.VerticalAlignment == global::System.Windows.VerticalAlignment.Bottom)
						{
							goto IL_87D;
						}
						goto IL_275;
					case 4:
						num = (short)105316397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						location.Y += lineSize.Height;
						num = (short)141295639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						location.Y += (size.Height - this.m_RealCalculatedSize.Height) / 2.0;
						num = (short)484048943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_275;
					case 8:
					{
						if (num3 > num4)
						{
							num = (short)129695775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = internalChildren[num3];
						num = (short)1684144129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (flag)
						{
							num = (short)1408040965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						location.X += lineSize.Width;
						num = (short)192282636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						if (flag)
						{
							num = (short)1564606504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Size size2;
						lineSize.Height += size2.Height;
						lineSize.Width = global::System.Math.Max(size2.Width, lineSize.Width);
						num = (short)1321795614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						num = (short)742497031;
						short num5 = num;
						num = (short)303471367;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_87D;
						default:
							num = (short)86769664;
							if (num != 0)
							{
							}
							location.Y += size.Height - this.m_RealCalculatedSize.Height;
							num = (short)1827995655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_6C6;
					case 13:
						if (!flag)
						{
							num = (short)776273944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E5;
					case 14:
					{
						global::System.Windows.UIElement uielement;
						global::System.Windows.Size size2 = new global::System.Windows.Size(global::System.Math.Round(uielement.DesiredSize.Width), global::System.Math.Round(uielement.DesiredSize.Height));
						num = (short)1023213609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::System.Windows.Size size2;
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(lineSize.Height + size2.Height, size.Height))
						{
							num = (short)1756364844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E5;
					}
					case 16:
						goto IL_799;
					case 17:
						goto IL_8E5;
					case 18:
						goto IL_3FF;
					case 19:
						num = (short)829292590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (num6 - num7 == 0)
						{
							num = (short)754319393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_335;
					case 21:
						if (lineSize.Height * 1.5 >= size.Height)
						{
							num = (short)418906160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_335;
					case 22:
						goto IL_598;
					case 23:
						goto IL_6C6;
					case 24:
						num = (short)225771535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::System.Windows.Size size2;
						size2.Height = size.Height;
						num = (short)1978400810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_611;
					case 27:
						if (num6 - num7 == 0)
						{
							num = (short)1001259040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FF;
					case 28:
						if (base.VerticalAlignment == global::System.Windows.VerticalAlignment.Center)
						{
							num = (short)304152582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)257032195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)1332871188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_611;
					case 31:
						num = (short)891813925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1109327910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1133510677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_335;
					case 35:
						lineSize.Height = size.Height;
						num = (short)389480466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1368064027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (num7 <= num4)
						{
							num = (short)1704001555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return size;
					case 38:
						if (lineSize.Height * 1.5 >= size.Height)
						{
							num = (short)312279075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FF;
					case 39:
						if (!flag)
						{
							num = (short)456720413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_335;
					case 40:
					{
						global::System.Windows.Size size2;
						lineSize.Width += size2.Width;
						lineSize.Height = global::System.Math.Max(size2.Height, lineSize.Height);
						num = (short)1118896154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
					{
						global::System.Windows.UIElement uielement;
						if (this.GetResizeGallery(uielement))
						{
							num = (short)1777205273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_383;
					}
					case 42:
						goto IL_383;
					case 43:
						return size;
					case 44:
						goto IL_42C;
					case 45:
					{
						global::System.Windows.Size size2;
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(lineSize.Width + size2.Width, size.Width))
						{
							num = (short)1210908694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42C;
					}
					case 46:
						if (!flag)
						{
							num = (short)1746337828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FF;
					case 47:
						goto IL_275;
					case 48:
						lineSize.Height = size.Height;
						num = (short)2107637794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F3;
					IL_275:
					num3 = 0;
					num = (short)1334706192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_335:
					this.ArrangeSingleLine(location, num7, num6, lineSize, flag, useLineSize);
					num = (short)973668361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_383:
					num = (short)553058306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FF:
					this.ArrangeSingleLine(location, num7, num4, lineSize, flag, useLineSize);
					num = (short)223608875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42C:
					num6 = num3 - 1;
					num = (short)1116012583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_598:
					num = (short)1225195533;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_611:
					num3++;
					num = (short)20578304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C6:
					num7 = num3;
					num6 = num3;
					lineSize = new global::System.Windows.Size(0.0, 0.0);
					num = (short)1363279889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_799:
					num = (short)1619394568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_87D:
					num = (short)1777139723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E5:
					num = (short)1668481024;
					short num8 = num;
					num = (short)1625948170;
					num2 = (int)((global::System.IntPtr)num);
				}
				return size;
				IL_F3:
				internalChildren = base.InternalChildren;
				num4 = internalChildren.Count - 1;
				size = finalRect.Size;
				flag = (this.Orientation == global::DevComponents.WpfRibbon.eButtonPanelOrientation.Horizontal);
				lineSize = new global::System.Windows.Size(0.0, 0.0);
				num7 = 0;
				num6 = 0;
				location = finalRect.Location;
				useLineSize = (base.HorizontalAlignment == global::System.Windows.HorizontalAlignment.Stretch);
				num = (short)697696284;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00039E5C File Offset: 0x0003805C
		private void ArrangeSingleLine(global::System.Windows.Point currentLocation, int lineStart, int lineEnd, global::System.Windows.Size lineSize, bool horizontal, bool useLineSize)
		{
			short num = (short)944242689;
			if (num != 0)
			{
			}
			num = (short)166264832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B5;
				}
				int num5;
				global::System.Windows.Controls.UIElementCollection internalChildren;
				for (;;)
				{
					IL_4E:
					global::System.Windows.Rect empty;
					global::System.Windows.UIElement uielement;
					global::System.Windows.Size desiredSize;
					switch (num2)
					{
					case 0:
						empty = global::System.Windows.Rect.Empty;
						num = (short)579797005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.GetResizeGallery(uielement))
						{
							num = (short)2096758802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D;
					case 2:
						if (lineEnd - lineStart == 0)
						{
							num = (short)793372084;
							short num3 = num;
							num = (short)552723892;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_356;
							case 1:
								break;
							default:
							{
								num = (short)688848896;
								short num4 = num;
								break;
							}
							}
							num = (short)993984512;
							if (num != 0)
							{
							}
							num = (short)1982136329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D7;
					case 3:
					{
						double x = currentLocation.X;
						double y = currentLocation.Y;
						desiredSize = uielement.DesiredSize;
						double width = desiredSize.Width;
						double height;
						if (!useLineSize)
						{
							desiredSize = uielement.DesiredSize;
							height = desiredSize.Height;
						}
						else
						{
							height = lineSize.Height;
						}
						empty = new global::System.Windows.Rect(x, y, width, height);
						num = (short)978190337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						empty.Height = lineSize.Height;
						num = (short)2123759623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_4D0;
					case 6:
						num = (short)1925906435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_3D7;
					case 8:
						goto IL_4B2;
					case 9:
						goto IL_356;
					case 10:
						goto IL_4D0;
					case 11:
						if (num5 > lineEnd)
						{
							num = (short)746323988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement = internalChildren[num5];
						num = (short)158138385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						empty.Height = lineSize.Height;
						num = (short)641794067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (horizontal)
						{
							num = (short)1643708422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1174601743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_46A;
					case 15:
					{
						double x2 = currentLocation.X;
						double y2 = currentLocation.Y;
						double width2;
						if (!useLineSize)
						{
							desiredSize = uielement.DesiredSize;
							width2 = desiredSize.Width;
						}
						else
						{
							width2 = lineSize.Width;
						}
						desiredSize = uielement.DesiredSize;
						empty = new global::System.Windows.Rect(x2, y2, width2, desiredSize.Height);
						num = (short)651427842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_21D;
					case 17:
						if (uielement != null)
						{
							num = (short)1154351104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B2;
					case 18:
						empty.Height = lineSize.Height;
						num = (short)1190395920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_43B;
					case 20:
						return;
					case 21:
						if (desiredSize.Height * 1.5 >= lineSize.Height)
						{
							num = (short)1781989380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D7;
					case 22:
						goto IL_46A;
					case 23:
						if (this.GetResizeGallery(uielement))
						{
							num = (short)890568716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43B;
					}
					goto IL_B5;
					IL_21D:
					currentLocation.X += empty.Width;
					num = (short)2096627734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_356:
					desiredSize = uielement.DesiredSize;
					num = (short)477429781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D7:
					num = (short)1504575511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43B:
					currentLocation.Y += empty.Height;
					num = (short)1888223246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46A:
					empty.Width = global::System.Math.Round(empty.Width);
					empty.Height = global::System.Math.Round(empty.Height);
					uielement.Arrange(empty);
					num = (short)507052040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B2:
					num5++;
					num = (short)403963914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D0:
					num = (short)14352395;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_B5:
				internalChildren = base.InternalChildren;
				num5 = lineStart;
				num = (short)1160118277;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0003A374 File Offset: 0x00038574
		private bool IsDesignMode
		{
			get
			{
				short num = (short)1989586322;
				short num2 = num;
				num = (short)2077535634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)279117824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1727987713;
				if (num != 0)
				{
				}
				num = (short)128122880;
				if (num != 0)
				{
				}
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0003A424 File Offset: 0x00038624
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)788712629;
					short num3 = num2;
					num2 = (short)1940769973;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D1;
					default:
						goto IL_176;
					}
					break;
				}
				case 1:
					if (visualAdded is global::DevComponents.WpfRibbon.Gallery)
					{
						num2 = (short)234029058;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					this.m_Galleries.Add(visualAdded as global::DevComponents.WpfRibbon.Gallery);
					num2 = (short)871694342;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)815464448;
					short num4 = num2;
					num2 = (short)92143617;
					if (num2 != 0)
					{
					}
					if (buttonDropDown is global::DevComponents.WpfRibbon.Gallery)
					{
						num2 = (short)647364608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
					goto IL_1D1;
				case 5:
					goto IL_B5;
				case 6:
					return;
				case 7:
					if (buttonDropDown.AutoSizeBag != null)
					{
						num2 = (short)1470496772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B5;
				case 8:
					buttonDropDown = (visualRemoved as global::DevComponents.WpfRibbon.ButtonDropDown);
					num2 = (short)2062548999;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (visualRemoved is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num2 = (short)1487929352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)510722049;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_B5:
				num2 = (short)555941891;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1D1:
				buttonDropDown.AutoSizeBag.RestoreSettings();
				buttonDropDown.AutoSizeBag = null;
				num2 = (short)384958469;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_176:
			num2 = (short)1738735616;
			if (num2 != 0)
			{
			}
			this.m_Galleries.Remove(buttonDropDown as global::DevComponents.WpfRibbon.Gallery);
			return;
			IL_38:
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
			num2 = (short)964362249;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0003A674 File Offset: 0x00038874
		private bool HasGallery
		{
			get
			{
				short num = (short)1485872732;
				short num2 = num;
				num = (short)405773916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)711983104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)376897537;
				if (num != 0)
				{
				}
				num = (short)283312128;
				if (num != 0)
				{
				}
				return this.m_Galleries.Count > 0;
			}
		}

		// Token: 0x040000D4 RID: 212
		public static readonly global::System.Windows.DependencyProperty OrientationProperty;

		// Token: 0x040000D5 RID: 213
		public static readonly global::System.Windows.DependencyProperty FixedWidthProperty;

		// Token: 0x040000D6 RID: 214
		public static readonly global::System.Windows.DependencyProperty FixedHeightProperty;

		// Token: 0x040000D7 RID: 215
		private bool m_AutoLayoutEnabled = true;

		// Token: 0x040000D8 RID: 216
		private const double HeightClosenessFactor = 1.5;

		// Token: 0x040000D9 RID: 217
		private int m_ButtonDropDownCount;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Size m_LastCalculatedSize;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Size m_RealCalculatedSize;

		// Token: 0x040000DC RID: 220
		private global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.Gallery> m_Galleries = new global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.Gallery>();
	}
}
