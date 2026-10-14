using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200034E RID: 846
	public class SrpTlsClient : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsClient
	{
		// Token: 0x060022BF RID: 8895 RVA: 0x00098B67 File Offset: 0x00096D67
		public SrpTlsClient(byte[] identity, byte[] password) : this(new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory(), new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier(), identity, password)
		{
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00098B7B File Offset: 0x00096D7B
		public SrpTlsClient(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory, byte[] identity, byte[] password) : this(cipherFactory, new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier(), identity, password)
		{
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00098B8B File Offset: 0x00096D8B
		public SrpTlsClient(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory, global::Org.BouncyCastle.Crypto.Tls.TlsSrpGroupVerifier groupVerifier, byte[] identity, byte[] password) : base(cipherFactory)
		{
			this.mGroupVerifier = groupVerifier;
			this.mIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(identity);
			this.mPassword = global::Org.BouncyCastle.Utilities.Arrays.Clone(password);
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x00098BB4 File Offset: 0x00096DB4
		protected virtual bool RequireSrpServerExtension
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00098BB7 File Offset: 0x00096DB7
		public override int[] GetCipherSuites()
		{
			return new int[]
			{
				49182
			};
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00098BC7 File Offset: 0x00096DC7
		public override global::System.Collections.IDictionary GetClientExtensions()
		{
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(base.GetClientExtensions());
			global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.AddSrpExtension(dictionary, this.mIdentity);
			return dictionary;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00098BE0 File Offset: 0x00096DE0
		public override void ProcessServerExtensions(global::System.Collections.IDictionary serverExtensions)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(serverExtensions, 12, 47) && this.RequireSrpServerExtension)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			base.ProcessServerExtensions(serverExtensions);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00098C08 File Offset: 0x00096E08
		public override global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange()
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			if (keyExchangeAlgorithm - 21 <= 2)
			{
				return this.CreateSrpKeyExchange(keyExchangeAlgorithm);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00098C37 File Offset: 0x00096E37
		public override global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication GetAuthentication()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00098C40 File Offset: 0x00096E40
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateSrpKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsSrpKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.mGroupVerifier, this.mIdentity, this.mPassword);
		}

		// Token: 0x04000E18 RID: 3608
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSrpGroupVerifier mGroupVerifier;

		// Token: 0x04000E19 RID: 3609
		protected byte[] mIdentity;

		// Token: 0x04000E1A RID: 3610
		protected byte[] mPassword;
	}
}
