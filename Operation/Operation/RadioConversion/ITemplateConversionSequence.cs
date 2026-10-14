using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Operation.RadioConversion
{
	// Token: 0x02000006 RID: 6
	public interface ITemplateConversionSequence
	{
		// Token: 0x06000010 RID: 16
		global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ConvertTemplate(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template, global::System.Guid? jobContainerGuid);
	}
}
