using System;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000037 RID: 55
	internal class MigrateRadioAndCommonResourceCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000239 RID: 569 RVA: 0x0001D744 File Offset: 0x0001B944
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)551478551;
			short num2 = num;
			num = (short)1182262551;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1414987776;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1385889792;
			if (num != 0)
			{
			}
			num = (short)729808897;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1736638464;
			switch (num)
			{
			default:
			{
				num = (short)2061041665;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext dbmigrationContext;
					switch (num2)
					{
					case 0:
					{
						num = (short)198554399;
						short num3 = num;
						num = (short)1920709407;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C0;
						default:
						{
							num = (short)1890648064;
							short num4 = num;
							num = (short)635174912;
							if (num != 0)
							{
							}
							num = (short)230096898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 2:
						if (paras.Count<object>() <= 0)
						{
							num = (short)1191116803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					case 3:
						goto IL_1BE;
					case 4:
						try
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName = null;
							global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DbMigrationService.MigrateRadioAndCommonResource(regionName, dbmigrationContext.NeedMigrateHistoryPBA);
							return dbmigrationContext;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							dbmigrationContext.MigrationError = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null);
							return dbmigrationContext;
						}
						goto IL_135;
					}
					IL_57:
					if (paras != null)
					{
						num = (short)1110310912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_135:
					num = (short)1544224769;
					if (num != 0)
					{
					}
					dbmigrationContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext);
					num = (short)1839595524;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BE:
				IL_1C0:
				throw new global::System.ArgumentNullException();
			}
			}
		}
	}
}
