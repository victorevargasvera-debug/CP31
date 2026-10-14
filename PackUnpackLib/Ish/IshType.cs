using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000012 RID: 18
	public abstract class IshType : global::System.IComparable<global::Motorola.Acp.PackUnpack.Ish.IshType>
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		protected IshType(string name, int value, bool isSingleInstance)
		{
			int a_ = 2;
			base..ctor();
			if (name == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("漢爵", a_));
			}
			if (value >= 1)
			{
				if (value <= 65533)
				{
					this.a = name;
					this.b = value;
					this.c = isSingleInstance;
					this.d = null;
					return;
				}
			}
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("漢쒠", a_));
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000F23C File Offset: 0x0000D43C
		internal string Name
		{
			get
			{
				short num = (short)177410950;
				short num2 = num;
				num = (short)614732678;
				switch (num2 == num)
				{
				}
				num = (short)1165033472;
				short num3 = num;
				num = (short)321060865;
				if (num != 0)
				{
				}
				num = (short)635895808;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		internal int Value
		{
			get
			{
				short num = (short)1941596889;
				short num2 = num;
				num = (short)1219193561;
				switch (num2 == num)
				{
				}
				num = (short)1899298816;
				short num3 = num;
				num = (short)1995767809;
				if (num != 0)
				{
				}
				num = (short)1379598336;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000F3A0 File Offset: 0x0000D5A0
		internal bool IsSingleInstance
		{
			get
			{
				short num = (short)1653407745;
				if (num != 0)
				{
				}
				num = (short)790840147;
				short num2 = num;
				num = (short)779567955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)855769088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)323158016;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000F450 File Offset: 0x0000D650
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000F500 File Offset: 0x0000D700
		public global::Motorola.Acp.PackUnpack.Ish.Partition Partition
		{
			get
			{
				short num = (short)164888577;
				if (num != 0)
				{
				}
				num = (short)1183041535;
				short num2 = num;
				num = (short)1009305599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)31588352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)457834496;
				if (num != 0)
				{
				}
				return this.d;
			}
			internal set
			{
				short num = (short)407079135;
				short num2 = num;
				num = (short)1362594015;
				switch (num2 == num)
				{
				}
				num = (short)1439105024;
				short num3 = num;
				num = (short)1922760705;
				if (num != 0)
				{
				}
				num = (short)1033306112;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
		public int CompareTo(global::Motorola.Acp.PackUnpack.Ish.IshType other)
		{
			switch (0)
			{
			case 0:
				goto IL_AC;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = 1;
					num3 = (short)822476806;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					num2 = this.a(other);
					num3 = (short)1270611986;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					if (other is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
					{
						num3 = (short)2046033942;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)175374368;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					if (other is global::Motorola.Acp.PackUnpack.Ish.ListListletType)
					{
						num3 = (short)700383263;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)2100625419;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					if (num2 == 0)
					{
						num3 = (short)1283981319;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num2;
				case 5:
					if (num2 == 0)
					{
						num3 = (short)505610264;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num2;
				case 6:
					goto IL_20D;
				case 7:
					num2 = this.a(other);
					num3 = (short)1532690442;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
					num2 = -1;
					num3 = (short)605093917;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					if (this is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
					{
						num3 = (short)837222419;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1739849744;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					goto IL_535;
				case 11:
					if (other is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
					{
						num3 = (short)993525760;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1513685006;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
					num3 = (short)1700331522;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 13:
					num2 = 1;
					num3 = (short)832372751;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 14:
					if (other is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
					{
						num3 = (short)763822114;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_579;
				case 15:
					goto IL_2CC;
				case 16:
					if (this is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
					{
						num3 = (short)943718412;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1313275905;
					if (num3 != 0)
					{
					}
					num3 = (short)1546387473;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 17:
					if (this is global::Motorola.Acp.PackUnpack.Ish.ListListletType)
					{
						num3 = (short)1157824533;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_32F;
				case 18:
					goto IL_4CA;
				case 19:
				{
					num3 = (short)724962518;
					short num4 = num3;
					num3 = (short)641600726;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2AC;
					default:
						num3 = (short)593952768;
						if (num3 != 0)
						{
						}
						num3 = (short)1815085083;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 20:
					goto IL_3D2;
				case 21:
					num3 = (short)200867843;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 22:
					num2 = this.b(other);
					num3 = (short)681181209;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 23:
					goto IL_2AC;
				case 24:
					num2 = this.a(other);
					num3 = (short)86835238;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 25:
					if (num2 == 0)
					{
						num3 = (short)897777665;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num2;
				case 26:
					goto IL_2EB;
				case 27:
					if (other is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
					{
						num3 = (short)961347619;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)617938980;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 28:
					num2 = -1;
					num3 = (short)1654521882;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 29:
					return num2;
				case 30:
					if (other is global::Motorola.Acp.PackUnpack.Ish.ListListletType)
					{
						num3 = (short)2063204360;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_510;
				case 31:
					num2 = this.b(other);
					num3 = (short)1152778245;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 32:
					if (other is global::Motorola.Acp.PackUnpack.Ish.CompositeType)
					{
						num3 = (short)888537101;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)694288414;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 33:
					num2 = -1;
					num3 = (short)744554516;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 34:
					num2 = 1;
					num3 = (short)2058682391;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 35:
					num2 = this.b(other);
					num3 = (short)1414070276;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 36:
					if (other is global::Motorola.Acp.PackUnpack.Ish.ListHeaderType)
					{
						num3 = (short)1973354529;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1497956389;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 37:
					if (other is global::Motorola.Acp.PackUnpack.Ish.ListListletType)
					{
						num3 = (short)1783758876;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_402;
				case 38:
					goto IL_4A6;
				}
				goto IL_AC;
			}
			IL_20D:
			IL_2AC:
			IL_2CC:
			IL_2EB:
			return num2;
			IL_32F:
			throw new global::System.InvalidCastException();
			IL_3D2:
			num3 = (short)820183040;
			short num5 = num3;
			return num2;
			IL_402:
			throw new global::System.InvalidCastException();
			IL_4A6:
			IL_4CA:
			return num2;
			IL_510:
			throw new global::System.InvalidCastException();
			IL_535:
			return num2;
			IL_579:
			throw new global::System.InvalidCastException();
			IL_AC:
			num2 = 0;
			num3 = (short)1067843593;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000FC00 File Offset: 0x0000DE00
		private int b(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num;
			for (;;)
			{
				num = (short)814088194;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (A_0.c)
						{
							num = (short)1480196100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 0;
					case 1:
						if (!this.c)
						{
							num = (short)1186791431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 0;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 3:
						return -1;
					case 4:
						goto IL_9C;
					case 5:
						if (!A_0.c)
						{
							num = (short)1621491715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C8;
					case 6:
						num = (short)721813509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)737148928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_45:
					if (this.c)
					{
						num = (short)1163132934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C8:
					num = (short)718733313;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9C:
				num = (short)1191510016;
				short num3 = num;
				num = (short)755394355;
				short num4 = num;
				num = (short)955148083;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_174;
				}
			}
			return -1;
			IL_174:
			num = (short)588251137;
			if (num != 0)
			{
			}
			num = (short)1618280448;
			if (num != 0)
			{
			}
			return 1;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000FDC4 File Offset: 0x0000DFC4
		private int a(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			short num = (short)2114191362;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return -1;
				case 1:
					return 1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					if (this.b > A_0.b)
					{
						num = (short)964755457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return 0;
				}
				for (;;)
				{
					IL_34:
					num = (short)866713601;
					if (num != 0)
					{
					}
					if (this.b < A_0.b)
					{
						break;
					}
					num = (short)40102663;
					short num3 = num;
					num = (short)243657479;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_BC;
					}
				}
				num = (short)1480785920;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BC:
				num = (short)54657024;
				short num4 = num;
				num = (short)1276575744;
				if (num != 0)
				{
				}
				num = (short)1118109699;
				num2 = (int)((global::System.IntPtr)num);
			}
			return -1;
		}

		// Token: 0x04000033 RID: 51
		private string a;

		// Token: 0x04000034 RID: 52
		private int b;

		// Token: 0x04000035 RID: 53
		private bool c;

		// Token: 0x04000036 RID: 54
		private global::Motorola.Acp.PackUnpack.Ish.Partition d;
	}
}
