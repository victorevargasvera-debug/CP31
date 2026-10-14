using System;
using System.Collections;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x02000722 RID: 1826
	public sealed class Gost3410NamedParameters
	{
		// Token: 0x0600419E RID: 16798 RVA: 0x00129453 File Offset: 0x00127653
		private Gost3410NamedParameters()
		{
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x0012945C File Offset: 0x0012765C
		static Gost3410NamedParameters()
		{
			global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProA] = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.cryptoProA;
			global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProB] = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.cryptoProB;
			global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProXchA] = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.cryptoProXchA;
			global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds["GostR3410-94-CryptoPro-A"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProA;
			global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds["GostR3410-94-CryptoPro-B"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProB;
			global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds["GostR3410-94-CryptoPro-XchA"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProXchA;
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x0012957C File Offset: 0x0012777C
		public static global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters GetByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters[oid];
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x0012958E File Offset: 0x0012778E
		public static global::System.Collections.IEnumerable Names
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds.Keys);
			}
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x001295A0 File Offset: 0x001277A0
		public static global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters GetByName(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds[name];
			if (oid != null)
			{
				return (global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.parameters[oid];
			}
			return null;
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x001295D3 File Offset: 0x001277D3
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
		{
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.objIds[name];
		}

		// Token: 0x04001F91 RID: 8081
		private static readonly global::System.Collections.IDictionary objIds = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001F92 RID: 8082
		private static readonly global::System.Collections.IDictionary parameters = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001F93 RID: 8083
		private static readonly global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters cryptoProA = new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters(1024, new global::Org.BouncyCastle.Math.BigInteger("127021248288932417465907042777176443525787653508916535812817507265705031260985098497423188333483401180925999995120988934130659205614996724254121049274349357074920312769561451689224110579311248812610229678534638401693520013288995000362260684222750813532307004517341633685004541062586971416883686778842537820383"), new global::Org.BouncyCastle.Math.BigInteger("68363196144955700784444165611827252895102170888761442055095051287550314083023"), new global::Org.BouncyCastle.Math.BigInteger("100997906755055304772081815535925224869841082572053457874823515875577147990529272777244152852699298796483356699682842027972896052747173175480590485607134746852141928680912561502802222185647539190902656116367847270145019066794290930185446216399730872221732889830323194097355403213400972588322876850946740663962"));

		// Token: 0x04001F94 RID: 8084
		private static readonly global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters cryptoProB = new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters(1024, new global::Org.BouncyCastle.Math.BigInteger("139454871199115825601409655107690713107041707059928031797758001454375765357722984094124368522288239833039114681648076688236921220737322672160740747771700911134550432053804647694904686120113087816240740184800477047157336662926249423571248823968542221753660143391485680840520336859458494803187341288580489525163"), new global::Org.BouncyCastle.Math.BigInteger("79885141663410976897627118935756323747307951916507639758300472692338873533959"), new global::Org.BouncyCastle.Math.BigInteger("42941826148615804143873447737955502392672345968607143066798112994089471231420027060385216699563848719957657284814898909770759462613437669456364882730370838934791080835932647976778601915343474400961034231316672578686920482194932878633360203384797092684342247621055760235016132614780652761028509445403338652341"));

		// Token: 0x04001F95 RID: 8085
		private static readonly global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters cryptoProXchA = new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters(1024, new global::Org.BouncyCastle.Math.BigInteger("142011741597563481196368286022318089743276138395243738762872573441927459393512718973631166078467600360848946623567625795282774719212241929071046134208380636394084512691828894000571524625445295769349356752728956831541775441763139384457191755096847107846595662547942312293338483924514339614727760681880609734239"), new global::Org.BouncyCastle.Math.BigInteger("91771529896554605945588149018382750217296858393520724172743325725474374979801"), new global::Org.BouncyCastle.Math.BigInteger("133531813272720673433859519948319001217942375967847486899482359599369642528734712461590403327731821410328012529253871914788598993103310567744136196364803064721377826656898686468463277710150809401182608770201615324990468332931294920912776241137878030224355746606283971659376426832674269780880061631528163475887"));
	}
}
