using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200007C RID: 124
	public class XcmpNandAccess : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0001AC30 File Offset: 0x00018E30
		public XcmpNandAccess(byte TransferType, ushort PartitionID, uint OptionFlag, uint StartID, uint EndID)
		{
			base.Opcode = 1091;
			this.e = TransferType;
			this.a = PartitionID;
			this.b = OptionFlag;
			this.c = StartID;
			this.d = EndID;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001AC74 File Offset: 0x00018E74
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)869728256;
			short num2 = num;
			num = (short)381104292;
			short num3 = num;
			num = (short)937177252;
			switch (num3 == num)
			{
			}
			num = (short)1959329793;
			if (num != 0)
			{
			}
			num = (short)1462632448;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.e,
				this.a,
				this.b,
				this.c,
				this.d
			});
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001AD7C File Offset: 0x00018F7C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)645005313;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			int num2;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
				{
					num = (short)2097697276;
					short num3 = num;
					num = (short)1701073404;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19D;
					default:
						num = (short)1376583680;
						if (num != 0)
						{
						}
						if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)264634372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					return;
				case 2:
					this.e = replyBuffer[offset + 3];
					this.a = (ushort)((int)replyBuffer[offset + 5] | (int)replyBuffer[offset + 4] << 8);
					this.b = (uint)((int)replyBuffer[offset + 9] | (int)replyBuffer[offset + 8] << 8 | (int)replyBuffer[offset + 7] << 16 | (int)replyBuffer[offset + 6] << 24);
					this.c = (uint)((int)replyBuffer[offset + 13] | (int)replyBuffer[offset + 12] << 8 | (int)replyBuffer[offset + 11] << 16 | (int)replyBuffer[offset + 10] << 24);
					this.d = (uint)((int)replyBuffer[offset + 17] | (int)replyBuffer[offset + 16] << 8 | (int)replyBuffer[offset + 15] << 16 | (int)replyBuffer[offset + 14] << 24);
					num = (short)1651507201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (length >= global::Motorola.Common.Communication.r.b() + 17)
					{
						num = (short)1562312706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					goto IL_19D;
				}
				goto IL_4A;
				IL_19D:
				num = (short)1605304320;
				short num4 = num;
				num = (short)708313091;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_4A:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)1677262848;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x04000275 RID: 629
		private ushort a;

		// Token: 0x04000276 RID: 630
		private uint b;

		// Token: 0x04000277 RID: 631
		private uint c;

		// Token: 0x04000278 RID: 632
		private uint d;

		// Token: 0x04000279 RID: 633
		private byte e;

		// Token: 0x0200007D RID: 125
		public enum TransferType : byte
		{
			// Token: 0x0400027B RID: 635
			Read,
			// Token: 0x0400027C RID: 636
			Write,
			// Token: 0x0400027D RID: 637
			Erase,
			// Token: 0x0400027E RID: 638
			Format
		}
	}
}
