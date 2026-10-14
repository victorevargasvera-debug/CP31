using System;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000054 RID: 84
	public interface IRadioValidationService
	{
		// Token: 0x06000303 RID: 771
		void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsModifyRequest, out int supportedConnections);

		// Token: 0x06000304 RID: 772
		void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio d, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsModifyRequest, out int supportedConnections, out global::Motorola.CommonCPS.Server.CommonDBConstants.JobType correctedJobType);

		// Token: 0x06000305 RID: 773
		void RefreshLastProgrammedDate(global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP);
	}
}
