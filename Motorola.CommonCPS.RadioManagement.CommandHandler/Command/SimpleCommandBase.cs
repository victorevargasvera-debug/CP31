using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000016 RID: 22
	public abstract class SimpleCommandBase : global::Motorola.CommonCPS.RadioManagement.Command.ICommandImplementation
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00007A00 File Offset: 0x00005C00
		public virtual object Execute(params object[] paras)
		{
			short num = (short)1094009462;
			short num2 = num;
			num = (short)120013430;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)648019968;
				if (num != 0)
				{
				}
				if (!this.CanExecute(paras))
				{
					num = (short)469041153;
					if (num != 0)
					{
					}
					num = (short)121110528;
					short num3 = num;
					throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Local_Data_Outof_Date, null);
				}
				break;
			}
			return this.ExecuteCmd(paras);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007ACC File Offset: 0x00005CCC
		public virtual bool CanExecute(params object[] paras)
		{
			short num = (short)903544832;
			short num2 = num;
			num = (short)777918949;
			short num3 = num;
			num = (short)757275109;
			switch (num3 == num)
			{
			}
			num = (short)79691777;
			if (num != 0)
			{
			}
			num = (short)95551488;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000060 RID: 96
		protected abstract object ExecuteCmd(params object[] paras);
	}
}
