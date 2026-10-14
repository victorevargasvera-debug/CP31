using System;
using System.Runtime.Serialization;

namespace SourceGrid
{
	// Token: 0x020003BE RID: 958
	[global::System.Serializable]
	internal class SourceGridException : global::System.ApplicationException
	{
		// Token: 0x06002BC0 RID: 11200 RVA: 0x00092E60 File Offset: 0x00091060
		public SourceGridException(string p_strErrDescription) : base(p_strErrDescription)
		{
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x00092E6C File Offset: 0x0009106C
		public SourceGridException(string p_strErrDescription, global::System.Exception p_InnerException) : base(p_strErrDescription, p_InnerException)
		{
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x00092E78 File Offset: 0x00091078
		protected SourceGridException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
