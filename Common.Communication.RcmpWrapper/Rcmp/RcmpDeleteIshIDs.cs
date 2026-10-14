using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200002E RID: 46
	public class RcmpDeleteIshIDs : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000B3E4 File Offset: 0x000095E4
		private byte LogicalPartition
		{
			get
			{
				short num = (short)623067679;
				short num2 = num;
				num = (short)1811169823;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1055588352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2078932992;
				if (num != 0)
				{
				}
				num = (short)265420801;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000B494 File Offset: 0x00009694
		public ushort IshType
		{
			get
			{
				short num = (short)335766658;
				short num2 = num;
				num = (short)1982489730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1494810624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1839136769;
				if (num != 0)
				{
				}
				num = (short)1425801216;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000B544 File Offset: 0x00009744
		private ushort StartID
		{
			get
			{
				short num = (short)835735422;
				short num2 = num;
				num = (short)671567742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1839005696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1081999360;
				if (num != 0)
				{
				}
				num = (short)98369537;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000B5F8 File Offset: 0x000097F8
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000B6A8 File Offset: 0x000098A8
		public ushort EndID
		{
			get
			{
				short num = (short)1547076406;
				short num2 = num;
				num = (short)1070891830;
				switch (num2 == num)
				{
				default:
				{
					num = (short)128647168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)651034625;
				if (num != 0)
				{
				}
				num = (short)581304320;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1287801027;
				short num2 = num;
				num = (short)830359747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1105723392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)519176192;
				if (num != 0)
				{
				}
				num = (short)1567096833;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000B75C File Offset: 0x0000995C
		public RcmpDeleteIshIDs(byte partition, ushort type, ushort startID, ushort endID)
		{
			base.Opcode = 258;
			this.a = partition;
			this.b = type;
			this.c = startID;
			this.d = endID;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000B798 File Offset: 0x00009998
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)706197106;
			short num2 = num;
			num = (short)1188345458;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1765736448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)102957057;
			if (num != 0)
			{
			}
			num = (short)2028011520;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c,
				this.d
			});
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000B894 File Offset: 0x00009A94
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num;
			int num3;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)512491520;
					short num2 = num;
					switch (num3)
					{
					case 0:
					{
						num = (short)609812481;
						if (num != 0)
						{
						}
						object[] array = new object[]
						{
							global::Motorola.Common.Communication.r.b,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.a
						};
						global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
						this.a = (byte)array[0];
						this.b = (ushort)array[1];
						this.c = (ushort)array[2];
						this.d = (ushort)array[3];
						num = (short)617120542;
						short num4 = num;
						num = (short)1563525918;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5F;
						default:
							num = (short)811925504;
							if (num != 0)
							{
							}
							num = (short)1718812673;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						if (length > global::Motorola.Common.Communication.r.b())
						{
							num = (short)1830223872;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_45;
				}
				return;
			}
			IL_45:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			IL_5F:
			num = (short)1496645634;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000BA38 File Offset: 0x00009C38
		public int MaxMessageSize
		{
			get
			{
				short num = (short)553420787;
				short num2 = num;
				num = (short)1748797427;
				switch (num2 == num)
				{
				}
				num = (short)1044578305;
				if (num != 0)
				{
				}
				num = (short)163315712;
				if (num != 0)
				{
				}
				num = (short)1009385472;
				short num3 = num;
				return 10;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		private static int RcmpDeleteIshIDsHeaderSize
		{
			get
			{
				short num = (short)1660486290;
				short num2 = num;
				num = (short)357237394;
				switch (num2 == num)
				{
				}
				num = (short)443285505;
				if (num != 0)
				{
				}
				num = (short)2125070336;
				if (num != 0)
				{
				}
				num = (short)317521920;
				short num3 = num;
				return 10;
			}
		}

		// Token: 0x040000E5 RID: 229
		private byte a;

		// Token: 0x040000E6 RID: 230
		private ushort b;

		// Token: 0x040000E7 RID: 231
		private ushort c;

		// Token: 0x040000E8 RID: 232
		private ushort d;
	}
}
