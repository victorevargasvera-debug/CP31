using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000014 RID: 20
	public class ModifyItemCounterComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery>
	{
		// Token: 0x06000075 RID: 117 RVA: 0x000070F0 File Offset: 0x000052F0
		public bool Equals(global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery x, global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery y)
		{
			short num = (short)1514209288;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (x.IshID == y.IshID)
					{
						num = (short)908656653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					num = (short)560070668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1652031488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)451805191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (x.IshPartition == y.IshPartition)
					{
						num = (short)1877344257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					return true;
				case 6:
					goto IL_2A9;
				case 7:
					if (y == null)
					{
						num = (short)1442906118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)727384068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 9:
					goto IL_1F3;
				case 10:
					if (x.Counter == y.Counter)
					{
						num = (short)1289617417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 11:
				{
					num = (short)373227521;
					if (num != 0)
					{
					}
					if (x == null)
					{
						goto IL_24A;
					}
					num = (short)1269069072;
					short num3 = num;
					num = (short)654210320;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21F;
					default:
						num = (short)1227358208;
						if (num != 0)
						{
						}
						num = (short)774176771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 12:
					if (x.IshType == y.IshType)
					{
						goto IL_21F;
					}
					return false;
				case 13:
					num = (short)2027749386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5D:
				if (x == y)
				{
					num = (short)1191313413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)39780363;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21F:
				num = (short)286588930;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_1F3:
			return x.IsModified == y.IsModified;
			IL_24A:
			num = (short)1029439488;
			short num4 = num;
			return false;
			IL_2A9:
			goto IL_24A;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000073AC File Offset: 0x000055AC
		public int GetHashCode(global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery obj)
		{
			short num = (short)1889992704;
			short num2 = num;
			num = (short)687821584;
			short num3 = num;
			num = (short)348944;
			switch (num3 == num)
			{
			}
			num = (short)1636958209;
			if (num != 0)
			{
			}
			num = (short)1411579904;
			if (num != 0)
			{
			}
			return obj.IshPartition.GetHashCode() ^ obj.IshType.GetHashCode() ^ obj.IshID.GetHashCode() ^ obj.Counter.GetHashCode() ^ obj.IsModified.GetHashCode();
		}
	}
}
