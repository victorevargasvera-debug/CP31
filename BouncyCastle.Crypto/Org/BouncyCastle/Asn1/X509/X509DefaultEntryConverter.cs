using System;
using System.IO;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200067C RID: 1660
	public class X509DefaultEntryConverter : global::Org.BouncyCastle.Asn1.X509.X509NameEntryConverter
	{
		// Token: 0x06003D40 RID: 15680 RVA: 0x00116C60 File Offset: 0x00114E60
		public override global::Org.BouncyCastle.Asn1.Asn1Object GetConvertedValue(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, string value)
		{
			if (value.Length != 0 && value[0] == '#')
			{
				try
				{
					return base.ConvertHexEncoded(value, 1);
				}
				catch (global::System.IO.IOException)
				{
					throw new global::System.Exception("can't recode value for oid " + oid.Id);
				}
			}
			if (value.Length != 0 && value[0] == '\\')
			{
				value = value.Substring(1);
			}
			if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Name.EmailAddress) || oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Name.DC))
			{
				return new global::Org.BouncyCastle.Asn1.DerIA5String(value);
			}
			if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Name.DateOfBirth))
			{
				return new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(value);
			}
			if (oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Name.C) || oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Name.SerialNumber) || oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Name.DnQualifier) || oid.Equals(global::Org.BouncyCastle.Asn1.X509.X509Name.TelephoneNumber))
			{
				return new global::Org.BouncyCastle.Asn1.DerPrintableString(value);
			}
			return new global::Org.BouncyCastle.Asn1.DerUtf8String(value);
		}
	}
}
