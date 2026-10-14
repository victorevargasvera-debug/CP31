using System;
using Org.BouncyCastle.Asn1.X9;

namespace Org.BouncyCastle.Asn1.Sec
{
	// Token: 0x020006A6 RID: 1702
	public abstract class SecObjectIdentifiers
	{
		// Token: 0x06003E7E RID: 15998 RVA: 0x0011CF08 File Offset: 0x0011B108
		// Note: this type is marked as 'beforefieldinit'.
		static SecObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve != null) ? ellipticCurve.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve2 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve2 != null) ? ellipticCurve2.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve3 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT239k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve3 != null) ? ellipticCurve3.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve4 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve4 != null) ? ellipticCurve4.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve5 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT113r2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve5 != null) ? ellipticCurve5.ToString() : null) + ".5");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve6 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP112r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve6 != null) ? ellipticCurve6.ToString() : null) + ".6");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve7 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP112r2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve7 != null) ? ellipticCurve7.ToString() : null) + ".7");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve8 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve8 != null) ? ellipticCurve8.ToString() : null) + ".8");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve9 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve9 != null) ? ellipticCurve9.ToString() : null) + ".9");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve10 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve10 != null) ? ellipticCurve10.ToString() : null) + ".10");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve11 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT163r2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve11 != null) ? ellipticCurve11.ToString() : null) + ".15");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve12 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve12 != null) ? ellipticCurve12.ToString() : null) + ".16");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve13 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT283r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve13 != null) ? ellipticCurve13.ToString() : null) + ".17");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve14 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve14 != null) ? ellipticCurve14.ToString() : null) + ".22");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve15 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT131r2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve15 != null) ? ellipticCurve15.ToString() : null) + ".23");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve16 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve16 != null) ? ellipticCurve16.ToString() : null) + ".24");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve17 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT193r2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve17 != null) ? ellipticCurve17.ToString() : null) + ".25");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve18 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve18 != null) ? ellipticCurve18.ToString() : null) + ".26");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve19 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT233r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve19 != null) ? ellipticCurve19.ToString() : null) + ".27");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve20 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP128r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve20 != null) ? ellipticCurve20.ToString() : null) + ".28");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve21 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP128r2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve21 != null) ? ellipticCurve21.ToString() : null) + ".29");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve22 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP160r2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve22 != null) ? ellipticCurve22.ToString() : null) + ".30");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve23 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve23 != null) ? ellipticCurve23.ToString() : null) + ".31");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve24 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve24 != null) ? ellipticCurve24.ToString() : null) + ".32");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve25 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve25 != null) ? ellipticCurve25.ToString() : null) + ".33");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve26 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP384r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve26 != null) ? ellipticCurve26.ToString() : null) + ".34");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve27 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP521r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve27 != null) ? ellipticCurve27.ToString() : null) + ".35");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve28 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve28 != null) ? ellipticCurve28.ToString() : null) + ".36");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve29 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT409r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve29 != null) ? ellipticCurve29.ToString() : null) + ".37");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve30 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571k1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve30 != null) ? ellipticCurve30.ToString() : null) + ".38");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve31 = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecT571r1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve31 != null) ? ellipticCurve31.ToString() : null) + ".39");
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP192r1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v1;
			global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP256r1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime256v1;
		}

		// Token: 0x04001C2B RID: 7211
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EllipticCurve = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.132.0");

		// Token: 0x04001C2C RID: 7212
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT163k1;

		// Token: 0x04001C2D RID: 7213
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT163r1;

		// Token: 0x04001C2E RID: 7214
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT239k1;

		// Token: 0x04001C2F RID: 7215
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT113r1;

		// Token: 0x04001C30 RID: 7216
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT113r2;

		// Token: 0x04001C31 RID: 7217
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP112r1;

		// Token: 0x04001C32 RID: 7218
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP112r2;

		// Token: 0x04001C33 RID: 7219
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP160r1;

		// Token: 0x04001C34 RID: 7220
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP160k1;

		// Token: 0x04001C35 RID: 7221
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP256k1;

		// Token: 0x04001C36 RID: 7222
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT163r2;

		// Token: 0x04001C37 RID: 7223
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT283k1;

		// Token: 0x04001C38 RID: 7224
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT283r1;

		// Token: 0x04001C39 RID: 7225
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT131r1;

		// Token: 0x04001C3A RID: 7226
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT131r2;

		// Token: 0x04001C3B RID: 7227
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT193r1;

		// Token: 0x04001C3C RID: 7228
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT193r2;

		// Token: 0x04001C3D RID: 7229
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT233k1;

		// Token: 0x04001C3E RID: 7230
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT233r1;

		// Token: 0x04001C3F RID: 7231
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP128r1;

		// Token: 0x04001C40 RID: 7232
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP128r2;

		// Token: 0x04001C41 RID: 7233
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP160r2;

		// Token: 0x04001C42 RID: 7234
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP192k1;

		// Token: 0x04001C43 RID: 7235
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP224k1;

		// Token: 0x04001C44 RID: 7236
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP224r1;

		// Token: 0x04001C45 RID: 7237
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP384r1;

		// Token: 0x04001C46 RID: 7238
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP521r1;

		// Token: 0x04001C47 RID: 7239
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT409k1;

		// Token: 0x04001C48 RID: 7240
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT409r1;

		// Token: 0x04001C49 RID: 7241
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT571k1;

		// Token: 0x04001C4A RID: 7242
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecT571r1;

		// Token: 0x04001C4B RID: 7243
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP192r1;

		// Token: 0x04001C4C RID: 7244
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SecP256r1;
	}
}
