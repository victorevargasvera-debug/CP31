using System;
using System.Collections;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000633 RID: 1587
	public sealed class X962NamedCurves
	{
		// Token: 0x06003AE4 RID: 15076 RVA: 0x0010FE15 File Offset: 0x0010E015
		private X962NamedCurves()
		{
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x0010FE1D File Offset: 0x0010E01D
		private static global::Org.BouncyCastle.Asn1.X9.X9ECPoint ConfigureBasepoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, string encoding)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECPoint x9ECPoint = new global::Org.BouncyCastle.Asn1.X9.X9ECPoint(curve, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(encoding));
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ConfigureBasepoint(x9ECPoint.Point);
			return x9ECPoint;
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x0010FE36 File Offset: 0x0010E036
		private static global::Org.BouncyCastle.Math.EC.ECCurve ConfigureCurve(global::Org.BouncyCastle.Math.EC.ECCurve curve)
		{
			return curve;
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x0010FE39 File Offset: 0x0010E039
		private static global::Org.BouncyCastle.Math.BigInteger FromHex(string hex)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(hex));
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x0010FE47 File Offset: 0x0010E047
		private static void DefineCurve(string name, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
		{
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.objIds.Add(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name), oid);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.names.Add(oid, name);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.curves.Add(oid, holder);
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x0010FE74 File Offset: 0x0010E074
		static X962NamedCurves()
		{
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("prime192v1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime192v1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("prime192v2", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v2, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime192v2Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("prime192v3", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v3, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime192v3Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("prime239v1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime239v1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("prime239v2", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v2, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime239v2Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("prime239v3", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v3, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime239v3Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("prime256v1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime256v1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime256v1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2pnb163v1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb163v1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb163v1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2pnb163v2", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb163v2, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb163v2Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2pnb163v3", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb163v3, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb163v3Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2pnb176w1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb176w1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb176w1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2tnb191v1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb191v1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb191v1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2tnb191v2", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb191v2, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb191v2Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2tnb191v3", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb191v3, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb191v3Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2pnb208w1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb208w1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb208w1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2tnb239v1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb239v1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb239v1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2tnb239v2", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb239v2, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb239v2Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2tnb239v3", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb239v3, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb239v3Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2pnb272w1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb272w1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb272w1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2pnb304w1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb304w1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb304w1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2tnb359v1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb359v1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb359v1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2pnb368w1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Pnb368w1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb368w1Holder.Instance);
			global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.DefineCurve("c2tnb431r1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.C2Tnb431r1, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb431r1Holder.Instance);
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x0011006C File Offset: 0x0010E26C
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetOid(name);
			if (oid != null)
			{
				return global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.GetByOid(oid);
			}
			return null;
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x0011008C File Offset: 0x0010E28C
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder = (global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder)global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.curves[oid];
			if (holder != null)
			{
				return holder.Parameters;
			}
			return null;
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x001100B5 File Offset: 0x0010E2B5
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
		{
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.objIds[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name)];
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x001100CC File Offset: 0x0010E2CC
		public static string GetName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.names[oid];
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06003AEE RID: 15086 RVA: 0x001100DE File Offset: 0x0010E2DE
		public static global::System.Collections.IEnumerable Names
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.names.Values);
			}
		}

		// Token: 0x040019C8 RID: 6600
		private static readonly global::System.Collections.IDictionary objIds = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040019C9 RID: 6601
		private static readonly global::System.Collections.IDictionary curves = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040019CA RID: 6602
		private static readonly global::System.Collections.IDictionary names = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x02000851 RID: 2129
		internal class Prime192v1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600475B RID: 18267 RVA: 0x0013B8C3 File Offset: 0x00139AC3
			private Prime192v1Holder()
			{
			}

			// Token: 0x0600475C RID: 18268 RVA: 0x0013B8CC File Offset: 0x00139ACC
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("ffffffffffffffffffffffff99def836146bc9b1b4d22831");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFF"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("fffffffffffffffffffffffffffffffefffffffffffffffc"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("64210519e59c80e70fa7e9ab72243049feb8deecc146b9b1"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "03188da80eb03090f67cbf20eb43a18800f4ff0afd82ff1012");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("3045AE6FC8422f64ED579528D38120EAE12196D5"));
			}

			// Token: 0x040025CA RID: 9674
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime192v1Holder();
		}

		// Token: 0x02000852 RID: 2130
		internal class Prime192v2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600475E RID: 18270 RVA: 0x0013B93E File Offset: 0x00139B3E
			private Prime192v2Holder()
			{
			}

			// Token: 0x0600475F RID: 18271 RVA: 0x0013B948 File Offset: 0x00139B48
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("fffffffffffffffffffffffe5fb1a724dc80418648d8dd31");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFF"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("fffffffffffffffffffffffffffffffefffffffffffffffc"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("cc22d6dfb95c6b25e49c0d6364a4e5980c393aa21668d953"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "03eea2bae7e1497842f2de7769cfe9c989c072ad696f48034a");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("31a92ee2029fd10d901b113e990710f0d21ac6b6"));
			}

			// Token: 0x040025CB RID: 9675
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime192v2Holder();
		}

		// Token: 0x02000853 RID: 2131
		internal class Prime192v3Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004761 RID: 18273 RVA: 0x0013B9BA File Offset: 0x00139BBA
			private Prime192v3Holder()
			{
			}

			// Token: 0x06004762 RID: 18274 RVA: 0x0013B9C4 File Offset: 0x00139BC4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("ffffffffffffffffffffffff7a62d031c83f4294f640ec13");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFF"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("fffffffffffffffffffffffffffffffefffffffffffffffc"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("22123dc2395a05caa7423daeccc94760a7d462256bd56916"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "027d29778100c65a1da1783716588dce2b8b4aee8e228f1896");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("c469684435deb378c4b65ca9591e2a5763059a2e"));
			}

			// Token: 0x040025CC RID: 9676
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime192v3Holder();
		}

		// Token: 0x02000854 RID: 2132
		internal class Prime239v1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004764 RID: 18276 RVA: 0x0013BA36 File Offset: 0x00139C36
			private Prime239v1Holder()
			{
			}

			// Token: 0x06004765 RID: 18277 RVA: 0x0013BA40 File Offset: 0x00139C40
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("7fffffffffffffffffffffff7fffff9e5e9a9f5d9071fbd1522688909d0b");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(new global::Org.BouncyCastle.Math.BigInteger("883423532389192164791648750360308885314476597252960362792450860609699839"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("7fffffffffffffffffffffff7fffffffffff8000000000007ffffffffffc"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("6b016c3bdcf18941d0d654921475ca71a9db2fb27d1d37796185c2942c0a"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "020ffa963cdca8816ccc33b8642bedf905c3d358573d3f27fbbd3b3cb9aaaf");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("e43bb460f0b80cc0c0b075798e948060f8321b7d"));
			}

			// Token: 0x040025CD RID: 9677
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime239v1Holder();
		}

		// Token: 0x02000855 RID: 2133
		internal class Prime239v2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004767 RID: 18279 RVA: 0x0013BAB2 File Offset: 0x00139CB2
			private Prime239v2Holder()
			{
			}

			// Token: 0x06004768 RID: 18280 RVA: 0x0013BABC File Offset: 0x00139CBC
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("7fffffffffffffffffffffff800000cfa7e8594377d414c03821bc582063");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(new global::Org.BouncyCastle.Math.BigInteger("883423532389192164791648750360308885314476597252960362792450860609699839"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("7fffffffffffffffffffffff7fffffffffff8000000000007ffffffffffc"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("617fab6832576cbbfed50d99f0249c3fee58b94ba0038c7ae84c8c832f2c"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "0238af09d98727705120c921bb5e9e26296a3cdcf2f35757a0eafd87b830e7");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("e8b4011604095303ca3b8099982be09fcb9ae616"));
			}

			// Token: 0x040025CE RID: 9678
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime239v2Holder();
		}

		// Token: 0x02000856 RID: 2134
		internal class Prime239v3Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600476A RID: 18282 RVA: 0x0013BB2E File Offset: 0x00139D2E
			private Prime239v3Holder()
			{
			}

			// Token: 0x0600476B RID: 18283 RVA: 0x0013BB38 File Offset: 0x00139D38
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("7fffffffffffffffffffffff7fffff975deb41b3a6057c3c432146526551");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(new global::Org.BouncyCastle.Math.BigInteger("883423532389192164791648750360308885314476597252960362792450860609699839"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("7fffffffffffffffffffffff7fffffffffff8000000000007ffffffffffc"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("255705fa2a306654b1f4cb03d6a750a30c250102d4988717d9ba15ab6d3e"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "036768ae8e18bb92cfcf005c949aa2c6d94853d0e660bbf854b1c9505fe95a");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("7d7374168ffe3471b60a857686a19475d3bfa2ff"));
			}

			// Token: 0x040025CF RID: 9679
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime239v3Holder();
		}

		// Token: 0x02000857 RID: 2135
		internal class Prime256v1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600476D RID: 18285 RVA: 0x0013BBAA File Offset: 0x00139DAA
			private Prime256v1Holder()
			{
			}

			// Token: 0x0600476E RID: 18286 RVA: 0x0013BBB4 File Offset: 0x00139DB4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("ffffffff00000000ffffffffffffffffbce6faada7179e84f3b9cac2fc632551");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(new global::Org.BouncyCastle.Math.BigInteger("115792089210356248762697446949407573530086143415290314195533631308867097853951"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("ffffffff00000001000000000000000000000000fffffffffffffffffffffffc"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("5ac635d8aa3a93e7b3ebbd55769886bc651d06b0cc53b0f63bce3c3e27d2604b"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "036b17d1f2e12c4247f8bce6e563a440f277037d812deb33a0f4a13945d898c296");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("c49d360886e704936a6678e1139d26b7819f7e90"));
			}

			// Token: 0x040025D0 RID: 9680
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.Prime256v1Holder();
		}

		// Token: 0x02000858 RID: 2136
		internal class C2pnb163v1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004770 RID: 18288 RVA: 0x0013BC26 File Offset: 0x00139E26
			private C2pnb163v1Holder()
			{
			}

			// Token: 0x06004771 RID: 18289 RVA: 0x0013BC30 File Offset: 0x00139E30
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("0400000000000000000001E60FC8821CC74DAEAFC1");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.Two;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(163, 1, 2, 8, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("072546B5435234A422E0789675F432C89435DE5242"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("00C9517D06D5240D3CFF38C74B20B6CD4D6F9DD4D9"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "0307AF69989546103D79329FCC3D74880F33BBE803CB");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("D2C0FB15760860DEF1EEF4D696E6768756151754"));
			}

			// Token: 0x040025D1 RID: 9681
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb163v1Holder();
		}

		// Token: 0x02000859 RID: 2137
		internal class C2pnb163v2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004773 RID: 18291 RVA: 0x0013BCA0 File Offset: 0x00139EA0
			private C2pnb163v2Holder()
			{
			}

			// Token: 0x06004774 RID: 18292 RVA: 0x0013BCA8 File Offset: 0x00139EA8
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("03FFFFFFFFFFFFFFFFFFFDF64DE1151ADBB78F10A7");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.Two;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(163, 1, 2, 8, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("0108B39E77C4B108BED981ED0E890E117C511CF072"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("0667ACEB38AF4E488C407433FFAE4F1C811638DF20"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "030024266E4EB5106D0A964D92C4860E2671DB9B6CC5");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025D2 RID: 9682
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb163v2Holder();
		}

		// Token: 0x0200085A RID: 2138
		internal class C2pnb163v3Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004776 RID: 18294 RVA: 0x0013BD0E File Offset: 0x00139F0E
			private C2pnb163v3Holder()
			{
			}

			// Token: 0x06004777 RID: 18295 RVA: 0x0013BD18 File Offset: 0x00139F18
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("03FFFFFFFFFFFFFFFFFFFE1AEE140F110AFF961309");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.Two;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(163, 1, 2, 8, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("07A526C63D3E25A256A007699F5447E32AE456B50E"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("03F7061798EB99E238FD6F1BF95B48FEEB4854252B"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "0202F9F87B7C574D0BDECF8A22E6524775F98CDEBDCB");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025D3 RID: 9683
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb163v3Holder();
		}

		// Token: 0x0200085B RID: 2139
		internal class C2pnb176w1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004779 RID: 18297 RVA: 0x0013BD7E File Offset: 0x00139F7E
			private C2pnb176w1Holder()
			{
			}

			// Token: 0x0600477A RID: 18298 RVA: 0x0013BD88 File Offset: 0x00139F88
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("010092537397ECA4F6145799D62B0A19CE06FE26AD");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(65390L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(176, 1, 2, 43, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("E4E6DB2995065C407D9D39B8D0967B96704BA8E9C90B"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("5DDA470ABE6414DE8EC133AE28E9BBD7FCEC0AE0FFF2"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "038D16C2866798B600F9F08BB4A8E860F3298CE04A5798");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025D4 RID: 9684
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb176w1Holder();
		}

		// Token: 0x0200085C RID: 2140
		internal class C2tnb191v1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600477C RID: 18300 RVA: 0x0013BDF5 File Offset: 0x00139FF5
			private C2tnb191v1Holder()
			{
			}

			// Token: 0x0600477D RID: 18301 RVA: 0x0013BE00 File Offset: 0x0013A000
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("40000000000000000000000004A20E90C39067C893BBB9A5");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.Two;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(191, 9, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("2866537B676752636A68F56554E12640276B649EF7526267"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("2E45EF571F00786F67B0081B9495A3D95462F5DE0AA185EC"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "0236B3DAF8A23206F9C4F299D7B21A9C369137F2C84AE1AA0D");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("4E13CA542744D696E67687561517552F279A8C84"));
			}

			// Token: 0x040025D5 RID: 9685
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb191v1Holder();
		}

		// Token: 0x0200085D RID: 2141
		internal class C2tnb191v2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600477F RID: 18303 RVA: 0x0013BE6F File Offset: 0x0013A06F
			private C2tnb191v2Holder()
			{
			}

			// Token: 0x06004780 RID: 18304 RVA: 0x0013BE78 File Offset: 0x0013A078
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("20000000000000000000000050508CB89F652824E06B8173");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(191, 9, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("401028774D7777C7B7666D1366EA432071274F89FF01E718"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("0620048D28BCBD03B6249C99182B7C8CD19700C362C46A01"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "023809B2B7CC1B28CC5A87926AAD83FD28789E81E2C9E3BF10");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025D6 RID: 9686
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb191v2Holder();
		}

		// Token: 0x0200085E RID: 2142
		internal class C2tnb191v3Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004782 RID: 18306 RVA: 0x0013BEDF File Offset: 0x0013A0DF
			private C2tnb191v3Holder()
			{
			}

			// Token: 0x06004783 RID: 18307 RVA: 0x0013BEE8 File Offset: 0x0013A0E8
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("155555555555555555555555610C0B196812BFB6288A3EA3");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(6L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(191, 9, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("6C01074756099122221056911C77D77E77A777E7E7E77FCB"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("71FE1AF926CF847989EFEF8DB459F66394D90F32AD3F15E8"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "03375D4CE24FDE434489DE8746E71786015009E66E38A926DD");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025D7 RID: 9687
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb191v3Holder();
		}

		// Token: 0x0200085F RID: 2143
		internal class C2pnb208w1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004785 RID: 18309 RVA: 0x0013BF4F File Offset: 0x0013A14F
			private C2pnb208w1Holder()
			{
			}

			// Token: 0x06004786 RID: 18310 RVA: 0x0013BF58 File Offset: 0x0013A158
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("0101BAF95C9723C57B6C21DA2EFF2D5ED588BDD5717E212F9D");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(65096L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(208, 1, 2, 83, global::Org.BouncyCastle.Math.BigInteger.Zero, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("C8619ED45A62E6212E1160349E2BFA844439FAFC2A3FD1638F9E"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "0289FDFBE4ABE193DF9559ECF07AC0CE78554E2784EB8C1ED1A57A");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025D8 RID: 9688
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb208w1Holder();
		}

		// Token: 0x02000860 RID: 2144
		internal class C2tnb239v1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004788 RID: 18312 RVA: 0x0013BFC0 File Offset: 0x0013A1C0
			private C2tnb239v1Holder()
			{
			}

			// Token: 0x06004789 RID: 18313 RVA: 0x0013BFC8 File Offset: 0x0013A1C8
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("2000000000000000000000000000000F4D42FFE1492A4993F1CAD666E447");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(239, 36, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("32010857077C5431123A46B808906756F543423E8D27877578125778AC76"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("790408F2EEDAF392B012EDEFB3392F30F4327C0CA3F31FC383C422AA8C16"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "0257927098FA932E7C0A96D3FD5B706EF7E5F5C156E16B7E7C86038552E91D");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025D9 RID: 9689
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb239v1Holder();
		}

		// Token: 0x02000861 RID: 2145
		internal class C2tnb239v2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600478B RID: 18315 RVA: 0x0013C02F File Offset: 0x0013A22F
			private C2tnb239v2Holder()
			{
			}

			// Token: 0x0600478C RID: 18316 RVA: 0x0013C038 File Offset: 0x0013A238
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("1555555555555555555555555555553C6F2885259C31E3FCDF154624522D");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(6L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(239, 36, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("4230017757A767FAE42398569B746325D45313AF0766266479B75654E65F"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("5037EA654196CFF0CD82B2C14A2FCF2E3FF8775285B545722F03EACDB74B"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "0228F9D04E900069C8DC47A08534FE76D2B900B7D7EF31F5709F200C4CA205");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025DA RID: 9690
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb239v2Holder();
		}

		// Token: 0x02000862 RID: 2146
		internal class C2tnb239v3Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600478E RID: 18318 RVA: 0x0013C09F File Offset: 0x0013A29F
			private C2tnb239v3Holder()
			{
			}

			// Token: 0x0600478F RID: 18319 RVA: 0x0013C0A8 File Offset: 0x0013A2A8
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("0CCCCCCCCCCCCCCCCCCCCCCCCCCCCCAC4912D2D9DF903EF9888B8A0E4CFF");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(10L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(239, 36, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("01238774666A67766D6676F778E676B66999176666E687666D8766C66A9F"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("6A941977BA9F6A435199ACFC51067ED587F519C5ECB541B8E44111DE1D40"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "0370F6E9D04D289C4E89913CE3530BFDE903977D42B146D539BF1BDE4E9C92");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025DB RID: 9691
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb239v3Holder();
		}

		// Token: 0x02000863 RID: 2147
		internal class C2pnb272w1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004791 RID: 18321 RVA: 0x0013C110 File Offset: 0x0013A310
			private C2pnb272w1Holder()
			{
			}

			// Token: 0x06004792 RID: 18322 RVA: 0x0013C118 File Offset: 0x0013A318
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("0100FAF51354E0E39E4892DF6E319C72C8161603FA45AA7B998A167B8F1E629521");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(65286L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(272, 1, 3, 56, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("91A091F03B5FBA4AB2CCF49C4EDD220FB028712D42BE752B2C40094DBACDB586FB20"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("7167EFC92BB2E3CE7C8AAAFF34E12A9C557003D7C73A6FAF003F99F6CC8482E540F7"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "026108BABB2CEEBCF787058A056CBE0CFE622D7723A289E08A07AE13EF0D10D171DD8D");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025DC RID: 9692
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb272w1Holder();
		}

		// Token: 0x02000864 RID: 2148
		internal class C2pnb304w1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004794 RID: 18324 RVA: 0x0013C185 File Offset: 0x0013A385
			private C2pnb304w1Holder()
			{
			}

			// Token: 0x06004795 RID: 18325 RVA: 0x0013C190 File Offset: 0x0013A390
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("0101D556572AABAC800101D556572AABAC8001022D5C91DD173F8FB561DA6899164443051D");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(65070L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(304, 1, 2, 11, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("FD0D693149A118F651E6DCE6802085377E5F882D1B510B44160074C1288078365A0396C8E681"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("BDDB97E555A50A908E43B01C798EA5DAA6788F1EA2794EFCF57166B8C14039601E55827340BE"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "02197B07845E9BE2D96ADB0F5F3C7F2CFFBD7A3EB8B6FEC35C7FD67F26DDF6285A644F740A2614");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025DD RID: 9693
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb304w1Holder();
		}

		// Token: 0x02000865 RID: 2149
		internal class C2tnb359v1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004797 RID: 18327 RVA: 0x0013C1FD File Offset: 0x0013A3FD
			private C2tnb359v1Holder()
			{
			}

			// Token: 0x06004798 RID: 18328 RVA: 0x0013C208 File Offset: 0x0013A408
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("01AF286BCA1AF286BCA1AF286BCA1AF286BCA1AF286BC9FB8F6B85C556892C20A7EB964FE7719E74F490758D3B");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(76L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(359, 68, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("5667676A654B20754F356EA92017D946567C46675556F19556A04616B567D223A5E05656FB549016A96656A557"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("2472E2D0197C49363F1FE7F5B6DB075D52B6947D135D8CA445805D39BC345626089687742B6329E70680231988"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "033C258EF3047767E7EDE0F1FDAA79DAEE3841366A132E163ACED4ED2401DF9C6BDCDE98E8E707C07A2239B1B097");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025DE RID: 9694
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb359v1Holder();
		}

		// Token: 0x02000866 RID: 2150
		internal class C2pnb368w1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600479A RID: 18330 RVA: 0x0013C270 File Offset: 0x0013A470
			private C2pnb368w1Holder()
			{
			}

			// Token: 0x0600479B RID: 18331 RVA: 0x0013C278 File Offset: 0x0013A478
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("010090512DA9AF72B08349D98A5DD4C7B0532ECA51CE03E2D10F3B7AC579BD87E909AE40A6F131E9CFCE5BD967");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(65392L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(368, 1, 2, 85, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("E0D2EE25095206F5E2A4F9ED229F1F256E79A0E2B455970D8D0D865BD94778C576D62F0AB7519CCD2A1A906AE30D"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("FC1217D4320A90452C760A58EDCD30C8DD069B3C34453837A34ED50CB54917E1C2112D84D164F444F8F74786046A"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "021085E2755381DCCCE3C1557AFA10C2F0C0C2825646C5B34A394CBCFA8BC16B22E7E789E927BE216F02E1FB136A5F");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025DF RID: 9695
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2pnb368w1Holder();
		}

		// Token: 0x02000867 RID: 2151
		internal class C2tnb431r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600479D RID: 18333 RVA: 0x0013C2E5 File Offset: 0x0013A4E5
			private C2tnb431r1Holder()
			{
			}

			// Token: 0x0600479E RID: 18334 RVA: 0x0013C2F0 File Offset: 0x0013A4F0
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("0340340340340340340340340340340340340340340340340340340323C313FAB50589703B5EC68D3587FEC60D161CC149C1AD4A91");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(10080L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.F2mCurve(431, 120, global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("1A827EF00DD6FC0E234CAF046C6A5D8A85395B236CC4AD2CF32A0CADBDC9DDF620B0EB9906D0957F6C6FEACD615468DF104DE296CD8F"), global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.FromHex("10D9B4A3D9047D8B154359ABFB1B7F5485B04CEB868237DDC9DEDA982A679A5A919B626D4E50A8DD731B107A9962381FB5D807BF2618"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.ConfigureBasepoint(curve, "02120FC05D3C67A99DE161D2F4092622FECA701BE4F50F4758714E8A87BBF2A658EF8C21E7C5EFE965361F6C2999C0C247B0DBD70CE6B7");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025E0 RID: 9696
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.X9.X962NamedCurves.C2tnb431r1Holder();
		}
	}
}
