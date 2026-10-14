using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004BB RID: 1211
	public class TeaEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002EE2 RID: 12002 RVA: 0x000D6F30 File Offset: 0x000D5130
		public TeaEngine()
		{
			this._initialised = false;
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x000D6F3F File Offset: 0x000D513F
		public virtual string AlgorithmName
		{
			get
			{
				return "TEA";
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x000D6F46 File Offset: 0x000D5146
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x000D6F49 File Offset: 0x000D5149
		public virtual int GetBlockSize()
		{
			return 8;
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x000D6F4C File Offset: 0x000D514C
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

		// Token: 0x06002EE7 RID: 12007 RVA: 0x000D6F98 File Offset: 0x000D5198
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

		// Token: 0x06002EE8 RID: 12008 RVA: 0x000D6FFD File Offset: 0x000D51FD
		public virtual void Reset()
		{
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x000D6FFF File Offset: 0x000D51FF
		private void setKey(byte[] key)
		{
			this._a = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, 0);
			this._b = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, 4);
			this._c = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, 8);
			this._d = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, 12);
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x000D7038 File Offset: 0x000D5238
		private int encryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			uint v0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(inBytes, inOff);
			uint v = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(inBytes, inOff + 4);
			uint sum = 0U;
			for (int i = 0; i != 32; i++)
			{
				sum += 2654435769U;
				v0 += ((v << 4) + this._a ^ v + sum ^ (v >> 5) + this._b);
				v += ((v0 << 4) + this._c ^ v0 + sum ^ (v0 >> 5) + this._d);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(v0, outBytes, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(v, outBytes, outOff + 4);
			return 8;
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x000D70BC File Offset: 0x000D52BC
		private int decryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			uint v0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(inBytes, inOff);
			uint v = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(inBytes, inOff + 4);
			uint sum = 3337565984U;
			for (int i = 0; i != 32; i++)
			{
				v -= ((v0 << 4) + this._c ^ v0 + sum ^ (v0 >> 5) + this._d);
				v0 -= ((v << 4) + this._a ^ v + sum ^ (v >> 5) + this._b);
				sum -= 2654435769U;
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(v0, outBytes, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(v, outBytes, outOff + 4);
			return 8;
		}

		// Token: 0x040013EA RID: 5098
		private const int rounds = 32;

		// Token: 0x040013EB RID: 5099
		private const int block_size = 8;

		// Token: 0x040013EC RID: 5100
		private const uint delta = 2654435769U;

		// Token: 0x040013ED RID: 5101
		private const uint d_sum = 3337565984U;

		// Token: 0x040013EE RID: 5102
		private uint _a;

		// Token: 0x040013EF RID: 5103
		private uint _b;

		// Token: 0x040013F0 RID: 5104
		private uint _c;

		// Token: 0x040013F1 RID: 5105
		private uint _d;

		// Token: 0x040013F2 RID: 5106
		private bool _initialised;

		// Token: 0x040013F3 RID: 5107
		private bool _forEncryption;
	}
}
