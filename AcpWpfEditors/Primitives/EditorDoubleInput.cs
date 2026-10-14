using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Input;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x0200005F RID: 95
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EditorDoubleInput : global::DevComponents.WpfEditors.Primitives.EditorNumericInput
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0007D188 File Offset: 0x0007B388
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0007D240 File Offset: 0x0007B440
		[global::System.ComponentModel.Category("Behavior")]
		public string DisplayFormat
		{
			get
			{
				short num = (short)896991232;
				short num2 = num;
				num = (short)1404614056;
				short num3 = num;
				num = (short)2115089832;
				switch (num3 == num)
				{
				}
				num = (short)758382592;
				if (num != 0)
				{
				}
				num = (short)1780547585;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.DisplayFormatProperty);
			}
			set
			{
				short num = (short)1813708800;
				short num2 = num;
				num = (short)509214721;
				if (num != 0)
				{
				}
				num = (short)825232777;
				short num3 = num;
				num = (short)1242762633;
				switch (num3 == num)
				{
				}
				num = (short)106037248;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.DisplayFormatProperty, value);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0007D2F4 File Offset: 0x0007B4F4
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			for (;;)
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
						num2 = (short)1131085825;
						if (num2 != 0)
						{
						}
						global::DevComponents.WpfEditors.Primitives.EditorDoubleInput editorDoubleInput;
						if (editorDoubleInput != null)
						{
							num2 = (short)1568276481;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 1:
					{
						global::DevComponents.WpfEditors.Primitives.EditorDoubleInput editorDoubleInput;
						editorDoubleInput.OnMinValueChanged((double)A_1.OldValue, (double)A_1.NewValue);
						num2 = (short)1055784962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						return;
					}
					break;
				}
				IL_1C:
				num2 = (short)1965686784;
				short num3 = num2;
				num2 = (short)2132576720;
				short num4 = num2;
				num2 = (short)1960479184;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1364983808;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfEditors.Primitives.EditorDoubleInput editorDoubleInput = A_0 as global::DevComponents.WpfEditors.Primitives.EditorDoubleInput;
					num2 = (short)1854668800;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0007D428 File Offset: 0x0007B628
		protected virtual void OnMinValueChanged(double oldValue, double newValue)
		{
			short num = (short)1191575555;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				double? value;
				switch (num2)
				{
				case 0:
				{
					base.AllowsNegativeValue = false;
					num = (short)1718157312;
					short num3 = num;
					num = (short)1766850565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_212;
				case 2:
					num = (short)562036748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 4:
					if (this.IsEmpty)
					{
						num = (short)1884028930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				case 5:
					goto IL_217;
				case 6:
					num = (short)1158217732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_217;
				case 8:
					if (this.IsEmpty)
					{
						num = (short)1625882630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_167;
				case 9:
					num = (short)415694856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (value.GetValueOrDefault() < newValue & value != null)
					{
						num = (short)1951399945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				case 11:
					goto IL_18C;
				case 12:
					if (!base.AllowEmptyState)
					{
						num = (short)1341915137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				}
				IL_58:
				if (newValue >= 0.0)
				{
					num = (short)719323136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)227062307;
				short num4 = num;
				num = (short)1800909347;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)28377088;
					if (num != 0)
					{
					}
					base.AllowsNegativeValue = true;
					num = (short)2025259015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_167:
				this.Value = new double?(newValue);
				num = (short)287506443;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_212:
				goto IL_167;
				IL_217:
				value = this.Value;
				num = (short)1212416010;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_18C:
			IL_267:
			num = (short)1964048385;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0007D6C4 File Offset: 0x0007B8C4
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x0007D780 File Offset: 0x0007B980
		public double MinValue
		{
			get
			{
				short num = (short)957349888;
				short num2 = num;
				num = (short)1937605348;
				short num3 = num;
				num = (short)862618340;
				switch (num3 == num)
				{
				}
				num = (short)1817772033;
				if (num != 0)
				{
				}
				num = (short)1056833536;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.MinValueProperty);
			}
			set
			{
				short num = (short)1001259008;
				short num2 = num;
				num = (short)1962213377;
				if (num != 0)
				{
				}
				num = (short)358189174;
				short num3 = num;
				num = (short)955025526;
				switch (num3 == num)
				{
				}
				num = (short)641925120;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.MinValueProperty, value);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0007D838 File Offset: 0x0007BA38
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			for (;;)
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
						global::DevComponents.WpfEditors.Primitives.EditorDoubleInput editorDoubleInput;
						if (editorDoubleInput != null)
						{
							num2 = (short)1146748929;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 1:
					{
						global::DevComponents.WpfEditors.Primitives.EditorDoubleInput editorDoubleInput;
						editorDoubleInput.OnMaxValueChanged((double)A_1.OldValue, (double)A_1.NewValue);
						num2 = (short)952107010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						return;
					}
					break;
				}
				IL_1C:
				num2 = (short)1905655808;
				short num3 = num2;
				num2 = (short)360320345;
				short num4 = num2;
				num2 = (short)298192217;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1777664001;
					if (num2 != 0)
					{
					}
					num2 = (short)1118109696;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfEditors.Primitives.EditorDoubleInput editorDoubleInput = A_0 as global::DevComponents.WpfEditors.Primitives.EditorDoubleInput;
					num2 = (short)738656256;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0007D974 File Offset: 0x0007BB74
		protected virtual void OnMaxValueChanged(double oldValue, double newValue)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			double? value;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (!(value.GetValueOrDefault() > newValue & value != null))
					{
						return;
					}
					num2 = (short)775560946;
					short num3 = num2;
					num2 = (short)1310990066;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D1;
					default:
						num2 = (short)22609920;
						if (num2 != 0)
						{
						}
						num2 = (short)2113863681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)913047560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				case 3:
					goto IL_1D9;
				case 4:
					if (!base.AllowEmptyState)
					{
						num2 = (short)1647640576;
						short num4 = num2;
						num2 = (short)1455554563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					goto IL_D1;
				case 6:
					num2 = (short)1212940289;
					if (num2 != 0)
					{
					}
					num2 = (short)2026635271;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (this.IsEmpty)
					{
						num2 = (short)2131492869;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					if (this.IsEmpty)
					{
						num2 = (short)641859590;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D9;
				}
				goto IL_34;
				IL_D1:
				num2 = (short)1684930564;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1D9:
				this.Value = new double?(newValue);
				num2 = (short)1735131138;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_34:
			value = this.Value;
			num2 = (short)1802371072;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0007DB80 File Offset: 0x0007BD80
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x0007DC38 File Offset: 0x0007BE38
		public double MaxValue
		{
			get
			{
				short num = (short)1516109824;
				short num2 = num;
				num = (short)657429560;
				short num3 = num;
				num = (short)732402744;
				switch (num3 == num)
				{
				}
				num = (short)1810956289;
				if (num != 0)
				{
				}
				num = (short)1468334080;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.MaxValueProperty);
			}
			set
			{
				short num = (short)799473664;
				short num2 = num;
				num = (short)83635332;
				short num3 = num;
				num = (short)1326132356;
				switch (num3 == num)
				{
				}
				num = (short)1967456257;
				if (num != 0)
				{
				}
				num = (short)622460928;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.MaxValueProperty, value);
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0007DCF8 File Offset: 0x0007BEF8
		private static object a(global::System.Windows.DependencyObject A_0, object A_1)
		{
			short num = (short)1617428480;
			short num2 = num;
			num = (short)1236982203;
			short num3 = num;
			num = (short)1817106875;
			switch (num3 == num)
			{
			}
			num = (short)433651712;
			if (num != 0)
			{
			}
			num = (short)1104674817;
			if (num != 0)
			{
			}
			return (A_0 as global::DevComponents.WpfEditors.Primitives.EditorDoubleInput).OnCoerceValue((double?)A_1);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0007DDB8 File Offset: 0x0007BFB8
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			for (;;)
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
						global::DevComponents.WpfEditors.Primitives.EditorDoubleInput editorDoubleInput;
						if (editorDoubleInput != null)
						{
							num2 = (short)749731841;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 1:
					{
						global::DevComponents.WpfEditors.Primitives.EditorDoubleInput editorDoubleInput;
						editorDoubleInput.OnValueChanged((double?)A_1.OldValue, (double?)A_1.NewValue);
						num2 = (short)328466434;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						return;
					}
					break;
				}
				IL_1C:
				num2 = (short)583467008;
				short num3 = num2;
				num2 = (short)2017300703;
				short num4 = num2;
				num2 = (short)504074463;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)975110145;
					if (num2 != 0)
					{
					}
					num2 = (short)638779392;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfEditors.Primitives.EditorDoubleInput editorDoubleInput = A_0 as global::DevComponents.WpfEditors.Primitives.EditorDoubleInput;
					num2 = (short)2090336256;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0007DEF0 File Offset: 0x0007C0F0
		protected virtual double? OnCoerceValue(double? value)
		{
			short num = (short)267649025;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)913702912;
				short num3 = num;
				double? num4;
				double num5;
				switch (num2)
				{
				case 0:
					if (num4.GetValueOrDefault() > num5 & num4 != null)
					{
						num = (short)1549729798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return value;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_78;
					}
					continue;
				case 2:
					num = (short)885653508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (!(num4.GetValueOrDefault() < num5 & num4 != null))
					{
						num4 = value;
						num5 = this.MaxValue;
						num = (short)1016987648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1515334128;
					short num6 = num;
					num = (short)2005281264;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1104478208;
						if (num != 0)
						{
						}
						num = (short)640417801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (!base.AllowEmptyState)
					{
						num = (short)1132986375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EF;
				case 5:
					return value;
				case 6:
					value = new double?(this.MaxValue);
					num = (short)536477706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					value = new double?(0.0);
					num = (short)2028077057;
					if (num != 0)
					{
					}
					num = (short)1212940296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_EF;
				case 9:
					value = new double?(this.MinValue);
					num = (short)1303511045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					return value;
				}
				IL_78:
				if (value == null)
				{
					num = (short)981073922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_EF:
				num4 = value;
				num5 = this.MinValue;
				num = (short)727646211;
				num2 = (int)((global::System.IntPtr)num);
			}
			return value;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0007E16C File Offset: 0x0007C36C
		protected virtual void OnValueChanged(double? oldValue, double? newValue)
		{
			short num = (short)1004535813;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1743126529;
					if (num != 0)
					{
					}
					num = (short)1199833088;
					short num3 = num;
					goto IL_1A7;
				}
				case 1:
				{
					num = (short)608984434;
					short num4 = num;
					num = (short)268590450;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A2;
					default:
						num = (short)1436483584;
						if (num != 0)
						{
						}
						num = (short)1974599693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					base.InvalidateMeasure();
					num = (short)884604939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.TextInputComplete(false);
					num = (short)712835086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.IsEmpty = false;
					num = (short)14876681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 6:
					if (base.IsKeyboardFocused)
					{
						num = (short)213385219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CE;
				case 7:
					this.IsEmpty = true;
					num = (short)292552714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (!base.IsEnabled)
					{
						num = (short)737345538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					goto IL_144;
				case 10:
					goto IL_1A2;
				case 11:
					return;
				case 12:
					if (this.IsEmpty)
					{
						num = (short)1798504452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				case 13:
					if (newValue == null)
					{
						num = (short)233570311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)733478924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_CE;
				}
				IL_61:
				if (!this.a)
				{
					num = (short)897908737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1A7;
				IL_CE:
				base.ResetInputStack();
				this.OnValueChanged();
				num = (short)1126105088;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A2:
				goto IL_CE;
				IL_144:
				num = (short)447283206;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A7:
				num = (short)501547016;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0007E440 File Offset: 0x0007C640
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x0007E4F8 File Offset: 0x0007C6F8
		public double? Value
		{
			get
			{
				short num = (short)1644911016;
				short num2 = num;
				num = (short)2094291368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)515244032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1832452097;
				if (num != 0)
				{
				}
				num = (short)1639186432;
				if (num != 0)
				{
				}
				return (double?)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.ValueProperty);
			}
			set
			{
				short num = (short)1071799212;
				short num2 = num;
				num = (short)212163500;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97452032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1728380928;
				if (num != 0)
				{
				}
				num = (short)1755185153;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.ValueProperty, value);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0007E5B4 File Offset: 0x0007C7B4
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x0007E66C File Offset: 0x0007C86C
		public double Increment
		{
			get
			{
				short num = (short)587843361;
				short num2 = num;
				num = (short)1656342305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)530382848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265355265;
				if (num != 0)
				{
				}
				num = (short)66650112;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.IncrementProperty);
			}
			set
			{
				short num = (short)1707729967;
				short num2 = num;
				num = (short)325313583;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1302986752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)880279553;
				if (num != 0)
				{
				}
				num = (short)1299316736;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.IncrementProperty, value);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0007E728 File Offset: 0x0007C928
		protected override string GetInputStringValue()
		{
			short num = (short)702398675;
			short num2 = num;
			num = (short)533905619;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1631649792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1974992897;
			if (num != 0)
			{
			}
			num = (short)1750532096;
			if (num != 0)
			{
			}
			return this.Text;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0007E7D8 File Offset: 0x0007C9D8
		protected override bool AcceptKeyPress(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1612080922;
					short num3 = num2;
					num2 = (short)102459162;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
						num2 = (short)355336192;
						if (num2 != 0)
						{
						}
						num2 = (short)1604190211;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_3B;
				case 2:
					return true;
				case 3:
					num2 = (short)1521156097;
					if (num2 != 0)
					{
					}
					if (!base.InputStack.Contains(text))
					{
						num2 = (short)1239220226;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_142;
				}
				goto IL_20;
				IL_3B:
				num2 = (short)1381761024;
				short num4 = num2;
				if (!(e.Text == text))
				{
					goto IL_142;
				}
				num2 = (short)1277952000;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_142:
			return base.AcceptKeyPress(e);
			IL_20:
			text = this.NumberDecimalSeparator;
			num2 = (short)408813569;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0007E930 File Offset: 0x0007CB30
		protected override void OnInputStackChanged()
		{
			int a_ = 18;
			short num = (short)1361641474;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1CC;
				case 1:
					goto IL_14E;
				case 2:
					goto IL_1E;
				case 3:
					goto IL_27C;
				case 4:
					if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_))
					{
						num = (short)1274675200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)156041227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_) + this.NumberDecimalSeparator)
					{
						num = (short)1348665353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)803625185;
					short num3 = num;
					num = (short)490625249;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
						num = (short)2015821824;
						if (num != 0)
						{
						}
						this.b(new double?(double.Parse(base.InputStack)), true);
						num = (short)361431052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					this.IsEmpty = true;
					this.b(null);
					num = (short)827785217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)262864901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (base.AllowEmptyState)
					{
						num = (short)1195442182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.b(new double?(0.0));
					num = (short)1170014211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_2D9;
				case 10:
					this.IsEmpty = false;
					num = (short)2127233025;
					if (num != 0)
					{
					}
					num = (short)1773404164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!(base.InputStack == this.NumberDecimalSeparator))
					{
						num = (short)992215047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4;
				case 12:
					goto IL_24B;
				}
				goto IL_62;
				IL_1E:
				switch (0)
				{
				case 0:
					IL_62:
					if (base.InputStack.Length > 0)
					{
						num = (short)367656960;
						short num4 = num;
						num = (short)724172810;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1163919368;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_F4:
			this.b(new double?(0.0), true);
			return;
			IL_14E:
			goto IL_32A;
			IL_1CC:
			this.b(new double?(0.0), true);
			return;
			IL_24B:
			IL_27C:
			goto IL_32A;
			IL_2D9:
			goto IL_F4;
			IL_32A:
			base.OnInputStackChanged();
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0007EC70 File Offset: 0x0007CE70
		protected override bool IsNumeric(string t)
		{
			for (;;)
			{
				IL_00:
				short num = (short)485097475;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return false;
					case 1:
					{
						num = (short)506986496;
						short num3 = num;
						if (t[0] >= '0')
						{
							num = (short)338034693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 2:
						num = (short)891682817;
						if (num != 0)
						{
						}
						num = (short)826933249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 4:
						if (t.Length == 1)
						{
							num = (short)1685651458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18B;
					case 5:
						goto IL_11F;
					}
					IL_3D:
					if (t.Length == 0)
					{
						num = (short)1870616341;
						short num4 = num;
						num = (short)743790357;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)147324928;
							if (num != 0)
							{
							}
							num = (short)1665204224;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)1000079364;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			return false;
			IL_11F:
			return t[0] <= '9';
			IL_18B:
			double num5 = 0.0;
			return double.TryParse(t, out num5);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0007EE1C File Offset: 0x0007D01C
		protected override void OnInputKeyAccepted()
		{
			short num = (short)1012493583;
			short num2 = num;
			num = (short)1837067535;
			switch (num2 == num)
			{
			default:
			{
				num = (short)178782208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2020081665;
			if (num != 0)
			{
			}
			num = (short)1207304192;
			if (num != 0)
			{
			}
			this.a(true);
			base.OnInputKeyAccepted();
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0007EED4 File Offset: 0x0007D0D4
		private void a(bool A_0)
		{
			int a_ = 15;
			short num = (short)300613632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_AE;
				}
				for (;;)
				{
					IL_32:
					num = (short)917176320;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_206;
					case 1:
					{
						if (base.InputStack.Contains(this.NumberDecimalSeparator))
						{
							num = (short)1120862209;
							if (num != 0)
							{
							}
							num = (short)582549522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = base.InputStack + this.NumberDecimalSeparator;
						string s = base.InputStack + global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						num = (short)1796931599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (base.InputStack.Length > 0)
						{
							num = (short)1296498696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F2;
					case 3:
						goto IL_33A;
					case 4:
						num = (short)1595015173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_) + this.NumberDecimalSeparator)
						{
							num = (short)1098317824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double? value = this.Value;
						double maxValue = this.MaxValue;
						num = (short)1428422672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)116260875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						string s;
						if (!this.ValidateNewInputStack(s))
						{
							num = (short)55312387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 8:
						num = (short)356515841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)796721159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						string text;
						if (!this.ValidateNewInputStack(text))
						{
							num = (short)180813833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 11:
						if (!base.InputStack.StartsWith(this.NumberDecimalSeparator))
						{
							num = (short)1680343044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						goto IL_3F2;
					case 13:
						goto IL_35A;
					case 14:
						num = (short)438042634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_3F2;
					case 16:
					{
						double? value;
						double maxValue;
						if (!(value.GetValueOrDefault() == maxValue & value != null))
						{
							num = (short)1377370126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33A;
					}
					case 17:
						if (!(base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_)))
						{
							num = (short)1911881734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
					{
						string text = base.InputStack + global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
						string s = text;
						num = (short)598671372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_AE;
					IL_33A:
					this.TextInputComplete(A_0);
					num = (short)1464664077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F2:
					num = (short)1912864785;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_206:
				return;
				IL_35A:
				return;
				for (;;)
				{
					IL_AE:
					string text = "";
					string s = "";
					num = (short)944686880;
					short num4 = num;
					num = (short)312657696;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_F2;
					}
				}
				IL_F2:
				num = (short)847249408;
				if (num != 0)
				{
				}
				num = (short)1476591618;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0007F324 File Offset: 0x0007D524
		protected override void OnInputLostFocus()
		{
			short num = (short)2019164161;
			if (num != 0)
			{
			}
			num = (short)1147928576;
			short num2 = num;
			num = (short)1278249979;
			short num3 = num;
			num = (short)1465945083;
			switch (num3 == num)
			{
			}
			num = (short)725417984;
			if (num != 0)
			{
			}
			this.ValidateValue();
			base.OnInputLostFocus();
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0007F3DC File Offset: 0x0007D5DC
		protected virtual void ValidateValue()
		{
			short num;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				int num2;
				double? value;
				double num4;
				for (;;)
				{
					IL_0A:
					num = (short)416677889;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_E3;
					case 1:
						this.Value = new double?(this.MaxValue);
						num = (short)2113273860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)878220990;
						short num3 = num;
						num = (short)388601534;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)926089216;
							if (num != 0)
							{
							}
							if (value.GetValueOrDefault() < num4 & value != null)
							{
								num = (short)1750073344;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							value = this.Value;
							num4 = this.MaxValue;
							num = (short)2093481987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (value.GetValueOrDefault() > num4 & value != null)
						{
							num = (short)1758658561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_110;
					}
					break;
				}
				IL_4B:
				value = this.Value;
				num4 = this.MinValue;
				num = (short)2000486402;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_E3:
			this.Value = new double?(this.MinValue);
			return;
			IL_110:
			num = (short)1328807936;
			short num5 = num;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0007F58C File Offset: 0x0007D78C
		protected override void OnAllowEmptyStateChanged(bool oldValue, bool newValue)
		{
			short num = (short)2057830400;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_10F;
				case 2:
					base.CoerceValue(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.ValueProperty);
					num = (short)468189185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				num = (short)41347474;
				short num3 = num;
				num = (short)859892114;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1662124032;
					short num4 = num;
					num = (short)714342400;
					if (num != 0)
					{
					}
					num = (short)1067384833;
					if (num != 0)
					{
					}
					if (newValue)
					{
						goto IL_111;
					}
					num = (short)389873666;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_10F:
			IL_111:
			base.OnAllowEmptyStateChanged(oldValue, newValue);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0007F6B4 File Offset: 0x0007D8B4
		private void b(double? A_0, bool A_1)
		{
			short num = (short)1456644702;
			short num2 = num;
			num = (short)598057566;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)194838528;
				short num3 = num;
				num = (short)1564016641;
				if (num != 0)
				{
				}
				num = (short)924057600;
				if (num != 0)
				{
				}
				this.a = true;
				try
				{
					num = (short)1844641794;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						double? value;
						double? num5;
						switch (num4)
						{
						case 0:
							num = (short)1823735816;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_298;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_FE;
							}
							continue;
						case 3:
							this.OnValueChanged();
							num = (short)2029649921;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (A_0.Value >= this.MinValue)
							{
								num = (short)1781792768;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_25D;
						case 5:
							goto IL_25B;
						case 6:
							goto IL_25D;
						case 7:
							goto IL_2BC;
						case 8:
							if (A_0.Value > this.MaxValue)
							{
								num = (short)467009542;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CC;
						case 9:
							if (base.IsFocused)
							{
								num = (short)1313669131;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CC;
						case 10:
							num = (short)472580100;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							base.InvalidateMeasure();
							base.InvalidateVisual();
							num = (short)522125317;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							bool flag = !(value.GetValueOrDefault() == num5.GetValueOrDefault() & value != null == (num5 != null)) || A_1;
							this.Value = A_0;
							if (flag)
							{
								num = (short)1237647363;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_298;
						}
						}
						IL_FE:
						if (A_0 != null)
						{
							num = (short)1002962954;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1CC:
						value = this.Value;
						num5 = A_0;
						num = (short)160301068;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_25D:
						num = (short)2109669385;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_298:
						base.InvalidateMeasure();
						base.InvalidateVisual();
						num = (short)1720975367;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_25B:
					IL_2BC:;
				}
				finally
				{
					this.a = false;
				}
				break;
			}
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0007F9A4 File Offset: 0x0007DBA4
		private void b(double? A_0)
		{
			short num = (short)816717321;
			short num2 = num;
			num = (short)1621433865;
			switch (num2 == num)
			{
			}
			num = (short)1823932417;
			if (num != 0)
			{
			}
			num = (short)1171193856;
			short num3 = num;
			num = (short)526712832;
			if (num != 0)
			{
			}
			this.b(A_0, false);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0007FA58 File Offset: 0x0007DC58
		protected override string GetMeasureString()
		{
			int a_ = 4;
			short num = (short)510066688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A8;
				}
				string result;
				for (;;)
				{
					IL_31:
					double? value;
					double num5;
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(base.InputStack))
						{
							num = (short)1459814402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						num = (short)838402049;
						if (num != 0)
						{
						}
						goto IL_296;
					case 2:
					{
						double num3 = 0.0;
						num = (short)911614452;
						short num4 = num;
						num = (short)115679732;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_468;
						default:
							num = (short)100204544;
							if (num != 0)
							{
							}
							num = (short)264175628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (base.IsFocused)
						{
							num = (short)2126905365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						if (value.GetValueOrDefault() == num5 & value != null)
						{
							num = (short)1111228443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53F;
					case 5:
						if (!this.IsEmpty)
						{
							num = (short)1777336334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_255;
					case 6:
						num = (short)1196949528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)441057297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!(base.InputStack == this.NumberDecimalSeparator))
						{
							num = (short)496173062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_160;
					case 9:
						if (value.GetValueOrDefault() == num5 & value != null)
						{
							num = (short)1363017747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_296;
					case 10:
						goto IL_160;
					case 11:
						if (value == null)
						{
							num = (short)69206029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE;
					case 12:
					{
						double num3;
						if (this.a(base.InputStack, out num3))
						{
							num = (short)1909981200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 13:
						goto IL_255;
					case 14:
						value = this.Value;
						num = (short)564592651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						value = this.Value;
						num5 = 0.0;
						num = (short)588709892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_468;
					case 17:
					{
						double num3;
						if (num3 < this.MinValue)
						{
							num = (short)1899692058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 18:
						if (base.AllowEmptyState)
						{
							num = (short)2044985367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE;
					case 19:
						goto IL_1B9;
					case 20:
						if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ﳐ", a_))
						{
							num = (short)1074003983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53F;
					case 21:
						num = (short)1557659648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_296;
					case 23:
						result = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藐", a_);
						num = (short)933232641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ﳐ", a_) + this.NumberDecimalSeparator)
						{
							num = (short)832700426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_296;
					case 25:
					{
						double num3;
						if (num3 <= this.MaxValue)
						{
							num = (short)433717255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D7;
					}
					case 26:
						goto IL_3CB;
					case 27:
						result = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ﳐ", a_);
						num = (short)117374998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8;
					IL_160:
					value = this.Value;
					num5 = 0.0;
					num = (short)2100822025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BE:
					num = (short)82640916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_255:
					num = (short)613941266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_296:
					num = (short)1054670851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_468:
					num = (short)907673625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53F:
					num = (short)1537867784;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B9:
				return base.InputStack;
				IL_2D7:
				return base.InputStack;
				IL_3CB:
				goto IL_2D7;
				IL_A8:
				num = (short)1625686016;
				short num6 = num;
				result = this.GetRenderString();
				num = (short)1930428421;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0007FFF8 File Offset: 0x0007E1F8
		protected override string GetRenderString()
		{
			int a_ = 15;
			short num = (short)1841561603;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				double? value;
				double num4;
				switch (num2)
				{
				case 0:
					if (!string.IsNullOrEmpty(base.InputStack))
					{
						num = (short)887685127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_506;
				case 1:
					goto IL_1EF;
				case 2:
					num = (short)1399259140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					continue;
				case 4:
				{
					double num3;
					if (num3 <= this.MaxValue)
					{
						num = (short)1877278736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26D;
				}
				case 5:
					goto IL_4AF;
				case 6:
					if (value.GetValueOrDefault() == num4 & value != null)
					{
						num = (short)2137325573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B4;
				case 7:
				{
					double num3 = 0.0;
					num = (short)109379601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_) + this.NumberDecimalSeparator)
					{
						num = (short)2125266959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22E;
				case 9:
					goto IL_229;
				case 10:
					if (value.GetValueOrDefault() == num4 & value != null)
					{
						num = (short)49479698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22E;
				case 11:
				{
					double num3;
					if (num3 < this.MinValue)
					{
						num = (short)1313079320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_506;
				}
				case 12:
					value = this.Value;
					goto IL_41A;
				case 13:
					if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_))
					{
						num = (short)19660823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B4;
				case 14:
					num = (short)1097007112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					num = (short)594083840;
					short num5 = num;
					goto IL_101;
				}
				case 16:
					num = (short)245956619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					double num3;
					if (this.a(base.InputStack, out num3))
					{
						num = (short)976158722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_506;
				}
				case 18:
					goto IL_157;
				case 19:
					if (base.IsFocused)
					{
						num = (short)1515323414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_506;
				case 20:
					if (value == null)
					{
						num = (short)1782185985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C;
				case 21:
					if (base.AllowEmptyState)
					{
						num = (short)1978138633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C;
				case 22:
					num = (short)1154023424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					value = this.Value;
					num4 = 0.0;
					num = (short)1038221318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
				{
					num = (short)575970677;
					short num6 = num;
					num = (short)853581173;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_41A;
					default:
						goto IL_36F;
					}
					break;
				}
				case 25:
					if (!(base.InputStack == this.NumberDecimalSeparator))
					{
						num = (short)789970958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_101;
				}
				IL_95:
				if (!this.IsEmpty)
				{
					num = (short)330432524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1EF;
				IL_101:
				value = this.Value;
				num4 = 0.0;
				num = (short)188743690;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15C:
				num = (short)1947402253;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EF:
				num = (short)147914773;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_22E:
				num = (short)225771539;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41A:
				num = (short)2020933652;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B4:
				num = (short)95485977;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_157:
			return base.InputStack;
			IL_229:
			return "";
			IL_26D:
			return base.InputStack;
			IL_36F:
			num = (short)436862976;
			if (num != 0)
			{
			}
			goto IL_26D;
			IL_4AF:
			num = (short)2041577473;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_);
			IL_506:
			return this.a(this.Value, true);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00080518 File Offset: 0x0007E718
		protected override bool NegateValue()
		{
			short num = (short)798949377;
			int num2 = (int)((global::System.IntPtr)num);
			double num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					double? value = this.Value;
					num3 = -value.Value;
					num = (short)2127757316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 2:
				{
					double? value;
					double num4;
					if (!(value.GetValueOrDefault() == num4 & value != null))
					{
						num = (short)103415809;
						if (num != 0)
						{
						}
						num = (short)1896153096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 3:
					goto IL_BE;
				case 4:
					if (num3 < this.MinValue)
					{
						num = (short)1742602243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_81;
				case 5:
				{
					double? value = this.Value;
					double num4 = 0.0;
					num = (short)166199298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (num3 > this.MaxValue)
					{
						num = (short)185466891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_199;
				case 7:
				{
					double? value;
					if (value != null)
					{
						num = (short)1114767370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 8:
				{
					num = (short)1046151168;
					short num5 = num;
					double? value = this.Value;
					num = (short)1973157895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					num = (short)1747479218;
					short num6 = num;
					num = (short)993356466;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BE;
					default:
						num = (short)2126053376;
						if (num != 0)
						{
						}
						goto IL_81;
					}
					break;
				}
				case 10:
					num = (short)1961426957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num3 = this.MaxValue;
					num = (short)1057030156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_24A;
				case 13:
					if (this.MaxValue >= 0.0)
					{
						num = (short)372834304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_5C:
				if (!this.IsEmpty)
				{
					num = (short)649658373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_81:
				num = (short)51838982;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BE:
				num3 = this.MinValue;
				num = (short)1280835593;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_199:
			this.a(this.a(num3));
			return true;
			IL_24A:
			goto IL_199;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00080810 File Offset: 0x0007EA10
		protected override void ResetValue()
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			short num2;
			double? num3;
			for (;;)
			{
				IL_0A:
				int num;
				double? num4;
				double maxValue;
				switch (num)
				{
				case 0:
					goto IL_F0;
				case 1:
					if (!base.AllowEmptyState)
					{
						num2 = (short)876412930;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1DF;
				case 2:
					num3 = new double?(0.0);
					num2 = (short)173473799;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					double minValue = this.MinValue;
					num4 = num3;
					if (minValue > num4.GetValueOrDefault() & num4 != null)
					{
						num2 = (short)260833288;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F0;
				}
				case 4:
					goto IL_1DD;
				case 5:
					num3 = new double?(this.MaxValue);
					num2 = (short)406978564;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)2008481793;
					if (num2 != 0)
					{
					}
					if (num4.GetValueOrDefault() > maxValue & num4 != null)
					{
						num2 = (short)1639251973;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_231;
				case 7:
					goto IL_1B7;
				case 8:
					num3 = new double?(this.MinValue);
					num2 = (short)1514864640;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_F0:
				num4 = num3;
				maxValue = this.MaxValue;
				num2 = (short)685703174;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1B7:
			goto IL_1DF;
			IL_1DD:
			IL_231:
			this.b(num3);
			base.InvalidateMeasure();
			base.InvalidateVisual();
			return;
			IL_34:
			num2 = (short)1711197686;
			short num5 = num2;
			num2 = (short)567332342;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1DF:
				num2 = (short)16384003;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)404226048;
				short num6 = num2;
				num2 = (short)428081152;
				if (num2 != 0)
				{
				}
				num3 = null;
				num2 = (short)1402142721;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00080A64 File Offset: 0x0007EC64
		private void a(string A_0)
		{
			short num = (short)1426391040;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1829112598;
					short num3 = num;
					num = (short)2129005334;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)695009281;
						if (num != 0)
						{
						}
						num = (short)731250688;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					}
					break;
				}
				case 1:
					base.SetInputPosition(base.InputStack.Length);
					num = (short)1735786498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_E6;
				}
				IL_A2:
				if (!this.SetInputStack(A_0))
				{
					break;
				}
				num = (short)2114453505;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			num = (short)613482496;
			short num4 = num;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00080B84 File Offset: 0x0007ED84
		protected override bool ValidateNewInputStack(string s)
		{
			int a_ = 1;
			short num = (short)1314521088;
			switch (num)
			{
			default:
			{
				num = (short)1591803909;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1624375296;
					short num3 = num;
					string text;
					double num4;
					switch (num2)
					{
					case 0:
						if (text.Contains(this.NumberDecimalSeparator))
						{
							num = (short)1460338690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (this.a(s, out num4))
						{
							num = (short)504365073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
					{
						int num5 = this.c();
						int length = s.Substring(s.IndexOf(this.NumberDecimalSeparator) + 1).Length;
						num = (short)255983620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (num4 < this.MinValue)
						{
							num = (short)688979989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_224;
					case 4:
					{
						int num5;
						if (num5 > 0)
						{
							num = (short)1305411611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_E8;
						}
						continue;
					case 6:
						goto IL_279;
					case 7:
						return false;
					case 8:
						if (this.MaxValue < 0.0)
						{
							num = (short)1929183238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						if (this.MinValue < 0.0)
						{
							num = (short)128057363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_224;
					case 10:
						goto IL_30A;
					case 11:
						if (num4 > this.MaxValue)
						{
							num = (short)334757901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					case 12:
						num = (short)119210000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)542834696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)931201050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1827602456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (base.AllowsNegativeValue)
						{
							num = (short)810418177;
							if (num != 0)
							{
							}
							num = (short)1883635734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A2;
					case 17:
						num = (short)375455755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (s.Contains(this.NumberDecimalSeparator))
						{
							num = (short)2012217367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 19:
						goto IL_19D;
					case 20:
						if (!(s == this.NumberDecimalSeparator))
						{
							num = (short)389677071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 21:
						num = (short)831127561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						return true;
					case 23:
						num = (short)814350336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (s == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_) + this.NumberDecimalSeparator)
						{
							num = (short)1183383562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = 0.0;
						num = (short)29818881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						int num5;
						int length;
						if (length > num5)
						{
							num = (short)1327955975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 26:
					{
						num = (short)1411586411;
						short num6 = num;
						num = (short)1450252651;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num = (short)1758330880;
							if (num != 0)
							{
							}
							if (s == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_))
							{
								num = (short)1824849932;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A2;
						}
						break;
					}
					case 27:
						num = (short)1752367129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E8:
					if (s.Length > 0)
					{
						num = (short)1144520718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54A;
					IL_1A2:
					num = (short)339279892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_224:
					text = this.a(new double?(num4), true, true);
					num = (short)1711210514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_279:
					num = (short)1780088835;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19D:
				return false;
				IL_30A:
				return true;
				IL_54A:
				return base.ValidateNewInputStack(s);
			}
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000810E4 File Offset: 0x0007F2E4
		private int c()
		{
			short num = (short)1187250177;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.IFormatProvider formatProvider;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (formatProvider is global::System.Globalization.NumberFormatInfo)
					{
						num = (short)1499267076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return 2;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
				{
					num = (short)1196490752;
					short num3 = num;
					if (formatProvider != null)
					{
						goto IL_17F;
					}
					return 2;
				}
				case 3:
					formatProvider = (global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().GetFormat(typeof(global::System.Globalization.NumberFormatInfo)) as global::System.IFormatProvider);
					num = (short)1286602754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_120;
				case 5:
					num = (short)6488064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				if (!string.IsNullOrEmpty(this.DisplayFormat))
				{
					goto IL_19C;
				}
				num = (short)1759313520;
				short num4 = num;
				num = (short)1469841008;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1807810560;
					if (num != 0)
					{
					}
					num = (short)2064515075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_17F:
				num = (short)115802117;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_120:
			num = (short)355336193;
			if (num != 0)
			{
			}
			return ((global::System.Globalization.NumberFormatInfo)formatProvider).NumberDecimalDigits;
			IL_19C:
			string text = this.a(new double?(11.111111111111), true, true);
			return text.Substring(text.IndexOf(this.NumberDecimalSeparator) + 1).Length;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000812C0 File Offset: 0x0007F4C0
		internal bool a(string A_0, out double A_1)
		{
			short num;
			global::System.IFormatProvider formatProvider;
			for (;;)
			{
				num = (short)38731776;
				short num2 = num;
				formatProvider = (global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().GetFormat(typeof(global::System.Globalization.NumberFormatInfo)) as global::System.IFormatProvider);
				if (formatProvider == null)
				{
					goto IL_C7;
				}
				num = (short)2021073285;
				short num3 = num;
				num = (short)1798775173;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7E;
				}
			}
			IL_7E:
			num = (short)1690042369;
			if (num != 0)
			{
			}
			num = (short)1036779520;
			if (num != 0)
			{
			}
			return double.TryParse(A_0, global::System.Globalization.NumberStyles.Number, formatProvider, out A_1);
			IL_C7:
			return double.TryParse(A_0, out A_1);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0008139C File Offset: 0x0007F59C
		public override void IncreaseValue()
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			int num;
			double? value;
			short num2;
			for (;;)
			{
				IL_0A:
				double maxValue;
				double num3;
				double num5;
				switch (num)
				{
				case 0:
					if (value.GetValueOrDefault() < maxValue & value != null)
					{
						num2 = (short)1524432901;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D6;
				case 1:
					goto IL_70;
				case 2:
					goto IL_D6;
				case 3:
					value = this.Value;
					num2 = (short)2100887562;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1869086728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1404829703;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1185153036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					if (num3 <= this.MaxValue)
					{
						goto IL_D6;
					}
					num2 = (short)1028448472;
					short num4 = num2;
					num2 = (short)1453318360;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70;
					default:
						num2 = (short)886112256;
						if (num2 != 0)
						{
						}
						num2 = (short)2107244557;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 8:
					if (base.AllowEmptyState)
					{
						num2 = (short)466354185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_225;
				case 9:
					num3 = global::System.Math.Max(0.0, this.MinValue);
					num2 = (short)750125070;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)205979649;
					if (num2 != 0)
					{
					}
					num5 = value.Value;
					goto IL_2E3;
				case 11:
					goto IL_258;
				case 12:
					if (this.IsEmpty)
					{
						num2 = (short)584646660;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_225;
				case 13:
					num3 = this.MaxValue;
					num2 = (short)1239220226;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_225;
				case 15:
					num5 = 0.0;
					goto IL_2E3;
				case 16:
				{
					num2 = (short)328007680;
					short num6 = num2;
					if (num3 <= this.MaxValue)
					{
						num2 = (short)1293942790;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_367;
				}
				}
				goto IL_54;
				IL_70:
				if (value != null)
				{
					num2 = (short)415563779;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)1221066767;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_D6:
				num2 = (short)1416560656;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_225:
				this.a(this.b(this.a(num3)));
				this.a(false);
				num2 = (short)875036683;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E3:
				num3 = num5 + this.Increment;
				value = this.Value;
				maxValue = this.MaxValue;
				num2 = (short)917962752;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_258:
			IL_367:
			base.IncreaseValue();
			return;
			IL_54:
			value = this.Value;
			num2 = (short)1838022657;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00081718 File Offset: 0x0007F918
		public override void DecreaseValue()
		{
			int num;
			short num2;
			double? value;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					double num4;
					double minValue;
					double num6;
					switch (num)
					{
					case 0:
					{
						num2 = (short)195775013;
						short num3 = num2;
						num2 = (short)372984357;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_47;
						default:
							num2 = (short)909770752;
							if (num2 != 0)
							{
							}
							num2 = (short)1481441281;
							if (num2 != 0)
							{
							}
							if (value != null)
							{
								num2 = (short)871628804;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1158938633;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_1DD;
					case 2:
						num2 = (short)919994379;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num4 = value.Value;
						goto IL_21C;
					case 4:
						value = this.Value;
						num2 = (short)886767619;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (value.GetValueOrDefault() > minValue & value != null)
						{
							num2 = (short)1764163584;
							short num5 = num2;
							num2 = (short)1082589186;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1DD;
					case 6:
						goto IL_1AE;
					case 7:
						this.a(this.b(this.a(num6)));
						this.a(false);
						num2 = (short)1382481926;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						if (num6 >= this.MinValue)
						{
							num2 = (short)943587335;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2A6;
					case 9:
						num4 = 0.0;
						goto IL_21C;
					case 10:
						num6 = this.MinValue;
						num2 = (short)448462849;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						if (num6 < this.MinValue)
						{
							num2 = (short)221708298;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1DD;
					}
					goto IL_40;
					IL_1DD:
					num2 = (short)1686896648;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_21C:
					num6 = num4 - this.Increment;
					value = this.Value;
					minValue = this.MinValue;
					num2 = (short)1141768197;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1AE:
				IL_2A6:
				base.DecreaseValue();
				return;
			}
			IL_40:
			value = this.Value;
			IL_47:
			num2 = (short)1099104256;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x000819D4 File Offset: 0x0007FBD4
		private string a(double? A_0)
		{
			short num = (short)1964638208;
			short num2 = num;
			num = (short)1936326657;
			if (num != 0)
			{
			}
			num = (short)34463471;
			short num3 = num;
			num = (short)1141038831;
			switch (num3 == num)
			{
			}
			num = (short)1676673024;
			if (num != 0)
			{
			}
			return this.a(A_0, false, false);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00081A88 File Offset: 0x0007FC88
		private string a(double? A_0, bool A_1)
		{
			short num = (short)1318715392;
			short num2 = num;
			num = (short)1084897763;
			short num3 = num;
			num = (short)515586531;
			switch (num3 == num)
			{
			}
			num = (short)529858560;
			if (num != 0)
			{
			}
			num = (short)1932263425;
			if (num != 0)
			{
			}
			return this.a(A_0, A_1, false);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00081B38 File Offset: 0x0007FD38
		private string a(double? A_0, bool A_1, bool A_2)
		{
			short num = (short)409075715;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1724186624;
				short num3 = num;
				string text;
				double a_;
				switch (num2)
				{
				case 0:
					return text;
				case 1:
					num = (short)1684406273;
					if (num != 0)
					{
					}
					if (text.Substring(text.IndexOf(this.NumberDecimalSeparator)) != base.InputStack.Substring(base.InputStack.IndexOf(this.NumberDecimalSeparator)))
					{
						num = (short)895025159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 2:
					goto IL_CD;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 4:
					if (this.DisplayFormat.Length != 0)
					{
						num = (short)1117454352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_520;
				case 5:
					if (this.DisplayFormat.Length > 0)
					{
						num = (short)362938389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 6:
					if (A_0 != null)
					{
						num = (short)443285524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D9;
				case 7:
					goto IL_44B;
				case 8:
					if (base.InputStack.Contains(this.NumberDecimalSeparator))
					{
						num = (short)1855389709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 9:
					if (!A_2)
					{
						num = (short)568852490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CE;
				case 10:
					num = (short)895221764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!A_1)
					{
						num = (short)1812398098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CE;
				case 12:
					num = (short)463863819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1926299662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (!text.Contains(this.NumberDecimalSeparator))
					{
						num = (short)1924333583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)919797761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					text += base.InputStack.Substring(base.InputStack.IndexOf(this.NumberDecimalSeparator));
					num = (short)1447886848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)470614035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					return text;
				case 18:
					goto IL_520;
				case 19:
					if (!base.IsKeyboardFocused)
					{
						num = (short)548732940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_520;
				case 20:
					a_ = A_0.Value;
					num = (short)543817750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_31B;
					try
					{
						for (;;)
						{
							IL_31B:
							switch (0)
							{
							case 0:
								goto IL_33F;
							}
							global::System.IFormatProvider formatProvider;
							for (;;)
							{
								IL_325:
								switch (num2)
								{
								case 0:
									if (formatProvider != null)
									{
										num = (short)1083047940;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									text = a_.ToString(this.DisplayFormat);
									num = (short)900530178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3D7;
								case 2:
									goto IL_3D7;
								case 3:
									goto IL_438;
								case 4:
									text = a_.ToString(this.DisplayFormat, formatProvider);
									num = (short)2106589185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_3D7:
								num = (short)378266513;
								short num4 = num;
								num = (short)1466557329;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_31B;
								default:
									num = (short)1402929152;
									if (num != 0)
									{
									}
									num = (short)665059331;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_33F:
							formatProvider = (global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().GetFormat(typeof(global::System.Globalization.NumberFormatInfo)) as global::System.IFormatProvider);
							num = (short)348323840;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_325;
						}
						IL_438:
						return text;
					}
					catch
					{
						return a_.ToString();
					}
					goto IL_44B;
				case 22:
					goto IL_2D9;
				}
				IL_A9:
				if (A_0 == null)
				{
					num = (short)204800002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				a_ = 0.0;
				num = (short)1052835846;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CE:
				num = (short)1703477253;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D9:
				text = this.a(a_);
				num = (short)1882128393;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44B:
				text = text.Substring(0, text.IndexOf(this.NumberDecimalSeparator)) + base.InputStack.Substring(base.InputStack.IndexOf(this.NumberDecimalSeparator));
				num = (short)855769105;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_520:
				num = (short)2014511112;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			return "";
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000820CC File Offset: 0x000802CC
		private string a(double A_0)
		{
			short num = (short)833478717;
			short num2 = num;
			num = (short)1011015741;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1917714433;
				if (num != 0)
				{
				}
				num = (short)1839267840;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				int num3;
				global::System.IFormatProvider formatProvider;
				for (;;)
				{
					IL_7D:
					switch (num3)
					{
					case 0:
					{
						if (formatProvider != null)
						{
							num = (short)2121728005;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1059389440;
						short num4 = num;
						num = (short)445644803;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (!string.IsNullOrEmpty(this.DisplayFormat))
						{
							num = (short)644939780;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14D;
					case 2:
						goto IL_14B;
					case 3:
						if (!string.IsNullOrEmpty(this.DisplayFormat))
						{
							num = (short)427098114;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B1;
					case 4:
						goto IL_192;
					case 5:
						num = (short)149553153;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9B;
				}
				IL_14B:
				break;
				IL_14D:
				return A_0.ToString(formatProvider);
				IL_192:
				return A_0.ToString(this.DisplayFormat, formatProvider);
				IL_1B1:
				return A_0.ToString();
				IL_9B:
				formatProvider = (global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().GetFormat(typeof(global::System.Globalization.NumberFormatInfo)) as global::System.IFormatProvider);
				num = (short)2097741824;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7D;
			}
			}
			return A_0.ToString(this.DisplayFormat);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00082294 File Offset: 0x00080494
		internal string b(string A_0)
		{
			short num2;
			string text;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				int num;
				int num5;
				for (;;)
				{
					IL_0A:
					char c;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1391788032;
						short num3 = num2;
						goto IL_267;
					}
					case 1:
						goto IL_2CE;
					case 2:
						goto IL_F8;
					case 3:
						if (!(c.ToString() != this.NumberThousandsSeparator))
						{
							num2 = (short)2088894474;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return text;
					case 4:
						if (text.Length > 0)
						{
							num2 = (short)1567096846;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B4;
					case 5:
						goto IL_2A2;
					case 6:
					{
						num2 = (short)452844933;
						short num4 = num2;
						num2 = (short)713874821;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1459159040;
							if (num2 != 0)
							{
							}
							goto IL_1B4;
						}
						break;
					}
					case 7:
						if (A_0[num5] == '-')
						{
							num2 = (short)749862914;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_228;
					case 8:
						if (!(c.ToString() == this.NumberDecimalSeparator))
						{
							num2 = (short)1084686352;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F8;
					case 9:
						if (num5 >= A_0.Length)
						{
							num2 = (short)920715269;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						c = A_0[num5];
						num2 = (short)2040070152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						goto IL_1B4;
					case 11:
						if (A_0[num5] >= '0')
						{
							num2 = (short)2059403282;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2CE;
					case 12:
						num2 = (short)93650951;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 13:
						if (num5 == 0)
						{
							num2 = (short)585236492;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_228;
					case 14:
						c = A_0[num5];
						num2 = (short)1122304003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 15:
						if (A_0[num5] > '9')
						{
							num2 = (short)590217217;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F8;
					case 16:
						num2 = (short)623509515;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 17:
						goto IL_267;
					case 18:
						num2 = (short)1857617935;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
					IL_F8:
					string str = text;
					c = A_0[num5];
					text = str + c.ToString();
					num2 = (short)922157062;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1B4:
					num5++;
					num2 = (short)125108241;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_228:
					num2 = (short)1268383748;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_267:
					num2 = (short)500498441;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_2CE:
					num2 = (short)203096077;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_5C:
				text = "";
				num5 = 0;
				num2 = (short)332333056;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_2A2:
			num2 = (short)1014300673;
			if (num2 != 0)
			{
			}
			return text;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0008262C File Offset: 0x0008082C
		private string NumberDecimalSeparator
		{
			get
			{
				short num = (short)566034432;
				short num2 = num;
				num = (short)1862084749;
				short num3 = num;
				num = (short)1207707789;
				switch (num3 == num)
				{
				}
				num = (short)835846145;
				if (num != 0)
				{
				}
				num = (short)701693952;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().NumberFormat.NumberDecimalSeparator;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x000826E4 File Offset: 0x000808E4
		private string NumberThousandsSeparator
		{
			get
			{
				short num = (short)1328873472;
				short num2 = num;
				num = (short)795740992;
				short num3 = num;
				num = (short)454036288;
				switch (num3 == num)
				{
				}
				num = (short)292945921;
				if (num != 0)
				{
				}
				num = (short)1816657920;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture().NumberFormat.NumberGroupSeparator;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0008279C File Offset: 0x0008099C
		[global::System.ComponentModel.Browsable(false)]
		public virtual string Text
		{
			get
			{
				short num = (short)372310016;
				short num2 = num;
				num = (short)1182926751;
				short num3 = num;
				num = (short)1370818463;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1893793793;
					if (num != 0)
					{
					}
					num = (short)1965424640;
					if (num != 0)
					{
					}
					num = (short)770834432;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_D1;
						}
						continue;
					case 1:
						if (base.AllowEmptyState)
						{
							num = (short)1299841026;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_128;
					case 2:
						goto IL_126;
					case 3:
						num = (short)93388801;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D1:
					if (!this.IsEmpty)
					{
						goto IL_128;
					}
					num = (short)850984963;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_126:
				return "";
				IL_128:
				return this.a(this.Value, true, true);
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x000828E0 File Offset: 0x00080AE0
		public override string ToString()
		{
			short num = (short)163905536;
			short num2 = num;
			num = (short)1539899393;
			if (num != 0)
			{
			}
			num = (short)1712412048;
			short num3 = num;
			num = (short)1237931408;
			switch (num3 == num)
			{
			}
			num = (short)305987584;
			if (num != 0)
			{
			}
			return this.GetRenderString();
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000829A4 File Offset: 0x00080BA4
		// Note: this type is marked as 'beforefieldinit'.
		static EditorDoubleInput()
		{
			int a_ = 14;
			short num = (short)246611968;
			short num2 = num;
			num = (short)1547476189;
			short num3 = num;
			num = (short)132881629;
			switch (num3 == num)
			{
			}
			num = (short)807927809;
			if (num != 0)
			{
			}
			num = (short)763756544;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.DisplayFormatProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鿚드곞釠迢蓤黦꿨蓪鿬苮郰蟲", a_), typeof(string), typeof(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闚", a_), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.MinValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("雚드뇞럠苢觤鋦賨", a_), typeof(double), typeof(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput), new global::System.Windows.FrameworkPropertyMetadata(double.MinValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.c)));
			global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.MaxValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("雚볜꟞럠苢觤鋦賨", a_), typeof(double), typeof(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput), new global::System.Windows.FrameworkPropertyMetadata(double.MaxValue, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.b)));
			global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.ValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跚볜돞铠蛢", a_), typeof(double?), typeof(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.a), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.a)));
			global::DevComponents.WpfEditors.Primitives.EditorDoubleInput.IncrementProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鋚돜볞鏠蛢裤苦蟨鿪", a_), typeof(double), typeof(global::DevComponents.WpfEditors.Primitives.EditorDoubleInput), new global::System.Windows.FrameworkPropertyMetadata(1.0));
		}

		// Token: 0x040002AF RID: 687
		private bool a;

		// Token: 0x040002B0 RID: 688
		public static readonly global::System.Windows.DependencyProperty DisplayFormatProperty;

		// Token: 0x040002B1 RID: 689
		public static readonly global::System.Windows.DependencyProperty MinValueProperty;

		// Token: 0x040002B2 RID: 690
		public static readonly global::System.Windows.DependencyProperty MaxValueProperty;

		// Token: 0x040002B3 RID: 691
		public static readonly global::System.Windows.DependencyProperty ValueProperty;

		// Token: 0x040002B4 RID: 692
		public static readonly global::System.Windows.DependencyProperty IncrementProperty;
	}
}
