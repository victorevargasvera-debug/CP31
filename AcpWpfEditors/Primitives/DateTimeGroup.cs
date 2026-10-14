using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000057 RID: 87
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DateTimeGroup : global::DevComponents.WpfEditors.Primitives.EditorInputGroup
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0006FEE8 File Offset: 0x0006E0E8
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0006FFA0 File Offset: 0x0006E1A0
		public bool DefaultInputValues
		{
			get
			{
				short num = (short)527161756;
				short num2 = num;
				num = (short)1565120924;
				switch (num2 == num)
				{
				}
				num = (short)1551761408;
				short num3 = num;
				num = (short)1509097472;
				if (num != 0)
				{
				}
				num = (short)731971585;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.DefaultInputValuesProperty);
			}
			set
			{
				short num = (short)874592817;
				short num2 = num;
				num = (short)1756052017;
				switch (num2 == num)
				{
				}
				num = (short)507510784;
				short num3 = num;
				num = (short)1536884737;
				if (num != 0)
				{
				}
				num = (short)1649868800;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.DefaultInputValuesProperty, value);
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000581 RID: 1409 RVA: 0x0007005C File Offset: 0x0006E25C
		// (remove) Token: 0x06000582 RID: 1410 RVA: 0x00070110 File Offset: 0x0006E310
		public event global::System.Windows.RoutedEventHandler ValueChanged
		{
			add
			{
				short num = (short)892201925;
				short num2 = num;
				num = (short)2072505285;
				switch (num2 == num)
				{
				}
				num = (short)1421737984;
				short num3 = num;
				num = (short)806092801;
				if (num != 0)
				{
				}
				num = (short)1382416384;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueChangedEvent, value);
			}
			remove
			{
				short num = (short)1683040114;
				short num2 = num;
				num = (short)731326322;
				switch (num2 == num)
				{
				}
				num = (short)623509504;
				short num3 = num;
				num = (short)1552809985;
				if (num != 0)
				{
				}
				num = (short)857997312;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueChangedEvent, value);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000701C8 File Offset: 0x0006E3C8
		protected virtual void OnValueChanged(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)3512378;
			short num2 = num;
			num = (short)1193318458;
			switch (num2 == num)
			{
			}
			num = (short)728432640;
			short num3 = num;
			num = (short)989200385;
			if (num != 0)
			{
			}
			num = (short)262275072;
			if (num != 0)
			{
			}
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00070278 File Offset: 0x0006E478
		private static object a(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup = A_0 as global::DevComponents.WpfEditors.Primitives.DateTimeGroup;
			short num;
			if (dateTimeGroup != null)
			{
				num = (short)373591233;
				short num2 = num;
				num = (short)1711312065;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)894042112;
					if (num != 0)
					{
					}
					break;
				}
				return dateTimeGroup.OnCoerceValue((global::System.DateTime?)A_1);
			}
			num = (short)1438580736;
			short num3 = num;
			num = (short)1506279425;
			if (num != 0)
			{
			}
			return A_1;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00070344 File Offset: 0x0006E544
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					dateTimeGroup.OnValueChanged((global::System.DateTime?)A_1.OldValue, (global::System.DateTime?)A_1.NewValue);
					num2 = (short)674889730;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1453384236;
					short num3 = num2;
					num2 = (short)972939820;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
						num2 = (short)525991937;
						if (num2 != 0)
						{
						}
						num2 = (short)2024538112;
						if (num2 != 0)
						{
						}
						if (dateTimeGroup != null)
						{
							num2 = (short)1487339520;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					goto IL_FD;
				}
				goto IL_1C;
			}
			IL_FD:
			num2 = (short)533659648;
			short num4 = num2;
			return;
			IL_1C:
			dateTimeGroup = (A_0 as global::DevComponents.WpfEditors.Primitives.DateTimeGroup);
			num2 = (short)622460929;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0007047C File Offset: 0x0006E67C
		protected virtual global::System.DateTime? OnCoerceValue(global::System.DateTime? value)
		{
			short num = (short)1278279686;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.DateTime? dateTime;
				global::System.DateTime t;
				bool flag;
				bool flag2;
				switch (num2)
				{
				case 0:
					if (value != null)
					{
						num = (short)1557200916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return value;
				case 1:
					if (dateTime == null)
					{
						num = (short)877592585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)456065042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					flag = (dateTime.GetValueOrDefault() < t);
					goto IL_4D0;
				case 3:
				{
					t = value.Value;
					int year = t.Year;
					t = value.Value;
					int month = t.Month;
					t = value.Value;
					int day = t.Day;
					t = value.Value;
					int hour = t.Hour;
					t = value.Value;
					int minute = t.Minute;
					t = value.Value;
					value = new global::System.DateTime?(new global::System.DateTime(year, month, day, hour, minute, t.Second));
					num = (short)1773076503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					value = new global::System.DateTime?(this.MaxDate);
					num = (short)14417931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!this.k)
					{
						num = (short)1452802064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return value;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_8D;
					}
					continue;
				case 7:
					if (t.Millisecond != 0)
					{
						num = (short)256573443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43B;
				case 8:
					num = (short)988282902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)836173841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)532480015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					num = (short)283615534;
					short num3 = num;
					num = (short)136814894;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3F5;
					default:
						goto IL_371;
					}
					break;
				}
				case 12:
					value = new global::System.DateTime?(global::System.DateTime.Today);
					num = (short)1434583059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (value == null)
					{
						num = (short)2002190344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B6;
				case 14:
					goto IL_3F5;
				case 15:
					flag = false;
					goto IL_4D0;
				case 16:
					dateTime = value;
					t = this.MinDate;
					num = (short)1321271317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					flag2 = false;
					goto IL_23D;
				case 18:
					flag2 = (dateTime.GetValueOrDefault() > t);
					goto IL_23D;
				case 19:
					goto IL_2CA;
				case 20:
					num = (short)1783431173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (dateTime == null)
					{
						num = (short)189988874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1220345858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (!base.AllowEmptyState)
					{
						num = (short)1127481356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B6;
				case 23:
					goto IL_43B;
				case 24:
					goto IL_1F3;
				case 25:
					value = new global::System.DateTime?(this.MinDate);
					num = (short)1669333016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8D:
				if (value != null)
				{
					num = (short)102301710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_43B;
				IL_1F3:
				dateTime = value;
				t = this.MaxDate;
				num = (short)1504313345;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4D0:
				if (flag)
				{
					num = (short)506200089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1F3;
				IL_23D:
				if (flag2)
				{
					num = (short)898498564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return value;
				IL_3B6:
				num = (short)1127088128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F5:
				t = value.Value;
				num = (short)11862023;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43B:
				num = (short)1120993293;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2CA:
			num = (short)145293313;
			if (num != 0)
			{
			}
			return value;
			IL_371:
			num = (short)1692205056;
			short num4 = num;
			num = (short)2074935296;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00070980 File Offset: 0x0006EB80
		protected virtual void OnValueChanged(global::System.DateTime? oldValue, global::System.DateTime? newValue)
		{
			short num = (short)1953038338;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_52;
				case 1:
					goto IL_114;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					goto IL_134;
				}
				IL_34:
				if (newValue == null)
				{
					num = (short)1847918592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.IsEmpty = false;
				num = (short)1863555916;
				short num3 = num;
				num = (short)1531091788;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_52;
				case 1:
					break;
				default:
				{
					num = (short)1427111936;
					short num4 = num;
					break;
				}
				}
				num = (short)1715142657;
				if (num != 0)
				{
				}
				num = (short)878116864;
				if (num != 0)
				{
				}
				num = (short)1243676673;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_52:
				base.IsEmpty = true;
				num = (short)845545475;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_114:
			IL_134:
			this.d();
			base.InvalidateMeasure();
			base.InvalidateVisual();
			this.OnValueChanged(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueChangedEvent));
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00070AE8 File Offset: 0x0006ECE8
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00070BA4 File Offset: 0x0006EDA4
		public global::System.DateTime? Value
		{
			get
			{
				short num = (short)2102982014;
				short num2 = num;
				num = (short)2112288126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1710948352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1172832256;
				if (num != 0)
				{
				}
				num = (short)685834241;
				if (num != 0)
				{
				}
				return (global::System.DateTime?)base.GetValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueProperty);
			}
			set
			{
				short num = (short)47157094;
				short num2 = num;
				num = (short)1593151334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1887043584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879427585;
				if (num != 0)
				{
				}
				num = (short)1816199168;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueProperty, value);
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00070C5C File Offset: 0x0006EE5C
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					dateTimeGroup.OnMinDateChanged((global::System.DateTime)A_1.OldValue, (global::System.DateTime)A_1.NewValue);
					num2 = (short)1971453954;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1175265217;
					short num3 = num2;
					num2 = (short)1026891713;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FC;
					default:
						num2 = (short)1944190977;
						if (num2 != 0)
						{
						}
						num2 = (short)1507786752;
						if (num2 != 0)
						{
						}
						if (dateTimeGroup != null)
						{
							num2 = (short)769916928;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					goto IL_FC;
				}
				goto IL_1C;
			}
			IL_FC:
			num2 = (short)689242112;
			short num4 = num2;
			return;
			IL_1C:
			dateTimeGroup = (A_0 as global::DevComponents.WpfEditors.Primitives.DateTimeGroup);
			num2 = (short)1877344257;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00070D94 File Offset: 0x0006EF94
		protected virtual void OnMinDateChanged(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			short num = (short)1792439798;
			short num2 = num;
			num = (short)385971702;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1663762432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)491847680;
			if (num != 0)
			{
			}
			num = (short)2125594625;
			if (num != 0)
			{
			}
			base.CoerceValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueProperty);
			this.c();
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00070E50 File Offset: 0x0006F050
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x00070F10 File Offset: 0x0006F110
		public global::System.DateTime MinDate
		{
			get
			{
				short num = (short)1885047160;
				short num2 = num;
				num = (short)1442548088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1479213056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2044854273;
				if (num != 0)
				{
				}
				num = (short)1969160192;
				if (num != 0)
				{
				}
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MinDateProperty);
			}
			set
			{
				short num = (short)326238209;
				if (num != 0)
				{
				}
				num = (short)994443264;
				short num2 = num;
				num = (short)82498500;
				short num3 = num;
				num = (short)2123879364;
				switch (num3 == num)
				{
				}
				num = (short)1981808640;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MinDateProperty, value);
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00070FCC File Offset: 0x0006F1CC
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					dateTimeGroup.OnMaxDateChanged((global::System.DateTime)A_1.OldValue, (global::System.DateTime)A_1.NewValue);
					num2 = (short)882835458;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1363508431;
					short num3 = num2;
					num2 = (short)1432911055;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FE;
					default:
						num2 = (short)1912733696;
						if (num2 != 0)
						{
						}
						num2 = (short)1414791169;
						if (num2 != 0)
						{
						}
						if (dateTimeGroup != null)
						{
							num2 = (short)834797568;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					goto IL_FE;
				}
				goto IL_1C;
			}
			IL_FE:
			num2 = (short)481296384;
			short num4 = num2;
			return;
			IL_1C:
			dateTimeGroup = (A_0 as global::DevComponents.WpfEditors.Primitives.DateTimeGroup);
			num2 = (short)875954177;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00071104 File Offset: 0x0006F304
		protected virtual void OnMaxDateChanged(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			short num = (short)1973745215;
			short num2 = num;
			num = (short)1811347007;
			switch (num2 == num)
			{
			default:
			{
				num = (short)30343168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1721434113;
			if (num != 0)
			{
			}
			num = (short)1625882624;
			if (num != 0)
			{
			}
			base.CoerceValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueProperty);
			this.c();
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x000711BC File Offset: 0x0006F3BC
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00071274 File Offset: 0x0006F474
		public global::System.DateTime MaxDate
		{
			get
			{
				short num = (short)977601939;
				short num2 = num;
				num = (short)2042627475;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196228608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)389087232;
				if (num != 0)
				{
				}
				num = (short)457965569;
				if (num != 0)
				{
				}
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MaxDateProperty);
			}
			set
			{
				short num = (short)1121830743;
				short num2 = num;
				num = (short)1731446615;
				switch (num2 == num)
				{
				default:
				{
					num = (short)860028928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1376780289;
				if (num != 0)
				{
				}
				num = (short)666238976;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MaxDateProperty, value);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0007132C File Offset: 0x0006F52C
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			short num = (short)229244929;
			if (num != 0)
			{
			}
			num = (short)321454080;
			short num2 = num;
			num = (short)963955062;
			short num3 = num;
			num = (short)165071222;
			switch (num3 == num)
			{
			}
			num = (short)487587840;
			if (num != 0)
			{
			}
			global::System.Windows.DependencyObject[] a_;
			if (visualAdded != null)
			{
				(a_ = new global::System.Windows.DependencyObject[1])[0] = visualAdded;
			}
			else
			{
				a_ = null;
			}
			global::System.Windows.DependencyObject[] a_2;
			if (visualRemoved != null)
			{
				(a_2 = new global::System.Windows.DependencyObject[1])[0] = visualRemoved;
			}
			else
			{
				a_2 = null;
			}
			this.a(a_, a_2);
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0007140C File Offset: 0x0006F60C
		private void a(global::System.Collections.Generic.IEnumerable<global::System.Windows.DependencyObject> A_0, global::System.Collections.Generic.IEnumerable<global::System.Windows.DependencyObject> A_1)
		{
			short num = (short)483721216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1482227716;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.IEnumerator<global::System.Windows.DependencyObject> enumerator;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EC;
					case 1:
						if (A_0 != null)
						{
							num = (short)1204551682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0A;
					case 2:
						enumerator = A_0.GetEnumerator();
						num = (short)347668481;
						if (num != 0)
						{
						}
						num = (short)1224409088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_5BC;
					case 4:
					{
						num = (short)377290752;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_84;
						}
						continue;
					}
					case 5:
						try
						{
							num = (short)1182203912;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									this.a = null;
									num = (short)1860304910;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Windows.DependencyObject dependencyObject;
									if (dependencyObject == this.b)
									{
										num = (short)28246031;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Windows.DependencyObject dependencyObject;
									if (dependencyObject == this.a)
									{
										num = (short)1031274496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)399572997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Windows.DependencyObject dependencyObject;
									if (dependencyObject == this.c)
									{
										num = (short)2145976341;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1239744523;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Windows.DependencyObject dependencyObject;
									if (dependencyObject == this.f)
									{
										num = (short)1953103879;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)907542544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									this.f = null;
									num = (short)1474166802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_1C5;
									}
									continue;
								case 9:
								{
									global::System.Windows.DependencyObject dependencyObject;
									if (dependencyObject == this.h)
									{
										num = (short)1152581654;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)414973953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::System.Windows.DependencyObject dependencyObject;
									if (dependencyObject == this.d)
									{
										num = (short)1187250199;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1651441684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num = (short)1616707601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									this.b = null;
									num = (short)674693123;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::System.Windows.DependencyObject dependencyObject;
									if (dependencyObject == this.g)
									{
										num = (short)1759641626;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1204289545;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
									goto IL_54C;
								case 20:
								{
									global::System.Windows.DependencyObject dependencyObject;
									if (dependencyObject == this.e)
									{
										num = (short)503447577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1952382982;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 21:
									this.c = null;
									num = (short)1598357514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									this.h = null;
									num = (short)141557787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									this.d = null;
									num = (short)642383891;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1115815948;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.DependencyObject dependencyObject = enumerator.Current;
									num = (short)48037890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									this.e = null;
									num = (short)146014221;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									this.g = null;
									num = (short)94830596;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_24F:
								num = (short)443088920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C5:
								goto IL_24F;
							}
							IL_54C:
							goto IL_F1;
						}
						finally
						{
							num = (short)330760193;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1021116418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_583;
									}
									continue;
								case 2:
									goto IL_5B9;
								}
								IL_583:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1156317184;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5B9:;
						}
						goto IL_5BC;
					}
					IL_84:
					if (A_1 != null)
					{
						num = (short)854654979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F1:
					num = (short)510328833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5BC:
					enumerator = A_1.GetEnumerator();
					num = (short)1000669189;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EC:
				try
				{
					num = (short)427229200;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput;
						global::System.Windows.DependencyObject dependencyObject2;
						switch (num2)
						{
						case 1:
							if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.DayName)
							{
								num = (short)342097930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)708247586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (this.e is global::DevComponents.WpfEditors.Primitives.NumericHourInput)
							{
								num = (short)1759576095;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9A3;
						case 6:
							goto IL_D4F;
						case 7:
							if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.Month)
							{
								num = (short)1234567197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BDE;
						case 9:
						{
							global::System.Collections.IEnumerator enumerator2 = base.Items.GetEnumerator();
							num = (short)885587981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							this.b = dateTimePartInput;
							num = (short)110100488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							this.f = dateTimePartInput;
							num = (short)1800011780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							num = (short)1568079902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							try
							{
								num = (short)2136539138;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_B63;
									case 1:
									{
										global::System.Collections.IEnumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1607335942;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator2.Current;
										num = (short)2069037061;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_A96;
										}
										continue;
									case 4:
									{
										global::System.Windows.UIElement uielement;
										((global::DevComponents.WpfEditors.Primitives.HourPeriodInput)uielement).HourInput = (global::DevComponents.WpfEditors.Primitives.NumericHourInput)this.e;
										num = (short)2054225923;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::System.Windows.UIElement uielement;
										if (uielement is global::DevComponents.WpfEditors.Primitives.HourPeriodInput)
										{
											num = (short)1497759748;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										num = (short)1867513856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_B0E:
									num = (short)547553281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_A96:
									goto IL_B0E;
								}
								IL_B63:
								break;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_B85;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_B72:
									switch (num2)
									{
									case 0:
										disposable.Dispose();
										num = (short)890503170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (disposable != null)
										{
											num = (short)1143406592;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_BDD;
									case 2:
										goto IL_BDB;
									}
									goto IL_B85;
								}
								IL_BDB:
								IL_BDD:
								goto EndFinally_37;
								IL_B85:
								global::System.Collections.IEnumerator enumerator2;
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)1458044929;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_B72;
								EndFinally_37:;
							}
							goto IL_BDE;
						case 14:
							if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.DayOfYear)
							{
								num = (short)637075480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 16:
							switch (0)
							{
							case 0:
								goto IL_6A4;
							}
							continue;
						case 17:
							if (dependencyObject2 is global::DevComponents.WpfEditors.Primitives.HourPeriodInput)
							{
								num = (short)1109852172;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9A3;
						case 19:
							num = (short)1466564633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							this.a = dateTimePartInput;
							num = (short)1282605056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							this.d = dateTimePartInput;
							num = (short)1359085583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.Second)
							{
								num = (short)1553006628;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)855900192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							num = (short)990511109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							this.h = dateTimePartInput;
							num = (short)1983315986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.Day)
							{
								num = (short)856031252;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)685637633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							this.e = dateTimePartInput;
							num = (short)436207651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							if (dateTimePartInput != null)
							{
								num = (short)2029912083;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 28:
							if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.Minute)
							{
								num = (short)1568604171;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1086980103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							this.c = dateTimePartInput;
							num = (short)639434754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							if (this.e != null)
							{
								num = (short)1016135703;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9A3;
						case 31:
							((global::DevComponents.WpfEditors.Primitives.HourPeriodInput)dependencyObject2).HourInput = (global::DevComponents.WpfEditors.Primitives.NumericHourInput)this.e;
							num = (short)1645936677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.Year)
							{
								num = (short)1497694229;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)779616270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)1634402310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.Hour)
							{
								num = (short)1699414042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)126943260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							if (this.e is global::DevComponents.WpfEditors.Primitives.NumericHourInput)
							{
								num = (short)342818825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 36:
							this.g = dateTimePartInput;
							num = (short)1764360195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							goto IL_9A3;
						case 38:
							if (!enumerator.MoveNext())
							{
								num = (short)707199009;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							dependencyObject2 = enumerator.Current;
							num = (short)857800721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A4;
						IL_9A3:
						dateTimePartInput = (dependencyObject2 as global::DevComponents.WpfEditors.Primitives.IDateTimePartInput);
						num = (short)600178715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BDE:
						num = (short)648806422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C41:
						num = (short)497745958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6A4:
						goto IL_C41;
					}
					IL_D4F:;
				}
				finally
				{
					num = (short)122991788;
					short num4 = num;
					num = (short)1965733036;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_DD2:
						if (enumerator == null)
						{
							goto IL_E09;
						}
						num = (short)1608581120;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1250230272;
						if (num != 0)
						{
						}
						num = (short)1775697921;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1706098690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DD2;
							}
							continue;
						case 2:
							goto IL_E07;
						}
						goto IL_DD2;
					}
					IL_E07:
					IL_E09:;
				}
				IL_E0A:
				this.c();
				this.d();
				this.a();
				return;
			}
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00072284 File Offset: 0x00070484
		protected override void OnChildInputChanged(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)1699282944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				for (;;)
				{
					IL_1E:
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					global::DevComponents.WpfEditors.Primitives.EditorInputBase editorInputBase;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							if (!this.l)
							{
								num = (short)1182924804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1301;
						case 1:
							num = (short)1885732864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!this.k)
							{
								num = (short)909115395;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1301;
						case 3:
						{
							num = (short)173186003;
							short num3 = num;
							num = (short)811310035;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E;
							default:
								num = (short)1276182528;
								if (num != 0)
								{
								}
								try
								{
									switch (0)
									{
									case 0:
										goto IL_278;
									}
									for (;;)
									{
										IL_C5:
										switch (num2)
										{
										case 0:
											goto IL_C84;
										case 1:
											this.e.Value = new int?(0);
											num = (short)1154154505;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
										{
											int? value;
											int num4;
											if (value.GetValueOrDefault() == num4 & value != null)
											{
												num = (short)1890910299;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_103A;
										}
										case 3:
											if (this.f != null)
											{
												num = (short)241762357;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_1107;
										case 4:
											num = (short)251723817;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
										{
											int? value;
											if (value == null)
											{
												num = (short)155189258;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_114A;
										}
										case 6:
											if (this.d != null)
											{
												num = (short)239992863;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_7E5;
										case 7:
											this.c.Value = new int?(this.MaxDate.Month);
											num = (short)400293961;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
											goto IL_65E;
										case 9:
											goto IL_EE7;
										case 10:
											goto IL_61E;
										case 11:
											num = (short)1135673372;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 12:
											if (this.DefaultInputValues)
											{
												num = (short)758906934;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_303;
										case 13:
											goto IL_A8F;
										case 14:
										{
											int? value = this.f.Value;
											num = (short)1310326846;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 15:
										{
											int? value;
											if (value == null)
											{
												num = (short)735051825;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_114A;
										}
										case 16:
										{
											int? value = this.c.Value;
											num = (short)1961361487;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 17:
											goto IL_114A;
										case 18:
											if (this.d != null)
											{
												num = (short)1905786906;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_55B;
										case 19:
											if (this.g != null)
											{
												num = (short)1197801514;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_65E;
										case 20:
										{
											int? value = this.e.Value;
											num = (short)112918591;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 21:
										{
											int? value;
											if (value == null)
											{
												num = (short)1313472549;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_65E;
										}
										case 22:
											goto IL_1203;
										case 23:
											num = (short)1944322091;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 24:
										{
											int? value;
											if (value == null)
											{
												num = (short)69992487;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_EE7;
										}
										case 25:
										{
											int? value = this.d.Value;
											int num4 = this.MaxDate.Year;
											num = (short)770637899;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 26:
										{
											int? value = this.d.Value;
											num = (short)1015087136;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 27:
											if (this.h != null)
											{
												num = (short)1983709219;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_ACF;
										case 28:
											if (this.e != null)
											{
												num = (short)39190617;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_EE7;
										case 29:
											if (editorInputBase == this.d)
											{
												num = (short)1455685691;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_116B;
										case 30:
											if (editorInputBase != this.e)
											{
												num = (short)818479115;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_EE7;
										case 31:
										{
											int? value = this.d.Value;
											num = (short)1532821585;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 32:
										{
											int? value;
											if (value == null)
											{
												num = (short)852295703;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_55B;
										}
										case 33:
											if (editorInputBase != this.g)
											{
												num = (short)1353908311;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_65E;
										case 34:
										{
											int? value = this.d.Value;
											int num4 = this.MaxDate.Year;
											num = (short)1560346718;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 35:
											this.i();
											num = (short)548470850;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 36:
											if (this.e != null)
											{
												num = (short)1873674260;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_E0B;
										case 37:
											num = (short)290062383;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 38:
											this.h();
											num = (short)273219677;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 39:
											num = (short)1635057741;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 40:
											num = (short)434700370;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 41:
											if (this.d != null)
											{
												num = (short)1191968793;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_103A;
										case 42:
										{
											int? value = this.g.Value;
											num = (short)1230831637;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 43:
											if (this.DefaultInputValues)
											{
												num = (short)99090489;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_55B;
										case 44:
											if (this.a != null)
											{
												num = (short)1892352038;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_116B;
										case 45:
											if (editorInputBase != this.f)
											{
												num = (short)706936872;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_303;
										case 46:
											goto IL_303;
										case 47:
											if (this.DefaultInputValues)
											{
												num = (short)1877213255;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_65E;
										case 48:
											num = (short)704118834;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 49:
											goto IL_1107;
										case 50:
											if (this.d != null)
											{
												num = (short)989462562;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_76B;
										case 51:
											if (this.c != null)
											{
												num = (short)2096627792;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_A8F;
										case 52:
											if (this.a != null)
											{
												num = (short)814284865;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_61E;
										case 53:
										{
											int? value = this.f.Value;
											num = (short)472645647;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 54:
											this.f.Value = new int?(0);
											num = (short)251920430;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 55:
											if (this.DefaultInputValues)
											{
												num = (short)231931952;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_BA4;
										case 56:
											if (editorInputBase != this.d)
											{
												num = (short)1147732066;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_55B;
										case 57:
											this.d.Value = new int?(global::System.Math.Min(global::System.DateTime.Now.Year, this.MaxDate.Year));
											num = (short)482541671;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 58:
										{
											int? value = this.g.Value;
											num = (short)713228362;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 59:
											goto IL_B12;
										case 60:
										{
											int? value;
											if (value == null)
											{
												num = (short)677052429;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_114A;
										}
										case 61:
											if (this.g != null)
											{
												num = (short)1861812282;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_11DA;
										case 62:
										{
											int? value;
											if (value == null)
											{
												num = (short)244056149;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_303;
										}
										case 63:
										{
											int? value;
											if (value == null)
											{
												num = (short)964952134;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_114A;
										}
										case 64:
											goto IL_BA4;
										case 65:
										{
											int? value = this.a.Value;
											num = (short)967835653;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 66:
											goto IL_ACF;
										case 67:
											if (this.c != null)
											{
												num = (short)1018036240;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_C84;
										case 68:
											if (editorInputBase != this.a)
											{
												num = (short)1980956758;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_97B;
										case 69:
										{
											int? value = this.c.Value;
											int num4 = this.MaxDate.Month;
											num = (short)166002690;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 70:
											goto IL_E0B;
										case 71:
											this.g.Value = new int?(0);
											num = (short)1831206920;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 72:
											num = (short)1551695927;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 73:
											goto IL_BA4;
										case 74:
										{
											int? value;
											if (value != null)
											{
												num = (short)885719057;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_11DA;
										}
										case 75:
										{
											int? value;
											int num4;
											if (value.GetValueOrDefault() == num4 & value != null)
											{
												num = (short)603324522;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_103A;
										}
										case 76:
											num = (short)45875227;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 77:
											if (this.DefaultInputValues)
											{
												num = (short)1210580993;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_EE7;
										case 78:
										{
											int? value;
											if (value == null)
											{
												num = (short)1208942694;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_97B;
										}
										case 79:
										{
											int? value;
											if (value == null)
											{
												num = (short)784203848;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_C84;
										}
										case 80:
										{
											int? value = this.c.Value;
											num = (short)774701116;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 81:
										{
											int? value;
											if (value == null)
											{
												num = (short)1212153948;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_114A;
										}
										case 82:
											if (this.f != null)
											{
												num = (short)307232782;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_303;
										case 83:
											num = (short)1926365251;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 84:
										{
											int? value = this.a.Value;
											num = (short)2116616270;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 85:
											num = (short)79495180;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 86:
											num = (short)242024536;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 87:
											num = (short)201785363;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 88:
											if (this.a != null)
											{
												num = (short)2111963220;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_97B;
										case 89:
										{
											int? value = this.e.Value;
											num = (short)7143448;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 90:
											num = (short)2038562845;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 91:
											this.a.Value = new int?(this.MaxDate.Day);
											num = (short)2054881379;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 92:
											goto IL_7E5;
										case 93:
											goto IL_116B;
										case 94:
										{
											int? value;
											int num4;
											if (value.GetValueOrDefault() == num4 & value != null)
											{
												num = (short)669646855;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_76B;
										}
										case 95:
											if (this.DefaultInputValues)
											{
												num = (short)1513816068;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_97B;
										case 96:
											if (editorInputBase != this.c)
											{
												num = (short)340066394;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_B12;
										case 97:
											if (editorInputBase == this.d)
											{
												num = (short)116457548;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_ACF;
										case 98:
											num = (short)465436690;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 99:
											goto IL_97B;
										case 100:
											if (this.c != null)
											{
												num = (short)300613701;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_103A;
										case 101:
											goto IL_97B;
										case 102:
											num = (short)232456287;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 103:
											goto IL_55B;
										case 104:
											goto IL_11DA;
										case 105:
											if (editorInputBase != this.c)
											{
												num = (short)337051731;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_C84;
										case 106:
											num = (short)677904484;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_278;
										IL_303:
										num = (short)748748833;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_55B:
										num = (short)255721577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_61E:
										num = (short)328138788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_65E:
										num = (short)943128582;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_76B:
										this.c.Value = new int?(global::System.DateTime.Now.Month);
										num = (short)768409664;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_7E5:
										num = (short)874184755;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_97B:
										num = (short)718077982;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_A8F:
										num = (short)338690100;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_ACF:
										num = (short)1555759160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_B12:
										num = (short)304152620;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_BA4:
										this.h();
										num = (short)1952382976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_C84:
										num = (short)1670185028;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_E0B:
										num = (short)629276675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_EE7:
										num = (short)1478623277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_103A:
										this.a.Value = new int?(global::System.DateTime.Now.Day);
										num = (short)1439694949;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_1107:
										num = (short)1032454205;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_114A:
										base.IsEmpty = false;
										num = (short)91881576;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_116B:
										num = (short)1148256353;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_11DA:
										this.a(editorInputBase);
										this.UpdateValue(false, false);
										num = (short)889651222;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1203:
									goto IL_1301;
									IL_278:
									this.i = true;
									num = (short)1912733792;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_C5;
								}
								finally
								{
									this.i = false;
								}
								goto IL_1210;
							}
							break;
						}
						case 4:
							num = (short)2106130433;
							if (num != 0)
							{
							}
							goto IL_1210;
						case 5:
						{
							num = (short)1778515968;
							short num5 = num;
							if (!this.i)
							{
								num = (short)1453588481;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1301;
						}
						}
						break;
						IL_1210:
						num = (short)1671823362;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_47:
					editorInputBase = (eventArgs.OriginalSource as global::DevComponents.WpfEditors.Primitives.EditorInputBase);
					num = (short)1867382789;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				IL_1301:
				base.OnChildInputChanged(eventArgs);
				return;
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000735B8 File Offset: 0x000717B8
		private void i()
		{
			short num = (short)1593966596;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)549388294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					int? value = this.d.Value;
					num = (short)2087518213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				case 3:
				{
					global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput = this.h;
					global::System.Globalization.Calendar calendar = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().Calendar;
					int? value = this.d.Value;
					dateTimePartInput.MaxValue = calendar.GetDaysInYear(value.Value);
					num = (short)492437506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)714176182;
					short num3 = num;
					num = (short)1716680374;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BE;
					default:
						num = (short)1410990081;
						if (num != 0)
						{
						}
						num = (short)243531776;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					}
					break;
				}
				case 5:
				{
					int? value;
					if (value != null)
					{
						num = (short)350879744;
						short num4 = num;
						num = (short)134086656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 6:
					if (this.h != null)
					{
						num = (short)1288896515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_B3;
				IL_BE:
				num = (short)615645185;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B3:
				if (this.d != null)
				{
					goto IL_BE;
				}
				break;
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0007379C File Offset: 0x0007199C
		protected override void OnFocusedItemChanged(global::DevComponents.WpfEditors.Primitives.EditorElement previousFocus)
		{
			short num = (short)1792737280;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 1:
					goto IL_93;
				case 2:
					goto IL_15C;
				case 3:
					num = (short)800129031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)930217985;
					if (num != 0)
					{
					}
					if (previousFocus != this.d)
					{
						num = (short)1694236675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78;
				case 5:
					this.h();
					num = (short)802881545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_78;
				case 7:
				{
					num = (short)559049361;
					short num3 = num;
					num = (short)1893165713;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1589248000;
						if (num != 0)
						{
						}
						if (previousFocus == this.a)
						{
							num = (short)1457389574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(previousFocus);
						num = (short)1595277314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					num = (short)1354366986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_17E;
				case 10:
					if (this.a is global::DevComponents.WpfEditors.Primitives.NumericDayInput)
					{
						num = (short)1971978245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98;
				}
				IL_50:
				if (base.FocusedItem == this.a)
				{
					num = (short)515833864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_98;
				IL_78:
				this.h();
				num = (short)2019426305;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_98:
				num = (short)994836484;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_93:
			IL_15C:
			goto IL_238;
			IL_17E:
			num = (short)242810880;
			short num4 = num;
			IL_238:
			base.OnFocusedItemChanged(previousFocus);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000739E8 File Offset: 0x00071BE8
		private void h()
		{
			short num = (short)1170079745;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a != null)
					{
						num = (short)1219821582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 2:
					if (this.d != null)
					{
						num = (short)1168506891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)1526333449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_198;
				case 5:
					return;
				case 6:
					if (this.a is global::DevComponents.WpfEditors.Primitives.NumericDayInput)
					{
						num = (short)532873220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_319;
				case 7:
				{
					num = (short)1835377359;
					short num3 = num;
					num = (short)964862671;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_269;
					default:
						num = (short)1292304384;
						if (num != 0)
						{
						}
						num = (short)1788346368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
				{
					int? value = this.c.Value;
					num = (short)1434910732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					num = (short)856948737;
					if (num != 0)
					{
					}
					if (base.FocusedItem == this.a)
					{
						num = (short)1904476175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_319;
				case 10:
				{
					num = (short)1259339776;
					short num4 = num;
					if (this.c != null)
					{
						num = (short)1800601608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 11:
					goto IL_269;
				case 12:
				{
					int? value;
					if (value != null)
					{
						num = (short)138280967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 13:
				{
					global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput = this.a;
					int? value = this.d.Value;
					int year;
					if (value != null)
					{
						value = this.d.Value;
						year = value.Value;
					}
					else
					{
						year = global::System.DateTime.Now.Year;
					}
					value = this.c.Value;
					dateTimePartInput.MaxValue = global::System.DateTime.DaysInMonth(year, value.Value);
					num = (short)311427077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					num = (short)214827021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)1331691526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_64:
				if (this.a != null)
				{
					num = (short)934608899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_319;
				IL_269:
				num = (short)560136202;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_319:
				num = (short)1040384002;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_198:
			this.a.MaxValue = 31;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00073D4C File Offset: 0x00071F4C
		protected override void HandleInputComplete(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)551699712;
			short num2 = num;
			num = (short)988955904;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1741094912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)923795457;
			if (num != 0)
			{
			}
			num = (short)90243072;
			if (num != 0)
			{
			}
			this.a(base.FocusedItem ?? (e.OriginalSource as global::DevComponents.WpfEditors.Primitives.EditorElement));
			base.HandleInputComplete(e);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00073E1C File Offset: 0x0007201C
		protected override bool ValidateInput(global::DevComponents.WpfEditors.Primitives.EditorElement inputItem)
		{
			short num = (short)1230635008;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 1:
					try
					{
						this.j = true;
						global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput;
						dateTimePartInput.UndoInput();
						return false;
					}
					finally
					{
						this.j = false;
					}
					goto IL_8A;
				case 2:
				{
					global::System.DateTime t;
					if (t > this.MaxDate)
					{
						num = (short)63897609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_258;
				}
				case 3:
				{
					global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput = (global::DevComponents.WpfEditors.Primitives.IDateTimePartInput)inputItem;
					global::System.DateTime t = this.e();
					num = (short)1074266112;
					short num3 = num;
					num = (short)453574663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (!base.IsEmpty)
					{
						num = (short)1318387715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_258;
				case 5:
					num = (short)1127743492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)346161154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1588572802;
					short num4 = num;
					num = (short)1467200130;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1225392128;
						if (num != 0)
						{
						}
						global::System.DateTime t;
						if (!(t < this.MinDate))
						{
							num = (short)1661927425;
							if (num != 0)
							{
							}
							num = (short)313196550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A;
					}
					}
					break;
				}
				case 8:
					num = (short)1481703434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_8A;
				case 10:
					if (inputItem is global::DevComponents.WpfEditors.Primitives.IDateTimePartInput)
					{
						num = (short)237699077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_258;
				}
				IL_51:
				if (!this.j)
				{
					num = (short)2098855944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_258;
				IL_8A:
				num = (short)140181505;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_258:
			return base.ValidateInput(inputItem);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00074098 File Offset: 0x00072298
		private void a(global::DevComponents.WpfEditors.Primitives.EditorElement A_0)
		{
			short num = (short)13828096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FB;
				}
				global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput3;
				for (;;)
				{
					IL_28:
					int? value;
					global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput;
					int num5;
					switch (num2)
					{
					case 0:
						if (value != null)
						{
							num = (short)1635582000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EC;
					case 1:
						try
						{
							num = (short)765067265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.DateTime dateTime;
								switch (num2)
								{
								case 0:
									goto IL_658;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_548;
									}
									continue;
								case 2:
									goto IL_658;
								case 3:
									goto IL_683;
								case 4:
								{
									num = (short)915511033;
									short num3 = num;
									num = (short)1174836985;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)1564606464;
										if (num != 0)
										{
										}
										value = this.d.Value;
										int value2 = value.Value;
										value = this.h.Value;
										dateTime = global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a(value2, value.Value);
										break;
									}
									}
									num = (short)941096962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_548:
								if (this.h != null)
								{
									num = (short)213319684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								value = this.d.Value;
								int value3 = value.Value;
								value = this.c.Value;
								int value4 = value.Value;
								value = this.a.Value;
								dateTime = new global::System.DateTime(value3, value4, value.Value);
								num = (short)1558446080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_658:
								dateTimePartInput.Value = new int?((int)dateTime.DayOfWeek);
								num = (short)749731843;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_683:
							goto IL_9EC;
						}
						catch
						{
							global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput2 = dateTimePartInput;
							value = null;
							dateTimePartInput2.Value = value;
							goto IL_9EC;
						}
						goto IL_69D;
					case 2:
						num = (short)1613299758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_7A1;
					case 4:
						num = (short)232783882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1358757894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.c != null)
						{
							num = (short)1754267670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69D;
					case 7:
						if (this.d != null)
						{
							num = (short)1714225177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_300;
					case 8:
						goto IL_226;
					case 9:
						if (dateTimePartInput != null)
						{
							num = (short)237436932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EC;
					case 10:
						if (dateTimePartInput.Part == dateTimePartInput3.Part)
						{
							num = (short)1805975554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E9;
					case 11:
						goto IL_69D;
					case 12:
					{
						num = (short)84148224;
						short num4 = num;
						num = (short)171114503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_9EC;
					case 14:
						if (value != null)
						{
							num = (short)403832873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69D;
					case 15:
						goto IL_3B1;
					case 16:
						if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.Month)
						{
							num = (short)301924394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EC;
					case 17:
						value = this.d.Value;
						num = (short)322174976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)644087841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)262733850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						value = this.h.Value;
						num = (short)1575026718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (value != null)
						{
							num = (short)189661189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_300;
					case 22:
						value = this.c.Value;
						num = (short)36700174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_3B1;
					case 24:
						value = this.a.Value;
						num = (short)1562902562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						value = this.d.Value;
						num = (short)478281749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (dateTimePartInput3.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.DayOfYear)
						{
							num = (short)1692532768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 27:
						if (this.a != null)
						{
							num = (short)102957080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69D;
					case 28:
						if (this.h != null)
						{
							num = (short)1939865620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_300;
					case 29:
						if (dateTimePartInput3 == null)
						{
							num = (short)650969133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 0;
						num = (short)1208614927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (value != null)
						{
							num = (short)76414984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_300;
					case 31:
						if (dateTimePartInput.Part != global::DevComponents.WpfEditors.Primitives.eDateTimePart.Day)
						{
							num = (short)1985347602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A1;
					case 32:
						num = (short)101777439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.Month)
						{
							num = (short)1045102595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 34:
						if (value == null)
						{
							num = (short)1170276363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_226;
					case 35:
						if (dateTimePartInput != dateTimePartInput3)
						{
							num = (short)1020133395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 36:
						goto IL_9EC;
					case 37:
						dateTimePartInput.Value = dateTimePartInput3.Value;
						num = (short)686620708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_9EC;
					case 39:
						if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.Day)
						{
							num = (short)1041956911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1104740368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (this.d != null)
						{
							num = (short)542179345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EC;
					case 41:
						num = (short)1832976411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						global::System.DateTime dateTime2;
						dateTimePartInput.Value = new int?(dateTime2.Month);
						num = (short)1954807851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_9EC;
					case 44:
						return;
					case 45:
						return;
					case 46:
						if (dateTimePartInput != dateTimePartInput3)
						{
							num = (short)483524645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E9;
					case 47:
					{
						global::System.DateTime dateTime2;
						dateTimePartInput.Value = new int?(dateTime2.Day);
						num = (short)77660198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
					{
						value = this.d.Value;
						int value5 = value.Value;
						value = dateTimePartInput3.Value;
						global::System.DateTime dateTime2 = global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a(value5, value.Value);
						num = (short)1631846439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.DayName)
						{
							num = (short)29949964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EC;
					case 50:
						if (num5 >= base.Items.Count)
						{
							num = (short)1433600044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dateTimePartInput = (base.Items[num5] as global::DevComponents.WpfEditors.Primitives.IDateTimePartInput);
						num = (short)346619913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FB;
					IL_1E9:
					num = (short)1260453923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_226:
					num = (short)1277100033;
					if (num != 0)
					{
					}
					num = (short)1969094657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_300:
					global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput4 = dateTimePartInput;
					value = null;
					dateTimePartInput4.Value = value;
					num = (short)1055981581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32C:
					num = (short)1567162417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B1:
					num = (short)1261830194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69D:
					num = (short)1628176412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A1:
					num = (short)1012006952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9EC:
					num5++;
					num = (short)1001127959;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_FB:
				dateTimePartInput3 = (A_0 as global::DevComponents.WpfEditors.Primitives.IDateTimePartInput);
				num = (short)181600285;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00074AD0 File Offset: 0x00072CD0
		internal static global::System.DateTime a(int A_0, int A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.DateTime result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					num2 = (short)1502182433;
					short num3 = num2;
					num2 = (short)134446113;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_102;
					default:
						num2 = (short)2024865792;
						if (num2 != 0)
						{
						}
						if (A_1 > 0)
						{
							num2 = (short)606666754;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 2:
				{
					num2 = (short)594280448;
					short num4 = num2;
					num2 = (short)447283201;
					if (num2 != 0)
					{
					}
					result.AddDays((double)(A_1 - 1));
					goto IL_102;
				}
				}
				goto IL_1C;
				IL_102:
				num2 = (short)784990208;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			result = new global::System.DateTime(A_0, 1, 1);
			num2 = (short)528154625;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00074BFC File Offset: 0x00072DFC
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1528427790;
			short num2 = num;
			num = (short)1653077262;
			switch (num2 == num)
			{
			}
			num = (short)976879616;
			short num3 = num;
			num = (short)738263041;
			if (num != 0)
			{
			}
			num = (short)1404895232;
			if (num != 0)
			{
			}
			this.UpdateValue(false, true);
			base.OnLostFocus(e);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00074CB4 File Offset: 0x00072EB4
		protected override void OnGroupInputComplete()
		{
			short num = (short)334224560;
			short num2 = num;
			num = (short)1242619056;
			switch (num2 == num)
			{
			}
			num = (short)1854406656;
			short num3 = num;
			num = (short)1823997953;
			if (num != 0)
			{
			}
			num = (short)1401225216;
			if (num != 0)
			{
			}
			this.UpdateValue(false, true);
			base.OnGroupInputComplete();
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00074D6C File Offset: 0x00072F6C
		protected internal void UpdateValue(bool updateDirect, bool enforceMinMax)
		{
			short num = (short)1190789120;
			short num2 = num;
			num = (short)1541235927;
			short num3 = num;
			num = (short)1351509207;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)971112448;
				if (num != 0)
				{
				}
				num = (short)1878130688;
				switch (num)
				{
				}
				break;
			}
			global::System.DateTime dateTime = global::System.DateTime.Now;
			this.k = true;
			try
			{
				num = (short)358285379;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					global::System.DateTime? value2;
					switch (num4)
					{
					case 0:
						goto IL_742;
					case 1:
						num = (short)1974468611;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						flag = false;
						num = (short)1088749636;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.f != null)
						{
							num = (short)548143165;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					case 4:
						this.UpdateIsEmpty();
						num = (short)1222311968;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_B32;
					case 6:
					{
						int? value;
						if (value != null)
						{
							num = (short)522649671;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB5;
					}
					case 7:
					{
						int? value;
						if (value == null)
						{
							num = (short)933036104;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					}
					case 8:
					{
						int? value;
						if (value != null)
						{
							num = (short)1129513033;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB5;
					}
					case 9:
						if (dateTime < this.MinDate)
						{
							num = (short)221118474;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 10:
						dateTime = this.MinDate;
						num = (short)788922396;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)259457078;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1752563759;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						int? value;
						if (value != null)
						{
							num = (short)877133854;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB5;
					}
					case 14:
						if (this.c != null)
						{
							num = (short)1098907711;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					case 15:
					{
						int? value;
						if (value == null)
						{
							num = (short)1728446464;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					}
					case 16:
						goto IL_68B;
					case 17:
						goto IL_36C;
					case 18:
						goto IL_DAA;
					case 19:
					{
						int? value = this.e.Value;
						num = (short)1951858729;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						int? value;
						if (value == null)
						{
							num = (short)1911160861;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					}
					case 21:
						if (this.c != null)
						{
							num = (short)619839539;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_895;
					case 22:
						num = (short)1436745768;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (value2 != null)
						{
							num = (short)1203699745;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B;
					case 24:
					{
						int? value;
						if (value == null)
						{
							num = (short)785580076;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					}
					case 25:
						if (this.e != null)
						{
							num = (short)906690571;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_404;
					case 26:
						this.UpdateIsEmpty();
						num = (short)1589051480;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_E51;
					case 28:
						goto IL_36C;
					case 29:
						goto IL_B73;
					case 30:
						goto IL_C3A;
					case 31:
						if (flag)
						{
							num = (short)826540087;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E39;
					case 32:
						goto IL_6AF;
					case 33:
					{
						value2 = this.Value;
						global::System.TimeSpan timeSpan = value2.Value.Subtract(dateTime);
						num = (short)1922695218;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						if (this.g != null)
						{
							num = (short)2072576074;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B32;
					case 35:
					{
						int? value = this.a.Value;
						num = (short)710934536;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						if (this.f != null)
						{
							num = (short)730660934;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32C;
					case 37:
						if (this.a != null)
						{
							num = (short)1597636666;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					case 38:
						goto IL_E39;
					case 39:
						if (!this.DefaultInputValues)
						{
							num = (short)1854144524;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_782;
					case 40:
						if (this.d != null)
						{
							num = (short)58589260;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3A;
					case 41:
					{
						int? value;
						if (value != null)
						{
							num = (short)110231570;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB5;
					}
					case 42:
						goto IL_814;
					case 43:
						if (this.g != null)
						{
							num = (short)312934462;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_782;
					case 44:
						goto IL_AD0;
					case 45:
					{
						int? value;
						if (value == null)
						{
							num = (short)1051066410;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					}
					case 46:
						if (this.f != null)
						{
							num = (short)316538881;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_814;
					case 47:
						if (!base.IsKeyboardFocusWithin)
						{
							num = (short)900399126;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_782;
					case 48:
						num = (short)1546125326;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						int? value;
						if (value == null)
						{
							num = (short)173211712;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_782;
					}
					case 50:
					{
						global::System.TimeSpan timeSpan;
						if (global::System.Math.Abs(timeSpan.TotalSeconds) < 1.0)
						{
							num = (short)1583677442;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B;
					}
					case 51:
					{
						int? value = this.c.Value;
						num = (short)1426522118;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						num = (short)1089732677;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (this.a != null)
						{
							num = (short)1435500603;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_742;
					case 54:
						if (this.e != null)
						{
							num = (short)113049687;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					case 55:
						this.Value = new global::System.DateTime?(dateTime);
						num = (short)450953254;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (this.HasNestedGroups)
						{
							num = (short)1315307546;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ResetValue();
						num = (short)254541910;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (this.d != null)
						{
							num = (short)2131361871;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					case 58:
					{
						int? value = this.a.Value;
						num = (short)1017315343;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						num = (short)1593507877;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (this.e != null)
						{
							num = (short)2138767379;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DAA;
					case 61:
					{
						int? value = this.f.Value;
						num = (short)183173165;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
					{
						int? value = this.g.Value;
						num = (short)378994737;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
					{
						int? value = this.c.Value;
						num = (short)46006292;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						goto IL_BB5;
					case 65:
						dateTime = this.MaxDate;
						num = (short)1687748625;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (this.c != null)
						{
							num = (short)2029781040;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B73;
					case 67:
						switch (0)
						{
						case 0:
							goto IL_22E;
						}
						continue;
					case 68:
						goto IL_48B;
					case 69:
						if (dateTime > this.MaxDate)
						{
							num = (short)970129473;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)700973065;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
					{
						int? value = this.f.Value;
						num = (short)1996095568;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						goto IL_895;
					case 72:
						goto IL_404;
					case 73:
						goto IL_CCA;
					case 74:
						num = (short)1598357586;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						if (this.a != null)
						{
							num = (short)1210318883;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CCA;
					case 76:
					{
						int? value = this.d.Value;
						num = (short)1646460941;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 77:
						if (enforceMinMax)
						{
							num = (short)636944436;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 78:
						if (this.HasNestedGroups)
						{
							num = (short)412024836;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ResetValue();
						num = (short)2143617040;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
					{
						int? value = this.d.Value;
						num = (short)678821912;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 80:
					{
						int? value;
						if (value != null)
						{
							num = (short)1323761745;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB5;
					}
					case 81:
						goto IL_32C;
					case 82:
						if (this.g != null)
						{
							num = (short)918683733;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					case 83:
						num = (short)1587216441;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						int? value;
						if (value == null)
						{
							num = (short)1955463173;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					}
					case 85:
					{
						int? value = this.g.Value;
						num = (short)1175453780;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 86:
						goto IL_9D2;
					case 87:
					{
						int? value = this.e.Value;
						num = (short)1702035463;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 88:
						goto IL_668;
					}
					IL_22E:
					if (this.d != null)
					{
						num = (short)151650387;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AD0;
					IL_32C:
					num = (short)821231659;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_36C:
					flag = true;
					value2 = this.Value;
					num = (short)1958608919;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_404:
					num = (short)1040777262;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_48B:
					num = (short)2108096543;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C7:
					num = (short)829095975;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_742:
					num = (short)1833893913;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_782:
					dateTime = this.e();
					num = (short)2142896205;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_814:
					num = (short)1202782242;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_895:
					num = (short)120389707;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD0:
					num = (short)1228603458;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_B32:
					num = (short)212402254;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_B73:
					num = (short)91029557;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB5:
					num = (short)890044472;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_C3A:
					num = (short)1838350357;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_CCA:
					num = (short)1714552892;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_DAA:
					num = (short)2099773476;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E39:
					num = (short)1556152347;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_668:
				IL_68B:
				IL_6AF:
				IL_9D2:
				IL_E51:;
			}
			finally
			{
				num = (short)1373437953;
				if (num != 0)
				{
				}
				this.k = false;
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00075C18 File Offset: 0x00073E18
		private bool g()
		{
			int num;
			global::System.DateTime t;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!(t < this.MinDate))
						{
							num2 = (short)2043674625;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 1:
						num2 = (short)712441859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_13D;
					case 3:
					{
						num2 = (short)499187712;
						short num3 = num2;
						if (!(t > this.MaxDate))
						{
							return true;
						}
						num2 = (short)1300102676;
						short num4 = num2;
						num2 = (short)1881406996;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
							num2 = (short)1961558017;
							if (num2 != 0)
							{
							}
							num2 = (short)15794176;
							if (num2 != 0)
							{
							}
							num2 = (short)763756546;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_20;
				}
				return false;
				IL_13D:
				return false;
			}
			IL_20:
			t = this.e();
			IL_27:
			num2 = (short)1751646208;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00075D68 File Offset: 0x00073F68
		private bool HasNestedGroups
		{
			get
			{
				global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
				short num;
				bool result;
				try
				{
					num = (short)2092957702;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_DE;
						case 1:
							if (((global::System.Windows.UIElement)enumerator.Current) is global::DevComponents.WpfEditors.Primitives.EditorGroup)
							{
								num = (short)1865678853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 2:
							num = (short)872677380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)1666711554;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1858011137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_FB;
						case 5:
							result = true;
							num = (short)1284046848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_52;
							}
							continue;
						}
						IL_54:
						num = (short)874774531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_52:
						goto IL_54;
					}
					IL_DE:
					goto IL_1E8;
					IL_FB:
					num = (short)1363869697;
					if (num != 0)
					{
					}
					return false;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_143;
					}
					int num2;
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_131:
						switch (num2)
						{
						case 0:
							goto IL_1E5;
						case 1:
						{
							num = (short)424869032;
							short num3 = num;
							num = (short)263126184;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)340131840;
								if (num != 0)
								{
								}
								disposable.Dispose();
								break;
							}
							num = (short)247529472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (disposable != null)
							{
								num = (short)1082327041;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E7;
						}
						goto IL_143;
					}
					IL_1E5:
					IL_1E7:
					goto EndFinally_6;
					IL_143:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)585826306;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_131;
					EndFinally_6:;
				}
				IL_1E8:
				num = (short)632881152;
				short num4 = num;
				return result;
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00075FA4 File Offset: 0x000741A4
		private global::System.DateTime e()
		{
			short num = (short)764411904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_103;
				}
				int num3;
				int num4;
				int month2;
				int hour;
				global::System.DateTime dateTime;
				global::System.DateTime? value2;
				int minute;
				int second;
				for (;;)
				{
					IL_28:
					global::System.DateTime dateTime2;
					int num7;
					switch (num2)
					{
					case 0:
					{
						int? value;
						if (value != null)
						{
							num = (short)112066590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E8;
					}
					case 1:
						if (num3 < 30)
						{
							num = (short)471990305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)648151082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int? value;
						if (value != null)
						{
							num = (short)694222897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					}
					case 3:
						goto IL_25C;
					case 4:
					{
						int val = num4;
						int? value = this.d.Value;
						int year;
						if (value != null)
						{
							value = this.d.Value;
							year = value.Value;
						}
						else
						{
							year = global::System.DateTime.Now.Year;
						}
						value = this.c.Value;
						int month;
						if (value != null)
						{
							value = this.c.Value;
							month = value.Value;
						}
						else
						{
							month = global::System.DateTime.Now.Month;
						}
						num4 = global::System.Math.Min(val, global::System.DateTime.DaysInMonth(year, month));
						num = (short)2055864360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_4A6;
					case 6:
						if (this.a != null)
						{
							num = (short)1288503296;
							short num5 = num;
							num = (short)1464926229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62A;
					case 7:
						goto IL_9D7;
					case 8:
					{
						int? value = this.c.Value;
						month2 = value.Value;
						num = (short)1737162757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_3F0;
					case 10:
					{
						int? value = this.e.Value;
						num = (short)1099563033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int? value = this.e.Value;
						hour = value.Value;
						num = (short)1975451699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						dateTime = this.MinDate;
						num = (short)216137765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_3F0;
					case 14:
						if (this.e != null)
						{
							num = (short)638058506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E4;
					case 15:
					{
						int? value;
						if (value != null)
						{
							num = (short)1036648482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D9;
					}
					case 16:
					{
						int? value;
						if (value != null)
						{
							num = (short)1098645540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A2;
					}
					case 17:
						dateTime = this.MaxDate;
						goto IL_240;
					case 18:
					{
						num = (short)1745066800;
						short num6 = num;
						num = (short)2112592688;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_240;
						default:
							num = (short)630390784;
							if (num != 0)
							{
							}
							goto IL_7E8;
						}
						break;
					}
					case 19:
						dateTime2 = value2.Value;
						goto IL_190;
					case 20:
						if (this.d != null)
						{
							num = (short)1079902247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					case 21:
					{
						int? value = this.a.Value;
						num = (short)588316703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						int? value = this.a.Value;
						num4 = value.Value;
						num = (short)605356036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						if (this.c != null)
						{
							num = (short)819134505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A6;
					case 24:
						value2 = this.Value;
						num = (short)786366483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						int? value;
						if (value != null)
						{
							num = (short)1413677067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E4;
					}
					case 26:
					{
						int? value = this.g.Value;
						num = (short)144441360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_8A2;
					case 28:
					{
						global::System.DateTime dateTime3 = global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a(num3, num7);
						month2 = dateTime3.Month;
						num4 = dateTime3.Day;
						num = (short)125894663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (dateTime > this.MaxDate)
						{
							num = (short)648282129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25C;
					case 30:
					{
						int? value = this.f.Value;
						minute = value.Value;
						num = (short)529072146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						int? value;
						if (value != null)
						{
							num = (short)1227882518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62A;
					}
					case 32:
					{
						int? value = this.f.Value;
						num = (short)876871680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						num3 += 2000;
						num = (short)1981808653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						int? value = this.h.Value;
						num7 = value.Value;
						num = (short)775749670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (this.g != null)
						{
							num = (short)1330577434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A2;
					case 36:
					{
						int? value = this.g.Value;
						second = value.Value;
						num = (short)420937755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						goto IL_25C;
					case 38:
						if (num7 > 0)
						{
							num = (short)117178396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D9;
					case 39:
					{
						int? value = this.d.Value;
						num = (short)1781858306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_62A;
					case 41:
					{
						int? value = this.c.Value;
						num = (short)2078933037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						if (num3 < 100)
						{
							num = (short)248447020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					case 43:
						if (dateTime < this.MinDate)
						{
							num = (short)1357119500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1438384157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num3 += 1900;
						num = (short)857866249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						int? value;
						if (value != null)
						{
							num = (short)1048903688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A6;
					}
					case 46:
						if (this.f != null)
						{
							num = (short)254410784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E8;
					case 47:
					{
						int? value = this.h.Value;
						num = (short)740163599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						num = (short)335609857;
						if (num != 0)
						{
						}
						if (this.h != null)
						{
							num = (short)1763049519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D9;
					case 49:
					{
						int? value = this.d.Value;
						num3 = value.Value;
						num = (short)1397489665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						if (value2 != null)
						{
							num = (short)288358424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)368508980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_6E4;
					case 52:
						dateTime2 = global::System.DateTime.Today;
						goto IL_190;
					}
					goto IL_103;
					IL_190:
					dateTime = dateTime2;
					num = (short)1017774123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_240:
					num = (short)1984692227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25C:
					num3 = dateTime.Year;
					month2 = dateTime.Month;
					num4 = dateTime.Day;
					hour = dateTime.Hour;
					minute = dateTime.Minute;
					second = dateTime.Second;
					num7 = dateTime.DayOfYear;
					num = (short)1498415124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F0:
					num = (short)1845559319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A6:
					num = (short)880541702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62A:
					num = (short)1566441486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E4:
					num = (short)49676334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E8:
					num = (short)1642987555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8A2:
					num = (short)1048707120;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9D7:
				IL_9D9:
				dateTime = new global::System.DateTime(num3, month2, num4, hour, minute, second, dateTime.Millisecond);
				return dateTime;
				IL_103:
				value2 = this.Value;
				num = (short)1315962930;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x000769A4 File Offset: 0x00074BA4
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00076CB8 File Offset: 0x00074EB8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.DateTime[] Values
		{
			get
			{
				short num = (short)593559552;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)173539330;
					num2 = (int)((global::System.IntPtr)num);
					global::System.Collections.Generic.List<global::System.DateTime> list;
					for (;;)
					{
						num = (short)1005191168;
						short num3 = num;
						global::System.Collections.IEnumerator enumerator;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1318518790;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)919797765;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfEditors.Primitives.DateTimeGroup;
										num = (short)1163722755;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup;
										list.Add(dateTimeGroup.Value.Value);
										num = (short)1655570432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup;
										if (dateTimeGroup != null)
										{
											num = (short)2099249154;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										goto IL_1CD;
									case 5:
										num = (short)1730871300;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_109;
										}
										continue;
									}
									IL_14C:
									num = (short)688324609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_109:
									goto IL_14C;
								}
								IL_1CD:
								goto IL_2C6;
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
										goto IL_294;
									case 1:
									{
										num = (short)1795503783;
										short num4 = num;
										num = (short)906770087;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1657929728;
											if (num != 0)
											{
											}
											disposable.Dispose();
											break;
										}
										num = (short)1141243904;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										if (disposable != null)
										{
											num = (short)1850605569;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_296;
									}
									goto IL_1EF;
								}
								IL_294:
								IL_296:
								goto EndFinally_7;
								IL_1EF:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1992687618;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1DC;
								EndFinally_7:;
							}
							goto IL_297;
						case 1:
							goto IL_297;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_79;
							}
							continue;
						}
						IL_79:
						if (this.HasNestedGroups)
						{
							num = (short)710606849;
							if (num != 0)
							{
							}
							num = (short)991625217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CD;
						IL_297:
						list = new global::System.Collections.Generic.List<global::System.DateTime>();
						enumerator = base.Items.GetEnumerator();
						num = (short)853016576;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C6:
					return list.ToArray();
					IL_2CD:
					return new global::System.DateTime[]
					{
						this.Value.Value
					};
				}
				}
			}
			set
			{
				short num = (short)15204352;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					num = (short)1714946055;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num3;
						global::System.Collections.IEnumerator enumerator;
						switch (num2)
						{
						case 0:
							goto IL_357;
						case 1:
							if (this.HasNestedGroups)
							{
								num = (short)667549701;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.Value = new global::System.DateTime?(value[0]);
							num = (short)968949763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)1700921352;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1028980741;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (num3 >= value.Length)
										{
											num = (short)164888576;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 2:
									{
										global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup;
										if (dateTimeGroup != null)
										{
											num = (short)1384775683;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
									{
										global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup;
										dateTimeGroup.Value = new global::System.DateTime?(value[num3]);
										num3++;
										num = (short)2089156609;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)16056327;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfEditors.Primitives.DateTimeGroup;
										num = (short)715063298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_E9;
									case 6:
										goto IL_1D6;
									case 7:
										num = (short)1948254214;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										switch (0)
										{
										case 0:
											goto IL_D0;
										}
										continue;
									}
									IL_132:
									num = (short)825163780;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_D0:
									goto IL_132;
								}
								IL_E9:
								IL_1D6:
								return;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_1F8;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1E5:
									switch (num2)
									{
									case 0:
										goto IL_29B;
									case 1:
									{
										num = (short)1949192264;
										short num4 = num;
										num = (short)229462088;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)2008481792;
											if (num != 0)
											{
											}
											disposable.Dispose();
											break;
										}
										num = (short)2113536000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										if (disposable != null)
										{
											num = (short)1527447553;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_29D;
									}
									goto IL_1F8;
								}
								IL_29B:
								IL_29D:
								goto EndFinally_10;
								IL_1F8:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1232404482;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1E5;
								EndFinally_10:;
							}
							goto IL_29E;
						case 3:
							goto IL_2F4;
						case 4:
							num = (short)1682767878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)427884545;
							if (num != 0)
							{
							}
							goto IL_29E;
						case 6:
							if (value.Length == 0)
							{
								num = (short)1998454784;
								short num5 = num;
								num = (short)550109184;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)864026625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_65;
							}
							continue;
						}
						IL_65:
						if (value != null)
						{
							num = (short)1090256900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_29E:
						num3 = 0;
						enumerator = base.Items.GetEnumerator();
						num = (short)402456578;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_2F4:
					return;
					IL_357:
					return;
				}
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000770A4 File Offset: 0x000752A4
		private void d()
		{
			short num = (short)1313144832;
			switch (num)
			{
			default:
			{
				num = (short)162201611;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.DateTime? value;
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_780;
					case 1:
						num = (short)1145569304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (value == null)
						{
							num = (short)1806434351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f.Value = new int?(value.Value.Minute);
						num = (short)584908833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.a is global::DevComponents.WpfEditors.Primitives.NumericDayInput)
						{
							num = (short)926810152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86C;
					case 4:
					{
						global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput;
						dateTimePartInput.Value = null;
						num = (short)1415905324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_8D9;
					case 6:
						goto IL_780;
					case 7:
						num = (short)2125529142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)697106485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_502;
					case 10:
						if (this.b != null)
						{
							num = (short)1933508663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_969;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_14D;
						}
						continue;
					case 12:
						if (this.d != null)
						{
							num = (short)1245118502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_740;
					case 13:
						if (base.FocusedItem == this.a)
						{
							num = (short)1615921168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86C;
					case 14:
						num = (short)203292674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!this.i)
						{
							num = (short)1564934181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_502;
					case 16:
						num = (short)1713635331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_542;
					case 18:
						goto IL_969;
					case 19:
						goto IL_740;
					case 20:
						goto IL_927;
					case 21:
						this.d.Value = null;
						num = (short)2095710250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						this.g.Value = null;
						num = (short)1601110016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						if (num3 >= base.Items.Count)
						{
							num = (short)329908287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput = base.Items[num3] as global::DevComponents.WpfEditors.Primitives.IDateTimePartInput;
						num = (short)898105372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (value == null)
						{
							num = (short)897318969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e.Value = new int?(value.Value.Hour);
						num = (short)1628700715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)415301688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_1D9;
					case 27:
						if (this.e != null)
						{
							num = (short)2030305281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_927;
					case 28:
					{
						global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput;
						if (dateTimePartInput != null)
						{
							num = (short)174784574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_542;
					}
					case 29:
						goto IL_5AD;
					case 30:
						if (this.g != null)
						{
							num = (short)1255473216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_780;
					case 31:
						this.h();
						num = (short)1233322029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						this.b.Value = null;
						num = (short)220397586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						IL_417:
						goto IL_1D9;
					case 34:
						if (this.f != null)
						{
							num = (short)1631518734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9;
					case 35:
						if (this.a != null)
						{
							num = (short)31260703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_502;
					case 36:
						goto IL_502;
					case 37:
						goto IL_86C;
					case 38:
						num = (short)830341172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput;
						if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.DayOfYear)
						{
							num = (short)1524170777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_542;
					}
					case 40:
						num = (short)1294925839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						this.a.Value = null;
						num = (short)1555693577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_740;
					case 43:
						goto IL_927;
					case 44:
						goto IL_542;
					case 45:
						if (value == null)
						{
							num = (short)1293484073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)348782605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						this.c.Value = null;
						num = (short)1685258288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						this.f.Value = null;
						num = (short)138870810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_8D9;
					case 49:
						if (this.c != null)
						{
							num = (short)1309081607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D9;
					case 50:
						goto IL_5AD;
					case 51:
						if (value == null)
						{
							num = (short)304218144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b.Value = new int?((int)value.Value.DayOfWeek);
						num = (short)1170735163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						num = (short)104726529;
						if (num != 0)
						{
						}
						if (value == null)
						{
							num = (short)808452117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.d.Value = new int?(value.Value.Year);
						num = (short)874184723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
					{
						global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput;
						dateTimePartInput.Value = ((value == null) ? null : new int?((int)value.Value.DayOfWeek));
						num = (short)351600705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						if (value == null)
						{
							num = (short)207880238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.c.Value = new int?(value.Value.Month);
						num = (short)2019753989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						num = (short)1540554803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
					{
						if (value == null)
						{
							num = (short)943259652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput;
						dateTimePartInput.Value = new int?(value.Value.DayOfYear);
						num = (short)1753481233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
						this.e.Value = null;
						num = (short)2121334804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						return;
					case 59:
						goto IL_969;
					case 60:
						if (value == null)
						{
							num = (short)498270230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.g.Value = new int?(value.Value.Second);
						num = (short)770179078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						num = (short)1843789824;
						short num4 = num;
						global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput;
						if (dateTimePartInput.Part == global::DevComponents.WpfEditors.Primitives.eDateTimePart.DayName)
						{
							num = (short)35389448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1536884775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						num = (short)61079613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						goto IL_5EE;
					case 64:
						num = (short)555941948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_542;
					}
					IL_14D:
					if (this.k)
					{
						num = (short)1161953338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.k = true;
					value = this.Value;
					num = (short)1284309004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D9:
					num = (short)320733214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_969:
					num = (short)1383895196;
					short num5 = num;
					num = (short)1410961564;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_417;
					default:
						num = (short)1781334016;
						if (num != 0)
						{
						}
						num = (short)1738866715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_502:
					num = (short)1886388234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_542:
					num3++;
					num = (short)1478557746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AD:
					num = (short)73072663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_740:
					num = (short)295305265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_780:
					num3 = 0;
					num = (short)1755316253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_86C:
					this.a.Value = new int?(value.Value.Day);
					num = (short)1524432932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D9:
					num = (short)1318453283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_927:
					num = (short)801832994;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5EE:
				base.InvalidateMeasure();
				base.InvalidateVisual();
				this.k = false;
				return;
			}
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00077CC0 File Offset: 0x00075EC0
		protected override void ResetValue()
		{
			short num = (short)833290240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				for (;;)
				{
					this.l = true;
					try
					{
						num = (short)1224671247;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							int? value;
							global::System.Collections.IEnumerator enumerator;
							switch (num2)
							{
							case 0:
								goto IL_4A3;
							case 1:
							{
								global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput = this.f;
								value = null;
								dateTimePartInput.Value = value;
								num = (short)1448214545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_3CE;
							case 3:
							{
								global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput2 = this.c;
								value = null;
								dateTimePartInput2.Value = value;
								num = (short)420675595;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								if (this.a != null)
								{
									num = (short)598409226;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_526;
							case 5:
								if (this.e != null)
								{
									num = (short)1339621394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3CE;
							case 6:
							{
								global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput3 = this.g;
								value = null;
								dateTimePartInput3.Value = value;
								num = (short)1420230678;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								goto IL_4A8;
							case 8:
								if (this.g != null)
								{
									num = (short)607322118;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_44E;
							case 9:
								goto IL_64C;
							case 10:
								goto IL_35C;
							case 11:
								goto IL_40E;
							case 12:
								if (this.f != null)
								{
									num = (short)1298923521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_38D;
							case 13:
								if (this.c != null)
								{
									num = (short)1249574915;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_40E;
							case 14:
								goto IL_526;
							case 15:
								switch (0)
								{
								case 0:
									goto IL_AA;
								}
								continue;
							case 16:
								if (this.d != null)
								{
									num = (short)1915748371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4A8;
							case 17:
								goto IL_38D;
							case 18:
							{
								global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput4 = this.e;
								value = null;
								dateTimePartInput4.Value = value;
								num = (short)1641742338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 19:
							{
								global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput5 = this.d;
								value = null;
								dateTimePartInput5.Value = value;
								num = (short)204734471;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 20:
								try
								{
									num = (short)1493434378;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											if (value != null)
											{
												num = (short)83623937;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 1:
										{
											global::System.Windows.UIElement uielement;
											global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput6 = (global::DevComponents.WpfEditors.Primitives.IDateTimePartInput)uielement;
											value = null;
											dateTimePartInput6.Value = value;
											num = (short)998506505;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
										{
											global::System.Windows.UIElement uielement;
											if (uielement is global::DevComponents.WpfEditors.Primitives.IDateTimePartInput)
											{
												num = (short)279052293;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 4:
										{
											global::System.Windows.UIElement uielement;
											((global::DevComponents.WpfEditors.Primitives.DateTimeGroup)uielement).IsEmpty = true;
											num = (short)1742471170;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
										{
											global::System.Windows.UIElement uielement;
											value = ((global::DevComponents.WpfEditors.Primitives.IDateTimePartInput)uielement).Value;
											num = (short)588447744;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 6:
											goto IL_2E5;
										case 7:
										{
											global::System.Windows.UIElement uielement;
											if (uielement is global::DevComponents.WpfEditors.Primitives.DateTimeGroup)
											{
												num = (short)761528324;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1936457731;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 8:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)837091339;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
											num = (short)1182138375;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 10:
											switch (0)
											{
											case 0:
												goto IL_15A;
											}
											continue;
										case 11:
											num = (short)951123974;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_28D:
										num = (short)1039794184;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_15A:
										goto IL_28D;
									}
									IL_2E5:
									goto IL_479;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_307;
									}
									global::System.IDisposable disposable;
									for (;;)
									{
										IL_2F4:
										switch (num2)
										{
										case 0:
											goto IL_359;
										case 1:
											disposable.Dispose();
											num = (short)425590784;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											if (disposable != null)
											{
												num = (short)2044723201;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_35B;
										}
										goto IL_307;
									}
									IL_359:
									IL_35B:
									goto EndFinally_17;
									IL_307:
									disposable = (enumerator as global::System.IDisposable);
									num = (short)224067586;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_2F4;
									EndFinally_17:;
								}
								goto IL_35C;
								IL_479:
								this.Value = null;
								num = (short)1056440320;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 21:
								num = (short)1133510660;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 22:
								goto IL_44E;
							}
							IL_AA:
							if (base.AllowEmptyState)
							{
								num = (short)597098517;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b();
							num = (short)297992201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_35C:
							global::DevComponents.WpfEditors.Primitives.IDateTimePartInput dateTimePartInput7 = this.a;
							value = null;
							dateTimePartInput7.Value = value;
							num = (short)1783693326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_38D:
							num = (short)2072707080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3CE:
							num = (short)1144061964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_40E:
							num = (short)383320080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_44E:
							enumerator = base.Items.GetEnumerator();
							num = (short)979632148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4A8:
							num = (short)189005829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_526:
							num = (short)96600077;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4A3:
						IL_64C:;
					}
					finally
					{
						this.l = false;
					}
					num = (short)962395792;
					short num3 = num;
					num = (short)1501101712;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_68B;
					}
				}
				IL_68B:
				num = (short)1909719040;
				if (num != 0)
				{
				}
				num = (short)1191510017;
				if (num != 0)
				{
				}
				num = (short)200867840;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000783F0 File Offset: 0x000765F0
		private void c()
		{
			global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
			short num;
			try
			{
				num = (short)1898053633;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_13B;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_4E;
						}
						continue;
					case 2:
					{
						global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup;
						dateTimeGroup.MinDate = this.MinDate;
						dateTimeGroup.MaxDate = this.MaxDate;
						num = (short)1796866051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_BA;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1874198533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfEditors.Primitives.DateTimeGroup;
						num = (short)1301020678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)863502336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup;
						if (dateTimeGroup != null)
						{
							num = (short)1398276098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA;
					}
					}
					goto IL_4E;
					IL_BA:
					num = (short)1544880132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E:
					num = (short)1567490049;
					if (num != 0)
					{
					}
					goto IL_BA;
				}
				IL_13B:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_15C;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_14A:
					switch (num2)
					{
					case 0:
						goto IL_1B0;
					case 1:
						disposable.Dispose();
						num = (short)1100611584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (disposable != null)
						{
							num = (short)248381441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B0;
					}
					goto IL_15C;
					IL_1B0:
					num = (short)32206138;
					short num3 = num;
					num = (short)1667001658;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1E6;
					}
				}
				IL_1E6:
				num = (short)1451687936;
				if (num != 0)
				{
				}
				goto EndFinally_6;
				IL_15C:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)905052162;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_14A;
				EndFinally_6:;
			}
			num = (short)1171259392;
			short num4 = num;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00078644 File Offset: 0x00076844
		protected override void OnAllowEmptyStateChanged(bool oldValue, bool newValue)
		{
			short num = (short)1949892608;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1101135873;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 1:
					goto IL_AC;
				case 2:
					goto IL_107;
				case 3:
					if (base.IsEmpty)
					{
						num = (short)1795817473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_107;
				case 4:
					num = (short)434700291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_63:
				if (!newValue)
				{
					num = (short)415367168;
					short num3 = num;
					num = (short)728498180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_107;
				IL_AC:
				this.b();
				num = (short)698089474;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_107:
				num = (short)1161173052;
				short num4 = num;
				num = (short)133699644;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AC;
				default:
					goto IL_13D;
				}
			}
			IL_13D:
			num = (short)180158464;
			if (num != 0)
			{
			}
			base.OnAllowEmptyStateChanged(oldValue, newValue);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000787AC File Offset: 0x000769AC
		private void b()
		{
			short num = (short)270961779;
			short num2 = num;
			num = (short)830835827;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)555941888;
				if (num != 0)
				{
				}
				if (this.MinDate > global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MinDateTime)
				{
					num = (short)1265696769;
					if (num != 0)
					{
					}
					this.Value = new global::System.DateTime?(this.MinDate);
					return;
				}
				break;
			}
			num = (short)679084032;
			short num3 = num;
			this.Value = new global::System.DateTime?(global::System.DateTime.Now);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0007888C File Offset: 0x00076A8C
		protected override void OnIsEmptyChanged()
		{
			short num = (short)390660096;
			short num2 = num;
			num = (short)884867073;
			if (num != 0)
			{
			}
			num = (short)1600056699;
			short num3 = num;
			num = (short)348843387;
			switch (num3 == num)
			{
			}
			num = (short)1712259072;
			if (num != 0)
			{
			}
			this.a();
			base.OnIsEmptyChanged();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00078944 File Offset: 0x00076B44
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1780154368;
			short num2 = num;
			num = (short)1200757585;
			short num3 = num;
			num = (short)637672273;
			switch (num3 == num)
			{
			}
			num = (short)1332871169;
			if (num != 0)
			{
			}
			num = (short)1882980352;
			if (num != 0)
			{
			}
			this.UpdateValue(false, true);
			this.a();
			base.OnIsKeyboardFocusWithinChanged(e);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00078A08 File Offset: 0x00076C08
		private void a()
		{
			short num = (short)1813905408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::System.Collections.Generic.List<global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a>.Enumerator enumerator;
				for (;;)
				{
					IL_27:
					global::System.Collections.IEnumerator enumerator2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2110914560;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_36F;
									}
									continue;
								case 1:
									goto IL_3E7;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1222574083;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a a = enumerator.Current;
									a.c();
									num = (short)1845952516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1349779457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_398:
								num = (short)196280322;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_36F:
								goto IL_398;
							}
							IL_3E7:
							goto IL_297;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_3FA;
					case 1:
						try
						{
							num = (short)1821507588;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)167051273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator2.Current;
									num = (short)773914631;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Windows.UIElement uielement;
									if (uielement is global::System.Windows.Controls.Label)
									{
										num = (short)767754242;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Windows.UIElement uielement;
									global::System.Windows.Controls.Label label = (global::System.Windows.Controls.Label)uielement;
									global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a item = new global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a(label);
									label.Foreground = global::System.Windows.Media.Brushes.Transparent;
									this.m.Add(item);
									num = (short)690028549;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_21D;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_B4;
									}
									continue;
								case 7:
								{
									global::System.Windows.UIElement uielement;
									if (uielement is global::DevComponents.WpfEditors.Primitives.EditorElement)
									{
										num = (short)1698103304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)767164417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::System.Windows.UIElement uielement;
									global::DevComponents.WpfEditors.Primitives.EditorElement editorElement = (global::DevComponents.WpfEditors.Primitives.EditorElement)uielement;
									global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a item2 = new global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a(editorElement);
									editorElement.Foreground = global::System.Windows.Media.Brushes.Transparent;
									this.m.Add(item2);
									num = (short)719192070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)1035862019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B6:
								num = (short)1870069760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B4:
								goto IL_B6;
							}
							IL_21D:
							goto IL_424;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_23F;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_22C:
								switch (num2)
								{
								case 0:
									goto IL_294;
								case 1:
									disposable.Dispose();
									num = (short)1963786240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)548732929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_296;
								}
								goto IL_23F;
							}
							IL_294:
							IL_296:
							goto EndFinally_11;
							IL_23F:
							disposable = (enumerator2 as global::System.IDisposable);
							num = (short)637992962;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_22C;
							EndFinally_11:;
						}
						goto IL_297;
					case 2:
						num = (short)641859585;
						if (num != 0)
						{
						}
						goto IL_3FA;
					case 3:
						if (this.RenderWatermark)
						{
							num = (short)2102657026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_424;
					}
					goto IL_3E;
					IL_297:
					num = (short)1185087488;
					short num3 = num;
					this.m.Clear();
					num = (short)550567939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_406:
					num = (short)1705181185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_424:
					num = (short)1051041542;
					short num4 = num;
					num = (short)2093784838;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_406;
					default:
						goto IL_459;
					}
					IL_3FA:
					enumerator2 = base.Items.GetEnumerator();
					goto IL_406;
				}
				IL_459:
				num = (short)1334509568;
				if (num != 0)
				{
				}
				return;
				IL_3E:
				enumerator = this.m.GetEnumerator();
				num = (short)987955200;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00078EB8 File Offset: 0x000770B8
		protected override global::System.Windows.Rect GetWatermarkBounds()
		{
			short num = (short)310050816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Windows.Rect watermarkBounds = base.GetWatermarkBounds();
				global::System.Collections.IEnumerator enumerator = base.Items.GetEnumerator();
				try
				{
					num = (short)1339359236;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							num = (short)1398472707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::System.Windows.Controls.CheckBox)
							{
								num = (short)634322951;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1146814469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_211;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_81;
							}
							continue;
						case 5:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfEditors.Primitives.EditorButton)
							{
								num = (short)1336147974;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							global::System.Windows.UIElement uielement;
							global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot((global::System.Windows.FrameworkElement)uielement);
							watermarkBounds.Width = watermarkBounds.Right - layoutSlot.X;
							num = (short)1093730312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Windows.UIElement uielement;
							watermarkBounds.X += uielement.RenderSize.Width + 3.0;
							watermarkBounds.Width -= uielement.RenderSize.Width + 3.0;
							num = (short)1846476800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_1B6;
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)676855809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)675282946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_ED:
						num = (short)1371078665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_81:
						goto IL_ED;
					}
					IL_1B6:
					IL_211:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_233;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_220:
						switch (num2)
						{
						case 0:
							goto IL_2B2;
						case 1:
							disposable.Dispose();
							num = (short)975503360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (disposable != null)
							{
								num = (short)1683161089;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B2;
						}
						goto IL_233;
						IL_2B2:
						num = (short)2047749046;
						short num3 = num;
						num = (short)2139630518;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_2E9;
						}
					}
					IL_2E9:
					num = (short)1293680640;
					if (num != 0)
					{
					}
					goto EndFinally_7;
					IL_233:
					num = (short)820903937;
					if (num != 0)
					{
					}
					disposable = (enumerator as global::System.IDisposable);
					num = (short)272498690;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_220;
					EndFinally_7:;
				}
				num = (short)481492992;
				short num4 = num;
				return watermarkBounds;
			}
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0007922C File Offset: 0x0007742C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeGroup()
		{
			int a_ = 12;
			short num = (short)2060845056;
			short num2 = num;
			num = (short)1853127574;
			short num3 = num;
			num = (short)1241283478;
			switch (num3 == num)
			{
			}
			num = (short)721879041;
			if (num != 0)
			{
			}
			num = (short)1552547840;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MinDateTime = new global::System.DateTime(1753, 1, 1);
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MaxDateTime = new global::System.DateTime(9998, 12, 31);
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup.DefaultInputValuesProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷘뻚믜뻞铠迢釤껦蟨鯪飬鯮꟰鋲駴苶鳸裺", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.DateTimeGroup), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("还뫚뇜꫞蓠ꃢ跤蛦蟨質裬诮", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.DateTimeGroup));
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("还뫚뇜꫞蓠", a_), typeof(global::System.DateTime?), typeof(global::DevComponents.WpfEditors.Primitives.DateTimeGroup), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.c), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a), true, global::System.Windows.Data.UpdateSourceTrigger.LostFocus));
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MinDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铘닚돜鯞胠韢胤", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.Primitives.DateTimeGroup), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.MinValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.b)));
			global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MaxDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铘뫚ꗜ鯞胠韢胤", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.Primitives.DateTimeGroup), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.MaxValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a)));
		}

		// Token: 0x04000284 RID: 644
		private global::DevComponents.WpfEditors.Primitives.IDateTimePartInput a;

		// Token: 0x04000285 RID: 645
		private new global::DevComponents.WpfEditors.Primitives.IDateTimePartInput b;

		// Token: 0x04000286 RID: 646
		private global::DevComponents.WpfEditors.Primitives.IDateTimePartInput c;

		// Token: 0x04000287 RID: 647
		private global::DevComponents.WpfEditors.Primitives.IDateTimePartInput d;

		// Token: 0x04000288 RID: 648
		private global::DevComponents.WpfEditors.Primitives.IDateTimePartInput e;

		// Token: 0x04000289 RID: 649
		private global::DevComponents.WpfEditors.Primitives.IDateTimePartInput f;

		// Token: 0x0400028A RID: 650
		private global::DevComponents.WpfEditors.Primitives.IDateTimePartInput g;

		// Token: 0x0400028B RID: 651
		private global::DevComponents.WpfEditors.Primitives.IDateTimePartInput h;

		// Token: 0x0400028C RID: 652
		public static readonly global::System.DateTime MinDateTime;

		// Token: 0x0400028D RID: 653
		public static readonly global::System.DateTime MaxDateTime;

		// Token: 0x0400028E RID: 654
		public static readonly global::System.Windows.DependencyProperty DefaultInputValuesProperty;

		// Token: 0x04000290 RID: 656
		public static readonly global::System.Windows.DependencyProperty ValueProperty;

		// Token: 0x04000291 RID: 657
		public static readonly global::System.Windows.DependencyProperty MinDateProperty;

		// Token: 0x04000292 RID: 658
		public static readonly global::System.Windows.DependencyProperty MaxDateProperty;

		// Token: 0x04000293 RID: 659
		private bool i;

		// Token: 0x04000294 RID: 660
		private bool j;

		// Token: 0x04000295 RID: 661
		private bool k;

		// Token: 0x04000296 RID: 662
		private bool l;

		// Token: 0x04000297 RID: 663
		private global::System.Collections.Generic.List<global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a> m = new global::System.Collections.Generic.List<global::DevComponents.WpfEditors.Primitives.DateTimeGroup.a>();

		// Token: 0x02000058 RID: 88
		private struct a
		{
			// Token: 0x060005AF RID: 1455 RVA: 0x0007944C File Offset: 0x0007764C
			public a(global::System.Windows.FrameworkElement A_0)
			{
				this.a = A_0;
				if (A_0 is global::DevComponents.WpfEditors.Primitives.EditorElement)
				{
					this.b = ((global::DevComponents.WpfEditors.Primitives.EditorElement)A_0).Foreground;
					return;
				}
				if (A_0 is global::System.Windows.Controls.Control)
				{
					this.b = ((global::System.Windows.Controls.Control)A_0).Foreground;
					return;
				}
				this.b = null;
			}

			// Token: 0x060005B0 RID: 1456 RVA: 0x000794A0 File Offset: 0x000776A0
			public void c()
			{
				short num = (short)1009516544;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 1:
					{
						IL_11D:
						num = (short)2000224256;
						short num3 = num;
						((global::System.Windows.Controls.Control)this.a).Foreground = this.b;
						num = (short)959643650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_139;
					case 3:
						if (this.a is global::System.Windows.Controls.Control)
						{
							num = (short)696975361;
							if (num != 0)
							{
							}
							num = (short)1170931713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					case 4:
						goto IL_5A;
					}
					IL_39:
					if (this.a is global::DevComponents.WpfEditors.Primitives.EditorElement)
					{
						num = (short)1118765060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1383333891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139:
					num = (short)2066385511;
					short num4 = num;
					num = (short)413043303;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11D;
					default:
						goto IL_16F;
					}
				}
				IL_5A:
				((global::DevComponents.WpfEditors.Primitives.EditorElement)this.a).Foreground = this.b;
				return;
				IL_16F:
				num = (short)77791232;
				if (num != 0)
				{
				}
			}

			// Token: 0x04000298 RID: 664
			public global::System.Windows.FrameworkElement a;

			// Token: 0x04000299 RID: 665
			public global::System.Windows.Media.Brush b;
		}
	}
}
