using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200002C RID: 44
	[global::System.ComponentModel.DefaultEvent("SelectedDateChanged")]
	public class MonthCalendar : global::System.Windows.Controls.Control
	{
		// Token: 0x0600022B RID: 555 RVA: 0x0002A078 File Offset: 0x00028278
		private static void ac(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_64:
					if (monthCalendar != null)
					{
						num2 = (short)1735589889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DC;
				case 1:
					monthCalendar.OnMonthlyMarkedDatesChanged((global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>)A_1.OldValue, (global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>)A_1.NewValue);
					num2 = (short)1415839746;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)570359809;
					if (num2 != 0)
					{
					}
					goto IL_DC;
				}
				goto IL_1C;
				IL_DC:
				num2 = (short)1325465900;
				short num3 = num2;
				num2 = (short)1951662380;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_64;
				default:
					goto IL_112;
				}
			}
			IL_112:
			num2 = (short)1588658176;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)17694720;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)353239040;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0002A1B0 File Offset: 0x000283B0
		protected virtual void OnMonthlyMarkedDatesChanged(global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime> oldValue, global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime> newValue)
		{
			short num = (short)1713373187;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)712572928;
				short num3 = num;
				switch (num2)
				{
				case 0:
					oldValue.CollectionChanged -= this.c;
					goto IL_171;
				case 1:
					goto IL_100;
				case 2:
				{
					num = (short)1900050599;
					short num4 = num;
					num = (short)273053863;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_171;
					default:
						goto IL_E5;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					continue;
				case 4:
					if (newValue != null)
					{
						num = (short)589758465;
						if (num != 0)
						{
						}
						num = (short)734003205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18D;
				case 5:
					newValue.CollectionChanged += this.c;
					num = (short)1060831234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_67:
				if (oldValue != null)
				{
					num = (short)207355904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_100:
				num = (short)1203961860;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_171:
				num = (short)1727987713;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			num = (short)285999104;
			if (num != 0)
			{
			}
			IL_18D:
			this.f();
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0002A350 File Offset: 0x00028550
		private void c(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1150462713;
			short num2 = num;
			num = (short)560769785;
			switch (num2 == num)
			{
			}
			num = (short)929497089;
			if (num != 0)
			{
			}
			num = (short)319094784;
			if (num != 0)
			{
			}
			num = (short)795017216;
			short num3 = num;
			this.f();
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0002A400 File Offset: 0x00028600
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0002A4B8 File Offset: 0x000286B8
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.Description("Indicates array of DateTime objects that determine which monthly days to mark using Colors.MonthlyMarker settings. ")]
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime> MonthlyMarkedDates
		{
			get
			{
				short num = (short)641061554;
				short num2 = num;
				num = (short)1809896114;
				switch (num2 == num)
				{
				}
				num = (short)143982593;
				if (num != 0)
				{
				}
				num = (short)387186688;
				if (num != 0)
				{
				}
				num = (short)1823145984;
				short num3 = num;
				return (global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.MonthlyMarkedDatesProperty);
			}
			set
			{
				short num = (short)1039859713;
				if (num != 0)
				{
				}
				num = (short)2020996351;
				short num2 = num;
				num = (short)215807231;
				switch (num2 == num)
				{
				}
				num = (short)1958346752;
				if (num != 0)
				{
				}
				num = (short)772472832;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.MonthlyMarkedDatesProperty, value);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0002A56C File Offset: 0x0002876C
		private static void ab(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_5F:
					if (monthCalendar != null)
					{
						num2 = (short)908132353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AF;
				case 1:
					monthCalendar.OnAnnuallyMarkedDatesChanged((global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>)A_1.OldValue, (global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>)A_1.NewValue);
					num2 = (short)2072772610;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_AF;
				}
				goto IL_1C;
				IL_AF:
				num2 = (short)1262129295;
				short num3 = num2;
				num2 = (short)1753911439;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5F;
				default:
					goto IL_E5;
				}
			}
			IL_E5:
			num2 = (short)200081409;
			if (num2 != 0)
			{
			}
			num2 = (short)1734868992;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)614989824;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)72876032;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0002A69C File Offset: 0x0002889C
		protected virtual void OnAnnuallyMarkedDatesChanged(global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime> oldValue, global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime> newValue)
		{
			short num = (short)1835204611;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)98697216;
				short num3 = num;
				switch (num2)
				{
				case 0:
					oldValue.CollectionChanged -= this.b;
					goto IL_16B;
				case 1:
					goto IL_123;
				case 2:
				{
					num = (short)2108108914;
					short num4 = num;
					num = (short)580137074;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16B;
					default:
						goto IL_E4;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 4:
					if (newValue != null)
					{
						num = (short)2132017157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_184;
				case 5:
					newValue.CollectionChanged += this.b;
					num = (short)1277231106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_66:
				if (oldValue != null)
				{
					num = (short)1684930560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_123:
				num = (short)1584660484;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16B:
				num = (short)2056126465;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E4:
			num = (short)1544617985;
			if (num != 0)
			{
			}
			num = (short)2142633984;
			if (num != 0)
			{
			}
			IL_184:
			this.f();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0002A834 File Offset: 0x00028A34
		private void b(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)67960833;
			if (num != 0)
			{
			}
			num = (short)519515479;
			short num2 = num;
			num = (short)571157847;
			switch (num2 == num)
			{
			}
			num = (short)166592512;
			if (num != 0)
			{
			}
			num = (short)1387724800;
			short num3 = num;
			this.f();
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0002A8E4 File Offset: 0x00028AE4
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0002A99C File Offset: 0x00028B9C
		[global::System.ComponentModel.Description("Indicates array of DateTime objects that determines which annual days are marked using Colors.AnnualMarker settings.")]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Localizable(true)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime> AnnuallyMarkedDates
		{
			get
			{
				short num = (short)209645367;
				short num2 = num;
				num = (short)321646391;
				switch (num2 == num)
				{
				}
				num = (short)1439039488;
				if (num != 0)
				{
				}
				num = (short)1110048769;
				if (num != 0)
				{
				}
				num = (short)1043988480;
				short num3 = num;
				return (global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.AnnuallyMarkedDatesProperty);
			}
			set
			{
				short num = (short)2039115018;
				short num2 = num;
				num = (short)1296395530;
				switch (num2 == num)
				{
				}
				num = (short)117506048;
				if (num != 0)
				{
				}
				num = (short)1060372481;
				if (num != 0)
				{
				}
				num = (short)131858432;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.AnnuallyMarkedDatesProperty, value);
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0002AA50 File Offset: 0x00028C50
		private static void aa(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_87:
					if (monthCalendar != null)
					{
						num2 = (short)529334273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DA;
				case 1:
					monthCalendar.OnMarkedDatesChanged((global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>)A_1.OldValue, (global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>)A_1.NewValue);
					num2 = (short)570228738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_DA;
				}
				goto IL_1C;
				IL_DA:
				num2 = (short)772425928;
				short num3 = num2;
				num2 = (short)265439432;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_87;
				default:
					goto IL_110;
				}
			}
			IL_110:
			num2 = (short)63307776;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)1847132160;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)26411009;
			if (num2 != 0)
			{
			}
			num2 = (short)1445330944;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0002AB84 File Offset: 0x00028D84
		protected virtual void OnMarkedDatesChanged(global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime> oldValue, global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime> newValue)
		{
			short num = (short)183828483;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2052587520;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)821559297;
					if (num != 0)
					{
					}
					oldValue.CollectionChanged -= this.a;
					goto IL_16E;
				case 1:
					goto IL_124;
				case 2:
				{
					num = (short)1793268525;
					short num4 = num;
					num = (short)948902701;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16E;
					default:
						goto IL_10B;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 4:
					if (newValue != null)
					{
						num = (short)1138819077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_188;
				case 5:
					newValue.CollectionChanged += this.a;
					num = (short)1920335874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_65:
				if (oldValue != null)
				{
					num = (short)1867579392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_124:
				num = (short)1906573316;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16E:
				num = (short)2056847361;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			num = (short)96075776;
			if (num != 0)
			{
			}
			IL_188:
			this.f();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0002AD20 File Offset: 0x00028F20
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1080780119;
			short num2 = num;
			num = (short)1141990743;
			switch (num2 == num)
			{
			}
			num = (short)137363457;
			if (num != 0)
			{
			}
			num = (short)1535705088;
			if (num != 0)
			{
			}
			num = (short)2004156416;
			short num3 = num;
			this.f();
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0002ADCC File Offset: 0x00028FCC
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0002AE84 File Offset: 0x00029084
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Description("Indicates array of DateTime objects that determines which nonrecurring dates are marked using Colors.DayMarker settings.")]
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime> MarkedDates
		{
			get
			{
				short num = (short)2108539748;
				short num2 = num;
				num = (short)1245102948;
				switch (num2 == num)
				{
				}
				num = (short)241238016;
				if (num != 0)
				{
				}
				num = (short)332398593;
				if (num != 0)
				{
				}
				num = (short)1900347392;
				short num3 = num;
				return (global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.MarkedDatesProperty);
			}
			set
			{
				short num = (short)295536662;
				short num2 = num;
				num = (short)205031446;
				switch (num2 == num)
				{
				}
				num = (short)313458689;
				if (num != 0)
				{
				}
				num = (short)2123759616;
				if (num != 0)
				{
				}
				num = (short)1376190464;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.MarkedDatesProperty, value);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0002AF38 File Offset: 0x00029138
		private static void z(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_87:
					if (monthCalendar != null)
					{
						num2 = (short)358809601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D2;
				case 1:
					monthCalendar.OnAnnuallyMarkedDatesStyleChanged(A_1.OldValue, A_1.NewValue);
					num2 = (short)1907949570;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_D2;
				}
				goto IL_1C;
				IL_D2:
				num2 = (short)1144620261;
				short num3 = num2;
				num2 = (short)1383630053;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_87;
				default:
					goto IL_108;
				}
			}
			IL_108:
			num2 = (short)2052063232;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)2145779712;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)2099576833;
			if (num2 != 0)
			{
			}
			num2 = (short)324141056;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0002B064 File Offset: 0x00029264
		protected virtual void OnAnnuallyMarkedDatesStyleChanged(object oldValue, object newValue)
		{
			short num = (short)927293335;
			short num2 = num;
			num = (short)78405527;
			switch (num2 == num)
			{
			}
			num = (short)784203776;
			if (num != 0)
			{
			}
			num = (short)1858535425;
			if (num != 0)
			{
			}
			num = (short)257818624;
			short num3 = num;
			this.a(false, false);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0002B118 File Offset: 0x00029318
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0002B1D0 File Offset: 0x000293D0
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style AnnuallyMarkedDatesStyle
		{
			get
			{
				short num = (short)562337570;
				short num2 = num;
				num = (short)569087778;
				switch (num2 == num)
				{
				}
				num = (short)847249409;
				if (num != 0)
				{
				}
				num = (short)636813312;
				if (num != 0)
				{
				}
				num = (short)806420480;
				short num3 = num;
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.AnnuallyMarkedDatesStyleProperty);
			}
			set
			{
				short num = (short)648124010;
				short num2 = num;
				num = (short)1800443498;
				switch (num2 == num)
				{
				}
				num = (short)231276545;
				if (num != 0)
				{
				}
				num = (short)1942487040;
				if (num != 0)
				{
				}
				num = (short)1257373696;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.AnnuallyMarkedDatesStyleProperty, value);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0002B284 File Offset: 0x00029484
		private static void y(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_61:
					if (monthCalendar != null)
					{
						num2 = (short)937230337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D0;
				case 1:
					monthCalendar.OnMonthlyMarkedDatesStyleChanged(A_1.OldValue, A_1.NewValue);
					num2 = (short)1458962434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1399259137;
					if (num2 != 0)
					{
					}
					goto IL_D0;
				}
				goto IL_1C;
				IL_D0:
				num2 = (short)1358697989;
				short num3 = num2;
				num2 = (short)711267845;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_61;
				default:
					goto IL_106;
				}
			}
			IL_106:
			num2 = (short)1752170496;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)277544960;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)935591936;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0002B3B0 File Offset: 0x000295B0
		protected virtual void OnMonthlyMarkedDatesStyleChanged(object oldValue, object newValue)
		{
			short num = (short)155123713;
			if (num != 0)
			{
			}
			num = (short)2067779488;
			short num2 = num;
			num = (short)1351274400;
			switch (num2 == num)
			{
			}
			num = (short)95617024;
			short num3 = num;
			num = (short)1548812288;
			if (num != 0)
			{
			}
			this.a(false, false);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0002B460 File Offset: 0x00029660
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0002B518 File Offset: 0x00029718
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style MonthlyMarkedDatesStyle
		{
			get
			{
				short num = (short)227354308;
				short num2 = num;
				num = (short)1051010756;
				switch (num2 == num)
				{
				}
				num = (short)174981121;
				if (num != 0)
				{
				}
				num = (short)1050869760;
				short num3 = num;
				num = (short)984285184;
				if (num != 0)
				{
				}
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.MonthlyMarkedDatesStyleProperty);
			}
			set
			{
				short num = (short)1047033917;
				short num2 = num;
				num = (short)375945277;
				switch (num2 == num)
				{
				}
				num = (short)837746688;
				if (num != 0)
				{
				}
				num = (short)1418788864;
				short num3 = num;
				num = (short)1806237697;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.MonthlyMarkedDatesStyleProperty, value);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0002B5CC File Offset: 0x000297CC
		private static void x(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
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
					goto IL_F7;
				case 1:
					goto IL_81;
				case 2:
				{
					num2 = (short)262406144;
					short num3 = num2;
					global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
					monthCalendar.OnMarkedDatesStyleChanged(A_1.OldValue, A_1.NewValue);
					num2 = (short)1337655296;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_F7:
			num2 = (short)1395720193;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)570123608;
			short num4 = num2;
			num2 = (short)508323160;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_81:
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				if (monthCalendar != null)
				{
					num2 = (short)2115043330;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)1846214656;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
				num2 = (short)1147076609;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0002B6FC File Offset: 0x000298FC
		protected virtual void OnMarkedDatesStyleChanged(object oldValue, object newValue)
		{
			short num = (short)608960513;
			if (num != 0)
			{
			}
			num = (short)620669403;
			short num2 = num;
			num = (short)1720363483;
			switch (num2 == num)
			{
			}
			num = (short)230948864;
			short num3 = num;
			num = (short)453050368;
			if (num != 0)
			{
			}
			this.a(false, false);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0002B7AC File Offset: 0x000299AC
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0002B864 File Offset: 0x00029A64
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style MarkedDatesStyle
		{
			get
			{
				short num = (short)5045658;
				short num2 = num;
				num = (short)806878618;
				switch (num2 == num)
				{
				}
				num = (short)1212284929;
				if (num != 0)
				{
				}
				num = (short)1817116672;
				short num3 = num;
				num = (short)405864448;
				if (num != 0)
				{
				}
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.MarkedDatesStyleProperty);
			}
			set
			{
				short num = (short)1712065337;
				short num2 = num;
				num = (short)529140537;
				switch (num2 == num)
				{
				}
				num = (short)706084865;
				if (num != 0)
				{
				}
				num = (short)1454637056;
				short num3 = num;
				num = (short)1911422976;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.MarkedDatesStyleProperty, value);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0002B91C File Offset: 0x00029B1C
		private static object h(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
			short num;
			if (monthCalendar == null)
			{
				num = (short)447845819;
				short num2 = num;
				num = (short)458855867;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)932642816;
					if (num != 0)
					{
					}
					return A_1;
				}
			}
			num = (short)1715929088;
			short num3 = num;
			num = (short)428867585;
			if (num != 0)
			{
			}
			return monthCalendar.OnCoerceCalendarDimensions((global::System.Windows.Size)A_1);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0002B9E4 File Offset: 0x00029BE4
		private static void w(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
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
					goto IL_12C;
				case 1:
					goto IL_83;
				case 2:
				{
					global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
					monthCalendar.OnCalendarDimensionsChanged((global::System.Windows.Size)A_1.OldValue, (global::System.Windows.Size)A_1.NewValue);
					num2 = (short)1834483712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_12C:
			return;
			IL_1C:
			num2 = (short)1279487069;
			short num3 = num2;
			num2 = (short)1106209885;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_83:
				num2 = (short)2106130433;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				if (monthCalendar != null)
				{
					num2 = (short)764346368;
					short num4 = num2;
					num2 = (short)300875778;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)975044608;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
				num2 = (short)1002438657;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0002BB20 File Offset: 0x00029D20
		protected virtual global::System.Windows.Size OnCoerceCalendarDimensions(global::System.Windows.Size value)
		{
			short num = (short)1984823297;
			if (num != 0)
			{
			}
			num = (short)509301063;
			short num2 = num;
			num = (short)1373524295;
			switch (num2 == num)
			{
			}
			num = (short)410779648;
			short num3 = num;
			num = (short)1839529984;
			if (num != 0)
			{
			}
			value.Width = global::System.Math.Max(1.0, global::System.Math.Ceiling(value.Width));
			value.Height = global::System.Math.Max(1.0, global::System.Math.Ceiling(value.Height));
			return value;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0002BC0C File Offset: 0x00029E0C
		protected virtual void OnCalendarDimensionsChanged(global::System.Windows.Size oldValue, global::System.Windows.Size newValue)
		{
			short num = (short)1911602081;
			short num2 = num;
			num = (short)292862881;
			switch (num2 == num)
			{
			}
			num = (short)788004865;
			if (num != 0)
			{
			}
			num = (short)637730816;
			short num3 = num;
			num = (short)1455620096;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0002BCBC File Offset: 0x00029EBC
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0002BD74 File Offset: 0x00029F74
		[global::System.ComponentModel.Description("Indicates number of columns and rows of months displayed on control.")]
		public global::System.Windows.Size CalendarDimensions
		{
			get
			{
				short num = (short)430015340;
				short num2 = num;
				num = (short)1518568300;
				switch (num2 == num)
				{
				}
				num = (short)2045640704;
				if (num != 0)
				{
				}
				num = (short)166658048;
				short num3 = num;
				num = (short)2072051713;
				if (num != 0)
				{
				}
				return (global::System.Windows.Size)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.CalendarDimensionsProperty);
			}
			set
			{
				short num = (short)940048385;
				if (num != 0)
				{
				}
				num = (short)451846202;
				short num2 = num;
				num = (short)156803130;
				switch (num2 == num)
				{
				}
				num = (short)1793916928;
				short num3 = num;
				num = (short)1881014272;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.CalendarDimensionsProperty, value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0002BE30 File Offset: 0x0002A030
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0002BEE8 File Offset: 0x0002A0E8
		[global::System.ComponentModel.DefaultValue(global::System.Windows.Visibility.Visible)]
		public global::System.Windows.Visibility NavigationVisibility
		{
			get
			{
				short num = (short)2004418561;
				if (num != 0)
				{
				}
				num = (short)1891946787;
				short num2 = num;
				num = (short)1316409635;
				switch (num2 == num)
				{
				}
				num = (short)1967587328;
				short num3 = num;
				num = (short)856555520;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.NavigationVisibilityProperty);
			}
			set
			{
				short num = (short)111087491;
				short num2 = num;
				num = (short)866193283;
				switch (num2 == num)
				{
				}
				num = (short)83623937;
				if (num != 0)
				{
				}
				num = (short)1831141376;
				short num3 = num;
				num = (short)751435776;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.NavigationVisibilityProperty, value);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0002BFA4 File Offset: 0x0002A1A4
		private static object g(global::System.Windows.DependencyObject A_0, object A_1)
		{
			short num = (short)578289665;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
			if (monthCalendar == null)
			{
				num = (short)586152898;
				short num2 = num;
				num = (short)770440130;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1196752896;
					if (num != 0)
					{
					}
					return A_1;
				}
			}
			num = (short)1090715648;
			short num3 = num;
			return monthCalendar.OnCoerceSelectedDate((global::System.DateTime?)A_1);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0002C06C File Offset: 0x0002A26C
		protected virtual global::System.DateTime OnCoerceDisplayMonth(global::System.DateTime value)
		{
			short num = (short)2134966273;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F6;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
				{
					value = new global::System.DateTime(value.Year, value.Month, 1);
					num = (short)1254096038;
					short num3 = num;
					num = (short)682425510;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F6;
					default:
						num = (short)1035534337;
						if (num != 0)
						{
						}
						num = (short)751370240;
						if (num != 0)
						{
						}
						num = (short)92012544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_31:
				if (value.Day == 1)
				{
					break;
				}
				num = (short)42008578;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F6:
			num = (short)1932197888;
			short num4 = num;
			return value;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0002C19C File Offset: 0x0002A39C
		private static void v(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
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
					goto IL_126;
				case 1:
					goto IL_AA;
				case 2:
				{
					global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
					monthCalendar.OnDisplayMonthChanged((global::System.DateTime)A_1.OldValue, (global::System.DateTime)A_1.NewValue);
					num2 = (short)473890816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_126:
			return;
			IL_1C:
			num2 = (short)1284541228;
			short num3 = num2;
			num2 = (short)546540332;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_AA:
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				if (monthCalendar != null)
				{
					num2 = (short)1232928768;
					short num4 = num2;
					num2 = (short)1135869954;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)2141585409;
				if (num2 != 0)
				{
				}
				num2 = (short)2041905152;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
				num2 = (short)670302209;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0002C2D4 File Offset: 0x0002A4D4
		protected virtual void OnDisplayMonthChanged(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			short num = (short)594673665;
			if (num != 0)
			{
			}
			num = (short)1565029331;
			short num2 = num;
			num = (short)589132755;
			switch (num2 == num)
			{
			}
			num = (short)1516896256;
			short num3 = num;
			num = (short)205127680;
			if (num != 0)
			{
			}
			this.a(newValue > oldValue, newValue.Year != oldValue.Year || newValue.Month != oldValue.Month);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0002C3B4 File Offset: 0x0002A5B4
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0002C46C File Offset: 0x0002A66C
		public global::System.DateTime DisplayMonth
		{
			get
			{
				short num = (short)47493829;
				short num2 = num;
				num = (short)1991881413;
				switch (num2 == num)
				{
				}
				num = (short)1996554241;
				if (num != 0)
				{
				}
				num = (short)379125760;
				short num3 = num;
				num = (short)611319808;
				if (num != 0)
				{
				}
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.DisplayMonthProperty);
			}
			set
			{
				short num = (short)589977995;
				short num2 = num;
				num = (short)386161035;
				switch (num2 == num)
				{
				}
				num = (short)1782710273;
				if (num != 0)
				{
				}
				num = (short)1539112960;
				short num3 = num;
				num = (short)764936192;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.DisplayMonthProperty, value);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0002C528 File Offset: 0x0002A728
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0002C5E4 File Offset: 0x0002A7E4
		public bool AnimationEnabled
		{
			get
			{
				short num = (short)543648116;
				short num2 = num;
				num = (short)531196276;
				switch (num2 == num)
				{
				}
				num = (short)434765824;
				if (num != 0)
				{
				}
				num = (short)1858469888;
				short num3 = num;
				num = (short)1274216449;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.AnimationEnabledProperty);
			}
			set
			{
				short num = (short)773781958;
				short num2 = num;
				num = (short)950401478;
				switch (num2 == num)
				{
				}
				num = (short)1290076161;
				if (num != 0)
				{
				}
				num = (short)545259520;
				short num3 = num;
				num = (short)1921712128;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.AnimationEnabledProperty, value);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
		private static void u(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
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
					goto IL_127;
				case 1:
					goto IL_AC;
				case 2:
				{
					global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
					monthCalendar.OnMinDateChanged((global::System.DateTime)A_1.OldValue, (global::System.DateTime)A_1.NewValue);
					num2 = (short)428998656;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_127:
			return;
			IL_1C:
			num2 = (short)1001390081;
			if (num2 != 0)
			{
			}
			num2 = (short)966526924;
			short num3 = num2;
			num2 = (short)1953368012;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_AC:
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				if (monthCalendar != null)
				{
					num2 = (short)2127036416;
					short num4 = num2;
					num2 = (short)169148418;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)34799616;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
				num2 = (short)617807873;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
		protected virtual void OnMinDateChanged(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			short num = (short)1401996302;
			short num2 = num;
			num = (short)2052178958;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_166;
			case 1:
				break;
			default:
			{
				num = (short)2102853632;
				short num3 = num;
				break;
			}
			}
			num = (short)1127546880;
			if (num != 0)
			{
			}
			num = (short)856883201;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1438384131;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)1641676801;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_156;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_E6;
						}
						continue;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)158400512;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.MinDate = newValue;
						num = (short)486801410;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_10C:
					num = (short)1265565700;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E6:
					goto IL_10C;
				}
				IL_156:;
			}
			IL_166:
			base.CoerceValue(global::DevComponents.WpfEditors.MonthCalendar.SelectedDateProperty);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0002C968 File Offset: 0x0002AB68
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0002CA24 File Offset: 0x0002AC24
		[global::System.ComponentModel.Description("Indicates minimum date and time that can be selected in the control.")]
		public global::System.DateTime MinDate
		{
			get
			{
				short num = (short)1718026241;
				if (num != 0)
				{
				}
				num = (short)1960301948;
				short num2 = num;
				num = (short)1345770876;
				switch (num2 == num)
				{
				}
				num = (short)1185873920;
				short num3 = num;
				num = (short)1271529472;
				if (num != 0)
				{
				}
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.MinDateProperty);
			}
			set
			{
				short num = (short)862799282;
				short num2 = num;
				num = (short)1929004466;
				switch (num2 == num)
				{
				}
				num = (short)81395713;
				if (num != 0)
				{
				}
				num = (short)1448345600;
				short num3 = num;
				num = (short)1540816896;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.MinDateProperty, value);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0002CADC File Offset: 0x0002ACDC
		private static void t(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
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
					goto IL_128;
				case 1:
					goto IL_AB;
				case 2:
				{
					global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
					monthCalendar.OnMaxDateChanged((global::System.DateTime)A_1.OldValue, (global::System.DateTime)A_1.NewValue);
					num2 = (short)1280835584;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_128:
			return;
			IL_1C:
			num2 = (short)346207557;
			short num3 = num2;
			num2 = (short)1858057541;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_AB:
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				if (monthCalendar != null)
				{
					num2 = (short)1398472704;
					short num4 = num2;
					num2 = (short)1283522562;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)1169293313;
				if (num2 != 0)
				{
				}
				num2 = (short)1425670144;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
				num2 = (short)1641152513;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0002CC14 File Offset: 0x0002AE14
		protected virtual void OnMaxDateChanged(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			short num = (short)183589449;
			short num2 = num;
			num = (short)1583962697;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_162;
			case 1:
				break;
			default:
			{
				num = (short)570294272;
				short num3 = num;
				break;
			}
			}
			num = (short)899219457;
			if (num != 0)
			{
			}
			num = (short)240713728;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)399638531;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)2006056961;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_152;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_E2;
						}
						continue;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)1671888896;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.MaxDate = newValue;
						num = (short)642646018;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_108:
					num = (short)786694148;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E2:
					goto IL_108;
				}
				IL_152:;
			}
			IL_162:
			base.CoerceValue(global::DevComponents.WpfEditors.MonthCalendar.SelectedDateProperty);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0002CDA0 File Offset: 0x0002AFA0
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0002CE5C File Offset: 0x0002B05C
		[global::System.ComponentModel.Description("Indicates maximum date and time that can be selected in the control.")]
		public global::System.DateTime MaxDate
		{
			get
			{
				short num = (short)1147216351;
				short num2 = num;
				num = (short)1485447647;
				switch (num2 == num)
				{
				}
				num = (short)581828609;
				if (num != 0)
				{
				}
				num = (short)1614020608;
				short num3 = num;
				num = (short)1261502464;
				if (num != 0)
				{
				}
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.MaxDateProperty);
			}
			set
			{
				short num = (short)1886322689;
				if (num != 0)
				{
				}
				num = (short)746465646;
				short num2 = num;
				num = (short)1085679982;
				switch (num2 == num)
				{
				}
				num = (short)710934528;
				short num3 = num;
				num = (short)1496645632;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.MaxDateProperty, value);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0002CF14 File Offset: 0x0002B114
		private static object f(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
			short num;
			if (monthCalendar == null)
			{
				num = (short)1934760313;
				short num2 = num;
				num = (short)934943097;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1791098880;
					if (num != 0)
					{
					}
					return A_1;
				}
			}
			num = (short)1131937793;
			if (num != 0)
			{
			}
			num = (short)1238958080;
			short num3 = num;
			return monthCalendar.OnCoerceSelectedDate((global::System.DateTime?)A_1);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0002CFDC File Offset: 0x0002B1DC
		private static void s(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
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
					goto IL_125;
				case 1:
					goto IL_83;
				case 2:
				{
					global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
					monthCalendar.OnSelectedDateChanged((global::System.DateTime?)A_1.OldValue, (global::System.DateTime?)A_1.NewValue);
					num2 = (short)1491468288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_125:
			return;
			IL_1C:
			num2 = (short)222877175;
			short num3 = num2;
			num2 = (short)1375524343;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_83:
				num2 = (short)1772027905;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				if (monthCalendar != null)
				{
					num2 = (short)1471414272;
					short num4 = num2;
					num2 = (short)1487077378;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)498597888;
				if (num2 != 0)
				{
				}
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
				num2 = (short)2095120385;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0002D110 File Offset: 0x0002B310
		protected virtual global::System.DateTime? OnCoerceSelectedDate(global::System.DateTime? value)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			short num2;
			global::System.DateTime? dateTime;
			global::System.DateTime t;
			for (;;)
			{
				IL_0A:
				bool flag;
				bool flag2;
				switch (num)
				{
				case 0:
					if (value != null)
					{
						num2 = (short)902430731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return value;
				case 1:
					goto IL_1F6;
				case 2:
					num2 = (short)1358888965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					flag = (dateTime.GetValueOrDefault() > t);
					goto IL_C8;
				case 4:
					value = new global::System.DateTime?(this.MaxDate);
					num2 = (short)521535489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					flag = false;
					goto IL_C8;
				case 6:
					goto IL_1F6;
				case 7:
					value = new global::System.DateTime?(this.MinDate);
					num2 = (short)2107244550;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					flag2 = (dateTime.GetValueOrDefault() < t);
					goto IL_288;
				case 9:
					if (dateTime == null)
					{
						num2 = (short)333905932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)231669768;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					flag2 = false;
					goto IL_288;
				case 11:
				{
					t = value.Value;
					int year = t.Year;
					t = value.Value;
					int month = t.Month;
					t = value.Value;
					value = new global::System.DateTime?(new global::System.DateTime(year, month, t.Day));
					num2 = (short)2047580811;
					short num3 = num2;
					num2 = (short)260807307;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10D;
					default:
						num2 = (short)4980736;
						if (num2 != 0)
						{
						}
						num2 = (short)7667726;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 12:
					num2 = (short)122093578;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (dateTime == null)
					{
						num2 = (short)601686018;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)995557377;
					if (num2 != 0)
					{
					}
					num2 = (short)1664286723;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					return value;
				}
				goto IL_4C;
				IL_C8:
				if (flag)
				{
					num2 = (short)1197801476;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_10D:
				dateTime = value;
				t = this.MinDate;
				num2 = (short)616300553;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F6:
				num2 = (short)1292369920;
				short num4 = num2;
				num2 = (short)2114125824;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_288:
				if (!flag2)
				{
					goto IL_1F6;
				}
				num2 = (short)339148807;
				num = (int)((global::System.IntPtr)num2);
			}
			return value;
			IL_4C:
			dateTime = value;
			t = this.MaxDate;
			num2 = (short)1468334093;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0002D440 File Offset: 0x0002B640
		protected virtual void OnSelectedDateChanged(global::System.DateTime? oldValue, global::System.DateTime? newValue)
		{
			short num = (short)400031744;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
				{
					num = (short)578449678;
					short num3 = num;
					num = (short)971469070;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_195;
					default:
					{
						num = (short)2114519040;
						short num4 = num;
						num = (short)1349255168;
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
					}
					break;
				}
				case 1:
					this.SelectionStart = newValue;
					this.SelectionEnd = newValue;
					num = (short)1340014595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)559677441;
					if (num != 0)
					{
					}
					try
					{
						num = (short)812122113;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								switch (0)
								{
								case 0:
									goto IL_106;
								}
								continue;
							case 2:
								num = (short)1571356676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)2093678594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.SelectedDate = newValue;
								num = (short)1483407360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_176;
							}
							IL_12B:
							num = (short)2078081027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_106:
							goto IL_12B;
						}
						IL_176:
						goto IL_201;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_189;
				case 3:
					goto IL_1FF;
				}
				IL_A8:
				if (this.MultiSelect)
				{
					num = (short)478543873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_189;
				IL_195:
				num = (short)1639448578;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_189:
				enumerator = this.b.GetEnumerator();
				goto IL_195;
			}
			IL_1FF:
			IL_201:
			this.OnSelectedDateChanged();
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0002D664 File Offset: 0x0002B864
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0002D71C File Offset: 0x0002B91C
		public global::System.DateTime? SelectedDate
		{
			get
			{
				short num = (short)914741864;
				short num2 = num;
				num = (short)161077864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1814298624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)144506880;
				if (num != 0)
				{
				}
				num = (short)783548417;
				if (num != 0)
				{
				}
				return (global::System.DateTime?)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.SelectedDateProperty);
			}
			set
			{
				short num = (short)163709033;
				short num2 = num;
				num = (short)1134100585;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1138098176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1699151872;
				if (num != 0)
				{
				}
				num = (short)36372481;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.SelectedDateProperty, value);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0002D7D4 File Offset: 0x0002B9D4
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0002D88C File Offset: 0x0002BA8C
		public bool AutoNavigate
		{
			get
			{
				short num = (short)1580811681;
				short num2 = num;
				num = (short)2131838369;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2139029504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)636944385;
				if (num != 0)
				{
				}
				num = (short)214695936;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.AutoNavigateProperty);
			}
			set
			{
				short num = (short)1228668929;
				if (num != 0)
				{
				}
				num = (short)2041184256;
				short num2 = num;
				num = (short)400107735;
				short num3 = num;
				num = (short)21178583;
				switch (num3 == num)
				{
				}
				num = (short)1711079424;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.AutoNavigateProperty, value);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0002D948 File Offset: 0x0002BB48
		private static void r(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)425129829;
					short num3 = num2;
					num2 = (short)1305474917;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)598081536;
						if (num2 != 0)
						{
						}
						if (monthCalendar != null)
						{
							num2 = (short)334561281;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					monthCalendar.OnDayNameLabelStyleChanged((global::System.Windows.Style)A_1.OldValue, (global::System.Windows.Style)A_1.NewValue);
					num2 = (short)32964609;
					if (num2 != 0)
					{
					}
					num2 = (short)1446313986;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)58654720;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)1619591168;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0002DA7C File Offset: 0x0002BC7C
		protected virtual void OnDayNameLabelStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
		{
			short num = (short)150635862;
			short num2 = num;
			num = (short)321422678;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1192951808;
				short num3 = num;
				break;
			}
			}
			num = (short)1843396609;
			if (num != 0)
			{
			}
			num = (short)991232000;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1472397313;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_E0;
						}
						continue;
					case 2:
						num = (short)179699716;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)1467809794;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.DayNameLabelStyle = newValue;
						num = (short)286064640;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_151;
					}
					IL_107:
					num = (short)1262944259;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E0:
					goto IL_107;
				}
				IL_151:;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0002DCB4 File Offset: 0x0002BEB4
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style DayNameLabelStyle
		{
			get
			{
				short num = (short)302160566;
				short num2 = num;
				num = (short)50764470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)970588160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)821166081;
				if (num != 0)
				{
				}
				num = (short)1037434880;
				if (num != 0)
				{
				}
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.DayNameLabelStyleProperty);
			}
			set
			{
				short num = (short)1915994361;
				short num2 = num;
				num = (short)1995948281;
				switch (num2 == num)
				{
				default:
				{
					num = (short)616366080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1448738817;
				if (num != 0)
				{
				}
				num = (short)1864761344;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.DayNameLabelStyleProperty, value);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0002DD68 File Offset: 0x0002BF68
		private static object e(global::System.Windows.DependencyObject A_0, object A_1)
		{
			short num = (short)740793839;
			short num2 = num;
			num = (short)493395439;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1425145856;
				short num3 = num;
				num = (short)1429536768;
				if (num != 0)
				{
				}
				monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
				if (monthCalendar == null)
				{
					return A_1;
				}
				break;
			}
			}
			num = (short)1211105281;
			if (num != 0)
			{
			}
			return monthCalendar.OnCoerceDayNames((string[])A_1);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0002DE2C File Offset: 0x0002C02C
		private static void q(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)757248361;
					short num3 = num2;
					num2 = (short)1125822825;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)225968128;
						if (num2 != 0)
						{
						}
						if (monthCalendar != null)
						{
							num2 = (short)1650327553;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					monthCalendar.OnDayNamesChanged((string[])A_1.OldValue, (string[])A_1.NewValue);
					num2 = (short)1106640898;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1719009280;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)2010972161;
			if (num2 != 0)
			{
			}
			num2 = (short)1845231616;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0002DF5C File Offset: 0x0002C15C
		protected virtual string[] OnCoerceDayNames(string[] value)
		{
			int a_ = 8;
			short num = (short)2059927552;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)805961728;
				short num3 = num;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 1:
					goto IL_A7;
				case 2:
				{
					if (value.Length == 7)
					{
						return value;
					}
					num = (short)1477625179;
					short num4 = num;
					num = (short)1726072155;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A7;
					default:
						num = (short)983891968;
						if (num != 0)
						{
						}
						num = (short)161087491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_13D;
				}
				IL_66:
				if (value != null)
				{
					num = (short)1388314625;
					if (num != 0)
					{
					}
					num = (short)986382337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return value;
				IL_A7:
				num = (short)89980930;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13D:
			throw new global::System.ArgumentException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("釔뛖ꃘ闚볜닞蓠郢엤諦鳨飪駬쿮駰鋲菴鋶\ud9f8黺藼黾戀眂椄縆⤈㰊ⴌ明攐瘒研搖㤘爚猜㼞䈠䰢䤤䬦䰨䠪夬䘮帰崲᬴", a_));
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0002E0AC File Offset: 0x0002C2AC
		protected virtual void OnDayNamesChanged(string[] oldValue, string[] newValue)
		{
			short num = (short)1207007987;
			short num2 = num;
			num = (short)1004042995;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1165230080;
				short num3 = num;
				break;
			}
			}
			num = (short)1073217537;
			if (num != 0)
			{
			}
			num = (short)1482686464;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1946288129;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_E3;
						}
						continue;
					case 2:
						num = (short)926285828;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)356450306;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.DayNames = newValue;
						num = (short)726597632;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_156;
					}
					IL_108:
					num = (short)453771267;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E3:
					goto IL_108;
				}
				IL_156:;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0002E230 File Offset: 0x0002C430
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0002E2E8 File Offset: 0x0002C4E8
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Description("Indicates array of custom names for days displayed on calendar header.")]
		public string[] DayNames
		{
			get
			{
				short num = (short)617059380;
				short num2 = num;
				num = (short)581342260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1426784256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1863712769;
				if (num != 0)
				{
				}
				num = (short)1956118528;
				if (num != 0)
				{
				}
				return (string[])base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.DayNamesProperty);
			}
			set
			{
				short num = (short)1611445217;
				short num2 = num;
				num = (short)1425257441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)890241024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)582942721;
				if (num != 0)
				{
				}
				num = (short)1349320704;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.DayNamesProperty, value);
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0002E39C File Offset: 0x0002C59C
		private static void p(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)659292161;
					if (num2 != 0)
					{
					}
					num2 = (short)63999060;
					short num3 = num2;
					num2 = (short)523406420;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)996671488;
						if (num2 != 0)
						{
						}
						if (monthCalendar != null)
						{
							num2 = (short)1932001281;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					monthCalendar.OnDayStyleChanged((global::System.Windows.Style)A_1.OldValue, (global::System.Windows.Style)A_1.NewValue);
					num2 = (short)453378050;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1481179136;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)913375232;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0002E4D4 File Offset: 0x0002C6D4
		protected virtual void OnDayStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
		{
			short num = (short)1391822910;
			short num2 = num;
			num = (short)1883342910;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)260374528;
				short num3 = num;
				break;
			}
			}
			num = (short)781713408;
			if (num != 0)
			{
			}
			num = (short)116457473;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1811087361;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_E1;
						}
						continue;
					case 2:
						num = (short)1504641028;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)1472266242;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.DayStyle = newValue;
						num = (short)1066729472;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_151;
					}
					IL_106:
					num = (short)517275651;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E1:
					goto IL_106;
				}
				IL_151:;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0002E654 File Offset: 0x0002C854
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0002E70C File Offset: 0x0002C90C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style DayStyle
		{
			get
			{
				short num = (short)1193792618;
				short num2 = num;
				num = (short)1002951786;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1590427648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)849084417;
				if (num != 0)
				{
				}
				num = (short)575209472;
				if (num != 0)
				{
				}
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.DayStyleProperty);
			}
			set
			{
				short num = (short)170533711;
				short num2 = num;
				num = (short)991503183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)38797312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)522584065;
				if (num != 0)
				{
				}
				num = (short)161546240;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.DayStyleProperty, value);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0002E7C4 File Offset: 0x0002C9C4
		private static void o(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)501801892;
					short num3 = num2;
					num2 = (short)417981348;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1903951872;
						if (num2 != 0)
						{
						}
						if (monthCalendar != null)
						{
							num2 = (short)1841299457;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					monthCalendar.OnFirstDayOfWeekChanged((global::System.DayOfWeek)A_1.OldValue, (global::System.DayOfWeek)A_1.NewValue);
					num2 = (short)1459290114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_100;
				}
				goto IL_1C;
			}
			IL_100:
			num2 = (short)2079784961;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)1256325120;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)542900224;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0002E8FC File Offset: 0x0002CAFC
		protected virtual void OnFirstDayOfWeekChanged(global::System.DayOfWeek oldValue, global::System.DayOfWeek newValue)
		{
			short num = (short)1974272001;
			if (num != 0)
			{
			}
			num = (short)1392377856;
			short num2 = num;
			num = (short)1325382777;
			short num3 = num;
			num = (short)971422841;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2126839808;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
				{
					num = (short)2090401793;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_E0;
							}
							continue;
						case 2:
							num = (short)1419837444;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)983105538;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.FirstDayOfWeek = newValue;
							num = (short)2137391104;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_150;
						}
						IL_105:
						num = (short)1156775939;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E0:
						goto IL_105;
					}
					IL_150:;
				}
				break;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0002EA7C File Offset: 0x0002CC7C
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0002EB34 File Offset: 0x0002CD34
		[global::System.ComponentModel.Description("Indicates first day of week displayed on the calendar.")]
		[global::System.ComponentModel.DefaultValue(global::System.DayOfWeek.Sunday)]
		public global::System.DayOfWeek FirstDayOfWeek
		{
			get
			{
				short num = (short)668952107;
				short num2 = num;
				num = (short)1969448491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)456130560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1446707201;
				if (num != 0)
				{
				}
				num = (short)1787363328;
				if (num != 0)
				{
				}
				return (global::System.DayOfWeek)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.FirstDayOfWeekProperty);
			}
			set
			{
				short num = (short)41823485;
				short num2 = num;
				num = (short)1783377149;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1687945216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)752943105;
				if (num != 0)
				{
				}
				num = (short)1826750464;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.FirstDayOfWeekProperty, value);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0002EBF0 File Offset: 0x0002CDF0
		private static object d(global::System.Windows.DependencyObject A_0, object A_1)
		{
			short num = (short)214462577;
			short num2 = num;
			num = (short)145780849;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)598605824;
				short num3 = num;
				num = (short)1334312960;
				if (num != 0)
				{
				}
				num = (short)1706688513;
				if (num != 0)
				{
				}
				monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
				if (monthCalendar == null)
				{
					return A_1;
				}
				break;
			}
			}
			return monthCalendar.OnCoerceMonthNames((string[])A_1);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0002ECB4 File Offset: 0x0002CEB4
		private static void n(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2093064522;
					short num3 = num2;
					num2 = (short)2080940362;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)839712769;
						if (num2 != 0)
						{
						}
						num2 = (short)619118592;
						if (num2 != 0)
						{
						}
						if (monthCalendar != null)
						{
							num2 = (short)658309121;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					monthCalendar.OnMonthNamesChanged((string[])A_1.OldValue, (string[])A_1.NewValue);
					num2 = (short)1409941506;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1502019584;
			short num4 = num2;
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num2 = (short)790691840;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
		protected virtual string[] OnCoerceMonthNames(string[] value)
		{
			int a_ = 13;
			short num = (short)2074214401;
			if (num != 0)
			{
			}
			num = (short)1451360256;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1042939904;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_8C;
					}
					continue;
				}
				case 1:
					goto IL_A7;
				case 2:
				{
					if (value.Length == 12)
					{
						return value;
					}
					num = (short)1257034846;
					short num4 = num;
					num = (short)1112790110;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A7;
					default:
						num = (short)880345088;
						if (num != 0)
						{
						}
						num = (short)1677262851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_13D;
				}
				IL_8C:
				if (value != null)
				{
					num = (short)1369309185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return value;
				IL_A7:
				num = (short)2133983234;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13D:
			throw new global::System.ArgumentException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韙돛냝铟諡ꫣ蟥藧迩鿫컭胯胱鯳蛵鷷裹裻蟽⃿漁焃甅簇⨉搋漍昏眑㐓✕⨗㨙焛笝䴟䀡䄣吥嬧", a_));
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0002EF38 File Offset: 0x0002D138
		protected virtual void OnMonthNamesChanged(string[] oldValue, string[] newValue)
		{
			short num = (short)1343600615;
			short num2 = num;
			num = (short)1683470311;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)30998528;
				short num3 = num;
				break;
			}
			}
			num = (short)1107165184;
			if (num != 0)
			{
			}
			num = (short)2055405569;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1381367809;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_E1;
						}
						continue;
					case 2:
						num = (short)38862852;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)178126850;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.MonthNames = newValue;
						num = (short)1810235392;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_151;
					}
					IL_106:
					num = (short)1067974659;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E1:
					goto IL_106;
				}
				IL_151:;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0002F170 File Offset: 0x0002D370
		public string[] MonthNames
		{
			get
			{
				short num = (short)765285875;
				short num2 = num;
				num = (short)320230899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)807141376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)574095361;
				if (num != 0)
				{
				}
				num = (short)1537736704;
				if (num != 0)
				{
				}
				return (string[])base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.MonthNamesProperty);
			}
			set
			{
				short num = (short)238369650;
				short num2 = num;
				num = (short)1199782770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2122252288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2095579136;
				if (num != 0)
				{
				}
				num = (short)416088065;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.MonthNamesProperty, value);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0002F228 File Offset: 0x0002D428
		private static object c(global::System.Windows.DependencyObject A_0, object A_1)
		{
			short num = (short)1250885633;
			if (num != 0)
			{
			}
			num = (short)611273342;
			short num2 = num;
			num = (short)1976060542;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A3;
			case 1:
				break;
			default:
			{
				num = (short)1224605696;
				short num3 = num;
				break;
			}
			}
			num = (short)975568896;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
			if (monthCalendar == null)
			{
				return A_1;
			}
			IL_A3:
			return monthCalendar.OnCoerceMultiSelect((bool)A_1);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0002F2F0 File Offset: 0x0002D4F0
		private static void m(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)130482177;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			int num3;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_32:
				num = (short)451346432;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)909846489;
					short num4 = num;
					num = (short)46540761;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1225916416;
						if (num != 0)
						{
						}
						if (monthCalendar != null)
						{
							num = (short)499843073;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					monthCalendar.OnMultiSelectChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num = (short)1014300674;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				}
				goto IL_6D;
			}
			return;
			IL_6D:
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num = (short)514981888;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0002F424 File Offset: 0x0002D624
		protected virtual bool OnCoerceMultiSelect(bool value)
		{
			short num = (short)1706885120;
			short num2 = num;
			num = (short)1699193384;
			short num3 = num;
			num = (short)1067819560;
			switch (num3 == num)
			{
			}
			num = (short)87490561;
			if (num != 0)
			{
			}
			num = (short)1870725120;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0002F4D0 File Offset: 0x0002D6D0
		protected virtual void OnMultiSelectChanged(bool oldValue, bool newValue)
		{
			short num;
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1247870976;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 1:
						num = (short)1815609347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)2026438657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.AutoSelect = !newValue;
						num = (short)1002373124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_138;
					case 4:
					{
						num = (short)1212919157;
						short num3 = num;
						num = (short)721857909;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)121700352;
							if (num != 0)
							{
							}
							goto IL_E3;
						}
						break;
					}
					}
					goto IL_46;
					IL_E3:
					num = (short)865271810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46:
					num = (short)1209008129;
					if (num != 0)
					{
					}
					goto IL_E3;
				}
				IL_138:;
			}
			num = (short)1943732224;
			short num4 = num;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0002F66C File Offset: 0x0002D86C
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0002F724 File Offset: 0x0002D924
		[global::System.ComponentModel.Description("Indicates whether multiple days can be selected by clicking each day.")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool MultiSelect
		{
			get
			{
				short num = (short)1122172928;
				short num2 = num;
				num = (short)1427834286;
				short num3 = num;
				num = (short)1664812462;
				switch (num3 == num)
				{
				}
				num = (short)1972568065;
				if (num != 0)
				{
				}
				num = (short)1951531008;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.MultiSelectProperty);
			}
			set
			{
				short num = (short)1379532800;
				short num2 = num;
				num = (short)194076692;
				short num3 = num;
				num = (short)1296130068;
				switch (num3 == num)
				{
				}
				num = (short)606142465;
				if (num != 0)
				{
				}
				num = (short)1001979904;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.MultiSelectProperty, value);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0002F7DC File Offset: 0x0002D9DC
		private static void l(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			short num;
			int num4;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				num = (short)109720859;
				short num2 = num;
				num = (short)1092891931;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B8;
				default:
				{
					num = (short)2096365568;
					short num3 = num;
					num = (short)794624001;
					if (num != 0)
					{
					}
					num = (short)2007760896;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						monthCalendar.OnShowTodayMarkerChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						num = (short)2128740353;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						if (monthCalendar != null)
						{
							num = (short)1183711232;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_B8;
				}
				}
			}
			return;
			IL_B8:
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num = (short)876675074;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0002F918 File Offset: 0x0002DB18
		protected virtual void OnShowTodayMarkerChanged(bool oldValue, bool newValue)
		{
			short num = (short)1929314305;
			if (num != 0)
			{
			}
			num = (short)1786904576;
			short num2 = num;
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1811611648;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_96;
						}
						continue;
					case 1:
						num = (short)1826357251;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)337575937;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.ShowTodayMarker = newValue;
						num = (short)151191556;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_15D;
					case 4:
					{
						num = (short)377748312;
						short num4 = num;
						num = (short)856292184;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1590099968;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					}
					IL_106:
					num = (short)202768386;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_96:
					goto IL_106;
				}
				IL_15D:;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0002FAB0 File Offset: 0x0002DCB0
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0002FB6C File Offset: 0x0002DD6C
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Description("Indicates whether today marker that indicates TodayDate is visible on the calendar.")]
		public bool ShowTodayMarker
		{
			get
			{
				short num = (short)891944960;
				short num2 = num;
				num = (short)1564278785;
				if (num != 0)
				{
				}
				num = (short)199341828;
				short num3 = num;
				num = (short)467449604;
				switch (num3 == num)
				{
				}
				num = (short)1171193856;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.ShowTodayMarkerProperty);
			}
			set
			{
				short num = (short)1228537856;
				short num2 = num;
				num = (short)1146880001;
				if (num != 0)
				{
				}
				num = (short)2022597204;
				short num3 = num;
				num = (short)2035835476;
				switch (num3 == num)
				{
				}
				num = (short)1667694592;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.ShowTodayMarkerProperty, value);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0002FC24 File Offset: 0x0002DE24
		private static void k(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_BB;
			}
			short num;
			int num4;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				num = (short)2016836717;
				short num2 = num;
				num = (short)2007268461;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_BB;
				default:
				{
					num = (short)1257373696;
					short num3 = num;
					num = (short)971964416;
					if (num != 0)
					{
					}
					num = (short)455344129;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						monthCalendar.OnShowWeekNumbersChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						num = (short)1882914817;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						if (monthCalendar != null)
						{
							num = (short)924975104;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_BB;
				}
				}
			}
			return;
			IL_BB:
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num = (short)490536962;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0002FD60 File Offset: 0x0002DF60
		protected virtual void OnShowWeekNumbersChanged(bool oldValue, bool newValue)
		{
			short num;
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)284557312;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_47;
						}
						continue;
					case 1:
						num = (short)201523203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)2017001473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.ShowWeekNumbers = newValue;
						num = (short)1769668612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_130;
					case 4:
					{
						num = (short)1189686639;
						short num3 = num;
						num = (short)1184181615;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)2018836480;
							if (num != 0)
							{
							}
							goto IL_DC;
						}
						break;
					}
					}
					goto IL_47;
					IL_DC:
					num = (short)419495938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47:
					num = (short)294649857;
					if (num != 0)
					{
					}
					goto IL_DC;
				}
				IL_130:;
			}
			num = (short)1570766848;
			short num4 = num;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0002FFB0 File Offset: 0x0002E1B0
		[global::System.ComponentModel.Description("Indicates whether week of year is visible.")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ShowWeekNumbers
		{
			get
			{
				short num = (short)526778368;
				short num2 = num;
				num = (short)84786900;
				short num3 = num;
				num = (short)716750548;
				switch (num3 == num)
				{
				}
				num = (short)294191105;
				if (num != 0)
				{
				}
				num = (short)1387200512;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.ShowWeekNumbersProperty);
			}
			set
			{
				short num = (short)1090781184;
				short num2 = num;
				num = (short)1482336379;
				short num3 = num;
				num = (short)40020091;
				switch (num3 == num)
				{
				}
				num = (short)1325531136;
				if (num != 0)
				{
				}
				num = (short)996868097;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.ShowWeekNumbersProperty, value);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0003006C File Offset: 0x0002E26C
		private static void j(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			short num;
			int num4;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				num = (short)1148148694;
				short num2 = num;
				num = (short)1178229718;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B8;
				default:
				{
					num = (short)114950144;
					short num3 = num;
					num = (short)441843712;
					if (num != 0)
					{
					}
					num = (short)1778122753;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						monthCalendar.OnTodayDateChanged((global::System.DateTime?)A_1.OldValue, (global::System.DateTime?)A_1.NewValue);
						num = (short)1470955521;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						if (monthCalendar != null)
						{
							num = (short)412352512;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_B8;
				}
				}
			}
			return;
			IL_B8:
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num = (short)231997442;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000301A4 File Offset: 0x0002E3A4
		protected virtual void OnTodayDateChanged(global::System.DateTime? oldValue, global::System.DateTime? newValue)
		{
			short num;
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1299382272;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 1:
						num = (short)2033713155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1291976705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.TodayDate = newValue;
						num = (short)2103312388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_10A;
					case 4:
					{
						num = (short)1642944099;
						short num3 = num;
						num = (short)1485592163;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1674969088;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					}
					IL_B6:
					num = (short)1225850882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46:
					goto IL_B6;
				}
				IL_10A:;
			}
			num = (short)141950976;
			short num4 = num;
			num = (short)594083841;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0003032C File Offset: 0x0002E52C
		// (set) Token: 0x0600028F RID: 655 RVA: 0x000303E4 File Offset: 0x0002E5E4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.DateTime? TodayDate
		{
			get
			{
				short num = (short)1694040064;
				short num2 = num;
				num = (short)1174142642;
				short num3 = num;
				num = (short)254738098;
				switch (num3 == num)
				{
				}
				num = (short)1119879169;
				if (num != 0)
				{
				}
				num = (short)1425539072;
				if (num != 0)
				{
				}
				return (global::System.DateTime?)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.TodayDateProperty);
			}
			set
			{
				short num = (short)833028096;
				short num2 = num;
				num = (short)1923635849;
				short num3 = num;
				num = (short)632511113;
				switch (num3 == num)
				{
				}
				num = (short)1231552513;
				if (num != 0)
				{
				}
				num = (short)343146496;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.TodayDateProperty, value);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000304A0 File Offset: 0x0002E6A0
		private static void i(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_B5;
			}
			short num;
			int num4;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				num = (short)1297809409;
				if (num != 0)
				{
				}
				num = (short)1858843006;
				short num2 = num;
				num = (short)2031333758;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B5;
				case 1:
					break;
				default:
				{
					num = (short)1510211584;
					short num3 = num;
					break;
				}
				}
				num = (short)377421824;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					monthCalendar.OnTrailingDayStyleChanged((global::System.Windows.Style)A_1.OldValue, (global::System.Windows.Style)A_1.NewValue);
					num = (short)1596719105;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					if (monthCalendar != null)
					{
						num = (short)606797824;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_B5;
			}
			return;
			IL_B5:
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num = (short)757727234;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000305D4 File Offset: 0x0002E7D4
		protected virtual void OnTrailingDayStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
		{
			short num;
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1853685760;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_47;
						}
						continue;
					case 1:
						num = (short)1315045379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1032323073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.TrailingDayStyle = newValue;
						num = (short)438435844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_10B;
					case 4:
					{
						num = (short)1973616996;
						short num3 = num;
						num = (short)552599908;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1136721920;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					}
					IL_B7:
					num = (short)1604059138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47:
					goto IL_B7;
				}
				IL_10B:;
			}
			num = (short)1324548096;
			short num4 = num;
			num = (short)961937409;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00030760 File Offset: 0x0002E960
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0003081C File Offset: 0x0002EA1C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style TrailingDayStyle
		{
			get
			{
				short num = (short)1213005824;
				short num2 = num;
				num = (short)75746804;
				short num3 = num;
				num = (short)1634782708;
				switch (num3 == num)
				{
				}
				num = (short)803667969;
				if (num != 0)
				{
				}
				num = (short)394854400;
				if (num != 0)
				{
				}
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.TrailingDayStyleProperty);
			}
			set
			{
				short num = (short)627834880;
				short num2 = num;
				num = (short)764713376;
				short num3 = num;
				num = (short)160471456;
				switch (num3 == num)
				{
				}
				num = (short)737738753;
				if (num != 0)
				{
				}
				num = (short)1592721408;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.TrailingDayStyleProperty, value);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000308D4 File Offset: 0x0002EAD4
		private static void h(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_92;
			}
			short num;
			int num4;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				num = (short)1874220291;
				short num2 = num;
				num = (short)430593283;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_92;
				default:
				{
					num = (short)646053888;
					short num3 = num;
					num = (short)348192768;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						monthCalendar.OnTrailingDaysVisibleChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						num = (short)1399455745;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						num = (short)1271005185;
						if (num != 0)
						{
						}
						if (monthCalendar != null)
						{
							num = (short)183369728;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_92;
				}
				}
			}
			return;
			IL_92:
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num = (short)2116354050;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00030A10 File Offset: 0x0002EC10
		protected virtual void OnTrailingDaysVisibleChanged(bool oldValue, bool newValue)
		{
			bool trailingDaysVisible = this.d();
			short num;
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1279459328;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					case 1:
						num = (short)1316356099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)865468417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.TrailingDaysVisible = trailingDaysVisible;
						num = (short)1098907652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_115;
					case 4:
					{
						num = (short)578614825;
						short num3 = num;
						num = (short)1515386409;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1732116480;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					}
					IL_C0:
					num = (short)401735682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F:
					goto IL_C0;
				}
				IL_115:;
			}
			num = (short)1127940096;
			short num4 = num;
			num = (short)1700790273;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00030BB0 File Offset: 0x0002EDB0
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00030C6C File Offset: 0x0002EE6C
		[global::System.ComponentModel.DefaultValue(true)]
		public bool TrailingDaysVisible
		{
			get
			{
				short num = (short)375914496;
				short num2 = num;
				num = (short)1857417810;
				short num3 = num;
				num = (short)1525084754;
				switch (num3 == num)
				{
				}
				num = (short)929497089;
				if (num != 0)
				{
				}
				num = (short)741998592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.TrailingDaysVisibleProperty);
			}
			set
			{
				short num = (short)43188224;
				short num2 = num;
				num = (short)152624657;
				short num3 = num;
				num = (short)137682449;
				switch (num3 == num)
				{
				}
				num = (short)194510848;
				if (num != 0)
				{
				}
				num = (short)1774190593;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.TrailingDaysVisibleProperty, value);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00030D28 File Offset: 0x0002EF28
		private static void g(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_BA;
			}
			short num;
			int num4;
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
			for (;;)
			{
				IL_0A:
				num = (short)395381474;
				short num2 = num;
				num = (short)1381436130;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_BA;
				default:
				{
					num = (short)1867579392;
					short num3 = num;
					num = (short)253755393;
					if (num != 0)
					{
					}
					num = (short)133038080;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						monthCalendar.OnTwoLetterDayNameChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						num = (short)35127297;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						if (monthCalendar != null)
						{
							num = (short)690487296;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_BA;
				}
				}
			}
			return;
			IL_BA:
			monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
			num = (short)648806402;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00030E64 File Offset: 0x0002F064
		protected virtual void OnTwoLetterDayNameChanged(bool oldValue, bool newValue)
		{
			short num = (short)285802497;
			if (num != 0)
			{
			}
			num = (short)989659136;
			short num2 = num;
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1135869952;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_96;
						}
						continue;
					case 1:
						num = (short)12255235;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1004863489;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.TwoLetterDayName = newValue;
						num = (short)1999503364;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_15C;
					case 4:
					{
						num = (short)1602268522;
						short num4 = num;
						num = (short)297381226;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)660930560;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					}
					IL_108:
					num = (short)595394562;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_96:
					goto IL_108;
				}
				IL_15C:;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00030FFC File Offset: 0x0002F1FC
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000310B8 File Offset: 0x0002F2B8
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Description("Indicates whether control uses the two letter day names.")]
		public bool TwoLetterDayName
		{
			get
			{
				short num = (short)1889599489;
				if (num != 0)
				{
				}
				num = (short)410750968;
				short num2 = num;
				num = (short)350326776;
				switch (num2 == num)
				{
				}
				num = (short)356319232;
				if (num != 0)
				{
				}
				num = (short)1014366208;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.TwoLetterDayNameProperty);
			}
			set
			{
				short num = (short)1665115222;
				short num2 = num;
				num = (short)712352854;
				switch (num2 == num)
				{
				}
				num = (short)336920577;
				if (num != 0)
				{
				}
				num = (short)463536128;
				if (num != 0)
				{
				}
				num = (short)1878851584;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.TwoLetterDayNameProperty, value);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00031174 File Offset: 0x0002F374
		private static void f(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1305760888;
			short num2 = num;
			num = (short)343889016;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2072444928;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				int num3;
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
						goto IL_101;
					case 1:
					{
						num = (short)1245184000;
						short num4 = num;
						monthCalendar.OnWeekendDaysSelectableChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						num = (short)149815296;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (monthCalendar != null)
						{
							num = (short)1418330113;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				IL_67:
				monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
				num = (short)278134786;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			}
			IL_101:
			num = (short)118816769;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000312AC File Offset: 0x0002F4AC
		protected virtual void OnWeekendDaysSelectableChanged(bool oldValue, bool newValue)
		{
			global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator();
			goto IL_0E;
			short num;
			try
			{
				for (;;)
				{
					IL_0E:
					num = (short)2139684868;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_139;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)1307574275;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.WeekendDaysSelectable = newValue;
							num = (short)993394690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)47972352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_47;
							}
							continue;
						}
						IL_6D:
						num = (short)1100300158;
						short num3 = num;
						num = (short)1146306430;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_0E;
						default:
							num = (short)1609826305;
							if (num != 0)
							{
							}
							num = (short)1344733184;
							if (num != 0)
							{
							}
							num = (short)2063794177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_47:
						goto IL_6D;
					}
				}
				IL_139:;
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)1322319872;
			short num4 = num;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00031448 File Offset: 0x0002F648
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00031500 File Offset: 0x0002F700
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Description("Indicates whether weekend days can be selected.")]
		public bool WeekendDaysSelectable
		{
			get
			{
				short num = (short)393359203;
				short num2 = num;
				num = (short)475475811;
				switch (num2 == num)
				{
				}
				num = (short)509607936;
				if (num != 0)
				{
				}
				num = (short)1889075201;
				if (num != 0)
				{
				}
				num = (short)1225129984;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.WeekendDaysSelectableProperty);
			}
			set
			{
				short num = (short)293297988;
				short num2 = num;
				num = (short)433413956;
				switch (num2 == num)
				{
				}
				num = (short)1121452032;
				if (num != 0)
				{
				}
				num = (short)888012801;
				if (num != 0)
				{
				}
				num = (short)1025572864;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.WeekendDaysSelectableProperty, value);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000315BC File Offset: 0x0002F7BC
		private static void e(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)60192379;
			short num2 = num;
			num = (short)446199419;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1631125504;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				int num3;
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				for (;;)
				{
					IL_54:
					switch (num3)
					{
					case 0:
						goto IL_FA;
					case 1:
					{
						num = (short)243335168;
						short num4 = num;
						monthCalendar.OnWeekLabelStyleChanged((global::System.Windows.Style)A_1.OldValue, (global::System.Windows.Style)A_1.NewValue);
						num = (short)1573191680;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (monthCalendar != null)
						{
							num = (short)1058668545;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				IL_66:
				monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
				num = (short)1028587522;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			}
			IL_FA:
			num = (short)484245505;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000316EC File Offset: 0x0002F8EC
		protected virtual void OnWeekLabelStyleChanged(global::System.Windows.Style oldValue, global::System.Windows.Style newValue)
		{
			global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator();
			goto IL_0E;
			short num;
			try
			{
				for (;;)
				{
					IL_0E:
					num = (short)1865547780;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_10D;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)452591619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.WeekLabelStyle = newValue;
							num = (short)2089353218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)839843840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_46;
							}
							continue;
						}
						IL_6B:
						num = (short)910849558;
						short num3 = num;
						num = (short)2050127382;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_0E;
						default:
							num = (short)1144389632;
							if (num != 0)
							{
							}
							num = (short)908066817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_46:
						goto IL_6B;
					}
				}
				IL_10D:;
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)122880001;
			if (num != 0)
			{
			}
			num = (short)1847853056;
			short num4 = num;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00031880 File Offset: 0x0002FA80
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00031938 File Offset: 0x0002FB38
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style WeekLabelStyle
		{
			get
			{
				short num = (short)86507521;
				if (num != 0)
				{
				}
				num = (short)337579840;
				short num2 = num;
				num = (short)1816203072;
				switch (num2 == num)
				{
				}
				num = (short)1718026240;
				if (num != 0)
				{
				}
				num = (short)2022244352;
				short num3 = num;
				return (global::System.Windows.Style)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.WeekLabelStyleProperty);
			}
			set
			{
				short num = (short)1932007398;
				short num2 = num;
				num = (short)347346918;
				switch (num2 == num)
				{
				}
				num = (short)1785724929;
				if (num != 0)
				{
				}
				num = (short)1127415808;
				if (num != 0)
				{
				}
				num = (short)525926400;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.WeekLabelStyleProperty, value);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000319F0 File Offset: 0x0002FBF0
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)531723588;
			short num2 = num;
			num = (short)538277188;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)820969473;
				if (num != 0)
				{
				}
				num = (short)48758784;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				int num3;
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				for (;;)
				{
					IL_7D:
					switch (num3)
					{
					case 0:
						return;
					case 1:
						monthCalendar.OnWeekOfYearRuleChanged((global::System.Globalization.CalendarWeekRule)A_1.OldValue, (global::System.Globalization.CalendarWeekRule)A_1.NewValue);
						num = (short)1517551616;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (monthCalendar != null)
						{
							num = (short)1432682496;
							short num4 = num;
							num = (short)808910849;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				IL_8F:
				monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
				num = (short)30146562;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00031B24 File Offset: 0x0002FD24
		protected virtual void OnWeekOfYearRuleChanged(global::System.Globalization.CalendarWeekRule oldValue, global::System.Globalization.CalendarWeekRule newValue)
		{
			global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator();
			goto IL_0E;
			short num;
			try
			{
				for (;;)
				{
					IL_0E:
					num = (short)557645828;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_135;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)1283588099;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.WeekOfYearRule = newValue;
							num = (short)914751490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1703673856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_46;
							}
							continue;
						}
						IL_6B:
						num = (short)221197343;
						short num3 = num;
						num = (short)429536287;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_0E;
						default:
							num = (short)1091371008;
							if (num != 0)
							{
							}
							num = (short)1478492161;
							if (num != 0)
							{
							}
							num = (short)2129592321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_46:
						goto IL_6B;
					}
				}
				IL_135:;
			}
			finally
			{
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)1486946304;
			short num4 = num;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x00031CBC File Offset: 0x0002FEBC
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00031D74 File Offset: 0x0002FF74
		[global::System.ComponentModel.Description("Indicates rule used to determine first week of the year for week of year display on calendar.")]
		[global::System.ComponentModel.DefaultValue(global::System.Globalization.CalendarWeekRule.FirstDay)]
		public global::System.Globalization.CalendarWeekRule WeekOfYearRule
		{
			get
			{
				short num = (short)1384283846;
				short num2 = num;
				num = (short)1179156166;
				switch (num2 == num)
				{
				}
				num = (short)1907556353;
				if (num != 0)
				{
				}
				num = (short)465240064;
				if (num != 0)
				{
				}
				num = (short)361103360;
				short num3 = num;
				return (global::System.Globalization.CalendarWeekRule)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.WeekOfYearRuleProperty);
			}
			set
			{
				short num = (short)255889659;
				short num2 = num;
				num = (short)300060923;
				switch (num2 == num)
				{
				}
				num = (short)281280513;
				if (num != 0)
				{
				}
				num = (short)662896640;
				if (num != 0)
				{
				}
				num = (short)2094399488;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.WeekOfYearRuleProperty, value);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060002A8 RID: 680 RVA: 0x00031E30 File Offset: 0x00030030
		// (remove) Token: 0x060002A9 RID: 681 RVA: 0x00031EE4 File Offset: 0x000300E4
		public event global::System.Windows.RoutedEventHandler SelectedDateChanged
		{
			add
			{
				short num = (short)1144312122;
				short num2 = num;
				num = (short)980734266;
				switch (num2 == num)
				{
				}
				num = (short)1767112704;
				if (num != 0)
				{
				}
				num = (short)1266155521;
				if (num != 0)
				{
				}
				num = (short)1466892288;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.MonthCalendar.SelectedDateChangedEvent, value);
			}
			remove
			{
				short num = (short)1363083265;
				if (num != 0)
				{
				}
				num = (short)915173909;
				short num2 = num;
				num = (short)106590741;
				switch (num2 == num)
				{
				}
				num = (short)1584922624;
				if (num != 0)
				{
				}
				num = (short)1996488704;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.MonthCalendar.SelectedDateChangedEvent, value);
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060002AA RID: 682 RVA: 0x00031F98 File Offset: 0x00030198
		// (remove) Token: 0x060002AB RID: 683 RVA: 0x0003204C File Offset: 0x0003024C
		public event global::System.Windows.RoutedEventHandler PreviewSelectedDateChanged
		{
			add
			{
				short num = (short)1429448418;
				short num2 = num;
				num = (short)1509664482;
				switch (num2 == num)
				{
				}
				num = (short)154402817;
				if (num != 0)
				{
				}
				num = (short)1171324928;
				if (num != 0)
				{
				}
				num = (short)1296236544;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.MonthCalendar.PreviewSelectedDateChangedEvent, value);
			}
			remove
			{
				short num = (short)1809298997;
				short num2 = num;
				num = (short)1572255285;
				switch (num2 == num)
				{
				}
				num = (short)1142816768;
				if (num != 0)
				{
				}
				num = (short)305594369;
				if (num != 0)
				{
				}
				num = (short)1450377216;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.MonthCalendar.PreviewSelectedDateChangedEvent, value);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00032100 File Offset: 0x00030300
		protected virtual void OnSelectedDateChanged()
		{
			short num = (short)1788346369;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.MonthCalendar.PreviewSelectedDateChangedEvent);
			base.RaiseEvent(routedEventArgs);
			if (routedEventArgs.Handled)
			{
				num = (short)360644005;
				short num2 = num;
				num = (short)246807973;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B9;
				case 1:
					break;
				default:
				{
					num = (short)280035328;
					short num3 = num;
					break;
				}
				}
				num = (short)346095616;
				if (num != 0)
				{
				}
				return;
			}
			IL_B9:
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.MonthCalendar.SelectedDateChangedEvent);
			base.RaiseEvent(e);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000321D8 File Offset: 0x000303D8
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1589362096;
			short num2 = num;
			num = (short)1165671856;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2026176513;
				if (num != 0)
				{
				}
				num = (short)1672609792;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				int num3;
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				for (;;)
				{
					IL_79:
					switch (num3)
					{
					case 0:
						return;
					case 1:
						monthCalendar.OnMaxSelectionCountChanged((int)A_1.OldValue, (int)A_1.NewValue);
						num = (short)1066991616;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (monthCalendar != null)
						{
							num = (short)871563264;
							short num4 = num;
							num = (short)1096679425;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				IL_8B:
				monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
				num = (short)1029111810;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_79;
			}
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00032308 File Offset: 0x00030508
		protected virtual void OnMaxSelectionCountChanged(int oldValue, int newValue)
		{
			short num = (short)1273614631;
			short num2 = num;
			num = (short)1843581223;
			switch (num2 == num)
			{
			}
			num = (short)1943470081;
			if (num != 0)
			{
			}
			num = (short)2006581248;
			if (num != 0)
			{
			}
			num = (short)1090387968;
			short num3 = num;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002AF RID: 687 RVA: 0x000323B0 File Offset: 0x000305B0
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00032468 File Offset: 0x00030668
		[global::System.ComponentModel.DefaultValue(7)]
		[global::System.ComponentModel.Description("Gets or sets the maximum number of days that can be selected in a month calendar control.")]
		public int MaxSelectionCount
		{
			get
			{
				short num = (short)1447762445;
				short num2 = num;
				num = (short)1398151693;
				switch (num2 == num)
				{
				}
				num = (short)551026689;
				if (num != 0)
				{
				}
				num = (short)44040192;
				if (num != 0)
				{
				}
				num = (short)871038976;
				short num3 = num;
				return (int)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.MaxSelectionCountProperty);
			}
			set
			{
				short num = (short)1289200280;
				short num2 = num;
				num = (short)1564058264;
				switch (num2 == num)
				{
				}
				num = (short)2127888384;
				if (num != 0)
				{
				}
				num = (short)1355153409;
				if (num != 0)
				{
				}
				num = (short)327090176;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.MaxSelectionCountProperty, value);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00032524 File Offset: 0x00030724
		private static object b(global::System.Windows.DependencyObject A_0, object A_1)
		{
			short num = (short)110362625;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
			if (monthCalendar != null)
			{
				num = (short)427784661;
				short num2 = num;
				num = (short)585595349;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return A_1;
				case 1:
					break;
				default:
				{
					num = (short)1722679296;
					short num3 = num;
					break;
				}
				}
				num = (short)1028653056;
				if (num != 0)
				{
				}
				return monthCalendar.OnCoerceSelectionStart((global::System.DateTime?)A_1);
			}
			return A_1;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000325F0 File Offset: 0x000307F0
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1602815592;
			short num2 = num;
			num = (short)502728296;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)822214656;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				int num3;
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				for (;;)
				{
					IL_57:
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1376124928;
						short num4 = num;
						num = (short)191299585;
						if (num != 0)
						{
						}
						monthCalendar.OnSelectionStartChanged((global::System.DateTime?)A_1.OldValue, (global::System.DateTime?)A_1.NewValue);
						num = (short)341311488;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (monthCalendar != null)
						{
							num = (short)419561473;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				IL_69:
				monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
				num = (short)644087810;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00032728 File Offset: 0x00030928
		protected virtual global::System.DateTime? OnCoerceSelectionStart(global::System.DateTime? value)
		{
			short num = (short)2024821903;
			short num2 = num;
			num = (short)1517573263;
			switch (num2 == num)
			{
			}
			num = (short)147718144;
			if (num != 0)
			{
			}
			num = (short)1992163329;
			if (num != 0)
			{
			}
			num = (short)1876361216;
			short num3 = num;
			return value;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000327D0 File Offset: 0x000309D0
		protected virtual void OnSelectionStartChanged(global::System.DateTime? oldValue, global::System.DateTime? newValue)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.DateTime dateTime;
				global::System.DateTime a_;
				switch (num)
				{
				case 0:
					goto IL_E2;
				case 1:
					goto IL_C9;
				case 2:
				{
					dateTime = global::System.DateTime.MinValue;
					global::System.DateTime? selectionStart = this.SelectionStart;
					num2 = (short)1578069374;
					short num3 = num2;
					num2 = (short)395079038;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					default:
						num2 = (short)837287936;
						if (num2 != 0)
						{
						}
						num2 = (short)327024645;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					a_ = newValue.Value;
					num2 = (short)1239547910;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return;
				case 5:
				{
					global::System.DateTime? selectionStart;
					if (selectionStart != null)
					{
						num2 = (short)1112408071;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C9;
				}
				case 6:
				{
					num2 = (short)612302848;
					short num4 = num2;
					goto IL_19D;
				}
				case 7:
				{
					global::System.DateTime? selectionStart = this.SelectionStart;
					dateTime = selectionStart.Value;
					num2 = (short)852099073;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					if (this.MultiSelect)
					{
						num2 = (short)194904066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_34;
				IL_C9:
				a_ = dateTime;
				num2 = (short)723648512;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E2:
				if (newValue != null)
				{
					num2 = (short)1545732099;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_19D:
				num2 = (short)1709768705;
				if (num2 != 0)
				{
				}
				this.a(dateTime, a_);
				num2 = (short)1417674756;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_34:
			base.CoerceValue(global::DevComponents.WpfEditors.MonthCalendar.SelectionEndProperty);
			num2 = (short)1655570440;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000329F0 File Offset: 0x00030BF0
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00032AAC File Offset: 0x00030CAC
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.DateTime? SelectionStart
		{
			get
			{
				short num = (short)1205842141;
				short num2 = num;
				num = (short)1525264605;
				switch (num2 == num)
				{
				}
				num = (short)571801601;
				if (num != 0)
				{
				}
				num = (short)86835200;
				if (num != 0)
				{
				}
				num = (short)889520128;
				short num3 = num;
				return (global::System.DateTime?)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.SelectionStartProperty);
			}
			set
			{
				short num = (short)1147851477;
				short num2 = num;
				num = (short)1030017749;
				switch (num2 == num)
				{
				}
				num = (short)1008467968;
				if (num != 0)
				{
				}
				num = (short)684720129;
				if (num != 0)
				{
				}
				num = (short)1129250816;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.SelectionStartProperty, value);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00032B64 File Offset: 0x00030D64
		private static object a(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.MonthCalendar monthCalendar = A_0 as global::DevComponents.WpfEditors.MonthCalendar;
			if (monthCalendar != null)
			{
				short num = (short)1362275326;
				short num2 = num;
				num = (short)987212798;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)458555392;
					short num3 = num;
					num = (short)2133590016;
					if (num != 0)
					{
					}
					num = (short)726269953;
					if (num != 0)
					{
					}
					return monthCalendar.OnCoerceSelectionEnd((global::System.DateTime?)A_1);
				}
				}
			}
			return A_1;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00032C30 File Offset: 0x00030E30
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)324320034;
			short num2 = num;
			num = (short)1242348322;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)200605696;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_65;
				}
				int num3;
				global::DevComponents.WpfEditors.MonthCalendar monthCalendar;
				for (;;)
				{
					IL_53:
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)2069889024;
						short num4 = num;
						monthCalendar.OnSelectionEndChanged((global::System.DateTime?)A_1.OldValue, (global::System.DateTime?)A_1.NewValue);
						num = (short)458620929;
						if (num != 0)
						{
						}
						num = (short)1785856000;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (monthCalendar != null)
						{
							num = (short)1502806017;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				IL_65:
				monthCalendar = (A_0 as global::DevComponents.WpfEditors.MonthCalendar);
				num = (short)2130706434;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_53;
			}
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00032D64 File Offset: 0x00030F64
		protected virtual global::System.DateTime? OnCoerceSelectionEnd(global::System.DateTime? value)
		{
			short num = (short)123404288;
			switch (num)
			{
			default:
			{
				num = (short)2009006082;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1427636224;
					short num3 = num;
					global::System.DateTime? selectionStart;
					bool flag;
					switch (num2)
					{
					case 0:
					{
						selectionStart = this.SelectionStart;
						global::System.DateTime value2;
						global::System.TimeSpan timeSpan = value2.Subtract(selectionStart.Value);
						num = (short)444530695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return value;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 3:
						return value;
					case 4:
						return value;
					case 5:
						value = this.SelectionStart;
						num = (short)972619777;
						if (num != 0)
						{
						}
						num = (short)511901700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (selectionStart == null)
						{
							num = (short)1567621130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)631177225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.TimeSpan timeSpan;
						if (timeSpan.TotalDays >= (double)this.MaxSelectionCount)
						{
							num = (short)513802252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return value;
					}
					case 8:
						flag = false;
						goto IL_1FD;
					case 9:
					{
						global::System.DateTime t;
						flag = (t < selectionStart.GetValueOrDefault());
						goto IL_1FD;
					}
					case 10:
						num = (short)836239368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						if (selectionStart == null)
						{
							num = (short)734199821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.DateTime value2 = value.Value;
						global::System.DateTime t = value2;
						selectionStart = this.SelectionStart;
						num = (short)983957510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						num = (short)1555900316;
						short num4 = num;
						num = (short)1272129436;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_202;
						default:
						{
							num = (short)1567227904;
							if (num != 0)
							{
							}
							selectionStart = this.SelectionStart;
							global::System.DateTime t = selectionStart.Value;
							value = new global::System.DateTime?(t.AddDays((double)(this.MaxSelectionCount - 1)));
							num = (short)895352835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 13:
						value = null;
						num = (short)2117009409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (selectionStart != null)
						{
							num = (short)1571291136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return value;
					case 15:
						selectionStart = this.SelectionStart;
						num = (short)1589772299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AC:
					if (value != null)
					{
						num = (short)458817551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_202:
					num = (short)1898971141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FD:
					if (flag)
					{
						goto IL_202;
					}
					selectionStart = this.SelectionStart;
					num = (short)381550606;
					num2 = (int)((global::System.IntPtr)num);
				}
				return value;
			}
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000330F0 File Offset: 0x000312F0
		protected virtual void OnSelectionEndChanged(global::System.DateTime? oldValue, global::System.DateTime? newValue)
		{
			short num = (short)1067057152;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.DateTime? selectionStart;
				global::System.DateTime dateTime;
				global::System.DateTime a_;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 1:
					goto IL_15F;
				case 2:
					if (selectionStart != null)
					{
						num = (short)2007826433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DB;
				case 3:
				{
					num = (short)225662257;
					short num3 = num;
					num = (short)374428977;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15F;
					default:
						num = (short)1336016896;
						if (num != 0)
						{
						}
						goto IL_161;
					}
					break;
				}
				case 4:
					if (newValue != null)
					{
						num = (short)1797914632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				case 5:
					dateTime = global::System.DateTime.MinValue;
					selectionStart = this.SelectionStart;
					num = (short)664600578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1AF;
				case 7:
					goto IL_DB;
				case 8:
					a_ = newValue.Value;
					num = (short)1666187267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_48:
				if (this.MultiSelect)
				{
					num = (short)135135237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_DB:
				a_ = dateTime;
				num = (short)217972740;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15F:
				selectionStart = this.SelectionStart;
				dateTime = selectionStart.Value;
				num = (short)294912007;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_161:
				num = (short)1715666944;
				short num4 = num;
				this.a(dateTime, a_);
				this.OnSelectedDateChanged();
				num = (short)1224605702;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1AF:
			num = (short)122552321;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00033300 File Offset: 0x00031500
		// (set) Token: 0x060002BC RID: 700 RVA: 0x000333BC File Offset: 0x000315BC
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.DateTime? SelectionEnd
		{
			get
			{
				short num = (short)1957070768;
				short num2 = num;
				num = (short)1262061488;
				switch (num2 == num)
				{
				}
				num = (short)490799104;
				if (num != 0)
				{
				}
				num = (short)1430913024;
				short num3 = num;
				num = (short)1414725633;
				if (num != 0)
				{
				}
				return (global::System.DateTime?)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.SelectionEndProperty);
			}
			set
			{
				short num = (short)1781295968;
				short num2 = num;
				num = (short)624847712;
				switch (num2 == num)
				{
				}
				num = (short)1149435905;
				if (num != 0)
				{
				}
				num = (short)1506607104;
				short num3 = num;
				num = (short)1442578432;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.SelectionEndProperty, value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0003347C File Offset: 0x0003167C
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00033538 File Offset: 0x00031738
		public global::System.Windows.Visibility TodayButtonVisibility
		{
			get
			{
				short num = (short)609882798;
				short num2 = num;
				num = (short)1588531886;
				switch (num2 == num)
				{
				}
				num = (short)1774452736;
				if (num != 0)
				{
				}
				num = (short)1943011328;
				short num3 = num;
				num = (short)2004680705;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.TodayButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1927482844;
				short num2 = num;
				num = (short)224857564;
				switch (num2 == num)
				{
				}
				num = (short)1193082880;
				if (num != 0)
				{
				}
				num = (short)1407385600;
				short num3 = num;
				num = (short)2097020929;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.TodayButtonVisibilityProperty, value);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000335F4 File Offset: 0x000317F4
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x000336B0 File Offset: 0x000318B0
		public global::System.Windows.Visibility ClearButtonVisibility
		{
			get
			{
				short num = (short)1684552943;
				short num2 = num;
				num = (short)1582578927;
				switch (num2 == num)
				{
				}
				num = (short)1851850752;
				if (num != 0)
				{
				}
				num = (short)1612054528;
				short num3 = num;
				num = (short)140640257;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.ClearButtonVisibilityProperty);
			}
			set
			{
				short num = (short)632749580;
				short num2 = num;
				num = (short)1864433164;
				switch (num2 == num)
				{
				}
				num = (short)146145281;
				if (num != 0)
				{
				}
				num = (short)2058289152;
				short num3 = num;
				num = (short)1601175552;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.ClearButtonVisibilityProperty, value);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00033768 File Offset: 0x00031968
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0003381C File Offset: 0x00031A1C
		[global::System.ComponentModel.Localizable(true)]
		public object TodayButtonContent
		{
			get
			{
				short num = (short)1428447120;
				short num2 = num;
				num = (short)91774864;
				switch (num2 == num)
				{
				}
				num = (short)1007288321;
				if (num != 0)
				{
				}
				num = (short)1607335936;
				short num3 = num;
				num = (short)1448607744;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.TodayButtonContentProperty);
			}
			set
			{
				short num = (short)240660991;
				short num2 = num;
				num = (short)2106798591;
				switch (num2 == num)
				{
				}
				num = (short)1430126592;
				if (num != 0)
				{
				}
				num = (short)1600258048;
				short num3 = num;
				num = (short)91684865;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.TodayButtonContentProperty, value);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x000338D0 File Offset: 0x00031AD0
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00033984 File Offset: 0x00031B84
		[global::System.ComponentModel.Localizable(true)]
		public object ClearButtonContent
		{
			get
			{
				short num = (short)1423245313;
				if (num != 0)
				{
				}
				num = (short)1650255295;
				short num2 = num;
				num = (short)44754367;
				switch (num2 == num)
				{
				}
				num = (short)260112384;
				short num3 = num;
				num = (short)387317760;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.ClearButtonContentProperty);
			}
			set
			{
				short num = (short)582108962;
				short num2 = num;
				num = (short)1134970658;
				switch (num2 == num)
				{
				}
				num = (short)1107296257;
				if (num != 0)
				{
				}
				num = (short)927793152;
				short num3 = num;
				num = (short)40435712;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.ClearButtonContentProperty, value);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00033A38 File Offset: 0x00031C38
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00033AF4 File Offset: 0x00031CF4
		public global::System.Windows.CornerRadius CornerRadius
		{
			get
			{
				short num = (short)296937163;
				short num2 = num;
				num = (short)368240331;
				switch (num2 == num)
				{
				}
				num = (short)1896087552;
				if (num != 0)
				{
				}
				num = (short)1463418880;
				short num3 = num;
				num = (short)1964244993;
				if (num != 0)
				{
				}
				return (global::System.Windows.CornerRadius)base.GetValue(global::DevComponents.WpfEditors.MonthCalendar.CornerRadiusProperty);
			}
			set
			{
				short num = (short)1916790084;
				short num2 = num;
				num = (short)1197270340;
				switch (num2 == num)
				{
				}
				num = (short)208994305;
				if (num != 0)
				{
				}
				num = (short)2125332480;
				short num3 = num;
				num = (short)1242955776;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.MonthCalendar.CornerRadiusProperty, value);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00033BB0 File Offset: 0x00031DB0
		static MonthCalendar()
		{
			int a_ = 17;
			short num = (short)950631774;
			short num2 = num;
			num = (short)812350814;
			switch (num2 == num)
			{
			}
			num = (short)2067005440;
			if (num != 0)
			{
			}
			num = (short)1753677824;
			short num3 = num;
			num = (short)471859201;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.MonthCalendar.MonthlyMarkedDatesProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝迟賡郣軥蓧鏩ꇫ迭苯駱釳鋵볷鯹裻鯽珿", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.ac)));
			global::DevComponents.WpfEditors.MonthCalendar.AnnuallyMarkedDatesProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鿝軟賡釣蟥蓧蛩闫ꏭ釯胱鿳鏵鳷뻹鷻諽旿焁", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.ab)));
			global::DevComponents.WpfEditors.MonthCalendar.MarkedDatesProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝臟郡迣菥賧껩跫髭闯臱", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTime>), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.aa)));
			global::DevComponents.WpfEditors.MonthCalendar.AnnuallyMarkedDatesStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鿝軟賡釣蟥蓧蛩闫ꏭ釯胱鿳鏵鳷뻹鷻諽旿焁圃爅焇昉椋", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.z)));
			global::DevComponents.WpfEditors.MonthCalendar.MonthlyMarkedDatesStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝迟賡郣軥蓧鏩ꇫ迭苯駱釳鋵볷鯹裻鯽珿儁瀃缅搇漉", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.y)));
			global::DevComponents.WpfEditors.MonthCalendar.MarkedDatesStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝臟郡迣菥賧껩跫髭闯臱ꟳ苵臷雹駻", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.x)));
			global::DevComponents.WpfEditors.MonthCalendar.CalendarDimensionsProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝臟軡臣裥賧诩黫ꫭ駯鿱釳飵请鏹鏻都珿", a_), typeof(global::System.Windows.Size), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(new global::System.Windows.Size(1.0, 1.0), new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.w), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.MonthCalendar.h)));
			global::DevComponents.WpfEditors.MonthCalendar.NavigationVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郝臟铡跣臥觧黩藫臭黯ꓱ鷳藵釷飹闻鋽槿瘁紃", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::DevComponents.WpfEditors.MonthCalendar.DisplayMonthProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髝觟釡铣諥觧鏩ꇫ臭黯蛱鳳", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.Today, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.v), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.MonthCalendar.g)));
			global::DevComponents.WpfEditors.MonthCalendar.AnimationEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鿝軟诡解蟥鳧菩菫胭뗯鳱闳铵铷鿹飻", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.MonthCalendar.MinDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝觟賡ꃣ蟥鳧迩", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.MinValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.u)));
			global::DevComponents.WpfEditors.MonthCalendar.MaxDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝臟髡ꃣ蟥鳧迩", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.MaxValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.t)));
			global::DevComponents.WpfEditors.MonthCalendar.SelectedDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("距藟軡臣藥鳧迩裫ꫭ釯蛱釳", a_), typeof(global::System.DateTime?), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.s), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.MonthCalendar.f)));
			global::DevComponents.WpfEditors.MonthCalendar.AutoNavigateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鿝闟雡诣꣥觧鳩藫觭釯蛱釳", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.MonthCalendar.DayNameLabelStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髝臟鯡ꫣ蟥藧迩ꃫ迭鋯韱飳ꗵ賷菹郻鯽", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.r)));
			global::DevComponents.WpfEditors.MonthCalendar.DayNamesProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髝臟鯡ꫣ蟥藧迩鿫", a_), typeof(string[]), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.q), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.MonthCalendar.e)));
			global::DevComponents.WpfEditors.MonthCalendar.DayStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髝臟鯡럣鋥釧蛩觫", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.p)));
			global::DevComponents.WpfEditors.MonthCalendar.FirstDayOfWeekProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飝觟郡韣鋥곧诩闫ꇭ雯ꗱ釳鏵鏷", a_), typeof(global::System.DayOfWeek), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.DayOfWeek.Sunday, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.o)));
			global::DevComponents.WpfEditors.MonthCalendar.MonthNamesProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝迟賡郣軥ꛧ诩臫语華", a_), typeof(string[]), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.n), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.MonthCalendar.d)));
			global::DevComponents.WpfEditors.MonthCalendar.MultiSelectProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝闟軡郣迥믧迩胫语鏯蛱", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.m), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.MonthCalendar.c)));
			global::DevComponents.WpfEditors.MonthCalendar.ShowTodayMarkerProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("距裟跡鏣닥蟧軩跫韭뷯鏱蛳鷵鷷裹", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.l)));
			global::DevComponents.WpfEditors.MonthCalendar.ShowWeekNumbersProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("距裟跡鏣뇥跧迩蟫ꃭ藯鿱雳鏵諷觹", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.k)));
			global::DevComponents.WpfEditors.MonthCalendar.TodayDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝迟蛡藣鿥곧诩飫语", a_), typeof(global::System.DateTime?), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.j)));
			global::DevComponents.WpfEditors.MonthCalendar.TrailingDayStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝鋟菡跣諥臧蓩诫ꫭ釯诱ꟳ苵臷雹駻", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.i)));
			global::DevComponents.WpfEditors.MonthCalendar.TrailingDaysVisibleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝鋟菡跣諥臧蓩诫ꫭ釯诱蟳ꃵ釷觹闻鳽泿朁", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.h)));
			global::DevComponents.WpfEditors.MonthCalendar.TwoLetterDayNameProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝韟跡꣣菥鳧黩觫鳭듯鏱跳룵駷韹駻", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.g)));
			global::DevComponents.WpfEditors.MonthCalendar.WeekendDaysSelectableProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觝藟蟡迣菥蛧軩꣫迭觯臱ꟳ鏵铷鿹鿻諽懿态栃挅", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.f)));
			global::DevComponents.WpfEditors.MonthCalendar.WeekLabelStyleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觝藟蟡迣ꫥ觧裩觫苭ꏯ蛱跳髵鷷", a_), typeof(global::System.Windows.Style), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.e)));
			global::DevComponents.WpfEditors.MonthCalendar.WeekOfYearRuleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觝藟蟡迣ꧥ軧돩觫迭苯ꃱ至髵鷷", a_), typeof(global::System.Globalization.CalendarWeekRule), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.Globalization.CalendarWeekRule.FirstDay, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.d)));
			global::DevComponents.WpfEditors.MonthCalendar.SelectedDateChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("距藟軡臣藥鳧迩裫ꫭ釯蛱釳뗵郷鯹鋻駽旿昁", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.MonthCalendar));
			global::DevComponents.WpfEditors.MonthCalendar.PreviewSelectedDateChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軝鋟蟡鋣迥跧鷩뿫语鳯韱音苵鷷黹룻鿽瓿朁䜃清椇搉欋欍琏", a_), global::System.Windows.RoutingStrategy.Tunnel, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.MonthCalendar));
			global::DevComponents.WpfEditors.MonthCalendar.MaxSelectionCountProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝臟髡럣菥蓧迩迫髭駯鷱髳뗵韷迹鋻諽", a_), typeof(int), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(7, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.c)));
			global::DevComponents.WpfEditors.MonthCalendar.SelectionStartProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("距藟軡臣藥鳧菩菫胭ꏯ蛱闳蓵賷", a_), typeof(global::System.DateTime?), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.b), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.MonthCalendar.b)));
			global::DevComponents.WpfEditors.MonthCalendar.SelectionEndProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("距藟軡臣藥鳧菩菫胭뗯鳱郳", a_), typeof(global::System.DateTime?), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.MonthCalendar.a), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.MonthCalendar.a)));
			global::DevComponents.WpfEditors.MonthCalendar.TodayButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝迟蛡藣鿥ꫧ鿩飫髭鿯鳱ꋳ鿵请鏹黻韽泿欁瀃缅", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::DevComponents.WpfEditors.MonthCalendar.ClearButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝賟蟡藣铥ꫧ鿩飫髭鿯鳱ꋳ鿵请鏹黻韽泿欁瀃缅", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::DevComponents.WpfEditors.MonthCalendar.TodayButtonContentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝迟蛡藣鿥ꫧ鿩飫髭鿯鳱럳駵雷軹駻都瓿", a_), typeof(object), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝迟蛡藣鿥", a_)));
			global::DevComponents.WpfEditors.MonthCalendar.ClearButtonContentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝賟蟡藣铥ꫧ鿩飫髭鿯鳱럳駵雷軹駻都瓿", a_), typeof(object), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝賟蟡藣铥", a_)));
			global::DevComponents.WpfEditors.MonthCalendar.CornerRadiusProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝迟郡諣菥髧룩跫諭駯蟱蟳", a_), typeof(global::System.Windows.CornerRadius), typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.UIPropertyMetadata(default(global::System.Windows.CornerRadius)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.MonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.MonthCalendar)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.MonthCalendar), global::System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.MonthCalendar.b));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.MonthCalendar), global::DevComponents.WpfEditors.SingleMonthCalendar.SelectedDateChangedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.MonthCalendar.a));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000346B8 File Offset: 0x000328B8
		public override void OnApplyTemplate()
		{
			int a_ = 9;
			short num = (short)1468268545;
			if (num != 0)
			{
			}
			num = (short)1437827741;
			short num2 = num;
			num = (short)1044087453;
			switch (num2 == num)
			{
			}
			num = (short)1963065344;
			short num3 = num;
			num = (short)1470496768;
			if (num != 0)
			{
			}
			this.a = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闕맗뛙맛냝蓟菡難ꇥ髧菩裫", a_)) as global::System.Windows.Controls.Grid);
			this.c();
			this.a(false, false);
			base.OnApplyTemplate();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000347A0 File Offset: 0x000329A0
		private void f()
		{
			short num = (short)2041839616;
			short num2 = num;
			using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
			{
				num = (short)1889615096;
				short num3 = num;
				num = (short)328154360;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1025572864;
					if (num != 0)
					{
					}
					num = (short)227540993;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)298123267;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_BB;
						}
						continue;
					case 3:
						goto IL_12A;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)999030784;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.UpdateCalendarDisplay();
						num = (short)1758134274;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DF:
					num = (short)659947524;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB:
					goto IL_DF;
				}
				IL_12A:;
			}
			num = (short)1491140609;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00034920 File Offset: 0x00032B20
		private void a(bool A_0, bool A_1)
		{
			int a_ = 17;
			short num = (short)1981677568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				global::System.DateTime displayMonth;
				global::DevComponents.WpfEditors.StateAnimationControl stateAnimationControl;
				bool flag;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_387;
					case 1:
						goto IL_4C7;
					case 2:
						goto IL_4C7;
					case 3:
						try
						{
							num = (short)1684129894;
							short num3 = num;
							num = (short)2017380454;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)553910272;
								if (num != 0)
								{
								}
								num = (short)521601025;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2D1;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_262;
									}
									continue;
								case 2:
									try
									{
										displayMonth = displayMonth.AddMonths(1);
										break;
									}
									catch (global::System.ArgumentOutOfRangeException)
									{
										goto IL_3C5;
									}
									goto IL_2D1;
								case 3:
									goto IL_2EA;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)481820672;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.DisplayMonth = displayMonth;
									num = (short)1491664898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_288:
								num = (short)531300356;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_262:
								goto IL_288;
								IL_2D1:
								num = (short)1306722307;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2EA:
							goto IL_3C5;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2FD;
						IL_3C5:
						num = (short)1730674697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.a())
						{
							num = (short)189726731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					case 5:
						num = (short)1983250433;
						if (num != 0)
						{
						}
						if (A_1)
						{
							num = (short)480968710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					case 6:
					{
						num = (short)1269760000;
						short num4 = num;
						num = (short)1927741447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (stateAnimationControl != null)
						{
							num = (short)1272709133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					case 8:
						goto IL_2FD;
					case 9:
						if (this.MultiSelect)
						{
							num = (short)97583114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_387;
					case 10:
						this.e();
						num = (short)1776287744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)79036437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (A_0)
						{
							num = (short)687996944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stateAnimationControl.AnimationType = global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromLeftToRight;
						num = (short)571408386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1702887442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)351141892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return;
					case 16:
						stateAnimationControl.AnimationType = global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromRightToLeft;
						num = (short)544276481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)530579468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (!stateAnimationControl.IsAnimating)
						{
							num = (short)2090008590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					case 19:
						if (flag)
						{
							num = (short)79429640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 20:
						goto IL_112;
					case 21:
						if (base.IsInitialized)
						{
							num = (short)373948433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					}
					goto IL_8F;
					IL_112:
					enumerator = this.b.GetEnumerator();
					num = (short)777977859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FD:
					stateAnimationControl.AnimateStateTransition();
					num = (short)1332871183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_387:
					num = (short)1997340691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C7:
					stateAnimationControl.StartStateTransition();
					flag = true;
					num = (short)1763966996;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8F:
				displayMonth = this.DisplayMonth;
				stateAnimationControl = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("距铟菡郣菥ꧧ蓩藫菭釯蛱鷳駵雷", a_)) as global::DevComponents.WpfEditors.StateAnimationControl);
				flag = false;
				num = (short)1567031301;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00034E50 File Offset: 0x00033050
		private void e()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::System.DateTime? dateTime;
			global::System.DateTime dateTime2;
			short num2;
			global::System.DateTime a_;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_12A:
					goto IL_BE;
				case 1:
					dateTime = this.SelectionStart;
					dateTime2 = dateTime.Value;
					num2 = (short)742391808;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_12C;
				case 3:
					if (dateTime != null)
					{
						num2 = (short)1872756741;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12C;
				case 4:
					if (dateTime != null)
					{
						num2 = (short)2050818049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BE;
				case 5:
					dateTime = this.SelectionEnd;
					a_ = dateTime.Value;
					num2 = (short)1628176385;
					if (num2 != 0)
					{
					}
					num2 = (short)1616773122;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_BE:
				a_ = dateTime2;
				dateTime = this.SelectionEnd;
				num2 = (short)1139146755;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_12C:
				num2 = (short)511435501;
				short num3 = num2;
				num2 = (short)425714413;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12A;
				default:
					goto IL_162;
				}
			}
			IL_162:
			num2 = (short)1883373568;
			short num4 = num2;
			num2 = (short)1209401344;
			if (num2 != 0)
			{
			}
			this.a(dateTime2, a_);
			return;
			IL_28:
			dateTime2 = global::System.DateTime.MinValue;
			dateTime = this.SelectionStart;
			num2 = (short)2047606788;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00035004 File Offset: 0x00033204
		private bool d()
		{
			short num = (short)994770944;
			short num2 = num;
			num = (short)472514561;
			if (num != 0)
			{
			}
			global::System.Windows.Size calendarDimensions = this.CalendarDimensions;
			if ((int)(calendarDimensions.Width * calendarDimensions.Height) == 1)
			{
				for (;;)
				{
					num = (short)1643728711;
					short num3 = num;
					num = (short)961040199;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9F;
					}
				}
				IL_9F:
				num = (short)941228032;
				if (num != 0)
				{
				}
				return this.TrailingDaysVisible;
			}
			return false;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000350D0 File Offset: 0x000332D0
		private void c()
		{
			short num = (short)2094661632;
			switch (num)
			{
			default:
			{
				num = (short)1808728076;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
					int num5;
					int num6;
					int num7;
					switch (num2)
					{
					case 0:
						num = (short)2104229892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1015676969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1525678124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_549;
					case 4:
						goto IL_501;
					case 5:
						singleMonthCalendar.NextMonthButtonVisibility = global::System.Windows.Visibility.Visible;
						singleMonthCalendar.PreviousMonthButtonVisibility = global::System.Windows.Visibility.Visible;
						num = (short)957022236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Windows.Size calendarDimensions;
						if (calendarDimensions.Width == 1.0)
						{
							num = (short)352387108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DC;
					}
					case 7:
						num = (short)1724121146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						this.a.ColumnDefinitions.Clear();
						int num3 = 0;
						num = (short)734724144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_327;
					case 10:
					{
						this.a.RowDefinitions.Clear();
						int num4 = 0;
						num = (short)1964310552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar2;
						if (this.a.Children.Contains(singleMonthCalendar2))
						{
							num = (short)683409460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_501;
					}
					case 12:
						switch (0)
						{
						case 0:
							goto IL_133;
						}
						continue;
					case 13:
						num = (short)1905328129;
						if (num != 0)
						{
						}
						goto IL_44E;
					case 14:
					{
						global::System.Windows.Size calendarDimensions;
						if ((double)num5 >= calendarDimensions.Height)
						{
							num = (short)1878261799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = 0;
						num = (short)720764962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::System.Windows.Size calendarDimensions;
						if (calendarDimensions.Width > 1.0)
						{
							num = (short)1240137761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						singleMonthCalendar.PreviousMonthButtonVisibility = global::System.Windows.Visibility.Collapsed;
						singleMonthCalendar.NextMonthButtonVisibility = global::System.Windows.Visibility.Collapsed;
						num = (short)2117337118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_501;
					case 17:
						singleMonthCalendar.PreviousMonthButtonVisibility = global::System.Windows.Visibility.Collapsed;
						singleMonthCalendar.NextMonthButtonVisibility = global::System.Windows.Visibility.Visible;
						num = (short)29491251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::System.Windows.Size calendarDimensions;
						if ((double)num6 >= calendarDimensions.Width)
						{
							num = (short)2109145144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						singleMonthCalendar = this.b[num7];
						global::System.Windows.Controls.Grid.SetRow(singleMonthCalendar, num5);
						global::System.Windows.Controls.Grid.SetColumn(singleMonthCalendar, num6);
						num = (short)823394310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						int num8;
						if (num8 > this.b.Count)
						{
							num = (short)1396637697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_549;
					}
					case 20:
					{
						int num8;
						if (num8 <= this.b.Count)
						{
							num = (short)529399811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar3 = this.b();
						bool trailingDaysVisible;
						singleMonthCalendar3.TrailingDaysVisible = trailingDaysVisible;
						this.b.Add(singleMonthCalendar3);
						this.a.Children.Add(singleMonthCalendar3);
						goto IL_3BC;
					}
					case 21:
						if (num5 == 0)
						{
							num = (short)1782710277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DC;
					case 22:
					{
						global::System.Windows.Size calendarDimensions;
						if ((double)this.a.RowDefinitions.Count != calendarDimensions.Height)
						{
							num = (short)1921646602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A7;
					}
					case 23:
					{
						global::System.Windows.Size calendarDimensions;
						if ((double)this.a.ColumnDefinitions.Count != calendarDimensions.Width)
						{
							num = (short)1254031368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44E;
					}
					case 24:
						goto IL_926;
					case 25:
						singleMonthCalendar.AnimationEnabled = this.AnimationEnabled;
						num = (short)1655636027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)1920991289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						global::System.Windows.Size calendarDimensions;
						int num3;
						if ((double)num3 >= calendarDimensions.Width)
						{
							num = (short)1866399757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Controls.ColumnDefinition value = new global::System.Windows.Controls.ColumnDefinition();
						this.a.ColumnDefinitions.Add(value);
						num3++;
						num = (short)1600847919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						int num8;
						if (num8 == 1)
						{
							num = (short)332202009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						singleMonthCalendar.AnimationEnabled = false;
						num = (short)288686133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						int num8;
						if (this.b.Count <= num8)
						{
							num = (short)1170800694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar2 = this.b[this.b.Count - 1];
						num = (short)662700043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_327;
					case 31:
						goto IL_A6E;
					case 32:
						goto IL_409;
					case 33:
						num = (short)2142634029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						num = (short)1275673628;
						short num9 = num;
						num = (short)481246236;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3BC;
						default:
						{
							num = (short)1515192320;
							short num10 = num;
							num = (short)1983971328;
							if (num != 0)
							{
							}
							goto IL_A6E;
						}
						}
						break;
					}
					case 35:
						goto IL_926;
					case 36:
						num = (short)665321493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_9A7;
					case 38:
						goto IL_409;
					case 39:
						return;
					case 40:
					{
						global::System.Windows.Size calendarDimensions;
						int num4;
						if ((double)num4 >= calendarDimensions.Height)
						{
							num = (short)921698341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Controls.RowDefinition value2 = new global::System.Windows.Controls.RowDefinition();
						this.a.RowDefinitions.Add(value2);
						num4++;
						num = (short)213581859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						goto IL_7BE;
					case 42:
						goto IL_7BE;
					case 43:
						if (num5 == 0)
						{
							num = (short)588382215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59E;
					case 44:
						if (num6 == 0)
						{
							num = (short)891093038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_969;
					case 45:
						if (num5 == 0)
						{
							num = (short)1331822594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_969;
					case 46:
						singleMonthCalendar.NextMonthButtonVisibility = global::System.Windows.Visibility.Collapsed;
						singleMonthCalendar.PreviousMonthButtonVisibility = global::System.Windows.Visibility.Visible;
						num = (short)1781202994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_62D;
					case 48:
						goto IL_62D;
					case 49:
						return;
					case 50:
						goto IL_327;
					case 51:
						goto IL_327;
					case 52:
					{
						global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar2;
						this.a.Children.Remove(singleMonthCalendar2);
						this.b.Remove(singleMonthCalendar2);
						num = (short)238419984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						goto IL_327;
					case 54:
						goto IL_202;
					case 55:
					{
						int num8;
						if (this.b.Count > num8)
						{
							num = (short)281018368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_202;
					}
					case 56:
						num5++;
						num = (short)1480458278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
					{
						if (this.a == null)
						{
							num = (short)1488584753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Size calendarDimensions = this.CalendarDimensions;
						int num8 = (int)(calendarDimensions.Width * calendarDimensions.Height);
						bool trailingDaysVisible = this.d();
						num = (short)1061224503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
					{
						global::System.Windows.Size calendarDimensions;
						if ((double)num6 == calendarDimensions.Width - 1.0)
						{
							num = (short)183173137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59E;
					}
					case 59:
						goto IL_327;
					}
					IL_133:
					if (base.IsInitialized)
					{
						num = (short)858849306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_202:
					num = (short)378863635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DC:
					num = (short)2035875855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_327:
					num7++;
					num6++;
					num = (short)1727660063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BC:
					num = (short)837222442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_409:
					num = (short)1424162830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44E:
					num = (short)791805974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_501:
					num = (short)266076189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_549:
					num = (short)984547351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59E:
					singleMonthCalendar.PreviousMonthButtonVisibility = global::System.Windows.Visibility.Collapsed;
					singleMonthCalendar.NextMonthButtonVisibility = global::System.Windows.Visibility.Collapsed;
					num = (short)354353161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62D:
					num = (short)1270218779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7BE:
					num = (short)563019796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_926:
					num = (short)1043791912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_969:
					num = (short)219217963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A7:
					num7 = 0;
					num5 = 0;
					num = (short)719781920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6E:
					num = (short)276103186;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00035BF8 File Offset: 0x00033DF8
		private global::DevComponents.WpfEditors.SingleMonthCalendar b()
		{
			short num = (short)1549926400;
			short num2 = num;
			num = (short)803930113;
			if (num != 0)
			{
			}
			num = (short)472899692;
			short num3 = num;
			num = (short)1911742572;
			switch (num3 == num)
			{
			}
			num = (short)1524957184;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfEditors.SingleMonthCalendar
			{
				OwnerMonthCalendar = this,
				AutoNavigate = false,
				AnimationEnabled = false,
				MinDate = this.MinDate,
				MaxDate = this.MaxDate,
				SelectedDate = this.SelectedDate,
				DayNameLabelStyle = this.DayNameLabelStyle,
				DayStyle = this.DayStyle,
				TrailingDayStyle = this.TrailingDayStyle,
				ShowWeekNumbers = this.ShowWeekNumbers,
				ShowTodayMarker = this.ShowTodayMarker,
				MonthNames = this.MonthNames,
				FirstDayOfWeek = this.FirstDayOfWeek,
				DayNames = this.DayNames,
				TodayDate = this.TodayDate,
				TrailingDaysVisible = this.TrailingDaysVisible,
				TwoLetterDayName = this.TwoLetterDayName,
				WeekendDaysSelectable = this.WeekendDaysSelectable,
				WeekLabelStyle = this.WeekLabelStyle,
				WeekOfYearRule = this.WeekOfYearRule,
				AutoSelect = !this.MultiSelect
			};
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00035D98 File Offset: 0x00033F98
		private static void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)940113920;
			short num2 = num;
			num = (short)808583169;
			if (num != 0)
			{
			}
			num = (short)1924615473;
			short num3 = num;
			num = (short)1111444785;
			switch (num3 == num)
			{
			}
			num = (short)699006976;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.MonthCalendar)A_0).b(A_1);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00035E4C File Offset: 0x0003404C
		private void b(global::System.Windows.RoutedEventArgs A_0)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			int num;
			short num2;
			global::System.DateTime? dateTime;
			global::System.Windows.Controls.Button button;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_3FE;
				case 1:
					goto IL_36D;
				case 2:
					goto IL_3E3;
				case 3:
					goto IL_131;
				case 4:
					if (this.AutoNavigate)
					{
						num2 = (short)1052377098;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					if (dateTime == null)
					{
						num2 = (short)1630404615;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1581056009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					A_0.Handled = true;
					dateTime = null;
					this.SelectedDate = dateTime;
					num2 = (short)2016608264;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)316801024;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (this.MultiSelect)
					{
						num2 = (short)727384076;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					goto IL_2EE;
				case 10:
					num2 = (short)1247870991;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (button.Name == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駚꣜ꯞ闠賢诤럦鯨軪鯬蛮黰蛲蛴뫶雸闺觼韾", a_))
					{
						num2 = (short)424148992;
						short num3 = num2;
						num2 = (short)1374158851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)559611918;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					dateTime = null;
					this.SelectionStart = dateTime;
					dateTime = null;
					this.SelectionEnd = dateTime;
					num2 = (short)723517442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)805896203;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (button.Name == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駚꣜ꯞ闠賢诤ꧦ賨鏪駬ꋮ黰鷲致鿶", a_))
					{
						num2 = (short)1292697601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)508690450;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (button != null)
					{
						num2 = (short)1204944909;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 16:
				{
					num2 = (short)573758530;
					short num4 = num2;
					num2 = (short)305126466;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2D1;
					default:
						num2 = (short)1132331008;
						if (num2 != 0)
						{
						}
						if (button.Name == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飚뇜뫞胠釢꟤鋦鷨鿪苬臮", a_))
						{
							num2 = (short)1090846726;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 17:
					goto IL_2D1;
				case 18:
					if (button.Name == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("迚닜믞胠髢꟤鋦鷨鿪苬臮", a_))
					{
						num2 = (short)66256913;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)416677904;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_65;
				IL_2D1:
				A_0.Handled = true;
				dateTime = this.TodayDate;
				num2 = (short)1215561733;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_131:
			A_0.Handled = true;
			this.PreviousMonth();
			return;
			IL_2EE:
			num2 = (short)502857729;
			if (num2 != 0)
			{
			}
			global::System.DateTime dateTime2 = dateTime.GetValueOrDefault();
			goto IL_405;
			IL_36D:
			A_0.Handled = true;
			this.NextMonth();
			return;
			IL_3E3:
			return;
			IL_3FE:
			dateTime2 = global::System.DateTime.Today;
			IL_405:
			global::System.DateTime value = dateTime2;
			this.SelectedDate = new global::System.DateTime?(value);
			this.DisplayMonth = new global::System.DateTime(value.Year, value.Month, 1);
			return;
			IL_65:
			button = (A_0.OriginalSource as global::System.Windows.Controls.Button);
			num2 = (short)2037645316;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00036288 File Offset: 0x00034488
		public void PreviousMonth()
		{
			short num = (short)265551872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::System.DateTime t;
				global::System.DateTime dateTime;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)267255809;
						if (num != 0)
						{
						}
						global::System.Windows.Size calendarDimensions;
						if (calendarDimensions.Width == 1.0)
						{
							num = (short)1223884804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9;
					}
					case 1:
						t = t.AddDays((double)(-(double)(t.Day - 1)));
						num = (short)1804140546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1BD;
					case 3:
						if (this.MinDate != global::System.DateTime.MinValue)
						{
							num = (short)1339293697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BD;
					case 4:
						num = (short)140115973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Windows.Size calendarDimensions;
						if (calendarDimensions.Height == 1.0)
						{
							num = (short)805961728;
							short num3 = num;
							num = (short)1128464392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9;
					}
					case 6:
						if (this.b.Count == 1)
						{
							num = (short)740098057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9;
					case 7:
						return;
					case 8:
						num = (short)1463156742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_298;
					case 10:
					{
						if (dateTime < t)
						{
							num = (short)211812359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Size calendarDimensions = this.CalendarDimensions;
						num = (short)2091712512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5A;
					IL_1BD:
					num = (short)1140719626;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_298:
				num = (short)79459818;
				short num4 = num;
				num = (short)1628403178;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)476971008;
					if (num != 0)
					{
					}
					this.b[0].PreviousMonth();
					this.DisplayMonth = this.b[0].DisplayMonth;
					return;
				}
				IL_2E9:
				this.DisplayMonth = dateTime;
				return;
				IL_5A:
				dateTime = this.DisplayMonth.AddDays((double)(-(double)(this.DisplayMonth.Day - 1)));
				dateTime = dateTime.AddMonths(-1);
				t = this.MinDate;
				num = (short)1608646659;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00036588 File Offset: 0x00034788
		public void NextMonth()
		{
			short num;
			global::System.DateTime dateTime;
			try
			{
				num = (short)1636040704;
				switch (num)
				{
				default:
					dateTime = this.DisplayMonth.AddDays((double)(global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().Calendar.GetDaysInMonth(this.DisplayMonth.Year, this.DisplayMonth.Month) - this.DisplayMonth.Day));
					dateTime = dateTime.AddMonths(1);
					goto IL_19E;
				}
			}
			catch (global::System.ArgumentException)
			{
				return;
			}
			goto IL_7E;
			int num2;
			global::System.DateTime dateTime2;
			for (;;)
			{
				IL_9D:
				switch (num2)
				{
				case 0:
					num = (short)1814233089;
					if (num != 0)
					{
					}
					dateTime2 = dateTime2.AddDays((double)(global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().Calendar.GetDaysInMonth(dateTime2.Year, dateTime2.Month) - dateTime2.Day));
					num = (short)1343094794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					if (dateTime2 != global::System.DateTime.MaxValue)
					{
						num = (short)188416000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D3;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_D4;
					}
					continue;
				case 4:
					goto IL_FB;
				case 5:
				{
					global::System.Windows.Size calendarDimensions;
					if (calendarDimensions.Width == 1.0)
					{
						goto IL_17F;
					}
					goto IL_2AE;
				}
				case 6:
				{
					if (dateTime > dateTime2)
					{
						num = (short)1504247809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Size calendarDimensions = this.CalendarDimensions;
					num = (short)2122121662;
					short num3 = num;
					num = (short)1588265406;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17F;
					default:
						num = (short)1087700992;
						if (num != 0)
						{
						}
						num = (short)614793221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_2A9;
				case 8:
					goto IL_2CE;
				case 9:
					num = (short)678428683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_2D3;
				case 11:
				{
					global::System.Windows.Size calendarDimensions;
					if (calendarDimensions.Height == 1.0)
					{
						num = (short)1359347719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE;
				}
				}
				IL_D4:
				if (this.b.Count == 1)
				{
					num = (short)117309444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2AE;
				IL_17F:
				num = (short)1278541833;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AE:
				this.DisplayMonth = dateTime;
				num = (short)896466952;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D3:
				num = (short)155123718;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FB:
			this.b[0].NextMonth();
			this.DisplayMonth = this.b[0].DisplayMonth;
			return;
			IL_2A9:
			goto IL_7E;
			IL_2CE:
			return;
			IL_7E:
			num = (short)882966531;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_9D;
			IL_19E:
			num = (short)868089856;
			short num4 = num;
			dateTime2 = this.MaxDate;
			num = (short)1716453378;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_9D;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00036904 File Offset: 0x00034B04
		private bool a()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_145;
				case 1:
				{
					global::System.Windows.Size calendarDimensions;
					if (calendarDimensions.Width == 1.0)
					{
						num2 = (short)1184694274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14A;
				}
				case 2:
					num2 = (short)257359873;
					if (num2 != 0)
					{
					}
					num2 = (short)976289795;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					global::System.Windows.Size calendarDimensions;
					if (calendarDimensions.Height == 1.0)
					{
						num2 = (short)538443776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14A;
				}
				}
				goto IL_20;
			}
			IL_145:
			num2 = (short)1690753698;
			short num3 = num2;
			num2 = (short)1680923298;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_20:
				global::System.Windows.Size calendarDimensions = this.CalendarDimensions;
				num2 = (short)1124007937;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			case 1:
				break;
			default:
			{
				num2 = (short)2063269888;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1895104512;
			if (num2 != 0)
			{
			}
			return false;
			IL_14A:
			return this.AnimationEnabled;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00036A64 File Offset: 0x00034C64
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1573191681;
			if (num != 0)
			{
			}
			num = (short)1726167317;
			short num2 = num;
			num = (short)1856059669;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1958346752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2077556736;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.MonthCalendar)A_0).a(A_1);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00036B18 File Offset: 0x00034D18
		private void a(global::System.Windows.RoutedEventArgs A_0)
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
					num2 = (short)1850399443;
					short num3 = num2;
					num2 = (short)1160633043;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
					{
						num2 = (short)1580924928;
						if (num2 != 0)
						{
						}
						num2 = (short)1703542784;
						short num4 = num2;
						this.SelectedDate = singleMonthCalendar.SelectedDate;
						num2 = (short)1008926721;
						if (num2 != 0)
						{
						}
						num2 = (short)404553730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_3D;
				case 2:
					return;
				}
				goto IL_1C;
				IL_3D:
				if (singleMonthCalendar == null)
				{
					break;
				}
				num2 = (short)1363869696;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			singleMonthCalendar = (A_0.OriginalSource as global::DevComponents.WpfEditors.SingleMonthCalendar);
			num2 = (short)1978859521;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00036C44 File Offset: 0x00034E44
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)59047937;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EE;
				case 1:
					num = (short)2123366401;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 2:
				{
					global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
					if (monthCalendarDayLabel != null)
					{
						num = (short)461045764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17D;
				}
				case 3:
				{
					num = (short)2044391877;
					short num3 = num;
					num = (short)1210446277;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)467206144;
						if (num != 0)
						{
						}
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel = this.a(e);
						num = (short)759562242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
				{
					global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
					monthCalendarDayLabel.IsChecked = new bool?(true);
					this.SelectionEnd = null;
					this.SelectionStart = new global::System.DateTime?(monthCalendarDayLabel.Date);
					num = (short)1147338752;
					short num4 = num;
					num = (short)1841496064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_60:
				if (!this.MultiSelect)
				{
					break;
				}
				num = (short)784596995;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EE:
			IL_17D:
			base.OnPreviewMouseLeftButtonDown(e);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00036DD8 File Offset: 0x00034FD8
		protected override void OnPreviewMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1765867520;
			switch (num)
			{
			default:
			{
				num = (short)1579352067;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.DateTime? selectionStart = this.SelectionStart;
						num = (short)1627389956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.DateTime? selectionStart = this.SelectionStart;
						this.SelectionEnd = new global::System.DateTime?(selectionStart.Value.AddDays((double)(-(double)(this.MaxSelectionCount - 1))));
						num = (short)1008205836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.DateTime? selectionStart = this.SelectionStart;
						this.SelectionEnd = new global::System.DateTime?(selectionStart.Value.AddDays((double)(this.MaxSelectionCount - 1)));
						num = (short)238485513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8A;
						}
						continue;
					case 4:
					{
						global::System.DateTime? selectionStart;
						if (selectionStart != null)
						{
							num = (short)2112552975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					}
					case 5:
					{
						global::System.TimeSpan timeSpan;
						if (timeSpan.TotalDays < 0.0)
						{
							num = (short)1633943553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
						global::System.DateTime date = monthCalendarDayLabel.Date;
						global::System.DateTime? selectionStart = this.SelectionStart;
						timeSpan = date.Subtract(selectionStart.Value);
						num = (short)1820721162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
						this.SelectionEnd = new global::System.DateTime?(monthCalendarDayLabel.Date);
						num = (short)450625536;
						short num3 = num;
						num = (short)615186439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_149;
					case 8:
						num = (short)1998782478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_2EB;
					case 10:
					{
						global::System.TimeSpan timeSpan;
						if (timeSpan.TotalDays > 0.0)
						{
							num = (short)525336578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					}
					case 11:
					{
						global::System.TimeSpan timeSpan;
						if (global::System.Math.Abs(timeSpan.TotalDays) < (double)this.MaxSelectionCount)
						{
							num = (short)1424359430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
						global::System.DateTime date = monthCalendarDayLabel.Date;
						global::System.DateTime? selectionStart = this.SelectionStart;
						timeSpan = date.Subtract(selectionStart.Value);
						num = (short)1833172997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_F2;
					case 13:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
						global::System.DateTime date = monthCalendarDayLabel.Date;
						global::System.DateTime? selectionStart = this.SelectionStart;
						global::System.TimeSpan timeSpan = date.Subtract(selectionStart.Value);
						goto IL_335;
					}
					case 14:
						if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
						{
							num = (short)1560739840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					case 15:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel = this.a(e);
						num = (short)739820957;
						short num4 = num;
						num = (short)972735901;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_335;
						default:
							num = (short)569638912;
							if (num != 0)
							{
							}
							num = (short)639762448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
					{
						global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
						if (monthCalendarDayLabel != null)
						{
							num = (short)1083244557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					}
					}
					IL_8A:
					if (this.MultiSelect)
					{
						num = (short)1136001032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_335:
					num = (short)661520395;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F2:
				IL_149:
				goto IL_411;
				IL_2EB:
				num = (short)192937985;
				if (num != 0)
				{
				}
				IL_411:
				base.OnPreviewMouseMove(e);
				return;
			}
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00037200 File Offset: 0x00035400
		private global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel a(global::System.Windows.Input.MouseEventArgs A_0)
		{
			short num = (short)1322319872;
			switch (num)
			{
			default:
			{
				for (;;)
				{
					global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel result;
					using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
					{
						num = (short)345767939;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)2103115786;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_124;
							case 2:
								goto IL_1FB;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_11F;
								}
								continue;
							case 4:
							{
								global::System.Windows.Rect rect;
								global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
								if (rect.Contains(A_0.GetPosition(monthCalendarDayLabel)))
								{
									num = (short)1683292167;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								int num3;
								num3++;
								num = (short)851181569;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								int num3;
								global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array;
								if (num3 >= array.Length)
								{
									num = (short)2047213573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel = array[num3];
								global::System.Windows.Rect rect = new global::System.Windows.Rect(monthCalendarDayLabel.RenderSize);
								num = (short)1387134980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
								result = monthCalendarDayLabel;
								num = (short)314769410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1166934016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array = enumerator.Current.DayLabels;
								int num3 = 0;
								num = (short)596639753;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_124;
							case 10:
								goto IL_26E;
							}
							goto IL_11F;
							IL_124:
							num = (short)2138374150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1A4:
							num = (short)399114248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_11F:
							goto IL_1A4;
						}
						IL_1FB:
						return result;
						IL_26E:
						goto IL_2F;
					}
					return result;
					IL_2F:
					num = (short)1433337857;
					if (num != 0)
					{
					}
					num = (short)626959168;
					short num4 = num;
					num = (short)385524544;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_8B;
					}
				}
				IL_8B:
				num = (short)844496896;
				short num5 = num;
				num = (short)1591083008;
				if (num != 0)
				{
				}
				return null;
			}
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000374AC File Offset: 0x000356AC
		private void a(global::System.DateTime A_0, global::System.DateTime A_1)
		{
			short num = (short)278815554;
			short num2 = num;
			num = (short)1220109122;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1690238976;
				if (num != 0)
				{
				}
				num = (short)395247616;
				short num3 = num;
				num = (short)107675649;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
				{
					num = (short)1983053825;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1709834242;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.b(A_0, A_1);
							num = (short)826081283;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_E3;
							}
							continue;
						case 2:
							num = (short)289406980;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_155;
						}
						IL_109:
						num = (short)766115840;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E3:
						goto IL_109;
					}
					IL_155:;
				}
				break;
			}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00037630 File Offset: 0x00035830
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(false)]
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::DevComponents.WpfEditors.SingleMonthCalendar> Calendars
		{
			get
			{
				short num = (short)1027342337;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.c = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::DevComponents.WpfEditors.SingleMonthCalendar>(this.b);
						num = (short)101842946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1381391555;
						short num3 = num;
						num = (short)868506819;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)830668801;
							if (num != 0)
							{
							}
							num = (short)121503744;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_9F;
							}
							continue;
						}
						break;
					}
					case 2:
						goto IL_111;
					}
					IL_9F:
					num = (short)1154875392;
					short num4 = num;
					if (this.c != null)
					{
						break;
					}
					num = (short)1392312320;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_111:
				return this.c;
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00037758 File Offset: 0x00035958
		public global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel GetDay(global::System.DateTime date)
		{
			short num = (short)1897660416;
			switch (num)
			{
			default:
			{
				for (;;)
				{
					global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel result;
					using (global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>.Enumerator enumerator = this.b.GetEnumerator())
					{
						num = (short)1176240134;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							int num3;
							switch (num2)
							{
							case 0:
							{
								global::System.DateTime date2;
								if (date2.Year == date.Year)
								{
									num = (short)1572667399;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_193;
							}
							case 1:
								goto IL_134;
							case 2:
							{
								global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
								result = monthCalendarDayLabel;
								num = (short)1221459977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)1371471883;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::System.DateTime date2;
								if (date2.Month == date.Month)
								{
									num = (short)211091470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_193;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_12F;
								}
								continue;
							case 7:
								num = (short)1107820548;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)661913603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array = enumerator.Current.DayLabels;
								num3 = 0;
								num = (short)938082305;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_2A7;
							case 10:
							{
								global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel[] array;
								if (num3 >= array.Length)
								{
									num = (short)81657861;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel = array[num3];
								global::System.DateTime date2 = monthCalendarDayLabel.Date;
								num = (short)2083979264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
								goto IL_30A;
							case 12:
							{
								global::System.DateTime date2;
								if (date2.Day == date.Day)
								{
									num = (short)1428750338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_193;
							}
							case 13:
								goto IL_134;
							case 14:
								num = (short)1517486092;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12F;
							IL_134:
							num = (short)18350090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_193:
							num3++;
							num = (short)1045626893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1B2:
							num = (short)51904520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_12F:
							goto IL_1B2;
						}
						IL_2A7:
						return result;
						IL_30A:
						goto IL_2E;
					}
					return result;
					IL_2E:
					num = (short)1938116008;
					short num4 = num;
					num = (short)930631080;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_65;
					}
				}
				IL_65:
				num = (short)2099249153;
				if (num != 0)
				{
				}
				num = (short)1259470848;
				short num5 = num;
				num = (short)885522432;
				if (num != 0)
				{
				}
				return null;
			}
			}
		}

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Controls.Grid a;

		// Token: 0x04000151 RID: 337
		private global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar> b = new global::System.Collections.Generic.List<global::DevComponents.WpfEditors.SingleMonthCalendar>();

		// Token: 0x04000152 RID: 338
		public static readonly global::System.Windows.DependencyProperty MonthlyMarkedDatesProperty;

		// Token: 0x04000153 RID: 339
		public static readonly global::System.Windows.DependencyProperty AnnuallyMarkedDatesProperty;

		// Token: 0x04000154 RID: 340
		public static readonly global::System.Windows.DependencyProperty MarkedDatesProperty;

		// Token: 0x04000155 RID: 341
		public static readonly global::System.Windows.DependencyProperty AnnuallyMarkedDatesStyleProperty;

		// Token: 0x04000156 RID: 342
		public static readonly global::System.Windows.DependencyProperty MonthlyMarkedDatesStyleProperty;

		// Token: 0x04000157 RID: 343
		public static readonly global::System.Windows.DependencyProperty MarkedDatesStyleProperty;

		// Token: 0x04000158 RID: 344
		public static readonly global::System.Windows.DependencyProperty CalendarDimensionsProperty;

		// Token: 0x04000159 RID: 345
		public static readonly global::System.Windows.DependencyProperty NavigationVisibilityProperty;

		// Token: 0x0400015A RID: 346
		public static readonly global::System.Windows.DependencyProperty DisplayMonthProperty;

		// Token: 0x0400015B RID: 347
		public static readonly global::System.Windows.DependencyProperty AnimationEnabledProperty;

		// Token: 0x0400015C RID: 348
		public static readonly global::System.Windows.DependencyProperty MinDateProperty;

		// Token: 0x0400015D RID: 349
		public static readonly global::System.Windows.DependencyProperty MaxDateProperty;

		// Token: 0x0400015E RID: 350
		public static readonly global::System.Windows.DependencyProperty SelectedDateProperty;

		// Token: 0x0400015F RID: 351
		public static readonly global::System.Windows.DependencyProperty AutoNavigateProperty;

		// Token: 0x04000160 RID: 352
		public static readonly global::System.Windows.DependencyProperty DayNameLabelStyleProperty;

		// Token: 0x04000161 RID: 353
		public static readonly global::System.Windows.DependencyProperty DayNamesProperty;

		// Token: 0x04000162 RID: 354
		public static readonly global::System.Windows.DependencyProperty DayStyleProperty;

		// Token: 0x04000163 RID: 355
		public static readonly global::System.Windows.DependencyProperty FirstDayOfWeekProperty;

		// Token: 0x04000164 RID: 356
		public static readonly global::System.Windows.DependencyProperty MonthNamesProperty;

		// Token: 0x04000165 RID: 357
		public static readonly global::System.Windows.DependencyProperty MultiSelectProperty;

		// Token: 0x04000166 RID: 358
		public static readonly global::System.Windows.DependencyProperty ShowTodayMarkerProperty;

		// Token: 0x04000167 RID: 359
		public static readonly global::System.Windows.DependencyProperty ShowWeekNumbersProperty;

		// Token: 0x04000168 RID: 360
		public static readonly global::System.Windows.DependencyProperty TodayDateProperty;

		// Token: 0x04000169 RID: 361
		public static readonly global::System.Windows.DependencyProperty TrailingDayStyleProperty;

		// Token: 0x0400016A RID: 362
		public static readonly global::System.Windows.DependencyProperty TrailingDaysVisibleProperty;

		// Token: 0x0400016B RID: 363
		public static readonly global::System.Windows.DependencyProperty TwoLetterDayNameProperty;

		// Token: 0x0400016C RID: 364
		public static readonly global::System.Windows.DependencyProperty WeekendDaysSelectableProperty;

		// Token: 0x0400016D RID: 365
		public static readonly global::System.Windows.DependencyProperty WeekLabelStyleProperty;

		// Token: 0x0400016E RID: 366
		public static readonly global::System.Windows.DependencyProperty WeekOfYearRuleProperty;

		// Token: 0x04000171 RID: 369
		public static readonly global::System.Windows.DependencyProperty MaxSelectionCountProperty;

		// Token: 0x04000172 RID: 370
		public static readonly global::System.Windows.DependencyProperty SelectionStartProperty;

		// Token: 0x04000173 RID: 371
		public static readonly global::System.Windows.DependencyProperty SelectionEndProperty;

		// Token: 0x04000174 RID: 372
		public static readonly global::System.Windows.DependencyProperty TodayButtonVisibilityProperty;

		// Token: 0x04000175 RID: 373
		public static readonly global::System.Windows.DependencyProperty ClearButtonVisibilityProperty;

		// Token: 0x04000176 RID: 374
		public static readonly global::System.Windows.DependencyProperty TodayButtonContentProperty;

		// Token: 0x04000177 RID: 375
		public static readonly global::System.Windows.DependencyProperty ClearButtonContentProperty;

		// Token: 0x04000178 RID: 376
		public static readonly global::System.Windows.DependencyProperty CornerRadiusProperty;

		// Token: 0x04000179 RID: 377
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::DevComponents.WpfEditors.SingleMonthCalendar> c;
	}
}
