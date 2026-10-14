using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Apache.Bzip2
{
	// Token: 0x02000007 RID: 7
	public class CBZip2InputStream : global::System.IO.Stream
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0000221F File Offset: 0x0000041F
		private static void Cadvise()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002221 File Offset: 0x00000421
		private static void CompressedStreamEOF()
		{
			global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.Cadvise();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002228 File Offset: 0x00000428
		private void MakeMaps()
		{
			this.nInUse = 0;
			for (int i = 0; i < 256; i++)
			{
				if (this.inUse[i])
				{
					this.seqToUnseq[this.nInUse] = (char)i;
					this.unseqToSeq[i] = (char)this.nInUse;
					this.nInUse++;
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002284 File Offset: 0x00000484
		public CBZip2InputStream(global::System.IO.Stream zStream)
		{
			this.ll8 = null;
			this.tt = null;
			this.BsSetStream(zStream);
			this.Initialize();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002378 File Offset: 0x00000578
		internal static int[][] InitIntArray(int n1, int n2)
		{
			int[][] a = new int[n1][];
			for (int i = 0; i < n1; i++)
			{
				a[i] = new int[n2];
			}
			return a;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000023A4 File Offset: 0x000005A4
		internal static byte[][] InitByteArray(int n1, int n2)
		{
			byte[][] a = new byte[n1][];
			for (int i = 0; i < n1; i++)
			{
				a[i] = new byte[n2];
			}
			return a;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023D0 File Offset: 0x000005D0
		public override int ReadByte()
		{
			if (this.streamEnd)
			{
				return -1;
			}
			int retChar = this.currentChar;
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
			return retChar;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000243C File Offset: 0x0000063C
		private void Initialize()
		{
			int num = (int)this.BsGetUChar();
			char magic4 = this.BsGetUChar();
			if (num != 66 && magic4 != 'Z')
			{
				throw new global::System.IO.IOException("Not a BZIP2 marked stream");
			}
			int num2 = (int)this.BsGetUChar();
			magic4 = this.BsGetUChar();
			if (num2 != 104 || magic4 < '1' || magic4 > '9')
			{
				this.BsFinishedWithStream();
				this.streamEnd = true;
				return;
			}
			this.SetDecompressStructureSizes((int)(magic4 - '0'));
			this.computedCombinedCRC = 0;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024A4 File Offset: 0x000006A4
		private void InitBlock()
		{
			char magic = this.BsGetUChar();
			char magic2 = this.BsGetUChar();
			char magic3 = this.BsGetUChar();
			char magic4 = this.BsGetUChar();
			char magic5 = this.BsGetUChar();
			char magic6 = this.BsGetUChar();
			if (magic == '\u0017' && magic2 == 'r' && magic3 == 'E' && magic4 == '8' && magic5 == 'P' && magic6 == '\u0090')
			{
				this.Complete();
				return;
			}
			if (magic != '1' || magic2 != 'A' || magic3 != 'Y' || magic4 != '&' || magic5 != 'S' || magic6 != 'Y')
			{
				global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.BadBlockHeader();
				this.streamEnd = true;
				return;
			}
			this.storedBlockCRC = this.BsGetInt32();
			this.blockRandomised = (this.BsR(1) == 1);
			this.GetAndMoveToFrontDecode();
			this.mCrc.InitialiseCRC();
			this.currentState = 1;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002568 File Offset: 0x00000768
		private void EndBlock()
		{
			this.computedBlockCRC = this.mCrc.GetFinalCRC();
			if (this.storedBlockCRC != this.computedBlockCRC)
			{
				global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.CrcError();
			}
			this.computedCombinedCRC = (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(this.computedCombinedCRC, 1) ^ this.computedBlockCRC);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000025A7 File Offset: 0x000007A7
		private void Complete()
		{
			this.storedCombinedCRC = this.BsGetInt32();
			if (this.storedCombinedCRC != this.computedCombinedCRC)
			{
				global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.CrcError();
			}
			this.BsFinishedWithStream();
			this.streamEnd = true;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000025D5 File Offset: 0x000007D5
		private static void BlockOverrun()
		{
			global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.Cadvise();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025DC File Offset: 0x000007DC
		private static void BadBlockHeader()
		{
			global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.Cadvise();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025E3 File Offset: 0x000007E3
		private static void CrcError()
		{
			global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.Cadvise();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000025EC File Offset: 0x000007EC
		private void BsFinishedWithStream()
		{
			try
			{
				if (this.bsStream != null)
				{
					global::Org.BouncyCastle.Utilities.Platform.Dispose(this.bsStream);
					this.bsStream = null;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002628 File Offset: 0x00000828
		private void BsSetStream(global::System.IO.Stream f)
		{
			this.bsStream = f;
			this.bsLive = 0;
			this.bsBuff = 0;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002640 File Offset: 0x00000840
		private int BsR(int n)
		{
			while (this.bsLive < n)
			{
				char thech = '\0';
				try
				{
					thech = (char)this.bsStream.ReadByte();
				}
				catch (global::System.IO.IOException)
				{
					global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.CompressedStreamEOF();
				}
				if (thech == '￿')
				{
					global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.CompressedStreamEOF();
				}
				int zzi = (int)thech;
				this.bsBuff = (this.bsBuff << 8 | (zzi & 255));
				this.bsLive += 8;
			}
			int result = this.bsBuff >> this.bsLive - n & (1 << n) - 1;
			this.bsLive -= n;
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000026E0 File Offset: 0x000008E0
		private char BsGetUChar()
		{
			return (char)this.BsR(8);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026EA File Offset: 0x000008EA
		private int BsGetint()
		{
			return this.BsR(16) << 16 | this.BsR(16);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002700 File Offset: 0x00000900
		private int BsGetIntVS(int numBits)
		{
			return this.BsR(numBits);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002709 File Offset: 0x00000909
		private int BsGetInt32()
		{
			return this.BsGetint();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002714 File Offset: 0x00000914
		private void HbCreateDecodeTables(int[] limit, int[] basev, int[] perm, byte[] length, int minLen, int maxLen, int alphaSize)
		{
			int pp = 0;
			for (int i = minLen; i <= maxLen; i++)
			{
				for (int j = 0; j < alphaSize; j++)
				{
					if ((int)length[j] == i)
					{
						perm[pp] = j;
						pp++;
					}
				}
			}
			for (int i = 0; i < 23; i++)
			{
				basev[i] = 0;
			}
			for (int i = 0; i < alphaSize; i++)
			{
				basev[(int)(length[i] + 1)]++;
			}
			for (int i = 1; i < 23; i++)
			{
				basev[i] += basev[i - 1];
			}
			for (int i = 0; i < 23; i++)
			{
				limit[i] = 0;
			}
			int vec = 0;
			for (int i = minLen; i <= maxLen; i++)
			{
				vec += basev[i + 1] - basev[i];
				limit[i] = vec - 1;
				vec <<= 1;
			}
			for (int i = minLen + 1; i <= maxLen; i++)
			{
				basev[i] = (limit[i - 1] + 1 << 1) - basev[i];
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000027F0 File Offset: 0x000009F0
		private void RecvDecodingTables()
		{
			byte[][] len = global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.InitByteArray(6, 258);
			bool[] inUse16 = new bool[16];
			for (int i = 0; i < 16; i++)
			{
				inUse16[i] = (this.BsR(1) == 1);
			}
			for (int i = 0; i < 16; i++)
			{
				int i2 = i * 16;
				if (inUse16[i])
				{
					for (int j = 0; j < 16; j++)
					{
						this.inUse[i2 + j] = (this.BsR(1) == 1);
					}
				}
				else
				{
					for (int j = 0; j < 16; j++)
					{
						this.inUse[i2 + j] = false;
					}
				}
			}
			this.MakeMaps();
			int alphaSize = this.nInUse + 2;
			int nGroups = this.BsR(3);
			int nSelectors = this.BsR(15);
			for (int i = 0; i < nSelectors; i++)
			{
				int j = 0;
				while (this.BsR(1) == 1)
				{
					j++;
				}
				this.selectorMtf[i] = (char)j;
			}
			char[] pos = new char[6];
			char v = '\0';
			while ((int)v < nGroups)
			{
				pos[(int)v] = v;
				v += '\u0001';
			}
			for (int i = 0; i < nSelectors; i++)
			{
				v = this.selectorMtf[i];
				char tmp = pos[(int)v];
				while (v > '\0')
				{
					pos[(int)v] = pos[(int)(v - '\u0001')];
					v -= '\u0001';
				}
				pos[0] = tmp;
				this.selector[i] = tmp;
			}
			for (int t = 0; t < nGroups; t++)
			{
				byte[] len_t = len[t];
				int curr = this.BsR(5);
				for (int i = 0; i < alphaSize; i++)
				{
					while (this.BsR(1) == 1)
					{
						if (this.BsR(1) == 0)
						{
							curr++;
						}
						else
						{
							curr--;
						}
					}
					len_t[i] = (byte)curr;
				}
			}
			for (int t = 0; t < nGroups; t++)
			{
				int minLen = 32;
				int maxLen = 0;
				byte[] len_t2 = len[t];
				for (int i = 0; i < alphaSize; i++)
				{
					int lti = (int)len_t2[i];
					if (lti > maxLen)
					{
						maxLen = lti;
					}
					if (lti < minLen)
					{
						minLen = lti;
					}
				}
				this.HbCreateDecodeTables(this.limit[t], this.basev[t], this.perm[t], len_t2, minLen, maxLen, alphaSize);
				this.minLens[t] = minLen;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000029F8 File Offset: 0x00000BF8
		private void GetAndMoveToFrontDecode()
		{
			char[] yy = new char[256];
			int limitLast = 100000 * this.blockSize100k;
			this.origPtr = this.BsGetIntVS(24);
			this.RecvDecodingTables();
			int EOB = this.nInUse + 1;
			int groupNo = -1;
			int groupPos = 0;
			for (int i = 0; i <= 255; i++)
			{
				this.unzftab[i] = 0;
			}
			for (int i = 0; i <= 255; i++)
			{
				yy[i] = (char)i;
			}
			this.last = -1;
			if (groupPos == 0)
			{
				groupNo++;
				groupPos = 50;
			}
			groupPos--;
			int zt = (int)this.selector[groupNo];
			int zn = this.minLens[zt];
			int zvec;
			int zj;
			for (zvec = this.BsR(zn); zvec > this.limit[zt][zn]; zvec = (zvec << 1 | zj))
			{
				zn++;
				while (this.bsLive < 1)
				{
					char thech = '\0';
					try
					{
						thech = (char)this.bsStream.ReadByte();
					}
					catch (global::System.IO.IOException)
					{
						global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.CompressedStreamEOF();
					}
					if (thech == '￿')
					{
						global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.CompressedStreamEOF();
					}
					int zzi = (int)thech;
					this.bsBuff = (this.bsBuff << 8 | (zzi & 255));
					this.bsLive += 8;
				}
				zj = (this.bsBuff >> this.bsLive - 1 & 1);
				this.bsLive--;
			}
			int nextSym = this.perm[zt][zvec - this.basev[zt][zn]];
			while (nextSym != EOB)
			{
				if (nextSym == 0 || nextSym == 1)
				{
					int s = -1;
					int N = 1;
					do
					{
						if (nextSym == 0)
						{
							s += N;
						}
						else if (nextSym == 1)
						{
							s += 2 * N;
						}
						N *= 2;
						if (groupPos == 0)
						{
							groupNo++;
							groupPos = 50;
						}
						groupPos--;
						int zt2 = (int)this.selector[groupNo];
						int zn2 = this.minLens[zt2];
						int zvec2;
						int zj2;
						for (zvec2 = this.BsR(zn2); zvec2 > this.limit[zt2][zn2]; zvec2 = (zvec2 << 1 | zj2))
						{
							zn2++;
							while (this.bsLive < 1)
							{
								char thech2 = '\0';
								try
								{
									thech2 = (char)this.bsStream.ReadByte();
								}
								catch (global::System.IO.IOException)
								{
									global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.CompressedStreamEOF();
								}
								if (thech2 == '￿')
								{
									global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.CompressedStreamEOF();
								}
								int zzi2 = (int)thech2;
								this.bsBuff = (this.bsBuff << 8 | (zzi2 & 255));
								this.bsLive += 8;
							}
							zj2 = (this.bsBuff >> this.bsLive - 1 & 1);
							this.bsLive--;
						}
						nextSym = this.perm[zt2][zvec2 - this.basev[zt2][zn2]];
					}
					while (nextSym == 0 || nextSym == 1);
					s++;
					char ch = this.seqToUnseq[(int)yy[0]];
					this.unzftab[(int)ch] += s;
					while (s > 0)
					{
						this.last++;
						this.ll8[this.last] = ch;
						s--;
					}
					if (this.last >= limitLast)
					{
						global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.BlockOverrun();
					}
				}
				else
				{
					int num = this.last + 1;
					this.last = num;
					if (num >= limitLast)
					{
						global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.BlockOverrun();
					}
					char tmp = yy[nextSym - 1];
					this.unzftab[(int)this.seqToUnseq[(int)tmp]]++;
					this.ll8[this.last] = this.seqToUnseq[(int)tmp];
					if (nextSym <= 16)
					{
						for (int j = nextSym - 1; j > 0; j--)
						{
							yy[j] = yy[j - 1];
						}
					}
					else
					{
						global::System.Array.Copy(yy, 0, yy, 1, nextSym - 1);
					}
					yy[0] = tmp;
					if (groupPos == 0)
					{
						groupNo++;
						groupPos = 50;
					}
					groupPos--;
					int zt3 = (int)this.selector[groupNo];
					int zn3 = this.minLens[zt3];
					int zvec3;
					int zj3;
					for (zvec3 = this.BsR(zn3); zvec3 > this.limit[zt3][zn3]; zvec3 = (zvec3 << 1 | zj3))
					{
						zn3++;
						while (this.bsLive < 1)
						{
							char thech3 = '\0';
							try
							{
								thech3 = (char)this.bsStream.ReadByte();
							}
							catch (global::System.IO.IOException)
							{
								global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.CompressedStreamEOF();
							}
							int zzi3 = (int)thech3;
							this.bsBuff = (this.bsBuff << 8 | (zzi3 & 255));
							this.bsLive += 8;
						}
						zj3 = (this.bsBuff >> this.bsLive - 1 & 1);
						this.bsLive--;
					}
					nextSym = this.perm[zt3][zvec3 - this.basev[zt3][zn3]];
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002EA4 File Offset: 0x000010A4
		private void SetupBlock()
		{
			int[] cftab = new int[257];
			cftab[0] = 0;
			this.i = 1;
			while (this.i <= 256)
			{
				cftab[this.i] = this.unzftab[this.i - 1];
				this.i++;
			}
			this.i = 1;
			while (this.i <= 256)
			{
				cftab[this.i] += cftab[this.i - 1];
				this.i++;
			}
			this.i = 0;
			while (this.i <= this.last)
			{
				char ch = this.ll8[this.i];
				this.tt[cftab[(int)ch]] = this.i;
				cftab[(int)ch]++;
				this.i++;
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

		// Token: 0x06000028 RID: 40 RVA: 0x00002FDC File Offset: 0x000011DC
		private void SetupRandPartA()
		{
			if (this.i2 <= this.last)
			{
				this.chPrev = this.ch2;
				this.ch2 = (int)this.ll8[this.tPos];
				this.tPos = this.tt[this.tPos];
				if (this.rNToGo == 0)
				{
					this.rNToGo = global::Org.BouncyCastle.Apache.Bzip2.BZip2Constants.rNums[this.rTPos];
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
				this.mCrc.UpdateCRC(this.ch2);
				return;
			}
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000030D8 File Offset: 0x000012D8
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
				this.mCrc.UpdateCRC(this.ch2);
				return;
			}
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000316C File Offset: 0x0000136C
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
					this.rNToGo = global::Org.BouncyCastle.Apache.Bzip2.BZip2Constants.rNums[this.rTPos];
					this.rTPos++;
					if (this.rTPos == 512)
					{
						this.rTPos = 0;
					}
				}
				this.rNToGo--;
				this.z ^= ((this.rNToGo == 1) ? '\u0001' : '\0');
				this.j2 = 0;
				this.currentState = 4;
				this.SetupRandPartC();
				return;
			}
			this.currentState = 2;
			this.SetupRandPartA();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003264 File Offset: 0x00001464
		private void SetupRandPartC()
		{
			if (this.j2 < (int)this.z)
			{
				this.currentChar = this.ch2;
				this.mCrc.UpdateCRC(this.ch2);
				this.j2++;
				return;
			}
			this.currentState = 2;
			this.i2++;
			this.count = 0;
			this.SetupRandPartA();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000032D0 File Offset: 0x000014D0
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

		// Token: 0x0600002D RID: 45 RVA: 0x00003360 File Offset: 0x00001560
		private void SetupNoRandPartC()
		{
			if (this.j2 < (int)this.z)
			{
				this.currentChar = this.ch2;
				this.mCrc.UpdateCRC(this.ch2);
				this.j2++;
				return;
			}
			this.currentState = 5;
			this.i2++;
			this.count = 0;
			this.SetupNoRandPartA();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000033CC File Offset: 0x000015CC
		private void SetDecompressStructureSizes(int newSize100k)
		{
			if (0 <= newSize100k && newSize100k <= 9 && 0 <= this.blockSize100k)
			{
				int num = this.blockSize100k;
			}
			this.blockSize100k = newSize100k;
			if (newSize100k == 0)
			{
				return;
			}
			int i = 100000 * newSize100k;
			this.ll8 = new char[i];
			this.tt = new int[i];
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003420 File Offset: 0x00001620
		public override void Flush()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003424 File Offset: 0x00001624
		public override int Read(byte[] buffer, int offset, int count)
		{
			int i;
			for (i = 0; i < count; i++)
			{
				int c = this.ReadByte();
				if (c == -1)
				{
					break;
				}
				buffer[i + offset] = (byte)c;
			}
			return i;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003452 File Offset: 0x00001652
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003456 File Offset: 0x00001656
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003458 File Offset: 0x00001658
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000345A File Offset: 0x0000165A
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000345D File Offset: 0x0000165D
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003460 File Offset: 0x00001660
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003463 File Offset: 0x00001663
		public override long Length
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003467 File Offset: 0x00001667
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000346B File Offset: 0x0000166B
		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		// Token: 0x0400001C RID: 28
		private int last;

		// Token: 0x0400001D RID: 29
		private int origPtr;

		// Token: 0x0400001E RID: 30
		private int blockSize100k;

		// Token: 0x0400001F RID: 31
		private bool blockRandomised;

		// Token: 0x04000020 RID: 32
		private int bsBuff;

		// Token: 0x04000021 RID: 33
		private int bsLive;

		// Token: 0x04000022 RID: 34
		private global::Org.BouncyCastle.Apache.Bzip2.CRC mCrc = new global::Org.BouncyCastle.Apache.Bzip2.CRC();

		// Token: 0x04000023 RID: 35
		private bool[] inUse = new bool[256];

		// Token: 0x04000024 RID: 36
		private int nInUse;

		// Token: 0x04000025 RID: 37
		private char[] seqToUnseq = new char[256];

		// Token: 0x04000026 RID: 38
		private char[] unseqToSeq = new char[256];

		// Token: 0x04000027 RID: 39
		private char[] selector = new char[18002];

		// Token: 0x04000028 RID: 40
		private char[] selectorMtf = new char[18002];

		// Token: 0x04000029 RID: 41
		private int[] tt;

		// Token: 0x0400002A RID: 42
		private char[] ll8;

		// Token: 0x0400002B RID: 43
		private int[] unzftab = new int[256];

		// Token: 0x0400002C RID: 44
		private int[][] limit = global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.InitIntArray(6, 258);

		// Token: 0x0400002D RID: 45
		private int[][] basev = global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.InitIntArray(6, 258);

		// Token: 0x0400002E RID: 46
		private int[][] perm = global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.InitIntArray(6, 258);

		// Token: 0x0400002F RID: 47
		private int[] minLens = new int[6];

		// Token: 0x04000030 RID: 48
		private global::System.IO.Stream bsStream;

		// Token: 0x04000031 RID: 49
		private bool streamEnd;

		// Token: 0x04000032 RID: 50
		private int currentChar = -1;

		// Token: 0x04000033 RID: 51
		private const int START_BLOCK_STATE = 1;

		// Token: 0x04000034 RID: 52
		private const int RAND_PART_A_STATE = 2;

		// Token: 0x04000035 RID: 53
		private const int RAND_PART_B_STATE = 3;

		// Token: 0x04000036 RID: 54
		private const int RAND_PART_C_STATE = 4;

		// Token: 0x04000037 RID: 55
		private const int NO_RAND_PART_A_STATE = 5;

		// Token: 0x04000038 RID: 56
		private const int NO_RAND_PART_B_STATE = 6;

		// Token: 0x04000039 RID: 57
		private const int NO_RAND_PART_C_STATE = 7;

		// Token: 0x0400003A RID: 58
		private int currentState = 1;

		// Token: 0x0400003B RID: 59
		private int storedBlockCRC;

		// Token: 0x0400003C RID: 60
		private int storedCombinedCRC;

		// Token: 0x0400003D RID: 61
		private int computedBlockCRC;

		// Token: 0x0400003E RID: 62
		private int computedCombinedCRC;

		// Token: 0x0400003F RID: 63
		private int i2;

		// Token: 0x04000040 RID: 64
		private int count;

		// Token: 0x04000041 RID: 65
		private int chPrev;

		// Token: 0x04000042 RID: 66
		private int ch2;

		// Token: 0x04000043 RID: 67
		private int i;

		// Token: 0x04000044 RID: 68
		private int tPos;

		// Token: 0x04000045 RID: 69
		private int rNToGo;

		// Token: 0x04000046 RID: 70
		private int rTPos;

		// Token: 0x04000047 RID: 71
		private int j2;

		// Token: 0x04000048 RID: 72
		private char z;
	}
}
