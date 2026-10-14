using System;
using System.Runtime.Serialization;

namespace DevAge.Configuration
{
	// Token: 0x0200028A RID: 650
	[global::System.Serializable]
	internal class ConfigurationException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002168 RID: 8552 RVA: 0x0007709C File Offset: 0x0007529C
		public ConfigurationException(string p_strErrDescription) : base(p_strErrDescription)
		{
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x000770A8 File Offset: 0x000752A8
		public ConfigurationException(string p_strErrDescription, global::System.Exception p_InnerException) : base(p_strErrDescription, p_InnerException)
		{
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x000770B4 File Offset: 0x000752B4
		protected ConfigurationException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
