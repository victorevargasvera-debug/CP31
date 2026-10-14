using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000494 RID: 1172
	public sealed class Cast6Engine : global::Org.BouncyCastle.Crypto.Engines.Cast5Engine
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x000C8AA5 File Offset: 0x000C6CA5
		public override string AlgorithmName
		{
			get
			{
				return "CAST6";
			}
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x000C8AAC File Offset: 0x000C6CAC
		public override void Reset()
		{
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x000C8AAE File Offset: 0x000C6CAE
		public override int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x000C8AB4 File Offset: 0x000C6CB4
		internal override void SetKey(byte[] key)
		{
			uint Cm = 1518500249U;
			uint Mm = 1859775393U;
			int Cr = 19;
			int Mr = 17;
			for (int i = 0; i < 24; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					this._Tm[i * 8 + j] = Cm;
					Cm += Mm;
					this._Tr[i * 8 + j] = Cr;
					Cr = (Cr + Mr & 31);
				}
			}
			byte[] tmpKey = new byte[64];
			key.CopyTo(tmpKey, 0);
			for (int k = 0; k < 8; k++)
			{
				this._workingKey[k] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(tmpKey, k * 4);
			}
			for (int l = 0; l < 12; l++)
			{
				int i2 = l * 2 * 8;
				this._workingKey[6] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(this._workingKey[7], this._Tm[i2], this._Tr[i2]);
				this._workingKey[5] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(this._workingKey[6], this._Tm[i2 + 1], this._Tr[i2 + 1]);
				this._workingKey[4] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(this._workingKey[5], this._Tm[i2 + 2], this._Tr[i2 + 2]);
				this._workingKey[3] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(this._workingKey[4], this._Tm[i2 + 3], this._Tr[i2 + 3]);
				this._workingKey[2] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(this._workingKey[3], this._Tm[i2 + 4], this._Tr[i2 + 4]);
				this._workingKey[1] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(this._workingKey[2], this._Tm[i2 + 5], this._Tr[i2 + 5]);
				this._workingKey[0] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(this._workingKey[1], this._Tm[i2 + 6], this._Tr[i2 + 6]);
				this._workingKey[7] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(this._workingKey[0], this._Tm[i2 + 7], this._Tr[i2 + 7]);
				i2 = (l * 2 + 1) * 8;
				this._workingKey[6] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(this._workingKey[7], this._Tm[i2], this._Tr[i2]);
				this._workingKey[5] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(this._workingKey[6], this._Tm[i2 + 1], this._Tr[i2 + 1]);
				this._workingKey[4] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(this._workingKey[5], this._Tm[i2 + 2], this._Tr[i2 + 2]);
				this._workingKey[3] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(this._workingKey[4], this._Tm[i2 + 3], this._Tr[i2 + 3]);
				this._workingKey[2] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(this._workingKey[3], this._Tm[i2 + 4], this._Tr[i2 + 4]);
				this._workingKey[1] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(this._workingKey[2], this._Tm[i2 + 5], this._Tr[i2 + 5]);
				this._workingKey[0] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(this._workingKey[1], this._Tm[i2 + 6], this._Tr[i2 + 6]);
				this._workingKey[7] ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(this._workingKey[0], this._Tm[i2 + 7], this._Tr[i2 + 7]);
				this._Kr[l * 4] = (int)(this._workingKey[0] & 31U);
				this._Kr[l * 4 + 1] = (int)(this._workingKey[2] & 31U);
				this._Kr[l * 4 + 2] = (int)(this._workingKey[4] & 31U);
				this._Kr[l * 4 + 3] = (int)(this._workingKey[6] & 31U);
				this._Km[l * 4] = this._workingKey[7];
				this._Km[l * 4 + 1] = this._workingKey[5];
				this._Km[l * 4 + 2] = this._workingKey[3];
				this._Km[l * 4 + 3] = this._workingKey[1];
			}
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000C8F54 File Offset: 0x000C7154
		internal override int EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
			uint A = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(src, srcIndex);
			uint B = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(src, srcIndex + 4);
			uint C = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(src, srcIndex + 8);
			uint D = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(src, srcIndex + 12);
			uint[] result = new uint[4];
			this.CAST_Encipher(A, B, C, D, result);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(result[0], dst, dstIndex);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(result[1], dst, dstIndex + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(result[2], dst, dstIndex + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(result[3], dst, dstIndex + 12);
			return 16;
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x000C8FD8 File Offset: 0x000C71D8
		internal override int DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
			uint A = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(src, srcIndex);
			uint B = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(src, srcIndex + 4);
			uint C = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(src, srcIndex + 8);
			uint D = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(src, srcIndex + 12);
			uint[] result = new uint[4];
			this.CAST_Decipher(A, B, C, D, result);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(result[0], dst, dstIndex);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(result[1], dst, dstIndex + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(result[2], dst, dstIndex + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(result[3], dst, dstIndex + 12);
			return 16;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x000C905C File Offset: 0x000C725C
		private void CAST_Encipher(uint A, uint B, uint C, uint D, uint[] result)
		{
			for (int i = 0; i < 6; i++)
			{
				int x = i * 4;
				C ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(D, this._Km[x], this._Kr[x]);
				B ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(C, this._Km[x + 1], this._Kr[x + 1]);
				A ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(B, this._Km[x + 2], this._Kr[x + 2]);
				D ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(A, this._Km[x + 3], this._Kr[x + 3]);
			}
			for (int j = 6; j < 12; j++)
			{
				int x2 = j * 4;
				D ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(A, this._Km[x2 + 3], this._Kr[x2 + 3]);
				A ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(B, this._Km[x2 + 2], this._Kr[x2 + 2]);
				B ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(C, this._Km[x2 + 1], this._Kr[x2 + 1]);
				C ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(D, this._Km[x2], this._Kr[x2]);
			}
			result[0] = A;
			result[1] = B;
			result[2] = C;
			result[3] = D;
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x000C9194 File Offset: 0x000C7394
		private void CAST_Decipher(uint A, uint B, uint C, uint D, uint[] result)
		{
			for (int i = 0; i < 6; i++)
			{
				int x = (11 - i) * 4;
				C ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(D, this._Km[x], this._Kr[x]);
				B ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(C, this._Km[x + 1], this._Kr[x + 1]);
				A ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(B, this._Km[x + 2], this._Kr[x + 2]);
				D ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(A, this._Km[x + 3], this._Kr[x + 3]);
			}
			for (int j = 6; j < 12; j++)
			{
				int x2 = (11 - j) * 4;
				D ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(A, this._Km[x2 + 3], this._Kr[x2 + 3]);
				A ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F3(B, this._Km[x2 + 2], this._Kr[x2 + 2]);
				B ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F2(C, this._Km[x2 + 1], this._Kr[x2 + 1]);
				C ^= global::Org.BouncyCastle.Crypto.Engines.Cast5Engine.F1(D, this._Km[x2], this._Kr[x2]);
			}
			result[0] = A;
			result[1] = B;
			result[2] = C;
			result[3] = D;
		}

		// Token: 0x040012EE RID: 4846
		private const int ROUNDS = 12;

		// Token: 0x040012EF RID: 4847
		private const int BLOCK_SIZE = 16;

		// Token: 0x040012F0 RID: 4848
		private int[] _Kr = new int[48];

		// Token: 0x040012F1 RID: 4849
		private uint[] _Km = new uint[48];

		// Token: 0x040012F2 RID: 4850
		private int[] _Tr = new int[192];

		// Token: 0x040012F3 RID: 4851
		private uint[] _Tm = new uint[192];

		// Token: 0x040012F4 RID: 4852
		private uint[] _workingKey = new uint[8];
	}
}
