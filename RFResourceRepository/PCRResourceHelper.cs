using System;

namespace RFResourceRepository
{
	// Token: 0x0200000C RID: 12
	public class PCRResourceHelper
	{
		// Token: 0x060040A2 RID: 16546 RVA: 0x00349A90 File Offset: 0x00347C90
		public static global::RFResourceRepository.RFResourceHelperBase Instance()
		{
			short num = (short)1420886017;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					global::RFResourceRepository.PCRResourceHelper.a = new global::RFResourceRepository.PCRResource();
					num = (short)1800339458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_10B;
				}
				IL_31:
				num = (short)188876204;
				short num3 = num;
				num = (short)1349125548;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2063073281;
					if (num != 0)
					{
					}
					num = (short)1680605184;
					if (num != 0)
					{
					}
					if (global::RFResourceRepository.PCRResourceHelper.a != null)
					{
						goto IL_10D;
					}
					break;
				}
				num = (short)377290752;
				short num4 = num;
				num = (short)740491264;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			IL_10D:
			return global::RFResourceRepository.PCRResourceHelper.a;
		}

		// Token: 0x04000011 RID: 17
		private static global::RFResourceRepository.RFResourceHelperBase a;
	}
}
