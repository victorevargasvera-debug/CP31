using System;
using System.Collections;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Nist
{
	// Token: 0x020006DA RID: 1754
	public sealed class NistNamedCurves
	{
		// Token: 0x06003FF0 RID: 16368 RVA: 0x00121C6C File Offset: 0x0011FE6C
		private NistNamedCurves()
		{
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x00121C74 File Offset: 0x0011FE74
		private static void DefineCurveAlias(string name, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.objIds.Add(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name), oid);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.names.Add(oid, name);
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x00121C94 File Offset: 0x0011FE94
		static NistNamedCurves()
		{
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("B-163", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r2);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("B-233", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233r1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("B-283", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283r1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("B-409", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409r1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("B-571", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571r1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("K-163", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163k1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("K-233", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233k1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("K-283", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283k1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("K-409", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409k1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("K-571", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571k1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("P-192", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192r1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("P-224", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224r1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("P-256", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256r1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("P-384", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP384r1);
			global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.DefineCurveAlias("P-521", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP521r1);
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x00121D98 File Offset: 0x0011FF98
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetOid(name);
			if (oid != null)
			{
				return global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetByOid(oid);
			}
			return null;
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00121DB7 File Offset: 0x0011FFB7
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByOid(oid);
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00121DBF File Offset: 0x0011FFBF
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
		{
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.objIds[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name)];
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x00121DD6 File Offset: 0x0011FFD6
		public static string GetName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.names[oid];
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06003FF7 RID: 16375 RVA: 0x00121DE8 File Offset: 0x0011FFE8
		public static global::System.Collections.IEnumerable Names
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.names.Values);
			}
		}

		// Token: 0x04001DC8 RID: 7624
		private static readonly global::System.Collections.IDictionary objIds = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001DC9 RID: 7625
		private static readonly global::System.Collections.IDictionary names = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
