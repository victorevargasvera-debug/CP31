using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004C2 RID: 1218
	public class XteaEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002F27 RID: 12071 RVA: 0x000DB174 File Offset: 0x000D9374
		public XteaEngine()
		{
			this._initialised = false;
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x000DB1A9 File Offset: 0x000D93A9
		public virtual string AlgorithmName
		{
			get
			{
				return "XTEA";
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x000DB1B0 File Offset: 0x000D93B0
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x000DB1B3 File Offset: 0x000D93B3
		public virtual int GetBlockSize()
		{
			return 8;
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x000DB1B8 File Offset: 0x000D93B8
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("invalid parameter passed to TEA init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			this._forEncryption = forEncryption;
			this._initialised = true;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter p = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
			this.setKey(p.GetKey());
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000DB204 File Offset: 0x000D9404
		public virtual int ProcessBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			if (!this._initialised)
			{
				throw new global::System.InvalidOperationException(this.AlgorithmName + " not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(inBytes, inOff, 8, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(outBytes, outOff, 8, "output buffer too short");
			if (!this._forEncryption)
			{
				return this.decryptBlock(inBytes, inOff, outBytes, outOff);
			}
			return this.encryptBlock(inBytes, inOff, outBytes, outOff);
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x000DB269 File Offset: 0x000D9469
		public virtual void Reset()
		{
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000DB26C File Offset: 0x000D946C
		private void setKey(byte[] key)
		{
			int j;
			int i = j = 0;
			while (j < 4)
			{
				this._S[j] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, i);
				j++;
				i += 4;
			}
			i = (j = 0);
			while (j < 32)
			{
				this._sum0[j] = (uint)(i + (int)this._S[i & 3]);
				i += -1640531527;
				this._sum1[j] = (uint)(i + (int)this._S[i >> 11 & 3]);
				j++;
			}
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000DB2DC File Offset: 0x000D94DC
		private int encryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			uint v0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(inBytes, inOff);
			uint v = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(inBytes, inOff + 4);
			for (int i = 0; i < 32; i++)
			{
				v0 += ((v << 4 ^ v >> 5) + v ^ this._sum0[i]);
				v += ((v0 << 4 ^ v0 >> 5) + v0 ^ this._sum1[i]);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(v0, outBytes, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(v, outBytes, outOff + 4);
			return 8;
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x000DB348 File Offset: 0x000D9548
		private int decryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			uint v0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(inBytes, inOff);
			uint v = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(inBytes, inOff + 4);
			for (int i = 31; i >= 0; i--)
			{
				v -= ((v0 << 4 ^ v0 >> 5) + v0 ^ this._sum1[i]);
				v0 -= ((v << 4 ^ v >> 5) + v ^ this._sum0[i]);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(v0, outBytes, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(v, outBytes, outOff + 4);
			return 8;
		}

		// Token: 0x0400143B RID: 5179
		private const int rounds = 32;

		// Token: 0x0400143C RID: 5180
		private const int block_size = 8;

		// Token: 0x0400143D RID: 5181
		private const int delta = -1640531527;

		// Token: 0x0400143E RID: 5182
		private uint[] _S = new uint[4];

		// Token: 0x0400143F RID: 5183
		private uint[] _sum0 = new uint[32];

		// Token: 0x04001440 RID: 5184
		private uint[] _sum1 = new uint[32];

		// Token: 0x04001441 RID: 5185
		private bool _initialised;

		// Token: 0x04001442 RID: 5186
		private bool _forEncryption;
	}
}
