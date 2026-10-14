using System;

namespace DevAge.Data
{
	// Token: 0x02000290 RID: 656
	[global::System.Serializable]
	internal class BinaryDataSetInvalidException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002180 RID: 8576 RVA: 0x000776AC File Offset: 0x000758AC
		public BinaryDataSetInvalidException() : base("Binary data not valid")
		{
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x000776BC File Offset: 0x000758BC
		public BinaryDataSetInvalidException(global::System.Exception p_InnerException) : base("Binary data not valid", p_InnerException)
		{
		}
	}
}
