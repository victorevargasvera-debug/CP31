using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Operation.RadioConversion
{
	// Token: 0x02000005 RID: 5
	public interface IRadioConversionSequence
	{
		// Token: 0x0600000F RID: 15
		global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult ConvertRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, global::System.Guid? jobContainerGuid, global::System.Guid? rwJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio convertedRadio = null);
	}
}
