using System;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200034D RID: 845
	public class SimulatedTlsSrpIdentityManager : global::Org.BouncyCastle.Crypto.Tls.TlsSrpIdentityManager
	{
		// Token: 0x060022BB RID: 8891 RVA: 0x00098A30 File Offset: 0x00096C30
		public static global::Org.BouncyCastle.Crypto.Tls.SimulatedTlsSrpIdentityManager GetRfc5054Default(global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters group, byte[] seedKey)
		{
			global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6VerifierGenerator verifierGenerator = new global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6VerifierGenerator();
			verifierGenerator.Init(group, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(2));
			global::Org.BouncyCastle.Crypto.Macs.HMac mac = new global::Org.BouncyCastle.Crypto.Macs.HMac(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(2));
			mac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(seedKey));
			return new global::Org.BouncyCastle.Crypto.Tls.SimulatedTlsSrpIdentityManager(group, verifierGenerator, mac);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00098A70 File Offset: 0x00096C70
		public SimulatedTlsSrpIdentityManager(global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters group, global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6VerifierGenerator verifierGenerator, global::Org.BouncyCastle.Crypto.IMac mac)
		{
			this.mGroup = group;
			this.mVerifierGenerator = verifierGenerator;
			this.mMac = mac;
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00098A90 File Offset: 0x00096C90
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsSrpLoginParameters GetLoginParameters(byte[] identity)
		{
			this.mMac.BlockUpdate(global::Org.BouncyCastle.Crypto.Tls.SimulatedTlsSrpIdentityManager.PREFIX_SALT, 0, global::Org.BouncyCastle.Crypto.Tls.SimulatedTlsSrpIdentityManager.PREFIX_SALT.Length);
			this.mMac.BlockUpdate(identity, 0, identity.Length);
			byte[] salt = new byte[this.mMac.GetMacSize()];
			this.mMac.DoFinal(salt, 0);
			this.mMac.BlockUpdate(global::Org.BouncyCastle.Crypto.Tls.SimulatedTlsSrpIdentityManager.PREFIX_PASSWORD, 0, global::Org.BouncyCastle.Crypto.Tls.SimulatedTlsSrpIdentityManager.PREFIX_PASSWORD.Length);
			this.mMac.BlockUpdate(identity, 0, identity.Length);
			byte[] password = new byte[this.mMac.GetMacSize()];
			this.mMac.DoFinal(password, 0);
			global::Org.BouncyCastle.Math.BigInteger verifier = this.mVerifierGenerator.GenerateVerifier(salt, identity, password);
			return new global::Org.BouncyCastle.Crypto.Tls.TlsSrpLoginParameters(this.mGroup, verifier, salt);
		}

		// Token: 0x04000E13 RID: 3603
		private static readonly byte[] PREFIX_PASSWORD = global::Org.BouncyCastle.Utilities.Strings.ToByteArray("password");

		// Token: 0x04000E14 RID: 3604
		private static readonly byte[] PREFIX_SALT = global::Org.BouncyCastle.Utilities.Strings.ToByteArray("salt");

		// Token: 0x04000E15 RID: 3605
		protected readonly global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters mGroup;

		// Token: 0x04000E16 RID: 3606
		protected readonly global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6VerifierGenerator mVerifierGenerator;

		// Token: 0x04000E17 RID: 3607
		protected readonly global::Org.BouncyCastle.Crypto.IMac mMac;
	}
}
