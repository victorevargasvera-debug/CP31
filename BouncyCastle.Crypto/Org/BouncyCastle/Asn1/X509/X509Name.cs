using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000680 RID: 1664
	public class X509Name : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06003D6A RID: 15722 RVA: 0x001179F1 File Offset: 0x00115BF1
		// (set) Token: 0x06003D6B RID: 15723 RVA: 0x001179FA File Offset: 0x00115BFA
		public static bool DefaultReverse
		{
			get
			{
				return global::Org.BouncyCastle.Asn1.X509.X509Name.defaultReverse[0];
			}
			set
			{
				global::Org.BouncyCastle.Asn1.X509.X509Name.defaultReverse[0] = value;
			}
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00117A04 File Offset: 0x00115C04
		static X509Name()
		{
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.C, "C");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.O, "O");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.T, "T");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.OU, "OU");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.CN, "CN");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.L, "L");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.ST, "ST");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.SerialNumber, "SERIALNUMBER");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.EmailAddress, "E");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.DC, "DC");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.UID, "UID");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.Street, "STREET");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.Surname, "SURNAME");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.GivenName, "GIVENNAME");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.Initials, "INITIALS");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.Generation, "GENERATION");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.UnstructuredAddress, "unstructuredAddress");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.UnstructuredName, "unstructuredName");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.UniqueIdentifier, "UniqueIdentifier");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.DnQualifier, "DN");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.Pseudonym, "Pseudonym");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.PostalAddress, "PostalAddress");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.NameAtBirth, "NameAtBirth");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.CountryOfCitizenship, "CountryOfCitizenship");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.CountryOfResidence, "CountryOfResidence");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.Gender, "Gender");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.PlaceOfBirth, "PlaceOfBirth");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.DateOfBirth, "DateOfBirth");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.PostalCode, "PostalCode");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.BusinessCategory, "BusinessCategory");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.TelephoneNumber, "TelephoneNumber");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.C, "C");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.O, "O");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.OU, "OU");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.CN, "CN");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.L, "L");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.ST, "ST");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.Street, "STREET");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.DC, "DC");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC2253Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.UID, "UID");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC1779Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.C, "C");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC1779Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.O, "O");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC1779Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.OU, "OU");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC1779Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.CN, "CN");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC1779Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.L, "L");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC1779Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.ST, "ST");
			global::Org.BouncyCastle.Asn1.X509.X509Name.RFC1779Symbols.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.Street, "STREET");
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("c", global::Org.BouncyCastle.Asn1.X509.X509Name.C);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("o", global::Org.BouncyCastle.Asn1.X509.X509Name.O);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("t", global::Org.BouncyCastle.Asn1.X509.X509Name.T);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("ou", global::Org.BouncyCastle.Asn1.X509.X509Name.OU);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("cn", global::Org.BouncyCastle.Asn1.X509.X509Name.CN);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("l", global::Org.BouncyCastle.Asn1.X509.X509Name.L);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("st", global::Org.BouncyCastle.Asn1.X509.X509Name.ST);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("serialnumber", global::Org.BouncyCastle.Asn1.X509.X509Name.SerialNumber);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("street", global::Org.BouncyCastle.Asn1.X509.X509Name.Street);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("emailaddress", global::Org.BouncyCastle.Asn1.X509.X509Name.E);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("dc", global::Org.BouncyCastle.Asn1.X509.X509Name.DC);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("e", global::Org.BouncyCastle.Asn1.X509.X509Name.E);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("uid", global::Org.BouncyCastle.Asn1.X509.X509Name.UID);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("surname", global::Org.BouncyCastle.Asn1.X509.X509Name.Surname);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("givenname", global::Org.BouncyCastle.Asn1.X509.X509Name.GivenName);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("initials", global::Org.BouncyCastle.Asn1.X509.X509Name.Initials);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("generation", global::Org.BouncyCastle.Asn1.X509.X509Name.Generation);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("unstructuredaddress", global::Org.BouncyCastle.Asn1.X509.X509Name.UnstructuredAddress);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("unstructuredname", global::Org.BouncyCastle.Asn1.X509.X509Name.UnstructuredName);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("uniqueidentifier", global::Org.BouncyCastle.Asn1.X509.X509Name.UniqueIdentifier);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("dn", global::Org.BouncyCastle.Asn1.X509.X509Name.DnQualifier);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("pseudonym", global::Org.BouncyCastle.Asn1.X509.X509Name.Pseudonym);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("postaladdress", global::Org.BouncyCastle.Asn1.X509.X509Name.PostalAddress);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("nameofbirth", global::Org.BouncyCastle.Asn1.X509.X509Name.NameAtBirth);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("countryofcitizenship", global::Org.BouncyCastle.Asn1.X509.X509Name.CountryOfCitizenship);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("countryofresidence", global::Org.BouncyCastle.Asn1.X509.X509Name.CountryOfResidence);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("gender", global::Org.BouncyCastle.Asn1.X509.X509Name.Gender);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("placeofbirth", global::Org.BouncyCastle.Asn1.X509.X509Name.PlaceOfBirth);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("dateofbirth", global::Org.BouncyCastle.Asn1.X509.X509Name.DateOfBirth);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("postalcode", global::Org.BouncyCastle.Asn1.X509.X509Name.PostalCode);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("businesscategory", global::Org.BouncyCastle.Asn1.X509.X509Name.BusinessCategory);
			global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup.Add("telephonenumber", global::Org.BouncyCastle.Asn1.X509.X509Name.TelephoneNumber);
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x0011825A File Offset: 0x0011645A
		public static global::Org.BouncyCastle.Asn1.X509.X509Name GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00118268 File Offset: 0x00116468
		public static global::Org.BouncyCastle.Asn1.X509.X509Name GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.X509Name)
			{
				return (global::Org.BouncyCastle.Asn1.X509.X509Name)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.X509Name(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00118289 File Offset: 0x00116489
		protected X509Name()
		{
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x001182B4 File Offset: 0x001164B4
		protected X509Name(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.seq = seq;
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1Set asn1Set = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
				for (int i = 0; i < asn1Set.Count; i++)
				{
					global::Org.BouncyCastle.Asn1.Asn1Sequence s = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(asn1Set[i].ToAsn1Object());
					if (s.Count != 2)
					{
						throw new global::System.ArgumentException("badly sized pair");
					}
					this.ordering.Add(global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(s[0].ToAsn1Object()));
					global::Org.BouncyCastle.Asn1.Asn1Object derValue = s[1].ToAsn1Object();
					if (derValue is global::Org.BouncyCastle.Asn1.IAsn1String && !(derValue is global::Org.BouncyCastle.Asn1.DerUniversalString))
					{
						string v = ((global::Org.BouncyCastle.Asn1.IAsn1String)derValue).GetString();
						if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(v, "#"))
						{
							v = "\\" + v;
						}
						this.values.Add(v);
					}
					else
					{
						this.values.Add("#" + global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(derValue.GetEncoded()));
					}
					this.added.Add(i != 0);
				}
			}
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x0011843C File Offset: 0x0011663C
		public X509Name(global::System.Collections.IList ordering, global::System.Collections.IDictionary attributes) : this(ordering, attributes, new global::Org.BouncyCastle.Asn1.X509.X509DefaultEntryConverter())
		{
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x0011844C File Offset: 0x0011664C
		public X509Name(global::System.Collections.IList ordering, global::System.Collections.IDictionary attributes, global::Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter)
		{
			this.converter = converter;
			foreach (object obj in ordering)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
				object attribute = attributes[oid];
				if (attribute == null)
				{
					string str = "No attribute for object id - ";
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier = oid;
					throw new global::System.ArgumentException(str + ((derObjectIdentifier != null) ? derObjectIdentifier.ToString() : null) + " - passed to distinguished name");
				}
				this.ordering.Add(oid);
				this.added.Add(false);
				this.values.Add(attribute);
			}
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x00118520 File Offset: 0x00116720
		public X509Name(global::System.Collections.IList oids, global::System.Collections.IList values) : this(oids, values, new global::Org.BouncyCastle.Asn1.X509.X509DefaultEntryConverter())
		{
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00118530 File Offset: 0x00116730
		public X509Name(global::System.Collections.IList oids, global::System.Collections.IList values, global::Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter)
		{
			this.converter = converter;
			if (oids.Count != values.Count)
			{
				throw new global::System.ArgumentException("'oids' must be same length as 'values'.");
			}
			for (int i = 0; i < oids.Count; i++)
			{
				this.ordering.Add(oids[i]);
				this.values.Add(values[i]);
				this.added.Add(false);
			}
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x001185CD File Offset: 0x001167CD
		public X509Name(string dirName) : this(global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultReverse, global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup, dirName)
		{
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x001185E0 File Offset: 0x001167E0
		public X509Name(string dirName, global::Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter) : this(global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultReverse, global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup, dirName, converter)
		{
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x001185F4 File Offset: 0x001167F4
		public X509Name(bool reverse, string dirName) : this(reverse, global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup, dirName)
		{
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00118603 File Offset: 0x00116803
		public X509Name(bool reverse, string dirName, global::Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter) : this(reverse, global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultLookup, dirName, converter)
		{
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x00118613 File Offset: 0x00116813
		public X509Name(bool reverse, global::System.Collections.IDictionary lookUp, string dirName) : this(reverse, lookUp, dirName, new global::Org.BouncyCastle.Asn1.X509.X509DefaultEntryConverter())
		{
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x00118624 File Offset: 0x00116824
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier DecodeOid(string name, global::System.Collections.IDictionary lookUp)
		{
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(name), "OID."))
			{
				return new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(name.Substring(4));
			}
			if (name[0] >= '0' && name[0] <= '9')
			{
				return new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(name);
			}
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)lookUp[global::Org.BouncyCastle.Utilities.Platform.ToLowerInvariant(name)];
			if (derObjectIdentifier == null)
			{
				throw new global::System.ArgumentException("Unknown object id - " + name + " - passed to distinguished name");
			}
			return derObjectIdentifier;
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x00118698 File Offset: 0x00116898
		public X509Name(bool reverse, global::System.Collections.IDictionary lookUp, string dirName, global::Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter)
		{
			this.converter = converter;
			global::Org.BouncyCastle.Asn1.X509.X509NameTokenizer nTok = new global::Org.BouncyCastle.Asn1.X509.X509NameTokenizer(dirName);
			while (nTok.HasMoreTokens())
			{
				string text = nTok.NextToken();
				int index = text.IndexOf('=');
				if (index == -1)
				{
					throw new global::System.ArgumentException("badly formated directory string");
				}
				string name = text.Substring(0, index);
				string value = text.Substring(index + 1);
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = this.DecodeOid(name, lookUp);
				if (value.IndexOf('+') > 0)
				{
					global::Org.BouncyCastle.Asn1.X509.X509NameTokenizer vTok = new global::Org.BouncyCastle.Asn1.X509.X509NameTokenizer(value, '+');
					string v = vTok.NextToken();
					this.ordering.Add(oid);
					this.values.Add(v);
					this.added.Add(false);
					while (vTok.HasMoreTokens())
					{
						string text2 = vTok.NextToken();
						int ndx = text2.IndexOf('=');
						string nm = text2.Substring(0, ndx);
						string vl = text2.Substring(ndx + 1);
						this.ordering.Add(this.DecodeOid(nm, lookUp));
						this.values.Add(vl);
						this.added.Add(true);
					}
				}
				else
				{
					this.ordering.Add(oid);
					this.values.Add(value);
					this.added.Add(false);
				}
			}
			if (reverse)
			{
				global::System.Collections.IList o = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				global::System.Collections.IList v2 = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				global::System.Collections.IList a = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				int count = 1;
				for (int i = 0; i < this.ordering.Count; i++)
				{
					if (!(bool)this.added[i])
					{
						count = 0;
					}
					int index2 = count++;
					o.Insert(index2, this.ordering[i]);
					v2.Insert(index2, this.values[i]);
					a.Insert(index2, this.added[i]);
				}
				this.ordering = o;
				this.values = v2;
				this.added = a;
			}
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x001188BC File Offset: 0x00116ABC
		public global::System.Collections.IList GetOidList()
		{
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.ordering);
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x001188C9 File Offset: 0x00116AC9
		public global::System.Collections.IList GetValueList()
		{
			return this.GetValueList(null);
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x001188D4 File Offset: 0x00116AD4
		public global::System.Collections.IList GetValueList(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::System.Collections.IList v = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			for (int i = 0; i != this.values.Count; i++)
			{
				if (oid == null || oid.Equals(this.ordering[i]))
				{
					string val = (string)this.values[i];
					if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(val, "\\#"))
					{
						val = val.Substring(1);
					}
					v.Add(val);
				}
			}
			return v;
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x00118944 File Offset: 0x00116B44
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.seq == null)
			{
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector vec = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector sVec = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier lstOid = null;
				for (int i = 0; i != this.ordering.Count; i++)
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)this.ordering[i];
					string str = (string)this.values[i];
					if (lstOid != null && !(bool)this.added[i])
					{
						vec.Add(new global::Org.BouncyCastle.Asn1.DerSet(sVec));
						sVec = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
					}
					sVec.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
					{
						oid,
						this.converter.GetConvertedValue(oid, str)
					}));
					lstOid = oid;
				}
				vec.Add(new global::Org.BouncyCastle.Asn1.DerSet(sVec));
				this.seq = new global::Org.BouncyCastle.Asn1.DerSequence(vec);
			}
			return this.seq;
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00118A1C File Offset: 0x00116C1C
		public bool Equivalent(global::Org.BouncyCastle.Asn1.X509.X509Name other, bool inOrder)
		{
			if (!inOrder)
			{
				return this.Equivalent(other);
			}
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			int orderingSize = this.ordering.Count;
			if (orderingSize != other.ordering.Count)
			{
				return false;
			}
			for (int i = 0; i < orderingSize; i++)
			{
				object obj = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)this.ordering[i];
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oOid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)other.ordering[i];
				if (!obj.Equals(oOid))
				{
					return false;
				}
				string s = (string)this.values[i];
				string oVal = (string)other.values[i];
				if (!global::Org.BouncyCastle.Asn1.X509.X509Name.equivalentStrings(s, oVal))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x00118AC4 File Offset: 0x00116CC4
		public bool Equivalent(global::Org.BouncyCastle.Asn1.X509.X509Name other)
		{
			if (other == null)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			int orderingSize = this.ordering.Count;
			if (orderingSize != other.ordering.Count)
			{
				return false;
			}
			bool[] indexes = new bool[orderingSize];
			int start;
			int end;
			int delta;
			if (this.ordering[0].Equals(other.ordering[0]))
			{
				start = 0;
				end = orderingSize;
				delta = 1;
			}
			else
			{
				start = orderingSize - 1;
				end = -1;
				delta = -1;
			}
			for (int i = start; i != end; i += delta)
			{
				bool found = false;
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)this.ordering[i];
				string value = (string)this.values[i];
				for (int j = 0; j < orderingSize; j++)
				{
					if (!indexes[j])
					{
						global::Org.BouncyCastle.Asn1.DerObjectIdentifier oOid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)other.ordering[j];
						if (oid.Equals(oOid))
						{
							string oValue = (string)other.values[j];
							if (global::Org.BouncyCastle.Asn1.X509.X509Name.equivalentStrings(value, oValue))
							{
								indexes[j] = true;
								found = true;
								break;
							}
						}
					}
				}
				if (!found)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00118BD8 File Offset: 0x00116DD8
		private static bool equivalentStrings(string s1, string s2)
		{
			string v = global::Org.BouncyCastle.Asn1.X509.X509Name.canonicalize(s1);
			string v2 = global::Org.BouncyCastle.Asn1.X509.X509Name.canonicalize(s2);
			if (!v.Equals(v2))
			{
				v = global::Org.BouncyCastle.Asn1.X509.X509Name.stripInternalSpaces(v);
				v2 = global::Org.BouncyCastle.Asn1.X509.X509Name.stripInternalSpaces(v2);
				if (!v.Equals(v2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x00118C18 File Offset: 0x00116E18
		private static string canonicalize(string s)
		{
			string v = global::Org.BouncyCastle.Utilities.Platform.ToLowerInvariant(s).Trim();
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(v, "#"))
			{
				global::Org.BouncyCastle.Asn1.Asn1Object obj = global::Org.BouncyCastle.Asn1.X509.X509Name.decodeObject(v);
				if (obj is global::Org.BouncyCastle.Asn1.IAsn1String)
				{
					v = global::Org.BouncyCastle.Utilities.Platform.ToLowerInvariant(((global::Org.BouncyCastle.Asn1.IAsn1String)obj).GetString()).Trim();
				}
			}
			return v;
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x00118C64 File Offset: 0x00116E64
		private static global::Org.BouncyCastle.Asn1.Asn1Object decodeObject(string v)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object result;
			try
			{
				result = global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(v, 1, v.Length - 1));
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::System.InvalidOperationException("unknown encoding in name: " + e.Message, e);
			}
			return result;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00118CB4 File Offset: 0x00116EB4
		private static string stripInternalSpaces(string str)
		{
			global::System.Text.StringBuilder res = new global::System.Text.StringBuilder();
			if (str.Length != 0)
			{
				char c = str[0];
				res.Append(c);
				for (int i = 1; i < str.Length; i++)
				{
					char c2 = str[i];
					if (c != ' ' || c2 != ' ')
					{
						res.Append(c2);
					}
					c = c2;
				}
			}
			return res.ToString();
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x00118D14 File Offset: 0x00116F14
		private void AppendValue(global::System.Text.StringBuilder buf, global::System.Collections.IDictionary oidSymbols, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string val)
		{
			string sym = (string)oidSymbols[oid];
			if (sym != null)
			{
				buf.Append(sym);
			}
			else
			{
				buf.Append(oid.Id);
			}
			buf.Append('=');
			int index = buf.Length;
			buf.Append(val);
			int end = buf.Length;
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(val, "\\#"))
			{
				index += 2;
			}
			while (index != end)
			{
				if (buf[index] == ',' || buf[index] == '"' || buf[index] == '\\' || buf[index] == '+' || buf[index] == '=' || buf[index] == '<' || buf[index] == '>' || buf[index] == ';')
				{
					buf.Insert(index++, "\\");
					end++;
				}
				index++;
			}
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x00118DF4 File Offset: 0x00116FF4
		public string ToString(bool reverse, global::System.Collections.IDictionary oidSymbols)
		{
			global::System.Collections.ArrayList components = new global::System.Collections.ArrayList();
			global::System.Text.StringBuilder ava = null;
			for (int i = 0; i < this.ordering.Count; i++)
			{
				if ((bool)this.added[i])
				{
					ava.Append('+');
					this.AppendValue(ava, oidSymbols, (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)this.ordering[i], (string)this.values[i]);
				}
				else
				{
					ava = new global::System.Text.StringBuilder();
					this.AppendValue(ava, oidSymbols, (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)this.ordering[i], (string)this.values[i]);
					components.Add(ava);
				}
			}
			if (reverse)
			{
				components.Reverse();
			}
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			if (components.Count > 0)
			{
				buf.Append(components[0].ToString());
				for (int j = 1; j < components.Count; j++)
				{
					buf.Append(',');
					buf.Append(components[j].ToString());
				}
			}
			return buf.ToString();
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00118F08 File Offset: 0x00117108
		public override string ToString()
		{
			return this.ToString(global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultReverse, global::Org.BouncyCastle.Asn1.X509.X509Name.DefaultSymbols);
		}

		// Token: 0x04001B37 RID: 6967
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.6");

		// Token: 0x04001B38 RID: 6968
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier O = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.10");

		// Token: 0x04001B39 RID: 6969
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier OU = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.11");

		// Token: 0x04001B3A RID: 6970
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier T = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.12");

		// Token: 0x04001B3B RID: 6971
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CN = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.3");

		// Token: 0x04001B3C RID: 6972
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Street = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.9");

		// Token: 0x04001B3D RID: 6973
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SerialNumber = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.5");

		// Token: 0x04001B3E RID: 6974
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier L = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.7");

		// Token: 0x04001B3F RID: 6975
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ST = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.8");

		// Token: 0x04001B40 RID: 6976
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Surname = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.4");

		// Token: 0x04001B41 RID: 6977
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier GivenName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.42");

		// Token: 0x04001B42 RID: 6978
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Initials = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.43");

		// Token: 0x04001B43 RID: 6979
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Generation = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.44");

		// Token: 0x04001B44 RID: 6980
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier UniqueIdentifier = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.45");

		// Token: 0x04001B45 RID: 6981
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BusinessCategory = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.15");

		// Token: 0x04001B46 RID: 6982
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PostalCode = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.17");

		// Token: 0x04001B47 RID: 6983
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DnQualifier = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.46");

		// Token: 0x04001B48 RID: 6984
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Pseudonym = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.65");

		// Token: 0x04001B49 RID: 6985
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DateOfBirth = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.9.1");

		// Token: 0x04001B4A RID: 6986
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PlaceOfBirth = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.9.2");

		// Token: 0x04001B4B RID: 6987
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Gender = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.9.3");

		// Token: 0x04001B4C RID: 6988
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CountryOfCitizenship = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.9.4");

		// Token: 0x04001B4D RID: 6989
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CountryOfResidence = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.9.5");

		// Token: 0x04001B4E RID: 6990
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NameAtBirth = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.36.8.3.14");

		// Token: 0x04001B4F RID: 6991
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PostalAddress = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.16");

		// Token: 0x04001B50 RID: 6992
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DmdName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.54");

		// Token: 0x04001B51 RID: 6993
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier TelephoneNumber = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.id_at_telephoneNumber;

		// Token: 0x04001B52 RID: 6994
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier OrganizationIdentifier = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.id_at_organizationIdentifier;

		// Token: 0x04001B53 RID: 6995
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Name = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.id_at_name;

		// Token: 0x04001B54 RID: 6996
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EmailAddress = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtEmailAddress;

		// Token: 0x04001B55 RID: 6997
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier UnstructuredName = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtUnstructuredName;

		// Token: 0x04001B56 RID: 6998
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier UnstructuredAddress = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtUnstructuredAddress;

		// Token: 0x04001B57 RID: 6999
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier E = global::Org.BouncyCastle.Asn1.X509.X509Name.EmailAddress;

		// Token: 0x04001B58 RID: 7000
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DC = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("0.9.2342.19200300.100.1.25");

		// Token: 0x04001B59 RID: 7001
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier UID = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("0.9.2342.19200300.100.1.1");

		// Token: 0x04001B5A RID: 7002
		private static readonly bool[] defaultReverse = new bool[1];

		// Token: 0x04001B5B RID: 7003
		public static readonly global::System.Collections.Hashtable DefaultSymbols = new global::System.Collections.Hashtable();

		// Token: 0x04001B5C RID: 7004
		public static readonly global::System.Collections.Hashtable RFC2253Symbols = new global::System.Collections.Hashtable();

		// Token: 0x04001B5D RID: 7005
		public static readonly global::System.Collections.Hashtable RFC1779Symbols = new global::System.Collections.Hashtable();

		// Token: 0x04001B5E RID: 7006
		public static readonly global::System.Collections.Hashtable DefaultLookup = new global::System.Collections.Hashtable();

		// Token: 0x04001B5F RID: 7007
		private readonly global::System.Collections.IList ordering = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04001B60 RID: 7008
		private readonly global::Org.BouncyCastle.Asn1.X509.X509NameEntryConverter converter;

		// Token: 0x04001B61 RID: 7009
		private global::System.Collections.IList values = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04001B62 RID: 7010
		private global::System.Collections.IList added = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04001B63 RID: 7011
		private global::Org.BouncyCastle.Asn1.Asn1Sequence seq;
	}
}
