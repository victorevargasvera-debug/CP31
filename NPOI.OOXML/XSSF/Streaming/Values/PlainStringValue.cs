using System;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000D8 RID: 216
	public class PlainStringValue : global::NPOI.XSSF.Streaming.Values.StringValue
	{
		// Token: 0x06000DE2 RID: 3554 RVA: 0x00005008 File Offset: 0x00003208
		public override bool IsRichText()
		{
			return false;
		}

		// Token: 0x0400040F RID: 1039
		public string Value;
	}
}
