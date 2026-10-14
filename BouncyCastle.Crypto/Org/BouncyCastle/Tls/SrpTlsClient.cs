using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000F1 RID: 241
	public class SrpTlsClient : global::Org.BouncyCastle.Tls.AbstractTlsClient
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x0002378B File Offset: 0x0002198B
		public SrpTlsClient(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, byte[] identity, byte[] password) : this(crypto, new global::Org.BouncyCastle.Tls.BasicTlsSrpIdentity(identity, password))
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0002379B File Offset: 0x0002199B
		public SrpTlsClient(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.TlsSrpIdentity srpIdentity) : base(crypto)
		{
			this.m_srpIdentity = srpIdentity;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000237AB File Offset: 0x000219AB
		protected override int[] GetSupportedCipherSuites()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetSupportedCipherSuites(this.Crypto, global::Org.BouncyCastle.Tls.SrpTlsClient.DefaultCipherSuites);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x000237BD File Offset: 0x000219BD
		protected override global::Org.BouncyCastle.Tls.ProtocolVersion[] GetSupportedVersions()
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.DownTo(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x000237CE File Offset: 0x000219CE
		protected virtual bool RequireSrpServerExtension
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000237D1 File Offset: 0x000219D1
		public override global::System.Collections.IDictionary GetClientExtensions()
		{
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(base.GetClientExtensions());
			global::Org.BouncyCastle.Tls.TlsSrpUtilities.AddSrpExtension(dictionary, this.m_srpIdentity.GetSrpIdentity());
			return dictionary;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000237EF File Offset: 0x000219EF
		public override void ProcessServerExtensions(global::System.Collections.IDictionary serverExtensions)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(serverExtensions, 12, 47) && this.RequireSrpServerExtension)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			base.ProcessServerExtensions(serverExtensions);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00023814 File Offset: 0x00021A14
		public override global::Org.BouncyCastle.Tls.TlsSrpIdentity GetSrpIdentity()
		{
			return this.m_srpIdentity;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0002381C File Offset: 0x00021A1C
		public override global::Org.BouncyCastle.Tls.TlsAuthentication GetAuthentication()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x040006C1 RID: 1729
		private static readonly int[] DefaultCipherSuites = new int[]
		{
			49182
		};

		// Token: 0x040006C2 RID: 1730
		protected readonly global::Org.BouncyCastle.Tls.TlsSrpIdentity m_srpIdentity;
	}
}
