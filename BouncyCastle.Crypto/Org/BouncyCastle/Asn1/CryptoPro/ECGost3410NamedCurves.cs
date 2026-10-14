using System;
using System.Collections;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x0200071F RID: 1823
	public sealed class ECGost3410NamedCurves
	{
		// Token: 0x06004187 RID: 16775 RVA: 0x00128B26 File Offset: 0x00126D26
		private static global::Org.BouncyCastle.Math.EC.ECPoint ConfigureBasepoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Math.BigInteger y)
		{
			global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = curve.CreatePoint(x, y);
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ConfigureBasepoint(ecpoint);
			return ecpoint;
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x00128B36 File Offset: 0x00126D36
		private static global::Org.BouncyCastle.Math.EC.ECCurve ConfigureCurve(global::Org.BouncyCastle.Math.EC.ECCurve curve)
		{
			return curve;
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x00128B39 File Offset: 0x00126D39
		private ECGost3410NamedCurves()
		{
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x00128B44 File Offset: 0x00126D44
		static ECGost3410NamedCurves()
		{
			global::Org.BouncyCastle.Math.BigInteger q = new global::Org.BouncyCastle.Math.BigInteger("115792089237316195423570985008687907853269984665640564039457584007913129639319");
			global::Org.BouncyCastle.Math.BigInteger mod_q = new global::Org.BouncyCastle.Math.BigInteger("115792089237316195423570985008687907853073762908499243225378155805079068850323");
			global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, new global::Org.BouncyCastle.Math.BigInteger("115792089237316195423570985008687907853269984665640564039457584007913129639316"), new global::Org.BouncyCastle.Math.BigInteger("166"), mod_q, global::Org.BouncyCastle.Math.BigInteger.One));
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureBasepoint(curve, new global::Org.BouncyCastle.Math.BigInteger("1"), new global::Org.BouncyCastle.Math.BigInteger("64033881142927202683649881450433473985931760268884941288852745803908878638612")), mod_q, global::Org.BouncyCastle.Math.BigInteger.One);
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProA] = ecParams;
			global::Org.BouncyCastle.Math.BigInteger q2 = new global::Org.BouncyCastle.Math.BigInteger("115792089237316195423570985008687907853269984665640564039457584007913129639319");
			mod_q = new global::Org.BouncyCastle.Math.BigInteger("115792089237316195423570985008687907853073762908499243225378155805079068850323");
			global::Org.BouncyCastle.Math.EC.ECCurve curve2 = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q2, new global::Org.BouncyCastle.Math.BigInteger("115792089237316195423570985008687907853269984665640564039457584007913129639316"), new global::Org.BouncyCastle.Math.BigInteger("166"), mod_q, global::Org.BouncyCastle.Math.BigInteger.One));
			ecParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve2, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureBasepoint(curve2, new global::Org.BouncyCastle.Math.BigInteger("1"), new global::Org.BouncyCastle.Math.BigInteger("64033881142927202683649881450433473985931760268884941288852745803908878638612")), mod_q, global::Org.BouncyCastle.Math.BigInteger.One);
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProXchA] = ecParams;
			global::Org.BouncyCastle.Math.BigInteger q3 = new global::Org.BouncyCastle.Math.BigInteger("57896044618658097711785492504343953926634992332820282019728792003956564823193");
			mod_q = new global::Org.BouncyCastle.Math.BigInteger("57896044618658097711785492504343953927102133160255826820068844496087732066703");
			global::Org.BouncyCastle.Math.EC.ECCurve curve3 = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q3, new global::Org.BouncyCastle.Math.BigInteger("57896044618658097711785492504343953926634992332820282019728792003956564823190"), new global::Org.BouncyCastle.Math.BigInteger("28091019353058090096996979000309560759124368558014865957655842872397301267595"), mod_q, global::Org.BouncyCastle.Math.BigInteger.One));
			ecParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve3, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureBasepoint(curve3, new global::Org.BouncyCastle.Math.BigInteger("1"), new global::Org.BouncyCastle.Math.BigInteger("28792665814854611296992347458380284135028636778229113005756334730996303888124")), mod_q, global::Org.BouncyCastle.Math.BigInteger.One);
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProB] = ecParams;
			global::Org.BouncyCastle.Math.BigInteger q4 = new global::Org.BouncyCastle.Math.BigInteger("70390085352083305199547718019018437841079516630045180471284346843705633502619");
			mod_q = new global::Org.BouncyCastle.Math.BigInteger("70390085352083305199547718019018437840920882647164081035322601458352298396601");
			global::Org.BouncyCastle.Math.EC.ECCurve curve4 = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q4, new global::Org.BouncyCastle.Math.BigInteger("70390085352083305199547718019018437841079516630045180471284346843705633502616"), new global::Org.BouncyCastle.Math.BigInteger("32858"), mod_q, global::Org.BouncyCastle.Math.BigInteger.One));
			ecParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve4, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureBasepoint(curve4, new global::Org.BouncyCastle.Math.BigInteger("0"), new global::Org.BouncyCastle.Math.BigInteger("29818893917731240733471273240314769927240550812383695689146495261604565990247")), mod_q, global::Org.BouncyCastle.Math.BigInteger.One);
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProXchB] = ecParams;
			global::Org.BouncyCastle.Math.BigInteger q5 = new global::Org.BouncyCastle.Math.BigInteger("70390085352083305199547718019018437841079516630045180471284346843705633502619");
			mod_q = new global::Org.BouncyCastle.Math.BigInteger("70390085352083305199547718019018437840920882647164081035322601458352298396601");
			global::Org.BouncyCastle.Math.EC.ECCurve curve5 = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q5, new global::Org.BouncyCastle.Math.BigInteger("70390085352083305199547718019018437841079516630045180471284346843705633502616"), new global::Org.BouncyCastle.Math.BigInteger("32858"), mod_q, global::Org.BouncyCastle.Math.BigInteger.One));
			ecParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve5, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureBasepoint(curve5, new global::Org.BouncyCastle.Math.BigInteger("0"), new global::Org.BouncyCastle.Math.BigInteger("29818893917731240733471273240314769927240550812383695689146495261604565990247")), mod_q, global::Org.BouncyCastle.Math.BigInteger.One);
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProC] = ecParams;
			global::Org.BouncyCastle.Math.BigInteger q6 = new global::Org.BouncyCastle.Math.BigInteger("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFD97", 16);
			mod_q = new global::Org.BouncyCastle.Math.BigInteger("400000000000000000000000000000000FD8CDDFC87B6635C115AF556C360C67", 16);
			global::Org.BouncyCastle.Math.EC.ECCurve curve6 = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q6, new global::Org.BouncyCastle.Math.BigInteger("C2173F1513981673AF4892C23035A27CE25E2013BF95AA33B22C656F277E7335", 16), new global::Org.BouncyCastle.Math.BigInteger("295F9BAE7428ED9CCC20E7C359A9D41A22FCCD9108E17BF7BA9337A6F8AE9513", 16), mod_q, global::Org.BouncyCastle.Math.BigInteger.Four));
			ecParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve6, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureBasepoint(curve6, new global::Org.BouncyCastle.Math.BigInteger("91E38443A5E82C0D880923425712B2BB658B9196932E02C78B2582FE742DAA28", 16), new global::Org.BouncyCastle.Math.BigInteger("32879423AB1A0375895786C4BB46E9565FDE0B5344766740AF268ADB32322E5C", 16)), mod_q, global::Org.BouncyCastle.Math.BigInteger.Four);
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256_paramSetA] = ecParams;
			global::Org.BouncyCastle.Math.BigInteger q7 = new global::Org.BouncyCastle.Math.BigInteger("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDC7", 16);
			mod_q = new global::Org.BouncyCastle.Math.BigInteger("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF27E69532F48D89116FF22B8D4E0560609B4B38ABFAD2B85DCACDB1411F10B275", 16);
			global::Org.BouncyCastle.Math.EC.ECCurve curve7 = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q7, new global::Org.BouncyCastle.Math.BigInteger("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDC4", 16), new global::Org.BouncyCastle.Math.BigInteger("E8C2505DEDFC86DDC1BD0B2B6667F1DA34B82574761CB0E879BD081CFD0B6265EE3CB090F30D27614CB4574010DA90DD862EF9D4EBEE4761503190785A71C760", 16), mod_q, global::Org.BouncyCastle.Math.BigInteger.One));
			ecParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve7, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureBasepoint(curve7, new global::Org.BouncyCastle.Math.BigInteger("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003"), new global::Org.BouncyCastle.Math.BigInteger("7503CFE87A836AE3A61B8816E25450E6CE5E1C93ACF1ABC1778064FDCBEFA921DF1626BE4FD036E93D75E6A50E3A41E98028FE5FC235F5B889A589CB5215F2A4", 16)), mod_q, global::Org.BouncyCastle.Math.BigInteger.One);
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetA] = ecParams;
			global::Org.BouncyCastle.Math.BigInteger q8 = new global::Org.BouncyCastle.Math.BigInteger("8000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006F", 16);
			mod_q = new global::Org.BouncyCastle.Math.BigInteger("800000000000000000000000000000000000000000000000000000000000000149A1EC142565A545ACFDB77BD9D40CFA8B996712101BEA0EC6346C54374F25BD", 16);
			global::Org.BouncyCastle.Math.EC.ECCurve curve8 = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q8, new global::Org.BouncyCastle.Math.BigInteger("8000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006C", 16), new global::Org.BouncyCastle.Math.BigInteger("687D1B459DC841457E3E06CF6F5E2517B97C7D614AF138BCBF85DC806C4B289F3E965D2DB1416D217F8B276FAD1AB69C50F78BEE1FA3106EFB8CCBC7C5140116", 16), mod_q, global::Org.BouncyCastle.Math.BigInteger.One));
			ecParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve8, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureBasepoint(curve8, new global::Org.BouncyCastle.Math.BigInteger("00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002"), new global::Org.BouncyCastle.Math.BigInteger("1A8F7EDA389B094C2C071E3647A8940F3C123B697578C213BE6DD9E6C8EC7335DCB228FD1EDF4A39152CBCAAF8C0398828041055F94CEEEC7E21340780FE41BD", 16)), mod_q, global::Org.BouncyCastle.Math.BigInteger.One);
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetB] = ecParams;
			global::Org.BouncyCastle.Math.BigInteger q9 = new global::Org.BouncyCastle.Math.BigInteger("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDC7", 16);
			mod_q = new global::Org.BouncyCastle.Math.BigInteger("3FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC98CDBA46506AB004C33A9FF5147502CC8EDA9E7A769A12694623CEF47F023ED", 16);
			global::Org.BouncyCastle.Math.EC.ECCurve curve9 = global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q9, new global::Org.BouncyCastle.Math.BigInteger("DC9203E514A721875485A529D2C722FB187BC8980EB866644DE41C68E143064546E861C0E2C9EDD92ADE71F46FCF50FF2AD97F951FDA9F2A2EB6546F39689BD3", 16), new global::Org.BouncyCastle.Math.BigInteger("B4C4EE28CEBC6C2C8AC12952CF37F16AC7EFB6A9F69F4B57FFDA2E4F0DE5ADE038CBC2FFF719D2C18DE0284B8BFEF3B52B8CC7A5F5BF0A3C8D2319A5312557E1", 16), mod_q, global::Org.BouncyCastle.Math.BigInteger.Four));
			ecParams = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve9, global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.ConfigureBasepoint(curve9, new global::Org.BouncyCastle.Math.BigInteger("E2E31EDFC23DE7BDEBE241CE593EF5DE2295B7A9CBAEF021D385F7074CEA043AA27272A7AE602BF2A7B9033DB9ED3610C6FB85487EAE97AAC5BC7928C1950148", 16), new global::Org.BouncyCastle.Math.BigInteger("F5CE40D95B5EB899ABBCCFF5911CB8577939804D6527378B8C108C3D2090FF9BE18E2D33E3021ED2EF32D85822423B6304F726AA854BAE07D0396E9A9ADDC40F", 16)), mod_q, global::Org.BouncyCastle.Math.BigInteger.Four);
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetC] = ecParams;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds["GostR3410-2001-CryptoPro-A"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProA;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds["GostR3410-2001-CryptoPro-B"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProB;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds["GostR3410-2001-CryptoPro-C"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProC;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds["GostR3410-2001-CryptoPro-XchA"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProXchA;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds["GostR3410-2001-CryptoPro-XchB"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProXchB;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds["Tc26-Gost-3410-12-256-paramSetA"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256_paramSetA;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds["Tc26-Gost-3410-12-512-paramSetA"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetA;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds["Tc26-Gost-3410-12-512-paramSetB"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetB;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds["Tc26-Gost-3410-12-512-paramSetC"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetC;
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProA] = "GostR3410-2001-CryptoPro-A";
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProB] = "GostR3410-2001-CryptoPro-B";
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProC] = "GostR3410-2001-CryptoPro-C";
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProXchA] = "GostR3410-2001-CryptoPro-XchA";
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001CryptoProXchB] = "GostR3410-2001-CryptoPro-XchB";
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256_paramSetA] = "Tc26-Gost-3410-12-256-paramSetA";
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetA] = "Tc26-Gost-3410-12-512-paramSetA";
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetB] = "Tc26-Gost-3410-12-512-paramSetB";
			global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSetC] = "Tc26-Gost-3410-12-512-paramSetC";
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x001290EA File Offset: 0x001272EA
		[global::System.Obsolete("Use 'GetByOidX9' instead")]
		public static global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters GetByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[oid];
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x001290FC File Offset: 0x001272FC
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOidX9(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ec = (global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[oid];
			if (ec != null)
			{
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(ec.Curve, new global::Org.BouncyCastle.Asn1.X9.X9ECPoint(ec.G, false), ec.N, ec.H, ec.GetSeed());
			}
			return null;
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x00129148 File Offset: 0x00127348
		public static global::System.Collections.IEnumerable Names
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names.Values);
			}
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x0012915C File Offset: 0x0012735C
		[global::System.Obsolete("Use 'GetByNameX9' instead")]
		public static global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters GetByName(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds[name];
			if (oid != null)
			{
				return (global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters)global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.parameters[oid];
			}
			return null;
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x00129190 File Offset: 0x00127390
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByNameX9(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds[name];
			if (oid != null)
			{
				return global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.GetByOidX9(oid);
			}
			return null;
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x001291B9 File Offset: 0x001273B9
		public static string GetName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.names[oid];
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x001291CB File Offset: 0x001273CB
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
		{
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410NamedCurves.objIds[name];
		}

		// Token: 0x04001F86 RID: 8070
		internal static readonly global::System.Collections.IDictionary objIds = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001F87 RID: 8071
		internal static readonly global::System.Collections.IDictionary parameters = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001F88 RID: 8072
		internal static readonly global::System.Collections.IDictionary names = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
