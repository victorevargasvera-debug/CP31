using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x0200016B RID: 363
	internal static class FunctionParameterExtensions
	{
		// Token: 0x0600168F RID: 5775 RVA: 0x0003A99F File Offset: 0x00038B9F
		public static object GetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter)
		{
			return functionParameter.Annotations.GetConfiguration();
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0003A9AC File Offset: 0x00038BAC
		public static void SetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter, object configuration)
		{
			functionParameter.GetMetadataProperties().SetConfiguration(configuration);
		}
	}
}
