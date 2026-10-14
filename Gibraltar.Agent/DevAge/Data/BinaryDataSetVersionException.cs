using System;

namespace DevAge.Data
{
	// Token: 0x02000291 RID: 657
	[global::System.Serializable]
	internal class BinaryDataSetVersionException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002182 RID: 8578 RVA: 0x000776CC File Offset: 0x000758CC
		public BinaryDataSetVersionException() : base("Binary data version not valid")
		{
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x000776DC File Offset: 0x000758DC
		public BinaryDataSetVersionException(global::System.Exception p_InnerException) : base("Binary data version not valid", p_InnerException)
		{
		}
	}
}
