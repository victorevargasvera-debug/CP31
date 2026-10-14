using System;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000038 RID: 56
	public abstract class SignatureProvider : global::System.IDisposable
	{
		// Token: 0x0600016F RID: 367 RVA: 0x00006CA2 File Offset: 0x00004EA2
		protected SignatureProvider(global::Microsoft.IdentityModel.Tokens.SecurityKey key, string algorithm)
		{
			if (key == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("key");
			}
			this.Key = key;
			if (!string.IsNullOrEmpty(algorithm))
			{
				this.Algorithm = algorithm;
				return;
			}
			throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("algorithm");
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00006CDC File Offset: 0x00004EDC
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public string Algorithm { get; private set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00006CED File Offset: 0x00004EED
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00006CF5 File Offset: 0x00004EF5
		public string Context { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00006CFE File Offset: 0x00004EFE
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00006D06 File Offset: 0x00004F06
		public global::Microsoft.IdentityModel.Tokens.CryptoProviderCache CryptoProviderCache { get; set; }

		// Token: 0x06000176 RID: 374 RVA: 0x00006D0F File Offset: 0x00004F0F
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000177 RID: 375
		protected abstract void Dispose(bool disposing);

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00006D1E File Offset: 0x00004F1E
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00006D26 File Offset: 0x00004F26
		public global::Microsoft.IdentityModel.Tokens.SecurityKey Key { get; private set; }

		// Token: 0x0600017A RID: 378
		public abstract byte[] Sign(byte[] input);

		// Token: 0x0600017B RID: 379
		public abstract bool Verify(byte[] input, byte[] signature);

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00006D2F File Offset: 0x00004F2F
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00006D37 File Offset: 0x00004F37
		public bool WillCreateSignatures { get; protected set; }
	}
}
