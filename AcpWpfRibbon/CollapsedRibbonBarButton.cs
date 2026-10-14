using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200001E RID: 30
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CollapsedRibbonBarButton : global::DevComponents.WpfRibbon.ButtonDropDown
	{
		// Token: 0x06000288 RID: 648 RVA: 0x0003B920 File Offset: 0x00039B20
		static CollapsedRibbonBarButton()
		{
			short num = (short)1642093171;
			short num2 = num;
			num = (short)2073713267;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1403060224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)958529536;
			if (num != 0)
			{
			}
			num = (short)780795905;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.CollapsedRibbonBarButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.CollapsedRibbonBarButton)));
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0003B9F0 File Offset: 0x00039BF0
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0003BAA0 File Offset: 0x00039CA0
		internal global::DevComponents.WpfRibbon.RibbonBar AttachedRibbonBar
		{
			get
			{
				short num = (short)687376250;
				short num2 = num;
				num = (short)1171752826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1342636032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)323682305;
				if (num != 0)
				{
				}
				num = (short)912392192;
				if (num != 0)
				{
				}
				return this.m_AttachedRibbonBar;
			}
			set
			{
				short num = (short)483459077;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.RemoveLogicalChild(this.m_AttachedRibbonBar);
						num = (short)2055798788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						base.AddLogicalChild(this.m_AttachedRibbonBar);
						goto IL_6A;
					case 3:
						if (this.m_AttachedRibbonBar != null)
						{
							num = (short)1520173058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)1091764225;
						if (num != 0)
						{
						}
						goto IL_83;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					}
					IL_3C:
					if (this.m_AttachedRibbonBar != null)
					{
						num = (short)494796800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83;
					IL_6A:
					num = (short)747241473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_83:
					this.m_AttachedRibbonBar = value;
					num = (short)1926189363;
					short num3 = num;
					num = (short)2086424883;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
					{
						num = (short)1861746688;
						if (num != 0)
						{
						}
						num = (short)960299008;
						short num4 = num;
						num = (short)1089470467;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0003BC38 File Offset: 0x00039E38
		protected override void HandleMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (e.ChangedButton == global::System.Windows.Input.MouseButton.Left)
					{
						num2 = (short)889192454;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C2;
				case 1:
					if (rect.Contains(e.GetPosition(this)))
					{
						num2 = (short)59113476;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C2;
				case 2:
					goto IL_A2;
				case 3:
				{
					num2 = (short)329908224;
					short num3 = num2;
					this.ClickHeader();
					num2 = (short)821362690;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)263377731;
					short num4 = num2;
					num2 = (short)511562563;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A7;
					default:
						num2 = (short)1121648640;
						if (num2 != 0)
						{
						}
						num2 = (short)1286471680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (this.AttachedRibbonBar != null)
					{
						num2 = (short)540409859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C2;
				case 6:
					num2 = (short)2144927745;
					if (num2 != 0)
					{
					}
					goto IL_A7;
				}
				goto IL_2C;
				IL_A7:
				num2 = (short)411500549;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A2:
			IL_1C2:
			e.Handled = true;
			return;
			IL_2C:
			rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			num2 = (short)250937345;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0003BE10 File Offset: 0x0003A010
		protected override bool HasVisibleItems
		{
			get
			{
				short num = (short)105421748;
				short num2 = num;
				num = (short)1152949172;
				switch (num2 == num)
				{
				default:
				{
					num = (short)801701888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1743781889;
				if (num != 0)
				{
				}
				num = (short)1484718080;
				if (num != 0)
				{
				}
				return this.AttachedRibbonBar != null;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0003BEC4 File Offset: 0x0003A0C4
		internal global::DevComponents.WpfRibbon.CollapsedRibbonBarPanel CollapsedRibbonBarPanel
		{
			get
			{
				int a_ = 13;
				short num = (short)1752510423;
				short num2 = num;
				num = (short)1300115415;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1666908160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1442119681;
				if (num != 0)
				{
				}
				num = (short)1833566208;
				if (num != 0)
				{
				}
				return base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㕤♦㭨㽪㉬ⱮṰὲᥴᙶॸࡺ᡼᭾펀쾌쎒練ﲘ", a_)) as global::DevComponents.WpfRibbon.CollapsedRibbonBarPanel;
			}
		}

		// Token: 0x040000DD RID: 221
		private global::DevComponents.WpfRibbon.RibbonBar m_AttachedRibbonBar;
	}
}
