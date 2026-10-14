using System;

namespace DevAge
{
	// Token: 0x020002B5 RID: 693
	[global::System.Serializable]
	internal class TypeNotSupportedException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600226A RID: 8810 RVA: 0x0007982C File Offset: 0x00077A2C
		public TypeNotSupportedException(global::System.Type pType) : base("Type " + pType.ToString() + " not supported exception")
		{
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x0007984C File Offset: 0x00077A4C
		public TypeNotSupportedException(global::System.Type pType, global::System.Exception p_InnerException) : base("Type " + pType.ToString() + " not supported exception", p_InnerException)
		{
		}
	}
}
