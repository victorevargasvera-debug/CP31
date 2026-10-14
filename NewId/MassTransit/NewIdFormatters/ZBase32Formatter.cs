using System;

namespace MassTransit.NewIdFormatters
{
	// Token: 0x02000019 RID: 25
	public class ZBase32Formatter : global::MassTransit.NewIdFormatters.Base32Formatter
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000036F8 File Offset: 0x000018F8
		public ZBase32Formatter(bool upperCase = false)
		{
			string text = upperCase ? "YBNDRFG8EJKMCPQXOT1UWISZA345H769" : "ybndrfg8ejkmcpqxot1uwisza345h769";
			base..ctor(text);
		}

		// Token: 0x0400002C RID: 44
		private const string LowerCaseChars = "ybndrfg8ejkmcpqxot1uwisza345h769";

		// Token: 0x0400002D RID: 45
		private const string UpperCaseChars = "YBNDRFG8EJKMCPQXOT1UWISZA345H769";
	}
}
