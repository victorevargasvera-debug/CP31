using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200002D RID: 45
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SingleMonthCalendar : global::System.Windows.Controls.Control
	{
		// Token: 0x060002DD RID: 733 RVA: 0x00037AC0 File Offset: 0x00035CC0
		private static void r(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1637608295;
					short num3 = num2;
					num2 = (short)1924852583;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					default:
					{
						num2 = (short)160563200;
						short num4 = num2;
						num2 = (short)1752956928;
						if (num2 != 0)
						{
						}
						singleMonthCalendar.OnFirstDayOfWeekChanged((global::System.DayOfWeek)A_1.OldValue, (global::System.DayOfWeek)A_1.NewValue);
						num2 = (short)662241282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_38;
				case 2:
					return;
				}
				goto IL_1C;
				IL_38:
				num2 = (short)2091188225;
				if (num2 != 0)
				{
				}
				if (singleMonthCalendar == null)
				{
					break;
				}
				num2 = (short)1249968128;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)648609793;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00037BF4 File Offset: 0x00035DF4
		protected virtual void OnFirstDayOfWeekChanged(global::System.DayOfWeek oldValue, global::System.DayOfWeek newValue)
		{
			short num = (short)1557856257;
			if (num != 0)
			{
			}
			num = (short)51368683;
			short num2 = num;
			num = (short)1377293035;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1239678976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1769472000;
			if (num != 0)
			{
			}
			this.UpdateCalendarDisplay();
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00037CA4 File Offset: 0x00035EA4
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00037D5C File Offset: 0x00035F5C
		[global::System.ComponentModel.Description("Indicates first day of week displayed on the calendar.")]
		[global::System.ComponentModel.DefaultValue(global::System.DayOfWeek.Sunday)]
		public global::System.DayOfWeek FirstDayOfWeek
		{
			get
			{
				short num = (short)1113832396;
				short num2 = num;
				num = (short)1973730252;
				switch (num2 == num)
				{
				}
				num = (short)294125568;
				short num3 = num;
				num = (short)2000355328;
				if (num != 0)
				{
				}
				num = (short)676069377;
				if (num != 0)
				{
				}
				return (global::System.DayOfWeek)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.FirstDayOfWeekProperty);
			}
			set
			{
				short num = (short)1469617297;
				short num2 = num;
				num = (short)1564775569;
				switch (num2 == num)
				{
				}
				num = (short)1418133504;
				short num3 = num;
				num = (short)709754881;
				if (num != 0)
				{
				}
				num = (short)1309016064;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.FirstDayOfWeekProperty, value);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00037E18 File Offset: 0x00036018
		private static void q(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)228428042;
					short num3 = num2;
					num2 = (short)702122250;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37;
					default:
					{
						num2 = (short)1163329536;
						if (num2 != 0)
						{
						}
						num2 = (short)1410662400;
						short num4 = num2;
						singleMonthCalendar.OnTwoLetterDayNameChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						num2 = (short)754647042;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_37;
				case 2:
					goto IL_FD;
				}
				goto IL_1C;
				IL_37:
				if (singleMonthCalendar == null)
				{
					break;
				}
				num2 = (short)811794432;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FD:
			num2 = (short)1557266433;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)705822721;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00037F4C File Offset: 0x0003614C
		protected virtual void OnTwoLetterDayNameChanged(bool oldValue, bool newValue)
		{
			short num = (short)1371722225;
			short num2 = num;
			num = (short)1909838321;
			switch (num2 == num)
			{
			}
			num = (short)1594884096;
			short num3 = num;
			num = (short)1781137408;
			if (num != 0)
			{
			}
			num = (short)113573889;
			if (num != 0)
			{
			}
			this.UpdateCalendarDisplay();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00037FFC File Offset: 0x000361FC
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000380B4 File Offset: 0x000362B4
		[global::System.ComponentModel.Description("Indicates whether control uses the two letter day names.")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool TwoLetterDayName
		{
			get
			{
				short num = (short)776614021;
				short num2 = num;
				num = (short)305279109;
				switch (num2 == num)
				{
				}
				num = (short)1414070272;
				short num3 = num;
				num = (short)433192960;
				if (num != 0)
				{
				}
				num = (short)306708481;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.TwoLetterDayNameProperty);
			}
			set
			{
				short num = (short)110028919;
				short num2 = num;
				num = (short)2095835255;
				switch (num2 == num)
				{
				}
				num = (short)1791557632;
				short num3 = num;
				num = (short)1881735169;
				if (num != 0)
				{
				}
				num = (short)2084896768;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.TwoLetterDayNameProperty, value);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00038170 File Offset: 0x00036370
		private static void p(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1266745345;
					if (num2 != 0)
					{
					}
					num2 = (short)185921512;
					short num3 = num2;
					num2 = (short)2051469288;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					default:
					{
						num2 = (short)1849294848;
						short num4 = num2;
						num2 = (short)781320192;
						if (num2 != 0)
						{
						}
						singleMonthCalendar.OnShowTodayMarkerChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						num2 = (short)2128478210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_38;
				case 2:
					return;
				}
				goto IL_1C;
				IL_38:
				if (singleMonthCalendar == null)
				{
					break;
				}
				num2 = (short)688128000;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)1681260545;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000382A4 File Offset: 0x000364A4
		protected virtual void OnShowTodayMarkerChanged(bool oldValue, bool newValue)
		{
			short num = (short)359292087;
			short num2 = num;
			num = (short)2026593463;
			switch (num2 == num)
			{
			}
			num = (short)418971648;
			short num3 = num;
			num = (short)692060161;
			if (num != 0)
			{
			}
			num = (short)147521536;
			if (num != 0)
			{
			}
			this.UpdateCalendarDisplay();
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00038350 File Offset: 0x00036550
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00038408 File Offset: 0x00036608
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Description("Indicates whether today marker that indicates TodayDate is visible on the calendar.")]
		public bool ShowTodayMarker
		{
			get
			{
				short num = (short)681213702;
				short num2 = num;
				num = (short)257851142;
				switch (num2 == num)
				{
				}
				num = (short)623968257;
				if (num != 0)
				{
				}
				num = (short)189726720;
				if (num != 0)
				{
				}
				num = (short)276365312;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.ShowTodayMarkerProperty);
			}
			set
			{
				short num = (short)2056800048;
				short num2 = num;
				num = (short)975718192;
				switch (num2 == num)
				{
				}
				num = (short)1791819776;
				if (num != 0)
				{
				}
				num = (short)1621164033;
				if (num != 0)
				{
				}
				num = (short)1265958912;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.ShowTodayMarkerProperty, value);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000384C0 File Offset: 0x000366C0
		private static void o(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (singleMonthCalendar != null)
					{
						num2 = (short)807993345;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_101;
				case 1:
				{
					singleMonthCalendar.OnShowWeekNumbersChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num2 = (short)1264386048;
					short num3 = num2;
					num2 = (short)1328742402;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_B4;
				}
				goto IL_1C;
			}
			IL_B4:
			num2 = (short)945752063;
			short num4 = num2;
			num2 = (short)20121599;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1574567936;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_101:
			num2 = (short)892731393;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)691077120;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000385F4 File Offset: 0x000367F4
		protected virtual void OnShowWeekNumbersChanged(bool oldValue, bool newValue)
		{
			short num = (short)1998957422;
			short num2 = num;
			num = (short)1639426926;
			switch (num2 == num)
			{
			}
			num = (short)1662058497;
			if (num != 0)
			{
			}
			num = (short)956628992;
			if (num != 0)
			{
			}
			num = (short)1589772288;
			short num3 = num;
			this.UpdateCalendarDisplay();
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002EB RID: 747 RVA: 0x000386A4 File Offset: 0x000368A4
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0003875C File Offset: 0x0003695C
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("Indicates whether week of year is visible.")]
		public bool ShowWeekNumbers
		{
			get
			{
				short num = (short)1635317109;
				short num2 = num;
				num = (short)961738101;
				switch (num2 == num)
				{
				}
				num = (short)814219264;
				if (num != 0)
				{
				}
				num = (short)1017905153;
				if (num != 0)
				{
				}
				num = (short)1921712128;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.ShowWeekNumbersProperty);
			}
			set
			{
				short num = (short)712249584;
				short num2 = num;
				num = (short)1236930800;
				switch (num2 == num)
				{
				}
				num = (short)838533121;
				if (num != 0)
				{
				}
				num = (short)2020081664;
				if (num != 0)
				{
				}
				num = (short)1214251008;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.ShowWeekNumbersProperty, value);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00038818 File Offset: 0x00036A18
		private static void n(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (singleMonthCalendar != null)
					{
						num2 = (short)697565185;
						if (num2 != 0)
						{
						}
						num2 = (short)556400641;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1141702656;
					short num3 = num2;
					singleMonthCalendar.OnWeekendDaysSelectableChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num2 = (short)718143490;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_DA;
				}
				goto IL_1C;
			}
			IL_DA:
			num2 = (short)763966265;
			short num4 = num2;
			num2 = (short)225456953;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1977810944;
				if (num2 != 0)
				{
				}
				break;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)816185344;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00038950 File Offset: 0x00036B50
		protected virtual void OnWeekendDaysSelectableChanged(bool oldValue, bool newValue)
		{
			short num = (short)1562969050;
			short num2 = num;
			num = (short)121373658;
			switch (num2 == num)
			{
			}
			num = (short)218497024;
			if (num != 0)
			{
			}
			num = (short)1996881921;
			if (num != 0)
			{
			}
			num = (short)927137792;
			short num3 = num;
			this.UpdateCalendarDisplay();
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00038A00 File Offset: 0x00036C00
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00038ABC File Offset: 0x00036CBC
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Description("Indicates whether weekend days can be selected.")]
		public bool WeekendDaysSelectable
		{
			get
			{
				short num = (short)1546789688;
				short num2 = num;
				num = (short)965157688;
				switch (num2 == num)
				{
				}
				num = (short)2139684865;
				if (num != 0)
				{
				}
				num = (short)1933377536;
				if (num != 0)
				{
				}
				num = (short)2091122688;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.WeekendDaysSelectableProperty);
			}
			set
			{
				short num = (short)1510436298;
				short num2 = num;
				num = (short)397045194;
				switch (num2 == num)
				{
				}
				num = (short)1321467905;
				if (num != 0)
				{
				}
				num = (short)1546780672;
				if (num != 0)
				{
				}
				num = (short)1247412224;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.WeekendDaysSelectableProperty, value);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00038B74 File Offset: 0x00036D74
		private static object d(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			short num;
			for (;;)
			{
				singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
				if (singleMonthCalendar != null)
				{
					num = (short)877620322;
					short num2 = num;
					num = (short)1546742882;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_6D;
					}
					break;
				}
				return A_1;
			}
			num = (short)804323328;
			short num3 = num;
			IL_6D:
			num = (short)1362886657;
			if (num != 0)
			{
			}
			num = (short)1791819776;
			if (num != 0)
			{
			}
			return singleMonthCalendar.OnCoerceSelectedDate((global::System.DateTime?)A_1);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00038C40 File Offset: 0x00036E40
		protected virtual global::System.DateTime? OnCoerceSelectedDate(global::System.DateTime? value)
		{
			short num = (short)1252589568;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					value = new global::System.DateTime?(new global::System.DateTime(value.Value.Year, value.Value.Month, value.Value.Day));
					num = (short)2025127938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_D0;
				}
				IL_32:
				num = (short)1934098432;
				short num3 = num;
				if (value != null)
				{
					num = (short)1981349889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D0:
				num = (short)594100863;
				short num4 = num;
				num = (short)1175011967;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_32;
				default:
					goto IL_105;
				}
			}
			IL_105:
			num = (short)199622657;
			if (num != 0)
			{
			}
			num = (short)983695360;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00038D94 File Offset: 0x00036F94
		private static void m(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (singleMonthCalendar != null)
					{
						num2 = (short)295501825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					singleMonthCalendar.OnSelectedDateChanged((global::System.DateTime?)A_1.OldValue, (global::System.DateTime?)A_1.NewValue);
					num2 = (short)1343946752;
					short num3 = num2;
					num2 = (short)962330626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_B2;
				}
				goto IL_1C;
			}
			IL_B2:
			num2 = (short)648733664;
			short num4 = num2;
			num2 = (short)1330242528;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1117454337;
				if (num2 != 0)
				{
				}
				num2 = (short)1267859456;
				if (num2 != 0)
				{
				}
				break;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)1201602560;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00038ECC File Offset: 0x000370CC
		protected virtual void OnSelectedDateChanged(global::System.DateTime? oldValue, global::System.DateTime? newValue)
		{
			short num = (short)915734528;
			switch (num)
			{
			default:
			{
				num = (short)880476172;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.c != null)
						{
							num = (short)651624450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31B;
					case 1:
						goto IL_2B4;
					case 2:
					{
						global::System.DateTime value = newValue.Value;
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array = this.c;
						int num3 = 0;
						num = (short)618135560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_13A;
					case 4:
						goto IL_A3;
					case 5:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array;
						int num3;
						if (num3 >= array.Length)
						{
							num = (short)39321610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num3].IsChecked = new bool?(false);
						num3++;
						num = (short)1899954182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_2B4;
					case 7:
					{
						num = (short)389414912;
						short num4 = num;
						if (this.c != null)
						{
							num = (short)2023358475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31B;
					}
					case 8:
						goto IL_278;
					case 9:
						goto IL_278;
					case 10:
					{
						num = (short)1880394247;
						short num5 = num;
						num = (short)175671815;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A3;
						default:
							num = (short)696188928;
							if (num != 0)
							{
							}
							num = (short)334561283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array = this.c;
						int num3 = 0;
						num = (short)255983617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 13:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array;
						int num3;
						if (num3 >= array.Length)
						{
							num = (short)1399128078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel = array[num3];
						global::System.DateTime value;
						monthCalendarDayLabel.IsChecked = new bool?(this.a(monthCalendarDayLabel.Date, value));
						num3++;
						num = (short)1135738889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_2B2;
					}
					IL_80:
					if (newValue == null)
					{
						num = (short)1919090692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2065629185;
					if (num != 0)
					{
					}
					num = (short)1130364928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					num = (short)1634271239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_278:
					num = (short)1143078925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B4:
					num = (short)2073362437;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13A:
				IL_2B2:
				IL_31B:
				this.OnSelectedDateChanged();
				return;
			}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x000391FC File Offset: 0x000373FC
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x000392B8 File Offset: 0x000374B8
		public global::System.DateTime? SelectedDate
		{
			get
			{
				short num = (short)1117820828;
				short num2 = num;
				num = (short)702388124;
				switch (num2 == num)
				{
				}
				num = (short)87293953;
				if (num != 0)
				{
				}
				num = (short)1722744832;
				if (num != 0)
				{
				}
				num = (short)1592131584;
				short num3 = num;
				return (global::System.DateTime?)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.SelectedDateProperty);
			}
			set
			{
				short num = (short)765526017;
				if (num != 0)
				{
				}
				num = (short)1934204528;
				short num2 = num;
				num = (short)77373040;
				switch (num2 == num)
				{
				}
				num = (short)1532624896;
				if (num != 0)
				{
				}
				num = (short)939393024;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.SelectedDateProperty, value);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00039374 File Offset: 0x00037574
		private static void l(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (singleMonthCalendar != null)
					{
						num2 = (short)2043281409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					singleMonthCalendar.OnWeekOfYearRuleChanged((global::System.Globalization.CalendarWeekRule)A_1.OldValue, (global::System.Globalization.CalendarWeekRule)A_1.NewValue);
					num2 = (short)294387712;
					short num3 = num2;
					num2 = (short)152174593;
					if (num2 != 0)
					{
					}
					num2 = (short)689569794;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_D9;
				}
				goto IL_1C;
			}
			IL_D9:
			num2 = (short)85232519;
			short num4 = num2;
			num2 = (short)266374023;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)96010240;
				if (num2 != 0)
				{
				}
				break;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)682557440;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000394A8 File Offset: 0x000376A8
		protected virtual void OnWeekOfYearRuleChanged(global::System.Globalization.CalendarWeekRule oldValue, global::System.Globalization.CalendarWeekRule newValue)
		{
			short num = (short)2036537181;
			short num2 = num;
			num = (short)177280861;
			switch (num2 == num)
			{
			}
			num = (short)1054867456;
			if (num != 0)
			{
			}
			num = (short)1764032513;
			if (num != 0)
			{
			}
			num = (short)1684865024;
			short num3 = num;
			this.UpdateCalendarDisplay();
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00039558 File Offset: 0x00037758
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00039614 File Offset: 0x00037814
		[global::System.ComponentModel.DefaultValue(global::System.Globalization.CalendarWeekRule.FirstDay)]
		[global::System.ComponentModel.Description("Indicates rule used to determine first week of the year for week of year display on calendar.")]
		public global::System.Globalization.CalendarWeekRule WeekOfYearRule
		{
			get
			{
				short num = (short)2063665626;
				short num2 = num;
				num = (short)409143770;
				switch (num2 == num)
				{
				}
				num = (short)639041537;
				if (num != 0)
				{
				}
				num = (short)1213595648;
				if (num != 0)
				{
				}
				num = (short)1628045312;
				short num3 = num;
				return (global::System.Globalization.CalendarWeekRule)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.WeekOfYearRuleProperty);
			}
			set
			{
				short num = (short)928546483;
				short num2 = num;
				num = (short)526352051;
				switch (num2 == num)
				{
				}
				num = (short)1633746944;
				if (num != 0)
				{
				}
				num = (short)1310721;
				if (num != 0)
				{
				}
				num = (short)1185808384;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.WeekOfYearRuleProperty, value);
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000396D0 File Offset: 0x000378D0
		private static void k(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1527382017;
					if (num2 != 0)
					{
					}
					if (singleMonthCalendar != null)
					{
						num2 = (short)1028784129;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)280297472;
					short num3 = num2;
					singleMonthCalendar.OnTrailingDaysVisibleChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num2 = (short)1491861506;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_DD;
				}
				goto IL_1C;
			}
			IL_DD:
			num2 = (short)93447508;
			short num4 = num2;
			num2 = (short)1635312980;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1850933248;
				if (num2 != 0)
				{
				}
				break;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)1697710080;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00039808 File Offset: 0x00037A08
		protected virtual void OnTrailingDaysVisibleChanged(bool oldValue, bool newValue)
		{
			short num = (short)81526785;
			if (num != 0)
			{
			}
			num = (short)2030797811;
			short num2 = num;
			num = (short)579437555;
			switch (num2 == num)
			{
			}
			num = (short)308215808;
			if (num != 0)
			{
			}
			num = (short)1490550784;
			short num3 = num;
			this.UpdateCalendarDisplay();
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002FD RID: 765 RVA: 0x000398B8 File Offset: 0x00037AB8
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00039970 File Offset: 0x00037B70
		[global::System.ComponentModel.DefaultValue(true)]
		public bool TrailingDaysVisible
		{
			get
			{
				short num = (short)756826712;
				short num2 = num;
				num = (short)1668694616;
				switch (num2 == num)
				{
				}
				num = (short)1626210305;
				if (num != 0)
				{
				}
				num = (short)1418264576;
				if (num != 0)
				{
				}
				num = (short)1718550528;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.TrailingDaysVisibleProperty);
			}
			set
			{
				short num = (short)647872897;
				short num2 = num;
				num = (short)927383937;
				switch (num2 == num)
				{
				}
				num = (short)898498560;
				if (num != 0)
				{
				}
				num = (short)224460801;
				if (num != 0)
				{
				}
				num = (short)356057088;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.TrailingDaysVisibleProperty, value);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00039A2C File Offset: 0x00037C2C
		private static object c(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			short num;
			for (;;)
			{
				singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
				if (singleMonthCalendar != null)
				{
					num = (short)65794266;
					short num2 = num;
					num = (short)596701402;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_6B;
					}
					break;
				}
				return A_1;
			}
			num = (short)807862272;
			short num3 = num;
			IL_6B:
			num = (short)924778497;
			if (num != 0)
			{
			}
			num = (short)529006592;
			if (num != 0)
			{
			}
			return singleMonthCalendar.OnCoerceDayNames((string[])A_1);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00039AF4 File Offset: 0x00037CF4
		private static void j(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)47841281;
					if (num2 != 0)
					{
					}
					if (singleMonthCalendar != null)
					{
						num2 = (short)1595277313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)2088173568;
					short num3 = num2;
					singleMonthCalendar.OnDayNamesChanged((string[])A_1.OldValue, (string[])A_1.NewValue);
					num2 = (short)1348009986;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_DA;
				}
				goto IL_1C;
			}
			IL_DA:
			num2 = (short)1757913855;
			short num4 = num2;
			num2 = (short)1770496767;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)170983424;
				if (num2 != 0)
				{
				}
				break;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)953352192;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00039C28 File Offset: 0x00037E28
		protected virtual string[] OnCoerceDayNames(string[] value)
		{
			int a_ = 4;
			short num = (short)1796603905;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1223753730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
				{
					num = (short)1128744433;
					short num3 = num;
					num = (short)961693169;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)1468530688;
						short num4 = num;
						break;
					}
					}
					num = (short)1345781761;
					if (num != 0)
					{
					}
					num = (short)942800896;
					if (num != 0)
					{
					}
					if (value.Length != 7)
					{
						num = (short)559153155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return value;
				}
				case 3:
					goto IL_140;
				}
				IL_3D:
				if (value == null)
				{
					return value;
				}
				num = (short)906362880;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_140:
			throw new global::System.ArgumentException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闐닒곔駖룘뛚룜곞쇠転郤铦鷨쯪藬軮蟰雲헴鋶臸髺黼课洀稂┄〆⤈戊礌樎簐怒㔔縖眘㬚縜瀞䴠伢䀤䐦崨䈪䈬䄮ἰ", a_));
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00039D7C File Offset: 0x00037F7C
		protected virtual void OnDayNamesChanged(string[] oldValue, string[] newValue)
		{
			short num = (short)1669416465;
			short num2 = num;
			num = (short)850282001;
			switch (num2 == num)
			{
			}
			num = (short)1983643648;
			if (num != 0)
			{
			}
			num = (short)1935147009;
			if (num != 0)
			{
			}
			num = (short)845545472;
			short num3 = num;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00039E28 File Offset: 0x00038028
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00039EE0 File Offset: 0x000380E0
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Description("Indicates array of custom names for days displayed on calendar header.")]
		public string[] DayNames
		{
			get
			{
				short num = (short)1319632897;
				if (num != 0)
				{
				}
				num = (short)4173835;
				short num2 = num;
				num = (short)1963503627;
				switch (num2 == num)
				{
				}
				num = (short)35717120;
				if (num != 0)
				{
				}
				num = (short)733872128;
				short num3 = num;
				return (string[])base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.DayNamesProperty);
			}
			set
			{
				short num = (short)1351286785;
				if (num != 0)
				{
				}
				num = (short)1187580130;
				short num2 = num;
				num = (short)595069154;
				switch (num2 == num)
				{
				}
				num = (short)718929920;
				if (num != 0)
				{
				}
				num = (short)974913536;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.DayNamesProperty, value);
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00039F94 File Offset: 0x00038194
		private static void i(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)976093185;
					if (num2 != 0)
					{
					}
					if (singleMonthCalendar != null)
					{
						num2 = (short)1827602433;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1494810624;
					short num3 = num2;
					singleMonthCalendar.OnTodayDateChanged((global::System.DateTime?)A_1.OldValue, (global::System.DateTime?)A_1.NewValue);
					num2 = (short)108593154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_DA;
				}
				goto IL_1C;
			}
			IL_DA:
			num2 = (short)1424998720;
			short num4 = num2;
			num2 = (short)884392256;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1271529472;
				if (num2 != 0)
				{
				}
				break;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)338362368;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0003A0CC File Offset: 0x000382CC
		protected virtual void OnTodayDateChanged(global::System.DateTime? oldValue, global::System.DateTime? newValue)
		{
			short num = (short)615767333;
			short num2 = num;
			num = (short)1057152293;
			switch (num2 == num)
			{
			}
			num = (short)1899692033;
			if (num != 0)
			{
			}
			num = (short)675545088;
			if (num != 0)
			{
			}
			num = (short)518848512;
			short num3 = num;
			this.UpdateCalendarDisplay();
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0003A180 File Offset: 0x00038380
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0003A23C File Offset: 0x0003843C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.DateTime? TodayDate
		{
			get
			{
				short num = (short)1309520727;
				short num2 = num;
				num = (short)1742844759;
				switch (num2 == num)
				{
				}
				num = (short)838336512;
				if (num != 0)
				{
				}
				num = (short)418578433;
				if (num != 0)
				{
				}
				num = (short)127008768;
				short num3 = num;
				return (global::System.DateTime?)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.TodayDateProperty);
			}
			set
			{
				short num = (short)2022703105;
				if (num != 0)
				{
				}
				num = (short)940246666;
				short num2 = num;
				num = (short)1555236490;
				switch (num2 == num)
				{
				}
				num = (short)407109632;
				if (num != 0)
				{
				}
				num = (short)1413611520;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.TodayDateProperty, value);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0003A2F4 File Offset: 0x000384F4
		private static void h(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)479133697;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			int num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					if (singleMonthCalendar != null)
					{
						num = (short)352911361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)880541696;
					short num3 = num;
					singleMonthCalendar.OnMinDateChanged((global::System.DateTime)A_1.OldValue, (global::System.DateTime)A_1.NewValue);
					num = (short)573636610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_DA;
				}
				goto IL_43;
			}
			IL_DA:
			num = (short)1136516541;
			short num4 = num;
			num = (short)756014525;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)50790400;
				if (num != 0)
				{
				}
				break;
			}
			return;
			IL_43:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num = (short)2104492032;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0003A428 File Offset: 0x00038628
		protected virtual void OnMinDateChanged(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			short num = (short)1417283191;
			short num2 = num;
			num = (short)81200759;
			switch (num2 == num)
			{
			}
			num = (short)396296193;
			if (num != 0)
			{
			}
			num = (short)651821056;
			if (num != 0)
			{
			}
			num = (short)1727397888;
			short num3 = num;
			this.UpdateCalendarDisplay();
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0003A4D8 File Offset: 0x000386D8
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0003A590 File Offset: 0x00038790
		[global::System.ComponentModel.Description("Indicates minimum date and time that can be selected in the control.")]
		public global::System.DateTime MinDate
		{
			get
			{
				short num = (short)1976096494;
				short num2 = num;
				num = (short)1755829998;
				switch (num2 == num)
				{
				}
				num = (short)171966465;
				if (num != 0)
				{
				}
				num = (short)985333760;
				short num3 = num;
				num = (short)622133248;
				if (num != 0)
				{
				}
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.MinDateProperty);
			}
			set
			{
				short num = (short)1298221991;
				short num2 = num;
				num = (short)1515604903;
				switch (num2 == num)
				{
				}
				num = (short)35979265;
				if (num != 0)
				{
				}
				num = (short)2114584576;
				short num3 = num;
				num = (short)117964800;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.MinDateProperty, value);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0003A64C File Offset: 0x0003884C
		private static void g(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					for (;;)
					{
						num2 = (short)132853797;
						short num3 = num2;
						num2 = (short)708784165;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B1;
						}
					}
					IL_B1:
					num2 = (short)1517879296;
					if (num2 != 0)
					{
					}
					singleMonthCalendar.OnMaxDateChanged((global::System.DateTime)A_1.OldValue, (global::System.DateTime)A_1.NewValue);
					num2 = (short)1133641728;
					short num4 = num2;
					num2 = (short)390397953;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					num2 = (short)1843003393;
					if (num2 != 0)
					{
					}
					if (singleMonthCalendar != null)
					{
						num2 = (short)2067660800;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)1059323906;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0003A780 File Offset: 0x00038980
		protected virtual void OnMaxDateChanged(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			short num = (short)269266331;
			short num2 = num;
			num = (short)2034150811;
			switch (num2 == num)
			{
			}
			num = (short)75169793;
			if (num != 0)
			{
			}
			num = (short)1487470592;
			short num3 = num;
			num = (short)1491861504;
			if (num != 0)
			{
			}
			this.UpdateCalendarDisplay();
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0003A830 File Offset: 0x00038A30
		// (set) Token: 0x06000310 RID: 784 RVA: 0x0003A8E8 File Offset: 0x00038AE8
		[global::System.ComponentModel.Description("Indicates maximum date and time that can be selected in the control.")]
		public global::System.DateTime MaxDate
		{
			get
			{
				short num = (short)466157569;
				if (num != 0)
				{
				}
				num = (short)1759129856;
				short num2 = num;
				num = (short)789393664;
				switch (num2 == num)
				{
				}
				num = (short)51642368;
				short num3 = num;
				num = (short)108724224;
				if (num != 0)
				{
				}
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.MaxDateProperty);
			}
			set
			{
				short num = (short)2136408065;
				if (num != 0)
				{
				}
				num = (short)1097754136;
				short num2 = num;
				num = (short)1496606232;
				switch (num2 == num)
				{
				}
				num = (short)973471744;
				short num3 = num;
				num = (short)1533149184;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.MaxDateProperty, value);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0003A9A0 File Offset: 0x00038BA0
		private static void f(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					for (;;)
					{
						num2 = (short)650024176;
						short num3 = num2;
						num2 = (short)1400870128;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B0;
						}
					}
					IL_B0:
					num2 = (short)128778240;
					if (num2 != 0)
					{
					}
					singleMonthCalendar.OnTrailingDayStyleChanged((global::System.Windows.Style)A_1.OldValue, (global::System.Windows.Style)A_1.NewValue);
					num2 = (short)1447362560;
					short num4 = num2;
					num2 = (short)1005387777;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					if (singleMonthCalendar != null)
					{
						num2 = (short)2106589184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1781465089;
			if (num2 != 0)
			{
			}
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)1512505346;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		protected virtual void OnTrailingDayStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
		{
			short num = (short)1103429632;
			switch (num)
			{
			default:
			{
				num = (short)491192325;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_193;
					case 1:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
						if (monthCalendarDayLabel.IsTrailing)
						{
							num = (short)1162608646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5;
					}
					case 2:
						return;
					case 3:
						goto IL_193;
					case 4:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array;
						if (num3 >= array.Length)
						{
							num = (short)503250946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel = array[num3];
						num = (short)1244200961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					case 6:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
						monthCalendarDayLabel.Style = newValue;
						num = (short)479526919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)2110664777;
						short num4 = num;
						num = (short)1487941705;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B5;
						default:
							num = (short)109051904;
							if (num != 0)
							{
							}
							goto IL_B5;
						}
						break;
					}
					case 8:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array = this.c;
						num3 = 0;
						num = (short)1345191936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_68:
					num = (short)354353152;
					short num5 = num;
					if (this.c != null)
					{
						num = (short)1711538184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_B5:
					num3++;
					num = (short)2053701633;
					if (num != 0)
					{
					}
					num = (short)317849603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_193:
					num = (short)1372848132;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0003ACF8 File Offset: 0x00038EF8
		// (set) Token: 0x06000314 RID: 788 RVA: 0x0003ADB4 File Offset: 0x00038FB4
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style TrailingDayStyle
		{
			get
			{
				short num = (short)2032017230;
				short num2 = num;
				num = (short)1493966670;
				switch (num2 == num)
				{
				}
				num = (short)895090688;
				if (num != 0)
				{
				}
				num = (short)721420288;
				short num3 = num;
				num = (short)798097409;
				if (num != 0)
				{
				}
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.TrailingDayStyleProperty);
			}
			set
			{
				short num = (short)1784654056;
				short num2 = num;
				num = (short)557951208;
				switch (num2 == num)
				{
				}
				num = (short)1772224513;
				if (num != 0)
				{
				}
				num = (short)357302272;
				short num3 = num;
				num = (short)202113024;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.TrailingDayStyleProperty, value);
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0003AE68 File Offset: 0x00039068
		private static void e(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					for (;;)
					{
						num2 = (short)1412427530;
						short num3 = num2;
						num2 = (short)1135931146;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B1;
						}
					}
					IL_B1:
					num2 = (short)124387328;
					if (num2 != 0)
					{
					}
					singleMonthCalendar.OnDayNameLabelStyleChanged((global::System.Windows.Style)A_1.OldValue, (global::System.Windows.Style)A_1.NewValue);
					num2 = (short)616824832;
					short num4 = num2;
					num2 = (short)1323827201;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					if (singleMonthCalendar != null)
					{
						num2 = (short)647823361;
						if (num2 != 0)
						{
						}
						num2 = (short)1789001728;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)631701506;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0003AFA0 File Offset: 0x000391A0
		protected virtual void OnDayNameLabelStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
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
					num2 = (short)663826885;
					short num3 = num2;
					num2 = (short)1529557445;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1713700864;
						if (num2 != 0)
						{
						}
						num2 = (short)1868890112;
						short num4 = num2;
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayNameLabel[] array = this.b;
						int num5 = 0;
						num2 = (short)2003238915;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_FF;
				case 2:
					return;
				case 3:
					goto IL_FF;
				case 4:
				{
					global::DevComponents.WpfEditors.Primitives.MonthCalendarDayNameLabel[] array;
					int num5;
					if (num5 >= array.Length)
					{
						num2 = (short)1548419074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					array[num5].Style = newValue;
					num5++;
					num2 = (short)563412993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					num2 = (short)578224129;
					if (num2 != 0)
					{
					}
					if (this.b != null)
					{
						num2 = (short)1113784320;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_28;
				IL_FF:
				num2 = (short)415236100;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_28:
			num2 = (short)1196556293;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0003B12C File Offset: 0x0003932C
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0003B1EC File Offset: 0x000393EC
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style DayNameLabelStyle
		{
			get
			{
				short num = (short)263781621;
				short num2 = num;
				num = (short)959053045;
				switch (num2 == num)
				{
				}
				num = (short)1391132673;
				if (num != 0)
				{
				}
				num = (short)542113792;
				short num3 = num;
				num = (short)120389632;
				if (num != 0)
				{
				}
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.DayNameLabelStyleProperty);
			}
			set
			{
				short num = (short)1164962457;
				short num2 = num;
				num = (short)1617357465;
				switch (num2 == num)
				{
				}
				num = (short)160038912;
				if (num != 0)
				{
				}
				num = (short)2067333120;
				short num3 = num;
				num = (short)94896129;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.DayNameLabelStyleProperty, value);
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0003B2A0 File Offset: 0x000394A0
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					for (;;)
					{
						num2 = (short)2132690538;
						short num3 = num2;
						num2 = (short)560088682;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B1;
						}
					}
					IL_B1:
					num2 = (short)538574848;
					if (num2 != 0)
					{
					}
					singleMonthCalendar.OnWeekLabelStyleChanged((global::System.Windows.Style)A_1.OldValue, (global::System.Windows.Style)A_1.NewValue);
					num2 = (short)958332928;
					short num4 = num2;
					num2 = (short)983826433;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					num2 = (short)80478209;
					if (num2 != 0)
					{
					}
					if (singleMonthCalendar != null)
					{
						num2 = (short)291373056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)673251330;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0003B3D4 File Offset: 0x000395D4
		protected virtual void OnWeekLabelStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
		{
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_0A:
				num = (short)1647181825;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)735779111;
					short num3 = num;
					num = (short)202119463;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)251396096;
						if (num != 0)
						{
						}
						num = (short)1037369344;
						short num4 = num;
						global::DevComponents.WpfEditors.Primitives.MonthCalendarWeekLabel[] array = this.a;
						int num5 = 0;
						num = (short)214564867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_FB;
				case 2:
					return;
				case 3:
					goto IL_FB;
				case 4:
				{
					global::DevComponents.WpfEditors.Primitives.MonthCalendarWeekLabel[] array;
					int num5;
					if (num5 >= array.Length)
					{
						num = (short)258080770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					array[num5].Style = newValue;
					num5++;
					num = (short)557645825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (this.a != null)
					{
						num = (short)941817856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_4F;
				IL_FB:
				num = (short)1604845572;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_4F:
			num = (short)986644485;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0003B564 File Offset: 0x00039764
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0003B620 File Offset: 0x00039820
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style WeekLabelStyle
		{
			get
			{
				short num = (short)1500110492;
				short num2 = num;
				num = (short)427613852;
				switch (num2 == num)
				{
				}
				num = (short)56492032;
				if (num != 0)
				{
				}
				num = (short)554369024;
				short num3 = num;
				num = (short)787939329;
				if (num != 0)
				{
				}
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.WeekLabelStyleProperty);
			}
			set
			{
				short num = (short)1855353140;
				short num2 = num;
				num = (short)1498444084;
				switch (num2 == num)
				{
				}
				num = (short)1188364289;
				if (num != 0)
				{
				}
				num = (short)1021902848;
				short num3 = num;
				num = (short)1994129408;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.WeekLabelStyleProperty, value);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0003B6D4 File Offset: 0x000398D4
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					for (;;)
					{
						num2 = (short)400848738;
						short num3 = num2;
						num2 = (short)545748834;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B0;
						}
					}
					IL_B0:
					num2 = (short)931332096;
					if (num2 != 0)
					{
					}
					singleMonthCalendar.OnDayStyleChanged((global::System.Windows.Style)A_1.OldValue, (global::System.Windows.Style)A_1.NewValue);
					num2 = (short)433979392;
					short num4 = num2;
					num2 = (short)299892737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					num2 = (short)619577345;
					if (num2 != 0)
					{
					}
					if (singleMonthCalendar != null)
					{
						num2 = (short)680984576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)639959042;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0003B80C File Offset: 0x00039A0C
		protected virtual void OnDayStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
		{
			short num = (short)1769209856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				for (;;)
				{
					IL_28:
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_194;
					case 1:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
						if (!monthCalendarDayLabel.IsTrailing)
						{
							num = (short)1750138886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D;
					}
					case 2:
						return;
					case 3:
						goto IL_194;
					case 4:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array;
						if (num3 >= array.Length)
						{
							num = (short)1613299714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel = array[num3];
						goto IL_1D1;
					}
					case 5:
						if (this.c != null)
						{
							num = (short)204341256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
						monthCalendarDayLabel.Style = newValue;
						num = (short)412024839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_8D;
					case 8:
					{
						num = (short)1158217728;
						short num4 = num;
						num = (short)2109209362;
						short num5 = num;
						num = (short)794295058;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D1;
						default:
						{
							num = (short)660602880;
							if (num != 0)
							{
							}
							global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array = this.c;
							num3 = 0;
							num = (short)1807482880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_53;
					IL_8D:
					num = (short)1426522113;
					if (num != 0)
					{
					}
					num3++;
					num = (short)1823735811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_194:
					num = (short)1677000708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D1:
					num = (short)1524498433;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_53:
				num = (short)469630981;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0003BA2C File Offset: 0x00039C2C
		// (set) Token: 0x06000320 RID: 800 RVA: 0x0003BAE4 File Offset: 0x00039CE4
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style DayStyle
		{
			get
			{
				short num = (short)355599576;
				short num2 = num;
				num = (short)274793688;
				switch (num2 == num)
				{
				}
				num = (short)1018298369;
				if (num != 0)
				{
				}
				num = (short)592969728;
				short num3 = num;
				num = (short)810942464;
				if (num != 0)
				{
				}
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.DayStyleProperty);
			}
			set
			{
				short num = (short)2117861377;
				if (num != 0)
				{
				}
				num = (short)1846167166;
				short num2 = num;
				num = (short)518080126;
				switch (num2 == num)
				{
				}
				num = (short)1087897600;
				short num3 = num;
				num = (short)425852928;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.DayStyleProperty, value);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0003BB98 File Offset: 0x00039D98
		// (set) Token: 0x06000322 RID: 802 RVA: 0x0003BC54 File Offset: 0x00039E54
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("Indicates whether multiple days can be selected by clicking each day.")]
		public bool MultiSelect
		{
			get
			{
				short num = (short)2129509012;
				short num2 = num;
				num = (short)1760606868;
				switch (num2 == num)
				{
				}
				num = (short)1439236096;
				if (num != 0)
				{
				}
				num = (short)1111425024;
				short num3 = num;
				num = (short)456196097;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.MultiSelectProperty);
			}
			set
			{
				short num = (short)652104309;
				short num2 = num;
				num = (short)1609323125;
				switch (num2 == num)
				{
				}
				num = (short)442564609;
				if (num != 0)
				{
				}
				num = (short)183500800;
				short num3 = num;
				num = (short)1164115968;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.MultiSelectProperty, value);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0003BD10 File Offset: 0x00039F10
		private static object b(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar = A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar;
			if (singleMonthCalendar != null)
			{
				short num = (short)241224446;
				short num2 = num;
				num = (short)592235262;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1656487937;
					if (num != 0)
					{
					}
					num = (short)359268352;
					if (num != 0)
					{
					}
					num = (short)377946112;
					short num3 = num;
					return singleMonthCalendar.OnCoerceDisplayMonth((global::System.DateTime)A_1);
				}
				}
			}
			return A_1;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0003BDDC File Offset: 0x00039FDC
		protected virtual global::System.DateTime OnCoerceDisplayMonth(global::System.DateTime value)
		{
			short num = (short)2100559876;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_101;
				case 1:
					if (value.Month == 1)
					{
						num = (short)699072515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C3;
				case 2:
					if (value.Day == 1)
					{
						num = (short)556400640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C3;
				case 3:
					goto IL_186;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 5:
					try
					{
						value.AddDays(-1.0);
						return value;
					}
					catch
					{
						return global::System.DateTime.Today;
					}
					goto IL_101;
				case 6:
					return value;
				case 7:
				{
					num = (short)1001844008;
					short num3 = num;
					num = (short)74313000;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_186;
					case 1:
						break;
					default:
					{
						num = (short)667811840;
						short num4 = num;
						break;
					}
					}
					num = (short)843841536;
					if (num != 0)
					{
					}
					num = (short)1492910081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_44:
				if (value.Year == 1)
				{
					num = (short)769589255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1C3;
				IL_101:
				num = (short)33095681;
				if (num != 0)
				{
				}
				value = global::System.DateTime.Today;
				num = (short)143261702;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_186:
				num = (short)539295746;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C3:
				num = (short)231342085;
				num2 = (int)((global::System.IntPtr)num);
			}
			return value;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0003BFDC File Offset: 0x0003A1DC
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)2086163407;
			short num2 = num;
			num = (short)110121935;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1502150656;
				short num3 = num;
				num = (short)1856241664;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				int num4;
				global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
				for (;;)
				{
					IL_7E:
					switch (num4)
					{
					case 0:
						return;
					case 1:
						if (singleMonthCalendar != null)
						{
							num = (short)1905262594;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						singleMonthCalendar.OnDisplayMonthChanged((global::System.DateTime)A_1.OldValue, (global::System.DateTime)A_1.NewValue);
						num = (short)1708523520;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_90:
				num = (short)568131585;
				if (num != 0)
				{
				}
				singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
				num = (short)1125842945;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7E;
			}
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0003C10C File Offset: 0x0003A30C
		protected virtual void OnDisplayMonthChanged(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			short num = (short)1405288449;
			if (num != 0)
			{
			}
			num = (short)2147162710;
			short num2 = num;
			num = (short)887495254;
			switch (num2 == num)
			{
			}
			num = (short)1638793216;
			if (num != 0)
			{
			}
			num = (short)621346816;
			short num3 = num;
			this.UpdateCalendarDisplay();
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0003C1BC File Offset: 0x0003A3BC
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0003C274 File Offset: 0x0003A474
		public global::System.DateTime DisplayMonth
		{
			get
			{
				short num = (short)1351789706;
				short num2 = num;
				num = (short)1727179914;
				switch (num2 == num)
				{
				}
				num = (short)552206336;
				if (num != 0)
				{
				}
				num = (short)780795905;
				if (num != 0)
				{
				}
				num = (short)1426915328;
				short num3 = num;
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.DisplayMonthProperty);
			}
			set
			{
				short num = (short)33816577;
				if (num != 0)
				{
				}
				num = (short)375099196;
				short num2 = num;
				num = (short)742362940;
				switch (num2 == num)
				{
				}
				num = (short)1961361408;
				if (num != 0)
				{
				}
				num = (short)1324023808;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.DisplayMonthProperty, value);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0003C32C File Offset: 0x0003A52C
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0003C3E4 File Offset: 0x0003A5E4
		public string DisplayMonthName
		{
			get
			{
				short num = (short)484020007;
				short num2 = num;
				num = (short)1311215399;
				switch (num2 == num)
				{
				}
				num = (short)1261764609;
				if (num != 0)
				{
				}
				num = (short)983433216;
				if (num != 0)
				{
				}
				num = (short)1185939456;
				short num3 = num;
				return (string)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.DisplayMonthNameProperty);
			}
			internal set
			{
				short num = (short)2002312533;
				short num2 = num;
				num = (short)204528981;
				switch (num2 == num)
				{
				}
				num = (short)1611923457;
				if (num != 0)
				{
				}
				num = (short)254148608;
				if (num != 0)
				{
				}
				num = (short)847183872;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.d, value);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0003C49C File Offset: 0x0003A69C
		private static object a(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar = A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar;
			if (singleMonthCalendar == null)
			{
				short num = (short)1497410634;
				short num2 = num;
				num = (short)537504842;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1765408769;
					if (num != 0)
					{
					}
					num = (short)1742864384;
					short num3 = num;
					num = (short)609812480;
					if (num != 0)
					{
					}
					return A_1;
				}
				}
			}
			return singleMonthCalendar.OnCoerceMonthNames((string[])A_1);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0003C560 File Offset: 0x0003A760
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)315134244;
			short num2 = num;
			num = (short)913740068;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1406533632;
				short num3 = num;
				num = (short)1114374144;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				int num4;
				global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
				for (;;)
				{
					IL_7C:
					switch (num4)
					{
					case 0:
						return;
					case 1:
						if (singleMonthCalendar != null)
						{
							num = (short)1792278530;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						singleMonthCalendar.OnMonthNamesChanged((string[])A_1.OldValue, (string[])A_1.NewValue);
						num = (short)1683554304;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_8E:
				num = (short)2059075585;
				if (num != 0)
				{
				}
				singleMonthCalendar = (A_0 as global::DevComponents.WpfEditors.SingleMonthCalendar);
				num = (short)954466305;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0003C690 File Offset: 0x0003A890
		protected virtual string[] OnCoerceMonthNames(string[] value)
		{
			int a_ = 2;
			short num = (short)511100801;
			short num2 = num;
			num = (short)217827201;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)272826368;
				short num3 = num;
				num = (short)531496960;
				if (num != 0)
				{
				}
				num = (short)1655832577;
				if (num != 0)
				{
				}
				num = (short)104988674;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_13A;
					case 1:
						if (value.Length != 12)
						{
							num = (short)1453719552;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return value;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_DB;
						}
						continue;
					case 3:
						num = (short)790757377;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DB:
					if (value == null)
					{
						break;
					}
					num = (short)1129512963;
					num4 = (int)((global::System.IntPtr)num);
				}
				return value;
			}
			}
			IL_13A:
			throw new global::System.ArgumentException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("苎뻐뷒ꇔ뿖韘뫚냜뫞鋠쏢闤闦蛨鯪裬鷮藰諲헴髶賸裺觼\udffe椀戂猄戆⤈㨊㼌⼎簐瘒研甖簘椚渜", a_));
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0003C7DC File Offset: 0x0003A9DC
		protected virtual void OnMonthNamesChanged(string[] oldValue, string[] newValue)
		{
			short num = (short)1177436128;
			short num2 = num;
			num = (short)1416183776;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1412890624;
				if (num != 0)
				{
				}
				num = (short)959578113;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)861011969;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_D6;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 2:
						this.a();
						num = (short)753860608;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A2:
					if (newValue == null)
					{
						return;
					}
					num = (short)321454082;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			}
			}
			IL_D6:
			num = (short)524746752;
			short num4 = num;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0003C8EC File Offset: 0x0003AAEC
		// (set) Token: 0x06000330 RID: 816 RVA: 0x0003C9A4 File Offset: 0x0003ABA4
		public string[] MonthNames
		{
			get
			{
				short num = (short)622061367;
				short num2 = num;
				num = (short)1156572983;
				switch (num2 == num)
				{
				}
				num = (short)1066205184;
				if (num != 0)
				{
				}
				num = (short)1261961217;
				if (num != 0)
				{
				}
				num = (short)1968963584;
				short num3 = num;
				return (string[])base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.MonthNamesProperty);
			}
			set
			{
				short num = (short)2030722110;
				short num2 = num;
				num = (short)7625790;
				switch (num2 == num)
				{
				}
				num = (short)409403392;
				if (num != 0)
				{
				}
				num = (short)2028666881;
				if (num != 0)
				{
				}
				num = (short)12582912;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.MonthNamesProperty, value);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0003CA58 File Offset: 0x0003AC58
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0003CB14 File Offset: 0x0003AD14
		public global::System.Windows.Visibility PreviousMonthButtonVisibility
		{
			get
			{
				short num = (short)2146979251;
				short num2 = num;
				num = (short)486428083;
				switch (num2 == num)
				{
				}
				num = (short)1810497537;
				if (num != 0)
				{
				}
				num = (short)1898971136;
				if (num != 0)
				{
				}
				num = (short)1762131968;
				short num3 = num;
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.PreviousMonthButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1783332668;
				short num2 = num;
				num = (short)1861648188;
				switch (num2 == num)
				{
				}
				num = (short)1026424832;
				if (num != 0)
				{
				}
				num = (short)1762721793;
				if (num != 0)
				{
				}
				num = (short)1503985664;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.PreviousMonthButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0003CBCC File Offset: 0x0003ADCC
		// (set) Token: 0x06000334 RID: 820 RVA: 0x0003CC84 File Offset: 0x0003AE84
		public global::System.Windows.Visibility NextMonthButtonVisibility
		{
			get
			{
				short num = (short)836955907;
				short num2 = num;
				num = (short)338423555;
				switch (num2 == num)
				{
				}
				num = (short)263192577;
				if (num != 0)
				{
				}
				num = (short)2000748544;
				if (num != 0)
				{
				}
				num = (short)691535872;
				short num3 = num;
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.NextMonthButtonVisibilityProperty);
			}
			set
			{
				short num = (short)2089222145;
				if (num != 0)
				{
				}
				num = (short)206311950;
				short num2 = num;
				num = (short)1177948686;
				switch (num2 == num)
				{
				}
				num = (short)912916480;
				if (num != 0)
				{
				}
				num = (short)1097072640;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.NextMonthButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0003CD40 File Offset: 0x0003AF40
		// (set) Token: 0x06000336 RID: 822 RVA: 0x0003CDFC File Offset: 0x0003AFFC
		public bool AutoNavigate
		{
			get
			{
				short num = (short)712745522;
				short num2 = num;
				num = (short)1559863858;
				switch (num2 == num)
				{
				}
				num = (short)1221525504;
				if (num != 0)
				{
				}
				num = (short)551157761;
				if (num != 0)
				{
				}
				num = (short)1747779584;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.AutoNavigateProperty);
			}
			set
			{
				short num = (short)358565874;
				short num2 = num;
				num = (short)220743666;
				switch (num2 == num)
				{
				}
				num = (short)635305984;
				if (num != 0)
				{
				}
				num = (short)1689190401;
				if (num != 0)
				{
				}
				num = (short)204341248;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.AutoNavigateProperty, value);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0003CEB8 File Offset: 0x0003B0B8
		// (set) Token: 0x06000338 RID: 824 RVA: 0x0003CF70 File Offset: 0x0003B170
		public bool AnimationEnabled
		{
			get
			{
				short num = (short)1890169845;
				short num2 = num;
				num = (short)1612559349;
				switch (num2 == num)
				{
				}
				num = (short)419233793;
				if (num != 0)
				{
				}
				num = (short)689176576;
				if (num != 0)
				{
				}
				num = (short)904724480;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.AnimationEnabledProperty);
			}
			set
			{
				short num = (short)1119097900;
				short num2 = num;
				num = (short)1769542700;
				switch (num2 == num)
				{
				}
				num = (short)729284609;
				if (num != 0)
				{
				}
				num = (short)1759641600;
				if (num != 0)
				{
				}
				num = (short)1761411072;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.AnimationEnabledProperty, value);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0003D02C File Offset: 0x0003B22C
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0003D0E8 File Offset: 0x0003B2E8
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AutoSelect
		{
			get
			{
				short num = (short)1202145563;
				short num2 = num;
				num = (short)1389316379;
				switch (num2 == num)
				{
				}
				num = (short)2011037697;
				if (num != 0)
				{
				}
				num = (short)1860435968;
				if (num != 0)
				{
				}
				num = (short)1676214272;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.AutoSelectProperty);
			}
			set
			{
				short num = (short)1266599281;
				short num2 = num;
				num = (short)682476913;
				switch (num2 == num)
				{
				}
				num = (short)1076166656;
				if (num != 0)
				{
				}
				num = (short)53739521;
				if (num != 0)
				{
				}
				num = (short)1403453440;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.AutoSelectProperty, value);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600033B RID: 827 RVA: 0x0003D1A4 File Offset: 0x0003B3A4
		// (remove) Token: 0x0600033C RID: 828 RVA: 0x0003D258 File Offset: 0x0003B458
		public event global::System.Windows.RoutedEventHandler SelectedDateChanged
		{
			add
			{
				short num = (short)840024695;
				short num2 = num;
				num = (short)1049870967;
				switch (num2 == num)
				{
				}
				num = (short)1567358977;
				if (num != 0)
				{
				}
				num = (short)1213988864;
				if (num != 0)
				{
				}
				num = (short)2028535808;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.SingleMonthCalendar.SelectedDateChangedEvent, value);
			}
			remove
			{
				short num = (short)1584703513;
				short num2 = num;
				num = (short)1122281497;
				switch (num2 == num)
				{
				}
				num = (short)847904769;
				if (num != 0)
				{
				}
				num = (short)719388672;
				if (num != 0)
				{
				}
				num = (short)833290240;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.SingleMonthCalendar.SelectedDateChangedEvent, value);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600033D RID: 829 RVA: 0x0003D30C File Offset: 0x0003B50C
		// (remove) Token: 0x0600033E RID: 830 RVA: 0x0003D3C4 File Offset: 0x0003B5C4
		public event global::System.Windows.RoutedEventHandler PreviewSelectedDateChanged
		{
			add
			{
				short num = (short)1416429193;
				short num2 = num;
				num = (short)1736507017;
				switch (num2 == num)
				{
				}
				num = (short)959840257;
				if (num != 0)
				{
				}
				num = (short)1992818688;
				if (num != 0)
				{
				}
				num = (short)53542912;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.SingleMonthCalendar.PreviewSelectedDateChangedEvent, value);
			}
			remove
			{
				short num = (short)485245475;
				short num2 = num;
				num = (short)921387555;
				switch (num2 == num)
				{
				}
				num = (short)325386240;
				if (num != 0)
				{
				}
				num = (short)934019073;
				if (num != 0)
				{
				}
				num = (short)432275456;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.SingleMonthCalendar.PreviewSelectedDateChangedEvent, value);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0003D478 File Offset: 0x0003B678
		protected virtual void OnSelectedDateChanged()
		{
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.SingleMonthCalendar.PreviewSelectedDateChangedEvent);
			base.RaiseEvent(routedEventArgs);
			if (!routedEventArgs.Handled)
			{
				short num = (short)725716775;
				short num2 = num;
				num = (short)1443532583;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)729743361;
					if (num != 0)
					{
					}
					num = (short)1580924928;
					short num3 = num;
					num = (short)1449394176;
					if (num != 0)
					{
					}
					global::System.Windows.RoutedEventArgs routedEventArgs2 = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.SingleMonthCalendar.SelectedDateChangedEvent);
					base.RaiseEvent(routedEventArgs2);
					return;
				}
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0003D550 File Offset: 0x0003B750
		internal global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] DayLabels
		{
			get
			{
				short num = (short)1208607403;
				short num2 = num;
				num = (short)1223549611;
				switch (num2 == num)
				{
				}
				num = (short)2063728641;
				if (num != 0)
				{
				}
				num = (short)1511456768;
				if (num != 0)
				{
				}
				num = (short)459603968;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0003D600 File Offset: 0x0003B800
		public global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel GetDay(global::System.DateTime date)
		{
			short num = (short)1532821504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				int num3;
				global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array;
				global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_15E;
					case 1:
					{
						global::System.DateTime date2;
						if (date2.Month == date.Month)
						{
							num = (short)1036779523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A;
					}
					case 2:
					{
						num = (short)256114689;
						if (num != 0)
						{
						}
						if (num3 >= array.Length)
						{
							num = (short)399835142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						monthCalendarDayLabel = array[num3];
						global::System.DateTime date2 = monthCalendarDayLabel.Date;
						num = (short)1751908361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_24F;
					case 4:
						num = (short)567279617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.DateTime date2;
						if (date2.Day == date.Day)
						{
							num = (short)1253834759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A;
					}
					case 6:
					{
						num = (short)2111504799;
						short num4 = num;
						num = (short)756482463;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_24F;
						default:
							goto IL_1F5;
						}
						break;
					}
					case 7:
						return monthCalendarDayLabel;
					case 8:
					{
						num = (short)2056519680;
						short num5 = num;
						goto IL_15E;
					}
					case 9:
					{
						global::System.DateTime date2;
						if (date2.Year == date.Year)
						{
							num = (short)1350238212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A;
					}
					}
					goto IL_56;
					IL_7A:
					num3++;
					num = (short)884408328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E:
					num = (short)1833172994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24F:
					num = (short)1477640197;
					num2 = (int)((global::System.IntPtr)num);
				}
				return monthCalendarDayLabel;
				IL_1F5:
				num = (short)700514304;
				if (num != 0)
				{
				}
				return null;
				IL_56:
				array = this.c;
				num3 = 0;
				num = (short)1238892544;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0003D864 File Offset: 0x0003BA64
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0003D91C File Offset: 0x0003BB1C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::DevComponents.WpfEditors.MonthCalendar OwnerMonthCalendar
		{
			get
			{
				short num = (short)140546159;
				short num2 = num;
				num = (short)2122027119;
				switch (num2 == num)
				{
				}
				num = (short)649986049;
				if (num != 0)
				{
				}
				num = (short)2138963968;
				if (num != 0)
				{
				}
				num = (short)360775680;
				short num3 = num;
				return (global::DevComponents.WpfEditors.MonthCalendar)base.GetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.OwnerMonthCalendarProperty);
			}
			set
			{
				short num = (short)1785958675;
				short num2 = num;
				num = (short)63672595;
				switch (num2 == num)
				{
				}
				num = (short)559480833;
				if (num != 0)
				{
				}
				num = (short)1223950336;
				if (num != 0)
				{
				}
				num = (short)1641611264;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.SingleMonthCalendar.OwnerMonthCalendarProperty, value);
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0003D9D4 File Offset: 0x0003BBD4
		static SingleMonthCalendar()
		{
			int a_ = 4;
			short num = (short)740285872;
			short num2 = num;
			num = (short)1086643632;
			switch (num2 == num)
			{
			}
			num = (short)557121536;
			if (num != 0)
			{
			}
			num = (short)943980545;
			if (num != 0)
			{
			}
			num = (short)1454899200;
			short num3 = num;
			global::DevComponents.WpfEditors.SingleMonthCalendar.FirstDayOfWeekProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韐뫒꟔ꓖ귘鿚볜ꛞ껠藢다苦賨胪", a_), typeof(global::System.DayOfWeek), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.DayOfWeek.Sunday, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.r)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.TwoLetterDayNameProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藐ꓒ뫔鯖볘꿚꧜뫞鏠꟢蓤黦꟨諪胬諮", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.q)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.ShowTodayMarkerProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("苐믒뫔ꃖ跘듚맜뻞飠껢蓤闦苨軪鿬", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.p)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.ShowWeekNumbersProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("苐믒뫔ꃖ軘뻚룜듞꿠離裤藦賨駪黬", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.o)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.WeekendDaysSelectableProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蛐뛒냔볖볘뗚맜鯞胠髢雤듦賨蟪裬賮藰鋲韴鯶鳸", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.n)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.SelectedDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("苐뛒맔닖뫘꿚룜믞ꗠ苢釤苦", a_), typeof(global::System.DateTime?), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.m), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.d)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.WeekOfYearRuleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蛐뛒냔볖雘뷚蓜뫞胠釢럤鋦藨軪", a_), typeof(global::System.Globalization.CalendarWeekRule), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.Globalization.CalendarWeekRule.FirstDay, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.l)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.TrailingDaysVisibleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藐ꇒ듔뻖뗘닚돜룞ꗠ苢鳤铦뿨苪黬蛮鏰鿲郴", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.k)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.DayNamesProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闐닒곔駖룘뛚룜곞", a_), typeof(string[]), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.j), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.c)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.TodayDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藐볒뇔뛖ꃘ鿚볜ꯞ蓠", a_), typeof(global::System.DateTime?), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.i)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.MinDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳐뫒믔鏖룘꿚룜", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.MinValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.h)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.MaxDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳐닒귔鏖룘꿚룜", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.MaxValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.g)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.TrailingDayStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藐ꇒ듔뻖뗘닚돜룞ꗠ苢鳤듦鷨鋪臬諮", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.f)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.DayNameLabelStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闐닒곔駖룘뛚룜鏞胠臢胤详뫨鿪铬菮铰", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.e)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.WeekLabelStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蛐뛒냔볖闘뫚뿜뫞跠냢釤黦藨軪", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.d)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.DayStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闐닒곔蓖귘ꋚ뇜뫞", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.c)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.MultiSelectProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳐ꛒ맔ꏖ냘裚룜돞蓠胢釤", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfEditors.SingleMonthCalendar.DisplayMonthProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闐뫒ꛔꟖ뗘뫚ꓜ鋞軠跢釤迦", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.Today, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.b), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.b)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.d = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闐뫒ꛔꟖ뗘뫚ꓜ鋞軠跢釤迦꟨諪胬諮", a_), typeof(string), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(""));
			global::DevComponents.WpfEditors.SingleMonthCalendar.DisplayMonthNameProperty = global::DevComponents.WpfEditors.SingleMonthCalendar.d.DependencyProperty;
			global::DevComponents.WpfEditors.SingleMonthCalendar.MonthNamesProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳐볒믔ꏖ뇘闚볜닞蓠郢", a_), typeof(string[]), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.a), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.SingleMonthCalendar.a)));
			global::DevComponents.WpfEditors.SingleMonthCalendar.PreviousMonthButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("臐ꇒ냔ꇖ냘듚꣜곞고賢诤鏦臨ꧪ飬鯮藰鳲鯴ꇶ郸裺铼鷾栀漂氄猆瀈", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::DevComponents.WpfEditors.SingleMonthCalendar.NextMonthButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鿐뛒귔ꏖ铘듚돜ꯞ觠ꇢ郤鏦鷨蓪菬맮飰胲鳴闶郸韺铼课砀", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::DevComponents.WpfEditors.SingleMonthCalendar.AutoNavigateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郐ꛒꇔ룖韘뫚ꯜ뛞蛠苢釤苦", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.SingleMonthCalendar.AnimationEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郐뷒볔뫖룘꿚드냞迠ꛢ诤蛦诨蟪裬诮", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.SingleMonthCalendar.AutoSelectProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郐ꛒꇔ룖諘뻚뇜뫞苠韢", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.SingleMonthCalendar.SelectedDateChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("苐뛒맔닖뫘꿚룜믞ꗠ苢釤苦ꫨ菪賬臮雰雲釴", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar));
			global::DevComponents.WpfEditors.SingleMonthCalendar.PreviewSelectedDateChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("臐ꇒ냔ꇖ냘뻚ꫜ賞蓠迢胤蓦鷨軪觬꯮郰蟲郴듶釸髺鏼飾搀朂", a_), global::System.Windows.RoutingStrategy.Tunnel, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar));
			global::DevComponents.WpfEditors.SingleMonthCalendar.OwnerMonthCalendarProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("黐ꓒ믔닖ꯘ雚닜뇞闠询ꛤ蛦藨軪菬诮郰臲", a_), typeof(global::DevComponents.WpfEditors.MonthCalendar), typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.UIPropertyMetadata(null));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.SingleMonthCalendar)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), global::System.Windows.Controls.Primitives.ToggleButton.CheckedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.SingleMonthCalendar.b));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.SingleMonthCalendar), global::System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.SingleMonthCalendar.a));
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0003E1D0 File Offset: 0x0003C3D0
		private static void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)196666013;
			short num2 = num;
			num = (short)2097603229;
			switch (num2 == num)
			{
			}
			num = (short)384368641;
			if (num != 0)
			{
			}
			num = (short)725155840;
			if (num != 0)
			{
			}
			num = (short)1262485504;
			short num3 = num;
			((global::DevComponents.WpfEditors.SingleMonthCalendar)A_0).b(A_1);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0003E284 File Offset: 0x0003C484
		private void b(global::System.Windows.RoutedEventArgs A_0)
		{
			short num = (short)1873674245;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel = A_0.OriginalSource as global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel;
					num = (short)498204676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (this.AutoSelect)
					{
						num = (short)1902379008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)432603136;
					short num3 = num;
					num = (short)408765399;
					short num4 = num;
					num = (short)1570522071;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C;
					default:
						goto IL_1A0;
					}
					break;
				}
				case 3:
					num = (short)419299329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
					if (monthCalendarDayLabel == null)
					{
						num = (short)1672216577;
						if (num != 0)
						{
						}
						num = (short)1860173830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.SelectedDate = new global::System.DateTime?(monthCalendarDayLabel.Date);
					num = (short)1209597954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 6:
					goto IL_D9;
				}
				goto IL_41;
				IL_4C:
				num = (short)626917379;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41:
				if (!this.MultiSelect)
				{
					goto IL_4C;
				}
				return;
			}
			IL_D9:
			this.SelectedDate = null;
			return;
			IL_1A0:
			num = (short)1452670976;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0003E448 File Offset: 0x0003C648
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)326701641;
			short num2 = num;
			num = (short)1130238537;
			switch (num2 == num)
			{
			}
			num = (short)816971776;
			if (num != 0)
			{
			}
			num = (short)486080513;
			if (num != 0)
			{
			}
			num = (short)1686831104;
			short num3 = num;
			((global::DevComponents.WpfEditors.SingleMonthCalendar)A_0).a(A_1);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0003E500 File Offset: 0x0003C700
		private void a(global::System.Windows.RoutedEventArgs A_0)
		{
			int a_ = 2;
			for (;;)
			{
				IL_09:
				short num = (short)37421063;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Controls.Button button;
						if (button.Name == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跎ꓐ꟒ꇔ룖럘诚꿜뫞韠諢諤鋦髨ꛪ苬臮藰鯲", a_))
						{
							num = (short)833355778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2106130438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						A_0.Handled = true;
						this.NextMonth();
						num = (short)1646985221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_22D;
					case 3:
					{
						num = (short)1330018970;
						short num3 = num;
						num = (short)117865114;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						case 1:
							break;
						default:
						{
							num = (short)419233792;
							short num4 = num;
							break;
						}
						}
						num = (short)2054160384;
						if (num != 0)
						{
						}
						num = (short)541917184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)20119553;
						if (num != 0)
						{
						}
						global::System.Windows.Controls.Button button = A_0.OriginalSource as global::System.Windows.Controls.Button;
						num = (short)1713373192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_164;
					case 6:
					{
						global::System.Windows.Controls.Button button;
						if (button.Name == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跎ꓐ꟒ꇔ룖럘闚룜꟞闠껢諤触鷨菪", a_))
						{
							num = (short)929431553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_52;
						}
						continue;
					case 8:
					{
						global::System.Windows.Controls.Button button;
						if (button != null)
						{
							num = (short)83296259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_52:
					if (!this.AutoNavigate)
					{
						return;
					}
					num = (short)1768095748;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_164:
			return;
			IL_22D:
			A_0.Handled = true;
			this.PreviousMonth();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0003E740 File Offset: 0x0003C940
		public void PreviousMonth()
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			global::DevComponents.WpfEditors.StateAnimationControl stateAnimationControl;
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (stateAnimationControl != null)
					{
						num2 = (short)606438335;
						short num3 = num2;
						num2 = (short)80184255;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1FF;
						case 1:
							break;
						default:
						{
							num2 = (short)509542400;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1197932544;
						if (num2 != 0)
						{
						}
						num2 = (short)939196424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12F;
				case 1:
					if (this.AnimationEnabled)
					{
						num2 = (short)1602682883;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12F;
				case 2:
					goto IL_1FF;
				case 3:
					stateAnimationControl.AnimationType = global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromLeftToRight;
					stateAnimationControl.StartStateTransition();
					flag = true;
					num2 = (short)248119305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!stateAnimationControl.IsAnimating)
					{
						num2 = (short)1470038018;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12F;
				case 5:
					if (flag)
					{
						num2 = (short)1496907783;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					return;
				case 7:
					stateAnimationControl.AnimateStateTransition();
					num2 = (short)763363334;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1593180164;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_12F;
				}
				goto IL_41;
				IL_12F:
				global::System.DateTime displayMonth = this.DisplayMonth.AddMonths(-1);
				this.DisplayMonth = displayMonth;
				num2 = (short)2053767173;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FF:
				num2 = (short)1496842241;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_41:
			num2 = (short)788856833;
			if (num2 != 0)
			{
			}
			stateAnimationControl = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觙꣛뿝铟蟡ꗣ裥臧蟩跫髭駯鷱髳", a_)) as global::DevComponents.WpfEditors.StateAnimationControl);
			flag = false;
			num2 = (short)1628962816;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0003E98C File Offset: 0x0003CB8C
		public void NextMonth()
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			global::DevComponents.WpfEditors.StateAnimationControl stateAnimationControl;
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (stateAnimationControl == null)
					{
						goto IL_105;
					}
					num2 = (short)1185910801;
					short num3 = num2;
					num2 = (short)1303482385;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_200;
					default:
					{
						num2 = (short)229376000;
						short num4 = num2;
						num2 = (short)1159069696;
						if (num2 != 0)
						{
						}
						num2 = (short)2103836680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					if (this.AnimationEnabled)
					{
						num2 = (short)1413939203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_105;
				case 2:
					goto IL_200;
				case 3:
					stateAnimationControl.AnimationType = global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromRightToLeft;
					stateAnimationControl.StartStateTransition();
					flag = true;
					num2 = (short)518258697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!stateAnimationControl.IsAnimating)
					{
						num2 = (short)2124808194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_105;
				case 5:
					if (flag)
					{
						num2 = (short)2117533703;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					return;
				case 7:
					num2 = (short)1629421569;
					if (num2 != 0)
					{
					}
					stateAnimationControl.AnimateStateTransition();
					num2 = (short)1419968518;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)12189700;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_105;
				}
				goto IL_41;
				IL_105:
				global::System.DateTime displayMonth = this.DisplayMonth.AddMonths(1);
				this.DisplayMonth = displayMonth;
				num2 = (short)1651507205;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_200:
				num2 = (short)1209466881;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_41:
			stateAnimationControl = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("苐꟒듔ꏖ볘髚돜뛞賠苢釤軦蛨藪", a_)) as global::DevComponents.WpfEditors.StateAnimationControl);
			flag = false;
			num2 = (short)214106112;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0003EBDC File Offset: 0x0003CDDC
		public override void OnApplyTemplate()
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num3;
			int num5;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_E3;
				case 1:
					goto IL_203;
				case 2:
				{
					int num2;
					if (num2 >= 43)
					{
						num3 = (short)680001540;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.c[num2 - 1] = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鿚볜ꛞ", a_) + num2.ToString()) as global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel);
					num2++;
					num3 = (short)863633417;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 3:
					goto IL_10D;
				case 4:
					goto IL_1B3;
				case 5:
				{
					int num4;
					if (num4 >= 8)
					{
						num3 = (short)1493106699;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.b[num4 - 1] = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鿚볜ꛞ꿠苢裤苦", a_) + num4.ToString()) as global::DevComponents.WpfEditors.Primitives.MonthCalendarDayNameLabel);
					num4++;
					num3 = (short)298254344;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 6:
					if (num5 >= 7)
					{
						num3 = (short)1803026442;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.a[num5 - 1] = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("賚룜뫞諠귢郤諦诨軪鿬", a_) + num5.ToString()) as global::DevComponents.WpfEditors.Primitives.MonthCalendarWeekLabel);
					num5++;
					num3 = (short)1878654977;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					goto IL_17D;
				case 8:
					goto IL_10D;
				case 9:
					goto IL_17D;
				case 10:
				{
					this.b = new global::DevComponents.WpfEditors.Primitives.MonthCalendarDayNameLabel[7];
					int num4 = 1;
					num3 = (short)318767107;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 11:
				{
					this.c = new global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[42];
					int num2 = 1;
					num3 = (short)1798635527;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				}
				goto IL_49;
				IL_10D:
				num3 = (short)1822621701;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_17D:
				num3 = (short)1213333506;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_E3:
			goto IL_144;
			IL_1B3:
			this.UpdateCalendarDisplay();
			base.OnApplyTemplate();
			return;
			IL_49:
			num3 = (short)879040960;
			short num6 = num3;
			num3 = (short)1715018176;
			switch ((num6 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_203:
				num3 = (short)973799425;
				if (num3 != 0)
				{
				}
				goto IL_144;
			case 1:
				break;
			default:
			{
				num3 = (short)347734016;
				short num7 = num3;
				break;
			}
			}
			num3 = (short)813367296;
			if (num3 != 0)
			{
			}
			this.a = new global::DevComponents.WpfEditors.Primitives.MonthCalendarWeekLabel[6];
			num5 = 1;
			num3 = (short)967639040;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
			IL_144:
			num3 = (short)928120838;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0003EEEC File Offset: 0x0003D0EC
		public void UpdateCalendarDisplay()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1129316352;
				short num2 = num;
				num = (short)1791819776;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 1:
					{
						global::System.DateTime displayMonth = this.DisplayMonth;
						this.b(displayMonth.Month, displayMonth.Year);
						num = (short)2129657859;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1210384385;
						if (num != 0)
						{
						}
						if (this.c == null)
						{
							return;
						}
						num = (short)771035572;
						short num4 = num;
						num = (short)848040372;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1234829312;
							if (num != 0)
							{
							}
							num = (short)1247084545;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						num = (short)919666690;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_60:
					if (!base.IsInitialized)
					{
						return;
					}
					num = (short)1857552388;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0003F060 File Offset: 0x0003D260
		private bool a(global::System.DateTime A_0, global::System.DateTime? A_1)
		{
			short num = (short)79725947;
			short num2 = num;
			num = (short)9274747;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)790626304;
				if (num != 0)
				{
				}
				if (A_1 != null)
				{
					num = (short)1612578816;
					short num3 = num;
					return this.a(A_0, A_1.Value);
				}
				num = (short)834011137;
				if (num != 0)
				{
				}
				break;
			}
			return false;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0003F128 File Offset: 0x0003D328
		private bool a(global::System.DateTime A_0, global::System.DateTime A_1)
		{
			short num = (short)1992256465;
			short num2 = num;
			num = (short)357657553;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_123:
				if (A_0.Month != A_1.Month)
				{
					return false;
				}
				num = (short)44302338;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)844496896;
				if (num != 0)
				{
				}
				num = (short)814743552;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					continue;
				case 1:
					goto IL_123;
				case 2:
					goto IL_14B;
				case 3:
					num = (short)223608833;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_80:
				num = (short)1530527745;
				if (num != 0)
				{
				}
				if (A_0.Year != A_1.Year)
				{
					return false;
				}
				num = (short)309002243;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_14B:
			num = (short)1310720000;
			short num4 = num;
			return A_0.Day == A_1.Day;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0003F284 File Offset: 0x0003D484
		private void b(int A_0, int A_1)
		{
			short num = (short)1801388032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_23A;
				}
				global::System.DateTime dateTime2;
				string[] array3;
				string[] shortestDayNames;
				for (;;)
				{
					IL_27:
					bool[] array;
					global::System.DateTime dateTime;
					int num3;
					int num4;
					global::System.Windows.Style style;
					global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
					global::System.Windows.Style a_;
					global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel2;
					global::System.Windows.Style a_2;
					bool[] array2;
					global::System.DateTime dateTime3;
					global::System.Windows.Style a_3;
					bool flag;
					global::System.Windows.Style a_4;
					global::System.Windows.Style style3;
					int num6;
					global::System.DateTime dateTime4;
					bool[] array4;
					int num8;
					int num9;
					global::DevComponents.WpfEditors.Primitives.MonthCalendarWeekLabel monthCalendarWeekLabel;
					int num10;
					int num11;
					int num12;
					switch (num2)
					{
					case 0:
						if (array[dateTime.Day - 1])
						{
							num = (short)1514602547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D74;
					case 1:
						goto IL_9B7;
					case 2:
						if (num3 > 0)
						{
							num = (short)550961248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EE3;
					case 3:
						goto IL_CD7;
					case 4:
						num4 += num3;
						num = (short)103743531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						style = this.DayNameLabelStyle;
						num = (short)676266095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Windows.Style style2 = null;
						num = (short)60489736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_1026;
					case 8:
						if (this.TrailingDayStyle != null)
						{
							num = (short)601423975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15BA;
					case 9:
						num = (short)1642135599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						this.a(monthCalendarDayLabel, a_);
						num = (short)115802156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						this.c(monthCalendarDayLabel2, a_2);
						num = (short)940900453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)516751386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (array2[dateTime2.Day - 1])
						{
							num = (short)1757741109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD2;
					case 14:
						if (global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.a(dateTime))
						{
							num = (short)1879572510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A52;
					case 15:
					{
						global::System.DateTime? todayDate = this.TodayDate;
						num = (short)2112290875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::System.Windows.Style style2;
						if (style2 != null)
						{
							num = (short)314572900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_862;
					}
					case 17:
						if (this.DayStyle != null)
						{
							num = (short)1492975651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8FA;
					case 18:
						goto IL_8D3;
					case 19:
						monthCalendarDayLabel2.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)1564737663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						dateTime3 = global::System.DateTime.Today;
						goto IL_78F;
					case 21:
						if (this.TrailingDaysVisible)
						{
							num = (short)161808396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					case 22:
					{
						if (this.DayNames == null)
						{
							goto IL_F28;
						}
						num = (short)2064982807;
						short num5 = num;
						num = (short)2024940311;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8D3;
						default:
							num = (short)60030976;
							if (num != 0)
							{
							}
							num = (short)1010171940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 23:
						a_3 = this.WeekLabelStyle;
						num = (short)1003880542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_C9D;
					case 25:
						monthCalendarDayLabel2.Selectable = false;
						num = (short)590545021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (this.TrailingDaysBeforeVisible)
						{
							num = (short)302907448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_318;
					case 27:
						num = (short)1781334030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_BCD;
					case 29:
						goto IL_613;
					case 30:
						monthCalendarDayLabel.Selectable = false;
						num = (short)1650131017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_120E;
					case 32:
						if (flag)
						{
							num = (short)312148010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92C;
					case 33:
						this.b(monthCalendarDayLabel, a_4);
						num = (short)334692438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						monthCalendarDayLabel2.IsChecked = new bool?(true);
						num = (short)1957363741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						style3 = this.DayStyle;
						num = (short)961609798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						array3 = this.DayNames;
						num = (short)2095317046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (A_1 == dateTime.Year)
						{
							num = (short)707854403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D74;
					case 38:
						if (num6 > 6)
						{
							num = (short)1801257055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1112;
					case 39:
						if (dateTime2.Month != A_0)
						{
							num = (short)1275265128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						monthCalendarDayLabel2.Style = style3;
						monthCalendarDayLabel2.IsTrailing = false;
						num = (short)20185160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)609484922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						if (!this.ShowTodayMarker)
						{
							num = (short)236650505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.DateTime? todayDate = this.TodayDate;
						num = (short)1761214593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						num = (short)1447690285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_EE3;
					case 44:
						goto IL_1144;
					case 45:
						if (this.a(dateTime4, dateTime2))
						{
							num = (short)104398848;
							short num7 = num;
							num = (short)120782923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92C;
					case 46:
						if (num3 < 0)
						{
							num = (short)3866723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_120E;
					case 47:
						dateTime3 = global::System.DateTime.MinValue;
						goto IL_78F;
					case 48:
						goto IL_CDC;
					case 49:
						num = (short)10223731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						goto IL_AA3;
					case 51:
						this.c(monthCalendarDayLabel, a_2);
						num = (short)1160052829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (!this.WeekendDaysSelectable)
						{
							num = (short)112001051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A52;
					case 53:
						this.a(monthCalendarDayLabel2, a_);
						num = (short)543817851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_F28;
					case 55:
						goto IL_613;
					case 56:
						monthCalendarDayLabel.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)657326128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_1026;
					case 58:
						if (A_0 == dateTime2.Month)
						{
							num = (short)1923416169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B7;
					case 59:
					{
						global::System.DateTime? todayDate;
						dateTime3 = todayDate.Value;
						goto IL_78F;
					}
					case 60:
						num = (short)1825964111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)1191968805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_15BA;
					case 63:
						goto IL_CDC;
					case 64:
						goto IL_BCD;
					case 65:
						if (array4[dateTime2.Day - 1])
						{
							num = (short)85655682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B7;
					case 66:
						goto IL_1112;
					case 67:
						num = (short)2077753344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (array2[dateTime.Day - 1])
						{
							num = (short)680919050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1144;
					case 69:
						num = (short)1685651553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						goto IL_8FA;
					case 71:
						if (num8 >= 7)
						{
							num = (short)952369158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2082144377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (this.a(monthCalendarDayLabel2.Date, this.SelectedDate))
						{
							num = (short)1589116962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_613;
					case 73:
						goto IL_A52;
					case 74:
						if (array[dateTime2.Day - 1])
						{
							num = (short)366215179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1416;
					case 75:
						monthCalendarDayLabel2.IsToday = true;
						num = (short)596312181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (dateTime2.Month != A_0)
						{
							num = (short)122486894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_478;
					case 77:
						monthCalendarWeekLabel = this.a[num9];
						monthCalendarWeekLabel.Content = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().Calendar.GetWeekOfYear(dateTime2, this.WeekOfYearRule, this.FirstDayOfWeek).ToString();
						monthCalendarWeekLabel.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)1676410956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.a(dateTime2))
						{
							num = (short)756875289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58C;
					case 79:
						if (array4[dateTime.Day - 1])
						{
							num = (short)79822881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BD;
					case 80:
						if (A_0 == dateTime2.Month)
						{
							num = (short)1607663742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1416;
					case 81:
						if (A_0 == dateTime.Month)
						{
							num = (short)1874329660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BD;
					case 82:
						if (this.WeekLabelStyle != null)
						{
							num = (short)1250295831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33E;
					case 83:
						goto IL_1090;
					case 84:
					{
						global::System.Windows.Style style2;
						monthCalendarDayLabel.Style = style2;
						num = (short)458752088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						goto IL_C9D;
					case 86:
						goto IL_4BD;
					case 87:
						if (this.DayNameLabelStyle != null)
						{
							num = (short)816447493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D56;
					case 88:
						goto IL_82C;
					case 89:
						goto IL_AA3;
					case 90:
						if (num10 >= num4 + num3)
						{
							num = (short)803930116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						monthCalendarDayLabel = this.c[num10];
						monthCalendarDayLabel.Date = dateTime;
						monthCalendarDayLabel.Visibility = global::System.Windows.Visibility.Visible;
						this.a(monthCalendarDayLabel);
						num = (short)1532493915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						if (flag)
						{
							num = (short)1313800232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1090;
					case 92:
						goto IL_DB0;
					case 93:
						goto IL_D74;
					case 94:
						goto IL_33E;
					case 95:
						num6 = 0;
						num = (short)900726850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						dateTime = dateTime2;
						num = (short)1427964032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						monthCalendarWeekLabel.Visibility = (this.TrailingDaysVisible ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
						num = (short)862322752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						if (!this.WeekendDaysSelectable)
						{
							num = (short)1362100332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58C;
					case 99:
						num3 = 7 + num3;
						num = (short)546897951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
					{
						global::System.Windows.Style style2;
						monthCalendarDayLabel2.Style = style2;
						num = (short)264044656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 101:
						goto IL_1416;
					case 102:
						num = (short)1434386552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
					{
						global::System.Windows.Style style2 = this.TrailingDayStyle;
						num = (short)1209925694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 104:
						num = (short)2135359504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						num = (short)61472833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
					{
						global::System.Windows.Style style2;
						if (style2 != null)
						{
							num = (short)410648660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82C;
					}
					case 107:
					{
						global::System.DateTime dateTime5;
						if (dateTime5.Month != A_0)
						{
							num = (short)41222213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_478;
					}
					case 108:
						num = (short)269484110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						try
						{
							dateTime2 = dateTime2.AddDays(1.0);
							goto IL_C35;
						}
						catch (global::System.ArgumentOutOfRangeException)
						{
							goto IL_167B;
						}
						goto IL_EE3;
						IL_C35:
						num11++;
						num12++;
						num = (short)1268711448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
					{
						global::System.DateTime dateTime5 = dateTime2.AddDays((double)(-(double)num11));
						num = (short)1471479915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 111:
						goto IL_D56;
					case 112:
						goto IL_862;
					case 113:
						if (num11 == 6)
						{
							num = (short)261423153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_718;
					case 114:
						if (this.TrailingDaysVisible)
						{
							num = (short)1903558758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_544;
					case 115:
						if (this.ShowWeekNumbers)
						{
							num = (short)1151270989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a[num9].Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)333054002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						goto IL_DB0;
					case 117:
						goto IL_92C;
					case 118:
						goto IL_718;
					case 119:
						if (A_0 == dateTime.Month)
						{
							num = (short)191823933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D74;
					case 120:
						if (this.TrailingDaysAfterVisible)
						{
							num = (short)1601044499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_544;
					case 121:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayNameLabel monthCalendarDayNameLabel = this.b[num8];
						monthCalendarDayNameLabel.Content = (this.TwoLetterDayName ? this.a(shortestDayNames[num6]) : array3[num6]);
						monthCalendarDayNameLabel.Visibility = global::System.Windows.Visibility.Visible;
						monthCalendarDayNameLabel.Style = style;
						num6++;
						num = (short)1582104614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 122:
						if (dateTime4 == dateTime)
						{
							num = (short)262471698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1090;
					case 123:
						goto IL_AD2;
					case 124:
						if (num12 >= 42)
						{
							num = (short)1146880003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						monthCalendarDayLabel2 = this.c[num12];
						monthCalendarDayLabel2.Date = dateTime2;
						this.a(monthCalendarDayLabel2);
						num = (short)1059520544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						goto IL_58C;
					case 126:
						num = (short)1232273482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						goto IL_613;
					case 128:
						try
						{
							dateTime = dateTime.AddDays((double)(-(double)num3));
							goto IL_56A;
						}
						catch
						{
							goto IL_56A;
						}
						goto IL_478;
						IL_56A:
						num10 = num4;
						num = (short)1650130951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 129:
					{
						global::System.DateTime? todayDate;
						if (todayDate != null)
						{
							num = (short)517996559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)549191700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 130:
						this.b(monthCalendarDayLabel2, a_4);
						num = (short)1320353793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_23A;
					IL_318:
					monthCalendarDayLabel.Visibility = global::System.Windows.Visibility.Hidden;
					num = (short)1949368383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33E:
					style3 = null;
					num = (short)1121976337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_478:
					monthCalendarWeekLabel.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)1268449308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BD:
					num = (short)442826871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_544:
					monthCalendarDayLabel2.Visibility = global::System.Windows.Visibility.Hidden;
					num = (short)113180727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58C:
					monthCalendarDayLabel2.IsEnabled = this.a(dateTime2);
					monthCalendarDayLabel2.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)892469287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_613:
					num = (short)961150989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_718:
					num = (short)2101674093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_78F:
					dateTime4 = dateTime3;
					flag = (dateTime4 != global::System.DateTime.MinValue);
					int firstDayOfWeek;
					num3 = dateTime2.DayOfWeek - (global::System.DayOfWeek)firstDayOfWeek;
					num = (short)1073414190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_82C:
					dateTime = dateTime.AddDays(1.0);
					num10++;
					num = (short)1489305657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_862:
					monthCalendarDayLabel2.IsTrailing = true;
					num = (short)1286799474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D3:
					monthCalendarDayLabel.IsToday = true;
					num = (short)534773843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8FA:
					num9 = 0;
					num11 = num4 % 7;
					num12 = num4;
					num = (short)2087518293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_92C:
					num = (short)1197801570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9B7:
					num = (short)971440208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A52:
					monthCalendarDayLabel.IsEnabled = this.a(dateTime);
					num = (short)871890965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA3:
					num9++;
					num11 = -1;
					num = (short)810877046;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD2:
					num = (short)79167546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BCD:
					this.a(monthCalendarWeekLabel, a_3);
					num = (short)927531097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C9D:
					num = (short)745341052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CDC:
					monthCalendarDayLabel.IsTrailing = true;
					num = (short)310444100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D56:
					num8 = 0;
					num = (short)142671964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D74:
					num = (short)1650458730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DB0:
					num = (short)1309474887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EE3:
					a_3 = null;
					num = (short)1726087250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F28:
					firstDayOfWeek = (int)this.FirstDayOfWeek;
					num6 = firstDayOfWeek;
					style = null;
					num = (short)1608712279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1026:
					num = (short)403701850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1090:
					num = (short)1109852212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1112:
					num8++;
					num = (short)1029963892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1144:
					num = (short)1250689105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_120E:
					num4 = 0;
					num = (short)1452343298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1416:
					num = (short)1192099953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15BA:
					array2 = this.b();
					array4 = this.a(A_0);
					array = this.a(A_0, A_1);
					a_ = this.c();
					a_4 = this.e();
					a_2 = this.f();
					num = (short)1311637545;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CD7:
				IL_167B:
				this.a();
				return;
				IL_23A:
				dateTime2 = new global::System.DateTime(A_1, A_0, 1);
				array3 = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.AbbreviatedDayNames;
				shortestDayNames = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.ShortestDayNames;
				num = (short)1636696065;
				if (num != 0)
				{
				}
				num = (short)605552662;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00040930 File Offset: 0x0003EB30
		private global::System.Windows.Style f()
		{
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar = this.d();
			short num;
			if (monthCalendar != null)
			{
				num = (short)1595147914;
				short num2 = num;
				num = (short)718407306;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1268056065;
					if (num != 0)
					{
					}
					num = (short)1249902592;
					if (num != 0)
					{
					}
					return monthCalendar.MarkedDatesStyle;
				}
			}
			num = (short)618856448;
			short num3 = num;
			return null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000409F0 File Offset: 0x0003EBF0
		private global::System.Windows.Style e()
		{
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar = this.d();
			short num;
			if (monthCalendar != null)
			{
				num = (short)5911023;
				short num2 = num;
				num = (short)711537135;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)355139585;
					if (num != 0)
					{
					}
					num = (short)272171008;
					if (num != 0)
					{
					}
					return monthCalendar.AnnuallyMarkedDatesStyle;
				}
			}
			num = (short)28377088;
			short num3 = num;
			return null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00040AAC File Offset: 0x0003ECAC
		private global::DevComponents.WpfEditors.MonthCalendar d()
		{
			short num = (short)613253726;
			short num2 = num;
			num = (short)80446046;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1045495808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2078801921;
			if (num != 0)
			{
			}
			num = (short)964689920;
			if (num != 0)
			{
			}
			return this.OwnerMonthCalendar;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00040B5C File Offset: 0x0003ED5C
		private global::System.Windows.Style c()
		{
			short num = (short)1943273473;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar = this.d();
			if (monthCalendar != null)
			{
				num = (short)1591944064;
				short num2 = num;
				num = (short)1137517440;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1292632064;
					if (num != 0)
					{
					}
					return monthCalendar.MonthlyMarkedDatesStyle;
				}
			}
			num = (short)1126170624;
			short num3 = num;
			return null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00040C1C File Offset: 0x0003EE1C
		private void a(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel A_0)
		{
			short num = (short)1118697510;
			short num2 = num;
			num = (short)1528887334;
			switch (num2 == num)
			{
			default:
			{
				num = (short)306315264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2022178817;
			if (num != 0)
			{
			}
			num = (short)196542464;
			if (num != 0)
			{
			}
			A_0.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
			A_0.ClearValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.SelectableProperty);
			A_0.ClearValue(global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty);
			A_0.ClearValue(global::System.Windows.UIElement.IsEnabledProperty);
			A_0.ClearValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.IsTodayProperty);
			A_0.IsTrailing = false;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00040D00 File Offset: 0x0003EF00
		private void a(global::DevComponents.WpfEditors.Primitives.MonthCalendarWeekLabel A_0, global::System.Windows.Style A_1)
		{
			short num = (short)1126829070;
			short num2 = num;
			num = (short)82119694;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1937768448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)959578113;
			if (num != 0)
			{
			}
			num = (short)31326208;
			if (num != 0)
			{
			}
			A_0.Style = A_1;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00040DB4 File Offset: 0x0003EFB4
		private bool a(global::System.DateTime A_0)
		{
			short num = (short)1396375553;
			if (num != 0)
			{
			}
			num = (short)1088225283;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A4;
				case 1:
				{
					num = (short)1689121482;
					short num3 = num;
					num = (short)1322513098;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A4;
					default:
						goto IL_116;
					}
					break;
				}
				case 2:
					if (A_0 < this.MinDate)
					{
						num = (short)2089615361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				}
				IL_5A:
				num = (short)753926144;
				short num4 = num;
				if (!(A_0 > this.MaxDate))
				{
					num = (short)317063168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A4:
				num = (short)479002626;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_116:
			num = (short)1066598400;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00040EF4 File Offset: 0x0003F0F4
		private void c(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel A_0, global::System.Windows.Style A_1)
		{
			short num = (short)362414081;
			if (num != 0)
			{
			}
			num = (short)2012610560;
			short num2 = num;
			num = (short)750429260;
			short num3 = num;
			num = (short)1923589196;
			switch (num3 == num)
			{
			}
			num = (short)102694912;
			if (num != 0)
			{
			}
			A_0.Style = A_1;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00040FA4 File Offset: 0x0003F1A4
		private void b(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel A_0, global::System.Windows.Style A_1)
		{
			short num = (short)923890337;
			short num2 = num;
			num = (short)952595105;
			switch (num2 == num)
			{
			default:
			{
				num = (short)824049664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1569652736;
			if (num != 0)
			{
			}
			num = (short)203423745;
			if (num != 0)
			{
			}
			A_0.Style = A_1;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00041058 File Offset: 0x0003F258
		private void a(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel A_0, global::System.Windows.Style A_1)
		{
			short num = (short)274006017;
			if (num != 0)
			{
			}
			num = (short)101318656;
			short num2 = num;
			num = (short)505454208;
			short num3 = num;
			num = (short)287809152;
			switch (num3 == num)
			{
			}
			num = (short)668008448;
			if (num != 0)
			{
			}
			A_0.Style = A_1;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00041108 File Offset: 0x0003F308
		private string a(string A_0)
		{
			short num;
			if (A_0.Length > 2)
			{
				num = (short)206550738;
				short num2 = num;
				num = (short)1512683218;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)598016000;
					if (num != 0)
					{
					}
					num = (short)1734213633;
					if (num != 0)
					{
					}
					return A_0.Substring(0, 2);
				}
			}
			num = (short)970915840;
			short num3 = num;
			return A_0;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000411C4 File Offset: 0x0003F3C4
		private bool[] b()
		{
			short num = (short)948895744;
			short num2 = num;
			num = (short)762445824;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				bool[] array;
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				for (;;)
				{
					IL_52:
					global::System.Collections.Generic.IEnumerator<global::System.DateTime> enumerator;
					switch (num3)
					{
					case 0:
						num = (short)1491992577;
						if (num != 0)
						{
						}
						num = (short)1468137475;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_D8;
						try
						{
							for (;;)
							{
								IL_D8:
								num = (short)1862205444;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1340997635;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)978625548;
										short num4 = num;
										num = (short)828548108;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_D8;
										default:
										{
											num = (short)392560640;
											if (num != 0)
											{
											}
											global::System.DateTime dateTime = enumerator.Current;
											array[dateTime.Day - 1] = true;
											num = (short)351600640;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										break;
									}
									case 2:
										goto IL_1E7;
									case 3:
										num = (short)2130640898;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_114;
										}
										continue;
									}
									IL_190:
									num = (short)1260126209;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_114:
									goto IL_190;
								}
							}
							IL_1E7:
							return array;
						}
						finally
						{
							num = (short)1348927490;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_257;
								case 1:
									enumerator.Dispose();
									num = (short)922877952;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_220;
									}
									continue;
								}
								IL_220:
								if (enumerator == null)
								{
									break;
								}
								num = (short)809566209;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_257:;
						}
						goto IL_25A;
					case 2:
						goto IL_25A;
					case 3:
						if (monthCalendar.MonthlyMarkedDates != null)
						{
							num = (short)375259138;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 4:
						if (monthCalendar != null)
						{
							num = (short)1963458560;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					}
					goto IL_6D;
					IL_25A:
					enumerator = monthCalendar.MonthlyMarkedDates.GetEnumerator();
					num = (short)1330708481;
					num3 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_6D:
				array = new bool[31];
				monthCalendar = this.d();
				num = (short)1780416516;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_52;
			}
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000414B0 File Offset: 0x0003F6B0
		private bool[] a(int A_0)
		{
			short num = (short)1147011072;
			short num2 = num;
			num = (short)813498368;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				bool[] array;
				for (;;)
				{
					IL_4F:
					global::System.Collections.Generic.IEnumerator<global::System.DateTime> enumerator;
					switch (num3)
					{
					case 0:
						if (monthCalendar != null)
						{
							num = (short)268697603;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 1:
						if (monthCalendar.AnnuallyMarkedDates != null)
						{
							num = (short)438435844;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 2:
						num = (short)1719336961;
						if (num != 0)
						{
							goto IL_2B9;
						}
						goto IL_2B9;
						IL_2B9:
						goto IL_B1;
						try
						{
							for (;;)
							{
								IL_B1:
								num = (short)1137180672;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										num = (short)1752272477;
										short num4 = num;
										num = (short)1857523293;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_B1;
										default:
											num = (short)1317732352;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_13D;
											}
											continue;
										}
										break;
									}
									case 1:
										num = (short)2029256710;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										global::System.DateTime dateTime;
										array[dateTime.Day - 1] = true;
										num = (short)1624637442;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)553058305;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.DateTime dateTime = enumerator.Current;
										num = (short)1571160069;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::System.DateTime dateTime;
										if (dateTime.Month == A_0)
										{
											num = (short)1376124931;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										goto IL_1F8;
									}
									IL_17E:
									num = (short)544276484;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_13D:
									goto IL_17E;
								}
							}
							IL_1F8:
							return array;
						}
						finally
						{
							num = (short)74383361;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									enumerator.Dispose();
									num = (short)953352194;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_231;
									}
									continue;
								case 2:
									goto IL_268;
								}
								IL_231:
								if (enumerator == null)
								{
									break;
								}
								num = (short)319619072;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_268:;
						}
						goto IL_26B;
					case 3:
						num = (short)1227227137;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_26B;
					}
					goto IL_6A;
					IL_26B:
					enumerator = monthCalendar.AnnuallyMarkedDates.GetEnumerator();
					num = (short)343801858;
					num3 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_6A:
				array = new bool[31];
				monthCalendar = this.d();
				num = (short)1299185664;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000417D8 File Offset: 0x0003F9D8
		private bool[] a(int A_0, int A_1)
		{
			short num = (short)1756430336;
			short num2 = num;
			num = (short)2023882752;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				bool[] array;
				for (;;)
				{
					IL_51:
					global::System.Collections.Generic.IEnumerator<global::System.DateTime> enumerator;
					switch (num3)
					{
					case 0:
						if (monthCalendar != null)
						{
							num = (short)1484062723;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 1:
						if (monthCalendar.MarkedDates != null)
						{
							num = (short)680787969;
							if (num != 0)
							{
							}
							num = (short)1269432324;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 2:
						try
						{
							num = (short)1692925952;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									num = (short)1516853214;
									short num4 = num;
									num = (short)1610569694;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_150;
									default:
										num = (short)2082340864;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_147;
										}
										continue;
									}
									break;
								}
								case 1:
								{
									global::System.DateTime dateTime;
									if (dateTime.Year == A_1)
									{
										num = (short)420610056;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)253034499;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_241;
								case 4:
								{
									global::System.DateTime dateTime;
									if (dateTime.Month == A_0)
									{
										num = (short)1090715655;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1371602946;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.DateTime dateTime = enumerator.Current;
									goto IL_150;
								}
								case 7:
									num = (short)1224933377;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::System.DateTime dateTime;
									array[dateTime.Day - 1] = true;
									num = (short)170459142;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_147;
								IL_150:
								num = (short)442695684;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_187:
								num = (short)1685585925;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_147:
								goto IL_187;
							}
							IL_241:
							return array;
						}
						finally
						{
							num = (short)269746177;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									enumerator.Dispose();
									num = (short)433455106;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_278;
									}
									continue;
								case 2:
									goto IL_2AF;
								}
								IL_278:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2038956032;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_2AF:;
						}
						goto IL_2B2;
					case 3:
						num = (short)1706033153;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_2B2;
					}
					goto IL_6C;
					IL_2B2:
					enumerator = monthCalendar.MarkedDates.GetEnumerator();
					num = (short)855244802;
					num3 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_6C:
				array = new bool[31];
				monthCalendar = this.d();
				num = (short)1535311872;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00041B44 File Offset: 0x0003FD44
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00041BF4 File Offset: 0x0003FDF4
		internal bool TrailingDaysBeforeVisible
		{
			get
			{
				short num = (short)102694912;
				short num2 = num;
				num = (short)1400046705;
				short num3 = num;
				num = (short)602801265;
				switch (num3 == num)
				{
				}
				num = (short)1016201217;
				if (num != 0)
				{
				}
				num = (short)345112576;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1303023795;
				short num2 = num;
				num = (short)957714611;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_FA:
					num = (short)102498306;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1288241152;
					if (num != 0)
					{
					}
					num = (short)187039745;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_EB;
					case 1:
					{
						num = (short)208601088;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					}
					case 2:
						return;
					}
					IL_A6:
					if (this.e == value)
					{
						return;
					}
					num = (short)1519058945;
					if (num != 0)
					{
					}
					num = (short)178192384;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_EB:
				this.e = value;
				this.UpdateCalendarDisplay();
				goto IL_FA;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00041D14 File Offset: 0x0003FF14
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00041DC4 File Offset: 0x0003FFC4
		internal bool TrailingDaysAfterVisible
		{
			get
			{
				short num = (short)1998061568;
				short num2 = num;
				num = (short)1365855492;
				short num3 = num;
				num = (short)1600343300;
				switch (num3 == num)
				{
				}
				num = (short)459603968;
				if (num != 0)
				{
				}
				num = (short)165347329;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1155812909;
				short num2 = num;
				num = (short)2024164909;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D1:
					num = (short)968753154;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)2015952896;
					if (num != 0)
					{
					}
					num = (short)1692073985;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_C2;
					case 1:
					{
						num = (short)189464576;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					case 2:
						goto IL_E6;
					}
					IL_A3:
					if (this.f == value)
					{
						return;
					}
					num = (short)261619712;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_C2:
				this.f = value;
				this.UpdateCalendarDisplay();
				goto IL_D1;
				IL_E6:
				num = (short)1745354753;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00041EE0 File Offset: 0x000400E0
		private void a()
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_52;
			}
			short num;
			int num3;
			string text;
			for (;;)
			{
				IL_13:
				num = (short)151715840;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_133;
				case 1:
					text = this.MonthNames[this.DisplayMonth.Month - 1];
					num = (short)422379523;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1342032286;
					short num4 = num;
					num = (short)1410517406;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1623851009;
						if (num != 0)
						{
						}
						num = (short)403636224;
						if (num != 0)
						{
						}
						if (this.MonthNames != null)
						{
							num = (short)1559756801;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.GetMonthName(this.DisplayMonth.Month);
						num = (short)939130880;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_164;
				}
				goto IL_52;
			}
			IL_133:
			IL_164:
			text = text + global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_) + this.DisplayMonth.Year.ToString();
			this.DisplayMonthName = text;
			return;
			IL_52:
			text = "";
			num = (short)493486082;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00042088 File Offset: 0x00040288
		internal void b(global::System.DateTime A_0, global::System.DateTime A_1)
		{
			short num = (short)802816000;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
				int num4;
				global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)792920065;
					if (num != 0)
					{
					}
					num = (short)1290768261;
					short num3 = num;
					num = (short)933269381;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16C;
					default:
						num = (short)2047213568;
						if (num != 0)
						{
						}
						num = (short)396361734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return;
				case 4:
					goto IL_E8;
				case 5:
					monthCalendarDayLabel.IsChecked = new bool?(true);
					num = (short)1169227786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (monthCalendarDayLabel.Date <= A_1)
					{
						num = (short)591855621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_76;
				case 7:
					goto IL_151;
				case 8:
					if (num4 >= array.Length)
					{
						num = (short)1564082179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					monthCalendarDayLabel = array[num4];
					num = (short)1458241547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_16C;
				case 10:
					goto IL_151;
				case 11:
					if (monthCalendarDayLabel.Date >= A_0)
					{
						num = (short)164560898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_76;
				}
				IL_54:
				if (this.c == null)
				{
					num = (short)112197633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				array = this.c;
				num4 = 0;
				num = (short)154468356;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_76:
				monthCalendarDayLabel.IsChecked = new bool?(false);
				num = (short)673513479;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E8:
				num = (short)214499328;
				short num5 = num;
				num = (short)847904776;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16C:
				goto IL_E8;
				IL_151:
				num4++;
				num = (short)329318409;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0400017A RID: 378
		private global::DevComponents.WpfEditors.Primitives.MonthCalendarWeekLabel[] a;

		// Token: 0x0400017B RID: 379
		private global::DevComponents.WpfEditors.Primitives.MonthCalendarDayNameLabel[] b;

		// Token: 0x0400017C RID: 380
		private global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] c;

		// Token: 0x0400017D RID: 381
		public static readonly global::System.Windows.DependencyProperty FirstDayOfWeekProperty;

		// Token: 0x0400017E RID: 382
		public static readonly global::System.Windows.DependencyProperty TwoLetterDayNameProperty;

		// Token: 0x0400017F RID: 383
		public static readonly global::System.Windows.DependencyProperty ShowTodayMarkerProperty;

		// Token: 0x04000180 RID: 384
		public static readonly global::System.Windows.DependencyProperty ShowWeekNumbersProperty;

		// Token: 0x04000181 RID: 385
		public static readonly global::System.Windows.DependencyProperty WeekendDaysSelectableProperty;

		// Token: 0x04000182 RID: 386
		public static readonly global::System.Windows.DependencyProperty SelectedDateProperty;

		// Token: 0x04000183 RID: 387
		public static readonly global::System.Windows.DependencyProperty WeekOfYearRuleProperty;

		// Token: 0x04000184 RID: 388
		public static readonly global::System.Windows.DependencyProperty TrailingDaysVisibleProperty;

		// Token: 0x04000185 RID: 389
		public static readonly global::System.Windows.DependencyProperty DayNamesProperty;

		// Token: 0x04000186 RID: 390
		public static readonly global::System.Windows.DependencyProperty TodayDateProperty;

		// Token: 0x04000187 RID: 391
		public static readonly global::System.Windows.DependencyProperty MinDateProperty;

		// Token: 0x04000188 RID: 392
		public static readonly global::System.Windows.DependencyProperty MaxDateProperty;

		// Token: 0x04000189 RID: 393
		public static readonly global::System.Windows.DependencyProperty TrailingDayStyleProperty;

		// Token: 0x0400018A RID: 394
		public static readonly global::System.Windows.DependencyProperty DayNameLabelStyleProperty;

		// Token: 0x0400018B RID: 395
		public static readonly global::System.Windows.DependencyProperty WeekLabelStyleProperty;

		// Token: 0x0400018C RID: 396
		public static readonly global::System.Windows.DependencyProperty DayStyleProperty;

		// Token: 0x0400018D RID: 397
		public static readonly global::System.Windows.DependencyProperty MultiSelectProperty;

		// Token: 0x0400018E RID: 398
		public static readonly global::System.Windows.DependencyProperty DisplayMonthProperty;

		// Token: 0x0400018F RID: 399
		private static readonly global::System.Windows.DependencyPropertyKey d;

		// Token: 0x04000190 RID: 400
		public static readonly global::System.Windows.DependencyProperty DisplayMonthNameProperty;

		// Token: 0x04000191 RID: 401
		public static readonly global::System.Windows.DependencyProperty MonthNamesProperty;

		// Token: 0x04000192 RID: 402
		public static readonly global::System.Windows.DependencyProperty PreviousMonthButtonVisibilityProperty;

		// Token: 0x04000193 RID: 403
		public static readonly global::System.Windows.DependencyProperty NextMonthButtonVisibilityProperty;

		// Token: 0x04000194 RID: 404
		public static readonly global::System.Windows.DependencyProperty AutoNavigateProperty;

		// Token: 0x04000195 RID: 405
		public static readonly global::System.Windows.DependencyProperty AnimationEnabledProperty;

		// Token: 0x04000196 RID: 406
		public static readonly global::System.Windows.DependencyProperty AutoSelectProperty;

		// Token: 0x04000199 RID: 409
		public static readonly global::System.Windows.DependencyProperty OwnerMonthCalendarProperty;

		// Token: 0x0400019A RID: 410
		internal bool e = true;

		// Token: 0x0400019B RID: 411
		internal bool f = true;
	}
}
