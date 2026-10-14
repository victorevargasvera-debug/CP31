using System;
using System.Text;
using Motorola.Common.Communication.Rcmp;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public class RcmpMemoryStreamReadBroadcast : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00005954 File Offset: 0x00003B54
		private uint SizeOfDataBlock
		{
			get
			{
				short num = (short)1511329077;
				short num2 = num;
				num = (short)938544437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1015939072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)768081921;
				if (num != 0)
				{
				}
				num = (short)1659830272;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00005A04 File Offset: 0x00003C04
		public byte[] DataBlock
		{
			get
			{
				short num = (short)1577108417;
				short num2 = num;
				num = (short)1914487745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)591790080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1408958465;
				if (num != 0)
				{
				}
				num = (short)895680512;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005AB4 File Offset: 0x00003CB4
		public RcmpMemoryStreamReadBroadcast(string fileID)
		{
			int a_ = 2;
			base..ctor();
			base.Opcode = 13376;
			this.b = global::System.Text.Encoding.ASCII.GetBytes(fileID);
			if (this.b.Length > 4)
			{
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("좍憐ﺑ뚕톗\ude99벛펟芡좣즥욧충즫\udcad邯욱\udcb3ힵ횷骹", a_) + 4.ToString() + global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("꺍", a_));
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005B2C File Offset: 0x00003D2C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)214602518;
			short num2 = num;
			num = (short)1116115734;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1579286528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1854734337;
			if (num != 0)
			{
			}
			num = (short)1572995072;
			if (num != 0)
			{
			}
			return 0;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005BD4 File Offset: 0x00003DD4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)882114561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					object[] array = new object[]
					{
						new byte[4],
						global::Motorola.Common.Communication.r.d,
						global::Motorola.Common.Communication.r.c
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + 2, length - 2, array);
					this.d = (uint)array[1];
					this.c = (byte[])array[2];
					num2 = (short)1210253315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_19F;
				case 3:
				{
					num2 = (short)631824515;
					short num3 = num2;
					num2 = (short)787603587;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1048510464;
						if (num2 != 0)
						{
						}
						if ((long)this.c.Length != (long)((ulong)this.d))
						{
							num2 = (short)1031340033;
							if (num2 != 0)
							{
							}
							num2 = (short)179175426;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_19F:
			num2 = (short)1035010048;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRcmpBroadcastMsgSize);
			IL_20:
			global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			base.ReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Success;
			num2 = (short)605618176;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000012 RID: 18
		private const int a = 4;

		// Token: 0x04000013 RID: 19
		private byte[] b;

		// Token: 0x04000014 RID: 20
		private byte[] c;

		// Token: 0x04000015 RID: 21
		private uint d;
	}
}
