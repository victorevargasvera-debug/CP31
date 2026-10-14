using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000032 RID: 50
	public class ModifyTypeCounterComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery>
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x0001B3BC File Offset: 0x000195BC
		public bool Equals(global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery x, global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery y)
		{
			short num = (short)1219100681;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1106116609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (x.Counter == y.Counter)
					{
						num = (short)187564038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					goto IL_237;
				case 3:
					if (x.IshType == y.IshType)
					{
						num = (short)1912995840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					if (y == null)
					{
						num = (short)633929730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)18284555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (x != null)
					{
						goto IL_145;
					}
					return false;
				case 6:
				{
					num = (short)1136842416;
					short num3 = num;
					num = (short)1196218032;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_145;
					default:
						goto IL_196;
					}
					break;
				}
				case 7:
					num = (short)1239023619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1082654724;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 10:
					goto IL_6F;
				case 11:
					if (x.IshPartition == y.IshPartition)
					{
						num = (short)128581639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_54:
				if (x == y)
				{
					num = (short)876281866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1156775941;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_145:
				num = (short)777584648;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6F:
			num = (short)683999232;
			short num4 = num;
			return true;
			IL_196:
			num = (short)853737472;
			if (num != 0)
			{
			}
			return x.IsModified == y.IsModified;
			IL_237:
			num = (short)1912602625;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001B62C File Offset: 0x0001982C
		public int GetHashCode(global::Motorola.Common.Communication.Pba.TypeLevelChangeDiscovery obj)
		{
			short num = (short)629932033;
			if (num != 0)
			{
			}
			num = (short)1188055873;
			short num2 = num;
			num = (short)547965761;
			switch (num2 == num)
			{
			}
			num = (short)567738368;
			if (num != 0)
			{
			}
			num = (short)1091829760;
			short num3 = num;
			return obj.IshPartition.GetHashCode() ^ obj.IshType.GetHashCode() ^ obj.Counter.GetHashCode() ^ obj.IsModified.GetHashCode();
		}
	}
}
