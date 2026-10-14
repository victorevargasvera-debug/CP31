using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000657 RID: 1623
	public class GeneralSubtree : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C0F RID: 15375 RVA: 0x001136B8 File Offset: 0x001118B8
		private GeneralSubtree(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.baseName = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[0]);
			switch (seq.Count)
			{
			case 1:
				return;
			case 2:
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[1]);
				int tagNo = o.TagNo;
				if (tagNo == 0)
				{
					this.minimum = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o, false);
					return;
				}
				if (tagNo != 1)
				{
					throw new global::System.ArgumentException("Bad tag number: " + o.TagNo.ToString());
				}
				this.maximum = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o, false);
				return;
			}
			case 3:
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject oMin = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[1]);
				if (oMin.TagNo != 0)
				{
					throw new global::System.ArgumentException("Bad tag number for 'minimum': " + oMin.TagNo.ToString());
				}
				this.minimum = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(oMin, false);
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject oMax = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[2]);
				if (oMax.TagNo != 1)
				{
					throw new global::System.ArgumentException("Bad tag number for 'maximum': " + oMax.TagNo.ToString());
				}
				this.maximum = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(oMax, false);
				return;
			}
			default:
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x001137FC File Offset: 0x001119FC
		public GeneralSubtree(global::Org.BouncyCastle.Asn1.X509.GeneralName baseName, global::Org.BouncyCastle.Math.BigInteger minimum, global::Org.BouncyCastle.Math.BigInteger maximum)
		{
			this.baseName = baseName;
			if (minimum != null)
			{
				this.minimum = new global::Org.BouncyCastle.Asn1.DerInteger(minimum);
			}
			if (maximum != null)
			{
				this.maximum = new global::Org.BouncyCastle.Asn1.DerInteger(maximum);
			}
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x00113829 File Offset: 0x00111A29
		public GeneralSubtree(global::Org.BouncyCastle.Asn1.X509.GeneralName baseName) : this(baseName, null, null)
		{
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x00113834 File Offset: 0x00111A34
		public static global::Org.BouncyCastle.Asn1.X509.GeneralSubtree GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject o, bool isExplicit)
		{
			return new global::Org.BouncyCastle.Asn1.X509.GeneralSubtree(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o, isExplicit));
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x00113842 File Offset: 0x00111A42
		public static global::Org.BouncyCastle.Asn1.X509.GeneralSubtree GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.GeneralSubtree)
			{
				return (global::Org.BouncyCastle.Asn1.X509.GeneralSubtree)obj;
			}
			return new global::Org.BouncyCastle.Asn1.X509.GeneralSubtree(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x00113863 File Offset: 0x00111A63
		public global::Org.BouncyCastle.Asn1.X509.GeneralName Base
		{
			get
			{
				return this.baseName;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06003C15 RID: 15381 RVA: 0x0011386B File Offset: 0x00111A6B
		public global::Org.BouncyCastle.Math.BigInteger Minimum
		{
			get
			{
				if (this.minimum != null)
				{
					return this.minimum.Value;
				}
				return global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x00113886 File Offset: 0x00111A86
		public global::Org.BouncyCastle.Math.BigInteger Maximum
		{
			get
			{
				if (this.maximum != null)
				{
					return this.maximum.Value;
				}
				return null;
			}
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x001138A0 File Offset: 0x00111AA0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.baseName
			});
			if (this.minimum != null && !this.minimum.HasValue(0))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, this.minimum));
			}
			v.AddOptionalTagged(false, 1, this.maximum);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001A70 RID: 6768
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName baseName;

		// Token: 0x04001A71 RID: 6769
		private readonly global::Org.BouncyCastle.Asn1.DerInteger minimum;

		// Token: 0x04001A72 RID: 6770
		private readonly global::Org.BouncyCastle.Asn1.DerInteger maximum;
	}
}
