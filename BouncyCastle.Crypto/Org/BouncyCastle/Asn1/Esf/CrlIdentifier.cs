using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000708 RID: 1800
	public class CrlIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040F7 RID: 16631 RVA: 0x001266B4 File Offset: 0x001248B4
		public static global::Org.BouncyCastle.Asn1.Esf.CrlIdentifier GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.CrlIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.CrlIdentifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.CrlIdentifier((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'CrlIdentifier' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x00126704 File Offset: 0x00124904
		private CrlIdentifier(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count < 2 || seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.crlIssuer = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(seq[0]);
			this.crlIssuedTime = global::Org.BouncyCastle.Asn1.DerUtcTime.GetInstance(seq[1]);
			if (seq.Count > 2)
			{
				this.crlNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[2]);
			}
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x00126799 File Offset: 0x00124999
		public CrlIdentifier(global::Org.BouncyCastle.Asn1.X509.X509Name crlIssuer, global::System.DateTime crlIssuedTime) : this(crlIssuer, crlIssuedTime, null)
		{
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x001267A4 File Offset: 0x001249A4
		public CrlIdentifier(global::Org.BouncyCastle.Asn1.X509.X509Name crlIssuer, global::System.DateTime crlIssuedTime, global::Org.BouncyCastle.Math.BigInteger crlNumber)
		{
			if (crlIssuer == null)
			{
				throw new global::System.ArgumentNullException("crlIssuer");
			}
			this.crlIssuer = crlIssuer;
			this.crlIssuedTime = new global::Org.BouncyCastle.Asn1.DerUtcTime(crlIssuedTime);
			if (crlNumber != null)
			{
				this.crlNumber = new global::Org.BouncyCastle.Asn1.DerInteger(crlNumber);
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x001267DC File Offset: 0x001249DC
		public global::Org.BouncyCastle.Asn1.X509.X509Name CrlIssuer
		{
			get
			{
				return this.crlIssuer;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060040FC RID: 16636 RVA: 0x001267E4 File Offset: 0x001249E4
		public global::System.DateTime CrlIssuedTime
		{
			get
			{
				return this.crlIssuedTime.ToAdjustedDateTime();
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060040FD RID: 16637 RVA: 0x001267F1 File Offset: 0x001249F1
		public global::Org.BouncyCastle.Math.BigInteger CrlNumber
		{
			get
			{
				if (this.crlNumber != null)
				{
					return this.crlNumber.Value;
				}
				return null;
			}
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x00126808 File Offset: 0x00124A08
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.crlIssuer.ToAsn1Object(),
				this.crlIssuedTime
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.crlNumber
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F1E RID: 7966
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Name crlIssuer;

		// Token: 0x04001F1F RID: 7967
		private readonly global::Org.BouncyCastle.Asn1.DerUtcTime crlIssuedTime;

		// Token: 0x04001F20 RID: 7968
		private readonly global::Org.BouncyCastle.Asn1.DerInteger crlNumber;
	}
}
