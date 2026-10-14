using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200000A RID: 10
	public class AttributeCertificateHolder : global::Org.BouncyCastle.X509.Store.IX509Selector, global::System.ICloneable
	{
		// Token: 0x0600006E RID: 110 RVA: 0x0000546B File Offset: 0x0000366B
		internal AttributeCertificateHolder(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.holder = global::Org.BouncyCastle.Asn1.X509.Holder.GetInstance(seq);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000547F File Offset: 0x0000367F
		public AttributeCertificateHolder(global::Org.BouncyCastle.Asn1.X509.X509Name issuerName, global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			this.holder = new global::Org.BouncyCastle.Asn1.X509.Holder(new global::Org.BouncyCastle.Asn1.X509.IssuerSerial(this.GenerateGeneralNames(issuerName), new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber)));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000054A4 File Offset: 0x000036A4
		public AttributeCertificateHolder(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Name name;
			try
			{
				name = global::Org.BouncyCastle.X509.PrincipalUtilities.GetIssuerX509Principal(cert);
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException(ex.Message);
			}
			this.holder = new global::Org.BouncyCastle.Asn1.X509.Holder(new global::Org.BouncyCastle.Asn1.X509.IssuerSerial(this.GenerateGeneralNames(name), new global::Org.BouncyCastle.Asn1.DerInteger(cert.SerialNumber)));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005500 File Offset: 0x00003700
		public AttributeCertificateHolder(global::Org.BouncyCastle.Asn1.X509.X509Name principal)
		{
			this.holder = new global::Org.BouncyCastle.Asn1.X509.Holder(this.GenerateGeneralNames(principal));
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000551A File Offset: 0x0000371A
		public AttributeCertificateHolder(int digestedObjectType, string digestAlgorithm, string otherObjectTypeID, byte[] objectDigest)
		{
			this.holder = new global::Org.BouncyCastle.Asn1.X509.Holder(new global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo(digestedObjectType, otherObjectTypeID, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(digestAlgorithm)), global::Org.BouncyCastle.Utilities.Arrays.Clone(objectDigest)));
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00005548 File Offset: 0x00003748
		public int DigestedObjectType
		{
			get
			{
				global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo odi = this.holder.ObjectDigestInfo;
				if (odi != null)
				{
					return odi.DigestedObjectType.IntValueExact;
				}
				return -1;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005574 File Offset: 0x00003774
		public string DigestAlgorithm
		{
			get
			{
				global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo odi = this.holder.ObjectDigestInfo;
				if (odi != null)
				{
					return odi.DigestAlgorithm.Algorithm.Id;
				}
				return null;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000055A4 File Offset: 0x000037A4
		public byte[] GetObjectDigest()
		{
			global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo odi = this.holder.ObjectDigestInfo;
			if (odi != null)
			{
				return odi.ObjectDigest.GetBytes();
			}
			return null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000055D0 File Offset: 0x000037D0
		public string OtherObjectTypeID
		{
			get
			{
				global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo odi = this.holder.ObjectDigestInfo;
				if (odi != null)
				{
					return odi.OtherObjectTypeID.Id;
				}
				return null;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000055F9 File Offset: 0x000037F9
		private global::Org.BouncyCastle.Asn1.X509.GeneralNames GenerateGeneralNames(global::Org.BouncyCastle.Asn1.X509.X509Name principal)
		{
			return new global::Org.BouncyCastle.Asn1.X509.GeneralNames(new global::Org.BouncyCastle.Asn1.X509.GeneralName(principal));
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005608 File Offset: 0x00003808
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

		// Token: 0x06000079 RID: 121 RVA: 0x00005668 File Offset: 0x00003868
		private object[] GetNames(global::Org.BouncyCastle.Asn1.X509.GeneralName[] names)
		{
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

		// Token: 0x0600007A RID: 122 RVA: 0x000056D4 File Offset: 0x000038D4
		private global::Org.BouncyCastle.Asn1.X509.X509Name[] GetPrincipals(global::Org.BouncyCastle.Asn1.X509.GeneralNames names)
		{
			object[] p = this.GetNames(names.GetNames());
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

		// Token: 0x0600007B RID: 123 RVA: 0x00005748 File Offset: 0x00003948
		public global::Org.BouncyCastle.Asn1.X509.X509Name[] GetEntityNames()
		{
			if (this.holder.EntityName != null)
			{
				return this.GetPrincipals(this.holder.EntityName);
			}
			return null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000576A File Offset: 0x0000396A
		public global::Org.BouncyCastle.Asn1.X509.X509Name[] GetIssuer()
		{
			if (this.holder.BaseCertificateID != null)
			{
				return this.GetPrincipals(this.holder.BaseCertificateID.Issuer);
			}
			return null;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00005791 File Offset: 0x00003991
		public global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				if (this.holder.BaseCertificateID != null)
				{
					return this.holder.BaseCertificateID.Serial.Value;
				}
				return null;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000057B7 File Offset: 0x000039B7
		public object Clone()
		{
			return new global::Org.BouncyCastle.X509.AttributeCertificateHolder((global::Org.BouncyCastle.Asn1.Asn1Sequence)this.holder.ToAsn1Object());
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000057D0 File Offset: 0x000039D0
		public bool Match(global::Org.BouncyCastle.X509.X509Certificate x509Cert)
		{
			try
			{
				if (this.holder.BaseCertificateID != null)
				{
					return this.holder.BaseCertificateID.Serial.HasValue(x509Cert.SerialNumber) && this.MatchesDN(global::Org.BouncyCastle.X509.PrincipalUtilities.GetIssuerX509Principal(x509Cert), this.holder.BaseCertificateID.Issuer);
				}
				if (this.holder.EntityName != null && this.MatchesDN(global::Org.BouncyCastle.X509.PrincipalUtilities.GetSubjectX509Principal(x509Cert), this.holder.EntityName))
				{
					return true;
				}
				if (this.holder.ObjectDigestInfo != null)
				{
					global::Org.BouncyCastle.Crypto.IDigest md = null;
					try
					{
						md = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(this.DigestAlgorithm);
					}
					catch (global::System.Exception)
					{
						return false;
					}
					int digestedObjectType = this.DigestedObjectType;
					if (digestedObjectType != 0)
					{
						if (digestedObjectType == 1)
						{
							byte[] b = x509Cert.GetEncoded();
							md.BlockUpdate(b, 0, b.Length);
						}
					}
					else
					{
						byte[] b2 = global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(x509Cert.GetPublicKey()).GetEncoded();
						md.BlockUpdate(b2, 0, b2.Length);
					}
					if (!global::Org.BouncyCastle.Utilities.Arrays.AreEqual(global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(md), this.GetObjectDigest()))
					{
						return false;
					}
				}
			}
			catch (global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException)
			{
				return false;
			}
			return false;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000058FC File Offset: 0x00003AFC
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			if (!(obj is global::Org.BouncyCastle.X509.AttributeCertificateHolder))
			{
				return false;
			}
			global::Org.BouncyCastle.X509.AttributeCertificateHolder other = (global::Org.BouncyCastle.X509.AttributeCertificateHolder)obj;
			return this.holder.Equals(other.holder);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005931 File Offset: 0x00003B31
		public override int GetHashCode()
		{
			return this.holder.GetHashCode();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000593E File Offset: 0x00003B3E
		public bool Match(object obj)
		{
			return obj is global::Org.BouncyCastle.X509.X509Certificate && this.Match((global::Org.BouncyCastle.X509.X509Certificate)obj);
		}

		// Token: 0x04000072 RID: 114
		internal readonly global::Org.BouncyCastle.Asn1.X509.Holder holder;
	}
}
