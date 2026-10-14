using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Fpe
{
	// Token: 0x02000487 RID: 1159
	public class FpeFf1Engine : global::Org.BouncyCastle.Crypto.Fpe.FpeEngine
	{
		// Token: 0x06002C56 RID: 11350 RVA: 0x000BF7A4 File Offset: 0x000BD9A4
		public FpeFf1Engine() : this(new global::Org.BouncyCastle.Crypto.Engines.AesEngine())
		{
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000BF7B1 File Offset: 0x000BD9B1
		public FpeFf1Engine(global::Org.BouncyCastle.Crypto.IBlockCipher baseCipher) : base(baseCipher)
		{
			if (global::Org.BouncyCastle.Crypto.Fpe.FpeEngine.IsOverrideSet(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.FPE_DISABLED) || global::Org.BouncyCastle.Crypto.Fpe.FpeEngine.IsOverrideSet(global::Org.BouncyCastle.Crypto.Fpe.SP80038G.FF1_DISABLED))
			{
				throw new global::System.InvalidOperationException("FF1 encryption disabled");
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000BF7DD File Offset: 0x000BD9DD
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
			this.fpeParameters = (global::Org.BouncyCastle.Crypto.Parameters.FpeParameters)parameters;
			this.baseCipher.Init(!this.fpeParameters.UseInverseFunction, this.fpeParameters.Key);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000BF818 File Offset: 0x000BDA18
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
				ushort[] u16Out = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.EncryptFF1w(this.baseCipher, this.fpeParameters.Radix, this.fpeParameters.GetTweak(), u16In, 0, u16In.Length);
				enc = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt16_To_BE(u16Out, 0, u16Out.Length);
			}
			else
			{
				enc = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.EncryptFF1(this.baseCipher, this.fpeParameters.Radix, this.fpeParameters.GetTweak(), inBuf, inOff, length);
			}
			global::System.Array.Copy(enc, 0, outBuf, outOff, length);
			return length;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000BF8B8 File Offset: 0x000BDAB8
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
				ushort[] u16Out = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.DecryptFF1w(this.baseCipher, this.fpeParameters.Radix, this.fpeParameters.GetTweak(), u16In, 0, u16In.Length);
				dec = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt16_To_BE(u16Out, 0, u16Out.Length);
			}
			else
			{
				dec = global::Org.BouncyCastle.Crypto.Fpe.SP80038G.DecryptFF1(this.baseCipher, this.fpeParameters.Radix, this.fpeParameters.GetTweak(), inBuf, inOff, length);
			}
			global::System.Array.Copy(dec, 0, outBuf, outOff, length);
			return length;
		}
	}
}
