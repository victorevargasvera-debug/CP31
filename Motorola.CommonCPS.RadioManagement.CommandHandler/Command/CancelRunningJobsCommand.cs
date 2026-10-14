using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000099 RID: 153
	internal class CancelRunningJobsCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000391 RID: 913 RVA: 0x00039894 File Offset: 0x00037A94
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1642987522;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1443430401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)480051201;
					if (num != 0)
					{
					}
					if (paras.Count<object>() > 0)
					{
						goto IL_102;
					}
					num = (short)408661352;
					short num3 = num;
					num = (short)185183592;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_102;
					default:
						num = (short)760938496;
						if (num != 0)
						{
						}
						num = (short)184877059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				case 3:
					goto IL_FD;
				}
				IL_36:
				if (paras == null)
				{
					break;
				}
				num = (short)454426624;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_50:
			throw new global::System.ArgumentNullException();
			IL_FD:
			goto IL_50;
			IL_102:
			num = (short)1246756864;
			short num4 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext selectRunningRadiosContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext;
			return selectRunningRadiosContext.Radios.Count + selectRunningRadiosContext.SelectRunningRadios.Count > 0;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000399F0 File Offset: 0x00037BF0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1789329410;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1048444929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if (paras.Count<object>() > 0)
					{
						goto IL_FF;
					}
					num = (short)880424133;
					short num3 = num;
					num = (short)2017211589;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FF;
					default:
						num = (short)1221263360;
						if (num != 0)
						{
						}
						num = (short)1853161475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)1297809409;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 3:
					goto IL_FA;
				}
				IL_5C:
				if (paras == null)
				{
					break;
				}
				num = (short)1864433664;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_76:
			throw new global::System.ArgumentNullException();
			IL_FA:
			goto IL_76;
			IL_FF:
			num = (short)1291321344;
			short num4 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext selectRunningRadiosContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectRunningRadiosContext;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list = selectRunningRadiosContext.Radios.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			list.AddRange(selectRunningRadiosContext.SelectRunningRadios.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>());
			global::Motorola.CommonCPS.RadioManagement.BatchOp.CancelJobBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.CancelJobBatchOp(list);
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
			return true;
		}
	}
}
