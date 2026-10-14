using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x0200006E RID: 110
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class MonthCalendarDayLabel : global::System.Windows.Controls.Primitives.ToggleButton
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00097498 File Offset: 0x00095698
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x00097550 File Offset: 0x00095750
		public global::System.DateTime Date
		{
			get
			{
				short num = (short)1674992684;
				short num2 = num;
				num = (short)1945918508;
				switch (num2 == num)
				{
				}
				num = (short)1954283520;
				if (num != 0)
				{
				}
				num = (short)1279524865;
				if (num != 0)
				{
				}
				num = (short)1483276288;
				short num3 = num;
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.DateProperty);
			}
			internal set
			{
				short num = (short)91963184;
				short num2 = num;
				num = (short)1151942448;
				switch (num2 == num)
				{
				}
				num = (short)1235812353;
				if (num != 0)
				{
				}
				num = (short)144179200;
				if (num != 0)
				{
				}
				num = (short)1472135168;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.a, value);
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00097608 File Offset: 0x00095808
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (monthCalendarDayLabel != null)
						{
							num2 = (short)1519517698;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						num2 = (short)1004011520;
						short num3 = num2;
						num2 = (short)1788936193;
						if (num2 != 0)
						{
						}
						num2 = (short)392605658;
						short num4 = num2;
						num2 = (short)1483452378;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)2001797120;
							if (num2 != 0)
							{
							}
							monthCalendarDayLabel.OnDateChanged((global::System.DateTime)A_1.OldValue, (global::System.DateTime)A_1.NewValue);
							num2 = (short)540606464;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				monthCalendarDayLabel = (A_0 as global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel);
				num2 = (short)1388445697;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0009773C File Offset: 0x0009593C
		protected virtual void OnDateChanged(global::System.DateTime oldValue, global::System.DateTime newValue)
		{
			short num = (short)1741225985;
			if (num != 0)
			{
			}
			num = (short)1466943397;
			short num2 = num;
			num = (short)1157941157;
			switch (num2 == num)
			{
			}
			num = (short)904069120;
			if (num != 0)
			{
			}
			num = (short)726794240;
			short num3 = num;
			base.Content = newValue.Day.ToString();
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x000977F8 File Offset: 0x000959F8
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x000978B0 File Offset: 0x00095AB0
		public bool IsToday
		{
			get
			{
				short num = (short)1499272440;
				short num2 = num;
				num = (short)129570040;
				switch (num2 == num)
				{
				}
				num = (short)1390739457;
				if (num != 0)
				{
				}
				num = (short)277217280;
				if (num != 0)
				{
				}
				num = (short)138018816;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.IsTodayProperty);
			}
			set
			{
				short num = (short)1634982049;
				short num2 = num;
				num = (short)58972321;
				switch (num2 == num)
				{
				}
				num = (short)1071513600;
				if (num != 0)
				{
				}
				num = (short)1444806657;
				if (num != 0)
				{
				}
				num = (short)1031995392;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.IsTodayProperty, value);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0009796C File Offset: 0x00095B6C
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00097A24 File Offset: 0x00095C24
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IsTrailing
		{
			get
			{
				short num = (short)1715669437;
				short num2 = num;
				num = (short)199952829;
				switch (num2 == num)
				{
				}
				num = (short)1224015872;
				if (num != 0)
				{
				}
				num = (short)254541825;
				if (num != 0)
				{
				}
				num = (short)2076639232;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.IsTrailingProperty);
			}
			internal set
			{
				short num = (short)357823011;
				short num2 = num;
				num = (short)443675171;
				switch (num2 == num)
				{
				}
				num = (short)176488449;
				if (num != 0)
				{
				}
				num = (short)1798832128;
				if (num != 0)
				{
				}
				num = (short)60555264;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.b, value);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00097AE0 File Offset: 0x00095CE0
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel monthCalendarDayLabel;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (monthCalendarDayLabel != null)
						{
							num2 = (short)52756481;
							if (num2 != 0)
							{
							}
							num2 = (short)1568866304;
							short num3 = num2;
							num2 = (short)1468923906;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						num2 = (short)135543000;
						short num4 = num2;
						num2 = (short)980891864;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)632487936;
							if (num2 != 0)
							{
							}
							monthCalendarDayLabel.OnSelectableChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
							num2 = (short)1521483776;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				monthCalendarDayLabel = (A_0 as global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel);
				num2 = (short)551944193;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00097C18 File Offset: 0x00095E18
		protected virtual void OnSelectableChanged(bool oldValue, bool newValue)
		{
			short num = (short)717150888;
			short num2 = num;
			num = (short)851106472;
			switch (num2 == num)
			{
			}
			num = (short)815529984;
			if (num != 0)
			{
			}
			num = (short)632029185;
			if (num != 0)
			{
			}
			num = (short)229244928;
			short num3 = num;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00097CC0 File Offset: 0x00095EC0
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00097D7C File Offset: 0x00095F7C
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Description("Indicates whether label is selectable.")]
		public bool Selectable
		{
			get
			{
				short num = (short)1069162999;
				short num2 = num;
				num = (short)1157243383;
				switch (num2 == num)
				{
				}
				num = (short)1384579073;
				if (num != 0)
				{
				}
				num = (short)1493368832;
				if (num != 0)
				{
				}
				num = (short)792199168;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.SelectableProperty);
			}
			set
			{
				short num = (short)269080506;
				short num2 = num;
				num = (short)215603130;
				switch (num2 == num)
				{
				}
				num = (short)702414849;
				if (num != 0)
				{
				}
				num = (short)1837629440;
				if (num != 0)
				{
				}
				num = (short)703397888;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.SelectableProperty, value);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00097E38 File Offset: 0x00096038
		static MonthCalendarDayLabel()
		{
			int a_ = 7;
			short num = (short)343553976;
			short num2 = num;
			num = (short)2018195384;
			switch (num2 == num)
			{
			}
			num = (short)2071789568;
			if (num != 0)
			{
			}
			num = (short)332333057;
			if (num != 0)
			{
			}
			num = (short)1870462976;
			short num3 = num;
			global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.a = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郓럕곗뿙", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.MinValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.b)));
			global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.DateProperty = global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.a.DependencyProperty;
			global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.IsTodayProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷓ꗕ賗뗙룛뿝駟", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.b = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷓ꗕ賗꣙뷛럝賟诡諣臥", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.IsTrailingProperty = global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.b.DependencyProperty;
			global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.SelectableProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蟓돕듗뿙뿛ꫝ臟胡裣菥", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel.a)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.Primitives.MonthCalendarDayLabel)));
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00098028 File Offset: 0x00096228
		internal static bool a(global::System.DateTime A_0)
		{
			if (A_0.DayOfWeek == global::System.DayOfWeek.Saturday)
			{
				short num = (short)855310336;
				short num2 = num;
				num = (short)207040662;
				short num3 = num;
				num = (short)1144533142;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1327890433;
					if (num != 0)
					{
					}
					num = (short)787611648;
					if (num != 0)
					{
					}
					return true;
				}
			}
			return A_0.DayOfWeek == global::System.DayOfWeek.Sunday;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000980E8 File Offset: 0x000962E8
		protected override void OnToggle()
		{
			for (;;)
			{
				IL_00:
				short num = (short)45350913;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						num = (short)1973312082;
						short num3 = num;
						num = (short)1233476178;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)2082734080;
							short num4 = num;
							num = (short)1192820737;
							if (num != 0)
							{
							}
							num = (short)1000931328;
							if (num != 0)
							{
							}
							base.OnToggle();
							num = (short)498139136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_30:
					if (!this.a())
					{
						return;
					}
					num = (short)1594294274;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00098200 File Offset: 0x00096400
		private bool a()
		{
			short num2;
			global::DevComponents.WpfEditors.SingleMonthCalendar singleMonthCalendar;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_114;
					case 1:
						num2 = (short)423493635;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (singleMonthCalendar != null)
						{
							num2 = (short)1018691584;
							short num3 = num2;
							num2 = (short)1072824321;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13C;
					case 3:
						if (this.Selectable)
						{
							num2 = (short)1465253888;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8A;
					}
					goto IL_20;
				}
				IL_8A:
				num2 = (short)1614421734;
				short num4 = num2;
				num2 = (short)32579302;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_BF;
				}
				IL_20:
				singleMonthCalendar = (base.TemplatedParent as global::DevComponents.WpfEditors.SingleMonthCalendar);
				num2 = (short)643432450;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_BF:
			num2 = (short)198246400;
			if (num2 != 0)
			{
			}
			return false;
			IL_114:
			num2 = (short)1107492865;
			if (num2 != 0)
			{
			}
			return singleMonthCalendar.AutoSelect;
			IL_13C:
			return this.Selectable;
		}

		// Token: 0x040002F8 RID: 760
		private static readonly global::System.Windows.DependencyPropertyKey a;

		// Token: 0x040002F9 RID: 761
		public static readonly global::System.Windows.DependencyProperty DateProperty;

		// Token: 0x040002FA RID: 762
		public static readonly global::System.Windows.DependencyProperty IsTodayProperty;

		// Token: 0x040002FB RID: 763
		private static readonly global::System.Windows.DependencyPropertyKey b;

		// Token: 0x040002FC RID: 764
		public static readonly global::System.Windows.DependencyProperty IsTrailingProperty;

		// Token: 0x040002FD RID: 765
		public static readonly global::System.Windows.DependencyProperty SelectableProperty;
	}
}
