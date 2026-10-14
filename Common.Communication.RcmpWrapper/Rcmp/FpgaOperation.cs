using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000034 RID: 52
	public class FpgaOperation : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x0000C02C File Offset: 0x0000A22C
		public FpgaOperation(global::Motorola.Common.Communication.Rcmp.FPGAOperationType operation, global::Motorola.Common.Communication.Rcmp.FpgaOperationID fpgaID)
		{
			base.Opcode = 520;
			this.a = (byte)(operation | (global::Motorola.Common.Communication.Rcmp.FPGAOperationType)fpgaID);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000C054 File Offset: 0x0000A254
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1624999982;
			short num2 = num;
			num = (short)1220249646;
			switch (num2 == num)
			{
			}
			num = (short)309526529;
			if (num != 0)
			{
			}
			num = (short)1584594944;
			if (num != 0)
			{
			}
			num = (short)2003042304;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000C124 File Offset: 0x0000A324
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (replyBuffer[offset] != this.a)
					{
						num2 = (short)1665400839;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_B1;
				case 2:
					if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1599340549;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B1;
				case 3:
				{
					num2 = (short)1712732223;
					short num3 = num2;
					num2 = (short)569587775;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B1;
					default:
						num2 = (short)1359085568;
						if (num2 != 0)
						{
						}
						if (this.a == 64)
						{
							num2 = (short)1729495040;
							short num4 = num2;
							num2 = (short)1860173825;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 4:
					num2 = (short)702414851;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1065746433;
					if (num2 != 0)
					{
					}
					num2 = (short)671219718;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.LockSequenceFailure)
					{
						num2 = (short)937558020;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					goto IL_F0;
				}
				goto IL_30;
				IL_B1:
				num2 = (short)1946025984;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F0:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError);
			IL_30:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			offset += global::Motorola.Common.Communication.r.b();
			num2 = (short)179765250;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000F5 RID: 245
		private byte a;
	}
}
