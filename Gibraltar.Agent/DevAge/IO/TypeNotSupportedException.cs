using System;
using System.Runtime.Serialization;

namespace DevAge.IO
{
	// Token: 0x020002B4 RID: 692
	[global::System.Serializable]
	internal class TypeNotSupportedException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x06002266 RID: 8806 RVA: 0x000797F0 File Offset: 0x000779F0
		public TypeNotSupportedException(global::System.Type pType) : base("Type not supported: " + pType.ToString())
		{
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00079808 File Offset: 0x00077A08
		public TypeNotSupportedException(string p_strErrDescription) : base(p_strErrDescription)
		{
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00079814 File Offset: 0x00077A14
		public TypeNotSupportedException(string p_strErrDescription, global::System.Exception p_InnerException) : base(p_strErrDescription, p_InnerException)
		{
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00079820 File Offset: 0x00077A20
		protected TypeNotSupportedException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
