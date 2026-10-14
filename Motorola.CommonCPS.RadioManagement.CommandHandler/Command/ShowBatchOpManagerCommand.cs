using System;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000BD RID: 189
	internal class ShowBatchOpManagerCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000402 RID: 1026 RVA: 0x00043504 File Offset: 0x00041704
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1146093568;
			short num2 = num;
			num = (short)1802399779;
			short num3 = num;
			num = (short)1385132067;
			switch (num3 == num)
			{
			}
			num = (short)1174863873;
			if (num != 0)
			{
			}
			num = (short)1668087808;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowProgressWindow(global::Motorola.CommonCPS.RadioManagement.UIModels.DockPanelNames.TaskView);
			return true;
		}
	}
}
