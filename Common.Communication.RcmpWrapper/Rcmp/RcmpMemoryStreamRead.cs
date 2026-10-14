using System;
using System.Text;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200003A RID: 58
	public class RcmpMemoryStreamRead : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		private uint SizeOfDataBlock
		{
			get
			{
				short num = (short)612491453;
				short num2 = num;
				num = (short)1169481917;
				switch (num2 == num)
				{
				}
				num = (short)1146093568;
				if (num != 0)
				{
				}
				num = (short)701235201;
				if (num != 0)
				{
				}
				num = (short)836632576;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		public RcmpMemoryStreamRead(string fileID)
		{
			int a_ = 7;
			base..ctor();
			base.Opcode = 1088;
			this.c = global::System.Text.Encoding.ASCII.GetBytes(fileID);
			if (this.c.Length > 4)
			{
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("햒ﲔﮖﲘ뮚풜\udb9e膠쪢횤螦얨쒪쎬좮풰솲閴쎶톸\udaba펼龾", a_) + 4.ToString() + global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("뎒ﺚ", a_));
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)2129966741;
			short num2 = num;
			num = (short)1076213397;
			switch (num2 == num)
			{
			}
			num = (short)548339713;
			if (num != 0)
			{
			}
			num = (short)1879834624;
			if (num != 0)
			{
			}
			num = (short)1723662336;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.c
			});
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)745415150;
			short num2 = num;
			num = (short)472850926;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13E:
				num = (short)855900161;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)649265152;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_A3:
				switch (num3)
				{
				case 0:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1689845762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					goto IL_101;
				}
				goto IL_B5;
			}
			IL_101:
			object[] array = new object[]
			{
				new byte[4],
				global::Motorola.Common.Communication.r.d
			};
			global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
			this.b = (uint)array[1];
			goto IL_13E;
			IL_5E:
			num = (short)2039283712;
			if (num != 0)
			{
			}
			num = (short)488177665;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B5;
			}
			goto IL_A3;
			IL_B5:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)1945960448;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_A3;
		}

		// Token: 0x04000107 RID: 263
		private const int a = 4;

		// Token: 0x04000108 RID: 264
		private uint b;

		// Token: 0x04000109 RID: 265
		private byte[] c;
	}
}
