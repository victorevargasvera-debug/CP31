using System;
using System.Runtime.Serialization;

namespace SourceGrid
{
	// Token: 0x020003BF RID: 959
	[global::System.Serializable]
	internal class EditingCellException : global::SourceGrid.SourceGridException
	{
		// Token: 0x06002BC3 RID: 11203 RVA: 0x00092E84 File Offset: 0x00091084
		public EditingCellException(global::System.Exception innerException) : base(innerException.Message, innerException)
		{
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00092E94 File Offset: 0x00091094
		protected EditingCellException(global::System.Runtime.Serialization.SerializationInfo p_Info, global::System.Runtime.Serialization.StreamingContext p_StreamingContext) : base(p_Info, p_StreamingContext)
		{
		}
	}
}
