using System;
using System.Runtime.Serialization;

namespace DevAge
{
	// Token: 0x02000279 RID: 633
	[global::System.Serializable]
	internal class DevAgeApplicationException : global::System.ApplicationException
	{
		// Token: 0x06002079 RID: 8313 RVA: 0x000740E8 File Offset: 0x000722E8
		public DevAgeApplicationException(string p_strErrDescription) : base(p_strErrDescription)
		{
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x000740F4 File Offset: 0x000722F4
		public DevAgeApplicationException(string p_strErrDescription, global::System.Exception p_InnerException) : base(p_strErrDescription, p_InnerException)
		{
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00074100 File Offset: 0x00072300
		protected DevAgeApplicationException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
