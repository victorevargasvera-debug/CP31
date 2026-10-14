using System;
using System.Globalization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000043 RID: 67
	public class RcmpReadIshTypeSet : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000F084 File Offset: 0x0000D284
		private byte LogicalPartition
		{
			get
			{
				short num = (short)705424988;
				short num2 = num;
				num = (short)905834076;
				switch (num2 == num)
				{
				}
				num = (short)501547009;
				if (num != 0)
				{
				}
				num = (short)514981888;
				if (num != 0)
				{
				}
				num = (short)987824128;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000F138 File Offset: 0x0000D338
		public ushort TotalTypeCount
		{
			get
			{
				short num = (short)2079175476;
				short num2 = num;
				num = (short)1799729972;
				switch (num2 == num)
				{
				}
				num = (short)1634664449;
				if (num != 0)
				{
				}
				num = (short)154271744;
				if (num != 0)
				{
				}
				num = (short)925106176;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000F1E8 File Offset: 0x0000D3E8
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000F298 File Offset: 0x0000D498
		private ushort NumberOfTypes
		{
			get
			{
				short num = (short)1646237068;
				short num2 = num;
				num = (short)916821388;
				switch (num2 == num)
				{
				}
				num = (short)429457409;
				if (num != 0)
				{
				}
				num = (short)126943232;
				if (num != 0)
				{
				}
				num = (short)986251264;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)418840574;
				short num2 = num;
				num = (short)2110521342;
				switch (num2 == num)
				{
				}
				num = (short)1970405377;
				if (num != 0)
				{
				}
				num = (short)1780875264;
				if (num != 0)
				{
				}
				num = (short)159645696;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000F348 File Offset: 0x0000D548
		private ushort Offset
		{
			get
			{
				short num = (short)845136180;
				short num2 = num;
				num = (short)1467793716;
				switch (num2 == num)
				{
				}
				num = (short)1249509377;
				if (num != 0)
				{
				}
				num = (short)754778112;
				if (num != 0)
				{
				}
				num = (short)1314848768;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000F3FC File Offset: 0x0000D5FC
		public ushort[] Types
		{
			get
			{
				short num = (short)168624129;
				if (num != 0)
				{
				}
				num = (short)1404436480;
				short num2 = num;
				num = (short)2096501944;
				short num3 = num;
				num = (short)1746015416;
				switch (num3 == num)
				{
				}
				num = (short)506855424;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		public RcmpReadIshTypeSet(byte logicalPartition, ushort numberofTypes, ushort offset)
		{
			base.Opcode = 261;
			this.a = logicalPartition;
			this.b = numberofTypes;
			this.c = offset;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)831711077;
			short num2 = num;
			num = (short)964749157;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2146041856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)895352832;
			if (num != 0)
			{
			}
			num = (short)1138884609;
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

		// Token: 0x060000F8 RID: 248 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 16;
			short num = (short)1487601664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)26148865;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_81;
				}
				for (;;)
				{
					IL_56:
					switch (num2)
					{
					case 0:
						goto IL_28E;
					case 1:
						if (length > global::Motorola.Common.Communication.r.b())
						{
							num = (short)2083782659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_28E;
					case 3:
					{
						num = (short)1956712783;
						short num3 = num;
						num = (short)1948782927;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1265172480;
							if (num != 0)
							{
							}
							object[] array = new object[]
							{
								global::Motorola.Common.Communication.r.b,
								global::Motorola.Common.Communication.r.a,
								global::Motorola.Common.Communication.r.a,
								global::Motorola.Common.Communication.r.a,
								global::Motorola.Common.Communication.r.c
							};
							global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
							this.a = (byte)array[0];
							this.b = (ushort)array[1];
							this.c = (ushort)array[2];
							this.d = (ushort)array[3];
							byte[] array2 = (byte[])array[4];
							this.e = new ushort[array2.Length / 2];
							int num4 = 0;
							break;
						}
						}
						num = (short)953286656;
						short num5 = num;
						num = (short)808976384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_2CF;
					case 5:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("캛ﮝ솟욡蒣ﮧ貫節즯슱톳隵ﺷ\udbb9햻튽떿냁ꇃﳅ", a_) + base.ReplyResult.ToString(), global::System.Array.Empty<object>());
						num = (short)1138229252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1762197509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CF;
					case 8:
					{
						int num4;
						if (num4 >= this.e.Length)
						{
							num = (short)2124480518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array2;
						this.e[num4] = (ushort)((int)array2[num4 * 2] * 256 + (int)array2[num4 * 2 + 1]);
						num4++;
						num = (short)1758920706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_81;
					IL_28E:
					num = (short)375848968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CF:
					num = (short)901382145;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_81:
				base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
				num = (short)664469511;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000F8EC File Offset: 0x0000DAEC
		public int MaxMessageSize
		{
			get
			{
				short num = (short)728014815;
				short num2 = num;
				num = (short)428384223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820655616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2089943040;
				if (num != 0)
				{
				}
				num = (short)228786177;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.Rcmp.RcmpReadIshTypeSet.HeaderSize + (int)(2 * this.b);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
		public static int HeaderSize
		{
			get
			{
				short num = (short)1160970241;
				if (num != 0)
				{
				}
				num = (short)1319567360;
				short num2 = num;
				num = (short)986680244;
				short num3 = num;
				num = (short)190614452;
				switch (num3 == num)
				{
				}
				num = (short)1665662976;
				if (num != 0)
				{
				}
				return 10;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000FA54 File Offset: 0x0000DC54
		public override string ToString()
		{
			int a_ = 7;
			short num = (short)1955062053;
			short num2 = num;
			num = (short)1199628581;
			switch (num2 == num)
			{
			default:
			{
				num = (short)312475648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1543438337;
			if (num != 0)
			{
			}
			num = (short)44892160;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ꖔ놘쮚ﲜ햠쪢톤캦욨얪邬풮肰캲馴禮첸횺\udfbc\udabe돀賂ꏄ鏆냈믊꣌볎꣒꫖铚믜맞鋠蛢釤\udae6鋨\ud8ea郬쏮ꗰ鳲致零闸꿺蓼迾搀䀂樄爆月缊「琎┐渒㤔䔖簘欚焜昞猠䘢嘤刦䔨弪ာ吮а串ᰴ", a_), new object[]
			{
				base.GetType().Name,
				this.LogicalPartition,
				this.NumberOfTypes,
				this.Offset,
				this.TotalTypeCount,
				base.ReplyResult
			});
		}

		// Token: 0x04000145 RID: 325
		private byte a;

		// Token: 0x04000146 RID: 326
		private ushort b;

		// Token: 0x04000147 RID: 327
		private ushort c;

		// Token: 0x04000148 RID: 328
		private ushort d;

		// Token: 0x04000149 RID: 329
		private ushort[] e;
	}
}
