using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200067E RID: 1662
	public class X509Extensions : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003D4A RID: 15690 RVA: 0x00116E50 File Offset: 0x00115050
		public static global::Org.BouncyCastle.Asn1.X509.X509Extension GetExtension(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			if (extensions != null)
			{
				return extensions.GetExtension(oid);
			}
			return null;
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x00116E5E File Offset: 0x0011505E
		public static global::Org.BouncyCastle.Asn1.Asn1Encodable GetExtensionParsedValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			if (extensions != null)
			{
				return extensions.GetExtensionParsedValue(oid);
			}
			return null;
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x00116E6C File Offset: 0x0011506C
		public static global::Org.BouncyCastle.Asn1.X509.X509Extensions GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00116E7C File Offset: 0x0011507C
		public static global::Org.BouncyCastle.Asn1.X509.X509Extensions GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.X509Extensions)
			{
				return (global::Org.BouncyCastle.Asn1.X509.X509Extensions)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.X509Extensions((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj).GetObject());
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x00116EE4 File Offset: 0x001150E4
		private X509Extensions(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.ordering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence s = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
				if (s.Count < 2 || s.Count > 3)
				{
					throw new global::System.ArgumentException("Bad sequence size: " + s.Count.ToString());
				}
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(s[0].ToAsn1Object());
				bool isCritical = s.Count == 3 && global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(s[1].ToAsn1Object()).IsTrue;
				global::Org.BouncyCastle.Asn1.Asn1OctetString octets = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(s[s.Count - 1].ToAsn1Object());
				if (this.extensions.Contains(oid))
				{
					string str = "repeated extension found: ";
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier = oid;
					throw new global::System.ArgumentException(str + ((derObjectIdentifier != null) ? derObjectIdentifier.ToString() : null));
				}
				this.extensions.Add(oid, new global::Org.BouncyCastle.Asn1.X509.X509Extension(isCritical, octets));
				this.ordering.Add(oid);
			}
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x0011702C File Offset: 0x0011522C
		public X509Extensions(global::System.Collections.IDictionary extensions) : this(null, extensions)
		{
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x00117038 File Offset: 0x00115238
		public X509Extensions(global::System.Collections.IList ordering, global::System.Collections.IDictionary extensions)
		{
			if (ordering == null)
			{
				this.ordering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(extensions.Keys);
			}
			else
			{
				this.ordering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(ordering);
			}
			foreach (object obj in this.ordering)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
				this.extensions.Add(oid, (global::Org.BouncyCastle.Asn1.X509.X509Extension)extensions[oid]);
			}
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x001170D8 File Offset: 0x001152D8
		public X509Extensions(global::System.Collections.IList oids, global::System.Collections.IList values)
		{
			this.ordering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(oids);
			int count = 0;
			foreach (object obj in this.ordering)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
				this.extensions.Add(oid, (global::Org.BouncyCastle.Asn1.X509.X509Extension)values[count++]);
			}
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x00117168 File Offset: 0x00115368
		[global::System.Obsolete]
		public X509Extensions(global::System.Collections.Hashtable extensions) : this(null, extensions)
		{
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00117174 File Offset: 0x00115374
		[global::System.Obsolete]
		public X509Extensions(global::System.Collections.ArrayList ordering, global::System.Collections.Hashtable extensions)
		{
			if (ordering == null)
			{
				this.ordering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(extensions.Keys);
			}
			else
			{
				this.ordering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(ordering);
			}
			foreach (object obj in this.ordering)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
				this.extensions.Add(oid, (global::Org.BouncyCastle.Asn1.X509.X509Extension)extensions[oid]);
			}
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00117214 File Offset: 0x00115414
		[global::System.Obsolete]
		public X509Extensions(global::System.Collections.ArrayList oids, global::System.Collections.ArrayList values)
		{
			this.ordering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(oids);
			int count = 0;
			foreach (object obj in this.ordering)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
				this.extensions.Add(oid, (global::Org.BouncyCastle.Asn1.X509.X509Extension)values[count++]);
			}
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x001172A4 File Offset: 0x001154A4
		[global::System.Obsolete("Use ExtensionOids IEnumerable property")]
		public global::System.Collections.IEnumerator Oids()
		{
			return this.ExtensionOids.GetEnumerator();
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06003D56 RID: 15702 RVA: 0x001172B1 File Offset: 0x001154B1
		public global::System.Collections.IEnumerable ExtensionOids
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.ordering);
			}
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x001172BE File Offset: 0x001154BE
		public global::Org.BouncyCastle.Asn1.X509.X509Extension GetExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (global::Org.BouncyCastle.Asn1.X509.X509Extension)this.extensions[oid];
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x001172D4 File Offset: 0x001154D4
		public global::Org.BouncyCastle.Asn1.Asn1Encodable GetExtensionParsedValue(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Extension ext = this.GetExtension(oid);
			if (ext != null)
			{
				return ext.GetParsedValue();
			}
			return null;
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x001172F4 File Offset: 0x001154F4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector vec = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this.ordering)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
				global::Org.BouncyCastle.Asn1.X509.X509Extension ext = (global::Org.BouncyCastle.Asn1.X509.X509Extension)this.extensions[oid];
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					oid
				});
				if (ext.IsCritical)
				{
					v.Add(global::Org.BouncyCastle.Asn1.DerBoolean.True);
				}
				v.Add(ext.Value);
				vec.Add(new global::Org.BouncyCastle.Asn1.DerSequence(v));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(vec);
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x001173A8 File Offset: 0x001155A8
		public bool Equivalent(global::Org.BouncyCastle.Asn1.X509.X509Extensions other)
		{
			if (this.extensions.Count != other.extensions.Count)
			{
				return false;
			}
			foreach (object obj in this.extensions.Keys)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
				if (!this.extensions[oid].Equals(other.extensions[oid]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00117440 File Offset: 0x00115640
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] GetExtensionOids()
		{
			return global::Org.BouncyCastle.Asn1.X509.X509Extensions.ToOidArray(this.ordering);
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x0011744D File Offset: 0x0011564D
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] GetNonCriticalExtensionOids()
		{
			return this.GetExtensionOids(false);
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x00117456 File Offset: 0x00115656
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] GetCriticalExtensionOids()
		{
			return this.GetExtensionOids(true);
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x00117460 File Offset: 0x00115660
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] GetExtensionOids(bool isCritical)
		{
			global::System.Collections.IList oids = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in this.ordering)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
				if (((global::Org.BouncyCastle.Asn1.X509.X509Extension)this.extensions[oid]).IsCritical == isCritical)
				{
					oids.Add(oid);
				}
			}
			return global::Org.BouncyCastle.Asn1.X509.X509Extensions.ToOidArray(oids);
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x001174E0 File Offset: 0x001156E0
		private static global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] ToOidArray(global::System.Collections.IList oids)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] oidArray = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier[oids.Count];
			oids.CopyTo(oidArray, 0);
			return oidArray;
		}

		// Token: 0x04001B12 RID: 6930
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectDirectoryAttributes = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.9");

		// Token: 0x04001B13 RID: 6931
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectKeyIdentifier = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.14");

		// Token: 0x04001B14 RID: 6932
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier KeyUsage = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.15");

		// Token: 0x04001B15 RID: 6933
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PrivateKeyUsagePeriod = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.16");

		// Token: 0x04001B16 RID: 6934
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectAlternativeName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.17");

		// Token: 0x04001B17 RID: 6935
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IssuerAlternativeName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.18");

		// Token: 0x04001B18 RID: 6936
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BasicConstraints = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.19");

		// Token: 0x04001B19 RID: 6937
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CrlNumber = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.20");

		// Token: 0x04001B1A RID: 6938
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ReasonCode = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.21");

		// Token: 0x04001B1B RID: 6939
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier InstructionCode = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.23");

		// Token: 0x04001B1C RID: 6940
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier InvalidityDate = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.24");

		// Token: 0x04001B1D RID: 6941
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DeltaCrlIndicator = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.27");

		// Token: 0x04001B1E RID: 6942
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IssuingDistributionPoint = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.28");

		// Token: 0x04001B1F RID: 6943
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CertificateIssuer = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.29");

		// Token: 0x04001B20 RID: 6944
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NameConstraints = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.30");

		// Token: 0x04001B21 RID: 6945
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CrlDistributionPoints = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.31");

		// Token: 0x04001B22 RID: 6946
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CertificatePolicies = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.32");

		// Token: 0x04001B23 RID: 6947
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyMappings = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.33");

		// Token: 0x04001B24 RID: 6948
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier AuthorityKeyIdentifier = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.35");

		// Token: 0x04001B25 RID: 6949
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PolicyConstraints = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.36");

		// Token: 0x04001B26 RID: 6950
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ExtendedKeyUsage = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.37");

		// Token: 0x04001B27 RID: 6951
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier FreshestCrl = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.46");

		// Token: 0x04001B28 RID: 6952
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier InhibitAnyPolicy = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.54");

		// Token: 0x04001B29 RID: 6953
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier AuthorityInfoAccess = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.1.1");

		// Token: 0x04001B2A RID: 6954
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SubjectInfoAccess = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.1.11");

		// Token: 0x04001B2B RID: 6955
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier LogoType = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.1.12");

		// Token: 0x04001B2C RID: 6956
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BiometricInfo = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.1.2");

		// Token: 0x04001B2D RID: 6957
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier QCStatements = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.1.3");

		// Token: 0x04001B2E RID: 6958
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier AuditIdentity = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.1.4");

		// Token: 0x04001B2F RID: 6959
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NoRevAvail = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.56");

		// Token: 0x04001B30 RID: 6960
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier TargetInformation = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.55");

		// Token: 0x04001B31 RID: 6961
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ExpiredCertsOnCrl = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.29.60");

		// Token: 0x04001B32 RID: 6962
		private readonly global::System.Collections.IDictionary extensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001B33 RID: 6963
		private readonly global::System.Collections.IList ordering;
	}
}
