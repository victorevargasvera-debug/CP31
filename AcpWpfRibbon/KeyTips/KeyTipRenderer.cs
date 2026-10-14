using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace DevComponents.WpfRibbon.KeyTips
{
	// Token: 0x020000CE RID: 206
	internal abstract class KeyTipRenderer
	{
		// Token: 0x060008AD RID: 2221
		public abstract void Render(global::System.Windows.Media.DrawingContext dc, object elem, global::DevComponents.WpfRibbon.KeyTipRenderInfo info);

		// Token: 0x060008AE RID: 2222 RVA: 0x000C4E8C File Offset: 0x000C308C
		protected virtual bool HasKeyTip(global::System.Windows.UIElement e)
		{
			short num = (short)747503616;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string keyTip;
				switch (num2)
				{
				case 0:
					num = (short)763756545;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 1:
					if (keyTip.Length > 0)
					{
						num = (short)461373443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_123;
				case 2:
					num = (short)1060438017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return true;
				case 4:
				{
					IL_D4:
					num = (short)785645568;
					short num3 = num;
					if (keyTip != null)
					{
						num = (short)1147076610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_123;
				}
				case 5:
					return false;
				}
				IL_64:
				if (e == null)
				{
					num = (short)1936719877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				keyTip = global::DevComponents.WpfRibbon.Ribbon.GetKeyTip(e);
				num = (short)138543108;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_123:
				num = (short)246328351;
				short num4 = num;
				num = (short)968928287;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D4;
				default:
					goto IL_15A;
				}
			}
			return false;
			IL_15A:
			num = (short)399179776;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000C500C File Offset: 0x000C320C
		protected virtual void RecordActiveKeyTip(global::System.Windows.UIElement e, global::DevComponents.WpfRibbon.KeyTipRenderInfo info)
		{
			short num = (short)644415488;
			short num2 = num;
			num = (short)1035796482;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)875879004;
				short num4 = num;
				num = (short)425515612;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)124518400;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return;
					case 1:
						info.ActiveKeyTipsElements.Add(e);
						num = (short)407437312;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_41;
					}
					goto IL_A6;
				}
				IL_41:
				switch (0)
				{
				case 0:
					IL_A6:
					if (!e.IsEnabled)
					{
						return;
					}
					num = (short)275120129;
					if (num != 0)
					{
					}
					num = (short)1586888705;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000C512C File Offset: 0x000C332C
		protected virtual string GetKeyTipString(global::System.Windows.UIElement elem, global::DevComponents.WpfRibbon.KeyTipRenderInfo info)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (text != "")
					{
						num2 = (short)2110783491;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 1:
				{
					num2 = (short)1975558440;
					short num3 = num2;
					num2 = (short)793026856;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16F;
					default:
					{
						num2 = (short)1584594944;
						if (num2 != 0)
						{
						}
						num2 = (short)1712848896;
						short num4 = num2;
						num2 = (short)1703937;
						if (num2 != 0)
						{
						}
						if (!text.StartsWith(info.KeyTipsStack))
						{
							num2 = (short)398786564;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return text;
					}
					}
					break;
				}
				case 2:
					num2 = (short)707067905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1831731205;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_16F;
				case 5:
					if (info.KeyTipsStack != null)
					{
						num2 = (short)1614151682;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 6:
					return text;
				}
				goto IL_2C;
				IL_16F:
				text = "";
				num2 = (short)785645574;
				num = (int)((global::System.IntPtr)num2);
			}
			return text;
			IL_2C:
			text = global::DevComponents.WpfRibbon.Ribbon.GetKeyTip(elem);
			num2 = (short)1818558464;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000C52EC File Offset: 0x000C34EC
		protected virtual void RenderKeyTip(global::System.Windows.Media.DrawingContext dc, global::DevComponents.WpfRibbon.KeyTipRenderInfo info, global::System.Windows.UIElement e, global::System.Windows.Point loc)
		{
			short num = (short)243466240;
			switch (num)
			{
			default:
			{
				num = (short)458883075;
				int num2 = (int)((global::System.IntPtr)num);
				string keyTipString;
				global::System.Windows.Point point;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)153878534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (keyTipString == "")
						{
							num = (short)2134441993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(e as global::System.Windows.FrameworkElement);
						num = (short)1026555916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)2035941376;
						short num3 = num;
						num = (short)666632205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					case 4:
						point.X = loc.X;
						num = (short)1929445381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)2145560177;
						short num4 = num;
						num = (short)1914087025;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_337;
						default:
							num = (short)1440219136;
							if (num != 0)
							{
							}
							goto IL_2CE;
						}
						break;
					}
					case 6:
						if (!e.IsVisible)
						{
							num = (short)1695416336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						keyTipString = this.GetKeyTipString(e, info);
						num = (short)26345473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)365363211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_40C;
					case 9:
						return;
					case 10:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(loc.Y))
						{
							num = (short)1978400782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40F;
					case 11:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(loc.X))
						{
							num = (short)1941504004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CE;
					case 12:
						point = new global::System.Windows.Point((e.RenderSize.Width - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Width) / 2.0, e.RenderSize.Height - ((e is global::DevComponents.WpfRibbon.ButtonDropDown) ? (global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height / 2.0) : (global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height / 3.0)));
						point = e.PointToScreen(point);
						point = info.Adorner.PointFromScreen(point);
						point.X = global::System.Math.Round(point.X) + 0.5;
						point.Y = global::System.Math.Round(point.Y) + 0.5;
						num = (short)1063190543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (e.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)272302080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						goto IL_337;
					case 15:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(loc))
						{
							num = (short)27787271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40F;
					case 16:
						return;
					}
					IL_88:
					if (e != null)
					{
						num = (short)1743257602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_2CE:
					num = (short)1059520513;
					if (num != 0)
					{
					}
					num = (short)2020278282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_337:
					point.Y = loc.Y;
					num = (short)1483145224;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_40C:
				IL_40F:
				global::DevComponents.WpfRibbon.KeyTipColors colors = this.GetColors(e, info);
				this.RenderKeyTip(dc, new global::System.Windows.Rect(point, global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize), colors, info.Typeface, info.FontSize, keyTipString);
				return;
			}
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000C5734 File Offset: 0x000C3934
		protected virtual void RenderKeyTip(global::System.Windows.Media.DrawingContext dc, global::DevComponents.WpfRibbon.KeyTipRenderInfo info, global::System.Windows.UIElement e)
		{
			short num = (short)102472738;
			short num2 = num;
			num = (short)139566114;
			switch (num2 == num)
			{
			}
			num = (short)593035265;
			if (num != 0)
			{
			}
			num = (short)1943928832;
			if (num != 0)
			{
			}
			num = (short)572850176;
			short num3 = num;
			this.RenderKeyTip(dc, info, e, default(global::System.Windows.Point));
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000C57F0 File Offset: 0x000C39F0
		protected virtual void RenderKeyTip(global::System.Windows.Media.DrawingContext dc, global::System.Windows.Rect r, global::DevComponents.WpfRibbon.KeyTipColors c, global::System.Windows.Media.Typeface tf, double fontSize, string keyTip)
		{
			short num = (short)2133715335;
			short num2 = num;
			num = (short)1120004487;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_8D;
			default:
				num = (short)1217331201;
				if (num != 0)
				{
				}
				num = (short)443744256;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8D;
				}
				break;
			}
			int num3;
			global::System.Windows.Media.FormattedText formattedText;
			for (;;)
			{
				IL_7B:
				switch (num3)
				{
				case 0:
					goto IL_137;
				case 1:
				{
					r.Width = formattedText.Width + 4.0;
					num = (short)292093952;
					short num4 = num;
					num = (short)1640497152;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (formattedText.Width > r.Width)
					{
						num = (short)17891329;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_139;
				}
				goto IL_8D;
			}
			IL_137:
			IL_139:
			dc.DrawRoundedRectangle(c.Background, c.Border, r, 2.0, 2.0);
			global::System.Windows.Point origin = new global::System.Windows.Point(r.X + (r.Width - formattedText.Width) / 2.0, r.Y + (r.Height - formattedText.Height) / 2.0);
			dc.DrawText(formattedText, origin);
			return;
			IL_8D:
			formattedText = new global::System.Windows.Media.FormattedText(keyTip, global::System.Globalization.CultureInfo.CurrentCulture, global::System.Windows.FlowDirection.LeftToRight, tf, fontSize, c.Foreground);
			num = (short)1417084930;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7B;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000C59AC File Offset: 0x000C3BAC
		protected virtual global::DevComponents.WpfRibbon.KeyTipColors GetColors(global::System.Windows.UIElement elem, global::DevComponents.WpfRibbon.KeyTipRenderInfo info)
		{
			short num = (short)1331363840;
			short num2 = num;
			num = (short)960630970;
			short num3 = num;
			num = (short)1795297466;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1271463937;
				if (num != 0)
				{
				}
				num = (short)193069056;
				if (num != 0)
				{
				}
				if (elem.IsEnabled)
				{
					return info.EnabledColors;
				}
				break;
			}
			return info.DisabledColors;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000C5A80 File Offset: 0x000C3C80
		// Note: this type is marked as 'beforefieldinit'.
		static KeyTipRenderer()
		{
			short num = (short)344291056;
			short num2 = num;
			num = (short)600995568;
			switch (num2 == num)
			{
			}
			num = (short)486998016;
			if (num != 0)
			{
			}
			num = (short)1382547457;
			if (num != 0)
			{
			}
			num = (short)433258496;
			short num3 = num;
			global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize = new global::System.Windows.Size(15.0, 17.0);
		}

		// Token: 0x04000756 RID: 1878
		protected static global::System.Windows.Size DefaultKeyTipSize;
	}
}
