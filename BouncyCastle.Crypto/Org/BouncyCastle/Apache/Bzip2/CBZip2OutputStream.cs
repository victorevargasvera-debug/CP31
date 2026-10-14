using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Apache.Bzip2
{
	// Token: 0x02000008 RID: 8
	public class CBZip2OutputStream : global::System.IO.Stream
	{
		// Token: 0x0600003A RID: 58 RVA: 0x0000346D File Offset: 0x0000166D
		private static void Panic()
		{
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003474 File Offset: 0x00001674
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

		// Token: 0x0600003C RID: 60 RVA: 0x000034D0 File Offset: 0x000016D0
		protected static void HbMakeCodeLengths(byte[] len, int[] freq, int alphaSize, int maxLen)
		{
			int[] heap = new int[260];
			int[] weight = new int[516];
			int[] parent = new int[516];
			for (int i = 0; i < alphaSize; i++)
			{
				weight[i + 1] = ((freq[i] == 0) ? 1 : freq[i]) << 8;
			}
			for (;;)
			{
				int nNodes = alphaSize;
				int nHeap = 0;
				heap[0] = 0;
				weight[0] = 0;
				parent[0] = -2;
				for (int j = 1; j <= alphaSize; j++)
				{
					parent[j] = -1;
					heap[++nHeap] = j;
					int zz = nHeap;
					int tmp = heap[zz];
					while (weight[tmp] < weight[heap[zz >> 1]])
					{
						heap[zz] = heap[zz >> 1];
						zz >>= 1;
					}
					heap[zz] = tmp;
				}
				if (nHeap >= 260)
				{
					global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
				}
				while (nHeap > 1)
				{
					int n = heap[1];
					heap[1] = heap[nHeap--];
					int zz2 = 1;
					int tmp2 = heap[zz2];
					for (;;)
					{
						int yy = zz2 << 1;
						if (yy > nHeap)
						{
							break;
						}
						if (yy < nHeap && weight[heap[yy + 1]] < weight[heap[yy]])
						{
							yy++;
						}
						if (weight[tmp2] < weight[heap[yy]])
						{
							break;
						}
						heap[zz2] = heap[yy];
						zz2 = yy;
					}
					heap[zz2] = tmp2;
					int n2 = heap[1];
					heap[1] = heap[nHeap--];
					int zz3 = 1;
					int tmp3 = heap[zz3];
					for (;;)
					{
						int yy2 = zz3 << 1;
						if (yy2 > nHeap)
						{
							break;
						}
						if (yy2 < nHeap && weight[heap[yy2 + 1]] < weight[heap[yy2]])
						{
							yy2++;
						}
						if (weight[tmp3] < weight[heap[yy2]])
						{
							break;
						}
						heap[zz3] = heap[yy2];
						zz3 = yy2;
					}
					heap[zz3] = tmp3;
					nNodes++;
					parent[n] = (parent[n2] = nNodes);
					weight[nNodes] = (int)((uint)(((long)weight[n] & (long)((ulong)-256)) + ((long)weight[n2] & (long)((ulong)-256))) | (uint)(1 + (((weight[n] & 255) > (weight[n2] & 255)) ? (weight[n] & 255) : (weight[n2] & 255))));
					parent[nNodes] = -1;
					heap[++nHeap] = nNodes;
					int zz4 = nHeap;
					int tmp4 = heap[zz4];
					while (weight[tmp4] < weight[heap[zz4 >> 1]])
					{
						heap[zz4] = heap[zz4 >> 1];
						zz4 >>= 1;
					}
					heap[zz4] = tmp4;
				}
				if (nNodes >= 516)
				{
					global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
				}
				bool tooLong = false;
				for (int k = 1; k <= alphaSize; k++)
				{
					int l = 0;
					int m = k;
					while (parent[m] >= 0)
					{
						m = parent[m];
						l++;
					}
					len[k - 1] = (byte)l;
					if (l > maxLen)
					{
						tooLong = true;
					}
				}
				if (!tooLong)
				{
					break;
				}
				for (int i2 = 1; i2 < alphaSize; i2++)
				{
					int j2 = weight[i2] >> 8;
					j2 = 1 + j2 / 2;
					weight[i2] = j2 << 8;
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003782 File Offset: 0x00001982
		public CBZip2OutputStream(global::System.IO.Stream outStream) : this(outStream, 9)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003790 File Offset: 0x00001990
		public CBZip2OutputStream(global::System.IO.Stream outStream, int blockSize)
		{
			this.blockBytes = null;
			this.quadrantShorts = null;
			this.zptr = null;
			this.ftab = null;
			outStream.WriteByte(66);
			outStream.WriteByte(90);
			this.BsSetStream(outStream);
			this.workFactor = 50;
			if (blockSize > 9)
			{
				blockSize = 9;
			}
			if (blockSize < 1)
			{
				blockSize = 1;
			}
			this.blockSize100k = blockSize;
			this.AllocateCompressStructures();
			this.Initialize();
			this.InitBlock();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000387C File Offset: 0x00001A7C
		public override void WriteByte(byte b)
		{
			if (this.currentByte == (int)b)
			{
				this.runLength++;
				if (this.runLength > 254)
				{
					this.WriteRun();
					this.currentByte = -1;
					this.runLength = 0;
					return;
				}
			}
			else
			{
				if (this.currentByte == -1)
				{
					this.currentByte = (int)b;
					this.runLength++;
					return;
				}
				this.WriteRun();
				this.runLength = 1;
				this.currentByte = (int)b;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000038F8 File Offset: 0x00001AF8
		private void WriteRun()
		{
			if (this.count > this.allowableBlockSize)
			{
				this.EndBlock();
				this.InitBlock();
			}
			this.inUse[this.currentByte] = true;
			for (int i = 0; i < this.runLength; i++)
			{
				this.mCrc.UpdateCRC(this.currentByte);
			}
			switch (this.runLength)
			{
			case 1:
			{
				byte[] array = this.blockBytes;
				int num = this.count + 1;
				this.count = num;
				array[num] = (byte)this.currentByte;
				return;
			}
			case 2:
			{
				byte[] array2 = this.blockBytes;
				int num = this.count + 1;
				this.count = num;
				array2[num] = (byte)this.currentByte;
				byte[] array3 = this.blockBytes;
				num = this.count + 1;
				this.count = num;
				array3[num] = (byte)this.currentByte;
				return;
			}
			case 3:
			{
				byte[] array4 = this.blockBytes;
				int num = this.count + 1;
				this.count = num;
				array4[num] = (byte)this.currentByte;
				byte[] array5 = this.blockBytes;
				num = this.count + 1;
				this.count = num;
				array5[num] = (byte)this.currentByte;
				byte[] array6 = this.blockBytes;
				num = this.count + 1;
				this.count = num;
				array6[num] = (byte)this.currentByte;
				return;
			}
			default:
			{
				this.inUse[this.runLength - 4] = true;
				byte[] array7 = this.blockBytes;
				int num = this.count + 1;
				this.count = num;
				array7[num] = (byte)this.currentByte;
				byte[] array8 = this.blockBytes;
				num = this.count + 1;
				this.count = num;
				array8[num] = (byte)this.currentByte;
				byte[] array9 = this.blockBytes;
				num = this.count + 1;
				this.count = num;
				array9[num] = (byte)this.currentByte;
				byte[] array10 = this.blockBytes;
				num = this.count + 1;
				this.count = num;
				array10[num] = (byte)this.currentByte;
				byte[] array11 = this.blockBytes;
				num = this.count + 1;
				this.count = num;
				array11[num] = (byte)(this.runLength - 4);
				return;
			}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003AD9 File Offset: 0x00001CD9
		public override void Close()
		{
			if (this.closed)
			{
				return;
			}
			this.Finish();
			this.closed = true;
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.bsStream);
			base.Close();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003B04 File Offset: 0x00001D04
		public void Finish()
		{
			if (this.finished)
			{
				return;
			}
			if (this.runLength > 0)
			{
				this.WriteRun();
			}
			this.currentByte = -1;
			if (this.count > 0)
			{
				this.EndBlock();
			}
			this.EndCompression();
			this.finished = true;
			this.Flush();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003B52 File Offset: 0x00001D52
		public override void Flush()
		{
			this.bsStream.Flush();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003B5F File Offset: 0x00001D5F
		private void Initialize()
		{
			this.BsPutUChar(104);
			this.BsPutUChar(48 + this.blockSize100k);
			this.combinedCRC = 0;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003B80 File Offset: 0x00001D80
		private void InitBlock()
		{
			this.mCrc.InitialiseCRC();
			this.count = 0;
			for (int i = 0; i < 256; i++)
			{
				this.inUse[i] = false;
			}
			this.allowableBlockSize = 100000 * this.blockSize100k - 20;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003BD0 File Offset: 0x00001DD0
		private void EndBlock()
		{
			this.blockCRC = this.mCrc.GetFinalCRC();
			this.combinedCRC = (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(this.combinedCRC, 1) ^ this.blockCRC);
			this.DoReversibleTransformation();
			this.BsPutUChar(49);
			this.BsPutUChar(65);
			this.BsPutUChar(89);
			this.BsPutUChar(38);
			this.BsPutUChar(83);
			this.BsPutUChar(89);
			this.BsPutint(this.blockCRC);
			this.BsW(1, this.blockRandomised ? 1 : 0);
			this.MoveToFrontCodeAndSend();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003C64 File Offset: 0x00001E64
		private void EndCompression()
		{
			this.BsPutUChar(23);
			this.BsPutUChar(114);
			this.BsPutUChar(69);
			this.BsPutUChar(56);
			this.BsPutUChar(80);
			this.BsPutUChar(144);
			this.BsPutint(this.combinedCRC);
			this.BsFinishedWithStream();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003CB8 File Offset: 0x00001EB8
		private void HbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize)
		{
			int vec = 0;
			for (int i = minLen; i <= maxLen; i++)
			{
				for (int j = 0; j < alphaSize; j++)
				{
					if ((int)length[j] == i)
					{
						code[j] = vec;
						vec++;
					}
				}
				vec <<= 1;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003CF3 File Offset: 0x00001EF3
		private void BsSetStream(global::System.IO.Stream f)
		{
			this.bsStream = f;
			this.bsLive = 0;
			this.bsBuff = 0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003D0A File Offset: 0x00001F0A
		private void BsFinishedWithStream()
		{
			while (this.bsLive > 0)
			{
				this.bsStream.WriteByte((byte)(this.bsBuff >> 24));
				this.bsBuff <<= 8;
				this.bsLive -= 8;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003D48 File Offset: 0x00001F48
		private void BsW(int n, int v)
		{
			while (this.bsLive >= 8)
			{
				this.bsStream.WriteByte((byte)(this.bsBuff >> 24));
				this.bsBuff <<= 8;
				this.bsLive -= 8;
			}
			this.bsBuff |= v << 32 - this.bsLive - n;
			this.bsLive += n;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003DBC File Offset: 0x00001FBC
		private void BsPutUChar(int c)
		{
			this.BsW(8, c);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003DC6 File Offset: 0x00001FC6
		private void BsPutint(int u)
		{
			this.BsW(16, u >> 16 & 65535);
			this.BsW(16, u & 65535);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003DE9 File Offset: 0x00001FE9
		private void BsPutIntVS(int numBits, int c)
		{
			this.BsW(numBits, c);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003DF4 File Offset: 0x00001FF4
		private void SendMTFValues()
		{
			byte[][] len = global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.InitByteArray(6, 258);
			int nSelectors = 0;
			int alphaSize = this.nInUse + 2;
			for (int t = 0; t < 6; t++)
			{
				byte[] len_t = len[t];
				for (int v = 0; v < alphaSize; v++)
				{
					len_t[v] = 15;
				}
			}
			if (this.nMTF <= 0)
			{
				global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
			}
			int nGroups;
			if (this.nMTF < 200)
			{
				nGroups = 2;
			}
			else if (this.nMTF < 600)
			{
				nGroups = 3;
			}
			else if (this.nMTF < 1200)
			{
				nGroups = 4;
			}
			else if (this.nMTF < 2400)
			{
				nGroups = 5;
			}
			else
			{
				nGroups = 6;
			}
			int nPart = nGroups;
			int remF = this.nMTF;
			int gs = 0;
			while (nPart > 0)
			{
				int tFreq = remF / nPart;
				int ge = gs - 1;
				int aFreq = 0;
				while (aFreq < tFreq && ge < alphaSize - 1)
				{
					aFreq += this.mtfFreq[++ge];
				}
				if (ge > gs && nPart != nGroups && nPart != 1 && (nGroups - nPart) % 2 == 1)
				{
					aFreq -= this.mtfFreq[ge--];
				}
				byte[] len_np = len[nPart - 1];
				for (int v = 0; v < alphaSize; v++)
				{
					if (v >= gs && v <= ge)
					{
						len_np[v] = 0;
					}
					else
					{
						len_np[v] = 15;
					}
				}
				nPart--;
				gs = ge + 1;
				remF -= aFreq;
			}
			int[][] rfreq = global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.InitIntArray(6, 258);
			int[] fave = new int[6];
			short[] cost = new short[6];
			byte[] len_0 = len[0];
			byte[] len_ = len[1];
			byte[] len_2 = len[2];
			byte[] len_3 = len[3];
			byte[] len_4 = len[4];
			byte[] len_5 = len[5];
			for (int iter = 0; iter < 4; iter++)
			{
				for (int t = 0; t < nGroups; t++)
				{
					fave[t] = 0;
					int[] rfreq_t = rfreq[t];
					for (int v = 0; v < alphaSize; v++)
					{
						rfreq_t[v] = 0;
					}
				}
				nSelectors = 0;
				int ge;
				for (gs = 0; gs < this.nMTF; gs = ge + 1)
				{
					ge = global::System.Math.Min(gs + 50 - 1, this.nMTF - 1);
					if (nGroups == 6)
					{
						short cost2 = 0;
						short cost3 = 0;
						short cost4 = 0;
						short cost5 = 0;
						short cost6 = 0;
						short cost7 = 0;
						for (int i = gs; i <= ge; i++)
						{
							int icv = this.szptr[i];
							cost2 += (short)len_0[icv];
							cost3 += (short)len_[icv];
							cost4 += (short)len_2[icv];
							cost5 += (short)len_3[icv];
							cost6 += (short)len_4[icv];
							cost7 += (short)len_5[icv];
						}
						cost[0] = cost2;
						cost[1] = cost3;
						cost[2] = cost4;
						cost[3] = cost5;
						cost[4] = cost6;
						cost[5] = cost7;
					}
					else
					{
						for (int t = 0; t < nGroups; t++)
						{
							cost[t] = 0;
						}
						for (int i = gs; i <= ge; i++)
						{
							int icv2 = this.szptr[i];
							for (int t = 0; t < nGroups; t++)
							{
								short[] array = cost;
								int num = t;
								array[num] += (short)len[t][icv2];
							}
						}
					}
					int bc = 999999999;
					int bt = -1;
					for (int t = 0; t < nGroups; t++)
					{
						if ((int)cost[t] < bc)
						{
							bc = (int)cost[t];
							bt = t;
						}
					}
					fave[bt]++;
					this.selector[nSelectors] = (char)bt;
					nSelectors++;
					int[] rfreq_bt = rfreq[bt];
					for (int i = gs; i <= ge; i++)
					{
						rfreq_bt[this.szptr[i]]++;
					}
				}
				for (int t = 0; t < nGroups; t++)
				{
					global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.HbMakeCodeLengths(len[t], rfreq[t], alphaSize, 20);
				}
			}
			if (nGroups >= 8)
			{
				global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
			}
			if (nSelectors >= 32768 || nSelectors > 18002)
			{
				global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
			}
			char[] pos = new char[6];
			for (int i = 0; i < nGroups; i++)
			{
				pos[i] = (char)i;
			}
			for (int i = 0; i < nSelectors; i++)
			{
				char ll_i = this.selector[i];
				int j = 0;
				char tmp = pos[j];
				while (ll_i != tmp)
				{
					j++;
					char tmp2 = tmp;
					tmp = pos[j];
					pos[j] = tmp2;
				}
				pos[0] = tmp;
				this.selectorMtf[i] = (char)j;
			}
			int[][] code = global::Org.BouncyCastle.Apache.Bzip2.CBZip2InputStream.InitIntArray(6, 258);
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
				if (maxLen > 20)
				{
					global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
				}
				if (minLen < 1)
				{
					global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
				}
				this.HbAssignCodes(code[t], len[t], minLen, maxLen, alphaSize);
			}
			bool[] inUse16 = new bool[16];
			for (int i = 0; i < 16; i++)
			{
				inUse16[i] = false;
				int i2 = i * 16;
				for (int j = 0; j < 16; j++)
				{
					if (this.inUse[i2 + j])
					{
						inUse16[i] = true;
						break;
					}
				}
			}
			for (int i = 0; i < 16; i++)
			{
				this.BsW(1, inUse16[i] ? 1 : 0);
			}
			for (int i = 0; i < 16; i++)
			{
				if (inUse16[i])
				{
					int i3 = i * 16;
					for (int j = 0; j < 16; j++)
					{
						this.BsW(1, this.inUse[i3 + j] ? 1 : 0);
					}
				}
			}
			this.BsW(3, nGroups);
			this.BsW(15, nSelectors);
			for (int i = 0; i < nSelectors; i++)
			{
				int count;
				for (count = (int)this.selectorMtf[i]; count >= 24; count -= 24)
				{
					this.BsW(24, 16777215);
				}
				this.BsW(count + 1, (1 << count + 1) - 2);
			}
			for (int t = 0; t < nGroups; t++)
			{
				byte[] len_t3 = len[t];
				int curr = (int)len_t3[0];
				this.BsW(5, curr);
				for (int i = 0; i < alphaSize; i++)
				{
					int lti2 = (int)len_t3[i];
					while (curr < lti2)
					{
						this.BsW(2, 2);
						curr++;
					}
					while (curr > lti2)
					{
						this.BsW(2, 3);
						curr--;
					}
					this.BsW(1, 0);
				}
			}
			int selCtr = 0;
			gs = 0;
			while (gs < this.nMTF)
			{
				int ge = global::System.Math.Min(gs + 50 - 1, this.nMTF - 1);
				int selector_selCtr = (int)this.selector[selCtr];
				byte[] len_selCtr = len[selector_selCtr];
				int[] code_selCtr = code[selector_selCtr];
				for (int i = gs; i <= ge; i++)
				{
					int sfmap_i = this.szptr[i];
					this.BsW((int)len_selCtr[sfmap_i], code_selCtr[sfmap_i]);
				}
				gs = ge + 1;
				selCtr++;
			}
			if (selCtr != nSelectors)
			{
				global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000446A File Offset: 0x0000266A
		private void MoveToFrontCodeAndSend()
		{
			this.BsPutIntVS(24, this.origPtr);
			this.GenerateMTFValues();
			this.SendMTFValues();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004488 File Offset: 0x00002688
		private void SimpleSort(int lo, int hi, int d)
		{
			int bigN = hi - lo + 1;
			if (bigN < 2)
			{
				return;
			}
			int hp = 0;
			while (global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.incs[hp] < bigN)
			{
				hp++;
			}
			for (hp--; hp >= 0; hp--)
			{
				int h = global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.incs[hp];
				int i = lo + h;
				while (i <= hi)
				{
					int v = this.zptr[i];
					int j = i;
					while (this.FullGtU(this.zptr[j - h] + d, v + d))
					{
						this.zptr[j] = this.zptr[j - h];
						j -= h;
						if (j <= lo + h - 1)
						{
							break;
						}
					}
					this.zptr[j] = v;
					if (++i > hi)
					{
						break;
					}
					v = this.zptr[i];
					j = i;
					while (this.FullGtU(this.zptr[j - h] + d, v + d))
					{
						this.zptr[j] = this.zptr[j - h];
						j -= h;
						if (j <= lo + h - 1)
						{
							break;
						}
					}
					this.zptr[j] = v;
					if (++i > hi)
					{
						break;
					}
					v = this.zptr[i];
					j = i;
					while (this.FullGtU(this.zptr[j - h] + d, v + d))
					{
						this.zptr[j] = this.zptr[j - h];
						j -= h;
						if (j <= lo + h - 1)
						{
							break;
						}
					}
					this.zptr[j] = v;
					i++;
					if (this.workDone > this.workLimit && this.firstAttempt)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000045FC File Offset: 0x000027FC
		private void Vswap(int p1, int p2, int n)
		{
			while (--n >= 0)
			{
				int t = this.zptr[p1];
				int t2 = this.zptr[p2];
				this.zptr[p1++] = t2;
				this.zptr[p2++] = t;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004642 File Offset: 0x00002842
		private int Med3(int a, int b, int c)
		{
			if (a <= b)
			{
				if (c < a)
				{
					return a;
				}
				if (c <= b)
				{
					return c;
				}
				return b;
			}
			else
			{
				if (c < b)
				{
					return b;
				}
				if (c <= a)
				{
					return c;
				}
				return a;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004664 File Offset: 0x00002864
		private static void PushStackElem(global::System.Collections.IList stack, int stackCount, int ll, int hh, int dd)
		{
			global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.StackElem stackElem;
			if (stackCount < stack.Count)
			{
				stackElem = (global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.StackElem)stack[stackCount];
			}
			else
			{
				stackElem = new global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.StackElem();
				stack.Add(stackElem);
			}
			stackElem.ll = ll;
			stackElem.hh = hh;
			stackElem.dd = dd;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000046B0 File Offset: 0x000028B0
		private void QSort3(int loSt, int hiSt, int dSt)
		{
			global::System.Collections.IList stack = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			int stackCount = 0;
			int lo = loSt;
			int hi = hiSt;
			int d = dSt;
			for (;;)
			{
				if (hi - lo < 20 || d > 10)
				{
					this.SimpleSort(lo, hi, d);
					if (stackCount < 1 || (this.workDone > this.workLimit && this.firstAttempt))
					{
						break;
					}
					global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.StackElem stackElem = (global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.StackElem)stack[--stackCount];
					lo = stackElem.ll;
					hi = stackElem.hh;
					d = stackElem.dd;
				}
				else
				{
					int d2 = d + 1;
					int med = this.Med3((int)this.blockBytes[this.zptr[lo] + d2], (int)this.blockBytes[this.zptr[hi] + d2], (int)this.blockBytes[this.zptr[lo + hi >> 1] + d2]);
					int unLo;
					int ltLo = unLo = lo;
					int unHi;
					int gtHi = unHi = hi;
					for (;;)
					{
						if (unLo <= unHi)
						{
							int zUnLo = this.zptr[unLo];
							int i = (int)this.blockBytes[zUnLo + d2] - med;
							if (i <= 0)
							{
								if (i == 0)
								{
									this.zptr[unLo] = this.zptr[ltLo];
									this.zptr[ltLo++] = zUnLo;
								}
								unLo++;
								continue;
							}
						}
						while (unLo <= unHi)
						{
							int zUnHi = this.zptr[unHi];
							int i = (int)this.blockBytes[zUnHi + d2] - med;
							if (i < 0)
							{
								break;
							}
							if (i == 0)
							{
								this.zptr[unHi] = this.zptr[gtHi];
								this.zptr[gtHi--] = zUnHi;
							}
							unHi--;
						}
						if (unLo > unHi)
						{
							break;
						}
						int temp = this.zptr[unLo];
						this.zptr[unLo++] = this.zptr[unHi];
						this.zptr[unHi--] = temp;
					}
					if (gtHi < ltLo)
					{
						d = d2;
					}
					else
					{
						int i = global::System.Math.Min(ltLo - lo, unLo - ltLo);
						this.Vswap(lo, unLo - i, i);
						int j = global::System.Math.Min(hi - gtHi, gtHi - unHi);
						this.Vswap(unLo, hi - j + 1, j);
						i = lo + (unLo - ltLo);
						j = hi - (gtHi - unHi);
						global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.PushStackElem(stack, stackCount++, lo, i - 1, d);
						global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.PushStackElem(stack, stackCount++, i, j, d2);
						lo = j + 1;
					}
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000048E4 File Offset: 0x00002AE4
		private void MainSort()
		{
			int[] runningOrder = new int[256];
			int[] copy = new int[256];
			bool[] bigDone = new bool[256];
			for (int i = 0; i < 20; i++)
			{
				this.blockBytes[this.count + i + 1] = this.blockBytes[i % this.count + 1];
			}
			for (int i = 0; i <= this.count + 20; i++)
			{
				this.quadrantShorts[i] = 0;
			}
			this.blockBytes[0] = this.blockBytes[this.count];
			if (this.count <= 4000)
			{
				for (int i = 0; i < this.count; i++)
				{
					this.zptr[i] = i;
				}
				this.firstAttempt = false;
				this.workDone = (this.workLimit = 0);
				this.SimpleSort(0, this.count - 1, 0);
				return;
			}
			for (int i = 0; i <= 255; i++)
			{
				bigDone[i] = false;
			}
			for (int i = 0; i <= 65536; i++)
			{
				this.ftab[i] = 0;
			}
			int c = (int)this.blockBytes[0];
			for (int i = 1; i <= this.count; i++)
			{
				int c2 = (int)this.blockBytes[i];
				this.ftab[(c << 8) + c2]++;
				c = c2;
			}
			for (int i = 0; i < 65536; i++)
			{
				this.ftab[i + 1] += this.ftab[i];
			}
			c = (int)this.blockBytes[1];
			int j;
			for (int i = 0; i < this.count - 1; i++)
			{
				int c2 = (int)this.blockBytes[i + 2];
				j = (c << 8) + c2;
				c = c2;
				this.ftab[j]--;
				this.zptr[this.ftab[j]] = i;
			}
			j = ((int)this.blockBytes[this.count] << 8) + (int)this.blockBytes[1];
			this.ftab[j]--;
			this.zptr[this.ftab[j]] = this.count - 1;
			for (int i = 0; i <= 255; i++)
			{
				runningOrder[i] = i;
			}
			int h = 1;
			do
			{
				h = 3 * h + 1;
			}
			while (h <= 256);
			do
			{
				h /= 3;
				for (int i = h; i <= 255; i++)
				{
					int vv = runningOrder[i];
					j = i;
					while (this.ftab[runningOrder[j - h] + 1 << 8] - this.ftab[runningOrder[j - h] << 8] > this.ftab[vv + 1 << 8] - this.ftab[vv << 8])
					{
						runningOrder[j] = runningOrder[j - h];
						j -= h;
						if (j < h)
						{
							break;
						}
					}
					runningOrder[j] = vv;
				}
			}
			while (h != 1);
			for (int i = 0; i <= 255; i++)
			{
				int ss = runningOrder[i];
				for (j = 0; j <= 255; j++)
				{
					int sb = (ss << 8) + j;
					if ((this.ftab[sb] & 2097152) != 2097152)
					{
						int lo = this.ftab[sb] & -2097153;
						int hi = (this.ftab[sb + 1] & -2097153) - 1;
						if (hi > lo)
						{
							this.QSort3(lo, hi, 2);
							if (this.workDone > this.workLimit && this.firstAttempt)
							{
								return;
							}
						}
						this.ftab[sb] |= 2097152;
					}
				}
				bigDone[ss] = true;
				if (i < 255)
				{
					int bbStart = this.ftab[ss << 8] & -2097153;
					int bbSize = (this.ftab[ss + 1 << 8] & -2097153) - bbStart;
					int shifts = 0;
					while (bbSize >> shifts > 65534)
					{
						shifts++;
					}
					for (j = 0; j < bbSize; j++)
					{
						int a2update = this.zptr[bbStart + j] + 1;
						ushort qVal = (ushort)(j >> shifts);
						this.quadrantShorts[a2update] = qVal;
						if (a2update <= 20)
						{
							this.quadrantShorts[a2update + this.count] = qVal;
						}
					}
					if (bbSize - 1 >> shifts > 65535)
					{
						global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
					}
				}
				for (j = 0; j <= 255; j++)
				{
					copy[j] = (this.ftab[(j << 8) + ss] & -2097153);
				}
				for (j = (this.ftab[ss << 8] & -2097153); j < (this.ftab[ss + 1 << 8] & -2097153); j++)
				{
					int zptr_j = this.zptr[j];
					c = (int)this.blockBytes[zptr_j];
					if (!bigDone[c])
					{
						this.zptr[copy[c]] = ((zptr_j == 0) ? this.count : zptr_j) - 1;
						copy[c]++;
					}
				}
				for (j = 0; j <= 255; j++)
				{
					this.ftab[(j << 8) + ss] |= 2097152;
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004DC0 File Offset: 0x00002FC0
		private void RandomiseBlock()
		{
			for (int i = 0; i < 256; i++)
			{
				this.inUse[i] = false;
			}
			int rNToGo = 0;
			int rTPos = 0;
			for (int j = 0; j < this.count; j++)
			{
				if (rNToGo == 0)
				{
					rNToGo = global::Org.BouncyCastle.Apache.Bzip2.BZip2Constants.rNums[rTPos];
					if (++rTPos == 512)
					{
						rTPos = 0;
					}
				}
				rNToGo--;
				byte[] array = this.blockBytes;
				int num = j + 1;
				array[num] ^= ((rNToGo == 1) ? 1 : 0);
				this.inUse[(int)this.blockBytes[j + 1]] = true;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004E48 File Offset: 0x00003048
		private void DoReversibleTransformation()
		{
			this.workLimit = this.workFactor * (this.count - 1);
			this.workDone = 0;
			this.blockRandomised = false;
			this.firstAttempt = true;
			this.MainSort();
			if (this.workDone > this.workLimit && this.firstAttempt)
			{
				this.RandomiseBlock();
				this.workLimit = (this.workDone = 0);
				this.blockRandomised = true;
				this.firstAttempt = false;
				this.MainSort();
			}
			this.origPtr = -1;
			for (int i = 0; i < this.count; i++)
			{
				if (this.zptr[i] == 0)
				{
					this.origPtr = i;
					break;
				}
			}
			if (this.origPtr == -1)
			{
				global::Org.BouncyCastle.Apache.Bzip2.CBZip2OutputStream.Panic();
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004F00 File Offset: 0x00003100
		private bool FullGtU(int i1, int i2)
		{
			int c = (int)this.blockBytes[++i1];
			int c2 = (int)this.blockBytes[++i2];
			if (c != c2)
			{
				return c > c2;
			}
			c = (int)this.blockBytes[++i1];
			c2 = (int)this.blockBytes[++i2];
			if (c != c2)
			{
				return c > c2;
			}
			c = (int)this.blockBytes[++i1];
			c2 = (int)this.blockBytes[++i2];
			if (c != c2)
			{
				return c > c2;
			}
			c = (int)this.blockBytes[++i1];
			c2 = (int)this.blockBytes[++i2];
			if (c != c2)
			{
				return c > c2;
			}
			c = (int)this.blockBytes[++i1];
			c2 = (int)this.blockBytes[++i2];
			if (c != c2)
			{
				return c > c2;
			}
			c = (int)this.blockBytes[++i1];
			c2 = (int)this.blockBytes[++i2];
			if (c != c2)
			{
				return c > c2;
			}
			int j = this.count;
			int s;
			int s2;
			for (;;)
			{
				c = (int)this.blockBytes[++i1];
				c2 = (int)this.blockBytes[++i2];
				if (c != c2)
				{
					break;
				}
				s = (int)this.quadrantShorts[i1];
				s2 = (int)this.quadrantShorts[i2];
				if (s != s2)
				{
					goto Block_8;
				}
				c = (int)this.blockBytes[++i1];
				c2 = (int)this.blockBytes[++i2];
				if (c != c2)
				{
					goto Block_9;
				}
				s = (int)this.quadrantShorts[i1];
				s2 = (int)this.quadrantShorts[i2];
				if (s != s2)
				{
					goto Block_10;
				}
				c = (int)this.blockBytes[++i1];
				c2 = (int)this.blockBytes[++i2];
				if (c != c2)
				{
					goto Block_11;
				}
				s = (int)this.quadrantShorts[i1];
				s2 = (int)this.quadrantShorts[i2];
				if (s != s2)
				{
					goto Block_12;
				}
				c = (int)this.blockBytes[++i1];
				c2 = (int)this.blockBytes[++i2];
				if (c != c2)
				{
					goto Block_13;
				}
				s = (int)this.quadrantShorts[i1];
				s2 = (int)this.quadrantShorts[i2];
				if (s != s2)
				{
					goto Block_14;
				}
				if (i1 >= this.count)
				{
					i1 -= this.count;
				}
				if (i2 >= this.count)
				{
					i2 -= this.count;
				}
				j -= 4;
				this.workDone++;
				if (j < 0)
				{
					return false;
				}
			}
			return c > c2;
			Block_8:
			return s > s2;
			Block_9:
			return c > c2;
			Block_10:
			return s > s2;
			Block_11:
			return c > c2;
			Block_12:
			return s > s2;
			Block_13:
			return c > c2;
			Block_14:
			return s > s2;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005140 File Offset: 0x00003340
		private void AllocateCompressStructures()
		{
			int i = 100000 * this.blockSize100k;
			this.blockBytes = new byte[i + 1 + 20];
			this.quadrantShorts = new ushort[i + 1 + 20];
			this.zptr = new int[i];
			this.ftab = new int[65537];
			this.szptr = this.zptr;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000051A4 File Offset: 0x000033A4
		private void GenerateMTFValues()
		{
			char[] yy = new char[256];
			this.MakeMaps();
			int EOB = this.nInUse + 1;
			for (int i = 0; i <= EOB; i++)
			{
				this.mtfFreq[i] = 0;
			}
			int wr = 0;
			int zPend = 0;
			for (int i = 0; i < this.nInUse; i++)
			{
				yy[i] = (char)i;
			}
			for (int i = 0; i < this.count; i++)
			{
				char ll_i = this.unseqToSeq[(int)this.blockBytes[this.zptr[i]]];
				int j = 0;
				char tmp = yy[j];
				while (ll_i != tmp)
				{
					j++;
					char tmp2 = tmp;
					tmp = yy[j];
					yy[j] = tmp2;
				}
				yy[0] = tmp;
				if (j == 0)
				{
					zPend++;
				}
				else
				{
					if (zPend > 0)
					{
						zPend--;
						for (;;)
						{
							int num = zPend % 2;
							if (num != 0)
							{
								if (num == 1)
								{
									this.szptr[wr++] = 1;
									this.mtfFreq[1]++;
								}
							}
							else
							{
								this.szptr[wr++] = 0;
								this.mtfFreq[0]++;
							}
							if (zPend < 2)
							{
								break;
							}
							zPend = (zPend - 2) / 2;
						}
						zPend = 0;
					}
					this.szptr[wr++] = j + 1;
					this.mtfFreq[j + 1]++;
				}
			}
			if (zPend > 0)
			{
				zPend--;
				for (;;)
				{
					int num = zPend % 2;
					if (num != 0)
					{
						if (num == 1)
						{
							this.szptr[wr++] = 1;
							this.mtfFreq[1]++;
						}
					}
					else
					{
						this.szptr[wr++] = 0;
						this.mtfFreq[0]++;
					}
					if (zPend < 2)
					{
						break;
					}
					zPend = (zPend - 2) / 2;
				}
			}
			this.szptr[wr++] = EOB;
			this.mtfFreq[EOB]++;
			this.nMTF = wr;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005387 File Offset: 0x00003587
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000538A File Offset: 0x0000358A
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000538E File Offset: 0x0000358E
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005390 File Offset: 0x00003590
		public override void Write(byte[] buffer, int offset, int count)
		{
			for (int i = 0; i < count; i++)
			{
				this.WriteByte(buffer[i + offset]);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000053B4 File Offset: 0x000035B4
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000053B7 File Offset: 0x000035B7
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000053BA File Offset: 0x000035BA
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000053BD File Offset: 0x000035BD
		public override long Length
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000053C1 File Offset: 0x000035C1
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000053C5 File Offset: 0x000035C5
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

		// Token: 0x04000049 RID: 73
		protected const int SETMASK = 2097152;

		// Token: 0x0400004A RID: 74
		protected const int CLEARMASK = -2097153;

		// Token: 0x0400004B RID: 75
		protected const int GREATER_ICOST = 15;

		// Token: 0x0400004C RID: 76
		protected const int LESSER_ICOST = 0;

		// Token: 0x0400004D RID: 77
		protected const int SMALL_THRESH = 20;

		// Token: 0x0400004E RID: 78
		protected const int DEPTH_THRESH = 10;

		// Token: 0x0400004F RID: 79
		private bool finished;

		// Token: 0x04000050 RID: 80
		private int count;

		// Token: 0x04000051 RID: 81
		private int origPtr;

		// Token: 0x04000052 RID: 82
		private readonly int blockSize100k;

		// Token: 0x04000053 RID: 83
		private int allowableBlockSize;

		// Token: 0x04000054 RID: 84
		private bool blockRandomised;

		// Token: 0x04000055 RID: 85
		private int bsBuff;

		// Token: 0x04000056 RID: 86
		private int bsLive;

		// Token: 0x04000057 RID: 87
		private readonly global::Org.BouncyCastle.Apache.Bzip2.CRC mCrc = new global::Org.BouncyCastle.Apache.Bzip2.CRC();

		// Token: 0x04000058 RID: 88
		private bool[] inUse = new bool[256];

		// Token: 0x04000059 RID: 89
		private int nInUse;

		// Token: 0x0400005A RID: 90
		private char[] seqToUnseq = new char[256];

		// Token: 0x0400005B RID: 91
		private char[] unseqToSeq = new char[256];

		// Token: 0x0400005C RID: 92
		private char[] selector = new char[18002];

		// Token: 0x0400005D RID: 93
		private char[] selectorMtf = new char[18002];

		// Token: 0x0400005E RID: 94
		private byte[] blockBytes;

		// Token: 0x0400005F RID: 95
		private ushort[] quadrantShorts;

		// Token: 0x04000060 RID: 96
		private int[] zptr;

		// Token: 0x04000061 RID: 97
		private int[] szptr;

		// Token: 0x04000062 RID: 98
		private int[] ftab;

		// Token: 0x04000063 RID: 99
		private int nMTF;

		// Token: 0x04000064 RID: 100
		private int[] mtfFreq = new int[258];

		// Token: 0x04000065 RID: 101
		private int workFactor;

		// Token: 0x04000066 RID: 102
		private int workDone;

		// Token: 0x04000067 RID: 103
		private int workLimit;

		// Token: 0x04000068 RID: 104
		private bool firstAttempt;

		// Token: 0x04000069 RID: 105
		private int currentByte = -1;

		// Token: 0x0400006A RID: 106
		private int runLength;

		// Token: 0x0400006B RID: 107
		private bool closed;

		// Token: 0x0400006C RID: 108
		private int blockCRC;

		// Token: 0x0400006D RID: 109
		private int combinedCRC;

		// Token: 0x0400006E RID: 110
		private global::System.IO.Stream bsStream;

		// Token: 0x0400006F RID: 111
		private static readonly int[] incs = new int[]
		{
			1,
			4,
			13,
			40,
			121,
			364,
			1093,
			3280,
			9841,
			29524,
			88573,
			265720,
			797161,
			2391484
		};

		// Token: 0x02000798 RID: 1944
		internal class StackElem
		{
			// Token: 0x040022D9 RID: 8921
			internal int ll;

			// Token: 0x040022DA RID: 8922
			internal int hh;

			// Token: 0x040022DB RID: 8923
			internal int dd;
		}
	}
}
