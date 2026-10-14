using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000022 RID: 34
	internal class DBMigrationService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IDBMigrationService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x0002D2B8 File Offset: 0x0002B4B8
		public DBMigrationService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor) : base(serverAccessor)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0002D2CC File Offset: 0x0002B4CC
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo GetDBMigrationRecord()
		{
			short num = (short)1968621395;
			short num2 = num;
			num = (short)1785907027;
			switch (num2 == num)
			{
			}
			num = (short)1264910336;
			short num3 = num;
			num = (short)1534394369;
			if (num != 0)
			{
			}
			num = (short)353370112;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetMigrationInfo();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0002D380 File Offset: 0x0002B580
		public void MigrateRadioAndCommonResource(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName, bool migrateHistoryPBAs = false)
		{
			short num = (short)1920466945;
			if (num != 0)
			{
			}
			num = (short)404082250;
			short num2 = num;
			num = (short)1065930314;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1784676352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1440677888;
			if (num != 0)
			{
			}
			base.ServerAccessor.MigrateRadioAndCommonResource(regionName, migrateHistoryPBAs);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0002D438 File Offset: 0x0002B638
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo> ListMigrationTemplateList()
		{
			short num = (short)2028666881;
			if (num != 0)
			{
			}
			num = (short)635129950;
			short num2 = num;
			num = (short)659968094;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1276444672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)23134208;
			if (num != 0)
			{
			}
			return base.ServerAccessor.ListMigrationTemplateList();
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0002D4EC File Offset: 0x0002B6EC
		public int ScheduleMigrationJob()
		{
			short num = (short)1262857754;
			short num2 = num;
			num = (short)1887481370;
			switch (num2 == num)
			{
			}
			num = (short)1721565184;
			short num3 = num;
			num = (short)663093249;
			if (num != 0)
			{
			}
			num = (short)252248064;
			if (num != 0)
			{
			}
			return base.ServerAccessor.ScheduleMigrationJob();
		}
	}
}
