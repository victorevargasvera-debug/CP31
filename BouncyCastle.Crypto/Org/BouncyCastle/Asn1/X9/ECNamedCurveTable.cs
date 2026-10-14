using System;
using System.Collections;
using Org.BouncyCastle.Asn1.Anssi;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000630 RID: 1584
	public class ECNamedCurveTable
	{
		// Token: 0x06003AD3 RID: 15059 RVA: 0x0010FAE4 File Offset: 0x0010DCE4
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetByName(name);
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByName(name);
			}
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetByName(name);
			}
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetByName(name);
			}
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetByName(name);
			}
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetByNameX9(name);
			}
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.GetByName(name);
			}
			return ecP;
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x0010FB38 File Offset: 0x0010DD38
		public static string GetName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			string name = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetName(oid);
			if (name == null)
			{
				name = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetName(oid);
			}
			if (name == null)
			{
				name = global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetName(oid);
			}
			if (name == null)
			{
				name = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetName(oid);
			}
			if (name == null)
			{
				name = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetName(oid);
			}
			if (name == null)
			{
				name = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetName(oid);
			}
			if (name == null)
			{
				name = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.GetName(oid);
			}
			return name;
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x0010FB8C File Offset: 0x0010DD8C
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetOid(name);
			if (oid == null)
			{
				oid = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetOid(name);
			}
			if (oid == null)
			{
				oid = global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.GetOid(name);
			}
			if (oid == null)
			{
				oid = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetOid(name);
			}
			if (oid == null)
			{
				oid = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetOid(name);
			}
			if (oid == null)
			{
				oid = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetOid(name);
			}
			if (oid == null)
			{
				oid = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.GetOid(name);
			}
			return oid;
		}

		// Token: 0x06003AD6 RID: 15062 RVA: 0x0010FBE0 File Offset: 0x0010DDE0
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetByOid(oid);
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByOid(oid);
			}
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetByOid(oid);
			}
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetByOid(oid);
			}
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetByOidX9(oid);
			}
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.GetByOid(oid);
			}
			return ecP;
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x0010FC28 File Offset: 0x0010DE28
		public static global::System.Collections.IEnumerable Names
		{
			get
			{
				global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(list, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Names);
				global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(list, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Names);
				global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(list, global::Org.BouncyCastle.Asn1.Nist.NistNamedCurves.Names);
				global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(list, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.Names);
				global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(list, global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.Names);
				global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(list, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.Names);
				global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(list, global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.Names);
				return list;
			}
		}
	}
}
