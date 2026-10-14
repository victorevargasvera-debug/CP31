using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace NPOI.POIFS.Crypt.Dsig.Facets
{
	// Token: 0x02000111 RID: 273
	public class XAdESSignatureFacet : global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x000065E4 File Offset: 0x000047E4
		public new void preSign(global::System.Xml.XmlDocument document, global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Reference> references, global::System.Collections.Generic.List<global::System.Xml.XmlNode> objects)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00036C2C File Offset: 0x00034E2C
		public void AddMimeType(string dsReferenceUri, string mimetype)
		{
			this.dataObjectFormatMimeTypes.Add(dsReferenceUri, mimetype);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000065E4 File Offset: 0x000047E4
		protected static void insertXChild(global::System.Xml.XmlNode root, global::System.Xml.XmlNode child)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040004C9 RID: 1225
		private static string XADES_TYPE = "http://uri.etsi.org/01903#SignedProperties";

		// Token: 0x040004CA RID: 1226
		private global::System.Collections.Generic.Dictionary<string, string> dataObjectFormatMimeTypes = new global::System.Collections.Generic.Dictionary<string, string>();
	}
}
