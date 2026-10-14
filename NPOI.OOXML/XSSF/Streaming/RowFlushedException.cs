using System;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000CC RID: 204
	public class RowFlushedException : global::System.Exception
	{
		// Token: 0x06000CA7 RID: 3239 RVA: 0x0002E212 File Offset: 0x0002C412
		public RowFlushedException(int rowNum) : base("Row " + rowNum.ToString() + " has been flushed, cannot evaluate all cells")
		{
		}
	}
}
