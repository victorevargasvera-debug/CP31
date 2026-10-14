using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000086 RID: 134
	public abstract class AbstractTlsClient : global::Org.BouncyCastle.Tls.AbstractTlsPeer, global::Org.BouncyCastle.Tls.TlsClient, global::Org.BouncyCastle.Tls.TlsPeer
	{
		// Token: 0x0600054C RID: 1356 RVA: 0x000183B0 File Offset: 0x000165B0
		protected AbstractTlsClient(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto) : base(crypto)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000183B9 File Offset: 0x000165B9
		protected virtual bool AllowUnexpectedServerExtension(int extensionType, byte[] extensionData)
		{
			if (extensionType == 10)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadSupportedGroupsExtension(extensionData);
				return true;
			}
			if (extensionType != 11)
			{
				return false;
			}
			global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadSupportedPointFormatsExtension(extensionData);
			return true;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000183DC File Offset: 0x000165DC
		protected virtual global::System.Collections.IList GetNamedGroupRoles()
		{
			global::System.Collections.IList namedGroupRoles = global::Org.BouncyCastle.Tls.TlsUtilities.GetNamedGroupRoles(this.GetCipherSuites());
			global::System.Collections.IList sigAlgs = this.m_supportedSignatureAlgorithms;
			global::System.Collections.IList sigAlgsCert = this.m_supportedSignatureAlgorithmsCert;
			if (sigAlgs == null || global::Org.BouncyCastle.Tls.TlsUtilities.ContainsAnySignatureAlgorithm(sigAlgs, 3) || (sigAlgsCert != null && global::Org.BouncyCastle.Tls.TlsUtilities.ContainsAnySignatureAlgorithm(sigAlgsCert, 3)))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.AddToSet(namedGroupRoles, 3);
			}
			return namedGroupRoles;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00018424 File Offset: 0x00016624
		protected virtual void CheckForUnexpectedServerExtension(global::System.Collections.IDictionary serverExtensions, int extensionType)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(serverExtensions, extensionType);
			if (extensionData != null && !this.AllowUnexpectedServerExtension(extensionType, extensionData))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0001844E File Offset: 0x0001664E
		public virtual global::Org.BouncyCastle.Tls.TlsPskIdentity GetPskIdentity()
		{
			return null;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00018451 File Offset: 0x00016651
		public virtual global::Org.BouncyCastle.Tls.TlsSrpIdentity GetSrpIdentity()
		{
			return null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00018454 File Offset: 0x00016654
		public virtual global::Org.BouncyCastle.Tls.TlsDHGroupVerifier GetDHGroupVerifier()
		{
			return new global::Org.BouncyCastle.Tls.DefaultTlsDHGroupVerifier();
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0001845B File Offset: 0x0001665B
		public virtual global::Org.BouncyCastle.Tls.TlsSrpConfigVerifier GetSrpConfigVerifier()
		{
			return new global::Org.BouncyCastle.Tls.DefaultTlsSrpConfigVerifier();
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00018462 File Offset: 0x00016662
		protected virtual global::System.Collections.IList GetCertificateAuthorities()
		{
			return null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00018465 File Offset: 0x00016665
		protected virtual global::System.Collections.IList GetProtocolNames()
		{
			return null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00018468 File Offset: 0x00016668
		protected virtual global::Org.BouncyCastle.Tls.CertificateStatusRequest GetCertificateStatusRequest()
		{
			return new global::Org.BouncyCastle.Tls.CertificateStatusRequest(1, new global::Org.BouncyCastle.Tls.OcspStatusRequest(null, null));
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00018477 File Offset: 0x00016677
		protected virtual global::System.Collections.IList GetMultiCertStatusRequest()
		{
			return null;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0001847A File Offset: 0x0001667A
		protected virtual global::System.Collections.IList GetSniServerNames()
		{
			return null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00018480 File Offset: 0x00016680
		protected virtual global::System.Collections.IList GetSupportedGroups(global::System.Collections.IList namedGroupRoles)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto = this.Crypto;
			global::System.Collections.IList supportedGroups = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (namedGroupRoles.Contains(2))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.AddIfSupported(supportedGroups, crypto, new int[]
				{
					29,
					30
				});
			}
			if (namedGroupRoles.Contains(2) || namedGroupRoles.Contains(3))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.AddIfSupported(supportedGroups, crypto, new int[]
				{
					23,
					24
				});
			}
			if (namedGroupRoles.Contains(1))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.AddIfSupported(supportedGroups, crypto, new int[]
				{
					256,
					257,
					258
				});
			}
			return supportedGroups;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00018519 File Offset: 0x00016719
		protected virtual global::System.Collections.IList GetSupportedSignatureAlgorithms()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetDefaultSupportedSignatureAlgorithms(this.m_context);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00018526 File Offset: 0x00016726
		protected virtual global::System.Collections.IList GetSupportedSignatureAlgorithmsCert()
		{
			return null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00018529 File Offset: 0x00016729
		protected virtual global::System.Collections.IList GetTrustedCAIndication()
		{
			return null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0001852C File Offset: 0x0001672C
		public virtual void Init(global::Org.BouncyCastle.Tls.TlsClientContext context)
		{
			this.m_context = context;
			this.m_protocolVersions = this.GetSupportedVersions();
			this.m_cipherSuites = this.GetSupportedCipherSuites();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0001854D File Offset: 0x0001674D
		public override global::Org.BouncyCastle.Tls.ProtocolVersion[] GetProtocolVersions()
		{
			return this.m_protocolVersions;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00018555 File Offset: 0x00016755
		public override int[] GetCipherSuites()
		{
			return this.m_cipherSuites;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001855D File Offset: 0x0001675D
		public override void NotifyHandshakeBeginning()
		{
			base.NotifyHandshakeBeginning();
			this.m_supportedGroups = null;
			this.m_supportedSignatureAlgorithms = null;
			this.m_supportedSignatureAlgorithmsCert = null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001857A File Offset: 0x0001677A
		public virtual global::Org.BouncyCastle.Tls.TlsSession GetSessionToResume()
		{
			return null;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001857D File Offset: 0x0001677D
		public virtual global::System.Collections.IList GetExternalPsks()
		{
			return null;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00018580 File Offset: 0x00016780
		public virtual bool IsFallback()
		{
			return false;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00018584 File Offset: 0x00016784
		public virtual global::System.Collections.IDictionary GetClientExtensions()
		{
			global::System.Collections.IDictionary clientExtensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			bool offeringTlsV13Plus = false;
			bool offeringPreTlsV13 = false;
			global::Org.BouncyCastle.Tls.ProtocolVersion[] supportedVersions = this.GetProtocolVersions();
			for (int i = 0; i < supportedVersions.Length; i++)
			{
				if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(supportedVersions[i]))
				{
					offeringTlsV13Plus = true;
				}
				else
				{
					offeringPreTlsV13 = true;
				}
			}
			global::System.Collections.IList protocolNames = this.GetProtocolNames();
			if (protocolNames != null)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddAlpnExtensionClient(clientExtensions, protocolNames);
			}
			global::System.Collections.IList sniServerNames = this.GetSniServerNames();
			if (sniServerNames != null)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddServerNameExtensionClient(clientExtensions, sniServerNames);
			}
			global::Org.BouncyCastle.Tls.CertificateStatusRequest statusRequest = this.GetCertificateStatusRequest();
			if (statusRequest != null)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddStatusRequestExtension(clientExtensions, statusRequest);
			}
			if (offeringTlsV13Plus)
			{
				global::System.Collections.IList certificateAuthorities = this.GetCertificateAuthorities();
				if (certificateAuthorities != null)
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddCertificateAuthoritiesExtension(clientExtensions, certificateAuthorities);
				}
			}
			if (offeringPreTlsV13)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddEncryptThenMacExtension(clientExtensions);
				global::System.Collections.IList statusRequestV2 = this.GetMultiCertStatusRequest();
				if (statusRequestV2 != null)
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddStatusRequestV2Extension(clientExtensions, statusRequestV2);
				}
				global::System.Collections.IList trustedCAKeys = this.GetTrustedCAIndication();
				if (trustedCAKeys != null)
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddTrustedCAKeysExtensionClient(clientExtensions, trustedCAKeys);
				}
			}
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(this.m_context.ClientVersion))
			{
				global::System.Collections.IList supportedSigAlgs = this.GetSupportedSignatureAlgorithms();
				if (supportedSigAlgs != null && supportedSigAlgs.Count > 0)
				{
					this.m_supportedSignatureAlgorithms = supportedSigAlgs;
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSignatureAlgorithmsExtension(clientExtensions, supportedSigAlgs);
				}
				global::System.Collections.IList supportedSigAlgsCert = this.GetSupportedSignatureAlgorithmsCert();
				if (supportedSigAlgsCert != null && supportedSigAlgsCert.Count > 0)
				{
					this.m_supportedSignatureAlgorithmsCert = supportedSigAlgsCert;
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSignatureAlgorithmsCertExtension(clientExtensions, supportedSigAlgsCert);
				}
			}
			global::System.Collections.IList namedGroupRoles = this.GetNamedGroupRoles();
			global::System.Collections.IList supportedGroups = this.GetSupportedGroups(namedGroupRoles);
			if (supportedGroups != null && supportedGroups.Count > 0)
			{
				this.m_supportedGroups = supportedGroups;
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSupportedGroupsExtension(clientExtensions, supportedGroups);
			}
			if (offeringPreTlsV13 && (namedGroupRoles.Contains(2) || namedGroupRoles.Contains(3)))
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSupportedPointFormatsExtension(clientExtensions, new short[1]);
			}
			return clientExtensions;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00018708 File Offset: 0x00016908
		public virtual global::System.Collections.IList GetEarlyKeyShareGroups()
		{
			if (this.m_supportedGroups == null || this.m_supportedGroups.Count < 1)
			{
				return null;
			}
			if (this.m_supportedGroups.Contains(29))
			{
				return global::Org.BouncyCastle.Tls.TlsUtilities.VectorOfOne(29);
			}
			if (this.m_supportedGroups.Contains(23))
			{
				return global::Org.BouncyCastle.Tls.TlsUtilities.VectorOfOne(23);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.VectorOfOne(this.m_supportedGroups[0]);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00018780 File Offset: 0x00016980
		public virtual void NotifyServerVersion(global::Org.BouncyCastle.Tls.ProtocolVersion serverVersion)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00018782 File Offset: 0x00016982
		public virtual void NotifySessionToResume(global::Org.BouncyCastle.Tls.TlsSession session)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00018784 File Offset: 0x00016984
		public virtual void NotifySessionID(byte[] sessionID)
		{
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00018786 File Offset: 0x00016986
		public virtual void NotifySelectedCipherSuite(int selectedCipherSuite)
		{
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00018788 File Offset: 0x00016988
		public virtual void NotifySelectedPsk(global::Org.BouncyCastle.Tls.TlsPsk selectedPsk)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001878C File Offset: 0x0001698C
		public virtual void ProcessServerExtensions(global::System.Collections.IDictionary serverExtensions)
		{
			if (serverExtensions == null)
			{
				return;
			}
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_context.SecurityParameters;
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
			{
				this.CheckForUnexpectedServerExtension(serverExtensions, 13);
				this.CheckForUnexpectedServerExtension(serverExtensions, 50);
				this.CheckForUnexpectedServerExtension(serverExtensions, 10);
				if (global::Org.BouncyCastle.Tls.TlsEccUtilities.IsEccCipherSuite(securityParameters.CipherSuite))
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedPointFormatsExtension(serverExtensions);
				}
				else
				{
					this.CheckForUnexpectedServerExtension(serverExtensions, 11);
				}
				this.CheckForUnexpectedServerExtension(serverExtensions, 21);
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000187F9 File Offset: 0x000169F9
		public virtual void ProcessServerSupplementalData(global::System.Collections.IList serverSupplementalData)
		{
			if (serverSupplementalData != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x0600056D RID: 1389
		public abstract global::Org.BouncyCastle.Tls.TlsAuthentication GetAuthentication();

		// Token: 0x0600056E RID: 1390 RVA: 0x00018806 File Offset: 0x00016A06
		public virtual global::System.Collections.IList GetClientSupplementalData()
		{
			return null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00018809 File Offset: 0x00016A09
		public virtual void NotifyNewSessionTicket(global::Org.BouncyCastle.Tls.NewSessionTicket newSessionTicket)
		{
		}

		// Token: 0x040002E1 RID: 737
		protected global::Org.BouncyCastle.Tls.TlsClientContext m_context;

		// Token: 0x040002E2 RID: 738
		protected global::Org.BouncyCastle.Tls.ProtocolVersion[] m_protocolVersions;

		// Token: 0x040002E3 RID: 739
		protected int[] m_cipherSuites;

		// Token: 0x040002E4 RID: 740
		protected global::System.Collections.IList m_supportedGroups;

		// Token: 0x040002E5 RID: 741
		protected global::System.Collections.IList m_supportedSignatureAlgorithms;

		// Token: 0x040002E6 RID: 742
		protected global::System.Collections.IList m_supportedSignatureAlgorithmsCert;
	}
}
