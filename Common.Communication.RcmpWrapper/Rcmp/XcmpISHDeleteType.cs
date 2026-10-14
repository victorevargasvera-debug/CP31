using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000077 RID: 119
	public class XcmpISHDeleteType : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00019944 File Offset: 0x00017B44
		private byte Partition
		{
			get
			{
				short num = (short)1429602304;
				short num2 = num;
				num = (short)1453604572;
				short num3 = num;
				num = (short)671760092;
				switch (num3 == num)
				{
				}
				num = (short)374079488;
				if (num != 0)
				{
				}
				num = (short)1352531969;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000199F4 File Offset: 0x00017BF4
		private ushort StartType
		{
			get
			{
				short num = (short)126222336;
				short num2 = num;
				num = (short)532398903;
				short num3 = num;
				num = (short)1259651895;
				switch (num3 == num)
				{
				}
				num = (short)186187776;
				if (num != 0)
				{
				}
				num = (short)208732161;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00019AA4 File Offset: 0x00017CA4
		private ushort EndType
		{
			get
			{
				short num = (short)1569390592;
				short num2 = num;
				num = (short)865624940;
				short num3 = num;
				num = (short)1052337004;
				switch (num3 == num)
				{
				}
				num = (short)352845824;
				if (num != 0)
				{
				}
				num = (short)727056385;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00019B54 File Offset: 0x00017D54
		public XcmpISHDeleteType(byte partition, ushort startType, ushort endType)
		{
			base.Opcode = 259;
			this.a = partition;
			this.b = startType;
			this.c = endType;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00019B88 File Offset: 0x00017D88
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1085210624;
			short num2 = num;
			num = (short)467664897;
			if (num != 0)
			{
			}
			num = (short)1712998031;
			short num3 = num;
			num = (short)44582543;
			switch (num3 == num)
			{
			}
			num = (short)533987328;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c
			});
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00019C78 File Offset: 0x00017E78
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)267128061;
			short num2 = num;
			num = (short)1790053629;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F1:
				num = (short)158203906;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)690814976;
				if (num != 0)
				{
				}
				num = (short)618463233;
				if (num != 0)
				{
				}
				num = (short)674299904;
				short num4 = num;
				switch (0)
				{
				case 0:
					goto IL_B6;
				}
				break;
			}
			}
			for (;;)
			{
				IL_A4:
				switch (num3)
				{
				case 0:
					goto IL_E6;
				case 1:
					return;
				case 2:
				{
					object[] array = new object[6];
					array[0] = global::Motorola.Common.Communication.r.b;
					array[1] = global::Motorola.Common.Communication.r.a;
					array[2] = global::Motorola.Common.Communication.r.a;
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (byte)array[0];
					this.b = (ushort)array[1];
					this.c = (ushort)array[2];
					num = (short)1534984193;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_B6;
			}
			IL_E6:
			if (length > global::Motorola.Common.Communication.r.b())
			{
				goto IL_F1;
			}
			return;
			IL_B6:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)36044800;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_A4;
		}

		// Token: 0x0400024C RID: 588
		private byte a;

		// Token: 0x0400024D RID: 589
		private ushort b;

		// Token: 0x0400024E RID: 590
		private ushort c;
	}
}
