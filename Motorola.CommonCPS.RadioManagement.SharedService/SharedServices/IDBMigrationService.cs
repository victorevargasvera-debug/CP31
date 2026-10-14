using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000011 RID: 17
	public interface IDBMigrationService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000094 RID: 148
		global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo GetDBMigrationRecord();

		// Token: 0x06000095 RID: 149
		void MigrateRadioAndCommonResource(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName, bool migrateHistoryPBAs = false);

		// Token: 0x06000096 RID: 150
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo> ListMigrationTemplateList();

		// Token: 0x06000097 RID: 151
		int ScheduleMigrationJob();
	}
}
