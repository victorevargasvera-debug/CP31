using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004CA RID: 1226
	public class Dstu7564Digest : global::Org.BouncyCastle.Crypto.IDigest, global::Org.BouncyCastle.Utilities.IMemoable
	{
		// Token: 0x06002F99 RID: 12185 RVA: 0x000DE057 File Offset: 0x000DC257
		public Dstu7564Digest(global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest digest)
		{
			this.CopyIn(digest);
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x000DE068 File Offset: 0x000DC268
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest digest)
		{
			this.hashSize = digest.hashSize;
			this.blockSize = digest.blockSize;
			this.rounds = digest.rounds;
			if (this.columns > 0 && this.columns == digest.columns)
			{
				global::System.Array.Copy(digest.state, 0, this.state, 0, this.columns);
				global::System.Array.Copy(digest.buf, 0, this.buf, 0, this.blockSize);
			}
			else
			{
				this.columns = digest.columns;
				this.state = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.state);
				this.tempState1 = new ulong[this.columns];
				this.tempState2 = new ulong[this.columns];
				this.buf = global::Org.BouncyCastle.Utilities.Arrays.Clone(digest.buf);
			}
			this.inputBlocks = digest.inputBlocks;
			this.bufOff = digest.bufOff;
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x000DE14C File Offset: 0x000DC34C
		public Dstu7564Digest(int hashSizeBits)
		{
			if (hashSizeBits == 256 || hashSizeBits == 384 || hashSizeBits == 512)
			{
				this.hashSize = hashSizeBits / 8;
				if (hashSizeBits > 256)
				{
					this.columns = 16;
					this.rounds = 14;
				}
				else
				{
					this.columns = 8;
					this.rounds = 10;
				}
				this.blockSize = this.columns << 3;
				this.state = new ulong[this.columns];
				this.state[0] = (ulong)((long)this.blockSize);
				this.tempState1 = new ulong[this.columns];
				this.tempState2 = new ulong[this.columns];
				this.buf = new byte[this.blockSize];
				return;
			}
			throw new global::System.ArgumentException("Hash size is not recommended. Use 256/384/512 instead");
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x000DE217 File Offset: 0x000DC417
		public virtual string AlgorithmName
		{
			get
			{
				return "DSTU7564";
			}
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x000DE21E File Offset: 0x000DC41E
		public virtual int GetDigestSize()
		{
			return this.hashSize;
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x000DE226 File Offset: 0x000DC426
		public virtual int GetByteLength()
		{
			return this.blockSize;
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x000DE230 File Offset: 0x000DC430
		public virtual void Update(byte input)
		{
			byte[] array = this.buf;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = input;
			if (this.bufOff == this.blockSize)
			{
				this.ProcessBlock(this.buf, 0);
				this.bufOff = 0;
				this.inputBlocks += 1UL;
			}
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x000DE288 File Offset: 0x000DC488
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
			while (this.bufOff != 0 && length > 0)
			{
				this.Update(input[inOff++]);
				length--;
			}
			if (length > 0)
			{
				while (length >= this.blockSize)
				{
					this.ProcessBlock(input, inOff);
					inOff += this.blockSize;
					length -= this.blockSize;
					this.inputBlocks += 1UL;
				}
				while (length > 0)
				{
					this.Update(input[inOff++]);
					length--;
				}
			}
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x000DE30C File Offset: 0x000DC50C
		public virtual int DoFinal(byte[] output, int outOff)
		{
			int inputBytes = this.bufOff;
			byte[] array = this.buf;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = 128;
			int lenPos = this.blockSize - 12;
			if (this.bufOff > lenPos)
			{
				while (this.bufOff < this.blockSize)
				{
					byte[] array2 = this.buf;
					num = this.bufOff;
					this.bufOff = num + 1;
					array2[num] = 0;
				}
				this.bufOff = 0;
				this.ProcessBlock(this.buf, 0);
			}
			while (this.bufOff < lenPos)
			{
				byte[] array3 = this.buf;
				num = this.bufOff;
				this.bufOff = num + 1;
				array3[num] = 0;
			}
			ulong num2 = (this.inputBlocks & (ulong)-1) * (ulong)((long)this.blockSize) + (ulong)inputBytes << 3;
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)num2, this.buf, this.bufOff);
			this.bufOff += 4;
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE((num2 >> 32) + ((this.inputBlocks >> 32) * (ulong)((long)this.blockSize) << 3), this.buf, this.bufOff);
			this.ProcessBlock(this.buf, 0);
			global::System.Array.Copy(this.state, 0, this.tempState1, 0, this.columns);
			this.P(this.tempState1);
			for (int col = 0; col < this.columns; col++)
			{
				this.state[col] ^= this.tempState1[col];
			}
			int neededColumns = this.hashSize / 8;
			for (int col2 = this.columns - neededColumns; col2 < this.columns; col2++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(this.state[col2], output, outOff);
				outOff += 8;
			}
			this.Reset();
			return this.hashSize;
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x000DE4B7 File Offset: 0x000DC6B7
		public virtual void Reset()
		{
			global::System.Array.Clear(this.state, 0, this.state.Length);
			this.state[0] = (ulong)((long)this.blockSize);
			this.inputBlocks = 0UL;
			this.bufOff = 0;
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x000DE4EC File Offset: 0x000DC6EC
		protected virtual void ProcessBlock(byte[] input, int inOff)
		{
			int pos = inOff;
			for (int col = 0; col < this.columns; col++)
			{
				ulong word = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(input, pos);
				pos += 8;
				this.tempState1[col] = (this.state[col] ^ word);
				this.tempState2[col] = word;
			}
			this.P(this.tempState1);
			this.Q(this.tempState2);
			for (int col2 = 0; col2 < this.columns; col2++)
			{
				this.state[col2] ^= (this.tempState1[col2] ^ this.tempState2[col2]);
			}
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x000DE580 File Offset: 0x000DC780
		private void P(ulong[] s)
		{
			for (int round = 0; round < this.rounds; round++)
			{
				ulong rc = (ulong)((long)round);
				for (int col = 0; col < this.columns; col++)
				{
					s[col] ^= rc;
					rc += 16UL;
				}
				this.ShiftRows(s);
				this.SubBytes(s);
				this.MixColumns(s);
			}
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000DE5DC File Offset: 0x000DC7DC
		private void Q(ulong[] s)
		{
			for (int round = 0; round < this.rounds; round++)
			{
				ulong rc = (ulong)((long)(this.columns - 1 << 4 ^ round) << 56 | 67818912035696883L);
				for (int col = 0; col < this.columns; col++)
				{
					s[col] += rc;
					rc -= 1152921504606846976UL;
				}
				this.ShiftRows(s);
				this.SubBytes(s);
				this.MixColumns(s);
			}
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x000DE654 File Offset: 0x000DC854
		private static ulong MixColumn(ulong c)
		{
			ulong x = (c & 9187201950435737471UL) << 1 ^ ((c & 9259542123273814144UL) >> 7) * 29UL;
			ulong u = global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.Rotate(8, c) ^ c;
			u ^= global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.Rotate(16, u);
			u ^= global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.Rotate(48, c);
			ulong v = u ^ c ^ x;
			v = ((v & 4557430888798830399UL) << 2 ^ ((v & 9259542123273814144UL) >> 6) * 29UL ^ ((v & 4629771061636907072UL) >> 6) * 29UL);
			return u ^ global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.Rotate(32, v) ^ global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.Rotate(40, x) ^ global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.Rotate(48, x);
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x000DE6F8 File Offset: 0x000DC8F8
		private void MixColumns(ulong[] s)
		{
			for (int col = 0; col < this.columns; col++)
			{
				s[col] = global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.MixColumn(s[col]);
			}
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x000DE721 File Offset: 0x000DC921
		private static ulong Rotate(int n, ulong x)
		{
			return x >> n | x << -n;
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x000DE734 File Offset: 0x000DC934
		private void ShiftRows(ulong[] s)
		{
			int num = this.columns;
			if (num == 8)
			{
				ulong c0 = s[0];
				ulong c = s[1];
				ulong c2 = s[2];
				ulong c3 = s[3];
				ulong c4 = s[4];
				ulong c5 = s[5];
				ulong c6 = s[6];
				ulong c7 = s[7];
				ulong d = (c0 ^ c4) & 18446744069414584320UL;
				c0 ^= d;
				c4 ^= d;
				d = ((c ^ c5) & 72057594021150720UL);
				c ^= d;
				c5 ^= d;
				d = ((c2 ^ c6) & 281474976645120UL);
				c2 ^= d;
				c6 ^= d;
				d = ((c3 ^ c7) & 1099511627520UL);
				c3 ^= d;
				c7 ^= d;
				d = ((c0 ^ c2) & 18446462603027742720UL);
				c0 ^= d;
				c2 ^= d;
				d = ((c ^ c3) & 72056494543077120UL);
				c ^= d;
				c3 ^= d;
				d = ((c4 ^ c6) & 18446462603027742720UL);
				c4 ^= d;
				c6 ^= d;
				d = ((c5 ^ c7) & 72056494543077120UL);
				c5 ^= d;
				c7 ^= d;
				d = ((c0 ^ c) & 18374966859414961920UL);
				c0 ^= d;
				c ^= d;
				d = ((c2 ^ c3) & 18374966859414961920UL);
				c2 ^= d;
				c3 ^= d;
				d = ((c4 ^ c5) & 18374966859414961920UL);
				c4 ^= d;
				c5 ^= d;
				d = ((c6 ^ c7) & 18374966859414961920UL);
				c6 ^= d;
				c7 ^= d;
				s[0] = c0;
				s[1] = c;
				s[2] = c2;
				s[3] = c3;
				s[4] = c4;
				s[5] = c5;
				s[6] = c6;
				s[7] = c7;
				return;
			}
			if (num != 16)
			{
				throw new global::System.InvalidOperationException("unsupported state size: only 512/1024 are allowed");
			}
			ulong c8 = s[0];
			ulong c9 = s[1];
			ulong c10 = s[2];
			ulong c11 = s[3];
			ulong c12 = s[4];
			ulong c13 = s[5];
			ulong c14 = s[6];
			ulong c15 = s[7];
			ulong c16 = s[8];
			ulong c17 = s[9];
			ulong c18 = s[10];
			ulong c19 = s[11];
			ulong c20 = s[12];
			ulong c21 = s[13];
			ulong c22 = s[14];
			ulong c23 = s[15];
			ulong d2 = (c8 ^ c16) & 18374686479671623680UL;
			c8 ^= d2;
			c16 ^= d2;
			d2 = ((c9 ^ c17) & 18374686479671623680UL);
			c9 ^= d2;
			c17 ^= d2;
			d2 = ((c10 ^ c18) & 18446462598732840960UL);
			c10 ^= d2;
			c18 ^= d2;
			d2 = ((c11 ^ c19) & 18446742974197923840UL);
			c11 ^= d2;
			c19 ^= d2;
			d2 = ((c12 ^ c20) & 18446744069414584320UL);
			c12 ^= d2;
			c20 ^= d2;
			d2 = ((c13 ^ c21) & 72057594021150720UL);
			c13 ^= d2;
			c21 ^= d2;
			d2 = ((c14 ^ c22) & 72057594037862400UL);
			c14 ^= d2;
			c22 ^= d2;
			d2 = ((c15 ^ c23) & 72057594037927680UL);
			c15 ^= d2;
			c23 ^= d2;
			d2 = ((c8 ^ c12) & 72057589742960640UL);
			c8 ^= d2;
			c12 ^= d2;
			d2 = ((c9 ^ c13) & 18446744073692774400UL);
			c9 ^= d2;
			c13 ^= d2;
			d2 = ((c10 ^ c14) & 18374967954648268800UL);
			c10 ^= d2;
			c14 ^= d2;
			d2 = ((c11 ^ c15) & 18374687579183251200UL);
			c11 ^= d2;
			c15 ^= d2;
			d2 = ((c16 ^ c20) & 72057589742960640UL);
			c16 ^= d2;
			c20 ^= d2;
			d2 = ((c17 ^ c21) & 18446744073692774400UL);
			c17 ^= d2;
			c21 ^= d2;
			d2 = ((c18 ^ c22) & 18374967954648268800UL);
			c18 ^= d2;
			c22 ^= d2;
			d2 = ((c19 ^ c23) & 18374687579183251200UL);
			c19 ^= d2;
			c23 ^= d2;
			d2 = ((c8 ^ c10) & 18446462603027742720UL);
			c8 ^= d2;
			c10 ^= d2;
			d2 = ((c9 ^ c11) & 72056494543077120UL);
			c9 ^= d2;
			c11 ^= d2;
			d2 = ((c12 ^ c14) & 18446462603027742720UL);
			c12 ^= d2;
			c14 ^= d2;
			d2 = ((c13 ^ c15) & 72056494543077120UL);
			c13 ^= d2;
			c15 ^= d2;
			d2 = ((c16 ^ c18) & 18446462603027742720UL);
			c16 ^= d2;
			c18 ^= d2;
			d2 = ((c17 ^ c19) & 72056494543077120UL);
			c17 ^= d2;
			c19 ^= d2;
			d2 = ((c20 ^ c22) & 18446462603027742720UL);
			c20 ^= d2;
			c22 ^= d2;
			d2 = ((c21 ^ c23) & 72056494543077120UL);
			c21 ^= d2;
			c23 ^= d2;
			d2 = ((c8 ^ c9) & 18374966859414961920UL);
			c8 ^= d2;
			c9 ^= d2;
			d2 = ((c10 ^ c11) & 18374966859414961920UL);
			c10 ^= d2;
			c11 ^= d2;
			d2 = ((c12 ^ c13) & 18374966859414961920UL);
			c12 ^= d2;
			c13 ^= d2;
			d2 = ((c14 ^ c15) & 18374966859414961920UL);
			c14 ^= d2;
			c15 ^= d2;
			d2 = ((c16 ^ c17) & 18374966859414961920UL);
			c16 ^= d2;
			c17 ^= d2;
			d2 = ((c18 ^ c19) & 18374966859414961920UL);
			c18 ^= d2;
			c19 ^= d2;
			d2 = ((c20 ^ c21) & 18374966859414961920UL);
			c20 ^= d2;
			c21 ^= d2;
			d2 = ((c22 ^ c23) & 18374966859414961920UL);
			c22 ^= d2;
			c23 ^= d2;
			s[0] = c8;
			s[1] = c9;
			s[2] = c10;
			s[3] = c11;
			s[4] = c12;
			s[5] = c13;
			s[6] = c14;
			s[7] = c15;
			s[8] = c16;
			s[9] = c17;
			s[10] = c18;
			s[11] = c19;
			s[12] = c20;
			s[13] = c21;
			s[14] = c22;
			s[15] = c23;
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x000DED90 File Offset: 0x000DCF90
		private void SubBytes(ulong[] s)
		{
			for (int i = 0; i < this.columns; i++)
			{
				ulong num = s[i];
				uint lo = (uint)num;
				uint hi = (uint)(num >> 32);
				uint num2 = (uint)global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.S0[(int)(lo & 255U)];
				byte t = global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.S1[(int)(lo >> 8 & 255U)];
				byte t2 = global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.S2[(int)(lo >> 16 & 255U)];
				byte t3 = global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.S3[(int)(lo >> 24)];
				lo = (num2 | (uint)((uint)t << 8) | (uint)((uint)t2 << 16) | (uint)((uint)t3 << 24));
				uint num3 = (uint)global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.S0[(int)(hi & 255U)];
				byte t4 = global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.S1[(int)(hi >> 8 & 255U)];
				byte t5 = global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.S2[(int)(hi >> 16 & 255U)];
				byte t6 = global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest.S3[(int)(hi >> 24)];
				hi = (num3 | (uint)((uint)t4 << 8) | (uint)((uint)t5 << 16) | (uint)((uint)t6 << 24));
				s[i] = ((ulong)lo | (ulong)hi << 32);
			}
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x000DEE64 File Offset: 0x000DD064
		public virtual global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest(this);
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x000DEE6C File Offset: 0x000DD06C
		public virtual void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest d = (global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x04001483 RID: 5251
		private const int NB_512 = 8;

		// Token: 0x04001484 RID: 5252
		private const int NB_1024 = 16;

		// Token: 0x04001485 RID: 5253
		private const int NR_512 = 10;

		// Token: 0x04001486 RID: 5254
		private const int NR_1024 = 14;

		// Token: 0x04001487 RID: 5255
		private int hashSize;

		// Token: 0x04001488 RID: 5256
		private int blockSize;

		// Token: 0x04001489 RID: 5257
		private int columns;

		// Token: 0x0400148A RID: 5258
		private int rounds;

		// Token: 0x0400148B RID: 5259
		private ulong[] state;

		// Token: 0x0400148C RID: 5260
		private ulong[] tempState1;

		// Token: 0x0400148D RID: 5261
		private ulong[] tempState2;

		// Token: 0x0400148E RID: 5262
		private ulong inputBlocks;

		// Token: 0x0400148F RID: 5263
		private int bufOff;

		// Token: 0x04001490 RID: 5264
		private byte[] buf;

		// Token: 0x04001491 RID: 5265
		private static readonly byte[] S0 = new byte[]
		{
			168,
			67,
			95,
			6,
			107,
			117,
			108,
			89,
			113,
			223,
			135,
			149,
			23,
			240,
			216,
			9,
			109,
			243,
			29,
			203,
			201,
			77,
			44,
			175,
			121,
			224,
			151,
			253,
			111,
			75,
			69,
			57,
			62,
			221,
			163,
			79,
			180,
			182,
			154,
			14,
			31,
			191,
			21,
			225,
			73,
			210,
			147,
			198,
			146,
			114,
			158,
			97,
			209,
			99,
			250,
			238,
			244,
			25,
			213,
			173,
			88,
			164,
			187,
			161,
			220,
			242,
			131,
			55,
			66,
			228,
			122,
			50,
			156,
			204,
			171,
			74,
			143,
			110,
			4,
			39,
			46,
			231,
			226,
			90,
			150,
			22,
			35,
			43,
			194,
			101,
			102,
			15,
			188,
			169,
			71,
			65,
			52,
			72,
			252,
			183,
			106,
			136,
			165,
			83,
			134,
			249,
			91,
			219,
			56,
			123,
			195,
			30,
			34,
			51,
			36,
			40,
			54,
			199,
			178,
			59,
			142,
			119,
			186,
			245,
			20,
			159,
			8,
			85,
			155,
			76,
			254,
			96,
			92,
			218,
			24,
			70,
			205,
			125,
			33,
			176,
			63,
			27,
			137,
			byte.MaxValue,
			235,
			132,
			105,
			58,
			157,
			215,
			211,
			112,
			103,
			64,
			181,
			222,
			93,
			48,
			145,
			177,
			120,
			17,
			1,
			229,
			0,
			104,
			152,
			160,
			197,
			2,
			166,
			116,
			45,
			11,
			162,
			118,
			179,
			190,
			206,
			189,
			174,
			233,
			138,
			49,
			28,
			236,
			241,
			153,
			148,
			170,
			246,
			38,
			47,
			239,
			232,
			140,
			53,
			3,
			212,
			127,
			251,
			5,
			193,
			94,
			144,
			32,
			61,
			130,
			247,
			234,
			10,
			13,
			126,
			248,
			80,
			26,
			196,
			7,
			87,
			184,
			60,
			98,
			227,
			200,
			172,
			82,
			100,
			16,
			208,
			217,
			19,
			12,
			18,
			41,
			81,
			185,
			207,
			214,
			115,
			141,
			129,
			84,
			192,
			237,
			78,
			68,
			167,
			42,
			133,
			37,
			230,
			202,
			124,
			139,
			86,
			128
		};

		// Token: 0x04001492 RID: 5266
		private static readonly byte[] S1 = new byte[]
		{
			206,
			187,
			235,
			146,
			234,
			203,
			19,
			193,
			233,
			58,
			214,
			178,
			210,
			144,
			23,
			248,
			66,
			21,
			86,
			180,
			101,
			28,
			136,
			67,
			197,
			92,
			54,
			186,
			245,
			87,
			103,
			141,
			49,
			246,
			100,
			88,
			158,
			244,
			34,
			170,
			117,
			15,
			2,
			177,
			223,
			109,
			115,
			77,
			124,
			38,
			46,
			247,
			8,
			93,
			68,
			62,
			159,
			20,
			200,
			174,
			84,
			16,
			216,
			188,
			26,
			107,
			105,
			243,
			189,
			51,
			171,
			250,
			209,
			155,
			104,
			78,
			22,
			149,
			145,
			238,
			76,
			99,
			142,
			91,
			204,
			60,
			25,
			161,
			129,
			73,
			123,
			217,
			111,
			55,
			96,
			202,
			231,
			43,
			72,
			253,
			150,
			69,
			252,
			65,
			18,
			13,
			121,
			229,
			137,
			140,
			227,
			32,
			48,
			220,
			183,
			108,
			74,
			181,
			63,
			151,
			212,
			98,
			45,
			6,
			164,
			165,
			131,
			95,
			42,
			218,
			201,
			0,
			126,
			162,
			85,
			191,
			17,
			213,
			156,
			207,
			14,
			10,
			61,
			81,
			125,
			147,
			27,
			254,
			196,
			71,
			9,
			134,
			11,
			143,
			157,
			106,
			7,
			185,
			176,
			152,
			24,
			50,
			113,
			75,
			239,
			59,
			112,
			160,
			228,
			64,
			byte.MaxValue,
			195,
			169,
			230,
			120,
			249,
			139,
			70,
			128,
			30,
			56,
			225,
			184,
			168,
			224,
			12,
			35,
			118,
			29,
			37,
			36,
			5,
			241,
			110,
			148,
			40,
			154,
			132,
			232,
			163,
			79,
			119,
			211,
			133,
			226,
			82,
			242,
			130,
			80,
			122,
			47,
			116,
			83,
			179,
			97,
			175,
			57,
			53,
			222,
			205,
			31,
			153,
			172,
			173,
			114,
			44,
			221,
			208,
			135,
			190,
			94,
			166,
			236,
			4,
			198,
			3,
			52,
			251,
			219,
			89,
			182,
			194,
			1,
			240,
			90,
			237,
			167,
			102,
			33,
			127,
			138,
			39,
			199,
			192,
			41,
			215
		};

		// Token: 0x04001493 RID: 5267
		private static readonly byte[] S2 = new byte[]
		{
			147,
			217,
			154,
			181,
			152,
			34,
			69,
			252,
			186,
			106,
			223,
			2,
			159,
			220,
			81,
			89,
			74,
			23,
			43,
			194,
			148,
			244,
			187,
			163,
			98,
			228,
			113,
			212,
			205,
			112,
			22,
			225,
			73,
			60,
			192,
			216,
			92,
			155,
			173,
			133,
			83,
			161,
			122,
			200,
			45,
			224,
			209,
			114,
			166,
			44,
			196,
			227,
			118,
			120,
			183,
			180,
			9,
			59,
			14,
			65,
			76,
			222,
			178,
			144,
			37,
			165,
			215,
			3,
			17,
			0,
			195,
			46,
			146,
			239,
			78,
			18,
			157,
			125,
			203,
			53,
			16,
			213,
			79,
			158,
			77,
			169,
			85,
			198,
			208,
			123,
			24,
			151,
			211,
			54,
			230,
			72,
			86,
			129,
			143,
			119,
			204,
			156,
			185,
			226,
			172,
			184,
			47,
			21,
			164,
			124,
			218,
			56,
			30,
			11,
			5,
			214,
			20,
			110,
			108,
			126,
			102,
			253,
			177,
			229,
			96,
			175,
			94,
			51,
			135,
			201,
			240,
			93,
			109,
			63,
			136,
			141,
			199,
			247,
			29,
			233,
			236,
			237,
			128,
			41,
			39,
			207,
			153,
			168,
			80,
			15,
			55,
			36,
			40,
			48,
			149,
			210,
			62,
			91,
			64,
			131,
			179,
			105,
			87,
			31,
			7,
			28,
			138,
			188,
			32,
			235,
			206,
			142,
			171,
			238,
			49,
			162,
			115,
			249,
			202,
			58,
			26,
			251,
			13,
			193,
			254,
			250,
			242,
			111,
			189,
			150,
			221,
			67,
			82,
			182,
			8,
			243,
			174,
			190,
			25,
			137,
			50,
			38,
			176,
			234,
			75,
			100,
			132,
			130,
			107,
			245,
			121,
			191,
			1,
			95,
			117,
			99,
			27,
			35,
			61,
			104,
			42,
			101,
			232,
			145,
			246,
			byte.MaxValue,
			19,
			88,
			241,
			71,
			10,
			127,
			197,
			167,
			231,
			97,
			90,
			6,
			70,
			68,
			66,
			4,
			160,
			219,
			57,
			134,
			84,
			170,
			140,
			52,
			33,
			139,
			248,
			12,
			116,
			103
		};

		// Token: 0x04001494 RID: 5268
		private static readonly byte[] S3 = new byte[]
		{
			104,
			141,
			202,
			77,
			115,
			75,
			78,
			42,
			212,
			82,
			38,
			179,
			84,
			30,
			25,
			31,
			34,
			3,
			70,
			61,
			45,
			74,
			83,
			131,
			19,
			138,
			183,
			213,
			37,
			121,
			245,
			189,
			88,
			47,
			13,
			2,
			237,
			81,
			158,
			17,
			242,
			62,
			85,
			94,
			209,
			22,
			60,
			102,
			112,
			93,
			243,
			69,
			64,
			204,
			232,
			148,
			86,
			8,
			206,
			26,
			58,
			210,
			225,
			223,
			181,
			56,
			110,
			14,
			229,
			244,
			249,
			134,
			233,
			79,
			214,
			133,
			35,
			207,
			50,
			153,
			49,
			20,
			174,
			238,
			200,
			72,
			211,
			48,
			161,
			146,
			65,
			177,
			24,
			196,
			44,
			113,
			114,
			68,
			21,
			253,
			55,
			190,
			95,
			170,
			155,
			136,
			216,
			171,
			137,
			156,
			250,
			96,
			234,
			188,
			98,
			12,
			36,
			166,
			168,
			236,
			103,
			32,
			219,
			124,
			40,
			221,
			172,
			91,
			52,
			126,
			16,
			241,
			123,
			143,
			99,
			160,
			5,
			154,
			67,
			119,
			33,
			191,
			39,
			9,
			195,
			159,
			182,
			215,
			41,
			194,
			235,
			192,
			164,
			139,
			140,
			29,
			251,
			byte.MaxValue,
			193,
			178,
			151,
			46,
			248,
			101,
			246,
			117,
			7,
			4,
			73,
			51,
			228,
			217,
			185,
			208,
			66,
			199,
			108,
			144,
			0,
			142,
			111,
			80,
			1,
			197,
			218,
			71,
			63,
			205,
			105,
			162,
			226,
			122,
			167,
			198,
			147,
			15,
			10,
			6,
			230,
			43,
			150,
			163,
			28,
			175,
			106,
			18,
			132,
			57,
			231,
			176,
			130,
			247,
			254,
			157,
			135,
			92,
			129,
			53,
			222,
			180,
			165,
			252,
			128,
			239,
			203,
			187,
			107,
			118,
			186,
			90,
			125,
			120,
			11,
			149,
			227,
			173,
			116,
			152,
			59,
			54,
			100,
			109,
			220,
			240,
			89,
			169,
			76,
			23,
			127,
			145,
			184,
			201,
			87,
			27,
			224,
			97
		};
	}
}
