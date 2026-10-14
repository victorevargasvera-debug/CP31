using System;
using System.Runtime.Serialization;

namespace DevAge.IO
{
	// Token: 0x020002B3 RID: 691
	[global::System.Serializable]
	internal class InvalidDataException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002262 RID: 8802 RVA: 0x000797BC File Offset: 0x000779BC
		public InvalidDataException() : base("Invalid data exception")
		{
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x000797CC File Offset: 0x000779CC
		public InvalidDataException(string p_strErrDescription) : base(p_strErrDescription)
		{
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x000797D8 File Offset: 0x000779D8
		public InvalidDataException(string p_strErrDescription, global::System.Exception p_InnerException) : base(p_strErrDescription, p_InnerException)
		{
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x000797E4 File Offset: 0x000779E4
		protected InvalidDataException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
