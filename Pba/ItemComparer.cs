using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000013 RID: 19
	public class ItemComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery>
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00006DF0 File Offset: 0x00004FF0
		public bool Equals(global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery x, global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery y)
		{
			short num = (short)970850308;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_204;
				case 1:
					num = (short)900268037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return true;
				case 3:
					if (y == null)
					{
						num = (short)1663434752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)140247049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 5:
					if (x.IshType == y.IshType)
					{
						num = (short)1873084424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					num = (short)464781315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1310392320;
					short num3 = num;
					num = (short)275185665;
					if (num != 0)
					{
					}
					if (x != null)
					{
						num = (short)1449656326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 8:
					goto IL_1CE;
				case 9:
					if (x.IshPartition == y.IshPartition)
					{
						num = (short)1147404289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_4D:
				if (x == y)
				{
					num = (short)1809907714;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)910548857;
					short num4 = num;
					num = (short)1868488569;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)771751936;
						if (num != 0)
						{
						}
						num = (short)639041543;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			return true;
			IL_1CE:
			return x.IshID == y.IshID;
			IL_204:
			return false;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007008 File Offset: 0x00005208
		public int GetHashCode(global::Motorola.Common.Communication.Pba.ItemLevelChangeDiscovery obj)
		{
			short num = (short)608436224;
			short num2 = num;
			num = (short)1353823692;
			short num3 = num;
			num = (short)1569043916;
			switch (num3 == num)
			{
			}
			num = (short)704380928;
			if (num != 0)
			{
			}
			num = (short)720961537;
			if (num != 0)
			{
			}
			return obj.IshPartition.GetHashCode() ^ obj.IshType.GetHashCode() ^ obj.IshID.GetHashCode();
		}
	}
}
