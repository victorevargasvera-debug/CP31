using System;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000013 RID: 19
	public interface ITemplateDeviceOperation : global::Motorola.CommonCPS.RadioManagement.SharedServices.IDeviceOperation
	{
		// Token: 0x060000A8 RID: 168
		global::Motorola.CommonCPS.Server.EntityModel.Template PreImportTemplateToServer(string filePath, global::Motorola.CommonCPS.Server.EntityModel.Template template);
	}
}
