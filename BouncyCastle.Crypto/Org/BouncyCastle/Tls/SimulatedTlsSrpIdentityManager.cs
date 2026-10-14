using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000F0 RID: 240
	public class SimulatedTlsSrpIdentityManager : global::Org.BouncyCastle.Tls.TlsSrpIdentityManager
	{
		// Token: 0x060008BD RID: 2237 RVA: 0x00023640 File Offset: 0x00021840
		public static global::Org.BouncyCastle.Tls.SimulatedTlsSrpIdentityManager GetRfc5054Default(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.Crypto.Srp6Group group, byte[] seedKey)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsMac mac = crypto.CreateHmac(2);
			mac.SetKey(seedKey, 0, seedKey.Length);
			global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig = new global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig();
			srpConfig.SetExplicitNG(new global::Org.BouncyCastle.Math.BigInteger[]
			{
				group.N,
				group.G
			});
			return new global::Org.BouncyCastle.Tls.SimulatedTlsSrpIdentityManager(group, crypto.CreateSrp6VerifierGenerator(srpConfig), mac);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00023692 File Offset: 0x00021892
		public SimulatedTlsSrpIdentityManager(global::Org.BouncyCastle.Tls.Crypto.Srp6Group group, global::Org.BouncyCastle.Tls.Crypto.TlsSrp6VerifierGenerator verifierGenerator, global::Org.BouncyCastle.Tls.Crypto.TlsMac mac)
		{
			this.m_group = group;
			this.m_verifierGenerator = verifierGenerator;
			this.m_mac = mac;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000236B0 File Offset: 0x000218B0
		public virtual global::Org.BouncyCastle.Tls.TlsSrpLoginParameters GetLoginParameters(byte[] identity)
		{
			this.m_mac.Update(global::Org.BouncyCastle.Tls.SimulatedTlsSrpIdentityManager.PrefixSalt, 0, global::Org.BouncyCastle.Tls.SimulatedTlsSrpIdentityManager.PrefixSalt.Length);
			this.m_mac.Update(identity, 0, identity.Length);
			byte[] salt = this.m_mac.CalculateMac();
			this.m_mac.Update(global::Org.BouncyCastle.Tls.SimulatedTlsSrpIdentityManager.PrefixPassword, 0, global::Org.BouncyCastle.Tls.SimulatedTlsSrpIdentityManager.PrefixPassword.Length);
			this.m_mac.Update(identity, 0, identity.Length);
			byte[] password = this.m_mac.CalculateMac();
			global::Org.BouncyCastle.Math.BigInteger verifier = this.m_verifierGenerator.GenerateVerifier(salt, identity, password);
			global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig = new global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig();
			srpConfig.SetExplicitNG(new global::Org.BouncyCastle.Math.BigInteger[]
			{
				this.m_group.N,
				this.m_group.G
			});
			return new global::Org.BouncyCastle.Tls.TlsSrpLoginParameters(identity, srpConfig, verifier, salt);
		}

		// Token: 0x040006BC RID: 1724
		private static readonly byte[] PrefixPassword = global::Org.BouncyCastle.Utilities.Strings.ToByteArray("password");

		// Token: 0x040006BD RID: 1725
		private static readonly byte[] PrefixSalt = global::Org.BouncyCastle.Utilities.Strings.ToByteArray("salt");

		// Token: 0x040006BE RID: 1726
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Srp6Group m_group;

		// Token: 0x040006BF RID: 1727
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsSrp6VerifierGenerator m_verifierGenerator;

		// Token: 0x040006C0 RID: 1728
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsMac m_mac;
	}
}
