using System;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200002D RID: 45
	public class IshTypeEqualityComparer : global::System.Collections.Generic.EqualityComparer<global::Motorola.Acp.PackUnpack.Ish.IshType>
	{
		// Token: 0x06000193 RID: 403 RVA: 0x000239D8 File Offset: 0x00021BD8
		internal IshTypeEqualityComparer()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000239EC File Offset: 0x00021BEC
		public override bool Equals(global::Motorola.Acp.PackUnpack.Ish.IshType x, global::Motorola.Acp.PackUnpack.Ish.IshType y)
		{
			short num = (short)897974272;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)412046922;
					short num3 = num;
					num = (short)195319370;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CA;
					default:
						num = (short)1462632448;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					}
					break;
				}
				case 1:
					return false;
				case 2:
					return false;
				case 3:
					if (x.Partition != y.Partition)
					{
						goto IL_CA;
					}
					goto IL_10E;
				}
				IL_81:
				if (x.Value != y.Value)
				{
					num = (short)1024786434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1975058435;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CA:
				num = (short)280035328;
				short num4 = num;
				num = (short)2085158913;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_10E:
			num = (short)625672193;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00023B30 File Offset: 0x00021D30
		public override int GetHashCode(global::Motorola.Acp.PackUnpack.Ish.IshType obj)
		{
			short num = (short)1152319488;
			short num2 = num;
			num = (short)2069522760;
			short num3 = num;
			num = (short)568879432;
			switch (num3 == num)
			{
			}
			num = (short)765722625;
			if (num != 0)
			{
			}
			num = (short)1661927424;
			if (num != 0)
			{
			}
			return obj.Value;
		}
	}
}
