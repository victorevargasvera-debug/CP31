using System;
using System.Text;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000D RID: 13
	public class RcmpMemoryStreamStatusBroadcast : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00005D88 File Offset: 0x00003F88
		public global::Motorola.Common.Communication.MemoryStreamStatus Status
		{
			get
			{
				short num = (short)2002780161;
				if (num != 0)
				{
				}
				num = (short)782696448;
				short num2 = num;
				num = (short)673479806;
				short num3 = num;
				num = (short)181501054;
				switch (num3 == num)
				{
				}
				num = (short)527106048;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00005E3C File Offset: 0x0000403C
		public int Progress
		{
			get
			{
				short num = (short)1028074279;
				short num2 = num;
				num = (short)838282023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)217579520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1116471297;
				if (num != 0)
				{
				}
				num = (short)1262026752;
				if (num != 0)
				{
				}
				return (int)this.c;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00005EF0 File Offset: 0x000040F0
		public string FILEID
		{
			get
			{
				short num = (short)2131245043;
				short num2 = num;
				num = (short)1435514867;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1860567040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)602013697;
				if (num != 0)
				{
				}
				num = (short)1901461504;
				if (num != 0)
				{
				}
				return global::System.Text.Encoding.ASCII.GetString(this.d);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005FA8 File Offset: 0x000041A8
		public RcmpMemoryStreamStatusBroadcast(string fID)
		{
			int a_ = 4;
			base..ctor();
			base.Opcode = 13378;
			this.d = global::System.Text.Encoding.ASCII.GetBytes(fID);
			if (this.d.Length > 4)
			{
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("횏ﮑ뢗펙\ud89b뺝즟톡蒣쪥잧쒩쮫쮭슯銱삳\udeb5\ud9b7풹鲻", a_) + 4.ToString() + global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("낏ﶗ", a_));
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006020 File Offset: 0x00004220
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1511568297;
			short num2 = num;
			num = (short)1894233001;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2087649280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1556348928;
			if (num != 0)
			{
			}
			num = (short)90112001;
			if (num != 0)
			{
			}
			return 0;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000060C8 File Offset: 0x000042C8
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					num2 = (short)1206976512;
					short num3 = num2;
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)2125135874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
					return;
				case 2:
				{
					num2 = (short)1412748573;
					short num4 = num2;
					num2 = (short)1575802141;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1896939520;
						if (num2 != 0)
						{
						}
						object[] array = new object[]
						{
							global::Motorola.Common.Communication.r.b,
							new byte[4],
							global::Motorola.Common.Communication.r.b
						};
						global::Motorola.Common.Communication.r.a(replyBuffer, offset + 2, length - 2, array);
						this.b = (global::Motorola.Common.Communication.MemoryStreamStatus)array[0];
						this.d = (byte[])array[1];
						this.c = (byte)array[2];
						num2 = (short)162988033;
						if (num2 != 0)
						{
						}
						num2 = (short)1647706113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			base.ReplyResult = global::Motorola.Common.Communication.RcmpReplyResult.Success;
			num2 = (short)330694656;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006250 File Offset: 0x00004450
		// Note: this type is marked as 'beforefieldinit'.
		static RcmpMemoryStreamStatusBroadcast()
		{
			short num = (short)1269867857;
			short num2 = num;
			num = (short)2118493521;
			switch (num2 == num)
			{
			default:
			{
				num = (short)311164928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1567424513;
			if (num != 0)
			{
			}
			num = (short)1140785152;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.RcmpMemoryStreamStatusBroadcast.FLASH_PROGRESS_PROPORTION = 0.2;
		}

		// Token: 0x0400001C RID: 28
		public static readonly double FLASH_PROGRESS_PROPORTION;

		// Token: 0x0400001D RID: 29
		private const int a = 4;

		// Token: 0x0400001E RID: 30
		private global::Motorola.Common.Communication.MemoryStreamStatus b;

		// Token: 0x0400001F RID: 31
		private byte c;

		// Token: 0x04000020 RID: 32
		private byte[] d;
	}
}
