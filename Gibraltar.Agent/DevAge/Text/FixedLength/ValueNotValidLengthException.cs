using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000294 RID: 660
	[global::System.Serializable]
	internal class ValueNotValidLengthException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600218A RID: 8586 RVA: 0x0007793C File Offset: 0x00075B3C
		public ValueNotValidLengthException(string value, int expectedLength) : base("Value " + value + " not valid, length must be " + expectedLength.ToString())
		{
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x0007795C File Offset: 0x00075B5C
		protected ValueNotValidLengthException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
