using System;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509
{
	// Token: 0x020006E6 RID: 1766
	public class AdditionalInformationSyntax : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004019 RID: 16409 RVA: 0x00122E99 File Offset: 0x00121099
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.AdditionalInformationSyntax GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.IsisMtt.X509.AdditionalInformationSyntax)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.AdditionalInformationSyntax)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.IAsn1String)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.X509.AdditionalInformationSyntax(global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(obj));
			}
			throw new global::System.ArgumentException("Unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x00122ED8 File Offset: 0x001210D8
		private AdditionalInformationSyntax(global::Org.BouncyCastle.Asn1.X500.DirectoryString information)
		{
			this.information = information;
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x00122EE7 File Offset: 0x001210E7
		public AdditionalInformationSyntax(string information)
		{
			this.information = new global::Org.BouncyCastle.Asn1.X500.DirectoryString(information);
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x00122EFB File Offset: 0x001210FB
		public virtual global::Org.BouncyCastle.Asn1.X500.DirectoryString Information
		{
			get
			{
				return this.information;
			}
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x00122F03 File Offset: 0x00121103
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.information.ToAsn1Object();
		}

		// Token: 0x04001E59 RID: 7769
		private readonly global::Org.BouncyCastle.Asn1.X500.DirectoryString information;
	}
}
