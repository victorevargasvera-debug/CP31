using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified
{
	// Token: 0x0200068B RID: 1675
	public class QCStatement : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003DC1 RID: 15809 RVA: 0x00119C38 File Offset: 0x00117E38
		public static global::Org.BouncyCastle.Asn1.X509.Qualified.QCStatement GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.Qualified.QCStatement)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Qualified.QCStatement)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Qualified.QCStatement(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			throw new global::System.ArgumentException("unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x00119C85 File Offset: 0x00117E85
		private QCStatement(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.qcStatementId = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			if (seq.Count > 1)
			{
				this.qcStatementInfo = seq[1];
			}
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x00119CB5 File Offset: 0x00117EB5
		public QCStatement(global::Org.BouncyCastle.Asn1.DerObjectIdentifier qcStatementId)
		{
			this.qcStatementId = qcStatementId;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00119CC4 File Offset: 0x00117EC4
		public QCStatement(global::Org.BouncyCastle.Asn1.DerObjectIdentifier qcStatementId, global::Org.BouncyCastle.Asn1.Asn1Encodable qcStatementInfo)
		{
			this.qcStatementId = qcStatementId;
			this.qcStatementInfo = qcStatementInfo;
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06003DC5 RID: 15813 RVA: 0x00119CDA File Offset: 0x00117EDA
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier StatementId
		{
			get
			{
				return this.qcStatementId;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06003DC6 RID: 15814 RVA: 0x00119CE2 File Offset: 0x00117EE2
		public global::Org.BouncyCastle.Asn1.Asn1Encodable StatementInfo
		{
			get
			{
				return this.qcStatementInfo;
			}
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00119CEC File Offset: 0x00117EEC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.qcStatementId
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.qcStatementInfo
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001B9D RID: 7069
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier qcStatementId;

		// Token: 0x04001B9E RID: 7070
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable qcStatementInfo;
	}
}
