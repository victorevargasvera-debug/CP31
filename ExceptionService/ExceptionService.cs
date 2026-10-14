using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000003 RID: 3
	public class ExceptionService
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002198 File Offset: 0x00000398
		protected virtual string GenericErrorCode
		{
			get
			{
				short num = (short)178819924;
				short num2 = num;
				num = (short)1349030740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1622999040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)917241856;
				if (num != 0)
				{
				}
				num = (short)560070657;
				if (num != 0)
				{
				}
				return global::Motorola.Common.CustomException.CommonErrorCode.GenericError.ToString();
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002254 File Offset: 0x00000454
		public static string Receive(global::System.Exception exception, bool allowShowNotification = false, bool showNotificationInPlace = false, bool showErrorCode = true)
		{
			short num = (short)527188948;
			short num2 = num;
			num = (short)1394295764;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1251475456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)130088961;
			if (num != 0)
			{
			}
			num = (short)2037448704;
			if (num != 0)
			{
			}
			int a_;
			string a_2;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.Instance.GetErrorCodeAndMessage(exception, out a_, out a_2);
			string text = global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.a(a_, a_2, showErrorCode);
			global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.a(exception, text, allowShowNotification, showNotificationInPlace);
			return text;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002320 File Offset: 0x00000520
		public static global::Motorola.Common.CustomException.CommonErrorCode? ReceiveErrorCode(global::System.Exception ex)
		{
			short num = (short)717336078;
			short num2 = num;
			num = (short)749907470;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1103298560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)136118273;
			if (num != 0)
			{
			}
			num = (short)920584192;
			if (num != 0)
			{
			}
			global::Motorola.Common.CustomException.CommonException ex2 = global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.a(ex);
			if (ex2 == null)
			{
				return null;
			}
			return new global::Motorola.Common.CustomException.CommonErrorCode?(ex2.ErrorCode);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023E8 File Offset: 0x000005E8
		private static global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService Instance
		{
			get
			{
				short num = (short)1913417432;
				short num2 = num;
				num = (short)150695640;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1192493056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2024275968;
				if (num != 0)
				{
				}
				num = (short)1607335937;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.a.a();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002498 File Offset: 0x00000698
		private static global::Microsoft.Practices.Prism.Events.IEventAggregator EventAggregator
		{
			get
			{
				short num = (short)1156972546;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1710948353;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.b = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>();
						num = (short)114819073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_111;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)1548384150;
					short num3 = num;
					num = (short)773420950;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1727528960;
						if (num != 0)
						{
						}
						num = (short)486539264;
						short num4 = num;
						if (global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.b != null)
						{
							goto IL_113;
						}
						break;
					}
					}
					num = (short)1157300224;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_111:
				IL_113:
				return global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.b;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025C0 File Offset: 0x000007C0
		protected virtual void GetErrorCodeAndMessage(global::System.Exception exception, out int errorCode, out string errorMessage)
		{
			int a_ = 15;
			short num = (short)926416896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				global::Motorola.Common.CustomException.CommonException ex;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						errorCode = (int)ex.ErrorCode;
						num = (short)2070740993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						errorMessage = ((ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.GenericError || ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error || ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Special_Display_Msg || ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenTimeout || ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Commit_Fail) ? ex.Message : global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null));
						num = (short)725942273;
						if (num != 0)
						{
						}
						num = (short)1029111810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)1238106122;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (errorCode == 2103)
									{
										num = (short)144048135;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_36F;
								case 1:
									if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
									{
										num = (short)1336934403;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_36F;
								case 2:
									goto IL_27F;
								case 3:
									num = (short)495583232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (ex.CommonExceptionData != null)
									{
										num = (short)314769416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27F;
								case 5:
									goto IL_388;
								case 6:
									goto IL_36F;
								case 7:
								{
									num = (short)1887137406;
									short num3 = num;
									num = (short)1175809662;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_27F;
									default:
										num = (short)504758272;
										if (num != 0)
										{
										}
										errorMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_CommunicationServerNotAvailabe_RN;
										num = (short)1257832454;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::System.IFormatProvider currentCulture = global::System.Globalization.CultureInfo.CurrentCulture;
									string format = errorMessage;
									object[] paramters = ex.CommonExceptionData.Paramters;
									errorMessage = string.Format(currentCulture, format, paramters);
									num = (short)517996546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)1962344452;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_1E8;
									}
									continue;
								}
								IL_1E8:
								if (!string.IsNullOrEmpty(errorMessage))
								{
									num = (short)1137770505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_27F:
								num = (short)1473314817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_36F:
								num = (short)1538785285;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_388:;
						}
						catch (global::System.Exception e)
						{
							string message = string.Concat(new string[]
							{
								global::<Module>.b("욢톤\udba8\ud9aa슬\uddae\udcb2톴튶햺\ud9bc꓀냂뛄ꛆ껈껊뛒꟔ꗖ뛘꧚郜뫞鋠郢蓤胦賨쯪퇬", a_),
								errorMessage,
								global::<Module>.b("龠莢첤풦覨좪슬솮ힰ\udfb2\udcb4풶춸鮺쪼횾뗀ꯂ韆꣈맊곌ꋎꗐ뛒꟔ꓖ律", a_),
								string.Join(global::<Module>.b("趠莢", a_), ex.CommonExceptionData.Paramters),
								global::<Module>.b("龠", a_)
							});
							global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.c.Error(e, message);
							errorMessage = string.Empty;
						}
						goto IL_407;
					case 3:
						errorMessage = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.Instance.GenericErrorCode, null);
						num = (short)317456389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (string.IsNullOrEmpty(errorMessage))
						{
							num = (short)1412956163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						return;
					case 6:
						if (ex != null)
						{
							num = (short)1950482432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_407;
					}
					goto IL_54;
					IL_407:
					num = (short)662175748;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_54:
				errorCode = -244210;
				errorMessage = string.Empty;
				ex = global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.a(exception);
				num = (short)1603403776;
				short num4 = num;
				num = (short)1499267078;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002A58 File Offset: 0x00000C58
		private static string a(int A_0, string A_1, bool A_2 = true)
		{
			int a_ = 10;
			short num = (short)1940586502;
			int num2 = (int)((global::System.IntPtr)num);
			string result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1C1;
				case 1:
					num = (short)1052442626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (A_2)
					{
						num = (short)1581907968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E9;
				case 3:
					if (A_0 != -244210)
					{
						num = (short)1784217605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E9;
				case 4:
					return result;
				case 5:
					result = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::<Module>.b("꺝\udd9f膡\udfa3钥銧骩톫햭膯쾱钳춵讷잹", a_), new object[]
					{
						global::Motorola.CommonCPS.ResourceRepository.Resources.Left_Square_Brackets,
						global::Motorola.CommonCPS.ResourceRepository.Resources.Right_Square_Brackets,
						A_0,
						A_1
					});
					num = (short)217579528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)291635201;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_77;
					}
					continue;
				case 7:
					return result;
				case 8:
					return result;
				}
				IL_77:
				if (string.IsNullOrEmpty(A_1))
				{
					result = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.Instance.GenericErrorCode, null);
					num = (short)1254031367;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)303639728;
				short num3 = num;
				num = (short)543632560;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1C1;
				default:
					num = (short)201129984;
					if (num != 0)
					{
					}
					num = (short)796262401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E9:
				num = (short)1159200768;
				short num4 = num;
				result = A_1;
				num = (short)1109917700;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C1:
				num = (short)310378499;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002C94 File Offset: 0x00000E94
		private static global::Motorola.Common.CustomException.CommonException a(global::System.Exception A_0)
		{
			short num = (short)588906497;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.CustomException.CommonException result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)291167685;
					short num3 = num;
					num = (short)711843269;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						goto IL_EB;
					}
					break;
				}
				case 1:
					goto IL_15;
				case 2:
				{
					num = (short)325124096;
					short num4 = num;
					if ((result = (A_0 as global::Motorola.Common.CustomException.CommonException)) == null)
					{
						num = (short)2054750208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 3:
					goto IL_4C;
				}
				goto IL_35;
				IL_15:
				switch (0)
				{
				case 0:
					IL_35:
					if (A_0 == null)
					{
						num = (short)1375076355;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1996947458;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_4C:
			return null;
			IL_EB:
			num = (short)1455685633;
			if (num != 0)
			{
			}
			num = (short)964952064;
			if (num != 0)
			{
			}
			result = global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.a(A_0.InnerException);
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002DD8 File Offset: 0x00000FD8
		private static void a(global::System.Exception A_0, string A_1, bool A_2, bool A_3)
		{
			int a_ = 0;
			short num = (short)1573388295;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				string text2;
				switch (num2)
				{
				case 0:
				{
					num = (short)1624834048;
					short num3 = num;
					text = string.Format(global::Motorola.Common.LogUtility.PredefinedName.DefaultCulture, global::<Module>.b("꒓醗鞙際醟\udfa1", a_), A_1, A_0.ToString());
					goto IL_264;
				}
				case 1:
					if (A_2)
					{
						num = (short)430505992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					return;
				case 3:
					if (!string.IsNullOrEmpty(A_1))
					{
						num = (short)168820741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E2;
				case 4:
					if (!global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.a)
					{
						num = (short)354287622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					num = (short)1874526208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_D0;
						}
						for (;;)
						{
							IL_B6:
							switch (num2)
							{
							case 0:
								goto IL_1B1;
							case 1:
								global::System.Windows.Forms.MessageBox.Show(A_1, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_Error);
								num = (short)640745475;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								while (!A_3)
								{
									global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.a(A_1, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_Error);
									num = (short)1164999767;
									short num4 = num;
									num = (short)1916697687;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)502398976;
										if (num != 0)
										{
										}
										num = (short)338427908;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_B6;
									}
								}
								num = (short)916783105;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_19A;
							case 4:
								goto IL_19A;
							}
							goto IL_D0;
							IL_19A:
							num = (short)707526656;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1B1:
						return;
						IL_D0:
						global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.a = true;
						num = (short)241106946;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_B6;
					}
					catch (global::System.Exception e)
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.c.Error(e, global::<Module>.b("솑ﲓ秊\udb99瞧춡쎣킧즩즫\udead쒯\udbb1\udbb3\ud8b5颷鞹鲻", a_) + text2);
						return;
					}
					finally
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.a = false;
					}
					goto IL_1E2;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 8:
					num = (short)93716484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					text = A_0.ToString();
					goto IL_264;
				}
				IL_56:
				if (A_0 == null)
				{
					num = (short)922746882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)792657923;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E2:
				num = (short)160301065;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_264:
				text2 = text;
				global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.c.Error(A_0, text2);
				num = (short)326369281;
				if (num != 0)
				{
				}
				num = (short)302055425;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003120 File Offset: 0x00001320
		private static void a(string A_0, string A_1)
		{
			short num = (short)641661673;
			short num2 = num;
			num = (short)2026306281;
			switch (num2 == num)
			{
			}
			num = (short)794427392;
			if (num != 0)
			{
			}
			num = (short)1011810305;
			if (num != 0)
			{
			}
			num = (short)1498152960;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext payload = new global::Motorola.CommonCPS.RadioManagement.UIModels.ErrorMessageContext(A_0);
			global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowErrorMessageDialogRequestedEvent>().Publish(payload);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000031F4 File Offset: 0x000013F4
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionService()
		{
			short num = (short)1296105736;
			short num2 = num;
			num = (short)178192648;
			switch (num2 == num)
			{
			}
			num = (short)1047855104;
			if (num != 0)
			{
			}
			num = (short)115736577;
			if (num != 0)
			{
			}
			num = (short)304087040;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ExceptionService.c = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);
		}

		// Token: 0x04000003 RID: 3
		protected const int InvalidErrorCode = -244210;

		// Token: 0x04000004 RID: 4
		private static bool a;

		// Token: 0x04000005 RID: 5
		private static global::Microsoft.Practices.Prism.Events.IEventAggregator b;

		// Token: 0x04000006 RID: 6
		private static global::Motorola.Common.LogUtility.ILog c;
	}
}
