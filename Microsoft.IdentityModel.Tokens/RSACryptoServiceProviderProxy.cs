using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000030 RID: 48
	public class RSACryptoServiceProviderProxy : global::System.IDisposable
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00006724 File Offset: 0x00004924
		public RSACryptoServiceProviderProxy(global::System.Security.Cryptography.RSACryptoServiceProvider rsa)
		{
			if (rsa == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("rsa");
			}
			if ((rsa.CspKeyContainerInfo.ProviderType == 1 || rsa.CspKeyContainerInfo.ProviderType == 12) && !rsa.CspKeyContainerInfo.HardwareDevice)
			{
				global::System.Security.Cryptography.CspParameters cspParameters = new global::System.Security.Cryptography.CspParameters();
				cspParameters.ProviderType = 24;
				cspParameters.KeyContainerName = rsa.CspKeyContainerInfo.KeyContainerName;
				cspParameters.KeyNumber = (int)rsa.CspKeyContainerInfo.KeyNumber;
				if (rsa.CspKeyContainerInfo.MachineKeyStore)
				{
					cspParameters.Flags = global::System.Security.Cryptography.CspProviderFlags.UseMachineKeyStore;
				}
				cspParameters.Flags |= global::System.Security.Cryptography.CspProviderFlags.UseExistingKey;
				this._rsa = new global::System.Security.Cryptography.RSACryptoServiceProvider(cspParameters);
				this._disposeRsa = true;
				return;
			}
			this._rsa = rsa;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000067DC File Offset: 0x000049DC
		~RSACryptoServiceProviderProxy()
		{
			this.Dispose(false);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000680C File Offset: 0x00004A0C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000681B File Offset: 0x00004A1B
		public byte[] Decrypt(byte[] input, bool fOAEP)
		{
			return this._rsa.Decrypt(input, fOAEP);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000682A File Offset: 0x00004A2A
		public byte[] Encrypt(byte[] input, bool fOAEP)
		{
			return this._rsa.Encrypt(input, fOAEP);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006839 File Offset: 0x00004A39
		public byte[] SignData(byte[] signingInput, object hash)
		{
			return this._rsa.SignData(signingInput, hash);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006848 File Offset: 0x00004A48
		public bool VerifyData(byte[] signingInput, object hash, byte[] signature)
		{
			return this._rsa.VerifyData(signingInput, hash, signature);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006858 File Offset: 0x00004A58
		private void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing && this._disposeRsa && this._rsa != null)
				{
					this._rsa.Dispose();
					this._rsa = null;
				}
				this._disposed = true;
			}
		}

		// Token: 0x04000110 RID: 272
		private const int PROV_RSA_AES = 24;

		// Token: 0x04000111 RID: 273
		private const int PROV_RSA_FULL = 1;

		// Token: 0x04000112 RID: 274
		private const int PROV_RSA_SCHANNEL = 12;

		// Token: 0x04000113 RID: 275
		private bool _disposed;

		// Token: 0x04000114 RID: 276
		private bool _disposeRsa;

		// Token: 0x04000115 RID: 277
		private global::System.Security.Cryptography.RSACryptoServiceProvider _rsa;
	}
}
