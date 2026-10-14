using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000053 RID: 83
	public class RcmpSoftpot : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00012584 File Offset: 0x00010784
		private byte Operation
		{
			get
			{
				short num = (short)1394209191;
				short num2 = num;
				num = (short)210432423;
				switch (num2 == num)
				{
				}
				num = (short)776798209;
				if (num != 0)
				{
				}
				num = (short)780926976;
				short num3 = num;
				num = (short)1581645824;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00012634 File Offset: 0x00010834
		private byte Type
		{
			get
			{
				short num = (short)397535962;
				short num2 = num;
				num = (short)2043079386;
				switch (num2 == num)
				{
				}
				num = (short)204734464;
				if (num != 0)
				{
				}
				num = (short)1019936768;
				short num3 = num;
				num = (short)1248919553;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000126E4 File Offset: 0x000108E4
		private byte[] Values
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				byte[] array;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						if (this.c != null)
						{
							num2 = (short)717422593;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return array;
					case 1:
						array = new byte[this.c.Length];
						global::System.Buffer.BlockCopy(this.c, 0, array, 0, this.c.Length);
						num2 = (short)155058178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_12E;
					}
					break;
				}
				IL_1C:
				array = null;
				num2 = (short)1129809115;
				short num3 = num2;
				num2 = (short)454853851;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_12E:
					break;
				default:
				{
					num2 = (short)1948188672;
					short num4 = num2;
					num2 = (short)911409153;
					if (num2 != 0)
					{
					}
					num2 = (short)2138439680;
					if (num2 != 0)
					{
					}
					num2 = (short)64356352;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
				return array;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00012824 File Offset: 0x00010A24
		public RcmpSoftpot(byte operation, byte type, byte[] values)
		{
			base.Opcode = 1;
			this.a = operation;
			this.b = type;
			this.c = values;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00012854 File Offset: 0x00010A54
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			int a_ = 11;
			short num = (short)1274937355;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1572077569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.a != 6)
					{
						num = (short)1875902470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_377;
				case 2:
					if (this.a == 4)
					{
						num = (short)384827401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_159;
				case 3:
					if (this.c != null)
					{
						num = (short)330956808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B7;
				case 4:
					if (this.c != null)
					{
						num = (short)1494941713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_159;
				case 5:
					goto IL_377;
				case 6:
					num = (short)1477312528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1418067970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_194;
				case 9:
					num = (short)1169358849;
					if (num != 0)
					{
					}
					goto IL_9B;
				case 10:
					goto IL_D6;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					continue;
				case 12:
					if (this.a != 1)
					{
						num = (short)1103626247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9B;
				case 13:
					if (this.c == null)
					{
						num = (short)1655963658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_159;
				case 14:
					if (this.a != 3)
					{
						num = (short)1687289856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_377;
				case 15:
					num = (short)1431633934;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (this.a == 7)
					{
						goto IL_2F5;
					}
					num = (short)1745682444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					num = (short)1182066705;
					short num3 = num;
					num = (short)1604511761;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2F5;
					default:
						goto IL_299;
					}
					break;
				}
				}
				IL_75:
				if (this.a != 0)
				{
					num = (short)754122767;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_377;
				IL_9B:
				num = (short)917307405;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_159:
				num = (short)694288387;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F5:
				num = (short)1187184645;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_377:
				num = (short)1962147844;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D6:
			num = (short)263061504;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("솖爵튠", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("톖붜펠쪢톤슦覨쒪\uddac쪮쎰튲솴\udeb6횸햺캼鎾闂꓄ꯆ볈껊뻌볐ꛒꛔꏖ律뗚닜ꯞ쇠臢胤쟦蟨黪臬菮", a_));
			IL_194:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c
			});
			IL_299:
			num = (short)555614208;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("솖爵튠", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("톖붜쒠슢솤螦욨\udbaa좬\uddae킰잲\udcb4\ud8b6ힸ좺醼龾韀ꋂ꧄닆곈룊ꋎꓐꃒꇔ믘뻚﷜뇞铠迢觤", a_));
			IL_3B7:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b
			});
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00012C50 File Offset: 0x00010E50
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1463943169;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1431633921;
					if (num2 != 0)
					{
					}
					object[] array = new object[]
					{
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.c
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (byte)array[0];
					this.b = (byte)array[1];
					this.c = (byte[])array[2];
					num2 = (short)2074148866;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_187;
				}
				break;
			}
			IL_1C:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)369084910;
			short num3 = num2;
			num2 = (short)2012989934;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_187:
				break;
			default:
			{
				num2 = (short)753270784;
				short num4 = num2;
				num2 = (short)1794048000;
				if (num2 != 0)
				{
				}
				num2 = (short)1369309184;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04000172 RID: 370
		private byte a;

		// Token: 0x04000173 RID: 371
		private byte b;

		// Token: 0x04000174 RID: 372
		private byte[] c;
	}
}
