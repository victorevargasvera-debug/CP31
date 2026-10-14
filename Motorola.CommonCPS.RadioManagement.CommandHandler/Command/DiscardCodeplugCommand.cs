using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200009D RID: 157
	internal class DiscardCodeplugCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600039D RID: 925 RVA: 0x0003A964 File Offset: 0x00038B64
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)982450176;
			switch (num)
			{
			default:
			{
				num = (short)753139723;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
					switch (num2)
					{
					case 0:
					{
						if (observableCollection.Count == 0)
						{
							num = (short)631308290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = observableCollection.GetEnumerator();
						num = (short)2102591500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (paras.Count<object>() < 1)
						{
							num = (short)918618122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D8;
					case 2:
						return false;
					case 3:
					{
						num = (short)934281217;
						if (num != 0)
						{
						}
						num = (short)1348599808;
						short num3 = num;
						num = (short)428998656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1147797512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)74842113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return false;
					case 7:
						if (paras != null)
						{
							num = (short)1921318917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165;
					case 8:
						if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsReduceShareableSetMode)
						{
							num = (short)1008992262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					case 9:
						if (observableCollection != null)
						{
							num = (short)1015152643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						goto IL_581;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 12:
						try
						{
							num = (short)826540046;
							num2 = (int)((global::System.IntPtr)num);
							bool flag;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag = false;
									num = (short)978518022;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									bool? isOutOfSync;
									if (isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null)
									{
										num = (short)1537933325;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)933363727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									if (base.UIValidateService.IsRadioSwitchoverRequired(radioBase.JobStatus, radioBase.CruncherStatus))
									{
										num = (short)1748238346;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1439236099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									if (radioBase.UIChangeIndicator <= 0)
									{
										num = (short)978321412;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									flag = false;
									num = (short)19857419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_39B;
								case 6:
									goto IL_2CA;
								case 7:
								{
									num = (short)1336070473;
									short num4 = num;
									num = (short)1938542921;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_31C;
									default:
										goto IL_450;
									}
									break;
								}
								case 8:
									num = (short)100270087;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)580714504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
									bool? isOutOfSync = radioBase.IsOutOfSync;
									flag = true;
									num = (short)1255735297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_31C;
								case 11:
									goto IL_37B;
								case 12:
									goto IL_3BC;
								case 13:
									flag = false;
									num = (short)1481310220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									switch (0)
									{
									case 0:
										goto IL_20A;
									}
									continue;
								case 15:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									if (!base.UIValidateService.CanCreateJob(radioBase.JobStatus))
									{
										num = (short)693895168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1498152962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_20A;
								IL_31C:
								flag = false;
								num = (short)2030764037;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_31E:
								num = (short)141361161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20A:
								goto IL_31E;
							}
							IL_2CA:
							IL_37B:
							IL_39B:
							IL_3BC:
							return flag;
							IL_450:
							num = (short)649986048;
							if (num != 0)
							{
							}
							return true;
						}
						finally
						{
							num = (short)1905197058;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)392429569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4D5;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_49F;
									}
									continue;
								}
								IL_49F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1140654080;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4D5:;
						}
						goto IL_4D8;
					}
					IL_7A:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
					{
						num = (short)1449918468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_126:
					num = (short)1120796679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D8:
					observableCollection = (paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
					num = (short)1039466505;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_165:
				throw new global::System.ArgumentNullException();
				IL_581:
				goto IL_165;
			}
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0003AF18 File Offset: 0x00039118
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)502005760;
				switch (num)
				{
				default:
				{
					num = (short)649330705;
					int num2 = (int)((global::System.IntPtr)num);
					object result;
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext selectRadiosContext;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list2;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair> list3;
						switch (num2)
						{
						case 0:
							goto IL_4D7;
						case 1:
							num = (short)82116624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(selectRadiosContext.SelectedRadioPairs.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair pair)
							{
								short num5 = (short)1032501083;
								short num6 = num5;
								num5 = (short)1815197531;
								switch (num6 == num5)
								{
								}
								num5 = (short)1206714368;
								if (num5 != 0)
								{
								}
								num5 = (short)1525415936;
								short num7 = num5;
								num5 = (short)1667432449;
								if (num5 != 0)
								{
								}
								return pair.Radio;
							}));
							list.AddRange(list2);
							global::Motorola.CommonCPS.RadioManagement.BatchOp.DiscardCodeplugBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.DiscardCodeplugBatchOp(list);
							base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
							result = true;
							num = (short)1364787214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
							if (observableCollection != null)
							{
								num = (short)438108161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_51D;
						}
						case 4:
							if (list3.Count > 0)
							{
								num = (short)1743519753;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1470496774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							try
							{
								num = (short)287375366;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1115160581;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1265631232;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
										num = (short)825163779;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										if (this.a(radioBase))
										{
											num = (short)1789198340;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										list2.Add(radioBase);
										num = (short)1687814151;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
										list3.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair(radioBase, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Warning_PendingFeatures));
										num = (short)1793130498;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_380;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_298;
										}
										continue;
									}
									IL_32C:
									num = (short)1852637185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_298:
									goto IL_32C;
								}
								IL_380:
								goto IL_1C0;
							}
							finally
							{
								num = (short)912916482;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)849543169;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_3ED;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_3B7;
										}
										continue;
									}
									IL_3B7:
									if (enumerator == null)
									{
										break;
									}
									num = (short)358219776;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3ED:;
							}
							goto IL_3F0;
							IL_1C0:
							num = (short)1620639748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (base.Interaction.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Confirm_DiscardCodeplugChanges, global::Motorola.CommonCPS.ResourceRepository.Resources.DiscardCodeplugChanges))
							{
								num = (short)625147917;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_566;
						case 7:
							num = (short)1844707336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							if (paras.Count<object>() < 1)
							{
								num = (short)1187315727;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection = paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>;
							num = (short)1848049667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_3F0;
						case 10:
							goto IL_57E;
						case 11:
							goto IL_42F;
						case 12:
							num = (short)1997602818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
							global::Motorola.CommonCPS.RadioManagement.BatchOp.DiscardCodeplugBatchOp op2 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.DiscardCodeplugBatchOp(observableCollection.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>());
							base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op2);
							result = true;
							num = (short)2044526592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							goto IL_49C;
						case 15:
							goto IL_515;
						case 16:
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
							if (observableCollection.Count == 0)
							{
								num = (short)1305935890;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1250358932;
							short num3 = num;
							num = (short)1283913364;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_42F;
							default:
							{
								num = (short)1720057856;
								if (num != 0)
								{
								}
								list3 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioPair>();
								list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = observableCollection.GetEnumerator();
								num = (short)173604869;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 17:
							switch (0)
							{
							case 0:
								goto IL_9A;
							}
							continue;
						case 18:
							goto IL_123;
						}
						IL_9A:
						if (paras != null)
						{
							num = (short)1027145735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_517;
						IL_3F0:
						string rmc_DiscardChanges_SeleteRadios_ASTRO = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DiscardChanges_SeleteRadios_ASTRO;
						selectRadiosContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRadiosContext(list3, rmc_DiscardChanges_SeleteRadios_ASTRO, list2.Count > 0);
						base.Interaction.ShowSelectRadiosDialog(selectRadiosContext);
						num = (short)1938423819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_42F:
						if (selectRadiosContext.IsConfirmed)
						{
							num = (short)678363148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_566:
						num = (short)385155082;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_123:
					goto IL_51D;
					IL_49C:
					IL_4D7:
					return result;
					IL_515:
					IL_517:
					throw new global::System.ArgumentNullException();
					IL_51D:
					throw new global::System.ArgumentNullException();
					IL_57E:
					break;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DiscardCodeplugForDevice_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("∁", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
			}
			num = (short)246087680;
			short num4 = num;
			num = (short)463142913;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0003B590 File Offset: 0x00039790
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			while ((A_0.ChangeIndicator & 16) == 0)
			{
				short num = (short)18163083;
				short num2 = num;
				num = (short)546579851;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1401290752;
					if (num != 0)
					{
					}
					num = (short)2046558209;
					if (num != 0)
					{
					}
					num = (short)535429120;
					short num3 = num;
					return (A_0.ChangeIndicator & 32) != 0;
				}
				}
			}
			return true;
		}
	}
}
