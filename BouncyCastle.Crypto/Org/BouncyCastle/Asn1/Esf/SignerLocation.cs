using System;
using Org.BouncyCastle.Asn1.X500;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x0200071A RID: 1818
	public class SignerLocation : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600416F RID: 16751 RVA: 0x001282F8 File Offset: 0x001264F8
		public SignerLocation(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			foreach (object obj2 in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj2;
				switch (obj.TagNo)
				{
				case 0:
					this.countryName = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(obj, true);
					break;
				case 1:
					this.localityName = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(obj, true);
					break;
				case 2:
				{
					bool isExplicit = obj.IsExplicit();
					this.postalAddress = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit);
					if (this.postalAddress != null && this.postalAddress.Count > 6)
					{
						throw new global::System.ArgumentException("postal address must contain less than 6 strings");
					}
					break;
				}
				default:
					throw new global::System.ArgumentException("illegal tag");
				}
			}
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x001283D0 File Offset: 0x001265D0
		private SignerLocation(global::Org.BouncyCastle.Asn1.X500.DirectoryString countryName, global::Org.BouncyCastle.Asn1.X500.DirectoryString localityName, global::Org.BouncyCastle.Asn1.Asn1Sequence postalAddress)
		{
			if (postalAddress != null && postalAddress.Count > 6)
			{
				throw new global::System.ArgumentException("postal address must contain less than 6 strings");
			}
			this.countryName = countryName;
			this.localityName = localityName;
			this.postalAddress = postalAddress;
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x00128404 File Offset: 0x00126604
		public SignerLocation(global::Org.BouncyCastle.Asn1.X500.DirectoryString countryName, global::Org.BouncyCastle.Asn1.X500.DirectoryString localityName, global::Org.BouncyCastle.Asn1.X500.DirectoryString[] postalAddress) : this(countryName, localityName, new global::Org.BouncyCastle.Asn1.DerSequence(postalAddress))
		{
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00128421 File Offset: 0x00126621
		public SignerLocation(global::Org.BouncyCastle.Asn1.DerUtf8String countryName, global::Org.BouncyCastle.Asn1.DerUtf8String localityName, global::Org.BouncyCastle.Asn1.Asn1Sequence postalAddress) : this(global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(countryName), global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(localityName), postalAddress)
		{
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x00128436 File Offset: 0x00126636
		public static global::Org.BouncyCastle.Asn1.Esf.SignerLocation GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.SignerLocation)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.SignerLocation)obj;
			}
			return new global::Org.BouncyCastle.Asn1.Esf.SignerLocation(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06004174 RID: 16756 RVA: 0x00128455 File Offset: 0x00126655
		public global::Org.BouncyCastle.Asn1.X500.DirectoryString Country
		{
			get
			{
				return this.countryName;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x0012845D File Offset: 0x0012665D
		public global::Org.BouncyCastle.Asn1.X500.DirectoryString Locality
		{
			get
			{
				return this.localityName;
			}
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00128468 File Offset: 0x00126668
		public global::Org.BouncyCastle.Asn1.X500.DirectoryString[] GetPostal()
		{
			if (this.postalAddress == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.X500.DirectoryString[] dirStrings = new global::Org.BouncyCastle.Asn1.X500.DirectoryString[this.postalAddress.Count];
			for (int i = 0; i != dirStrings.Length; i++)
			{
				dirStrings[i] = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(this.postalAddress[i]);
			}
			return dirStrings;
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06004177 RID: 16759 RVA: 0x001284B3 File Offset: 0x001266B3
		[global::System.Obsolete("Use 'Country' property instead")]
		public global::Org.BouncyCastle.Asn1.DerUtf8String CountryName
		{
			get
			{
				if (this.countryName != null)
				{
					return new global::Org.BouncyCastle.Asn1.DerUtf8String(this.countryName.GetString());
				}
				return null;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06004178 RID: 16760 RVA: 0x001284CF File Offset: 0x001266CF
		[global::System.Obsolete("Use 'Locality' property instead")]
		public global::Org.BouncyCastle.Asn1.DerUtf8String LocalityName
		{
			get
			{
				if (this.localityName != null)
				{
					return new global::Org.BouncyCastle.Asn1.DerUtf8String(this.localityName.GetString());
				}
				return null;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06004179 RID: 16761 RVA: 0x001284EB File Offset: 0x001266EB
		public global::Org.BouncyCastle.Asn1.Asn1Sequence PostalAddress
		{
			get
			{
				return this.postalAddress;
			}
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x001284F3 File Offset: 0x001266F3
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 0, this.countryName);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.localityName);
			asn1EncodableVector.AddOptionalTagged(true, 2, this.postalAddress);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001F4F RID: 8015
		private global::Org.BouncyCastle.Asn1.X500.DirectoryString countryName;

		// Token: 0x04001F50 RID: 8016
		private global::Org.BouncyCastle.Asn1.X500.DirectoryString localityName;

		// Token: 0x04001F51 RID: 8017
		private global::Org.BouncyCastle.Asn1.Asn1Sequence postalAddress;
	}
}
