using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000293 RID: 659
	[global::System.Serializable]
	internal class InvalidFieldLengthException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002188 RID: 8584 RVA: 0x00077910 File Offset: 0x00075B10
		public InvalidFieldLengthException(int length) : base("Invalid field length " + length.ToString() + " must be a positive number.")
		{
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00077930 File Offset: 0x00075B30
		protected InvalidFieldLengthException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
