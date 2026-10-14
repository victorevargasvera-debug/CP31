using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006C1 RID: 1729
	public class SignedData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F3B RID: 16187 RVA: 0x0011FBB4 File Offset: 0x0011DDB4
		public static global::Org.BouncyCastle.Asn1.Pkcs.SignedData GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Pkcs.SignedData existing = obj as global::Org.BouncyCastle.Asn1.Pkcs.SignedData;
			if (existing != null)
			{
				return existing;
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.SignedData(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x0011FBDD File Offset: 0x0011DDDD
		public SignedData(global::Org.BouncyCastle.Asn1.DerInteger _version, global::Org.BouncyCastle.Asn1.Asn1Set _digestAlgorithms, global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo _contentInfo, global::Org.BouncyCastle.Asn1.Asn1Set _certificates, global::Org.BouncyCastle.Asn1.Asn1Set _crls, global::Org.BouncyCastle.Asn1.Asn1Set _signerInfos)
		{
			this.version = _version;
			this.digestAlgorithms = _digestAlgorithms;
			this.contentInfo = _contentInfo;
			this.certificates = _certificates;
			this.crls = _crls;
			this.signerInfos = _signerInfos;
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x0011FC14 File Offset: 0x0011DE14
		private SignedData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)e.Current;
			e.MoveNext();
			this.digestAlgorithms = (global::Org.BouncyCastle.Asn1.Asn1Set)e.Current;
			e.MoveNext();
			this.contentInfo = global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo.GetInstance(e.Current);
			while (e.MoveNext())
			{
				object obj = e.Current;
				global::Org.BouncyCastle.Asn1.Asn1Object o = (global::Org.BouncyCastle.Asn1.Asn1Object)obj;
				if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
				{
					global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o;
					int tagNo = tagged.TagNo;
					if (tagNo != 0)
					{
						if (tagNo != 1)
						{
							throw new global::System.ArgumentException("unknown tag value " + tagged.TagNo.ToString());
						}
						this.crls = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(tagged, false);
					}
					else
					{
						this.certificates = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(tagged, false);
					}
				}
				else
				{
					this.signerInfos = (global::Org.BouncyCastle.Asn1.Asn1Set)o;
				}
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06003F3E RID: 16190 RVA: 0x0011FCF4 File Offset: 0x0011DEF4
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06003F3F RID: 16191 RVA: 0x0011FCFC File Offset: 0x0011DEFC
		public global::Org.BouncyCastle.Asn1.Asn1Set DigestAlgorithms
		{
			get
			{
				return this.digestAlgorithms;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06003F40 RID: 16192 RVA: 0x0011FD04 File Offset: 0x0011DF04
		public global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo ContentInfo
		{
			get
			{
				return this.contentInfo;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06003F41 RID: 16193 RVA: 0x0011FD0C File Offset: 0x0011DF0C
		public global::Org.BouncyCastle.Asn1.Asn1Set Certificates
		{
			get
			{
				return this.certificates;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x0011FD14 File Offset: 0x0011DF14
		public global::Org.BouncyCastle.Asn1.Asn1Set Crls
		{
			get
			{
				return this.crls;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06003F43 RID: 16195 RVA: 0x0011FD1C File Offset: 0x0011DF1C
		public global::Org.BouncyCastle.Asn1.Asn1Set SignerInfos
		{
			get
			{
				return this.signerInfos;
			}
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x0011FD24 File Offset: 0x0011DF24
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.digestAlgorithms,
				this.contentInfo
			});
			asn1EncodableVector.AddOptionalTagged(false, 0, this.certificates);
			asn1EncodableVector.AddOptionalTagged(false, 1, this.crls);
			asn1EncodableVector.Add(this.signerInfos);
			return new global::Org.BouncyCastle.Asn1.BerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D3A RID: 7482
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001D3B RID: 7483
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set digestAlgorithms;

		// Token: 0x04001D3C RID: 7484
		private readonly global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo contentInfo;

		// Token: 0x04001D3D RID: 7485
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set certificates;

		// Token: 0x04001D3E RID: 7486
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set crls;

		// Token: 0x04001D3F RID: 7487
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set signerInfos;
	}
}
