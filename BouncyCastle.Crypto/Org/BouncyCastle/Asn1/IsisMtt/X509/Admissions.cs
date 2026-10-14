using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509
{
	// Token: 0x020006E7 RID: 1767
	public class Admissions : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600401E RID: 16414 RVA: 0x00122F10 File Offset: 0x00121110
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.Admissions GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.IsisMtt.X509.Admissions)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.Admissions)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.X509.Admissions((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x00122F60 File Offset: 0x00121160
		private Admissions(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			global::Org.BouncyCastle.Asn1.Asn1Encodable o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
			if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				int tagNo = ((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o).TagNo;
				if (tagNo != 0)
				{
					if (tagNo != 1)
					{
						throw new global::System.ArgumentException("Bad tag number: " + ((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o).TagNo.ToString());
					}
					this.namingAuthority = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o, true);
				}
				else
				{
					this.admissionAuthority = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o, true);
				}
				e.MoveNext();
				o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				if (((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o).TagNo != 1)
				{
					throw new global::System.ArgumentException("Bad tag number: " + ((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o).TagNo.ToString());
				}
				this.namingAuthority = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o, true);
				e.MoveNext();
				o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
			}
			this.professionInfos = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o);
			if (e.MoveNext())
			{
				throw new global::System.ArgumentException("Bad object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(e.Current));
			}
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x001230C0 File Offset: 0x001212C0
		public Admissions(global::Org.BouncyCastle.Asn1.X509.GeneralName admissionAuthority, global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority namingAuthority, global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo[] professionInfos)
		{
			this.admissionAuthority = admissionAuthority;
			this.namingAuthority = namingAuthority;
			this.professionInfos = new global::Org.BouncyCastle.Asn1.DerSequence(professionInfos);
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06004021 RID: 16417 RVA: 0x001230EF File Offset: 0x001212EF
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName AdmissionAuthority
		{
			get
			{
				return this.admissionAuthority;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x001230F7 File Offset: 0x001212F7
		public virtual global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority NamingAuthority
		{
			get
			{
				return this.namingAuthority;
			}
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x00123100 File Offset: 0x00121300
		public global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo[] GetProfessionInfos()
		{
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo[] infos = new global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo[this.professionInfos.Count];
			int count = 0;
			foreach (object obj in this.professionInfos)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
				infos[count++] = global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.GetInstance(ae);
			}
			return infos;
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x00123178 File Offset: 0x00121378
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 0, this.admissionAuthority);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.namingAuthority);
			asn1EncodableVector.Add(this.professionInfos);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001E5A RID: 7770
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName admissionAuthority;

		// Token: 0x04001E5B RID: 7771
		private readonly global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority namingAuthority;

		// Token: 0x04001E5C RID: 7772
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence professionInfos;
	}
}
