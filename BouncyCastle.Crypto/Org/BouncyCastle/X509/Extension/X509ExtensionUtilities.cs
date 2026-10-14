using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509.Extension
{
	// Token: 0x02000031 RID: 49
	public class X509ExtensionUtilities
	{
		// Token: 0x06000220 RID: 544 RVA: 0x0000B2FE File Offset: 0x000094FE
		public static global::Org.BouncyCastle.Asn1.Asn1Object FromExtensionValue(global::Org.BouncyCastle.Asn1.Asn1OctetString extensionValue)
		{
			return global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(extensionValue.GetOctets());
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B30B File Offset: 0x0000950B
		public static global::System.Collections.ICollection GetIssuerAlternativeNames(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			return global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.GetAlternativeName(cert.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuerAlternativeName));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000B31D File Offset: 0x0000951D
		public static global::System.Collections.ICollection GetSubjectAlternativeNames(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			return global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.GetAlternativeName(cert.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectAlternativeName));
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000B330 File Offset: 0x00009530
		private static global::System.Collections.ICollection GetAlternativeName(global::Org.BouncyCastle.Asn1.Asn1OctetString extVal)
		{
			global::System.Collections.IList temp = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (extVal != null)
			{
				try
				{
					foreach (object obj in global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(extVal)))
					{
						object obj2 = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
						global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
						global::Org.BouncyCastle.Asn1.X509.GeneralName genName = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(obj2);
						list.Add(genName.TagNo);
						switch (genName.TagNo)
						{
						case 0:
						case 3:
						case 5:
							list.Add(genName.Name.ToAsn1Object());
							break;
						case 1:
						case 2:
						case 6:
							list.Add(((global::Org.BouncyCastle.Asn1.IAsn1String)genName.Name).GetString());
							break;
						case 4:
							list.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(genName.Name).ToString());
							break;
						case 7:
							list.Add(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(genName.Name).GetOctets());
							break;
						case 8:
							list.Add(global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(genName.Name).Id);
							break;
						default:
							throw new global::System.IO.IOException("Bad tag number: " + genName.TagNo.ToString());
						}
						temp.Add(list);
					}
				}
				catch (global::System.Exception ex)
				{
					throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException(ex.Message);
				}
			}
			return temp;
		}
	}
}
