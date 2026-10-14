using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace NPOI.POIFS.Crypt.Dsig.Facets
{
	// Token: 0x02000110 RID: 272
	public abstract class SignatureFacet : global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable
	{
		// Token: 0x06000F8D RID: 3981 RVA: 0x00036BD1 File Offset: 0x00034DD1
		public void SetSignatureConfig(global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig)
		{
			this.signatureConfig = signatureConfig;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000029BF File Offset: 0x00000BBF
		public virtual void preSign(global::System.Xml.XmlDocument document, global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Reference> references, global::System.Collections.Generic.List<global::System.Xml.XmlNode> objects)
		{
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000029BF File Offset: 0x00000BBF
		public virtual void postSign(global::System.Xml.XmlDocument document)
		{
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000065E4 File Offset: 0x000047E4
		protected global::System.Security.Cryptography.Xml.Transform newTransform(string canonicalizationMethod)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00036BDA File Offset: 0x00034DDA
		protected global::System.Security.Cryptography.Xml.Reference newReference(string uri, global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Transform> transforms, string type, string id, byte[] digestValue)
		{
			return global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet.newReference(uri, transforms, type, id, digestValue, this.signatureConfig);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000065E4 File Offset: 0x000047E4
		public static global::System.Security.Cryptography.Xml.Reference newReference(string uri, global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Transform> transforms, string type, string id, byte[] digestValue, global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000065E4 File Offset: 0x000047E4
		public static void brokenJvmWorkaround(global::System.Security.Cryptography.Xml.Reference reference)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040004C2 RID: 1218
		public static string XML_NS = "http://www.w3.org/2000/xmlns/";

		// Token: 0x040004C3 RID: 1219
		public static string XML_DIGSIG_NS = "http://www.w3.org/2000/09/xmldsig#";

		// Token: 0x040004C4 RID: 1220
		public static string OO_DIGSIG_NS = "http://schemas.openxmlformats.org/package/2006/digital-signature";

		// Token: 0x040004C5 RID: 1221
		public static string MS_DIGSIG_NS = "http://schemas.microsoft.com/office/2006/digsig";

		// Token: 0x040004C6 RID: 1222
		public static string XADES_132_NS = "http://uri.etsi.org/01903/v1.3.2#";

		// Token: 0x040004C7 RID: 1223
		public static string XADES_141_NS = "http://uri.etsi.org/01903/v1.4.1#";

		// Token: 0x040004C8 RID: 1224
		protected global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig;
	}
}
