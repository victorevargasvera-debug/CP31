using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200009A RID: 154
	internal class DeleteDeviceCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000394 RID: 916 RVA: 0x00039B74 File Offset: 0x00037D74
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1346109445;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.ICollection collection;
			for (;;)
			{
				num = (short)212016152;
				short num3 = num;
				num = (short)426449944;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1386086400;
					short num4 = num;
					num = (short)972685312;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)1817247750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)2088828935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_148;
					case 3:
						if (collection != null)
						{
							num = (short)134414336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						return false;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_BA;
						}
						continue;
					case 6:
						num = (short)1651965953;
						if (num != 0)
						{
						}
						if (collection.Count == 0)
						{
							num = (short)1819082754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C6;
					case 7:
						if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsMaintenanceMode)
						{
							num = (short)2009726980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14A;
					}
					IL_BA:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
					{
						break;
					}
					IL_14A:
					collection = (paras[0] as global::System.Collections.ICollection);
					num = (short)919076867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				num = (short)1126367233;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_148:
			return false;
			IL_1C6:
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios = collection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			return base.UIValidateService.CanDeleteRadio(radios);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00039D60 File Offset: 0x00037F60
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 7;
			short num;
			object result;
			try
			{
				num = (short)1315700736;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					global::System.Collections.ICollection collection;
					for (;;)
					{
						IL_31:
						switch (num2)
						{
						case 0:
							if (base.Interaction.ShowDeleteRadiosConfirmationDialog(collection.Count))
							{
								num = (short)1159462913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1870659588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> rds;
							global::Motorola.CommonCPS.RadioManagement.BatchOp.DeleteRadioBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.DeleteRadioBatchOp(rds);
							base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
							result = true;
							num = (short)324337667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> rds = collection.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
							{
								short num5 = (short)1813708801;
								if (num5 != 0)
								{
								}
								num5 = (short)294812097;
								short num6 = num5;
								num5 = (short)1569356225;
								switch (num6 == num5)
								{
								default:
								{
									num5 = (short)2106064896;
									short num7 = num5;
									break;
								}
								case true:
									break;
								}
								num5 = (short)1910243328;
								if (num5 != 0)
								{
								}
								return d.Clone() as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
							}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
							num = (short)518782976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_C5;
						case 4:
							goto IL_136;
						}
						goto IL_4C;
					}
					IL_C5:
					goto IL_20A;
					IL_136:
					break;
					IL_4C:
					collection = (paras[0] as global::System.Collections.ICollection);
					num = (short)318308354;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex, global::Motorola.Common.LogUtility.LoggingLevel.EventWarning);
				base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeleteDevices_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\ud8f7", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
			}
			num = (short)88716832;
			short num3 = num;
			num = (short)1260762656;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_20A:
				num = (short)2112946177;
				if (num != 0)
				{
				}
				return result;
			default:
			{
				num = (short)1095892992;
				if (num != 0)
				{
				}
				num = (short)1107886080;
				short num4 = num;
				return false;
			}
			}
		}
	}
}
