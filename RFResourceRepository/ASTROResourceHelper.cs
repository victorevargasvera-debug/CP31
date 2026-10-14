using System;

namespace RFResourceRepository
{
	// Token: 0x02000009 RID: 9
	public class ASTROResourceHelper
	{
		// Token: 0x06004094 RID: 16532 RVA: 0x00348CE8 File Offset: 0x00346EE8
		public static global::RFResourceRepository.RFResourceHelperBase Instance()
		{
			short num = (short)706215937;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)965017600;
					short num3 = num;
					num = (short)1490747393;
					if (num != 0)
					{
					}
					global::RFResourceRepository.ASTROResourceHelper.a = new global::RFResourceRepository.ASTROResource();
					num = (short)1488125954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_10C;
				}
				IL_30:
				num = (short)5237810;
				short num4 = num;
				num = (short)105966642;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1638400;
					if (num != 0)
					{
					}
					if (global::RFResourceRepository.ASTROResourceHelper.a != null)
					{
						goto IL_10E;
					}
					break;
				}
				num = (short)191234048;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			IL_10E:
			return global::RFResourceRepository.ASTROResourceHelper.a;
		}

		// Token: 0x0400000F RID: 15
		private static global::RFResourceRepository.RFResourceHelperBase a;
	}
}
