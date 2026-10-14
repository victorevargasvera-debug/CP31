using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200000B RID: 11
	public class AttributeCertificateIssuer : global::Org.BouncyCastle.X509.Store.IX509Selector, global::System.ICloneable
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00005956 File Offset: 0x00003B56
		public AttributeCertificateIssuer(global::Org.BouncyCastle.Asn1.X509.AttCertIssuer issuer)
		{
			this.form = issuer.Issuer;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000596A File Offset: 0x00003B6A
		public AttributeCertificateIssuer(global::Org.BouncyCastle.Asn1.X509.X509Name principal)
		{
			this.form = new global::Org.BouncyCastle.Asn1.X509.V2Form(new global::Org.BouncyCastle.Asn1.X509.GeneralNames(new global::Org.BouncyCastle.Asn1.X509.GeneralName(principal)));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005988 File Offset: 0x00003B88
		private object[] GetNames()
		{
			global::Org.BouncyCastle.Asn1.X509.GeneralNames name;
			if (this.form is global::Org.BouncyCastle.Asn1.X509.V2Form)
			{
				name = ((global::Org.BouncyCastle.Asn1.X509.V2Form)this.form).IssuerName;
			}
			else
			{
				name = (global::Org.BouncyCastle.Asn1.X509.GeneralNames)this.form;
			}
			global::Org.BouncyCastle.Asn1.X509.GeneralName[] names = name.GetNames();
			int count = 0;
			for (int i = 0; i != names.Length; i++)
			{
				if (names[i].TagNo == 4)
				{
					count++;
				}
			}
			object[] result = new object[count];
			int pos = 0;
			for (int j = 0; j != names.Length; j++)
			{
				if (names[j].TagNo == 4)
				{
					result[pos++] = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(names[j].Name);
				}
			}
			return result;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005A2C File Offset: 0x00003C2C
		public global::Org.BouncyCastle.Asn1.X509.X509Name[] GetPrincipals()
		{
			object[] p = this.GetNames();
			int count = 0;
			for (int i = 0; i != p.Length; i++)
			{
				if (p[i] is global::Org.BouncyCastle.Asn1.X509.X509Name)
				{
					count++;
				}
			}
			global::Org.BouncyCastle.Asn1.X509.X509Name[] result = new global::Org.BouncyCastle.Asn1.X509.X509Name[count];
			int pos = 0;
			for (int j = 0; j != p.Length; j++)
			{
				if (p[j] is global::Org.BouncyCastle.Asn1.X509.X509Name)
				{
					result[pos++] = (global::Org.BouncyCastle.Asn1.X509.X509Name)p[j];
				}
			}
			return result;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005A9C File Offset: 0x00003C9C
		private bool MatchesDN(global::Org.BouncyCastle.Asn1.X509.X509Name subject, global::Org.BouncyCastle.Asn1.X509.GeneralNames targets)
		{
			global::Org.BouncyCastle.Asn1.X509.GeneralName[] names = targets.GetNames();
			for (int i = 0; i != names.Length; i++)
			{
				global::Org.BouncyCastle.Asn1.X509.GeneralName gn = names[i];
				if (gn.TagNo == 4)
				{
					try
					{
						if (global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(gn.Name).Equivalent(subject))
						{
							return true;
						}
					}
					catch (global::System.Exception)
					{
					}
				}
			}
			return false;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005AFC File Offset: 0x00003CFC
		public object Clone()
		{
			return new global::Org.BouncyCastle.X509.AttributeCertificateIssuer(global::Org.BouncyCastle.Asn1.X509.AttCertIssuer.GetInstance(this.form));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00005B10 File Offset: 0x00003D10
		public bool Match(global::Org.BouncyCastle.X509.X509Certificate x509Cert)
		{
			if (!(this.form is global::Org.BouncyCastle.Asn1.X509.V2Form))
			{
				return this.MatchesDN(x509Cert.SubjectDN, (global::Org.BouncyCastle.Asn1.X509.GeneralNames)this.form);
			}
			global::Org.BouncyCastle.Asn1.X509.V2Form issuer = (global::Org.BouncyCastle.Asn1.X509.V2Form)this.form;
			if (issuer.BaseCertificateID != null)
			{
				return issuer.BaseCertificateID.Serial.HasValue(x509Cert.SerialNumber) && this.MatchesDN(x509Cert.IssuerDN, issuer.BaseCertificateID.Issuer);
			}
			return this.MatchesDN(x509Cert.SubjectDN, issuer.IssuerName);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005B9C File Offset: 0x00003D9C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			if (!(obj is global::Org.BouncyCastle.X509.AttributeCertificateIssuer))
			{
				return false;
			}
			global::Org.BouncyCastle.X509.AttributeCertificateIssuer other = (global::Org.BouncyCastle.X509.AttributeCertificateIssuer)obj;
			return this.form.Equals(other.form);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005BD1 File Offset: 0x00003DD1
		public override int GetHashCode()
		{
			return this.form.GetHashCode();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005BDE File Offset: 0x00003DDE
		public bool Match(object obj)
		{
			return obj is global::Org.BouncyCastle.X509.X509Certificate && this.Match((global::Org.BouncyCastle.X509.X509Certificate)obj);
		}

		// Token: 0x04000073 RID: 115
		internal readonly global::Org.BouncyCastle.Asn1.Asn1Encodable form;
	}
}
