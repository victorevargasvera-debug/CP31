using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication
{
	// Token: 0x02000027 RID: 39
	public class XcmpUsbRouteControl : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000979C File Offset: 0x0000799C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000984C File Offset: 0x00007A4C
		private byte Function
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)133859516;
				short num2 = num;
				num = (short)1842514108;
				switch (num2 == num)
				{
				}
				num = (short)854130688;
				short num3 = num;
				num = (short)49086464;
				if (num != 0)
				{
				}
				num = (short)1213333505;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)489156308;
				short num2 = num;
				num = (short)1951461076;
				switch (num2 == num)
				{
				}
				num = (short)1243414528;
				short num3 = num;
				num = (short)2130575360;
				if (num != 0)
				{
				}
				num = (short)286195713;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000098FC File Offset: 0x00007AFC
		public XcmpUsbRouteControl(global::Motorola.Common.Communication.UsbRouteControlFunction function)
		{
			base.Opcode = 272;
			this.Function = (byte)function;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009924 File Offset: 0x00007B24
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1446823984;
			short num2 = num;
			num = (short)730974256;
			switch (num2 == num)
			{
			}
			num = (short)835321856;
			short num3 = num;
			num = (short)1454833664;
			if (num != 0)
			{
			}
			num = (short)1611726849;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.Function
			});
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000099F8 File Offset: 0x00007BF8
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)2041005041;
			short num2 = num;
			num = (short)1236747249;
			switch (num2 == num)
			{
			}
			num = (short)1857814528;
			short num3 = num;
			num = (short)439812097;
			if (num != 0)
			{
			}
			num = (short)17039360;
			if (num != 0)
			{
			}
			ushort a_ = base.Opcode | global::Motorola.Common.Communication.r.a();
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, a_);
			this.Function = replyBuffer[offset + 3];
		}

		// Token: 0x040000C5 RID: 197
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte a;
	}
}
