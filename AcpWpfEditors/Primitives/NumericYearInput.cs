using System;
using System.ComponentModel;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000079 RID: 121
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NumericYearInput : global::DevComponents.WpfEditors.Primitives.EditorIntegerInput, global::DevComponents.WpfEditors.Primitives.IDateTimePartInput
	{
		// Token: 0x0600076C RID: 1900 RVA: 0x0009A2A8 File Offset: 0x000984A8
		public NumericYearInput()
		{
			base.MinValue = global::System.DateTime.MinValue.Year;
			base.MaxValue = global::System.DateTime.MaxValue.Year;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x0009A2E4 File Offset: 0x000984E4
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x0009A390 File Offset: 0x00098590
		[global::System.ComponentModel.DefaultValue(global::DevComponents.WpfEditors.Primitives.eYearDisplayFormat.FourDigit)]
		public global::DevComponents.WpfEditors.Primitives.eYearDisplayFormat YearDisplayFormat
		{
			get
			{
				short num = (short)1931877589;
				short num2 = num;
				num = (short)20978901;
				switch (num2 == num)
				{
				}
				num = (short)476971008;
				short num3 = num;
				num = (short)1464008705;
				if (num != 0)
				{
				}
				num = (short)1444216832;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1605107713;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)602333405;
							short num3 = num;
							num = (short)1929306333;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)2073362432;
								short num4 = num;
								num = (short)2057830401;
								if (num != 0)
								{
								}
								num = (short)1450377216;
								if (num != 0)
								{
								}
								this.a = value;
								base.InvalidateMeasure();
								base.InvalidateVisual();
								num = (short)183500802;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						case 2:
							return;
						}
						IL_30:
						if (this.a == value)
						{
							return;
						}
						num = (short)1316749312;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0009A4BC File Offset: 0x000986BC
		protected override string GetMeasureString()
		{
			short num = (short)1765330407;
			short num2 = num;
			num = (short)1933495783;
			switch (num2 == num)
			{
			}
			num = (short)1470627840;
			short num3 = num;
			num = (short)1608843265;
			if (num != 0)
			{
			}
			num = (short)683016192;
			if (num != 0)
			{
			}
			return this.a(base.GetMeasureString());
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0009A570 File Offset: 0x00098770
		protected override string GetRenderString()
		{
			short num = (short)98235105;
			short num2 = num;
			num = (short)1241825;
			switch (num2 == num)
			{
			}
			num = (short)1929904128;
			short num3 = num;
			num = (short)1717436417;
			if (num != 0)
			{
			}
			num = (short)2138898432;
			if (num != 0)
			{
			}
			return this.a(base.GetRenderString());
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0009A624 File Offset: 0x00098824
		private string a(string A_0)
		{
			short num = (short)1492254722;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)179044352;
					short num3 = num;
					if (A_0.Length >= 4)
					{
						num = (short)2111504385;
						if (num != 0)
						{
						}
						num = (short)502595585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return A_0;
				}
				case 1:
					num = (short)2012610567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 3:
				{
					if (this.a != global::DevComponents.WpfEditors.Primitives.eYearDisplayFormat.TwoDigit)
					{
						goto IL_1C5;
					}
					num = (short)1381421119;
					short num4 = num;
					num = (short)1292947519;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
						num = (short)71499776;
						if (num != 0)
						{
						}
						num = (short)1207828485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_1C0;
				case 5:
					goto IL_EC;
				case 6:
					goto IL_F3;
				case 7:
					if (this.a == global::DevComponents.WpfEditors.Primitives.eYearDisplayFormat.FourDigit)
					{
						num = (short)266731524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1447034883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_44:
				if (!base.IsKeyboardFocused)
				{
					num = (short)1748303878;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return A_0;
				IL_F3:
				num = (short)1002766336;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EC:
			return A_0.Substring(2);
			IL_1C0:
			return A_0;
			IL_1C5:
			return A_0.Substring(3);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0009A800 File Offset: 0x00098A00
		protected override void TextInputComplete(bool sendNotification)
		{
			short num = (short)1221712648;
			short num2 = num;
			num = (short)328194824;
			switch (num2 == num)
			{
			}
			num = (short)1143406592;
			short num3 = num;
			num = (short)1476919297;
			if (num != 0)
			{
			}
			num = (short)1372585984;
			if (num != 0)
			{
			}
			this.a();
			base.TextInputComplete(sendNotification);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0009A8B4 File Offset: 0x00098AB4
		protected override void OnInputLostFocus()
		{
			short num = (short)945135013;
			short num2 = num;
			num = (short)670211493;
			switch (num2 == num)
			{
			}
			num = (short)1852178432;
			short num3 = num;
			num = (short)1472331777;
			if (num != 0)
			{
			}
			num = (short)1768423424;
			if (num != 0)
			{
			}
			this.a();
			base.OnInputLostFocus();
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0009A96C File Offset: 0x00098B6C
		private void a()
		{
			int a_ = 16;
			short num = (short)494993408;
			switch (num)
			{
			default:
			{
				num = (short)598409217;
				if (num != 0)
				{
				}
				num = (short)806223875;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						int? value = base.Value;
						int value2 = value.Value;
						int num3 = global::System.DateTime.Now.Year;
						base.Value = new int?(int.Parse(num3.ToString().Substring(0, 2) + value2.ToString(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_))));
						num = (short)2023241022;
						short num4 = num;
						num = (short)1995126078;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_180;
						default:
							num = (short)1541931008;
							if (num != 0)
							{
							}
							num = (short)1759051780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						int? value;
						int num3;
						if (value.GetValueOrDefault() < num3 & value != null)
						{
							num = (short)188547072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						int? value = base.Value;
						int num3 = 100;
						goto IL_180;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_91;
						}
						continue;
					case 4:
						return;
					case 5:
					{
						int? value = base.Value;
						num = (short)955711494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						int? value;
						if (value != null)
						{
							num = (short)1884160002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_91:
					if (!this.IsEmpty)
					{
						num = (short)1823145989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_180:
					num = (short)1984036864;
					short num5 = num;
					num = (short)757858305;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0009ABB4 File Offset: 0x00098DB4
		global::DevComponents.WpfEditors.Primitives.eDateTimePart global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Part
		{
			get
			{
				short num = (short)1366191204;
				short num2 = num;
				num = (short)24996964;
				switch (num2 == num)
				{
				}
				num = (short)317652992;
				short num3 = num;
				num = (short)1054474241;
				if (num != 0)
				{
				}
				num = (short)107282432;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eDateTimePart.Year;
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0009AC60 File Offset: 0x00098E60
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1725560884 + A_1) + (global::System.IntPtr)9 + (global::System.IntPtr)60 + (global::System.IntPtr)83);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x04000306 RID: 774
		private new global::DevComponents.WpfEditors.Primitives.eYearDisplayFormat a;
	}
}
