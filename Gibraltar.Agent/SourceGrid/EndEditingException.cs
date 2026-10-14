using System;
using System.Runtime.Serialization;

namespace SourceGrid
{
	// Token: 0x02000404 RID: 1028
	[global::System.Serializable]
	internal class EndEditingException : global::SourceGrid.SourceGridException
	{
		// Token: 0x06002D57 RID: 11607 RVA: 0x00098B24 File Offset: 0x00096D24
		public EndEditingException(global::System.Exception innerException) : base(innerException.Message, innerException)
		{
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00098B34 File Offset: 0x00096D34
		protected EndEditingException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
