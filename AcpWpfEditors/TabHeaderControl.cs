using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000044 RID: 68
	[global::System.ComponentModel.DesignTimeVisible(true)]
	public class TabHeaderControl : global::System.Windows.Controls.TabControl
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00060984 File Offset: 0x0005EB84
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00060A3C File Offset: 0x0005EC3C
		public global::System.Windows.Visibility TabStripVisibility
		{
			get
			{
				short num = (short)1658982055;
				short num2 = num;
				num = (short)2094206631;
				switch (num2 == num)
				{
				}
				num = (short)1385693184;
				short num3 = num;
				num = (short)704970753;
				if (num != 0)
				{
				}
				num = (short)230817792;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.TabHeaderControl.TabStripVisibilityProperty);
			}
			set
			{
				short num = (short)299603584;
				short num2 = num;
				num = (short)598382208;
				switch (num2 == num)
				{
				}
				num = (short)965148672;
				short num3 = num;
				num = (short)1670316032;
				if (num != 0)
				{
				}
				num = (short)1216937985;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.TabHeaderControl.TabStripVisibilityProperty, value);
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00060AF4 File Offset: 0x0005ECF4
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num;
			int num3;
			global::DevComponents.WpfEditors.TabHeaderControl tabHeaderControl;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1422643168;
					short num2 = num;
					num = (short)1045024736;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						num = (short)1415774208;
						if (num != 0)
						{
						}
						num = (short)1468071937;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
						{
							num = (short)221773824;
							short num4 = num;
							tabHeaderControl.OnHeaderChanged(A_1.OldValue, A_1.NewValue);
							num = (short)349896706;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (tabHeaderControl != null)
							{
								num = (short)1424752640;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							return;
						}
						goto IL_8F;
					}
				}
				return;
			}
			IL_8F:
			tabHeaderControl = (A_0 as global::DevComponents.WpfEditors.TabHeaderControl);
			IL_96:
			num = (short)2130968577;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00060C24 File Offset: 0x0005EE24
		protected virtual void OnHeaderChanged(object oldValue, object newValue)
		{
			short num = (short)515964930;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1499398145;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)967611506;
					short num3 = num;
					num = (short)1238078578;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1055326208;
						if (num != 0)
						{
						}
						base.AddLogicalChild(newValue);
						num = (short)561774596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (newValue != null)
					{
						num = (short)1158414336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 3:
				{
					num = (short)201129984;
					short num4 = num;
					base.RemoveLogicalChild(oldValue);
					num = (short)894828549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				case 5:
					goto IL_A3;
				}
				IL_64:
				if (oldValue != null)
				{
					num = (short)1604059139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A3:
				num = (short)2121793537;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00060DA4 File Offset: 0x0005EFA4
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00060E58 File Offset: 0x0005F058
		public object Header
		{
			get
			{
				short num = (short)736596640;
				short num2 = num;
				num = (short)1024561824;
				switch (num2 == num)
				{
				}
				num = (short)199098368;
				short num3 = num;
				num = (short)960823296;
				if (num != 0)
				{
				}
				num = (short)893845505;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.TabHeaderControl.HeaderProperty);
			}
			set
			{
				short num = (short)1800928465;
				short num2 = num;
				num = (short)762510545;
				switch (num2 == num)
				{
				}
				num = (short)902299648;
				short num3 = num;
				num = (short)1484783617;
				if (num != 0)
				{
				}
				num = (short)1374617600;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.TabHeaderControl.HeaderProperty, value);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00060F10 File Offset: 0x0005F110
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num;
			int num3;
			global::DevComponents.WpfEditors.TabHeaderControl tabHeaderControl;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1591968625;
					short num2 = num;
					num = (short)1819050865;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					default:
						num = (short)2003369984;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
						{
							num = (short)1861287937;
							if (num != 0)
							{
							}
							num = (short)1733951488;
							short num4 = num;
							tabHeaderControl.OnFooterChanged(A_1.OldValue, A_1.NewValue);
							num = (short)1552482306;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (tabHeaderControl != null)
							{
								num = (short)129695744;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							return;
						}
						goto IL_66;
					}
				}
				return;
			}
			IL_66:
			tabHeaderControl = (A_0 as global::DevComponents.WpfEditors.TabHeaderControl);
			IL_6D:
			num = (short)1481441281;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00061040 File Offset: 0x0005F240
		protected virtual void OnFooterChanged(object oldValue, object newValue)
		{
			short num = (short)331481090;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2088328766;
					short num3 = num;
					num = (short)737500734;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)529334272;
						if (num != 0)
						{
						}
						base.AddLogicalChild(newValue);
						num = (short)1052311556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (newValue != null)
					{
						num = (short)1338638336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
				{
					num = (short)1144258560;
					short num4 = num;
					base.RemoveLogicalChild(oldValue);
					num = (short)1685716997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				case 5:
					goto IL_A3;
				}
				IL_3C:
				if (oldValue != null)
				{
					num = (short)645464065;
					if (num != 0)
					{
					}
					num = (short)1424883715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A3:
				num = (short)1346437121;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000611C4 File Offset: 0x0005F3C4
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0006127C File Offset: 0x0005F47C
		public object Footer
		{
			get
			{
				short num = (short)1311244289;
				if (num != 0)
				{
				}
				num = (short)146116328;
				short num2 = num;
				num = (short)937397992;
				switch (num2 == num)
				{
				}
				num = (short)648478720;
				short num3 = num;
				num = (short)455475200;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.TabHeaderControl.FooterProperty);
			}
			set
			{
				short num = (short)1305673729;
				if (num != 0)
				{
				}
				num = (short)978222288;
				short num2 = num;
				num = (short)1252162768;
				switch (num2 == num)
				{
				}
				num = (short)274923520;
				short num3 = num;
				num = (short)1687945216;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.TabHeaderControl.FooterProperty, value);
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00061330 File Offset: 0x0005F530
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num3;
			global::DevComponents.WpfEditors.TabHeaderControl tabHeaderControl;
			for (;;)
			{
				IL_0A:
				num = (short)2092861112;
				short num2 = num;
				num = (short)963741368;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1567424512;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_F8;
					case 1:
						goto IL_A4;
					case 2:
						if (tabHeaderControl != null)
						{
							num = (short)1141702657;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_67;
				}
				IL_A4:
				num = (short)1567686656;
				short num4 = num;
				tabHeaderControl.OnTabInfoChanged(A_1.OldValue, A_1.NewValue);
				num = (short)1657798656;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F8:
			num = (short)1543503873;
			if (num != 0)
			{
			}
			return;
			IL_67:
			tabHeaderControl = (A_0 as global::DevComponents.WpfEditors.TabHeaderControl);
			num = (short)367394818;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00061460 File Offset: 0x0005F660
		protected virtual void OnTabInfoChanged(object oldValue, object newValue)
		{
			short num = (short)1814036485;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.AddLogicalChild(newValue);
					num = (short)1047855106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)751108097;
					if (num != 0)
					{
					}
					goto IL_7A;
				case 2:
					return;
				case 3:
				{
					base.RemoveLogicalChild(oldValue);
					num = (short)1766326272;
					short num3 = num;
					num = (short)1926889473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					if (newValue == null)
					{
						return;
					}
					num = (short)1850303905;
					short num4 = num;
					num = (short)1483564449;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)894369792;
						if (num != 0)
						{
						}
						num = (short)1787101184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				IL_3C:
				if (oldValue != null)
				{
					num = (short)1983119363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7A:
				num = (short)263585796;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x000615DC File Offset: 0x0005F7DC
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00061690 File Offset: 0x0005F890
		public object TabInfo
		{
			get
			{
				short num = (short)29192226;
				short num2 = num;
				num = (short)462778402;
				switch (num2 == num)
				{
				}
				num = (short)431947777;
				if (num != 0)
				{
				}
				num = (short)2136211456;
				short num3 = num;
				num = (short)297467904;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.TabHeaderControl.TabInfoProperty);
			}
			set
			{
				short num = (short)130842026;
				short num2 = num;
				num = (short)1733918122;
				switch (num2 == num)
				{
				}
				num = (short)104202240;
				if (num != 0)
				{
				}
				num = (short)1475084288;
				short num3 = num;
				num = (short)1182203905;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.TabHeaderControl.TabInfoProperty, value);
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00061744 File Offset: 0x0005F944
		static TabHeaderControl()
		{
			int a_ = 19;
			short num = (short)792039009;
			short num2 = num;
			num = (short)635670113;
			switch (num2 == num)
			{
			}
			num = (short)1119813632;
			if (num != 0)
			{
			}
			num = (short)1416036352;
			short num3 = num;
			num = (short)98697217;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.TabHeaderControl.TabStripVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟菡蛣뗥鳧飩藫黭ꛯ鯱蟳鿵髷鏹郻韽瓿笁", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.TabHeaderControl), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::DevComponents.WpfEditors.TabHeaderControl.HeaderProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꣟蟡藣若跧飩", a_), typeof(object), typeof(global::DevComponents.WpfEditors.TabHeaderControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.TabHeaderControl.c)));
			global::DevComponents.WpfEditors.TabHeaderControl.FooterProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꛟ跡诣鋥跧飩", a_), typeof(object), typeof(global::DevComponents.WpfEditors.TabHeaderControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.TabHeaderControl.b)));
			global::DevComponents.WpfEditors.TabHeaderControl.TabInfoProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟菡蛣꿥蛧賩菫", a_), typeof(object), typeof(global::DevComponents.WpfEditors.TabHeaderControl), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.TabHeaderControl.a)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.TabHeaderControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.TabHeaderControl)));
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00061908 File Offset: 0x0005FB08
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num3;
			global::System.Windows.FrameworkElement frameworkElement;
			for (;;)
			{
				IL_0A:
				num = (short)1956254888;
				short num2 = num;
				num = (short)2138248360;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)303562752;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)2060582912;
						short num4 = num;
						goto IL_101;
					}
					case 2:
						if (frameworkElement is global::System.Windows.Controls.TabItem)
						{
							num = (short)1828847617;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_67;
				}
				IL_101:
				frameworkElement.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, this.a());
				num = (short)99221504;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_67:
			num = (short)1147666433;
			if (num != 0)
			{
			}
			base.PrepareContainerForItemOverride(element, item);
			frameworkElement = (element as global::System.Windows.FrameworkElement);
			num = (short)515637250;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00061A44 File Offset: 0x0005FC44
		private object a()
		{
			int a_ = 14;
			short num = (short)886636546;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_131;
				case 1:
				{
					num = (short)2073482822;
					short num3 = num;
					num = (short)32233030;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					default:
					{
						num = (short)654442496;
						short num4 = num;
						num = (short)687472640;
						if (num != 0)
						{
						}
						this.a = new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.TabHeaderControl), global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("迚볜뷞꣠韢胤諦", a_));
						num = (short)1320484864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				goto IL_3A;
				IL_6D:
				num = (short)1919614977;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A:
				num = (short)2116485121;
				if (num != 0)
				{
				}
				if (this.a == null)
				{
					goto IL_6D;
				}
				break;
			}
			IL_131:
			return this.a;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00061B8C File Offset: 0x0005FD8C
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				global::System.Collections.ArrayList arrayList;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					int num;
					short num2;
					global::System.Collections.IEnumerator logicalChildren;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							arrayList.Add(this.TabInfo);
							num2 = (short)412549127;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_189;
						case 2:
							goto IL_BC;
						case 3:
							if (this.TabInfo != null)
							{
								num2 = (short)2111504384;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_2A1;
						case 4:
							num2 = (short)526974985;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 5:
							if (!logicalChildren.MoveNext())
							{
								num2 = (short)353959940;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							arrayList.Add(logicalChildren.Current);
							num2 = (short)1623064587;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 6:
							arrayList.Add(this.Footer);
							num2 = (short)79691777;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 7:
							goto IL_15A;
						case 8:
							arrayList.Add(this.Header);
							num2 = (short)1906507778;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 9:
						{
							if (this.Header == null)
							{
								goto IL_BC;
							}
							num2 = (short)90259377;
							short num3 = num2;
							num2 = (short)1845903281;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)693633025;
								if (num2 != 0)
								{
								}
								num2 = (short)1893924864;
								if (num2 != 0)
								{
								}
								num2 = (short)933953544;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 10:
							if (this.Footer != null)
							{
								num2 = (short)1999503366;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_189;
						case 11:
							goto IL_FA;
						case 12:
						{
							num2 = (short)1325465600;
							short num4 = num2;
							goto IL_FA;
						}
						}
						break;
						IL_BC:
						num2 = (short)108920842;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_FA:
						num2 = (short)1089404933;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_189:
						num2 = (short)1667563523;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_44:
					arrayList = new global::System.Collections.ArrayList();
					logicalChildren = base.LogicalChildren;
					num2 = (short)1063452684;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_15A:
				IL_2A1:
				return arrayList.GetEnumerator();
			}
		}

		// Token: 0x04000249 RID: 585
		public static readonly global::System.Windows.DependencyProperty TabStripVisibilityProperty;

		// Token: 0x0400024A RID: 586
		public static readonly global::System.Windows.DependencyProperty HeaderProperty;

		// Token: 0x0400024B RID: 587
		public static readonly global::System.Windows.DependencyProperty FooterProperty;

		// Token: 0x0400024C RID: 588
		public static readonly global::System.Windows.DependencyProperty TabInfoProperty;

		// Token: 0x0400024D RID: 589
		private global::System.Windows.ComponentResourceKey a;
	}
}
