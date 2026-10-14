using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000015 RID: 21
	[global::System.ComponentModel.DesignTimeVisible(true)]
	[global::System.ComponentModel.DefaultEvent("ValueChanged")]
	public class DateTimeInput : global::DevComponents.WpfEditors.InputBaseControl
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00015FFC File Offset: 0x000141FC
		// (set) Token: 0x0600011D RID: 285 RVA: 0x000160B8 File Offset: 0x000142B8
		public bool AutoAdvance
		{
			get
			{
				short num = (short)2042494977;
				if (num != 0)
				{
				}
				num = (short)465232160;
				short num2 = num;
				num = (short)858710304;
				switch (num2 == num)
				{
				}
				num = (short)1184956416;
				if (num != 0)
				{
				}
				num = (short)1853751296;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.AutoAdvanceProperty);
			}
			set
			{
				short num = (short)310620148;
				short num2 = num;
				num = (short)2105061364;
				switch (num2 == num)
				{
				}
				num = (short)1862467585;
				if (num != 0)
				{
				}
				num = (short)1168965632;
				if (num != 0)
				{
				}
				num = (short)913113088;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.AutoAdvanceProperty, value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00016170 File Offset: 0x00014370
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0001622C File Offset: 0x0001442C
		public bool DefaultInputValues
		{
			get
			{
				short num = (short)1673634544;
				short num2 = num;
				num = (short)1899340528;
				switch (num2 == num)
				{
				}
				num = (short)17367041;
				if (num != 0)
				{
				}
				num = (short)1866989568;
				if (num != 0)
				{
				}
				num = (short)416481280;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.DefaultInputValuesProperty);
			}
			set
			{
				short num = (short)1842210823;
				short num2 = num;
				num = (short)1583147015;
				switch (num2 == num)
				{
				}
				num = (short)672989184;
				if (num != 0)
				{
				}
				num = (short)1262551041;
				if (num != 0)
				{
				}
				num = (short)626130944;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.DefaultInputValuesProperty, value);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000162E4 File Offset: 0x000144E4
		private static void f(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)399298791;
			short num2 = num;
			num = (short)540332263;
			global::DevComponents.WpfEditors.DateTimeInput dateTimeInput;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C4:
				num = (short)762052608;
				short num3 = num;
				dateTimeInput.OnShowDropDownChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
				num = (short)986316801;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1965096961;
				if (num != 0)
				{
				}
				num = (short)1957429248;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_91;
				}
				break;
			}
			for (;;)
			{
				IL_7F:
				switch (num4)
				{
				case 0:
					goto IL_C4;
				case 1:
					return;
				case 2:
					if (dateTimeInput != null)
					{
						num = (short)1278935040;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_91;
			}
			return;
			IL_91:
			dateTimeInput = (A_0 as global::DevComponents.WpfEditors.DateTimeInput);
			num = (short)1470300162;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001641C File Offset: 0x0001461C
		protected virtual void OnShowDropDownChanged(bool oldValue, bool newValue)
		{
			short num = (short)289048172;
			short num2 = num;
			num = (short)58295916;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1560936448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)238485505;
			if (num != 0)
			{
			}
			num = (short)1479475200;
			if (num != 0)
			{
			}
			this.d();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000164CC File Offset: 0x000146CC
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00016588 File Offset: 0x00014788
		public bool ShowDropDown
		{
			get
			{
				short num = (short)1961426945;
				if (num != 0)
				{
				}
				num = (short)109838336;
				short num2 = num;
				num = (short)2022136711;
				short num3 = num;
				num = (short)809982855;
				switch (num3 == num)
				{
				}
				num = (short)807796736;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowDropDownProperty);
			}
			set
			{
				short num = (short)2094700121;
				short num2 = num;
				num = (short)1538627161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1366425600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)867827713;
				if (num != 0)
				{
				}
				num = (short)1714880512;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowDropDownProperty, value);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00016644 File Offset: 0x00014844
		private static void e(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.DateTimeInput dateTimeInput;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)348634784;
					short num3 = num2;
					num2 = (short)234012320;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)493289472;
						if (num2 != 0)
						{
						}
						num2 = (short)1301151744;
						short num4 = num2;
						num2 = (short)1440612353;
						if (num2 != 0)
						{
						}
						dateTimeInput.OnShowUpDownChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						break;
					}
					}
					num2 = (short)808976384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (dateTimeInput != null)
					{
						num2 = (short)80347137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			dateTimeInput = (A_0 as global::DevComponents.WpfEditors.DateTimeInput);
			num2 = (short)107151362;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0001677C File Offset: 0x0001497C
		protected virtual void OnShowUpDownChanged(bool oldValue, bool newValue)
		{
			short num = (short)1511437916;
			short num2 = num;
			num = (short)1055110748;
			switch (num2 == num)
			{
			default:
			{
				num = (short)530120704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1268187136;
			if (num != 0)
			{
			}
			num = (short)40435713;
			if (num != 0)
			{
			}
			this.f();
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0001682C File Offset: 0x00014A2C
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000168E4 File Offset: 0x00014AE4
		public bool ShowUpDown
		{
			get
			{
				short num = (short)638356938;
				short num2 = num;
				num = (short)905153994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)453312512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)399376385;
				if (num != 0)
				{
				}
				num = (short)974323712;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowUpDownProperty);
			}
			set
			{
				short num = (short)1219968428;
				short num2 = num;
				num = (short)988102060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1465712640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)502661121;
				if (num != 0)
				{
				}
				num = (short)1691615232;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowUpDownProperty, value);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000128 RID: 296 RVA: 0x000169A0 File Offset: 0x00014BA0
		// (remove) Token: 0x06000129 RID: 297 RVA: 0x00016A54 File Offset: 0x00014C54
		public event global::System.Windows.RoutedEventHandler ValueChanged
		{
			add
			{
				short num = (short)1395314382;
				short num2 = num;
				num = (short)1633406670;
				switch (num2 == num)
				{
				default:
				{
					num = (short)367067136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1316683777;
				if (num != 0)
				{
				}
				num = (short)961871872;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.DateTimeInput.ValueChangedEvent, value);
			}
			remove
			{
				short num = (short)222573059;
				short num2 = num;
				num = (short)1793667587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)379322368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)887160833;
				if (num != 0)
				{
				}
				num = (short)90701824;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.DateTimeInput.ValueChangedEvent, value);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00016B08 File Offset: 0x00014D08
		protected virtual void OnValueChanged(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)1558222126;
			short num2 = num;
			num = (short)2092537134;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1160773632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)451608577;
			if (num != 0)
			{
			}
			num = (short)927793152;
			if (num != 0)
			{
			}
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00016BB8 File Offset: 0x00014DB8
		private new static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.DateTimeInput dateTimeInput;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)1808205825;
					short num3 = num2;
					num2 = (short)1245382657;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1898643457;
						if (num2 != 0)
						{
						}
						num2 = (short)2038956032;
						short num4 = num2;
						num2 = (short)461504512;
						if (num2 != 0)
						{
						}
						dateTimeInput.OnShowClearButtonChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						break;
					}
					}
					num2 = (short)229965824;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (dateTimeInput != null)
					{
						num2 = (short)1333460993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			dateTimeInput = (A_0 as global::DevComponents.WpfEditors.DateTimeInput);
			num2 = (short)227737602;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00016CF0 File Offset: 0x00014EF0
		protected virtual void OnShowClearButtonChanged(bool oldValue, bool newValue)
		{
			short num = (short)1573892713;
			short num2 = num;
			num = (short)527413865;
			switch (num2 == num)
			{
			default:
			{
				num = (short)953745408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1945042945;
			if (num != 0)
			{
			}
			num = (short)1148649472;
			if (num != 0)
			{
			}
			this.e();
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00016DA0 File Offset: 0x00014FA0
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00016E58 File Offset: 0x00015058
		public bool ShowClearButton
		{
			get
			{
				short num = (short)1798324093;
				short num2 = num;
				num = (short)961822589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)429588480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545207809;
				if (num != 0)
				{
				}
				num = (short)296222720;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowClearButtonProperty);
			}
			set
			{
				short num = (short)714907546;
				short num2 = num;
				num = (short)338534298;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013069312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1844183041;
				if (num != 0)
				{
				}
				num = (short)2101477376;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowClearButtonProperty, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00016F14 File Offset: 0x00015114
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00016FCC File Offset: 0x000151CC
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AllowEmptyState
		{
			get
			{
				short num = (short)2101525062;
				short num2 = num;
				num = (short)1183300166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1559691264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1431699457;
				if (num != 0)
				{
				}
				num = (short)371654656;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.AllowEmptyStateProperty);
			}
			set
			{
				short num = (short)876000508;
				short num2 = num;
				num = (short)665367804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1762263040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)788267008;
				if (num != 0)
				{
				}
				num = (short)274792449;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.AllowEmptyStateProperty, value);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00017084 File Offset: 0x00015284
		private static object a(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.DateTimeInput dateTimeInput = A_0 as global::DevComponents.WpfEditors.DateTimeInput;
			if (dateTimeInput == null)
			{
				short num = (short)1043028781;
				short num2 = num;
				num = (short)2021874477;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)924844032;
					short num3 = num;
					num = (short)1318977537;
					if (num != 0)
					{
					}
					num = (short)350486528;
					if (num != 0)
					{
					}
					return A_1;
				}
				}
			}
			return dateTimeInput.OnCoerceValue((global::System.DateTime?)A_1);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00017150 File Offset: 0x00015350
		private new static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.DateTimeInput dateTimeInput;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)663263336;
					short num3 = num2;
					num2 = (short)2009372776;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)839254016;
						if (num2 != 0)
						{
						}
						num2 = (short)77266944;
						short num4 = num2;
						num2 = (short)124911617;
						if (num2 != 0)
						{
						}
						dateTimeInput.OnValueChanged((global::System.DateTime?)A_1.OldValue, (global::System.DateTime?)A_1.NewValue);
						break;
					}
					}
					num2 = (short)2118123520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (dateTimeInput != null)
					{
						num2 = (short)1135017985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			dateTimeInput = (A_0 as global::DevComponents.WpfEditors.DateTimeInput);
			num2 = (short)1034944514;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00017284 File Offset: 0x00015484
		protected virtual global::System.DateTime? OnCoerceValue(global::System.DateTime? value)
		{
			short num = (short)1220599593;
			short num2 = num;
			num = (short)1759174441;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1924661248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1913126913;
			if (num != 0)
			{
			}
			num = (short)552206336;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001732C File Offset: 0x0001552C
		protected virtual void OnValueChanged(global::System.DateTime? oldValue, global::System.DateTime? newValue)
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
					return;
				case 1:
				{
					num2 = (short)622767905;
					short num3 = num2;
					num2 = (short)223850273;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1229651968;
						short num4 = num2;
						num2 = (short)1977090048;
						if (num2 != 0)
						{
						}
						this.d.SelectedDate = newValue;
						break;
					}
					}
					num2 = (short)721682432;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)1006043137;
					if (num2 != 0)
					{
					}
					if (this.d != null)
					{
						num2 = (short)42467329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.OnValueChanged(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.DateTimeInput.ValueChangedEvent));
			num2 = (short)404815874;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0001745C File Offset: 0x0001565C
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00017514 File Offset: 0x00015714
		public global::System.DateTime? Value
		{
			get
			{
				short num = (short)629113903;
				short num2 = num;
				num = (short)1228047407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1634271232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)558694401;
				if (num != 0)
				{
				}
				num = (short)830668800;
				if (num != 0)
				{
				}
				return (global::System.DateTime?)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.ValueProperty);
			}
			set
			{
				short num = (short)414218064;
				short num2 = num;
				num = (short)728463184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1851392000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1768816641;
				if (num != 0)
				{
				}
				num = (short)263520256;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.ValueProperty, value);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000175D0 File Offset: 0x000157D0
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.DateTimeInput dateTimeInput;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FD;
				case 1:
				{
					num2 = (short)311506862;
					short num3 = num2;
					num2 = (short)1933260718;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)355401728;
						if (num2 != 0)
						{
						}
						num2 = (short)2004156416;
						short num4 = num2;
						dateTimeInput.OnCustomFormatChanged((string)A_1.OldValue, (string)A_1.NewValue);
						break;
					}
					}
					num2 = (short)1669136384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (dateTimeInput != null)
					{
						num2 = (short)668860417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_FD:
			num2 = (short)371982337;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			dateTimeInput = (A_0 as global::DevComponents.WpfEditors.DateTimeInput);
			num2 = (short)495386626;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00017704 File Offset: 0x00015904
		protected virtual void OnCustomFormatChanged(string oldValue, string newValue)
		{
			short num = (short)2001540797;
			short num2 = num;
			num = (short)1520703165;
			switch (num2 == num)
			{
			default:
			{
				num = (short)688783360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1522335745;
			if (num != 0)
			{
			}
			num = (short)709623808;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000177B8 File Offset: 0x000159B8
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00017870 File Offset: 0x00015A70
		[global::System.ComponentModel.Localizable(true)]
		[global::System.ComponentModel.Description("Indicates the custom date/time format string. ")]
		[global::System.ComponentModel.DefaultValue("")]
		public string CustomFormat
		{
			get
			{
				short num = (short)185335809;
				if (num != 0)
				{
				}
				num = (short)1792409600;
				short num2 = num;
				num = (short)394171300;
				short num3 = num;
				num = (short)413307812;
				switch (num3 == num)
				{
				}
				num = (short)625672192;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.CustomFormatProperty);
			}
			set
			{
				short num = (short)1588414376;
				short num2 = num;
				num = (short)1311852456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)286654464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)656343041;
				if (num != 0)
				{
				}
				num = (short)1545338880;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.CustomFormatProperty, value);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00017928 File Offset: 0x00015B28
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.DateTimeInput dateTimeInput;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)537067521;
					if (num2 != 0)
					{
					}
					num2 = (short)563762523;
					short num3 = num2;
					num2 = (short)1565611355;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1004339200;
						short num4 = num2;
						num2 = (short)351272960;
						if (num2 != 0)
						{
						}
						dateTimeInput.OnFormatChanged((global::DevComponents.WpfEditors.eDateTimePickerFormat)A_1.OldValue, (global::DevComponents.WpfEditors.eDateTimePickerFormat)A_1.NewValue);
						break;
					}
					}
					num2 = (short)1623588864;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (dateTimeInput != null)
					{
						num2 = (short)1789722625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			dateTimeInput = (A_0 as global::DevComponents.WpfEditors.DateTimeInput);
			num2 = (short)203554818;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00017A60 File Offset: 0x00015C60
		protected virtual void OnFormatChanged(global::DevComponents.WpfEditors.eDateTimePickerFormat oldValue, global::DevComponents.WpfEditors.eDateTimePickerFormat newValue)
		{
			short num = (short)1388118017;
			if (num != 0)
			{
			}
			num = (short)1044512768;
			short num2 = num;
			num = (short)97813957;
			short num3 = num;
			num = (short)1669629381;
			switch (num3 == num)
			{
			}
			num = (short)1361838080;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00017B10 File Offset: 0x00015D10
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00017BCC File Offset: 0x00015DCC
		[global::System.ComponentModel.DefaultValue(global::DevComponents.WpfEditors.eDateTimePickerFormat.Short)]
		public global::DevComponents.WpfEditors.eDateTimePickerFormat Format
		{
			get
			{
				short num = (short)1757689001;
				short num2 = num;
				num = (short)1962685609;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086717952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1574502400;
				if (num != 0)
				{
				}
				num = (short)299761665;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.eDateTimePickerFormat)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.FormatProperty);
			}
			set
			{
				short num = (short)2057316015;
				short num2 = num;
				num = (short)56633007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1539244032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)873922561;
				if (num != 0)
				{
				}
				num = (short)716111872;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.FormatProperty, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00017C88 File Offset: 0x00015E88
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00017D40 File Offset: 0x00015F40
		public global::System.DateTime MinDate
		{
			get
			{
				short num = (short)31064065;
				if (num != 0)
				{
				}
				num = (short)841351168;
				short num2 = num;
				num = (short)1858519046;
				short num3 = num;
				num = (short)2062073862;
				switch (num3 == num)
				{
				}
				num = (short)1685979136;
				if (num != 0)
				{
				}
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.MinDateProperty);
			}
			set
			{
				short num = (short)1842373051;
				short num2 = num;
				num = (short)975593915;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1480785920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)584908801;
				if (num != 0)
				{
				}
				num = (short)357498880;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.MinDateProperty, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00017DFC File Offset: 0x00015FFC
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00017EB8 File Offset: 0x000160B8
		public global::System.DateTime MaxDate
		{
			get
			{
				short num = (short)778346161;
				short num2 = num;
				num = (short)465673905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1927217152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010761729;
				if (num != 0)
				{
				}
				num = (short)1098973184;
				if (num != 0)
				{
				}
				return (global::System.DateTime)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.MaxDateProperty);
			}
			set
			{
				short num = (short)726335489;
				if (num != 0)
				{
				}
				num = (short)55574528;
				short num2 = num;
				num = (short)1556154404;
				short num3 = num;
				num = (short)1713440804;
				switch (num3 == num)
				{
				}
				num = (short)261160960;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.MaxDateProperty, value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00017F70 File Offset: 0x00016170
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00018028 File Offset: 0x00016228
		public new bool IsReadOnly
		{
			get
			{
				short num = (short)1257547293;
				short num2 = num;
				num = (short)1279960605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)213450752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)124977153;
				if (num != 0)
				{
				}
				num = (short)250609664;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.IsReadOnlyProperty);
			}
			set
			{
				short num = (short)1143016854;
				short num2 = num;
				num = (short)620432790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1988165632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1257766912;
				if (num != 0)
				{
				}
				num = (short)1295384577;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000180E4 File Offset: 0x000162E4
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0001819C File Offset: 0x0001639C
		public string SelectNextInputCharacters
		{
			get
			{
				short num = (short)1821113907;
				short num2 = num;
				num = (short)797965875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1107165184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)218300416;
				if (num != 0)
				{
				}
				num = (short)542375937;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.SelectNextInputCharactersProperty);
			}
			set
			{
				short num = (short)1576874796;
				short num2 = num;
				num = (short)1879520044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1167458304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)498204673;
				if (num != 0)
				{
				}
				num = (short)574619648;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.SelectNextInputCharactersProperty, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00018254 File Offset: 0x00016454
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00018310 File Offset: 0x00016510
		[global::System.ComponentModel.Description("Indicates number of columns and rows of months displayed on popup calendar control.")]
		public global::System.Windows.Size CalendarDimensions
		{
			get
			{
				short num = (short)1292901723;
				short num2 = num;
				num = (short)195108187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)652869632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1933508609;
				if (num != 0)
				{
				}
				num = (short)722010112;
				if (num != 0)
				{
				}
				return (global::System.Windows.Size)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.CalendarDimensionsProperty);
			}
			set
			{
				short num = (short)1660478286;
				short num2 = num;
				num = (short)382853966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)616693760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1318125569;
				if (num != 0)
				{
				}
				num = (short)1849163776;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.CalendarDimensionsProperty, value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000183C8 File Offset: 0x000165C8
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00018480 File Offset: 0x00016680
		public global::System.Windows.Visibility TodayButtonVisibility
		{
			get
			{
				short num = (short)54263808;
				short num2 = num;
				num = (short)1137462903;
				short num3 = num;
				num = (short)964906615;
				switch (num3 == num)
				{
				}
				num = (short)1369243649;
				if (num != 0)
				{
				}
				num = (short)1715798016;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.TodayButtonVisibilityProperty);
			}
			set
			{
				short num = (short)293732352;
				short num2 = num;
				num = (short)1336063816;
				short num3 = num;
				num = (short)2026092360;
				switch (num3 == num)
				{
				}
				num = (short)445054976;
				if (num != 0)
				{
				}
				num = (short)1306460161;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.TodayButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00018538 File Offset: 0x00016738
		// (set) Token: 0x0600014C RID: 332 RVA: 0x000185F4 File Offset: 0x000167F4
		public global::System.Windows.Visibility ClearButtonVisibility
		{
			get
			{
				short num = (short)1933836288;
				short num2 = num;
				num = (short)1693016634;
				short num3 = num;
				num = (short)923755066;
				switch (num3 == num)
				{
				}
				num = (short)710344705;
				if (num != 0)
				{
				}
				num = (short)1931608064;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.ClearButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1417412608;
				short num2 = num;
				num = (short)293060678;
				short num3 = num;
				num = (short)24035398;
				switch (num3 == num)
				{
				}
				num = (short)837419008;
				if (num != 0)
				{
				}
				num = (short)997588993;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.ClearButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000186B0 File Offset: 0x000168B0
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00018764 File Offset: 0x00016964
		[global::System.ComponentModel.Localizable(true)]
		public object TodayButtonContent
		{
			get
			{
				short num = (short)1781334016;
				short num2 = num;
				num = (short)934925747;
				short num3 = num;
				num = (short)1155978675;
				switch (num3 == num)
				{
				}
				num = (short)1238237185;
				if (num != 0)
				{
				}
				num = (short)427622400;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.TodayButtonContentProperty);
			}
			set
			{
				short num = (short)1221853184;
				short num2 = num;
				num = (short)149380375;
				short num3 = num;
				num = (short)1416846615;
				switch (num3 == num)
				{
				}
				num = (short)1116602369;
				if (num != 0)
				{
				}
				num = (short)1284374528;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.TodayButtonContentProperty, value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0001881C File Offset: 0x00016A1C
		// (set) Token: 0x06000150 RID: 336 RVA: 0x000188D0 File Offset: 0x00016AD0
		[global::System.ComponentModel.Localizable(true)]
		public object ClearButtonContent
		{
			get
			{
				short num = (short)765460480;
				short num2 = num;
				num = (short)1347063075;
				short num3 = num;
				num = (short)248679715;
				switch (num3 == num)
				{
				}
				num = (short)1636827137;
				if (num != 0)
				{
				}
				num = (short)1799684096;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.ClearButtonContentProperty);
			}
			set
			{
				short num = (short)1746075648;
				short num2 = num;
				num = (short)2069582063;
				short num3 = num;
				num = (short)736252143;
				switch (num3 == num)
				{
				}
				num = (short)475332608;
				if (num != 0)
				{
				}
				num = (short)450625537;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.ClearButtonContentProperty, value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00018988 File Offset: 0x00016B88
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00018A40 File Offset: 0x00016C40
		[global::System.ComponentModel.DefaultValue(global::System.Globalization.CalendarWeekRule.FirstDay)]
		[global::System.ComponentModel.Description("Indicates rule used to determine first week of the year for week of year display on calendar.")]
		public global::System.Globalization.CalendarWeekRule WeekOfYearRule
		{
			get
			{
				short num = (short)1632239616;
				short num2 = num;
				num = (short)563110972;
				short num3 = num;
				num = (short)15819836;
				switch (num3 == num)
				{
				}
				num = (short)989396993;
				if (num != 0)
				{
				}
				num = (short)571604992;
				if (num != 0)
				{
				}
				return (global::System.Globalization.CalendarWeekRule)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.WeekOfYearRuleProperty);
			}
			set
			{
				short num = (short)147587072;
				short num2 = num;
				num = (short)2095981569;
				short num3 = num;
				num = (short)1212556289;
				switch (num3 == num)
				{
				}
				num = (short)1269825536;
				if (num != 0)
				{
				}
				num = (short)1027801089;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.WeekOfYearRuleProperty, value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00018AF8 File Offset: 0x00016CF8
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00018BB0 File Offset: 0x00016DB0
		[global::System.ComponentModel.Description("Indicates whether week of year is visible.")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ShowWeekNumbers
		{
			get
			{
				short num = (short)305201152;
				short num2 = num;
				num = (short)1402963442;
				short num3 = num;
				num = (short)41584114;
				switch (num3 == num)
				{
				}
				num = (short)676331521;
				if (num != 0)
				{
				}
				num = (short)1713307648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowWeekNumbersProperty);
			}
			set
			{
				short num = (short)1788149760;
				short num2 = num;
				num = (short)129898380;
				short num3 = num;
				num = (short)1719932812;
				switch (num3 == num)
				{
				}
				num = (short)1685389313;
				if (num != 0)
				{
				}
				num = (short)1630339072;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowWeekNumbersProperty, value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00018C70 File Offset: 0x00016E70
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00018D28 File Offset: 0x00016F28
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Description("Indicates whether today marker that indicates TodayDate is visible on the calendar.")]
		public bool ShowTodayMarker
		{
			get
			{
				short num = (short)955056128;
				short num2 = num;
				num = (short)824427462;
				short num3 = num;
				num = (short)1226752966;
				switch (num3 == num)
				{
				}
				num = (short)1507786753;
				if (num != 0)
				{
				}
				num = (short)285081600;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowTodayMarkerProperty);
			}
			set
			{
				short num = (short)1512308736;
				short num2 = num;
				num = (short)934820070;
				short num3 = num;
				num = (short)656357606;
				switch (num3 == num)
				{
				}
				num = (short)104857601;
				if (num != 0)
				{
				}
				num = (short)674168832;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.ShowTodayMarkerProperty, value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00018DE0 File Offset: 0x00016FE0
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00018E98 File Offset: 0x00017098
		[global::System.ComponentModel.DefaultValue(global::System.DayOfWeek.Sunday)]
		[global::System.ComponentModel.Description("Indicates first day of week displayed on the calendar.")]
		public global::System.DayOfWeek FirstDayOfWeek
		{
			get
			{
				short num = (short)1755709440;
				short num2 = num;
				num = (short)1822969016;
				short num3 = num;
				num = (short)1010388152;
				switch (num3 == num)
				{
				}
				num = (short)1482489856;
				if (num != 0)
				{
				}
				num = (short)1504968705;
				if (num != 0)
				{
				}
				return (global::System.DayOfWeek)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.FirstDayOfWeekProperty);
			}
			set
			{
				short num = (short)545849344;
				short num2 = num;
				num = (short)2116947740;
				short num3 = num;
				num = (short)493817628;
				switch (num3 == num)
				{
				}
				num = (short)562626561;
				if (num != 0)
				{
				}
				num = (short)1517879296;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.FirstDayOfWeekProperty, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00018F54 File Offset: 0x00017154
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00019010 File Offset: 0x00017210
		[global::System.ComponentModel.Description("Indicates whether weekend days can be selected.")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool WeekendDaysSelectable
		{
			get
			{
				short num = (short)1584070656;
				short num2 = num;
				num = (short)1163011032;
				short num3 = num;
				num = (short)333521880;
				switch (num3 == num)
				{
				}
				num = (short)1529741313;
				if (num != 0)
				{
				}
				num = (short)1891106816;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.DateTimeInput.WeekendDaysSelectableProperty);
			}
			set
			{
				short num = (short)1937375232;
				short num2 = num;
				num = (short)2079096731;
				short num3 = num;
				num = (short)1228504987;
				switch (num3 == num)
				{
				}
				num = (short)271581184;
				if (num != 0)
				{
				}
				num = (short)599261185;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.DateTimeInput.WeekendDaysSelectableProperty, value);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000190D0 File Offset: 0x000172D0
		static DateTimeInput()
		{
			int a_ = 1;
			short num = (short)1837498368;
			short num2 = num;
			num = (short)1312566011;
			short num3 = num;
			num = (short)426519291;
			switch (num3 == num)
			{
			}
			num = (short)1918107649;
			if (num != 0)
			{
			}
			num = (short)1185284096;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.DateTimeInput.AutoAdvanceProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("迍ꗏꛑ믓韕볗곙뷛냝菟蟡", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfEditors.DateTimeInput.DefaultInputValuesProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諍뗏듑뗓ꏕ듗껙闛냝郟韡郣냥觧蛩駫语華", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfEditors.DateTimeInput.ShowDropDownProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷍룏뷑ꏓ鋕꫗뗙곛髝迟闡諣", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.DateTimeInput.f)));
			global::DevComponents.WpfEditors.DateTimeInput.ShowUpDownProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷍룏뷑ꏓ菕꣗黙돛꧝軟", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.DateTimeInput.e)));
			global::DevComponents.WpfEditors.DateTimeInput.ValueChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飍뇏뻑ꇓ돕鯗닙뷛냝蟟蟡胣", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.DateTimeInput));
			global::DevComponents.WpfEditors.DateTimeInput.ShowClearButtonProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷍룏뷑ꏓ闕듗뿙뷛곝ꋟ韡郣鋥蟧蓩", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.DateTimeInput.d)));
			global::DevComponents.WpfEditors.DateTimeInput.AllowEmptyStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("迍볏뻑믓ꇕ鷗럙곛ꫝ駟뇡郣蟥鳧迩", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.DateTimeInput.ValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飍뇏뻑ꇓ돕", a_), typeof(global::System.DateTime?), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.DateTimeInput.c), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.DateTimeInput.a), true, global::System.Windows.Data.UpdateSourceTrigger.PropertyChanged));
			global::DevComponents.WpfEditors.DateTimeInput.CustomFormatProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跍ꗏꇑꃓ맕뗗鳙돛곝跟菡郣", a_), typeof(string), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.DateTimeInput.b)));
			global::DevComponents.WpfEditors.DateTimeInput.FormatProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("裍뿏ꃑ맓럕곗", a_), typeof(global::DevComponents.WpfEditors.eDateTimePickerFormat), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eDateTimePickerFormat.Short, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.DateTimeInput.a)));
			global::DevComponents.WpfEditors.DateTimeInput.MinDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菍맏병郓럕곗뿙", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.MinValue));
			global::DevComponents.WpfEditors.DateTimeInput.MaxDateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菍뇏꫑郓럕곗뿙", a_), typeof(global::System.DateTime), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(global::System.DateTime.MaxValue));
			global::DevComponents.WpfEditors.DateTimeInput.IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蟍ꏏ胑뇓럕볗闙닛닝駟", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfEditors.DateTimeInput.SelectNextInputCharactersProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷍뗏뻑뇓뗕곗铙맛ꛝ铟ꯡ諣雥鷧黩꿫蛭釯胱闳闵賷鿹軻跽", a_), typeof(string), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(""));
			global::DevComponents.WpfEditors.DateTimeInput.CalendarDimensionsProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跍뇏뻑뇓룕볗믙껛髝觟迡臣裥鯧菩菫胭華", a_), typeof(global::System.Windows.Size), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(new global::System.Windows.Size(1.0, 1.0)));
			global::DevComponents.WpfEditors.DateTimeInput.TodayButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髍뿏뛑뗓꿕髗꿙꣛ꫝ迟賡닣迥鯧菩軫蟭鳯鯱胳迵", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::DevComponents.WpfEditors.DateTimeInput.ClearButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跍볏럑뗓ꓕ髗꿙꣛ꫝ迟賡닣迥鯧菩軫蟭鳯鯱胳迵", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::DevComponents.WpfEditors.DateTimeInput.TodayButtonContentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髍뿏뛑뗓꿕髗꿙꣛ꫝ迟賡꟣觥蛧黩觫胭蓯", a_), typeof(object), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髍뿏뛑뗓꿕", a_)));
			global::DevComponents.WpfEditors.DateTimeInput.ClearButtonContentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跍볏럑뗓ꓕ髗꿙꣛ꫝ迟賡꟣觥蛧黩觫胭蓯", a_), typeof(object), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跍볏럑뗓ꓕ", a_)));
			global::DevComponents.WpfEditors.DateTimeInput.WeekOfYearRuleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駍뗏럑뿓駕뻗菙맛뿝鋟냡釣諥跧", a_), typeof(global::System.Globalization.CalendarWeekRule), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(global::System.Globalization.CalendarWeekRule.FirstDay));
			global::DevComponents.WpfEditors.DateTimeInput.ShowWeekNumbersProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷍룏뷑ꏓ臕뷗뿙럛郝闟迡蛣菥髧駩", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfEditors.DateTimeInput.ShowTodayMarkerProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷍룏뷑ꏓ苕럗뻙뷛꟝귟菡難跥跧飩", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.DateTimeInput.FirstDayOfWeekProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("裍맏ꃑꟓꋕ鳗믙ꗛ針蛟뗡臣菥菧", a_), typeof(global::System.DayOfWeek), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(global::System.DayOfWeek.Sunday));
			global::DevComponents.WpfEditors.DateTimeInput.WeekendDaysSelectableProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駍뗏럑뿓돕뛗뻙飛뿝駟釡럣菥蓧迩迫髭釯郱飳鏵", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.DateTimeInput.e = false;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.DateTimeInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.DateTimeInput)));
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00019760 File Offset: 0x00017960
		public global::DevComponents.WpfEditors.MonthCalendar GetDropDownMonthCalendar()
		{
			int a_ = 10;
			if (this.d == null)
			{
				short num = (short)1603825331;
				short num2 = num;
				num = (short)2012114611;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)410386433;
					if (num != 0)
					{
					}
					num = (short)1454505984;
					if (num != 0)
					{
					}
					num = (short)1412431872;
					short num3 = num;
					return null;
				}
				}
			}
			return this.d.Template.FindName(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蟖뛘ꯚ꣜꿞ꋠ苢觤苦蟨迪賬鷮", a_), this.d) as global::DevComponents.WpfEditors.MonthCalendar;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00019850 File Offset: 0x00017A50
		public void DisplayPopup()
		{
			short num = (short)54671471;
			short num2 = num;
			num = (short)711080047;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AC:
				num = (short)697040898;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2021720064;
				if (num != 0)
				{
				}
				num = (short)1736638465;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 2:
					num = (short)1649213441;
					if (num != 0)
					{
					}
					this.d.IsPopupOpen = true;
					num = (short)863633408;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			IL_7B:
			num = (short)916062208;
			short num4 = num;
			if (this.d != null)
			{
				goto IL_AC;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00019970 File Offset: 0x00017B70
		public void HidePopup()
		{
			short num = (short)1579202535;
			short num2 = num;
			num = (short)231913447;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D3:
				num = (short)1834483714;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)963903489;
				if (num != 0)
				{
				}
				num = (short)10092544;
				if (num != 0)
				{
				}
				num = (short)1799094273;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)1936916480;
				short num4 = num;
				switch (num3)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_CB;
					}
					continue;
				case 2:
					this.d.IsPopupOpen = false;
					num = (short)657391616;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			IL_CB:
			if (this.d != null)
			{
				goto IL_D3;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00019A8C File Offset: 0x00017C8C
		protected override void OnInputGroupAssigned()
		{
			short num = (short)1129512960;
			short num2 = num;
			num = (short)1660525092;
			short num3 = num;
			num = (short)182098468;
			switch (num3 == num)
			{
			}
			num = (short)236781569;
			if (num != 0)
			{
			}
			num = (short)1273102336;
			if (num != 0)
			{
			}
			this.a = (this.GetInputGroup() as global::DevComponents.WpfEditors.Primitives.DateTimeGroup);
			this.g();
			this.c();
			base.OnInputGroupAssigned();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00019B58 File Offset: 0x00017D58
		private new void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1410727936;
			short num2 = num;
			num = (short)1802767187;
			short num3 = num;
			num = (short)1011813203;
			switch (num3 == num)
			{
			}
			num = (short)1985150976;
			if (num != 0)
			{
			}
			num = (short)524288001;
			if (num != 0)
			{
			}
			this.OnValueChanged(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueChangedEvent));
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00019C10 File Offset: 0x00017E10
		private void g()
		{
			int a_ = 7;
			if (this.a == null)
			{
				short num = (short)1095161127;
				short num2 = num;
				num = (short)983029031;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1213988865;
					if (num != 0)
					{
					}
					num = (short)2141257728;
					if (num != 0)
					{
					}
					num = (short)64684032;
					short num3 = num;
					return;
				}
				}
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("苓럕듗꿙맛", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.PropertyChanged;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.ValueProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓뿕뛗黙뷛ꫝ藟", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MinDateProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓럕ꃗ黙뷛ꫝ藟", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.MaxDateProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闓ꏕ곗뗙鏛꣝藟郡鏣铥臧黩觫", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AutoOverwriteProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闓뫕듗뗙ꯛ鯝跟鋡郣鿥믧黩跫髭闯", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AllowEmptyStateProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷓ꗕ諗뿙뷛뫝꿟賡裣鿥", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.IsReadOnlyProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蟓돕듗뿙뿛ꫝ껟蟡鳣鋥ꇧ蓩鳫鯭蓯뇱鳳韵諷鯹鿻諽旿瀁眃", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.SelectNextInputCharactersProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣꟥蓧菩诫胭鷯韱髳苵", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkAlignmentProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣ꓥ跧苩跫飭駯鷱蛳", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBehaviorProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣ꓥ髧鿩鿫蛭", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBrushProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣ꏥ蛧诩軫苭闯雱", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkEnabledProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣닥跧鋩飫", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkTextProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郓돕뻗믙꧛닝铟ꯡ諣雥鷧黩뫫迭鳯蟱釳藵", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.DateTimeGroup.DefaultInputValuesProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闓ꏕ곗뗙鷛뫝雟菡諣藥跧", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Source = this;
			this.a.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.AutoAdvanceProperty, binding);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00019FB0 File Offset: 0x000181B0
		private void f()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.EditorGroup editorGroup;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (editorGroup == null)
					{
						num2 = (short)347668485;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)236781577;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_178;
				case 2:
					num2 = (short)782499841;
					if (num2 != 0)
					{
					}
					this.b = new global::DevComponents.WpfEditors.Primitives.EditorUpDownButton
					{
						HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right,
						Focusable = false,
						ButtonsFocusable = false,
						AutoChange = global::DevComponents.WpfEditors.Primitives.eUpDownButtonAutoChange.FocusedItem
					};
					num2 = (short)924909576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_1CE;
				case 4:
					if (this.b == null)
					{
						num2 = (short)412352514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_74;
				case 5:
					return;
				case 6:
					if (this.b != null)
					{
						num2 = (short)661651463;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24D;
				case 7:
				{
					num2 = (short)2008416256;
					short num3 = num2;
					editorGroup.Items.Remove(this.b);
					num2 = (short)135987203;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
				{
					num2 = (short)1947117126;
					short num4 = num2;
					num2 = (short)1154328134;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_178;
					default:
						goto IL_128;
					}
					break;
				}
				case 9:
					if (this.ShowUpDown)
					{
						num2 = (short)1729101825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)552599558;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_178:
				num2 = (short)170852356;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_74:
			editorGroup.Items.Insert(this.GetUpDownButtonInsertPosition(), this.b);
			return;
			IL_128:
			num2 = (short)1302986752;
			if (num2 != 0)
			{
			}
			goto IL_74;
			IL_1CE:
			IL_24D:
			this.b = null;
			return;
			IL_38:
			editorGroup = this.a;
			num2 = (short)498466816;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0001A214 File Offset: 0x00018414
		private void e()
		{
			switch (0)
			{
			case 0:
				goto IL_92;
			}
			short num;
			int num3;
			global::DevComponents.WpfEditors.Primitives.EditorGroup editorGroup;
			int num5;
			for (;;)
			{
				IL_0A:
				num = (short)1677398968;
				short num2 = num;
				num = (short)714675128;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1208418304;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return;
					case 1:
						this.c = new global::DevComponents.WpfEditors.Primitives.EditorClearButton();
						this.c.Click += this.a;
						this.c.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
						num = (short)1744568326;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.ShowClearButton)
						{
							num = (short)388825100;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)197459973;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (editorGroup == null)
						{
							num = (short)1453129728;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1157103616;
						short num4 = num;
						num = (short)71434242;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_211;
					case 5:
						if (this.c != null)
						{
							num = (short)172425220;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF;
					case 6:
						goto IL_E2;
					case 7:
						if (this.c == null)
						{
							num = (short)291635201;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E2;
					case 8:
						if (this.ShowUpDown)
						{
							num = (short)209518603;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF;
					case 9:
						goto IL_20C;
					case 10:
						goto IL_250;
					case 11:
						num5++;
						num = (short)526057481;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1974796289;
						if (num != 0)
						{
						}
						num = (short)389611527;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_92;
					IL_E2:
					num5 = this.GetUpDownButtonInsertPosition();
					num = (short)1079115784;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_211:
				editorGroup.Items.Remove(this.c);
				this.c.Click -= this.a;
				num = (short)340525066;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_CF:
			editorGroup.Items.Insert(num5, this.c);
			return;
			IL_20C:
			goto IL_CF;
			IL_250:
			IL_2DF:
			this.c = null;
			return;
			IL_92:
			editorGroup = this.a;
			num = (short)1280770051;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0001A508 File Offset: 0x00018708
		private new void d()
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			int num;
			short num2;
			int num4;
			global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.ShowDropDown)
					{
						num2 = (short)1347944459;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1132724242;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.ShowClearButton)
					{
						num2 = (short)1380778000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_56D;
				case 2:
				{
					if (this.c == null)
					{
						goto IL_56D;
					}
					num2 = (short)448149336;
					short num3 = num2;
					num2 = (short)15677272;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5FA;
					default:
						num2 = (short)772603904;
						if (num2 != 0)
						{
						}
						num2 = (short)34734085;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (this.d == null)
					{
						num2 = (short)897581069;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5BD;
				case 4:
					goto IL_5FA;
				case 5:
				{
					num4++;
					num2 = (short)670498816;
					short num5 = num2;
					num2 = (short)748224521;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					num4++;
					num2 = (short)408354831;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_2A9;
				case 8:
					return;
				case 9:
					goto IL_EE;
				case 10:
					if (inputGroup == null)
					{
						num2 = (short)557776904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)40501248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)1235025923;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (this.b != null)
					{
						num2 = (short)153681926;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_580;
				case 13:
				{
					this.d = new global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton();
					this.d.Focusable = false;
					this.d.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
					this.d.SelectedDateChanged += this.b;
					this.d.SelectedDate = this.Value;
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝迟蛡藣鿥ꫧ鿩飫髭鿯鳱ꋳ鿵请鏹黻韽泿欁瀃缅", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.TodayButtonVisibilityProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("諝迟蛡藣鿥ꫧ鿩飫髭鿯鳱럳駵雷軹駻都瓿", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.TodayButtonContentProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝賟蟡藣铥ꫧ鿩飫髭鿯鳱럳駵雷軹駻都瓿", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.ClearButtonContentProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝賟蟡藣铥ꫧ鿩飫髭鿯鳱ꋳ鿵请鏹黻韽泿欁瀃缅", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.ClearButtonVisibilityProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝臟軡臣裥賧诩黫ꫭ駯鿱釳飵请鏹鏻都珿", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.CalendarDimensionsProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觝藟蟡迣ꧥ軧돩觫迭苯ꃱ至髵鷷", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.WeekOfYearRuleProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("距裟跡鏣닥蟧軩跫韭뷯鏱蛳鷵鷷裹", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.ShowTodayMarkerProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("距裟跡鏣뇥跧迩蟫ꃭ藯鿱雳鏵諷觹", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.ShowWeekNumbersProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飝觟郡韣鋥곧诩闫ꇭ雯ꗱ釳鏵鏷", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.FirstDayOfWeekProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觝藟蟡迣菥蛧軩꣫迭觯臱ꟳ鏵铷鿹鿻諽懿态栃挅", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.WeekendDaysSelectableProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝觟賡ꃣ蟥鳧迩", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.MinDateProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏝臟髡ꃣ蟥鳧迩", a_));
					binding.Source = this;
					this.d.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton.MaxDateProperty, binding);
					num2 = (short)1993146385;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 14:
					if (this.ShowUpDown)
					{
						num2 = (short)529530884;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_580;
				case 15:
					goto IL_580;
				case 16:
					num2 = (short)286195714;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_5BD;
				case 18:
					if (this.d != null)
					{
						num2 = (short)1275723795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5FF;
				case 19:
					inputGroup.Items.Remove(this.d);
					num2 = (short)2000748551;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_69;
				IL_580:
				num2 = (short)1619984385;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5BD:
				num4 = this.GetUpDownButtonInsertPosition();
				num2 = (short)645791758;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5FA:
				num2 = (short)842399756;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_EE:
			num2 = (short)717881345;
			if (num2 != 0)
			{
			}
			goto IL_56D;
			IL_2A9:
			goto IL_5FF;
			IL_56D:
			inputGroup.Items.Insert(num4, this.d);
			return;
			IL_5FF:
			this.d = null;
			return;
			IL_69:
			inputGroup = this.GetInputGroup();
			num2 = (short)1512898570;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0001AB1C File Offset: 0x00018D1C
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)225574913;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)247462268;
				short num3 = num;
				num = (short)1842215292;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1785135104;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)411893763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					case 2:
						goto IL_1E9;
					case 3:
						if (this.a.IsKeyboardFocusWithin)
						{
							goto IL_127;
						}
						goto IL_19D;
					case 4:
						this.Value = this.d.SelectedDate;
						this.d.ClosePopup();
						num = (short)1694171142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)106954759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.a != null)
						{
							num = (short)746848256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						if (this.a.FocusedItem == null)
						{
							num = (short)1765015560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						goto IL_19D;
					}
					IL_93:
					if (this.d.IsPopupOpen)
					{
						num = (short)89980932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_19D:
					this.a.b(true);
					num = (short)291241984;
					short num4 = num;
					num = (short)1363214338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_127:
				num = (short)841547781;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E9:
			num = (short)1037500417;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0001AD3C File Offset: 0x00018F3C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)110996655;
			short num2 = num;
			num = (short)423013551;
			switch (num2 == num)
			{
			default:
			{
				num = (short)546504704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)336920577;
			if (num != 0)
			{
			}
			num = (short)745472000;
			if (num != 0)
			{
			}
			this.ResetValue();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001ADE8 File Offset: 0x00018FE8
		protected virtual void ResetValue()
		{
			short num = (short)632862408;
			short num2 = num;
			num = (short)709473992;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1129709568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)761135105;
			if (num != 0)
			{
			}
			num = (short)466419712;
			if (num != 0)
			{
			}
			this.Value = null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001AEA0 File Offset: 0x000190A0
		protected virtual global::DevComponents.WpfEditors.Primitives.EditorInputBase GetDefaultInputItem()
		{
			short num = (short)2145845249;
			if (num != 0)
			{
			}
			num = (short)1175781376;
			short num2 = num;
			num = (short)375400448;
			short num3 = num;
			num = (short)1339435008;
			switch (num3 == num)
			{
			}
			num = (short)924581888;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001AF48 File Offset: 0x00019148
		protected virtual int GetUpDownButtonInsertPosition()
		{
			short num = (short)496762888;
			int num2 = (int)((global::System.IntPtr)num);
			int num4;
			for (;;)
			{
				num = (short)1933312000;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1255145478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_DD;
				case 2:
					return 0;
				case 3:
					goto IL_123;
				case 4:
				{
					if (num4 >= this.a.Items.Count)
					{
						num = (short)1626341381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.UIElement uielement = this.a.Items[num4];
					num = (short)792592391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_165;
				case 6:
				{
					global::System.Windows.UIElement uielement;
					if (uielement is global::System.Windows.Controls.Button)
					{
						num = (short)243728385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4++;
					num = (short)1427898377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					global::System.Windows.UIElement uielement;
					if (!(uielement is global::DevComponents.WpfEditors.UpDownButton))
					{
						num = (short)17235968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return num4;
				}
				case 8:
					switch (0)
					{
					case 0:
						goto IL_76;
					}
					continue;
				case 9:
					goto IL_123;
				}
				IL_76:
				if (this.a.Items.Count == 0)
				{
					num = (short)2099249154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num4 = 0;
				num = (short)916848641;
				if (num != 0)
				{
				}
				num = (short)53739523;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_123:
				num = (short)990707716;
				num2 = (int)((global::System.IntPtr)num);
			}
			return 0;
			IL_DD:
			return num4;
			IL_165:
			num = (short)1967094541;
			short num5 = num;
			num = (short)1725856525;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return num4;
			default:
				num = (short)1981284352;
				if (num != 0)
				{
				}
				return this.a.Items.Count - 1;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001B18C File Offset: 0x0001938C
		private new void c()
		{
			short num = (short)879755265;
			if (num != 0)
			{
			}
			num = (short)1900085248;
			short num2 = num;
			num = (short)652540890;
			short num3 = num;
			num = (short)2044525530;
			switch (num3 == num)
			{
			}
			num = (short)563478528;
			if (num != 0)
			{
			}
			this.b();
			base.InvalidateMeasure();
			base.InvalidateVisual();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001B248 File Offset: 0x00019448
		private void b()
		{
			short num = (short)1809842182;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D4;
				case 1:
					if (this.Format != global::DevComponents.WpfEditors.eDateTimePickerFormat.Custom)
					{
						num = (short)1894383618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DB;
				case 2:
				{
					num = (short)719085738;
					short num3 = num;
					num = (short)1974886570;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B5;
					default:
						goto IL_10F;
					}
					break;
				}
				case 3:
					goto IL_B5;
				case 4:
					return;
				case 5:
				{
					num = (short)1709834240;
					short num4 = num;
					num = (short)1248657411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 7:
					if (this.CustomFormat.Length > 0)
					{
						num = (short)1173946373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66;
				}
				IL_44:
				if (this.a == null)
				{
					num = (short)1582956548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1119748103;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_66:
				num = (short)1711341569;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B5:
				if (this.Format != global::DevComponents.WpfEditors.eDateTimePickerFormat.Custom)
				{
					goto IL_66;
				}
				num = (short)1551368192;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_D4:
			this.b(this.CustomFormat);
			return;
			IL_10F:
			num = (short)1209860096;
			if (num != 0)
			{
			}
			num = (short)1712521217;
			if (num != 0)
			{
			}
			this.b(this.a(this.Format));
			return;
			IL_1DB:
			this.a.Items.Clear();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0001B440 File Offset: 0x00019640
		private string a(global::DevComponents.WpfEditors.eDateTimePickerFormat A_0)
		{
			short num = (short)2033057798;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14F;
				case 1:
					if (A_0 == global::DevComponents.WpfEditors.eDateTimePickerFormat.ShortTime)
					{
						num = (short)732299266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1727135751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_A7;
				case 3:
				{
					num = (short)1224002790;
					short num3 = num;
					num = (short)1498664166;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1382023168;
						if (num != 0)
						{
						}
						num = (short)113049601;
						if (num != 0)
						{
						}
						if (A_0 == global::DevComponents.WpfEditors.eDateTimePickerFormat.Short)
						{
							num = (short)985071616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1275985921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_5D;
				case 5:
					goto IL_1A5;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 7:
					if (A_0 == global::DevComponents.WpfEditors.eDateTimePickerFormat.LongTime)
					{
						num = (short)1451491333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B7;
				}
				IL_45:
				if (A_0 == global::DevComponents.WpfEditors.eDateTimePickerFormat.Long)
				{
					num = (short)1804075012;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)761987075;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5D:
			return global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.LongDatePattern;
			IL_A7:
			return global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.ShortTimePattern;
			IL_14F:
			return global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.ShortDatePattern;
			IL_1A5:
			return global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().DateTimeFormat.LongTimePattern;
			IL_1B7:
			num = (short)1113391104;
			short num4 = num;
			return "";
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001B634 File Offset: 0x00019834
		private void b(string A_0)
		{
			int a_ = 9;
			short num = (short)741343232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_22F;
				}
				for (;;)
				{
					IL_30:
					global::DevComponents.WpfEditors.Primitives.EditorGroup editorGroup;
					int num3;
					bool flag;
					global::System.Collections.Generic.Stack<global::DevComponents.WpfEditors.Primitives.EditorGroup> stack;
					bool flag4;
					global::System.DateTime? value;
					global::System.DateTime? value3;
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfEditors.Primitives.NumericYearInput element = new global::DevComponents.WpfEditors.Primitives.NumericYearInput();
						editorGroup.Items.Add(element);
						num3 += 3;
						flag = true;
						num = (short)1008271459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꗕ", a_))
						{
							num = (short)1185611803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)442957860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Windows.Controls.Label label = this.a();
						global::System.Text.StringBuilder stringBuilder;
						label.Content = stringBuilder.ToString();
						editorGroup.Items.Add(label);
						stringBuilder = new global::System.Text.StringBuilder(A_0.Length);
						num = (short)1188888639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						string text = A_0.Substring(num3, global::System.Math.Min(2, A_0.Length - num3));
						num = (short)1386545271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_395;
					case 5:
						editorGroup = stack.Pop();
						flag = true;
						num = (short)1357512718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)2142568449;
						if (num != 0)
						{
						}
						global::System.Text.StringBuilder stringBuilder;
						if (stringBuilder.Length > 0)
						{
							num = (short)1984364593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1B;
					}
					case 7:
						goto IL_83C;
					case 8:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)986185809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = true;
						num = (short)336658501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_161D;
					case 10:
					{
						if (flag)
						{
							num = (short)701038625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Text.StringBuilder stringBuilder;
						stringBuilder.Append(A_0[num3]);
						num = (short)867500120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::DevComponents.WpfEditors.Primitives.NumericYearInput numericYearInput = new global::DevComponents.WpfEditors.Primitives.NumericYearInput();
						numericYearInput.YearDisplayFormat = global::DevComponents.WpfEditors.Primitives.eYearDisplayFormat.OneDigit;
						editorGroup.Items.Add(numericYearInput);
						flag = true;
						num = (short)480247834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::DevComponents.WpfEditors.Primitives.NumericHourInput numericHourInput = new global::DevComponents.WpfEditors.Primitives.NumericHourInput();
						numericHourInput.DisplayFormat = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						numericHourInput.Is24HourFormat = true;
						editorGroup.Items.Add(numericHourInput);
						num3++;
						flag = true;
						num = (short)140378212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_176A;
					case 14:
						goto IL_161D;
					case 15:
					{
						global::DevComponents.WpfEditors.Primitives.NumericMonthInput element2 = new global::DevComponents.WpfEditors.Primitives.NumericMonthInput();
						editorGroup.Items.Add(element2);
						flag = true;
						num = (short)720306217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::DevComponents.WpfEditors.Primitives.NumericDayOfYearInput element3 = new global::DevComponents.WpfEditors.Primitives.NumericDayOfYearInput();
						editorGroup.Items.Add(element3);
						flag = true;
						num = (short)242155588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꿕", a_))
						{
							num = (short)1296302091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1876164636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (!flag)
						{
							num = (short)465633283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1194;
					case 19:
					{
						global::DevComponents.WpfEditors.Primitives.HourPeriodInput hourPeriodInput = new global::DevComponents.WpfEditors.Primitives.HourPeriodInput();
						hourPeriodInput.UseSingleLetterLabel = true;
						editorGroup.Items.Add(hourPeriodInput);
						flag = true;
						num = (short)1252261917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						bool flag3 = false;
						num = (short)48234509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.Text.StringBuilder stringBuilder;
						if (stringBuilder.Length > 0)
						{
							num = (short)497549314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1104;
					}
					case 22:
						this.a.Value = this.Value;
						num = (short)1422458972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_161D;
					case 24:
					{
						string text = A_0[num3].ToString();
						num = (short)785776701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)1524498548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = A_0.Substring(num3, global::System.Math.Min(4, A_0.Length - num3));
						flag = false;
						num = (short)342622261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_161D;
					case 27:
					{
						global::DevComponents.WpfEditors.Primitives.NumericSecondInput element4 = new global::DevComponents.WpfEditors.Primitives.NumericSecondInput();
						editorGroup.Items.Add(element4);
						flag = true;
						num = (short)2048262269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("볕", a_))
						{
							num = (short)1853489168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)623902828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_161D;
					case 30:
						goto IL_161D;
					case 31:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("뻕냗", a_))
						{
							num = (short)684195944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)356646955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (!flag)
						{
							num = (short)265879576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161D;
					case 33:
						num = (short)379781213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						global::DevComponents.WpfEditors.Primitives.MonthNameInput element5 = new global::DevComponents.WpfEditors.Primitives.MonthNameInput();
						editorGroup.Items.Add(element5);
						num3 += 3;
						flag = true;
						num = (short)2040266797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (!flag)
						{
							num = (short)384893050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_618;
					case 36:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꋕ", a_))
						{
							num = (short)2078670867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1848836113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
					{
						global::DevComponents.WpfEditors.Primitives.NumericSecondInput numericSecondInput = new global::DevComponents.WpfEditors.Primitives.NumericSecondInput();
						numericSecondInput.DisplayFormat = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						editorGroup.Items.Add(numericSecondInput);
						num3++;
						flag = true;
						num = (short)90833017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯕闗韙釛", a_))
						{
							num = (short)1465122850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)533266506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						return;
					case 40:
						flag4 = false;
						goto IL_165A;
					case 41:
						goto IL_161D;
					case 42:
						num = (short)2145517608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("黕郗", a_))
						{
							num = (short)826343436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2026504236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("믕뗗", a_))
						{
							num = (short)962068540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2093023321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						goto IL_D7B;
					case 46:
						goto IL_83C;
					case 47:
					{
						global::DevComponents.WpfEditors.Primitives.NumericDayInput element6 = new global::DevComponents.WpfEditors.Primitives.NumericDayInput();
						editorGroup.Items.Add(element6);
						flag = true;
						num = (short)2077360137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						goto IL_1194;
					case 49:
					{
						global::System.Windows.Controls.Label label2 = this.a();
						global::System.Text.StringBuilder stringBuilder;
						label2.Content = stringBuilder.ToString();
						editorGroup.Items.Add(label2);
						num = (short)702742610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
					{
						bool flag3;
						if (flag3)
						{
							num = (short)1511850006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 51:
					{
						global::DevComponents.WpfEditors.Primitives.DayLabelItem element7 = new global::DevComponents.WpfEditors.Primitives.DayLabelItem();
						editorGroup.Items.Add(element7);
						num3 += 3;
						flag = true;
						num = (short)1321926753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						goto IL_395;
					case 53:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("닕볗뻙룛", a_))
						{
							num = (short)1875050547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)138739750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
					{
						value = this.a.Value;
						global::System.DateTime value2 = value.Value;
						value = this.Value;
						global::System.TimeSpan timeSpan = value2.Subtract(value.Value);
						num = (short)2035089466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
					{
						bool flag3 = true;
						value = this.a.Value;
						num = (short)577568825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
					{
						global::DevComponents.WpfEditors.Primitives.HourPeriodInput element8 = new global::DevComponents.WpfEditors.Primitives.HourPeriodInput();
						editorGroup.Items.Add(element8);
						num3++;
						flag = true;
						num = (short)642318398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
						if (value != null)
						{
							num = (short)892010620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176A;
					case 58:
					{
						global::System.TimeSpan timeSpan;
						if (global::System.Math.Abs(timeSpan.TotalSeconds) < 1.0)
						{
							num = (short)1969160212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176A;
					}
					case 59:
						num = (short)2140471304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						global::DevComponents.WpfEditors.Primitives.NumericMinuteInput numericMinuteInput = new global::DevComponents.WpfEditors.Primitives.NumericMinuteInput();
						numericMinuteInput.DisplayFormat = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						editorGroup.Items.Add(numericMinuteInput);
						num3++;
						flag = true;
						num = (short)2046165059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("닕", a_))
						{
							num = (short)1850736687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)143720528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						goto IL_1194;
					case 63:
						goto IL_1104;
					case 64:
						if (value3 == null)
						{
							num = (short)1071644714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)937492595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
					{
						string text;
						if (!(text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("믕", a_)))
						{
							num = (short)1263927408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)138679573;
						short num4 = num;
						num = (short)412488981;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)105906176;
							if (num != 0)
							{
							}
							num = (short)116981830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 66:
						goto IL_1194;
					case 67:
						goto IL_1194;
					case 68:
						goto IL_161D;
					case 69:
						goto IL_395;
					case 70:
					{
						global::DevComponents.WpfEditors.Primitives.NumericMinuteInput element9 = new global::DevComponents.WpfEditors.Primitives.NumericMinuteInput();
						editorGroup.Items.Add(element9);
						flag = true;
						num = (short)1604845598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
					{
						global::DevComponents.WpfEditors.Primitives.MonthNameInput monthNameInput = new global::DevComponents.WpfEditors.Primitives.MonthNameInput();
						monthNameInput.UseAbbreviatedNames = true;
						editorGroup.Items.Add(monthNameInput);
						num3 += 2;
						flag = true;
						num = (short)1435959391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 72:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꗕꯗ", a_))
						{
							num = (short)730726437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)344195156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						goto IL_161D;
					case 74:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꿕ꇗꏙꗛ", a_))
						{
							num = (short)695468032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7B;
					}
					case 75:
					{
						if (A_0.Length == 0)
						{
							num = (short)1078132775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(A_0.Length);
						bool flag2 = false;
						stack = new global::System.Collections.Generic.Stack<global::DevComponents.WpfEditors.Primitives.EditorGroup>();
						editorGroup = this.a;
						num3 = 0;
						num = (short)358940679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
						goto IL_1194;
					case 77:
						if (A_0[num3] == '\'')
						{
							num = (short)1676935227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)877723673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (value3 != null != (value != null))
						{
							num = (short)661127274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)964100160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("볕닗냙", a_))
						{
							num = (short)596246614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_618;
					}
					case 80:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("뻕", a_))
						{
							num = (short)828047461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1460600934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 81:
					{
						bool flag2 = false;
						num = (short)735117316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 82:
						goto IL_B1B;
					case 83:
					{
						global::DevComponents.WpfEditors.Primitives.NumericDayInput numericDayInput = new global::DevComponents.WpfEditors.Primitives.NumericDayInput();
						numericDayInput.DisplayFormat = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						editorGroup.Items.Add(numericDayInput);
						num3++;
						flag = true;
						num = (short)2080702530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 84:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꋕ곗", a_))
						{
							num = (short)895221816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)961478750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						goto IL_1194;
					case 86:
					{
						global::DevComponents.WpfEditors.Primitives.NumericDayOfYearInput numericDayOfYearInput = new global::DevComponents.WpfEditors.Primitives.NumericDayOfYearInput();
						numericDayOfYearInput.DisplayFormat = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						editorGroup.Items.Add(numericDayOfYearInput);
						num3 += 2;
						flag = true;
						num = (short)1681522779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 87:
						if (num3 >= A_0.Length)
						{
							num = (short)986513504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)198180941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						goto IL_395;
					case 89:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯕闗", a_))
						{
							num = (short)1837236342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)637075528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 90:
						flag4 = true;
						goto IL_165A;
					case 91:
						goto IL_618;
					case 92:
						return;
					case 93:
					{
						global::System.Text.StringBuilder stringBuilder;
						if (stringBuilder.Length > 0)
						{
							num = (short)2025259111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_395;
					}
					case 94:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꿕ꇗ", a_))
						{
							num = (short)493617261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1194;
					}
					case 95:
						goto IL_618;
					case 96:
						num = (short)1429405702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						goto IL_D7B;
					case 98:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("닕볗뻙", a_))
						{
							num = (short)741671023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)836960369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 99:
						goto IL_D7B;
					case 100:
						goto IL_1194;
					case 101:
					{
						global::DevComponents.WpfEditors.Primitives.NumericHourInput numericHourInput2 = new global::DevComponents.WpfEditors.Primitives.NumericHourInput();
						numericHourInput2.Is24HourFormat = false;
						editorGroup.Items.Add(numericHourInput2);
						flag = true;
						num = (short)1285816393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 102:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("黕", a_))
						{
							num = (short)1869414505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1962934337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 103:
					{
						global::System.Windows.Controls.Label label3 = this.a();
						global::System.Text.StringBuilder stringBuilder;
						label3.Content = stringBuilder.ToString();
						editorGroup.Items.Insert(editorGroup.Items.Count - 1, label3);
						stringBuilder = new global::System.Text.StringBuilder(A_0.Length);
						num = (short)1654980715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 104:
					{
						global::DevComponents.WpfEditors.Primitives.NumericHourInput numericHourInput3 = new global::DevComponents.WpfEditors.Primitives.NumericHourInput();
						numericHourInput3.DisplayFormat = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						numericHourInput3.Is24HourFormat = false;
						editorGroup.Items.Add(numericHourInput3);
						num3++;
						flag = true;
						num = (short)764411952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 105:
					{
						global::DevComponents.WpfEditors.Primitives.NumericHourInput numericHourInput4 = new global::DevComponents.WpfEditors.Primitives.NumericHourInput();
						numericHourInput4.Is24HourFormat = true;
						editorGroup.Items.Add(numericHourInput4);
						flag = true;
						num = (short)82706542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 106:
						num = (short)1431765082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						goto IL_395;
					case 108:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("귕", a_))
						{
							num = (short)1892876408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2047541371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 109:
					{
						global::DevComponents.WpfEditors.Primitives.NumericYearInput numericYearInput2 = new global::DevComponents.WpfEditors.Primitives.NumericYearInput();
						numericYearInput2.YearDisplayFormat = global::DevComponents.WpfEditors.Primitives.eYearDisplayFormat.TwoDigit;
						editorGroup.Items.Add(numericYearInput2);
						num3++;
						flag = true;
						num = (short)2114191436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 110:
						goto IL_161D;
					case 111:
					{
						global::DevComponents.WpfEditors.Primitives.DayLabelItem dayLabelItem = new global::DevComponents.WpfEditors.Primitives.DayLabelItem();
						dayLabelItem.UseAbbreviatedNames = true;
						editorGroup.Items.Add(dayLabelItem);
						num3 += 2;
						flag = true;
						num = (short)328138869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 112:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯕", a_))
						{
							num = (short)1440415759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1685192705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 113:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯕闗韙", a_))
						{
							num = (short)1218641920;
							short num5 = num;
							num = (short)461635655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)231014479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 114:
						if (value != null)
						{
							num = (short)1650917430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176A;
					case 115:
						flag4 = (value3.GetValueOrDefault() != value.GetValueOrDefault());
						goto IL_165A;
					case 116:
					{
						global::System.Text.StringBuilder stringBuilder;
						stringBuilder.Append(A_0[num3]);
						num = (short)1923874868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 117:
						goto IL_618;
					case 118:
					{
						global::DevComponents.WpfEditors.Primitives.NumericMonthInput numericMonthInput = new global::DevComponents.WpfEditors.Primitives.NumericMonthInput();
						numericMonthInput.DisplayFormat = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						editorGroup.Items.Add(numericMonthInput);
						num3++;
						flag = true;
						num = (short)866320469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 119:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("닕볗", a_))
						{
							num = (short)944963667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1027932191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 120:
						num = (short)1971978261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						goto IL_1194;
					case 122:
					{
						string text = A_0.Substring(num3, global::System.Math.Min(3, A_0.Length - num3));
						num = (short)942932066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 123:
					{
						string text;
						if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꯕ", a_))
						{
							num = (short)1792671749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161D;
					}
					case 124:
						value = this.Value;
						num = (short)1346175090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						goto IL_161D;
					}
					goto IL_22F;
					IL_395:
					num3++;
					num = (short)1447886894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_618:
					num = (short)1349255186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_83C:
					num = (short)2040201303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1B:
					this.RecreateButtons();
					this.f();
					this.e();
					this.d();
					value3 = this.a.Value;
					value = this.Value;
					num = (short)170852430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D7B:
					num = (short)2064449571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1104:
					global::DevComponents.WpfEditors.Primitives.DateTimeGroup dateTimeGroup = new global::DevComponents.WpfEditors.Primitives.DateTimeGroup();
					editorGroup.Items.Add(dateTimeGroup);
					stack.Push(editorGroup);
					editorGroup = dateTimeGroup;
					flag = true;
					num = (short)617807895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1194:
					num = (short)1059586080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_161D:
					num = (short)28966922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165A:
					if (flag4)
					{
						num = (short)1423114295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_176A:
					num = (short)1942683698;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_22F:
				this.a.Items.Clear();
				base.UpdateLockUpdateCheckBox();
				num = (short)1006436427;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0001CF80 File Offset: 0x0001B180
		private global::System.Windows.Controls.Label a()
		{
			int a_ = 3;
			short num = (short)1270052712;
			short num2 = num;
			num = (short)1104443240;
			switch (num2 == num)
			{
			}
			num = (short)1737162752;
			if (num != 0)
			{
			}
			num = (short)1563426816;
			short num3 = num;
			num = (short)1298399233;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Label label = new global::System.Windows.Controls.Label();
			label.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
			label.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
			label.Padding = default(global::System.Windows.Thickness);
			label.Margin = default(global::System.Windows.Thickness);
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("雏뷑ꛓ돕뿗꣙돛ꯝ軟蛡", a_));
			binding.Source = this;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			label.SetBinding(global::System.Windows.Controls.Control.ForegroundProperty, binding);
			return label;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0001D090 File Offset: 0x0001B290
		public override string ToString()
		{
			if (this.Value != null)
			{
				short num;
				for (;;)
				{
					num = (short)1903951872;
					short num2 = num;
					num = (short)1837121802;
					short num3 = num;
					num = (short)720781578;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_74;
					}
				}
				IL_74:
				num = (short)1678966784;
				if (num != 0)
				{
				}
				num = (short)1939341313;
				if (num != 0)
				{
				}
				return this.Value.Value.ToString();
			}
			return string.Empty;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001D16C File Offset: 0x0001B36C
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)196294285;
			short num2 = num;
			num = (short)1781413517;
			switch (num2 == num)
			{
			}
			num = (short)1258815488;
			if (num != 0)
			{
			}
			num = (short)805437440;
			short num3 = num;
			num = (short)1595867137;
			if (num != 0)
			{
			}
			base.OnIsKeyboardFocusWithinChanged(e);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0001D21C File Offset: 0x0001B41C
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)917962757;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)912374405;
					short num3 = num;
					num = (short)7322245;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_209;
					default:
						num = (short)1216806912;
						if (num != 0)
						{
						}
						this.d.ClosePopup();
						num = (short)1590034446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (this.d != null)
					{
						goto IL_209;
					}
					goto IL_225;
				case 2:
					num = (short)512294913;
					if (num != 0)
					{
					}
					if (this.d.IsPopupOpen)
					{
						num = (short)560201736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32F;
				case 3:
					goto IL_119;
				case 4:
					if ((e.SystemKey & global::System.Windows.Input.Key.Down) == global::System.Windows.Input.Key.Down)
					{
						num = (short)543883281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32F;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 6:
					this.d.OpenPopup();
					num = (short)1120337923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (e.Key == global::System.Windows.Input.Key.Escape)
					{
						num = (short)882245632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32F;
				case 8:
					num = (short)1652883463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)29032450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)697368587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!this.d.IsPopupOpen)
					{
						num = (short)1137573901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_225;
				case 12:
					if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Alt)
					{
						num = (short)502792198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32F;
				case 13:
					num = (short)476905476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_289;
				case 15:
					if (this.d != null)
					{
						num = (short)508952585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32F;
				case 16:
					num = (short)927203329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)862912524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6C:
				if (this.ShowDropDown)
				{
					num = (short)1713963024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_225;
				IL_209:
				num = (short)163512330;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_225:
				num = (short)1851064335;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_119:
			goto IL_32F;
			IL_289:
			num = (short)88604672;
			short num4 = num;
			IL_32F:
			base.OnKeyDown(e);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0001D560 File Offset: 0x0001B760
		protected override string GetInputStringValue()
		{
			short num = (short)290062336;
			short num2 = num;
			num = (short)1554973803;
			short num3 = num;
			num = (short)1692927083;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1222705152;
				if (num != 0)
				{
				}
				if (this.Value == null)
				{
					num = (short)999489537;
					if (num != 0)
					{
					}
					return "";
				}
				break;
			}
			return this.ToString();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0001D624 File Offset: 0x0001B824
		protected override void OnClear()
		{
			short num = (short)1374364040;
			short num2 = num;
			num = (short)2132287880;
			switch (num2 == num)
			{
			}
			num = (short)927596545;
			if (num != 0)
			{
			}
			num = (short)1045299200;
			if (num != 0)
			{
			}
			num = (short)1473445888;
			short num3 = num;
			this.ResetValue();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
		protected override void OnClipboardPaste()
		{
			short num = (short)2056257537;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1980240039;
				short num3 = num;
				num = (short)953618599;
				global::System.DateTime minValue;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)504365056;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_D0;
					case 1:
					{
						num = (short)1743912960;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					}
					case 2:
						goto IL_F3;
					case 3:
						if (global::System.DateTime.TryParse(global::System.Windows.Clipboard.GetText(), out minValue))
						{
							num = (short)47251456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A;
					case 4:
						minValue = global::System.DateTime.MinValue;
						num = (short)1259077635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AD:
					if (global::System.Windows.Clipboard.ContainsText())
					{
						num = (short)91619332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13A;
				}
				IL_D0:
				this.Value = new global::System.DateTime?(minValue);
				num = (short)984285186;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F3:
			IL_13A:
			num = (short)106037249;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0001D840 File Offset: 0x0001BA40
		internal static void a(string A_0)
		{
			int a_ = 10;
			short num = (short)1714421760;
			short num2 = num;
			num = (short)33005756;
			short num3 = num;
			num = (short)419406012;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)217448448;
				if (num != 0)
				{
				}
				if (A_0 == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏖飘鿚틠폢헤ꏦ꣨\ud9ea\udfec", a_))
				{
					num = (short)186777601;
					if (num != 0)
					{
					}
					global::DevComponents.WpfEditors.DateTimeInput.e = true;
					return;
				}
				break;
			}
			global::DevComponents.WpfEditors.DateTimeInput.e = false;
		}

		// Token: 0x04000052 RID: 82
		private new global::DevComponents.WpfEditors.Primitives.DateTimeGroup a;

		// Token: 0x04000053 RID: 83
		private new global::DevComponents.WpfEditors.Primitives.EditorUpDownButton b;

		// Token: 0x04000054 RID: 84
		private new global::DevComponents.WpfEditors.Primitives.EditorClearButton c;

		// Token: 0x04000055 RID: 85
		private new global::DevComponents.WpfEditors.Primitives.EditorCalendarDropDownButton d;

		// Token: 0x04000056 RID: 86
		public static readonly global::System.Windows.DependencyProperty AutoAdvanceProperty;

		// Token: 0x04000057 RID: 87
		public static readonly global::System.Windows.DependencyProperty DefaultInputValuesProperty;

		// Token: 0x04000058 RID: 88
		public static readonly global::System.Windows.DependencyProperty ShowDropDownProperty;

		// Token: 0x04000059 RID: 89
		public static readonly global::System.Windows.DependencyProperty ShowUpDownProperty;

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Windows.DependencyProperty ShowClearButtonProperty;

		// Token: 0x0400005C RID: 92
		public static readonly global::System.Windows.DependencyProperty AllowEmptyStateProperty;

		// Token: 0x0400005D RID: 93
		public static readonly global::System.Windows.DependencyProperty ValueProperty;

		// Token: 0x0400005E RID: 94
		public static readonly global::System.Windows.DependencyProperty CustomFormatProperty;

		// Token: 0x0400005F RID: 95
		public static readonly global::System.Windows.DependencyProperty FormatProperty;

		// Token: 0x04000060 RID: 96
		public static readonly global::System.Windows.DependencyProperty MinDateProperty;

		// Token: 0x04000061 RID: 97
		public static readonly global::System.Windows.DependencyProperty MaxDateProperty;

		// Token: 0x04000062 RID: 98
		public new static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty;

		// Token: 0x04000063 RID: 99
		public static readonly global::System.Windows.DependencyProperty SelectNextInputCharactersProperty;

		// Token: 0x04000064 RID: 100
		public static readonly global::System.Windows.DependencyProperty CalendarDimensionsProperty;

		// Token: 0x04000065 RID: 101
		public static readonly global::System.Windows.DependencyProperty TodayButtonVisibilityProperty;

		// Token: 0x04000066 RID: 102
		public static readonly global::System.Windows.DependencyProperty ClearButtonVisibilityProperty;

		// Token: 0x04000067 RID: 103
		public static readonly global::System.Windows.DependencyProperty TodayButtonContentProperty;

		// Token: 0x04000068 RID: 104
		public static readonly global::System.Windows.DependencyProperty ClearButtonContentProperty;

		// Token: 0x04000069 RID: 105
		public static readonly global::System.Windows.DependencyProperty WeekOfYearRuleProperty;

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Windows.DependencyProperty ShowWeekNumbersProperty;

		// Token: 0x0400006B RID: 107
		public static readonly global::System.Windows.DependencyProperty ShowTodayMarkerProperty;

		// Token: 0x0400006C RID: 108
		public static readonly global::System.Windows.DependencyProperty FirstDayOfWeekProperty;

		// Token: 0x0400006D RID: 109
		public static readonly global::System.Windows.DependencyProperty WeekendDaysSelectableProperty;

		// Token: 0x0400006E RID: 110
		internal static bool e;
	}
}
