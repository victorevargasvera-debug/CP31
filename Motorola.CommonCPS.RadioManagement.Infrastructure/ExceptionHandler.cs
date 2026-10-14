using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.LocalService;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000039 RID: 57
	public class ExceptionHandler
	{
		// Token: 0x0600015F RID: 351 RVA: 0x000148B8 File Offset: 0x00012AB8
		public static string Receive(global::System.Exception exception, bool allowShowNotification = false, bool showNotificationInPlace = false)
		{
			short num = (short)1892808486;
			short num2 = num;
			num = (short)883291942;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C6:
				num = (short)984350720;
				short num3 = num;
				allowShowNotification = false;
				num = (short)1690042370;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)266141696;
				if (num != 0)
				{
				}
				num = (short)1816526848;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_7E;
					}
					continue;
				case 1:
					goto IL_C4;
				case 2:
					goto IL_109;
				}
				IL_7E:
				num = (short)325582849;
				if (num != 0)
				{
				}
				if (!global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.a(exception))
				{
					goto IL_10B;
				}
				num = (short)381878273;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_C4:
			goto IL_C6;
			IL_109:
			IL_10B:
			return global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.Receive(exception, allowShowNotification, showNotificationInPlace, true);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000149DC File Offset: 0x00012BDC
		private static bool a(global::System.Exception A_0)
		{
			short num = (short)1727725568;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				bool flag2;
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					flag = false;
					goto IL_17D;
				case 2:
					num = (short)1973616646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1010761733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					flag2 = false;
					goto IL_EC;
				case 5:
				{
					global::Motorola.Common.CustomException.CommonException ex = A_0 as global::Motorola.Common.CustomException.CommonException;
					if (ex == null)
					{
						num = (short)689242113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_PreShared_Key_Mismatch);
					goto IL_17D;
				}
				case 6:
					goto IL_1B0;
				}
				goto IL_40;
				IL_14:
				switch (0)
				{
				case 0:
				{
					IL_40:
					global::Motorola.Common.CustomException.CommonException ex2 = A_0 as global::Motorola.Common.CustomException.CommonException;
					if (ex2 != null)
					{
						flag2 = (ex2.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Handshake_Failed);
						goto IL_EC;
					}
					num = (short)1530399447;
					short num3 = num;
					num = (short)1639713495;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					case 1:
						break;
					default:
					{
						num = (short)1762983936;
						short num4 = num;
						break;
					}
					}
					num = (short)1332150272;
					if (num != 0)
					{
					}
					num = (short)1740439556;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				continue;
				IL_EC:
				if (!flag2)
				{
					num = (short)1052770305;
					if (num != 0)
					{
					}
					num = (short)1961558019;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_17D:
				if (flag)
				{
					return true;
				}
				num = (short)1287520258;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1B0:
			global::Motorola.Common.CustomException.CommonException ex3 = A_0 as global::Motorola.Common.CustomException.CommonException;
			return ex3 != null && ex3.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_PreShared_Key_Missing;
		}
	}
}
