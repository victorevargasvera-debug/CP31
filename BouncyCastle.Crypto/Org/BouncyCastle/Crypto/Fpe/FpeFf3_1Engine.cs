using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Fpe
{
	// Token: 0x02000488 RID: 1160
	public class FpeFf3_1Engine : global::Org.BouncyCastle.Crypto.Fpe.FpeEngine
	{
		// Token: 0x06002C5B RID: 11355 RVA: 0x000BF956 File Offset: 0x000BDB56
		public FpeFf3_1Engine() : this(new global::Org.BouncyCastle.Crypto.Engines.AesEngine())
		{
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000BF963 File Offset: 0x000BDB63
		public FpeFf3_1Engine(global::Org.BouncyCastle.Crypto.IBlockCipher baseCipher) : base(baseCipher)
		{
			if (global::Org.BouncyCastle.Crypto.Fpe.FpeEngine.IsOverrideSet(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.FPE_DISABLED))
			{
				throw new global::System.InvalidOperationException("FPE disabled");
			}
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000BF984 File Offset: 0x000BDB84
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
			this.fpeParameters = (global::Org.BouncyCastle.Crypto.Parameters.FpeParameters)parameters;
			this.baseCipher.Init(!this.fpeParameters.UseInverseFunction, new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(global::Org.BouncyCastle.Utilities.Arrays.Reverse(this.fpeParameters.Key.GetKey())));
			if (this.fpeParameters.GetTweak().Length != 7)
			{
				throw new global::System.ArgumentException("tweak should be 56 bits");
			}
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000BF9F4 File Offset: 0x000BDBF4
		protected override int EncryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff)
		{
			byte[] enc;
			if (this.fpeParameters.Radix > 256)
			{
				if ((length & 1) != 0)
				{
					throw new global::System.ArgumentException("input must be an even number of bytes for a wide radix");
				}
				ushort[] u16In = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt16(inBuf, inOff, length);
				ushort[] u16Out = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.EncryptFF3_1w(this.baseCipher, this.fpeParameters.Radix, this.fpeParameters.GetTweak(), u16In, 0, u16In.Length);
				enc = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt16_To_BE(u16Out, 0, u16Out.Length);
			}
			else
			{
				enc = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.EncryptFF3_1(this.baseCipher, this.fpeParameters.Radix, this.fpeParameters.GetTweak(), inBuf, inOff, length);
			}
			global::System.Array.Copy(enc, 0, outBuf, outOff, length);
			return length;
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000BFA94 File Offset: 0x000BDC94
		protected override int DecryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff)
		{
			byte[] dec;
			if (this.fpeParameters.Radix > 256)
			{
				if ((length & 1) != 0)
				{
					throw new global::System.ArgumentException("input must be an even number of bytes for a wide radix");
				}
				ushort[] u16In = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt16(inBuf, inOff, length);
				ushort[] u16Out = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.DecryptFF3_1w(this.baseCipher, this.fpeParameters.Radix, this.fpeParameters.GetTweak(), u16In, 0, u16In.Length);
				dec = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt16_To_BE(u16Out, 0, u16Out.Length);
			}
			else
			{
				dec = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.DecryptFF3_1(this.baseCipher, this.fpeParameters.Radix, this.fpeParameters.GetTweak(), inBuf, inOff, length);
			}
			global::System.Array.Copy(dec, 0, outBuf, outOff, length);
			return length;
		}
	}
}
