using System;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200008D RID: 141
	internal class SelectASKForCFSCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000366 RID: 870 RVA: 0x00035E6C File Offset: 0x0003406C
		public override bool CanExecute(params object[] paras)
		{
			short num;
			for (;;)
			{
				num = (short)89456640;
				short num2 = num;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext selectASKForCFSContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext;
				if (selectASKForCFSContext.RadioASKMapping.Count != selectASKForCFSContext.Radios.Count)
				{
					return false;
				}
				num = (short)1464122861;
				short num3 = num;
				num = (short)791330285;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_80;
				}
			}
			IL_80:
			num = (short)1463943169;
			if (num != 0)
			{
			}
			num = (short)1927348224;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00035F3C File Offset: 0x0003413C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)243752431;
			short num2 = num;
			num = (short)97541615;
			switch (num2 == num)
			{
			}
			num = (short)549650433;
			if (num != 0)
			{
			}
			num = (short)881393664;
			short num3 = num;
			num = (short)1489698816;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
