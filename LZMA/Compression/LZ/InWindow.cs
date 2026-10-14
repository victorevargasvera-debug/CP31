using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000015 RID: 21
	public class InWindow
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00008244 File Offset: 0x00006444
		public void MoveBlock()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			uint num4;
			for (;;)
			{
				IL_0A:
				uint num5;
				uint num6;
				switch (num)
				{
				case 0:
					goto IL_11D;
				case 1:
					goto IL_166;
				case 2:
					goto IL_166;
				case 3:
					goto IL_1C5;
				case 4:
				{
					num2 = (short)1551499264;
					short num3 = num2;
					if (num4 > 0U)
					{
						num2 = (short)524615686;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11D;
				}
				case 5:
				{
					num2 = (short)1055850497;
					if (num2 != 0)
					{
					}
					if (num5 >= num6)
					{
						num2 = (short)188612611;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)877675040;
					short num7 = num2;
					num2 = (short)1992639008;
					switch ((num7 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)944635904;
						if (num2 != 0)
						{
						}
						this._bufferBase[(int)num5] = this._bufferBase[(int)(num4 + num5)];
						num5 += 1U;
						break;
					}
					num2 = (short)2061828098;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					num4 -= 1U;
					num2 = (short)1959067648;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_11D:
				num6 = this._bufferOffset + this._streamPos - num4;
				num5 = 0U;
				num2 = (short)555548673;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_166:
				num2 = (short)1396506629;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C5:
			this._bufferOffset -= num4;
			return;
			IL_2C:
			num4 = this._bufferOffset + this._pos - this.e;
			num2 = (short)1456603140;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008428 File Offset: 0x00006628
		public virtual void ReadBlock()
		{
			short num = (short)1829240841;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
				{
					if (num3 == 0)
					{
						goto IL_188;
					}
					int num4 = this.a.Read(this._bufferBase, (int)(this._bufferOffset + this._streamPos), num3);
					num = (short)2036465674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					this.b = this._streamPos;
					num = (short)663814145;
					if (num != 0)
					{
					}
					num = (short)2018246656;
					short num5 = num;
					num = (short)1025179659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					this.b = this.d - this._bufferOffset;
					num = (short)1973616645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					this.b = this._streamPos - this.f;
					num = (short)1144717320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_200;
				case 6:
					return;
				case 7:
					if (this._streamPos >= this._pos + this.f)
					{
						num = (short)1066074116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_153;
				case 8:
					goto IL_153;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 10:
				{
					int num4;
					if (num4 == 0)
					{
						num = (short)1181810689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this._streamPos += (uint)num4;
					num = (short)1455292423;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					if (this._bufferOffset + this.b > this.d)
					{
						num = (short)774701058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_200;
				}
				IL_56:
				if (this.c)
				{
					num = (short)1284571139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_153:
				num3 = (int)(0U - this._bufferOffset + this._blockSize - this._streamPos);
				num = (short)421986304;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_188:
				num = (short)1391788038;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_200:
				num = (short)1734821483;
				short num6 = num;
				num = (short)1534084715;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_188;
				default:
					goto IL_235;
				}
			}
			return;
			IL_235:
			num = (short)30474240;
			if (num != 0)
			{
			}
			this.c = true;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00008710 File Offset: 0x00006910
		private void a()
		{
			short num = (short)436535992;
			short num2 = num;
			num = (short)1752302264;
			switch (num2 == num)
			{
			}
			num = (short)1901330433;
			if (num != 0)
			{
			}
			num = (short)673251328;
			if (num != 0)
			{
			}
			num = (short)427622400;
			short num3 = num;
			this._bufferBase = null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000087C4 File Offset: 0x000069C4
		public void Create(uint keepSizeBefore, uint keepSizeAfter, uint keepSizeReserv)
		{
			switch (0)
			{
			case 0:
				goto IL_6E;
			}
			short num;
			int num3;
			uint num4;
			for (;;)
			{
				IL_0A:
				num = (short)1768713350;
				short num2 = num;
				num = (short)941714566;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1849229312;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_E5;
					case 1:
						goto IL_11A;
					case 2:
						if (this._bufferBase != null)
						{
							num = (short)1594687492;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 3:
						if (this._blockSize != num4)
						{
							num = (short)1715208192;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					case 4:
						goto IL_B9;
					}
					goto IL_6E;
					IL_E5:
					this.a();
					this._blockSize = num4;
					this._bufferBase = new byte[this._blockSize];
					num = (short)1105985537;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B9:
				num = (short)1376911360;
				short num5 = num;
				num = (short)13238275;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_11A:
			num = (short)1855717377;
			if (num != 0)
			{
			}
			IL_184:
			this.d = this._blockSize - keepSizeAfter;
			return;
			IL_6E:
			this.e = keepSizeBefore;
			this.f = keepSizeAfter;
			num4 = keepSizeBefore + keepSizeAfter + keepSizeReserv;
			num = (short)393543682;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00008964 File Offset: 0x00006B64
		public void SetStream(global::System.IO.Stream stream)
		{
			short num = (short)1663330890;
			short num2 = num;
			num = (short)1133341258;
			switch (num2 == num)
			{
			}
			num = (short)1042481152;
			if (num != 0)
			{
			}
			num = (short)1345060865;
			if (num != 0)
			{
			}
			num = (short)80084992;
			short num3 = num;
			this.a = stream;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00008A14 File Offset: 0x00006C14
		public void ReleaseStream()
		{
			short num = (short)343684650;
			short num2 = num;
			num = (short)131872298;
			switch (num2 == num)
			{
			}
			num = (short)1740111873;
			if (num != 0)
			{
			}
			num = (short)226492416;
			if (num != 0)
			{
			}
			num = (short)171573248;
			short num3 = num;
			this.a = null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00008AC8 File Offset: 0x00006CC8
		public void Init()
		{
			short num = (short)1775932686;
			short num2 = num;
			num = (short)89298190;
			switch (num2 == num)
			{
			}
			num = (short)1329070081;
			if (num != 0)
			{
			}
			num = (short)922091520;
			if (num != 0)
			{
			}
			num = (short)1664745472;
			short num3 = num;
			this._bufferOffset = 0U;
			this._pos = 0U;
			this._streamPos = 0U;
			this.c = false;
			this.ReadBlock();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008B94 File Offset: 0x00006D94
		public void MovePos()
		{
			switch (0)
			{
			case 0:
				goto IL_74;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)1547573417;
				short num2 = num;
				num = (short)741021865;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)960167936;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)1332609024;
						short num4 = num;
						num = (short)882704386;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						this.MoveBlock();
						num = (short)1260716037;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this._bufferOffset + this._pos > this.d)
						{
							num = (short)2092040193;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4;
					case 3:
						if (this._pos > this.b)
						{
							goto IL_AA;
						}
						goto IL_17A;
					case 4:
						goto IL_E1;
					case 5:
						goto IL_C4;
					}
					goto IL_74;
					IL_C4:
					this.ReadBlock();
					num = (short)1265893380;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AA:
				num = (short)591331328;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_E1:
			IL_17A:
			num = (short)549388289;
			if (num != 0)
			{
			}
			return;
			IL_74:
			this._pos += 1U;
			num = (short)1330446339;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00008D44 File Offset: 0x00006F44
		public byte GetIndexByte(int index)
		{
			short num = (short)1248488921;
			short num2 = num;
			num = (short)1632136665;
			switch (num2 == num)
			{
			}
			num = (short)1350762497;
			if (num != 0)
			{
			}
			num = (short)1572601856;
			if (num != 0)
			{
			}
			num = (short)386662400;
			short num3 = num;
			return this._bufferBase[(int)(checked((global::System.IntPtr)(unchecked((ulong)(this._bufferOffset + this._pos) + (ulong)((long)index)))))];
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00008E08 File Offset: 0x00007008
		public uint GetMatchLen(int index, uint distance, uint limit)
		{
			short num = (short)359661569;
			int num2 = (int)((global::System.IntPtr)num);
			uint num4;
			for (;;)
			{
				uint num3;
				switch (num2)
				{
				case 0:
					goto IL_EB;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 2:
					if (this._bufferBase[(int)(num3 + num4)] != this._bufferBase[(int)(num3 + num4 - distance)])
					{
						num = (short)1333526534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4 += 1U;
					goto IL_242;
				case 3:
					num = (short)487915522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)118685697;
					if (num != 0)
					{
					}
					if (num4 < limit)
					{
						num = (short)1933508611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return num4;
				case 5:
					goto IL_14A;
				case 6:
					return num4;
				case 7:
					goto IL_EB;
				case 8:
					num = (short)783351817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if ((ulong)this._pos + (ulong)((long)index) + (ulong)limit > (ulong)this._streamPos)
					{
						num = (short)518651914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
				case 10:
					limit = this._streamPos - (uint)((ulong)this._pos + (ulong)((long)index));
					num = (short)1635385349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_50:
				num = (short)1712067228;
				short num5 = num;
				num = (short)1350505116;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_242:
					num = (short)2042888199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					break;
				default:
				{
					num = (short)807206912;
					short num6 = num;
					break;
				}
				}
				num = (short)640942080;
				if (num != 0)
				{
				}
				if (this.c)
				{
					num = (short)1194000392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_14A;
				IL_EB:
				num = (short)1746141188;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				distance += 1U;
				num3 = this._bufferOffset + this._pos + (uint)index;
				num4 = 0U;
				num = (short)1359347712;
				num2 = (int)((global::System.IntPtr)num);
			}
			return num4;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00009078 File Offset: 0x00007278
		public uint GetNumAvailableBytes()
		{
			short num = (short)1358691855;
			short num2 = num;
			num = (short)824835599;
			switch (num2 == num)
			{
			}
			num = (short)199491585;
			if (num != 0)
			{
			}
			num = (short)1630797824;
			if (num != 0)
			{
			}
			num = (short)326434816;
			short num3 = num;
			return this._streamPos - this._pos;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000912C File Offset: 0x0000732C
		public void ReduceOffsets(int subValue)
		{
			short num = (short)2120784491;
			short num2 = num;
			num = (short)1969199723;
			switch (num2 == num)
			{
			}
			num = (short)384827393;
			if (num != 0)
			{
			}
			num = (short)51642368;
			if (num != 0)
			{
			}
			num = (short)878968832;
			short num3 = num;
			this._bufferOffset += (uint)subValue;
			this.b -= (uint)subValue;
			this._pos -= (uint)subValue;
			this._streamPos -= (uint)subValue;
		}

		// Token: 0x04000043 RID: 67
		public byte[] _bufferBase;

		// Token: 0x04000044 RID: 68
		private global::System.IO.Stream a;

		// Token: 0x04000045 RID: 69
		private uint b;

		// Token: 0x04000046 RID: 70
		private bool c;

		// Token: 0x04000047 RID: 71
		private uint d;

		// Token: 0x04000048 RID: 72
		public uint _bufferOffset;

		// Token: 0x04000049 RID: 73
		public uint _blockSize;

		// Token: 0x0400004A RID: 74
		public uint _pos;

		// Token: 0x0400004B RID: 75
		private uint e;

		// Token: 0x0400004C RID: 76
		private uint f;

		// Token: 0x0400004D RID: 77
		public uint _streamPos;
	}
}
