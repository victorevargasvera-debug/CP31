using System;
using System.Threading;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002F5 RID: 757
	internal abstract class AbstractTlsContext : global::Org.BouncyCastle.Crypto.Tls.TlsContext
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x0009150A File Offset: 0x0008F70A
		private static long NextCounterValue()
		{
			return global::System.Threading.Interlocked.Increment(ref global::Org.BouncyCastle.Crypto.Tls.AbstractTlsContext.counter);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00091518 File Offset: 0x0008F718
		private static global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator CreateNonceRandom(global::Org.BouncyCastle.Security.SecureRandom secureRandom, int connectionEnd)
		{
			byte[] additionalSeedMaterial = new byte[16];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE((ulong)global::Org.BouncyCastle.Crypto.Tls.AbstractTlsContext.NextCounterValue(), additionalSeedMaterial, 0);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE((ulong)global::Org.BouncyCastle.Utilities.Times.NanoTime(), additionalSeedMaterial, 8);
			byte[] array = additionalSeedMaterial;
			int num = 0;
			array[num] &= 127;
			byte[] array2 = additionalSeedMaterial;
			int num2 = 0;
			array2[num2] |= (byte)(connectionEnd << 7);
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(4);
			byte[] seed = new byte[digest.GetDigestSize()];
			secureRandom.NextBytes(seed);
			global::Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator digestRandomGenerator = new global::Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator(digest);
			((global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator)digestRandomGenerator).AddSeedMaterial(additionalSeedMaterial);
			((global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator)digestRandomGenerator).AddSeedMaterial(seed);
			return digestRandomGenerator;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0009158F File Offset: 0x0008F78F
		internal AbstractTlsContext(global::Org.BouncyCastle.Security.SecureRandom secureRandom, global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters)
		{
			this.mSecureRandom = secureRandom;
			this.mSecurityParameters = securityParameters;
			this.mNonceRandom = global::Org.BouncyCastle.Crypto.Tls.AbstractTlsContext.CreateNonceRandom(secureRandom, securityParameters.Entity);
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x000915B7 File Offset: 0x0008F7B7
		public virtual global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator NonceRandomGenerator
		{
			get
			{
				return this.mNonceRandom;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x000915BF File Offset: 0x0008F7BF
		public virtual global::Org.BouncyCastle.Security.SecureRandom SecureRandom
		{
			get
			{
				return this.mSecureRandom;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x000915C7 File Offset: 0x0008F7C7
		public virtual global::Org.BouncyCastle.Crypto.Tls.SecurityParameters SecurityParameters
		{
			get
			{
				return this.mSecurityParameters;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600206E RID: 8302
		public abstract bool IsServer { get; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x000915CF File Offset: 0x0008F7CF
		public virtual global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion
		{
			get
			{
				return this.mClientVersion;
			}
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x000915D7 File Offset: 0x0008F7D7
		internal virtual void SetClientVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion clientVersion)
		{
			this.mClientVersion = clientVersion;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x000915E0 File Offset: 0x0008F7E0
		public virtual global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ServerVersion
		{
			get
			{
				return this.mServerVersion;
			}
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x000915E8 File Offset: 0x0008F7E8
		internal virtual void SetServerVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion serverVersion)
		{
			this.mServerVersion = serverVersion;
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x000915F1 File Offset: 0x0008F7F1
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsSession ResumableSession
		{
			get
			{
				return this.mSession;
			}
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x000915F9 File Offset: 0x0008F7F9
		internal virtual void SetResumableSession(global::Org.BouncyCastle.Crypto.Tls.TlsSession session)
		{
			this.mSession = session;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x00091602 File Offset: 0x0008F802
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x0009160A File Offset: 0x0008F80A
		public virtual object UserObject
		{
			get
			{
				return this.mUserObject;
			}
			set
			{
				this.mUserObject = value;
			}
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00091614 File Offset: 0x0008F814
		public virtual byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length)
		{
			if (context_value != null && !global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint16(context_value.Length))
			{
				throw new global::System.ArgumentException("must have length less than 2^16 (or be null)", "context_value");
			}
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters sp = this.SecurityParameters;
			if (!sp.IsExtendedMasterSecret)
			{
				throw new global::System.InvalidOperationException("cannot export keying material without extended_master_secret");
			}
			byte[] cr = sp.ClientRandom;
			byte[] sr = sp.ServerRandom;
			int seedLength = cr.Length + sr.Length;
			if (context_value != null)
			{
				seedLength += 2 + context_value.Length;
			}
			byte[] seed = new byte[seedLength];
			int seedPos = 0;
			global::System.Array.Copy(cr, 0, seed, seedPos, cr.Length);
			seedPos += cr.Length;
			global::System.Array.Copy(sr, 0, seed, seedPos, sr.Length);
			seedPos += sr.Length;
			if (context_value != null)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(context_value.Length, seed, seedPos);
				seedPos += 2;
				global::System.Array.Copy(context_value, 0, seed, seedPos, context_value.Length);
				seedPos += context_value.Length;
			}
			if (seedPos != seedLength)
			{
				throw new global::System.InvalidOperationException("error in calculation of seed for export");
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF(this, sp.MasterSecret, asciiLabel, seed, length);
		}

		// Token: 0x04000B45 RID: 2885
		private static long counter = global::Org.BouncyCastle.Utilities.Times.NanoTime();

		// Token: 0x04000B46 RID: 2886
		private readonly global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator mNonceRandom;

		// Token: 0x04000B47 RID: 2887
		private readonly global::Org.BouncyCastle.Security.SecureRandom mSecureRandom;

		// Token: 0x04000B48 RID: 2888
		private readonly global::Org.BouncyCastle.Crypto.Tls.SecurityParameters mSecurityParameters;

		// Token: 0x04000B49 RID: 2889
		private global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion mClientVersion;

		// Token: 0x04000B4A RID: 2890
		private global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion mServerVersion;

		// Token: 0x04000B4B RID: 2891
		private global::Org.BouncyCastle.Crypto.Tls.TlsSession mSession;

		// Token: 0x04000B4C RID: 2892
		private object mUserObject;
	}
}
