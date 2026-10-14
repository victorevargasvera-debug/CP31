using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004AD RID: 1197
	public class Rfc3394WrapEngine : global::Org.BouncyCastle.Crypto.IWrapper
	{
		// Token: 0x06002E34 RID: 11828 RVA: 0x000D0FEE File Offset: 0x000CF1EE
		public Rfc3394WrapEngine(global::Org.BouncyCastle.Crypto.IBlockCipher engine)
		{
			this.engine = engine;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x000D1014 File Offset: 0x000CF214
		public virtual void Init(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forWrapping = forWrapping;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				this.param = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
				return;
			}
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV pIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				byte[] iv = pIV.GetIV();
				if (iv.Length != 8)
				{
					throw new global::System.ArgumentException("IV length not equal to 8", "parameters");
				}
				this.iv = iv;
				this.param = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)pIV.Parameters;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002E36 RID: 11830 RVA: 0x000D1096 File Offset: 0x000CF296
		public virtual string AlgorithmName
		{
			get
			{
				return this.engine.AlgorithmName;
			}
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000D10A4 File Offset: 0x000CF2A4
		public virtual byte[] Wrap(byte[] input, int inOff, int inLen)
		{
			if (!this.forWrapping)
			{
				throw new global::System.InvalidOperationException("not set for wrapping");
			}
			int i = inLen / 8;
			if (i * 8 != inLen)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("wrap data must be a multiple of 8 bytes");
			}
			byte[] block = new byte[inLen + this.iv.Length];
			byte[] buf = new byte[8 + this.iv.Length];
			global::System.Array.Copy(this.iv, 0, block, 0, this.iv.Length);
			global::System.Array.Copy(input, inOff, block, this.iv.Length, inLen);
			this.engine.Init(true, this.param);
			for (int j = 0; j != 6; j++)
			{
				for (int k = 1; k <= i; k++)
				{
					global::System.Array.Copy(block, 0, buf, 0, this.iv.Length);
					global::System.Array.Copy(block, 8 * k, buf, this.iv.Length, 8);
					this.engine.ProcessBlock(buf, 0, buf, 0);
					int t = i * j + k;
					int l = 1;
					while (t != 0)
					{
						byte v = (byte)t;
						byte[] array = buf;
						int num = this.iv.Length - l;
						array[num] ^= v;
						t = (int)((uint)t >> 8);
						l++;
					}
					global::System.Array.Copy(buf, 0, block, 0, 8);
					global::System.Array.Copy(buf, 8, block, 8 * k, 8);
				}
			}
			return block;
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x000D11E4 File Offset: 0x000CF3E4
		public virtual byte[] Unwrap(byte[] input, int inOff, int inLen)
		{
			if (this.forWrapping)
			{
				throw new global::System.InvalidOperationException("not set for unwrapping");
			}
			int i = inLen / 8;
			if (i * 8 != inLen)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("unwrap data must be a multiple of 8 bytes");
			}
			byte[] block = new byte[inLen - this.iv.Length];
			byte[] a = new byte[this.iv.Length];
			byte[] buf = new byte[8 + this.iv.Length];
			global::System.Array.Copy(input, inOff, a, 0, this.iv.Length);
			global::System.Array.Copy(input, inOff + this.iv.Length, block, 0, inLen - this.iv.Length);
			this.engine.Init(false, this.param);
			i--;
			for (int j = 5; j >= 0; j--)
			{
				for (int k = i; k >= 1; k--)
				{
					global::System.Array.Copy(a, 0, buf, 0, this.iv.Length);
					global::System.Array.Copy(block, 8 * (k - 1), buf, this.iv.Length, 8);
					int t = i * j + k;
					int l = 1;
					while (t != 0)
					{
						byte v = (byte)t;
						byte[] array = buf;
						int num = this.iv.Length - l;
						array[num] ^= v;
						t = (int)((uint)t >> 8);
						l++;
					}
					this.engine.ProcessBlock(buf, 0, buf, 0);
					global::System.Array.Copy(buf, 0, a, 0, 8);
					global::System.Array.Copy(buf, 8, block, 8 * (k - 1), 8);
				}
			}
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a, this.iv))
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("checksum failed");
			}
			return block;
		}

		// Token: 0x04001395 RID: 5013
		private readonly global::Org.BouncyCastle.Crypto.IBlockCipher engine;

		// Token: 0x04001396 RID: 5014
		private global::Org.BouncyCastle.Crypto.Parameters.KeyParameter param;

		// Token: 0x04001397 RID: 5015
		private bool forWrapping;

		// Token: 0x04001398 RID: 5016
		private byte[] iv = new byte[]
		{
			166,
			166,
			166,
			166,
			166,
			166,
			166,
			166
		};
	}
}
