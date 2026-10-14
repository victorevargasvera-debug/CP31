using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x02000029 RID: 41
	public class X509CertStoreSelector : global::Org.BouncyCastle.X509.Store.IX509Selector, global::System.ICloneable
	{
		// Token: 0x060001CA RID: 458 RVA: 0x0000A582 File Offset: 0x00008782
		public X509CertStoreSelector()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000A594 File Offset: 0x00008794
		public X509CertStoreSelector(global::Org.BouncyCastle.X509.Store.X509CertStoreSelector o)
		{
			this.authorityKeyIdentifier = o.AuthorityKeyIdentifier;
			this.basicConstraints = o.BasicConstraints;
			this.certificate = o.Certificate;
			this.certificateValid = o.CertificateValid;
			this.extendedKeyUsage = o.ExtendedKeyUsage;
			this.ignoreX509NameOrdering = o.IgnoreX509NameOrdering;
			this.issuer = o.Issuer;
			this.keyUsage = o.KeyUsage;
			this.policy = o.Policy;
			this.privateKeyValid = o.PrivateKeyValid;
			this.serialNumber = o.SerialNumber;
			this.subject = o.Subject;
			this.subjectKeyIdentifier = o.SubjectKeyIdentifier;
			this.subjectPublicKey = o.SubjectPublicKey;
			this.subjectPublicKeyAlgID = o.SubjectPublicKeyAlgID;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000A662 File Offset: 0x00008862
		public virtual object Clone()
		{
			return new global::Org.BouncyCastle.X509.Store.X509CertStoreSelector(this);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000A66A File Offset: 0x0000886A
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0000A677 File Offset: 0x00008877
		public byte[] AuthorityKeyIdentifier
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.authorityKeyIdentifier);
			}
			set
			{
				this.authorityKeyIdentifier = global::Org.BouncyCastle.Utilities.Arrays.Clone(value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000A685 File Offset: 0x00008885
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000A68D File Offset: 0x0000888D
		public int BasicConstraints
		{
			get
			{
				return this.basicConstraints;
			}
			set
			{
				if (value < -2)
				{
					throw new global::System.ArgumentException("value can't be less than -2", "value");
				}
				this.basicConstraints = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000A6AB File Offset: 0x000088AB
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0000A6B3 File Offset: 0x000088B3
		public global::Org.BouncyCastle.X509.X509Certificate Certificate
		{
			get
			{
				return this.certificate;
			}
			set
			{
				this.certificate = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000A6BC File Offset: 0x000088BC
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000A6C4 File Offset: 0x000088C4
		public global::Org.BouncyCastle.Utilities.Date.DateTimeObject CertificateValid
		{
			get
			{
				return this.certificateValid;
			}
			set
			{
				this.certificateValid = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000A6CD File Offset: 0x000088CD
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000A6DA File Offset: 0x000088DA
		public global::Org.BouncyCastle.Utilities.Collections.ISet ExtendedKeyUsage
		{
			get
			{
				return global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.CopySet(this.extendedKeyUsage);
			}
			set
			{
				this.extendedKeyUsage = global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.CopySet(value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000A6E8 File Offset: 0x000088E8
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000A6F0 File Offset: 0x000088F0
		public bool IgnoreX509NameOrdering
		{
			get
			{
				return this.ignoreX509NameOrdering;
			}
			set
			{
				this.ignoreX509NameOrdering = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000A6F9 File Offset: 0x000088F9
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0000A701 File Offset: 0x00008901
		public global::Org.BouncyCastle.Asn1.X509.X509Name Issuer
		{
			get
			{
				return this.issuer;
			}
			set
			{
				this.issuer = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000A70A File Offset: 0x0000890A
		[global::System.Obsolete("Avoid working with X509Name objects in string form")]
		public string IssuerAsString
		{
			get
			{
				if (this.issuer == null)
				{
					return null;
				}
				return this.issuer.ToString();
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000A721 File Offset: 0x00008921
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0000A72E File Offset: 0x0000892E
		public bool[] KeyUsage
		{
			get
			{
				return global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.CopyBoolArray(this.keyUsage);
			}
			set
			{
				this.keyUsage = global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.CopyBoolArray(value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000A73C File Offset: 0x0000893C
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000A749 File Offset: 0x00008949
		public global::Org.BouncyCastle.Utilities.Collections.ISet Policy
		{
			get
			{
				return global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.CopySet(this.policy);
			}
			set
			{
				this.policy = global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.CopySet(value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000A757 File Offset: 0x00008957
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000A75F File Offset: 0x0000895F
		public global::Org.BouncyCastle.Utilities.Date.DateTimeObject PrivateKeyValid
		{
			get
			{
				return this.privateKeyValid;
			}
			set
			{
				this.privateKeyValid = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000A768 File Offset: 0x00008968
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x0000A770 File Offset: 0x00008970
		public global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				return this.serialNumber;
			}
			set
			{
				this.serialNumber = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000A779 File Offset: 0x00008979
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x0000A781 File Offset: 0x00008981
		public global::Org.BouncyCastle.Asn1.X509.X509Name Subject
		{
			get
			{
				return this.subject;
			}
			set
			{
				this.subject = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000A78A File Offset: 0x0000898A
		[global::System.Obsolete("Avoid working with X509Name objects in string form")]
		public string SubjectAsString
		{
			get
			{
				if (this.subject == null)
				{
					return null;
				}
				return this.subject.ToString();
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000A7A1 File Offset: 0x000089A1
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000A7AE File Offset: 0x000089AE
		public byte[] SubjectKeyIdentifier
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.subjectKeyIdentifier);
			}
			set
			{
				this.subjectKeyIdentifier = global::Org.BouncyCastle.Utilities.Arrays.Clone(value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000A7BC File Offset: 0x000089BC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000A7C4 File Offset: 0x000089C4
		public global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectPublicKey
		{
			get
			{
				return this.subjectPublicKey;
			}
			set
			{
				this.subjectPublicKey = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000A7CD File Offset: 0x000089CD
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000A7D5 File Offset: 0x000089D5
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectPublicKeyAlgID
		{
			get
			{
				return this.subjectPublicKeyAlgID;
			}
			set
			{
				this.subjectPublicKeyAlgID = value;
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A7E0 File Offset: 0x000089E0
		public virtual bool Match(object obj)
		{
			global::Org.BouncyCastle.X509.X509Certificate c = obj as global::Org.BouncyCastle.X509.X509Certificate;
			if (c == null)
			{
				return false;
			}
			if (!global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.MatchExtension(this.authorityKeyIdentifier, c, global::Org.BouncyCastle.Asn1.X509.X509Extensions.AuthorityKeyIdentifier))
			{
				return false;
			}
			if (this.basicConstraints != -1)
			{
				int bc = c.GetBasicConstraints();
				if (this.basicConstraints == -2)
				{
					if (bc != -1)
					{
						return false;
					}
				}
				else if (bc < this.basicConstraints)
				{
					return false;
				}
			}
			if (this.certificate != null && !this.certificate.Equals(c))
			{
				return false;
			}
			if (this.certificateValid != null && !c.IsValid(this.certificateValid.Value))
			{
				return false;
			}
			if (this.extendedKeyUsage != null)
			{
				global::System.Collections.IList eku = c.GetExtendedKeyUsage();
				if (eku != null)
				{
					foreach (object obj2 in this.extendedKeyUsage)
					{
						global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj2;
						if (!eku.Contains(oid.Id))
						{
							return false;
						}
					}
				}
			}
			if (this.issuer != null && !this.issuer.Equivalent(c.IssuerDN, !this.ignoreX509NameOrdering))
			{
				return false;
			}
			if (this.keyUsage != null)
			{
				bool[] ku = c.GetKeyUsage();
				if (ku != null)
				{
					for (int i = 0; i < 9; i++)
					{
						if (this.keyUsage[i] && !ku[i])
						{
							return false;
						}
					}
				}
			}
			if (this.policy != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString extVal = c.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies);
				if (extVal == null)
				{
					return false;
				}
				global::Org.BouncyCastle.Asn1.Asn1Sequence certPolicies = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(extVal));
				if (this.policy.Count < 1 && certPolicies.Count < 1)
				{
					return false;
				}
				bool found = false;
				foreach (object obj3 in certPolicies)
				{
					global::Org.BouncyCastle.Asn1.X509.PolicyInformation pi = (global::Org.BouncyCastle.Asn1.X509.PolicyInformation)obj3;
					if (this.policy.Contains(pi.PolicyIdentifier))
					{
						found = true;
						break;
					}
				}
				if (!found)
				{
					return false;
				}
			}
			if (this.privateKeyValid != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString extVal2 = c.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.PrivateKeyUsagePeriod);
				if (extVal2 == null)
				{
					return false;
				}
				global::Org.BouncyCastle.Asn1.X509.PrivateKeyUsagePeriod instance = global::Org.BouncyCastle.Asn1.X509.PrivateKeyUsagePeriod.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(extVal2));
				global::System.DateTime dt = this.privateKeyValid.Value;
				global::System.DateTime notAfter = instance.NotAfter.ToDateTime();
				global::System.DateTime notBefore = instance.NotBefore.ToDateTime();
				if (dt.CompareTo(notAfter) > 0 || dt.CompareTo(notBefore) < 0)
				{
					return false;
				}
			}
			return (this.serialNumber == null || this.serialNumber.Equals(c.SerialNumber)) && (this.subject == null || this.subject.Equivalent(c.SubjectDN, !this.ignoreX509NameOrdering)) && global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.MatchExtension(this.subjectKeyIdentifier, c, global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectKeyIdentifier) && (this.subjectPublicKey == null || this.subjectPublicKey.Equals(global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.GetSubjectPublicKey(c))) && (this.subjectPublicKeyAlgID == null || this.subjectPublicKeyAlgID.Equals(global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.GetSubjectPublicKey(c).AlgorithmID));
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000AAEC File Offset: 0x00008CEC
		internal static bool IssuersMatch(global::Org.BouncyCastle.Asn1.X509.X509Name a, global::Org.BouncyCastle.Asn1.X509.X509Name b)
		{
			if (a != null)
			{
				return a.Equivalent(b, true);
			}
			return b == null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000AAFE File Offset: 0x00008CFE
		private static bool[] CopyBoolArray(bool[] b)
		{
			if (b != null)
			{
				return (bool[])b.Clone();
			}
			return null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000AB10 File Offset: 0x00008D10
		private static global::Org.BouncyCastle.Utilities.Collections.ISet CopySet(global::Org.BouncyCastle.Utilities.Collections.ISet s)
		{
			if (s != null)
			{
				return new global::Org.BouncyCastle.Utilities.Collections.HashSet(s);
			}
			return null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000AB1D File Offset: 0x00008D1D
		private static global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo GetSubjectPublicKey(global::Org.BouncyCastle.X509.X509Certificate c)
		{
			return global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(c.GetPublicKey());
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000AB2C File Offset: 0x00008D2C
		private static bool MatchExtension(byte[] b, global::Org.BouncyCastle.X509.X509Certificate c, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			if (b == null)
			{
				return true;
			}
			global::Org.BouncyCastle.Asn1.Asn1OctetString extVal = c.GetExtensionValue(oid);
			return extVal != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(b, extVal.GetOctets());
		}

		// Token: 0x040000CF RID: 207
		private byte[] authorityKeyIdentifier;

		// Token: 0x040000D0 RID: 208
		private int basicConstraints = -1;

		// Token: 0x040000D1 RID: 209
		private global::Org.BouncyCastle.X509.X509Certificate certificate;

		// Token: 0x040000D2 RID: 210
		private global::Org.BouncyCastle.Utilities.Date.DateTimeObject certificateValid;

		// Token: 0x040000D3 RID: 211
		private global::Org.BouncyCastle.Utilities.Collections.ISet extendedKeyUsage;

		// Token: 0x040000D4 RID: 212
		private bool ignoreX509NameOrdering;

		// Token: 0x040000D5 RID: 213
		private global::Org.BouncyCastle.Asn1.X509.X509Name issuer;

		// Token: 0x040000D6 RID: 214
		private bool[] keyUsage;

		// Token: 0x040000D7 RID: 215
		private global::Org.BouncyCastle.Utilities.Collections.ISet policy;

		// Token: 0x040000D8 RID: 216
		private global::Org.BouncyCastle.Utilities.Date.DateTimeObject privateKeyValid;

		// Token: 0x040000D9 RID: 217
		private global::Org.BouncyCastle.Math.BigInteger serialNumber;

		// Token: 0x040000DA RID: 218
		private global::Org.BouncyCastle.Asn1.X509.X509Name subject;

		// Token: 0x040000DB RID: 219
		private byte[] subjectKeyIdentifier;

		// Token: 0x040000DC RID: 220
		private global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPublicKey;

		// Token: 0x040000DD RID: 221
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier subjectPublicKeyAlgID;
	}
}
