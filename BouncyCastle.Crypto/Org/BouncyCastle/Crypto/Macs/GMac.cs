using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000451 RID: 1105
	public class GMac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002ACC RID: 10956 RVA: 0x000B74AD File Offset: 0x000B56AD
		public GMac(global::Org.BouncyCastle.Crypto.Modes.GcmBlockCipher cipher) : this(cipher, 128)
		{
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000B74BB File Offset: 0x000B56BB
		public GMac(global::Org.BouncyCastle.Crypto.Modes.GcmBlockCipher cipher, int macSizeBits)
		{
			this.cipher = cipher;
			this.macSizeBits = macSizeBits;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000B74D4 File Offset: 0x000B56D4
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				byte[] iv = parametersWithIV.GetIV();
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParam = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parametersWithIV.Parameters;
				this.cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.AeadParameters(keyParam, this.macSizeBits, iv));
				return;
			}
			throw new global::System.ArgumentException("GMAC requires ParametersWithIV");
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x000B7525 File Offset: 0x000B5725
		public string AlgorithmName
		{
			get
			{
				return this.cipher.GetUnderlyingCipher().AlgorithmName + "-GMAC";
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000B7541 File Offset: 0x000B5741
		public int GetMacSize()
		{
			return this.macSizeBits / 8;
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x000B754B File Offset: 0x000B574B
		public void Update(byte input)
		{
			this.cipher.ProcessAadByte(input);
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000B7559 File Offset: 0x000B5759
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
			this.cipher.ProcessAadBytes(input, inOff, len);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x000B756C File Offset: 0x000B576C
		public int DoFinal(byte[] output, int outOff)
		{
			int result;
			try
			{
				result = this.cipher.DoFinal(output, outOff);
			}
			catch (global::Org.BouncyCastle.Crypto.InvalidCipherTextException ex)
			{
				throw new global::System.InvalidOperationException(ex.ToString());
			}
			return result;
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000B75A8 File Offset: 0x000B57A8
		public void Reset()
		{
			this.cipher.Reset();
		}

		// Token: 0x04001199 RID: 4505
		private readonly global::Org.BouncyCastle.Crypto.Modes.GcmBlockCipher cipher;

		// Token: 0x0400119A RID: 4506
		private readonly int macSizeBits;
	}
}
