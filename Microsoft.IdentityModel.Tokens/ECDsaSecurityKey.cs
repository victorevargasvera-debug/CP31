using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000009 RID: 9
	public class ECDsaSecurityKey : global::Microsoft.IdentityModel.Tokens.AsymmetricSecurityKey
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00003A58 File Offset: 0x00001C58
		public ECDsaSecurityKey(global::System.Security.Cryptography.ECDsa ecdsa)
		{
			if (ecdsa == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("ecdsa");
			}
			this.ECDsa = ecdsa;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003A75 File Offset: 0x00001C75
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00003A7D File Offset: 0x00001C7D
		public global::System.Security.Cryptography.ECDsa ECDsa { get; private set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00003A88 File Offset: 0x00001C88
		[global::System.Obsolete("HasPrivateKey method is deprecated, please use FoundPrivateKey instead.")]
		public override bool HasPrivateKey
		{
			get
			{
				if (this._hasPrivateKey == null)
				{
					try
					{
						byte[] hash = new byte[20];
						this.ECDsa.SignHash(hash);
						this._hasPrivateKey = new bool?(true);
					}
					catch (global::System.Security.Cryptography.CryptographicException)
					{
						this._hasPrivateKey = new bool?(false);
					}
				}
				return this._hasPrivateKey.Value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003AF0 File Offset: 0x00001CF0
		public override global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus PrivateKeyStatus
		{
			get
			{
				return global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.Unknown;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003AF3 File Offset: 0x00001CF3
		public override int KeySize
		{
			get
			{
				return this.ECDsa.KeySize;
			}
		}

		// Token: 0x0400001D RID: 29
		private bool? _hasPrivateKey;
	}
}
