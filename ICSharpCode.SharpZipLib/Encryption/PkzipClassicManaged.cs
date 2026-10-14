using System;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x02000059 RID: 89
	public sealed class PkzipClassicManaged : global::ICSharpCode.SharpZipLib.Encryption.PkzipClassic
	{
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00012E0A File Offset: 0x0001100A
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00012E0D File Offset: 0x0001100D
		public override int BlockSize
		{
			get
			{
				return 8;
			}
			set
			{
				if (value != 8)
				{
					throw new global::System.Security.Cryptography.CryptographicException("Block size is invalid");
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00012E1E File Offset: 0x0001101E
		public override global::System.Security.Cryptography.KeySizes[] LegalKeySizes
		{
			get
			{
				return new global::System.Security.Cryptography.KeySizes[]
				{
					new global::System.Security.Cryptography.KeySizes(96, 96, 0)
				};
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00012E33 File Offset: 0x00011033
		public override void GenerateIV()
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00012E35 File Offset: 0x00011035
		public override global::System.Security.Cryptography.KeySizes[] LegalBlockSizes
		{
			get
			{
				return new global::System.Security.Cryptography.KeySizes[]
				{
					new global::System.Security.Cryptography.KeySizes(8, 8, 0)
				};
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00012E48 File Offset: 0x00011048
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00012E68 File Offset: 0x00011068
		public override byte[] Key
		{
			get
			{
				if (this.key_ == null)
				{
					this.GenerateKey();
				}
				return (byte[])this.key_.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				if (value.Length != 12)
				{
					throw new global::System.Security.Cryptography.CryptographicException("Key size is illegal");
				}
				this.key_ = (byte[])value.Clone();
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00012E9C File Offset: 0x0001109C
		public override void GenerateKey()
		{
			this.key_ = new byte[12];
			using (global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(this.key_);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00012EE4 File Offset: 0x000110E4
		public override global::System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			this.key_ = rgbKey;
			return new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicEncryptCryptoTransform(this.Key);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00012EF8 File Offset: 0x000110F8
		public override global::System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			this.key_ = rgbKey;
			return new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicDecryptCryptoTransform(this.Key);
		}

		// Token: 0x04000274 RID: 628
		private byte[] key_;
	}
}
