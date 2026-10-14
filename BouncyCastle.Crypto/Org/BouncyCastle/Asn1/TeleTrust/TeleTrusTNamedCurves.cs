using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.TeleTrust
{
	// Token: 0x0200069C RID: 1692
	public class TeleTrusTNamedCurves
	{
		// Token: 0x06003E3D RID: 15933 RVA: 0x0011BE3F File Offset: 0x0011A03F
		private static global::Org.BouncyCastle.Asn1.X9.X9ECPoint ConfigureBasepoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, string encoding)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECPoint x9ECPoint = new global::Org.BouncyCastle.Asn1.X9.X9ECPoint(curve, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(encoding));
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ConfigureBasepoint(x9ECPoint.Point);
			return x9ECPoint;
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0011BE58 File Offset: 0x0011A058
		private static global::Org.BouncyCastle.Math.EC.ECCurve ConfigureCurve(global::Org.BouncyCastle.Math.EC.ECCurve curve)
		{
			return curve;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x0011BE5B File Offset: 0x0011A05B
		private static global::Org.BouncyCastle.Math.BigInteger FromHex(string hex)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(hex));
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x0011BE69 File Offset: 0x0011A069
		private static void DefineCurve(string name, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
		{
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.objIds.Add(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name), oid);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.names.Add(oid, name);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.curves.Add(oid, holder);
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x0011BE94 File Offset: 0x0011A094
		static TeleTrusTNamedCurves()
		{
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP160r1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP160R1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP160r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP160t1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP160T1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP160t1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP192r1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP192R1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP192r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP192t1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP192T1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP192t1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP224r1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP224R1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP224r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP224t1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP224T1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP224t1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP256r1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP256R1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP256r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP256t1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP256T1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP256t1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP320r1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP320R1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP320r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP320t1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP320T1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP320t1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP384r1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP384R1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP384r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP384t1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP384T1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP384t1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP512r1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP512R1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP512r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.DefineCurve("brainpoolP512t1", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP512T1, global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP512t1Holder.Instance);
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x0011BFD8 File Offset: 0x0011A1D8
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetOid(name);
			if (oid != null)
			{
				return global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetByOid(oid);
			}
			return null;
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x0011BFF8 File Offset: 0x0011A1F8
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder = (global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder)global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.curves[oid];
			if (holder != null)
			{
				return holder.Parameters;
			}
			return null;
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x0011C021 File Offset: 0x0011A221
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
		{
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.objIds[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name)];
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x0011C038 File Offset: 0x0011A238
		public static string GetName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.names[oid];
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x0011C04A File Offset: 0x0011A24A
		public static global::System.Collections.IEnumerable Names
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.names.Values);
			}
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x0011C05B File Offset: 0x0011A25B
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(short curvesize, bool twisted)
		{
			return global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.GetOid("brainpoolP" + curvesize.ToString() + (twisted ? "t" : "r") + "1");
		}

		// Token: 0x04001BF1 RID: 7153
		private static readonly global::System.Collections.IDictionary objIds = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001BF2 RID: 7154
		private static readonly global::System.Collections.IDictionary curves = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001BF3 RID: 7155
		private static readonly global::System.Collections.IDictionary names = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0200086A RID: 2154
		internal class BrainpoolP160r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047A2 RID: 18338 RVA: 0x0013C37C File Offset: 0x0013A57C
			private BrainpoolP160r1Holder()
			{
			}

			// Token: 0x060047A3 RID: 18339 RVA: 0x0013C384 File Offset: 0x0013A584
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("E95E4A5F737059DC60DF5991D45029409E60FC09");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("E95E4A5F737059DC60DFC7AD95B3D8139515620F"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("340E7BE2A280EB74E2BE61BADA745D97E8F7C300"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("1E589A8595423412134FAA2DBDEC95C8D8675E58"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "04BED5AF16EA3F6A4F62938C4631EB5AF7BDBCDBC31667CB477A1A8EC338F94741669C976316DA6321");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025E5 RID: 9701
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP160r1Holder();
		}

		// Token: 0x0200086B RID: 2155
		internal class BrainpoolP160t1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047A5 RID: 18341 RVA: 0x0013C3EC File Offset: 0x0013A5EC
			private BrainpoolP160t1Holder()
			{
			}

			// Token: 0x060047A6 RID: 18342 RVA: 0x0013C3F4 File Offset: 0x0013A5F4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("E95E4A5F737059DC60DF5991D45029409E60FC09");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("E95E4A5F737059DC60DFC7AD95B3D8139515620F"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("E95E4A5F737059DC60DFC7AD95B3D8139515620C"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("7A556B6DAE535B7B51ED2C4D7DAA7A0B5C55F380"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "04B199B13B9B34EFC1397E64BAEB05ACC265FF2378ADD6718B7C7C1961F0991B842443772152C9E0AD");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025E6 RID: 9702
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP160t1Holder();
		}

		// Token: 0x0200086C RID: 2156
		internal class BrainpoolP192r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047A8 RID: 18344 RVA: 0x0013C45C File Offset: 0x0013A65C
			private BrainpoolP192r1Holder()
			{
			}

			// Token: 0x060047A9 RID: 18345 RVA: 0x0013C464 File Offset: 0x0013A664
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("C302F41D932A36CDA7A3462F9E9E916B5BE8F1029AC4ACC1");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("C302F41D932A36CDA7A3463093D18DB78FCE476DE1A86297"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("6A91174076B1E0E19C39C031FE8685C1CAE040E5C69A28EF"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("469A28EF7C28CCA3DC721D044F4496BCCA7EF4146FBF25C9"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "04C0A0647EAAB6A48753B033C56CB0F0900A2F5C4853375FD614B690866ABD5BB88B5F4828C1490002E6773FA2FA299B8F");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025E7 RID: 9703
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP192r1Holder();
		}

		// Token: 0x0200086D RID: 2157
		internal class BrainpoolP192t1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047AB RID: 18347 RVA: 0x0013C4CC File Offset: 0x0013A6CC
			private BrainpoolP192t1Holder()
			{
			}

			// Token: 0x060047AC RID: 18348 RVA: 0x0013C4D4 File Offset: 0x0013A6D4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("C302F41D932A36CDA7A3462F9E9E916B5BE8F1029AC4ACC1");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("C302F41D932A36CDA7A3463093D18DB78FCE476DE1A86297"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("C302F41D932A36CDA7A3463093D18DB78FCE476DE1A86294"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("13D56FFAEC78681E68F9DEB43B35BEC2FB68542E27897B79"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "043AE9E58C82F63C30282E1FE7BBF43FA72C446AF6F4618129097E2C5667C2223A902AB5CA449D0084B7E5B3DE7CCC01C9");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025E8 RID: 9704
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP192t1Holder();
		}

		// Token: 0x0200086E RID: 2158
		internal class BrainpoolP224r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047AE RID: 18350 RVA: 0x0013C53C File Offset: 0x0013A73C
			private BrainpoolP224r1Holder()
			{
			}

			// Token: 0x060047AF RID: 18351 RVA: 0x0013C544 File Offset: 0x0013A744
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D7C134AA264366862A18302575D0FB98D116BC4B6DDEBCA3A5A7939F");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D7C134AA264366862A18302575D1D787B09F075797DA89F57EC8C0FF"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("68A5E62CA9CE6C1C299803A6C1530B514E182AD8B0042A59CAD29F43"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("2580F63CCFE44138870713B1A92369E33E2135D266DBB372386C400B"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "040D9029AD2C7E5CF4340823B2A87DC68C9E4CE3174C1E6EFDEE12C07D58AA56F772C0726F24C6B89E4ECDAC24354B9E99CAA3F6D3761402CD");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025E9 RID: 9705
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP224r1Holder();
		}

		// Token: 0x0200086F RID: 2159
		internal class BrainpoolP224t1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047B1 RID: 18353 RVA: 0x0013C5AC File Offset: 0x0013A7AC
			private BrainpoolP224t1Holder()
			{
			}

			// Token: 0x060047B2 RID: 18354 RVA: 0x0013C5B4 File Offset: 0x0013A7B4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D7C134AA264366862A18302575D0FB98D116BC4B6DDEBCA3A5A7939F");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D7C134AA264366862A18302575D1D787B09F075797DA89F57EC8C0FF"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D7C134AA264366862A18302575D1D787B09F075797DA89F57EC8C0FC"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("4B337D934104CD7BEF271BF60CED1ED20DA14C08B3BB64F18A60888D"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "046AB1E344CE25FF3896424E7FFE14762ECB49F8928AC0C76029B4D5800374E9F5143E568CD23F3F4D7C0D4B1E41C8CC0D1C6ABD5F1A46DB4C");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025EA RID: 9706
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP224t1Holder();
		}

		// Token: 0x02000870 RID: 2160
		internal class BrainpoolP256r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047B4 RID: 18356 RVA: 0x0013C61C File Offset: 0x0013A81C
			private BrainpoolP256r1Holder()
			{
			}

			// Token: 0x060047B5 RID: 18357 RVA: 0x0013C624 File Offset: 0x0013A824
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("A9FB57DBA1EEA9BC3E660A909D838D718C397AA3B561A6F7901E0E82974856A7");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("A9FB57DBA1EEA9BC3E660A909D838D726E3BF623D52620282013481D1F6E5377"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("7D5A0975FC2C3057EEF67530417AFFE7FB8055C126DC5C6CE94A4B44F330B5D9"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("26DC5C6CE94A4B44F330B5D9BBD77CBF958416295CF7E1CE6BCCDC18FF8C07B6"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "048BD2AEB9CB7E57CB2C4B482FFC81B7AFB9DE27E1E3BD23C23A4453BD9ACE3262547EF835C3DAC4FD97F8461A14611DC9C27745132DED8E545C1D54C72F046997");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025EB RID: 9707
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP256r1Holder();
		}

		// Token: 0x02000871 RID: 2161
		internal class BrainpoolP256t1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047B7 RID: 18359 RVA: 0x0013C68C File Offset: 0x0013A88C
			private BrainpoolP256t1Holder()
			{
			}

			// Token: 0x060047B8 RID: 18360 RVA: 0x0013C694 File Offset: 0x0013A894
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("A9FB57DBA1EEA9BC3E660A909D838D718C397AA3B561A6F7901E0E82974856A7");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("A9FB57DBA1EEA9BC3E660A909D838D726E3BF623D52620282013481D1F6E5377"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("A9FB57DBA1EEA9BC3E660A909D838D726E3BF623D52620282013481D1F6E5374"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("662C61C430D84EA4FE66A7733D0B76B7BF93EBC4AF2F49256AE58101FEE92B04"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "04A3E8EB3CC1CFE7B7732213B23A656149AFA142C47AAFBC2B79A191562E1305F42D996C823439C56D7F7B22E14644417E69BCB6DE39D027001DABE8F35B25C9BE");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025EC RID: 9708
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP256t1Holder();
		}

		// Token: 0x02000872 RID: 2162
		internal class BrainpoolP320r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047BA RID: 18362 RVA: 0x0013C6FC File Offset: 0x0013A8FC
			private BrainpoolP320r1Holder()
			{
			}

			// Token: 0x060047BB RID: 18363 RVA: 0x0013C704 File Offset: 0x0013A904
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D35E472036BC4FB7E13C785ED201E065F98FCFA5B68F12A32D482EC7EE8658E98691555B44C59311");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D35E472036BC4FB7E13C785ED201E065F98FCFA6F6F40DEF4F92B9EC7893EC28FCD412B1F1B32E27"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("3EE30B568FBAB0F883CCEBD46D3F3BB8A2A73513F5EB79DA66190EB085FFA9F492F375A97D860EB4"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("520883949DFDBC42D3AD198640688A6FE13F41349554B49ACC31DCCD884539816F5EB4AC8FB1F1A6"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "0443BD7E9AFB53D8B85289BCC48EE5BFE6F20137D10A087EB6E7871E2A10A599C710AF8D0D39E2061114FDD05545EC1CC8AB4093247F77275E0743FFED117182EAA9C77877AAAC6AC7D35245D1692E8EE1");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025ED RID: 9709
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP320r1Holder();
		}

		// Token: 0x02000873 RID: 2163
		internal class BrainpoolP320t1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047BD RID: 18365 RVA: 0x0013C76C File Offset: 0x0013A96C
			private BrainpoolP320t1Holder()
			{
			}

			// Token: 0x060047BE RID: 18366 RVA: 0x0013C774 File Offset: 0x0013A974
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D35E472036BC4FB7E13C785ED201E065F98FCFA5B68F12A32D482EC7EE8658E98691555B44C59311");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D35E472036BC4FB7E13C785ED201E065F98FCFA6F6F40DEF4F92B9EC7893EC28FCD412B1F1B32E27"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("D35E472036BC4FB7E13C785ED201E065F98FCFA6F6F40DEF4F92B9EC7893EC28FCD412B1F1B32E24"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("A7F561E038EB1ED560B3D147DB782013064C19F27ED27C6780AAF77FB8A547CEB5B4FEF422340353"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "04925BE9FB01AFC6FB4D3E7D4990010F813408AB106C4F09CB7EE07868CC136FFF3357F624A21BED5263BA3A7A27483EBF6671DBEF7ABB30EBEE084E58A0B077AD42A5A0989D1EE71B1B9BC0455FB0D2C3");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025EE RID: 9710
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP320t1Holder();
		}

		// Token: 0x02000874 RID: 2164
		internal class BrainpoolP384r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047C0 RID: 18368 RVA: 0x0013C7DC File Offset: 0x0013A9DC
			private BrainpoolP384r1Holder()
			{
			}

			// Token: 0x060047C1 RID: 18369 RVA: 0x0013C7E4 File Offset: 0x0013A9E4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("8CB91E82A3386D280F5D6F7E50E641DF152F7109ED5456B31F166E6CAC0425A7CF3AB6AF6B7FC3103B883202E9046565");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("8CB91E82A3386D280F5D6F7E50E641DF152F7109ED5456B412B1DA197FB71123ACD3A729901D1A71874700133107EC53"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("7BC382C63D8C150C3C72080ACE05AFA0C2BEA28E4FB22787139165EFBA91F90F8AA5814A503AD4EB04A8C7DD22CE2826"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("04A8C7DD22CE28268B39B55416F0447C2FB77DE107DCD2A62E880EA53EEB62D57CB4390295DBC9943AB78696FA504C11"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "041D1C64F068CF45FFA2A63A81B7C13F6B8847A3E77EF14FE3DB7FCAFE0CBD10E8E826E03436D646AAEF87B2E247D4AF1E8ABE1D7520F9C2A45CB1EB8E95CFD55262B70B29FEEC5864E19C054FF99129280E4646217791811142820341263C5315");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025EF RID: 9711
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP384r1Holder();
		}

		// Token: 0x02000875 RID: 2165
		internal class BrainpoolP384t1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047C3 RID: 18371 RVA: 0x0013C84C File Offset: 0x0013AA4C
			private BrainpoolP384t1Holder()
			{
			}

			// Token: 0x060047C4 RID: 18372 RVA: 0x0013C854 File Offset: 0x0013AA54
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("8CB91E82A3386D280F5D6F7E50E641DF152F7109ED5456B31F166E6CAC0425A7CF3AB6AF6B7FC3103B883202E9046565");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("8CB91E82A3386D280F5D6F7E50E641DF152F7109ED5456B412B1DA197FB71123ACD3A729901D1A71874700133107EC53"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("8CB91E82A3386D280F5D6F7E50E641DF152F7109ED5456B412B1DA197FB71123ACD3A729901D1A71874700133107EC50"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("7F519EADA7BDA81BD826DBA647910F8C4B9346ED8CCDC64E4B1ABD11756DCE1D2074AA263B88805CED70355A33B471EE"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "0418DE98B02DB9A306F2AFCD7235F72A819B80AB12EBD653172476FECD462AABFFC4FF191B946A5F54D8D0AA2F418808CC25AB056962D30651A114AFD2755AD336747F93475B7A1FCA3B88F2B6A208CCFE469408584DC2B2912675BF5B9E582928");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025F0 RID: 9712
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP384t1Holder();
		}

		// Token: 0x02000876 RID: 2166
		internal class BrainpoolP512r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047C6 RID: 18374 RVA: 0x0013C8BC File Offset: 0x0013AABC
			private BrainpoolP512r1Holder()
			{
			}

			// Token: 0x060047C7 RID: 18375 RVA: 0x0013C8C4 File Offset: 0x0013AAC4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("AADD9DB8DBE9C48B3FD4E6AE33C9FC07CB308DB3B3C9D20ED6639CCA70330870553E5C414CA92619418661197FAC10471DB1D381085DDADDB58796829CA90069");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("AADD9DB8DBE9C48B3FD4E6AE33C9FC07CB308DB3B3C9D20ED6639CCA703308717D4D9B009BC66842AECDA12AE6A380E62881FF2F2D82C68528AA6056583A48F3"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("7830A3318B603B89E2327145AC234CC594CBDD8D3DF91610A83441CAEA9863BC2DED5D5AA8253AA10A2EF1C98B9AC8B57F1117A72BF2C7B9E7C1AC4D77FC94CA"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("3DF91610A83441CAEA9863BC2DED5D5AA8253AA10A2EF1C98B9AC8B57F1117A72BF2C7B9E7C1AC4D77FC94CADC083E67984050B75EBAE5DD2809BD638016F723"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "0481AEE4BDD82ED9645A21322E9C4C6A9385ED9F70B5D916C1B43B62EEF4D0098EFF3B1F78E2D0D48D50D1687B93B97D5F7C6D5047406A5E688B352209BCB9F8227DDE385D566332ECC0EABFA9CF7822FDF209F70024A57B1AA000C55B881F8111B2DCDE494A5F485E5BCA4BD88A2763AED1CA2B2FA8F0540678CD1E0F3AD80892");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025F1 RID: 9713
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP512r1Holder();
		}

		// Token: 0x02000877 RID: 2167
		internal class BrainpoolP512t1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047C9 RID: 18377 RVA: 0x0013C92C File Offset: 0x0013AB2C
			private BrainpoolP512t1Holder()
			{
			}

			// Token: 0x060047CA RID: 18378 RVA: 0x0013C934 File Offset: 0x0013AB34
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("AADD9DB8DBE9C48B3FD4E6AE33C9FC07CB308DB3B3C9D20ED6639CCA70330870553E5C414CA92619418661197FAC10471DB1D381085DDADDB58796829CA90069");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("AADD9DB8DBE9C48B3FD4E6AE33C9FC07CB308DB3B3C9D20ED6639CCA703308717D4D9B009BC66842AECDA12AE6A380E62881FF2F2D82C68528AA6056583A48F3"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("AADD9DB8DBE9C48B3FD4E6AE33C9FC07CB308DB3B3C9D20ED6639CCA703308717D4D9B009BC66842AECDA12AE6A380E62881FF2F2D82C68528AA6056583A48F0"), global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.FromHex("7CBBBCF9441CFAB76E1890E46884EAE321F70C0BCB4981527897504BEC3E36A62BCDFA2304976540F6450085F2DAE145C22553B465763689180EA2571867423E"), i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.ConfigureBasepoint(curve, "04640ECE5C12788717B9C1BA06CBC2A6FEBA85842458C56DDE9DB1758D39C0313D82BA51735CDB3EA499AA77A7D6943A64F7A3F25FE26F06B51BAA2696FA9035DA5B534BD595F5AF0FA2C892376C84ACE1BB4E3019B71634C01131159CAE03CEE9D9932184BEEF216BD71DF2DADF86A627306ECFF96DBB8BACE198B61E00F8B332");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h);
			}

			// Token: 0x040025F2 RID: 9714
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTNamedCurves.BrainpoolP512t1Holder();
		}
	}
}
