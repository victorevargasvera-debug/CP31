using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200027A RID: 634
	[global::System.Serializable]
	public class BufferUnderrunException : global::System.IO.IOException
	{
		// Token: 0x06001110 RID: 4368 RVA: 0x00033DFD File Offset: 0x00031FFD
		internal BufferUnderrunException() : base("buffer underrun")
		{
		}
	}
}
