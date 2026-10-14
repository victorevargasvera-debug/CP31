using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000031 RID: 49
	public class TypeComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery>
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x0001B10C File Offset: 0x0001930C
		public bool Equals(global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery x, global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery y)
		{
			short num = (short)1678704646;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_62;
				case 1:
					num = (short)702087172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_12F;
				case 3:
					if (x.IshPartition == y.IshPartition)
					{
						num = (short)1594556423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
				{
					num = (short)359727104;
					short num3 = num;
					if (y == null)
					{
						num = (short)649658370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)288227331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					if (x != null)
					{
						num = (short)1651769345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 7:
					goto IL_A4;
				}
				IL_45:
				if (x == y)
				{
					num = (short)1083506688;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1682374661;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_62:
			num = (short)2056586971;
			short num4 = num;
			num = (short)123406043;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_12F:
				return false;
			default:
				num = (short)1329201152;
				if (num != 0)
				{
				}
				return true;
			}
			IL_A4:
			num = (short)45678593;
			if (num != 0)
			{
			}
			return x.IshType == y.IshType;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001B2E4 File Offset: 0x000194E4
		public int GetHashCode(global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery obj)
		{
			short num = (short)1514334509;
			short num2 = num;
			num = (short)328263981;
			switch (num2 == num)
			{
			}
			num = (short)1632894977;
			if (num != 0)
			{
			}
			num = (short)696516608;
			if (num != 0)
			{
			}
			num = (short)2021261312;
			short num3 = num;
			return obj.IshPartition.GetHashCode() ^ obj.IshType.GetHashCode();
		}
	}
}
