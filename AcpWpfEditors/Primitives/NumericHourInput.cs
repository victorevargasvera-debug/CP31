using System;
using System.ComponentModel;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000074 RID: 116
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class NumericHourInput : global::DevComponents.WpfEditors.Primitives.EditorIntegerInput, global::DevComponents.WpfEditors.Primitives.IDateTimePartInput
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00099690 File Offset: 0x00097890
		public NumericHourInput()
		{
			base.MinValue = 0;
			base.MaxValue = 23;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x000996BC File Offset: 0x000978BC
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x0009976C File Offset: 0x0009796C
		public bool Is24HourFormat
		{
			get
			{
				short num = (short)834571491;
				short num2 = num;
				num = (short)1489931491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)68812800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074331648;
				if (num != 0)
				{
				}
				num = (short)1031340033;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1208680448;
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
						goto IL_F0;
					case 2:
						return;
					}
					IL_32:
					num = (short)1486448855;
					short num3 = num;
					num = (short)825518295;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_F0:
						this.a = value;
						this.b();
						num = (short)1124335618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						break;
					default:
					{
						num = (short)336330752;
						short num4 = num;
						break;
					}
					}
					num = (short)1633091585;
					if (num != 0)
					{
					}
					num = (short)1875050496;
					if (num != 0)
					{
					}
					if (this.a == value)
					{
						break;
					}
					num = (short)887160833;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00099890 File Offset: 0x00097A90
		private void b()
		{
			short num = (short)762739986;
			short num2 = num;
			num = (short)1328643346;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1639972864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)786563072;
			if (num != 0)
			{
			}
			num = (short)118620161;
			if (num != 0)
			{
			}
			base.InvalidateMeasure();
			base.InvalidateVisual();
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00099944 File Offset: 0x00097B44
		protected override int? GetRenderValue()
		{
			short num = (short)788049544;
			short num2 = num;
			num = (short)1884401288;
			switch (num2 == num)
			{
			default:
			{
				num = (short)777388032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2004680705;
			if (num != 0)
			{
			}
			num = (short)1782579200;
			if (num != 0)
			{
			}
			return this.a();
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000999F4 File Offset: 0x00097BF4
		protected override int? GetMeasureValue()
		{
			short num = (short)154234646;
			short num2 = num;
			num = (short)1542745878;
			switch (num2 == num)
			{
			default:
			{
				num = (short)808058880;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1833172992;
			if (num != 0)
			{
			}
			num = (short)2000093185;
			if (num != 0)
			{
			}
			return this.a();
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00099AA4 File Offset: 0x00097CA4
		private int? a()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num4;
			int? value;
			for (;;)
			{
				IL_0A:
				int? num2;
				int num3;
				switch (num)
				{
				case 0:
					if (num2.GetValueOrDefault() > num3 & num2 != null)
					{
						num4 = (short)1720123393;
						if (num4 != 0)
						{
						}
						num4 = (short)600702979;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					return value;
				case 1:
					num4 = (short)554041350;
					num = (int)((global::System.IntPtr)num4);
					continue;
				case 2:
					if (num2.GetValueOrDefault() == num3 & num2 != null)
					{
						num4 = (short)973996036;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					num2 = value;
					num3 = 12;
					num4 = (short)955711488;
					num = (int)((global::System.IntPtr)num4);
					continue;
				case 3:
				{
					num4 = (short)631697016;
					short num5 = num4;
					num4 = (short)1302785656;
					switch ((num5 == num4) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15B;
					default:
						goto IL_141;
					}
					break;
				}
				case 4:
					goto IL_1A4;
				case 5:
				{
					num4 = (short)204013568;
					short num6 = num4;
					if (value != null)
					{
						num4 = (short)1810038785;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					return value;
				}
				case 6:
					if (this.Is24HourFormat)
					{
						num4 = (short)1926627335;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					goto IL_15B;
				case 7:
					return value;
				}
				goto IL_30;
				IL_15B:
				num2 = value;
				num3 = 0;
				num4 = (short)420806658;
				num = (int)((global::System.IntPtr)num4);
			}
			IL_141:
			num4 = (short)3866624;
			if (num4 != 0)
			{
			}
			return new int?(value.Value - 12);
			IL_1A4:
			return new int?(12);
			IL_30:
			value = base.Value;
			num4 = (short)1090781189;
			num = (int)((global::System.IntPtr)num4);
			goto IL_0A;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00099CAC File Offset: 0x00097EAC
		public global::DevComponents.WpfEditors.Primitives.eHourPeriod Period
		{
			get
			{
				short num2;
				for (;;)
				{
					int? value = base.Value;
					int num = 12;
					if (value.GetValueOrDefault() >= num & value != null)
					{
						return global::DevComponents.WpfEditors.Primitives.eHourPeriod.PM;
					}
					num2 = (short)1159397377;
					if (num2 != 0)
					{
					}
					num2 = (short)1290862592;
					short num3 = num2;
					num2 = (short)67261297;
					short num4 = num2;
					num2 = (short)1290687345;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A8;
					}
				}
				IL_A8:
				num2 = (short)208797696;
				if (num2 != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eHourPeriod.AM;
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00099D7C File Offset: 0x00097F7C
		protected override bool ValidateNewInputStack(string s)
		{
			short num = (short)1544880135;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					if (s.Length > 0)
					{
						num = (short)481099784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 2:
				{
					num = (short)2025996827;
					short num3 = num;
					num = (short)36586011;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1597374464;
						if (num != 0)
						{
						}
						int num4;
						if (num4 >= 0)
						{
							goto IL_203;
						}
						break;
					}
					}
					num = (short)1960574981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					int num4;
					if (num4 > 24)
					{
						num = (short)431292416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				}
				case 4:
					num = (short)224067585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1266089987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					int num4;
					if (int.TryParse(s, out num4))
					{
						num = (short)1283129353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				}
				case 7:
					num = (short)752484353;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_76;
					}
					continue;
				case 8:
				{
					int num4 = 0;
					num = (short)1760624646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					num = (short)996933634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_76:
				num = (short)1462566912;
				short num5 = num;
				if (this.a)
				{
					goto IL_203;
				}
				num = (short)182321156;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_203:
			return base.ValidateNewInputStack(s);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00099F94 File Offset: 0x00098194
		global::DevComponents.WpfEditors.Primitives.eDateTimePart global::DevComponents.WpfEditors.Primitives.IDateTimePartInput.Part
		{
			get
			{
				short num = (short)844907639;
				short num2 = num;
				num = (short)1932805239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2114191360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)786890752;
				if (num != 0)
				{
				}
				num = (short)1568669697;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfEditors.Primitives.eDateTimePart.Hour;
			}
		}

		// Token: 0x04000302 RID: 770
		private new bool a = true;
	}
}
