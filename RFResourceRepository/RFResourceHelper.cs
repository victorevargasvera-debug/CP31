using System;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace RFResourceRepository
{
	// Token: 0x0200000E RID: 14
	public class RFResourceHelper
	{
		// Token: 0x060040A9 RID: 16553 RVA: 0x0034A3C0 File Offset: 0x003485C0
		public static void Init(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType curPac)
		{
			short num = (short)1267550069;
			short num2 = num;
			num = (short)1105217397;
			switch (num2 == num)
			{
			}
			num = (short)1693908993;
			if (num != 0)
			{
			}
			num = (short)312803328;
			short num3 = num;
			num = (short)744685568;
			if (num != 0)
			{
			}
			global::RFResourceRepository.RFResourceHelper.b = curPac;
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x0034A474 File Offset: 0x00348674
		public static global::RFResourceRepository.RFResourceHelperBase Instance()
		{
			short num = (short)382992384;
			short num2 = num;
			num = (short)573479316;
			short num3 = num;
			num = (short)1167038868;
			global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pactype;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DC:
				switch (pactype)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO:
				case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PBB:
					global::RFResourceRepository.RFResourceHelper.a = new global::RFResourceRepository.ASTROResource();
					num = (short)212205572;
					num4 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR:
					global::RFResourceRepository.RFResourceHelper.a = new global::RFResourceRepository.PCRResource();
					num = (short)588513283;
					num4 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.TETRA:
					goto IL_169;
				default:
					num = (short)155516930;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			default:
				num = (short)1389101057;
				if (num != 0)
				{
				}
				num = (short)849805312;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_C2;
				}
				break;
			}
			for (;;)
			{
				IL_A4:
				switch (num4)
				{
				case 0:
					goto IL_DC;
				case 1:
					goto IL_18B;
				case 2:
					num = (short)61014021;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_12B;
				case 4:
					goto IL_14E;
				case 5:
					goto IL_167;
				}
				goto IL_C2;
			}
			IL_12B:
			IL_14E:
			goto IL_18D;
			IL_167:
			goto IL_169;
			IL_18B:
			IL_18D:
			return global::RFResourceRepository.RFResourceHelper.a;
			IL_C2:
			pactype = global::RFResourceRepository.RFResourceHelper.b;
			num = (short)135987200;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A4;
			IL_169:
			global::RFResourceRepository.RFResourceHelper.a = new global::RFResourceRepository.RFResource();
			num = (short)1457586177;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A4;
		}

		// Token: 0x04000012 RID: 18
		private static global::RFResourceRepository.RFResourceHelperBase a;

		// Token: 0x04000013 RID: 19
		private static global::Motorola.CommonCPS.Server.CommonDBConstants.PACType b;
	}
}
