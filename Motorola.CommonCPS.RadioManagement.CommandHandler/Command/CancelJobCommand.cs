using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000098 RID: 152
	internal class CancelJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600038D RID: 909 RVA: 0x00038DDC File Offset: 0x00036FDC
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1513440587;
			short num2 = num;
			num = (short)2034386251;
			global::System.Collections.ICollection collection;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_10D:
				if (collection.Count != 0)
				{
					return this.a(collection);
				}
				num = (short)222429186;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)364904448;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				break;
			}
			for (;;)
			{
				IL_56:
				switch (num3)
				{
				case 0:
				{
					num = (short)111935488;
					short num4 = num;
					if (collection != null)
					{
						num = (short)1294532609;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 1:
					num = (short)419495937;
					if (num != 0)
					{
					}
					num = (short)1990852611;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_12C;
				case 3:
					goto IL_10D;
				}
				goto IL_6C;
			}
			return false;
			IL_12C:
			return false;
			IL_6C:
			collection = (paras[0] as global::System.Collections.ICollection);
			num = (short)27590656;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_56;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00038F20 File Offset: 0x00037120
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1684537344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>.Enumerator enumerator;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> observableCollection2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1575092224;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_187;
									}
									continue;
								case 1:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus = radioBase.CruncherStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus cruncherStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.NONE;
									num = (short)1471021062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)454885379;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									radioBase = enumerator.Current;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_RUNNING;
									num = (short)1679622149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)876544007;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									num = (short)781155841;
									short num3 = num;
									num = (short)985628161;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
									{
										num = (short)1277034496;
										if (num != 0)
										{
										}
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2;
										if (jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null)
										{
											num = (short)945094657;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_189;
									}
									}
									break;
								}
								case 6:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus cruncherStatus2;
									if (cruncherStatus.GetValueOrDefault() == cruncherStatus2 & cruncherStatus != null)
									{
										num = (short)212467721;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_189;
								}
								case 7:
									goto IL_326;
								case 9:
									observableCollection.Add(radioBase);
									num = (short)885260296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_187;
								IL_189:
								observableCollection2.Add(radioBase);
								num = (short)1031798788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A8:
								num = (short)372178946;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_187:
								goto IL_1A8;
							}
							IL_326:
							goto IL_F5;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_339;
						IL_F5:
						num = (short)1326317572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_362;
					case 2:
						goto IL_F0;
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext selectRunningRadiosContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext();
						selectRunningRadiosContext.SelectRunningRadios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						selectRunningRadiosContext.Radios = observableCollection2;
						selectRunningRadiosContext.RunningRadios = observableCollection;
						base.Interaction.ShowSelectRunningRadiosDialog(selectRunningRadiosContext);
						num = (short)1288437762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (observableCollection.Count > 0)
						{
							num = (short)1711144963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_339;
					}
					goto IL_42;
					IL_339:
					global::Motorola.CommonCPS.RadioManagement.BatchOp.CancelJobBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.CancelJobBatchOp(observableCollection2);
					base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
					num = (short)194838529;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F0:
				goto IL_38B;
				IL_362:
				num = (short)140640257;
				if (num != 0)
				{
				}
				IL_38B:
				return true;
				IL_42:
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				observableCollection2 = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				enumerator = list.GetEnumerator();
				num = (short)1075314688;
				short num4 = num;
				num = (short)1888616448;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000392DC File Offset: 0x000374DC
		private bool a(global::System.Collections.ICollection A_0)
		{
			int a_ = 6;
			short num = (short)189857792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)207421440;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_75;
				}
				bool result;
				for (;;)
				{
					IL_5A:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1167654930;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_RUNNING;
									num = (short)1247019015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_262;
								case 2:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CREATED;
									num = (short)1432551441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									bool flag;
									if (!flag)
									{
										num = (short)1175257094;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_473;
								case 5:
									num = (short)1753350147;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									result = false;
									num = (short)1049100289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2;
									if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
									{
										num = (short)1600913424;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
									string text = jobStatus.ToString();
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED;
									if (!text.Contains(jobStatus2.ToString() + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꣶ", a_)))
									{
										num = (short)1801650181;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)718864395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = (global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)enumerator.Current;
									bool flag = base.UIValidateService.IsRadioSwitchoverRequired(radioBase.JobStatus, radioBase.CruncherStatus);
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_SCHEDULED;
									num = (short)1233125388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
									num = (short)1942552584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)1433731076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									num = (short)1488427473;
									short num4 = num;
									num = (short)758028753;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
									{
										num = (short)1930100736;
										if (num != 0)
										{
										}
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
										global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2;
										if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
										{
											num = (short)1794506752;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 13:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CODEPLUG_DOWNLOADED;
									num = (short)467271695;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2;
									if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
									{
										num = (short)1193279490;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 15:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2;
									if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
									{
										num = (short)2010513418;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 16:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = radioBase.JobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PENDING;
									num = (short)974258190;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2;
									if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
									{
										num = (short)1262747661;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 18:
									switch (0)
									{
									case 0:
										goto IL_11F;
									}
									continue;
								}
								IL_159:
								num = (short)423034889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11F:
								goto IL_159;
							}
							IL_262:
							IL_473:
							return result;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_495;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_482:
								switch (num2)
								{
								case 0:
									goto IL_4EA;
								case 1:
									disposable.Dispose();
									num = (short)1902837760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)1301413889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4EC;
								}
								goto IL_495;
							}
							IL_4EA:
							IL_4EC:
							goto EndFinally_14;
							IL_495:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1823604738;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_482;
							EndFinally_14:;
						}
						goto IL_4ED;
					case 1:
						goto IL_54C;
					case 2:
						num = (short)795344899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (A_0.Count == 0)
						{
							num = (short)1628372993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4ED;
					case 4:
						if (A_0 != null)
						{
							num = (short)893255682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_75;
					IL_4ED:
					enumerator = A_0.GetEnumerator();
					num = (short)1308229632;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_54C:
				num = (short)2135949313;
				if (num != 0)
				{
				}
				return false;
				IL_75:
				result = true;
				num = (short)388956164;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}
	}
}
