using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000061 RID: 97
	internal class CompleteJobCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002ED RID: 749 RVA: 0x0002C2DC File Offset: 0x0002A4DC
		public override bool CanExecute(params object[] paras)
		{
			int num;
			global::System.Collections.ICollection collection;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (collection.Count == 0)
						{
							num2 = (short)397672451;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_90;
					case 1:
						if (collection != null)
						{
							num2 = (short)958791682;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 2:
						num2 = (short)139132928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_8E;
					}
					goto IL_20;
				}
				return false;
				IL_8E:
				return false;
				IL_90:
				num2 = (short)349737454;
				short num3 = num2;
				num2 = (short)1682346478;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_29;
				case 1:
					break;
				default:
				{
					num2 = (short)1427243008;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)549584897;
				if (num2 != 0)
				{
				}
				num2 = (short)1653604352;
				if (num2 != 0)
				{
				}
				return this.a(collection);
			}
			}
			IL_20:
			collection = (paras[0] as global::System.Collections.ICollection);
			IL_29:
			num2 = (short)1126170625;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0002C41C File Offset: 0x0002A61C
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 17;
			short num;
			object result;
			try
			{
				num = (short)1530855424;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> rds;
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							goto IL_C2;
						case 1:
							if (base.Interaction.ShowCompleteRadioJobConfirmationDialog())
							{
								num = (short)645267458;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)555089923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.BatchOp.CompleteJobBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.CompleteJobBatchOp(rds);
							base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
							result = true;
							num = (short)1993474048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_E0;
						}
						goto IL_48;
					}
					IL_C2:
					return result;
					IL_E0:
					break;
					IL_48:
					rds = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
					num = (short)1721827329;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_CompleteJob_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("∁", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
			}
			num = (short)1029926443;
			short num3 = num;
			num = (short)51211819;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num = (short)2061238273;
				if (num != 0)
				{
				}
				num = (short)207486976;
				if (num != 0)
				{
				}
				num = (short)1965293568;
				short num4 = num;
				return false;
			}
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0002C618 File Offset: 0x0002A818
		private bool a(global::System.Collections.ICollection A_0)
		{
			short num = (short)2058682368;
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
				bool result;
				for (;;)
				{
					IL_27:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						num = (short)69533697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (A_0.Count != 0)
						{
							goto IL_223;
						}
						num = (short)1911411489;
						short num3 = num;
						num = (short)579916577;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22A;
						default:
							num = (short)1879638016;
							if (num != 0)
							{
							}
							num = (short)73072644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1808596993;
						if (num != 0)
						{
						}
						if (A_0 != null)
						{
							num = (short)1871839232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						try
						{
							num = (short)566820868;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = false;
									num = (short)1619853317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)281804806;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2;
									if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
									{
										num = (short)1747517440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)198115329;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = ((global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)enumerator.Current).JobStatus;
									global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED;
									num = (short)434831362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E2;
									}
									continue;
								case 5:
									goto IL_131;
								case 6:
									goto IL_1AA;
								}
								IL_E4:
								num = (short)1907818499;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E2:
								goto IL_E4;
							}
							IL_131:
							IL_1AA:
							return result;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1CC;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1B9:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1733820417;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_222;
								case 1:
									disposable.Dispose();
									num = (short)424607746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_220;
								}
								goto IL_1CC;
							}
							IL_220:
							IL_222:
							goto EndFinally_8;
							IL_1CC:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)441450496;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1B9;
							EndFinally_8:;
						}
						goto IL_223;
					case 4:
						return false;
					}
					goto IL_42;
					IL_22A:
					num = (short)1975255040;
					short num4 = num;
					num = (short)1305935875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_223:
					enumerator = A_0.GetEnumerator();
					goto IL_22A;
				}
				return false;
				IL_42:
				result = true;
				num = (short)443482114;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
