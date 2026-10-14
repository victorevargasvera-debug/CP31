using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200009C RID: 156
	internal class DeleteJobContainerCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600039A RID: 922 RVA: 0x0003A150 File Offset: 0x00038350
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1248329728;
			switch (num)
			{
			default:
			{
				num = (short)1773600774;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_43D;
					case 1:
					{
						num = (short)1715535872;
						short num3 = num;
						num = (short)503840775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_3FC;
					case 3:
						num = (short)715194372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection;
						if (observableCollection.Count == 0)
						{
							num = (short)2052194304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> enumerator = observableCollection.GetEnumerator();
						num = (short)919797761;
						if (num != 0)
						{
						}
						num = (short)111935490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_3B4;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 7:
					{
						if (paras.Count<object>() < 1)
						{
							num = (short)600965125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection = paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>;
						num = (short)296353800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection;
						if (observableCollection != null)
						{
							num = (short)36044803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					IL_6A:
					if (paras == null)
					{
						goto IL_370;
					}
					num = (short)85458945;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_370:
				throw new global::System.ArgumentNullException();
				IL_3B4:
				goto IL_370;
				IL_3FC:
				try
				{
					num = (short)1107427338;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.DateTime value;
							if (value.ToUniversalTime() > global::System.DateTime.UtcNow)
							{
								num = (short)906100748;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							num = (short)786007037;
							short num4 = num;
							num = (short)2095481853;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E2;
							default:
							{
								num = (short)1849425920;
								if (num != 0)
								{
								}
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)485228548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer = enumerator.Current;
								num = (short)469368834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer;
							if (!jobContainer.ForReadWrite)
							{
								num = (short)1859452933;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_2FD;
						case 4:
							num = (short)351207427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1031471110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer;
							if (jobContainer.TotalCount > jobContainer.ItemsCompleted)
							{
								goto IL_1E2;
							}
							break;
						}
						case 7:
						{
							global::System.DateTime? endTime;
							if (endTime != null)
							{
								num = (short)1773928456;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer;
							global::System.DateTime? endTime = jobContainer.EndTime;
							global::System.DateTime value = endTime.Value;
							num = (short)1144782848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer;
							global::System.DateTime? endTime = jobContainer.EndTime;
							num = (short)122421255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							switch (0)
							{
							case 0:
								goto IL_10E;
							}
							continue;
						case 11:
							goto IL_1B4;
						case 12:
							result = false;
							num = (short)1852768267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_110:
						num = (short)912523265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_10E:
						goto IL_110;
						IL_1E2:
						num = (short)1065746441;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1B4:
					return result;
					IL_2FD:
					return true;
				}
				finally
				{
					num = (short)996999169;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)292749314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_334;
							}
							continue;
						case 2:
							goto IL_36B;
						}
						IL_334:
						if (enumerator == null)
						{
							break;
						}
						num = (short)609026048;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_36B:;
				}
				return false;
				IL_43D:
				return false;
			}
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0003A604 File Offset: 0x00038804
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 15;
			short num;
			object result;
			try
			{
				num = (short)1801453568;
				switch (num)
				{
				default:
				{
					num = (short)1182597130;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection;
							if (observableCollection != null)
							{
								num = (short)671416332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_131;
						}
						case 1:
							num = (short)1061945350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_151;
						case 3:
							goto IL_229;
						case 4:
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection;
							if (base.Interaction.ShowDeleteJobsConfirmationDialog(observableCollection.Count))
							{
								num = (short)1070661643;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1432354819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_188;
						case 6:
						{
							if (paras.Count<object>() < 1)
							{
								num = (short)131081;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection = paras[0] as global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>;
							num = (short)2120220672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection;
							if (observableCollection.Count == 0)
							{
								num = (short)2071461896;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(observableCollection);
							num = (short)1145634820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_131;
						case 9:
							goto IL_12C;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_80;
							}
							continue;
						case 11:
						{
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> observableCollection;
							global::Motorola.CommonCPS.RadioManagement.BatchOp.DeleteJobContainerBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.DeleteJobContainerBatchOp(observableCollection.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>());
							base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(op);
							result = true;
							num = (short)605618181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)614924295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_80:
						if (paras != null)
						{
							num = (short)257622017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_131:
						result = false;
						num = (short)1324679170;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_9A:
					throw new global::System.ArgumentNullException();
					IL_12C:
					goto IL_9A;
					IL_151:
					IL_188:
					return result;
					IL_229:
					break;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeleteJobContainer_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("⃿", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
			}
			num = (short)737542145;
			if (num != 0)
			{
			}
			num = (short)1258352953;
			short num3 = num;
			num = (short)1904931129;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num = (short)361693184;
				short num4 = num;
				num = (short)2027945984;
				if (num != 0)
				{
				}
				return false;
			}
			}
		}
	}
}
