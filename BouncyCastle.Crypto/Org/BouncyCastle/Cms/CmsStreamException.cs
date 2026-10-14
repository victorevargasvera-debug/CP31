using System;
using System.IO;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200053E RID: 1342
	[global::System.Serializable]
	public class CmsStreamException : global::System.IO.IOException
	{
		// Token: 0x060033E7 RID: 13287 RVA: 0x000F8940 File Offset: 0x000F6B40
		public CmsStreamException()
		{
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x000F8948 File Offset: 0x000F6B48
		public CmsStreamException(string name) : base(name)
		{
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x000F8951 File Offset: 0x000F6B51
		public CmsStreamException(string name, global::System.Exception e) : base(name, e)
		{
		}
	}
}
