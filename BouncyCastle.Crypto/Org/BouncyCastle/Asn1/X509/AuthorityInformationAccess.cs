using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000645 RID: 1605
	public class AuthorityInformationAccess : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B6F RID: 15215 RVA: 0x001119C5 File Offset: 0x0010FBC5
		private static global::Org.BouncyCastle.Asn1.X509.AccessDescription[] Copy(global::Org.BouncyCastle.Asn1.X509.AccessDescription[] descriptions)
		{
			return (global::Org.BouncyCastle.Asn1.X509.AccessDescription[])descriptions.Clone();
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x001119D2 File Offset: 0x0010FBD2
		public static global::Org.BouncyCastle.Asn1.X509.AuthorityInformationAccess GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.AuthorityInformationAccess)
			{
				return (global::Org.BouncyCastle.Asn1.X509.AuthorityInformationAccess)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.AuthorityInformationAccess(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x001119F3 File Offset: 0x0010FBF3
		public static global::Org.BouncyCastle.Asn1.X509.AuthorityInformationAccess FromExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			return global::Org.BouncyCastle.Asn1.X509.AuthorityInformationAccess.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetExtensionParsedValue(extensions, global::Org.BouncyCastle.Asn1.X509.X509Extensions.AuthorityInfoAccess));
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00111A08 File Offset: 0x0010FC08
		private AuthorityInformationAccess(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1)
			{
				throw new global::System.ArgumentException("sequence may not be empty");
			}
			this.descriptions = new global::Org.BouncyCastle.Asn1.X509.AccessDescription[seq.Count];
			for (int i = 0; i < seq.Count; i++)
			{
				this.descriptions[i] = global::Org.BouncyCastle.Asn1.X509.AccessDescription.GetInstance(seq[i]);
			}
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x00111A65 File Offset: 0x0010FC65
		public AuthorityInformationAccess(global::Org.BouncyCastle.Asn1.X509.AccessDescription description)
		{
			this.descriptions = new global::Org.BouncyCastle.Asn1.X509.AccessDescription[]
			{
				description
			};
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00111A7D File Offset: 0x0010FC7D
		public AuthorityInformationAccess(global::Org.BouncyCastle.Asn1.X509.AccessDescription[] descriptions)
		{
			this.descriptions = global::Org.BouncyCastle.Asn1.X509.AuthorityInformationAccess.Copy(descriptions);
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00111A91 File Offset: 0x0010FC91
		public AuthorityInformationAccess(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.X509.GeneralName location) : this(new global::Org.BouncyCastle.Asn1.X509.AccessDescription(oid, location))
		{
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00111AA0 File Offset: 0x0010FCA0
		public global::Org.BouncyCastle.Asn1.X509.AccessDescription[] GetAccessDescriptions()
		{
			return global::Org.BouncyCastle.Asn1.X509.AuthorityInformationAccess.Copy(this.descriptions);
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00111AB0 File Offset: 0x0010FCB0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = this.descriptions;
			return new global::Org.BouncyCastle.Asn1.DerSequence(elements);
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00111ACC File Offset: 0x0010FCCC
		public override string ToString()
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			string sep = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			buf.Append("AuthorityInformationAccess:");
			buf.Append(sep);
			foreach (global::Org.BouncyCastle.Asn1.X509.AccessDescription description in this.descriptions)
			{
				buf.Append("    ");
				buf.Append(description);
				buf.Append(sep);
			}
			return buf.ToString();
		}

		// Token: 0x04001A37 RID: 6711
		private readonly global::Org.BouncyCastle.Asn1.X509.AccessDescription[] descriptions;
	}
}
