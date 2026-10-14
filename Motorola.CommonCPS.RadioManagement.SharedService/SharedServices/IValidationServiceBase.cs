using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000050 RID: 80
	public interface IValidationServiceBase : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x0600067E RID: 1662
		bool ValidateAllRadioFields(global::Motorola.CommonCPS.Server.EntityModel.Radio RadioFromServer, global::System.Collections.Generic.Dictionary<string, string> errorList);
	}
}
