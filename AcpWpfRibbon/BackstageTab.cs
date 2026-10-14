using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200000C RID: 12
	public class BackstageTab : global::System.Windows.Controls.TabItem
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00029238 File Offset: 0x00027438
		private static void OnPanelBackgroundChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					global::DevComponents.WpfRibbon.BackstageTab backstageTab;
					backstageTab.OnPanelBackgroundChanged((global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage)e.OldValue, (global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage)e.NewValue);
					num2 = (short)406454274;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)572719105;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfRibbon.BackstageTab backstageTab;
					if (backstageTab != null)
					{
						num2 = (short)540999680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					goto IL_FB;
				}
				goto IL_1C;
			}
			IL_FB:
			num2 = (short)771817472;
			short num3 = num2;
			return;
			for (;;)
			{
				IL_1C:
				global::DevComponents.WpfRibbon.BackstageTab backstageTab = o as global::DevComponents.WpfRibbon.BackstageTab;
				num2 = (short)1871122522;
				short num4 = num2;
				num2 = (short)1083838554;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_58;
				}
			}
			IL_58:
			num2 = (short)732364800;
			if (num2 != 0)
			{
			}
			num2 = (short)1416822785;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0002936C File Offset: 0x0002756C
		protected virtual void OnPanelBackgroundChanged(global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage oldValue, global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage newValue)
		{
			short num = (short)1661676839;
			short num2 = num;
			num = (short)1398549799;
			switch (num2 == num)
			{
			}
			num = (short)1893400577;
			if (num != 0)
			{
			}
			num = (short)1285357568;
			if (num != 0)
			{
			}
			num = (short)2002321408;
			short num3 = num;
			base.CoerceValue(global::DevComponents.WpfRibbon.BackstageTab.EffectiveBackgroundImageProperty);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00029420 File Offset: 0x00027620
		// (set) Token: 0x06000198 RID: 408 RVA: 0x000294DC File Offset: 0x000276DC
		public global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage PanelBackground
		{
			get
			{
				short num = (short)379397760;
				short num2 = num;
				num = (short)450569856;
				switch (num2 == num)
				{
				}
				num = (short)1609629697;
				if (num != 0)
				{
				}
				num = (short)1792802816;
				if (num != 0)
				{
				}
				num = (short)1117061120;
				short num3 = num;
				return (global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage)base.GetValue(global::DevComponents.WpfRibbon.BackstageTab.PanelBackgroundProperty);
			}
			set
			{
				short num = (short)787166264;
				short num2 = num;
				num = (short)1728197688;
				switch (num2 == num)
				{
				}
				num = (short)1661927425;
				if (num != 0)
				{
				}
				num = (short)1785462784;
				if (num != 0)
				{
				}
				num = (short)980484096;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.BackstageTab.PanelBackgroundProperty, value);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00029594 File Offset: 0x00027794
		private static void OnPanelBackgroundImageChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					global::DevComponents.WpfRibbon.BackstageTab backstageTab;
					backstageTab.OnPanelBackgroundImageChanged(e.OldValue, e.NewValue);
					num2 = (short)854523906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)1466564609;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfRibbon.BackstageTab backstageTab;
					if (backstageTab != null)
					{
						num2 = (short)909180928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					goto IL_F0;
				}
				goto IL_1C;
			}
			IL_F0:
			num2 = (short)753336320;
			short num3 = num2;
			return;
			for (;;)
			{
				IL_1C:
				global::DevComponents.WpfRibbon.BackstageTab backstageTab = o as global::DevComponents.WpfRibbon.BackstageTab;
				num2 = (short)1493312882;
				short num4 = num2;
				num2 = (short)653927794;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_57;
				}
			}
			IL_57:
			num2 = (short)141361152;
			if (num2 != 0)
			{
			}
			num2 = (short)2039873537;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000296BC File Offset: 0x000278BC
		protected virtual void OnPanelBackgroundImageChanged(object oldValue, object newValue)
		{
			short num = (short)2070225193;
			short num2 = num;
			num = (short)209068329;
			switch (num2 == num)
			{
			}
			num = (short)89456640;
			if (num != 0)
			{
			}
			num = (short)660471809;
			if (num != 0)
			{
			}
			num = (short)854196224;
			short num3 = num;
			base.CoerceValue(global::DevComponents.WpfRibbon.BackstageTab.EffectiveBackgroundImageProperty);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00029770 File Offset: 0x00027970
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00029824 File Offset: 0x00027A24
		public object PanelBackgroundImage
		{
			get
			{
				short num = (short)1855992406;
				short num2 = num;
				num = (short)343421526;
				switch (num2 == num)
				{
				}
				num = (short)1402535937;
				if (num != 0)
				{
				}
				num = (short)45744128;
				if (num != 0)
				{
				}
				num = (short)1525022720;
				short num3 = num;
				return base.GetValue(global::DevComponents.WpfRibbon.BackstageTab.PanelBackgroundImageProperty);
			}
			set
			{
				short num = (short)1408365529;
				short num2 = num;
				num = (short)1043854297;
				switch (num2 == num)
				{
				}
				num = (short)312737793;
				if (num != 0)
				{
				}
				num = (short)868548608;
				if (num != 0)
				{
				}
				num = (short)1908473856;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.BackstageTab.PanelBackgroundImageProperty, value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000298DC File Offset: 0x00027ADC
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00029990 File Offset: 0x00027B90
		public object EffectiveBackgroundImage
		{
			get
			{
				short num = (short)969301094;
				short num2 = num;
				num = (short)2123783270;
				switch (num2 == num)
				{
				}
				num = (short)2055208960;
				if (num != 0)
				{
				}
				num = (short)1583218689;
				if (num != 0)
				{
				}
				num = (short)1487798272;
				short num3 = num;
				return base.GetValue(global::DevComponents.WpfRibbon.BackstageTab.EffectiveBackgroundImageProperty);
			}
			internal set
			{
				short num = (short)277034959;
				short num2 = num;
				num = (short)326318031;
				switch (num2 == num)
				{
				}
				num = (short)1036189697;
				if (num != 0)
				{
				}
				num = (short)969932800;
				if (num != 0)
				{
				}
				num = (short)609484800;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.BackstageTab.EffectiveBackgroundImagePropertyKey, value);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00029A44 File Offset: 0x00027C44
		private static void OnEffectiveBackgroundImageChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					global::DevComponents.WpfRibbon.BackstageTab backstageTab;
					backstageTab.OnEffectiveBackgroundImageChanged(e.OldValue, e.NewValue);
					num2 = (short)1289945090;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					global::DevComponents.WpfRibbon.BackstageTab backstageTab;
					if (backstageTab != null)
					{
						num2 = (short)1865023488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					goto IL_F9;
				}
				goto IL_1C;
			}
			IL_F9:
			num2 = (short)1179779072;
			short num3 = num2;
			return;
			for (;;)
			{
				IL_1C:
				global::DevComponents.WpfRibbon.BackstageTab backstageTab = o as global::DevComponents.WpfRibbon.BackstageTab;
				num2 = (short)324726132;
				short num4 = num2;
				num2 = (short)1204809076;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5A;
				}
			}
			IL_5A:
			num2 = (short)898433025;
			if (num2 != 0)
			{
			}
			num2 = (short)1164247040;
			if (num2 != 0)
			{
			}
			num2 = (short)1990721537;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00029B78 File Offset: 0x00027D78
		protected virtual void OnEffectiveBackgroundImageChanged(object oldValue, object newValue)
		{
			short num = (short)548864001;
			if (num != 0)
			{
			}
			num = (short)137398346;
			short num2 = num;
			num = (short)438143050;
			switch (num2 == num)
			{
			}
			num = (short)993198080;
			if (num != 0)
			{
			}
			num = (short)344719360;
			short num3 = num;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00029C24 File Offset: 0x00027E24
		private static object OnCoerceEffectiveBackgroundImage(global::System.Windows.DependencyObject o, object value)
		{
			short num = (short)102552878;
			short num2 = num;
			num = (short)1810617646;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)663224321;
				if (num != 0)
				{
				}
				num = (short)876740608;
				if (num != 0)
				{
				}
				global::DevComponents.WpfRibbon.BackstageTab backstageTab = o as global::DevComponents.WpfRibbon.BackstageTab;
				if (backstageTab != null)
				{
					return backstageTab.OnCoerceEffectiveBackgroundImage(value);
				}
				break;
			}
			}
			num = (short)968687616;
			short num3 = num;
			return value;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00029CE4 File Offset: 0x00027EE4
		protected virtual object OnCoerceEffectiveBackgroundImage(object value)
		{
			int a_ = 9;
			short num = (short)1427374083;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1941241857;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					if (this.PanelBackground == global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage.Blue)
					{
						num = (short)2101477381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)275513344;
					short num3 = num;
					num = (short)1943601153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (this.PanelBackground == global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage.Green)
					{
						num = (short)52822018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2011758599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_252;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 4:
					goto IL_190;
				case 5:
					goto IL_14F;
				case 6:
					goto IL_E6;
				case 7:
					if (this.PanelBackground == global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage.Magenta)
					{
						num = (short)1588068361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1186594824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (this.PanelBackground == global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage.Orange)
					{
						goto IL_178;
					}
					goto IL_26C;
				case 9:
					goto IL_1D1;
				}
				IL_7C:
				num = (short)1267116670;
				short num4 = num;
				num = (short)236235390;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_178:
					num = (short)1384448004;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)314114048;
					if (num != 0)
					{
					}
					if (this.PanelBackgroundImage != null)
					{
						num = (short)158924806;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1236729856;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_E6:
			return this.PanelBackgroundImage;
			IL_14F:
			return this.CreateImageFromImageSource(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕠୢd੦౨ᡪ䉬ٮᱰቲቴቶ੸呺㽼፾임ﺌﮎ릖煮", a_));
			IL_190:
			return this.CreateImageFromImageSource(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕠୢd੦౨ᡪ䉬ٮᱰቲቴቶ੸呺㉼ൾ쮈ﲘ떚욠", a_));
			IL_1D1:
			return this.CreateImageFromImageSource(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕠୢd੦౨ᡪ䉬ٮᱰቲቴቶ੸呺ぼṾ즊敖ﺘﺚ뎜쾠쒢", a_));
			IL_252:
			return this.CreateImageFromImageSource(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕠୢd੦౨ᡪ䉬ٮᱰቲቴቶ੸呺㩼ൾ얆ﲎ래", a_));
			IL_26C:
			return null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00029F60 File Offset: 0x00028160
		protected virtual global::System.Windows.Controls.Image CreateImageFromImageSource(string imageSource)
		{
			int a_ = 14;
			short num = (short)237713968;
			short num2 = num;
			num = (short)900545072;
			switch (num2 == num)
			{
			}
			num = (short)1651441664;
			short num3 = num;
			num = (short)347340800;
			if (num != 0)
			{
			}
			num = (short)381812737;
			if (num != 0)
			{
			}
			return new global::System.Windows.Controls.Image
			{
				Source = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᙥ१३ݫ呭彯嵱ᕳٵࡷᙹᕻᵽ낉ꂋꊍ벏붑햓춙쮡욣쒥잧쒩鞫춭\udfaf\udfb1쒳\ud9b5횷\udfb9튻쪽", a_) + imageSource, global::System.UriKind.RelativeOrAbsolute)),
				Stretch = global::System.Windows.Media.Stretch.None
			};
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0002A044 File Offset: 0x00028244
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0002A0F8 File Offset: 0x000282F8
		public object TabToolTip
		{
			get
			{
				short num = (short)1884618753;
				if (num != 0)
				{
				}
				num = (short)1440839109;
				short num2 = num;
				num = (short)1181709765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881065984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1811283968;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.BackstageTab.TabToolTipProperty);
			}
			set
			{
				short num = (short)2064816484;
				short num2 = num;
				num = (short)1590794596;
				switch (num2 == num)
				{
				}
				num = (short)1050017792;
				short num3 = num;
				num = (short)736231425;
				if (num != 0)
				{
				}
				num = (short)1512439808;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.BackstageTab.TabToolTipProperty, value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0002A1B0 File Offset: 0x000283B0
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0002A26C File Offset: 0x0002846C
		public global::System.Windows.Controls.ContextMenu TabContextMenu
		{
			get
			{
				short num = (short)1601097530;
				short num2 = num;
				num = (short)1386204986;
				switch (num2 == num)
				{
				}
				num = (short)451936256;
				short num3 = num;
				num = (short)1190920193;
				if (num != 0)
				{
				}
				num = (short)933298176;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.ContextMenu)base.GetValue(global::DevComponents.WpfRibbon.BackstageTab.TabContextMenuProperty);
			}
			set
			{
				short num = (short)830603809;
				short num2 = num;
				num = (short)452067873;
				switch (num2 == num)
				{
				}
				num = (short)125370368;
				short num3 = num;
				num = (short)1367998464;
				if (num != 0)
				{
				}
				num = (short)396820481;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.BackstageTab.TabContextMenuProperty, value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0002A324 File Offset: 0x00028524
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0002A3DC File Offset: 0x000285DC
		public global::System.Windows.Media.Brush InnerBorderBrush
		{
			get
			{
				short num = (short)265184988;
				short num2 = num;
				num = (short)1790142172;
				switch (num2 == num)
				{
				}
				num = (short)2038824960;
				short num3 = num;
				num = (short)724959233;
				if (num != 0)
				{
				}
				num = (short)1231945728;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.BackstageTab.InnerBorderBrushProperty);
			}
			set
			{
				short num = (short)1997543422;
				short num2 = num;
				num = (short)1667438590;
				switch (num2 == num)
				{
				}
				num = (short)2002321408;
				short num3 = num;
				num = (short)1824915457;
				if (num != 0)
				{
				}
				num = (short)893714432;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.BackstageTab.InnerBorderBrushProperty, value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0002A494 File Offset: 0x00028694
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0002A550 File Offset: 0x00028750
		public global::System.Windows.Thickness InnerBorderThickness
		{
			get
			{
				short num = (short)1573722822;
				short num2 = num;
				num = (short)786373318;
				switch (num2 == num)
				{
				}
				num = (short)1912930304;
				short num3 = num;
				num = (short)1534656512;
				if (num != 0)
				{
				}
				num = (short)2019033089;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.BackstageTab.InnerBorderThicknessProperty);
			}
			set
			{
				short num = (short)1607270401;
				if (num != 0)
				{
				}
				num = (short)453037817;
				short num2 = num;
				num = (short)717475577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)716046336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2018508800;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.BackstageTab.InnerBorderThicknessProperty, value);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0002A60C File Offset: 0x0002880C
		static BackstageTab()
		{
			int a_ = 16;
			short num = (short)840164801;
			short num2 = num;
			num = (short)2088756673;
			switch (num2 == num)
			{
			}
			num = (short)381485056;
			short num3 = num;
			num = (short)862650369;
			if (num != 0)
			{
			}
			num = (short)1536753664;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.BackstageTab.PanelBackgroundProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㡧୩ɫ୭ᱯぱᕳᕵ፷ᵹ๻ᅽ", a_), typeof(global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage), typeof(global::DevComponents.WpfRibbon.BackstageTab), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eBackstagePanelBackgroundImage.Blue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.BackstageTab.OnPanelBackgroundChanged)));
			global::DevComponents.WpfRibbon.BackstageTab.PanelBackgroundImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㡧୩ɫ୭ᱯぱᕳᕵ፷ᵹ๻ᅽ쾅", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.BackstageTab), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.BackstageTab.OnPanelBackgroundImageChanged)));
			global::DevComponents.WpfRibbon.BackstageTab.EffectiveBackgroundImagePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⵧ౩੫୭፯ٱᵳuᵷ㡹ᵻᵽﶇ잍ﶏ", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.BackstageTab), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.BackstageTab.OnEffectiveBackgroundImageChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.BackstageTab.OnCoerceEffectiveBackgroundImage)));
			global::DevComponents.WpfRibbon.BackstageTab.EffectiveBackgroundImageProperty = global::DevComponents.WpfRibbon.BackstageTab.EffectiveBackgroundImagePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.BackstageTab.TabToolTipProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㱧୩๫㩭Ὧᵱᡳ≵ᅷ੹", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.BackstageTab), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.BackstageTab.TabContextMenuProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㱧୩๫⵭Ὧᱱs፵w๹ㅻ᭽", a_), typeof(global::System.Windows.Controls.ContextMenu), typeof(global::DevComponents.WpfRibbon.BackstageTab), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.BackstageTab.InnerBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅷѩɫ୭ɯぱ᭳ѵᱷό๻㱽", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.BackstageTab), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.BackstageTab.InnerBorderThicknessProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅷѩɫ୭ɯぱ᭳ѵᱷό๻⩽ﾋﶍ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.BackstageTab), new global::System.Windows.PropertyMetadata(default(global::System.Windows.Thickness)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.BackstageTab), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.BackstageTab)));
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0002A894 File Offset: 0x00028A94
		protected override void OnInitialized(global::System.EventArgs e)
		{
			short num = (short)1295535968;
			short num2 = num;
			num = (short)1476874080;
			switch (num2 == num)
			{
			}
			num = (short)286588928;
			short num3 = num;
			num = (short)259653633;
			if (num != 0)
			{
			}
			num = (short)971243520;
			if (num != 0)
			{
			}
			base.CoerceValue(global::DevComponents.WpfRibbon.BackstageTab.EffectiveBackgroundImageProperty);
			base.OnInitialized(e);
		}

		// Token: 0x0400008F RID: 143
		public static readonly global::System.Windows.DependencyProperty PanelBackgroundProperty;

		// Token: 0x04000090 RID: 144
		public static readonly global::System.Windows.DependencyProperty PanelBackgroundImageProperty;

		// Token: 0x04000091 RID: 145
		private static readonly global::System.Windows.DependencyPropertyKey EffectiveBackgroundImagePropertyKey;

		// Token: 0x04000092 RID: 146
		public static readonly global::System.Windows.DependencyProperty EffectiveBackgroundImageProperty;

		// Token: 0x04000093 RID: 147
		public static readonly global::System.Windows.DependencyProperty TabToolTipProperty;

		// Token: 0x04000094 RID: 148
		public static readonly global::System.Windows.DependencyProperty TabContextMenuProperty;

		// Token: 0x04000095 RID: 149
		public static readonly global::System.Windows.DependencyProperty InnerBorderBrushProperty;

		// Token: 0x04000096 RID: 150
		public static readonly global::System.Windows.DependencyProperty InnerBorderThicknessProperty;
	}
}
