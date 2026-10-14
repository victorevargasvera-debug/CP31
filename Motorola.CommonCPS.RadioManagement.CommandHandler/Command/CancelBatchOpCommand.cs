using System;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000074 RID: 116
	internal class CancelBatchOpCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000322 RID: 802 RVA: 0x000305B4 File Offset: 0x0002E7B4
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1422262273;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			int num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					if (jobContainer.Status != global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.PENDING)
					{
						num = (short)1585709059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					if (jobContainer.Status != global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.RUNNING)
					{
						num = (short)1691025410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
				{
					num = (short)623417896;
					short num3 = num;
					num = (short)1846975016;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					default:
						goto IL_BC;
					}
					break;
				}
				case 3:
					goto IL_103;
				}
				goto IL_46;
				IL_103:
				num = (short)1264779265;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BC:
			num = (short)1199177728;
			short num4 = num;
			num = (short)4128768;
			if (num != 0)
			{
			}
			return jobContainer.Status == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.SCHEDULED;
			IL_46:
			jobContainer = (global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)paras[0];
			num = (short)765526016;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00030704 File Offset: 0x0002E904
		protected override object ExecuteCmd(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.BatchOp.IBatchOp batchOp;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_12E;
				case 1:
				{
					if (batchOp == null)
					{
						goto IL_130;
					}
					num2 = (short)739311617;
					if (num2 != 0)
					{
					}
					num2 = (short)192264968;
					short num3 = num2;
					num2 = (short)1521007368;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12E;
					default:
						num2 = (short)874905600;
						if (num2 != 0)
						{
						}
						num2 = (short)1448345602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
				{
					num2 = (short)993198080;
					short num4 = num2;
					batchOp.CancelAsync();
					num2 = (short)1707081728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_12E:
			IL_130:
			return true;
			IL_1C:
			global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer = (global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer)paras[0];
			batchOp = global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.Instance.Find(jobContainer.ID.Value);
			num2 = (short)740622337;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
