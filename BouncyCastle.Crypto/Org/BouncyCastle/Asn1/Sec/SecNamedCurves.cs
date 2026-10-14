using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Endo;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.Sec
{
	// Token: 0x020006A5 RID: 1701
	public sealed class SecNamedCurves
	{
		// Token: 0x06003E71 RID: 15985 RVA: 0x0011CB44 File Offset: 0x0011AD44
		private SecNamedCurves()
		{
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x0011CB4C File Offset: 0x0011AD4C
		private static global::Org.BouncyCastle.Asn1.X9.X9ECPoint ConfigureBasepoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, string encoding)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECPoint x9ECPoint = new global::Org.BouncyCastle.Asn1.X9.X9ECPoint(curve, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(encoding));
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ConfigureBasepoint(x9ECPoint.Point);
			return x9ECPoint;
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x0011CB65 File Offset: 0x0011AD65
		private static global::Org.BouncyCastle.Math.EC.ECCurve ConfigureCurve(global::Org.BouncyCastle.Math.EC.ECCurve curve)
		{
			return curve;
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x0011CB68 File Offset: 0x0011AD68
		private static global::Org.BouncyCastle.Math.EC.ECCurve ConfigureCurveGlv(global::Org.BouncyCastle.Math.EC.ECCurve c, global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters p)
		{
			return c.Configure().SetEndomorphism(new global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBEndomorphism(c, p)).Create();
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x0011CB81 File Offset: 0x0011AD81
		private static global::Org.BouncyCastle.Math.BigInteger FromHex(string hex)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(hex));
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x0011CB8F File Offset: 0x0011AD8F
		private static void DefineCurve(string name, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder)
		{
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.objIds.Add(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name), oid);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.names.Add(oid, name);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.curves.Add(oid, holder);
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x0011CBBC File Offset: 0x0011ADBC
		static SecNamedCurves()
		{
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp112r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP112r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp112r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp112r2", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP112r2, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp112r2Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp128r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP128r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp128r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp128r2", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP128r2, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp128r2Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp160k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp160k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp160r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp160r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp160r2", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r2, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp160r2Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp192k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp192k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp192r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp192r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp224k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp224k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp224r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp224r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp256k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp256k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp256r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp256r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp384r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP384r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp384r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("secp521r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP521r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp521r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect113r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect113r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect113r2", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r2, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect113r2Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect131r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect131r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect131r2", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r2, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect131r2Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect163k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect163k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect163r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect163r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect163r2", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r2, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect163r2Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect193r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect193r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect193r2", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r2, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect193r2Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect233k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect233k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect233r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect233r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect239k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT239k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect239k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect283k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect283k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect283r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect283r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect409k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect409k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect409r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect409r1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect571k1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571k1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect571k1Holder.Instance);
			global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.DefineCurve("sect571r1", global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571r1, global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect571r1Holder.Instance);
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x0011CE7C File Offset: 0x0011B07C
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByName(string name)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetOid(name);
			if (oid != null)
			{
				return global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.GetByOid(oid);
			}
			return null;
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x0011CE9C File Offset: 0x0011B09C
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder holder = (global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder)global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.curves[oid];
			if (holder != null)
			{
				return holder.Parameters;
			}
			return null;
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x0011CEC5 File Offset: 0x0011B0C5
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOid(string name)
		{
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.objIds[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name)];
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x0011CEDC File Offset: 0x0011B0DC
		public static string GetName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.names[oid];
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x0011CEEE File Offset: 0x0011B0EE
		public static global::System.Collections.IEnumerable Names
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.names.Values);
			}
		}

		// Token: 0x04001C28 RID: 7208
		private static readonly global::System.Collections.IDictionary objIds = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001C29 RID: 7209
		private static readonly global::System.Collections.IDictionary curves = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001C2A RID: 7210
		private static readonly global::System.Collections.IDictionary names = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x02000878 RID: 2168
		internal class Secp112r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047CC RID: 18380 RVA: 0x0013C99C File Offset: 0x0013AB9C
			private Secp112r1Holder()
			{
			}

			// Token: 0x060047CD RID: 18381 RVA: 0x0013C9A4 File Offset: 0x0013ABA4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("DB7C2ABF62E35E668076BEAD208B");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("DB7C2ABF62E35E668076BEAD2088");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("659EF8BA043916EEDE8911702B22");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("00F50B028E4D696E676875615175290472783FB1");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("DB7C2ABF62E35E7628DFAC6561C5");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0409487239995A5EE76B55F9C2F098A89CE5AF8724C0A23E0E0FF77500");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025F3 RID: 9715
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp112r1Holder();
		}

		// Token: 0x02000879 RID: 2169
		internal class Secp112r2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047CF RID: 18383 RVA: 0x0013CA21 File Offset: 0x0013AC21
			private Secp112r2Holder()
			{
			}

			// Token: 0x060047D0 RID: 18384 RVA: 0x0013CA2C File Offset: 0x0013AC2C
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("DB7C2ABF62E35E668076BEAD208B");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("6127C24C05F38A0AAAF65C0EF02C");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("51DEF1815DB5ED74FCC34C85D709");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("002757A1114D696E6768756151755316C05E0BD4");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("36DF0AAFD8B8D7597CA10520D04B");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "044BA30AB5E892B4E1649DD0928643ADCD46F5882E3747DEF36E956E97");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025F4 RID: 9716
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp112r2Holder();
		}

		// Token: 0x0200087A RID: 2170
		internal class Secp128r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047D2 RID: 18386 RVA: 0x0013CAAB File Offset: 0x0013ACAB
			private Secp128r1Holder()
			{
			}

			// Token: 0x060047D3 RID: 18387 RVA: 0x0013CAB4 File Offset: 0x0013ACB4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFDFFFFFFFFFFFFFFFFFFFFFFFF");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFDFFFFFFFFFFFFFFFFFFFFFFFC");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("E87579C11079F43DD824993C2CEE5ED3");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("000E0D4D696E6768756151750CC03A4473D03679");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFE0000000075A30D1B9038A115");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04161FF7528B899B2D0C28607CA52C5B86CF5AC8395BAFEB13C02DA292DDED7A83");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025F5 RID: 9717
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp128r1Holder();
		}

		// Token: 0x0200087B RID: 2171
		internal class Secp128r2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047D5 RID: 18389 RVA: 0x0013CB31 File Offset: 0x0013AD31
			private Secp128r2Holder()
			{
			}

			// Token: 0x060047D6 RID: 18390 RVA: 0x0013CB3C File Offset: 0x0013AD3C
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFDFFFFFFFFFFFFFFFFFFFFFFFF");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("D6031998D1B3BBFEBF59CC9BBFF9AEE1");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("5EEEFCA380D02919DC2C6558BB6D8A5D");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("004D696E67687561517512D8F03431FCE63B88F4");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("3FFFFFFF7FFFFFFFBE0024720613B5A3");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "047B6AA5D85E572983E6FB32A7CDEBC14027B6916A894D3AEE7106FE805FC34B44");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025F6 RID: 9718
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp128r2Holder();
		}

		// Token: 0x0200087C RID: 2172
		internal class Secp160k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047D8 RID: 18392 RVA: 0x0013CBBB File Offset: 0x0013ADBB
			private Secp160k1Holder()
			{
			}

			// Token: 0x060047D9 RID: 18393 RVA: 0x0013CBC4 File Offset: 0x0013ADC4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger p = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFAC73");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.Zero;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.ValueOf(7L);
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0100000000000000000001B8FA16DFAB9ACA16B6B3");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters glv = new global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters(new global::Org.BouncyCastle.Math.BigInteger("9ba48cba5ebcb9b6bd33b92830b2a2e0e192f10a", 16), new global::Org.BouncyCastle.Math.BigInteger("c39c6c3b3a36d7701b9c71a1f5804ae5d0003f4", 16), new global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters(new global::Org.BouncyCastle.Math.BigInteger[]
				{
					new global::Org.BouncyCastle.Math.BigInteger("9162fbe73984472a0a9e", 16),
					new global::Org.BouncyCastle.Math.BigInteger("-96341f1138933bc2f505", 16)
				}, new global::Org.BouncyCastle.Math.BigInteger[]
				{
					new global::Org.BouncyCastle.Math.BigInteger("127971af8721782ecffa3", 16),
					new global::Org.BouncyCastle.Math.BigInteger("9162fbe73984472a0a9e", 16)
				}, new global::Org.BouncyCastle.Math.BigInteger("9162fbe73984472a0a9d0590", 16), new global::Org.BouncyCastle.Math.BigInteger("96341f1138933bc2f503fd44", 16), 176));
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurveGlv(new global::Org.BouncyCastle.Math.EC.FpCurve(p, a, b, i, h), glv);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "043B4C382CE37AA192A4019E763036F4F5DD4D7EBB938CF935318FDCED6BC28286531733C3F03C4FEE");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025F7 RID: 9719
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp160k1Holder();
		}

		// Token: 0x0200087D RID: 2173
		internal class Secp160r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047DB RID: 18395 RVA: 0x0013CCC0 File Offset: 0x0013AEC0
			private Secp160r1Holder()
			{
			}

			// Token: 0x060047DC RID: 18396 RVA: 0x0013CCC8 File Offset: 0x0013AEC8
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF7FFFFFFF");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF7FFFFFFC");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("1C97BEFC54BD7A8B65ACF89F81D4D4ADC565FA45");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("1053CDE42C14D696E67687561517533BF3F83345");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0100000000000000000001F4C8F927AED3CA752257");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "044A96B5688EF573284664698968C38BB913CBFC8223A628553168947D59DCC912042351377AC5FB32");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025F8 RID: 9720
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp160r1Holder();
		}

		// Token: 0x0200087E RID: 2174
		internal class Secp160r2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047DE RID: 18398 RVA: 0x0013CD45 File Offset: 0x0013AF45
			private Secp160r2Holder()
			{
			}

			// Token: 0x060047DF RID: 18399 RVA: 0x0013CD50 File Offset: 0x0013AF50
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFAC73");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFAC70");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("B4E134D3FB59EB8BAB57274904664D5AF50388BA");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("B99B99B099B323E02709A4D696E6768756151751");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0100000000000000000000351EE786A818F3A1A16B");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0452DCB034293A117E1F4FF11B30F7199D3144CE6DFEAFFEF2E331F296E071FA0DF9982CFEA7D43F2E");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025F9 RID: 9721
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp160r2Holder();
		}

		// Token: 0x0200087F RID: 2175
		internal class Secp192k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047E1 RID: 18401 RVA: 0x0013CDCD File Offset: 0x0013AFCD
			private Secp192k1Holder()
			{
			}

			// Token: 0x060047E2 RID: 18402 RVA: 0x0013CDD8 File Offset: 0x0013AFD8
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger p = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFEE37");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.Zero;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.ValueOf(3L);
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFE26F2FC170F69466A74DEFD8D");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters glv = new global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters(new global::Org.BouncyCastle.Math.BigInteger("bb85691939b869c1d087f601554b96b80cb4f55b35f433c2", 16), new global::Org.BouncyCastle.Math.BigInteger("3d84f26c12238d7b4f3d516613c1759033b1a5800175d0b1", 16), new global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters(new global::Org.BouncyCastle.Math.BigInteger[]
				{
					new global::Org.BouncyCastle.Math.BigInteger("71169be7330b3038edb025f1", 16),
					new global::Org.BouncyCastle.Math.BigInteger("-b3fb3400dec5c4adceb8655c", 16)
				}, new global::Org.BouncyCastle.Math.BigInteger[]
				{
					new global::Org.BouncyCastle.Math.BigInteger("12511cfe811d0f4e6bc688b4d", 16),
					new global::Org.BouncyCastle.Math.BigInteger("71169be7330b3038edb025f1", 16)
				}, new global::Org.BouncyCastle.Math.BigInteger("71169be7330b3038edb025f1d0f9", 16), new global::Org.BouncyCastle.Math.BigInteger("b3fb3400dec5c4adceb8655d4c94", 16), 208));
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurveGlv(new global::Org.BouncyCastle.Math.EC.FpCurve(p, a, b, i, h), glv);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04DB4FF10EC057E9AE26B07D0280B7F4341DA5D1B1EAE06C7D9B2F2F6D9C5628A7844163D015BE86344082AA88D95E2F9D");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025FA RID: 9722
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp192k1Holder();
		}

		// Token: 0x02000880 RID: 2176
		internal class Secp192r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047E4 RID: 18404 RVA: 0x0013CED4 File Offset: 0x0013B0D4
			private Secp192r1Holder()
			{
			}

			// Token: 0x060047E5 RID: 18405 RVA: 0x0013CEDC File Offset: 0x0013B0DC
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFF");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFC");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("64210519E59C80E70FA7E9AB72243049FEB8DEECC146B9B1");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("3045AE6FC8422F64ED579528D38120EAE12196D5");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFF99DEF836146BC9B1B4D22831");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04188DA80EB03090F67CBF20EB43A18800F4FF0AFD82FF101207192B95FFC8DA78631011ED6B24CDD573F977A11E794811");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025FB RID: 9723
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp192r1Holder();
		}

		// Token: 0x02000881 RID: 2177
		internal class Secp224k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047E7 RID: 18407 RVA: 0x0013CF59 File Offset: 0x0013B159
			private Secp224k1Holder()
			{
			}

			// Token: 0x060047E8 RID: 18408 RVA: 0x0013CF64 File Offset: 0x0013B164
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger p = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFE56D");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.Zero;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.ValueOf(5L);
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("010000000000000000000000000001DCE8D2EC6184CAF0A971769FB1F7");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters glv = new global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters(new global::Org.BouncyCastle.Math.BigInteger("fe0e87005b4e83761908c5131d552a850b3f58b749c37cf5b84d6768", 16), new global::Org.BouncyCastle.Math.BigInteger("60dcd2104c4cbc0be6eeefc2bdd610739ec34e317f9b33046c9e4788", 16), new global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters(new global::Org.BouncyCastle.Math.BigInteger[]
				{
					new global::Org.BouncyCastle.Math.BigInteger("6b8cf07d4ca75c88957d9d670591", 16),
					new global::Org.BouncyCastle.Math.BigInteger("-b8adf1378a6eb73409fa6c9c637d", 16)
				}, new global::Org.BouncyCastle.Math.BigInteger[]
				{
					new global::Org.BouncyCastle.Math.BigInteger("1243ae1b4d71613bc9f780a03690e", 16),
					new global::Org.BouncyCastle.Math.BigInteger("6b8cf07d4ca75c88957d9d670591", 16)
				}, new global::Org.BouncyCastle.Math.BigInteger("6b8cf07d4ca75c88957d9d67059037a4", 16), new global::Org.BouncyCastle.Math.BigInteger("b8adf1378a6eb73409fa6c9c637ba7f5", 16), 240));
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurveGlv(new global::Org.BouncyCastle.Math.EC.FpCurve(p, a, b, i, h), glv);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04A1455B334DF099DF30FC28A169A467E9E47075A90F7E650EB6B7A45C7E089FED7FBA344282CAFBD6F7E319F7C0B0BD59E2CA4BDB556D61A5");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025FC RID: 9724
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp224k1Holder();
		}

		// Token: 0x02000882 RID: 2178
		internal class Secp224r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047EA RID: 18410 RVA: 0x0013D060 File Offset: 0x0013B260
			private Secp224r1Holder()
			{
			}

			// Token: 0x060047EB RID: 18411 RVA: 0x0013D068 File Offset: 0x0013B268
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF000000000000000000000001");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFE");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("B4050A850C04B3ABF54132565044B0B7D7BFD8BA270B39432355FFB4");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("BD71344799D5C7FCDC45B59FA3B9AB8F6A948BC5");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFF16A2E0B8F03E13DD29455C5C2A3D");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04B70E0CBD6BB4BF7F321390B94A03C1D356C21122343280D6115C1D21BD376388B5F723FB4C22DFE6CD4375A05A07476444D5819985007E34");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025FD RID: 9725
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp224r1Holder();
		}

		// Token: 0x02000883 RID: 2179
		internal class Secp256k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047ED RID: 18413 RVA: 0x0013D0E5 File Offset: 0x0013B2E5
			private Secp256k1Holder()
			{
			}

			// Token: 0x060047EE RID: 18414 RVA: 0x0013D0F0 File Offset: 0x0013B2F0
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger p = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFC2F");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.Zero;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.ValueOf(7L);
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEBAAEDCE6AF48A03BBFD25E8CD0364141");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters glv = new global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters(new global::Org.BouncyCastle.Math.BigInteger("7ae96a2b657c07106e64479eac3434e99cf0497512f58995c1396c28719501ee", 16), new global::Org.BouncyCastle.Math.BigInteger("5363ad4cc05c30e0a5261c028812645a122e22ea20816678df02967c1b23bd72", 16), new global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters(new global::Org.BouncyCastle.Math.BigInteger[]
				{
					new global::Org.BouncyCastle.Math.BigInteger("3086d221a7d46bcde86c90e49284eb15", 16),
					new global::Org.BouncyCastle.Math.BigInteger("-e4437ed6010e88286f547fa90abfe4c3", 16)
				}, new global::Org.BouncyCastle.Math.BigInteger[]
				{
					new global::Org.BouncyCastle.Math.BigInteger("114ca50f7a8e2f3f657c1108d9d44cfd8", 16),
					new global::Org.BouncyCastle.Math.BigInteger("3086d221a7d46bcde86c90e49284eb15", 16)
				}, new global::Org.BouncyCastle.Math.BigInteger("3086d221a7d46bcde86c90e49284eb153dab", 16), new global::Org.BouncyCastle.Math.BigInteger("e4437ed6010e88286f547fa90abfe4c42212", 16), 272));
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurveGlv(new global::Org.BouncyCastle.Math.EC.FpCurve(p, a, b, i, h), glv);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0479BE667EF9DCBBAC55A06295CE870B07029BFCDB2DCE28D959F2815B16F81798483ADA7726A3C4655DA4FBFC0E1108A8FD17B448A68554199C47D08FFB10D4B8");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025FE RID: 9726
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp256k1Holder();
		}

		// Token: 0x02000884 RID: 2180
		internal class Secp256r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047F0 RID: 18416 RVA: 0x0013D1EC File Offset: 0x0013B3EC
			private Secp256r1Holder()
			{
			}

			// Token: 0x060047F1 RID: 18417 RVA: 0x0013D1F4 File Offset: 0x0013B3F4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFF00000001000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFF");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFF00000001000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFC");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("5AC635D8AA3A93E7B3EBBD55769886BC651D06B0CC53B0F63BCE3C3E27D2604B");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("C49D360886E704936A6678E1139D26B7819F7E90");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFF00000000FFFFFFFFFFFFFFFFBCE6FAADA7179E84F3B9CAC2FC632551");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "046B17D1F2E12C4247F8BCE6E563A440F277037D812DEB33A0F4A13945D898C2964FE342E2FE1A7F9B8EE7EB4A7C0F9E162BCE33576B315ECECBB6406837BF51F5");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x040025FF RID: 9727
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp256r1Holder();
		}

		// Token: 0x02000885 RID: 2181
		internal class Secp384r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047F3 RID: 18419 RVA: 0x0013D271 File Offset: 0x0013B471
			private Secp384r1Holder()
			{
			}

			// Token: 0x060047F4 RID: 18420 RVA: 0x0013D27C File Offset: 0x0013B47C
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFF0000000000000000FFFFFFFF");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFF0000000000000000FFFFFFFC");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("B3312FA7E23EE7E4988E056BE3F82D19181D9C6EFE8141120314088F5013875AC656398D8A2ED19D2A85C8EDD3EC2AEF");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("A335926AA319A27A1D00896A6773A4827ACDAC73");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC7634D81F4372DDF581A0DB248B0A77AECEC196ACCC52973");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04AA87CA22BE8B05378EB1C71EF320AD746E1D3B628BA79B9859F741E082542A385502F25DBF55296C3A545E3872760AB73617DE4A96262C6F5D9E98BF9292DC29F8F41DBD289A147CE9DA3113B5F0B8C00A60B1CE1D7E819D7A431D7C90EA0E5F");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002600 RID: 9728
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp384r1Holder();
		}

		// Token: 0x02000886 RID: 2182
		internal class Secp521r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047F6 RID: 18422 RVA: 0x0013D2F9 File Offset: 0x0013B4F9
			private Secp521r1Holder()
			{
			}

			// Token: 0x060047F7 RID: 18423 RVA: 0x0013D304 File Offset: 0x0013B504
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0051953EB9618E1C9A1F929A21A0B68540EEA2DA725B99B315F3B8B489918EF109E156193951EC7E937B1652C0BD3BB1BF073573DF883D2C34F1EF451FD46B503F00");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("D09E8800291CB85396CC6717393284AAA0DA64BA");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFA51868783BF2F966B7FCC0148F709A5D03BB5C9B8899C47AEBB6FB71E91386409");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.EC.ECCurve curve = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureCurve(new global::Org.BouncyCastle.Math.EC.FpCurve(q, a, b, i, h));
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0400C6858E06B70404E9CD9E3ECB662395B4429C648139053FB521F828AF606B4D3DBAA14B5E77EFE75928FE1DC127A2FFA8DE3348B3C1856A429BF97E7E31C2E5BD66011839296A789A3BC0045C8A5FB42C7D1BD998F54449579B446817AFBD17273E662C97EE72995EF42640C550B9013FAD0761353C7086A272C24088BE94769FD16650");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002601 RID: 9729
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Secp521r1Holder();
		}

		// Token: 0x02000887 RID: 2183
		internal class Sect113r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047F9 RID: 18425 RVA: 0x0013D381 File Offset: 0x0013B581
			private Sect113r1Holder()
			{
			}

			// Token: 0x060047FA RID: 18426 RVA: 0x0013D38C File Offset: 0x0013B58C
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("003088250CA6E7C7FE649CE85820F7");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("00E8BEE4D3E2260744188BE0E9C723");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("10E723AB14D696E6768756151756FEBF8FCB49A9");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0100000000000000D9CCEC8A39E56F");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(113, 9, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04009D73616F35F4AB1407D73562C10F00A52830277958EE84D1315ED31886");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002602 RID: 9730
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect113r1Holder();

			// Token: 0x04002603 RID: 9731
			private const int m = 113;

			// Token: 0x04002604 RID: 9732
			private const int k = 9;
		}

		// Token: 0x02000888 RID: 2184
		internal class Sect113r2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047FC RID: 18428 RVA: 0x0013D400 File Offset: 0x0013B600
			private Sect113r2Holder()
			{
			}

			// Token: 0x060047FD RID: 18429 RVA: 0x0013D408 File Offset: 0x0013B608
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("00689918DBEC7E5A0DD6DFC0AA55C7");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0095E9A9EC9B297BD4BF36E059184F");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("10C0FB15760860DEF1EEF4D696E676875615175D");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("010000000000000108789B2496AF93");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(113, 9, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0401A57A6A7B26CA5EF52FCDB816479700B3ADC94ED1FE674C06E695BABA1D");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002605 RID: 9733
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect113r2Holder();

			// Token: 0x04002606 RID: 9734
			private const int m = 113;

			// Token: 0x04002607 RID: 9735
			private const int k = 9;
		}

		// Token: 0x02000889 RID: 2185
		internal class Sect131r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x060047FF RID: 18431 RVA: 0x0013D47C File Offset: 0x0013B67C
			private Sect131r1Holder()
			{
			}

			// Token: 0x06004800 RID: 18432 RVA: 0x0013D484 File Offset: 0x0013B684
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("07A11B09A76B562144418FF3FF8C2570B8");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0217C05610884B63B9C6C7291678F9D341");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("4D696E676875615175985BD3ADBADA21B43A97E2");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0400000000000000023123953A9464B54D");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(131, 2, 3, 8, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "040081BAF91FDF9833C40F9C181343638399078C6E7EA38C001F73C8134B1B4EF9E150");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002608 RID: 9736
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect131r1Holder();

			// Token: 0x04002609 RID: 9737
			private const int m = 131;

			// Token: 0x0400260A RID: 9738
			private const int k1 = 2;

			// Token: 0x0400260B RID: 9739
			private const int k2 = 3;

			// Token: 0x0400260C RID: 9740
			private const int k3 = 8;
		}

		// Token: 0x0200088A RID: 2186
		internal class Sect131r2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004802 RID: 18434 RVA: 0x0013D4FC File Offset: 0x0013B6FC
			private Sect131r2Holder()
			{
			}

			// Token: 0x06004803 RID: 18435 RVA: 0x0013D504 File Offset: 0x0013B704
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("03E5A88919D7CAFCBF415F07C2176573B2");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("04B8266A46C55657AC734CE38F018F2192");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("985BD3ADBAD4D696E676875615175A21B43A97E3");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0400000000000000016954A233049BA98F");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(131, 2, 3, 8, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "040356DCD8F2F95031AD652D23951BB366A80648F06D867940A5366D9E265DE9EB240F");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x0400260D RID: 9741
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect131r2Holder();

			// Token: 0x0400260E RID: 9742
			private const int m = 131;

			// Token: 0x0400260F RID: 9743
			private const int k1 = 2;

			// Token: 0x04002610 RID: 9744
			private const int k2 = 3;

			// Token: 0x04002611 RID: 9745
			private const int k3 = 8;
		}

		// Token: 0x0200088B RID: 2187
		internal class Sect163k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004805 RID: 18437 RVA: 0x0013D57C File Offset: 0x0013B77C
			private Sect163k1Holder()
			{
			}

			// Token: 0x06004806 RID: 18438 RVA: 0x0013D584 File Offset: 0x0013B784
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.One;
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("04000000000000000000020108A2E0CC0D99F8A5EF");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(163, 3, 6, 7, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0402FE13C0537BBC11ACAA07D793DE4E6D5E5C94EEE80289070FB05D38FF58321F2E800536D538CCDAA3D9");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002612 RID: 9746
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect163k1Holder();

			// Token: 0x04002613 RID: 9747
			private const int m = 163;

			// Token: 0x04002614 RID: 9748
			private const int k1 = 3;

			// Token: 0x04002615 RID: 9749
			private const int k2 = 6;

			// Token: 0x04002616 RID: 9750
			private const int k3 = 7;
		}

		// Token: 0x0200088C RID: 2188
		internal class Sect163r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004808 RID: 18440 RVA: 0x0013D5E9 File Offset: 0x0013B7E9
			private Sect163r1Holder()
			{
			}

			// Token: 0x06004809 RID: 18441 RVA: 0x0013D5F4 File Offset: 0x0013B7F4
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("07B6882CAAEFA84F9554FF8428BD88E246D2782AE2");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0713612DCDDCB40AAB946BDA29CA91F73AF958AFD9");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("24B7B137C8A14D696E6768756151756FD0DA2E5C");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("03FFFFFFFFFFFFFFFFFFFF48AAB689C29CA710279B");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(163, 3, 6, 7, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "040369979697AB43897789566789567F787A7876A65400435EDB42EFAFB2989D51FEFCE3C80988F41FF883");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002617 RID: 9751
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect163r1Holder();

			// Token: 0x04002618 RID: 9752
			private const int m = 163;

			// Token: 0x04002619 RID: 9753
			private const int k1 = 3;

			// Token: 0x0400261A RID: 9754
			private const int k2 = 6;

			// Token: 0x0400261B RID: 9755
			private const int k3 = 7;
		}

		// Token: 0x0200088D RID: 2189
		internal class Sect163r2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600480B RID: 18443 RVA: 0x0013D66C File Offset: 0x0013B86C
			private Sect163r2Holder()
			{
			}

			// Token: 0x0600480C RID: 18444 RVA: 0x0013D674 File Offset: 0x0013B874
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("020A601907B8C953CA1481EB10512F78744A3205FD");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("85E25BFE5C86226CDB12016F7553F9D0E693A268");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("040000000000000000000292FE77E70C12A4234C33");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(163, 3, 6, 7, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0403F0EBA16286A2D57EA0991168D4994637E8343E3600D51FBC6C71A0094FA2CDD545B11C5C0C797324F1");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x0400261C RID: 9756
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect163r2Holder();

			// Token: 0x0400261D RID: 9757
			private const int m = 163;

			// Token: 0x0400261E RID: 9758
			private const int k1 = 3;

			// Token: 0x0400261F RID: 9759
			private const int k2 = 6;

			// Token: 0x04002620 RID: 9760
			private const int k3 = 7;
		}

		// Token: 0x0200088E RID: 2190
		internal class Sect193r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600480E RID: 18446 RVA: 0x0013D6E7 File Offset: 0x0013B8E7
			private Sect193r1Holder()
			{
			}

			// Token: 0x0600480F RID: 18447 RVA: 0x0013D6F0 File Offset: 0x0013B8F0
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0017858FEB7A98975169E171F77B4087DE098AC8A911DF7B01");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("00FDFB49BFE6C3A89FACADAA7A1E5BBC7CC1C2E5D831478814");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("103FAEC74D696E676875615175777FC5B191EF30");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("01000000000000000000000000C7F34A778F443ACC920EBA49");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(193, 15, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0401F481BC5F0FF84A74AD6CDF6FDEF4BF6179625372D8C0C5E10025E399F2903712CCF3EA9E3A1AD17FB0B3201B6AF7CE1B05");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002621 RID: 9761
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect193r1Holder();

			// Token: 0x04002622 RID: 9762
			private const int m = 193;

			// Token: 0x04002623 RID: 9763
			private const int k = 15;
		}

		// Token: 0x0200088F RID: 2191
		internal class Sect193r2Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004811 RID: 18449 RVA: 0x0013D767 File Offset: 0x0013B967
			private Sect193r2Holder()
			{
			}

			// Token: 0x06004812 RID: 18450 RVA: 0x0013D770 File Offset: 0x0013B970
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0163F35A5137C2CE3EA6ED8667190B0BC43ECD69977702709B");
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("00C9BB9E8927D4D64C377E2AB2856A5B16E3EFB7F61D4316AE");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("10B7B4D696E676875615175137C8A16FD0DA2211");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("010000000000000000000000015AAB561B005413CCD4EE99D5");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(193, 15, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0400D9B67D192E0367C803F39E1A7E82CA14A651350AAE617E8F01CE94335607C304AC29E7DEFBD9CA01F596F927224CDECF6C");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002624 RID: 9764
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect193r2Holder();

			// Token: 0x04002625 RID: 9765
			private const int m = 193;

			// Token: 0x04002626 RID: 9766
			private const int k = 15;
		}

		// Token: 0x02000890 RID: 2192
		internal class Sect233k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004814 RID: 18452 RVA: 0x0013D7E7 File Offset: 0x0013B9E7
			private Sect233k1Holder()
			{
			}

			// Token: 0x06004815 RID: 18453 RVA: 0x0013D7F0 File Offset: 0x0013B9F0
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.Zero;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.One;
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("8000000000000000000000000000069D5BB915BCD46EFB1AD5F173ABDF");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(233, 74, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04017232BA853A7E731AF129F22FF4149563A419C26BF50A4C9D6EEFAD612601DB537DECE819B7F70F555A67C427A8CD9BF18AEB9B56E0C11056FAE6A3");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002627 RID: 9767
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect233k1Holder();

			// Token: 0x04002628 RID: 9768
			private const int m = 233;

			// Token: 0x04002629 RID: 9769
			private const int k = 74;
		}

		// Token: 0x02000891 RID: 2193
		internal class Sect233r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004817 RID: 18455 RVA: 0x0013D854 File Offset: 0x0013BA54
			private Sect233r1Holder()
			{
			}

			// Token: 0x06004818 RID: 18456 RVA: 0x0013D85C File Offset: 0x0013BA5C
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0066647EDE6C332C7F8C0923BB58213B333B20E9CE4281FE115F7D8F90AD");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("74D59FF07F6B413D0EA14B344B20A2DB049B50C3");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("01000000000000000000000000000013E974E72F8A6922031D2603CFE0D7");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(233, 74, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0400FAC9DFCBAC8313BB2139F1BB755FEF65BC391F8B36F8F8EB7371FD558B01006A08A41903350678E58528BEBF8A0BEFF867A7CA36716F7E01F81052");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x0400262A RID: 9770
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect233r1Holder();

			// Token: 0x0400262B RID: 9771
			private const int m = 233;

			// Token: 0x0400262C RID: 9772
			private const int k = 74;
		}

		// Token: 0x02000892 RID: 2194
		internal class Sect239k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600481A RID: 18458 RVA: 0x0013D8CE File Offset: 0x0013BACE
			private Sect239k1Holder()
			{
			}

			// Token: 0x0600481B RID: 18459 RVA: 0x0013D8D8 File Offset: 0x0013BAD8
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.Zero;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.One;
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("2000000000000000000000000000005A79FEC67CB6E91F1C1DA800E478A5");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(239, 158, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0429A0B6A887A983E9730988A68727A8B2D126C44CC2CC7B2A6555193035DC76310804F12E549BDB011C103089E73510ACB275FC312A5DC6B76553F0CA");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x0400262D RID: 9773
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect239k1Holder();

			// Token: 0x0400262E RID: 9774
			private const int m = 239;

			// Token: 0x0400262F RID: 9775
			private const int k = 158;
		}

		// Token: 0x02000893 RID: 2195
		internal class Sect283k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600481D RID: 18461 RVA: 0x0013D93F File Offset: 0x0013BB3F
			private Sect283k1Holder()
			{
			}

			// Token: 0x0600481E RID: 18462 RVA: 0x0013D948 File Offset: 0x0013BB48
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.Zero;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.One;
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE9AE2ED07577265DFF7F94451E061E163C61");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(283, 5, 7, 12, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "040503213F78CA44883F1A3B8162F188E553CD265F23C1567A16876913B0C2AC245849283601CCDA380F1C9E318D90F95D07E5426FE87E45C0E8184698E45962364E34116177DD2259");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002630 RID: 9776
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect283k1Holder();

			// Token: 0x04002631 RID: 9777
			private const int m = 283;

			// Token: 0x04002632 RID: 9778
			private const int k1 = 5;

			// Token: 0x04002633 RID: 9779
			private const int k2 = 7;

			// Token: 0x04002634 RID: 9780
			private const int k3 = 12;
		}

		// Token: 0x02000894 RID: 2196
		internal class Sect283r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004820 RID: 18464 RVA: 0x0013D9AE File Offset: 0x0013BBAE
			private Sect283r1Holder()
			{
			}

			// Token: 0x06004821 RID: 18465 RVA: 0x0013D9B8 File Offset: 0x0013BBB8
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("027B680AC8B8596DA5A4AF8A19A0303FCA97FD7645309FA2A581485AF6263E313B79A2F5");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("77E2B07370EB0F832A6DD5B62DFC88CD06BB84BE");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("03FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEF90399660FC938A90165B042A7CEFADB307");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(283, 5, 7, 12, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "0405F939258DB7DD90E1934F8C70B0DFEC2EED25B8557EAC9C80E2E198F8CDBECD86B1205303676854FE24141CB98FE6D4B20D02B4516FF702350EDDB0826779C813F0DF45BE8112F4");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002635 RID: 9781
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect283r1Holder();

			// Token: 0x04002636 RID: 9782
			private const int m = 283;

			// Token: 0x04002637 RID: 9783
			private const int k1 = 5;

			// Token: 0x04002638 RID: 9784
			private const int k2 = 7;

			// Token: 0x04002639 RID: 9785
			private const int k3 = 12;
		}

		// Token: 0x02000895 RID: 2197
		internal class Sect409k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004823 RID: 18467 RVA: 0x0013DA2C File Offset: 0x0013BC2C
			private Sect409k1Holder()
			{
			}

			// Token: 0x06004824 RID: 18468 RVA: 0x0013DA34 File Offset: 0x0013BC34
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.Zero;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.One;
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("7FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE5F83B2D4EA20400EC4557D5ED3E3E7CA5B4B5C83B8E01E5FCF");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(409, 87, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "040060F05F658F49C1AD3AB1890F7184210EFD0987E307C84C27ACCFB8F9F67CC2C460189EB5AAAA62EE222EB1B35540CFE902374601E369050B7C4E42ACBA1DACBF04299C3460782F918EA427E6325165E9EA10E3DA5F6C42E9C55215AA9CA27A5863EC48D8E0286B");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x0400263A RID: 9786
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect409k1Holder();

			// Token: 0x0400263B RID: 9787
			private const int m = 409;

			// Token: 0x0400263C RID: 9788
			private const int k = 87;
		}

		// Token: 0x02000896 RID: 2198
		internal class Sect409r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004826 RID: 18470 RVA: 0x0013DA98 File Offset: 0x0013BC98
			private Sect409r1Holder()
			{
			}

			// Token: 0x06004827 RID: 18471 RVA: 0x0013DAA0 File Offset: 0x0013BCA0
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("0021A5C2C8EE9FEB5C4B9A753B7B476B7FD6422EF1F3DD674761FA99D6AC27C8A9A197B272822F6CD57A55AA4F50AE317B13545F");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("4099B5A457F9D69F79213D094C4BCD4D4262210B");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("010000000000000000000000000000000000000000000000000001E2AAD6A612F33307BE5FA47C3C9E052F838164CD37D9A21173");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(409, 87, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04015D4860D088DDB3496B0C6064756260441CDE4AF1771D4DB01FFE5B34E59703DC255A868A1180515603AEAB60794E54BB7996A70061B1CFAB6BE5F32BBFA78324ED106A7636B9C5A7BD198D0158AA4F5488D08F38514F1FDF4B4F40D2181B3681C364BA0273C706");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x0400263D RID: 9789
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect409r1Holder();

			// Token: 0x0400263E RID: 9790
			private const int m = 409;

			// Token: 0x0400263F RID: 9791
			private const int k = 87;
		}

		// Token: 0x02000897 RID: 2199
		internal class Sect571k1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x06004829 RID: 18473 RVA: 0x0013DB12 File Offset: 0x0013BD12
			private Sect571k1Holder()
			{
			}

			// Token: 0x0600482A RID: 18474 RVA: 0x0013DB1C File Offset: 0x0013BD1C
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.Zero;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.BigInteger.One;
				byte[] S = null;
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("020000000000000000000000000000000000000000000000000000000000000000000000131850E1F19A63E4B391A8DB917F4138B630D84BE5D639381E91DEB45CFE778F637C1001");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(571, 2, 5, 10, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "04026EB7A859923FBC82189631F8103FE4AC9CA2970012D5D46024804801841CA44370958493B205E647DA304DB4CEB08CBBD1BA39494776FB988B47174DCA88C7E2945283A01C89720349DC807F4FBF374F4AEADE3BCA95314DD58CEC9F307A54FFC61EFC006D8A2C9D4979C0AC44AEA74FBEBBB9F772AEDCB620B01A7BA7AF1B320430C8591984F601CD4C143EF1C7A3");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002640 RID: 9792
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect571k1Holder();

			// Token: 0x04002641 RID: 9793
			private const int m = 571;

			// Token: 0x04002642 RID: 9794
			private const int k1 = 2;

			// Token: 0x04002643 RID: 9795
			private const int k2 = 5;

			// Token: 0x04002644 RID: 9796
			private const int k3 = 10;
		}

		// Token: 0x02000898 RID: 2200
		internal class Sect571r1Holder : global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder
		{
			// Token: 0x0600482C RID: 18476 RVA: 0x0013DB82 File Offset: 0x0013BD82
			private Sect571r1Holder()
			{
			}

			// Token: 0x0600482D RID: 18477 RVA: 0x0013DB8C File Offset: 0x0013BD8C
			protected override global::Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters()
			{
				global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Math.BigInteger.One;
				global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("02F40E7E2221F295DE297117B7F3D62F5C6A97FFCB8CEFF1CD6BA8CE4A9A18AD84FFABBD8EFA59332BE7AD6756A66E294AFD185A78FF12AA520E4DE739BACA0C7FFEFF7F2955727A");
				byte[] S = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("2AA058F73A0E33AB486B0F610410C53A7F132310");
				global::Org.BouncyCastle.Math.BigInteger i = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.FromHex("03FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE661CE18FF55987308059B186823851EC7DD9CA1161DE93D5174D66E8382E9BB2FE84E47");
				global::Org.BouncyCastle.Math.BigInteger h = global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L);
				global::Org.BouncyCastle.Math.EC.F2mCurve curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(571, 2, 5, 10, a, b, i, h);
				global::Org.BouncyCastle.Asn1.X9.X9ECPoint G = global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.ConfigureBasepoint(curve, "040303001D34B856296C16C0D40D3CD7750A93D1D2955FA80AA5F40FC8DB7B2ABDBDE53950F4C0D293CDD711A35B67FB1499AE60038614F1394ABFA3B4C850D927E1E7769C8EEC2D19037BF27342DA639B6DCCFFFEB73D69D78C6C27A6009CBBCA1980F8533921E8A684423E43BAB08A576291AF8F461BB2A8B3531D2F0485C19B16E2F1516E23DD3C1A4827AF1B8AC15B");
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(curve, G, i, h, S);
			}

			// Token: 0x04002645 RID: 9797
			internal static readonly global::Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance = new global::Org.BouncyCastle.Asn1.Sec.SecNamedCurves.Sect571r1Holder();

			// Token: 0x04002646 RID: 9798
			private const int m = 571;

			// Token: 0x04002647 RID: 9799
			private const int k1 = 2;

			// Token: 0x04002648 RID: 9800
			private const int k2 = 5;

			// Token: 0x04002649 RID: 9801
			private const int k3 = 10;
		}
	}
}
