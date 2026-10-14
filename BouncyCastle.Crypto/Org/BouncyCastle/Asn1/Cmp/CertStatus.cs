using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000771 RID: 1905
	public class CertStatus : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043F6 RID: 17398 RVA: 0x0012F874 File Offset: 0x0012DA74
		private CertStatus(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.certHash = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]);
			this.certReqId = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
			if (seq.Count > 2)
			{
				this.statusInfo = global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo.GetInstance(seq[2]);
			}
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x0012F8C6 File Offset: 0x0012DAC6
		public CertStatus(byte[] certHash, global::Org.BouncyCastle.Math.BigInteger certReqId)
		{
			this.certHash = new global::Org.BouncyCastle.Asn1.DerOctetString(certHash);
			this.certReqId = new global::Org.BouncyCastle.Asn1.DerInteger(certReqId);
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x0012F8E6 File Offset: 0x0012DAE6
		public CertStatus(byte[] certHash, global::Org.BouncyCastle.Math.BigInteger certReqId, global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo statusInfo)
		{
			this.certHash = new global::Org.BouncyCastle.Asn1.DerOctetString(certHash);
			this.certReqId = new global::Org.BouncyCastle.Asn1.DerInteger(certReqId);
			this.statusInfo = statusInfo;
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x0012F90D File Offset: 0x0012DB0D
		public static global::Org.BouncyCastle.Asn1.Cmp.CertStatus GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.CertStatus)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.CertStatus)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CertStatus((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x0012F94C File Offset: 0x0012DB4C
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString CertHash
		{
			get
			{
				return this.certHash;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x0012F954 File Offset: 0x0012DB54
		public virtual global::Org.BouncyCastle.Asn1.DerInteger CertReqID
		{
			get
			{
				return this.certReqId;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x0012F95C File Offset: 0x0012DB5C
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo StatusInfo
		{
			get
			{
				return this.statusInfo;
			}
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x0012F964 File Offset: 0x0012DB64
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certHash,
				this.certReqId
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.statusInfo
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x040020A7 RID: 8359
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString certHash;

		// Token: 0x040020A8 RID: 8360
		private readonly global::Org.BouncyCastle.Asn1.DerInteger certReqId;

		// Token: 0x040020A9 RID: 8361
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo statusInfo;
	}
}
