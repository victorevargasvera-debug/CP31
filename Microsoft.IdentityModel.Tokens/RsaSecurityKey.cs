using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000031 RID: 49
	public class RsaSecurityKey : global::Microsoft.IdentityModel.Tokens.AsymmetricSecurityKey
	{
		// Token: 0x06000137 RID: 311 RVA: 0x00006890 File Offset: 0x00004A90
		public RsaSecurityKey(global::System.Security.Cryptography.RSAParameters rsaParameters)
		{
			if (rsaParameters.Modulus == null || rsaParameters.Exponent == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10700: Invalid RsaParameters: '{0}'. Both modulus and exponent should be present", new object[]
				{
					rsaParameters.ToString()
				})));
			}
			this._hasPrivateKey = new bool?(rsaParameters.D != null && rsaParameters.DP != null && rsaParameters.DQ != null && rsaParameters.P != null && rsaParameters.Q != null && rsaParameters.InverseQ != null);
			this._foundPrivateKey = (this._hasPrivateKey.Value ? global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.Exists : global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.DoesNotExist);
			this._foundPrivateKeyDetermined = true;
			this.Parameters = rsaParameters;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006942 File Offset: 0x00004B42
		public RsaSecurityKey(global::System.Security.Cryptography.RSA rsa)
		{
			if (rsa == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rsa");
			}
			this.Rsa = rsa;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00006960 File Offset: 0x00004B60
		[global::System.Obsolete("HasPrivateKey method is deprecated, please use FoundPrivateKey instead.")]
		public override bool HasPrivateKey
		{
			get
			{
				if (this._hasPrivateKey == null)
				{
					try
					{
						byte[] array = new byte[20];
						global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = this.Rsa as global::System.Security.Cryptography.RSACryptoServiceProvider;
						if (rsacryptoServiceProvider != null)
						{
							rsacryptoServiceProvider.SignData(array, "SHA256");
						}
						else
						{
							this.Rsa.DecryptValue(array);
						}
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

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000069E8 File Offset: 0x00004BE8
		public override global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus PrivateKeyStatus
		{
			get
			{
				if (this._foundPrivateKeyDetermined)
				{
					return this._foundPrivateKey;
				}
				this._foundPrivateKeyDetermined = true;
				if (this.Rsa != null)
				{
					try
					{
						global::System.Security.Cryptography.RSAParameters rsaparameters = this.Rsa.ExportParameters(true);
						if (rsaparameters.D != null && rsaparameters.DP != null && rsaparameters.DQ != null && rsaparameters.P != null && rsaparameters.Q != null && rsaparameters.InverseQ != null)
						{
							this._foundPrivateKey = global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.Exists;
						}
						else
						{
							this._foundPrivateKey = global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.DoesNotExist;
						}
						goto IL_DC;
					}
					catch (global::System.Exception)
					{
						this._foundPrivateKey = global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.Unknown;
						return this._foundPrivateKey;
					}
				}
				if (this.Parameters.D != null && this.Parameters.DP != null && this.Parameters.DQ != null && this.Parameters.P != null && this.Parameters.Q != null && this.Parameters.InverseQ != null)
				{
					this._foundPrivateKey = global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.Exists;
				}
				else
				{
					this._foundPrivateKey = global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.DoesNotExist;
				}
				IL_DC:
				return this._foundPrivateKey;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00006AEC File Offset: 0x00004CEC
		public override int KeySize
		{
			get
			{
				if (this.Rsa != null)
				{
					return this.Rsa.KeySize;
				}
				if (this.Parameters.Modulus != null)
				{
					return this.Parameters.Modulus.Length * 8;
				}
				return 0;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00006B20 File Offset: 0x00004D20
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00006B28 File Offset: 0x00004D28
		public global::System.Security.Cryptography.RSAParameters Parameters { get; private set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00006B31 File Offset: 0x00004D31
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00006B39 File Offset: 0x00004D39
		public global::System.Security.Cryptography.RSA Rsa { get; private set; }

		// Token: 0x04000116 RID: 278
		private bool? _hasPrivateKey;

		// Token: 0x04000117 RID: 279
		private bool _foundPrivateKeyDetermined;

		// Token: 0x04000118 RID: 280
		private global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus _foundPrivateKey;
	}
}
