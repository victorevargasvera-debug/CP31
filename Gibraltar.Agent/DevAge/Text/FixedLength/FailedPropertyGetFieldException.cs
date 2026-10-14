using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x0200029C RID: 668
	[global::System.Serializable]
	internal class FailedPropertyGetFieldException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600219B RID: 8603 RVA: 0x00077B70 File Offset: 0x00075D70
		public FailedPropertyGetFieldException(string field, global::System.Exception innerException) : base("Failed to get property for field " + field + " - " + innerException.Message, innerException)
		{
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00077B90 File Offset: 0x00075D90
		protected FailedPropertyGetFieldException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
