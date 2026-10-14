using System;
using System.IO;
using Ionic.Crc;

namespace Ionic.BZip2
{
	// Token: 0x02000064 RID: 100
	public class BZip2InputStream : global::System.IO.Stream
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x0001E507 File Offset: 0x0001C707
		public BZip2InputStream(global::System.IO.Stream input) : this(input, false)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001E511 File Offset: 0x0001C711
		public BZip2InputStream(global::System.IO.Stream input, bool leaveOpen)
		{
			this.input = input;
			this._leaveOpen = leaveOpen;
			this.init();
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0001E548 File Offset: 0x0001C748
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (offset < 0)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("offset ({0}) must be > 0", offset));
			}
			if (count < 0)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("count ({0}) must be > 0", count));
			}
			if (offset + count > buffer.Length)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("offset({0}) count({1}) bLength({2})", offset, count, buffer.Length));
			}
			if (this.input == null)
			{
				throw new global::System.IO.IOException("the stream is not open");
			}
			int num = offset + count;
			int num2 = offset;
			int num3;
			while (num2 < num && (num3 = this.ReadByte()) >= 0)
			{
				buffer[num2++] = (byte)num3;
			}
			return num2 - offset;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001E5EC File Offset: 0x0001C7EC
		private void MakeMaps()
		{
			bool[] inUse = this.data.inUse;
			byte[] seqToUnseq = this.data.seqToUnseq;
			int num = 0;
			for (int i = 0; i < 256; i++)
			{
				if (inUse[i])
				{
					seqToUnseq[num++] = (byte)i;
				}
			}
			this.nInUse = num;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0001E638 File Offset: 0x0001C838
		public override int ReadByte()
		{
			int result = this.currentChar;
			this.totalBytesRead += 1L;
			switch (this.currentState)
			{
			case global::Ionic.BZip2.BZip2InputStream.CState.EOF:
				return -1;
			case global::Ionic.BZip2.BZip2InputStream.CState.START_BLOCK:
				throw new global::System.IO.IOException("bad state");
			case global::Ionic.BZip2.BZip2InputStream.CState.RAND_PART_A:
				throw new global::System.IO.IOException("bad state");
			case global::Ionic.BZip2.BZip2InputStream.CState.RAND_PART_B:
				this.SetupRandPartB();
				break;
			case global::Ionic.BZip2.BZip2InputStream.CState.RAND_PART_C:
				this.SetupRandPartC();
				break;
			case global::Ionic.BZip2.BZip2InputStream.CState.NO_RAND_PART_A:
				throw new global::System.IO.IOException("bad state");
			case global::Ionic.BZip2.BZip2InputStream.CState.NO_RAND_PART_B:
				this.SetupNoRandPartB();
				break;
			case global::Ionic.BZip2.BZip2InputStream.CState.NO_RAND_PART_C:
				this.SetupNoRandPartC();
				break;
			default:
				throw new global::System.IO.IOException("bad state");
			}
			return result;
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0001E6D9 File Offset: 0x0001C8D9
		public override bool CanRead
		{
			get
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("BZip2Stream");
				}
				return this.input.CanRead;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0001E6F9 File Offset: 0x0001C8F9
		public override bool CanWrite
		{
			get
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("BZip2Stream");
				}
				return this.input.CanWrite;
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001E719 File Offset: 0x0001C919
		public override void Flush()
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("BZip2Stream");
			}
			this.input.Flush();
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0001E739 File Offset: 0x0001C939
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Position
		{
			get
			{
				return this.totalBytesRead;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000060ED File Offset: 0x000042ED
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000060ED File Offset: 0x000042ED
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001E744 File Offset: 0x0001C944
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
				{
					if (disposing && this.input != null)
					{
						this.input.Close();
					}
					this._disposed = true;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001E790 File Offset: 0x0001C990
		private void init()
		{
			if (this.input == null)
			{
				throw new global::System.IO.IOException("No input Stream");
			}
			if (!this.input.CanRead)
			{
				throw new global::System.IO.IOException("Unreadable input Stream");
			}
			this.CheckMagicChar('B', 0);
			this.CheckMagicChar('Z', 1);
			this.CheckMagicChar('h', 2);
			int num = this.input.ReadByte();
			if (num < 49 || num > 57)
			{
				throw new global::System.IO.IOException("Stream is not BZip2 formatted: illegal blocksize " + ((char)num).ToString());
			}
			this.blockSize100k = num - 48;
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001E82C File Offset: 0x0001CA2C
		private void CheckMagicChar(char expected, int position)
		{
			int num = this.input.ReadByte();
			if (num != (int)expected)
			{
				throw new global::System.IO.IOException(string.Format("Not a valid BZip2 stream. byte {0}, expected '{1}', got '{2}'", position, (int)expected, num));
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001E86C File Offset: 0x0001CA6C
		private void InitBlock()
		{
			char c = this.bsGetUByte();
			char c2 = this.bsGetUByte();
			char c3 = this.bsGetUByte();
			char c4 = this.bsGetUByte();
			char c5 = this.bsGetUByte();
			char c6 = this.bsGetUByte();
			if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
			{
				this.complete();
				return;
			}
			if (c != '1' || c2 != 'A' || c3 != 'Y' || c4 != '&' || c5 != 'S' || c6 != 'Y')
			{
				this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.EOF;
				throw new global::System.IO.IOException(string.Format("bad block header at offset 0x{0:X}", this.input.Position));
			}
			this.storedBlockCRC = this.bsGetInt();
			this.blockRandomised = (this.GetBits(1) == 1);
			if (this.data == null)
			{
				this.data = new global::Ionic.BZip2.BZip2InputStream.DecompressionState(this.blockSize100k);
			}
			this.getAndMoveToFrontDecode();
			this.crc.Reset();
			this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.START_BLOCK;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001E964 File Offset: 0x0001CB64
		private void EndBlock()
		{
			this.computedBlockCRC = (uint)this.crc.Crc32Result;
			if (this.storedBlockCRC != this.computedBlockCRC)
			{
				throw new global::System.IO.IOException(string.Format("BZip2 CRC error (expected {0:X8}, computed {1:X8})", this.storedBlockCRC, this.computedBlockCRC));
			}
			this.computedCombinedCRC = (this.computedCombinedCRC << 1 | this.computedCombinedCRC >> 31);
			this.computedCombinedCRC ^= this.computedBlockCRC;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
		private void complete()
		{
			this.storedCombinedCRC = this.bsGetInt();
			this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.EOF;
			this.data = null;
			if (this.storedCombinedCRC != this.computedCombinedCRC)
			{
				throw new global::System.IO.IOException(string.Format("BZip2 CRC error (expected {0:X8}, computed {1:X8})", this.storedCombinedCRC, this.computedCombinedCRC));
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001EA40 File Offset: 0x0001CC40
		public override void Close()
		{
			global::System.IO.Stream stream = this.input;
			if (stream != null)
			{
				try
				{
					if (!this._leaveOpen)
					{
						stream.Close();
					}
				}
				finally
				{
					this.data = null;
					this.input = null;
				}
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001EA88 File Offset: 0x0001CC88
		private int GetBits(int n)
		{
			int num = this.bsLive;
			int num2 = this.bsBuff;
			if (num < n)
			{
				for (;;)
				{
					int num3 = this.input.ReadByte();
					if (num3 < 0)
					{
						break;
					}
					num2 = (num2 << 8 | num3);
					num += 8;
					if (num >= n)
					{
						goto Block_2;
					}
				}
				throw new global::System.IO.IOException("unexpected end of stream");
				Block_2:
				this.bsBuff = num2;
			}
			this.bsLive = num - n;
			return num2 >> num - n & (1 << n) - 1;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001EAF1 File Offset: 0x0001CCF1
		private bool bsGetBit()
		{
			return this.GetBits(1) != 0;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001EAFD File Offset: 0x0001CCFD
		private char bsGetUByte()
		{
			return (char)this.GetBits(8);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001EB07 File Offset: 0x0001CD07
		private uint bsGetInt()
		{
			return (uint)(((this.GetBits(8) << 8 | this.GetBits(8)) << 8 | this.GetBits(8)) << 8 | this.GetBits(8));
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001EB30 File Offset: 0x0001CD30
		private static void hbCreateDecodeTables(int[] limit, int[] bbase, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
			int i = minLen;
			int num = 0;
			while (i <= maxLen)
			{
				for (int j = 0; j < alphaSize; j++)
				{
					if ((int)length[j] == i)
					{
						perm[num++] = j;
					}
				}
				i++;
			}
			int num2 = global::Ionic.BZip2.BZip2.MaxCodeLength;
			while (--num2 > 0)
			{
				bbase[num2] = 0;
				limit[num2] = 0;
			}
			for (int k = 0; k < alphaSize; k++)
			{
				bbase[(int)(length[k] + '\u0001')]++;
			}
			int l = 1;
			int num3 = bbase[0];
			while (l < global::Ionic.BZip2.BZip2.MaxCodeLength)
			{
				num3 += bbase[l];
				bbase[l] = num3;
				l++;
			}
			int m = minLen;
			int num4 = 0;
			int num5 = bbase[m];
			while (m <= maxLen)
			{
				int num6 = bbase[m + 1];
				num4 += num6 - num5;
				num5 = num6;
				limit[m] = num4 - 1;
				num4 <<= 1;
				m++;
			}
			for (int n = minLen + 1; n <= maxLen; n++)
			{
				bbase[n] = (limit[n - 1] + 1 << 1) - bbase[n];
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001EC30 File Offset: 0x0001CE30
		private void recvDecodingTables()
		{
			global::Ionic.BZip2.BZip2InputStream.DecompressionState decompressionState = this.data;
			bool[] inUse = decompressionState.inUse;
			byte[] recvDecodingTables_pos = decompressionState.recvDecodingTables_pos;
			int num = 0;
			for (int i = 0; i < 16; i++)
			{
				if (this.bsGetBit())
				{
					num |= 1 << i;
				}
			}
			int num2 = 256;
			while (--num2 >= 0)
			{
				inUse[num2] = false;
			}
			for (int j = 0; j < 16; j++)
			{
				if ((num & 1 << j) != 0)
				{
					int num3 = j << 4;
					for (int k = 0; k < 16; k++)
					{
						if (this.bsGetBit())
						{
							inUse[num3 + k] = true;
						}
					}
				}
			}
			this.MakeMaps();
			int num4 = this.nInUse + 2;
			int bits = this.GetBits(3);
			int bits2 = this.GetBits(15);
			for (int l = 0; l < bits2; l++)
			{
				int num5 = 0;
				while (this.bsGetBit())
				{
					num5++;
				}
				decompressionState.selectorMtf[l] = (byte)num5;
			}
			int num6 = bits;
			while (--num6 >= 0)
			{
				recvDecodingTables_pos[num6] = (byte)num6;
			}
			for (int m = 0; m < bits2; m++)
			{
				int n = (int)decompressionState.selectorMtf[m];
				byte b = recvDecodingTables_pos[n];
				while (n > 0)
				{
					recvDecodingTables_pos[n] = recvDecodingTables_pos[n - 1];
					n--;
				}
				recvDecodingTables_pos[0] = b;
				decompressionState.selector[m] = b;
			}
			char[][] temp_charArray2d = decompressionState.temp_charArray2d;
			for (int num7 = 0; num7 < bits; num7++)
			{
				int num8 = this.GetBits(5);
				char[] array = temp_charArray2d[num7];
				for (int num9 = 0; num9 < num4; num9++)
				{
					while (this.bsGetBit())
					{
						num8 += (this.bsGetBit() ? -1 : 1);
					}
					array[num9] = (char)num8;
				}
			}
			this.createHuffmanDecodingTables(num4, bits);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001EDEC File Offset: 0x0001CFEC
		private void createHuffmanDecodingTables(int alphaSize, int nGroups)
		{
			global::Ionic.BZip2.BZip2InputStream.DecompressionState decompressionState = this.data;
			char[][] temp_charArray2d = decompressionState.temp_charArray2d;
			for (int i = 0; i < nGroups; i++)
			{
				int num = 32;
				int num2 = 0;
				char[] array = temp_charArray2d[i];
				int num3 = alphaSize;
				while (--num3 >= 0)
				{
					char c = array[num3];
					if ((int)c > num2)
					{
						num2 = (int)c;
					}
					if ((int)c < num)
					{
						num = (int)c;
					}
				}
				global::Ionic.BZip2.BZip2InputStream.hbCreateDecodeTables(decompressionState.gLimit[i], decompressionState.gBase[i], decompressionState.gPerm[i], temp_charArray2d[i], num, num2, alphaSize);
				decompressionState.gMinlen[i] = num;
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001EE74 File Offset: 0x0001D074
		private void getAndMoveToFrontDecode()
		{
			global::Ionic.BZip2.BZip2InputStream.DecompressionState decompressionState = this.data;
			this.origPtr = this.GetBits(24);
			if (this.origPtr < 0)
			{
				throw new global::System.IO.IOException("BZ_DATA_ERROR");
			}
			if (this.origPtr > 10 + global::Ionic.BZip2.BZip2.BlockSizeMultiple * this.blockSize100k)
			{
				throw new global::System.IO.IOException("BZ_DATA_ERROR");
			}
			this.recvDecodingTables();
			byte[] getAndMoveToFrontDecode_yy = decompressionState.getAndMoveToFrontDecode_yy;
			int num = this.blockSize100k * global::Ionic.BZip2.BZip2.BlockSizeMultiple;
			int num2 = 256;
			while (--num2 >= 0)
			{
				getAndMoveToFrontDecode_yy[num2] = (byte)num2;
				decompressionState.unzftab[num2] = 0;
			}
			int num3 = 0;
			int num4 = global::Ionic.BZip2.BZip2.G_SIZE - 1;
			int num5 = this.nInUse + 1;
			int num6 = this.getAndMoveToFrontDecode0(0);
			int num7 = this.bsBuff;
			int i = this.bsLive;
			int num8 = -1;
			int num9 = (int)(decompressionState.selector[num3] & byte.MaxValue);
			int[] array = decompressionState.gBase[num9];
			int[] array2 = decompressionState.gLimit[num9];
			int[] array3 = decompressionState.gPerm[num9];
			int num10 = decompressionState.gMinlen[num9];
			while (num6 != num5)
			{
				if (num6 == (int)global::Ionic.BZip2.BZip2.RUNA || num6 == (int)global::Ionic.BZip2.BZip2.RUNB)
				{
					int num11 = -1;
					int num12 = 1;
					for (;;)
					{
						if (num6 == (int)global::Ionic.BZip2.BZip2.RUNA)
						{
							num11 += num12;
						}
						else
						{
							if (num6 != (int)global::Ionic.BZip2.BZip2.RUNB)
							{
								break;
							}
							num11 += num12 << 1;
						}
						if (num4 == 0)
						{
							num4 = global::Ionic.BZip2.BZip2.G_SIZE - 1;
							num9 = (int)(decompressionState.selector[++num3] & byte.MaxValue);
							array = decompressionState.gBase[num9];
							array2 = decompressionState.gLimit[num9];
							array3 = decompressionState.gPerm[num9];
							num10 = decompressionState.gMinlen[num9];
						}
						else
						{
							num4--;
						}
						int num13 = num10;
						while (i < num13)
						{
							int num14 = this.input.ReadByte();
							if (num14 < 0)
							{
								goto IL_1BB;
							}
							num7 = (num7 << 8 | num14);
							i += 8;
						}
						int j = num7 >> i - num13 & (1 << num13) - 1;
						i -= num13;
						while (j > array2[num13])
						{
							num13++;
							while (i < 1)
							{
								int num15 = this.input.ReadByte();
								if (num15 < 0)
								{
									goto IL_217;
								}
								num7 = (num7 << 8 | num15);
								i += 8;
							}
							i--;
							j = (j << 1 | (num7 >> i & 1));
						}
						num6 = array3[j - array[num13]];
						num12 <<= 1;
					}
					byte b = decompressionState.seqToUnseq[(int)getAndMoveToFrontDecode_yy[0]];
					decompressionState.unzftab[(int)(b & byte.MaxValue)] += num11 + 1;
					while (num11-- >= 0)
					{
						decompressionState.ll8[++num8] = b;
					}
					if (num8 >= num)
					{
						throw new global::System.IO.IOException("block overrun");
					}
					continue;
					IL_1BB:
					throw new global::System.IO.IOException("unexpected end of stream");
					IL_217:
					throw new global::System.IO.IOException("unexpected end of stream");
				}
				if (++num8 >= num)
				{
					throw new global::System.IO.IOException("block overrun");
				}
				byte b2 = getAndMoveToFrontDecode_yy[num6 - 1];
				decompressionState.unzftab[(int)(decompressionState.seqToUnseq[(int)b2] & byte.MaxValue)]++;
				decompressionState.ll8[num8] = decompressionState.seqToUnseq[(int)b2];
				if (num6 <= 16)
				{
					int k = num6 - 1;
					while (k > 0)
					{
						getAndMoveToFrontDecode_yy[k] = getAndMoveToFrontDecode_yy[--k];
					}
				}
				else
				{
					global::System.Buffer.BlockCopy(getAndMoveToFrontDecode_yy, 0, getAndMoveToFrontDecode_yy, 1, num6 - 1);
				}
				getAndMoveToFrontDecode_yy[0] = b2;
				if (num4 == 0)
				{
					num4 = global::Ionic.BZip2.BZip2.G_SIZE - 1;
					num9 = (int)(decompressionState.selector[++num3] & byte.MaxValue);
					array = decompressionState.gBase[num9];
					array2 = decompressionState.gLimit[num9];
					array3 = decompressionState.gPerm[num9];
					num10 = decompressionState.gMinlen[num9];
				}
				else
				{
					num4--;
				}
				int num16 = num10;
				while (i < num16)
				{
					int num17 = this.input.ReadByte();
					if (num17 < 0)
					{
						throw new global::System.IO.IOException("unexpected end of stream");
					}
					num7 = (num7 << 8 | num17);
					i += 8;
				}
				int l = num7 >> i - num16 & (1 << num16) - 1;
				i -= num16;
				while (l > array2[num16])
				{
					num16++;
					while (i < 1)
					{
						int num18 = this.input.ReadByte();
						if (num18 < 0)
						{
							throw new global::System.IO.IOException("unexpected end of stream");
						}
						num7 = (num7 << 8 | num18);
						i += 8;
					}
					i--;
					l = (l << 1 | (num7 >> i & 1));
				}
				num6 = array3[l - array[num16]];
			}
			this.last = num8;
			this.bsLive = i;
			this.bsBuff = num7;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		private int getAndMoveToFrontDecode0(int groupNo)
		{
			global::Ionic.BZip2.BZip2InputStream.DecompressionState decompressionState = this.data;
			int num = (int)(decompressionState.selector[groupNo] & byte.MaxValue);
			int[] array = decompressionState.gLimit[num];
			int num2 = decompressionState.gMinlen[num];
			int i = this.GetBits(num2);
			int j = this.bsLive;
			int num3 = this.bsBuff;
			while (i > array[num2])
			{
				num2++;
				while (j < 1)
				{
					int num4 = this.input.ReadByte();
					if (num4 < 0)
					{
						throw new global::System.IO.IOException("unexpected end of stream");
					}
					num3 = (num3 << 8 | num4);
					j += 8;
				}
				j--;
				i = (i << 1 | (num3 >> j & 1));
			}
			this.bsLive = j;
			this.bsBuff = num3;
			return decompressionState.gPerm[num][i - decompressionState.gBase[num][num2]];
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001F3C0 File Offset: 0x0001D5C0
		private void SetupBlock()
		{
			if (this.data == null)
			{
				return;
			}
			global::Ionic.BZip2.BZip2InputStream.DecompressionState decompressionState = this.data;
			int[] array = decompressionState.initTT(this.last + 1);
			int i;
			for (i = 0; i <= 255; i++)
			{
				if (decompressionState.unzftab[i] < 0 || decompressionState.unzftab[i] > this.last)
				{
					throw new global::System.Exception("BZ_DATA_ERROR");
				}
			}
			decompressionState.cftab[0] = 0;
			for (i = 1; i <= 256; i++)
			{
				decompressionState.cftab[i] = decompressionState.unzftab[i - 1];
			}
			for (i = 1; i <= 256; i++)
			{
				decompressionState.cftab[i] += decompressionState.cftab[i - 1];
			}
			for (i = 0; i <= 256; i++)
			{
				if (decompressionState.cftab[i] < 0 || decompressionState.cftab[i] > this.last + 1)
				{
					throw new global::System.Exception(string.Format("BZ_DATA_ERROR: cftab[{0}]={1} last={2}", i, decompressionState.cftab[i], this.last));
				}
			}
			for (i = 1; i <= 256; i++)
			{
				if (decompressionState.cftab[i - 1] > decompressionState.cftab[i])
				{
					throw new global::System.Exception("BZ_DATA_ERROR");
				}
			}
			i = 0;
			int num = this.last;
			while (i <= num)
			{
				int[] array2 = array;
				int[] cftab = decompressionState.cftab;
				byte b = decompressionState.ll8[i] & byte.MaxValue;
				int num2 = cftab[(int)b];
				cftab[(int)b] = num2 + 1;
				array2[num2] = i;
				i++;
			}
			if (this.origPtr < 0 || this.origPtr >= array.Length)
			{
				throw new global::System.IO.IOException("stream corrupted");
			}
			this.su_tPos = array[this.origPtr];
			this.su_count = 0;
			this.su_i2 = 0;
			this.su_ch2 = 256;
			if (this.blockRandomised)
			{
				this.su_rNToGo = 0;
				this.su_rTPos = 0;
				this.SetupRandPartA();
				return;
			}
			this.SetupNoRandPartA();
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0001F5A4 File Offset: 0x0001D7A4
		private void SetupRandPartA()
		{
			if (this.su_i2 <= this.last)
			{
				this.su_chPrev = this.su_ch2;
				int num = (int)(this.data.ll8[this.su_tPos] & byte.MaxValue);
				this.su_tPos = this.data.tt[this.su_tPos];
				if (this.su_rNToGo == 0)
				{
					this.su_rNToGo = global::Ionic.BZip2.Rand.Rnums(this.su_rTPos) - 1;
					int num2 = this.su_rTPos + 1;
					this.su_rTPos = num2;
					if (num2 == 512)
					{
						this.su_rTPos = 0;
					}
				}
				else
				{
					this.su_rNToGo--;
				}
				num = (this.su_ch2 = (num ^ ((this.su_rNToGo == 1) ? 1 : 0)));
				this.su_i2++;
				this.currentChar = num;
				this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.RAND_PART_B;
				this.crc.UpdateCRC((byte)num);
				return;
			}
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0001F69C File Offset: 0x0001D89C
		private void SetupNoRandPartA()
		{
			if (this.su_i2 <= this.last)
			{
				this.su_chPrev = this.su_ch2;
				int num = (int)(this.data.ll8[this.su_tPos] & byte.MaxValue);
				this.su_ch2 = num;
				this.su_tPos = this.data.tt[this.su_tPos];
				this.su_i2++;
				this.currentChar = num;
				this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.NO_RAND_PART_B;
				this.crc.UpdateCRC((byte)num);
				return;
			}
			this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.NO_RAND_PART_A;
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0001F740 File Offset: 0x0001D940
		private void SetupRandPartB()
		{
			if (this.su_ch2 != this.su_chPrev)
			{
				this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.RAND_PART_A;
				this.su_count = 1;
				this.SetupRandPartA();
				return;
			}
			int num = this.su_count + 1;
			this.su_count = num;
			if (num >= 4)
			{
				this.su_z = (char)(this.data.ll8[this.su_tPos] & byte.MaxValue);
				this.su_tPos = this.data.tt[this.su_tPos];
				if (this.su_rNToGo == 0)
				{
					this.su_rNToGo = global::Ionic.BZip2.Rand.Rnums(this.su_rTPos) - 1;
					num = this.su_rTPos + 1;
					this.su_rTPos = num;
					if (num == 512)
					{
						this.su_rTPos = 0;
					}
				}
				else
				{
					this.su_rNToGo--;
				}
				this.su_j2 = 0;
				this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.RAND_PART_C;
				if (this.su_rNToGo == 1)
				{
					this.su_z ^= '\u0001';
				}
				this.SetupRandPartC();
				return;
			}
			this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.RAND_PART_A;
			this.SetupRandPartA();
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0001F844 File Offset: 0x0001DA44
		private void SetupRandPartC()
		{
			if (this.su_j2 < (int)this.su_z)
			{
				this.currentChar = this.su_ch2;
				this.crc.UpdateCRC((byte)this.su_ch2);
				this.su_j2++;
				return;
			}
			this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.RAND_PART_A;
			this.su_i2++;
			this.su_count = 0;
			this.SetupRandPartA();
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0001F8B0 File Offset: 0x0001DAB0
		private void SetupNoRandPartB()
		{
			if (this.su_ch2 != this.su_chPrev)
			{
				this.su_count = 1;
				this.SetupNoRandPartA();
				return;
			}
			int num = this.su_count + 1;
			this.su_count = num;
			if (num >= 4)
			{
				this.su_z = (char)(this.data.ll8[this.su_tPos] & byte.MaxValue);
				this.su_tPos = this.data.tt[this.su_tPos];
				this.su_j2 = 0;
				this.SetupNoRandPartC();
				return;
			}
			this.SetupNoRandPartA();
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001F938 File Offset: 0x0001DB38
		private void SetupNoRandPartC()
		{
			if (this.su_j2 < (int)this.su_z)
			{
				int num = this.su_ch2;
				this.currentChar = num;
				this.crc.UpdateCRC((byte)num);
				this.su_j2++;
				this.currentState = global::Ionic.BZip2.BZip2InputStream.CState.NO_RAND_PART_C;
				return;
			}
			this.su_i2++;
			this.su_count = 0;
			this.SetupNoRandPartA();
		}

		// Token: 0x04000364 RID: 868
		private bool _disposed;

		// Token: 0x04000365 RID: 869
		private bool _leaveOpen;

		// Token: 0x04000366 RID: 870
		private long totalBytesRead;

		// Token: 0x04000367 RID: 871
		private int last;

		// Token: 0x04000368 RID: 872
		private int origPtr;

		// Token: 0x04000369 RID: 873
		private int blockSize100k;

		// Token: 0x0400036A RID: 874
		private bool blockRandomised;

		// Token: 0x0400036B RID: 875
		private int bsBuff;

		// Token: 0x0400036C RID: 876
		private int bsLive;

		// Token: 0x0400036D RID: 877
		private readonly global::Ionic.Crc.CRC32 crc = new global::Ionic.Crc.CRC32(true);

		// Token: 0x0400036E RID: 878
		private int nInUse;

		// Token: 0x0400036F RID: 879
		private global::System.IO.Stream input;

		// Token: 0x04000370 RID: 880
		private int currentChar = -1;

		// Token: 0x04000371 RID: 881
		private global::Ionic.BZip2.BZip2InputStream.CState currentState = global::Ionic.BZip2.BZip2InputStream.CState.START_BLOCK;

		// Token: 0x04000372 RID: 882
		private uint storedBlockCRC;

		// Token: 0x04000373 RID: 883
		private uint storedCombinedCRC;

		// Token: 0x04000374 RID: 884
		private uint computedBlockCRC;

		// Token: 0x04000375 RID: 885
		private uint computedCombinedCRC;

		// Token: 0x04000376 RID: 886
		private int su_count;

		// Token: 0x04000377 RID: 887
		private int su_ch2;

		// Token: 0x04000378 RID: 888
		private int su_chPrev;

		// Token: 0x04000379 RID: 889
		private int su_i2;

		// Token: 0x0400037A RID: 890
		private int su_j2;

		// Token: 0x0400037B RID: 891
		private int su_rNToGo;

		// Token: 0x0400037C RID: 892
		private int su_rTPos;

		// Token: 0x0400037D RID: 893
		private int su_tPos;

		// Token: 0x0400037E RID: 894
		private char su_z;

		// Token: 0x0400037F RID: 895
		private global::Ionic.BZip2.BZip2InputStream.DecompressionState data;

		// Token: 0x0200007D RID: 125
		private enum CState
		{
			// Token: 0x04000441 RID: 1089
			EOF,
			// Token: 0x04000442 RID: 1090
			START_BLOCK,
			// Token: 0x04000443 RID: 1091
			RAND_PART_A,
			// Token: 0x04000444 RID: 1092
			RAND_PART_B,
			// Token: 0x04000445 RID: 1093
			RAND_PART_C,
			// Token: 0x04000446 RID: 1094
			NO_RAND_PART_A,
			// Token: 0x04000447 RID: 1095
			NO_RAND_PART_B,
			// Token: 0x04000448 RID: 1096
			NO_RAND_PART_C
		}

		// Token: 0x0200007E RID: 126
		private sealed class DecompressionState
		{
			// Token: 0x06000566 RID: 1382 RVA: 0x00020E4C File Offset: 0x0001F04C
			public DecompressionState(int blockSize100k)
			{
				this.unzftab = new int[256];
				this.gLimit = global::Ionic.BZip2.BZip2.InitRectangularArray<int>(global::Ionic.BZip2.BZip2.NGroups, global::Ionic.BZip2.BZip2.MaxAlphaSize);
				this.gBase = global::Ionic.BZip2.BZip2.InitRectangularArray<int>(global::Ionic.BZip2.BZip2.NGroups, global::Ionic.BZip2.BZip2.MaxAlphaSize);
				this.gPerm = global::Ionic.BZip2.BZip2.InitRectangularArray<int>(global::Ionic.BZip2.BZip2.NGroups, global::Ionic.BZip2.BZip2.MaxAlphaSize);
				this.gMinlen = new int[global::Ionic.BZip2.BZip2.NGroups];
				this.cftab = new int[257];
				this.getAndMoveToFrontDecode_yy = new byte[256];
				this.temp_charArray2d = global::Ionic.BZip2.BZip2.InitRectangularArray<char>(global::Ionic.BZip2.BZip2.NGroups, global::Ionic.BZip2.BZip2.MaxAlphaSize);
				this.recvDecodingTables_pos = new byte[global::Ionic.BZip2.BZip2.NGroups];
				this.ll8 = new byte[blockSize100k * global::Ionic.BZip2.BZip2.BlockSizeMultiple];
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x00020F58 File Offset: 0x0001F158
			public int[] initTT(int length)
			{
				int[] array = this.tt;
				if (array == null || array.Length < length)
				{
					array = (this.tt = new int[length]);
				}
				return array;
			}

			// Token: 0x04000449 RID: 1097
			public readonly bool[] inUse = new bool[256];

			// Token: 0x0400044A RID: 1098
			public readonly byte[] seqToUnseq = new byte[256];

			// Token: 0x0400044B RID: 1099
			public readonly byte[] selector = new byte[global::Ionic.BZip2.BZip2.MaxSelectors];

			// Token: 0x0400044C RID: 1100
			public readonly byte[] selectorMtf = new byte[global::Ionic.BZip2.BZip2.MaxSelectors];

			// Token: 0x0400044D RID: 1101
			public readonly int[] unzftab;

			// Token: 0x0400044E RID: 1102
			public readonly int[][] gLimit;

			// Token: 0x0400044F RID: 1103
			public readonly int[][] gBase;

			// Token: 0x04000450 RID: 1104
			public readonly int[][] gPerm;

			// Token: 0x04000451 RID: 1105
			public readonly int[] gMinlen;

			// Token: 0x04000452 RID: 1106
			public readonly int[] cftab;

			// Token: 0x04000453 RID: 1107
			public readonly byte[] getAndMoveToFrontDecode_yy;

			// Token: 0x04000454 RID: 1108
			public readonly char[][] temp_charArray2d;

			// Token: 0x04000455 RID: 1109
			public readonly byte[] recvDecodingTables_pos;

			// Token: 0x04000456 RID: 1110
			public int[] tt;

			// Token: 0x04000457 RID: 1111
			public byte[] ll8;
		}
	}
}
