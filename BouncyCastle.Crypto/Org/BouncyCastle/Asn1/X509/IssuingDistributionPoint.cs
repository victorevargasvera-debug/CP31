using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200065B RID: 1627
	public class IssuingDistributionPoint : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C32 RID: 15410 RVA: 0x00113EEA File Offset: 0x001120EA
		public static global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x00113EF8 File Offset: 0x001120F8
		public static global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint)
			{
				return (global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.IssuingDistributionPoint((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x00113F48 File Offset: 0x00112148
		public IssuingDistributionPoint(global::Org.BouncyCastle.Asn1.X509.DistributionPointName distributionPoint, bool onlyContainsUserCerts, bool onlyContainsCACerts, global::Org.BouncyCastle.Asn1.X509.ReasonFlags onlySomeReasons, bool indirectCRL, bool onlyContainsAttributeCerts)
		{
			this._distributionPoint = distributionPoint;
			this._indirectCRL = indirectCRL;
			this._onlyContainsAttributeCerts = onlyContainsAttributeCerts;
			this._onlyContainsCACerts = onlyContainsCACerts;
			this._onlyContainsUserCerts = onlyContainsUserCerts;
			this._onlySomeReasons = onlySomeReasons;
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector vec = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (distributionPoint != null)
			{
				vec.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, distributionPoint));
			}
			if (onlyContainsUserCerts)
			{
				vec.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 1, global::Org.BouncyCastle.Asn1.DerBoolean.True));
			}
			if (onlyContainsCACerts)
			{
				vec.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 2, global::Org.BouncyCastle.Asn1.DerBoolean.True));
			}
			if (onlySomeReasons != null)
			{
				vec.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 3, onlySomeReasons));
			}
			if (indirectCRL)
			{
				vec.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 4, global::Org.BouncyCastle.Asn1.DerBoolean.True));
			}
			if (onlyContainsAttributeCerts)
			{
				vec.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 5, global::Org.BouncyCastle.Asn1.DerBoolean.True));
			}
			this.seq = new global::Org.BouncyCastle.Asn1.DerSequence(vec);
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00114014 File Offset: 0x00112214
		private IssuingDistributionPoint(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.seq = seq;
			for (int i = 0; i != seq.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[i]);
				switch (o.TagNo)
				{
				case 0:
					this._distributionPoint = global::Org.BouncyCastle.Asn1.X509.DistributionPointName.GetInstance(o, true);
					break;
				case 1:
					this._onlyContainsUserCerts = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(o, false).IsTrue;
					break;
				case 2:
					this._onlyContainsCACerts = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(o, false).IsTrue;
					break;
				case 3:
					this._onlySomeReasons = new global::Org.BouncyCastle.Asn1.X509.ReasonFlags(global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(o, false));
					break;
				case 4:
					this._indirectCRL = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(o, false).IsTrue;
					break;
				case 5:
					this._onlyContainsAttributeCerts = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(o, false).IsTrue;
					break;
				default:
					throw new global::System.ArgumentException("unknown tag in IssuingDistributionPoint");
				}
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06003C36 RID: 15414 RVA: 0x001140F7 File Offset: 0x001122F7
		public bool OnlyContainsUserCerts
		{
			get
			{
				return this._onlyContainsUserCerts;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06003C37 RID: 15415 RVA: 0x001140FF File Offset: 0x001122FF
		public bool OnlyContainsCACerts
		{
			get
			{
				return this._onlyContainsCACerts;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06003C38 RID: 15416 RVA: 0x00114107 File Offset: 0x00112307
		public bool IsIndirectCrl
		{
			get
			{
				return this._indirectCRL;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x0011410F File Offset: 0x0011230F
		public bool OnlyContainsAttributeCerts
		{
			get
			{
				return this._onlyContainsAttributeCerts;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06003C3A RID: 15418 RVA: 0x00114117 File Offset: 0x00112317
		public global::Org.BouncyCastle.Asn1.X509.DistributionPointName DistributionPoint
		{
			get
			{
				return this._distributionPoint;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x0011411F File Offset: 0x0011231F
		public global::Org.BouncyCastle.Asn1.X509.ReasonFlags OnlySomeReasons
		{
			get
			{
				return this._onlySomeReasons;
			}
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x00114127 File Offset: 0x00112327
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.seq;
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x00114130 File Offset: 0x00112330
		public override string ToString()
		{
			string sep = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			buf.Append("IssuingDistributionPoint: [");
			buf.Append(sep);
			if (this._distributionPoint != null)
			{
				this.appendObject(buf, sep, "distributionPoint", this._distributionPoint.ToString());
			}
			if (this._onlyContainsUserCerts)
			{
				this.appendObject(buf, sep, "onlyContainsUserCerts", this._onlyContainsUserCerts.ToString());
			}
			if (this._onlyContainsCACerts)
			{
				this.appendObject(buf, sep, "onlyContainsCACerts", this._onlyContainsCACerts.ToString());
			}
			if (this._onlySomeReasons != null)
			{
				this.appendObject(buf, sep, "onlySomeReasons", this._onlySomeReasons.ToString());
			}
			if (this._onlyContainsAttributeCerts)
			{
				this.appendObject(buf, sep, "onlyContainsAttributeCerts", this._onlyContainsAttributeCerts.ToString());
			}
			if (this._indirectCRL)
			{
				this.appendObject(buf, sep, "indirectCRL", this._indirectCRL.ToString());
			}
			buf.Append("]");
			buf.Append(sep);
			return buf.ToString();
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x00114244 File Offset: 0x00112444
		private void appendObject(global::System.Text.StringBuilder buf, string sep, string name, string val)
		{
			string indent = "    ";
			buf.Append(indent);
			buf.Append(name);
			buf.Append(":");
			buf.Append(sep);
			buf.Append(indent);
			buf.Append(indent);
			buf.Append(val);
			buf.Append(sep);
		}

		// Token: 0x04001A80 RID: 6784
		private readonly global::Org.BouncyCastle.Asn1.X509.DistributionPointName _distributionPoint;

		// Token: 0x04001A81 RID: 6785
		private readonly bool _onlyContainsUserCerts;

		// Token: 0x04001A82 RID: 6786
		private readonly bool _onlyContainsCACerts;

		// Token: 0x04001A83 RID: 6787
		private readonly global::Org.BouncyCastle.Asn1.X509.ReasonFlags _onlySomeReasons;

		// Token: 0x04001A84 RID: 6788
		private readonly bool _indirectCRL;

		// Token: 0x04001A85 RID: 6789
		private readonly bool _onlyContainsAttributeCerts;

		// Token: 0x04001A86 RID: 6790
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence seq;
	}
}
