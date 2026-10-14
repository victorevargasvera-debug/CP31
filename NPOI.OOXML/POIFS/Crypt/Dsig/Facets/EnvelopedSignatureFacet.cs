using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Xml;

namespace NPOI.POIFS.Crypt.Dsig.Facets
{
	// Token: 0x0200010C RID: 268
	public class EnvelopedSignatureFacet : global::NPOI.POIFS.Crypt.Dsig.Facets.SignatureFacet
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x000065E4 File Offset: 0x000047E4
		public override void preSign(global::System.Xml.XmlDocument document, global::System.Collections.Generic.List<global::System.Security.Cryptography.Xml.Reference> references, global::System.Collections.Generic.List<global::System.Xml.XmlNode> objects)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
