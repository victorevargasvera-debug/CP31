using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksum;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000078 RID: 120
	public class BZip2InputStream : global::System.IO.Stream
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x00014958 File Offset: 0x00012B58
		public BZip2InputStream(global::System.IO.Stream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			for (int i = 0; i < 6; i++)
			{
				this.limit[i] = new int[258];
				this.baseArray[i] = new int[258];
				this.perm[i] = new int[258];
			}
			this.baseStream = stream;
			this.bsLive = 0;
			this.bsBuff = 0;
			this.Initialize();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00014A92 File Offset: 0x00012C92
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00014A9A File Offset: 0x00012C9A
		public bool IsStreamOwner { get; set; } = true;

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00014AA3 File Offset: 0x00012CA3
		public override bool CanRead
		{
			get
			{
				return this.baseStream.CanRead;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00014AB0 File Offset: 0x00012CB0
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00014AB3 File Offset: 0x00012CB3
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00014AB6 File Offset: 0x00012CB6
		public override long Length
		{
			get
			{
				return this.baseStream.Length;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00014AC3 File Offset: 0x00012CC3
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00014AD0 File Offset: 0x00012CD0
		public override long Position
		{
			get
			{
				return this.baseStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException("BZip2InputStream position cannot be set");
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00014ADC File Offset: 0x00012CDC
		public override void Flush()
		{
			this.baseStream.Flush();
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00014AE9 File Offset: 0x00012CE9
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("BZip2InputStream Seek not supported");
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00014AF5 File Offset: 0x00012CF5
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException("BZip2InputStream SetLength not supported");
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00014B01 File Offset: 0x00012D01
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("BZip2InputStream Write not supported");
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00014B0D File Offset: 0x00012D0D
		public override void WriteByte(byte value)
		{
			throw new global::System.NotSupportedException("BZip2InputStream WriteByte not supported");
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00014B1C File Offset: 0x00012D1C
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			for (int i = 0; i < count; i++)
			{
				int num = this.ReadByte();
				if (num == -1)
				{
					return i;
				}
				buffer[offset + i] = (byte)num;
			}
			return count;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00014B58 File Offset: 0x00012D58
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.IsStreamOwner)
			{
				this.baseStream.Dispose();
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00014B70 File Offset: 0x00012D70
		public override int ReadByte()
		{
			if (this.streamEnd)
			{
				return -1;
			}
			int result = this.currentChar;
			switch (this.currentState)
			{
			case 3:
				this.SetupRandPartB();
				break;
			case 4:
				this.SetupRandPartC();
				break;
			case 6:
				this.SetupNoRandPartB();
				break;
			case 7:
				this.SetupNoRandPartC();
				break;
			}
			return result;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00014BDC File Offset: 0x00012DDC
		private void MakeMaps()
		{
			this.nInUse = 0;
			for (int i = 0; i < 256; i++)
			{
				if (this.inUse[i])
				{
					this.seqToUnseq[this.nInUse] = (byte)i;
					this.unseqToSeq[i] = (byte)this.nInUse;
					this.nInUse++;
				}
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00014C38 File Offset: 0x00012E38
		private void Initialize()
		{
			int num = (int)this.BsGetUChar();
			char c = this.BsGetUChar();
			char c2 = this.BsGetUChar();
			char c3 = this.BsGetUChar();
			if (num != 66 || c != 'Z' || c2 != 'h' || c3 < '1' || c3 > '9')
			{
				this.streamEnd = true;
				return;
			}
			this.SetDecompressStructureSizes((int)(c3 - '0'));
			this.computedCombinedCRC = 0U;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00014C94 File Offset: 0x00012E94
		private void InitBlock()
		{
			char c = this.BsGetUChar();
			char c2 = this.BsGetUChar();
			char c3 = this.BsGetUChar();
			char c4 = this.BsGetUChar();
			char c5 = this.BsGetUChar();
			char c6 = this.BsGetUChar();
			if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
			{
				this.Complete();
				return;
			}
			if (c != '1' || c2 != 'A' || c3 != 'Y' || c4 != '&' || c5 != 'S' || c6 != 'Y')
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.BadBlockHeader();
				this.streamEnd = true;
				return;
			}
			this.storedBlockCRC = this.BsGetInt32();
			this.blockRandomised = (this.BsR(1) == 1);
			this.GetAndMoveToFrontDecode();
			this.mCrc.Reset();
			this.currentState = 1;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00014D58 File Offset: 0x00012F58
		private void EndBlock()
		{
			this.computedBlockCRC = (int)this.mCrc.Value;
			if (this.storedBlockCRC != this.computedBlockCRC)
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.CrcError();
			}
			this.computedCombinedCRC = ((this.computedCombinedCRC << 1 & uint.MaxValue) | this.computedCombinedCRC >> 31);
			this.computedCombinedCRC ^= (uint)this.computedBlockCRC;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00014DB7 File Offset: 0x00012FB7
		private void Complete()
		{
			this.storedCombinedCRC = this.BsGetInt32();
			if (this.storedCombinedCRC != (int)this.computedCombinedCRC)
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.CrcError();
			}
			this.streamEnd = true;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00014DE0 File Offset: 0x00012FE0
		private void FillBuffer()
		{
			int num = 0;
			try
			{
				num = this.baseStream.ReadByte();
			}
			catch (global::System.Exception)
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.CompressedStreamEOF();
			}
			if (num == -1)
			{
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.CompressedStreamEOF();
			}
			this.bsBuff = (this.bsBuff << 8 | (num & 255));
			this.bsLive += 8;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00014E44 File Offset: 0x00013044
		private int BsR(int n)
		{
			while (this.bsLive < n)
			{
				this.FillBuffer();
			}
			int result = this.bsBuff >> this.bsLive - n & (1 << n) - 1;
			this.bsLive -= n;
			return result;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00014E80 File Offset: 0x00013080
		private char BsGetUChar()
		{
			return (char)this.BsR(8);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00014E8A File Offset: 0x0001308A
		private int BsGetIntVS(int numBits)
		{
			return this.BsR(numBits);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00014E93 File Offset: 0x00013093
		private int BsGetInt32()
		{
			return ((this.BsR(8) << 8 | this.BsR(8)) << 8 | this.BsR(8)) << 8 | this.BsR(8);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00014EBC File Offset: 0x000130BC
		private void RecvDecodingTables()
		{
			char[][] array = new char[6][];
			for (int i = 0; i < 6; i++)
			{
				array[i] = new char[258];
			}
			bool[] array2 = new bool[16];
			for (int j = 0; j < 16; j++)
			{
				array2[j] = (this.BsR(1) == 1);
			}
			for (int k = 0; k < 16; k++)
			{
				if (array2[k])
				{
					for (int l = 0; l < 16; l++)
					{
						this.inUse[k * 16 + l] = (this.BsR(1) == 1);
					}
				}
				else
				{
					for (int m = 0; m < 16; m++)
					{
						this.inUse[k * 16 + m] = false;
					}
				}
			}
			this.MakeMaps();
			int num = this.nInUse + 2;
			int num2 = this.BsR(3);
			int num3 = this.BsR(15);
			for (int n = 0; n < num3; n++)
			{
				int num4 = 0;
				while (this.BsR(1) == 1)
				{
					num4++;
				}
				this.selectorMtf[n] = (byte)num4;
			}
			byte[] array3 = new byte[6];
			for (int num5 = 0; num5 < num2; num5++)
			{
				array3[num5] = (byte)num5;
			}
			for (int num6 = 0; num6 < num3; num6++)
			{
				int num7 = (int)this.selectorMtf[num6];
				byte b = array3[num7];
				while (num7 > 0)
				{
					array3[num7] = array3[num7 - 1];
					num7--;
				}
				array3[0] = b;
				this.selector[num6] = b;
			}
			for (int num8 = 0; num8 < num2; num8++)
			{
				int num9 = this.BsR(5);
				for (int num10 = 0; num10 < num; num10++)
				{
					while (this.BsR(1) == 1)
					{
						if (this.BsR(1) == 0)
						{
							num9++;
						}
						else
						{
							num9--;
						}
					}
					array[num8][num10] = (char)num9;
				}
			}
			for (int num11 = 0; num11 < num2; num11++)
			{
				int num12 = 32;
				int num13 = 0;
				for (int num14 = 0; num14 < num; num14++)
				{
					num13 = global::System.Math.Max(num13, (int)array[num11][num14]);
					num12 = global::System.Math.Min(num12, (int)array[num11][num14]);
				}
				global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.HbCreateDecodeTables(this.limit[num11], this.baseArray[num11], this.perm[num11], array[num11], num12, num13, num);
				this.minLens[num11] = num12;
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00015108 File Offset: 0x00013308
		private void GetAndMoveToFrontDecode()
		{
			byte[] array = new byte[256];
			int num = 100000 * this.blockSize100k;
			this.origPtr = this.BsGetIntVS(24);
			this.RecvDecodingTables();
			int num2 = this.nInUse + 1;
			int num3 = -1;
			int num4 = 0;
			for (int i = 0; i <= 255; i++)
			{
				this.unzftab[i] = 0;
			}
			for (int j = 0; j <= 255; j++)
			{
				array[j] = (byte)j;
			}
			this.last = -1;
			if (num4 == 0)
			{
				num3++;
				num4 = 50;
			}
			num4--;
			int num5 = (int)this.selector[num3];
			int num6 = this.minLens[num5];
			int k;
			int num7;
			for (k = this.BsR(num6); k > this.limit[num5][num6]; k = (k << 1 | num7))
			{
				if (num6 > 20)
				{
					throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("Bzip data error");
				}
				num6++;
				while (this.bsLive < 1)
				{
					this.FillBuffer();
				}
				num7 = (this.bsBuff >> this.bsLive - 1 & 1);
				this.bsLive--;
			}
			if (k - this.baseArray[num5][num6] < 0 || k - this.baseArray[num5][num6] >= 258)
			{
				throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("Bzip data error");
			}
			int num8 = this.perm[num5][k - this.baseArray[num5][num6]];
			while (num8 != num2)
			{
				if (num8 == 0 || num8 == 1)
				{
					int l = -1;
					int num9 = 1;
					do
					{
						if (num8 == 0)
						{
							l += num9;
						}
						else if (num8 == 1)
						{
							l += 2 * num9;
						}
						num9 <<= 1;
						if (num4 == 0)
						{
							num3++;
							num4 = 50;
						}
						num4--;
						num5 = (int)this.selector[num3];
						num6 = this.minLens[num5];
						for (k = this.BsR(num6); k > this.limit[num5][num6]; k = (k << 1 | num7))
						{
							num6++;
							while (this.bsLive < 1)
							{
								this.FillBuffer();
							}
							num7 = (this.bsBuff >> this.bsLive - 1 & 1);
							this.bsLive--;
						}
						num8 = this.perm[num5][k - this.baseArray[num5][num6]];
					}
					while (num8 == 0 || num8 == 1);
					l++;
					byte b = this.seqToUnseq[(int)array[0]];
					this.unzftab[(int)b] += l;
					while (l > 0)
					{
						this.last++;
						this.ll8[this.last] = b;
						l--;
					}
					if (this.last >= num)
					{
						global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.BlockOverrun();
					}
				}
				else
				{
					this.last++;
					if (this.last >= num)
					{
						global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream.BlockOverrun();
					}
					byte b2 = array[num8 - 1];
					this.unzftab[(int)this.seqToUnseq[(int)b2]]++;
					this.ll8[this.last] = this.seqToUnseq[(int)b2];
					int m = num8 - 1;
					while (m > 0)
					{
						array[m] = array[--m];
					}
					array[0] = b2;
					if (num4 == 0)
					{
						num3++;
						num4 = 50;
					}
					num4--;
					num5 = (int)this.selector[num3];
					num6 = this.minLens[num5];
					for (k = this.BsR(num6); k > this.limit[num5][num6]; k = (k << 1 | num7))
					{
						num6++;
						while (this.bsLive < 1)
						{
							this.FillBuffer();
						}
						num7 = (this.bsBuff >> this.bsLive - 1 & 1);
						this.bsLive--;
					}
					num8 = this.perm[num5][k - this.baseArray[num5][num6]];
				}
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000154E0 File Offset: 0x000136E0
		private void SetupBlock()
		{
			int[] array = new int[257];
			array[0] = 0;
			global::System.Array.Copy(this.unzftab, 0, array, 1, 256);
			for (int i = 1; i <= 256; i++)
			{
				array[i] += array[i - 1];
			}
			for (int j = 0; j <= this.last; j++)
			{
				byte b = this.ll8[j];
				this.tt[array[(int)b]] = j;
				array[(int)b]++;
			}
			this.tPos = this.tt[this.origPtr];
			this.count = 0;
			this.i2 = 0;
			this.ch2 = 256;
			if (this.blockRandomised)
			{
				this.rNToGo = 0;
				this.rTPos = 0;
				this.SetupRandPartA();
				return;
			}
			this.SetupNoRandPartA();
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000155B4 File Offset: 0x000137B4
		private void SetupRandPartA()
		{
			if (this.i2 <= this.last)
			{
				this.chPrev = this.ch2;
				this.ch2 = (int)this.ll8[this.tPos];
				this.tPos = this.tt[this.tPos];
				if (this.rNToGo == 0)
				{
					this.rNToGo = global::ICSharpCode.SharpZipLib.BZip2.BZip2Constants.RandomNumbers[this.rTPos];
					this.rTPos++;
					if (this.rTPos == 512)
					{
						this.rTPos = 0;
					}
				}
				this.rNToGo--;
				this.ch2 ^= ((this.rNToGo == 1) ? 1 : 0);
				this.i2++;
				this.currentChar = this.ch2;
				this.currentState = 3;
				this.mCrc.Update(this.ch2);
				return;
			}
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000156B0 File Offset: 0x000138B0
		private void SetupNoRandPartA()
		{
			if (this.i2 <= this.last)
			{
				this.chPrev = this.ch2;
				this.ch2 = (int)this.ll8[this.tPos];
				this.tPos = this.tt[this.tPos];
				this.i2++;
				this.currentChar = this.ch2;
				this.currentState = 6;
				this.mCrc.Update(this.ch2);
				return;
			}
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00015744 File Offset: 0x00013944
		private void SetupRandPartB()
		{
			if (this.ch2 != this.chPrev)
			{
				this.currentState = 2;
				this.count = 1;
				this.SetupRandPartA();
				return;
			}
			this.count++;
			if (this.count >= 4)
			{
				this.z = this.ll8[this.tPos];
				this.tPos = this.tt[this.tPos];
				if (this.rNToGo == 0)
				{
					this.rNToGo = global::ICSharpCode.SharpZipLib.BZip2.BZip2Constants.RandomNumbers[this.rTPos];
					this.rTPos++;
					if (this.rTPos == 512)
					{
						this.rTPos = 0;
					}
				}
				this.rNToGo--;
				this.z ^= ((this.rNToGo == 1) ? 1 : 0);
				this.j2 = 0;
				this.currentState = 4;
				this.SetupRandPartC();
				return;
			}
			this.currentState = 2;
			this.SetupRandPartA();
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0001583C File Offset: 0x00013A3C
		private void SetupRandPartC()
		{
			if (this.j2 < (int)this.z)
			{
				this.currentChar = this.ch2;
				this.mCrc.Update(this.ch2);
				this.j2++;
				return;
			}
			this.currentState = 2;
			this.i2++;
			this.count = 0;
			this.SetupRandPartA();
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000158A8 File Offset: 0x00013AA8
		private void SetupNoRandPartB()
		{
			if (this.ch2 != this.chPrev)
			{
				this.currentState = 5;
				this.count = 1;
				this.SetupNoRandPartA();
				return;
			}
			this.count++;
			if (this.count >= 4)
			{
				this.z = this.ll8[this.tPos];
				this.tPos = this.tt[this.tPos];
				this.currentState = 7;
				this.j2 = 0;
				this.SetupNoRandPartC();
				return;
			}
			this.currentState = 5;
			this.SetupNoRandPartA();
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00015938 File Offset: 0x00013B38
		private void SetupNoRandPartC()
		{
			if (this.j2 < (int)this.z)
			{
				this.currentChar = this.ch2;
				this.mCrc.Update(this.ch2);
				this.j2++;
				return;
			}
			this.currentState = 5;
			this.i2++;
			this.count = 0;
			this.SetupNoRandPartA();
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000159A4 File Offset: 0x00013BA4
		private void SetDecompressStructureSizes(int newSize100k)
		{
			if (0 > newSize100k || newSize100k > 9 || 0 > this.blockSize100k || this.blockSize100k > 9)
			{
				throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("Invalid block size");
			}
			this.blockSize100k = newSize100k;
			if (newSize100k == 0)
			{
				return;
			}
			int num = 100000 * newSize100k;
			this.ll8 = new byte[num];
			this.tt = new int[num];
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00015A03 File Offset: 0x00013C03
		private static void CompressedStreamEOF()
		{
			throw new global::System.IO.EndOfStreamException("BZip2 input stream end of compressed stream");
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00015A0F File Offset: 0x00013C0F
		private static void BlockOverrun()
		{
			throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("BZip2 input stream block overrun");
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00015A1B File Offset: 0x00013C1B
		private static void BadBlockHeader()
		{
			throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("BZip2 input stream bad block header");
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00015A27 File Offset: 0x00013C27
		private static void CrcError()
		{
			throw new global::ICSharpCode.SharpZipLib.BZip2.BZip2Exception("BZip2 input stream crc error");
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00015A34 File Offset: 0x00013C34
		private static void HbCreateDecodeTables(int[] limit, int[] baseArray, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
			int num = 0;
			for (int i = minLen; i <= maxLen; i++)
			{
				for (int j = 0; j < alphaSize; j++)
				{
					if ((int)length[j] == i)
					{
						perm[num] = j;
						num++;
					}
				}
			}
			for (int k = 0; k < 23; k++)
			{
				baseArray[k] = 0;
			}
			for (int l = 0; l < alphaSize; l++)
			{
				baseArray[(int)(length[l] + '\u0001')]++;
			}
			for (int m = 1; m < 23; m++)
			{
				baseArray[m] += baseArray[m - 1];
			}
			for (int n = 0; n < 23; n++)
			{
				limit[n] = 0;
			}
			int num2 = 0;
			for (int num3 = minLen; num3 <= maxLen; num3++)
			{
				num2 += baseArray[num3 + 1] - baseArray[num3];
				limit[num3] = num2 - 1;
				num2 <<= 1;
			}
			for (int num4 = minLen + 1; num4 <= maxLen; num4++)
			{
				baseArray[num4] = (limit[num4 - 1] + 1 << 1) - baseArray[num4];
			}
		}

		// Token: 0x040002BD RID: 701
		private const int START_BLOCK_STATE = 1;

		// Token: 0x040002BE RID: 702
		private const int RAND_PART_A_STATE = 2;

		// Token: 0x040002BF RID: 703
		private const int RAND_PART_B_STATE = 3;

		// Token: 0x040002C0 RID: 704
		private const int RAND_PART_C_STATE = 4;

		// Token: 0x040002C1 RID: 705
		private const int NO_RAND_PART_A_STATE = 5;

		// Token: 0x040002C2 RID: 706
		private const int NO_RAND_PART_B_STATE = 6;

		// Token: 0x040002C3 RID: 707
		private const int NO_RAND_PART_C_STATE = 7;

		// Token: 0x040002C4 RID: 708
		private int last;

		// Token: 0x040002C5 RID: 709
		private int origPtr;

		// Token: 0x040002C6 RID: 710
		private int blockSize100k;

		// Token: 0x040002C7 RID: 711
		private bool blockRandomised;

		// Token: 0x040002C8 RID: 712
		private int bsBuff;

		// Token: 0x040002C9 RID: 713
		private int bsLive;

		// Token: 0x040002CA RID: 714
		private global::ICSharpCode.SharpZipLib.Checksum.IChecksum mCrc = new global::ICSharpCode.SharpZipLib.Checksum.BZip2Crc();

		// Token: 0x040002CB RID: 715
		private bool[] inUse = new bool[256];

		// Token: 0x040002CC RID: 716
		private int nInUse;

		// Token: 0x040002CD RID: 717
		private byte[] seqToUnseq = new byte[256];

		// Token: 0x040002CE RID: 718
		private byte[] unseqToSeq = new byte[256];

		// Token: 0x040002CF RID: 719
		private byte[] selector = new byte[18002];

		// Token: 0x040002D0 RID: 720
		private byte[] selectorMtf = new byte[18002];

		// Token: 0x040002D1 RID: 721
		private int[] tt;

		// Token: 0x040002D2 RID: 722
		private byte[] ll8;

		// Token: 0x040002D3 RID: 723
		private int[] unzftab = new int[256];

		// Token: 0x040002D4 RID: 724
		private int[][] limit = new int[6][];

		// Token: 0x040002D5 RID: 725
		private int[][] baseArray = new int[6][];

		// Token: 0x040002D6 RID: 726
		private int[][] perm = new int[6][];

		// Token: 0x040002D7 RID: 727
		private int[] minLens = new int[6];

		// Token: 0x040002D8 RID: 728
		private readonly global::System.IO.Stream baseStream;

		// Token: 0x040002D9 RID: 729
		private bool streamEnd;

		// Token: 0x040002DA RID: 730
		private int currentChar = -1;

		// Token: 0x040002DB RID: 731
		private int currentState = 1;

		// Token: 0x040002DC RID: 732
		private int storedBlockCRC;

		// Token: 0x040002DD RID: 733
		private int storedCombinedCRC;

		// Token: 0x040002DE RID: 734
		private int computedBlockCRC;

		// Token: 0x040002DF RID: 735
		private uint computedCombinedCRC;

		// Token: 0x040002E0 RID: 736
		private int count;

		// Token: 0x040002E1 RID: 737
		private int chPrev;

		// Token: 0x040002E2 RID: 738
		private int ch2;

		// Token: 0x040002E3 RID: 739
		private int tPos;

		// Token: 0x040002E4 RID: 740
		private int rNToGo;

		// Token: 0x040002E5 RID: 741
		private int rTPos;

		// Token: 0x040002E6 RID: 742
		private int i2;

		// Token: 0x040002E7 RID: 743
		private int j2;

		// Token: 0x040002E8 RID: 744
		private byte z;
	}
}
