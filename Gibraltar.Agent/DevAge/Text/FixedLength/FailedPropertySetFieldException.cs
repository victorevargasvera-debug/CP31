using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x0200029B RID: 667
	[global::System.Serializable]
	internal class FailedPropertySetFieldException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002199 RID: 8601 RVA: 0x00077B44 File Offset: 0x00075D44
		public FailedPropertySetFieldException(string field, global::System.Exception innerException) : base("Failed to set property for field " + field + " - " + innerException.Message, innerException)
		{
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00077B64 File Offset: 0x00075D64
		protected FailedPropertySetFieldException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
