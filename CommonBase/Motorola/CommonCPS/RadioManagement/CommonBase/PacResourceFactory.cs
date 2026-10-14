using System;

namespace Motorola.CommonCPS.RadioManagement.CommonBase
{
	// Token: 0x0200000B RID: 11
	public class PacResourceFactory
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00006194 File Offset: 0x00004394
		public static global::Motorola.CommonCPS.RadioManagement.CommonBase.IResource Instance()
		{
			short num = (short)458031106;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10E;
				case 1:
				{
					num = (short)94765056;
					short num3 = num;
					num = (short)1131598255;
					short num4 = num;
					num = (short)183882159;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1296433152;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.a = new global::Motorola.CommonCPS.RadioManagement.CommonBase.a();
						num = (short)1248722944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.a != null)
				{
					break;
				}
				num = (short)1623719937;
				if (num != 0)
				{
				}
				num = (short)579010561;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10E:
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.PacResourceFactory.a;
		}

		// Token: 0x04000026 RID: 38
		private static global::Motorola.CommonCPS.RadioManagement.CommonBase.IResource a;
	}
}
