using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000069 RID: 105
	internal class SubmitRadioPasteValueCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000302 RID: 770 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		protected override object ExecuteCmd(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1653538817;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (paras.Count<object>() <= 0)
					{
						num2 = (short)243531778;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				case 2:
					goto IL_13A;
				case 3:
				{
					num2 = (short)1391818958;
					short num3 = num2;
					num2 = (short)1861581006;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13A;
					default:
					{
						num2 = (short)404094976;
						short num4 = num2;
						num2 = (short)832831489;
						if (num2 != 0)
						{
						}
						num2 = (short)337510400;
						if (num2 != 0)
						{
						}
						if (paras != null)
						{
							num2 = (short)1663762432;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_FA;
					}
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_FA:
			throw new global::System.ArgumentNullException();
			IL_13A:
			goto IL_FA;
			IL_13C:
			global::Motorola.CommonCPS.RadioManagement.Command.SubmitRadioPasteValueCommand.<>c__DisplayClass0_0 CS$<>8__locals1;
			CS$<>8__locals1.radioModified = null;
			CS$<>8__locals1.context = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext);
			CS$<>8__locals1.tranferSuccess = false;
			CS$<>8__locals1.bw = new global::System.ComponentModel.BackgroundWorker();
			CS$<>8__locals1.bw.DoWork += delegate(object sender, global::System.ComponentModel.DoWorkEventArgs e)
			{
				short num5;
				try
				{
					num5 = (short)142082048;
					switch (num5)
					{
					default:
					{
						num5 = (short)1634271235;
						int num6 = (int)((global::System.IntPtr)num5);
						for (;;)
						{
							switch (num6)
							{
							case 0:
								goto IL_19A;
							case 1:
								CS$<>8__locals1.radioModified = CS$<>8__locals1.<>4__this.LocalService.SubmitRadioPasteValue(CS$<>8__locals1.context.ToPasteradio, CS$<>8__locals1.context.ValidateRadio, CS$<>8__locals1.context.TransferRadioIdentityForServer);
								num5 = (short)893190149;
								num6 = (int)((global::System.IntPtr)num5);
								continue;
							case 2:
								goto IL_19A;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_67;
								}
								continue;
							case 4:
								CS$<>8__locals1.context.ToPasteradio.CopyFrom(CS$<>8__locals1.radioModified);
								CS$<>8__locals1.tranferSuccess = true;
								num5 = (short)703791106;
								num6 = (int)((global::System.IntPtr)num5);
								continue;
							case 5:
								if (CS$<>8__locals1.radioModified != null)
								{
									num5 = (short)1242497028;
									num6 = (int)((global::System.IntPtr)num5);
									continue;
								}
								goto IL_19A;
							case 6:
								num5 = (short)1115226120;
								num6 = (int)((global::System.IntPtr)num5);
								continue;
							case 7:
								goto IL_1B2;
							case 8:
								if (CS$<>8__locals1.context.TransferRadioIdentityForServer.Count > 0)
								{
									num5 = (short)1817313281;
									num6 = (int)((global::System.IntPtr)num5);
									continue;
								}
								goto IL_CD;
							}
							IL_67:
							if (CS$<>8__locals1.context.TransferRadioIdentityForServer != null)
							{
								num5 = (short)764215302;
								num6 = (int)((global::System.IntPtr)num5);
								continue;
							}
							IL_CD:
							CS$<>8__locals1.tranferSuccess = true;
							num5 = (short)1509556224;
							num6 = (int)((global::System.IntPtr)num5);
							continue;
							IL_19A:
							num5 = (short)1621491719;
							num6 = (int)((global::System.IntPtr)num5);
						}
						IL_1B2:
						break;
					}
					}
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					global::Motorola.CommonCPS.RadioManagement.Command.SubmitRadioPasteValueCommand.<>c__DisplayClass0_1 CS$<>8__locals2 = new global::Motorola.CommonCPS.RadioManagement.Command.SubmitRadioPasteValueCommand.<>c__DisplayClass0_1();
					CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
					global::Motorola.Common.CustomException.CommonException ex2 = ex;
					CS$<>8__locals2.ex = ex2;
					CS$<>8__locals1.<>4__this.Interaction.HideWaitingIndicator();
					if (CS$<>8__locals2.ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
					{
						goto IL_215;
					}
					if (CS$<>8__locals2.ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
					{
						goto IL_215;
					}
					IL_1EF:
					global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						int a_ = 17;
						short num9 = (short)1885667329;
						if (num9 != 0)
						{
						}
						num9 = (short)1009329798;
						short num10 = num9;
						num9 = (short)1049896582;
						switch (num10 == num9)
						{
						default:
						{
							num9 = (short)2142961664;
							short num11 = num9;
							break;
						}
						case true:
							break;
						}
						num9 = (short)402718720;
						if (num9 != 0)
						{
						}
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RadioIdentityTransfer_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("∁", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(CS$<>8__locals2.ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					}), global::System.Array.Empty<object>());
					goto IL_306;
					IL_215:
					num5 = (short)2045303604;
					short num7 = num5;
					num5 = (short)892394292;
					switch ((num7 == num5) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num5 = (short)61734912;
						if (num5 != 0)
						{
						}
						if (string.IsNullOrWhiteSpace(CS$<>8__locals2.ex.Message))
						{
							goto IL_1EF;
						}
						break;
					}
					num5 = (short)307298305;
					if (num5 != 0)
					{
					}
					string errorMessage = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null);
					global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						int a_ = 17;
						short num9 = (short)30193848;
						short num10 = num9;
						num9 = (short)592230584;
						switch (num10 == num9)
						{
						}
						num9 = (short)2293760;
						short num11 = num9;
						num9 = (short)1179844609;
						if (num9 != 0)
						{
						}
						num9 = (short)224460800;
						if (num9 != 0)
						{
						}
						CS$<>8__locals2.CS$<>8__locals1.<>4__this.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RadioIdentityTransfer_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("∁", a_) + errorMessage, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					}), global::System.Array.Empty<object>());
					IL_306:;
				}
				catch (global::System.Exception)
				{
					string errorMessage = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null);
					global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						int a_ = 18;
						short num9 = (short)1467096545;
						short num10 = num9;
						num9 = (short)376053217;
						switch (num10 == num9)
						{
						}
						num9 = (short)568066048;
						short num11 = num9;
						num9 = (short)1470758913;
						if (num9 != 0)
						{
						}
						num9 = (short)75431936;
						if (num9 != 0)
						{
						}
						CS$<>8__locals1.<>4__this.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RadioIdentityTransfer_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("⌂", a_) + errorMessage, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					}), global::System.Array.Empty<object>());
				}
				num5 = (short)781647872;
				short num8 = num5;
			};
			CS$<>8__locals1.bw.RunWorkerCompleted += delegate(object sender, global::System.ComponentModel.RunWorkerCompletedEventArgs e)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num5;
				short num6;
				for (;;)
				{
					IL_0A:
					switch (num5)
					{
					case 0:
					{
						num6 = (short)1817626651;
						short num7 = num6;
						num6 = (short)1865205787;
						switch ((num7 == num6) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num6 = (short)1873281024;
							if (num6 != 0)
							{
							}
							global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Title_RadioIdentityTransfer_Success, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_RadioIdentityTransfer);
							num6 = (short)495321089;
							num5 = (int)((global::System.IntPtr)num6);
							continue;
						}
						break;
					}
					case 1:
						goto IL_FF;
					case 2:
						if (CS$<>8__locals1.tranferSuccess)
						{
							num6 = (short)1939013632;
							short num8 = num6;
							num6 = (short)1183973376;
							num5 = (int)((global::System.IntPtr)num6);
							continue;
						}
						goto IL_127;
					}
					goto IL_1C;
				}
				IL_FF:
				num6 = (short)853016577;
				if (num6 != 0)
				{
				}
				IL_127:
				CS$<>8__locals1.bw.Dispose();
				return;
				IL_1C:
				CS$<>8__locals1.<>4__this.Interaction.HideWaitingIndicator();
				num6 = (short)2111635458;
				num5 = (int)((global::System.IntPtr)num6);
				goto IL_0A;
			};
			CS$<>8__locals1.bw.RunWorkerAsync();
			base.Interaction.ShowWaitingIndicator();
			return CS$<>8__locals1.context.ToPasteradio;
			IL_20:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Command.SubmitRadioPasteValueCommand.<>c__DisplayClass0_0();
			CS$<>8__locals1.<>4__this = this;
			num2 = (short)673710083;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
