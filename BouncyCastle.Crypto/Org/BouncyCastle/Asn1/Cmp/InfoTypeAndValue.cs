using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000779 RID: 1913
	public class InfoTypeAndValue : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004421 RID: 17441 RVA: 0x00130061 File Offset: 0x0012E261
		private InfoTypeAndValue(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.infoType = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			if (seq.Count > 1)
			{
				this.infoValue = seq[1];
			}
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00130091 File Offset: 0x0012E291
		public static global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.InfoTypeAndValue((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x001300D0 File Offset: 0x0012E2D0
		public InfoTypeAndValue(global::Org.BouncyCastle.Asn1.DerObjectIdentifier infoType)
		{
			this.infoType = infoType;
			this.infoValue = null;
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x001300E6 File Offset: 0x0012E2E6
		public InfoTypeAndValue(global::Org.BouncyCastle.Asn1.DerObjectIdentifier infoType, global::Org.BouncyCastle.Asn1.Asn1Encodable optionalValue)
		{
			this.infoType = infoType;
			this.infoValue = optionalValue;
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06004425 RID: 17445 RVA: 0x001300FC File Offset: 0x0012E2FC
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier InfoType
		{
			get
			{
				return this.infoType;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06004426 RID: 17446 RVA: 0x00130104 File Offset: 0x0012E304
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable InfoValue
		{
			get
			{
				return this.infoValue;
			}
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x0013010C File Offset: 0x0012E30C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.infoType
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.infoValue
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x040020CF RID: 8399
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier infoType;

		// Token: 0x040020D0 RID: 8400
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable infoValue;
	}
}
