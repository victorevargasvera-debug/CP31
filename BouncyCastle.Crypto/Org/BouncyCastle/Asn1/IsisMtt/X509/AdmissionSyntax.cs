using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509
{
	// Token: 0x020006E8 RID: 1768
	public class AdmissionSyntax : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004025 RID: 16421 RVA: 0x001231AC File Offset: 0x001213AC
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.AdmissionSyntax GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.IsisMtt.X509.AdmissionSyntax)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.AdmissionSyntax)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.X509.AdmissionSyntax((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x001231FC File Offset: 0x001213FC
		private AdmissionSyntax(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int count = seq.Count;
			if (count == 1)
			{
				this.contentsOfAdmissions = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[0]);
				return;
			}
			if (count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.admissionAuthority = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[0]);
			this.contentsOfAdmissions = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[1]);
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00123275 File Offset: 0x00121475
		public AdmissionSyntax(global::Org.BouncyCastle.Asn1.X509.GeneralName admissionAuthority, global::Org.BouncyCastle.Asn1.Asn1Sequence contentsOfAdmissions)
		{
			this.admissionAuthority = admissionAuthority;
			this.contentsOfAdmissions = contentsOfAdmissions;
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x0012328C File Offset: 0x0012148C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.admissionAuthority
			});
			v.Add(this.contentsOfAdmissions);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06004029 RID: 16425 RVA: 0x001232C6 File Offset: 0x001214C6
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName AdmissionAuthority
		{
			get
			{
				return this.admissionAuthority;
			}
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x001232D0 File Offset: 0x001214D0
		public virtual global::Org.BouncyCastle.Asn1.IsisMtt.X509.Admissions[] GetContentsOfAdmissions()
		{
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.Admissions[] result = new global::Org.BouncyCastle.Asn1.IsisMtt.X509.Admissions[this.contentsOfAdmissions.Count];
			for (int i = 0; i < this.contentsOfAdmissions.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.IsisMtt.X509.Admissions.GetInstance(this.contentsOfAdmissions[i]);
			}
			return result;
		}

		// Token: 0x04001E5D RID: 7773
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName admissionAuthority;

		// Token: 0x04001E5E RID: 7774
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence contentsOfAdmissions;
	}
}
