using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200002A RID: 42
	public struct IshItemName : global::Motorola.Acp.PackUnpack.Ish.IIshItemName
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00022FE0 File Offset: 0x000211E0
		internal IshItemName(int A_0)
		{
			this.a = (A_0 >> 16 & 65535);
			this.b = (A_0 & 65535);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0002300C File Offset: 0x0002120C
		internal IshItemName(int A_0, int A_1)
		{
			int a_ = 8;
			if (A_0 != 0 && A_1 != 0)
			{
				if (A_0 >= 1)
				{
					if (A_0 <= 65533)
					{
						if (A_1 >= 0)
						{
							if (A_1 <= 65534)
							{
								goto IL_5B;
							}
						}
						throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얠", a_));
					}
				}
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\ud8a0펢삤", a_));
			}
			IL_5B:
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00023084 File Offset: 0x00021284
		internal static global::Motorola.Acp.PackUnpack.Ish.IshItemName Null
		{
			get
			{
				short num = (short)2070609921;
				if (num != 0)
				{
				}
				num = (short)872633103;
				short num2 = num;
				num = (short)25318159;
				switch (num2 == num)
				{
				}
				num = (short)1825898496;
				short num3 = num;
				num = (short)1933115392;
				if (num != 0)
				{
				}
				return global::Motorola.Acp.PackUnpack.Ish.IshItemName.c;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00023134 File Offset: 0x00021334
		public int Type
		{
			get
			{
				short num = (short)1038154807;
				short num2 = num;
				num = (short)763296823;
				switch (num2 == num)
				{
				}
				num = (short)863830017;
				if (num != 0)
				{
				}
				num = (short)1379532800;
				short num3 = num;
				num = (short)816578560;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000231E4 File Offset: 0x000213E4
		public int Id
		{
			get
			{
				short num = (short)293797889;
				if (num != 0)
				{
				}
				num = (short)1870622392;
				short num2 = num;
				num = (short)1615883960;
				switch (num2 == num)
				{
				default:
				{
					num = (short)686161920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)38469632;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00023294 File Offset: 0x00021494
		internal int Tag
		{
			get
			{
				short num = (short)2071241922;
				short num2 = num;
				num = (short)1170318530;
				switch (num2 == num)
				{
				}
				num = (short)1333854208;
				short num3 = num;
				num = (short)2126512129;
				if (num != 0)
				{
				}
				num = (short)1667629056;
				if (num != 0)
				{
				}
				return this.a << 16 | (this.b & 65535);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00023354 File Offset: 0x00021554
		internal bool IsNull
		{
			get
			{
				if (this.a == 0)
				{
					short num = (short)1508822217;
					short num2 = num;
					num = (short)1261030601;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					case 1:
						break;
					default:
					{
						num = (short)854654976;
						short num3 = num;
						break;
					}
					}
					num = (short)467468288;
					if (num != 0)
					{
					}
					num = (short)1275133953;
					if (num != 0)
					{
					}
					return this.b == 0;
				}
				return false;
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00023418 File Offset: 0x00021618
		public override int GetHashCode()
		{
			short num = (short)770784537;
			short num2 = num;
			num = (short)1774009625;
			switch (num2 == num)
			{
			}
			num = (short)172556288;
			short num3 = num;
			num = (short)2099380225;
			if (num != 0)
			{
			}
			num = (short)1970339840;
			if (num != 0)
			{
			}
			return base.GetHashCode();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000234D4 File Offset: 0x000216D4
		public override bool Equals(object obj)
		{
			short num;
			if (obj is global::Motorola.Acp.PackUnpack.Ish.IshItemName)
			{
				num = (short)633419599;
				short num2 = num;
				num = (short)1159673679;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_91;
				case 1:
					break;
				default:
				{
					num = (short)1669464064;
					short num3 = num;
					break;
				}
				}
				num = (short)455147520;
				if (num != 0)
				{
				}
				return this.Equals((global::Motorola.Acp.PackUnpack.Ish.IshItemName)obj);
			}
			IL_91:
			num = (short)897712129;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0002359C File Offset: 0x0002179C
		public bool Equals(global::Motorola.Acp.PackUnpack.Ish.IshItemName obj)
		{
			if (obj.a == this.a)
			{
				short num = (short)481070736;
				short num2 = num;
				num = (short)1633062544;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				case 1:
					break;
				default:
				{
					num = (short)1614807040;
					short num3 = num;
					break;
				}
				}
				num = (short)154402816;
				if (num != 0)
				{
				}
				num = (short)252510209;
				if (num != 0)
				{
				}
				return obj.b == this.b;
			}
			return false;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00023668 File Offset: 0x00021868
		public static bool operator ==(global::Motorola.Acp.PackUnpack.Ish.IshItemName a, global::Motorola.Acp.PackUnpack.Ish.IshItemName b)
		{
			short num = (short)1537524977;
			short num2 = num;
			num = (short)534168817;
			switch (num2 == num)
			{
			}
			num = (short)708050944;
			short num3 = num;
			num = (short)1365377025;
			if (num != 0)
			{
			}
			num = (short)2050031616;
			if (num != 0)
			{
			}
			return a.Equals(b);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00023718 File Offset: 0x00021918
		public static bool operator !=(global::Motorola.Acp.PackUnpack.Ish.IshItemName a, global::Motorola.Acp.PackUnpack.Ish.IshItemName b)
		{
			short num = (short)2015572286;
			short num2 = num;
			num = (short)1644966206;
			switch (num2 == num)
			{
			}
			num = (short)88014848;
			short num3 = num;
			num = (short)30670848;
			if (num != 0)
			{
			}
			num = (short)2138570753;
			if (num != 0)
			{
			}
			return !(a == b);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000237CC File Offset: 0x000219CC
		public static implicit operator int(global::Motorola.Acp.PackUnpack.Ish.IshItemName name)
		{
			short num = (short)1990164411;
			short num2 = num;
			num = (short)1282965435;
			switch (num2 == num)
			{
			}
			num = (short)2093088768;
			short num3 = num;
			num = (short)621346817;
			if (num != 0)
			{
			}
			num = (short)770310144;
			if (num != 0)
			{
			}
			return name.Tag;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00023878 File Offset: 0x00021A78
		internal static int a(int A_0, int A_1)
		{
			short num = (short)519266830;
			short num2 = num;
			num = (short)2061263374;
			switch (num2 == num)
			{
			}
			num = (short)1379074048;
			short num3 = num;
			num = (short)1434910721;
			if (num != 0)
			{
			}
			num = (short)153550848;
			if (num != 0)
			{
			}
			return A_0 << 16 | (A_1 & 65535);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00023930 File Offset: 0x00021B30
		// Note: this type is marked as 'beforefieldinit'.
		static IshItemName()
		{
			short num = (short)1146042994;
			short num2 = num;
			num = (short)1391344242;
			switch (num2 == num)
			{
			}
			num = (short)764477440;
			short num3 = num;
			num = (short)1108475904;
			if (num != 0)
			{
			}
			num = (short)1485832193;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400007F RID: 127
		private int a;

		// Token: 0x04000080 RID: 128
		private int b;

		// Token: 0x04000081 RID: 129
		private static global::Motorola.Acp.PackUnpack.Ish.IshItemName c;

		// Token: 0x04000082 RID: 130
		public const int MinTypeValue = 1;

		// Token: 0x04000083 RID: 131
		public const int MaxTypeValue = 65533;

		// Token: 0x04000084 RID: 132
		public const int MinIdValue = 0;

		// Token: 0x04000085 RID: 133
		public const int MaxIdValue = 65534;
	}
}
