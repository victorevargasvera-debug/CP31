using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000787 RID: 1927
	public class PkiStatusInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004490 RID: 17552 RVA: 0x001311BA File Offset: 0x0012F3BA
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x001311C8 File Offset: 0x0012F3C8
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x00131208 File Offset: 0x0012F408
		public PkiStatusInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.status = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.statusString = null;
			this.failInfo = null;
			if (seq.Count > 2)
			{
				this.statusString = global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText.GetInstance(seq[1]);
				this.failInfo = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[2]);
				return;
			}
			if (seq.Count > 1)
			{
				object obj = seq[1];
				if (obj is global::Org.BouncyCastle.Asn1.DerBitString)
				{
					this.failInfo = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj);
					return;
				}
				this.statusString = global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText.GetInstance(obj);
			}
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x0013129B File Offset: 0x0012F49B
		public PkiStatusInfo(int status)
		{
			this.status = new global::Org.BouncyCastle.Asn1.DerInteger(status);
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x001312AF File Offset: 0x0012F4AF
		public PkiStatusInfo(int status, global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText statusString)
		{
			this.status = new global::Org.BouncyCastle.Asn1.DerInteger(status);
			this.statusString = statusString;
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x001312CA File Offset: 0x0012F4CA
		public PkiStatusInfo(int status, global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText statusString, global::Org.BouncyCastle.Asn1.Cmp.PkiFailureInfo failInfo)
		{
			this.status = new global::Org.BouncyCastle.Asn1.DerInteger(status);
			this.statusString = statusString;
			this.failInfo = failInfo;
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x001312EC File Offset: 0x0012F4EC
		public global::Org.BouncyCastle.Math.BigInteger Status
		{
			get
			{
				return this.status.Value;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x001312F9 File Offset: 0x0012F4F9
		public global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText StatusString
		{
			get
			{
				return this.statusString;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06004498 RID: 17560 RVA: 0x00131301 File Offset: 0x0012F501
		public global::Org.BouncyCastle.Asn1.DerBitString FailInfo
		{
			get
			{
				return this.failInfo;
			}
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x0013130C File Offset: 0x0012F50C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.status
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.statusString,
				this.failInfo
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002145 RID: 8517
		private global::Org.BouncyCastle.Asn1.DerInteger status;

		// Token: 0x04002146 RID: 8518
		private global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText statusString;

		// Token: 0x04002147 RID: 8519
		private global::Org.BouncyCastle.Asn1.DerBitString failInfo;
	}
}
