using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200006E RID: 110
	public class XcmpDeleteLanguagePack : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000193 RID: 403 RVA: 0x000186BC File Offset: 0x000168BC
		public XcmpDeleteLanguagePack(string languagePackID, bool bigEndianForPackID = false)
		{
			if (string.IsNullOrEmpty(languagePackID))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			base.Opcode = 43;
			this.a = languagePackID;
			this.b = bigEndianForPackID;
			base.ReadTimeout = 50000;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00018704 File Offset: 0x00016904
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1930428416;
			short num2 = num;
			num = (short)1885224584;
			short num3 = num;
			num = (short)1023360648;
			switch (num3 == num)
			{
			}
			num = (short)155975681;
			if (num != 0)
			{
			}
			num = (short)210763776;
			if (num != 0)
			{
			}
			byte[] array = new byte[16];
			global::System.Array.Clear(array, 0, array.Length);
			global::Motorola.Common.Communication.r.a(this.a, array, 0, this.b);
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				16,
				array,
				0
			});
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00018800 File Offset: 0x00016A00
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)827457536;
			short num2 = num;
			num = (short)240685621;
			short num3 = num;
			num = (short)1798476341;
			switch (num3 == num)
			{
			}
			num = (short)1181614081;
			if (num != 0)
			{
			}
			num = (short)1368391680;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x0400022B RID: 555
		private string a;

		// Token: 0x0400022C RID: 556
		private bool b;
	}
}
