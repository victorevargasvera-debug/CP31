using System;

namespace MassTransit.NewIdParsers
{
	// Token: 0x02000015 RID: 21
	public class ZBase32Parser : global::MassTransit.NewIdParsers.Base32Parser
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000032EC File Offset: 0x000014EC
		public ZBase32Parser(bool handleTransposedCharacters = false)
		{
			string text = handleTransposedCharacters ? "ybndrfg8ejkmcpqxot1uwisza345h769YBNDRFG8EJKMCPQXOT1UWISZA345H769ybndrfg8ejkmcpqx0tlvwis2a345h769YBNDRFG8EJKMCPQX0TLVWIS2A345H769" : "ybndrfg8ejkmcpqxot1uwisza345h769YBNDRFG8EJKMCPQXOT1UWISZA345H769";
			base..ctor(text);
		}

		// Token: 0x04000021 RID: 33
		private const string ConvertChars = "ybndrfg8ejkmcpqxot1uwisza345h769YBNDRFG8EJKMCPQXOT1UWISZA345H769";

		// Token: 0x04000022 RID: 34
		private const string TransposeChars = "ybndrfg8ejkmcpqx0tlvwis2a345h769YBNDRFG8EJKMCPQX0TLVWIS2A345H769";
	}
}
