using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000081 RID: 129
	internal class QueryEIDCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000343 RID: 835 RVA: 0x000331F0 File Offset: 0x000313F0
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1057292292;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)274632852;
					short num3 = num;
					num = (short)1157533844;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_95;
					default:
						num = (short)1314324480;
						if (num != 0)
						{
						}
						if (registerRadioLicenseContext == null)
						{
							num = (short)1182400512;
							short num4 = num;
							num = (short)1156513797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)279773185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (!string.IsNullOrEmpty(registerRadioLicenseContext.EIDString))
					{
						num = (short)501809155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					goto IL_59;
				case 3:
					goto IL_95;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 5:
					return false;
				}
				IL_3D:
				if (paras.Length == 0)
				{
					num = (short)788332546;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
					num = (short)1329659904;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_59:
			num = (short)290127873;
			if (num != 0)
			{
			}
			return false;
			IL_95:
			return !string.IsNullOrEmpty(registerRadioLicenseContext.EIDString.Trim());
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0003338C File Offset: 0x0003158C
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 18;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
			short num2;
			int a_2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_59;
				}
				int num;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						if (new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("堂搄⨆猈䨊‌唎ℐ㸒Ⱄ䨖战⌚怜㈞稠䈢ࠤ崦栨ت眬Ἦᰰਲ栴䰶സ䘺ြ搾⁀湂㽄ن摈ᅊ経扎桐๒⹔捖⑘癚ٜ㹞䱠ᥢ⑤䩦㍨孪䁬噮Ɒࡲ䅴੶呸⁺ᱼ剾ﮀ슂ꢄ\udd86릈Ꚋ뒌튎ꊒꞔ", a_)).IsMatch(registerRadioLicenseContext.EIDString))
						{
							num2 = (short)1986723850;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_250;
					case 1:
						if (registerRadioLicenseContext.EIDString.Length > 36)
						{
							num2 = (short)666566667;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_353;
					case 2:
						goto IL_92;
					case 3:
						if (registerRadioLicenseContext.EIDHistory.Contains(registerRadioLicenseContext.EIDString))
						{
							num2 = (short)1547960325;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1206976518;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (paras.Length < 2)
						{
							num2 = (short)758906882;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
						a_2 = (int)paras[1];
						num2 = (short)1583677452;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_102;
					case 6:
						if (!string.IsNullOrEmpty(registerRadioLicenseContext.ExceptionMessage))
						{
							num2 = (short)843776008;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2CA;
					case 7:
						num2 = (short)72482817;
						if (num2 != 0)
						{
						}
						registerRadioLicenseContext.EIDString = registerRadioLicenseContext.EIDString.Trim();
						num2 = (short)2040987663;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						registerRadioLicenseContext.ExceptionMessage = string.Empty;
						num2 = (short)367460366;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						goto IL_207;
					case 10:
						num2 = (short)1094057985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						goto IL_149;
					case 12:
						if (registerRadioLicenseContext == null)
						{
							num2 = (short)776929289;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)649068557;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 13:
						if (!string.IsNullOrEmpty(registerRadioLicenseContext.EIDString))
						{
							num2 = (short)614203399;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_25B;
					case 14:
						goto IL_2CA;
					case 15:
						num2 = (short)1198325763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_59;
					IL_2CA:
					num2 = (short)201785344;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_149:
				num2 = (short)1208018874;
				short num3 = num2;
				num2 = (short)171501498;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_180;
				}
				IL_59:
				this.a = null;
				num2 = (short)1044840452;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			IL_92:
			return null;
			IL_102:
			return null;
			IL_180:
			num2 = (short)963379200;
			if (num2 != 0)
			{
			}
			num2 = (short)663552000;
			short num4 = num2;
			goto IL_250;
			IL_207:
			return null;
			IL_250:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Err_Invalid_EID);
			IL_25B:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Err_Invalid_EID);
			IL_353:
			this.a(registerRadioLicenseContext, a_2);
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000336F8 File Offset: 0x000318F8
		private void a(global::System.Collections.Generic.IReadOnlyList<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext A_1, int A_2)
		{
			short num = (short)1473642496;
			short num2 = num;
			num = (short)766967808;
			switch (num)
			{
			default:
			{
				num = (short)963575811;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)199884801;
						if (num != 0)
						{
						}
						if (A_0 != null)
						{
							num = (short)1809711112;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_463;
					case 1:
					{
						if (A_0.Count == 0)
						{
							num = (short)781713418;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1.EIDHistory.Add(A_1.EIDString);
						int count = A_1.EIDDetails.Count;
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> enumerator = A_0.GetEnumerator();
						num = (short)1403387906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_2E8;
						try
						{
							for (;;)
							{
								IL_2E8:
								num = (short)1735720963;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)611909636;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_39E;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)773521408;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail item = enumerator.Current;
										A_1.EIDDetails.Add(item);
										num = (short)1599209473;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_323;
										}
										continue;
									case 4:
										goto IL_3F3;
									}
									goto IL_323;
									IL_39E:
									num = (short)2088960002;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_323:
									num = (short)991656946;
									short num4 = num;
									num = (short)1486715890;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2E8;
									default:
										num = (short)1717895168;
										if (num != 0)
										{
										}
										goto IL_39E;
									}
								}
							}
							IL_3F3:
							goto IL_1F5;
						}
						finally
						{
							num = (short)1382481921;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> enumerator;
								switch (num3)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1715798018;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_42A;
									}
									continue;
								case 2:
									goto IL_460;
								}
								IL_42A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1120665600;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_460:;
						}
						goto IL_463;
						IL_1F5:
						num = (short)1420492805;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					case 4:
						num = (short)501547015;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						int count;
						if (count == 0)
						{
							num = (short)1893859340;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					}
					case 6:
						goto IL_24E;
					case 7:
						if (A_0[0].AvailableCount > 0)
						{
							num = (short)1022558222;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					case 8:
						num = (short)1703936001;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (A_0.Count == 1)
						{
							num = (short)1904345092;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					case 10:
						goto IL_14B;
					case 11:
						goto IL_18D;
					case 12:
						num = (short)451411977;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_CA;
					case 14:
						A_1.EIDDetails[0].IsSelected = true;
						A_1.SelectChangeSource = A_1.EIDDetails[0];
						num = (short)475594763;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AA:
					if (this.a != null)
					{
						num = (short)396689421;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)692715520;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_22E:
					A_1.SelectChangeSource = null;
					num = (short)1399128070;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_CA:
				global::Motorola.CommonCPS.RadioManagement.Command.QueryEIDCommand.a(A_1, this.a);
				return;
				IL_14B:
				goto IL_463;
				IL_18D:
				IL_24E:
				goto IL_476;
				IL_463:
				global::Motorola.Common.CustomException.CommonException a_ = new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Invalid_EID_ForotherRegOrRepeater);
				global::Motorola.CommonCPS.RadioManagement.Command.QueryEIDCommand.a(A_1, a_);
				return;
				IL_476:
				new global::Motorola.CommonCPS.RadioManagement.Command.FilterAvailableDevicesCommand().Execute(new object[]
				{
					A_1,
					A_2
				});
				return;
			}
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00033BB8 File Offset: 0x00031DB8
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext A_0, int A_1)
		{
			short num = (short)1008378682;
			short num2 = num;
			num = (short)538485562;
			switch (num2 == num)
			{
			}
			num = (short)562626561;
			if (num != 0)
			{
			}
			num = (short)304545792;
			short num3 = num;
			num = (short)1577385984;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> quearyDetailList = null;
			global::System.Threading.Tasks.Task.Run(delegate()
			{
				int a_ = 14;
				short num4;
				try
				{
					num4 = (short)1636742259;
					short num5 = num4;
					num4 = (short)1155445875;
					switch ((num5 == num4) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num4 = (short)1293352960;
						if (num4 != 0)
						{
						}
						global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.Command, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("껾琀昂眄縆⤈上䐌䬎ㄐ", a_)).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뫾䠀䜂", a_), A_0.EIDString), null);
						try
						{
							global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService manageRadioLicenseService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService;
							quearyDetailList = manageRadioLicenseService.GetEIDDetailList(A_0.EIDString);
						}
						finally
						{
							num4 = (short)1798701057;
							int num6 = (int)((global::System.IntPtr)num4);
							for (;;)
							{
								switch (num6)
								{
								case 0:
									automaticPerformanceMeasurer.Dispose();
									num4 = (short)507904002;
									num6 = (int)((global::System.IntPtr)num4);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E4;
									}
									continue;
								case 2:
									goto IL_118;
								}
								IL_E4:
								if (automaticPerformanceMeasurer == null)
								{
									break;
								}
								num4 = (short)1025376256;
								num6 = (int)((global::System.IntPtr)num4);
							}
							IL_118:;
						}
						break;
					}
					}
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					this.Interaction.HideWaitingIndicator();
					this.a = ex;
				}
				num4 = (short)1293942784;
				short num7 = num4;
				num4 = (short)1047134209;
				if (num4 != 0)
				{
				}
			}).GetAwaiter().OnCompleted(delegate
			{
				short num4 = (short)408616961;
				if (num4 != 0)
				{
				}
				num4 = (short)1063313375;
				short num5 = num4;
				num4 = (short)521658335;
				switch (num5 == num4)
				{
				}
				num4 = (short)1881866240;
				short num6 = num4;
				num4 = (short)168624128;
				if (num4 != 0)
				{
				}
				A_0.WaitingIndicatorVisibility = global::System.Windows.Visibility.Hidden;
				A_0.MainViewEnable = true;
				this.a(quearyDetailList, A_0, A_1);
				A_0.IsCompleted = true;
			});
			A_0.WaitingIndicatorVisibility = global::System.Windows.Visibility.Visible;
			A_0.MainViewEnable = false;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00033CC4 File Offset: 0x00031EC4
		private static void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase A_0, global::Motorola.Common.CustomException.CommonException A_1)
		{
			short num = (short)405078022;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.CustomException.CommonErrorCode errorCode;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_1.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.RMC_Special_Display_Msg)
					{
						num = (short)1644625925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
				case 1:
					num = (short)871301123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1592852480;
					short num3 = num;
					goto IL_9D;
				}
				case 3:
				{
					if (A_1.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
					{
						goto IL_1BE;
					}
					num = (short)1586531134;
					short num4 = num;
					num = (short)541690686;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9D;
					default:
						num = (short)1069088768;
						if (num != 0)
						{
						}
						num = (short)1950941186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_85;
				case 5:
					num = (short)1035665409;
					if (num != 0)
					{
					}
					errorCode = A_1.ErrorCode;
					num = (short)1848836100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 7:
					goto IL_1D5;
				}
				IL_44:
				if (A_1.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
				{
					num = (short)918290433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1BE;
				IL_9D:
				num = (short)749010944;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BE:
				num = (short)1358626823;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_85:
			string text = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(errorCode.ToString(), null);
			goto IL_1DD;
			IL_1D5:
			text = A_1.Message;
			IL_1DD:
			string exceptionMessage = text;
			A_0.ExceptionMessage = exceptionMessage;
		}

		// Token: 0x0400008E RID: 142
		private global::Motorola.Common.CustomException.CommonException a;
	}
}
