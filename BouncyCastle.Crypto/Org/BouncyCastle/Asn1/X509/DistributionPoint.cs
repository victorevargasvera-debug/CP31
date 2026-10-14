using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000651 RID: 1617
	public class DistributionPoint : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003BCD RID: 15309 RVA: 0x00112817 File Offset: 0x00110A17
		public static global::Org.BouncyCastle.Asn1.X509.DistributionPoint GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.DistributionPoint.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x00112825 File Offset: 0x00110A25
		public static global::Org.BouncyCastle.Asn1.X509.DistributionPoint GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.DistributionPoint)
			{
				return (global::Org.BouncyCastle.Asn1.X509.DistributionPoint)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.DistributionPoint((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid DistributionPoint: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x00112864 File Offset: 0x00110A64
		private DistributionPoint(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			for (int i = 0; i != seq.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject t = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[i]);
				switch (t.TagNo)
				{
				case 0:
					this.distributionPoint = global::Org.BouncyCastle.Asn1.X509.DistributionPointName.GetInstance(t, true);
					break;
				case 1:
					this.reasons = new global::Org.BouncyCastle.Asn1.X509.ReasonFlags(global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(t, false));
					break;
				case 2:
					this.cRLIssuer = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(t, false);
					break;
				}
			}
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x001128E0 File Offset: 0x00110AE0
		public DistributionPoint(global::Org.BouncyCastle.Asn1.X509.DistributionPointName distributionPointName, global::Org.BouncyCastle.Asn1.X509.ReasonFlags reasons, global::Org.BouncyCastle.Asn1.X509.GeneralNames crlIssuer)
		{
			this.distributionPoint = distributionPointName;
			this.reasons = reasons;
			this.cRLIssuer = crlIssuer;
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x001128FD File Offset: 0x00110AFD
		public global::Org.BouncyCastle.Asn1.X509.DistributionPointName DistributionPointName
		{
			get
			{
				return this.distributionPoint;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x00112905 File Offset: 0x00110B05
		public global::Org.BouncyCastle.Asn1.X509.ReasonFlags Reasons
		{
			get
			{
				return this.reasons;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x0011290D File Offset: 0x00110B0D
		public global::Org.BouncyCastle.Asn1.X509.GeneralNames CrlIssuer
		{
			get
			{
				return this.cRLIssuer;
			}
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00112915 File Offset: 0x00110B15
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 0, this.distributionPoint);
			asn1EncodableVector.AddOptionalTagged(false, 1, this.reasons);
			asn1EncodableVector.AddOptionalTagged(false, 2, this.cRLIssuer);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x0011294C File Offset: 0x00110B4C
		public override string ToString()
		{
			string sep = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			buf.Append("DistributionPoint: [");
			buf.Append(sep);
			if (this.distributionPoint != null)
			{
				this.appendObject(buf, sep, "distributionPoint", this.distributionPoint.ToString());
			}
			if (this.reasons != null)
			{
				this.appendObject(buf, sep, "reasons", this.reasons.ToString());
			}
			if (this.cRLIssuer != null)
			{
				this.appendObject(buf, sep, "cRLIssuer", this.cRLIssuer.ToString());
			}
			buf.Append("]");
			buf.Append(sep);
			return buf.ToString();
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x001129F4 File Offset: 0x00110BF4
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

		// Token: 0x04001A58 RID: 6744
		internal readonly global::Org.BouncyCastle.Asn1.X509.DistributionPointName distributionPoint;

		// Token: 0x04001A59 RID: 6745
		internal readonly global::Org.BouncyCastle.Asn1.X509.ReasonFlags reasons;

		// Token: 0x04001A5A RID: 6746
		internal readonly global::Org.BouncyCastle.Asn1.X509.GeneralNames cRLIssuer;
	}
}
