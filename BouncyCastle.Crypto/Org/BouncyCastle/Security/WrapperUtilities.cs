using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001D3 RID: 467
	public sealed class WrapperUtilities
	{
		// Token: 0x06001172 RID: 4466 RVA: 0x0004D7B7 File Offset: 0x0004B9B7
		private WrapperUtilities()
		{
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
		static WrapperUtilities()
		{
			((global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm)global::Org.BouncyCastle.Utilities.Enums.GetArbitraryValue(typeof(global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm))).ToString();
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Wrap.Id] = "AESWRAP";
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Wrap.Id] = "AESWRAP";
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Wrap.Id] = "AESWRAP";
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Wrap.Id] = "CAMELLIAWRAP";
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Wrap.Id] = "CAMELLIAWRAP";
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Wrap.Id] = "CAMELLIAWRAP";
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgCms3DesWrap.Id] = "DESEDEWRAP";
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms["TDEAWRAP"] = "DESEDEWRAP";
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgCmsRC2Wrap.Id] = "RC2WRAP";
			global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdNpkiAppCmsSeedWrap.Id] = "SEEDWRAP";
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0004D8EF File Offset: 0x0004BAEF
		public static global::Org.BouncyCastle.Crypto.IWrapper GetWrapper(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return global::Org.BouncyCastle.Security.WrapperUtilities.GetWrapper(oid.Id);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0004D8FC File Offset: 0x0004BAFC
		public static global::Org.BouncyCastle.Crypto.IWrapper GetWrapper(string algorithm)
		{
			string upper = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			string mechanism = (string)global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[upper];
			if (mechanism == null)
			{
				mechanism = upper;
			}
			try
			{
				switch ((global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm)global::Org.BouncyCastle.Utilities.Enums.GetEnumValue(typeof(global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm), mechanism))
				{
				case global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm.AESWRAP:
					return new global::Org.BouncyCastle.Crypto.Engines.AesWrapEngine();
				case global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm.CAMELLIAWRAP:
					return new global::Org.BouncyCastle.Crypto.Engines.CamelliaWrapEngine();
				case global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm.DESEDEWRAP:
					return new global::Org.BouncyCastle.Crypto.Engines.DesEdeWrapEngine();
				case global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm.RC2WRAP:
					return new global::Org.BouncyCastle.Crypto.Engines.RC2WrapEngine();
				case global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm.SEEDWRAP:
					return new global::Org.BouncyCastle.Crypto.Engines.SeedWrapEngine();
				case global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm.DESEDERFC3211WRAP:
					return new global::Org.BouncyCastle.Crypto.Engines.Rfc3211WrapEngine(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine());
				case global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm.AESRFC3211WRAP:
					return new global::Org.BouncyCastle.Crypto.Engines.Rfc3211WrapEngine(new global::Org.BouncyCastle.Crypto.Engines.AesEngine());
				case global::Org.BouncyCastle.Security.WrapperUtilities.WrapAlgorithm.CAMELLIARFC3211WRAP:
					return new global::Org.BouncyCastle.Crypto.Engines.Rfc3211WrapEngine(new global::Org.BouncyCastle.Crypto.Engines.CamelliaEngine());
				}
			}
			catch (global::System.ArgumentException)
			{
			}
			global::Org.BouncyCastle.Crypto.IBufferedCipher blockCipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(algorithm);
			if (blockCipher != null)
			{
				return new global::Org.BouncyCastle.Security.WrapperUtilities.BufferedCipherWrapper(blockCipher);
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Wrapper " + algorithm + " not recognised.");
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0004D9FC File Offset: 0x0004BBFC
		public static string GetAlgorithmName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Security.WrapperUtilities.algorithms[oid.Id];
		}

		// Token: 0x040008DF RID: 2271
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x020007B7 RID: 1975
		private enum WrapAlgorithm
		{
			// Token: 0x040023CF RID: 9167
			AESWRAP,
			// Token: 0x040023D0 RID: 9168
			CAMELLIAWRAP,
			// Token: 0x040023D1 RID: 9169
			DESEDEWRAP,
			// Token: 0x040023D2 RID: 9170
			RC2WRAP,
			// Token: 0x040023D3 RID: 9171
			SEEDWRAP,
			// Token: 0x040023D4 RID: 9172
			DESEDERFC3211WRAP,
			// Token: 0x040023D5 RID: 9173
			AESRFC3211WRAP,
			// Token: 0x040023D6 RID: 9174
			CAMELLIARFC3211WRAP
		}

		// Token: 0x020007B8 RID: 1976
		private class BufferedCipherWrapper : global::Org.BouncyCastle.Crypto.IWrapper
		{
			// Token: 0x06004542 RID: 17730 RVA: 0x00132DDB File Offset: 0x00130FDB
			public BufferedCipherWrapper(global::Org.BouncyCastle.Crypto.IBufferedCipher cipher)
			{
				this.cipher = cipher;
			}

			// Token: 0x17000A79 RID: 2681
			// (get) Token: 0x06004543 RID: 17731 RVA: 0x00132DEA File Offset: 0x00130FEA
			public string AlgorithmName
			{
				get
				{
					return this.cipher.AlgorithmName;
				}
			}

			// Token: 0x06004544 RID: 17732 RVA: 0x00132DF7 File Offset: 0x00130FF7
			public void Init(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
			{
				this.forWrapping = forWrapping;
				this.cipher.Init(forWrapping, parameters);
			}

			// Token: 0x06004545 RID: 17733 RVA: 0x00132E0D File Offset: 0x0013100D
			public byte[] Wrap(byte[] input, int inOff, int length)
			{
				if (!this.forWrapping)
				{
					throw new global::System.InvalidOperationException("Not initialised for wrapping");
				}
				return this.cipher.DoFinal(input, inOff, length);
			}

			// Token: 0x06004546 RID: 17734 RVA: 0x00132E30 File Offset: 0x00131030
			public byte[] Unwrap(byte[] input, int inOff, int length)
			{
				if (this.forWrapping)
				{
					throw new global::System.InvalidOperationException("Not initialised for unwrapping");
				}
				return this.cipher.DoFinal(input, inOff, length);
			}

			// Token: 0x040023D7 RID: 9175
			private readonly global::Org.BouncyCastle.Crypto.IBufferedCipher cipher;

			// Token: 0x040023D8 RID: 9176
			private bool forWrapping;
		}
	}
}
