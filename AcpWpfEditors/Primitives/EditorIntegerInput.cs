using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000066 RID: 102
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EditorIntegerInput : global::DevComponents.WpfEditors.Primitives.EditorNumericInput
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0008BC44 File Offset: 0x00089E44
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x0008BCFC File Offset: 0x00089EFC
		[global::System.ComponentModel.Category("Behavior")]
		public string DisplayFormat
		{
			get
			{
				short num = (short)1285103759;
				short num2 = num;
				num = (short)53682319;
				switch (num2 == num)
				{
				}
				num = (short)1593573377;
				if (num != 0)
				{
				}
				num = (short)722468864;
				short num3 = num;
				num = (short)159121408;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.DisplayFormatProperty);
			}
			set
			{
				short num = (short)1997264058;
				short num2 = num;
				num = (short)613012666;
				switch (num2 == num)
				{
				}
				num = (short)1640431616;
				if (num != 0)
				{
				}
				num = (short)659292160;
				short num3 = num;
				num = (short)1090977793;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.DisplayFormatProperty, value);
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0008BDB4 File Offset: 0x00089FB4
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1219559425;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			int num3;
			global::DevComponents.WpfEditors.Primitives.EditorIntegerInput editorIntegerInput;
			for (;;)
			{
				IL_32:
				num = (short)1733230592;
				short num2 = num;
				switch (num3)
				{
				case 0:
					editorIntegerInput.OnMinValueChanged((int)A_1.OldValue, (int)A_1.NewValue);
					num = (short)795541505;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)433466686;
					short num4 = num;
					num = (short)244198718;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)413990912;
						if (num != 0)
						{
						}
						if (editorIntegerInput == null)
						{
							return;
						}
						break;
					}
					num = (short)1869545472;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_6D;
			}
			return;
			IL_6D:
			editorIntegerInput = (A_0 as global::DevComponents.WpfEditors.Primitives.EditorIntegerInput);
			num = (short)109445122;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0008BEF0 File Offset: 0x0008A0F0
		protected virtual void OnMinValueChanged(int oldValue, int newValue)
		{
			short num = (short)1398603777;
			if (num != 0)
			{
			}
			num = (short)1376976903;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int? value;
				switch (num2)
				{
				case 0:
					if (base.IsKeyboardFocused)
					{
						num = (short)589692942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.c(new int?(newValue));
					num = (short)862257154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_298;
				case 2:
					return;
				case 3:
					goto IL_271;
				case 4:
					goto IL_298;
				case 5:
					if (this.IsEmpty)
					{
						num = (short)1292697613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					if (!base.AllowEmptyState)
					{
						num = (short)1962409996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					continue;
				case 8:
					if (value.GetValueOrDefault() < newValue & value != null)
					{
						num = (short)475791371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					base.AllowsNegativeValue = false;
					num = (short)1267269636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)566820869;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)1139146755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_AB;
				case 13:
					num = (short)854786054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_E3;
				}
				IL_8A:
				if (newValue >= 0)
				{
					num = (short)347734025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2114762814;
				short num3 = num;
				num = (short)724088894;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_271;
				default:
				{
					num = (short)1578696704;
					short num4 = num;
					num = (short)2119303168;
					if (num != 0)
					{
					}
					base.AllowsNegativeValue = true;
					num = (short)1964769281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_AB:
				num = (short)1093402624;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_271:
				if (this.IsEmpty)
				{
					num = (short)1158938634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_AB;
				IL_298:
				value = this.Value;
				num = (short)981729288;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E3:
			this.a(this.a(new int?(newValue)));
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0008C1E8 File Offset: 0x0008A3E8
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x0008C2A4 File Offset: 0x0008A4A4
		public int MinValue
		{
			get
			{
				short num = (short)1659962576;
				short num2 = num;
				num = (short)432014544;
				switch (num2 == num)
				{
				}
				num = (short)1584529408;
				if (num != 0)
				{
				}
				num = (short)1203372032;
				short num3 = num;
				num = (short)865796097;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.MinValueProperty);
			}
			set
			{
				short num = (short)548655682;
				short num2 = num;
				num = (short)627298882;
				switch (num2 == num)
				{
				}
				num = (short)2145320961;
				if (num != 0)
				{
				}
				num = (short)1750335488;
				short num3 = num;
				num = (short)1769799680;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.MinValueProperty, value);
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0008C360 File Offset: 0x0008A560
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.EditorIntegerInput editorIntegerInput;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					editorIntegerInput.OnMaxValueChanged((int)A_1.OldValue, (int)A_1.NewValue);
					num2 = (short)1143930881;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					num2 = (short)956929067;
					short num3 = num2;
					num2 = (short)875336747;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)615710720;
						if (num2 != 0)
						{
						}
						num2 = (short)1327759361;
						if (num2 != 0)
						{
						}
						if (editorIntegerInput == null)
						{
							return;
						}
						break;
					}
					num2 = (short)169345024;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)262078464;
			short num4 = num2;
			editorIntegerInput = (A_0 as global::DevComponents.WpfEditors.Primitives.EditorIntegerInput);
			num2 = (short)438370306;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0008C498 File Offset: 0x0008A698
		protected virtual void OnMaxValueChanged(int oldValue, int newValue)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			int? value;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_142;
				case 1:
					num2 = (short)1975975938;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.IsEmpty)
					{
						num2 = (short)391643142;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (value.GetValueOrDefault() > newValue & value != null)
					{
						num2 = (short)567869445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					if (base.IsKeyboardFocused)
					{
						num2 = (short)630194183;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.c(new int?(newValue));
					num2 = (short)158859272;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1736900608;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)558235658;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)160877079;
					short num3 = num2;
					num2 = (short)588237335;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_142;
					default:
						goto IL_23E;
					}
					break;
				}
				case 8:
					goto IL_189;
				case 9:
					num2 = (short)19136513;
					if (num2 != 0)
					{
					}
					goto IL_1CD;
				case 10:
				{
					num2 = (short)1259077632;
					short num4 = num2;
					if (!base.AllowEmptyState)
					{
						num2 = (short)1332674569;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_3C;
				IL_142:
				if (this.IsEmpty)
				{
					num2 = (short)315490305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_1CD:
				num2 = (short)475201540;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_189:
			return;
			IL_23E:
			num2 = (short)1328873472;
			if (num2 != 0)
			{
			}
			this.a(this.a(new int?(newValue)));
			return;
			IL_3C:
			value = this.Value;
			num2 = (short)1543962627;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0008C700 File Offset: 0x0008A900
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x0008C7BC File Offset: 0x0008A9BC
		public int MaxValue
		{
			get
			{
				short num = (short)1980138760;
				short num2 = num;
				num = (short)1146324232;
				switch (num2 == num)
				{
				}
				num = (short)703660033;
				if (num != 0)
				{
				}
				num = (short)531365888;
				short num3 = num;
				num = (short)1056374784;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.MaxValueProperty);
			}
			set
			{
				short num = (short)1486250587;
				short num2 = num;
				num = (short)1521377883;
				switch (num2 == num)
				{
				}
				num = (short)1276968960;
				if (num != 0)
				{
				}
				num = (short)2001928192;
				short num3 = num;
				num = (short)1215561729;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.MaxValueProperty, value);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0008C878 File Offset: 0x0008AA78
		private static object a(global::System.Windows.DependencyObject A_0, object A_1)
		{
			short num = (short)745833375;
			short num2 = num;
			num = (short)1300792223;
			switch (num2 == num)
			{
			}
			num = (short)2009530369;
			if (num != 0)
			{
			}
			num = (short)18939904;
			short num3 = num;
			num = (short)1173618688;
			if (num != 0)
			{
			}
			return (A_0 as global::DevComponents.WpfEditors.Primitives.EditorIntegerInput).OnCoerceValue((int?)A_1);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0008C938 File Offset: 0x0008AB38
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_6B;
			}
			short num;
			int num3;
			global::DevComponents.WpfEditors.Primitives.EditorIntegerInput editorIntegerInput;
			for (;;)
			{
				IL_0A:
				num = (short)1403715585;
				if (num != 0)
				{
				}
				num = (short)441188352;
				short num2 = num;
				switch (num3)
				{
				case 0:
					editorIntegerInput.OnValueChanged((int?)A_1.OldValue, (int?)A_1.NewValue);
					num = (short)1177681921;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)671524848;
					short num4 = num;
					num = (short)2005182448;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)963051520;
						if (num != 0)
						{
						}
						if (editorIntegerInput == null)
						{
							return;
						}
						break;
					}
					num = (short)1714356224;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_6B;
			}
			return;
			IL_6B:
			editorIntegerInput = (A_0 as global::DevComponents.WpfEditors.Primitives.EditorIntegerInput);
			num = (short)306446338;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0008CA6C File Offset: 0x0008AC6C
		protected virtual int? OnCoerceValue(int? value)
		{
			short num = (short)2122252291;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int? num4;
				int num5;
				switch (num2)
				{
				case 0:
					goto IL_134;
				case 1:
					value = new int?(this.MinValue);
					num = (short)2045378567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					value = new int?(0);
					num = (short)250740740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 4:
				{
					num = (short)1957429248;
					short num3 = num;
					goto IL_113;
				}
				case 5:
					num = (short)1740111880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return value;
				case 7:
					return value;
				case 8:
					if (value == null)
					{
						num = (short)1666252802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_113;
				case 9:
					value = new int?(this.MaxValue);
					num = (short)780337158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (num4.GetValueOrDefault() > num5 & num4 != null)
					{
						num = (short)995622921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return value;
				}
				IL_52:
				num = (short)931198011;
				short num6 = num;
				num = (short)1538192443;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_134:
					num = (short)319356929;
					if (num != 0)
					{
					}
					if (num4.GetValueOrDefault() < num5 & num4 != null)
					{
						num = (short)95420417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4 = value;
					num5 = this.MaxValue;
					num = (short)1225916426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)431292416;
					if (num != 0)
					{
					}
					if (!base.AllowEmptyState)
					{
						num = (short)894763013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_113:
				num4 = value;
				num5 = this.MinValue;
				num = (short)1159069696;
				num2 = (int)((global::System.IntPtr)num);
			}
			return value;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0008CCDC File Offset: 0x0008AEDC
		protected virtual void OnValueChanged(int? oldValue, int? newValue)
		{
			short num = (short)1225654279;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_156;
				case 1:
					if (!base.IsEnabled)
					{
						num = (short)581566468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_84;
				case 3:
					return;
				case 4:
					base.InvalidateMeasure();
					num = (short)889585667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.TextInputComplete(false);
					num = (short)1345454082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (newValue == null)
					{
						num = (short)559153164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)178389000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 8:
					if (this.IsEmpty)
					{
						num = (short)1350959115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AC;
				case 9:
					num = (short)168624134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_AC;
				case 11:
				{
					num = (short)1669857280;
					short num3 = num;
					this.IsEmpty = false;
					num = (short)399245322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
				{
					num = (short)555089921;
					if (num != 0)
					{
					}
					this.IsEmpty = true;
					num = (short)518145641;
					short num4 = num;
					num = (short)1967343209;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1850081280;
						if (num != 0)
						{
						}
						num = (short)1359216653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					goto IL_84;
				case 14:
					if (base.IsKeyboardFocused)
					{
						num = (short)907411461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_84;
				}
				IL_60:
				if (!this.a)
				{
					num = (short)2067922953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_156;
				IL_84:
				base.ResetInputStack();
				this.OnValueChanged();
				num = (short)60162048;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC:
				num = (short)1199308814;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_156:
				num = (short)504168449;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0008CFC0 File Offset: 0x0008B1C0
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x0008D078 File Offset: 0x0008B278
		public int? Value
		{
			get
			{
				short num = (short)1205106722;
				short num2 = num;
				num = (short)1017083938;
				switch (num2 == num)
				{
				}
				num = (short)279379969;
				if (num != 0)
				{
				}
				num = (short)1732509696;
				short num3 = num;
				num = (short)1284112384;
				if (num != 0)
				{
				}
				return (int?)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.ValueProperty);
			}
			set
			{
				short num = (short)1563466526;
				short num2 = num;
				num = (short)1212586782;
				switch (num2 == num)
				{
				}
				num = (short)611647489;
				if (num != 0)
				{
				}
				num = (short)793182208;
				short num3 = num;
				num = (short)318373888;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.ValueProperty, value);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0008D130 File Offset: 0x0008B330
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x0008D1E8 File Offset: 0x0008B3E8
		public int Increment
		{
			get
			{
				short num = (short)1085169583;
				short num2 = num;
				num = (short)208166831;
				switch (num2 == num)
				{
				}
				num = (short)1766457344;
				if (num != 0)
				{
				}
				num = (short)600440832;
				short num3 = num;
				num = (short)1757937665;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.IncrementProperty);
			}
			set
			{
				short num = (short)778425888;
				short num2 = num;
				num = (short)425645600;
				switch (num2 == num)
				{
				}
				num = (short)1966211073;
				if (num != 0)
				{
				}
				num = (short)1101398016;
				short num3 = num;
				num = (short)2024603648;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.IncrementProperty, value);
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0008D2A4 File Offset: 0x0008B4A4
		protected override string GetInputStringValue()
		{
			short num = (short)1964310530;
			int num2 = (int)((global::System.IntPtr)num);
			int? value;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E5;
				case 1:
				{
					num = (short)1359478784;
					short num3 = num;
					value = this.Value;
					num = (short)1280770051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
					if (value != null)
					{
						num = (short)249138759;
						short num4 = num;
						num = (short)1757580871;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_11F;
						}
					}
					num = (short)1266352129;
					if (num != 0)
					{
					}
					num = (short)874774528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_35:
				if (this.IsEmpty)
				{
					break;
				}
				num = (short)917307393;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_53:
			return "";
			IL_E5:
			goto IL_53;
			IL_11F:
			num = (short)1051394048;
			if (num != 0)
			{
			}
			value = this.Value;
			return value.Value.ToString();
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0008D3FC File Offset: 0x0008B5FC
		protected override void OnInputStackChanged()
		{
			int a_ = 19;
			short num = (short)634126343;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.IsEmpty = false;
					num = (short)239075333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_147;
				case 2:
					goto IL_110;
				case 3:
				{
					num = (short)30736384;
					short num3 = num;
					this.IsEmpty = true;
					num = (short)1543053868;
					short num4 = num;
					num = (short)1232085548;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_63;
					default:
						num = (short)1405616128;
						if (num != 0)
						{
						}
						num = (short)1413414914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (base.AllowEmptyState)
					{
						num = (short)585695235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.b(new int?(0), true);
					num = (short)652345350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("췟", a_))
					{
						num = (short)655622152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int value = int.Parse(base.InputStack);
					this.b(new int?(value), true);
					num = (short)342032385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_1C4;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 8:
					goto IL_19D;
				}
				goto IL_52;
				IL_63:
				num = (short)155844608;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_52:
				if (base.InputStack.Length > 0)
				{
					goto IL_63;
				}
				num = (short)827523076;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			IL_147:
			goto IL_23A;
			IL_19D:
			this.b(new int?(0), true);
			return;
			IL_1C4:
			num = (short)67436545;
			if (num != 0)
			{
			}
			IL_23A:
			base.OnInputStackChanged();
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0008D64C File Offset: 0x0008B84C
		protected override bool IsNumeric(string t)
		{
			short num = (short)742916100;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					if (t.Length == 1)
					{
						goto IL_16C;
					}
					goto IL_188;
				case 2:
					if (t[0] >= '0')
					{
						num = (short)1847197701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11D;
				case 3:
					num = (short)1124466690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					goto IL_119;
				}
				IL_3C:
				if (t.Length != 0)
				{
					num = (short)648609793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)672603619;
				short num3 = num;
				num = (short)876486115;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)460849153;
					if (num != 0)
					{
					}
					num = (short)1452539904;
					if (num != 0)
					{
					}
					num = (short)554696704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_16C:
				num = (short)1584660483;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_119:
			return t[0] <= '9';
			IL_11D:
			num = (short)338100224;
			short num4 = num;
			return false;
			IL_188:
			int num5 = 0;
			return this.a(t, out num5);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0008D7EC File Offset: 0x0008B9EC
		protected override void OnInputKeyAccepted()
		{
			short num = (short)1475018753;
			if (num != 0)
			{
			}
			num = (short)1027292542;
			short num2 = num;
			num = (short)1956396414;
			switch (num2 == num)
			{
			}
			num = (short)874577920;
			short num3 = num;
			num = (short)904396800;
			if (num != 0)
			{
			}
			this.a(true);
			base.OnInputKeyAccepted();
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0008D8A4 File Offset: 0x0008BAA4
		private void a(bool A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			int num3;
			int? value;
			int maxValue;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)83165190;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_20F;
				case 2:
					if (num3 > this.MaxValue)
					{
						num2 = (short)310444033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22F;
				case 3:
					goto IL_22D;
				case 4:
					num2 = (short)350093317;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (this.b(this.Value).Length < this.b(new int?(this.MinValue)).Length)
					{
						num2 = (short)1533280264;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20F;
				case 6:
				{
					num2 = (short)457793939;
					short num4 = num2;
					num2 = (short)1170497939;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_216;
					default:
						num2 = (short)1429143552;
						if (num2 != 0)
						{
						}
						num2 = (short)1833762817;
						if (num2 != 0)
						{
						}
						if (this.b(this.Value).Length >= this.b(new int?(this.MaxValue)).Length)
						{
							num2 = (short)1904017412;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_97;
					}
					break;
				}
				case 7:
					if (!(value.GetValueOrDefault() == maxValue & value != null))
					{
						num2 = (short)1733033984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20F;
				case 8:
					goto IL_97;
				}
				goto IL_34;
				IL_97:
				num2 = (short)1933574146;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_216:
				num2 = (short)787808259;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_20F:
				this.TextInputComplete(A_0);
				goto IL_216;
			}
			IL_22D:
			IL_22F:
			num2 = (short)852492288;
			short num5 = num2;
			return;
			IL_34:
			num3 = this.d(this.Value);
			value = this.Value;
			maxValue = this.MaxValue;
			num2 = (short)959774727;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0008DB0C File Offset: 0x0008BD0C
		private int d(int? A_0)
		{
			int a_ = 7;
			short num = (short)1532821504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				string a_2;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						num = (short)1437663238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11D;
					case 2:
						if (A_0 != null)
						{
							num = (short)2002190336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1895235592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_11D;
					case 4:
						goto IL_11D;
					case 5:
						a_2 = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						num = (short)1016463361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_24E;
					case 7:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)1925316618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_2 = this.b(new int?(A_0.Value)) + global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						num = (short)420610052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_204;
					case 9:
					{
						if (A_0 != null)
						{
							int? num3 = A_0;
							int num4 = 0;
							num = (short)1321861127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1092394929;
						short num5 = num;
						num = (short)2033426353;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_24E;
						default:
						{
							num = (short)1762394112;
							short num6 = num;
							num = (short)1292632064;
							if (num != 0)
							{
							}
							num = (short)1251016709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 10:
						num = (short)2119827457;
						if (num != 0)
						{
						}
						a_2 = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						num = (short)131792899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64;
					IL_11D:
					num = (short)1034223618;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_204:
				int num7 = 0;
				goto IL_2A9;
				IL_24E:
				num7 = A_0.Value;
				IL_2A9:
				int result = num7;
				this.a(a_2, out result);
				return result;
				IL_64:
				a_2 = "";
				num = (short)692584457;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0008DDD0 File Offset: 0x0008BFD0
		protected override void OnInputLostFocus()
		{
			short num = (short)961897761;
			short num2 = num;
			num = (short)636183841;
			switch (num2 == num)
			{
			}
			num = (short)890503169;
			if (num != 0)
			{
			}
			num = (short)2102853632;
			short num3 = num;
			num = (short)2083454976;
			if (num != 0)
			{
			}
			this.ValidateValue();
			base.OnInputLostFocus();
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0008DE88 File Offset: 0x0008C088
		protected virtual void ValidateValue()
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			int? value;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1536098310;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					this.Value = new int?(this.MaxValue);
					num2 = (short)2075131904;
					short num3 = num2;
					num2 = (short)1967128579;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (!this.IsEmpty)
					{
						num2 = (short)1006239745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
				{
					num2 = (short)573466174;
					short num4 = num2;
					num2 = (short)1476421182;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13D;
					default:
						goto IL_1B0;
					}
					break;
				}
				case 5:
					if (value.GetValueOrDefault() > num5 & value != null)
					{
						num2 = (short)112328712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					if (!this.IsEmpty)
					{
						goto IL_13D;
					}
					goto IL_C3;
				case 7:
					if (value.GetValueOrDefault() < num5 & value != null)
					{
						num2 = (short)395640832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C3;
				case 8:
					num2 = (short)517799938;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_C3:
				value = this.Value;
				num5 = this.MaxValue;
				num2 = (short)128843781;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_13D:
				num2 = (short)483786753;
				if (num2 != 0)
				{
				}
				num2 = (short)881262596;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1B0:
			num2 = (short)1548222464;
			if (num2 != 0)
			{
			}
			this.Value = new int?(this.MinValue);
			return;
			IL_34:
			value = this.Value;
			num5 = this.MinValue;
			num2 = (short)327417863;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0008E0C4 File Offset: 0x0008C2C4
		internal bool a(string A_0, out int A_1)
		{
			short num = (short)1110245377;
			if (num != 0)
			{
			}
			global::System.IFormatProvider formatProvider = global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().GetFormat(typeof(global::System.Globalization.NumberFormatInfo)) as global::System.IFormatProvider;
			if (formatProvider == null)
			{
				num = (short)1642316250;
				short num2 = num;
				num = (short)1009959386;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1445724160;
					if (num != 0)
					{
					}
					return int.TryParse(A_0, out A_1);
				}
			}
			num = (short)1495203840;
			short num3 = num;
			return int.TryParse(A_0, global::System.Globalization.NumberStyles.Number, formatProvider, out A_1);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0008E1A0 File Offset: 0x0008C3A0
		internal string b(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			int num2;
			short num3;
			string text;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_212;
				case 1:
					goto IL_AC;
				case 2:
					if (num2 >= A_0.Length)
					{
						num3 = (short)315555848;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)988151822;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
				{
					num3 = (short)886321934;
					short num4 = num3;
					num3 = (short)1213018894;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_82;
					default:
						num3 = (short)1628831744;
						if (num3 != 0)
						{
						}
						num3 = (short)1178075140;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 4:
					if (A_0[num2] > '9')
					{
						num3 = (short)402718720;
						short num5 = num3;
						num3 = (short)1333592070;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_AC;
				case 5:
					goto IL_212;
				case 6:
					goto IL_29B;
				case 7:
					if (num2 == 0)
					{
						num3 = (short)677380107;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_6E;
				case 8:
					return text;
				case 9:
					goto IL_147;
				case 10:
					goto IL_82;
				case 11:
					num3 = (short)1353580556;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
					num3 = (short)99155969;
					if (num3 != 0)
					{
					}
					if (A_0[num2] == '-')
					{
						num3 = (short)998440961;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_6E;
				case 13:
					goto IL_147;
				case 14:
					if (A_0[num2] >= '0')
					{
						num3 = (short)2065498115;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_29B;
				}
				goto IL_4C;
				IL_6E:
				num3 = (short)1134952458;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_82:
				if (text.Length <= 0)
				{
					num3 = (short)431226880;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				break;
				IL_AC:
				text += A_0[num2].ToString();
				num3 = (short)557842437;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_147:
				num3 = (short)1255800834;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_212:
				num2++;
				num3 = (short)1780940809;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_29B:
				num3 = (short)1052901383;
				num = (int)((global::System.IntPtr)num3);
			}
			return text;
			IL_4C:
			text = "";
			num2 = 0;
			num3 = (short)1441988621;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0008E484 File Offset: 0x0008C684
		protected override void OnAllowEmptyStateChanged(bool oldValue, bool newValue)
		{
			short num = (short)1485176833;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)86484199;
				short num3 = num;
				num = (short)1621861607;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1524301825;
					if (num != 0)
					{
					}
					num = (short)48431104;
					short num4 = num;
					num = (short)131072000;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_10C;
					case 1:
						goto IL_14;
					case 2:
						base.CoerceValue(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.ValueProperty);
						num = (short)1778319360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD;
				}
				}
				IL_14:
				switch (0)
				{
				case 0:
					IL_CD:
					if (newValue)
					{
						goto IL_10E;
					}
					num = (short)234356738;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10C:
			IL_10E:
			base.OnAllowEmptyStateChanged(oldValue, newValue);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0008E5A8 File Offset: 0x0008C7A8
		private void b(int? A_0, bool A_1)
		{
			short num = (short)1278111260;
			short num2 = num;
			num = (short)474770972;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)776208384;
				short num3 = num;
				break;
			}
			}
			num = (short)2005729280;
			if (num != 0)
			{
			}
			num = (short)1778909185;
			if (num != 0)
			{
			}
			this.a = true;
			try
			{
				num = (short)946733067;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int? value;
					int? num5;
					switch (num4)
					{
					case 0:
						goto IL_2BA;
					case 1:
						if (base.IsFocused)
						{
							num = (short)1150418949;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C8;
					case 2:
						goto IL_295;
					case 3:
						if (A_0.Value > this.MaxValue)
						{
							num = (short)919273476;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C8;
					case 4:
						goto IL_25A;
					case 5:
						base.InvalidateMeasure();
						base.InvalidateVisual();
						num = (short)294256650;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (A_0.Value >= this.MinValue)
						{
							num = (short)2052587529;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25A;
					case 7:
						this.OnValueChanged();
						num = (short)1346437122;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)434896902;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1628372995;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_258;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_FA;
						}
						continue;
					case 12:
					{
						bool flag = !(value.GetValueOrDefault() == num5.GetValueOrDefault() & value != null == (num5 != null)) || A_1;
						this.Value = A_0;
						if (flag)
						{
							num = (short)1506410503;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_295;
					}
					}
					IL_FA:
					if (A_0 != null)
					{
						num = (short)1331560456;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1C8:
					value = this.Value;
					num5 = A_0;
					num = (short)495910924;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_25A:
					num = (short)356581377;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_295:
					base.InvalidateMeasure();
					base.InvalidateVisual();
					num = (short)448987136;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_258:
				IL_2BA:;
			}
			finally
			{
				this.a = false;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0008E898 File Offset: 0x0008CA98
		private void c(int? A_0)
		{
			short num = (short)847966406;
			short num2 = num;
			num = (short)755429574;
			switch (num2 == num)
			{
			}
			num = (short)2006319104;
			if (num != 0)
			{
			}
			num = (short)970326016;
			short num3 = num;
			num = (short)1302790145;
			if (num != 0)
			{
			}
			this.b(A_0, false);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0008E94C File Offset: 0x0008CB4C
		protected override string GetMeasureString()
		{
			int a_ = 19;
			short num = (short)1395261440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_89;
				}
				string result;
				int? measureValue;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)1697513488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_199;
					}
					case 1:
						if (base.AllowEmptyState)
						{
							num = (short)1848311810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_322;
					case 2:
						result = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("듟", a_);
						num = (short)1776812042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1787428870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)122290189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("췟", a_))
						{
							num = (short)1292828689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_199;
					case 6:
					{
						int num5;
						if (num5 < this.MinValue)
						{
							num = (short)2043674625;
							if (num != 0)
							{
							}
							num = (short)387055627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 7:
						goto IL_2B0;
					case 8:
						if (base.IsFocused)
						{
							num = (short)1637154820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 9:
						goto IL_199;
					case 10:
						goto IL_199;
					case 11:
						goto IL_26B;
					case 12:
						if (this.IsEmpty)
						{
							num = (short)994377746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_322;
					case 13:
						if (!string.IsNullOrEmpty(base.InputStack))
						{
							num = (short)197066766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 14:
					{
						int num5 = 0;
						num = (short)1157627919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						num = (short)902283245;
						short num6 = num;
						num = (short)548716525;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B0;
						default:
						{
							num = (short)27918336;
							if (num != 0)
							{
							}
							int num5;
							if (this.a(base.InputStack, out num5))
							{
								num = (short)1897070592;
								short num7 = num;
								num = (short)1897988103;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						}
						break;
					}
					case 16:
						result = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("췟", a_);
						num = (short)1999372297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						int? num3 = measureValue;
						int num4 = 0;
						num = (short)34275328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)2039218177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						int num5;
						if (num5 <= this.MaxValue)
						{
							num = (short)2039283715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EF;
					}
					}
					goto IL_89;
					IL_199:
					num = (short)1231552520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B0:
					num = (short)1361248275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_322:
					num = (short)875036677;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_26B:
				IL_2EF:
				return base.InputStack;
				IL_89:
				measureValue = this.GetMeasureValue();
				result = this.a(measureValue, true);
				num = (short)1856372748;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0008ED60 File Offset: 0x0008CF60
		protected override string GetRenderString()
		{
			int a_ = 8;
			short num;
			int? renderValue;
			for (;;)
			{
				IL_09:
				num = (short)403243008;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							if (!string.IsNullOrEmpty(base.InputStack))
							{
								num = (short)818413569;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D1;
						case 1:
						{
							int num3 = 0;
							num = (short)1899954181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_))
							{
								num = (short)805175308;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F6;
						case 3:
						{
							int? num4;
							int num5;
							if (num4.GetValueOrDefault() == num5 & num4 != null)
							{
								num = (short)1089142793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F6;
						}
						case 4:
							if (this.IsEmpty)
							{
								num = (short)574685184;
								short num6 = num;
								num = (short)1657929738;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3AC;
						case 5:
						{
							int num3;
							if (this.a(base.InputStack, out num3))
							{
								num = (short)111280143;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D1;
						}
						case 6:
							num = (short)1657602048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							int num3;
							if (num3 < this.MinValue)
							{
								num = (short)1017446416;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D1;
						}
						case 8:
							if (base.IsFocused)
							{
								num = (short)1842151430;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D1;
						case 9:
							goto IL_365;
						case 10:
							num = (short)1601699851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (base.AllowEmptyState)
							{
								num = (short)921370641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3AC;
						case 12:
						{
							int? num4 = renderValue;
							int num5 = 0;
							num = (short)1631191043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							int num3;
							if (num3 <= this.MaxValue)
							{
								num = (short)2040856590;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_266;
						}
						case 14:
						{
							num = (short)80227606;
							short num7 = num;
							num = (short)782576918;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)2098987008;
								if (num != 0)
								{
								}
								num = (short)1869414407;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 15:
							num = (short)2114584589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_3A7;
						case 17:
							goto IL_1AA;
						}
						break;
						IL_D1:
						num = (short)1561067522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F6:
						num = (short)1495203844;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_80:
					renderValue = this.GetRenderValue();
					num = (short)2068578312;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
			}
			IL_1AA:
			return "";
			IL_266:
			num = (short)1173094401;
			if (num != 0)
			{
			}
			return base.InputStack;
			IL_365:
			return global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
			IL_3A7:
			goto IL_266;
			IL_3AC:
			return this.a(renderValue, true);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0008F124 File Offset: 0x0008D324
		protected virtual int? GetRenderValue()
		{
			short num = (short)1958871040;
			short num2 = num;
			num = (short)2070650490;
			short num3 = num;
			num = (short)1297456762;
			switch (num3 == num)
			{
			}
			num = (short)1968963585;
			if (num != 0)
			{
			}
			num = (short)1260191744;
			if (num != 0)
			{
			}
			return this.Value;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0008F1D4 File Offset: 0x0008D3D4
		protected virtual int? GetMeasureValue()
		{
			short num = (short)72482816;
			short num2 = num;
			num = (short)1356822502;
			short num3 = num;
			num = (short)1721006054;
			switch (num3 == num)
			{
			}
			num = (short)73465856;
			if (num != 0)
			{
			}
			num = (short)410386433;
			if (num != 0)
			{
			}
			return this.Value;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0008F284 File Offset: 0x0008D484
		protected override bool NegateValue()
		{
			short num = (short)1851326469;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (num3 < this.MinValue)
					{
						num = (short)1459421186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 1:
				{
					num = (short)670204670;
					short num4 = num;
					num = (short)1518371582;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EC;
					default:
					{
						num = (short)954859520;
						if (num != 0)
						{
						}
						num = (short)291504128;
						short num5 = num;
						int? value;
						if (value != null)
						{
							num = (short)1201864712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					break;
				}
				case 2:
					num3 = this.MinValue;
					goto IL_EC;
				case 3:
					num = (short)1228144647;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_A9;
				case 5:
					num = (short)723124225;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_83;
					}
					continue;
				case 6:
				{
					int? value = this.Value;
					num3 = -value.Value;
					num = (short)1163460608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (this.MaxValue >= 0)
					{
						num = (short)9633798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
				{
					int? value = this.Value;
					int num6 = 0;
					num = (short)1721171980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (num3 > this.MaxValue)
					{
						num = (short)2752522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15B;
				case 10:
					num3 = this.MaxValue;
					num = (short)1971716107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_24C;
				case 12:
				{
					int? value;
					int num6;
					if (!(value.GetValueOrDefault() == num6 & value != null))
					{
						num = (short)1566900227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 13:
				{
					int? value = this.Value;
					num = (short)1726808065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_83:
				if (!this.IsEmpty)
				{
					num = (short)903479309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_A9:
				num = (short)191561737;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC:
				num = (short)397672452;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_15B:
			this.a(this.a(new int?(num3)));
			return true;
			IL_24C:
			goto IL_15B;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0008F570 File Offset: 0x0008D770
		protected override void ResetValue()
		{
			int num;
			short num2;
			int? num3;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					int? num4;
					int maxValue;
					switch (num)
					{
					case 0:
						if (!base.AllowEmptyState)
						{
							num2 = (short)796327943;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1AC;
					case 1:
						goto IL_1AC;
					case 2:
						num3 = new int?(this.MinValue);
						num2 = (short)1215561734;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num3 = new int?(this.MaxValue);
						num2 = (short)2129723400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
					{
						if (!(num4.GetValueOrDefault() > maxValue & num4 != null))
						{
							goto IL_223;
						}
						num2 = (short)1066104495;
						short num5 = num2;
						num2 = (short)1479636655;
						switch ((num5 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C;
						default:
							num2 = (short)1176109056;
							if (num2 != 0)
							{
							}
							num2 = (short)769589251;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 5:
					{
						int minValue = this.MinValue;
						num4 = num3;
						if (minValue > num4.GetValueOrDefault() & num4 != null)
						{
							num2 = (short)1371078658;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_9D;
					}
					case 6:
						goto IL_9D;
					case 7:
					{
						num2 = (short)418316288;
						short num6 = num2;
						num3 = new int?(0);
						num2 = (short)323944449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 8:
						goto IL_1AA;
					}
					goto IL_34;
					IL_9D:
					num4 = num3;
					maxValue = this.MaxValue;
					num2 = (short)920977412;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1AC:
					num2 = (short)2049966081;
					if (num2 != 0)
					{
					}
					num2 = (short)496566277;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1AA:
				IL_223:
				this.c(num3);
				base.InvalidateMeasure();
				base.InvalidateVisual();
				return;
			}
			IL_34:
			num3 = null;
			IL_3C:
			num2 = (short)1188560896;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0008F7B4 File Offset: 0x0008D9B4
		private void a(string A_0)
		{
			short num = (short)330891264;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num3;
			bool flag;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					goto IL_1F8;
				case 1:
					this.a = true;
					flag = true;
					num = (short)1871511552;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!this.a)
					{
						num = (short)1647509505;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F8;
				case 3:
					goto IL_AB;
					try
					{
						for (;;)
						{
							IL_AB:
							num = (short)1443823618;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_18C;
								case 1:
									base.SetInputPosition(base.InputStack.Length);
									num = (short)1737031683;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_DF;
									}
									continue;
								case 3:
									goto IL_127;
								}
								IL_DF:
								if (this.SetInputStack(A_0))
								{
									num = (short)1898905601;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_127:
								num = (short)1055937817;
								short num4 = num;
								num = (short)1088115993;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_AB;
								default:
									num = (short)537395200;
									if (num != 0)
									{
									}
									num = (short)1418657792;
									num3 = (int)((global::System.IntPtr)num);
									break;
								}
							}
						}
						IL_18C:
						return;
					}
					finally
					{
						num = (short)2086666241;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								this.a = false;
								num = (short)1742864386;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1C1;
								}
								continue;
							case 2:
								goto IL_1F5;
							}
							IL_1C1:
							if (!flag)
							{
								break;
							}
							num = (short)884342784;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1F5:;
					}
					goto IL_1F8;
				}
				goto IL_48;
				IL_1F8:
				num = (short)1716518915;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_48:
			flag = false;
			num = (short)248446977;
			if (num != 0)
			{
			}
			num = (short)175898626;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0008FA08 File Offset: 0x0008DC08
		private string b(int? A_0)
		{
			short num = (short)846650300;
			short num2 = num;
			num = (short)588635068;
			switch (num2 == num)
			{
			default:
			{
				num = (short)731578368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)191365121;
			if (num != 0)
			{
			}
			num = (short)914423808;
			if (num != 0)
			{
			}
			return this.a(A_0, false);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0008FAB4 File Offset: 0x0008DCB4
		private string a(int? A_0, bool A_1)
		{
			short num = (short)214181854;
			short num2 = num;
			num = (short)530720734;
			switch (num2 == num)
			{
			default:
			{
				num = (short)894500864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1573126144;
			if (num != 0)
			{
			}
			num = (short)705691649;
			if (num != 0)
			{
			}
			return this.a(A_0, A_1, false);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0008FB64 File Offset: 0x0008DD64
		private string a(int? A_0, bool A_1, bool A_2)
		{
			short num = (short)522321920;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.IFormatProvider formatProvider;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 1:
					if (A_1)
					{
						num = (short)1378025472;
						short num3 = num;
						num = (short)443547650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 2:
					num = (short)1242824707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!base.IsKeyboardFocused)
					{
						num = (short)1975255048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 4:
					goto IL_CC;
				case 5:
					if (formatProvider != null)
					{
						num = (short)699334662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CD;
				case 6:
					goto IL_19D;
				case 7:
					num = (short)893452289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_D9;
				case 9:
					goto IL_12F;
				case 10:
					num = (short)1537212427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)2072838145;
					if (num != 0)
					{
					}
					if (this.DisplayFormat.Length == 0)
					{
						num = (short)1813839885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					formatProvider = (global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().GetFormat(typeof(global::System.Globalization.NumberFormatInfo)) as global::System.IFormatProvider);
					num = (short)1107034117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (this.DisplayFormat != null)
					{
						num = (short)980418570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 13:
					goto IL_20D;
				}
				IL_5E:
				if (A_0 != null)
				{
					num = (short)2091122697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)888531785;
				short num4 = num;
				num = (short)2055334729;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12F;
				default:
					num = (short)401604608;
					if (num != 0)
					{
					}
					num = (short)1292500996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D9:
				num = (short)509870092;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_12F:
				if (A_2)
				{
					goto IL_D9;
				}
				num = (short)888078343;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CC:
			return "";
			IL_D1:
			return this.a(A_0);
			IL_19D:
			return A_0.Value.ToString(this.DisplayFormat, formatProvider);
			IL_20D:
			goto IL_D1;
			IL_2CD:
			return A_0.Value.ToString(this.DisplayFormat);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0008FE54 File Offset: 0x0008E054
		private string a(int? A_0)
		{
			short num = (short)49554209;
			short num2 = num;
			num = (short)1122444065;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)657391616;
				if (num != 0)
				{
				}
				num = (short)724303874;
				int num3 = (int)((global::System.IntPtr)num);
				global::System.IFormatProvider formatProvider;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_14D;
					case 1:
						goto IL_9F;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 3:
						num = (short)1516240897;
						if (num != 0)
						{
						}
						if (formatProvider != null)
						{
							num = (short)1956249600;
							short num4 = num;
							num = (short)2108620800;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_158;
					}
					IL_81:
					if (A_0 == null)
					{
						num = (short)478740481;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						formatProvider = (global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().GetFormat(typeof(global::System.Globalization.NumberFormatInfo)) as global::System.IFormatProvider);
						num = (short)1975910403;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_9F:
				break;
				IL_14D:
				return A_0.Value.ToString(formatProvider);
				IL_158:
				return A_0.ToString();
			}
			}
			return "";
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0008FFC8 File Offset: 0x0008E1C8
		protected override bool ValidateNewInputStack(string s)
		{
			int a_ = 8;
			short num = (short)2104754176;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1198361937;
				short num3 = num;
				num = (short)1871613265;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)524025856;
					if (num != 0)
					{
					}
					int num4;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_B7;
						}
						continue;
					case 1:
						if (s == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_))
						{
							num = (short)1657864205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C1;
					case 2:
						goto IL_11A;
					case 3:
						if (num4 < this.MinValue)
						{
							num = (short)1410465799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						if (this.a(s, out num4))
						{
							num = (short)335216645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						num = (short)209715210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)379715585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1094516750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (base.AllowsNegativeValue)
						{
							num = (short)1629487113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C1;
					case 9:
						goto IL_199;
					case 10:
						if (num4 > this.MaxValue)
						{
							num = (short)2135883791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 11:
						goto IL_280;
					case 12:
						if (this.MaxValue < 0)
						{
							num = (short)1810563083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						num = (short)204931080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (this.MinValue < 0)
						{
							num = (short)1747779586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 15:
						num = (short)1214382092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B7:
					if (s.Length > 0)
					{
						break;
					}
					goto IL_305;
					IL_280:
					num = (short)376242179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C1:
					num4 = 0;
					num = (short)1770979332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				num = (short)1599733766;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11A:
			return false;
			IL_199:
			num = (short)1257111552;
			short num5 = num;
			num = (short)349372417;
			if (num != 0)
			{
			}
			return true;
			IL_305:
			return base.ValidateNewInputStack(s);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000902E4 File Offset: 0x0008E4E4
		public override void IncreaseValue()
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			int num;
			short num3;
			int? value;
			for (;;)
			{
				IL_0A:
				int num2;
				int num5;
				int maxValue;
				switch (num)
				{
				case 0:
					num2 = global::System.Math.Max(0, this.MinValue);
					num3 = (short)935264269;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					num3 = (short)2056519689;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
				{
					num3 = (short)876433585;
					short num4 = num3;
					num3 = (short)1017532593;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2BE;
					default:
						num3 = (short)1216020480;
						if (num3 != 0)
						{
						}
						num3 = (short)1893793807;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 3:
					goto IL_240;
				case 4:
					num3 = (short)1677918222;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
					goto IL_D7;
				case 6:
					if (value != null)
					{
						num3 = (short)1620705291;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)345112583;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					num5 = 0;
					goto IL_2AF;
				case 8:
					num2 = this.MaxValue;
					num3 = (short)2144272389;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					if (num2 > this.MaxValue)
					{
						num3 = (short)1500774408;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D7;
				case 10:
					if (num2 <= this.MaxValue)
					{
						num3 = (short)284098562;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_355;
				case 11:
					value = this.Value;
					num3 = (short)1075445776;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
					if (value.GetValueOrDefault() < maxValue & value != null)
					{
						num3 = (short)2018246657;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D7;
				case 13:
					goto IL_210;
				case 14:
					if (base.AllowEmptyState)
					{
						num3 = (short)522452992;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_210;
				case 15:
					if (this.IsEmpty)
					{
						num3 = (short)912588804;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_210;
				case 16:
					num5 = value.Value + this.Increment;
					goto IL_2AF;
				}
				goto IL_54;
				IL_D7:
				num3 = (short)1285881866;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_210:
				this.a(this.a(new int?(num2)));
				this.a(false);
				num3 = (short)610861059;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2BE:
				num3 = (short)1068433408;
				short num6 = num3;
				num3 = (short)1942880268;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2AF:
				num2 = num5;
				value = this.Value;
				maxValue = this.MaxValue;
				goto IL_2BE;
			}
			IL_240:
			num3 = (short)1770586113;
			if (num3 != 0)
			{
			}
			IL_355:
			base.IncreaseValue();
			return;
			IL_54:
			value = this.Value;
			num3 = (short)125108230;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0009064C File Offset: 0x0008E84C
		public override void DecreaseValue()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num3;
			int? value;
			for (;;)
			{
				IL_0A:
				int num2;
				int minValue;
				int num4;
				switch (num)
				{
				case 0:
					if (num2 >= this.MinValue)
					{
						num3 = (short)799866887;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_26F;
				case 1:
					if (value.GetValueOrDefault() > minValue & value != null)
					{
						num3 = (short)808386570;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_18B;
				case 2:
					num4 = 0;
					goto IL_216;
				case 3:
					if (num2 < this.MinValue)
					{
						num3 = (short)194510856;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_18B;
				case 4:
					num4 = value.Value - this.Increment;
					goto IL_216;
				case 5:
					goto IL_18B;
				case 6:
					if (value != null)
					{
						num3 = (short)199229449;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)762904578;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					this.a(this.a(new int?(num2)));
					this.a(false);
					num3 = (short)1806630923;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
					num2 = this.MinValue;
					num3 = (short)749273093;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					value = this.Value;
					goto IL_161;
				case 10:
					num3 = (short)1947467779;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
					goto IL_12F;
				}
				goto IL_40;
				IL_161:
				num3 = (short)784596996;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_18B:
				num3 = (short)1828843665;
				short num5 = num3;
				num3 = (short)1634726033;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_161;
				default:
					num3 = (short)1064108032;
					if (num3 != 0)
					{
					}
					num3 = (short)208207872;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				IL_216:
				num2 = num4;
				value = this.Value;
				minValue = this.MinValue;
				num3 = (short)1393754113;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_12F:
			num3 = (short)437256193;
			if (num3 != 0)
			{
			}
			IL_26F:
			num3 = (short)996081664;
			short num6 = num3;
			base.DecreaseValue();
			return;
			IL_40:
			value = this.Value;
			num3 = (short)865468422;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x000908F8 File Offset: 0x0008EAF8
		[global::System.ComponentModel.Browsable(false)]
		public virtual string Text
		{
			get
			{
				short num = (short)2115174401;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_104;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 2:
						num = (short)1724907521;
						if (num != 0)
						{
						}
						num = (short)1948909571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)743466426;
						short num3 = num;
						num = (short)1938187706;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_104;
						default:
							num = (short)920715264;
							if (num != 0)
							{
							}
							if (base.AllowEmptyState)
							{
								num = (short)2046689280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_132;
						}
						break;
					}
					}
					IL_34:
					if (!this.IsEmpty)
					{
						goto IL_132;
					}
					num = (short)1969881090;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_104:
				num = (short)1089077248;
				short num4 = num;
				return "";
				IL_132:
				return this.a(this.Value, true, true);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00090A48 File Offset: 0x0008EC48
		public override string ToString()
		{
			short num = (short)833382018;
			short num2 = num;
			num = (short)1324639874;
			switch (num2 == num)
			{
			}
			num = (short)1518927872;
			if (num != 0)
			{
			}
			num = (short)346947584;
			short num3 = num;
			num = (short)1910702081;
			if (num != 0)
			{
			}
			return this.Text;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00090B0C File Offset: 0x0008ED0C
		// Note: this type is marked as 'beforefieldinit'.
		static EditorIntegerInput()
		{
			int a_ = 16;
			short num = (short)1127591377;
			short num2 = num;
			num = (short)448572881;
			switch (num2 == num)
			{
			}
			num = (short)1686765569;
			if (num != 0)
			{
			}
			num = (short)1993932800;
			short num3 = num;
			num = (short)1154285568;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.DisplayFormatProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駜뛞鋠鏢觤蛦部귪苬鷮鳰鋲致", a_), typeof(string), typeof(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.MinValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郜뛞迠뗢蓤详鳨軪", a_), typeof(int), typeof(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput), new global::System.Windows.FrameworkPropertyMetadata(int.MinValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.c)));
			global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.MaxValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郜뻞駠뗢蓤详鳨軪", a_), typeof(int), typeof(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput), new global::System.Windows.FrameworkPropertyMetadata(int.MaxValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.b)));
			global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.ValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("诜뻞跠離胤", a_), typeof(int?), typeof(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.a), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.a)));
			global::DevComponents.WpfEditors.Primitives.EditorIntegerInput.IncrementProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铜뇞苠釢胤諦賨藪駬", a_), typeof(int), typeof(global::DevComponents.WpfEditors.Primitives.EditorIntegerInput), new global::System.Windows.FrameworkPropertyMetadata(1));
		}

		// Token: 0x040002D7 RID: 727
		private bool a;

		// Token: 0x040002D8 RID: 728
		public static readonly global::System.Windows.DependencyProperty DisplayFormatProperty;

		// Token: 0x040002D9 RID: 729
		public static readonly global::System.Windows.DependencyProperty MinValueProperty;

		// Token: 0x040002DA RID: 730
		public static readonly global::System.Windows.DependencyProperty MaxValueProperty;

		// Token: 0x040002DB RID: 731
		public static readonly global::System.Windows.DependencyProperty ValueProperty;

		// Token: 0x040002DC RID: 732
		public static readonly global::System.Windows.DependencyProperty IncrementProperty;
	}
}
