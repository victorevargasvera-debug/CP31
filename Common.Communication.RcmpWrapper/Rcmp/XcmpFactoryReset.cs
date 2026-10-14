using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000072 RID: 114
	public class XcmpFactoryReset : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00018C74 File Offset: 0x00016E74
		public XcmpFactoryReset(global::Motorola.Common.Communication.Rcmp.FactoryResetOperationType operationType)
		{
			base.Opcode = 63;
			this.b = operationType;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00018C98 File Offset: 0x00016E98
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)440401922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_1A4;
				case 2:
				{
					num2 = (short)599195649;
					if (num2 != 0)
					{
					}
					object[] array = new object[]
					{
						global::Motorola.Common.Communication.r.b
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (byte)array[0];
					num2 = (short)1565196291;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (this.a != (byte)this.b)
					{
						num2 = (short)1607008257;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_29;
			}
			IL_1A4:
			num2 = (short)1225782652;
			short num3 = num2;
			num2 = (short)159511932;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_29:
				base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
				num2 = (short)1057030144;
				short num4 = num2;
				num2 = (short)296878080;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
				num2 = (short)898629632;
				if (num2 != 0)
				{
				}
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("얙ﮝ풟힡횣좥\udfa9슫춭쒯\udbb1\udbb3\ud8b5", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("좙鍊첟\udba1蒣삥\udda7쒩쾫\udaad\ud9af\uddb1\udab3隵\udeb7좹펻펽냁ꗃꋅꇇꗉꟍꏏ뷓룕껗믙냛럝蓟", a_));
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00018E50 File Offset: 0x00017050
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)72876032;
			short num2 = num;
			num = (short)1179451393;
			if (num != 0)
			{
			}
			num = (short)292242497;
			short num3 = num;
			num = (short)1898529857;
			switch (num3 == num)
			{
			}
			num = (short)101384192;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				0
			});
		}

		// Token: 0x04000231 RID: 561
		private byte a;

		// Token: 0x04000232 RID: 562
		private global::Motorola.Common.Communication.Rcmp.FactoryResetOperationType b;
	}
}
