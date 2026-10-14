using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000004 RID: 4
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ApplicationMenu : global::DevComponents.WpfRibbon.ButtonDropDown
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00007244 File Offset: 0x00005444
		private static void OnColorChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1119223809;
					if (num2 != 0)
					{
					}
					num2 = (short)805457735;
					short num3 = num2;
					num2 = (short)1603489607;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1812529152;
						if (num2 != 0)
						{
						}
						applicationMenu.OnColorChanged((global::DevComponents.WpfRibbon.eApplicationMenuColor)e.OldValue, (global::DevComponents.WpfRibbon.eApplicationMenuColor)e.NewValue);
						num2 = (short)164495362;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)697630720;
					short num4 = num2;
					if (applicationMenu != null)
					{
						num2 = (short)1367015424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			applicationMenu = (o as global::DevComponents.WpfRibbon.ApplicationMenu);
			num2 = (short)1558904833;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000737C File Offset: 0x0000557C
		protected virtual void OnColorChanged(global::DevComponents.WpfRibbon.eApplicationMenuColor oldValue, global::DevComponents.WpfRibbon.eApplicationMenuColor newValue)
		{
			short num = (short)1296510186;
			short num2 = num;
			num = (short)2088578282;
			switch (num2 == num)
			{
			}
			num = (short)757727232;
			short num3 = num;
			num = (short)1616379905;
			if (num != 0)
			{
			}
			num = (short)701759488;
			if (num != 0)
			{
			}
			this.UpdateColors();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000742C File Offset: 0x0000562C
		private void UpdateColors()
		{
			int a_ = 13;
			short num = (short)441319425;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string str;
				string str2;
				switch (num2)
				{
				case 0:
					if (this.EffectiveStyle != global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
					{
						num = (short)1487274001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					str = "";
					num = (short)725286927;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					continue;
				case 2:
					goto IL_3E8;
				case 3:
					if (this._OutterBorder != null)
					{
						num = (short)1367605262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A7;
				case 4:
					str2 = global::System.Enum.GetName(typeof(global::DevComponents.WpfRibbon.eApplicationMenuColor), this.Color);
					num = (short)1346961415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					if (base.IsMouseOver)
					{
						num = (short)1298661384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E8;
				case 7:
					goto IL_1F5;
				case 8:
					goto IL_EA;
				case 9:
				{
					num = (short)1531969536;
					short num3 = num;
					num = (short)1364393990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					if (this.Color != global::DevComponents.WpfRibbon.eApplicationMenuColor.Blue)
					{
						num = (short)1979842564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F5;
				case 11:
					if (this._InnerBorder != null)
					{
						num = (short)402128914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
				{
					if (base.IsKeyboardFocused)
					{
						goto IL_EA;
					}
					num = (short)1599941032;
					short num4 = num;
					num = (short)1921919400;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A7;
					default:
						num = (short)457768960;
						if (num != 0)
						{
						}
						num = (short)1754464265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					goto IL_1B6;
				case 14:
					this._OutterBorder.SetResourceReference(global::System.Windows.Controls.Border.BackgroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝤๦୨४ɬŮ≰ݲᑴն൸㥺ࡼ୾", a_) + str2 + str + global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩤ቦᵨὪ࡬ᵮ㍰ᱲݴ፶ᱸॺ㭼ᙾ", a_)));
					this._OutterBorder.SetResourceReference(global::System.Windows.Controls.Border.BorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝤๦୨४ɬŮ≰ݲᑴն൸㥺ࡼ୾", a_) + str2 + str + global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩤ቦᵨὪ࡬ᵮ㍰ᱲݴ፶ᱸॺ", a_)));
					num = (short)2117468181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (base.IsPopupOpen)
					{
						num = (short)1809645584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)336134156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					str = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁤ὦᥨ੪ͬ୮ᑰᝲ", a_);
					num = (short)585170966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_1F0;
				case 18:
					num = (short)563544065;
					if (num != 0)
					{
					}
					this._InnerBorder.SetResourceReference(global::System.Windows.Controls.Border.BackgroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝤๦୨४ɬŮ≰ݲᑴն൸㥺ࡼ୾", a_) + str2 + str + global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❤ࡦᵨὪɬɮ㥰ᩲቴὶᕸቺ᩼᝾", a_)));
					this._InnerBorder.SetResourceReference(global::System.Windows.Controls.Border.BorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝤๦୨४ɬŮ≰ݲᑴն൸㥺ࡼ୾", a_) + str2 + str + global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ɽ०ݨ๪Ὤ⵮ṰŲᅴቶ୸", a_)));
					num = (short)783679493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (this._OutterBorder != null)
					{
						num = (short)1558052877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 20:
					num = (short)1836843027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_3A7;
				case 22:
					goto IL_3E8;
				}
				IL_8B:
				if (this._InnerBorder == null)
				{
					num = (short)335216660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1B6;
				IL_EA:
				str = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⵤࡦὨ๪Ὤ", a_);
				num = (short)1114112002;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B6:
				num = (short)1965686784;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F5:
				num = (short)1088290819;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A7:
				num = (short)762839051;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E8:
				str2 = "";
				num = (short)1615134730;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_1F0:;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000795C File Offset: 0x00005B5C
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00007A1C File Offset: 0x00005C1C
		public global::DevComponents.WpfRibbon.eApplicationMenuColor Color
		{
			get
			{
				short num = (short)372576635;
				short num2 = num;
				num = (short)1399198075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1351090176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1599143936;
				if (num != 0)
				{
				}
				num = (short)752943105;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eApplicationMenuColor)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.ColorProperty);
			}
			set
			{
				short num = (short)1918378475;
				short num2 = num;
				num = (short)1313022443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)92078080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1887043584;
				if (num != 0)
				{
				}
				num = (short)522715137;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.ColorProperty, value);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00007AD4 File Offset: 0x00005CD4
		private static void OnBackstageUsesPopupChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FD;
				case 1:
				{
					num2 = (short)1128145393;
					short num3 = num2;
					num2 = (short)1382687217;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						num2 = (short)1369833473;
						if (num2 != 0)
						{
						}
						num2 = (short)476577792;
						if (num2 != 0)
						{
						}
						applicationMenu.OnBackstageUsesPopupChanged((bool)e.OldValue, (bool)e.NewValue);
						num2 = (short)954073088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (applicationMenu != null)
					{
						goto IL_3D;
					}
					goto IL_FF;
				}
				goto IL_1C;
				IL_3D:
				num2 = (short)1939800065;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FD:
			IL_FF:
			num2 = (short)2037972992;
			short num4 = num2;
			return;
			IL_1C:
			applicationMenu = (o as global::DevComponents.WpfRibbon.ApplicationMenu);
			num2 = (short)185925634;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00007C0C File Offset: 0x00005E0C
		protected virtual void OnBackstageUsesPopupChanged(bool oldValue, bool newValue)
		{
			short num = (short)503110880;
			short num2 = num;
			num = (short)1569053920;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1306132480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)679346177;
			if (num != 0)
			{
			}
			num = (short)142016512;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00007CB8 File Offset: 0x00005EB8
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00007D74 File Offset: 0x00005F74
		public bool BackstageUsesPopup
		{
			get
			{
				short num = (short)1340131895;
				short num2 = num;
				num = (short)388942391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1020788736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1881145344;
				if (num != 0)
				{
				}
				num = (short)1894973441;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.BackstageUsesPopupProperty);
			}
			set
			{
				short num = (short)302429944;
				short num2 = num;
				num = (short)2021832440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1715601408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1064632321;
				if (num != 0)
				{
				}
				num = (short)1371209728;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.BackstageUsesPopupProperty, value);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00007E34 File Offset: 0x00006034
		private static object OnCoerceBackstageTab(global::System.Windows.DependencyObject o, object value)
		{
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu = o as global::DevComponents.WpfRibbon.ApplicationMenu;
			if (applicationMenu != null)
			{
				short num = (short)1972646727;
				short num2 = num;
				num = (short)1181102919;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1908277248;
					short num3 = num;
					num = (short)948043777;
					if (num != 0)
					{
					}
					num = (short)287637504;
					if (num != 0)
					{
					}
					return applicationMenu.OnCoerceBackstageTab((global::System.Windows.UIElement)value);
				}
				}
			}
			return value;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00007EF8 File Offset: 0x000060F8
		private static void OnBackstageTabChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FD;
				case 1:
				{
					num2 = (short)1877622774;
					short num3 = num2;
					num2 = (short)1640775670;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					default:
						num2 = (short)645136384;
						if (num2 != 0)
						{
						}
						applicationMenu.OnBackstageTabChanged((global::System.Windows.UIElement)e.OldValue, (global::System.Windows.UIElement)e.NewValue);
						num2 = (short)270794752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)498860033;
					if (num2 != 0)
					{
					}
					if (applicationMenu != null)
					{
						goto IL_65;
					}
					goto IL_FF;
				}
				goto IL_1C;
				IL_65:
				num2 = (short)1289158657;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FD:
			IL_FF:
			num2 = (short)2121334784;
			short num4 = num2;
			return;
			IL_1C:
			applicationMenu = (o as global::DevComponents.WpfRibbon.ApplicationMenu);
			num2 = (short)967770114;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00008030 File Offset: 0x00006230
		protected virtual global::System.Windows.UIElement OnCoerceBackstageTab(global::System.Windows.UIElement value)
		{
			short num = (short)801308673;
			if (num != 0)
			{
			}
			num = (short)457768960;
			short num2 = num;
			num = (short)1692375009;
			short num3 = num;
			num = (short)1425053665;
			switch (num3 == num)
			{
			}
			num = (short)1776287744;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000080D8 File Offset: 0x000062D8
		protected virtual void OnBackstageTabChanged(global::System.Windows.UIElement oldValue, global::System.Windows.UIElement newValue)
		{
			short num = (short)627873899;
			short num2 = num;
			num = (short)48863339;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_CF:
				if (!(newValue is global::DevComponents.WpfRibbon.Backstage))
				{
					return;
				}
				num = (short)1324351488;
				short num3 = num;
				num = (short)1412694016;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)906559488;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				break;
			}
			for (;;)
			{
				IL_54:
				switch (num4)
				{
				case 0:
					num = (short)670498817;
					if (num != 0)
					{
					}
					((global::DevComponents.WpfRibbon.Backstage)newValue).ApplicationMenu = this;
					num = (short)1333133317;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_BA;
				case 2:
					if (((global::DevComponents.WpfRibbon.Backstage)oldValue).ApplicationMenu == this)
					{
						num = (short)1805320198;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BA;
				case 3:
					if (oldValue is global::DevComponents.WpfRibbon.Backstage)
					{
						num = (short)314572807;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BA;
				case 4:
					goto IL_CF;
				case 5:
					goto IL_1D7;
				case 6:
					((global::DevComponents.WpfRibbon.Backstage)oldValue).ApplicationMenu = null;
					num = (short)459145217;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)803209218;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_7A;
				IL_BA:
				num = (short)706609156;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_1D7:
			return;
			IL_7A:
			base.CoerceValue(global::DevComponents.WpfRibbon.ApplicationMenu.IsBackstageActiveProperty);
			num = (short)1485242371;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000082C0 File Offset: 0x000064C0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00008378 File Offset: 0x00006578
		public global::System.Windows.UIElement BackstageTab
		{
			get
			{
				short num = (short)1352307442;
				short num2 = num;
				num = (short)894407410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1344208896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)875954176;
				if (num != 0)
				{
				}
				num = (short)974651393;
				if (num != 0)
				{
				}
				return (global::System.Windows.UIElement)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.BackstageTabProperty);
			}
			set
			{
				short num = (short)289800193;
				if (num != 0)
				{
				}
				num = (short)75366400;
				short num2 = num;
				num = (short)1726722389;
				short num3 = num;
				num = (short)1864020309;
				switch (num3 == num)
				{
				}
				num = (short)1536294912;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.BackstageTabProperty, value);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00008430 File Offset: 0x00006630
		private static object OnCoerceBackstageEnabled(global::System.Windows.DependencyObject o, object value)
		{
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu = o as global::DevComponents.WpfRibbon.ApplicationMenu;
			if (applicationMenu != null)
			{
				short num = (short)1528878645;
				short num2 = num;
				num = (short)1317459509;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)50593792;
					short num3 = num;
					num = (short)986644481;
					if (num != 0)
					{
					}
					num = (short)31588352;
					if (num != 0)
					{
					}
					return applicationMenu.OnCoerceBackstageEnabled((bool)value);
				}
				}
			}
			return value;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00008500 File Offset: 0x00006700
		private static void OnBackstageEnabledChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FE;
				case 1:
				{
					num2 = (short)1763180783;
					short num3 = num2;
					num2 = (short)64094447;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						num2 = (short)1450377216;
						if (num2 != 0)
						{
						}
						num2 = (short)813498369;
						if (num2 != 0)
						{
						}
						applicationMenu.OnBackstageEnabledChanged((bool)e.OldValue, (bool)e.NewValue);
						num2 = (short)931528704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (applicationMenu != null)
					{
						goto IL_3E;
					}
					goto IL_100;
				}
				goto IL_1C;
				IL_3E:
				num2 = (short)690814977;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FE:
			IL_100:
			num2 = (short)394002432;
			short num4 = num2;
			return;
			IL_1C:
			applicationMenu = (o as global::DevComponents.WpfRibbon.ApplicationMenu);
			num2 = (short)1186988034;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00008638 File Offset: 0x00006838
		protected virtual bool OnCoerceBackstageEnabled(bool value)
		{
			short num = (short)575864833;
			if (num != 0)
			{
			}
			num = (short)1622802432;
			short num2 = num;
			num = (short)612242373;
			short num3 = num;
			num = (short)1169953733;
			switch (num3 == num)
			{
			}
			num = (short)1186201600;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000086E8 File Offset: 0x000068E8
		protected virtual void OnBackstageEnabledChanged(bool oldValue, bool newValue)
		{
			short num = (short)911223896;
			short num2 = num;
			num = (short)109653080;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1029636096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)991166464;
			if (num != 0)
			{
			}
			num = (short)197066753;
			if (num != 0)
			{
			}
			base.CoerceValue(global::DevComponents.WpfRibbon.ApplicationMenu.IsBackstageActiveProperty);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000879C File Offset: 0x0000699C
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00008854 File Offset: 0x00006A54
		public bool BackstageEnabled
		{
			get
			{
				short num = (short)66137550;
				short num2 = num;
				num = (short)1488596430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2007760896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)720109569;
				if (num != 0)
				{
				}
				num = (short)2062155776;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.BackstageEnabledProperty);
			}
			set
			{
				short num = (short)785383425;
				if (num != 0)
				{
				}
				num = (short)1136918528;
				short num2 = num;
				num = (short)127679947;
				short num3 = num;
				num = (short)2114665931;
				switch (num3 == num)
				{
				}
				num = (short)743440384;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.BackstageEnabledProperty, value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000890C File Offset: 0x00006B0C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000089C4 File Offset: 0x00006BC4
		public bool IsBackstageActive
		{
			get
			{
				short num = (short)1184627085;
				short num2 = num;
				num = (short)540211597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)704380928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)186056704;
				if (num != 0)
				{
				}
				num = (short)458227713;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.IsBackstageActiveProperty);
			}
			internal set
			{
				short num = (short)145467110;
				short num2 = num;
				num = (short)729458406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1340145664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)982646784;
				if (num != 0)
				{
				}
				num = (short)1714290689;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.IsBackstageActivePropertyKey, value);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00008A80 File Offset: 0x00006C80
		private static void OnIsBackstageActiveChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FC;
				case 1:
				{
					num2 = (short)1350611448;
					short num3 = num2;
					num2 = (short)745386488;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						num2 = (short)2145845248;
						if (num2 != 0)
						{
						}
						applicationMenu.OnIsBackstageActiveChanged((bool)e.OldValue, (bool)e.NewValue);
						num2 = (short)1225916416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)1662976001;
					if (num2 != 0)
					{
					}
					if (applicationMenu != null)
					{
						goto IL_64;
					}
					goto IL_FE;
				}
				goto IL_1C;
				IL_64:
				num2 = (short)208207873;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FC:
			IL_FE:
			num2 = (short)1989869568;
			short num4 = num2;
			return;
			IL_1C:
			applicationMenu = (o as global::DevComponents.WpfRibbon.ApplicationMenu);
			num2 = (short)1688731650;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00008BB4 File Offset: 0x00006DB4
		protected virtual void OnIsBackstageActiveChanged(bool oldValue, bool newValue)
		{
			short num = (short)1903286927;
			short num2 = num;
			num = (short)1549982351;
			switch (num2 == num)
			{
			default:
			{
				num = (short)454361088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)353763329;
			if (num != 0)
			{
			}
			num = (short)1566900224;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00008C5C File Offset: 0x00006E5C
		private static object OnCoerceIsBackstageActive(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu = d as global::DevComponents.WpfRibbon.ApplicationMenu;
			if (applicationMenu != null)
			{
				short num = (short)1024634056;
				short num2 = num;
				num = (short)1016769736;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)903806976;
					short num3 = num;
					num = (short)834404352;
					if (num != 0)
					{
					}
					num = (short)2057502721;
					if (num != 0)
					{
					}
					return applicationMenu.CoerceIsBackstageActive((bool)baseValue);
				}
				}
			}
			return baseValue;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00008D24 File Offset: 0x00006F24
		private object CoerceIsBackstageActive(bool value)
		{
			short num = (short)735510529;
			if (num != 0)
			{
			}
			num = (short)1726873600;
			short num2 = num;
			num = (short)290914307;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_AC;
				case 1:
					goto IL_DD;
				case 2:
					if (this.BackstageEnabled)
					{
						num = (short)839516161;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_87;
					}
					continue;
				}
				IL_87:
				if (this.BackstageTab != null)
				{
					num = (short)1343094784;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_DF;
				IL_AC:
				num = (short)516882434;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_DF:
				num = (short)1041279513;
				short num4 = num;
				num = (short)1483975193;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AC;
				default:
					goto IL_114;
				}
			}
			IL_DD:
			return true;
			IL_114:
			num = (short)1090060288;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00008E64 File Offset: 0x00007064
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00008F1C File Offset: 0x0000711C
		public global::DevComponents.WpfRibbon.eRibbonVisualStyle VisualStyle
		{
			get
			{
				short num = (short)776994817;
				if (num != 0)
				{
				}
				num = (short)10354688;
				short num2 = num;
				num = (short)726753252;
				short num3 = num;
				num = (short)114712548;
				switch (num3 == num)
				{
				}
				num = (short)569311232;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eRibbonVisualStyle)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.VisualStyleProperty);
			}
			set
			{
				short num = (short)94147765;
				short num2 = num;
				num = (short)942314677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1212153856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)64749568;
				if (num != 0)
				{
				}
				num = (short)499122177;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.VisualStyleProperty, value);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00008FD8 File Offset: 0x000071D8
		private static void OnVisualStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)175439873;
			if (num != 0)
			{
			}
			num = (short)782237696;
			short num2 = num;
			num = (short)357356102;
			short num3 = num;
			num = (short)1799279174;
			switch (num3 == num)
			{
			}
			num = (short)1672478720;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ApplicationMenu)o).OnVisualStyleChanged((global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.OldValue, (global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.NewValue);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000090A4 File Offset: 0x000072A4
		private void OnVisualStyleChanged(global::DevComponents.WpfRibbon.eRibbonVisualStyle oldValue, global::DevComponents.WpfRibbon.eRibbonVisualStyle newValue)
		{
			short num = (short)290914309;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Black)
					{
						num = (short)597229569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_167;
				case 1:
					goto IL_129;
				case 2:
					num = (short)288555012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)797507584;
					short num3 = num;
					num = (short)1762525184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Blue)
					{
						num = (short)773718019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C6;
				case 5:
				{
					num = (short)1755892576;
					short num4 = num;
					num = (short)372296544;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_129;
					default:
						num = (short)133038080;
						if (num != 0)
						{
						}
						num = (short)1950875649;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					}
					break;
				}
				}
				IL_AB:
				if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Silver)
				{
					break;
				}
				num = (short)742916098;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C6:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010;
			return;
			IL_129:
			goto IL_C6;
			IL_167:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00009220 File Offset: 0x00007420
		private bool IsDesignMode
		{
			get
			{
				short num = (short)1619396695;
				short num2 = num;
				num = (short)2052786263;
				switch (num2 == num)
				{
				default:
				{
					num = (short)427163648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1353187329;
				if (num != 0)
				{
				}
				num = (short)422969344;
				if (num != 0)
				{
				}
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000092D4 File Offset: 0x000074D4
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000938C File Offset: 0x0000758C
		public global::DevComponents.WpfRibbon.eEffectiveStyle EffectiveStyle
		{
			get
			{
				short num = (short)471594096;
				short num2 = num;
				num = (short)2098721904;
				switch (num2 == num)
				{
				default:
				{
					num = (short)771293184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)586285057;
				if (num != 0)
				{
				}
				num = (short)1044119552;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eEffectiveStyle)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.EffectiveStyleProperty);
			}
			internal set
			{
				short num = (short)918764500;
				short num2 = num;
				num = (short)2138651604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767964672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)896401409;
				if (num != 0)
				{
				}
				num = (short)1730609152;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.EffectiveStylePropertyKey, value);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00009448 File Offset: 0x00007648
		private static void OnEffectiveStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FB;
				case 1:
				{
					num2 = (short)704736950;
					short num3 = num2;
					num2 = (short)639790774;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						num2 = (short)420151297;
						if (num2 != 0)
						{
						}
						num2 = (short)1297022976;
						if (num2 != 0)
						{
						}
						applicationMenu.OnEffectiveStyleChanged((global::DevComponents.WpfRibbon.eEffectiveStyle)e.OldValue, (global::DevComponents.WpfRibbon.eEffectiveStyle)e.NewValue);
						num2 = (short)1493237760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (applicationMenu != null)
					{
						goto IL_3D;
					}
					goto IL_FD;
				}
				goto IL_1C;
				IL_3D:
				num2 = (short)1925316609;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FB:
			IL_FD:
			num2 = (short)314638336;
			short num4 = num2;
			return;
			IL_1C:
			applicationMenu = (o as global::DevComponents.WpfRibbon.ApplicationMenu);
			num2 = (short)72613890;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000957C File Offset: 0x0000777C
		protected virtual void OnEffectiveStyleChanged(global::DevComponents.WpfRibbon.eEffectiveStyle oldValue, global::DevComponents.WpfRibbon.eEffectiveStyle newValue)
		{
			short num = (short)1812070401;
			if (num != 0)
			{
			}
			num = (short)2086338560;
			short num2 = num;
			num = (short)435620506;
			short num3 = num;
			num = (short)1964247706;
			switch (num3 == num)
			{
			}
			num = (short)2109407232;
			if (num != 0)
			{
			}
			this.UpdateColors();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000962C File Offset: 0x0000782C
		private static void OnMruItemsChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FD;
				case 1:
				{
					num2 = (short)1383407301;
					short num3 = num2;
					num2 = (short)1382031045;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						num2 = (short)260767744;
						if (num2 != 0)
						{
						}
						applicationMenu.OnMruItemsChanged((global::System.Collections.ObjectModel.ObservableCollection<object>)e.OldValue, (global::System.Collections.ObjectModel.ObservableCollection<object>)e.NewValue);
						num2 = (short)1055326208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (applicationMenu != null)
					{
						goto IL_3E;
					}
					goto IL_FF;
				}
				goto IL_1C;
				IL_3E:
				num2 = (short)1191641089;
				if (num2 != 0)
				{
				}
				num2 = (short)971833345;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FD:
			IL_FF:
			num2 = (short)1352794112;
			short num4 = num2;
			return;
			IL_1C:
			applicationMenu = (o as global::DevComponents.WpfRibbon.ApplicationMenu);
			num2 = (short)855900162;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00009764 File Offset: 0x00007964
		protected virtual void OnMruItemsChanged(global::System.Collections.ObjectModel.ObservableCollection<object> oldValue, global::System.Collections.ObjectModel.ObservableCollection<object> newValue)
		{
			short num = (short)11534340;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					oldValue.CollectionChanged -= this.MruItemsCollectionChanged;
					num = (short)1093599234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if (newValue == null)
					{
						num = (short)418971651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1245152602;
					short num3 = num;
					num = (short)1364034906;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_13C;
					}
					break;
				}
				case 2:
					goto IL_AD;
				case 3:
					goto IL_DB;
				case 4:
					goto IL_14;
				}
				goto IL_5E;
				IL_14:
				num = (short)1441333249;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
				{
					IL_5E:
					if (oldValue == null)
					{
						goto IL_AD;
					}
					num = (short)100794368;
					short num4 = num;
					num = (short)475332608;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				continue;
				IL_AD:
				num = (short)1224278017;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DB:
			base.ClearValue(global::DevComponents.WpfRibbon.ApplicationMenu.HasMruItemsPropertyKey);
			return;
			IL_13C:
			num = (short)1376518144;
			if (num != 0)
			{
			}
			newValue.CollectionChanged += this.MruItemsCollectionChanged;
			this.HasMruItems = (newValue.Count > 0);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000098E4 File Offset: 0x00007AE4
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000099A0 File Offset: 0x00007BA0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.ObjectModel.ObservableCollection<object> MruItems
		{
			get
			{
				short num = (short)1072103424;
				short num2 = num;
				num = (short)1321349427;
				short num3 = num;
				num = (short)1978675507;
				switch (num3 == num)
				{
				}
				num = (short)368640001;
				if (num != 0)
				{
				}
				num = (short)127139840;
				if (num != 0)
				{
				}
				return (global::System.Collections.ObjectModel.ObservableCollection<object>)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.MruItemsProperty);
			}
			set
			{
				short num = (short)1540751360;
				short num2 = num;
				num = (short)790935547;
				short num3 = num;
				num = (short)529709051;
				switch (num3 == num)
				{
				}
				num = (short)2051735553;
				if (num != 0)
				{
				}
				num = (short)765526016;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.MruItemsProperty, value);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00009A58 File Offset: 0x00007C58
		static ApplicationMenu()
		{
			int a_ = 4;
			short num = (short)1581318144;
			short num2 = num;
			num = (short)1274430123;
			short num3 = num;
			num = (short)809255595;
			switch (num3 == num)
			{
			}
			num = (short)921108481;
			if (num != 0)
			{
			}
			num = (short)1183776768;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ApplicationMenu.ColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ὓㅝ౟ൡᙣ", a_), typeof(global::DevComponents.WpfRibbon.eApplicationMenuColor), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eApplicationMenuColor.Blue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnColorChanged)));
			global::DevComponents.WpfRibbon.ApplicationMenu.BackstageUsesPopupProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ṛ㽝͟ॡᝣብ१൩५㭭ͯ᝱ݳ♵᝷੹ॻ๽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnBackstageUsesPopupChanged)));
			global::DevComponents.WpfRibbon.ApplicationMenu.BackstageTabProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ṛ㽝͟ॡᝣብ१൩५㩭ᅯၱ", a_), typeof(global::System.Windows.UIElement), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnBackstageTabChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnCoerceBackstageTab)));
			global::DevComponents.WpfRibbon.ApplicationMenu.BackstageEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ṛ㽝͟ॡᝣብ१൩५⭭ṯ፱ᙳ᩵ᵷṹ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnBackstageEnabledChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnCoerceBackstageEnabled)));
			global::DevComponents.WpfRibbon.ApplicationMenu.IsBackstageActivePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕛⵝ≟͡ݣ൥᭧ṩ൫७ᕯ㍱ᝳɵᅷ౹᥻", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnIsBackstageActiveChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnCoerceIsBackstageActive)));
			global::DevComponents.WpfRibbon.ApplicationMenu.IsBackstageActiveProperty = global::DevComponents.WpfRibbon.ApplicationMenu.IsBackstageActivePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ApplicationMenu.VisualStyleProperty = global::DevComponents.WpfRibbon.Ribbon.VisualStyleProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Blue, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnVisualStyleChanged)));
			global::DevComponents.WpfRibbon.ApplicationMenu.EffectiveStylePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᥛ㡝ٟݡݣብŧᱩ५㵭ѯୱᡳ፵", a_), typeof(global::DevComponents.WpfRibbon.eEffectiveStyle), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnEffectiveStyleChanged)));
			global::DevComponents.WpfRibbon.ApplicationMenu.EffectiveStyleProperty = global::DevComponents.WpfRibbon.ApplicationMenu.EffectiveStylePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ApplicationMenu.MruItemsProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅛⱝᕟ⭡ၣͥէᥩ", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<object>), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ApplicationMenu.OnMruItemsChanged)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.ApplicationMenu)));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ApplicationMenu.HasMruItemsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᑛ㽝፟⽡ᙣ፥Ⅷṩ५ͭͯ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.PropertyMetadata(false));
			global::DevComponents.WpfRibbon.ApplicationMenu.HasMruItemsProperty = global::DevComponents.WpfRibbon.ApplicationMenu.HasMruItemsPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ApplicationMenu.AppItemsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵛ⹝ၟ⭡ၣͥէᥩ", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<object>), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.PropertyMetadata(new global::System.Collections.ObjectModel.ObservableCollection<object>()));
			global::DevComponents.WpfRibbon.ApplicationMenu.AppItemsProperty = global::DevComponents.WpfRibbon.ApplicationMenu.AppItemsPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ApplicationMenu.HasAppItemsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᑛ㽝፟⍡ᑣᙥⅧṩ५ͭͯ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.PropertyMetadata(false));
			global::DevComponents.WpfRibbon.ApplicationMenu.HasAppItemsProperty = global::DevComponents.WpfRibbon.ApplicationMenu.HasAppItemsPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.ApplicationMenu.MruItemTemplateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅛⱝᕟ⭡ၣͥէ㹩५ͭoṱᕳɵᵷ", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ApplicationMenu.MruItemTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅛⱝᕟ⭡ၣͥէ㹩५ͭoṱᕳɵᵷ⥹᥻ች慎", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ApplicationMenu.AppItemTemplateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵛ⹝ၟ⭡ၣͥէ㹩५ͭoṱᕳɵᵷ", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ApplicationMenu.AppItemTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵛ⹝ၟ⭡ၣͥէ㹩५ͭoṱᕳɵᵷ⥹᥻ች慎", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.ApplicationMenu.DoubleClickCloseProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᡛㅝᕟaࡣͥ⭧٩ի൭᭯ㅱᡳ᥵୷ό", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ApplicationMenu), new global::System.Windows.FrameworkPropertyMetadata(true));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00009F58 File Offset: 0x00008158
		public ApplicationMenu()
		{
			global::System.Collections.ObjectModel.ObservableCollection<object> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<object>();
			base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.MruItemsProperty, observableCollection);
			observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<object>();
			observableCollection.CollectionChanged += this.AppItemsCollectionChanged;
			base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.AppItemsPropertyKey, observableCollection);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00009FA4 File Offset: 0x000081A4
		public override void OnApplyTemplate()
		{
			int a_ = 8;
			short num = (short)999096320;
			short num2 = num;
			num = (short)385952018;
			short num3 = num;
			num = (short)244984082;
			switch (num3 == num)
			{
			}
			num = (short)1578631169;
			if (num != 0)
			{
			}
			num = (short)2054488064;
			if (num != 0)
			{
			}
			this._OutterBorder = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⽟⁡", a_)) as global::System.Windows.Controls.Border);
			this._InnerBorder = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⥟⁡", a_)) as global::System.Windows.Controls.Border);
			base.OnApplyTemplate();
			this.UpdateColors();
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000A0A0 File Offset: 0x000082A0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Collections.ObjectModel.ObservableCollection<object> AppItems
		{
			get
			{
				short num = (short)1457913856;
				short num2 = num;
				num = (short)670258676;
				short num3 = num;
				num = (short)1507087860;
				switch (num3 == num)
				{
				}
				num = (short)806879232;
				if (num != 0)
				{
				}
				num = (short)576913409;
				if (num != 0)
				{
				}
				return (global::System.Collections.ObjectModel.ObservableCollection<object>)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.AppItemsProperty);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000A158 File Offset: 0x00008358
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasAppItems
		{
			get
			{
				short num = (short)57212928;
				short num2 = num;
				num = (short)1797914625;
				if (num != 0)
				{
				}
				num = (short)1683721593;
				short num3 = num;
				num = (short)1592233337;
				switch (num3 == num)
				{
				}
				num = (short)556269568;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.HasAppItemsProperty);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000A214 File Offset: 0x00008414
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000A2CC File Offset: 0x000084CC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasMruItems
		{
			get
			{
				short num = (short)1904476160;
				short num2 = num;
				num = (short)1534772888;
				short num3 = num;
				num = (short)296994456;
				switch (num3 == num)
				{
				}
				num = (short)1199177728;
				if (num != 0)
				{
				}
				num = (short)459866113;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.HasMruItemsProperty);
			}
			private set
			{
				short num = (short)1877671936;
				short num2 = num;
				num = (short)990061336;
				short num3 = num;
				num = (short)814031640;
				switch (num3 == num)
				{
				}
				num = (short)1706295297;
				if (num != 0)
				{
				}
				num = (short)199032832;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.HasMruItemsPropertyKey, value);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000A388 File Offset: 0x00008588
		private void AppItemsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)475398144;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1060634629;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (e.OldItems != null)
						{
							num = (short)804192272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CE;
					case 1:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num = (short)1856110600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)374210560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.AppItems.Count > 0)
						{
							num = (short)154861581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76F;
					case 3:
						if (e.NewItems != null)
						{
							num = (short)854851604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_38D;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					case 6:
						try
						{
							num = (short)261881856;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4F0;
									}
									continue;
								case 1:
									num = (short)1199243267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_567;
								case 4:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1436614657;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object child = enumerator.Current;
									base.AddLogicalChild(child);
									num = (short)122552322;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_51A:
								num = (short)189071364;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F0:
								goto IL_51A;
							}
							IL_567:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_589;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_576:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)185991170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5E2;
								case 1:
									goto IL_5E0;
								case 2:
									disposable.Dispose();
									num = (short)2092564481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_589;
							}
							IL_5E0:
							IL_5E2:
							goto EndFinally_25;
							IL_589:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1448738816;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_576;
							EndFinally_25:;
						}
						goto IL_5E3;
					case 7:
						try
						{
							num = (short)1458831360;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_E7;
								case 2:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1279131652;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object child2 = enumerator.Current;
									base.RemoveLogicalChild(child2);
									num = (short)889585665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									num = (short)1610092021;
									short num3 = num;
									num = (short)1447169525;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_E7;
									default:
										goto IL_1B7;
									}
									break;
								}
								case 4:
									num = (short)638517251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_10C;
								IL_E7:
								switch (0)
								{
								case 0:
									IL_10C:
									goto IL_10E;
								}
								continue;
								IL_10E:
								num = (short)727777282;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B7:
							num = (short)133496832;
							if (num != 0)
							{
							}
							goto IL_3CE;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1EF;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1DC:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1582235649;
										if (num != 0)
										{
										}
										num = (short)1036124162;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_26F;
								case 1:
									goto IL_26D;
								case 2:
									disposable.Dispose();
									num = (short)1914961921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1EF;
							}
							IL_26D:
							IL_26F:
							goto EndFinally_24;
							IL_1EF:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)219021312;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1DC;
							EndFinally_24:;
						}
						goto Block_3;
					case 8:
						goto IL_5E3;
					case 9:
						goto IL_76F;
					case 10:
						base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.HasAppItemsPropertyKey, false);
						num = (short)1402929161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.HasAppItemsPropertyKey, true);
						num = (short)1934884888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1812922382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1939996689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
						{
							num = (short)2039087127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40E;
					case 15:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num = (short)1448476693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76F;
					case 16:
					{
						num = (short)820707328;
						short num4 = num;
						this.SetRole(e.OldItems, global::DevComponents.WpfRibbon.eElementRole.Default);
						global::System.Collections.IEnumerator enumerator = e.OldItems.GetEnumerator();
						num = (short)900071431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (!this.HasAppItems)
						{
							num = (short)1634336779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76F;
					case 18:
						if (this.HasAppItems)
						{
							num = (short)1881276426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EC;
					case 19:
						if (this.AppItems.Count == 0)
						{
							num = (short)864747524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EC;
					case 20:
					{
						this.SetRole(e.NewItems, global::DevComponents.WpfRibbon.eElementRole.AppMenuApplicationCommand);
						global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator();
						num = (short)2127888390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_40E;
					case 22:
						goto IL_270;
					case 23:
						num = (short)1791426575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_76F;
					}
					IL_A9:
					if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						num = (short)168427532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_40E;
					IL_38D:
					num = (short)95879186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					global::System.Collections.Generic.IEnumerator<object> enumerator2;
					try
					{
						IL_270:
						num = (short)1512374272;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2AA;
								}
								continue;
							case 1:
								num = (short)1785331715;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_31E;
							case 4:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)128516097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object child3 = enumerator2.Current;
								base.AddLogicalChild(child3);
								num = (short)152961026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_2D1:
							num = (short)1590099972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2AA:
							goto IL_2D1;
						}
						IL_31E:
						break;
					}
					finally
					{
						num = (short)2080374784;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_355;
								}
								continue;
							case 1:
								goto IL_38A;
							case 2:
								enumerator2.Dispose();
								num = (short)1331167233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_355:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)695926786;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_38A:;
					}
					goto IL_38D;
					IL_3CE:
					num = (short)1814495235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40E:
					num = (short)325255187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E3:
					this.SetRole(this.AppItems, global::DevComponents.WpfRibbon.eElementRole.AppMenuApplicationCommand);
					enumerator2 = this.AppItems.GetEnumerator();
					num = (short)1132199958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EC:
					num = (short)71827458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76F:
					num = (short)562561025;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000AC14 File Offset: 0x00008E14
		private void MruItemsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1278803968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)672661513;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.SetRole(e.NewItems, global::DevComponents.WpfRibbon.eElementRole.AppMenuMruItem);
						global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator();
						num = (short)864813084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (this.HasMruItems)
						{
							num = (short)509018125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_656;
					case 2:
						num = (short)658374666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						this.SetRole(e.OldItems, global::DevComponents.WpfRibbon.eElementRole.Default);
						global::System.Collections.IEnumerator enumerator = e.OldItems.GetEnumerator();
						num = (short)1860042774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_4C0;
					case 5:
						goto IL_311;
					case 6:
						if (!this.HasMruItems)
						{
							num = (short)241696795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C0;
					case 7:
					{
						num = (short)603652096;
						short num3 = num;
						this.SetRole(this.MruItems, global::DevComponents.WpfRibbon.eElementRole.AppMenuMruItem);
						global::System.Collections.Generic.IEnumerator<object> enumerator2 = this.MruItems.GetEnumerator();
						num = (short)346685460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (e.OldItems != null)
						{
							num = (short)1266089987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_B8;
						}
						continue;
					case 10:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num = (short)1375993861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C0;
					case 11:
						if (this.MruItems.Count > 0)
						{
							num = (short)634585111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C0;
					case 12:
						num = (short)2048786450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.HasMruItemsPropertyKey, false);
						num = (short)110493700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (e.NewItems != null)
						{
							num = (short)73007104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						num = (short)1756495893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)923533323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_28F;
					case 18:
						if (this.MruItems.Count == 0)
						{
							num = (short)43450385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_656;
					case 19:
						goto IL_4C0;
					case 20:
						try
						{
							num = (short)1125449729;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_21D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_152;
									}
									continue;
								case 2:
								{
									IL_1DD:
									global::System.Collections.Generic.IEnumerator<object> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1771438083;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object child = enumerator2.Current;
									base.AddLogicalChild(child);
									num = (short)62717956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)2128019456;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17A:
								num = (short)1031611141;
								short num4 = num;
								num = (short)2120950533;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1DD;
								default:
									num = (short)595263488;
									if (num != 0)
									{
									}
									num = (short)1050476546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_152:
								goto IL_17A;
							}
							IL_21D:
							return;
						}
						finally
						{
							num = (short)1099956224;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<object> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_255;
									}
									continue;
								case 1:
									goto IL_28C;
								case 2:
									enumerator2.Dispose();
									num = (short)88080385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_255:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)86245378;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_28C:;
						}
						goto IL_28F;
					case 21:
						if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
						{
							num = (short)564854786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311;
					case 22:
						try
						{
							num = (short)1636040705;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_788;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_715;
									}
									continue;
								case 2:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1075838979;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object child2 = enumerator.Current;
									base.RemoveLogicalChild(child2);
									num = (short)222560260;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)208011264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_73C:
								num = (short)670367746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_715:
								goto IL_73C;
							}
							IL_788:
							goto IL_2D0;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_7AA;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_797:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)2142306306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_82D;
								case 1:
									goto IL_82B;
								case 2:
									num = (short)599851009;
									if (num != 0)
									{
									}
									disposable.Dispose();
									num = (short)1403322369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7AA;
							}
							IL_82B:
							IL_82D:
							goto EndFinally_26;
							IL_7AA:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)577241088;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_797;
							EndFinally_26:;
						}
						goto IL_82E;
					case 23:
						num = (short)563347462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (this.MruItems != null)
						{
							num = (short)172294156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_656;
					case 25:
						if (this.MruItems != null)
						{
							num = (short)487915536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C0;
					case 26:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num = (short)667353095;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1664090120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_82E;
					case 28:
						try
						{
							num = (short)1838874625;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_444;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3CD;
									}
									continue;
								case 2:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1700462595;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object child3 = enumerator.Current;
									base.AddLogicalChild(child3);
									num = (short)1291714564;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)81592320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3F8:
								num = (short)1836515330;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3CD:
								goto IL_3F8;
							}
							IL_444:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_466;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_453:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1059586050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4BF;
								case 1:
									goto IL_4BD;
								case 2:
									disposable.Dispose();
									num = (short)302317569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_466;
							}
							IL_4BD:
							IL_4BF:
							goto EndFinally_25;
							IL_466:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)2020802560;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_453;
							EndFinally_25:;
						}
						goto IL_4C0;
					}
					IL_B8:
					if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						num = (short)583794703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_311;
					IL_28F:
					num = (short)169213953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D0:
					num = (short)1945829390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_311:
					num = (short)1522860056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C0:
					num = (short)1727725594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_656:
					num = (short)222167065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_82E:
					base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.HasMruItemsPropertyKey, true);
					num = (short)505151507;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000B544 File Offset: 0x00009744
		private void SetRole(global::System.Collections.IList col, global::DevComponents.WpfRibbon.eElementRole role)
		{
			short num;
			for (;;)
			{
				global::System.Collections.IEnumerator enumerator = col.GetEnumerator();
				try
				{
					num = (short)1723400195;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.FrameworkElement frameworkElement;
							if (frameworkElement != null)
							{
								num = (short)1356922886;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_F5;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1837170692;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.FrameworkElement frameworkElement = enumerator.Current as global::System.Windows.FrameworkElement;
							num = (short)1552089088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_49;
							}
							continue;
						case 4:
							num = (short)1897332737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Windows.FrameworkElement frameworkElement;
							global::DevComponents.WpfRibbon.Ribbon.SetElementRole(frameworkElement, role);
							num = (short)1537605637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_88:
						num = (short)1841299458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_49:
						goto IL_88;
					}
					IL_F5:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_113;
					}
					int num2;
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_101:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)802750466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_164;
						case 1:
							goto IL_162;
						case 2:
							disposable.Dispose();
							num = (short)1596653569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_113;
					}
					IL_162:
					IL_164:
					goto EndFinally_5;
					IL_113:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1572143104;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_101;
					EndFinally_5:;
				}
				num = (short)1892876288;
				short num3 = num;
				num = (short)2117114040;
				short num4 = num;
				num = (short)2101254328;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1C2;
				}
			}
			IL_1C2:
			num = (short)1238499329;
			if (num != 0)
			{
			}
			num = (short)1076363264;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000B760 File Offset: 0x00009960
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000B818 File Offset: 0x00009A18
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate MruItemTemplate
		{
			get
			{
				short num = (short)1038176467;
				short num2 = num;
				num = (short)1752781011;
				switch (num2 == num)
				{
				}
				num = (short)1524629505;
				if (num != 0)
				{
				}
				num = (short)177668096;
				if (num != 0)
				{
				}
				num = (short)2108424192;
				short num3 = num;
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.MruItemTemplateProperty);
			}
			set
			{
				short num = (short)1975978453;
				short num2 = num;
				num = (short)1939737045;
				switch (num2 == num)
				{
				}
				num = (short)779485184;
				if (num != 0)
				{
				}
				num = (short)1138229249;
				if (num != 0)
				{
				}
				num = (short)2069299200;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.MruItemTemplateProperty, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000B8CC File Offset: 0x00009ACC
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000B988 File Offset: 0x00009B88
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate AppItemTemplate
		{
			get
			{
				short num = (short)954007553;
				if (num != 0)
				{
				}
				num = (short)135863318;
				short num2 = num;
				num = (short)218242070;
				switch (num2 == num)
				{
				}
				num = (short)1851457536;
				if (num != 0)
				{
				}
				num = (short)481034240;
				short num3 = num;
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.AppItemTemplateProperty);
			}
			set
			{
				short num = (short)1628303784;
				short num2 = num;
				num = (short)290714024;
				switch (num2 == num)
				{
				}
				num = (short)1194459137;
				if (num != 0)
				{
				}
				num = (short)1442119680;
				if (num != 0)
				{
				}
				num = (short)792002560;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.AppItemTemplateProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000BA3C File Offset: 0x00009C3C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.DataTemplateSelector MruItemTemplateSelector
		{
			get
			{
				short num = (short)812910636;
				short num2 = num;
				num = (short)519768108;
				switch (num2 == num)
				{
				}
				num = (short)484245505;
				if (num != 0)
				{
				}
				num = (short)68681728;
				if (num != 0)
				{
				}
				num = (short)1423966208;
				short num3 = num;
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.MruItemTemplateSelectorProperty);
			}
			set
			{
				short num = (short)1564387126;
				short num2 = num;
				num = (short)745252662;
				switch (num2 == num)
				{
				}
				num = (short)1359872001;
				if (num != 0)
				{
				}
				num = (short)1619591168;
				if (num != 0)
				{
				}
				num = (short)139984896;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.MruItemTemplateSelectorProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000BBAC File Offset: 0x00009DAC
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000BC64 File Offset: 0x00009E64
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector AppItemTemplateSelector
		{
			get
			{
				short num = (short)2013855745;
				if (num != 0)
				{
				}
				num = (short)209933753;
				short num2 = num;
				num = (short)1561023929;
				switch (num2 == num)
				{
				}
				num = (short)485949440;
				if (num != 0)
				{
				}
				num = (short)2136604672;
				short num3 = num;
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.AppItemTemplateSelectorProperty);
			}
			set
			{
				short num = (short)1674151428;
				short num2 = num;
				num = (short)1320257028;
				switch (num2 == num)
				{
				}
				num = (short)340656129;
				if (num != 0)
				{
				}
				num = (short)112066560;
				if (num != 0)
				{
				}
				num = (short)1203044352;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.AppItemTemplateSelectorProperty, value);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000BD1C File Offset: 0x00009F1C
		protected override void OnPopupOpened(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1606025217;
			if (num != 0)
			{
			}
			num = (short)963213231;
			short num2 = num;
			num = (short)1319991215;
			switch (num2 == num)
			{
			}
			num = (short)1594687488;
			if (num != 0)
			{
			}
			num = (short)661258240;
			short num3 = num;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Loaded, new global::System.Windows.Threading.DispatcherOperationCallback(this.ShowCuesAfterRender), null);
			base.OnPopupOpened(e);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)496173063;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::DevComponents.WpfRibbon.Ribbon ribbon;
					global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(ribbon);
					num = (short)1911881733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (this._OverlayAdorner == null)
					{
						num = (short)416874502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23F;
				case 2:
				{
					global::DevComponents.WpfRibbon.Ribbon ribbon = base.Parent as global::DevComponents.WpfRibbon.Ribbon;
					num = (short)1107361793;
					if (num != 0)
					{
					}
					num = (short)625475584;
					short num3 = num;
					num = (short)1197801476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)2009741036;
					short num4 = num;
					num = (short)679687916;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1467023360;
						if (num != 0)
						{
						}
						num = (short)2081816577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
				{
					global::DevComponents.WpfRibbon.Ribbon ribbon;
					if (ribbon != null)
					{
						num = (short)1527644160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23F;
				}
				case 5:
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer;
					if (adornerLayer != null)
					{
						num = (short)589103114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23F;
				}
				case 6:
					num = (short)1166475273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 8:
					goto IL_201;
				case 9:
					if (!this.IsBackstageActive)
					{
						num = (short)700645378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23F;
				case 10:
				{
					global::DevComponents.WpfRibbon.Ribbon ribbon;
					this._OverlayAdorner = new global::DevComponents.WpfRibbon.ApplicationMenu.OverlayAdorner(ribbon);
					global::System.Windows.Documents.AdornerLayer adornerLayer;
					adornerLayer.Add(this._OverlayAdorner);
					num = (short)1541603336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_50:
				if (!base.IsPopupOpen)
				{
					break;
				}
				num = (short)1400307715;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_201:
			IL_23F:
			this.UpdateColors();
			base.OnMouseLeave(e);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000C040 File Offset: 0x0000A240
		protected override void OnPopupClosed(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1371406336;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1218445313;
					if (num != 0)
					{
					}
					num = (short)1638233378;
					short num3 = num;
					num = (short)1378448674;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A9;
					default:
						num = (short)2138308608;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_F7;
				case 2:
					(this._OverlayAdorner.Parent as global::System.Windows.Documents.AdornerLayer).Remove(this._OverlayAdorner);
					this._OverlayAdorner = null;
					num = (short)2094530561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_A1;
				IL_A9:
				num = (short)1283522562;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A1:
				if (this._OverlayAdorner != null)
				{
					goto IL_A9;
				}
				break;
			}
			IL_F7:
			num = (short)1676476416;
			short num4 = num;
			base.OnPopupClosed(e);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000C178 File Offset: 0x0000A378
		private object ShowCuesAfterRender(object arg)
		{
			int a_ = 0;
			short num = (short)918552576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::System.Windows.Controls.Primitives.Popup popup;
				for (;;)
				{
					IL_31:
					global::System.Windows.Point point2;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Shapes.Rectangle rectangle;
						global::System.Windows.Media.TranslateTransform translateTransform = (global::System.Windows.Media.TranslateTransform)rectangle.RenderTransform;
						global::System.Windows.Point point = popup.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
						point2 = rectangle.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
						num = (short)11075592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::DevComponents.WpfRibbon.Ribbon.ShowKeyboardCues(popup, true);
						global::System.Windows.Shapes.Rectangle rectangle = base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᥗ⩙ⱛᱝᕟᙡၣ॥٧㩩ͫṭկɱ⑳᝵੷๹", a_)) as global::System.Windows.Shapes.Rectangle;
						num = (short)2134179844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1521876995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (popup.IsOpen)
						{
							num = (short)1826160641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					case 4:
					{
						global::System.Windows.Shapes.Rectangle rectangle;
						if (rectangle != null)
						{
							num = (short)1724317703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					}
					case 5:
						goto IL_29C;
					case 6:
						goto IL_2E1;
					case 7:
						num = (short)1205075980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Windows.Media.TranslateTransform translateTransform;
						if (translateTransform.X != 5.0)
						{
							num = (short)262078477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E1;
					}
					case 9:
					{
						num = (short)960526295;
						short num3 = num;
						num = (short)1233024983;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)391184384;
							if (num != 0)
							{
							}
							global::System.Windows.Point point;
							global::System.Windows.Media.TranslateTransform translateTransform = new global::System.Windows.Media.TranslateTransform(5.0 + point.X - point2.X, -26.0);
							global::System.Windows.Shapes.Rectangle rectangle;
							rectangle.RenderTransform = translateTransform;
							num = (short)1447821317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 10:
					{
						num = (short)2096496640;
						short num4 = num;
						if (popup != null)
						{
							num = (short)1702756354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					}
					case 11:
					{
						global::System.Windows.Media.TranslateTransform translateTransform;
						global::System.Windows.Point point;
						if (translateTransform.X != 5.0 + point.X - point2.X)
						{
							num = (short)1295384585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					}
					case 12:
					{
						global::System.Windows.Shapes.Rectangle rectangle;
						if (rectangle.RenderTransform is global::System.Windows.Media.TranslateTransform)
						{
							num = (short)779943936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					}
					case 13:
					{
						global::System.Windows.Media.TranslateTransform translateTransform;
						point2.X -= translateTransform.X - 5.0;
						num = (short)623443974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_70;
					IL_2E1:
					double x = point2.X;
					point2.X = x - 1.0;
					num = (short)1849688075;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_29C:
				IL_399:
				num = (short)1178796033;
				if (num != 0)
				{
				}
				return null;
				IL_70:
				popup = base.Popup;
				num = (short)1987575818;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000C548 File Offset: 0x0000A748
		protected override void OnMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1507032315;
			short num2 = num;
			num = (short)995654907;
			switch (num2 == num)
			{
			}
			num = (short)1695416321;
			if (num != 0)
			{
			}
			num = (short)1814888448;
			if (num != 0)
			{
			}
			num = (short)1416101888;
			short num3 = num;
			this.CloseOnDoubleClick(e);
			base.OnMouseDoubleClick(e);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000C600 File Offset: 0x0000A800
		internal void CloseOnDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1552416777;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Rect rect;
				global::System.Windows.Point position;
				switch (num2)
				{
				case 0:
					num = (short)713555976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)1467154433;
					if (num != 0)
					{
					}
					global::System.Windows.Window window;
					if (window != null)
					{
						num = (short)1580793863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
				{
					global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
					num = (short)593756162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)657012098;
					short num3 = num;
					num = (short)506082690;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_63;
					default:
					{
						num = (short)303169536;
						if (num != 0)
						{
						}
						num = (short)1381629952;
						short num4 = num;
						if (e.ChangedButton == global::System.Windows.Input.MouseButton.Left)
						{
							num = (short)861732864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 5:
					num = (short)2033516548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_233;
				case 7:
				{
					global::System.Windows.Window window;
					window.Close();
					num = (short)1634664449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					if (base.IsPopupOpen)
					{
						num = (short)453115914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_233;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 10:
					num = (short)1516175372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (rect.Contains(position))
					{
						num = (short)1254031363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					if (!this.IsBackstageActive)
					{
						num = (short)1809186822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_58;
				IL_63:
				num = (short)1088880645;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_58:
				if (this.DoubleClickClose)
				{
					goto IL_63;
				}
				break;
				IL_233:
				position = e.GetPosition(this);
				rect = new global::System.Windows.Rect(base.RenderSize);
				num = (short)740360203;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000C894 File Offset: 0x0000AA94
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000C950 File Offset: 0x0000AB50
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		public bool DoubleClickClose
		{
			get
			{
				short num = (short)1877468338;
				short num2 = num;
				num = (short)1297999026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2051407872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1310523392;
				if (num != 0)
				{
				}
				num = (short)2132410369;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ApplicationMenu.DoubleClickCloseProperty);
			}
			set
			{
				short num = (short)502294503;
				short num2 = num;
				num = (short)243951591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)131727360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1006043136;
				if (num != 0)
				{
				}
				num = (short)2064973825;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ApplicationMenu.DoubleClickCloseProperty, value);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000CA08 File Offset: 0x0000AC08
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::DevComponents.WpfRibbon.ButtonDropDown openButton;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Windows.Rect rect;
				switch (num)
				{
				case 0:
					goto IL_60;
				case 1:
				{
					openButton.IsPopupOpen = false;
					num2 = (short)1072904094;
					short num3 = num2;
					num2 = (short)1682323358;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
						num2 = (short)1275265024;
						if (num2 != 0)
						{
						}
						num2 = (short)2106785795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (openButton != null)
					{
						num2 = (short)86900736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14C;
				case 3:
					goto IL_F1;
				case 4:
					if (!rect.Contains(e.GetPosition(openButton.Popup)))
					{
						num2 = (short)664338433;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14C;
				}
				goto IL_24;
				IL_60:
				num2 = (short)434831361;
				if (num2 != 0)
				{
				}
				rect = new global::System.Windows.Rect(openButton.Popup.RenderSize);
				num2 = (short)1539833860;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F1:
			IL_14C:
			num2 = (short)1524891648;
			short num4 = num2;
			return;
			IL_24:
			base.OnMouseLeftButtonDown(e);
			openButton = this.GetOpenButton();
			num2 = (short)709885954;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		private global::DevComponents.WpfRibbon.ButtonDropDown GetOpenButton()
		{
			short num;
			for (;;)
			{
				num = (short)805306368;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)460628849;
					short num3 = num;
					num = (short)1245487985;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_54;
					}
					break;
				}
				}
			}
			IL_54:
			num = (short)475856897;
			if (num != 0)
			{
			}
			num = (short)1933770752;
			if (num != 0)
			{
			}
			global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
			global::DevComponents.WpfRibbon.ButtonDropDown result;
			try
			{
				num = (short)1493303302;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown != null)
						{
							num = (short)282394627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						result = buttonDropDown;
						num = (short)1842020359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_20A;
					case 3:
						num = (short)1152778248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1699020805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = enumerator.Current as global::DevComponents.WpfRibbon.ButtonDropDown;
						num = (short)1011548160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)960757762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_116;
						}
						continue;
					case 7:
						goto IL_1AE;
					case 8:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown.IsPopupOpen)
						{
							num = (short)460521473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_118:
					num = (short)734330884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_116:
					goto IL_118;
				}
				IL_1AE:
				return result;
				IL_20A:
				goto IL_A1;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_22C;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_219:
					switch (num2)
					{
					case 0:
						if (disposable != null)
						{
							num = (short)1402142721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_282;
					case 1:
						disposable.Dispose();
						num = (short)928710658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_280;
					}
					goto IL_22C;
				}
				IL_280:
				IL_282:
				goto EndFinally_6;
				IL_22C:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1411710976;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_219;
				EndFinally_6:;
			}
			return result;
			IL_A1:
			num = (short)1780219904;
			short num4 = num;
			return null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000CE3C File Offset: 0x0000B03C
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1696137222;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.SetRole(e.OldItems, global::DevComponents.WpfRibbon.eElementRole.Default);
					num = (short)1839661064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)798621696;
					short num3 = num;
					if (e.NewItems != null)
					{
						num = (short)1679360002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A;
				}
				case 2:
					num = (short)1089732609;
					if (num != 0)
					{
					}
					this.SetRole(e.NewItems, global::DevComponents.WpfRibbon.eElementRole.AppMenuDocumentCommand);
					num = (short)153878531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_6A;
				case 4:
				{
					num = (short)68574359;
					short num4 = num;
					num = (short)1497390231;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2082144256;
						if (num != 0)
						{
						}
						this.SetRole(base.Items, global::DevComponents.WpfRibbon.eElementRole.AppMenuDocumentCommand);
						num = (short)933101575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (e.OldItems != null)
					{
						num = (short)525860864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FA;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 7:
					goto IL_13E;
				case 8:
					goto IL_167;
				}
				IL_48:
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
				{
					num = (short)782237700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1540751361;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6A:
				num = (short)1155858437;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13E:
			IL_167:
			IL_1FA:
			base.OnItemsChanged(e);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000D04C File Offset: 0x0000B24C
		protected override void ClearChildMouseHighlight()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1759781947;
					short num3 = num2;
					num2 = (short)1141580859;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_42;
					default:
						goto IL_EE;
					}
					break;
				}
				case 1:
					goto IL_108;
				case 2:
				{
					this.ClearChildMouseHighlight(this.AppItems);
					num2 = (short)770244608;
					short num4 = num2;
					num2 = (short)1318518785;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_42;
				case 4:
					if (this.MruItems != null)
					{
						num2 = (short)477560837;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					this.ClearChildMouseHighlight(this.MruItems);
					num2 = (short)1203109888;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_42:
				num2 = (short)2108555265;
				if (num2 != 0)
				{
				}
				if (this.AppItems != null)
				{
					num2 = (short)1657405442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_108:
				num2 = (short)1036713988;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EE:
			num2 = (short)811991040;
			if (num2 != 0)
			{
			}
			return;
			IL_28:
			base.ClearChildMouseHighlight();
			num2 = (short)447545347;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)1013776384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_122;
				}
				global::System.Windows.Input.Key key;
				global::System.Windows.UIElement highlightedChild;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_7B4;
					case 1:
						if (key == global::System.Windows.Input.Key.Tab)
						{
							num = (short)586154000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 2:
						num = (short)1596391425;
						if (num != 0)
						{
						}
						num = (short)765394970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.MruItems.Count > 0)
						{
							num = (short)1861091358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_996;
					case 4:
					{
						if (e.Handled)
						{
							num = (short)1071972405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = false;
						num = (short)1212022802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_3F5;
					case 6:
						if (highlightedChild != null)
						{
							num = (short)1499136035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 7:
					{
						((global::System.Windows.UIElement)base.Items[0]).Focus();
						bool flag = true;
						num = (short)604897326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						bool flag;
						if (!flag)
						{
							num = (short)836436001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_996;
					}
					case 9:
						num = (short)493879315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						key = global::System.Windows.Input.Key.Right;
						num = (short)1855324172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.MruItems.Count > 0)
						{
							num = (short)757202994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C8;
					case 12:
						goto IL_8DB;
					case 13:
						if (key == global::System.Windows.Input.Key.Left)
						{
							num = (short)889782272;
							short num3 = num;
							num = (short)335085578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8DB;
					case 14:
						e.Handled = true;
						num = (short)1610809349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!e.Handled)
						{
							num = (short)1689714690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 16:
						goto IL_89D;
					case 17:
						if (base.IsPopupOpen)
						{
							num = (short)1720188949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95D;
					case 18:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							num = (short)432865305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8DB;
					case 19:
						if (base.Items.Count > 0)
						{
							num = (short)1641873451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 20:
						key = global::System.Windows.Input.Key.Left;
						num = (short)1713635380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)81723432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (key == global::System.Windows.Input.Key.Right)
						{
							num = (short)1243021346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_996;
					case 23:
						num = (short)1174274051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)1331691542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)308215837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (base.IsLastVisible(this.AppItems, highlightedChild))
						{
							num = (short)179896329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 27:
						if (base.Items.Count > 0)
						{
							num = (short)618594348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_996;
					case 28:
						goto IL_4C8;
					case 29:
						if (key == global::System.Windows.Input.Key.Right)
						{
							num = (short)752549908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1729495053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						this.FocusFirstItem(this.MruItems);
						bool flag = true;
						num = (short)454164516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						num = (short)1509205690;
						short num4 = num;
						num = (short)1665705658;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2A1;
						default:
							num = (short)761462784;
							if (num != 0)
							{
							}
							if (base.HighlightedChild != null)
							{
								num = (short)896270381;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_996;
						}
						break;
					}
					case 32:
						if (base.IsLastVisible(base.Items, highlightedChild))
						{
							num = (short)650182705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C8;
					case 33:
						num = (short)1574961183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_859;
					case 35:
						num = (short)923729952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_996;
					case 37:
					{
						bool flag;
						if (flag)
						{
							num = (short)1895890958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 38:
						if (key != global::System.Windows.Input.Key.Left)
						{
							num = (short)1740505112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_859;
					case 39:
						if (!e.Handled)
						{
							num = (short)1801715769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B4;
					case 40:
						goto IL_2A1;
					case 41:
						num = (short)59768833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (this.AppItems.Count > 0)
						{
							num = (short)1076559930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B4;
					case 43:
						this.FocusFirstItem(base.Items);
						e.Handled = true;
						num = (short)1462042684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
					{
						this.FocusFirstItem(base.Items);
						bool flag = true;
						num = (short)1546911791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown highlightedChild2 = base.HighlightedChild;
						num = (short)2022047803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						goto IL_95D;
					case 47:
						goto IL_996;
					case 48:
						if (base.IsLastVisible(this.MruItems, highlightedChild))
						{
							num = (short)1435697207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B4;
					case 49:
						num = (short)1304494091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						this.FocusFirstItem(this.MruItems);
						e.Handled = true;
						num = (short)1236533276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						num = (short)598867995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_8DB;
					case 53:
						return;
					case 54:
						if (key != global::System.Windows.Input.Key.Down)
						{
							num = (short)263716905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89D;
					case 55:
						num = (short)1218445354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown highlightedChild2;
						if (this.MruItems.Contains(highlightedChild2))
						{
							num = (short)975437875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_996;
					}
					case 57:
						num = (short)2034630704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						this.FocusFirstItem(this.AppItems);
						e.Handled = true;
						num = (short)85327872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown highlightedChild2;
						if (base.Items.Contains(highlightedChild2))
						{
							num = (short)1760165911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1260912696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						goto IL_3FA;
					}
					goto IL_122;
					IL_2A1:
					if (base.HighlightedChild == null)
					{
						num = (short)1867382791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_95D;
					IL_3FA:
					base.OnKeyDown(e);
					num = (short)616562692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C8:
					num = (short)624099367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7B4:
					num = (short)1862926351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_859:
					num = (short)462159889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_89D:
					num = (short)2106916870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8DB:
					num = (short)1449459750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_95D:
					num = (short)1012203528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_996:
					num = (short)26279973;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3F5:
				return;
				IL_122:
				key = e.Key;
				highlightedChild = base.HighlightedChild;
				num = (short)1664352310;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000DC18 File Offset: 0x0000BE18
		private void FocusFirstItem(global::System.Collections.IEnumerable en)
		{
			global::System.Collections.IEnumerator enumerator = en.GetEnumerator();
			short num;
			try
			{
				num = (short)39190530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)67305475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = enumerator.Current as global::DevComponents.WpfRibbon.ButtonDropDown;
						num = (short)1558970376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_11B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_52;
						}
						continue;
					case 3:
						num = (short)365035525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)2071461895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_137;
					case 6:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						buttonDropDown.Focus();
						num = (short)727842817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)145424390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
					{
						global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
						if (buttonDropDown != null)
						{
							num = (short)857079812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_8D:
					num = (short)478216192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_52:
					goto IL_8D;
				}
				IL_11B:
				IL_137:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_158;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_146:
					switch (num2)
					{
					case 0:
					{
						num = (short)1451079535;
						short num3 = num;
						num = (short)1484765039;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18F;
						default:
							goto IL_1E0;
						}
						break;
					}
					case 1:
						goto IL_18F;
					case 2:
						if (disposable != null)
						{
							num = (short)1589837825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F7;
					}
					goto IL_158;
					IL_18F:
					disposable.Dispose();
					num = (short)442630144;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E0:
				num = (short)51118080;
				if (num != 0)
				{
				}
				IL_1F7:
				goto EndFinally_7;
				IL_158:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)684916738;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_146;
				EndFinally_7:;
			}
			num = (short)1058668545;
			if (num != 0)
			{
			}
			num = (short)1700331520;
			short num4 = num;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000DE8C File Offset: 0x0000C08C
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				short num2;
				global::System.Collections.ArrayList arrayList;
				global::System.Collections.IEnumerator logicalChildren;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_19C;
					case 1:
					{
						num2 = (short)2040429461;
						short num3 = num2;
						num2 = (short)1770879893;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_202;
						default:
							num2 = (short)1568538624;
							if (num2 != 0)
							{
							}
							arrayList.AddRange(this.AppItems);
							num2 = (short)120848390;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_202;
					case 3:
						goto IL_1C9;
					case 4:
						if (this.AppItems != null)
						{
							num2 = (short)2096168961;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_64;
					case 5:
						arrayList.AddRange(this.MruItems);
						num2 = (short)985595904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						goto IL_64;
					case 7:
						if (!logicalChildren.MoveNext())
						{
							num2 = (short)1737228290;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						arrayList.Add(logicalChildren.Current);
						num2 = (short)380698632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						goto IL_1C9;
					case 9:
						num2 = (short)103088129;
						if (num2 != 0)
						{
						}
						if (this.MruItems != null)
						{
							num2 = (short)658178053;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_22F;
					}
					goto IL_38;
					IL_64:
					num2 = (short)1162280969;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1C9:
					num2 = (short)454754311;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_202:
					num2 = (short)639041540;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_19C:
				num2 = (short)1911160832;
				short num4 = num2;
				IL_22F:
				return arrayList.GetEnumerator();
				IL_38:
				logicalChildren = base.LogicalChildren;
				arrayList = new global::System.Collections.ArrayList();
				logicalChildren.Reset();
				num2 = (short)81788931;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		protected override void HandleMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1367670789;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)938140305;
				short num3 = num;
				num = (short)1316348561;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)927596544;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Rect rect;
						if (rect.Contains(e.GetPosition(this)))
						{
							num = (short)1890975753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					}
					case 1:
						if (e.ChangedButton == global::System.Windows.Input.MouseButton.Right)
						{
							num = (short)2026766338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 2:
						num = (short)351141889;
						if (num != 0)
						{
						}
						goto IL_C9;
					case 3:
						if (base.IsEnabled)
						{
							num = (short)2027028490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 4:
						if (e.ChangedButton != global::System.Windows.Input.MouseButton.Left)
						{
							num = (short)1509294086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C9;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					case 6:
					{
						num = (short)665255936;
						short num4 = num;
						num = (short)41680897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_105;
					case 8:
					{
						global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
						num = (short)601227267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1515978756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)776208384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.HasVisibleItems)
						{
							num = (short)425000967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					}
					break;
					IL_C9:
					num = (short)330891275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A1:
				if (!this.IsBackstageActive)
				{
					goto IL_279;
				}
				num = (short)454492168;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_105:
			e.Handled = true;
			this.ClickHeader();
			return;
			IL_279:
			base.HandleMouseDown(e);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000E360 File Offset: 0x0000C560
		public override void ClickHeader()
		{
			if (!this.IsBackstageActive)
			{
				short num = (short)190185472;
				short num2 = num;
				num = (short)999519324;
				short num3 = num;
				num = (short)2053338204;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1817182209;
					if (num != 0)
					{
					}
					num = (short)1925316608;
					if (num != 0)
					{
					}
					base.ClickHeader();
					return;
				}
			}
			base.IsPopupOpen = !base.IsPopupOpen;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000E430 File Offset: 0x0000C630
		protected override void OnIsPopupOpenChanged(bool oldValue, bool newValue)
		{
			short num = (short)640811008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D2;
				}
				global::System.Windows.UIElement uielement;
				for (;;)
				{
					IL_27:
					global::DevComponents.WpfRibbon.Ribbon ribbon2;
					switch (num2)
					{
					case 0:
					{
						if (this._PreviousFocusedElement != null)
						{
							num = (short)200146969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement = null;
						global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
						num = (short)1655373836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Windows.Documents.AdornerLayer adornerLayer;
						adornerLayer.Remove(this._BackstageAdorner);
						num = (short)460980264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Windows.Documents.AdornerLayer backstageAdornerLayer = this.GetBackstageAdornerLayer();
						base.Popup.Width = backstageAdornerLayer.RenderSize.Width - 1.0;
						global::DevComponents.WpfRibbon.Ribbon ribbon = this.GetRibbon();
						num = (short)983078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (!this.BackstageUsesPopup)
						{
							num = (short)969932816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E1;
					case 4:
						if (this._PreviousFocusedElement == null)
						{
							num = (short)375390226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C8;
					case 5:
						goto IL_11A;
					case 6:
						goto IL_58E;
					case 7:
					{
						global::System.Windows.Documents.AdornerLayer backstageAdornerLayer;
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						base.Popup.Height = backstageAdornerLayer.RenderSize.Height - ribbon.GetTitleChromeHeight() + 2.0;
						num = (short)1072693271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Windows.Documents.AdornerLayer adornerLayer;
						if (adornerLayer != null)
						{
							num = (short)2049835009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_655;
					}
					case 9:
						goto IL_42C;
					case 10:
						goto IL_152;
					case 11:
						goto IL_2C6;
					case 12:
					{
						global::System.Windows.Window window;
						if (window != null)
						{
							num = (short)1255604243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C6;
					}
					case 13:
						goto IL_38D;
					case 14:
						goto IL_38D;
					case 15:
						if (uielement == null)
						{
							num = (short)1554317339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58E;
					case 16:
						num = (short)1058799652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::System.Windows.Window window2;
						this._PreviousFocusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(window2);
						num = (short)150667273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						global::System.Windows.Window window2 = global::System.Windows.Window.GetWindow(this);
						num = (short)417726490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::System.Windows.Window window;
						uielement = (window.PredictFocus(global::System.Windows.Input.FocusNavigationDirection.Down) as global::System.Windows.UIElement);
						num = (short)743964683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (ribbon2 != null)
						{
							num = (short)1856307232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58E;
					case 21:
						if (this.IsBackstageActive)
						{
							num = (short)27131928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E1;
					case 22:
						if (uielement != null)
						{
							num = (short)1098448906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 23:
						goto IL_38D;
					case 24:
						num = (short)178257923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_6B9;
					case 26:
					{
						global::System.Windows.Window window2;
						if (window2 != null)
						{
							num = (short)663486481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C8;
					}
					case 27:
						goto IL_157;
					case 28:
						if (this._BackstageAdorner != null)
						{
							num = (short)1509883943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 29:
						goto IL_3AE;
					case 30:
						uielement = this.GetRibbon();
						num = (short)1109393413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1227227173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						uielement = (ribbon2.PredictFocus(global::System.Windows.Input.FocusNavigationDirection.Down) as global::System.Windows.UIElement);
						num = (short)311754758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (uielement == null)
						{
							num = (short)368967710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					case 34:
					{
						global::System.Windows.Documents.AdornerLayer backstageAdornerLayer2 = this.GetBackstageAdornerLayer();
						this._BackstageAdorner = new global::DevComponents.WpfRibbon.BackstageContentAdorner(this);
						backstageAdornerLayer2.Add(this._BackstageAdorner);
						global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
						base.IsSelected = true;
						this.OnPopupOpened(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ButtonDropDown.PopupOpenedEvent, this));
						this.UpdateKeyTipsState();
						this._PreviousFocusedElement = global::System.Windows.Input.Keyboard.FocusedElement;
						num = (short)425852932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (this.IsBackstageActive)
						{
							num = (short)1280376863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38D;
					case 36:
					{
						if (!newValue)
						{
							num = (short)832110620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1190914850;
						short num3 = num;
						num = (short)777317154;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_157;
						default:
							num = (short)713228289;
							if (num != 0)
							{
							}
							num = (short)952172544;
							if (num != 0)
							{
							}
							num = (short)869924898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 37:
						if (newValue)
						{
							num = (short)1126694914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.Popup.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
						base.Popup.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
						num = (short)855572494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						global::DevComponents.WpfRibbon.Ribbon ribbon;
						if (ribbon != null)
						{
							num = (short)208732167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.Popup.Height = base.RenderSize.Height;
						num = (short)1957756941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
					{
						global::System.Windows.Documents.AdornerLayer adornerLayer = this._BackstageAdorner.Parent as global::System.Windows.Documents.AdornerLayer;
						num = (short)1425997832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_655;
					}
					goto IL_D2;
					IL_11A:
					num = (short)1726349334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_157:
					ribbon2 = this.GetRibbon();
					num = (short)377815040;
					short num4 = num;
					num = (short)280363028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C6:
					num = (short)1178337295;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38D:
					base.OnIsPopupOpenChanged(oldValue, newValue);
					num = (short)311033885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E1:
					num = (short)1596850211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58E:
					num = (short)619249697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_655:
					this._BackstageAdorner.RemoveBackstageContent();
					global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
					this.OnPopupClosed(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfRibbon.ButtonDropDown.PopupClosedEvent, this));
					this.UpdateKeyTipsState();
					num = (short)724500480;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_152:
				global::System.Windows.Input.Keyboard.Focus(uielement);
				return;
				IL_1C8:
				this._BackstageAdorner.Focus();
				return;
				IL_3AE:
				return;
				IL_42C:
				goto IL_1C8;
				IL_6B9:
				global::System.Windows.Input.Keyboard.Focus(this._PreviousFocusedElement);
				this._PreviousFocusedElement = null;
				return;
				IL_D2:
				this.UpdateColors();
				num = (short)1521352725;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000EC34 File Offset: 0x0000CE34
		internal global::DevComponents.WpfRibbon.Ribbon GetRibbon()
		{
			short num = (short)1051399353;
			short num2 = num;
			num = (short)918820025;
			switch (num2 == num)
			{
			}
			num = (short)136904705;
			if (num != 0)
			{
			}
			num = (short)327614464;
			if (num != 0)
			{
			}
			num = (short)624885760;
			short num3 = num;
			return base.Parent as global::DevComponents.WpfRibbon.Ribbon;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		private global::System.Windows.Documents.AdornerLayer GetBackstageAdornerLayer()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::DevComponents.WpfRibbon.Ribbon ribbon;
			short num2;
			global::System.Windows.Documents.AdornerLayer adornerLayer3;
			for (;;)
			{
				IL_0A:
				global::System.Windows.Documents.AdornerLayer adornerLayer;
				global::System.Windows.Documents.AdornerLayer adornerLayer2;
				global::System.Windows.Window window;
				switch (num)
				{
				case 0:
					if ((adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(ribbon)) == null)
					{
						num2 = (short)2008416261;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1EE;
				case 1:
					num2 = (short)74121216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if ((adornerLayer2 = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(ribbon)) == null)
					{
						num2 = (short)129237000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12B;
				case 3:
				{
					num2 = (short)1661838232;
					short num3 = num2;
					num2 = (short)2046993304;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_128;
					default:
						num2 = (short)759955456;
						if (num2 != 0)
						{
						}
						if (ribbon != null)
						{
							num2 = (short)1775566855;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_145;
					}
					break;
				}
				case 4:
					return adornerLayer3;
				case 5:
					adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(window);
					goto IL_1EE;
				case 6:
					goto IL_145;
				case 7:
					num2 = (short)1350369281;
					if (num2 != 0)
					{
					}
					num2 = (short)969474050;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_128;
				case 9:
					if (window != null)
					{
						num2 = (short)1332674561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return adornerLayer3;
				}
				goto IL_38;
				IL_12B:
				adornerLayer3 = adornerLayer2;
				num2 = (short)1279393798;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_128:
				adornerLayer2 = adornerLayer3;
				goto IL_12B;
				IL_145:
				num2 = (short)1971781632;
				short num4 = num2;
				window = global::System.Windows.Window.GetWindow(this);
				num2 = (short)1476919305;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1EE:
				adornerLayer3 = adornerLayer;
				num2 = (short)2137653252;
				num = (int)((global::System.IntPtr)num2);
			}
			return adornerLayer3;
			IL_38:
			adornerLayer3 = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
			ribbon = this.GetRibbon();
			num2 = (short)464191491;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000EF00 File Offset: 0x0000D100
		protected override void OnShowKeyTipsChanged()
		{
			short num = (short)1666842624;
			switch (num)
			{
			default:
			{
				global::System.Windows.UIElement backstageTab2;
				for (;;)
				{
					IL_1D:
					num = (short)1308622849;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (this.m_KeyTipsAdorner != null)
							{
								num = (short)11141134;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_83;
							}
							continue;
						case 2:
						{
							global::System.Windows.Documents.AdornerLayer adornerLayer;
							adornerLayer.Remove(this.m_KeyTipsAdorner);
							num = (short)107479055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Windows.UIElement backstageTab;
							global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(backstageTab);
							num = (short)168886285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_2B2;
						case 5:
							if (base.ShowKeyTips)
							{
								num = (short)1974992907;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)546963456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Windows.Documents.AdornerLayer adornerLayer2;
							if (adornerLayer2 != null)
							{
								num = (short)1650524172;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 7:
						{
							global::System.Windows.UIElement backstageTab;
							if (backstageTab != null)
							{
								num = (short)1562181635;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22B;
						}
						case 8:
							if (this.BackstageUsesPopup)
							{
								num = (short)513474564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 9:
							goto IL_CE;
						case 10:
							goto IL_257;
						case 11:
						{
							num = (short)1312954732;
							short num3 = num;
							num = (short)1991121260;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
							{
								num = (short)1776222208;
								if (num != 0)
								{
								}
								backstageTab2 = this.BackstageTab;
								this.m_KeyTipsAdorner = new global::DevComponents.WpfRibbon.KeyTipsAdorner(backstageTab2);
								global::System.Windows.Documents.AdornerLayer adornerLayer2 = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(backstageTab2);
								num = (short)910688262;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 12:
						{
							global::System.Windows.Documents.AdornerLayer adornerLayer2;
							adornerLayer2.Add(this.m_KeyTipsAdorner);
							this.m_KeyTipsAdorner.ContextObject = this;
							num = (short)1353842696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							global::System.Windows.Documents.AdornerLayer adornerLayer;
							if (adornerLayer != null)
							{
								num = (short)1981284354;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22B;
						}
						case 14:
						{
							global::System.Windows.UIElement backstageTab = this.BackstageTab;
							num = (short)1872232455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
						{
							num = (short)1221656576;
							short num4 = num;
							goto IL_22B;
						}
						}
						IL_83:
						num = (short)1625161729;
						if (num != 0)
						{
						}
						if (!this.IsBackstageActive)
						{
							num = (short)1111425033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1520959493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_22B:
						this.m_KeyTipsAdorner.ContextObject = null;
						this.m_KeyTipsAdorner = null;
						num = (short)47120394;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_CE:
				base.OnShowKeyTipsChanged();
				return;
				IL_257:
				return;
				IL_2B2:
				backstageTab2.Focus();
				return;
			}
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000F26C File Offset: 0x0000D46C
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1568271200;
			short num2 = num;
			num = (short)385543008;
			switch (num2 == num)
			{
			}
			num = (short)775946241;
			if (num != 0)
			{
			}
			num = (short)1038024704;
			if (num != 0)
			{
			}
			num = (short)1914109952;
			short num3 = num;
			this.UpdateColors();
			base.OnIsKeyboardFocusWithinChanged(e);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000F324 File Offset: 0x0000D524
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)133281655;
			short num2 = num;
			num = (short)651343735;
			switch (num2 == num)
			{
			}
			num = (short)418447361;
			if (num != 0)
			{
			}
			num = (short)1497825280;
			if (num != 0)
			{
			}
			num = (short)1373241344;
			short num3 = num;
			this.UpdateColors();
			base.OnMouseEnter(e);
		}

		// Token: 0x04000014 RID: 20
		private const string ApplicationButtonResourceName = "RibbonStartButton";

		// Token: 0x04000015 RID: 21
		public static readonly global::System.Windows.DependencyProperty ColorProperty;

		// Token: 0x04000016 RID: 22
		public static readonly global::System.Windows.DependencyProperty BackstageUsesPopupProperty;

		// Token: 0x04000017 RID: 23
		public static readonly global::System.Windows.DependencyProperty BackstageTabProperty;

		// Token: 0x04000018 RID: 24
		public static readonly global::System.Windows.DependencyProperty BackstageEnabledProperty;

		// Token: 0x04000019 RID: 25
		private static readonly global::System.Windows.DependencyPropertyKey IsBackstageActivePropertyKey;

		// Token: 0x0400001A RID: 26
		public static readonly global::System.Windows.DependencyProperty IsBackstageActiveProperty;

		// Token: 0x0400001B RID: 27
		public static readonly global::System.Windows.DependencyProperty VisualStyleProperty;

		// Token: 0x0400001C RID: 28
		private static readonly global::System.Windows.DependencyPropertyKey EffectiveStylePropertyKey;

		// Token: 0x0400001D RID: 29
		public static readonly global::System.Windows.DependencyProperty EffectiveStyleProperty;

		// Token: 0x0400001E RID: 30
		public static readonly global::System.Windows.DependencyProperty MruItemsProperty;

		// Token: 0x0400001F RID: 31
		private static readonly global::System.Windows.DependencyPropertyKey AppItemsPropertyKey;

		// Token: 0x04000020 RID: 32
		public static readonly global::System.Windows.DependencyProperty AppItemsProperty;

		// Token: 0x04000021 RID: 33
		private static readonly global::System.Windows.DependencyPropertyKey HasMruItemsPropertyKey;

		// Token: 0x04000022 RID: 34
		public static readonly global::System.Windows.DependencyProperty HasMruItemsProperty;

		// Token: 0x04000023 RID: 35
		private static readonly global::System.Windows.DependencyPropertyKey HasAppItemsPropertyKey;

		// Token: 0x04000024 RID: 36
		public static readonly global::System.Windows.DependencyProperty HasAppItemsProperty;

		// Token: 0x04000025 RID: 37
		public static readonly global::System.Windows.DependencyProperty MruItemTemplateProperty;

		// Token: 0x04000026 RID: 38
		public static readonly global::System.Windows.DependencyProperty AppItemTemplateProperty;

		// Token: 0x04000027 RID: 39
		public static readonly global::System.Windows.DependencyProperty MruItemTemplateSelectorProperty;

		// Token: 0x04000028 RID: 40
		public static readonly global::System.Windows.DependencyProperty AppItemTemplateSelectorProperty;

		// Token: 0x04000029 RID: 41
		public static readonly global::System.Windows.DependencyProperty DoubleClickCloseProperty;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Controls.Border _OutterBorder;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Controls.Border _InnerBorder;

		// Token: 0x0400002C RID: 44
		private global::DevComponents.WpfRibbon.ApplicationMenu.OverlayAdorner _OverlayAdorner;

		// Token: 0x0400002D RID: 45
		private global::DevComponents.WpfRibbon.BackstageContentAdorner _BackstageAdorner;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.IInputElement _PreviousFocusedElement;

		// Token: 0x02000006 RID: 6
		private class OverlayAdorner : global::System.Windows.Documents.Adorner
		{
			// Token: 0x06000162 RID: 354 RVA: 0x000256E0 File Offset: 0x000238E0
			public OverlayAdorner(global::System.Windows.UIElement elem) : base(elem)
			{
			}

			// Token: 0x06000163 RID: 355 RVA: 0x000256F4 File Offset: 0x000238F4
			protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_24;
					}
					global::System.Windows.Rect rectangle;
					short num2;
					for (;;)
					{
						IL_0A:
						int num;
						switch (num)
						{
						case 0:
							drawingContext.DrawRectangle(global::System.Windows.Media.Brushes.Transparent, null, rectangle);
							num2 = (short)59572228;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							if (rectangle.Height > 0.0)
							{
								num2 = (short)1856962560;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_17B;
						case 2:
							if (rectangle.Width > 0.0)
							{
								num2 = (short)2086797315;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_17B;
						case 3:
							num2 = (short)1427832833;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
							goto IL_137;
						}
						break;
					}
					IL_24:
					rectangle = new global::System.Windows.Rect(base.RenderSize);
					num2 = (short)1926143699;
					short num3 = num2;
					num2 = (short)1663672019;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)419233792;
						short num4 = num2;
						num2 = (short)195624961;
						if (num2 != 0)
						{
						}
						num2 = (short)665452544;
						if (num2 != 0)
						{
						}
						num2 = (short)448069634;
						int num = (int)((global::System.IntPtr)num2);
						goto IL_0A;
					}
					}
				}
				IL_137:
				IL_17B:
				base.OnRender(drawingContext);
			}
		}
	}
}
