using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200065A RID: 1626
	public class IssuerSerial : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C2A RID: 15402 RVA: 0x00113D98 File Offset: 0x00111F98
		public static global::Org.BouncyCastle.Asn1.X509.IssuerSerial GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.IssuerSerial)
			{
				return (global::Org.BouncyCastle.Asn1.X509.IssuerSerial)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.IssuerSerial((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x00113DE5 File Offset: 0x00111FE5
		public static global::Org.BouncyCastle.Asn1.X509.IssuerSerial GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.IssuerSerial.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x00113DF4 File Offset: 0x00111FF4
		private IssuerSerial(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2 && seq.Count != 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.issuer = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(seq[0]);
			this.serial = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
			if (seq.Count == 3)
			{
				this.issuerUid = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[2]);
			}
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x00113E76 File Offset: 0x00112076
		public IssuerSerial(global::Org.BouncyCastle.Asn1.X509.GeneralNames issuer, global::Org.BouncyCastle.Asn1.DerInteger serial)
		{
			this.issuer = issuer;
			this.serial = serial;
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x00113E8C File Offset: 0x0011208C
		public global::Org.BouncyCastle.Asn1.X509.GeneralNames Issuer
		{
			get
			{
				return this.issuer;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06003C2F RID: 15407 RVA: 0x00113E94 File Offset: 0x00112094
		public global::Org.BouncyCastle.Asn1.DerInteger Serial
		{
			get
			{
				return this.serial;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x00113E9C File Offset: 0x0011209C
		public global::Org.BouncyCastle.Asn1.DerBitString IssuerUid
		{
			get
			{
				return this.issuerUid;
			}
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x00113EA4 File Offset: 0x001120A4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.issuer,
				this.serial
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.issuerUid
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001A7D RID: 6781
		internal readonly global::Org.BouncyCastle.Asn1.X509.GeneralNames issuer;

		// Token: 0x04001A7E RID: 6782
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger serial;

		// Token: 0x04001A7F RID: 6783
		internal readonly global::Org.BouncyCastle.Asn1.DerBitString issuerUid;
	}
}
