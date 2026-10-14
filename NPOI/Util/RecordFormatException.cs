using System;

namespace NPOI.Util
{
	// Token: 0x0200028B RID: 651
	[global::System.Serializable]
	public class RecordFormatException : global::NPOI.Util.RuntimeException
	{
		// Token: 0x060011A0 RID: 4512 RVA: 0x00034F50 File Offset: 0x00033150
		public RecordFormatException(string exception) : base(exception)
		{
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00034F59 File Offset: 0x00033159
		public RecordFormatException(string exception, global::System.Exception ex) : base(exception, ex)
		{
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00034F63 File Offset: 0x00033163
		public RecordFormatException(global::System.Exception ex) : base(ex)
		{
		}
	}
}
