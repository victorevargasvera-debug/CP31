using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Iana;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000515 RID: 1301
	public class PKMacBuilder
	{
		// Token: 0x060032AC RID: 12972 RVA: 0x000F2753 File Offset: 0x000F0953
		public PKMacBuilder() : this(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1), 1000, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance), new global::Org.BouncyCastle.Crmf.DefaultPKMacPrimitivesProvider())
		{
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x000F277E File Offset: 0x000F097E
		public PKMacBuilder(global::Org.BouncyCastle.Crmf.IPKMacPrimitivesProvider provider) : this(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1), 1000, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance), provider)
		{
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000F27A5 File Offset: 0x000F09A5
		public PKMacBuilder(global::Org.BouncyCastle.Crmf.IPKMacPrimitivesProvider provider, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithmIdentifier, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlgorithmIdentifier) : this(digestAlgorithmIdentifier, 1000, macAlgorithmIdentifier, provider)
		{
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000F27B5 File Offset: 0x000F09B5
		public PKMacBuilder(global::Org.BouncyCastle.Crmf.IPKMacPrimitivesProvider provider, int maxIterations)
		{
			this.saltLength = 20;
			base..ctor();
			this.provider = provider;
			this.maxIterations = maxIterations;
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x000F27D3 File Offset: 0x000F09D3
		private PKMacBuilder(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithmIdentifier, int iterationCount, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlgorithmIdentifier, global::Org.BouncyCastle.Crmf.IPKMacPrimitivesProvider provider)
		{
			this.saltLength = 20;
			base..ctor();
			this.iterationCount = iterationCount;
			this.mac = macAlgorithmIdentifier;
			this.owf = digestAlgorithmIdentifier;
			this.provider = provider;
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x000F2800 File Offset: 0x000F0A00
		public global::Org.BouncyCastle.Crmf.PKMacBuilder SetSaltLength(int saltLength)
		{
			if (saltLength < 8)
			{
				throw new global::System.ArgumentException("salt length must be at least 8 bytes");
			}
			this.saltLength = saltLength;
			return this;
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x000F2819 File Offset: 0x000F0A19
		public global::Org.BouncyCastle.Crmf.PKMacBuilder SetIterationCount(int iterationCount)
		{
			if (iterationCount < 100)
			{
				throw new global::System.ArgumentException("iteration count must be at least 100");
			}
			this.CheckIterationCountCeiling(iterationCount);
			this.iterationCount = iterationCount;
			return this;
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x000F283A File Offset: 0x000F0A3A
		public global::Org.BouncyCastle.Crmf.PKMacBuilder SetParameters(global::Org.BouncyCastle.Asn1.Cmp.PbmParameter parameters)
		{
			this.CheckIterationCountCeiling(parameters.IterationCount.IntValueExact);
			this.parameters = parameters;
			return this;
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x000F2855 File Offset: 0x000F0A55
		public global::Org.BouncyCastle.Crmf.PKMacBuilder SetSecureRandom(global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.random = random;
			return this;
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x000F2860 File Offset: 0x000F0A60
		public global::Org.BouncyCastle.Crypto.IMacFactory Build(char[] password)
		{
			if (this.parameters != null)
			{
				return this.GenCalculator(this.parameters, password);
			}
			byte[] salt = new byte[this.saltLength];
			if (this.random == null)
			{
				this.random = new global::Org.BouncyCastle.Security.SecureRandom();
			}
			this.random.NextBytes(salt);
			return this.GenCalculator(new global::Org.BouncyCastle.Asn1.Cmp.PbmParameter(salt, this.owf, this.iterationCount, this.mac), password);
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x000F28D0 File Offset: 0x000F0AD0
		private void CheckIterationCountCeiling(int iterationCount)
		{
			if (this.maxIterations > 0 && iterationCount > this.maxIterations)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"iteration count exceeds limit (",
					iterationCount.ToString(),
					" > ",
					this.maxIterations.ToString(),
					")"
				}));
			}
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x000F2930 File Offset: 0x000F0B30
		private global::Org.BouncyCastle.Crypto.IMacFactory GenCalculator(global::Org.BouncyCastle.Asn1.Cmp.PbmParameter parameters, char[] password)
		{
			byte[] pw = global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(password);
			byte[] salt = parameters.Salt.GetOctets();
			byte[] K = new byte[pw.Length + salt.Length];
			global::System.Array.Copy(pw, 0, K, 0, pw.Length);
			global::System.Array.Copy(salt, 0, K, pw.Length, salt.Length);
			global::Org.BouncyCastle.Crypto.IDigest digest = this.provider.CreateDigest(parameters.Owf);
			int iter = parameters.IterationCount.IntValueExact;
			digest.BlockUpdate(K, 0, K.Length);
			K = new byte[digest.GetDigestSize()];
			digest.DoFinal(K, 0);
			while (--iter > 0)
			{
				digest.BlockUpdate(K, 0, K.Length);
				digest.DoFinal(K, 0);
			}
			return new global::Org.BouncyCastle.Crmf.PKMacFactory(K, parameters);
		}

		// Token: 0x04001683 RID: 5763
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier owf;

		// Token: 0x04001684 RID: 5764
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mac;

		// Token: 0x04001685 RID: 5765
		private global::Org.BouncyCastle.Crmf.IPKMacPrimitivesProvider provider;

		// Token: 0x04001686 RID: 5766
		private global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04001687 RID: 5767
		private global::Org.BouncyCastle.Asn1.Cmp.PbmParameter parameters;

		// Token: 0x04001688 RID: 5768
		private int iterationCount;

		// Token: 0x04001689 RID: 5769
		private int saltLength;

		// Token: 0x0400168A RID: 5770
		private int maxIterations;
	}
}
