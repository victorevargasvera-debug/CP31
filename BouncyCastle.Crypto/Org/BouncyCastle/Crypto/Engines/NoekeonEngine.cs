using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A4 RID: 1188
	public class NoekeonEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002DD5 RID: 11733 RVA: 0x000CEA10 File Offset: 0x000CCC10
		public NoekeonEngine()
		{
			this._initialised = false;
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002DD6 RID: 11734 RVA: 0x000CEA2B File Offset: 0x000CCC2B
		public virtual string AlgorithmName
		{
			get
			{
				return "Noekeon";
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x000CEA32 File Offset: 0x000CCC32
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x000CEA35 File Offset: 0x000CCC35
		public virtual int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x000CEA3C File Offset: 0x000CCC3C
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("Invalid parameters passed to Noekeon init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters), "parameters");
			}
			byte[] key = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
			if (key.Length != 16)
			{
				throw new global::System.ArgumentException("Key length not 128 bits.");
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, 0, this.k, 0, 4);
			if (!forEncryption)
			{
				uint a0 = this.k[0];
				uint a = this.k[1];
				uint a2 = this.k[2];
				uint a3 = this.k[3];
				uint t2 = a0 ^ a2;
				t2 ^= (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t2, 8) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t2, 24));
				uint t3 = a ^ a3;
				t3 ^= (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t3, 8) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t3, 24));
				a0 ^= t3;
				a ^= t2;
				a2 ^= t3;
				a3 ^= t2;
				this.k[0] = a0;
				this.k[1] = a;
				this.k[2] = a2;
				this.k[3] = a3;
			}
			this._forEncryption = forEncryption;
			this._initialised = true;
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000CEB40 File Offset: 0x000CCD40
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (!this._initialised)
			{
				throw new global::System.InvalidOperationException(this.AlgorithmName + " not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 16, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 16, "output buffer too short");
			if (!this._forEncryption)
			{
				return this.DecryptBlock(input, inOff, output, outOff);
			}
			return this.EncryptBlock(input, inOff, output, outOff);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x000CEBA7 File Offset: 0x000CCDA7
		public virtual void Reset()
		{
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x000CEBAC File Offset: 0x000CCDAC
		private int EncryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			uint a0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff);
			uint a = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 4);
			uint a2 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 8);
			uint a3 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 12);
			uint k0 = this.k[0];
			uint k = this.k[1];
			uint k2 = this.k[2];
			uint k3 = this.k[3];
			int round = 0;
			for (;;)
			{
				a0 ^= (uint)global::Org.BouncyCastle.Crypto.Engines.NoekeonEngine.RoundConstants[round];
				uint t2 = a0 ^ a2;
				t2 ^= (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t2, 8) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t2, 24));
				a0 ^= k0;
				a ^= k;
				a2 ^= k2;
				a3 ^= k3;
				uint t3 = a ^ a3;
				t3 ^= (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t3, 8) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t3, 24));
				a0 ^= t3;
				a ^= t2;
				a2 ^= t3;
				a3 ^= t2;
				if (++round > 16)
				{
					break;
				}
				a = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a, 1);
				a2 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a2, 5);
				a3 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a3, 2);
				uint num = a3;
				a ^= (a3 | a2);
				a3 = (a0 ^ (a2 & ~a));
				a2 = (num ^ ~a ^ a2 ^ a3);
				a ^= (a3 | a2);
				a0 = (num ^ (a2 & a));
				a = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a, 31);
				a2 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a2, 27);
				a3 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a3, 30);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(a0, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(a, output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(a2, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(a3, output, outOff + 12);
			return 16;
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x000CED08 File Offset: 0x000CCF08
		private int DecryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			uint a0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff);
			uint a = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 4);
			uint a2 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 8);
			uint a3 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 12);
			uint k0 = this.k[0];
			uint k = this.k[1];
			uint k2 = this.k[2];
			uint k3 = this.k[3];
			int round = 16;
			for (;;)
			{
				uint t2 = a0 ^ a2;
				t2 ^= (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t2, 8) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t2, 24));
				a0 ^= k0;
				a ^= k;
				a2 ^= k2;
				a3 ^= k3;
				uint t3 = a ^ a3;
				t3 ^= (global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t3, 8) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(t3, 24));
				a0 ^= t3;
				a ^= t2;
				a2 ^= t3;
				a3 ^= t2;
				a0 ^= (uint)global::Org.BouncyCastle.Crypto.Engines.NoekeonEngine.RoundConstants[round];
				if (--round < 0)
				{
					break;
				}
				a = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a, 1);
				a2 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a2, 5);
				a3 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a3, 2);
				uint num = a3;
				a ^= (a3 | a2);
				a3 = (a0 ^ (a2 & ~a));
				a2 = (num ^ ~a ^ a2 ^ a3);
				a ^= (a3 | a2);
				a0 = (num ^ (a2 & a));
				a = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a, 31);
				a2 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a2, 27);
				a3 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(a3, 30);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(a0, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(a, output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(a2, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(a3, output, outOff + 12);
			return 16;
		}

		// Token: 0x04001364 RID: 4964
		private const int Size = 16;

		// Token: 0x04001365 RID: 4965
		private static readonly byte[] RoundConstants = new byte[]
		{
			128,
			27,
			54,
			108,
			216,
			171,
			77,
			154,
			47,
			94,
			188,
			99,
			198,
			151,
			53,
			106,
			212
		};

		// Token: 0x04001366 RID: 4966
		private readonly uint[] k = new uint[4];

		// Token: 0x04001367 RID: 4967
		private bool _initialised;

		// Token: 0x04001368 RID: 4968
		private bool _forEncryption;
	}
}
