using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.Anssi
{
	// Token: 0x02000795 RID: 1941
	public class AnssiNamedCurves
	{
		// Token: 0x060044E1 RID: 17633 RVA: 0x001322CF File Offset: 0x001304CF
		private static global::Org.BouncyCastle.Asn1.X9.X9ECPoint ConfigureBasepoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, string encoding)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECPoint x9ECPoint = new global::Org.BouncyCastle.Asn1.X9.X9ECPoint(curve, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(encoding));
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ConfigureBasepoint(x9ECPoint.Point);
			return x9ECPoint;
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x001322E8 File Offset: 0x001304E8
		private static global::Org.BouncyCastle.Math.EC.ECCurve ConfigureCurve(global::Org.BouncyCastle.Math.EC.ECCurve curve)
		{
			return curve;
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x001322EB File Offset: 0x001304EB
		private static global::Org.BouncyCastle.Math.BigInteger FromHex(string hex)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(hex));
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x001322F9 File Offset: 0x001304F9
		private static void DefineCurve(string name, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
		{
			global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.objIds.Add(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name), oid);
			global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.names.Add(oid, name);
			global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.curves.Add(oid, holder);
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x00132324 File Offset: 0x00130524
		static AnssiNamedCurves()
		{
			global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.DefineCurve("FRP256v1", global::Org.BouncyCastle.Asn1.Anssi.AnssiObjectIdentifiers.FRP256v1, global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.Frp256v1Holder.Instance);
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x00132358 File Offset: 0x00130558
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetOid(name);
			if (oid != null)
			{
				return global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.GetByOid(oid);
			}
			return null;
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x00132378 File Offset: 0x00130578
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder = (global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder)global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.curves[oid];
			if (holder != null)
			{
				return holder.Parameters;
			}
			return null;
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x001323A1 File Offset: 0x001305A1
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
		{
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.objIds[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name)];
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x001323B8 File Offset: 0x001305B8
		public static string GetName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.names[oid];
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x001323CA File Offset: 0x001305CA
		public static global::System.Collections.IEnumerable Names
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.names.Values);
			}
		}

		// Token: 0x0400219D RID: 8605
		private static readonly global::System.Collections.IDictionary objIds = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400219E RID: 8606
		private static readonly global::System.Collections.IDictionary curves = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400219F RID: 8607
		private static readonly global::System.Collections.IDictionary names = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0200089D RID: 2205
		internal class Frp256v1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004835 RID: 18485 RVA: 0x0013DCF8 File Offset: 0x0013BEF8
			private Frp256v1Holder()
			{
			}

			// Token: 0x06004836 RID: 18486 RVA: 0x0013DD00 File Offset: 0x0013BF00
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.FromHex("F1FD178C0B3AD58F10126DE8CE42435B3961ADBCABC8CA6DE8FCF353D86E9C03");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.FromHex("F1FD178C0B3AD58F10126DE8CE42435B3961ADBCABC8CA6DE8FCF353D86E9C00");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.FromHex("EE353FCA5428A9300D4ABA754A44C00FDFEC0C9AE4B1A1803075ED967B7BB73F");
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.FromHex("F1FD178C0B3AD58F10126DE8CE42435B53DC67E140D2BF941FFDD459C6D655E1");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.ConfigureBasepoint(curve, "04B6B3D4C356C139EB31183D4749D423958C27D2DCAF98B70164C97A2DD98F5CFF6142E0F7C8B204911F9271F0F3ECEF8C2701C307E8E4C9E183115A1554062CFB");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002654 RID: 9812
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Anssi.AnssiNamedCurves.Frp256v1Holder();
		}
	}
}
