using System;
using System.Text;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public class RcmpMemoryStreamWriteBroadcast : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00006308 File Offset: 0x00004508
		private uint NumOfDataBlock
		{
			get
			{
				short num = (short)1784860301;
				short num2 = num;
				num = (short)125816461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1455489024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)632160256;
				if (num != 0)
				{
				}
				num = (short)1500053505;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000063B4 File Offset: 0x000045B4
		private byte[] DataBlock
		{
			get
			{
				short num = (short)283826504;
				short num2 = num;
				num = (short)1654643016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1765277696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1725562881;
				if (num != 0)
				{
				}
				num = (short)1886322688;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006464 File Offset: 0x00004664
		public RcmpMemoryStreamWriteBroadcast(string fileID, uint numOfDataBlk, byte[] dataBlk)
		{
			int a_ = 16;
			base..ctor();
			base.Opcode = 46145;
			this.b = global::System.Text.Encoding.ASCII.GetBytes(fileID);
			if (this.b.Length > 4)
			{
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\uda9b첟잡蒣誩얫\uddad邯\udeb1\udbb3\ud8b5\udfb7\udfb9캻麽뒿꫁ꗃꣅ", a_) + 4.ToString() + global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("벛ﲝ\ud99f횡솣향", a_));
			}
			this.d = numOfDataBlk;
			this.c = dataBlk;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000064E8 File Offset: 0x000046E8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1463812097;
			if (num != 0)
			{
			}
			num = (short)407830528;
			short num2 = num;
			num = (short)2142386440;
			short num3 = num;
			num = (short)120535304;
			switch (num3 == num)
			{
			}
			num = (short)673775616;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Success;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.b,
				this.d,
				this.c
			});
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000065D8 File Offset: 0x000047D8
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1956970497;
			if (num != 0)
			{
			}
			num = (short)463667200;
			short num2 = num;
			num = (short)785176797;
			short num3 = num;
			num = (short)1641011421;
			switch (num3 == num)
			{
			}
			num = (short)957087744;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000021 RID: 33
		private const int a = 4;

		// Token: 0x04000022 RID: 34
		private byte[] b;

		// Token: 0x04000023 RID: 35
		private byte[] c;

		// Token: 0x04000024 RID: 36
		private uint d;
	}
}
