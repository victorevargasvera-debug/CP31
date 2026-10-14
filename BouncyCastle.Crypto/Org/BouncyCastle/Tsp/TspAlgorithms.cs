using System;
using System.Collections;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x02000082 RID: 130
	public abstract class TspAlgorithms
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x00017B8C File Offset: 0x00015D8C
		static TspAlgorithms()
		{
			string[] array = new string[]
			{
				global::Org.BouncyCastle.Tsp.TspAlgorithms.Gost3411,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.Gost3411_2012_256,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.Gost3411_2012_512,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.MD5,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.RipeMD128,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.RipeMD160,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.RipeMD256,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.Sha1,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.Sha224,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.Sha256,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.Sha384,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.Sha512,
				global::Org.BouncyCastle.Tsp.TspAlgorithms.SM3
			};
			global::Org.BouncyCastle.Tsp.TspAlgorithms.Allowed = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (string alg in array)
			{
				global::Org.BouncyCastle.Tsp.TspAlgorithms.Allowed.Add(alg);
			}
		}

		// Token: 0x040002CE RID: 718
		public static readonly string MD5 = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5.Id;

		// Token: 0x040002CF RID: 719
		public static readonly string Sha1 = global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Id;

		// Token: 0x040002D0 RID: 720
		public static readonly string Sha224 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Id;

		// Token: 0x040002D1 RID: 721
		public static readonly string Sha256 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Id;

		// Token: 0x040002D2 RID: 722
		public static readonly string Sha384 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Id;

		// Token: 0x040002D3 RID: 723
		public static readonly string Sha512 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Id;

		// Token: 0x040002D4 RID: 724
		public static readonly string RipeMD128 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Id;

		// Token: 0x040002D5 RID: 725
		public static readonly string RipeMD160 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Id;

		// Token: 0x040002D6 RID: 726
		public static readonly string RipeMD256 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Id;

		// Token: 0x040002D7 RID: 727
		public static readonly string Gost3411 = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411.Id;

		// Token: 0x040002D8 RID: 728
		public static readonly string Gost3411_2012_256 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_256.Id;

		// Token: 0x040002D9 RID: 729
		public static readonly string Gost3411_2012_512 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_512.Id;

		// Token: 0x040002DA RID: 730
		public static readonly string SM3 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm3.Id;

		// Token: 0x040002DB RID: 731
		public static readonly global::System.Collections.IList Allowed;
	}
}
