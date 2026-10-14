using System;
using System.Collections.Generic;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000170 RID: 368
	public sealed class RecordComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.CommonCPS.Server.EntityModel.IRecordSummary>
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x000D6878 File Offset: 0x000D4A78
		public bool Equals(global::Motorola.CommonCPS.Server.EntityModel.IRecordSummary x, global::Motorola.CommonCPS.Server.EntityModel.IRecordSummary y)
		{
			short num = (short)652476418;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1456144385;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1856140109;
					short num3 = num;
					num = (short)120484685;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_114;
					case 1:
						goto IL_DD;
					}
					goto Block_2;
				}
				case 1:
					goto IL_114;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 3:
					return true;
				}
				IL_5E:
				if (x == y)
				{
					num = (short)1942683651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2087387137;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_114:
				if (x == null)
				{
					return false;
				}
				num = (short)260833280;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			Block_2:
			num = (short)844234752;
			short num4 = num;
			IL_DD:
			num = (short)1759313920;
			if (num != 0)
			{
			}
			return x.Equals(y);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000D69BC File Offset: 0x000D4BBC
		public int GetHashCode(global::Motorola.CommonCPS.Server.EntityModel.IRecordSummary obj)
		{
			short num = (short)2024037516;
			short num2 = num;
			num = (short)458185868;
			switch (num2 == num)
			{
			}
			num = (short)63242240;
			short num3 = num;
			num = (short)1868562433;
			if (num != 0)
			{
			}
			num = (short)223739904;
			if (num != 0)
			{
			}
			return obj.GetHashCode();
		}
	}
}
