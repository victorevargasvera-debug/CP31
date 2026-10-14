using System;
using System.ServiceModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;

namespace SpecialFeatures
{
	// Token: 0x0200000D RID: 13
	public class CommonExceptionHelper
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00005B64 File Offset: 0x00003D64
		internal static void ConvertExceptiontAndThrow(global::System.Exception ex)
		{
			short num = (short)1495203845;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.CustomException.CommonException ex2;
			for (;;)
			{
				num = (short)96665601;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (ex is global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData>)
					{
						num = (short)845283334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1062666248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_152;
				case 2:
					goto IL_195;
				case 3:
				{
					if (ex2.ErrorCode == global::SpecialFeatures.CommonExceptionHelper.DirectMsgCode)
					{
						num = (short)825360386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)514198087;
					short num3 = num;
					num = (short)1799490119;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_152;
					default:
						goto IL_223;
					}
					break;
				}
				case 4:
					num = (short)448725001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 6:
					goto IL_2DA;
				case 7:
					if (ex is global::System.TimeoutException)
					{
						num = (short)1372061696;
						short num4 = num;
						num = (short)2143158282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					if (ex is global::System.ServiceModel.CommunicationException)
					{
						num = (short)340983812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)971898887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (ex is global::System.ServiceModel.EndpointNotFoundException)
					{
						num = (short)1262288907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19A;
				case 10:
					goto IL_150;
				case 11:
					goto IL_29B;
				}
				IL_7C:
				if (ex is global::Motorola.Common.CustomException.CommonException)
				{
					num = (short)1377370113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)629080064;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_152:
				ex2 = (ex as global::Motorola.Common.CustomException.CommonException);
				num = (short)466550787;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_150:
			throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceTimeout, global::Motorola.CommonCPS.ResourceRepository.Resources.CommunicationServiceTimeout, ex);
			IL_195:
			throw ex;
			IL_19A:
			throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceCommunicationError, global::Motorola.CommonCPS.ResourceRepository.Resources.CommunicationServiceCommunicationError, ex);
			IL_223:
			num = (short)1339031552;
			if (num != 0)
			{
			}
			throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(ex2.ErrorCode, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex2.ErrorCode.ToString(), null), ex);
			IL_29B:
			throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceNotAvailabe, global::Motorola.CommonCPS.ResourceRepository.Resources.CommunicationServiceNotAvailabe, ex);
			IL_2DA:
			global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData> faultException = ex as global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData>;
			throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(faultException.Detail.ErrorCode, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(faultException.Detail.ErrorCode.ToString(), null), ex);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005E50 File Offset: 0x00004050
		public static global::Motorola.Common.CustomException.CommonException CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID, string message, global::System.Exception ex = null)
		{
			short num = (short)896385167;
			short num2 = num;
			num = (short)2112929935;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)494403584;
				if (num != 0)
				{
				}
				if (ex != null)
				{
					num = (short)1042874368;
					short num3 = num;
					return new global::Motorola.Common.CustomException.CommonException(errorID, message, ex);
				}
				break;
			}
			num = (short)1616379905;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.CustomException.CommonException(errorID, message, new global::System.Exception());
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005F14 File Offset: 0x00004114
		public static global::Motorola.Common.CustomException.CommonException CreateDirectMessageCommonException(string message)
		{
			short num = (short)367058114;
			short num2 = num;
			num = (short)176217282;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1058013184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)187564033;
			if (num != 0)
			{
			}
			num = (short)434241536;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.CustomException.CommonException(global::SpecialFeatures.CommonExceptionHelper.DirectMsgCode, message);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005FC8 File Offset: 0x000041C8
		// Note: this type is marked as 'beforefieldinit'.
		static CommonExceptionHelper()
		{
			short num = (short)15171632;
			short num2 = num;
			num = (short)262701104;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1785331712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1952251904;
			if (num != 0)
			{
			}
			num = (short)969736193;
			if (num != 0)
			{
			}
			global::SpecialFeatures.CommonExceptionHelper.DirectMsgCode = global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error;
		}

		// Token: 0x04000017 RID: 23
		public static readonly global::Motorola.Common.CustomException.CommonErrorCode DirectMsgCode;
	}
}
