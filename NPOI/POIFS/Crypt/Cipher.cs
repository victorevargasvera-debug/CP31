using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002F5 RID: 757
	public class Cipher
	{
		// Token: 0x060015CB RID: 5579 RVA: 0x000410A0 File Offset: 0x0003F2A0
		public byte[] DoFinal(byte[] block)
		{
			return this.cipherImpl.DoFinal(block);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x000410AE File Offset: 0x0003F2AE
		public int DoFinal(byte[] input, int inputOffset, int inputLen, byte[] output)
		{
			return this.cipherImpl.DoFinal(input, inputOffset, inputLen, output, 0);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x000410C1 File Offset: 0x0003F2C1
		public static global::NPOI.POIFS.Crypt.Cipher GetInstance(string transformation)
		{
			return new global::NPOI.POIFS.Crypt.Cipher
			{
				cipherImpl = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(transformation)
			};
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x000410D4 File Offset: 0x0003F2D4
		public static global::NPOI.POIFS.Crypt.Cipher GetInstance(string transformation, string provider)
		{
			return global::NPOI.POIFS.Crypt.Cipher.GetInstance(transformation);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000410DC File Offset: 0x0003F2DC
		public void Init(int cipherMode, global::NPOI.POIFS.Crypt.IKey key, global::NPOI.POIFS.Crypt.AlgorithmParameterSpec aps)
		{
			global::Org.BouncyCastle.Crypto.ICipherParameters parameters;
			if (aps is global::NPOI.POIFS.Crypt.RC2ParameterSpec)
			{
				parameters = new global::Org.BouncyCastle.Crypto.Parameters.RC2Parameters(key.GetEncoded(), (aps as global::NPOI.POIFS.Crypt.RC2ParameterSpec).GetEffectiveKeyBits());
			}
			else
			{
				if (!(aps is global::NPOI.POIFS.Crypt.IvParameterSpec))
				{
					throw new global::System.NotImplementedException();
				}
				parameters = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key.GetEncoded());
				parameters = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters, (aps as global::NPOI.POIFS.Crypt.IvParameterSpec).GetIV());
			}
			this.cipherImpl.Init(cipherMode == global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE, parameters);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0004114C File Offset: 0x0003F34C
		public void Init(int cipherMode, global::NPOI.POIFS.Crypt.IKey key)
		{
			global::Org.BouncyCastle.Crypto.ICipherParameters parameters = new global::Org.BouncyCastle.Crypto.Parameters.RC2Parameters(key.GetEncoded());
			this.cipherImpl.Init(cipherMode == global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE, parameters);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00041179 File Offset: 0x0003F379
		public void Init(int cipherMode, global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters)
		{
			this.cipherImpl.Init(cipherMode == global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE, cipherParameters);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00041190 File Offset: 0x0003F390
		public static int GetMaxAllowedKeyLength(string jceId)
		{
			if (jceId == "RC2")
			{
				return 128;
			}
			if (jceId == "RC4")
			{
				return 128;
			}
			if (jceId == "DES")
			{
				return 64;
			}
			if (jceId == "AES")
			{
				return 128;
			}
			if (jceId == "DESede")
			{
				return int.MaxValue;
			}
			if (!(jceId == "RSA"))
			{
				throw new global::System.NotImplementedException();
			}
			return int.MaxValue;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00041213 File Offset: 0x0003F413
		public void Update(byte[] input, int inputOffset, int inputLen, byte[] output)
		{
			if (input == null || inputOffset < 0 || inputLen > input.Length - inputOffset || inputLen < 0)
			{
				throw new global::System.ArgumentException("Bad arguments");
			}
			this.cipherImpl.ProcessBytes(input, inputOffset, inputLen, output, 0);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00041245 File Offset: 0x0003F445
		public void Update(byte[] input, int inputOffset, int inputLen, byte[] output, int outputOffset)
		{
			if (input == null || inputOffset < 0 || inputLen > input.Length - inputOffset || inputLen < 0 || outputOffset < 0)
			{
				throw new global::System.ArgumentException("Bad arguments");
			}
			this.cipherImpl.ProcessBytes(input, inputOffset, inputLen, output, outputOffset);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0004127D File Offset: 0x0003F47D
		public byte[] DoFinal()
		{
			return this.cipherImpl.DoFinal();
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0004128A File Offset: 0x0003F48A
		public byte[] Update(byte[] ibuffer, int inOff, int length)
		{
			return this.cipherImpl.ProcessBytes(ibuffer, inOff, length);
		}

		// Token: 0x040008CC RID: 2252
		public static int DECRYPT_MODE = 2;

		// Token: 0x040008CD RID: 2253
		public static int ENCRYPT_MODE = 1;

		// Token: 0x040008CE RID: 2254
		public static int WRAP_MODE = 3;

		// Token: 0x040008CF RID: 2255
		public static int UNWRAP_MODE = 4;

		// Token: 0x040008D0 RID: 2256
		public static int PUBLIC_KEY = 1;

		// Token: 0x040008D1 RID: 2257
		public static int PRIVATE_KEY = 2;

		// Token: 0x040008D2 RID: 2258
		public static int SECRET_KEY = 3;

		// Token: 0x040008D3 RID: 2259
		protected global::Org.BouncyCastle.Crypto.IBufferedCipher cipherImpl;
	}
}
