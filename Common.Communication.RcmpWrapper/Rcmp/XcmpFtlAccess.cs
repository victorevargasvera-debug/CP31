using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000075 RID: 117
	public class XcmpFtlAccess : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x000195DC File Offset: 0x000177DC
		public XcmpFtlAccess(byte TransferType, ushort PartitionID, uint OptionFlag, uint StartID, uint EndID)
		{
			base.Opcode = 1092;
			this.e = TransferType;
			this.a = PartitionID;
			this.b = OptionFlag;
			this.c = StartID;
			this.d = EndID;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00019620 File Offset: 0x00017820
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1710161920;
			short num2 = num;
			num = (short)1788848342;
			short num3 = num;
			num = (short)1575266518;
			switch (num3 == num)
			{
			}
			num = (short)2052194305;
			if (num != 0)
			{
			}
			num = (short)434307072;
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

		// Token: 0x060001A8 RID: 424 RVA: 0x0001972C File Offset: 0x0001792C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1252589568;
					short num3 = num2;
					num2 = (short)676465661;
					short num4 = num2;
					num2 = (short)1474628605;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19E;
					default:
						num2 = (short)1145700352;
						if (num2 != 0)
						{
						}
						if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)1735524356;
							num = (int)((global::System.IntPtr)num2);
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
					num2 = (short)126156801;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (length >= global::Motorola.Common.Communication.r.b() + 17)
					{
						num2 = (short)1666383873;
						if (num2 != 0)
						{
						}
						num2 = (short)686489602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					goto IL_19E;
				}
				goto IL_24;
				IL_19E:
				num2 = (short)186777603;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1099431936;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000243 RID: 579
		private ushort a;

		// Token: 0x04000244 RID: 580
		private uint b;

		// Token: 0x04000245 RID: 581
		private uint c;

		// Token: 0x04000246 RID: 582
		private uint d;

		// Token: 0x04000247 RID: 583
		private byte e;

		// Token: 0x02000076 RID: 118
		public enum TransferType : byte
		{
			// Token: 0x04000249 RID: 585
			Read,
			// Token: 0x0400024A RID: 586
			Write,
			// Token: 0x0400024B RID: 587
			Erase
		}
	}
}
