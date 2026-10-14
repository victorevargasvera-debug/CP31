using System;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200052E RID: 1326
	[global::System.Serializable]
	public class CmsException : global::System.Exception
	{
		// Token: 0x06003338 RID: 13112 RVA: 0x000F48B9 File Offset: 0x000F2AB9
		public CmsException()
		{
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x000F48C1 File Offset: 0x000F2AC1
		public CmsException(string msg) : base(msg)
		{
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x000F48CA File Offset: 0x000F2ACA
		public CmsException(string msg, global::System.Exception e) : base(msg, e)
		{
		}
	}
}
