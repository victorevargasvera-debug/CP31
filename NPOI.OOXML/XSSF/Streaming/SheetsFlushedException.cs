using System;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000CB RID: 203
	public class SheetsFlushedException : global::System.Exception
	{
		// Token: 0x06000CA6 RID: 3238 RVA: 0x0002E205 File Offset: 0x0002C405
		public SheetsFlushedException() : base("One or more sheets have been flushed, cannot evaluate all cells")
		{
		}
	}
}
