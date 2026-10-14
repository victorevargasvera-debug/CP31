using System;
using System.Linq;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200005D RID: 93
	public class RcmpBigEndianHexVersionInformation : global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation
	{
		// Token: 0x06000153 RID: 339 RVA: 0x000141FC File Offset: 0x000123FC
		public RcmpBigEndianHexVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType type) : base(type)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00014210 File Offset: 0x00012410
		public new ushort VersionInformation
		{
			get
			{
				short num = (short)1621069397;
				short num2 = num;
				num = (short)1801621077;
				switch (num2 == num)
				{
				}
				num = (short)2109538305;
				if (num != 0)
				{
				}
				num = (short)985792512;
				short num3 = num;
				num = (short)282329088;
				if (num != 0)
				{
				}
				return this.m_VersionInformation;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000142C0 File Offset: 0x000124C0
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
				{
					num2 = (short)514129920;
					short num3 = num2;
					this.m_VersionInformation = global::System.BitConverter.ToUInt16(global::System.BitConverter.IsLittleEndian ? this.m_rawReply.Reverse<byte>().ToArray<byte>() : this.m_rawReply, 0);
					num2 = (short)1766195201;
					if (num2 != 0)
					{
					}
					num2 = (short)1957494787;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					int count = length - global::Motorola.Common.Communication.r.b();
					this.m_rawReply = replyBuffer.Skip(offset + global::Motorola.Common.Communication.r.b()).Take(count).ToArray<byte>();
					num2 = (short)1853685760;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_4E;
				case 3:
				{
					num2 = (short)313115830;
					short num4 = num2;
					num2 = (short)962512054;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4E;
					default:
						goto IL_17B;
					}
					break;
				}
				}
				goto IL_20;
				IL_4E:
				if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					return;
				}
				num2 = (short)243007489;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_17B:
			num2 = (short)1799159808;
			if (num2 != 0)
			{
			}
			return;
			IL_20:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1919614978;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040001AA RID: 426
		protected new ushort m_VersionInformation;
	}
}
