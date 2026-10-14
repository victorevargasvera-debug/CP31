using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication
{
	// Token: 0x02000021 RID: 33
	public class XcmpPsdtAccessBroadcast : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000082E8 File Offset: 0x000064E8
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00008398 File Offset: 0x00006598
		public byte CompletionPrecentage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)959157103;
				short num2 = num;
				num = (short)1145934703;
				switch (num2 == num)
				{
				}
				num = (short)1841299457;
				if (num != 0)
				{
				}
				num = (short)79757312;
				short num3 = num;
				num = (short)566755328;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)853291055;
				short num2 = num;
				num = (short)87371823;
				switch (num2 == num)
				{
				}
				num = (short)1457324032;
				if (num != 0)
				{
				}
				num = (short)1279262720;
				short num3 = num;
				num = (short)259981313;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00008448 File Offset: 0x00006648
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000084F4 File Offset: 0x000066F4
		public global::Motorola.Common.Communication.XcmpPsdtAccessBroadcast.PsdtAccessBroadcastStatus Status
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1873575099;
				short num2 = num;
				num = (short)1122925755;
				switch (num2 == num)
				{
				}
				num = (short)912326657;
				if (num != 0)
				{
				}
				num = (short)509149184;
				short num3 = num;
				num = (short)1665597440;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1214001241;
				short num2 = num;
				num = (short)43593817;
				switch (num2 == num)
				{
				}
				num = (short)267059200;
				if (num != 0)
				{
				}
				num = (short)9371648;
				short num3 = num;
				num = (short)1386741761;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000085A4 File Offset: 0x000067A4
		public XcmpPsdtAccessBroadcast()
		{
			base.Opcode = 45323;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000085C4 File Offset: 0x000067C4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)969914344;
			short num2 = num;
			num = (short)910800872;
			switch (num2 == num)
			{
			}
			num = (short)1090256896;
			if (num != 0)
			{
			}
			num = (short)117309440;
			short num3 = num;
			num = (short)94437377;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			object[] array = new object[]
			{
				global::Motorola.Common.Communication.r.b
			};
			global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
			this.Status = (global::Motorola.Common.Communication.XcmpPsdtAccessBroadcast.PsdtAccessBroadcastStatus)base.ReplyResult;
			this.CompletionPrecentage = (byte)array[0];
		}

		// Token: 0x04000096 RID: 150
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte a;

		// Token: 0x04000097 RID: 151
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.XcmpPsdtAccessBroadcast.PsdtAccessBroadcastStatus b;

		// Token: 0x04000098 RID: 152
		private const int c = 4;

		// Token: 0x02000022 RID: 34
		public enum PsdtAccessBroadcastStatus : byte
		{
			// Token: 0x0400009A RID: 154
			Success,
			// Token: 0x0400009B RID: 155
			Transfer_in_progress = 2
		}
	}
}
