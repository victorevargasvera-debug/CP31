using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000084 RID: 132
	public class XcmpUnkill : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0001D768 File Offset: 0x0001B968
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0001D814 File Offset: 0x0001BA14
		public byte Function
		{
			get
			{
				short num = (short)1379324668;
				short num2 = num;
				num = (short)1552732924;
				switch (num2 == num)
				{
				}
				num = (short)926089217;
				if (num != 0)
				{
				}
				num = (short)1529151488;
				if (num != 0)
				{
				}
				num = (short)1854799872;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1446070807;
				short num2 = num;
				num = (short)2084325911;
				switch (num2 == num)
				{
				}
				num = (short)1873477632;
				if (num != 0)
				{
				}
				num = (short)1172897793;
				if (num != 0)
				{
				}
				num = (short)121503744;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0001D974 File Offset: 0x0001BB74
		public ushort Size
		{
			get
			{
				short num = (short)1780756463;
				short num2 = num;
				num = (short)1459040239;
				switch (num2 == num)
				{
				}
				num = (short)1113391104;
				if (num != 0)
				{
				}
				num = (short)1639251969;
				if (num != 0)
				{
				}
				num = (short)1363673088;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1151115764;
				short num2 = num;
				num = (short)1108713972;
				switch (num2 == num)
				{
				}
				num = (short)2131230721;
				if (num != 0)
				{
				}
				num = (short)1959460864;
				if (num != 0)
				{
				}
				num = (short)1589837824;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0001DA24 File Offset: 0x0001BC24
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x0001DAFC File Offset: 0x0001BCFC
		public byte[] Values
		{
			get
			{
				if (this.c != null)
				{
					short num;
					for (;;)
					{
						num = (short)1265172481;
						if (num != 0)
						{
						}
						num = (short)736945307;
						short num2 = num;
						num = (short)604955803;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_69;
						}
					}
					IL_69:
					num = (short)1613234176;
					short num3 = num;
					num = (short)1032781824;
					if (num != 0)
					{
					}
					byte[] array = new byte[(int)this.Size];
					global::System.Buffer.BlockCopy(this.c, 0, array, 0, (int)this.Size);
					return array;
				}
				return null;
			}
			set
			{
				short num = (short)1334509570;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)124911616;
						short num3 = num;
						this.Size = (ushort)value.Length;
						this.c = new byte[(int)this.Size];
						global::System.Buffer.BlockCopy(value, 0, this.c, 0, (int)this.Size);
						num = (short)510673790;
						short num4 = num;
						num = (short)360203134;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5F;
						default:
							num = (short)1327235072;
							if (num != 0)
							{
							}
							num = (short)557252609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					goto IL_31;
					IL_5F:
					num = (short)156303360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31:
					num = (short)852819969;
					if (num != 0)
					{
					}
					if (value != null)
					{
						goto IL_5F;
					}
					break;
				}
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0001DC40 File Offset: 0x0001BE40
		public XcmpUnkill(global::Motorola.Common.Communication.Rcmp.UnkillFunction function, byte[] values)
		{
			base.Opcode = 1132;
			this.Function = (byte)function;
			this.Size = 0;
			this.Values = values;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001DC74 File Offset: 0x0001BE74
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			int a_ = 3;
			short num = (short)1244200969;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_200;
				case 1:
					if (this.Size != 0)
					{
						num = (short)942145542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C4;
				case 2:
					num = (short)1352990721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1834090504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					if (this.Function != 1)
					{
						goto IL_1C4;
					}
					num = (short)442654472;
					short num3 = num;
					num = (short)4546312;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1914437632;
						if (num != 0)
						{
						}
						num = (short)1777729539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_128;
				case 6:
					goto IL_1BF;
				case 7:
					if (this.c == null)
					{
						num = (short)16449536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28C;
				case 8:
					if (this.Size == 0)
					{
						num = (short)1440612357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C4;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				}
				IL_57:
				num = (short)360251393;
				if (num != 0)
				{
				}
				if (this.Function == 0)
				{
					num = (short)1294925826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)498532356;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C4:
				num = (short)29163527;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_128:
			num = (short)1303314432;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\ud98eﾒ", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("즎ﺐ떔춠莢쪤힦첨\ud9aa첬\udbae\ud8b0\udcb2\udbb4쒶閸鮺\udebe귀뛂ꃄ듆ꛊ료볎ꗐ믔룖귘ﯚ뿜뫞쇠跢郤详藨", a_));
			IL_1BF:
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\ud98eﾒ", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("즎ﺐ떔ﲘ爵튠힢薤솦욨\ud9aa趬\udaae\udfb0麲\udeb4\udeb6햸ힺ鶼춾ꃀꟂ계꣆鯌껎뷐ꛒ냔ꓖ律뛚꣜곞闠쏢蟤苦짨藪飬菮鷰", a_));
			IL_200:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.Function,
				this.Size
			});
			IL_28C:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.Function,
				this.Size,
				this.Values
			});
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001DF50 File Offset: 0x0001C150
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					object[] array = new object[]
					{
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.a,
						global::Motorola.Common.Communication.r.c
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.Size = (ushort)array[1];
					this.c = (byte[])array[2];
					num2 = (short)482738178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)761889359;
					short num3 = num2;
					num2 = (short)729973327;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1641807873;
						if (num2 != 0)
						{
						}
						num2 = (short)264372224;
						if (num2 != 0)
						{
						}
						if (this.a == 0)
						{
							num2 = (short)1917255680;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					if ((int)this.Size != this.c.Length)
					{
						num2 = (short)1043136515;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_13A;
				case 4:
					num2 = (short)2120613889;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)930873348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_31;
			}
			IL_13A:
			num2 = (short)1197408256;
			short num4 = num2;
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\ud98eﾒ", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("즎ﺐ떔춠莢쪤힦첨\ud9aa첬\udbae\ud8b0\udcb2\udbb4쒶閸鮺\udabe뗀뛂럄꧆곈꿊볎룐꧒냔뷘듚룜곞쇠跢諤鏦짨蛪賬鯮鋰鯲헴银釸髺釼鏾搀洂戄戆⤈紊氌挎搐瘒㈔搖㤘眚砜焞䘠圢䴤", a_));
			IL_31:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)814809093;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x04000296 RID: 662
		private byte a;

		// Token: 0x04000297 RID: 663
		private ushort b;

		// Token: 0x04000298 RID: 664
		private byte[] c;
	}
}
