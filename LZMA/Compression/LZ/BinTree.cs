using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000014 RID: 20
	public class BinTree : global::SevenZip.Compression.LZ.InWindow, global::SevenZip.Compression.LZ.b, global::SevenZip.Compression.LZ.a
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00005E28 File Offset: 0x00004028
		public void SetType(int numHashBytes)
		{
			this.i = (numHashBytes > 2);
			short num;
			if (this.i)
			{
				num = (short)1223516524;
				short num2 = num;
				num = (short)689922412;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)423165952;
					if (num != 0)
					{
					}
					num = (short)439222273;
					if (num != 0)
					{
					}
					this.q = 0U;
					this.r = 4U;
					this.s = 66560U;
					return;
				}
			}
			num = (short)1631191040;
			short num3 = num;
			this.q = 2U;
			this.r = 3U;
			this.s = 0U;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005F1C File Offset: 0x0000411C
		public new void SetStream(global::System.IO.Stream stream)
		{
			short num = (short)81694470;
			short num2 = num;
			num = (short)1219202822;
			switch (num2 == num)
			{
			}
			num = (short)1539637249;
			if (num != 0)
			{
			}
			num = (short)346292224;
			if (num != 0)
			{
			}
			num = (short)1524695040;
			short num3 = num;
			base.SetStream(stream);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005FD0 File Offset: 0x000041D0
		public new void ReleaseStream()
		{
			short num = (short)1874197754;
			short num2 = num;
			num = (short)846396666;
			switch (num2 == num)
			{
			}
			num = (short)957087744;
			if (num != 0)
			{
			}
			num = (short)19005441;
			if (num != 0)
			{
			}
			num = (short)1373437952;
			short num3 = num;
			base.ReleaseStream();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006080 File Offset: 0x00004280
		public new void Init()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			uint num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (num2 >= this.h)
					{
						num3 = (short)901513218;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.e[(int)num2] = 0U;
					num2 += 1U;
					num3 = (short)484573185;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					goto IL_3E;
				case 2:
					goto IL_112;
				case 3:
					IL_3C:
					goto IL_3E;
				}
				goto IL_20;
				IL_3E:
				num3 = (short)2131085174;
				short num4 = num3;
				num3 = (short)1606076278;
				switch ((num4 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3C;
				case 1:
					break;
				default:
				{
					num3 = (short)379518976;
					short num5 = num3;
					break;
				}
				}
				num3 = (short)299302913;
				if (num3 != 0)
				{
				}
				num3 = (short)294977536;
				if (num3 != 0)
				{
				}
				num3 = (short)1074331648;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_112:
			this.a = 0U;
			base.ReduceOffsets(-1);
			return;
			IL_20:
			base.Init();
			num2 = 0U;
			num3 = (short)496435203;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000061D8 File Offset: 0x000043D8
		public new void MovePos()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			uint num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1274907431;
					short num3 = num2;
					num2 = (short)849709863;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4D;
					default:
						num2 = (short)1859321857;
						if (num2 != 0)
						{
						}
						num2 = (short)1942028288;
						if (num2 != 0)
						{
						}
						goto IL_93;
					}
					break;
				}
				case 1:
					this.a();
					num2 = (short)711852034;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				case 3:
					this.a = 0U;
					num2 = (short)869072896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this._pos == 2147483647U)
					{
						num2 = (short)1880555521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					goto IL_4D;
				}
				goto IL_28;
				IL_4D:
				if (num4 >= this.b)
				{
					num2 = (short)376111107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_93:
				num2 = (short)682819584;
				short num5 = num2;
				base.MovePos();
				num2 = (short)1472069636;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_28:
			num4 = this.a + 1U;
			this.a = num4;
			num2 = (short)1003028485;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006380 File Offset: 0x00004580
		public new byte GetIndexByte(int index)
		{
			short num = (short)1707999233;
			if (num != 0)
			{
			}
			num = (short)1581141978;
			short num2 = num;
			num = (short)832983002;
			switch (num2 == num)
			{
			}
			num = (short)846594048;
			if (num != 0)
			{
			}
			num = (short)1508442112;
			short num3 = num;
			return base.GetIndexByte(index);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006430 File Offset: 0x00004630
		public new uint GetMatchLen(int index, uint distance, uint limit)
		{
			short num = (short)1347019432;
			short num2 = num;
			num = (short)1625285288;
			switch (num2 == num)
			{
			}
			num = (short)370737153;
			if (num != 0)
			{
			}
			num = (short)850722816;
			if (num != 0)
			{
			}
			num = (short)1723138048;
			short num3 = num;
			return base.GetMatchLen(index, distance, limit);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000064E4 File Offset: 0x000046E4
		public new uint GetNumAvailableBytes()
		{
			short num = (short)815071233;
			if (num != 0)
			{
			}
			num = (short)1049306355;
			short num2 = num;
			num = (short)1821385971;
			switch (num2 == num)
			{
			}
			num = (short)619511808;
			if (num != 0)
			{
			}
			num = (short)1085014016;
			short num3 = num;
			return base.GetNumAvailableBytes();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006598 File Offset: 0x00004798
		public void Create(uint historySize, uint keepAddBufferBefore, uint matchMaxLen, uint keepAddBufferAfter)
		{
			short num = (short)231669760;
			switch (num)
			{
			default:
			{
				num = (short)858652685;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					uint num3;
					uint num5;
					switch (num2)
					{
					case 0:
						goto IL_1E1;
					case 1:
						this.d = new uint[(this.b = num3) * 2U];
						num = (short)1924726788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.b != num3)
						{
							num = (short)1426718721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27B;
					case 3:
						return;
					case 4:
					{
						num = (short)2054400286;
						short num4 = num;
						num = (short)1719773470;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_140;
						default:
							num = (short)1074987008;
							if (num != 0)
							{
							}
							num = (short)1218969601;
							if (num != 0)
							{
							}
							goto IL_27B;
						}
						break;
					}
					case 5:
						goto IL_140;
					case 6:
						goto IL_9E;
					case 7:
						if (this.i)
						{
							num = (short)1708785673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E1;
					case 8:
						if (num5 != this.h)
						{
							num = (short)649134090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						num5 = historySize - 1U;
						num5 |= num5 >> 1;
						num5 |= num5 >> 2;
						num5 |= num5 >> 4;
						num5 |= num5 >> 8;
						num5 >>= 1;
						num5 |= 65535U;
						num = (short)151060485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						this.e = new uint[this.h = num5];
						num = (short)964493315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num5 >>= 1;
						num = (short)961413132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_A3;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					IL_7D:
					if (historySize > 2147483391U)
					{
						num = (short)39321606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.f = 16U + (matchMaxLen >> 1);
					uint keepSizeReserv = (historySize + keepAddBufferBefore + matchMaxLen + keepAddBufferAfter) / 2U + 256U;
					base.Create(historySize + keepAddBufferBefore, matchMaxLen + keepAddBufferAfter, keepSizeReserv);
					this.c = matchMaxLen;
					num3 = historySize + 1U;
					num = (short)353435650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					this.g = num5;
					num5 += 1U;
					num5 += this.s;
					num = (short)1354170368;
					short num6 = num;
					num = (short)756678656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_140:
					if (num5 > 16777216U)
					{
						num = (short)2136670219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
					IL_1E1:
					num = (short)346488840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27B:
					num5 = 65536U;
					num = (short)1969356807;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9E:
				throw new global::System.Exception();
			}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006910 File Offset: 0x00004B10
		public uint GetMatches(uint[] distances)
		{
			short num = (short)1235353600;
			switch (num)
			{
			default:
			{
				num = (short)1918304264;
				int num2 = (int)((global::System.IntPtr)num);
				uint num4;
				for (;;)
				{
					uint num3;
					uint num5;
					uint num6;
					uint num8;
					uint num10;
					uint num9;
					uint num11;
					uint num12;
					uint num13;
					uint num14;
					uint num15;
					uint val;
					uint num16;
					uint num17;
					uint num18;
					uint num22;
					uint num23;
					uint num24;
					uint num25;
					uint val2;
					switch (num2)
					{
					case 0:
						num3 = (distances[(int)num4++] = 2U);
						distances[(int)num4++] = this._pos - num5 - 1U;
						num = (short)1015873552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						uint num7;
						num6 = this.a - num7 + this.b;
						goto IL_B7A;
					}
					case 2:
						num5 = this.e[(int)num8];
						num9 = this.e[(int)(1024U + num10)];
						this.e[(int)num8] = this._pos;
						this.e[(int)(1024U + num10)] = this._pos;
						num = (short)1351286813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)703856646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this._bufferBase[(int)(this._bufferOffset + num9)] == this._bufferBase[(int)num11])
						{
							num = (short)1573650435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC0;
					case 5:
						num3 = (distances[(int)num4++] = this.q);
						distances[(int)num4++] = this._pos - num12 - 1U;
						num = (short)2121334804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (num9 == num5)
						{
							num = (short)989855771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37E;
					case 7:
						this.d[(int)num13] = num12;
						num13 = num14 + 1U;
						num12 = this.d[(int)num13];
						val = num15;
						num = (short)88866840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_14D;
						}
						continue;
					case 9:
						num = (short)380764174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)855375919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_3BC;
					case 12:
						num = (short)360775681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_686;
					case 14:
						num16 = 0U;
						goto IL_62D;
					case 15:
						goto IL_6D8;
					case 16:
						goto IL_340;
					case 17:
						if (num17 < this.r)
						{
							num = (short)1293353024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					case 18:
					{
						uint num7;
						num6 = this.a - num7;
						goto IL_B7A;
					}
					case 19:
						if (num15 == num17)
						{
							num = (short)264765472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 20:
						goto IL_803;
					case 21:
						if (num9 > num18)
						{
							num = (short)822149171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC0;
					case 22:
						goto IL_686;
					case 23:
					{
						num = (short)25886720;
						short num19 = num;
						uint num20 = global::SevenZip.a.a[(int)this._bufferBase[(int)num11]] ^ (uint)this._bufferBase[(int)(num11 + 1U)];
						num8 = (num20 & 1023U);
						uint num21 = num20 ^ (uint)((uint)this._bufferBase[(int)(num11 + 2U)] << 8);
						num10 = (num21 & 65535U);
						num22 = ((num21 ^ global::SevenZip.a.a[(int)this._bufferBase[(int)(num11 + 3U)]] << 5) & this.g);
						num = (short)1798701069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_C8B;
					case 25:
						if (this._bufferBase[(int)(num23 + num15)] == this._bufferBase[(int)(num11 + num15)])
						{
							num = (short)345440321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_302;
					case 26:
						goto IL_C4A;
					case 27:
						num4 -= 2U;
						num = (short)1682833436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_37E;
					case 29:
						if (num5 > num18)
						{
							num = (short)322306084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340;
					case 30:
					{
						if (num24-- == 0U)
						{
							num = (short)11272254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num7 = this._pos - num12;
						num = (short)934608936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_ABB;
					case 32:
						this.d[(int)num13] = this.d[(int)num14];
						this.d[(int)num25] = this.d[(int)(num14 + 1U)];
						num = (short)115277850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_44F;
					case 34:
						if (num4 != 0U)
						{
							num = (short)479920173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44F;
					case 35:
						if (this._bufferBase[(int)(this._bufferOffset + num5)] == this._bufferBase[(int)num11])
						{
							num = (short)238616576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340;
					case 36:
						num = (short)738721827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (this._bufferBase[(int)(num23 + num15)] == this._bufferBase[(int)(num11 + num15)])
						{
							num = (short)1391722535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 38:
						if (this.q != 0U)
						{
							num = (short)20643882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_803;
					case 39:
						num = (short)1854996491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						uint num7;
						if (num7 > this.a)
						{
							num = (short)619642892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)933953554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						if (num12 > num18)
						{
							num = (short)1797914678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8B;
					case 42:
						num = (short)1757020213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num16 = this._pos - this.b;
						goto IL_62D;
					case 44:
					{
						if (this.i)
						{
							num = (short)1731133463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2135859941;
						short num26 = num;
						num = (short)1910022885;
						switch ((num26 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B7;
						default:
							num = (short)210108416;
							if (num != 0)
							{
							}
							num22 = (uint)((int)this._bufferBase[(int)num11] ^ (int)this._bufferBase[(int)(num11 + 1U)] << 8);
							num = (short)2073886742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 45:
						num = (short)483721266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (this._bufferBase[(int)(num23 + num15)] < this._bufferBase[(int)(num11 + num15)])
						{
							goto IL_1B7;
						}
						this.d[(int)num25] = num12;
						num25 = num14;
						num12 = this.d[(int)num25];
						val2 = num15;
						num = (short)113115196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (this._bufferBase[(int)(this._bufferOffset + num12 + this.q)] != this._bufferBase[(int)(num11 + this.q)])
						{
							num = (short)795475973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_803;
					case 48:
						if ((num15 += 1U) == num17)
						{
							num = (short)1638449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)449183769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_302;
					case 50:
						if (num5 == num12)
						{
							num = (short)1209925687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44F;
					case 51:
						num = (short)2021982212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_AC0;
					case 53:
						if (num12 > num18)
						{
							num = (short)1255145482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_803;
					case 54:
						num = (short)644022273;
						if (num != 0)
						{
						}
						num = (short)1700069406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						num4 -= 2U;
						num3 = 1U;
						num = (short)2047606817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						num17 = this.c;
						num = (short)1495007247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (this.i)
						{
							num = (short)206045186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44F;
					case 58:
					{
						num3 = (distances[(int)num4++] = num15);
						uint num7;
						distances[(int)num4++] = num7 - 1U;
						num = (short)1332936723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						goto IL_C8B;
					case 60:
						goto IL_C8B;
					case 61:
						if (num3 < num15)
						{
							num = (short)514523194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 62:
						goto IL_A8B;
					case 63:
						if (this._pos <= this.b)
						{
							num = (short)1571749897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)968032299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						goto IL_628;
					case 65:
						goto IL_3BC;
					}
					IL_14D:
					if (this._pos + this.c <= this._streamPos)
					{
						num = (short)1174405176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num17 = this._streamPos - this._pos;
					num = (short)1806499857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_183:
					num = (short)68419630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B7:
					num = (short)1195507719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_302:
					num = (short)1177354301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_340:
					num = (short)1750532117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37E:
					num3 = (distances[(int)num4++] = 3U);
					distances[(int)num4++] = this._pos - num9 - 1U;
					num5 = num9;
					num = (short)84475956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BC:
					num = (short)1117913136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44F:
					this.e[(int)(this.s + num22)] = this._pos;
					num25 = (this.a << 1) + 1U;
					num13 = this.a << 1;
					val = (val2 = this.q);
					num = (short)805765158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62D:
					num18 = num16;
					num11 = this._bufferOffset + this._pos;
					num3 = 1U;
					num8 = 0U;
					num10 = 0U;
					num = (short)1630076972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_686:
					num12 = this.e[(int)(this.s + num22)];
					num = (short)1931608121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D8:
					num4 = 0U;
					num = (short)1039204415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_803:
					num24 = this.f;
					num = (short)1131610171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A8B:
					this.d[(int)num25] = (this.d[(int)num13] = 0U);
					num = (short)2035154975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC0:
					num = (short)473759778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B7A:
					num14 = num6 << 1;
					num23 = this._bufferOffset + num12;
					num15 = global::System.Math.Min(val2, val);
					num = (short)1003159589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C8B:
					num = (short)441647145;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_628:
				this.MovePos();
				return 0U;
				IL_ABB:
				IL_C4A:
				this.MovePos();
				return num4;
			}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007614 File Offset: 0x00005814
		public void Skip(uint num)
		{
			for (;;)
			{
				short num2 = (short)1083834368;
				switch (num2)
				{
				default:
				{
					num2 = (short)1911029790;
					int num3 = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						uint num4;
						uint num6;
						uint num7;
						uint num8;
						uint num9;
						uint num10;
						uint num12;
						uint num16;
						uint num17;
						uint num18;
						uint num19;
						uint val;
						uint num20;
						uint num21;
						uint val2;
						switch (num3)
						{
						case 0:
							if (this._pos <= this.b)
							{
								num2 = (short)435945484;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)396492811;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							this.MovePos();
							num2 = (short)222887975;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
						{
							uint num5;
							num4 = this.a - num5;
							goto IL_6B0;
						}
						case 3:
							num6 = 0U;
							goto IL_39F;
						case 4:
							if (num7 == num8)
							{
								num2 = (short)33095707;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_1CB;
						case 5:
							num2 = (short)453640193;
							if (num2 != 0)
							{
							}
							goto IL_2D4;
						case 6:
							if (num9 > num10)
							{
								num2 = (short)1973878810;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_67B;
						case 7:
							goto IL_470;
						case 8:
							return;
						case 9:
							goto IL_28E;
						case 10:
							goto IL_7AF;
						case 11:
							num6 = this._pos - this.b;
							goto IL_39F;
						case 12:
							num2 = (short)1712979971;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 13:
							goto IL_600;
						case 14:
						{
							uint num5;
							num4 = this.a - num5 + this.b;
							goto IL_6B0;
						}
						case 15:
						{
							uint num11 = global::SevenZip.a.a[(int)this._bufferBase[(int)num12]] ^ (uint)this._bufferBase[(int)(num12 + 1U)];
							uint num13 = num11 & 1023U;
							this.e[(int)num13] = this._pos;
							uint num14 = num11 ^ (uint)((uint)this._bufferBase[(int)(num12 + 2U)] << 8);
							uint num15 = num14 & 65535U;
							this.e[(int)(1024U + num15)] = this._pos;
							num16 = ((num14 ^ global::SevenZip.a.a[(int)this._bufferBase[(int)(num12 + 3U)]] << 5) & this.g);
							num2 = (short)86048790;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 16:
							if (this._bufferBase[(int)(num17 + num7)] == this._bufferBase[(int)(num12 + num7)])
							{
								num2 = (short)1238958108;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_600;
						case 17:
							goto IL_42D;
						case 18:
							this.d[(int)num18] = num9;
							num18 = num19 + 1U;
							num9 = this.d[(int)num18];
							val = num7;
							num2 = (short)1427308575;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 19:
						{
							if (num20-- == 0U)
							{
								num2 = (short)498991124;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							uint num5 = this._pos - num9;
							num2 = (short)1155072037;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 20:
							goto IL_67B;
						case 21:
							goto IL_446;
						case 22:
							goto IL_741;
						case 23:
							if (this.i)
							{
								num2 = (short)793116687;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							num16 = (uint)((int)this._bufferBase[(int)num12] ^ (int)this._bufferBase[(int)(num12 + 1U)] << 8);
							num2 = (short)1619525665;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 24:
							num2 = (short)54132741;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 25:
							goto IL_7AF;
						case 26:
							num2 = (short)1046151187;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 27:
							this.d[(int)num18] = this.d[(int)num19];
							this.d[(int)num21] = this.d[(int)(num19 + 1U)];
							num2 = (short)667484170;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 28:
							goto IL_2D4;
						case 29:
						{
							num2 = (short)1807821228;
							short num22 = num2;
							num2 = (short)1373710764;
							switch ((num22 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_446;
							default:
								num2 = (short)1429012480;
								if (num2 != 0)
								{
								}
								if (this._bufferBase[(int)(num17 + num7)] < this._bufferBase[(int)(num12 + num7)])
								{
									num2 = (short)2027683840;
									short num23 = num2;
									num2 = (short)811466770;
									num3 = (int)((global::System.IntPtr)num2);
									continue;
								}
								this.d[(int)num21] = num9;
								num21 = num19;
								num9 = this.d[(int)num21];
								val2 = num7;
								num2 = (short)2074279943;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 30:
							switch (0)
							{
							case 0:
								goto IL_E9;
							}
							continue;
						case 31:
							goto IL_470;
						case 32:
							if (num8 < this.r)
							{
								num2 = (short)1436614657;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_28E;
						case 33:
							goto IL_741;
						case 34:
							num2 = (short)1218904078;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 35:
							if (this._bufferBase[(int)(num17 + num7)] == this._bufferBase[(int)(num12 + num7)])
							{
								num2 = (short)1630797848;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_1CB;
						case 36:
							goto IL_470;
						case 37:
						{
							uint num5;
							if (num5 > this.a)
							{
								num2 = (short)628293666;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)254476290;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 38:
							num8 = this.c;
							num2 = (short)730267657;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 39:
							goto IL_42D;
						case 40:
							if ((num7 += 1U) == num8)
							{
								num2 = (short)802029581;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1013973008;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						IL_E9:
						if (this._pos + this.c <= this._streamPos)
						{
							num2 = (short)641597478;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						num8 = this._streamPos - this._pos;
						num2 = (short)1995702304;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_1CB:
						num2 = (short)1825832989;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_28E:
						num2 = (short)1038483456;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_2D4:
						num2 = (short)210370600;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_39F:
						num10 = num6;
						num12 = this._bufferOffset + this._pos;
						num2 = (short)1181286423;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_42D:
						num2 = (short)2124283925;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_446:
						if ((num -= 1U) == 0U)
						{
							num2 = (short)289013768;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
						IL_470:
						num2 = (short)233570310;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_600:
						num2 = (short)225705988;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_67B:
						this.d[(int)num21] = (this.d[(int)num18] = 0U);
						num2 = (short)2000683033;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_6B0:
						num19 = num4 << 1;
						num17 = this._bufferOffset + num9;
						num7 = global::System.Math.Min(val2, val);
						num2 = (short)1880621091;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_741:
						num9 = this.e[(int)(this.s + num16)];
						this.e[(int)(this.s + num16)] = this._pos;
						num21 = (this.a << 1) + 1U;
						num18 = this.a << 1;
						val = (val2 = this.q);
						num20 = this.f;
						num2 = (short)1041236004;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_7AF:
						this.MovePos();
						num2 = (short)2070020113;
						num3 = (int)((global::System.IntPtr)num2);
					}
					break;
				}
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007EB0 File Offset: 0x000060B0
		private void a(uint[] A_0, uint A_1, uint A_2)
		{
			int num;
			short num3;
			uint num4;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					uint num2;
					switch (num)
					{
					case 0:
						num2 = 0U;
						num3 = (short)953024514;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 1:
					{
						num3 = (short)746717185;
						if (num3 != 0)
						{
						}
						if (num4 < A_1)
						{
							num2 = A_0[(int)num4];
							num3 = (short)1694629891;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1733685076;
						short num5 = num3;
						num3 = (short)1905389396;
						switch ((num5 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32;
						default:
							num3 = (short)1410203648;
							if (num3 != 0)
							{
							}
							num3 = (short)307363846;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						break;
					}
					case 2:
						goto IL_4B;
					case 3:
						if (num2 <= A_2)
						{
							num3 = (short)113180672;
							short num6 = num3;
							num3 = (short)1900150784;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num2 -= A_2;
						num3 = (short)1947795463;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 4:
						goto IL_EF;
					case 5:
						goto IL_EF;
					case 6:
						return;
					case 7:
						goto IL_4B;
					}
					goto IL_30;
					IL_4B:
					A_0[(int)num4] = num2;
					num4 += 1U;
					num3 = (short)1329790980;
					num = (int)((global::System.IntPtr)num3);
					continue;
					IL_EF:
					num3 = (short)1854472193;
					num = (int)((global::System.IntPtr)num3);
				}
				return;
			}
			IL_30:
			num4 = 0U;
			IL_32:
			num3 = (short)738459653;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00008074 File Offset: 0x00006274
		private void a()
		{
			short num = (short)1349367017;
			short num2 = num;
			num = (short)286897385;
			switch (num2 == num)
			{
			}
			num = (short)1110900737;
			if (num != 0)
			{
			}
			num = (short)999096320;
			if (num != 0)
			{
			}
			num = (short)2045444096;
			short num3 = num;
			uint num4 = this._pos - this.b;
			this.a(this.d, this.b * 2U, num4);
			this.a(this.e, this.h, num4);
			base.ReduceOffsets((int)num4);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000815C File Offset: 0x0000635C
		public void SetCutValue(uint cutValue)
		{
			short num = (short)255603539;
			short num2 = num;
			num = (short)25506643;
			switch (num2 == num)
			{
			}
			num = (short)1736769537;
			if (num != 0)
			{
			}
			num = (short)2011234304;
			if (num != 0)
			{
			}
			num = (short)165347328;
			short num3 = num;
			this.f = cutValue;
		}

		// Token: 0x04000030 RID: 48
		private uint a;

		// Token: 0x04000031 RID: 49
		private uint b;

		// Token: 0x04000032 RID: 50
		private uint c;

		// Token: 0x04000033 RID: 51
		private uint[] d;

		// Token: 0x04000034 RID: 52
		private uint[] e;

		// Token: 0x04000035 RID: 53
		private uint f = 255U;

		// Token: 0x04000036 RID: 54
		private uint g;

		// Token: 0x04000037 RID: 55
		private uint h;

		// Token: 0x04000038 RID: 56
		private bool i = true;

		// Token: 0x04000039 RID: 57
		private const uint j = 1024U;

		// Token: 0x0400003A RID: 58
		private const uint k = 65536U;

		// Token: 0x0400003B RID: 59
		private const uint l = 65536U;

		// Token: 0x0400003C RID: 60
		private const uint m = 1U;

		// Token: 0x0400003D RID: 61
		private const uint n = 1024U;

		// Token: 0x0400003E RID: 62
		private const uint o = 0U;

		// Token: 0x0400003F RID: 63
		private const uint p = 2147483647U;

		// Token: 0x04000040 RID: 64
		private uint q;

		// Token: 0x04000041 RID: 65
		private uint r = 4U;

		// Token: 0x04000042 RID: 66
		private uint s = 66560U;
	}
}
