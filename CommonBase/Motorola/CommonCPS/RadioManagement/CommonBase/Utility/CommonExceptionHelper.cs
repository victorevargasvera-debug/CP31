using System;
using System.ServiceModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Comparers;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x0200000C RID: 12
	public class CommonExceptionHelper
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000062CC File Offset: 0x000044CC
		public static void ConvertExceptiontAndThrow(global::System.Exception ex)
		{
			int a_ = 19;
			short num = (short)2062811136;
			switch (num)
			{
			default:
			{
				num = (short)360775691;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Common.CustomException.CommonException ex2;
				global::System.ServiceModel.FaultException ex3;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)722862081;
						if (num != 0)
						{
						}
						num = (short)271319059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (ex is global::System.TimeoutException)
						{
							num = (short)790691849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						num = (short)441647109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_43D;
					case 4:
						goto IL_17D;
					case 5:
						if (ex2.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
						{
							num = (short)600440847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 6:
						if (ex is global::System.ServiceModel.FaultException)
						{
							num = (short)1834024976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1341849610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_FD;
					case 8:
						ex2 = (ex as global::Motorola.Common.CustomException.CommonException);
						num = (short)1651572748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_321;
					case 10:
						if (ex is global::System.ServiceModel.CommunicationException)
						{
							num = (short)2098200589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1953759233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_3B;
					case 12:
						if (ex2.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
						{
							num = (short)127336450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 13:
						num = (short)2115174414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (ex is global::System.ServiceModel.EndpointNotFoundException)
						{
							num = (short)847773703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_189;
					case 15:
						goto IL_1E9;
					case 16:
						ex3 = null;
						ex3 = (global::System.ServiceModel.FaultException)ex;
						num = (short)1533083666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (ex is global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData>)
						{
							num = (short)1400569859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1029111814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (ex3 != null)
						{
							num = (short)193200128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 19:
					{
						num = (short)583991296;
						short num3 = num;
						if (global::System.Enum.IsDefined(typeof(global::Motorola.Common.CustomException.CommonErrorCode), ex3.Reason.ToString()))
						{
							num = (short)1601699844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					goto IL_9C;
					IL_3B:
					switch (0)
					{
					case 0:
						IL_9C:
						if (ex is global::Motorola.Common.CustomException.CommonException)
						{
							num = (short)1259274248;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)1169447765;
							short num4 = num;
							num = (short)1559780181;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3B;
							default:
								num = (short)1084686336;
								if (num != 0)
								{
								}
								num = (short)140836881;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						break;
					}
				}
				IL_FD:
				throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CommunicationServerNotAvailabe, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⑦٨٪lᩮὰᩲᙴᙶ൸ቺቼᅾ튀力쎌튒ﲜﶞ쒠", a_), null), ex);
				IL_17D:
				global::Motorola.Common.CustomException.CommonErrorCode errorID = (global::Motorola.Common.CustomException.CommonErrorCode)global::System.Enum.Parse(typeof(global::Motorola.Common.CustomException.CommonErrorCode), ex3.Reason.ToString());
				throw new global::Motorola.Common.CustomException.CommonException(errorID, global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(errorID.ToString()), ex3);
				IL_182:
				throw ex as global::Motorola.Common.CustomException.CommonException;
				IL_189:
				throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CommunicationServerCommunicationError, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⑦٨٪lᩮὰᩲᙴᙶ൸ቺቼᅾ튀力캌ﲐﺒ練ﲜ좠첢쮤\udba8\ud9aa슬\uddae", a_), null), ex);
				IL_1E9:
				throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(ex2.ErrorCode, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex2.ErrorCode.ToString(), null), ex);
				IL_321:
				throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CommunicationServerTimeout, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⑦٨٪lᩮὰᩲᙴᙶ൸ቺቼᅾ튀力\ud98cﲐ杖", a_), null), ex);
				IL_43D:
				global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData> faultException = ex as global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData>;
				string commonErrorMessageByID = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.Message.ToString(), null);
				throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(faultException.Detail.ErrorCode, commonErrorMessageByID, ex);
			}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000067A0 File Offset: 0x000049A0
		public static global::Motorola.Common.CustomException.CommonException CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode errorID, string message, global::System.Exception ex = null)
		{
			short num;
			if (ex != null)
			{
				num = (short)869002685;
				short num2 = num;
				num = (short)945876413;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1285488640;
					if (num != 0)
					{
					}
					num = (short)1120993281;
					if (num != 0)
					{
					}
					return new global::Motorola.Common.CustomException.CommonException(errorID, message, ex);
				}
			}
			num = (short)729415680;
			short num3 = num;
			return new global::Motorola.Common.CustomException.CommonException(errorID, message, new global::System.Exception());
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006864 File Offset: 0x00004A64
		public static global::Motorola.Common.CustomException.CommonException CreateDirectMessageCommonException(string message)
		{
			short num = (short)1338017928;
			short num2 = num;
			num = (short)521439368;
			switch (num2 == num)
			{
			}
			num = (short)140509185;
			if (num != 0)
			{
			}
			num = (short)91684864;
			if (num != 0)
			{
			}
			num = (short)1844772864;
			short num3 = num;
			return new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.DirectMsgCode, message);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006930 File Offset: 0x00004B30
		// Note: this type is marked as 'beforefieldinit'.
		static CommonExceptionHelper()
		{
			short num = (short)1399459304;
			short num2 = num;
			num = (short)957550056;
			switch (num2 == num)
			{
			}
			num = (short)1610481665;
			if (num != 0)
			{
			}
			num = (short)28639232;
			if (num != 0)
			{
			}
			num = (short)1094320128;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.DirectMsgCode = global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error;
		}

		// Token: 0x04000027 RID: 39
		public static readonly global::Motorola.Common.CustomException.CommonErrorCode DirectMsgCode;
	}
}
