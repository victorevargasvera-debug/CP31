using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000034 RID: 52
	public class SuperTabControl : global::System.Windows.Controls.TabControl
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0004B1D0 File Offset: 0x000493D0
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x0004B288 File Offset: 0x00049488
		public global::System.Windows.Media.Brush ContentBackground
		{
			get
			{
				short num = (short)491913217;
				if (num != 0)
				{
				}
				num = (short)1460339965;
				short num2 = num;
				num = (short)505677053;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521287168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)106102784;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.ContentBackgroundProperty);
			}
			set
			{
				short num = (short)365824974;
				short num2 = num;
				num = (short)1022299086;
				switch (num2 == num)
				{
				}
				num = (short)1275396096;
				short num3 = num;
				num = (short)1498742784;
				if (num != 0)
				{
				}
				num = (short)327024641;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.ContentBackgroundProperty, value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0004B340 File Offset: 0x00049540
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0004B3FC File Offset: 0x000495FC
		public global::System.Windows.Media.Brush ContentBorderBrush
		{
			get
			{
				short num = (short)1978023671;
				short num2 = num;
				num = (short)598556407;
				switch (num2 == num)
				{
				}
				num = (short)1668546560;
				short num3 = num;
				num = (short)1978269697;
				if (num != 0)
				{
				}
				num = (short)149946368;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.ContentBorderBrushProperty);
			}
			set
			{
				short num = (short)1742645849;
				short num2 = num;
				num = (short)1625008729;
				switch (num2 == num)
				{
				}
				num = (short)225705984;
				short num3 = num;
				num = (short)1656291328;
				if (num != 0)
				{
				}
				num = (short)1908932609;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.ContentBorderBrushProperty, value);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0004B4B4 File Offset: 0x000496B4
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x0004B570 File Offset: 0x00049770
		public global::System.Windows.Media.Brush ContentInnerBorderBrush
		{
			get
			{
				short num = (short)1342134776;
				short num2 = num;
				num = (short)1535269368;
				switch (num2 == num)
				{
				}
				num = (short)596115456;
				short num3 = num;
				num = (short)894435329;
				if (num != 0)
				{
				}
				num = (short)93978624;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.ContentInnerBorderBrushProperty);
			}
			set
			{
				short num = (short)162322944;
				short num2 = num;
				num = (short)320592384;
				switch (num2 == num)
				{
				}
				num = (short)1759772672;
				short num3 = num;
				num = (short)21823489;
				if (num != 0)
				{
				}
				num = (short)1895890944;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.ContentInnerBorderBrushProperty, value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0004B628 File Offset: 0x00049828
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x0004B6E0 File Offset: 0x000498E0
		public global::System.Windows.Thickness ContentBorderThickness
		{
			get
			{
				short num = (short)1660354560;
				short num2 = num;
				num = (short)1643463407;
				short num3 = num;
				num = (short)1792819951;
				switch (num3 == num)
				{
				}
				num = (short)402391040;
				if (num != 0)
				{
				}
				num = (short)626262017;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.ContentBorderThicknessProperty);
			}
			set
			{
				short num = (short)22151168;
				short num2 = num;
				num = (short)308675496;
				short num3 = num;
				num = (short)1202193320;
				switch (num3 == num)
				{
				}
				num = (short)770441217;
				if (num != 0)
				{
				}
				num = (short)1071644672;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.ContentBorderThicknessProperty, value);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0004B79C File Offset: 0x0004999C
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.SuperTabControl superTabControl;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_86;
				case 1:
				{
					superTabControl.OnCloseButtonVisibilityChanged((global::DevComponents.WpfEditors.eTabCloseButtonVisibility)A_1.OldValue, (global::DevComponents.WpfEditors.eTabCloseButtonVisibility)A_1.NewValue);
					num2 = (short)1970329864;
					short num3 = num2;
					num2 = (short)1930287368;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
						num2 = (short)1762459648;
						if (num2 != 0)
						{
						}
						num2 = (short)2044461058;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_1C;
				IL_86:
				if (superTabControl == null)
				{
					break;
				}
				num2 = (short)1465122817;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)907018240;
			short num4 = num2;
			num2 = (short)1851588609;
			if (num2 != 0)
			{
			}
			superTabControl = (A_0 as global::DevComponents.WpfEditors.SuperTabControl);
			num2 = (short)684851200;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0004B8D0 File Offset: 0x00049AD0
		protected virtual void OnCloseButtonVisibilityChanged(global::DevComponents.WpfEditors.eTabCloseButtonVisibility oldValue, global::DevComponents.WpfEditors.eTabCloseButtonVisibility newValue)
		{
			short num = (short)718143488;
			short num2 = num;
			num = (short)1328322536;
			short num3 = num;
			num = (short)1597347816;
			switch (num3 == num)
			{
			}
			num = (short)2045509633;
			if (num != 0)
			{
			}
			num = (short)8650752;
			if (num != 0)
			{
			}
			this.f();
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0004B980 File Offset: 0x00049B80
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0004BA38 File Offset: 0x00049C38
		public global::DevComponents.WpfEditors.eTabCloseButtonVisibility CloseButtonVisibility
		{
			get
			{
				short num = (short)2109276160;
				short num2 = num;
				num = (short)1286702794;
				short num3 = num;
				num = (short)2079360714;
				switch (num3 == num)
				{
				}
				num = (short)2072641536;
				if (num != 0)
				{
				}
				num = (short)1246887937;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.eTabCloseButtonVisibility)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.CloseButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1553465344;
				short num2 = num;
				num = (short)581632001;
				if (num != 0)
				{
				}
				num = (short)1044246790;
				short num3 = num;
				num = (short)1167847686;
				switch (num3 == num)
				{
				}
				num = (short)335478784;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.CloseButtonVisibilityProperty, value);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0004BAF4 File Offset: 0x00049CF4
		private void f()
		{
			short num = (short)1510080512;
			short num2 = num;
			num = (short)1297285121;
			if (num != 0)
			{
			}
			int num3;
			int num5;
			global::System.Windows.Controls.ItemCollection items;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_5A:
					switch (num3)
					{
					case 0:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						superTabItem.CoerceValue(global::DevComponents.WpfEditors.SuperTabItem.EffectiveCloseButtonVisibilityProperty);
						num = (short)778240004;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_17D;
					case 2:
						goto IL_17D;
					case 3:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						if (superTabItem != null)
						{
							num = (short)1758199808;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E;
					}
					case 4:
					{
						num = (short)322759382;
						short num4 = num;
						num = (short)1422125782;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_85;
						default:
							num = (short)700186624;
							if (num != 0)
							{
							}
							goto IL_9E;
						}
						break;
					}
					case 5:
					{
						if (num5 >= items.Count)
						{
							num = (short)1126891526;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.SuperTabItem superTabItem = base.ItemContainerGenerator.ContainerFromIndex(num5) as global::DevComponents.WpfEditors.SuperTabItem;
						num = (short)516423683;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					}
					goto IL_7C;
					IL_9E:
					num5++;
					num = (short)48168961;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_17D:
					num = (short)1257177093;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			IL_7C:
			items = base.Items;
			num5 = 0;
			IL_85:
			num = (short)8060930;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5A;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0004BCBC File Offset: 0x00049EBC
		// (set) Token: 0x060003BF RID: 959 RVA: 0x0004BD74 File Offset: 0x00049F74
		public bool ReorderTabsEnabled
		{
			get
			{
				short num = (short)586874880;
				short num2 = num;
				num = (short)1674510337;
				if (num != 0)
				{
				}
				num = (short)1979293274;
				short num3 = num;
				num = (short)191274586;
				switch (num3 == num)
				{
				}
				num = (short)626982912;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.ReorderTabsEnabledProperty);
			}
			set
			{
				short num = (short)2111635456;
				short num2 = num;
				num = (short)1936591962;
				short num3 = num;
				num = (short)1583811674;
				switch (num3 == num)
				{
				}
				num = (short)680853505;
				if (num != 0)
				{
				}
				num = (short)1301020672;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.ReorderTabsEnabledProperty, value);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0004BE30 File Offset: 0x0004A030
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0004BEEC File Offset: 0x0004A0EC
		public global::DevComponents.WpfEditors.eSuperTabControlLayoutType TabLayoutType
		{
			get
			{
				short num = (short)962265088;
				short num2 = num;
				num = (short)1325844698;
				short num3 = num;
				num = (short)145737946;
				switch (num3 == num)
				{
				}
				num = (short)1115029505;
				if (num != 0)
				{
				}
				num = (short)1765933056;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.eSuperTabControlLayoutType)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.TabLayoutTypeProperty);
			}
			set
			{
				short num = (short)1591672832;
				short num2 = num;
				num = (short)2003655580;
				short num3 = num;
				num = (short)402742172;
				switch (num3 == num)
				{
				}
				num = (short)883556353;
				if (num != 0)
				{
				}
				num = (short)362479616;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.TabLayoutTypeProperty, value);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0004BFA4 File Offset: 0x0004A1A4
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.SuperTabControl superTabControl;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_63;
				case 1:
				{
					superTabControl.a((global::DevComponents.WpfEditors.eSuperTabControlLayoutType)A_1.OldValue, (global::DevComponents.WpfEditors.eSuperTabControlLayoutType)A_1.NewValue);
					num2 = (short)593928471;
					short num3 = num2;
					num2 = (short)448831767;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_63;
					default:
						num2 = (short)1161625600;
						if (num2 != 0)
						{
						}
						num2 = (short)1945501697;
						if (num2 != 0)
						{
						}
						num2 = (short)631504898;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_1C;
				IL_63:
				if (superTabControl == null)
				{
					break;
				}
				num2 = (short)1606418433;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)66387968;
			short num4 = num2;
			superTabControl = (A_0 as global::DevComponents.WpfEditors.SuperTabControl);
			num2 = (short)531103744;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0004C0D8 File Offset: 0x0004A2D8
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0004C194 File Offset: 0x0004A394
		public global::System.Windows.Visibility ControlBoxTabMenuVisibility
		{
			get
			{
				short num = (short)978518016;
				short num2 = num;
				num = (short)419809121;
				short num3 = num;
				num = (short)5687137;
				switch (num3 == num)
				{
				}
				num = (short)1750859777;
				if (num != 0)
				{
				}
				num = (short)1239089152;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.ControlBoxTabMenuVisibilityProperty);
			}
			set
			{
				short num = (short)1342570496;
				short num2 = num;
				num = (short)1961451024;
				short num3 = num;
				num = (short)2057657872;
				switch (num3 == num)
				{
				}
				num = (short)1429340161;
				if (num != 0)
				{
				}
				num = (short)104988672;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.ControlBoxTabMenuVisibilityProperty, value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x0004C24C File Offset: 0x0004A44C
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0004C308 File Offset: 0x0004A508
		public global::System.Windows.Visibility ControlBoxCloseTabVisibility
		{
			get
			{
				short num = (short)534118400;
				short num2 = num;
				num = (short)1233107685;
				short num3 = num;
				num = (short)430488293;
				switch (num3 == num)
				{
				}
				num = (short)103612417;
				if (num != 0)
				{
				}
				num = (short)725942272;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.ControlBoxCloseTabVisibilityProperty);
			}
			set
			{
				short num = (short)814546944;
				short num2 = num;
				num = (short)417333249;
				if (num != 0)
				{
				}
				num = (short)1651486612;
				short num3 = num;
				num = (short)1892986772;
				switch (num3 == num)
				{
				}
				num = (short)1644429312;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.ControlBoxCloseTabVisibilityProperty, value);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0004C3C4 File Offset: 0x0004A5C4
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0004C478 File Offset: 0x0004A678
		public object TabHeaderLeft
		{
			get
			{
				short num = (short)103022592;
				short num2 = num;
				num = (short)628662827;
				short num3 = num;
				num = (short)943563307;
				switch (num3 == num)
				{
				}
				num = (short)2084634625;
				if (num != 0)
				{
				}
				num = (short)1055981568;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.TabHeaderLeftProperty);
			}
			set
			{
				short num = (short)323551232;
				short num2 = num;
				num = (short)1282426359;
				short num3 = num;
				num = (short)1747338743;
				switch (num3 == num)
				{
				}
				num = (short)256704512;
				if (num != 0)
				{
				}
				num = (short)1358299137;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.TabHeaderLeftProperty, value);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0004C52C File Offset: 0x0004A72C
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0004C5E4 File Offset: 0x0004A7E4
		public object TabHeaderRight
		{
			get
			{
				short num = (short)387579904;
				short num2 = num;
				num = (short)1198653441;
				if (num != 0)
				{
				}
				num = (short)1654412667;
				short num3 = num;
				num = (short)1523996027;
				switch (num3 == num)
				{
				}
				num = (short)2949120;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.TabHeaderRightProperty);
			}
			set
			{
				short num = (short)1098448896;
				short num2 = num;
				num = (short)1098219369;
				short num3 = num;
				num = (short)1696825193;
				switch (num3 == num)
				{
				}
				num = (short)770899969;
				if (num != 0)
				{
				}
				num = (short)325976064;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.TabHeaderRightProperty, value);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0004C698 File Offset: 0x0004A898
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.SuperTabControl superTabControl;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_64;
				case 1:
				{
					superTabControl.OnTabStyleChanged((global::DevComponents.WpfEditors.eTabStyle)A_1.OldValue, (global::DevComponents.WpfEditors.eTabStyle)A_1.NewValue);
					num2 = (short)144499451;
					short num3 = num2;
					num2 = (short)334357243;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						num2 = (short)676855808;
						if (num2 != 0)
						{
						}
						num2 = (short)850853890;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_103;
				}
				goto IL_1C;
				IL_64:
				if (superTabControl == null)
				{
					break;
				}
				num2 = (short)2104164353;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_103:
			num2 = (short)120258561;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)640286720;
			short num4 = num2;
			superTabControl = (A_0 as global::DevComponents.WpfEditors.SuperTabControl);
			num2 = (short)1367343104;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0004C7D4 File Offset: 0x0004A9D4
		private void a(global::DevComponents.WpfEditors.eSuperTabControlLayoutType A_0, global::DevComponents.WpfEditors.eSuperTabControlLayoutType A_1)
		{
			short num = (short)395116544;
			short num2 = num;
			num = (short)1359158662;
			short num3 = num;
			num = (short)1870142854;
			switch (num3 == num)
			{
			}
			num = (short)1989410817;
			if (num != 0)
			{
			}
			num = (short)1875247104;
			if (num != 0)
			{
			}
			this.e();
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0004C884 File Offset: 0x0004AA84
		private void e()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			int num4;
			global::System.Windows.Controls.ItemCollection items;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1507393537;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					superTabItem.CoerceValue(global::DevComponents.WpfEditors.SuperTabItem.TabLayoutTypeProperty);
					num2 = (short)652673024;
					short num3 = num2;
					num2 = (short)1829699585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_50;
				case 2:
					return;
				case 3:
					goto IL_12F;
				case 4:
				{
					if (num4 >= items.Count)
					{
						num2 = (short)1867055106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::DevComponents.WpfEditors.SuperTabItem superTabItem = base.ItemContainerGenerator.ContainerFromIndex(num4) as global::DevComponents.WpfEditors.SuperTabItem;
					num2 = (short)672464901;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					IL_E5:
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					if (superTabItem != null)
					{
						num2 = (short)331546624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_50;
				}
				case 6:
					goto IL_12F;
				}
				goto IL_2C;
				IL_50:
				num4++;
				num2 = (short)1952776198;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_12F:
				num2 = (short)1039750477;
				short num5 = num2;
				num2 = (short)2079937869;
				switch ((num5 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E5;
				default:
					num2 = (short)860684288;
					if (num2 != 0)
					{
					}
					num2 = (short)1890779140;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return;
			IL_2C:
			items = base.Items;
			num4 = 0;
			num2 = (short)1381498883;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0004CA4C File Offset: 0x0004AC4C
		protected virtual void OnTabStyleChanged(global::DevComponents.WpfEditors.eTabStyle oldValue, global::DevComponents.WpfEditors.eTabStyle newValue)
		{
			short num = (short)2107491779;
			short num2 = num;
			num = (short)1838335427;
			switch (num2 == num)
			{
			}
			num = (short)32309249;
			if (num != 0)
			{
			}
			num = (short)2093416448;
			if (num != 0)
			{
			}
			num = (short)2002452480;
			short num3 = num;
			this.c();
			this.d();
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0004CB04 File Offset: 0x0004AD04
		private void d()
		{
			int a_ = 16;
			short num;
			int num4;
			global::DevComponents.WpfEditors.eTabStyle tabStyle;
			global::System.Windows.ComponentResourceKey name;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					num = (short)202585518;
					short num2 = num;
					num = (short)264058286;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D3;
					default:
					{
						num = (short)28049408;
						if (num != 0)
						{
						}
						num = (short)599588864;
						short num3 = num;
						switch (num4)
						{
						case 0:
							goto IL_13F;
						case 1:
							goto IL_13D;
						case 2:
							if (tabStyle != global::DevComponents.WpfEditors.eTabStyle.Office2007)
							{
								num = (short)1525022725;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13F;
						case 3:
							if (tabStyle == global::DevComponents.WpfEditors.eTabStyle.OneNote2007)
							{
								num = (short)1665531904;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							name = new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabControl), global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("诜賞폠폢헤\udfe6ꯨ黪駬鯮黰鷲", a_));
							num = (short)353042433;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_175;
						case 5:
							num = (short)1673461763;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A3;
						IL_13F:
						name = new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.SuperTabControl), global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鋜뇞蓠귢諤鏦賨\ud9ea\uddec\udfee웰뇲胴菶跸铺鏼", a_));
						num = (short)781778948;
						num4 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_13D:
				IL_175:
				base.SetResourceReference(global::DevComponents.WpfEditors.SuperTabControl.ControlButtonStyleProperty, name);
				return;
			}
			IL_A3:
			num = (short)812580865;
			if (num != 0)
			{
			}
			tabStyle = this.TabStyle;
			name = null;
			IL_D3:
			num = (short)623837186;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0004CCD0 File Offset: 0x0004AED0
		private void c()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			int num4;
			global::System.Windows.Controls.ItemCollection items;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					superTabItem.CoerceValue(global::DevComponents.WpfEditors.SuperTabItem.TabStripStyleProperty);
					num2 = (short)161349632;
					short num3 = num2;
					num2 = (short)1348337665;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_4F;
				case 2:
					return;
				case 3:
					goto IL_10A;
				case 4:
				{
					if (num4 >= items.Count)
					{
						num2 = (short)1435435009;
						if (num2 != 0)
						{
						}
						num2 = (short)1947795458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::DevComponents.WpfEditors.SuperTabItem superTabItem = base.ItemContainerGenerator.ContainerFromIndex(num4) as global::DevComponents.WpfEditors.SuperTabItem;
					num2 = (short)906428421;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					IL_E6:
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					if (superTabItem != null)
					{
						num2 = (short)875298816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4F;
				}
				case 6:
					goto IL_10A;
				}
				goto IL_2C;
				IL_4F:
				num4++;
				num2 = (short)1172307974;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10A:
				num2 = (short)1909077952;
				short num5 = num2;
				num2 = (short)596522944;
				switch ((num5 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E6;
				default:
					num2 = (short)854589440;
					if (num2 != 0)
					{
					}
					num2 = (short)1781661700;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return;
			IL_2C:
			items = base.Items;
			num4 = 0;
			num2 = (short)697761795;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0004CE9C File Offset: 0x0004B09C
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x0004CF58 File Offset: 0x0004B158
		public global::DevComponents.WpfEditors.eTabStyle TabStyle
		{
			get
			{
				short num = (short)281559174;
				short num2 = num;
				num = (short)1027817606;
				switch (num2 == num)
				{
				}
				num = (short)1140457472;
				if (num != 0)
				{
				}
				num = (short)649134081;
				if (num != 0)
				{
				}
				num = (short)2005860352;
				short num3 = num;
				return (global::DevComponents.WpfEditors.eTabStyle)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.TabStyleProperty);
			}
			set
			{
				short num = (short)809607450;
				short num2 = num;
				num = (short)1721868570;
				switch (num2 == num)
				{
				}
				num = (short)2113929217;
				if (num != 0)
				{
				}
				num = (short)1220345856;
				if (num != 0)
				{
				}
				num = (short)1493893120;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.TabStyleProperty, value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0004D014 File Offset: 0x0004B214
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x0004D0CC File Offset: 0x0004B2CC
		public global::System.Windows.Style ControlButtonStyle
		{
			get
			{
				short num = (short)1857694052;
				short num2 = num;
				num = (short)107686244;
				switch (num2 == num)
				{
				}
				num = (short)1267793921;
				if (num != 0)
				{
				}
				num = (short)1461977088;
				if (num != 0)
				{
				}
				num = (short)304218112;
				short num3 = num;
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.SuperTabControl.ControlButtonStyleProperty);
			}
			set
			{
				short num = (short)611429213;
				short num2 = num;
				num = (short)1952754525;
				switch (num2 == num)
				{
				}
				num = (short)668401665;
				if (num != 0)
				{
				}
				num = (short)13828096;
				if (num != 0)
				{
				}
				num = (short)695271424;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SuperTabControl.ControlButtonStyleProperty, value);
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0004D180 File Offset: 0x0004B380
		static SuperTabControl()
		{
			int a_ = 17;
			short num = (short)287421450;
			short num2 = num;
			num = (short)1661645834;
			switch (num2 == num)
			{
			}
			num = (short)526778369;
			if (num != 0)
			{
			}
			num = (short)1937506304;
			if (num != 0)
			{
			}
			num = (short)429260800;
			short num3 = num;
			global::DevComponents.WpfEditors.SuperTabControl.ContentBackgroundProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝迟賡郣菥蛧黩껫迭鏯駱鏳蓵韷迹鋻髽", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabControl.ContentBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝迟賡郣菥蛧黩껫臭苯雱釳蓵뫷裹觻跽棿", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabControl.ContentInnerBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝迟賡郣菥蛧黩ꗫ胭黯韱蛳듵韷裹飻鯽狿䀁瘃猅笇戉", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabControl.ContentBorderThicknessProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝迟賡郣菥蛧黩껫臭苯雱釳蓵곷鋹闻鷽毿氁愃甅笇", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(default(global::System.Windows.Thickness)));
			global::DevComponents.WpfEditors.SuperTabControl.CloseButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝賟跡韣菥ꫧ鿩飫髭鿯鳱ꋳ鿵请鏹黻韽泿欁瀃缅", a_), typeof(global::DevComponents.WpfEditors.eTabCloseButtonVisibility), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eTabCloseButtonVisibility.Hidden, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabControl.c)));
			global::DevComponents.WpfEditors.SuperTabControl.ReorderTabsEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("賝藟跡難若跧飩룫迭鋯臱뇳飵駷飹郻鯽擿", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.SuperTabControl.TabLayoutTypeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝臟胡꣣蟥釧藩駫髭ꓯ诱蓳鏵", a_), typeof(global::DevComponents.WpfEditors.eSuperTabControlLayoutType), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eSuperTabControlLayoutType.SingleLine, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabControl.b)));
			global::DevComponents.WpfEditors.SuperTabControl.ControlBoxTabMenuVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝迟賡郣铥蟧蛩껫臭裯꛱闳铵뗷鿹鋻诽囿欁眃漅樇按怋服搏欑", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::DevComponents.WpfEditors.SuperTabControl.ControlBoxCloseTabVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝迟賡郣铥蟧蛩껫臭裯뇱飳駵请鿹ꣻ鿽拿吁洃甅愇栉攋戍礏昑洓", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::DevComponents.WpfEditors.SuperTabControl.TabHeaderLeftProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝臟胡곣菥觧軩觫鳭볯韱鋳苵", a_), typeof(object), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabControl.TabHeaderRightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝臟胡곣菥觧軩觫鳭ꋯ鯱鏳黵賷", a_), typeof(object), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfEditors.SuperTabControl.TabStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝臟胡럣鋥釧蛩觫", a_), typeof(global::DevComponents.WpfEditors.eTabStyle), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eTabStyle.Office2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabControl.a)));
			global::DevComponents.WpfEditors.SuperTabControl.ControlButtonStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝迟賡郣铥蟧蛩껫鯭蓯蛱鯳飵꯷軹藻鋽旿", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.UIPropertyMetadata(null));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.SuperTabControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.SuperTabControl)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.SuperTabControl), global::DevComponents.WpfEditors.SuperTabItem.ClosedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.SuperTabControl.a));
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0004D54C File Offset: 0x0004B74C
		public SuperTabControl()
		{
			this.d();
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0004D568 File Offset: 0x0004B768
		public override void OnApplyTemplate()
		{
			int a_ = 6;
			short num = (short)955383810;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12B;
				case 1:
					goto IL_126;
				case 2:
				{
					num = (short)1012389461;
					short num3 = num;
					num = (short)1797379669;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)440074240;
						if (num != 0)
						{
						}
						num = (short)32636928;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_C0;
						}
						continue;
					}
					}
					break;
				}
				case 3:
					this.a.PreviewMouseLeftButtonDown += this.a;
					this.a.PreviewMouseRightButtonUp += this.b;
					num = (short)69730305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.a != null)
					{
						num = (short)520880131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F7;
				case 5:
					this.a.PreviewMouseLeftButtonDown -= this.a;
					this.a.PreviewMouseRightButtonUp -= this.b;
					num = (short)1909587968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C0:
				if (this.a != null)
				{
					num = (short)562233349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_12B:
				this.a = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("釒ꃔꏖ귘듚돜诞胠臢꣤苦蟨黪", a_)) as global::System.Windows.Controls.Button);
				num = (short)1676410881;
				if (num != 0)
				{
				}
				num = (short)1404239876;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_126:
			IL_1F7:
			base.OnApplyTemplate();
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0004D774 File Offset: 0x0004B974
		private void b(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)832499958;
			short num2 = num;
			num = (short)1189671158;
			switch (num2 == num)
			{
			}
			num = (short)595263489;
			if (num != 0)
			{
			}
			num = (short)1872101376;
			if (num != 0)
			{
			}
			num = (short)1572536320;
			short num3 = num;
			A_1.Handled = true;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0004D824 File Offset: 0x0004BA24
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)2142306304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::System.Windows.Controls.ContextMenu contextMenu;
				for (;;)
				{
					IL_28:
					int num3;
					switch (num2)
					{
					case 0:
						if (contextMenu == null)
						{
							num = (short)345636873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)693698567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (num3 >= base.Items.Count)
						{
							num = (short)1834483723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.SuperTabItem superTabItem = base.ItemContainerGenerator.ContainerFromIndex(num3) as global::DevComponents.WpfEditors.SuperTabItem;
						num = (short)1952645122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						if (superTabItem != null)
						{
							num = (short)501678088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					}
					case 3:
						goto IL_1DB;
					case 4:
						try
						{
							num = (short)1407451137;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_398;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_311;
									}
									continue;
								case 2:
									num = (short)1786576896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)46923778;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									((global::System.Windows.Controls.MenuItem)enumerator.Current).Click -= this.b;
									num = (short)1246953476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_346:
								num = (short)307953667;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_311:
								goto IL_346;
							}
							IL_398:
							goto IL_107;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_3BA;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_3A7:
								switch (num2)
								{
								case 0:
									goto IL_45D;
								case 1:
									disposable.Dispose();
									goto IL_445;
								case 2:
								{
									num = (short)783070810;
									short num4 = num;
									num = (short)497727066;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_445;
									default:
										num = (short)479330304;
										if (num != 0)
										{
										}
										if (disposable != null)
										{
											num = (short)266272769;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_45F;
									}
									break;
								}
								}
								goto IL_3BA;
								IL_445:
								num = (short)987758592;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_45D:
							IL_45F:
							goto EndFinally_9;
							IL_3BA:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1390215170;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3A7;
							EndFinally_9:;
						}
						return;
						IL_107:
						contextMenu.Items.Clear();
						num3 = 0;
						num = (short)1581645836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return;
					case 6:
					{
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)contextMenu.Items).GetEnumerator();
						num = (short)1714880516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (contextMenu != null)
						{
							num = (short)1453850630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						global::System.Windows.Controls.MenuItem menuItem = new global::System.Windows.Controls.MenuItem();
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						menuItem.Header = superTabItem.Header;
						menuItem.IsChecked = superTabItem.IsSelected;
						menuItem.Click += this.b;
						contextMenu.Items.Add(menuItem);
						num = (short)636616707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return;
					case 10:
						goto IL_195;
					case 11:
						A_1.Handled = true;
						contextMenu.PlacementTarget = this.a;
						contextMenu.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Bottom;
						contextMenu.IsOpen = true;
						num = (short)1660026885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						num = (short)488636416;
						short num5 = num;
						goto IL_195;
					}
					}
					goto IL_63;
					IL_195:
					num = (short)666632193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DB:
					num3++;
					num = (short)2078146561;
					if (num != 0)
					{
					}
					num = (short)900202506;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_63:
				contextMenu = this.a.ContextMenu;
				num = (short)389611520;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0004DCA4 File Offset: 0x0004BEA4
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num3;
			global::System.Windows.Controls.ContextMenu contextMenu;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					int num2;
					base.SelectedIndex = num2;
					num3 = (short)188022787;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
				{
					if (contextMenu == null)
					{
						num3 = (short)91815940;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					int num2 = contextMenu.Items.IndexOf(A_0);
					num3 = (short)1318780930;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
				{
					int num2;
					if (num2 >= 0)
					{
						num3 = (short)1770192896;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return;
				}
				case 3:
					goto IL_7C;
				case 4:
				{
					num3 = (short)1228638056;
					short num4 = num3;
					num3 = (short)1223067496;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_124;
					}
					goto Block_3;
				}
				}
				goto IL_24;
			}
			IL_7C:
			return;
			Block_3:
			num3 = (short)1833828352;
			short num5 = num3;
			IL_124:
			num3 = (short)432603137;
			if (num3 != 0)
			{
			}
			num3 = (short)1385889792;
			if (num3 != 0)
			{
			}
			return;
			IL_24:
			contextMenu = this.a.ContextMenu;
			num3 = (short)156631041;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0004DE14 File Offset: 0x0004C014
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			short num = (short)1079462446;
			short num2 = num;
			num = (short)1783974446;
			switch (num2 == num)
			{
			}
			num = (short)2088960001;
			if (num != 0)
			{
			}
			num = (short)912195584;
			if (num != 0)
			{
			}
			num = (short)1958477824;
			short num3 = num;
			base.OnSelectionChanged(e);
			this.b();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0004DECC File Offset: 0x0004C0CC
		private void b()
		{
			int a_ = 1;
			short num = (short)1335230464;
			short num2 = num;
			num = (short)412876802;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_BF;
						}
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						for (;;)
						{
							IL_91:
							switch (num3)
							{
							case 0:
								goto IL_138;
							case 1:
								goto IL_13D;
							case 2:
								if (base.SelectedIndex >= 0)
								{
									num = (short)848166918;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_13D;
							case 3:
							{
								num = (short)2101448968;
								short num4 = num;
								num = (short)1056739592;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_138;
								default:
									num = (short)620625920;
									if (num != 0)
									{
									}
									if (superTabItem != null)
									{
										num = (short)1213530120;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2D9;
								}
								break;
							}
							case 4:
								goto IL_2D4;
							case 5:
								goto IL_2F0;
							case 6:
								num = (short)1917976585;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_2D9;
							case 8:
							{
								global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跍뿏병ꃓ돕뛗껙黛뿝菟觡菣铥蟧鿩苫諭", a_));
								binding.Source = superTabItem;
								base.SetBinding(global::DevComponents.WpfEditors.SuperTabControl.ContentBackgroundProperty, binding);
								binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跍뿏병ꃓ돕뛗껙黛뇝鋟蛡臣铥ꫧ飩駫鷭飯", a_));
								binding.Source = superTabItem;
								base.SetBinding(global::DevComponents.WpfEditors.SuperTabControl.ContentBorderBrushProperty, binding);
								binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跍뿏병ꃓ돕뛗껙闛냝軟蟡難ꓥ蟧飩裫语苯냱蛳菵请鋹", a_));
								binding.Source = superTabItem;
								base.SetBinding(global::DevComponents.WpfEditors.SuperTabControl.ContentInnerBorderBrushProperty, binding);
								num = (short)1331101703;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.NotStarted)
								{
									num = (short)1617756160;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								superTabItem = (base.ItemContainerGenerator.ContainerFromIndex(base.SelectedIndex) as global::DevComponents.WpfEditors.SuperTabItem);
								num = (short)1203306497;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BF;
							IL_138:
							base.ItemContainerGenerator.StatusChanged += this.b;
							num = (short)626262020;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_13D:
							global::System.Windows.Data.BindingOperations.ClearBinding(this, global::DevComponents.WpfEditors.SuperTabControl.ContentBackgroundProperty);
							global::System.Windows.Data.BindingOperations.ClearBinding(this, global::DevComponents.WpfEditors.SuperTabControl.ContentBorderBrushProperty);
							global::System.Windows.Data.BindingOperations.ClearBinding(this, global::DevComponents.WpfEditors.SuperTabControl.ContentInnerBorderBrushProperty);
							num = (short)1391263747;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2D9:
							num = (short)439943173;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2D4:
						IL_2F0:
						goto IL_318;
						IL_BF:
						this.b = true;
						superTabItem = null;
						num = (short)527958018;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_91;
					}
					finally
					{
						this.b = false;
					}
					goto IL_2FA;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				}
				IL_63:
				if (this.b)
				{
					num = (short)814743553;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_2FA:
				num = (short)30736384;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_318:
			num = (short)3735553;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0004E234 File Offset: 0x0004C434
		private void b(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1244332034;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					base.ItemContainerGenerator.StatusChanged -= this.b;
					this.b();
					goto IL_111;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				num = (short)2060144927;
				short num3 = num;
				num = (short)1676103967;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_111:
					num = (short)893583360;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1829961729;
					if (num != 0)
					{
					}
					num = (short)1536360448;
					short num4 = num;
					num = (short)1373372416;
					if (num != 0)
					{
					}
					if (base.ItemContainerGenerator.Status != global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
					{
						return;
					}
					num = (short)76021761;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0004E370 File Offset: 0x0004C570
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			short num = (short)1918159587;
			short num2 = num;
			num = (short)1367722723;
			switch (num2 == num)
			{
			}
			num = (short)950337537;
			if (num != 0)
			{
			}
			num = (short)1436418048;
			if (num != 0)
			{
			}
			num = (short)1757282304;
			short num3 = num;
			return item is global::DevComponents.WpfEditors.SuperTabItem;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0004E424 File Offset: 0x0004C624
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			short num = (short)1361780217;
			short num2 = num;
			num = (short)763305465;
			switch (num2 == num)
			{
			}
			num = (short)154992641;
			if (num != 0)
			{
			}
			num = (short)2120024064;
			if (num != 0)
			{
			}
			num = (short)1692401664;
			short num3 = num;
			return new global::DevComponents.WpfEditors.SuperTabItem();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0004E4D0 File Offset: 0x0004C6D0
		protected override void OnInitialized(global::System.EventArgs e)
		{
			short num = (short)292104171;
			short num2 = num;
			num = (short)900147179;
			switch (num2 == num)
			{
			}
			num = (short)861929473;
			if (num != 0)
			{
			}
			num = (short)1036386304;
			if (num != 0)
			{
			}
			num = (short)729415680;
			short num3 = num;
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfEditors.SuperTabItem.CloseTab, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.a), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.a)));
			base.ItemContainerGenerator.StatusChanged += this.a;
			base.OnInitialized(e);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0004E5C8 File Offset: 0x0004C7C8
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)2073755649;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)235979546;
						short num3 = num;
						num = (short)505987866;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)796852224;
							if (num != 0)
							{
							}
							this.c();
							this.f();
							this.e();
							num = (short)1780744195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						num = (short)1804075008;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					case 2:
						if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
						{
							num = (short)122814464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_169;
					case 3:
						goto IL_126;
					case 4:
						num = (short)1836580866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					num = (short)403570689;
					if (num != 0)
					{
					}
					if (base.Items.Count <= 0)
					{
						goto IL_169;
					}
					num = (short)435027972;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_126:
			IL_169:
			base.OnItemsChanged(e);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0004E748 File Offset: 0x0004C948
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1169620994;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2116943873;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_CB;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				IL_59:
				if (base.ItemContainerGenerator.Status != global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
				{
					break;
				}
				num = (short)543871582;
				short num3 = num;
				num = (short)1250415198;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1135738880;
					if (num != 0)
					{
					}
					num = (short)1517355008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CB:
				num = (short)671416320;
				short num4 = num;
				this.c();
				this.f();
				this.e();
				num = (short)1674706945;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0004E878 File Offset: 0x0004CA78
		private void a(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)55836679;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1803485184;
					short num3 = num;
					num = (short)716769785;
					short num4 = num;
					num = (short)287902201;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C6;
					default:
						num = (short)1754529792;
						if (num != 0)
						{
						}
						if (A_1.Source == this)
						{
							num = (short)117702660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DF;
					}
					break;
				}
				case 1:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					superTabItem.Close();
					goto IL_1C6;
				}
				case 2:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					if (superTabItem != null)
					{
						num = (short)1286537217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DF;
				}
				case 3:
					goto IL_1BD;
				case 4:
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem = base.ItemContainerGenerator.ContainerFromIndex(base.SelectedIndex) as global::DevComponents.WpfEditors.SuperTabItem;
					num = (short)754319362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)1488781313;
					if (num != 0)
					{
					}
					(A_1.Source as global::DevComponents.WpfEditors.SuperTabItem).Close();
					num = (short)150863875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1DD;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				IL_45:
				if (A_1.Source is global::DevComponents.WpfEditors.SuperTabItem)
				{
					num = (short)2069495813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1996423168;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C6:
				num = (short)1909260294;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1BD:
			IL_1DD:
			IL_1DF:
			A_1.Handled = true;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0004EA6C File Offset: 0x0004CC6C
		private void a(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1641938950;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BA;
				case 1:
					if (A_1.Source == this)
					{
						num = (short)2084175875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)676986881;
					if (num != 0)
					{
					}
					A_1.CanExecute = false;
					goto IL_193;
				case 2:
				{
					num = (short)1230808418;
					short num3 = num;
					num = (short)868853090;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_193;
					default:
						goto IL_14F;
					}
					break;
				}
				case 3:
					A_1.CanExecute = (base.SelectedIndex >= 0);
					num = (short)992935936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					A_1.CanExecute = true;
					num = (short)214695938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1AA;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				num = (short)232390656;
				short num4 = num;
				if (A_1.Source is global::DevComponents.WpfEditors.SuperTabItem)
				{
					num = (short)1129447428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1911554049;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_193:
				num = (short)784728069;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BA:
			goto IL_1AC;
			IL_14F:
			num = (short)1500250112;
			if (num != 0)
			{
			}
			IL_1AA:
			IL_1AC:
			A_1.Handled = true;
			A_1.ContinueRouting = false;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0004EC34 File Offset: 0x0004CE34
		private global::System.Windows.Controls.TabItem a(int A_0, int A_1)
		{
			short num = (short)1489043472;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Controls.TabItem tabItem;
			for (;;)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 0:
					return tabItem;
				case 1:
					IL_2BF:
					goto IL_F4;
				case 2:
					if (num3 >= base.Items.Count)
					{
						num = (short)2072707075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4 += A_1;
					num = (short)31719428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_277;
				case 4:
					if (num4 >= base.Items.Count)
					{
						num = (short)1741684743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1002176520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (tabItem.Visibility == global::System.Windows.Visibility.Visible)
					{
						num = (short)1989410816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_186;
				case 6:
					goto IL_238;
				case 7:
					num4 = 0;
					num = (short)2071724033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (num4 < 0)
					{
						num = (short)1263140877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4;
				case 9:
					num = (short)1743519749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_F4;
				case 11:
					if (tabItem.IsEnabled)
					{
						num = (short)384892937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_186;
				case 12:
					goto IL_238;
				case 13:
					num4 = base.Items.Count - 1;
					num = (short)294518794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)154468363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (tabItem != null)
					{
						num = (short)1079640078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_186;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 17:
					num4 = A_0;
					num3 = 0;
					num = (short)2032467974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6C:
				if (A_1 != 0)
				{
					num = (short)663420929;
					if (num != 0)
					{
					}
					num = (short)710672401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_341;
				IL_F4:
				tabItem = (base.ItemContainerGenerator.ContainerFromIndex(num4) as global::System.Windows.Controls.TabItem);
				num = (short)105054223;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_186:
				num = (short)895292733;
				short num5 = num;
				num = (short)176952637;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2BF;
				case 1:
					break;
				default:
				{
					num = (short)112263168;
					short num6 = num;
					break;
				}
				}
				num = (short)1963130880;
				if (num != 0)
				{
				}
				num3++;
				num = (short)1512374284;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_238:
				num = (short)1936064514;
				num2 = (int)((global::System.IntPtr)num);
			}
			return tabItem;
			IL_277:
			IL_341:
			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0004EF84 File Offset: 0x0004D184
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2143919311;
			short num2 = num;
			num = (short)901356751;
			switch (num2 == num)
			{
			default:
			{
				num = (short)304021504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1800536064;
			if (num != 0)
			{
			}
			num = (short)68812801;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.SuperTabControl)A_0).OnSuperTabClosed(A_1.Source as global::DevComponents.WpfEditors.SuperTabItem);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0004F044 File Offset: 0x0004D244
		public void OnSuperTabClosed(global::DevComponents.WpfEditors.SuperTabItem item)
		{
			short num = (short)1224540163;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)804253616;
					short num3 = num;
					num = (short)1497558960;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1362231296;
						short num4 = num;
						num = (short)65011712;
						if (num != 0)
						{
						}
						num = (short)370081793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					if (!item.IsSelected)
					{
						num = (short)745537538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_128;
				case 2:
					goto IL_126;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (item == null)
				{
					break;
				}
				num = (short)1999962113;
				if (num != 0)
				{
				}
				num = (short)97452032;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_126:
			return;
			IL_128:
			base.SelectedItem = this.a(base.SelectedIndex, 1);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0004F18C File Offset: 0x0004D38C
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)704577552;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				global::DevComponents.WpfEditors.SuperTabItem superTabItem;
				switch (num2)
				{
				case 0:
					goto IL_303;
				case 1:
					if (num3 > 0)
					{
						num = (short)1977876491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				case 2:
					goto IL_25C;
				case 3:
				{
					num = (short)1381040128;
					short num4 = num;
					if (!this.c.f())
					{
						num = (short)50200586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_303;
				}
				case 4:
					goto IL_23F;
				case 5:
					goto IL_1B8;
				case 6:
					goto IL_1B8;
				case 7:
					if (this.c != null)
					{
						num = (short)748093452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23F;
				case 8:
					base.Items.Add(superTabItem);
					num = (short)1151926277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (num3 >= base.Items.Count)
					{
						num = (short)1037041672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					base.Items.Insert(num3, superTabItem);
					num = (short)200998918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num3++;
					num = (short)1107886080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_301;
				case 12:
					superTabItem = this.e;
					num3 = base.Items.IndexOf(this.c.e());
					num = (short)620363791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_261;
				case 14:
					num = (short)1381957633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (base.Items.IndexOf(superTabItem) < num3)
					{
						num = (short)648282126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 17:
				{
					num = (short)862107785;
					short num5 = num;
					num = (short)1507702921;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_301;
					default:
						num = (short)1718616064;
						if (num != 0)
						{
						}
						num = (short)727515143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_6E:
				num = (short)1547763713;
				if (num != 0)
				{
				}
				if (this.d)
				{
					num = (short)461307921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1B8:
				base.SelectedIndex = num3;
				num = (short)1038483460;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23F:
				base.ReleaseMouseCapture();
				num = (short)1720188930;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_261:
				num = (short)187891715;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_301:
				num3--;
				num = (short)1096351757;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_303:
				base.Items.Remove(superTabItem);
				num = (short)2110521353;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_25C:
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0004F518 File Offset: 0x0004D718
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1381498880;
			switch (num)
			{
			default:
			{
				num = (short)1896611864;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					bool a_;
					switch (num2)
					{
					case 0:
						if (base.TabStripPlacement == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)1270743051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D1;
					case 1:
					{
						global::System.Windows.Point position;
						global::System.Windows.Rect rect;
						if (position.X >= rect.Width / 2.0)
						{
							num = (short)1162215433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					}
					case 2:
						if (base.TabStripPlacement == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1312555018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					case 3:
						if (base.TabStripPlacement != global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1940520981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_116;
					case 4:
						goto IL_421;
					case 5:
					{
						if (superTabItem == this.e)
						{
							num = (short)110690319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Rect rect = new global::System.Windows.Rect(superTabItem.RenderSize);
						global::System.Windows.Point position = e.GetPosition(superTabItem);
						a_ = true;
						num = (short)1196556291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_2D1;
					case 7:
						num = (short)54329344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1539899397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						a_ = false;
						num = (short)474873874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_116;
					case 11:
						goto IL_1D3;
					case 12:
						superTabItem = this.a(e);
						num = (short)394854423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::System.Windows.Point position = e.GetPosition(this);
						position.Y -= 12.0;
						this.f.b(position);
						num = (short)405864462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (this.e != null)
						{
							num = (short)2012807180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C1;
					case 15:
						goto IL_3B6;
					case 16:
						num = (short)1053884433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (this.f != null)
						{
							num = (short)372375565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C1;
					case 18:
						IL_3B1:
						goto IL_2D1;
					case 19:
						a_ = false;
						num = (short)1615659014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_2F1;
					case 21:
						num = (short)713818114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::System.Windows.Point position;
						global::System.Windows.Rect rect;
						if (position.Y >= rect.Height / 2.0)
						{
							num = (short)1621360659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D1;
					}
					case 23:
					{
						num = (short)1178468352;
						short num3 = num;
						if (superTabItem != null)
						{
							num = (short)171900936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B6;
					}
					case 24:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 25:
						if (base.TabStripPlacement != global::System.Windows.Controls.Dock.Left)
						{
							num = (short)555089927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D3;
					}
					IL_AC:
					if (this.d)
					{
						num = (short)620953616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D4:
					num = (short)1405812761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_116:
					num = (short)448331777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D3:
					num = (short)1738604566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D1:
					this.a(superTabItem, a_);
					num = (short)932773908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B6:
					num = (short)689788265;
					short num4 = num;
					num = (short)279663977;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B1;
					default:
						num = (short)220594176;
						if (num != 0)
						{
						}
						this.a();
						num = (short)1072037892;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_2F1:
				IL_421:
				IL_4C1:
				num = (short)716242945;
				if (num != 0)
				{
				}
				base.OnMouseMove(e);
				return;
			}
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0004FA14 File Offset: 0x0004DC14
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)990838788;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1408854435;
					short num3 = num;
					num = (short)1378380195;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12E;
					default:
						num = (short)1203699712;
						if (num != 0)
						{
						}
						num = (short)365166594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_C7;
				case 2:
					goto IL_12E;
				case 3:
					num = (short)1219821569;
					if (num != 0)
					{
					}
					base.ReleaseMouseCapture();
					num = (short)423952385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				}
				IL_38:
				num = (short)1702232064;
				short num4 = num;
				if (this.d)
				{
					num = (short)740491264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_12E:
				if (e.Key != global::System.Windows.Input.Key.Escape)
				{
					break;
				}
				num = (short)1750466563;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C7:
			base.OnKeyDown(e);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0004FB7C File Offset: 0x0004DD7C
		private void a()
		{
			short num = (short)1531969541;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer;
					if (adornerLayer != null)
					{
						num = (short)1831075844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B0;
				}
				case 2:
					num = (short)52035585;
					if (num != 0)
					{
					}
					goto IL_B0;
				case 3:
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer = this.c.Parent as global::System.Windows.Documents.AdornerLayer;
					goto IL_15C;
				}
				case 4:
				{
					num = (short)1195180032;
					short num3 = num;
					global::System.Windows.Documents.AdornerLayer adornerLayer;
					adornerLayer.Remove(this.c);
					num = (short)1861091330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				}
				IL_3D:
				num = (short)290846976;
				short num4 = num;
				num = (short)1386543360;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_15C:
					num = (short)733020161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)2049638400;
					if (num != 0)
					{
					}
					if (this.c != null)
					{
						num = (short)2043412483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_B0:
				this.c = null;
				num = (short)324730880;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0004FD20 File Offset: 0x0004DF20
		private void a(global::DevComponents.WpfEditors.SuperTabItem A_0, bool A_1)
		{
			short num = (short)497942534;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Documents.AdornerLayer adornerLayer;
				switch (num2)
				{
				case 0:
					if (adornerLayer != null)
					{
						num = (short)2114846721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					adornerLayer.Add(this.c);
					goto IL_1B5;
				case 2:
				{
					num = (short)350835934;
					short num3 = num;
					num = (short)615994590;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B5;
					default:
						goto IL_168;
					}
					break;
				}
				case 3:
					if (this.c.e() == A_0)
					{
						num = (short)1799618562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_87;
				case 4:
					num = (short)301400067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				}
				IL_40:
				num = (short)853934080;
				short num4 = num;
				if (this.c != null)
				{
					num = (short)2136670212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_87:
				this.a();
				this.c = new global::DevComponents.WpfEditors.f(A_0);
				this.c.d(A_1);
				adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(A_0);
				num = (short)526188544;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B5:
				num = (short)793313285;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_168:
			num = (short)144375809;
			if (num != 0)
			{
			}
			num = (short)571080704;
			if (num != 0)
			{
			}
			this.c.d(A_1);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0004FEFC File Offset: 0x0004E0FC
		private global::DevComponents.WpfEditors.SuperTabItem a(global::System.Windows.Input.MouseEventArgs A_0)
		{
			short num = (short)1868234752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				int num3;
				global::System.Windows.Controls.ItemCollection items;
				for (;;)
				{
					IL_27:
					global::DevComponents.WpfEditors.SuperTabItem superTabItem;
					switch (num2)
					{
					case 0:
						if (num3 >= items.Count)
						{
							num = (short)676659204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						superTabItem = (base.ItemContainerGenerator.ContainerFromIndex(num3) as global::DevComponents.WpfEditors.SuperTabItem);
						num = (short)778895362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)672914062;
						short num4 = num;
						num = (short)300472974;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E7;
						default:
						{
							num = (short)766771200;
							if (num != 0)
							{
							}
							global::System.Windows.Point position = A_0.GetPosition(superTabItem);
							global::System.Windows.Rect rect = new global::System.Windows.Rect(superTabItem.RenderSize);
							num = (short)554434563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_E7;
					case 3:
					{
						global::System.Windows.Point position;
						global::System.Windows.Rect rect;
						if (rect.Contains(position))
						{
							num = (short)1037631494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99;
					}
					case 4:
						goto IL_1B6;
					case 5:
						goto IL_151;
					case 6:
						return superTabItem;
					case 7:
						num = (short)742326273;
						if (num != 0)
						{
						}
						goto IL_151;
					}
					goto IL_4E;
					IL_99:
					num3++;
					num = (short)1234829317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7:
					if (superTabItem != null)
					{
						num = (short)1938227201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99;
					IL_151:
					num = (short)513409024;
					short num5 = num;
					num = (short)540934144;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B6:
				return null;
				IL_4E:
				items = base.Items;
				num3 = 0;
				num = (short)949878791;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0005011C File Offset: 0x0004E31C
		[global::System.ComponentModel.Browsable(false)]
		public bool IsTabDragging
		{
			get
			{
				short num = (short)1144780549;
				short num2 = num;
				num = (short)1953167109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2091057152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)191102977;
				if (num != 0)
				{
				}
				num = (short)130220032;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000501CC File Offset: 0x0004E3CC
		internal bool a(global::DevComponents.WpfEditors.SuperTabItem A_0)
		{
			short num = (short)498204679;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Documents.AdornerLayer adornerLayer;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.d)
					{
						goto IL_16E;
					}
					this.d = true;
					adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(this);
					num = (short)918290435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_C7;
				case 2:
					if (!base.CaptureMouse())
					{
						num = (short)226623489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D2;
				case 3:
					if (adornerLayer != null)
					{
						num = (short)243204102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D2;
				case 4:
					goto IL_185;
				case 5:
					goto IL_63;
				case 6:
					num = (short)66781186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				}
				IL_44:
				if (!this.ReorderTabsEnabled)
				{
					num = (short)1397817349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)567813480;
				short num3 = num;
				num = (short)1006249320;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)173277184;
					short num4 = num;
					num = (short)446300160;
					if (num != 0)
					{
					}
					num = (short)960299008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_16E:
				num = (short)926351364;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_63:
			num = (short)707526657;
			if (num != 0)
			{
			}
			return false;
			IL_C7:
			IL_D2:
			this.d = false;
			return false;
			IL_185:
			return this.d;
			IL_1D2:
			this.f = new global::DevComponents.WpfEditors.e(this, A_0);
			adornerLayer.Add(this.f);
			this.e = A_0;
			return true;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000503CC File Offset: 0x0004E5CC
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)768868352;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)2099314688;
						short num3 = num;
						num = (short)1532341850;
						short num4 = num;
						num = (short)524398170;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1311178752;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A8;
							}
							continue;
						}
						break;
					}
					case 1:
						goto IL_129;
					case 2:
						num = (short)823001089;
						if (num != 0)
						{
						}
						(this.f.Parent as global::System.Windows.Documents.AdornerLayer).Remove(this.f);
						this.f = null;
						num = (short)337772545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A8:
					if (this.f == null)
					{
						goto IL_12B;
					}
					num = (short)1518796802;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_129:
			IL_12B:
			this.a();
			this.e = null;
			this.d = false;
			this.f = null;
			base.OnLostMouseCapture(e);
		}

		// Token: 0x040001CF RID: 463
		public static readonly global::System.Windows.DependencyProperty ContentBackgroundProperty;

		// Token: 0x040001D0 RID: 464
		public static readonly global::System.Windows.DependencyProperty ContentBorderBrushProperty;

		// Token: 0x040001D1 RID: 465
		public static readonly global::System.Windows.DependencyProperty ContentInnerBorderBrushProperty;

		// Token: 0x040001D2 RID: 466
		public static readonly global::System.Windows.DependencyProperty ContentBorderThicknessProperty;

		// Token: 0x040001D3 RID: 467
		public static readonly global::System.Windows.DependencyProperty CloseButtonVisibilityProperty;

		// Token: 0x040001D4 RID: 468
		public static readonly global::System.Windows.DependencyProperty ReorderTabsEnabledProperty;

		// Token: 0x040001D5 RID: 469
		public static readonly global::System.Windows.DependencyProperty TabLayoutTypeProperty;

		// Token: 0x040001D6 RID: 470
		public static readonly global::System.Windows.DependencyProperty ControlBoxTabMenuVisibilityProperty;

		// Token: 0x040001D7 RID: 471
		public static readonly global::System.Windows.DependencyProperty ControlBoxCloseTabVisibilityProperty;

		// Token: 0x040001D8 RID: 472
		public static readonly global::System.Windows.DependencyProperty TabHeaderLeftProperty;

		// Token: 0x040001D9 RID: 473
		public static readonly global::System.Windows.DependencyProperty TabHeaderRightProperty;

		// Token: 0x040001DA RID: 474
		public static readonly global::System.Windows.DependencyProperty TabStyleProperty;

		// Token: 0x040001DB RID: 475
		public static readonly global::System.Windows.DependencyProperty ControlButtonStyleProperty;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Controls.Button a;

		// Token: 0x040001DD RID: 477
		private bool b;

		// Token: 0x040001DE RID: 478
		private global::DevComponents.WpfEditors.f c;

		// Token: 0x040001DF RID: 479
		private bool d;

		// Token: 0x040001E0 RID: 480
		private global::DevComponents.WpfEditors.SuperTabItem e;

		// Token: 0x040001E1 RID: 481
		private global::DevComponents.WpfEditors.e f;
	}
}
