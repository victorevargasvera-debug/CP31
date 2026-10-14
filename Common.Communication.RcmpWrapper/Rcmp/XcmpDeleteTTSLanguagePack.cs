using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200006F RID: 111
	public class XcmpDeleteTTSLanguagePack : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000196 RID: 406 RVA: 0x000188C8 File Offset: 0x00016AC8
		public XcmpDeleteTTSLanguagePack(string languagePackID, bool bigEndianForPackID = false)
		{
			if (languagePackID == null)
			{
				languagePackID = string.Empty;
			}
			base.Opcode = 43;
			this.a = languagePackID;
			this.b = bigEndianForPackID;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00018900 File Offset: 0x00016B00
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)969539584;
			short num2 = num;
			num = (short)1113581140;
			short num3 = num;
			num = (short)1768089172;
			switch (num3 == num)
			{
			}
			num = (short)687341569;
			if (num != 0)
			{
			}
			num = (short)1428815872;
			if (num != 0)
			{
			}
			byte[] array = new byte[16];
			global::System.Array.Clear(array, 0, array.Length);
			global::Motorola.Common.Communication.r.a(this.a, array, 0, this.b);
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				48,
				array,
				0
			});
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00018A04 File Offset: 0x00016C04
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)2005729280;
			short num2 = num;
			num = (short)367302904;
			short num3 = num;
			num = (short)1334155512;
			switch (num3 == num)
			{
			}
			num = (short)379846657;
			if (num != 0)
			{
			}
			num = (short)1981284352;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x0400022D RID: 557
		private string a;

		// Token: 0x0400022E RID: 558
		private bool b;
	}
}
