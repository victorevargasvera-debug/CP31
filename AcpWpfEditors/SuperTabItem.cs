using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000036 RID: 54
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SuperTabItem : global::System.Windows.Controls.TabItem
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060003F1 RID: 1009 RVA: 0x00050528 File Offset: 0x0004E728
		// (remove) Token: 0x060003F2 RID: 1010 RVA: 0x000505DC File Offset: 0x0004E7DC
		public event global::System.Windows.RoutedEventHandler HeaderChanged
		{
			add
			{
				short num = (short)1833566208;
				short num2 = num;
				num = (short)481825605;
				short num3 = num;
				num = (short)1771246405;
				switch (num3 == num)
				{
				}
				num = (short)1735327744;
				if (num != 0)
				{
				}
				num = (short)1847197697;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.SuperTabItem.HeaderChangedEvent, value);
			}
			remove
			{
				short num = (short)1489960960;
				short num2 = num;
				num = (short)1152934457;
				short num3 = num;
				num = (short)844587577;
				switch (num3 == num)
				{
				}
				num = (short)63242240;
				if (num != 0)
				{
				}
				num = (short)1470431233;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.SuperTabItem.HeaderChangedEvent, value);
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00050690 File Offset: 0x0004E890
		protected virtual void OnHeaderChanged()
		{
			short num = (short)1732116480;
			short num2 = num;
			num = (short)1870856193;
			if (num != 0)
			{
			}
			num = (short)973819657;
			short num3 = num;
			num = (short)884952841;
			switch (num3 == num)
			{
			}
			num = (short)929300480;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.SuperTabItem.HeaderChangedEvent);
			base.RaiseEvent(routedEventArgs);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0005074C File Offset: 0x0004E94C
		private static void h(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1239134335;
			short num2 = num;
			num = (short)788377727;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1019412480;
				short num3 = num;
				num = (short)1050607617;
				if (num != 0)
				{
				}
				num = (short)18153472;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B6;
				}
				int num4;
				global::DevComponents.WpfEditors.SuperTabItem superTabItem;
				for (;;)
				{
					IL_A4:
					switch (num4)
					{
					case 0:
						if (superTabItem != null)
						{
							num = (short)139526146;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						superTabItem.OnImageChanged(A_1.OldValue, A_1.NewValue);
						num = (short)2017460225;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_B6:
				superTabItem = (A_0 as global::DevComponents.WpfEditors.SuperTabItem);
				num = (short)592314368;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_A4;
			}
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00050870 File Offset: 0x0004EA70
		protected virtual void OnImageChanged(object oldValue, object newValue)
		{
			short num = (short)1472397312;
			short num2 = num;
			num = (short)1897744827;
			short num3 = num;
			num = (short)1356614075;
			switch (num3 == num)
			{
			}
			num = (short)402653185;
			if (num != 0)
			{
			}
			num = (short)1224605696;
			if (num != 0)
			{
			}
			this.d();
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00050920 File Offset: 0x0004EB20
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000509D4 File Offset: 0x0004EBD4
		public object Image
		{
			get
			{
				short num = (short)1720582144;
				short num2 = num;
				num = (short)935687414;
				short num3 = num;
				num = (short)1109161206;
				switch (num3 == num)
				{
				}
				num = (short)828899329;
				if (num != 0)
				{
				}
				num = (short)1915879424;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.ImageProperty);
			}
			set
			{
				short num = (short)512557056;
				short num2 = num;
				num = (short)519045121;
				if (num != 0)
				{
				}
				num = (short)418341117;
				short num3 = num;
				num = (short)591159549;
				switch (num3 == num)
				{
				}
				num = (short)60489728;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.ImageProperty, value);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00050A8C File Offset: 0x0004EC8C
		private static void g(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)74388688;
			short num2 = num;
			num = (short)1485706448;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1070399488;
				short num3 = num;
				num = (short)910753792;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				int num4;
				global::DevComponents.WpfEditors.SuperTabItem superTabItem;
				for (;;)
				{
					IL_7C:
					switch (num4)
					{
					case 0:
						if (superTabItem != null)
						{
							num = (short)638189569;
							if (num != 0)
							{
							}
							num = (short)219021314;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						superTabItem.OnImageSourceChanged((string)A_1.OldValue, (string)A_1.NewValue);
						num = (short)235601921;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_8E:
				superTabItem = (A_0 as global::DevComponents.WpfEditors.SuperTabItem);
				num = (short)1324679168;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00050BBC File Offset: 0x0004EDBC
		protected virtual void OnImageSourceChanged(string oldValue, string newValue)
		{
			short num = (short)980680704;
			short num2 = num;
			num = (short)1454833665;
			if (num != 0)
			{
			}
			num = (short)1983087942;
			short num3 = num;
			num = (short)1256490310;
			switch (num3 == num)
			{
			}
			num = (short)1577254912;
			if (num != 0)
			{
			}
			this.d();
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00050C6C File Offset: 0x0004EE6C
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00050D28 File Offset: 0x0004EF28
		public string ImageSource
		{
			get
			{
				short num = (short)2037907456;
				short num2 = num;
				num = (short)580300833;
				short num3 = num;
				num = (short)174370849;
				switch (num3 == num)
				{
				}
				num = (short)652345345;
				if (num != 0)
				{
				}
				num = (short)875364352;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.ImageSourceProperty);
			}
			set
			{
				short num = (short)1076690944;
				short num2 = num;
				num = (short)744558854;
				short num3 = num;
				num = (short)748032262;
				switch (num3 == num)
				{
				}
				num = (short)1763770369;
				if (num != 0)
				{
				}
				num = (short)994705408;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.ImageSourceProperty, value);
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00050DDC File Offset: 0x0004EFDC
		private void d()
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			object a_;
			for (;;)
			{
				IL_0A:
				num = (short)1566955175;
				short num2 = num;
				num = (short)1752159911;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_13B;
				default:
					num = (short)690421760;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_13B;
					case 1:
						if (!string.IsNullOrEmpty(this.ImageSource))
						{
							num = (short)1695154179;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = this.Image;
						num = (short)1865482242;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_115;
					case 3:
					{
						num = (short)1101725696;
						short num4 = num;
						num = (short)1084555265;
						if (num != 0)
						{
						}
						a_ = this.CreateImageFromImageSource(this.ImageSource);
						num = (short)1552220160;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6A;
				}
			}
			IL_115:
			IL_13B:
			this.RenderImage = a_;
			return;
			IL_6A:
			a_ = null;
			num = (short)1354366977;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00050F30 File Offset: 0x0004F130
		protected virtual global::System.Windows.Controls.Image CreateImageFromImageSource(string imageSource)
		{
			short num = (short)1308229632;
			short num2 = num;
			num = (short)1603956918;
			short num3 = num;
			num = (short)1378775222;
			switch (num3 == num)
			{
			}
			num = (short)2137718784;
			if (num != 0)
			{
			}
			num = (short)1577385985;
			if (num != 0)
			{
			}
			return new global::System.Windows.Controls.Image
			{
				Source = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(imageSource, global::System.UriKind.RelativeOrAbsolute)),
				SnapsToDevicePixels = true,
				Stretch = global::System.Windows.Media.Stretch.None
			};
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00051000 File Offset: 0x0004F200
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x000510B8 File Offset: 0x0004F2B8
		public object RenderImage
		{
			get
			{
				short num = (short)562364416;
				short num2 = num;
				num = (short)1871577089;
				if (num != 0)
				{
				}
				num = (short)2096963212;
				short num3 = num;
				num = (short)2009013900;
				switch (num3 == num)
				{
				}
				num = (short)321323008;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.RenderImageProperty);
			}
			internal set
			{
				short num = (short)1027735552;
				short num2 = num;
				num = (short)88539137;
				if (num != 0)
				{
				}
				num = (short)210850060;
				short num3 = num;
				num = (short)542986508;
				switch (num3 == num)
				{
				}
				num = (short)162725888;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.a, value);
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0005116C File Offset: 0x0004F36C
		private static void f(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1936751379;
			short num2 = num;
			num = (short)1815640851;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)53805056;
				short num3 = num;
				num = (short)1427046400;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				int num4;
				global::DevComponents.WpfEditors.SuperTabItem superTabItem;
				for (;;)
				{
					IL_7D:
					switch (num4)
					{
					case 0:
						num = (short)1356988417;
						if (num != 0)
						{
						}
						if (superTabItem != null)
						{
							num = (short)1587412994;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						superTabItem.OnImagePositionChanged((global::System.Windows.Controls.Dock)A_1.OldValue, (global::System.Windows.Controls.Dock)A_1.NewValue);
						num = (short)730857473;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_8F:
				superTabItem = (A_0 as global::DevComponents.WpfEditors.SuperTabItem);
				num = (short)749207552;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000512A0 File Offset: 0x0004F4A0
		protected virtual void OnImagePositionChanged(global::System.Windows.Controls.Dock oldValue, global::System.Windows.Controls.Dock newValue)
		{
			short num = (short)2490368;
			short num2 = num;
			num = (short)2007709570;
			short num3 = num;
			num = (short)803288962;
			switch (num3 == num)
			{
			}
			num = (short)2134179841;
			if (num != 0)
			{
			}
			num = (short)1537277952;
			if (num != 0)
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00051348 File Offset: 0x0004F548
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00051400 File Offset: 0x0004F600
		public global::System.Windows.Controls.Dock ImagePosition
		{
			get
			{
				short num = (short)800653312;
				short num2 = num;
				num = (short)1182685053;
				short num3 = num;
				num = (short)901535613;
				switch (num3 == num)
				{
				}
				num = (short)1367670784;
				if (num != 0)
				{
				}
				num = (short)1590624257;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Dock)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.ImagePositionProperty);
			}
			set
			{
				short num = (short)944898048;
				short num2 = num;
				num = (short)1564352480;
				short num3 = num;
				num = (short)1232674784;
				switch (num3 == num)
				{
				}
				num = (short)2118647808;
				if (num != 0)
				{
				}
				num = (short)1050935297;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.ImagePositionProperty, value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000514B8 File Offset: 0x0004F6B8
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0005156C File Offset: 0x0004F76C
		public object TabToolTip
		{
			get
			{
				short num = (short)2045640704;
				short num2 = num;
				num = (short)1628457767;
				short num3 = num;
				num = (short)1087130407;
				switch (num3 == num)
				{
				}
				num = (short)441581569;
				if (num != 0)
				{
				}
				num = (short)1297743872;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.TabToolTipProperty);
			}
			set
			{
				short num = (short)56229888;
				short num2 = num;
				num = (short)1477069652;
				short num3 = num;
				num = (short)136334164;
				switch (num3 == num)
				{
				}
				num = (short)732299264;
				if (num != 0)
				{
				}
				num = (short)1295319041;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.TabToolTipProperty, value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00051624 File Offset: 0x0004F824
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000516DC File Offset: 0x0004F8DC
		public global::System.Windows.Controls.ContextMenu TabContextMenu
		{
			get
			{
				short num = (short)967573504;
				short num2 = num;
				num = (short)1504976993;
				short num3 = num;
				num = (short)787816545;
				switch (num3 == num)
				{
				}
				num = (short)1760362497;
				if (num != 0)
				{
				}
				num = (short)1399586816;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.ContextMenu)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.TabContextMenuProperty);
			}
			set
			{
				short num = (short)602210304;
				short num2 = num;
				num = (short)1905533041;
				short num3 = num;
				num = (short)1078993009;
				switch (num3 == num)
				{
				}
				num = (short)404881409;
				if (num != 0)
				{
				}
				num = (short)2069823488;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.TabContextMenuProperty, value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00051794 File Offset: 0x0004F994
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00051850 File Offset: 0x0004FA50
		public global::DevComponents.WpfEditors.eTabCloseButtonVisibility CloseButtonVisibility
		{
			get
			{
				short num = (short)1453916160;
				short num2 = num;
				num = (short)780533761;
				if (num != 0)
				{
				}
				num = (short)960469745;
				short num3 = num;
				num = (short)1252170481;
				switch (num3 == num)
				{
				}
				num = (short)1929969664;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.eTabCloseButtonVisibility)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.CloseButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1507917824;
				short num2 = num;
				num = (short)992366806;
				short num3 = num;
				num = (short)413880534;
				switch (num3 == num)
				{
				}
				num = (short)132972545;
				if (num != 0)
				{
				}
				num = (short)1426522112;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.CloseButtonVisibilityProperty, value);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0005190C File Offset: 0x0004FB0C
		private static void e(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1471539344;
			short num2 = num;
			num = (short)254797968;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1194524672;
				short num3 = num;
				num = (short)1738539008;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				int num4;
				global::DevComponents.WpfEditors.SuperTabItem superTabItem;
				for (;;)
				{
					IL_7E:
					num = (short)249757697;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (superTabItem != null)
						{
							num = (short)954335234;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						superTabItem.OnCloseButtonVisibilityChanged((global::DevComponents.WpfEditors.eTabCloseButtonVisibility)A_1.OldValue, (global::DevComponents.WpfEditors.eTabCloseButtonVisibility)A_1.NewValue);
						num = (short)1575944193;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_B7:
				superTabItem = (A_0 as global::DevComponents.WpfEditors.SuperTabItem);
				num = (short)10813440;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7E;
			}
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00051A3C File Offset: 0x0004FC3C
		protected virtual void OnCloseButtonVisibilityChanged(global::DevComponents.WpfEditors.eTabCloseButtonVisibility oldValue, global::DevComponents.WpfEditors.eTabCloseButtonVisibility newValue)
		{
			short num = (short)883752960;
			short num2 = num;
			num = (short)866833403;
			short num3 = num;
			num = (short)1790563323;
			switch (num3 == num)
			{
			}
			num = (short)1644298241;
			if (num != 0)
			{
			}
			num = (short)1307967488;
			if (num != 0)
			{
			}
			base.CoerceValue(global::DevComponents.WpfEditors.SuperTabItem.EffectiveCloseButtonVisibilityProperty);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00051AF0 File Offset: 0x0004FCF0
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00051BAC File Offset: 0x0004FDAC
		public global::System.Windows.Visibility EffectiveCloseButtonVisibility
		{
			get
			{
				short num = (short)300220416;
				short num2 = num;
				num = (short)1399669177;
				short num3 = num;
				num = (short)1617576377;
				switch (num3 == num)
				{
				}
				num = (short)1379598336;
				if (num != 0)
				{
				}
				num = (short)498794497;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.EffectiveCloseButtonVisibilityProperty);
			}
			internal set
			{
				short num = (short)1113194496;
				short num2 = num;
				num = (short)180992778;
				short num3 = num;
				num = (short)1115273994;
				switch (num3 == num)
				{
				}
				num = (short)1303445504;
				if (num != 0)
				{
				}
				num = (short)1528430593;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.b, value);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00051C68 File Offset: 0x0004FE68
		private static object c(global::System.Windows.DependencyObject A_0, object A_1)
		{
			short num;
			global::DevComponents.WpfEditors.SuperTabItem superTabItem;
			for (;;)
			{
				num = (short)69271552;
				short num2 = num;
				superTabItem = (A_0 as global::DevComponents.WpfEditors.SuperTabItem);
				if (superTabItem != null)
				{
					break;
				}
				num = (short)869630327;
				short num3 = num;
				num = (short)1498186103;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7A;
				}
			}
			return superTabItem.OnCoerceEffectiveCloseButtonVisibility((global::System.Windows.Visibility)A_1);
			IL_7A:
			num = (short)1994326016;
			if (num != 0)
			{
			}
			num = (short)1956249601;
			if (num != 0)
			{
			}
			return A_1;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00051D30 File Offset: 0x0004FF30
		protected virtual global::System.Windows.Visibility OnCoerceEffectiveCloseButtonVisibility(global::System.Windows.Visibility value)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.eTabCloseButtonVisibility closeButtonVisibility;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2052784128;
					short num3 = num2;
					if (closeButtonVisibility == global::DevComponents.WpfEditors.eTabCloseButtonVisibility.VisibleOnMouseOver)
					{
						num2 = (short)671809546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return value;
				}
				case 1:
					if (closeButtonVisibility == global::DevComponents.WpfEditors.eTabCloseButtonVisibility.Visible)
					{
						num2 = (short)40501260;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)53870592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					global::DevComponents.WpfEditors.SuperTabControl superTabControl = this.SuperTabControlParent;
					num2 = (short)683540493;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (closeButtonVisibility == global::DevComponents.WpfEditors.eTabCloseButtonVisibility.Inherit)
					{
						num2 = (short)2081030146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_276;
				case 4:
				{
					if (closeButtonVisibility == global::DevComponents.WpfEditors.eTabCloseButtonVisibility.Inherit)
					{
						num2 = (short)940244997;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)832247399;
					short num4 = num2;
					num2 = (short)1119491687;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return global::System.Windows.Visibility.Visible;
					default:
						num2 = (short)1523580929;
						if (num2 != 0)
						{
						}
						num2 = (short)1909981184;
						if (num2 != 0)
						{
						}
						num2 = (short)189988865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_1F5;
				case 6:
					return value;
				case 7:
					if (base.IsMouseOver)
					{
						num2 = (short)695861256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::System.Windows.Visibility.Collapsed;
				case 8:
					return global::System.Windows.Visibility.Visible;
				case 9:
					num2 = (short)2057175044;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)905707527;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (closeButtonVisibility != global::DevComponents.WpfEditors.eTabCloseButtonVisibility.Hidden)
					{
						num2 = (short)1315831817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::System.Windows.Visibility.Collapsed;
				case 12:
					return global::System.Windows.Visibility.Visible;
				case 13:
				{
					global::DevComponents.WpfEditors.SuperTabControl superTabControl;
					if (superTabControl == null)
					{
						num2 = (short)1264123910;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					closeButtonVisibility = superTabControl.CloseButtonVisibility;
					num2 = (short)1489829902;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 14:
					goto IL_276;
				}
				goto IL_4C;
				IL_276:
				num2 = (short)637206539;
				num = (int)((global::System.IntPtr)num2);
			}
			return global::System.Windows.Visibility.Visible;
			IL_1F5:
			return global::System.Windows.Visibility.Collapsed;
			IL_4C:
			closeButtonVisibility = this.CloseButtonVisibility;
			num2 = (short)1820786691;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00051FF0 File Offset: 0x000501F0
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x000520A8 File Offset: 0x000502A8
		public global::System.Windows.Controls.Dock CloseButtonPosition
		{
			get
			{
				short num = (short)1408827392;
				short num2 = num;
				num = (short)1379926017;
				if (num != 0)
				{
				}
				num = (short)1591328597;
				short num3 = num;
				num = (short)1083162453;
				switch (num3 == num)
				{
				}
				num = (short)1742929920;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Dock)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.CloseButtonPositionProperty);
			}
			set
			{
				short num = (short)210788864;
				short num2 = num;
				num = (short)1504469504;
				switch (num2 == num)
				{
				}
				num = (short)1235550209;
				if (num != 0)
				{
				}
				num = (short)1565917184;
				if (num != 0)
				{
				}
				num = (short)2050293760;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.CloseButtonPositionProperty, value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00052160 File Offset: 0x00050360
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00052218 File Offset: 0x00050418
		public global::System.Windows.Media.Brush InnerBorderBrush
		{
			get
			{
				short num = (short)625646548;
				short num2 = num;
				num = (short)957324244;
				switch (num2 == num)
				{
				}
				num = (short)1445920768;
				if (num != 0)
				{
				}
				num = (short)1986134017;
				if (num != 0)
				{
				}
				num = (short)270008320;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.InnerBorderBrushProperty);
			}
			set
			{
				short num = (short)1644789186;
				short num2 = num;
				num = (short)1061191106;
				switch (num2 == num)
				{
				}
				num = (short)608043009;
				if (num != 0)
				{
				}
				num = (short)1498480640;
				if (num != 0)
				{
				}
				num = (short)402849792;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.InnerBorderBrushProperty, value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000522CC File Offset: 0x000504CC
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00052384 File Offset: 0x00050584
		public global::System.Windows.Thickness InnerBorderThickness
		{
			get
			{
				short num = (short)1600843493;
				short num2 = num;
				num = (short)18149093;
				switch (num2 == num)
				{
				}
				num = (short)2039939073;
				if (num != 0)
				{
				}
				num = (short)1247739904;
				if (num != 0)
				{
				}
				num = (short)786694144;
				short num3 = num;
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.InnerBorderThicknessProperty);
			}
			set
			{
				short num = (short)208174041;
				short num2 = num;
				num = (short)302218201;
				switch (num2 == num)
				{
				}
				num = (short)2133983233;
				if (num != 0)
				{
				}
				num = (short)1179254784;
				if (num != 0)
				{
				}
				num = (short)19398656;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.InnerBorderThicknessProperty, value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00052440 File Offset: 0x00050640
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x000524F8 File Offset: 0x000506F8
		public global::DevComponents.WpfEditors.eTabItemState TabState
		{
			get
			{
				short num = (short)250047865;
				short num2 = num;
				num = (short)814640505;
				switch (num2 == num)
				{
				}
				num = (short)77856769;
				if (num != 0)
				{
				}
				num = (short)631832576;
				if (num != 0)
				{
				}
				num = (short)1979252736;
				short num3 = num;
				return (global::DevComponents.WpfEditors.eTabItemState)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.TabStateProperty);
			}
			internal set
			{
				short num = (short)27188783;
				short num2 = num;
				num = (short)18669103;
				switch (num2 == num)
				{
				}
				num = (short)1356333057;
				if (num != 0)
				{
				}
				num = (short)1576337408;
				if (num != 0)
				{
				}
				num = (short)1771962368;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.c, value);
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000525B4 File Offset: 0x000507B4
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					superTabItem.OnTabStateChanged((global::DevComponents.WpfEditors.eTabItemState)A_1.OldValue, (global::DevComponents.WpfEditors.eTabItemState)A_1.NewValue);
					num2 = (short)103940097;
					if (num2 != 0)
					{
					}
					num2 = (short)1154351105;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_B0;
				case 2:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					if (superTabItem != null)
					{
						num2 = (short)276824064;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DA;
				}
				}
				goto IL_1C;
			}
			IL_B0:
			num2 = (short)934084608;
			short num3 = num2;
			IL_DA:
			num2 = (short)1625050660;
			short num4 = num2;
			num2 = (short)1562660388;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				global::DevComponents.WpfEditors.SuperTabItem superTabItem = A_0 as global::DevComponents.WpfEditors.SuperTabItem;
				num2 = (short)860684290;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)858587136;
				if (num2 != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000526E8 File Offset: 0x000508E8
		protected virtual void OnTabStateChanged(global::DevComponents.WpfEditors.eTabItemState oldValue, global::DevComponents.WpfEditors.eTabItemState newValue)
		{
			short num = (short)1162870785;
			if (num != 0)
			{
			}
			num = (short)815165793;
			short num2 = num;
			num = (short)1089040737;
			switch (num2 == num)
			{
			}
			num = (short)1168244736;
			if (num != 0)
			{
			}
			num = (short)39714816;
			short num3 = num;
			this.c();
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00052798 File Offset: 0x00050998
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00052858 File Offset: 0x00050A58
		public global::DevComponents.WpfEditors.eTabStyle TabStripStyle
		{
			get
			{
				short num = (short)403767297;
				if (num != 0)
				{
				}
				num = (short)2100884776;
				short num2 = num;
				num = (short)839054632;
				switch (num2 == num)
				{
				}
				num = (short)1449263104;
				if (num != 0)
				{
				}
				num = (short)1774452736;
				short num3 = num;
				return (global::DevComponents.WpfEditors.eTabStyle)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.TabStripStyleProperty);
			}
			internal set
			{
				short num = (short)893394972;
				short num2 = num;
				num = (short)655106076;
				switch (num2 == num)
				{
				}
				num = (short)161808384;
				if (num != 0)
				{
				}
				num = (short)1704853505;
				if (num != 0)
				{
				}
				num = (short)787218432;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.d, value);
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00052914 File Offset: 0x00050B14
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					superTabItem.OnTabStripStyleChanged((global::DevComponents.WpfEditors.eTabStyle)A_1.OldValue, (global::DevComponents.WpfEditors.eTabStyle)A_1.NewValue);
					num2 = (short)2092630017;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_82;
				case 2:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					if (superTabItem != null)
					{
						num2 = (short)830603264;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_84;
				}
				}
				goto IL_1C;
			}
			IL_82:
			IL_84:
			num2 = (short)1508442112;
			short num3 = num2;
			num2 = (short)1844733212;
			short num4 = num2;
			num2 = (short)180118812;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				global::DevComponents.WpfEditors.SuperTabItem superTabItem = A_0 as global::DevComponents.WpfEditors.SuperTabItem;
				num2 = (short)1196425218;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)993722369;
				if (num2 != 0)
				{
				}
				num2 = (short)2109669376;
				if (num2 != 0)
				{
				}
				return;
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00052A44 File Offset: 0x00050C44
		protected virtual void OnTabStripStyleChanged(global::DevComponents.WpfEditors.eTabStyle oldValue, global::DevComponents.WpfEditors.eTabStyle newValue)
		{
			short num = (short)1883868104;
			short num2 = num;
			num = (short)602377160;
			switch (num2 == num)
			{
			}
			num = (short)393936897;
			if (num != 0)
			{
			}
			num = (short)262537216;
			if (num != 0)
			{
			}
			num = (short)181927936;
			short num3 = num;
			this.c();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00052AF4 File Offset: 0x00050CF4
		private static object b(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.SuperTabItem superTabItem = A_0 as global::DevComponents.WpfEditors.SuperTabItem;
			if (superTabItem != null)
			{
				short num = (short)2146893824;
				short num2 = num;
				num = (short)558307593;
				short num3 = num;
				num = (short)48044297;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)922091520;
					if (num != 0)
					{
					}
					num = (short)632684545;
					if (num != 0)
					{
					}
					return superTabItem.OnCoerceTabStripStyle((global::DevComponents.WpfEditors.eTabStyle)A_1);
				}
			}
			return A_1;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00052BC0 File Offset: 0x00050DC0
		protected virtual global::DevComponents.WpfEditors.eTabStyle OnCoerceTabStripStyle(global::DevComponents.WpfEditors.eTabStyle value)
		{
			global::DevComponents.WpfEditors.SuperTabControl superTabControl = this.SuperTabControlParent;
			if (superTabControl == null)
			{
				short num = (short)861274112;
				short num2 = num;
				num = (short)312147969;
				if (num != 0)
				{
				}
				num = (short)2128693203;
				short num3 = num;
				num = (short)1356416979;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1810694144;
					if (num != 0)
					{
					}
					return value;
				}
			}
			return superTabControl.TabStyle;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00052C80 File Offset: 0x00050E80
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					superTabItem.OnTabColorChanged((global::DevComponents.WpfEditors.eTabItemColor)A_1.OldValue, (global::DevComponents.WpfEditors.eTabItemColor)A_1.NewValue);
					num2 = (short)465436673;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_83;
				case 2:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					if (superTabItem != null)
					{
						num2 = (short)404029440;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_85;
				}
				}
				goto IL_1C;
			}
			IL_83:
			IL_85:
			num2 = (short)471859200;
			short num3 = num2;
			num2 = (short)2094413532;
			short num4 = num2;
			num2 = (short)238368476;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				global::DevComponents.WpfEditors.SuperTabItem superTabItem = A_0 as global::DevComponents.WpfEditors.SuperTabItem;
				num2 = (short)1994915842;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)802422785;
				if (num2 != 0)
				{
				}
				num2 = (short)640876544;
				if (num2 != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00052DAC File Offset: 0x00050FAC
		protected virtual void OnTabColorChanged(global::DevComponents.WpfEditors.eTabItemColor oldValue, global::DevComponents.WpfEditors.eTabItemColor newValue)
		{
			short num = (short)1037375639;
			short num2 = num;
			num = (short)1097603223;
			switch (num2 == num)
			{
			}
			num = (short)932184065;
			if (num != 0)
			{
			}
			num = (short)1002242048;
			if (num != 0)
			{
			}
			num = (short)693370880;
			short num3 = num;
			this.c();
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00052E58 File Offset: 0x00051058
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00052F14 File Offset: 0x00051114
		public global::DevComponents.WpfEditors.eTabItemColor TabColor
		{
			get
			{
				short num = (short)2064449537;
				if (num != 0)
				{
				}
				num = (short)281050604;
				short num2 = num;
				num = (short)1339981292;
				switch (num2 == num)
				{
				}
				num = (short)341049344;
				if (num != 0)
				{
				}
				num = (short)1567293440;
				short num3 = num;
				return (global::DevComponents.WpfEditors.eTabItemColor)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.TabColorProperty);
			}
			set
			{
				short num = (short)562102273;
				if (num != 0)
				{
				}
				num = (short)1329601883;
				short num2 = num;
				num = (short)1451892059;
				switch (num2 == num)
				{
				}
				num = (short)351928320;
				if (num != 0)
				{
				}
				num = (short)1414987776;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.TabColorProperty, value);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00052FD0 File Offset: 0x000511D0
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00053088 File Offset: 0x00051288
		public global::System.Windows.Media.Brush ContentBackground
		{
			get
			{
				short num = (short)209879825;
				short num2 = num;
				num = (short)1366983441;
				switch (num2 == num)
				{
				}
				num = (short)712507393;
				if (num != 0)
				{
				}
				num = (short)501547008;
				if (num != 0)
				{
				}
				num = (short)566493184;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.ContentBackgroundProperty);
			}
			set
			{
				short num = (short)1548801828;
				short num2 = num;
				num = (short)439670564;
				switch (num2 == num)
				{
				}
				num = (short)752484353;
				if (num != 0)
				{
				}
				num = (short)1560608768;
				if (num != 0)
				{
				}
				num = (short)1693646848;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.ContentBackgroundProperty, value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0005313C File Offset: 0x0005133C
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000531F8 File Offset: 0x000513F8
		public global::System.Windows.Media.Brush ContentBorderBrush
		{
			get
			{
				short num = (short)1114561088;
				short num2 = num;
				num = (short)448715328;
				switch (num2 == num)
				{
				}
				num = (short)1801650176;
				if (num != 0)
				{
				}
				num = (short)1115226113;
				if (num != 0)
				{
				}
				num = (short)34340864;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.ContentBorderBrushProperty);
			}
			set
			{
				short num = (short)381313798;
				short num2 = num;
				num = (short)1587045126;
				switch (num2 == num)
				{
				}
				num = (short)1012137984;
				if (num != 0)
				{
				}
				num = (short)1733951489;
				if (num != 0)
				{
				}
				num = (short)20447232;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.ContentBorderBrushProperty, value);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000532AC File Offset: 0x000514AC
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0005336C File Offset: 0x0005156C
		public global::System.Windows.Media.Brush ContentInnerBorderBrush
		{
			get
			{
				short num = (short)4190947;
				short num2 = num;
				num = (short)214495971;
				switch (num2 == num)
				{
				}
				num = (short)1849229313;
				if (num != 0)
				{
				}
				num = (short)2114912256;
				if (num != 0)
				{
				}
				num = (short)2134179840;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.ContentInnerBorderBrushProperty);
			}
			set
			{
				short num = (short)1598964168;
				short num2 = num;
				num = (short)887243208;
				switch (num2 == num)
				{
				}
				num = (short)1103691777;
				if (num != 0)
				{
				}
				num = (short)1262485504;
				if (num != 0)
				{
				}
				num = (short)2128805888;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.ContentInnerBorderBrushProperty, value);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600042A RID: 1066 RVA: 0x00053424 File Offset: 0x00051624
		// (remove) Token: 0x0600042B RID: 1067 RVA: 0x000534D8 File Offset: 0x000516D8
		public event global::DevComponents.WpfEditors.TabClosingRoutedEventHandler Closing
		{
			add
			{
				short num = (short)1936241688;
				short num2 = num;
				num = (short)749843480;
				switch (num2 == num)
				{
				}
				num = (short)1741488128;
				if (num != 0)
				{
				}
				num = (short)1162870785;
				if (num != 0)
				{
				}
				num = (short)2014838784;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.SuperTabItem.ClosingEvent, value);
			}
			remove
			{
				short num = (short)240607145;
				short num2 = num;
				num = (short)1981177769;
				switch (num2 == num)
				{
				}
				num = (short)764018689;
				if (num != 0)
				{
				}
				num = (short)1920270336;
				if (num != 0)
				{
				}
				num = (short)1731002368;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.SuperTabItem.ClosingEvent, value);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0005358C File Offset: 0x0005178C
		protected virtual void OnClosing(global::DevComponents.WpfEditors.TabClosingRoutedEventArgs eventArgs)
		{
			short num = (short)965370155;
			short num2 = num;
			num = (short)850813227;
			switch (num2 == num)
			{
			}
			num = (short)1839267841;
			if (num != 0)
			{
			}
			num = (short)1182859264;
			if (num != 0)
			{
			}
			num = (short)425459712;
			short num3 = num;
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600042D RID: 1069 RVA: 0x0005363C File Offset: 0x0005183C
		// (remove) Token: 0x0600042E RID: 1070 RVA: 0x000536F4 File Offset: 0x000518F4
		public event global::System.Windows.RoutedEventHandler Closed
		{
			add
			{
				short num = (short)1348468737;
				if (num != 0)
				{
				}
				num = (short)525050106;
				short num2 = num;
				num = (short)1309516026;
				switch (num2 == num)
				{
				}
				num = (short)2074869760;
				if (num != 0)
				{
				}
				num = (short)296878080;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.SuperTabItem.ClosedEvent, value);
			}
			remove
			{
				short num = (short)2066947908;
				short num2 = num;
				num = (short)1904090948;
				switch (num2 == num)
				{
				}
				num = (short)1057226753;
				if (num != 0)
				{
				}
				num = (short)2071855104;
				if (num != 0)
				{
				}
				num = (short)644874240;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.SuperTabItem.ClosedEvent, value);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000537A8 File Offset: 0x000519A8
		protected virtual void OnClosed()
		{
			short num = (short)163338694;
			short num2 = num;
			num = (short)1406818758;
			switch (num2 == num)
			{
			}
			num = (short)1986461697;
			if (num != 0)
			{
			}
			num = (short)569901056;
			if (num != 0)
			{
			}
			num = (short)846528512;
			short num3 = num;
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.SuperTabItem.ClosedEvent);
			base.RaiseEvent(routedEventArgs);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00053868 File Offset: 0x00051A68
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00053924 File Offset: 0x00051B24
		public global::DevComponents.WpfEditors.eSuperTabControlLayoutType TabLayoutType
		{
			get
			{
				short num = (short)1453654017;
				if (num != 0)
				{
				}
				num = (short)2133328846;
				short num2 = num;
				num = (short)1309869006;
				switch (num2 == num)
				{
				}
				num = (short)196542464;
				if (num != 0)
				{
				}
				num = (short)110690304;
				short num3 = num;
				return (global::DevComponents.WpfEditors.eSuperTabControlLayoutType)base.GetValue(global::DevComponents.WpfEditors.SuperTabItem.TabLayoutTypeProperty);
			}
			internal set
			{
				short num = (short)1057135033;
				short num2 = num;
				num = (short)58497465;
				switch (num2 == num)
				{
				}
				num = (short)1445724160;
				if (num != 0)
				{
				}
				num = (short)1999306753;
				if (num != 0)
				{
				}
				num = (short)653393920;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabItem.e, value);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000539E0 File Offset: 0x00051BE0
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1220149249;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					superTabItem.OnTabLayoutTypeChanged((global::DevComponents.WpfEditors.eSuperTabControlLayoutType)A_1.OldValue, (global::DevComponents.WpfEditors.eSuperTabControlLayoutType)A_1.NewValue);
					num2 = (short)349306881;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_B1;
				case 2:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					if (superTabItem != null)
					{
						num2 = (short)2104819712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DB;
				}
				}
				goto IL_1C;
			}
			IL_B1:
			num2 = (short)901382144;
			short num3 = num2;
			IL_DB:
			num2 = (short)915362224;
			short num4 = num2;
			num2 = (short)1422086576;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				global::DevComponents.WpfEditors.SuperTabItem superTabItem = A_0 as global::DevComponents.WpfEditors.SuperTabItem;
				num2 = (short)564002818;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)1813708800;
				if (num2 != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00053B14 File Offset: 0x00051D14
		protected virtual void OnTabLayoutTypeChanged(global::DevComponents.WpfEditors.eSuperTabControlLayoutType oldValue, global::DevComponents.WpfEditors.eSuperTabControlLayoutType newValue)
		{
			short num = (short)1817867431;
			short num2 = num;
			num = (short)2143188135;
			switch (num2 == num)
			{
			}
			num = (short)972488704;
			if (num != 0)
			{
			}
			num = (short)1414529025;
			if (num != 0)
			{
			}
			num = (short)1974534144;
			short num3 = num;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00053BC0 File Offset: 0x00051DC0
		private static object a(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.SuperTabItem superTabItem = A_0 as global::DevComponents.WpfEditors.SuperTabItem;
			short num;
			if (superTabItem != null)
			{
				num = (short)1390346240;
				short num2 = num;
				num = (short)446354658;
				short num3 = num;
				num = (short)1670108386;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)563806208;
					if (num != 0)
					{
					}
					return superTabItem.OnCoerceTabLayoutType((global::DevComponents.WpfEditors.eSuperTabControlLayoutType)A_1);
				}
			}
			num = (short)1098252289;
			if (num != 0)
			{
			}
			return A_1;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00053C8C File Offset: 0x00051E8C
		protected virtual global::DevComponents.WpfEditors.eSuperTabControlLayoutType OnCoerceTabLayoutType(global::DevComponents.WpfEditors.eSuperTabControlLayoutType value)
		{
			global::DevComponents.WpfEditors.SuperTabControl superTabControl = this.SuperTabControlParent;
			if (superTabControl == null)
			{
				short num = (short)1652686848;
				short num2 = num;
				num = (short)52142281;
				short num3 = num;
				num = (short)2005770441;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)871563264;
					if (num != 0)
					{
					}
					num = (short)1783693313;
					if (num != 0)
					{
					}
					return value;
				}
			}
			return superTabControl.TabLayoutType;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00053D4C File Offset: 0x00051F4C
		static SuperTabItem()
		{
			int a_ = 19;
			short num = (short)1081106983;
			short num2 = num;
			num = (short)418865703;
			switch (num2 == num)
			{
			}
			num = (short)919142401;
			if (num != 0)
			{
			}
			num = (short)1744699392;
			if (num != 0)
			{
			}
			num = (short)1870397440;
			short num3 = num;
			global::DevComponents.WpfEditors.SuperTabItem.HeaderChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꣟蟡藣若跧飩꿫蛭釯鳱鏳鏵鳷", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.SuperTabItem));
			global::DevComponents.WpfEditors.SuperTabItem.CloseTab = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꏟ軡诣闥跧", a_), typeof(global::DevComponents.WpfEditors.SuperTabItem));
			global::DevComponents.WpfEditors.SuperTabItem.ImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꧟迡藣臥跧", a_), typeof(object), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabItem.h)));
			global::DevComponents.WpfEditors.SuperTabItem.ImageSourceProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꧟迡藣臥跧맩菫鯭苯釱釳", a_), typeof(string), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabItem.g)));
			global::DevComponents.WpfEditors.SuperTabItem.a = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("닟蟡諣若跧飩ꗫ菭釯闱釳", a_), typeof(object), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabItem.RenderImageProperty = global::DevComponents.WpfEditors.SuperTabItem.a.DependencyProperty;
			global::DevComponents.WpfEditors.SuperTabItem.ImagePositionProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꧟迡藣臥跧뫩菫鷭駯蛱鷳駵雷", a_), typeof(global::System.Windows.Controls.Dock), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Controls.Dock.Left, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabItem.f)));
			global::DevComponents.WpfEditors.SuperTabItem.TabToolTipProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟菡蛣닥蟧藩胫뫭駯英", a_), typeof(object), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabItem.TabContextMenuProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟菡蛣ꗥ蟧蓩飫语裯蛱맳鏵雷迹", a_), typeof(global::System.Windows.Controls.ContextMenu), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabItem.CloseButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꏟ軡诣闥跧꣩駫髭蓯鷱髳ꃵ釷觹闻鳽槿渁洃爅焇", a_), typeof(global::DevComponents.WpfEditors.eTabCloseButtonVisibility), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eTabCloseButtonVisibility.Inherit, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabItem.e)));
			global::DevComponents.WpfEditors.SuperTabItem.b = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꗟ蓡苣菥诧黩藫飭闯뇱飳駵请鿹뻻诽瓿瘁欃栅帇按缋服爏笑砓缕気挙", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Collapsed, null, new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.SuperTabItem.c)));
			global::DevComponents.WpfEditors.SuperTabItem.EffectiveCloseButtonVisibilityProperty = global::DevComponents.WpfEditors.SuperTabItem.b.DependencyProperty;
			global::DevComponents.WpfEditors.SuperTabItem.CloseButtonPositionProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꏟ軡诣闥跧꣩駫髭蓯鷱髳꛵韷觹闻諽槿洁樃", a_), typeof(global::System.Windows.Controls.Dock), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Controls.Dock.Right));
			global::DevComponents.WpfEditors.SuperTabItem.InnerBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꧟賡諣菥髧꣩菫鳭铯韱蛳듵諷迹迻雽", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.SuperTabItem.InnerBorderThicknessProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꧟賡諣菥髧꣩菫鳭铯韱蛳ꋵ郷鏹鿻闽滿朁眃甅", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.PropertyMetadata(default(global::System.Windows.Thickness)));
			global::DevComponents.WpfEditors.SuperTabItem.c = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟菡蛣뗥鳧诩飫语", a_), typeof(global::DevComponents.WpfEditors.eTabItemState), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eTabItemState.Normal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabItem.d)));
			global::DevComponents.WpfEditors.SuperTabItem.TabStateProperty = global::DevComponents.WpfEditors.SuperTabItem.c.DependencyProperty;
			global::DevComponents.WpfEditors.SuperTabItem.d = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟菡蛣뗥鳧飩藫黭ꏯ蛱跳髵鷷", a_), typeof(global::DevComponents.WpfEditors.eTabStyle), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eTabStyle.OneNote2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabItem.c), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.SuperTabItem.b)));
			global::DevComponents.WpfEditors.SuperTabItem.TabStripStyleProperty = global::DevComponents.WpfEditors.SuperTabItem.d.DependencyProperty;
			global::DevComponents.WpfEditors.SuperTabItem.TabColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟菡蛣ꗥ蟧蛩菫鳭", a_), typeof(global::DevComponents.WpfEditors.eTabItemColor), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eTabItemColor.Default, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabItem.b)));
			global::DevComponents.WpfEditors.SuperTabItem.ContentBackgroundProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꏟ跡諣鋥跧蓩飫곭釯釱鿳釵諷闹觻都擿", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabItem.ContentBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꏟ跡諣鋥跧蓩飫곭鿯胱郳鏵諷룹軻诽珿樁", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabItem.ContentInnerBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꏟ跡諣鋥跧蓩飫꟭黯鳱釳蓵뫷闹軻髽旿瀁䘃琅紇礉搋", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabItem.ClosingEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꏟ軡诣闥臧蓩诫", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::DevComponents.WpfEditors.TabClosingRoutedEventHandler), typeof(global::DevComponents.WpfEditors.SuperTabItem));
			global::DevComponents.WpfEditors.SuperTabItem.ClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꏟ軡诣闥跧軩", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.SuperTabItem));
			global::DevComponents.WpfEditors.SuperTabItem.e = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟菡蛣ꫥ觧鏩菫鯭蓯꛱跳蛵鷷", a_), typeof(global::DevComponents.WpfEditors.eSuperTabControlLayoutType), typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eSuperTabControlLayoutType.SingleLine, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabItem.a), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.SuperTabItem.a)));
			global::DevComponents.WpfEditors.SuperTabItem.TabLayoutTypeProperty = global::DevComponents.WpfEditors.SuperTabItem.e.DependencyProperty;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.SuperTabItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.SuperTabItem)));
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00054354 File Offset: 0x00052554
		public override void OnApplyTemplate()
		{
			short num = (short)1714880313;
			short num2 = num;
			num = (short)598277945;
			switch (num2 == num)
			{
			}
			num = (short)903151617;
			if (num != 0)
			{
			}
			num = (short)1013514240;
			if (num != 0)
			{
			}
			num = (short)1093468160;
			short num3 = num;
			base.OnApplyTemplate();
			this.c();
			base.CoerceValue(global::DevComponents.WpfEditors.SuperTabItem.TabStripStyleProperty);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00054414 File Offset: 0x00052614
		private void c()
		{
			short num = (short)2093809664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				string text;
				global::DevComponents.WpfEditors.eTabItemColor tabColor;
				string text2;
				string str;
				string str2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						string resourceId = text + global::System.Enum.GetName(typeof(global::System.Windows.Controls.Dock), base.TabStripPlacement) + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eTabItemState), global::DevComponents.WpfEditors.eTabItemState.Normal) + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eSuperTabItemColorPart), global::DevComponents.WpfEditors.eSuperTabItemColorPart.Background);
						num = (short)967049217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						string resourceId;
						if (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), resourceId)) != null)
						{
							num = (short)1222967308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61D;
					}
					case 2:
						goto IL_1DA;
					case 3:
					{
						num = (short)912902665;
						short num3 = num;
						num = (short)1917897225;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_600;
						default:
						{
							num = (short)2116943872;
							if (num != 0)
							{
							}
							num = (short)1578893312;
							short num4 = num;
							if (tabColor == global::DevComponents.WpfEditors.eTabItemColor.Default)
							{
								num = (short)42532880;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_61D;
						}
						}
						break;
					}
					case 4:
					{
						if (tabColor == global::DevComponents.WpfEditors.eTabItemColor.Custom)
						{
							num = (short)374145029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = "";
						text2 = "";
						global::DevComponents.WpfEditors.eTabStyle tabStripStyle = this.TabStripStyle;
						num = (short)1231290369;
						if (num != 0)
						{
						}
						num = (short)783155215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						return;
					case 6:
					{
						global::DevComponents.WpfEditors.eTabStyle tabStripStyle;
						text = global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eTabStyle), tabStripStyle);
						text2 = text;
						num = (short)2089811985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_618;
					case 8:
						text2 += global::System.Enum.GetName(typeof(global::System.Windows.Controls.Dock), base.TabStripPlacement);
						num = (short)2018639874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (base.TabStripPlacement != global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1076822016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DA;
					case 10:
						goto IL_65B;
					case 11:
						if (this.TabState != global::DevComponents.WpfEditors.eTabItemState.Selected)
						{
							num = (short)205389842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E9;
					case 12:
						text += global::System.Enum.GetName(typeof(global::System.Windows.Controls.Dock), base.TabStripPlacement);
						num = (short)1367015427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_61D;
					case 14:
					{
						string resourceId = text2 + global::System.Enum.GetName(typeof(global::System.Windows.Controls.Dock), base.TabStripPlacement) + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eTabItemState), global::DevComponents.WpfEditors.eTabItemState.Normal) + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eSuperTabItemColorPart), global::DevComponents.WpfEditors.eSuperTabItemColorPart.Background);
						num = (short)2004287507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						if (tabColor == global::DevComponents.WpfEditors.eTabItemColor.Default)
						{
							num = (short)1046544390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.eTabStyle tabStripStyle;
						text = global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eTabStyle), tabStripStyle);
						text2 = global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eTabItemColor), tabColor);
						num = (short)1674248202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						text2 += global::System.Enum.GetName(typeof(global::System.Windows.Controls.Dock), base.TabStripPlacement);
						num = (short)1895432205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_65B;
					case 18:
						num = (short)522715157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						string resourceId;
						if (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), resourceId)) != null)
						{
							num = (short)302907400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DA;
					}
					case 20:
						if (tabColor != global::DevComponents.WpfEditors.eTabItemColor.Default)
						{
							num = (short)123600910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DA;
					case 21:
						if (this.TabState == global::DevComponents.WpfEditors.eTabItemState.SelectedMouseOver)
						{
							goto IL_600;
						}
						goto IL_73A;
					}
					goto IL_87;
					IL_1DA:
					str = text;
					str2 = text2;
					text += global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eTabItemState), this.TabState);
					text2 += global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eTabItemState), this.TabState);
					base.SetResourceReference(global::System.Windows.Controls.Control.BackgroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), text2 + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eSuperTabItemColorPart), global::DevComponents.WpfEditors.eSuperTabItemColorPart.Background)));
					base.SetResourceReference(global::System.Windows.Controls.Control.BorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), text + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eSuperTabItemColorPart), global::DevComponents.WpfEditors.eSuperTabItemColorPart.Border)));
					base.SetResourceReference(global::DevComponents.WpfEditors.SuperTabItem.InnerBorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), text + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eSuperTabItemColorPart), global::DevComponents.WpfEditors.eSuperTabItemColorPart.BorderInner)));
					base.SetResourceReference(global::System.Windows.Controls.Control.ForegroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), text + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eSuperTabItemColorPart), global::DevComponents.WpfEditors.eSuperTabItemColorPart.Foreground)));
					num = (short)180486155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_600:
					num = (short)990707719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61D:
					num = (short)1511587860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65B:
					num = (short)910360585;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3E9:
				text = str + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eTabItemState), global::DevComponents.WpfEditors.eTabItemState.Selected);
				text2 = str2 + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eTabItemState), global::DevComponents.WpfEditors.eTabItemState.Selected);
				base.SetResourceReference(global::DevComponents.WpfEditors.SuperTabItem.ContentBackgroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), text2 + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eSuperTabItemColorPart), global::DevComponents.WpfEditors.eSuperTabItemColorPart.ContentBackground)));
				base.SetResourceReference(global::DevComponents.WpfEditors.SuperTabItem.ContentBorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), text + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eSuperTabItemColorPart), global::DevComponents.WpfEditors.eSuperTabItemColorPart.ContentBorder)));
				base.SetResourceReference(global::DevComponents.WpfEditors.SuperTabItem.ContentInnerBorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabItem), text + global::System.Enum.GetName(typeof(global::DevComponents.WpfEditors.eSuperTabItemColorPart), global::DevComponents.WpfEditors.eSuperTabItemColorPart.ContentInnerBorder)));
				return;
				IL_618:
				goto IL_3E9;
				IL_73A:
				base.ClearValue(global::DevComponents.WpfEditors.SuperTabItem.ContentBackgroundProperty);
				base.ClearValue(global::DevComponents.WpfEditors.SuperTabItem.ContentBorderBrushProperty);
				return;
				IL_87:
				tabColor = this.TabColor;
				num = (short)1630994436;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00054B74 File Offset: 0x00052D74
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)982581248;
			short num2 = num;
			num = (short)1592655872;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 1:
					goto IL_115;
				case 2:
					this.c();
					num = (short)1105788929;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5C:
				num = (short)701497345;
				if (num != 0)
				{
				}
				if (e.Property != global::System.Windows.Controls.TabItem.TabStripPlacementProperty)
				{
					break;
				}
				num = (short)728725837;
				short num4 = num;
				num = (short)908032333;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_115;
				default:
					num = (short)1370357760;
					if (num != 0)
					{
					}
					num = (short)269680642;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_115:
			base.OnPropertyChanged(e);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00054CA0 File Offset: 0x00052EA0
		protected override void OnSelected(global::System.Windows.RoutedEventArgs e)
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
					num2 = (short)836108289;
					if (num2 != 0)
					{
					}
					if (this.f == 0)
					{
						goto IL_71;
					}
					goto IL_CF;
				case 1:
				{
					num2 = (short)1362296832;
					short num3 = num2;
					goto IL_CF;
				}
				case 2:
					this.f = 1;
					num2 = (short)282066945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
				IL_71:
				num2 = (short)163643394;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CF:
				num2 = (short)1481298363;
				short num4 = num2;
				num2 = (short)353161659;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_71;
				default:
					goto IL_103;
				}
			}
			IL_103:
			num2 = (short)895811584;
			if (num2 != 0)
			{
			}
			global::System.Windows.Controls.Panel.SetZIndex(this, 100);
			this.b();
			return;
			IL_1C:
			base.OnSelected(e);
			this.f = global::System.Windows.Controls.Panel.GetZIndex(this);
			num2 = (short)202637312;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00054DD4 File Offset: 0x00052FD4
		protected override void OnUnselected(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1933957574;
			short num2 = num;
			num = (short)1791416774;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1234173952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)727515137;
			if (num != 0)
			{
			}
			num = (short)1204748288;
			if (num != 0)
			{
			}
			base.OnUnselected(e);
			global::System.Windows.Controls.Panel.SetZIndex(this, this.f);
			this.b();
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00054E98 File Offset: 0x00053098
		private void b()
		{
			short num = (short)473956359;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.IsMouseOverTab)
					{
						num = (short)1257242624;
						short num3 = num;
						num = (short)484507650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.TabState = global::DevComponents.WpfEditors.eTabItemState.Selected;
					num = (short)714604548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.IsMouseOverTab)
					{
						goto IL_1EA;
					}
					num = (short)51904513;
					if (num != 0)
					{
					}
					this.TabState = global::DevComponents.WpfEditors.eTabItemState.Normal;
					num = (short)559546377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.TabState = global::DevComponents.WpfEditors.eTabItemState.SelectedMouseOver;
					num = (short)664666120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.TabState = global::DevComponents.WpfEditors.eTabItemState.NormalMouseOver;
					num = (short)51183622;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_F7;
				case 5:
					num = (short)1567424512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_D4;
				case 7:
				{
					num = (short)2086295083;
					short num4 = num;
					num = (short)1344099883;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1EA;
					default:
						num = (short)395182080;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_98;
						}
						continue;
					}
					break;
				}
				case 8:
					goto IL_1C6;
				case 9:
					goto IL_1A6;
				}
				IL_98:
				if (base.IsSelected)
				{
					num = (short)1758724101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)227409921;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EA:
				num = (short)875954179;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D4:
			IL_F7:
			IL_1A6:
			IL_1C6:
			base.CoerceValue(global::DevComponents.WpfEditors.SuperTabItem.EffectiveCloseButtonVisibilityProperty);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x000550B8 File Offset: 0x000532B8
		protected virtual bool IsMouseOverTab
		{
			get
			{
				short num = (short)1789460549;
				short num2 = num;
				num = (short)2048786501;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2117926912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1236205569;
				if (num != 0)
				{
				}
				num = (short)517406720;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00055168 File Offset: 0x00053368
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)452442965;
			short num2 = num;
			num = (short)233552725;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1069875200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1730936833;
			if (num != 0)
			{
			}
			num = (short)1133576192;
			if (num != 0)
			{
			}
			this.a(e);
			this.b();
			base.OnMouseEnter(e);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00055224 File Offset: 0x00053424
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1072434984;
			short num2 = num;
			num = (short)944508712;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1669398528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)299892736;
			if (num != 0)
			{
			}
			num = (short)502464513;
			if (num != 0)
			{
			}
			this.a(e);
			this.b();
			base.OnMouseLeave(e);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000552E0 File Offset: 0x000534E0
		private void a(global::System.Windows.Input.MouseEventArgs A_0)
		{
			short num = (short)2098280396;
			short num2 = num;
			num = (short)707344332;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1700462592;
				if (num != 0)
				{
				}
				num = (short)837812225;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
						global::System.Windows.Point position = A_0.GetPosition(this);
						num = (short)1319370755;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 2:
						goto IL_F8;
					case 3:
					{
						global::System.Windows.Rect rect;
						global::System.Windows.Point position;
						if (rect.Contains(position))
						{
							num = (short)1489895426;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E;
					}
					}
					IL_80:
					if (!base.IsMouseOver)
					{
						goto IL_FA;
					}
					num = (short)218300416;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_9E:
				this.g = false;
				return;
				IL_F8:
				this.g = true;
				return;
			}
			}
			IL_FA:
			num = (short)1525547009;
			if (num != 0)
			{
			}
			num = (short)964952064;
			short num4 = num;
			this.g = false;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00055440 File Offset: 0x00053640
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)191078589;
			short num2 = num;
			num = (short)1583915197;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)491126785;
				if (num != 0)
				{
				}
				num = (short)747438080;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				int num3;
				global::System.Windows.Point position;
				global::System.Windows.Rect rect;
				for (;;)
				{
					IL_7A:
					switch (num3)
					{
					case 0:
						this.h = position;
						num = (short)1534066690;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (rect.Contains(position))
						{
							num = (short)112394240;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.h = default(global::System.Windows.Point);
						num = (short)719978499;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_11F;
					case 3:
						goto IL_FE;
					}
					goto IL_90;
				}
				IL_FE:
				IL_11F:
				break;
				IL_90:
				rect = new global::System.Windows.Rect(base.RenderSize);
				position = e.GetPosition(this);
				num = (short)857014273;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7A;
			}
			}
			num = (short)500432896;
			short num4 = num;
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000555A0 File Offset: 0x000537A0
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)230006046;
			short num2 = num;
			num = (short)786603294;
			switch (num2 == num)
			{
			default:
			{
				num = (short)639500288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)191234049;
			if (num != 0)
			{
			}
			num = (short)1950744576;
			if (num != 0)
			{
			}
			this.h = default(global::System.Windows.Point);
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0005565C File Offset: 0x0005385C
		internal void e()
		{
			short num = (short)1814374689;
			short num2 = num;
			num = (short)986982689;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1957756928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1833435137;
			if (num != 0)
			{
			}
			num = (short)1121189888;
			if (num != 0)
			{
			}
			this.h = default(global::System.Windows.Point);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00055710 File Offset: 0x00053910
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::DevComponents.WpfEditors.SuperTabControl superTabControl;
				switch (num)
				{
				case 0:
					num2 = (short)1174601735;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_258;
				case 2:
					if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
					{
						num2 = (short)572325905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3E8;
				case 3:
				{
					num2 = (short)1758739741;
					short num3 = num2;
					num2 = (short)928660765;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1FD;
					default:
						num2 = (short)2014969857;
						if (num2 != 0)
						{
						}
						num2 = (short)593690624;
						if (num2 != 0)
						{
						}
						num2 = (short)1923743752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (this.h.X != 0.0)
					{
						goto IL_1FD;
					}
					goto IL_3E8;
				case 5:
					goto IL_27B;
				case 6:
					if (superTabControl.ItemsSource == null)
					{
						num2 = (short)1060110347;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_258;
				case 7:
					if (this.h.Y != 0.0)
					{
						num2 = (short)2035810320;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3E8;
				case 8:
				{
					global::System.Windows.Point position;
					if (global::System.Math.Abs(position.Y - this.h.Y) > 4.0)
					{
						num2 = (short)1470431250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3E8;
				}
				case 9:
					if (superTabControl != null)
					{
						num2 = (short)456917002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_258;
				case 10:
					num2 = (short)1314193420;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					num2 = (short)2127101952;
					short num4 = num2;
					superTabControl.a(this);
					num2 = (short)890306561;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					if (!superTabControl.IsTabDragging)
					{
						num2 = (short)1636171791;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_258;
				case 13:
				{
					global::System.Windows.Point position;
					if (global::System.Math.Abs(position.X - this.h.X) <= 5.0)
					{
						num2 = (short)1679163395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3A6;
				}
				case 14:
					if (superTabControl.ReorderTabsEnabled)
					{
						num2 = (short)2087190547;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_258;
				case 15:
					num2 = (short)423165966;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)431357965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
				{
					global::System.Windows.Point position = e.GetPosition(this);
					num2 = (short)39911428;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 18:
					goto IL_3A6;
				case 19:
					num2 = (short)553517062;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_60;
				IL_1FD:
				num2 = (short)910032896;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_258:
				this.h = default(global::System.Windows.Point);
				num2 = (short)2146304005;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3A6:
				superTabControl = this.SuperTabControlParent;
				num2 = (short)1616642057;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_27B:
			IL_3E8:
			base.OnMouseMove(e);
			return;
			IL_60:
			this.a(e);
			this.b();
			num2 = (short)719388674;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00055B0C File Offset: 0x00053D0C
		private global::DevComponents.WpfEditors.SuperTabControl SuperTabControlParent
		{
			get
			{
				short num = (short)1010983964;
				short num2 = num;
				num = (short)943678492;
				switch (num2 == num)
				{
				default:
				{
					num = (short)101515264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1656946688;
				if (num != 0)
				{
				}
				num = (short)1635909633;
				if (num != 0)
				{
				}
				return global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) as global::DevComponents.WpfEditors.SuperTabControl;
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00055BC0 File Offset: 0x00053DC0
		public bool Close()
		{
			short num;
			for (;;)
			{
				num = (short)915341313;
				if (num != 0)
				{
				}
				global::DevComponents.WpfEditors.TabClosingRoutedEventArgs tabClosingRoutedEventArgs = new global::DevComponents.WpfEditors.TabClosingRoutedEventArgs(global::DevComponents.WpfEditors.SuperTabItem.ClosingEvent);
				this.OnClosing(tabClosingRoutedEventArgs);
				if (!tabClosingRoutedEventArgs.Cancel)
				{
					goto IL_B8;
				}
				num = (short)1576768342;
				short num2 = num;
				num = (short)98014038;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_76;
				}
			}
			IL_76:
			num = (short)562298880;
			if (num != 0)
			{
			}
			num = (short)1669726208;
			short num3 = num;
			return false;
			IL_B8:
			base.Visibility = global::System.Windows.Visibility.Collapsed;
			this.OnClosed();
			return true;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00055C94 File Offset: 0x00053E94
		protected override void OnHeaderChanged(object oldHeader, object newHeader)
		{
			short num = (short)381741104;
			short num2 = num;
			num = (short)1950279728;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1386872832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)503513089;
			if (num != 0)
			{
			}
			num = (short)2037121024;
			if (num != 0)
			{
			}
			this.OnHeaderChanged();
			base.OnHeaderChanged(oldHeader, newHeader);
		}

		// Token: 0x040001EA RID: 490
		public static global::System.Windows.Input.RoutedCommand CloseTab;

		// Token: 0x040001EB RID: 491
		public static readonly global::System.Windows.DependencyProperty ImageProperty;

		// Token: 0x040001EC RID: 492
		public static readonly global::System.Windows.DependencyProperty ImageSourceProperty;

		// Token: 0x040001ED RID: 493
		private static readonly global::System.Windows.DependencyPropertyKey a;

		// Token: 0x040001EE RID: 494
		public static readonly global::System.Windows.DependencyProperty RenderImageProperty;

		// Token: 0x040001EF RID: 495
		public static readonly global::System.Windows.DependencyProperty ImagePositionProperty;

		// Token: 0x040001F0 RID: 496
		public static readonly global::System.Windows.DependencyProperty TabToolTipProperty;

		// Token: 0x040001F1 RID: 497
		public static readonly global::System.Windows.DependencyProperty TabContextMenuProperty;

		// Token: 0x040001F2 RID: 498
		public static readonly global::System.Windows.DependencyProperty CloseButtonVisibilityProperty;

		// Token: 0x040001F3 RID: 499
		private static readonly global::System.Windows.DependencyPropertyKey b;

		// Token: 0x040001F4 RID: 500
		public static readonly global::System.Windows.DependencyProperty EffectiveCloseButtonVisibilityProperty;

		// Token: 0x040001F5 RID: 501
		public static readonly global::System.Windows.DependencyProperty CloseButtonPositionProperty;

		// Token: 0x040001F6 RID: 502
		public static readonly global::System.Windows.DependencyProperty InnerBorderBrushProperty;

		// Token: 0x040001F7 RID: 503
		public static readonly global::System.Windows.DependencyProperty InnerBorderThicknessProperty;

		// Token: 0x040001F8 RID: 504
		private static readonly global::System.Windows.DependencyPropertyKey c;

		// Token: 0x040001F9 RID: 505
		public static readonly global::System.Windows.DependencyProperty TabStateProperty;

		// Token: 0x040001FA RID: 506
		private static readonly global::System.Windows.DependencyPropertyKey d;

		// Token: 0x040001FB RID: 507
		public static readonly global::System.Windows.DependencyProperty TabStripStyleProperty;

		// Token: 0x040001FC RID: 508
		public static readonly global::System.Windows.DependencyProperty TabColorProperty;

		// Token: 0x040001FD RID: 509
		public static readonly global::System.Windows.DependencyProperty ContentBackgroundProperty;

		// Token: 0x040001FE RID: 510
		public static readonly global::System.Windows.DependencyProperty ContentBorderBrushProperty;

		// Token: 0x040001FF RID: 511
		public static readonly global::System.Windows.DependencyProperty ContentInnerBorderBrushProperty;

		// Token: 0x04000202 RID: 514
		private static readonly global::System.Windows.DependencyPropertyKey e;

		// Token: 0x04000203 RID: 515
		public static readonly global::System.Windows.DependencyProperty TabLayoutTypeProperty;

		// Token: 0x04000204 RID: 516
		private int f;

		// Token: 0x04000205 RID: 517
		private bool g;

		// Token: 0x04000206 RID: 518
		private global::System.Windows.Point h;
	}
}
