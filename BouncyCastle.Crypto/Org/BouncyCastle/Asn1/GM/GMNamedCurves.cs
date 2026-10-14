using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.GM
{
	// Token: 0x020006F8 RID: 1784
	public sealed class GMNamedCurves
	{
		// Token: 0x0600408E RID: 16526 RVA: 0x00124C7D File Offset: 0x00122E7D
		private GMNamedCurves()
		{
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00124C85 File Offset: 0x00122E85
		private static global::Org.BouncyCastle.Asn1.X9.X9ECPoint ConfigureBasepoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, string encoding)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECPoint x9ECPoint = new global::Org.BouncyCastle.Asn1.X9.X9ECPoint(curve, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(encoding));
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ConfigureBasepoint(x9ECPoint.Point);
			return x9ECPoint;
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x00124C9E File Offset: 0x00122E9E
		private static global::Org.BouncyCastle.Math.EC.ECCurve ConfigureCurve(global::Org.BouncyCastle.Math.EC.ECCurve curve)
		{
			return curve;
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00124CA1 File Offset: 0x00122EA1
		private static global::Org.BouncyCastle.Math.BigInteger FromHex(string hex)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(hex));
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x00124CAF File Offset: 0x00122EAF
		private static void DefineCurve(string name, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
		{
			global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.objIds.Add(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name), oid);
			global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.names.Add(oid, name);
			global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.curves.Add(oid, holder);
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x00124CDC File Offset: 0x00122EDC
		static GMNamedCurves()
		{
			global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.DefineCurve("wapip192v1", global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.wapip192v1, global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.WapiP192V1Holder.Instance);
			global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.DefineCurve("sm2p256v1", global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2p256v1, global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.SM2P256V1Holder.Instance);
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x00124D30 File Offset: 0x00122F30
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.GetOid(name);
			if (oid != null)
			{
				return global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.GetByOid(oid);
			}
			return null;
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00124D50 File Offset: 0x00122F50
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder = (global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder)global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.curves[oid];
			if (holder != null)
			{
				return holder.Parameters;
			}
			return null;
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x00124D79 File Offset: 0x00122F79
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
		{
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.objIds[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name)];
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x00124D90 File Offset: 0x00122F90
		public static string GetName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.names[oid];
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x00124DA2 File Offset: 0x00122FA2
		public static global::System.Collections.IEnumerable Names
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.names.Values);
			}
		}

		// Token: 0x04001EBC RID: 7868
		private static readonly global::System.Collections.IDictionary objIds = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001EBD RID: 7869
		private static readonly global::System.Collections.IDictionary curves = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001EBE RID: 7870
		private static readonly global::System.Collections.IDictionary names = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0200089B RID: 2203
		internal class SM2P256V1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600482F RID: 18479 RVA: 0x0013DC00 File Offset: 0x0013BE00
			private SM2P256V1Holder()
			{
			}

			// Token: 0x06004830 RID: 18480 RVA: 0x0013DC08 File Offset: 0x0013BE08
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.FromHex("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFF");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.FromHex("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFC");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.FromHex("28E9FA9E9D9F5E344D5A9E4BCF6509A7F39789F515AB8F92DDBCBD414D940E93");
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.FromHex("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFF7203DF6B21C6052B53BBF40939D54123");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.ConfigureBasepoint(curve, "0432C4AE2C1F1981195F9904466A39C9948FE30BBFF2660BE1715A4589334C74C7BC3736A2F4F6779C59BDCEE36B692153D0A9877CC62A474002DF32E52139F0A0");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002652 RID: 9810
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.SM2P256V1Holder();
		}

		// Token: 0x0200089C RID: 2204
		internal class WapiP192V1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004832 RID: 18482 RVA: 0x0013DC7C File Offset: 0x0013BE7C
			private WapiP192V1Holder()
			{
			}

			// Token: 0x06004833 RID: 18483 RVA: 0x0013DC84 File Offset: 0x0013BE84
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.FromHex("BDB6F4FE3E8B1D9E0DA8C0D46F4C318CEFE4AFE3B6B8551F");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.FromHex("BB8E5E8FBC115E139FE6A814FE48AAA6F0ADA1AA5DF91985");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.FromHex("1854BEBDC31B21B7AEFC80AB0ECD10D5B1B3308E6DBF11C1");
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.FromHex("BDB6F4FE3E8B1D9E0DA8C0D40FC962195DFAE76F56564677");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.ConfigureBasepoint(curve, "044AD5F7048DE709AD51236DE65E4D4B482C836DC6E410664002BB3A02D4AAADACAE24817A4CA3A1B014B5270432DB27D2");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002653 RID: 9811
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.GM.GMNamedCurves.WapiP192V1Holder();
		}
	}
}
