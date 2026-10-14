using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000063 RID: 99
	internal class PasteRadioIdentityCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0002CBF0 File Offset: 0x0002ADF0
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::System.Collections.ICollection collection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return false;
				case 1:
					return false;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
					if (radioBase.DeviceUuid == global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.CopiedRadioIdentityRecordsToCopy.First<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>>().Key)
					{
						num2 = (short)1260126209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)372113416;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)804388874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1221875279;
					short num3 = num2;
					num2 = (short)1085560399;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num2 = (short)979107840;
						if (num2 != 0)
						{
						}
						num2 = (short)1354956805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.CopiedRadioIdentityRecordsToCopy.Count<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>>() > 0)
					{
						num2 = (short)231276551;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					goto IL_150;
				case 7:
					num2 = (short)1921974274;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
					if (!base.UIValidateService.CanCreateJob(radioBase.JobStatus))
					{
						num2 = (short)736428032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 9:
					if (collection != null)
					{
						num2 = (short)1425145859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 10:
				{
					if (collection.Count != 1)
					{
						num2 = (short)306511878;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = collection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>()[0];
					num2 = (short)950927360;
					short num4 = num2;
					num2 = (short)1577123851;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 11:
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.CopiedRadioIdentityRecordsToCopy != null)
					{
						num2 = (short)1255342081;
						if (num2 != 0)
						{
						}
						num2 = (short)381485060;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_40;
			}
			return false;
			IL_150:
			return false;
			IL_40:
			collection = (paras[0] as global::System.Collections.ICollection);
			num2 = (short)934805513;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0002CE88 File Offset: 0x0002B088
		protected override object ExecuteCmd(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Command.PasteRadioIdentityCommand.<>c__DisplayClass1_0 CS$<>8__locals1;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)374253414;
					short num3 = num2;
					num2 = (short)1435871078;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)816709633;
						if (num2 != 0)
						{
						}
						num2 = (short)498335744;
						if (num2 != 0)
						{
						}
						CS$<>8__locals1.tranferSuccess = false;
						CS$<>8__locals1.bw = new global::System.ComponentModel.BackgroundWorker();
						CS$<>8__locals1.bw.DoWork += delegate(object sender, global::System.ComponentModel.DoWorkEventArgs e)
						{
							short num5;
							try
							{
								num5 = (short)300023808;
								int num6 = (int)num5;
								switch (num6)
								{
								default:
								{
									switch (0)
									{
									case 0:
										goto IL_8E;
									}
									bool flag;
									for (;;)
									{
										IL_27:
										global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext copyPasteWarningContext;
										switch (num6)
										{
										case 0:
											if (CS$<>8__locals1.pasteRadioIdentityRecordsForServer.Count == 0)
											{
												num5 = (short)1878392843;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_45C;
										case 1:
											copyPasteWarningContext.FieldCannotPastedList = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo>(CS$<>8__locals1.cannotPasteList);
											num5 = (short)657260551;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										case 2:
											if (global::System.Windows.Application.Current != null)
											{
												num5 = (short)1847459857;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowCopyPasteWarningViewDialog(copyPasteWarningContext);
											num5 = (short)1151467525;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										case 3:
											num5 = (short)646512649;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										case 4:
											goto IL_45C;
										case 5:
											goto IL_45C;
										case 6:
											goto IL_FB;
										case 7:
											goto IL_35D;
										case 8:
											if (flag)
											{
												num5 = (short)613810194;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_FB;
										case 9:
											if (CS$<>8__locals1.cannotPasteList.Count > 0)
											{
												num5 = (short)1064370182;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_419;
										case 10:
											if (CS$<>8__locals1.pasteRadioIdentityRecordsForServer != null)
											{
												num5 = (short)891027469;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_250;
										case 11:
											goto IL_250;
										case 12:
											if (CS$<>8__locals1.cannotPasteList != null)
											{
												num5 = (short)522256385;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_35D;
										case 13:
											num5 = (short)1976893455;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										case 14:
											goto IL_45C;
										case 15:
											if (CS$<>8__locals1.pasteRadioIdentityRecordsForServer != null)
											{
												num5 = (short)1478623255;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_45C;
										case 16:
											goto IL_45C;
										case 17:
											global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
											{
												short num9 = (short)1383790293;
												short num10 = num9;
												num9 = (short)1103492821;
												switch (num10 == num9)
												{
												}
												num9 = (short)1968898048;
												short num11 = num9;
												num9 = (short)512950273;
												if (num9 != 0)
												{
												}
												num9 = (short)895680512;
												if (num9 != 0)
												{
												}
												global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowCopyPasteWarningViewDialog(copyPasteWarningContext);
											}), global::System.Array.Empty<object>());
											num5 = (short)1610481680;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										case 18:
											num5 = (short)663814164;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										case 19:
											if (CS$<>8__locals1.transferredRadio != null)
											{
												num5 = (short)810221589;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											num5 = (short)1308950538;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										case 20:
											if (CS$<>8__locals1.cannotPasteList != null)
											{
												num5 = (short)1843920899;
												num6 = (int)((global::System.IntPtr)num5);
												continue;
											}
											goto IL_419;
										case 21:
											CS$<>8__locals1.radioToPaste.CopyFrom(CS$<>8__locals1.transferredRadio);
											CS$<>8__locals1.tranferSuccess = true;
											num5 = (short)92798980;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										case 22:
											goto IL_475;
										case 23:
											num5 = (short)825229312;
											num6 = (int)((global::System.IntPtr)num5);
											continue;
										}
										goto IL_8E;
										IL_FB:
										copyPasteWarningContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.CopyPasteWarningContext();
										copyPasteWarningContext.HasInvalidData = !flag;
										copyPasteWarningContext.ValidateRadio = CS$<>8__locals1.validateRadio;
										copyPasteWarningContext.ToPasteradio = CS$<>8__locals1.radioToPaste;
										copyPasteWarningContext.TransferRadioIdentityForServer = CS$<>8__locals1.pasteRadioIdentityRecordsForServer;
										num5 = (short)314769420;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
										IL_250:
										CS$<>8__locals1.tranferSuccess = true;
										num5 = (short)1292894222;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
										IL_35D:
										num5 = (short)1744699394;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
										IL_419:
										num5 = (short)100990995;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
										IL_45C:
										num5 = (short)265814038;
										num6 = (int)((global::System.IntPtr)num5);
									}
									IL_475:
									break;
									IL_8E:
									flag = CS$<>8__locals1.<>4__this.LocalService.PasteRadioIdentity(CS$<>8__locals1.copiedRadioIdentityRecordsToCopy, CS$<>8__locals1.radioToPaste, out CS$<>8__locals1.pasteRadioIdentityRecordsForServer, out CS$<>8__locals1.transferredRadio, out CS$<>8__locals1.validateRadio, out CS$<>8__locals1.cannotPasteList);
									num5 = (short)1586954248;
									num6 = (int)((global::System.IntPtr)num5);
									goto IL_27;
								}
								}
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								global::Motorola.CommonCPS.RadioManagement.Command.PasteRadioIdentityCommand.<>c__DisplayClass1_2 CS$<>8__locals3 = new global::Motorola.CommonCPS.RadioManagement.Command.PasteRadioIdentityCommand.<>c__DisplayClass1_2();
								CS$<>8__locals3.CS$<>8__locals1 = CS$<>8__locals1;
								global::Motorola.Common.CustomException.CommonException ex2 = ex;
								CS$<>8__locals3.ex = ex2;
								CS$<>8__locals1.<>4__this.Interaction.HideWaitingIndicator();
								if (CS$<>8__locals3.ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
								{
									goto IL_588;
								}
								if (CS$<>8__locals3.ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
								{
									num5 = (short)78574510;
									short num7 = num5;
									num5 = (short)1696265134;
									switch ((num7 == num5) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num5 = (short)1653407744;
										if (num5 != 0)
										{
										}
										goto IL_588;
									}
								}
								IL_511:
								global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
								{
									int a_ = 18;
									short num9 = (short)383882731;
									short num10 = num9;
									num9 = (short)814192107;
									switch (num10 == num9)
									{
									}
									num9 = (short)1889206272;
									short num11 = num9;
									num9 = (short)1112276992;
									if (num9 != 0)
									{
									}
									num9 = (short)353239041;
									if (num9 != 0)
									{
									}
									CS$<>8__locals3.CS$<>8__locals1.<>4__this.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RadioIdentityTransfer_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("⌂", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(CS$<>8__locals3.ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
								}), global::System.Array.Empty<object>());
								goto IL_59F;
								IL_588:
								if (string.IsNullOrWhiteSpace(CS$<>8__locals3.ex.Message))
								{
									goto IL_511;
								}
								string errorMessage = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null);
								global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
								{
									short num9 = (short)960627138;
									short num10 = num9;
									num9 = (short)2026570178;
									switch (num10 == num9)
									{
									}
									num9 = (short)595853312;
									short num11 = num9;
									num9 = (short)1162084353;
									if (num9 != 0)
									{
									}
									num9 = (short)107151360;
									if (num9 != 0)
									{
									}
									CS$<>8__locals3.CS$<>8__locals1.<>4__this.Interaction.ShowNotificationDialog(errorMessage, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
								}), global::System.Array.Empty<object>());
								IL_59F:;
							}
							catch (global::System.Exception)
							{
								string errorMessage = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null);
								global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(delegate()
								{
									short num9 = (short)6019614;
									short num10 = num9;
									num9 = (short)555145758;
									switch (num10 == num9)
									{
									}
									num9 = (short)678232064;
									short num11 = num9;
									num9 = (short)1863450624;
									if (num9 != 0)
									{
									}
									num9 = (short)1882980353;
									if (num9 != 0)
									{
									}
									CS$<>8__locals1.<>4__this.Interaction.ShowNotificationDialog(errorMessage, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
								}), global::System.Array.Empty<object>());
							}
							num5 = (short)744554497;
							if (num5 != 0)
							{
							}
							num5 = (short)999620608;
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
									num6 = (short)9664368;
									short num7 = num6;
									num6 = (short)255489904;
									switch ((num7 == num6) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num6 = (short)1119092736;
										if (num6 != 0)
										{
										}
										global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RM_Title_RadioIdentityTransfer_Success, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_RadioIdentityTransfer);
										num6 = (short)1401552897;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									break;
								}
								case 1:
									goto IL_135;
								case 2:
								{
									num6 = (short)65404929;
									if (num6 != 0)
									{
									}
									num6 = (short)887095296;
									short num8 = num6;
									if (CS$<>8__locals1.tranferSuccess)
									{
										num6 = (short)1170866176;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									goto IL_137;
								}
								}
								goto IL_1C;
							}
							IL_135:
							IL_137:
							CS$<>8__locals1.bw.Dispose();
							return;
							IL_1C:
							CS$<>8__locals1.<>4__this.Interaction.HideWaitingIndicator();
							num6 = (short)1804206082;
							num5 = (int)((global::System.IntPtr)num6);
							goto IL_0A;
						};
						CS$<>8__locals1.bw.RunWorkerAsync();
						base.Interaction.ShowWaitingIndicator();
						num2 = (short)1536294913;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1A4;
				case 2:
					if (CS$<>8__locals1.copiedRadioIdentityRecordsToCopy != null)
					{
						num2 = (short)407633920;
						short num4 = num2;
						num2 = (short)1340997632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A6;
				}
				goto IL_1C;
			}
			IL_1A4:
			IL_1A6:
			return CS$<>8__locals1.radioToPaste;
			IL_1C:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Command.PasteRadioIdentityCommand.<>c__DisplayClass1_0();
			CS$<>8__locals1.<>4__this = this;
			global::System.Collections.ICollection source = paras[0] as global::System.Collections.ICollection;
			CS$<>8__locals1.radioToPaste = source.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>()[0];
			CS$<>8__locals1.transferredRadio = null;
			CS$<>8__locals1.validateRadio = null;
			CS$<>8__locals1.copiedRadioIdentityRecordsToCopy = global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.CopiedRadioIdentityRecordsToCopy;
			num2 = (short)1411383298;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
