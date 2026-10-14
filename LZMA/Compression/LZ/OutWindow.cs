using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000016 RID: 22
	public class OutWindow
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00009220 File Offset: 0x00007420
		public void Create(uint windowSize)
		{
			short num;
			for (;;)
			{
				num = (short)1815085056;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						goto IL_9C;
					case 2:
						num = (short)178913281;
						if (num != 0)
						{
						}
						this.a = new byte[windowSize];
						num = (short)1028390913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					if (this.c == windowSize)
					{
						break;
					}
					num = (short)1203896322;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C6:
				num = (short)1402140786;
				short num3 = num;
				num = (short)2111240306;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_FB;
				}
				IL_9C:
				num = (short)58130432;
				short num4 = num;
				goto IL_C6;
			}
			IL_FB:
			num = (short)772079616;
			if (num != 0)
			{
			}
			this.c = windowSize;
			this.b = 0U;
			this.d = 0U;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00009354 File Offset: 0x00007554
		public void Init(global::System.IO.Stream stream, bool solid)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)1927610368;
					short num2 = num;
					switch (num3)
					{
					case 0:
					{
						num = (short)1877449622;
						short num4 = num;
						num = (short)1347132310;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1819475968;
							if (num != 0)
							{
							}
							if (!solid)
							{
								num = (short)1800208386;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 1:
						return;
					case 2:
						num = (short)1780613121;
						if (num != 0)
						{
						}
						this.d = 0U;
						this.b = 0U;
						this.TrainSize = 0U;
						num = (short)238551041;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_46:
				this.ReleaseStream();
				this.e = stream;
				num = (short)601882624;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00009488 File Offset: 0x00007688
		public bool Train(global::System.IO.Stream stream)
		{
			short num = (short)1684602880;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				long length;
				for (;;)
				{
					IL_27:
					int num4;
					uint num5;
					uint num6;
					uint num7;
					switch (num2)
					{
					case 0:
					{
						num = (short)326541871;
						short num3 = num;
						num = (short)2041094703;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D3;
						default:
							num = (short)1540620288;
							if (num != 0)
							{
							}
							num = (short)693698569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (num4 == 0)
						{
							num = (short)984809480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 -= (uint)num4;
						this.b += (uint)num4;
						this.d += (uint)num4;
						num = (short)2115960844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (length >= (long)((ulong)this.c))
						{
							num = (short)1571684352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1161494535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num5 < num6)
						{
							num = (short)1831010314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_168;
					case 4:
						this.d = (this.b = 0U);
						num = (short)1126432781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_279;
					case 6:
						return true;
					case 7:
						goto IL_1D3;
					case 8:
						return false;
					case 9:
						num7 = this.c;
						goto IL_2FA;
					case 10:
						num6 = num5;
						num = (short)1015545867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_168;
					case 12:
					{
						num = (short)1605369856;
						short num8 = num;
						num = (short)1244266497;
						if (num != 0)
						{
						}
						if (this.b == this.c)
						{
							num = (short)744226820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_279;
					}
					case 13:
						goto IL_279;
					case 14:
						if (num5 <= 0U)
						{
							num = (short)1682440198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = this.c - this.b;
						num = (short)365690883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A;
					IL_168:
					num4 = stream.Read(this.a, (int)this.b, (int)num6);
					num = (short)884736001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_279:
					num = (short)1713897486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FA:
					num5 = num7;
					this.TrainSize = num5;
					stream.Position = length - (long)((ulong)num5);
					this.d = (this.b = 0U);
					num = (short)894238725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D3:
					num7 = (uint)length;
					goto IL_2FA;
				}
				return false;
				IL_6A:
				length = stream.Length;
				num = (short)1307574274;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000097F4 File Offset: 0x000079F4
		public void ReleaseStream()
		{
			short num = (short)764553353;
			short num2 = num;
			num = (short)751773833;
			switch (num2 == num)
			{
			}
			num = (short)854589441;
			if (num != 0)
			{
			}
			num = (short)2045575168;
			if (num != 0)
			{
			}
			num = (short)1166409728;
			short num3 = num;
			this.Flush();
			this.e = null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000098A8 File Offset: 0x00007AA8
		public void Flush()
		{
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			uint num4;
			for (;;)
			{
				IL_0A:
				num = (short)1238630400;
				short num2 = num;
				switch (num3)
				{
				case 0:
					this.b = 0U;
					num = (short)459669507;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
				{
					if (num4 == 0U)
					{
						num = (short)534380545;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.e.Write(this.a, (int)this.d, (int)num4);
					num = (short)596028757;
					short num5 = num;
					num = (short)217230677;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AB;
					default:
						num = (short)307560448;
						if (num != 0)
						{
						}
						num = (short)74448900;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_AB;
				case 4:
					if (this.b >= this.c)
					{
						num = (short)374538241;
						if (num != 0)
						{
						}
						num = (short)1577582592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17C;
				}
				goto IL_4E;
			}
			return;
			IL_AB:
			IL_17C:
			this.d = this.b;
			return;
			IL_4E:
			num4 = this.b - this.d;
			num = (short)768278530;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009A40 File Offset: 0x00007C40
		public void CopyBlock(uint distance, uint len)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
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
					if (num2 >= this.c)
					{
						num3 = (short)964427777;
						if (num3 != 0)
						{
						}
						num3 = (short)988086279;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_17B;
				case 1:
					goto IL_17B;
				case 2:
					this.Flush();
					num3 = (short)1739522057;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					goto IL_286;
				case 4:
					if (num2 >= this.c)
					{
						num3 = (short)787611658;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D2;
				case 5:
					if (this.b >= this.c)
					{
						num3 = (short)895877122;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1D8;
				case 6:
					return;
				case 7:
					num2 += this.c;
					num3 = (short)956497921;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
				{
					num3 = (short)1318120537;
					short num4 = num3;
					num3 = (short)1312418905;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_286;
					default:
						num3 = (short)1339752448;
						if (num3 != 0)
						{
						}
						goto IL_17B;
					}
					break;
				}
				case 9:
					goto IL_1D8;
				case 10:
				{
					num3 = (short)1092943872;
					short num5 = num3;
					num2 = 0U;
					num3 = (short)903741443;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 11:
					if (len <= 0U)
					{
						num3 = (short)1358036998;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1720909828;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_40;
				IL_D2:
				byte[] array = this.a;
				uint num6 = this.b;
				this.b = num6 + 1U;
				array[(int)num6] = this.a[(int)num2++];
				num3 = (short)1914044421;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_286:
				goto IL_D2;
				IL_17B:
				num3 = (short)2054815755;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1D8:
				len -= 1U;
				num3 = (short)1998782472;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_40:
			num2 = this.b - distance - 1U;
			num3 = (short)104136704;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00009CD8 File Offset: 0x00007ED8
		public void PutByte(byte b)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)984285184;
					short num2 = num;
					switch (num3)
					{
					case 0:
					{
						num = (short)1201451462;
						short num4 = num;
						num = (short)1494331846;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1368719361;
							if (num != 0)
							{
							}
							num = (short)207880192;
							if (num != 0)
							{
							}
							if (this.b >= this.c)
							{
								num = (short)780861442;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 1:
						return;
					case 2:
						this.Flush();
						num = (short)1799028737;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_46:
				byte[] array = this.a;
				uint num5 = this.b;
				this.b = num5 + 1U;
				array[(int)num5] = b;
				num = (short)577372160;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00009E10 File Offset: 0x00008010
		public byte GetByte(uint distance)
		{
			short num;
			uint num5;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)450035712;
					short num2 = num;
					switch (num3)
					{
					case 0:
					{
						num = (short)1885762692;
						short num4 = num;
						num = (short)1219523716;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1352007680;
							if (num != 0)
							{
							}
							if (num5 >= this.c)
							{
								num = (short)25034754;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_119;
						}
						break;
					}
					case 1:
						goto IL_F0;
					case 2:
						num5 += this.c;
						num = (short)1274806273;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_45:
				num5 = this.b - distance - 1U;
				num = (short)271056896;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_F0:
			num = (short)27459585;
			if (num != 0)
			{
			}
			IL_119:
			return this.a[(int)num5];
		}

		// Token: 0x0400004E RID: 78
		private byte[] a;

		// Token: 0x0400004F RID: 79
		private uint b;

		// Token: 0x04000050 RID: 80
		private uint c;

		// Token: 0x04000051 RID: 81
		private uint d;

		// Token: 0x04000052 RID: 82
		private global::System.IO.Stream e;

		// Token: 0x04000053 RID: 83
		public uint TrainSize;
	}
}
