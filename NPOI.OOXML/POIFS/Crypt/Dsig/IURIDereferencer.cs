using System;
using System.Security.Cryptography.Xml;

namespace NPOI.POIFS.Crypt.Dsig
{
	// Token: 0x020000FD RID: 253
	public interface IURIDereferencer
	{
		// Token: 0x06000F4D RID: 3917
		global::NPOI.POIFS.Crypt.Dsig.IData dereference(global::NPOI.POIFS.Crypt.Dsig.IURIReference uriReference, global::System.Security.Cryptography.Xml.SignedXml context);
	}
}
