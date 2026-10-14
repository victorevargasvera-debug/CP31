using System;
using System.Linq;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200005C RID: 92
	public class RcmpHexVersionInformation : global::Motorola.Common.Communication.Rcmp.RcmpVersionInformation
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00013F94 File Offset: 0x00012194
		public RcmpHexVersionInformation(global::Motorola.Common.Communication.Rcmp.VersionInfoType type) : base(type)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00013FA8 File Offset: 0x000121A8
		public new ushort VersionInformation
		{
			get
			{
				short num = (short)516853177;
				short num2 = num;
				num = (short)414092729;
				switch (num2 == num)
				{
				}
				num = (short)320602112;
				if (num != 0)
				{
				}
				num = (short)1022492672;
				short num3 = num;
				num = (short)1568997377;
				if (num != 0)
				{
				}
				return this.m_VersionInformation;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0001405C File Offset: 0x0001225C
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
					num2 = (short)283901952;
					short num3 = num2;
					this.m_VersionInformation = global::System.BitConverter.ToUInt16(global::System.BitConverter.IsLittleEndian ? this.m_rawReply : this.m_rawReply.Reverse<byte>().ToArray<byte>(), 0);
					num2 = (short)1367539713;
					if (num2 != 0)
					{
					}
					num2 = (short)129826819;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					int count = length - global::Motorola.Common.Communication.r.b();
					this.m_rawReply = replyBuffer.Skip(offset + global::Motorola.Common.Communication.r.b()).Take(count).ToArray<byte>();
					num2 = (short)1369178112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_4F;
				case 3:
				{
					num2 = (short)586019834;
					short num4 = num2;
					num2 = (short)1313141754;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4F;
					default:
						goto IL_17B;
					}
					break;
				}
				}
				goto IL_20;
				IL_4F:
				if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					return;
				}
				num2 = (short)293011457;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_17B:
			num2 = (short)736821248;
			if (num2 != 0)
			{
			}
			return;
			IL_20:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1581842434;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040001A9 RID: 425
		protected new ushort m_VersionInformation;
	}
}
