using System;
using System.Runtime.Serialization;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000296 RID: 662
	[global::System.Serializable]
	internal class TypeNotSupportedException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600218E RID: 8590 RVA: 0x00077994 File Offset: 0x00075B94
		public TypeNotSupportedException(global::System.Type type) : base("Type " + type.ToString() + " not supported")
		{
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x000779B4 File Offset: 0x00075BB4
		protected TypeNotSupportedException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
