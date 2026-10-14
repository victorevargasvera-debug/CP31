using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000040 RID: 64
	public interface IDataProviderService
	{
		// Token: 0x060005F7 RID: 1527
		int GetReferencedRadiosCount(global::System.Collections.Generic.List<global::System.Guid> templateUuidList);

		// Token: 0x060005F8 RID: 1528
		global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetReferencedRadios(global::System.Collections.Generic.List<global::System.Guid> templateUuidList, int startIndex, int count);

		// Token: 0x060005F9 RID: 1529
		global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary> GetMatchedReferenceRadiosForUpgrade(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid PCRFirmwareCodeplugGroupUuid, bool isAllowDowngrade, int startIndex, int count);

		// Token: 0x060005FA RID: 1530
		int GetUpgradeMatchedMatrixRadiosCount(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid pcrFWGroupUuid, bool isAllowDowngrade);
	}
}
