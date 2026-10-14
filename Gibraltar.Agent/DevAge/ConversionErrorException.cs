using System;

namespace DevAge
{
	// Token: 0x020002B7 RID: 695
	[global::System.Serializable]
	internal class ConversionErrorException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600226E RID: 8814 RVA: 0x000798A0 File Offset: 0x00077AA0
		public ConversionErrorException(string destinationType, string value, string extendedMessage) : base(string.Concat(new string[]
		{
			extendedMessage,
			", cannot convert ",
			value,
			" to ",
			destinationType,
			"."
		}))
		{
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00079900 File Offset: 0x00077B00
		public ConversionErrorException(string destinationType, string value) : base(string.Concat(new string[]
		{
			"Cannot convert ",
			value,
			" to ",
			destinationType,
			"."
		}))
		{
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00079958 File Offset: 0x00077B58
		public ConversionErrorException(string destinationType, string value, global::System.Exception p_InnerException) : base(string.Concat(new string[]
		{
			"Cannot convert ",
			value,
			" to ",
			destinationType,
			"."
		}), p_InnerException)
		{
		}
	}
}
