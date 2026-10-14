using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004AC RID: 1196
	public class Rfc3211WrapEngine : global::Org.BouncyCastle.Crypto.IWrapper
	{
		// Token: 0x06002E2F RID: 11823 RVA: 0x000D0CAF File Offset: 0x000CEEAF
		public Rfc3211WrapEngine(global::Org.BouncyCastle.Crypto.IBlockCipher engine)
		{
			this.engine = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(engine);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000D0CC4 File Offset: 0x000CEEC4
		public virtual void Init(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters param)
		{
			this.forWrapping = forWrapping;
			if (param is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom p = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)param;
				this.rand = p.Random;
				this.param = (p.Parameters as global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV);
			}
			else
			{
				if (forWrapping)
				{
					this.rand = new global::Org.BouncyCastle.Security.SecureRandom();
				}
				this.param = (param as global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV);
			}
			if (this.param == null)
			{
				throw new global::System.ArgumentException("RFC3211Wrap requires an IV", "param");
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x000D0D38 File Offset: 0x000CEF38
		public virtual string AlgorithmName
		{
			get
			{
				return this.engine.GetUnderlyingCipher().AlgorithmName + "/RFC3211Wrap";
			}
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000D0D54 File Offset: 0x000CEF54
		public virtual byte[] Wrap(byte[] inBytes, int inOff, int inLen)
		{
			if (!this.forWrapping)
			{
				throw new global::System.InvalidOperationException("not set for wrapping");
			}
			if (inLen > 255 || inLen < 0)
			{
				throw new global::System.ArgumentException("input must be from 0 to 255 bytes", "inLen");
			}
			this.engine.Init(true, this.param);
			int blockSize = this.engine.GetBlockSize();
			byte[] cekBlock;
			if (inLen + 4 < blockSize * 2)
			{
				cekBlock = new byte[blockSize * 2];
			}
			else
			{
				cekBlock = new byte[((inLen + 4) % blockSize == 0) ? (inLen + 4) : (((inLen + 4) / blockSize + 1) * blockSize)];
			}
			cekBlock[0] = (byte)inLen;
			global::System.Array.Copy(inBytes, inOff, cekBlock, 4, inLen);
			this.rand.NextBytes(cekBlock, inLen + 4, cekBlock.Length - inLen - 4);
			cekBlock[1] = ~cekBlock[4];
			cekBlock[2] = ~cekBlock[5];
			cekBlock[3] = ~cekBlock[6];
			for (int i = 0; i < cekBlock.Length; i += blockSize)
			{
				this.engine.ProcessBlock(cekBlock, i, cekBlock, i);
			}
			for (int j = 0; j < cekBlock.Length; j += blockSize)
			{
				this.engine.ProcessBlock(cekBlock, j, cekBlock, j);
			}
			return cekBlock;
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x000D0E58 File Offset: 0x000CF058
		public virtual byte[] Unwrap(byte[] inBytes, int inOff, int inLen)
		{
			if (this.forWrapping)
			{
				throw new global::System.InvalidOperationException("not set for unwrapping");
			}
			int blockSize = this.engine.GetBlockSize();
			if (inLen < 2 * blockSize)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("input too short");
			}
			byte[] cekBlock = new byte[inLen];
			byte[] iv = new byte[blockSize];
			global::System.Array.Copy(inBytes, inOff, cekBlock, 0, inLen);
			global::System.Array.Copy(inBytes, inOff, iv, 0, iv.Length);
			this.engine.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.param.Parameters, iv));
			for (int i = blockSize; i < cekBlock.Length; i += blockSize)
			{
				this.engine.ProcessBlock(cekBlock, i, cekBlock, i);
			}
			global::System.Array.Copy(cekBlock, cekBlock.Length - iv.Length, iv, 0, iv.Length);
			this.engine.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(this.param.Parameters, iv));
			this.engine.ProcessBlock(cekBlock, 0, cekBlock, 0);
			this.engine.Init(false, this.param);
			for (int j = 0; j < cekBlock.Length; j += blockSize)
			{
				this.engine.ProcessBlock(cekBlock, j, cekBlock, j);
			}
			bool invalidLength = (int)cekBlock[0] > cekBlock.Length - 4;
			byte[] key;
			if (invalidLength)
			{
				key = new byte[cekBlock.Length - 4];
			}
			else
			{
				key = new byte[(int)cekBlock[0]];
			}
			global::System.Array.Copy(cekBlock, 4, key, 0, key.Length);
			int nonEqual = 0;
			for (int k = 0; k != 3; k++)
			{
				byte check = ~cekBlock[1 + k];
				nonEqual |= (int)(check ^ cekBlock[4 + k]);
			}
			global::System.Array.Clear(cekBlock, 0, cekBlock.Length);
			if (nonEqual != 0 || invalidLength)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("wrapped key corrupted");
			}
			return key;
		}

		// Token: 0x04001391 RID: 5009
		private global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher engine;

		// Token: 0x04001392 RID: 5010
		private global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV param;

		// Token: 0x04001393 RID: 5011
		private bool forWrapping;

		// Token: 0x04001394 RID: 5012
		private global::Org.BouncyCastle.Security.SecureRandom rand;
	}
}
