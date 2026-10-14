using System;
using System.Net;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000021 RID: 33
	public class IPAddressCellRangeSeriesFiller : global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeSeriesFiller<string>
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x0000B060 File Offset: 0x00009260
		public IPAddressCellRangeSeriesFiller() : this(string.Empty, false)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000B07C File Offset: 0x0000927C
		public IPAddressCellRangeSeriesFiller(string name, bool autoCorrect = false) : base(name, autoCorrect)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000B094 File Offset: 0x00009294
		private long c(long A_0)
		{
			short num = (short)1364721664;
			int num2 = (int)((global::System.IntPtr)num);
			long result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 1:
					result = 16777216L;
					num = (short)1372389379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (A_0 == (long)((ulong)-65536))
					{
						num = (short)1613824005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)666107911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_148;
				case 4:
					result = 256L;
					num = (short)2145386502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					result = 65536L;
					goto IL_10C;
				case 6:
				{
					num = (short)1941768526;
					short num3 = num;
					num = (short)27986254;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10C;
					default:
						goto IL_EA;
					}
					break;
				}
				case 7:
					if (A_0 == (long)((ulong)-256))
					{
						num = (short)674430980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_175;
				case 8:
					goto IL_124;
				}
				IL_48:
				if (A_0 == (long)((ulong)-16777216))
				{
					num = (short)132317184;
					short num4 = num;
					num = (short)225378305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)148242434;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10C:
				num = (short)552927240;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EA:
			num = (short)463273984;
			if (num != 0)
			{
			}
			IL_124:
			return result;
			IL_148:
			num = (short)1573322753;
			if (num != 0)
			{
			}
			return result;
			IL_175:
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000B298 File Offset: 0x00009498
		private long b(long A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num2;
			short num3;
			long result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (num2 <= 223)
					{
						num3 = (short)126943235;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_246;
				case 1:
					if (num2 <= 191)
					{
						num3 = (short)879362055;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1E2;
				case 2:
					num3 = (short)641990657;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					result = (long)((ulong)-256);
					num3 = (short)1765998606;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					if (num2 >= 0)
					{
						num3 = (short)1777860614;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_28B;
				case 5:
					if (num2 <= 127)
					{
						num3 = (short)269680650;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_28B;
				case 6:
					goto IL_D6;
				case 7:
					result = (long)((ulong)-65536);
					num3 = (short)1133969419;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
					num3 = (short)673316865;
					if (num3 != 0)
					{
					}
					if (num2 >= 192)
					{
						num3 = (short)1044774921;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_246;
				case 9:
				{
					num3 = (short)23199744;
					short num4 = num3;
					num3 = (short)1576861696;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 10:
					result = (long)((ulong)-16777216);
					num3 = (short)1570308108;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
					goto IL_15D;
				case 12:
					goto IL_180;
				case 13:
					if (num2 >= 128)
					{
						num3 = (short)1507393538;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1E2;
				case 14:
					goto IL_1A4;
				}
				goto IL_4C;
				IL_1E2:
				num3 = (short)1573650440;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_28B:
				num3 = (short)151781389;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_15D:
			IL_180:
			IL_1A4:
			return result;
			IL_246:
			throw new global::System.NotSupportedException();
			IL_4C:
			num2 = ((int)(A_0 >> 24) & 255);
			num3 = (short)10394508;
			short num5 = num3;
			num3 = (short)1590598540;
			switch ((num5 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D6:
				num3 = (short)636485637;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			default:
			{
				num3 = (short)1790967808;
				if (num3 != 0)
				{
				}
				num3 = (short)414842884;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B570 File Offset: 0x00009770
		private long a(long A_0)
		{
			short num = (short)799801344;
			int num2 = (int)((global::System.IntPtr)num);
			long result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 1:
					result = 2130706432L;
					num = (short)621871107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (A_0 == (long)((ulong)-65536))
					{
						num = (short)1010237445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)613482503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_16E;
				case 4:
					result = (long)((ulong)-536871168);
					num = (short)275906566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					result = (long)((ulong)-1073807360);
					goto IL_133;
				case 6:
				{
					num = (short)230489544;
					short num3 = num;
					num = (short)1911815624;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_133;
					default:
						goto IL_EB;
					}
					break;
				}
				case 7:
					if (A_0 == (long)((ulong)-256))
					{
						num = (short)1988362244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				case 8:
					goto IL_14A;
				}
				IL_48:
				if (A_0 == (long)((ulong)-16777216))
				{
					num = (short)477036544;
					short num4 = num;
					num = (short)1655635969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1812660226;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_133:
				num = (short)1786904584;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EB:
			num = (short)606011392;
			if (num != 0)
			{
			}
			num = (short)1586167809;
			if (num != 0)
			{
			}
			IL_14A:
			IL_16E:
			return result;
			IL_173:
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000B774 File Offset: 0x00009974
		private long b(string A_0)
		{
			short num = (short)56498603;
			short num2 = num;
			num = (short)1820072363;
			switch (num2 == num)
			{
			}
			num = (short)348192769;
			if (num != 0)
			{
			}
			num = (short)99221504;
			if (num != 0)
			{
			}
			num = (short)1364656128;
			short num3 = num;
			return this.b(this.a(A_0));
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000B82C File Offset: 0x00009A2C
		private long a(string A_0)
		{
			short num = (short)1678854198;
			short num2 = num;
			num = (short)1391347766;
			switch (num2 == num)
			{
			}
			num = (short)797638657;
			if (num != 0)
			{
			}
			num = (short)1586364416;
			if (num != 0)
			{
			}
			num = (short)765460480;
			short num3 = num;
			return (long)((ulong)global::System.Net.IPAddress.HostToNetworkOrder((int)global::System.Net.IPAddress.Parse(A_0).Address));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000B8E8 File Offset: 0x00009AE8
		protected override bool TryParseValue(string value, out string parsedValue)
		{
			short num = (short)94934092;
			short num2 = num;
			num = (short)261985356;
			switch (num2 == num)
			{
			}
			num = (short)1891172352;
			if (num != 0)
			{
			}
			num = (short)1025507329;
			if (num != 0)
			{
			}
			num = (short)106233856;
			short num3 = num;
			parsedValue = value.Replace('-', '.');
			global::System.Net.IPAddress ipaddress;
			return global::System.Net.IPAddress.TryParse(parsedValue, out ipaddress);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		protected override bool TryDoIncrement(string oldValue, out string newValue)
		{
			short num = (short)359205071;
			short num2 = num;
			num = (short)164563151;
			switch (num2 == num)
			{
			}
			num = (short)302514177;
			if (num != 0)
			{
			}
			num = (short)1009319936;
			if (num != 0)
			{
			}
			num = (short)1328021504;
			short num3 = num;
			return this.TryDoIncrement(oldValue, 1, out newValue);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000BA5C File Offset: 0x00009C5C
		protected override bool TryDoIncrement(string oldValue, int count, out string newValue)
		{
			short num;
			try
			{
				num = (short)1970274304;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					int num3;
					long num4;
					long num5;
					long num6;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							goto IL_18A;
						case 1:
							num = (short)383713281;
							if (num != 0)
							{
							}
							goto IL_18A;
						case 2:
							if (num3 >= count)
							{
								num = (short)1537081349;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1360134152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num4 &= ~num5;
							num = (short)1830486023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_213;
						case 5:
							goto IL_1E5;
						case 6:
							goto IL_90;
						case 7:
							goto IL_90;
						case 8:
						{
							if ((num4 & num5) == (long)((ulong)-536871168))
							{
								num = (short)839450627;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 += num6;
							num = (short)2118844758;
							short num7 = num;
							num = (short)1794703702;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E5;
							default:
								num = (short)816513024;
								if (num != 0)
								{
								}
								num = (short)1042415622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_53;
						IL_90:
						num3++;
						num = (short)1115488257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_18A:
						num = (short)1039007746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E5:
						long newAddress = (long)((ulong)global::System.Net.IPAddress.HostToNetworkOrder((int)num4));
						newValue = new global::System.Net.IPAddress(newAddress).ToString();
						num = (short)1556807684;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_213:
					break;
					IL_53:
					num4 = this.a(oldValue);
					num5 = this.b(num4);
					num6 = this.c(num5);
					this.a(num5);
					num3 = 0;
					num = (short)689635328;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			catch (global::System.Exception)
			{
				newValue = null;
			}
			num = (short)1597898752;
			short num8 = num;
			return newValue != null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		protected override string ParseValue(string value)
		{
			short num = (short)665268920;
			short num2 = num;
			num = (short)190788280;
			switch (num2 == num)
			{
			}
			num = (short)1815543809;
			if (num != 0)
			{
			}
			num = (short)900988928;
			if (num != 0)
			{
			}
			num = (short)1597112320;
			short num3 = num;
			return value.Replace('-', '.');
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000BD80 File Offset: 0x00009F80
		protected override string DoIncrement(string value)
		{
			short num = (short)935365943;
			short num2 = num;
			num = (short)2030669111;
			switch (num2 == num)
			{
			}
			num = (short)982384640;
			if (num != 0)
			{
			}
			num = (short)1958150145;
			if (num != 0)
			{
			}
			num = (short)154861568;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000BE30 File Offset: 0x0000A030
		protected override string DoIncrement(string value, int count)
		{
			short num = (short)164318288;
			short num2 = num;
			num = (short)969690192;
			switch (num2 == num)
			{
			}
			num = (short)1306591233;
			if (num != 0)
			{
			}
			num = (short)130220032;
			if (num != 0)
			{
			}
			num = (short)1274675200;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
